using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace SQL_Practice
{
    public partial class Accounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }
        private void GetData()
        {
            string cs = ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["AC"].ToString() == "A1")
                    {
                        lblAccountNumber1.Text = dr["AC"].ToString();
                        lblName1.Text = dr["CustomerName"].ToString();
                        lblBalance1.Text = dr["Balance"].ToString();


                    }
                    else if (dr["AC"].ToString() == "A2")
                    {
                        lblAccountNumber2.Text = dr["AC"].ToString();
                        lblName2.Text = dr["CustomerName"].ToString();
                        lblBalance2.Text = dr["Balance"].ToString();
                    }
                }
            }
        }
        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
            try
                {
                    
                    SqlCommand cmd = new SqlCommand("Update Accounts set Balance =Balance-10 where AC='A1';", con,transaction);
              
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update Accounts set Balance =Balance+10 where AC='A2';", con,transaction);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    lblMessage.Text = "Transfer successful";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    GetData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    lblMessage.Text = "Transfer failed: " + ex.Message; 
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            }
    }
}