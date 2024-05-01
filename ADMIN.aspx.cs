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
    public partial class ADMIN : System.Web.UI.Page
    {
        ConnectionClass OBJ = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                string sel = "select max(REG_ID) from LOGINN";
                string regid = OBJ.fn_scalar(sel);
                int reg_id = 0;
                if (regid == "")
                {
                    reg_id = 1;
                }
                else
                {
                    int newgrid = Convert.ToInt32(regid);
                    reg_id = newgrid + 1;
                }
                string ins = "insert into ADMIN values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                int i = OBJ.fn_nonquery(ins);
                if (i != 0)
                {
                    string inslog = "insert into LOGINN values(" + reg_id + ",'" + TextBox4.Text + "',)";
                    int j = OBJ.fn_nonquery(inslog);
                }
            }

           
        }
    }
}
    