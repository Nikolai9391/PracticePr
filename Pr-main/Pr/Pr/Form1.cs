using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                    double x, y, z;
                    x = Convert.ToDouble(textBox1.Text); y = Convert.ToDouble(textBox2.Text);
                    z = Convert.ToDouble(textBox3.Text); double alpha = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2);
                    label4.Text = alpha.ToString();
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
