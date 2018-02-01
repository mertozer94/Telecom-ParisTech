using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje
{
    public partial class DİSHEKİMİTAKİP : Form
    {
        public DİSHEKİMİTAKİP()
        {
            InitializeComponent();
        }

        private void sEKRETERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEKRETERGİRİS goster = new SEKRETERGİRİS();
            goster.MdiParent = this;
            goster.Show();
        }

        private void hASTAİŞLEMERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RANDEVUGORHASTA goster = new RANDEVUGORHASTA();
            goster.MdiParent = this;
            goster.Show();

        }

        private void DİSHEKİMİTAKİP_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
