using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            double x ;
            double m;
            double z;
            double f;
            x = 0.15;
            m = 0.3;
            z = Math.Sin(x) / Math.Sqrt(1 + Math.Pow(m, 2) * Math.Sin(x) - Math.Pow(m * x, 2));
            f = z*(Math.Sin(x) * 9 + Math.E - (x - z));

            textBox1.Text = z.ToString();
            textBox2.Text = f.ToString();
        }
    }
}
