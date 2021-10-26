using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_07_Teglatest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int c = int.Parse(textBoxC.Text);
                textBoxFelszin.Text = (2 * (a * b + a * c + b * c)).ToString();
                textBoxTerfogat.Text = (a * b * c).ToString();
            }
            catch (Exception)
            {
                // TODO
            }
        }
    }
}