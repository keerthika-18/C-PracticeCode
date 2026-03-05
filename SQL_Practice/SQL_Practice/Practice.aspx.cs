using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace SQL_Practice
{
    public partial class Practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }

        }

        protected void LoadProducts()
        {
            //try
            //{
            //    using (SqlConnection con = new DataAccess.DbHelper().GetConnection())
            //    {
            //        string query = "SELECT * FROM Product_Price";
            //        SqlDataAdapter da = new SqlDataAdapter(query, con);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);

            //        GridView1.DataSource = dt;
            //        GridView1.DataBind();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message);
            //}

            //string query = "SELECT * FROM Product_Price Where ProductId=@pid";
            //using (SqlConnection con = new DataAccess.DbHelper().GetConnection())
            //{
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@pid", 1);
            //    con.Open();
            //    using(SqlDataReader dr = cmd.ExecuteReader()) { 
            //         dt.Load(dr);
            //    }

            //}
            //using (SqlConnection con = new DataAccess.DbHelper().GetConnection())
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("GetProductById", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Productid", 1);
            //    using (SqlDataReader dr = cmd.ExecuteReader()) {
            //        dt.Load(dr);
            //    }
            //}
            //using (SqlConnection con = new DataAccess.DbHelper().GetConnection()) { 
            //   con.Open();
            //    SqlCommand cmd = new SqlCommand("GetTotalCount", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlParameter sqlP = new SqlParameter("@TotalCount", SqlDbType.Int);
            //    sqlP.Direction  = ParameterDirection.Output;
            //    cmd.Parameters.Add(sqlP);
            //    cmd.ExecuteNonQuery();
            //    int count = (int) cmd.Parameters["@TotalCount"].Value;
            //    Response.Write("Total Products: " + count);
            //}
            //using(SqlConnection con =new DataAccess.DbHelper().GetConnection())
            //{
            //    con.Open();
            //    string query = "Select ProductID,Price,Quantity,Product_name from Product_Price";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    using (SqlDataReader rdr = cmd.ExecuteReader())
            //    {
            //        dt.Columns.Add("ProductID", typeof(int));
            //        dt.Columns.Add("Price", typeof(decimal));
            //        dt.Columns.Add("Quantity", typeof(int));
            //        dt.Columns.Add("Product_name", typeof(string));
            //        dt.Columns.Add("Discount", typeof(decimal));
            //        while (rdr.Read()) {
            //            DataRow datarow = dt.NewRow();
            //            decimal OG = Convert.ToDecimal(rdr["Price"]);
            //            decimal discount = OG * 0.9m;

            //            datarow["ProductID"] = rdr["ProductID"];
            //            datarow["Price"] = OG;
            //            datarow["Quantity"] = rdr["Quantity"];
            //            datarow["Product_name"] = rdr["Product_name"];
            //            datarow["Discount"] = discount;
            //            dt.Rows.Add(datarow);
            //        }

            //        GridView1.DataSource = dt;
            //        GridView1.DataBind();
            //    } 
            //}
            DataTable dt = new DataTable();
            using (SqlConnection con = new DataAccess.DbHelper().GetConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select ProductID,Price,Quantity,Product_name from Product_Price", con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                da.Fill(dt);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                dt.Rows[0]["Price"] = 300.0;
                da.Update(dt);
                Response.Write("UPDATED");

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }


    }
}