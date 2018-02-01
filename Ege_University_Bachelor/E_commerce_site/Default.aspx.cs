using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void UpdateButton_Click(object sender, EventArgs e)
    {
        DateTimeLabel1.Text = DateTime.Now.ToString();

        net.kowabunga.currencyconverter.Converter servis = new net.kowabunga.currencyconverter.Converter();
        DateTime date1 = DateTime.Now;
        decimal miktar = decimal.Parse(TextBox1.Text.ToString());

        Label1.Text = "Tarihi ve saatindeki TRY karsiligi  " + servis.GetConversionAmount("TRY", "EUR", date1, miktar).ToString().Substring(0, 7) + "TRY";
        


    }
  
}
