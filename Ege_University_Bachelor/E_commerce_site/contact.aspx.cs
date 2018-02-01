using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void mailAt(string mailAdres, string uyeAdi, string konu,string yazi)   // error kontrolu eklenecek. gmail sikinti cikardi
    {

        MailMessage o = new MailMessage("eczaneodev@hotmail.com", "mertozer94@gmail.com", konu + "\n gonderen: "+mailAdres, yazi );
        NetworkCredential netCred = new NetworkCredential("eczaneodev@hotmail.com", "Odevden100aldik");
        SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
        smtpobj.EnableSsl = true;
        smtpobj.Credentials = netCred;
        smtpobj.Send(o);
    }
    protected void mesajGonder_OnClick(object sender, EventArgs e)
    {
        mailAt(TextBox4.Text.ToString(), adSoyad.Text.ToString(), TextBox5.Text.ToString(), TextBox3.Text.ToString());
    }


    protected void adSoyad_TextChanged(object sender, EventArgs e)
    {

    }
}