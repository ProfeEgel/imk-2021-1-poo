
namespace FormsDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbColors = new System.Windows.Forms.TextBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkBlue = new System.Windows.Forms.CheckBox();
            this.chkBrown = new System.Windows.Forms.CheckBox();
            this.chkYellow = new System.Windows.Forms.CheckBox();
            this.chkOrange = new System.Windows.Forms.CheckBox();
            this.chkMagenta = new System.Windows.Forms.CheckBox();
            this.chkCyan = new System.Windows.Forms.CheckBox();
            this.chkGray = new System.Windows.Forms.CheckBox();
            this.chkWhite = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.radMercurio = new System.Windows.Forms.RadioButton();
            this.radVenus = new System.Windows.Forms.RadioButton();
            this.radTierra = new System.Windows.Forms.RadioButton();
            this.radMarte = new System.Windows.Forms.RadioButton();
            this.radJupiter = new System.Windows.Forms.RadioButton();
            this.radSaturno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNeptuno = new System.Windows.Forms.RadioButton();
            this.radUrano = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlaneta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(428, 17);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(87, 33);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prueba:";
            // 
            // tbTest
            // 
            this.tbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTest.Location = new System.Drawing.Point(97, 20);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(316, 26);
            this.tbTest.TabIndex = 2;
            this.tbTest.MouseEnter += new System.EventHandler(this.tbTest_MouseEnter);
            this.tbTest.MouseLeave += new System.EventHandler(this.tbTest_MouseLeave);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRed.Location = new System.Drawing.Point(97, 114);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(58, 24);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colores:";
            // 
            // tbColors
            // 
            this.tbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColors.Location = new System.Drawing.Point(97, 70);
            this.tbColors.Name = "tbColors";
            this.tbColors.ReadOnly = true;
            this.tbColors.Size = new System.Drawing.Size(316, 26);
            this.tbColors.TabIndex = 2;
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreen.Location = new System.Drawing.Point(97, 144);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(73, 24);
            this.chkGreen.TabIndex = 3;
            this.chkGreen.Text = "Green";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkBlue
            // 
            this.chkBlue.AutoSize = true;
            this.chkBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlue.Location = new System.Drawing.Point(97, 174);
            this.chkBlue.Name = "chkBlue";
            this.chkBlue.Size = new System.Drawing.Size(60, 24);
            this.chkBlue.TabIndex = 3;
            this.chkBlue.Text = "Blue";
            this.chkBlue.UseVisualStyleBackColor = true;
            this.chkBlue.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkBrown
            // 
            this.chkBrown.AutoSize = true;
            this.chkBrown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrown.Location = new System.Drawing.Point(211, 114);
            this.chkBrown.Name = "chkBrown";
            this.chkBrown.Size = new System.Drawing.Size(73, 24);
            this.chkBrown.TabIndex = 3;
            this.chkBrown.Text = "Brown";
            this.chkBrown.UseVisualStyleBackColor = true;
            this.chkBrown.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkYellow
            // 
            this.chkYellow.AutoSize = true;
            this.chkYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYellow.Location = new System.Drawing.Point(211, 144);
            this.chkYellow.Name = "chkYellow";
            this.chkYellow.Size = new System.Drawing.Size(74, 24);
            this.chkYellow.TabIndex = 3;
            this.chkYellow.Text = "Yellow";
            this.chkYellow.UseVisualStyleBackColor = true;
            this.chkYellow.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkOrange
            // 
            this.chkOrange.AutoSize = true;
            this.chkOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrange.Location = new System.Drawing.Point(211, 174);
            this.chkOrange.Name = "chkOrange";
            this.chkOrange.Size = new System.Drawing.Size(81, 24);
            this.chkOrange.TabIndex = 3;
            this.chkOrange.Text = "Orange";
            this.chkOrange.UseVisualStyleBackColor = true;
            this.chkOrange.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkMagenta
            // 
            this.chkMagenta.AutoSize = true;
            this.chkMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMagenta.Location = new System.Drawing.Point(341, 114);
            this.chkMagenta.Name = "chkMagenta";
            this.chkMagenta.Size = new System.Drawing.Size(91, 24);
            this.chkMagenta.TabIndex = 3;
            this.chkMagenta.Text = "Magenta";
            this.chkMagenta.UseVisualStyleBackColor = true;
            this.chkMagenta.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkCyan
            // 
            this.chkCyan.AutoSize = true;
            this.chkCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCyan.Location = new System.Drawing.Point(341, 144);
            this.chkCyan.Name = "chkCyan";
            this.chkCyan.Size = new System.Drawing.Size(64, 24);
            this.chkCyan.TabIndex = 3;
            this.chkCyan.Text = "Cyan";
            this.chkCyan.UseVisualStyleBackColor = true;
            this.chkCyan.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkGray
            // 
            this.chkGray.AutoSize = true;
            this.chkGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGray.Location = new System.Drawing.Point(341, 174);
            this.chkGray.Name = "chkGray";
            this.chkGray.Size = new System.Drawing.Size(62, 24);
            this.chkGray.TabIndex = 3;
            this.chkGray.Text = "Gray";
            this.chkGray.UseVisualStyleBackColor = true;
            this.chkGray.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkWhite
            // 
            this.chkWhite.AutoSize = true;
            this.chkWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhite.Location = new System.Drawing.Point(471, 114);
            this.chkWhite.Name = "chkWhite";
            this.chkWhite.Size = new System.Drawing.Size(69, 24);
            this.chkWhite.TabIndex = 3;
            this.chkWhite.Text = "White";
            this.chkWhite.UseVisualStyleBackColor = true;
            this.chkWhite.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlack.Location = new System.Drawing.Point(471, 144);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(67, 24);
            this.chkBlack.TabIndex = 3;
            this.chkBlack.Text = "Black";
            this.chkBlack.UseVisualStyleBackColor = true;
            this.chkBlack.CheckedChanged += new System.EventHandler(this.chkColors_CheckedChanged);
            // 
            // radMercurio
            // 
            this.radMercurio.AutoSize = true;
            this.radMercurio.Checked = true;
            this.radMercurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMercurio.Location = new System.Drawing.Point(26, 33);
            this.radMercurio.Name = "radMercurio";
            this.radMercurio.Size = new System.Drawing.Size(88, 24);
            this.radMercurio.TabIndex = 4;
            this.radMercurio.TabStop = true;
            this.radMercurio.Text = "Mercurio";
            this.radMercurio.UseVisualStyleBackColor = true;
            this.radMercurio.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radVenus
            // 
            this.radVenus.AutoSize = true;
            this.radVenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVenus.Location = new System.Drawing.Point(26, 63);
            this.radVenus.Name = "radVenus";
            this.radVenus.Size = new System.Drawing.Size(73, 24);
            this.radVenus.TabIndex = 4;
            this.radVenus.TabStop = true;
            this.radVenus.Text = "Venus";
            this.radVenus.UseVisualStyleBackColor = true;
            this.radVenus.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radTierra
            // 
            this.radTierra.AutoSize = true;
            this.radTierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTierra.Location = new System.Drawing.Point(26, 93);
            this.radTierra.Name = "radTierra";
            this.radTierra.Size = new System.Drawing.Size(67, 24);
            this.radTierra.TabIndex = 4;
            this.radTierra.TabStop = true;
            this.radTierra.Text = "Tierra";
            this.radTierra.UseVisualStyleBackColor = true;
            this.radTierra.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radMarte
            // 
            this.radMarte.AutoSize = true;
            this.radMarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMarte.Location = new System.Drawing.Point(150, 33);
            this.radMarte.Name = "radMarte";
            this.radMarte.Size = new System.Drawing.Size(68, 24);
            this.radMarte.TabIndex = 4;
            this.radMarte.TabStop = true;
            this.radMarte.Text = "Marte";
            this.radMarte.UseVisualStyleBackColor = true;
            this.radMarte.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radJupiter
            // 
            this.radJupiter.AutoSize = true;
            this.radJupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJupiter.Location = new System.Drawing.Point(150, 63);
            this.radJupiter.Name = "radJupiter";
            this.radJupiter.Size = new System.Drawing.Size(75, 24);
            this.radJupiter.TabIndex = 4;
            this.radJupiter.TabStop = true;
            this.radJupiter.Text = "Jupiter";
            this.radJupiter.UseVisualStyleBackColor = true;
            this.radJupiter.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radSaturno
            // 
            this.radSaturno.AutoSize = true;
            this.radSaturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSaturno.Location = new System.Drawing.Point(150, 93);
            this.radSaturno.Name = "radSaturno";
            this.radSaturno.Size = new System.Drawing.Size(84, 24);
            this.radSaturno.TabIndex = 4;
            this.radSaturno.TabStop = true;
            this.radSaturno.Text = "Saturno";
            this.radSaturno.UseVisualStyleBackColor = true;
            this.radSaturno.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMercurio);
            this.groupBox1.Controls.Add(this.radSaturno);
            this.groupBox1.Controls.Add(this.radVenus);
            this.groupBox1.Controls.Add(this.radNeptuno);
            this.groupBox1.Controls.Add(this.radJupiter);
            this.groupBox1.Controls.Add(this.radTierra);
            this.groupBox1.Controls.Add(this.radUrano);
            this.groupBox1.Controls.Add(this.radMarte);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planetas";
            // 
            // radNeptuno
            // 
            this.radNeptuno.AutoSize = true;
            this.radNeptuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNeptuno.Location = new System.Drawing.Point(267, 63);
            this.radNeptuno.Name = "radNeptuno";
            this.radNeptuno.Size = new System.Drawing.Size(88, 24);
            this.radNeptuno.TabIndex = 4;
            this.radNeptuno.TabStop = true;
            this.radNeptuno.Text = "Neptuno";
            this.radNeptuno.UseVisualStyleBackColor = true;
            this.radNeptuno.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // radUrano
            // 
            this.radUrano.AutoSize = true;
            this.radUrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUrano.Location = new System.Drawing.Point(267, 33);
            this.radUrano.Name = "radUrano";
            this.radUrano.Size = new System.Drawing.Size(71, 24);
            this.radUrano.TabIndex = 4;
            this.radUrano.TabStop = true;
            this.radUrano.Text = "Urano";
            this.radUrano.UseVisualStyleBackColor = true;
            this.radUrano.Click += new System.EventHandler(this.radMercurio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Planeta favorito:";
            // 
            // tbPlaneta
            // 
            this.tbPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaneta.Location = new System.Drawing.Point(156, 224);
            this.tbPlaneta.Name = "tbPlaneta";
            this.tbPlaneta.ReadOnly = true;
            this.tbPlaneta.Size = new System.Drawing.Size(257, 26);
            this.tbPlaneta.TabIndex = 2;
            this.tbPlaneta.Text = "Mercurio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkGray);
            this.Controls.Add(this.chkOrange);
            this.Controls.Add(this.chkBlue);
            this.Controls.Add(this.chkCyan);
            this.Controls.Add(this.chkYellow);
            this.Controls.Add(this.chkGreen);
            this.Controls.Add(this.chkBlack);
            this.Controls.Add(this.chkWhite);
            this.Controls.Add(this.chkMagenta);
            this.Controls.Add(this.chkBrown);
            this.Controls.Add(this.chkRed);
            this.Controls.Add(this.tbPlaneta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbColors;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkBlue;
        private System.Windows.Forms.CheckBox chkBrown;
        private System.Windows.Forms.CheckBox chkYellow;
        private System.Windows.Forms.CheckBox chkOrange;
        private System.Windows.Forms.CheckBox chkMagenta;
        private System.Windows.Forms.CheckBox chkCyan;
        private System.Windows.Forms.CheckBox chkGray;
        private System.Windows.Forms.CheckBox chkWhite;
        private System.Windows.Forms.CheckBox chkBlack;
        private System.Windows.Forms.RadioButton radMercurio;
        private System.Windows.Forms.RadioButton radVenus;
        private System.Windows.Forms.RadioButton radTierra;
        private System.Windows.Forms.RadioButton radMarte;
        private System.Windows.Forms.RadioButton radJupiter;
        private System.Windows.Forms.RadioButton radSaturno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNeptuno;
        private System.Windows.Forms.RadioButton radUrano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlaneta;
    }
}

