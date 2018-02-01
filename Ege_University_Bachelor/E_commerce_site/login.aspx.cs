using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // postback yaz
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
        @"Data Source=DESKTOP-1CBJKUC\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        conn.Open();
    }
    protected void girisYap_OnClick(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString =
        @"Data Source=DESKTOP-1CBJKUC\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        conn.Open();
        string userMail = TextBox1.Text.ToString();
        string userPassword = TextBox2.Text.ToString();
        string sql = "Select count(*) from eczaneBilgi where email = '" + userMail + "' and sifre = '" + userPassword + "'";
        SqlCommand command = new SqlCommand(sql, conn);
        int userId = Convert.ToInt32(command.ExecuteScalar());
        switch (userId)
        {
            case 0: //-1 olacak sonra
                Label1.Text = "Username and/or password is incorrect.";
                break;
            case -2:
                Label1.Text = "Account has not been activated.";
                break;
            case 1:
                FormsAuthentication.SetAuthCookie(userMail, true);
                Response.Redirect("index.aspx");
                break;
        }


    }
}
        /*
        CREATE PROCEDURE [dbo].[Validate_User]
      @Username NVARCHAR(20),
      @Password NVARCHAR(20)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @UserId INT, @LastLoginDate DATETIME
     
      SELECT @UserId = UserId, @LastLoginDate = LastLoginDate
      FROM Users WHERE Username = @Username AND [Password] = @Password
     
      IF @UserId IS NOT NULL
      BEGIN
            IF NOT EXISTS(SELECT UserId FROM UserActivation WHERE UserId = @UserId)
            BEGIN
                  UPDATE Users
                  SET LastLoginDate = GETDATE()
                  WHERE UserId = @UserId
                  SELECT @UserId [UserId] -- User Valid
            END
            ELSE
            BEGIN
                  SELECT -2 -- User not activated.
            END
      END
      ELSE
      BEGIN
            SELECT -1 -- User invalid.
      END
END
        */

