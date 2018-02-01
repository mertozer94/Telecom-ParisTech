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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktorİşlemleri goster = new Doktorİşlemleri();
            goster.Show();
            this.Hide();
            

            
        }
       
        private void Çıkışbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DİSHEKİMİTAKİP goster = new DİSHEKİMİTAKİP();
            goster.Show();
        }

        private void Hastabutton_Click(object sender, EventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            goster.Show();
            this.Visible = false;
        }

        private void Muayenebutton_Click(object sender, EventArgs e)
        {
            Muayene goster = new Muayene();
            goster.Show();
            this.Visible = false;
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            linqbagDataContext data = new linqbagDataContext();
            var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar1.SelectionRange.Start select t;
            dataGridView1.DataSource = T;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SekreterEkle goster = new SekreterEkle();
            goster.Show();
            this.Hide();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            DİSHEKİMİTAKİP goster = new DİSHEKİMİTAKİP();
            goster.Show();
        }

        
    }
}
