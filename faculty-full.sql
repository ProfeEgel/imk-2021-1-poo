
-- ********************************************************************
-- ******                     TABLES DESIGN                      ******
-- ********************************************************************

DROP TABLE IF EXISTS [students];
DROP TABLE IF EXISTS [course_subjects];
DROP TABLE IF EXISTS [subjects];
DROP TABLE IF EXISTS [professors];
DROP TABLE IF EXISTS [professor_categories];
DROP TABLE IF EXISTS [courses];
DROP TABLE IF EXISTS [course_levels];


CREATE TABLE [course_levels](
    [id] INTEGER PRIMARY KEY, 
    [description] TEXT NOT NULL UNIQUE,
    [payment_pct] INTEGER NOT NULL, 
    [required_credits] INTEGER NOT NULL,
    CHECK([payment_pct] > 0),
    CHECK([required_credits] > 0));

CREATE TABLE [courses](
    [id] INTEGER PRIMARY KEY, 
    [level_id] INTEGER NOT NULL REFERENCES course_levels([id]), 
    [active] INTEGER NOT NULL, 
    [description] TEXT NOT NULL UNIQUE, 
    UNIQUE([id], [level_id]));

CREATE TABLE [professor_categories](
    [id] INTEGER PRIMARY KEY, 
    [description] TEXT NOT NULL UNIQUE, 
    [payment] INTEGER NOT NULL, 
    CHECK([payment] >= 0));

CREATE TABLE [professors](
    [id] INTEGER PRIMARY KEY, 
    [fname] TEXT NOT NULL, 
    [lname] TEXT NOT NULL, 
    [category_id] INTEGER NOT NULL REFERENCES professor_categories([id]));

CREATE TABLE [subjects](
    [id] TEXT PRIMARY KEY, 
    [name] TEXT NOT NULL, 
    [level_id] INTEGER NOT NULL REFERENCES course_levels([id]), 
    [credits] INTEGER NOT NULL, 
    CHECK([credits] >= 0), 
    UNIQUE([id], [level_id]));

CREATE TABLE [course_subjects](
    [course_id] INTEGER NOT NULL, 
    [level_id] INTEGER NOT NULL,
    [subject_id] TEXT NOT NULL, 
    [professor_id] INTEGER NOT NULL REFERENCES professors([id]), 
    FOREIGN KEY([course_id], [level_id]) REFERENCES courses([id], [level_id]), 
    FOREIGN KEY([subject_id], [level_id]) REFERENCES subjects([id], [level_id]), 
    UNIQUE([course_id], [subject_id]));

CREATE TABLE [students](
    [id] INTEGER PRIMARY KEY, 
    [first_name] TEXT NOT NULL, 
    [last_name] TEXT NOT NULL, 
    [birthdate] TEXT, 
    [course_id] INTEGER REFERENCES courses([id]));


-- ********************************************************************
-- ******                       TEST DATA                        ******
-- ********************************************************************

INSERT INTO course_levels (id, description, payment_pct, required_credits) VALUES (0, 'Licenciatura', 100, 120);
INSERT INTO course_levels (id, description, payment_pct, required_credits) VALUES (1, 'Maestría', 150, 70);
INSERT INTO course_levels (id, description, payment_pct, required_credits) VALUES (2, 'Doctorado', 175, 45);
INSERT INTO course_levels (id, description, payment_pct, required_credits) VALUES (3, 'Diplomado', 100, 25);
INSERT INTO course_levels (id, description, payment_pct, required_credits) VALUES (4, 'Especialidad', 125, 40);


