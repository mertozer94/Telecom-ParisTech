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
    public partial class HastaEkle : Form
    {
        linqbagDataContext data = new linqbagDataContext();
        public HastaEkle()
        {
            InitializeComponent();
        }



    

  

        private void button2_Click(object sender, EventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            goster.Show();
            this.Visible = false;
        }

        private void Chekbox_Tc_CheckedChanged(object sender, EventArgs e)
        {
            if (Chekbox_Tc.Checked == true)
            {

                textBox_tc.UseSystemPasswordChar = true;

            }
            if (Chekbox_Tc.Checked == false)
            {
                textBox_tc.UseSystemPasswordChar = false;

            }
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            goster.Show();
            this.Visible = false;
        }

        private void textBox_tc_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_ev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (textBox_tc.TextLength == 0 || textBox_tc.TextLength != 11 || textBox_Ad.Text == "")
            {
                KaydeterrorProvider.SetError(Kaydetbutton,"Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (textBox_tc.TextLength == 0)
                {
                    TcKİmerrorProvider.SetError(textBox_tc, "Tc kimlik no boş bırakılamaz!");
                }
                else if (textBox_tc.TextLength != 11)
                {
                    TcKİmerrorProvider.SetError(textBox_tc, "Tc kimlik no 11 haneli olmalı!");
                }
                if (textBox_Ad.Text == "")
                {
                    AdSoyaderrorProvider.SetError(textBox_Ad, "Ad Soyad boş bırakılamaz!");
                }

            }
            else try
                {
                    if (!tcExist(textBox_tc.Text))
                    {

                        Person hasta = new Person();
                        hasta.TC_kimlik = textBox_tc.Text;
                        hasta.AdSoyad = textBox_Ad.Text;
                        hasta.AnaAdı = textBox_ana.Text;
                        hasta.BabaAdı = textBox_baba.Text;
                        hasta.Ceptel = textBox_cep.Text;
                        hasta.Evtel = textBox_ev.Text;
                        hasta.il =textBox_il.Text;
                        hasta.ilce = textBox_ilce.Text;
                        hasta.Adres = textBox_adres.Text;
                        hasta.DogumYeri = textBox_dogumYer.Text;
                        hasta.SGNO = textBox_guven_no.Text;
                        if(textBox_posta.Text!="")
                        hasta.PostaKodu = int.Parse( textBox_posta.Text);
                        hasta.Email = textBox_email.Text;
                        if (comboBox_cins.SelectedIndex == 0)
                        { hasta.Cinsiyet = true; }
                        else
                        { hasta.Cinsiyet = false; }
                        if (comboBox_medeni.SelectedIndex == 0)
                        { hasta.MedeniDurum = true; }
                        else
                        { hasta.MedeniDurum = false; }
                        if(comboBox_guven.SelectedIndex == 0)
                            hasta.SosyalGüvence = "Emekli Sandığı";
                        if(comboBox_guven.SelectedIndex == 1)
                            hasta.SosyalGüvence = "SSK";
                        if(comboBox_guven.SelectedIndex == 2)
                            hasta.SosyalGüvence = "Bağkur";
                        hasta.DogumTarihi = dateTimePicker_tarih.Value.Date;
                        data.Persons.InsertOnSubmit(hasta);
                        data.SubmitChanges();



                        KaydeterrorProvider.Clear();
                        MessageBox.Show("Kayıt başarıyla eklendi.");

                        clearTxt();


                    }
                    else
                    {
                        MessageBox.Show("GİRİLEN TC_KİMLİK NUMARASINA SAHİP HASTA VAR.LÜTFEN KONTROL EDİP YENİDEN DENEYİNİZ.");
                        clearTxt();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private bool tcExist(string tc)
        {
            var TE = data.Persons.SingleOrDefault(c => c.TC_kimlik == tc);
            return (TE != null) ? true : false;
        }

        

        
        private void clearTxt(){
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
        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void HastaEkle_Load_1(object sender, EventArgs e)
        {
            comboBox_cins.SelectedIndex = 0;
            comboBox_guven.SelectedIndex = 0;
            comboBox_medeni.SelectedIndex = 0;
        }

        private void HastaEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            goster.Show();
            this.Hide();
        }
    }
}
