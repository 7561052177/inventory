using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AA
{
    public partial class EDIT_PRODUCT : System.Web.UI.Page
    {
        ConnectionClass OBJ = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
protected void Button1_Click(object sender, EventArgs e)
        {
         
            SqlCommand cmm = new SqlCommand("update PRODUCT set NAME=@PRODUCTNAME,IMAGE=@IMAGE where PRICE@PRICE");
            cmm.Parameters.AddWithValue("@PRODUCTNAME", int.Parse(TextBox1.Text));
            cmm.Parameters.AddWithValue("PRICE", TextBox2.Text);
            cmm.Parameters.AddWithValue("IMAGE", FileUpload1);
            cmm.ExecuteNonQuery();
         
            Label1.Visible = true;
            Label1.Text = "successfully updated";
        }
    }
}