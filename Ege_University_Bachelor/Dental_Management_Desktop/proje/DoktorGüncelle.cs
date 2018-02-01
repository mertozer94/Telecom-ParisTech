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
    public partial class DoktorGüncelle : Form
    {
        public DoktorGüncelle()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();
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
                foreach (Doctor d in data.Doctors)
                {
                    if (d.TC_kimlik == TCtextBox.Text)
                    {
                        not = 1;
                        TckimliktextBox.Text = d.TC_kimlik;
                        AdSoyadtextBox.Text = d.AdSoyad;
                        SiciltextBox.Text = d.SicilNo;
                        CepTEltextBox.Text = d.Ceptel;
                        EvTeltextBox.Text = d.Evtel;
                        if (d.Cinsiyet == true)
                        { ErkekradioButton.Checked = true; }
                        else { KadınradioButton.Checked = false; }
                        iltextBox.Text = d.il;
                        ilçetextBox.Text = d.ilce;
                        AdrestextBox.Text = d.Adres;
                        emailtextBox.Text = d.Email;

                    }
                }
                //TCtextBox.Clear();
                if (not == 0)
                    MessageBox.Show("Bu Tc numarasına ait Doktor bulunamadı.");
            }
            
        }

        private void Kaydetbutton_Click(object sender, EventArgs e)
        {
            if (AdSoyadtextBox.Text == "")
            {
                MessageBox.Show("AdSoyad BOŞ BIRAKILAMAZ !");
            }
            else
            {
                try
                {


                    Doctor doktor = data.Doctors.SingleOrDefault(c => c.TC_kimlik == TCtextBox.Text);
                    doktor.TC_kimlik = TckimliktextBox.Text;
                    doktor.AdSoyad = AdSoyadtextBox.Text;
                    doktor.SicilNo = SiciltextBox.Text;
                    doktor.Ceptel = CepTEltextBox.Text;
                    doktor.Evtel = EvTeltextBox.Text;
                    if (ErkekradioButton.Checked == true)
                        doktor.Cinsiyet = true;
                    else
                        doktor.Cinsiyet = false;
                    doktor.il = iltextBox.Text;
                    doktor.ilce = ilçetextBox.Text;
                    doktor.Adres = AdrestextBox.Text;
                    doktor.Email = emailtextBox.Text;

                    data.SubmitChanges();



                    KaydeterrorProvider.Clear();
                    MessageBox.Show("Kayıt başarıyla güncellendi.");

                    clearTxt();



                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void AdSoyadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (AdSoyadtextBox.Text == "")
            {
                AdSoyaderrorProvider.SetError(AdSoyadtextBox, "Ad Soyad boş bırakılamaz!");
            }
            else
            {
                AdSoyaderrorProvider.Clear();
            }
        }
        private void clearTxt()
        {
            TckimliktextBox.Clear();
            AdrestextBox.Clear();
            AdSoyadtextBox.Clear();
            CepTEltextBox.Clear();
            EvTeltextBox.Clear();
            emailtextBox.Clear();
            SiciltextBox.Clear();
            ilçetextBox.Clear();
            iltextBox.Clear();
            TCtextBox.Clear();

        }

        private void EvTeltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void CepTEltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void iltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ilçetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Çıkışbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doktorİşlemleri goster = new Doktorİşlemleri();
            goster.Show();
        }

        private void DoktorGüncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Doktorİşlemleri goster = new Doktorİşlemleri();
            goster.Show();
        }
    }
}
