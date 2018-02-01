using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class category_grid_2 : System.Web.UI.Page
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

            arama.CommandText = "SELECT * FROM [Product] WHERE CategoryID = " + Request.QueryString["CategoryID"];

            conn.Open();

            arama.ExecuteNonQuery();
            conn.Close();
            var products = new List<Product>();
            SqlDataAdapter da = new SqlDataAdapter(arama);
            DataTable dt = new DataTable();

            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                products.Add(new Product()
                {
                    ProductID = int.Parse(dt.Rows[i][0].ToString()),
                    Name = dt.Rows[i][1].ToString(),
                    Supplier = dt.Rows[i][3].ToString(),
                    Price = double.Parse(dt.Rows[i][6].ToString())



                });
            }
            Repeater1.DataSource = products;
            Repeater1.DataBind();
        }
    }
    
}