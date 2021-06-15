using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataListsDemo
{
    public partial class MainForm : Form
    {
        private List<string> items = new List<string>();
        private List<User> users = new List<User>();

        public MainForm()
        {
            InitializeComponent();

            // #1 - Items - Strings
            // SelectedIndex - Ok
            // SelectedItem  - Ok (string)
            // SelectedValue - N/A
            //cmbUsers.Items.Add("Bermudez, Jesús");
            //cmbUsers.Items.Add("Huerta, Silvia");
            //cmbUsers.Items.Add("Ferrer, Manuel");
            //cmbUsers.Items.Add("Jurado, Francisca");
            //cmbUsers.Items.Add("Escribano, Rubén");
            //cmbUsers.Items.Add("García, Laia");
            //cmbUsers.Items.Add("Torrente, Oscar");
            //cmbUsers.SelectedIndex = 0;

            // #2 - Items - Objects
            // SelectedIndex - Ok
            // SelectedItem  - Ok
            // SelectedValue - N/A
            //cmbUsers.DisplayMember = "FullName";
            //cmbUsers.Items.Add(new User("Jesús", "Bermudez", 25));
            //cmbUsers.Items.Add(new User("Silvia", "Huerta", 18));
            //cmbUsers.Items.Add(new User("Manuel", "Ferrer", 36));
            //cmbUsers.Items.Add(new User("Francisca", "Jurado", 42));
            //cmbUsers.Items.Add(new User("Rubén", "Escribano", 27));
            //cmbUsers.Items.Add(new User("Laia", "García", 74));
            //cmbUsers.Items.Add(new User("Oscar", "Torrente", 53));
            //cmbUsers.SelectedIndex = 0;

            // #3 - DataSource - Strings (lista)
            // SelectedIndex - Ok
            // SelectedItem  - Ok (string)
            // SelectedValue - Ok (string)
            // Principal uso: datos no serán editados
            //items.Add("Bermudez, Jesús");
            //items.Add("Huerta, Silvia");
            //items.Add("Ferrer, Manuel");
            //items.Add("Jurado, Francisca");
            //items.Add("Escribano, Rubén");
            //items.Add("García, Laia");
            //items.Add("Torrente, Oscar");
            
            //cmbUsers.DataSource = items;

            // 4# - DataSource - Objects
            // SelectedIndex - Ok
            // SelectedItem  - Ok
            // SelectedValue - Ok (ValueMember habilitado)
            users.Add(new User("Jesús", "Bermudez", 25));
            users.Add(new User("Silvia", "Huerta", 18));
            users.Add(new User("Manuel", "Ferrer", 36));
            users.Add(new User("Francisca", "Jurado", 42));
            users.Add(new User("Rubén", "Escribano", 27));
            users.Add(new User("Laia", "García", 74));
            users.Add(new User("Oscar", "Torrente", 53));

            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Age";
            cmbUsers.DataSource = users;

            lstUsers.DisplayMember = "FullName";
            lstUsers.ValueMember = "Age";
            lstUsers.DataSource = users;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // #1 - Items - Strings
            // #2 - Items - Objects
            // #3 - DataSource - Strings
            // #4 - DataSource - Objects
            btnDelete.Enabled = true;

            tbIndex.Text = $"{cmbUsers.SelectedIndex}";
            tbItem.Text = $"{cmbUsers.SelectedItem}";
            tbValue.Text = $"{cmbUsers.SelectedValue}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // #1 - Items - Strings
            //cmbUsers.Items.Add("Agregado, Usuario");

            // #2 - Items - Objects
            //cmbUsers.Items.Add(new User("Usuario", "Agregado", 33));

            // #3 - DataSource - Strings
            //items.Add("Agregado, Usuario");
            //cmbUsers.DataSource = null;
            //cmbUsers.DataSource = items;

            // #4 - DataSource - Objects
            users.Add(new User("Usuario", "Agregado", 33));
            cmbUsers.DataSource = null;
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Age";
            cmbUsers.DataSource = users;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // #1 - Items - Strings
            // #2 - Items - Objects
            //cmbUsers.Items.RemoveAt(cmbUsers.SelectedIndex);

            // #3 - DataSource - Strings // ejemplo, no funciona bien
            //items.RemoveAt(cmbUsers.SelectedIndex);
            //cmbUsers.DataSource = null;
            //cmbUsers.DataSource = items;

            // #4 - DataSource - Objects // ejemplo, no funciona bien
            users.RemoveAt(cmbUsers.SelectedIndex);
            cmbUsers.DataSource = null;
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Age";
            cmbUsers.DataSource = users;

            btnDelete.Enabled = false;
            tbIndex.Clear();
            tbItem.Clear();
            tbValue.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("¿Confirmas borrar el elemento seleccionado?",
                                    "Aviso", MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    //MessageBox.Show("Seleccionaste: SI");
                    tsStatus.Text = "Seleccionaste: SI";
                    break;

                case DialogResult.No:
                    //MessageBox.Show("Seleccionaste: NO");
                    tsStatus.Text = "Seleccionaste: NO";
                    break;

                default:
                case DialogResult.Cancel:
                    //MessageBox.Show("Seleccionaste: CANCELAR o cerraste la ventana");
                    tsStatus.Text = "Seleccionaste: CANCELAR o cerraste la ventana";
                    break;
            }
        }

        private void nudProgress_ValueChanged(object sender, EventArgs e)
        {
            pbInstall.Value = (int)nudProgress.Value;
            pbStatus.Value = (int)nudProgress.Value;
        }
    }
}
