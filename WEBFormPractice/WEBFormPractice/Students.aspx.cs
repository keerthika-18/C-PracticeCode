using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace WEBFormPractice
{
    public partial class Students : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDBConnection"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                string query=@"select StId,Name from Student";
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDBConnection"].ConnectionString;
            int id;
      
            if (!int.TryParse(Text1.Text,out id))
            {
                Text1.Text = "Please enter a valid ID";
                return;
            }
            using (SqlConnection con = new SqlConnection(cs)) {

                string query = @"Select g.Tam ,g.Eng,g.Sci, g.Soc ,g.Math from Grade as g where g.StId=@StID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StID", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int total = Convert.ToInt32(dr["Tam"]) + Convert.ToInt32(dr["Eng"]) + Convert.ToInt32(dr["Soc"]) + Convert.ToInt32(dr["Sci"]) + Convert.ToInt32(dr["Math"]);
                    Label1.Text = total.ToString();
                    //total_value = total;
                }
                else
                {
                    Label1.Text = "No id is Present";
                }


            }

        }

    

        protected void Button2_Click(object sender, EventArgs e)
        {
            int total_value = 0;
            string cs = ConfigurationManager.ConnectionStrings["StudentDBConnection"].ConnectionString;
            int id;
            if (!int.TryParse(Text1.Text, out id))
            {
                Text1.Text = "Please enter a valid ID";
                return;
            }
            using (SqlConnection con = new SqlConnection(cs))
            {

                string query = @"Select g.Tam ,g.Eng,g.Sci, g.Soc ,g.Math from Grade as g where g.StId=@StID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StID", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int total = Convert.ToInt32(dr["Tam"]) + Convert.ToInt32(dr["Eng"]) + Convert.ToInt32(dr["Soc"]) + Convert.ToInt32(dr["Sci"]) + Convert.ToInt32(dr["Math"]);
                    Label1.Text = total.ToString();
                    total_value = total;
                }
                else
                {
                    Label1.Text = "No id is Present";
                }


            }

            if (total_value > 90)
            {
                
                Label2.Text = "A";
            }
            else if(total_value>70 && total_value < 80)
            {
                Label2.Text = "B";
            }
            else if(total_value>=60 && total_value <= 70)
            {
                Label2.Text = "C";
            }
            else
            {
                Label2.Text = "D";
            }

        }

        
    }
}