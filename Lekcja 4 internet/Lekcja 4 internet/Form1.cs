using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja_4_internet
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

        private void btnPrzelicz_Click(object sender, EventArgs e)
        {
            float predk_Mbity = float.Parse(txtMbity.Text);
            float predk_MBajty = predk_Mbity / 8;
            txtMBajty.Text = predk_MBajty.ToString();
        }
    }
}
