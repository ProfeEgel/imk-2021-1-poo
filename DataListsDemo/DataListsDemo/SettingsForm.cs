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
    public partial class SettingsForm : Form
    {
        public int Value { get; private set; }

        public SettingsForm(string name)
        {
            InitializeComponent();
            
            tbName.Text = name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // dar de alta paciente/libro/etc..
            int number = 0;
            if (Int32.TryParse(tbInOut.Text, out number) &&
                (number >= 0 && number <= 100))
            {
                Value = number;
            }
            else
            {
                Value = 0;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
