using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja_5_3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal kosztFilamentu = decimal.Parse(txtKoszt.Text);
            int zuzytyFilament = int.Parse(txtZuzyty.Text);
            decimal kosztMaterialu = (kosztFilamentu * zuzytyFilament) / 1000m;
            lblWynik.Text = $"Cena materiału wynosi: {kosztMaterialu.ToString("C")}";
        }
    }
}
