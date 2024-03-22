using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taux_de_change
{
    public partial class Form1 : Form
    {
        float montant_euro = 0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            label1.Text += ((Button)sender).Text;
            montant_euro = float.Parse(label1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void buttonDevise_Click(object sender, EventArgs e)
        {
            string devise = ((Button)sender).Text;
            switch (devise)
            {
                case "Dollars":
                    label1.Text = (montant_euro * 1.08).ToString(".##");
                    break;
                case "Livres":
                    label1.Text = (montant_euro * 0.86).ToString(".##");
                    break;
                case "Euros":
                    label1.Text = montant_euro.ToString();
                    break;
                
            }
        }
    }
}
