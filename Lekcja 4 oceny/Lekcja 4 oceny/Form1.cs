using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja_4_oceny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mat = int.Parse(textBox1.Text);
            int fiz = int.Parse(textBox2.Text);
            int inf = int.Parse(textBox3.Text);
            int suma = mat + fiz + inf;
            float srednia = (float) suma / 3;
            textBox4.Text = srednia.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
