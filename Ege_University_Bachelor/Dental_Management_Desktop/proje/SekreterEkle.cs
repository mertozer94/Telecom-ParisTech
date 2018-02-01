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
    public partial class SekreterEkle : Form
    {
        public SekreterEkle()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();
        private void eklebutton_Click(object sender, EventArgs e)
        {
             
            if (kaditextBox.Text == ""  )
            {
                MessageBox.Show("Kullanıcı Adı boş bırakılamaz !");
            }
            else if (sfrtextBox.Text == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz !");
            }
            else try
                {
                    if (!kadiExist(kaditextBox.Text))
                    {

                        Kayıt sekreter = new Kayıt();
                        sekreter.K_Adi = kaditextBox.Text;
                        sekreter.sifre = sfrtextBox.Text;
                        data.Kayıts.InsertOnSubmit(sekreter);
                        data.SubmitChanges();




                        MessageBox.Show("Kayıt başarıyla eklendi.");

                        clearTxt();


                    }
                    else
                    {
                        MessageBox.Show("GİRİLEN KULLANICI ADINA SAHİP SEKRETER VAR.LÜTFEN KONTROL EDİP YENİDEN DENEYİNİZ.");
                        clearTxt();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private bool kadiExist(string ad)
        {
            var TE = data.Kayıts.SingleOrDefault(c => c.K_Adi == ad);
            return (TE != null) ? true : false;
        }
        private void clearTxt()
        {
        kaditextBox.Clear();
            sfrtextBox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sfrtextBox.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false)
            {
                sfrtextBox.UseSystemPasswordChar = true;
            }
        }

        private void SekreterEkle_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            sfrtextBox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
        }

        private void SekreterEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
        }
    }
}
