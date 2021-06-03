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
        private CheckBox[] chkColorsArray;

        public Form1()
        {
            InitializeComponent();

            tbTest.Text = "Contador de clicks: 0";

            chkColorsArray = new[]
            {
                chkRed, chkGreen, chkBlue,
                chkBrown, chkYellow, chkOrange,
                chkMagenta, chkCyan, chkGray,
                chkWhite, chkBlack
            };
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tbTest.Text = $"Contador de clicks: {++contador}";

            //tbTest.Text = "¡¡¡Test Click!!!";
            // MessageBox.Show("Hola");
        }

        private void chkColors_CheckedChanged(object sender, EventArgs e)
        {
            List<string> colorNames = new List<string>();

            tbColors.Clear();
            foreach (var chkColor in chkColorsArray)
            {
                if (chkColor.Checked)
                {
                    colorNames.Add(chkColor.Text);
                }
            }

            tbColors.Text = String.Join("+", colorNames);
        }

        private void radMercurio_Click(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            tbPlaneta.Text = radio.Text;
        }

        private void tbTest_MouseEnter(object sender, EventArgs e)
        {
            tbTest.BackColor = Color.Yellow;
        }

        private void tbTest_MouseLeave(object sender, EventArgs e)
        {
            tbTest.BackColor = Color.White;
        }
    }
}
