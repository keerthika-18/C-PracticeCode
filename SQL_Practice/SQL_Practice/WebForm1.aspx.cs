//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using.Data.SqlClient;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace SQL_Practice
//{
//    public partial class Accounts : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                GetData();
//            }
//        }
//        private void GetData()
//        {
//            string cs = ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
//            using (SqlConnection con = new SqlConnection(cs))
//            {
//                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", con);
//                con.Open();
//                SqlDataReader dr = cmd.ExecuteReader();
//                while (dr.Read())
//                {
//                    if (dr["AC"].ToString() == "A1")
//                    {
//                        lblAccountNumber1.Text = dr["AC"].ToString();
//                        lblName1.Text = dr["CustomerName"].ToString();
//                        lblBalance1.Text = dr["Balance"].ToString();


//                    }
//                    else if (dr["AC"].ToString() == "A2")
//                    {
//                        lblAccountNumber2.Text = dr["AC"].ToString();
//                        lblName2.Text = dr["CustomerName"].ToString();
//                        lblBalance2.Text = dr["Balance"].ToString();
//                    }
//                }
//            }
//        }
//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            Response.Redirect("Practice.aspx");
//        }
//    }
//}