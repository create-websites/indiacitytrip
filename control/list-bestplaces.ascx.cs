using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

    public partial class tour : System.Web.UI.UserControl
    {

     
        protected string country = Global.Country.ToString();
        protected string state = Global.State.ToString();
        protected string festival = Global.Festival.ToString();
        protected string category = Global.Category.ToString();
        protected int year;
        protected int count = 5;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt;

            Places.GetVariables();
            dt = Places.GetData(Global.Continent, Global.Country, Global.State, Global.StateName, Global.City, Global.Category, Global.SubCategory, count, 1);

            if (dt.Rows.Count > 0)
            {

                RepDetails.DataSource = dt;
                RepDetails.DataBind();

                /*string val;
                val = DateTime.Now.ToShortTimeString();*/






            }
          
        }


      

        

     

    }