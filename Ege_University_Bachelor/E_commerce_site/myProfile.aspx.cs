using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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

            arama.CommandText = "SELECT * FROM Product ";
           // arama.CommandText = "INSERT INTO Product VALUES(5, 'Name', 'desc', 5, 3, 6, 1000, 1050, 1, 0, 'tru1e', 1, 'true') ";
            conn.Open();

            arama.ExecuteNonQuery();
            conn.Close();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
        @"Data Source=DESKTOP-1CBJKUC\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            // arama.CommandText = "INSERT INTO Product VALUES(5, 'Name', 'desc', 5, 3, 6, 1000, 1050, 1, 0, 'tru1e', 1, 'true') ";

            cmd.CommandText = "INSERT INTO [Product] VALUES(@ProductID, @ProductName,@ProductDescription, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @MSRP, @UnitsInStock, @ProductAvailable, @Picture, @Ranking, @Note)";
            cmd.Parameters.AddWithValue("@ProductID", int.Parse( TextBox1.Text));
            cmd.Parameters.AddWithValue("@ProductName", TextBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@ProductDescription", TextBox3.Text);
            cmd.Parameters.AddWithValue("@SupplierID", 1);
            cmd.Parameters.AddWithValue("@CategoryID", 4);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", 1);
             cmd.Parameters.AddWithValue("@UnitPrice", string.Format("{0:#.00}", Convert.ToDecimal(TextBox4.Text) / 100));
            cmd.Parameters.AddWithValue("@MSRP", string.Format("{0:#.00}", Convert.ToDecimal(TextBox4.Text) / 100));
            cmd.Parameters.AddWithValue("@UnitsInStock", TextBox5.Text);
            cmd.Parameters.AddWithValue("@ProductAvailable", 1);
            cmd.Parameters.AddWithValue("@Picture", "uzanti");
            cmd.Parameters.AddWithValue("@Ranking", 1);
            cmd.Parameters.AddWithValue("@Note", "uzanti");
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("myProfile.aspx");

        }
    }
}
    