INSERT INTO courses (id, level_id, active, description) VALUES (0, 0, 1, 'Ingeniería Mecatrónica');
INSERT INTO courses (id, level_id, active, description) VALUES (1, 0, 1, 'Ingeniería Física');
INSERT INTO courses (id, level_id, active, description) VALUES (2, 0, 0, 'Ingeniería Química');
INSERT INTO courses (id, level_id, active, description) VALUES (3, 0, 1, 'Ingeniería Electrónica');
INSERT INTO courses (id, level_id, active, description) VALUES (4, 0, 1, 'Ingeniería Mecánica');
INSERT INTO courses (id, level_id, active, description) VALUES (5, 0, 1, 'Ingeniería Civil');
INSERT INTO courses (id, level_id, active, description) VALUES (6, 0, 0, 'Ingeniería Ambiental');
INSERT INTO courses (id, level_id, active, description) VALUES (7, 0, 0, 'Ingeniería en Sistemas Computacionales');
INSERT INTO courses (id, level_id, active, description) VALUES (8, 0, 1, 'Ingeniería en Desarrollo de Software');
INSERT INTO courses (id, level_id, active, description) VALUES (9, 1, 0, 'Maestría en Ingeniería Ambiental');
INSERT INTO courses (id, level_id, active, description) VALUES (10, 1, 0, 'Maestría en Ingeniería de Software');
INSERT INTO courses (id, level_id, active, description) VALUES (11, 1, 1, 'Maestría en Ciencias en Electrónica');
INSERT INTO courses (id, level_id, active, description) VALUES (12, 1, 1, 'Maestría en Ciencias en Sistemas Computacionales');
INSERT INTO courses (id, level_id, active, description) VALUES (13, 2, 1, 'Doctorado en Ingeniería en Energías Renovables');
INSERT INTO courses (id, level_id, active, description) VALUES (14, 2, 1, 'Doctorado en Ingeniería Mecatrónica');
INSERT INTO courses (id, level_id, active, description) VALUES (15, 2, 0, 'Doctorado en Ciencias en Electrónica');
INSERT INTO courses (id, level_id, active, description) VALUES (16, 3, 0, 'Diplomado en Enseñanza de las Matemáticas');
INSERT INTO courses (id, level_id, active, description) VALUES (17, 4, 1, 'Especialidad en Estadística');


INSERT INTO professor_categories (id, description, payment) VALUES (0, 'Por horas A', 70);
INSERT INTO professor_categories (id, description, payment) VALUES (1, 'Por horas B', 80);
INSERT INTO professor_categories (id, description, payment) VALUES (2, 'De carrera A', 80);
INSERT INTO professor_categories (id, description, payment) VALUES (3, 'De carrera B', 90);
INSERT INTO professor_categories (id, description, payment) VALUES (4, 'De carrera C', 100);
INSERT INTO professor_categories (id, description, payment) VALUES (5, 'De carrera D', 120);
INSERT INTO professor_categories (id, description, payment) VALUES (6, 'Investigador A', 100);
INSERT INTO professor_categories (id, description, payment) VALUES (7, 'Investigador B', 140);
INSERT INTO professor_categories (id, description, payment) VALUES (8, 'Investigador C', 180);


