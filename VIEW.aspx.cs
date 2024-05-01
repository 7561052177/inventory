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
    public partial class VIEW : System.Web.UI.Page
    {
        ConnectionClass OBJ = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                string str = "select * from PRODUCT";
                DataSet DS = OBJ.fn_dataset(str);
                GridView1.DataSource = DS;
                GridView1.DataBind();
            }
           
        }

       
    }
}