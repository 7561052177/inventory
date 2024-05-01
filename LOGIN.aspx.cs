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
    public partial class LOGIN : System.Web.UI.Page
    {
        ConnectionClass OBJ = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
            protected void Button1_Click(object sender, EventArgs e)
            {
                string str = "select count(REG_ID) from LOGINN where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string cid = OBJ.fn_scalar(str);
                int cid1 = Convert.ToInt32(cid);
                if (cid1 == 1)
                {
                    string str1 = "select REG_ID from LOGINN where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                    int regid = Convert.ToInt32(OBJ.fn_scalar(str1));
                    Session["userid"] = regid;
                    

                }
            }


        }
    }
