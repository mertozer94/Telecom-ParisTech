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
    public partial class HastaGüncelle : Form
    {
        public HastaGüncelle()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();
        private void Çıkbutton_Click(object sender, EventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            this.Hide();
            goster.Show();
        }

        private void ARAbutton_Click(object sender, EventArgs e)
        {
            int not = 0;
            if (TCtextBox.TextLength == 0 || TCtextBox.TextLength != 11)
            {
                KaydeterrorProvider.SetError(ARAbutton, "Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (TCtextBox.TextLength == 0)
                {
                    tcerror.SetError(TCtextBox, "Tc kimlik no boş bırakılamaz!");
                }
                else if (TCtextBox.TextLength != 11)
                {
                    tcerror.SetError(TCtextBox, "Tc kimlik no 11 haneli olmalı!");
                }


            }
            else
            {
                foreach (Person d in data.Persons)
                {
                    if (d.TC_kimlik == TCtextBox.Text)
                    {
                        not = 1;
                        textBox_tc.Text = d.TC_kimlik;
                        textBox_Ad.Text = d.AdSoyad;
                        textBox_baba.Text = d.BabaAdı;
                        textBox_ana.Text = d.AnaAdı;
                        textBox_dogumYer.Text = d.DogumYeri;
                        dateTimePicker_tarih.Value = d.DogumTarihi.Value;
                        if (d.Cinsiyet == true)
                            comboBox_cins.SelectedIndex = 0;
                        else
                            comboBox_cins.SelectedIndex = 1;
                        if (d.SosyalGüvence == "Emekli Sandığı")
                        { comboBox_guven.SelectedIndex = 0; }
                        else if (d.SosyalGüvence == "SSK")
                        {
                            comboBox_guven.SelectedIndex = 1;
                        }
                        else
                        {
                            comboBox_guven.SelectedIndex = 2;
                                
                        }
                        
                        textBox_guven_no.Text = d.SGNO;
                        if (d.MedeniDurum == true)
                            comboBox_medeni.SelectedIndex = 0;
                        else
                            comboBox_medeni.SelectedIndex = 1;
                        textBox_il.Text = d.il;
                        textBox_ilce.Text = d.ilce;
                        textBox_adres.Text = d.Adres;
                        
                        textBox_posta.Text = (d.PostaKodu).ToString();
                        textBox_email.Text = d.Email;
                        textBox_cep.Text = d.Ceptel;
                        textBox_ev.Text = d.Evtel;


                    }
                }

            }
            if (not == 0)
                MessageBox.Show("Bu Tc numarasına ait Hasta bulunamadı.");
        }

        private void Kaydetbutton_Click(object sender, EventArgs e)
        {
            if (textBox_Ad.Text == "")
            { MessageBox.Show("AdSoyad BOŞ BIRAKILAMAZ !"); }
            else
            {
                try
                {


                    Person hasta = data.Persons.SingleOrDefault(c1 => c1.TC_kimlik == TCtextBox.Text);
                    hasta.TC_kimlik = textBox_tc.Text;
                    hasta.AdSoyad = textBox_Ad.Text;
                    hasta.AnaAdı = textBox_ana.Text;
                    hasta.BabaAdı = textBox_baba.Text;
                    hasta.Ceptel = textBox_cep.Text;
                    hasta.Evtel = textBox_ev.Text;
                    hasta.il = textBox_il.Text;
                    hasta.ilce = textBox_ilce.Text;
                    hasta.Adres = textBox_adres.Text;
                    hasta.DogumYeri = textBox_dogumYer.Text;
                    hasta.SGNO = textBox_guven_no.Text;
                    if (textBox_posta.Text != "")
                        hasta.PostaKodu = int.Parse(textBox_posta.Text);
                    hasta.Email = textBox_email.Text;
                    if (comboBox_cins.SelectedIndex == 0)
                    { hasta.Cinsiyet = true; }
                    else
                    { hasta.Cinsiyet = false; }
                    if (comboBox_medeni.SelectedIndex == 0)
                    { hasta.MedeniDurum = true; }
                    else
                    { hasta.MedeniDurum = false; }
                    if (comboBox_guven.SelectedIndex == 0)
                        hasta.SosyalGüvence = "Emekli Sandığı";
                    if (comboBox_guven.SelectedIndex == 1)
                        hasta.SosyalGüvence = "SSK";
                    if (comboBox_guven.SelectedIndex == 2)
                        hasta.SosyalGüvence = "Bağkur";
                    hasta.DogumTarihi = dateTimePicker_tarih.Value.Date;

                    data.SubmitChanges();




                    KaydeterrorProvider.Clear();
                    MessageBox.Show("Kayıt başarıyla güncellendi.");

                    clearTxt();



                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void clearTxt()
        {
            textBox_Ad.Clear();
            textBox_adres.Clear();
            textBox_ana.Clear();
            textBox_baba.Clear();
            textBox_cep.Clear();
            textBox_dogumYer.Clear();
            textBox_email.Clear();
            textBox_ev.Clear();
            textBox_guven_no.Clear();
            textBox_il.Clear();
            textBox_ilce.Clear();
            textBox_posta.Clear();
            textBox_tc.Clear();


        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_baba_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_ana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_dogumYer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_guven_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_il_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_ilce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_posta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_ev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HastaGüncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            this.Hide();
            goster.Show();
        }
    }
}
