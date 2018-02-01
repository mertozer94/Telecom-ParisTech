using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class single_product : System.Web.UI.Page
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

            arama.CommandText = "SELECT * FROM [Product] WHERE  ProductID = " + Request.QueryString["id"];

            conn.Open();

            arama.ExecuteNonQuery();
            conn.Close();
            var products = new List<Product>();
            SqlDataAdapter da = new SqlDataAdapter(arama);
            DataTable dt = new DataTable();

            da.Fill(dt);


            products.Add(new Product()
            {
                ProductID = int.Parse(dt.Rows[0][0].ToString()),
                Name = dt.Rows[0][1].ToString(),
                Desc = dt.Rows[0][2].ToString(),
                Supplier = dt.Rows[0][3].ToString(),
                Price = double.Parse(dt.Rows[0][6].ToString()),
                UnitsInStock = int.Parse(dt.Rows[0][8].ToString())

            });

            Repeater1.DataSource = products;
            Repeater1.DataBind();
        }
    }
    protected void satinAL_OnClick(object sender, EventArgs e)
    {
        // <a id="addto-cart" href="single-product.aspx?id=<%#Eval("ProductID")%>" class="le-button huge">Hizli satin al</a>
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

            arama.CommandText = "SELECT * FROM [Product] WHERE  ProductID = " + Request.QueryString["id"];

            conn.Open();

            arama.ExecuteNonQuery();
            conn.Close();
            var products = new List<Product>();
            SqlDataAdapter da = new SqlDataAdapter(arama);
            DataTable dt = new DataTable();

            da.Fill(dt);
            
           
            //int tane = int.Parse(Request.Form.["quantity"].ToString());   // neden kabul olmuyo anlamadim

            int UnitsInStock = int.Parse(dt.Rows[0][8].ToString())-1;
           

            arama.CommandText = "UPDATE [Product] SET UnitsInStock = "+ UnitsInStock+ " WHERE ProductID = "+ Request.QueryString["id"];
            conn.Open();

            arama.ExecuteNonQuery();
            conn.Close();
       
            Response.Redirect("single-product.aspx?id="+ int.Parse(dt.Rows[0][0].ToString()));

        }



    }
}