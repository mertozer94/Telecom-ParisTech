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
    public partial class RANDEVUGORHASTA : Form
    {
        public RANDEVUGORHASTA()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();

        private void Gosterbutton_Click(object sender, EventArgs e)
        {
            int not = 0;
            if (TCtextBox.TextLength == 0 || TCtextBox.TextLength != 11)
            {
                KaydeterrorProvider.SetError(Gosterbutton, "Doldurulması zorunlu olan alanları kontrol ediniz.");
                MessageBox.Show("Doldurulması zorunlu olan alanları kontrol ediniz.");
                if (TCtextBox.TextLength == 0)
                {
                    TcKİmerrorProvider.SetError(TCtextBox, "Tc kimlik no boş bırakılamaz!");
                }
                else if (TCtextBox.TextLength != 11)
                {
                    TcKİmerrorProvider.SetError(TCtextBox, "Tc kimlik no 11 haneli olmalı!");
                }


            }
            else
            {
                foreach (İslem d in data.İslems)
                {
                    if (d.Hasta_TC == TCtextBox.Text)
                    {
                        var T = from t in data.GetTable<İslem>() where t.Hasta_TC == TCtextBox.Text select t;
                        dataGridView1.DataSource = T;
                        not = 1;

                    }
                }
                if (not == 0)
                {
                    MessageBox.Show("Bu Tc numarasına ait Hasta kaydı bulunamadı.");
                }
                TcKİmerrorProvider.Clear();
                KaydeterrorProvider.Clear();
                
                foreach (Person d in data.Persons)
                {
                    if (d.TC_kimlik == TCtextBox.Text)
                    {
                        MessageBox.Show("" + d.AdSoyad + " bulundu.");

                    }
                }
                TCtextBox.Clear();
            }

        }      
                
        

            private void TCtextBox_KeyPress(object sender, KeyPressEventArgs e)
            {

                if (char.IsLetter(e.KeyChar))
                    e.Handled = true;

                TcKİmerrorProvider.SetError(TCtextBox, "Tc kimlik no 11 haneli olmalı!");
                if (TCtextBox.TextLength == 10 || TCtextBox.TextLength == 11)
                {
                    TcKİmerrorProvider.Clear();
                }
            }

            private void TCtextBox_KeyPress_1(object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

           
    }
}
