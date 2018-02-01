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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled=true;

            TcKİmerrorProvider.SetError(TckimliktextBox, "Tc kimlik no 11 haneli olmalı!");
            if (TckimliktextBox.TextLength == 10 || TckimliktextBox.TextLength == 11)
            {
                TcKİmerrorProvider.Clear();
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

        private void Çıkışbutton_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            Doktorİşlemleri göster = new Doktorİşlemleri();
            göster.Show();
            
        }
        linqbagDataContext data = new linqbagDataContext();
        private void Kaydetbutton_Click(object sender, EventArgs e)
        {
            if (TckimliktextBox.TextLength == 0 || TckimliktextBox.TextLength != 11 || AdSoyadtextBox.Text == "" )
            {
                KaydeterrorProvider.SetError(Kaydetbutton,"Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (TckimliktextBox.TextLength == 0)
                {
                    TcKİmerrorProvider.SetError(TckimliktextBox, "Tc kimlik no boş bırakılamaz!");
                }
                else if (TckimliktextBox.TextLength != 11)
                {
                    TcKİmerrorProvider.SetError(TckimliktextBox, "Tc kimlik no 11 haneli olmalı!");
                }
                if (AdSoyadtextBox.Text == "")
                {
                    AdSoyaderrorProvider.SetError(AdSoyadtextBox, "Ad Soyad boş bırakılamaz!");
                }

            }
            else try
                {
                    if (!tcExist(TckimliktextBox.Text))
                    {
                        
                        Doctor doktor = new Doctor();
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
                        data.Doctors.InsertOnSubmit(doktor);
                        data.SubmitChanges();
                        


                        KaydeterrorProvider.Clear();
                        MessageBox.Show("Kayıt başarıyla eklendi.");

                        clearTxt();


                    }
                    else
                    {
                        MessageBox.Show("GİRİLEN TC_KİMLİK NUMARASINA SAHİP DOKTOR VAR.LÜTFEN KONTROL EDİP YENİDEN DENEYİNİZ.");
                        clearTxt();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private bool tcExist(string tc)
        {
            var TE = data.Doctors.SingleOrDefault(c => c.TC_kimlik == tc);
            return (TE != null) ? true : false;
        }

        private void clearTxt(){
            TckimliktextBox.Clear();
            AdSoyadtextBox.Clear();
            SiciltextBox.Clear();
            CepTEltextBox.Clear();
            EvTeltextBox.Clear();
            ilçetextBox.Clear();
            iltextBox.Clear();
            AdrestextBox.Clear();
            emailtextBox.Clear();
        
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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ilçetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            ErkekradioButton.Checked = true;
        }

        private void DoktorEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Doktorİşlemleri göster = new Doktorİşlemleri();
            göster.Show();
        }

   



      

    
        
    }
}
