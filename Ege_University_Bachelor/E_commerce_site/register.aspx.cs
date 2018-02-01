using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand arama = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
        @"Data Source=DESKTOP-1CBJKUC\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        conn.Open();

        conn.Close();
    }
    protected void KayitOl_OnClick(object sender, EventArgs e)
    {

        //cmd.CommandText = "INSERT eczaneBilgi (adSoyad, eczaneAdı, eczaneAdres, email, telefonNo, sifre) VALUES ('babayaro', 'NorthWestern','adresss','hasan@hotmail.com','2222','333')";

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
        @"Data Source=DESKTOP-1CBJKUC\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        using (SqlCommand cmd = new SqlCommand())
        {
            SqlCommand arama = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            arama.Connection = conn;
            arama.CommandType = CommandType.Text;




            arama.CommandText = "SELECT FROM [eczaneBilgi] WHERE email = " + TextBox4.Text.ToString();
            cmd.CommandText = "INSERT INTO [eczaneBilgi] VALUES(@adSoyad, @eczaneAdı, @eczaneAdres, @email, @telefonNo, @sifre)";
            cmd.Parameters.AddWithValue("@adSoyad", adSoyad.Text.ToString());
            cmd.Parameters.AddWithValue("@eczaneAdı", TextBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@eczaneAdres", TextBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@email", TextBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@telefonNo", telNumber.Text.ToString());
            cmd.Parameters.AddWithValue("@sifre", TextBox6.Text.ToString());
            conn.Open();

            cmd.ExecuteNonQuery();
            mailAt("mertozer94@gmail.com", TextBox4.Text.ToString(), TextBox6.Text.ToString()); // dogrulamadigimiz mail adresi oldugu icin bazen sikinti cikiyor. Eger cikarsa girip guncelleme yapilacak.
            conn.Close();
        }

    }
    protected void mailAt(string mailAdres, string uyeAdi, string sifre)   // error kontrolu eklenecek. gmail sikinti cikardi
    {

        MailMessage o = new MailMessage("eczaneodev@hotmail.com", mailAdres, "E-eczane sitesine basvurunuz hakkinda", "Basvurunuz alinmistir \n Uyelik adiniz :" + uyeAdi + " \n Sifreniz :" + sifre + " Iyi gunler dileriz.");
        NetworkCredential netCred = new NetworkCredential("eczaneodev@hotmail.com", "Odevden100aldik");
        SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
        smtpobj.EnableSsl = true;
        smtpobj.Credentials = netCred;
        smtpobj.Send(o);
    }
}