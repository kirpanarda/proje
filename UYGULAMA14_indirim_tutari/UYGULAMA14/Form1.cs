using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonyuzde10_Click(object sender, EventArgs e)
        {
            double fiyat, indirimlifiyat,indirimtutari;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimtutari = fiyat * 0.1;
            indirimlifiyat=fiyat - indirimtutari;
            label3.Text = indirimlifiyat.ToString() + "TL";
        }

        private void buttonyuzde25_Click(object sender, EventArgs e)
        {
            double fiyat, indirimlifiyat, indirimtutari;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimtutari = fiyat * 0.25;
            indirimlifiyat = fiyat - indirimtutari;
            label3.Text = indirimlifiyat.ToString() + "TL";
        }

        private void buttonyuzde50_Click(object sender, EventArgs e)
        {
            double fiyat, indirimlifiyat, indirimtutari;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimtutari = fiyat * 0.5;
            indirimlifiyat = fiyat - indirimtutari;
            label3.Text = indirimlifiyat.ToString() + "TL";
        }

        private void buttonyuzde75_Click(object sender, EventArgs e)
        {
            double fiyat, indirimlifiyat, indirimtutari;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimtutari = fiyat * 0.75;
            indirimlifiyat = fiyat - indirimtutari;
            label3.Text = indirimlifiyat.ToString() + "TL";
        }
    }
}
