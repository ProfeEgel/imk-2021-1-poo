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
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.Items.Add(new User("Jesús", "Bermudez", 25));
            cmbUsers.Items.Add(new User("Silvia", "Huerta", 18));
            cmbUsers.Items.Add(new User("Manuel", "Ferrer", 36));
            cmbUsers.Items.Add(new User("Francisca", "Jurado", 42));
            cmbUsers.Items.Add(new User("Rubén", "Escribano", 27));
            cmbUsers.Items.Add(new User("Laia", "García", 74));
            cmbUsers.Items.Add(new User("Oscar", "Torrente", 53));
            cmbUsers.SelectedIndex = 0;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // #1 - Items - Strings
            // #2 - Items - Objects
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
            cmbUsers.Items.Add(new User("Usuario", "Agregado", 33));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // #1 - Items - Strings
            // #2 - Items - Objects
            cmbUsers.Items.RemoveAt(cmbUsers.SelectedIndex);

            btnDelete.Enabled = false;
            tbIndex.Clear();
            tbItem.Clear();
            tbValue.Clear();
        }
    }
}
