using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje
{
    public partial class Saat : UserControl
    {
        public Saat()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatlabel.Text = DateTime.Now.ToLongTimeString();
            tarhlabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
