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
    public partial class PRODUCT : System.Web.UI.Page
    {
        ConnectionClass OBJ = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/phs.webp/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string str = "insert into PRODUCT values( '" + TextBox1.Text + "',  '" + p + "', '" +
           TextBox3.Text + "',)";
            int j = OBJ.fn_nonquery(str);
            if (j == 1)

            {
                Label1.Visible = true;
                Label1.Text = "inserted";
            }
        }

      
    }
}