using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekckja_6_oceny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            int ocenaInf = int.Parse(textBox1.Text);
            int ocenaMat = int.Parse(textBox2.Text);
            int ocenaAng = int.Parse(textBox3.Text);
            const float pasek = 4.75f;
            float srednia = (float)(ocenaInf + ocenaMat + ocenaAng) / 3;
            bool czyPasek = (srednia >= pasek); //&& (frek > 0.85);
            MessageBox.Show("Czy dostaniesz czerwony pasek?" + czyPasek.ToString(),
                "wynik", MessageBoxButtons.OK);
        }
    }
}
