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
    public partial class HastaSil : Form
    {
        public HastaSil()
        {
            InitializeComponent();
        }

        private void TCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;

            tcerror.SetError(TCtextBox, "Tc kimlik no 11 haneli olmalı!");
            if (TCtextBox.TextLength == 10 || TCtextBox.TextLength == 11)
            {
                tcerror.Clear();
            }
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
                not = 2;

            }
            else
            {
                foreach (Person d in data.Persons)
                {
                    if (d.TC_kimlik == TCtextBox.Text)
                    {
                        not = 1;
                        tckimlbl.Text = d.TC_kimlik;
                        adsoyadlbl.Text = d.AdSoyad;
                        scllbl.Text = d.SGNO;
                        lblcp.Text = d.Ceptel;
                        lblev.Text = d.Evtel;
                        if (d.Cinsiyet == true)
                        { cinslnl.Text = "Erkek"; }
                        else { cinslnl.Text = "Kadın"; }
                        illbl.Text = d.il;
                        ilcelbl.Text = d.ilce;
                        adreslbl.Text = d.Adres;
                        emaillbl.Text = d.Email;
                        lblsosyagüv.Text = d.SosyalGüvence;

                    }
                }

            }
            if (not == 0)
                MessageBox.Show("Bu Tc numarasına ait Hasta bulunamadı.");
        }

        private void Çıkışbutton_Click(object sender, EventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            this.Hide();
            goster.Show();
        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            int not = 0;
            foreach (Person d in data.Persons)
            {
                if (d.TC_kimlik == TCtextBox.Text)
                {
                    not = 1;
                    data.Persons.DeleteOnSubmit(d);
                    data.SubmitChanges();

                }
            }
            if (not == 1)
            {
                lblSil();
                TCtextBox.Clear();
                MessageBox.Show("Kayıt Başarıyla Silindi !");
            }
        }
        private void lblSil()
        {
            tckimlbl.Text = "";
            adreslbl.Text = "";
            adsoyadlbl.Text = "";
            scllbl.Text = "";
            cplbl.Text = "";
            evlbl.Text = "";
            cinslnl.Text = "";
            emaillbl.Text = "";
            illbl.Text = "";
            ilcelbl.Text = "";
            lblcp.Text = "";
            lblev.Text = "";
            lblsosyagüv.Text = "";
        }

        private void hepsibutton_Click(object sender, EventArgs e)
        {
            foreach (Person d in data.Persons)
            {
                data.Persons.DeleteOnSubmit(d);
                data.SubmitChanges();
            }
            MessageBox.Show("Bütün kayıtlar başarıyla silindi.");
        }

        private void vazgecbutton_Click(object sender, EventArgs e)
        {
            lblSil();
        }

        private void HastaSil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hastaİşlemleri goster = new Hastaİşlemleri();
            this.Hide();
            goster.Show();
        }
    }
}
