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
    public partial class Doktorİşlemleri : Form
    {
        linqbagDataContext data = new linqbagDataContext();
        private void görüntüle()
        {
            try
            {
                var T = from t in data.GetTable<Doctor>() select t;
                dataGridView1.DataSource = T;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public Doktorİşlemleri()
        {
            InitializeComponent();
        }

        private void Doktorİşlemleri_Load(object sender, EventArgs e)
        {
            görüntüle();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                if (comboBox1.SelectedIndex == 0)
                { 
                
                
                
                }




            
            
            
            }
        }

        private void Eklebutton_Click(object sender, EventArgs e)
        {
            DoktorEkle ekle = new DoktorEkle();
            ekle.Show();
            this.Hide();

        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorSil goster = new DoktorSil();
            goster.Show();
        }

        private void Geributton_Click(object sender, EventArgs e)
        {
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
            this.Hide();
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            int indeks = comboBox1.SelectedIndex;
            switch (indeks)
            {
                case 0 :
                var T = from t in data.GetTable<Doctor>() select t;
                dataGridView1.DataSource = T;
                break;
                case 1:
                    var A = from t in data.Doctors where t.TC_kimlik==AramatextBox.Text select t;
                    dataGridView1.DataSource = A;
                    break;
                case 2:
                     var B = from t in data.Doctors where t.AdSoyad==AramatextBox.Text select t;
                    dataGridView1.DataSource = B;
                    break;
                case 3:
                     var S = from t in data.Doctors where t.SicilNo==AramatextBox.Text select t;
                    dataGridView1.DataSource = S;
                    break;
                case 4:
                     var Y = from t in data.Doctors where t.Ceptel==AramatextBox.Text select t;
                    dataGridView1.DataSource = Y;
                    break;
                case 5:
                     var V = from t in data.Doctors where t.Evtel==AramatextBox.Text select t;
                    dataGridView1.DataSource = V;
                    break;
                case 6:
                     var C = from t in data.Doctors where t.Email==AramatextBox.Text select t;
                    dataGridView1.DataSource = C;
                    break;
            }
        }

        private void güncellebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorGüncelle goster = new DoktorGüncelle();
            goster.Show();
        }

        private void Doktorİşlemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
            this.Hide();
        }
    }
}