-- BAS
INSERT INTO professors (id, fname, lname, category_id) VALUES (1262, 'Ramón', 'Suárez', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (8245, 'Pedro', 'Palma', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1941, 'Alejandro', 'Lemus', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2835, 'Alexia', 'Morales', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (5625, 'Rodrigo', 'Burgos', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9156, 'Arturo', 'Cambranis', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9831, 'Roxana', 'Rodríguez', 3);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9724, 'Laura', 'Teherán', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1724, 'Mateo', 'Canché', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2895, 'Javier', 'Meléndez', 1);
-- CAD
INSERT INTO professors (id, fname, lname, category_id) VALUES (2674, 'Israel', 'Sulub', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (4892, 'Edwin', 'Pérez', 8);
INSERT INTO professors (id, fname, lname, category_id) VALUES (3279, 'Ramiro', 'Soberanis', 8);
-- ELE
INSERT INTO professors (id, fname, lname, category_id) VALUES (8436, 'Ileana', 'López', 3);
INSERT INTO professors (id, fname, lname, category_id) VALUES (8356, 'José', 'Sosa', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (8427, 'Jesús', 'Monforte', 8);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6289, 'Lucía', 'Moreno', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7423, 'Rocío', 'Molina', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (3878, 'Pablo', 'Macías', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1789, 'Margarita', 'Poumián', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6773, 'Erika', 'López', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2952, 'Moisés', 'Alpuche', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6833, 'Miguel', 'Zárate', 8);
INSERT INTO professors (id, fname, lname, category_id) VALUES (8753, 'Alexia', 'Millán', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7321, 'Leonardo', 'Miquel', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7453, 'David', 'Ayala', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9834, 'Alberto', 'Basto', 3);
-- ENE
INSERT INTO professors (id, fname, lname, category_id) VALUES (3734, 'Felipe', 'Carballo', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7322, 'Manuel', 'Alemán', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6219, 'Carolina', 'Mejía', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1905, 'María', 'Basulto', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1284, 'Ramiro', 'Valenzuela', 3);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9350, 'Xótchil', 'Vargas', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (5120, 'Fernando', 'Montalvo', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6447, 'Ricardo', 'Mondragón', 2);
-- FIS
INSERT INTO professors (id, fname, lname, category_id) VALUES (1232, 'Robledo', 'Joan', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (4124, 'Marcos', 'Gallo', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (3716, 'Teresa', 'Casado', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (8138, 'David', 'Requena', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2586, 'Irene', 'Pallas', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1615, 'Vannia', 'Cano', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2686, 'José', 'Arques', 3);
-- MAT
INSERT INTO professors (id, fname, lname, category_id) VALUES (2662, 'Adrián', 'Jurado', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9366, 'Lucía', 'Bustamante', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6789, 'Rebeca', 'Zárate', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2286, 'Raquel', 'Bronson', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9923, 'Catarina', 'Infante', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (3558, 'Apolonia', 'Duarte', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9720, 'Efrén', 'Pasquel', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1637, 'Sergio', 'Yunes', 8);
-- MEC
INSERT INTO professors (id, fname, lname, category_id) VALUES (3114, 'Natanael', 'Campos', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (5018, 'Noella', 'Borrego', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6874, 'Margarita', 'Betancur', 8);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1599, 'Silvia', 'Quiroz', 7);
INSERT INTO professors (id, fname, lname, category_id) VALUES (6546, 'Nicolás', 'Echeverría', 1);
INSERT INTO professors (id, fname, lname, category_id) VALUES (1466, 'Xavier', 'Garza', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7180, 'Roque', 'Reyes', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (3704, 'Héctor', 'Rufino', 5);
-- CIV
INSERT INTO professors (id, fname, lname, category_id) VALUES (5185, 'Alberto', 'Montealbán', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (9618, 'Rafael', 'Méndez', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2729, 'Oscar', 'Muñoz', 6);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2770, 'Víctor', 'Estevez', 5);
INSERT INTO professors (id, fname, lname, category_id) VALUES (5276, 'Manuel', 'Melo', 5);
-- MAT (ESP)
INSERT INTO professors (id, fname, lname, category_id) VALUES (9285, 'Mauricio', 'Siqueiros', 2);
INSERT INTO professors (id, fname, lname, category_id) VALUES (4516, 'Lether', 'Balam', 0);
INSERT INTO professors (id, fname, lname, category_id) VALUES (7761, 'Donatiuh', 'Cepeda', 4);
INSERT INTO professors (id, fname, lname, category_id) VALUES (2267, 'Leslie', 'Bolaños', 2);


INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT000', 'Matemáticas I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT001', 'Matemáticas II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT002', 'Matemáticas III', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT003', 'Matemáticas IV', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT004', 'Matemáticas V', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT005', 'Matemáticas avanzadas I', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT006', 'Matemáticas avanzadas II', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT007', 'Probabilidad y estadística', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MAT008', 'Matemáticas discretas', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS000', 'Química', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS001', 'Física I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS002', 'Física II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS003', 'Física de semiconductores', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS004', 'Teoría electromagnética', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS005', 'Análisis de circuitos eléctricos I', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS006', 'Análisis de circuitos eléctricos II', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('FIS007', 'Termodinámica', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CAD000', 'Dibujo', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CAD001', 'Dibujo electrónico', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE000', 'Electrónica I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE001', 'Electrónica II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE002', 'Electrónica III', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE003', 'Electrónica digital I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE004', 'Electrónica digital II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE005', 'Ingeniería de control I', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE006', 'Ingeniería de control II', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE007', 'Instrumentación', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE008', 'Controladores lógicos programables', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE009', 'Sensores y actuadores', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE010', 'Microcontroladores I', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE011', 'Microcontroladores II', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE012', 'Procesamiento de señales', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE013', 'Redes industriales', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE014', 'Redes de computadoras', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE015', 'Control discreto', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE016', 'Redes neuronales', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE017', 'Lenguajes VLSI', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE018', 'Microprocesadores I', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE019', 'Microprocesadores II', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE020', 'Tratamiento digital de señales', 1, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE021', 'Control robusto', 2, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE022', 'Arquitectura de computadoras', 2, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE023', 'Control no lineal', 2, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE024', 'Electrónica industrial', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE025', 'Procesamiento de voz e imágenes', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ELE026', 'Inteligencia artificial', 2, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC000', 'Resistencia de materiales', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC001', 'Mecánica I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC002', 'Mecánica II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC003', 'Mecánica III', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC004', 'Robótica I', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC005', 'Robótica II', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC006', 'Neumática e hidráulica', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC007', 'Sistemas integrados de manufactura', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC008', 'Mecánica de materiales', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC009', 'Proyectos de sistemas mecatrónicos I', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC010', 'Proyectos de sistemas mecatrónicos II', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC011', 'Mecánica de fluidos', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC012', 'Vibración mecánica', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC013', 'Tecnología de materiales', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC014', 'Diseño mecatrónico', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('MEC015', 'Diseño de elementos de máquinas', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF000', 'Programación I', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF001', 'Programación II', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF002', 'Programación orientada a objetos', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF003', 'Programación web', 0, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF004', 'Programación de dispositivos portátiles', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF005', 'Sistemas operativos en tiempo real', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF006', 'Bases de datos I', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF007', 'Bases de datos II', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF008', 'Compiladores', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF009', 'Documentación de software', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF010', 'Lenguajes avanzados de programación', 1, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF011', 'Visión por computadora', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF012', 'Ingeniería de software I', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF013', 'Ingeniería de software II', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF014', 'Sistemas operativos modernos', 1, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF015', 'Proyecto integrador de software básico', 1, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF016', 'Sistemas operativos distribuidos', 2, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('SOF017', 'Proyecto integrador de software avanzado', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS000', 'Ética', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS001', 'Análisis político de México', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS002', 'Administración de recursos humanos', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS003', 'Metodología de la investigación', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS004', 'Proyecto de investigación', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS005', 'Economía', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS006', 'Legislación y ética profesional', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS007', 'Administración y calidad', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS008', 'Desarrollo de emprendedores', 0, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('BAS009', 'Planeación de proyectos', 1, 5);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE000', 'Energía y medio ambiente', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE001', 'Uso eficiente de la energía', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE002', 'Sistemas eléctricos', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE003', 'Generacion eólica', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE004', 'Sistemas fotovoltaicos y fototérmicos', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE005', 'Tecnología del hidrógeno', 2, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE006', 'Aerogeneradores', 2, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('ENE007', 'Potencial eólico', 2, 8);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV000', 'Procedimientos de construcción', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV001', 'Estructuras de concreto', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV002', 'Análisis estructural', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV003', 'Materiales de construcción', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV004', 'Costos de construcción', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV005', 'Carreteras', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV006', 'Pavimentos', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV007', 'Diseño de estructuras de acero', 0, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV008', 'Geotecnia I', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('CIV009', 'Geotecnia II', 0, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT001', 'Inferencia estadística', 4, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT002', 'Taller de análisis exploratorio de datos', 4, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT003', 'Técnicas de muestreo', 4, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT004', 'Modelos de regresión', 4, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT005', 'Diseño de experimentos', 4, 7);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT006', 'Análisis multivariado', 4, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT007', 'Estadística Bayesiana y teoría de decisiones', 4, 6);
INSERT INTO subjects (id, name, level_id, credits) VALUES ('EMT008', 'Métodos estadísticos con software', 4, 6);


INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1262 FROM subjects WHERE id = 'BAS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 8245 FROM subjects WHERE id = 'BAS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 9831 FROM subjects WHERE id = 'BAS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1941 FROM subjects WHERE id = 'BAS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 2835 FROM subjects WHERE id = 'BAS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 2895 FROM subjects WHERE id = 'BAS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 9156 FROM subjects WHERE id = 'BAS008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 3279 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 8356 FROM subjects WHERE id = 'ELE000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 3878 FROM subjects WHERE id = 'ELE001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 8427 FROM subjects WHERE id = 'ELE003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 6773 FROM subjects WHERE id = 'ELE005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 7453 FROM subjects WHERE id = 'ELE007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 8436 FROM subjects WHERE id = 'ELE008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 7321 FROM subjects WHERE id = 'ELE010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 6289 FROM subjects WHERE id = 'ELE011';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1232 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1615 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 3716 FROM subjects WHERE id = 'FIS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 4124 FROM subjects WHERE id = 'FIS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 2662 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 9366 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 6789 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 5018 FROM subjects WHERE id = 'MEC000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 6874 FROM subjects WHERE id = 'MEC002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 3114 FROM subjects WHERE id = 'MEC005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1466 FROM subjects WHERE id = 'MEC006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 3704 FROM subjects WHERE id = 'MEC007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 7180 FROM subjects WHERE id = 'MEC008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1599 FROM subjects WHERE id = 'MEC009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 5018 FROM subjects WHERE id = 'MEC011';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 1789 FROM subjects WHERE id = 'SOF000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 0, level_id, id, 8753 FROM subjects WHERE id = 'SOF002';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 8245 FROM subjects WHERE id = 'BAS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 9724 FROM subjects WHERE id = 'BAS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 2835 FROM subjects WHERE id = 'BAS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1941 FROM subjects WHERE id = 'BAS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1724 FROM subjects WHERE id = 'BAS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1941 FROM subjects WHERE id = 'BAS008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 4892 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 8436 FROM subjects WHERE id = 'ELE000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 2952 FROM subjects WHERE id = 'ELE001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 7453 FROM subjects WHERE id = 'ELE003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 7321 FROM subjects WHERE id = 'ELE005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 8427 FROM subjects WHERE id = 'ELE008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 7322 FROM subjects WHERE id = 'ENE002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1615 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 8138 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 2686 FROM subjects WHERE id = 'FIS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 4124 FROM subjects WHERE id = 'FIS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 3716 FROM subjects WHERE id = 'FIS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 2686 FROM subjects WHERE id = 'FIS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 3716 FROM subjects WHERE id = 'FIS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 2286 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 6789 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 9923 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1466 FROM subjects WHERE id = 'MEC000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 6546 FROM subjects WHERE id = 'MEC001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 1599 FROM subjects WHERE id = 'MEC002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 1, level_id, id, 8436 FROM subjects WHERE id = 'SOF000';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1941 FROM subjects WHERE id = 'BAS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 9724 FROM subjects WHERE id = 'BAS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1941 FROM subjects WHERE id = 'BAS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1724 FROM subjects WHERE id = 'BAS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2674 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 4892 FROM subjects WHERE id = 'CAD001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2952 FROM subjects WHERE id = 'ELE000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 8427 FROM subjects WHERE id = 'ELE001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 7321 FROM subjects WHERE id = 'ELE002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 6289 FROM subjects WHERE id = 'ELE003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2952 FROM subjects WHERE id = 'ELE004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1789 FROM subjects WHERE id = 'ELE005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 9834 FROM subjects WHERE id = 'ELE006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 7423 FROM subjects WHERE id = 'ELE009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 8436 FROM subjects WHERE id = 'ELE010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 7321 FROM subjects WHERE id = 'ELE012';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1905 FROM subjects WHERE id = 'ENE000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 6219 FROM subjects WHERE id = 'ENE003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 3716 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2586 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1232 FROM subjects WHERE id = 'FIS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2686 FROM subjects WHERE id = 'FIS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 8138 FROM subjects WHERE id = 'FIS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 2686 FROM subjects WHERE id = 'FIS006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 9923 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 3558 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 9720 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 1637 FROM subjects WHERE id = 'MAT003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 7180 FROM subjects WHERE id = 'MEC005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 7453 FROM subjects WHERE id = 'SOF000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 6219 FROM subjects WHERE id = 'SOF001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 3, level_id, id, 6447 FROM subjects WHERE id = 'SOF002';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2895 FROM subjects WHERE id = 'BAS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 8245 FROM subjects WHERE id = 'BAS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2835 FROM subjects WHERE id = 'BAS004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 9831 FROM subjects WHERE id = 'BAS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3279 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 6833 FROM subjects WHERE id = 'ELE000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 9834 FROM subjects WHERE id = 'ELE003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 6289 FROM subjects WHERE id = 'ELE005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3878 FROM subjects WHERE id = 'ELE006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 7453 FROM subjects WHERE id = 'ELE010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 1284 FROM subjects WHERE id = 'ENE001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2686 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2586 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3716 FROM subjects WHERE id = 'FIS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 4124 FROM subjects WHERE id = 'FIS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 1232 FROM subjects WHERE id = 'FIS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2662 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3558 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 2286 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 9720 FROM subjects WHERE id = 'MAT003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 6789 FROM subjects WHERE id = 'MAT004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3114 FROM subjects WHERE id = 'MEC000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 5018 FROM subjects WHERE id = 'MEC001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 6874 FROM subjects WHERE id = 'MEC002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 1599 FROM subjects WHERE id = 'MEC003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 6546 FROM subjects WHERE id = 'MEC004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 1466 FROM subjects WHERE id = 'MEC005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 7180 FROM subjects WHERE id = 'MEC007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 3704 FROM subjects WHERE id = 'MEC009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 5018 FROM subjects WHERE id = 'MEC010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 4, level_id, id, 8138 FROM subjects WHERE id = 'SOF000';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 9831 FROM subjects WHERE id = 'BAS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 1262 FROM subjects WHERE id = 'BAS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 1724 FROM subjects WHERE id = 'BAS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2835 FROM subjects WHERE id = 'BAS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2895 FROM subjects WHERE id = 'BAS006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2674 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 5185 FROM subjects WHERE id = 'CIV000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 9618 FROM subjects WHERE id = 'CIV001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2729 FROM subjects WHERE id = 'CIV002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2770 FROM subjects WHERE id = 'CIV003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 5276 FROM subjects WHERE id = 'CIV004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 5185 FROM subjects WHERE id = 'CIV005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 9618 FROM subjects WHERE id = 'CIV006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2729 FROM subjects WHERE id = 'CIV007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2770 FROM subjects WHERE id = 'CIV008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 5276 FROM subjects WHERE id = 'CIV009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 1232 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2686 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 3716 FROM subjects WHERE id = 'FIS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 3558 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 1637 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 9366 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 3114 FROM subjects WHERE id = 'MEC010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 5, level_id, id, 2286 FROM subjects WHERE id = 'SOF000';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 2835 FROM subjects WHERE id = 'BAS002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 9831 FROM subjects WHERE id = 'BAS003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 1941 FROM subjects WHERE id = 'BAS005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 1262 FROM subjects WHERE id = 'BAS007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 8245 FROM subjects WHERE id = 'BAS008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 3279 FROM subjects WHERE id = 'CAD000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 2586 FROM subjects WHERE id = 'FIS000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 1615 FROM subjects WHERE id = 'FIS001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 9923 FROM subjects WHERE id = 'MAT000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 6789 FROM subjects WHERE id = 'MAT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 2286 FROM subjects WHERE id = 'MAT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 9720 FROM subjects WHERE id = 'SOF000';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 6874 FROM subjects WHERE id = 'SOF001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 7180 FROM subjects WHERE id = 'SOF002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 3704 FROM subjects WHERE id = 'SOF003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 1789 FROM subjects WHERE id = 'SOF004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 8753 FROM subjects WHERE id = 'SOF005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 8436 FROM subjects WHERE id = 'SOF006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 7453 FROM subjects WHERE id = 'SOF007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 6219 FROM subjects WHERE id = 'SOF008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 8, level_id, id, 6447 FROM subjects WHERE id = 'SOF009';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 5625 FROM subjects WHERE id = 'BAS009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 3878 FROM subjects WHERE id = 'ELE014';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 7321 FROM subjects WHERE id = 'ELE015';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 6833 FROM subjects WHERE id = 'ELE016';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 6289 FROM subjects WHERE id = 'ELE017';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 1789 FROM subjects WHERE id = 'ELE018';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 7453 FROM subjects WHERE id = 'ELE019';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 9923 FROM subjects WHERE id = 'MAT005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 1637 FROM subjects WHERE id = 'MAT006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 9720 FROM subjects WHERE id = 'MAT007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 3704 FROM subjects WHERE id = 'MEC012';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 7180 FROM subjects WHERE id = 'MEC013';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 8138 FROM subjects WHERE id = 'SOF010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 11, level_id, id, 2286 FROM subjects WHERE id = 'SOF011';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 9724 FROM subjects WHERE id = 'BAS009';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 7321 FROM subjects WHERE id = 'ELE013';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 6833 FROM subjects WHERE id = 'ELE014';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 8753 FROM subjects WHERE id = 'ELE020';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 1637 FROM subjects WHERE id = 'MAT006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 6789 FROM subjects WHERE id = 'MAT007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 9923 FROM subjects WHERE id = 'MAT008';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 9720 FROM subjects WHERE id = 'SOF010';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 6874 FROM subjects WHERE id = 'SOF011';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 7180 FROM subjects WHERE id = 'SOF012';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 3704 FROM subjects WHERE id = 'SOF013';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 1789 FROM subjects WHERE id = 'SOF014';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 12, level_id, id, 8753 FROM subjects WHERE id = 'SOF015';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 8436 FROM subjects WHERE id = 'ELE021';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 8356 FROM subjects WHERE id = 'ELE022';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 9834 FROM subjects WHERE id = 'ELE023';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 7423 FROM subjects WHERE id = 'ELE024';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 1789 FROM subjects WHERE id = 'ELE025';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 6773 FROM subjects WHERE id = 'ELE026';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 8436 FROM subjects WHERE id = 'SOF016';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 13, level_id, id, 7453 FROM subjects WHERE id = 'SOF017';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 9834 FROM subjects WHERE id = 'ELE021';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 8753 FROM subjects WHERE id = 'ELE026';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 7322 FROM subjects WHERE id = 'ENE004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 3734 FROM subjects WHERE id = 'ENE005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 6219 FROM subjects WHERE id = 'ENE006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 1905 FROM subjects WHERE id = 'ENE007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 7322 FROM subjects WHERE id = 'MEC014';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 14, level_id, id, 6874 FROM subjects WHERE id = 'MEC015';

INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 9285 FROM subjects WHERE id = 'EMT001';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 4516 FROM subjects WHERE id = 'EMT002';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 7761 FROM subjects WHERE id = 'EMT003';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 2267 FROM subjects WHERE id = 'EMT004';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 4516 FROM subjects WHERE id = 'EMT005';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 9285 FROM subjects WHERE id = 'EMT006';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 9720 FROM subjects WHERE id = 'EMT007';
INSERT INTO course_subjects (course_id, level_id, subject_id, professor_id) SELECT 17, level_id, id, 6789 FROM subjects WHERE id = 'EMT008';


INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (987821, 'Alejandro', 'Martínez', '1993-06-10', 0);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (716785, 'Pedro', 'Meléndez', '1993-11-25', 0);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (414099, 'Erika', 'Izquierdo', '1988-02-09', 0);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (318447, 'Manuel', 'Rosado', '1994-04-01', 1);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (369755, 'Veronica', 'Brito', '1999-05-04', 1);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (630938, 'Eduardo', 'Galloso', '1992-07-13', 1);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (199605, 'Mauricio', 'García', '1991-09-27', 3);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (551921, 'Sidartha', 'Mukul', '1991-08-10', 3);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (152671, 'Ignacio', 'Dueñas', '1989-08-23', 3);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (256221, 'Elena', 'Cardeña', '1996-12-05', 4);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (117409, 'Carlos', 'Medina', '1996-01-01', 4);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (487605, 'Luis', 'Pavón', '1990-10-12', 4);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (910254, 'Álvaro', 'Ríos', '1993-09-29', 5);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (477974, 'Emilia', 'Almeida', '1990-07-12', 5);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (799994, 'Mario', 'Aguayo', '1999-05-08', 5);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (913740, 'Ramón', 'Bolaños', '1989-08-29', 5);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (824132, 'Victoria', 'Fuentes', '1989-02-11', 11);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (888168, 'Elizabeth', 'Baeza', '1993-05-22', 11);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (127295, 'Franciso', 'Icaza', '1997-10-07', 11);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (743846, 'Christian', 'Rojas', '1998-04-05', 12);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (354703, 'Isabel', 'Aké', '1991-04-15', 14);
INSERT INTO students (id, first_name, last_name, birthdate, course_id) VALUES (505867, 'Beatriz', 'Llánes', '1994-07-10', 14);


-- ********************************************************************
-- ******                        QUERY's                         ******
-- ********************************************************************

-- ¿Cuantos cursos existen por nivel?
-- [level_id, level_description, qty]

SELECT cl.id AS level_id, cl.description AS level_description, COUNT(c.id) AS qty
FROM course_levels cl
INNER JOIN courses c ON (cl.id = c.level_id)
GROUP BY cl.id, cl.description
ORDER BY cl.id;


-- ¿Cuantos cursos "activos" existen por nivel?
-- [level_id, level_description, qty]

-- ¿Cuantos cursos existen por nivel? (que sea mayor o igual a 3)
-- [level_id, level_description, qty]

-- ¿Cuántas materias se imparten por nivel?
-- [level_id, level_description, qty]

-- ¿Cuántas materias "diferentes" se imparten por nivel?
-- [level_id, level_description, qty]

-- ¿Cuantos profesores (distintos) imparten clases en cada curso?
-- [course_id, course_description, qty]

-- ¿Cuál es el pago por materias del semestre para cada profesor? (ordenado por pago)
-- [professor_id, full_name, payment]

-- ¿Cuánto es el pago total por materias en cada nivel?
-- [level_id, level_description, payment]

-- ¿Cuantos profesores (distintos) imparten clases en cada nivel?
-- [level_id, level_description, qty]







