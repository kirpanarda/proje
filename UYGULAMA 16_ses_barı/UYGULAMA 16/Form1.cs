﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;

            if (ses==0)
            {
                label1.Text = "ses yok ";
                label1.ForeColor = Color.Black;
            }

            if (ses>=1 && ses<=10)
            {
                label1.Text = "normal ses seviyesi";
                label1.ForeColor = Color.Green;

            }
            if (ses>=11 && ses<=15)
            {
                label1.Text = "yuksek ses seviyesi";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
