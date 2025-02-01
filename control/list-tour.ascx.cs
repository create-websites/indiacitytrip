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
            GetVariables();
            GetData();
           

          
        }


        private void GetVariables()
        {


            DateTime moment = DateTime.Now;


            // Year gets 1999. 
            year = moment.Year;

            // Month gets 1 (January). 
            int month = moment.Month;

            // Day gets 13. 
            int day = moment.Day;

            // Hour gets 3. 
            int hour = moment.Hour;

            // Minute gets 57. 
            int minute = moment.Minute;

            // Second gets 32. 
            int second = moment.Second;

            // Millisecond gets 11. 
            int millisecond = moment.Millisecond;

          

            if (Request.QueryString["country"] != null)
            {
                country = Request.QueryString["country"];

            }

        

            if (Request.QueryString["year"] != null)
            {
                year = Convert.ToInt16(Request.QueryString["year"]);

            }

            if (Request.QueryString["category"] != null)
            {
                category = Request.QueryString["category"];

            }

            if (Request.QueryString["count"] != null)
            {
                count = Convert.ToInt16(Request.QueryString["count"]);
            }

            if (Request.QueryString["country"] != null)
            {
                country = Request.QueryString["country"];
            }

            if (Request.QueryString["state"] != null)
            {
                state = Request.QueryString["state"];
            }

        }
        private void GetData()
        {


            string sp = "tourist_package_search";


            string connect = ConfigurationManager.ConnectionStrings["films"].ConnectionString;


            using (SqlConnection conn = new SqlConnection(connect))
            {

                using (SqlCommand cmd = new SqlCommand(sp, conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@region", state);
                  

                    cmd.Parameters.AddWithValue("@n", count);
                    cmd.Parameters.AddWithValue("@SortOrder", 1);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);


                    
                            


                    DataSet ds = new DataSet();

                    da.Fill(ds);


                    DataTable dt = ds.Tables[0];



                    if (dt.Rows.Count > 0)
                    {

                        RepDetails.DataSource = dt;
                        RepDetails.DataBind();

                        /*string val;
                        val = DateTime.Now.ToShortTimeString();*/





                       
                    }



                }




            }
        }

        

     

    }