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
    public partial class Hastaİşlemleri : Form
    {
        public Hastaİşlemleri()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();
        private void görüntüle()
        {
            try
            {
                var T = from t in data.GetTable<Person>() select t;
                dataGridView1.DataSource = T;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
            this.Visible = false;
        }

        private void Eklebutton_Click(object sender, EventArgs e)
        {
            HastaEkle goster = new HastaEkle();
            goster.Show();
            this.Hide();
        }

        private void Hastaİşlemleri_Load(object sender, EventArgs e)
        {
            görüntüle();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            HastaSil goster = new HastaSil();
            this.Hide();
            goster.Show();



        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            int indeks = comboBox1.SelectedIndex;
            switch (indeks)
            {
                case 0:
                    var T = from t in data.GetTable<Person>() select t;
                    dataGridView1.DataSource = T;
                    break;
                case 1:
                    var A = from t in data.Persons where t.TC_kimlik == AramatextBox.Text select t;
                    dataGridView1.DataSource = A;
                    break;
                case 2:
                    var B = from t in data.Persons where t.AdSoyad == AramatextBox.Text select t;
                    dataGridView1.DataSource = B;
                    break;

            }
        }

        private void Güncellebutton_Click(object sender, EventArgs e)
        {
            HastaGüncelle goster = new HastaGüncelle();
            this.Hide();
            goster.Show();
        }

        private void Hastaİşlemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
            this.Hide();
        }
    }
}
