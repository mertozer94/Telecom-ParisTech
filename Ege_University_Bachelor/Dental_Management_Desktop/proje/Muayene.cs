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
    
    public partial class Muayene : Form
    {
        string sifir = "";
        string dort = "";
        public Muayene()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ekle("Kayıt başarıyla eklendi.");

        }
        private bool tcExist(string tc)
        {
            var TE = data.Doctors.SingleOrDefault(c => c.TC_kimlik == tc);
            return (TE != null) ? true : false;
        }
        private bool tchastaExist(string tc)
        {
            var TE = data.Persons.SingleOrDefault(c => c.TC_kimlik == tc);
            return (TE != null) ? true : false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        linqbagDataContext data = new linqbagDataContext();
        private void button_hastaBul_Click(object sender, EventArgs e)
        {
            int not = 0;
            if (textBox_tcno.TextLength == 0 || textBox_tcno.TextLength != 11)
            {
                KaydeterrorProvider.SetError(button_hastaBul, "Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (textBox_tcno.TextLength == 0)
                {
                    tcerror.SetError(textBox_tcno, "Tc kimlik no boş bırakılamaz!");
                }
                else if (textBox_tcno.TextLength != 11)
                {
                    tcerror.SetError(textBox_tcno, "Tc kimlik no 11 haneli olmalı!");
                }


            }
            else
            {
                foreach (Person d in data.Persons)
                {
                    if (d.TC_kimlik == textBox_tcno.Text)
                    {
                        not = 1;
                        MessageBox.Show("Bu Tc numarasına ait.  "+d.AdSoyad + "  seçildi");

                    }
                }

            }
            if (not == 0)
                MessageBox.Show("Bu Tc numarasına ait Hasta bulunamadı.");
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
                foreach (Doctor d in data.Doctors)
                {
                    if (d.TC_kimlik == TCtextBox.Text)
                    {
                        not = 1;
                        MessageBox.Show("Bu Tc numarasına ait.  " + d.AdSoyad + "  seçildi");
                    }
                }

            }
            if (not == 0)
                MessageBox.Show("Bu Tc numarasına ait Doktor bulunamadı.");
        }

        private void monthCalendar_randevuVer_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar_randevuVer.MinDate = monthCalendar_randevuVer.TodayDate;
            linqbagDataContext data = new linqbagDataContext();
            var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar_randevuVer.SelectionRange.Start select t;
            dataGridView2.DataSource = T;

        }

        private void Muayene_Load(object sender, EventArgs e)
        {
            radioButton_genel.Checked = true;
            linqbagDataContext data = new linqbagDataContext();
            var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar1.TodayDate select t;
            dataGridView1.DataSource = T;
            T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar_randevuVer.TodayDate select t;
            dataGridView2.DataSource = T;
            T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar3.TodayDate  select t;
            dataGridView3.DataSource = T;
        }

        private void button_anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
            this.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
                    linqbagDataContext data = new linqbagDataContext();
                    var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar1.SelectionRange.Start select t;                    
                    dataGridView1.DataSource = T;
        }

        private void textBoxSaat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;

            TcKİmerrorProvider.SetError(textBoxSaat, "Saat 2 haneli olmalı ve 00 ile 24 arasinda olmali!");
            if (textBoxSaat.TextLength == 2 && Convert.ToInt32(textBoxDakika.Text) >= 0 && Convert.ToInt32(textBoxDakika.Text) <= 24 )
            {
                TcKİmerrorProvider.Clear();
            }
        }

        private void textBoxDakika_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (char.IsLetter(e.KeyChar))
                e.Handled = true;

                TcKİmerrorProvider.SetError(textBoxDakika, "Saat 2 haneli olmalı ve 00 veya 30 degerinde olmali!");
                if (textBoxDakika.TextLength == 2 && textBoxDakika.Text == "00" && textBoxDakika.Text == "30")
            {
                TcKİmerrorProvider.Clear();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                //get key
                int rowId = Convert.ToInt32(row.Cells[0].Value);

                //avoid updating the last empty row in datagrid
                if (rowId > 0)
                {
                    //delete 
                    Delete(rowId);

                    //refresh datagrid
                    dataGridView3.Rows.RemoveAt(row.Index);
                }
            }
           
        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {

            linqbagDataContext data = new linqbagDataContext();
            var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar3.SelectionRange.Start select t;
            dataGridView3.DataSource = T;
        }


        public void Delete(int rowId)
        {
            var toBeDeleted = data.İslems.First(c => c.RezID == rowId);
            data.İslems.DeleteOnSubmit(toBeDeleted);
            data.SubmitChanges();

        }


        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
                      
            int sayac = Convert.ToInt32(sifir);

            if(sayac != 0)
            {
                //get key

                //avoid updating the last empty row in datagrid
                if (sayac > 0 && dort == textBox_tcno.Text)
                {
                    int sayi = dataGridView2.RowCount;
                    ekle("Basariyla Guncellendi");
                    

                    if (sayi < dataGridView2.RowCount)
                    {
                            //avoid updating the last empty row in datagrid
                        if (sayac > 0)
                            {
                                //delete 

                                Delete(sayac);
                            }
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("Secili kayit ile guncellenecek kayittaki hasta bilgileri uyusmuyor");
                }
            }
        }
         
        public void ekle(string tipi)
        {

            if (textBox_tcno.TextLength == 0 || textBox_tcno.TextLength != 11 || TCtextBox.TextLength == 0 || TCtextBox.TextLength != 11 || textBoxDakika.TextLength == 0 || textBoxDakika.TextLength != 2 || textBoxSaat.TextLength == 0 || textBoxSaat.TextLength != 2)
            {
                KaydeterrorProvider.SetError(button_ekle, "Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (textBox_tcno.TextLength == 0 || TCtextBox.TextLength == 0)
                {
                    TcKİmerrorProvider.SetError(textBox_tcno, "Tc kimlik no boş bırakılamaz!");
                }
                else if (textBox_tcno.TextLength != 11 || TCtextBox.TextLength != 11)
                {
                    TcKİmerrorProvider.SetError(textBox_tcno, "Tc kimlik no 11 haneli olmalı!");
                }

                
            }
            else try
                {
                    string saat = textBoxSaat.Text + "" + textBoxDakika.Text;

                    int flag = 0;
                    foreach (İslem d in data.İslems)
                    {
                        if (d.Doktor_TC == TCtextBox.Text && d.RezTarihi == monthCalendar_randevuVer.SelectionStart.Date && d.Saat == saat)
                        {
                            MessageBox.Show("Doktorun o saatte baska bir randevusu var");
                            flag = 1;
                        }
                        if (d.Hasta_TC == textBox_tcno.Text && d.RezTarihi == monthCalendar_randevuVer.SelectionStart.Date && d.Saat == saat)
                        {
                            MessageBox.Show("Hastanin  o saatte baska bir randevusu var");
                            flag = 1;
                        }
                    }

                    if (flag == 0)
                    {
                        string tip;
                        if (tchastaExist(textBox_tcno.Text) && tcExist(TCtextBox.Text))
                        {
                            İslem islem = new İslem();
                            islem.Doktor_TC = TCtextBox.Text;
                            islem.Hasta_TC = textBox_tcno.Text;

                            islem.Saat = textBoxSaat.Text + "" + textBoxDakika.Text;
                            if (radioButton_genel.Checked == true)
                                tip = "Genel";
                            else if (radioButton_beyazlatma.Checked == true)
                                tip = "Diş Beyazlatma";
                            else if (radioButton_kontrol.Checked == true)
                                tip = "Kontrol";
                            else
                                tip = "Ameliyat";
                            islem.MuayaneTur = tip;

                            islem.RezTarihi = monthCalendar_randevuVer.SelectionStart.Date;


                            data.İslems.InsertOnSubmit(islem);
                            data.SubmitChanges();
                            textBox_tcno.Clear();
                            TCtextBox.Clear();
                            textBoxSaat.Clear();
                            textBoxDakika.Clear();
                            KaydeterrorProvider.Clear();

                            var T = from t in data.GetTable<İslem>() where t.RezTarihi == monthCalendar_randevuVer.SelectionRange.Start select t;
                            dataGridView2.DataSource = T;
                            MessageBox.Show(tipi);


                            
                        }
                        
                    }
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void monthCalendar_randevuVer_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        public DataGridViewCell row { get; set; }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.CurrentCell != null)
            {
                row = dataGridView2.CurrentCell;
                sifir = row.OwningRow.Cells[0].Value.ToString();
                MessageBox.Show("Guncellenecek kayit secildi.");
                dort = row.OwningRow.Cells[4].Value.ToString();
            }

        }

        private void Muayene_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa goster = new AnaSayfa();
            goster.Show();
        }

        


    }

 

}
