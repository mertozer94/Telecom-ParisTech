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
    public partial class SEKRETERGİRİS : Form
    {
        public SEKRETERGİRİS()
        {
            InitializeComponent();
        }
        linqbagDataContext data = new linqbagDataContext();
        private void GİRİSbutton_Click(object sender, EventArgs e)
        {
            int not = 0;
            if (adtextBox.Text == ""  )
            {
                MessageBox.Show("Kullanıcı Adı boş bırakılamaz !");
            }
            else if (sfrtextBox.Text == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz !");
            }
            else
            {
                foreach (Kayıt d in data.Kayıts)
                {
                    if (d.K_Adi == adtextBox.Text && d.sifre == sfrtextBox.Text)
                    {
                        AnaSayfa goster = new AnaSayfa();
                        this.Hide();
                        goster.Show();
                        not = 1;
                        this.ParentForm.Hide();
                    }
                }
                if (not == 0) {
                    MessageBox.Show("Kullanıcı Adı ve Şifreyi kontrol ediniz !");
                }
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sfrtextBox.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false) {
                sfrtextBox.UseSystemPasswordChar = true;
            }

        }

        private void SEKRETERGİRİS_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            sfrtextBox.UseSystemPasswordChar = true;
        }

     
    }
}
