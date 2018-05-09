using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_metody_2._2_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(this.textBox1.Text);
            double b = Convert.ToDouble(this.textBox2.Text);

            if (radioButton1.Checked)
            {
                this.textBox3.Text = (a % b).ToString();
            }

            if (radioButton2.Checked)
            {
                this.textBox3.Text = (Math.Pow(a, b)).ToString();
            }

            if (radioButton3.Checked)
            {
                this.textBox3.Text = (a + b).ToString();
            }

            if (radioButton4.Checked)
            {
                this.textBox3.Text = (a / b).ToString();
            }
        }
    }
}
