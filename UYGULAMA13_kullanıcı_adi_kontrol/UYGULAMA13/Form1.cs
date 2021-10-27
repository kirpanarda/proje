using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullainiciadi;
            kullainiciadi = textBox1.Text;

            if (kullainiciadi=="hrpmtal")
            {
                MessageBox.Show("kullanici adi doğru");
            }
            else
            {
                MessageBox.Show("kullanici adi yanlışs");
            }
        }
    }
}
