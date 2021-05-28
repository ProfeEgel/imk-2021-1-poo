using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class Form1 : Form
    {
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();

            tbTest.Text = "Contador de clicks: 0";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tbTest.Text = $"Contador de clicks: {++contador}";

            //tbTest.Text = "¡¡¡Test Click!!!";
            // MessageBox.Show("Hola");
        }
    }
}
