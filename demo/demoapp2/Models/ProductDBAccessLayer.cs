using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using demoapp2.Models;

namespace demoapp2.Models
{
    public class ProductDBAccessLayer
    {
        
        

        public string AddProductRecord(ProductEntities productEntities)
        {

            SqlConnection connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MusicStoreDatabase;Trusted_Connection=True;");

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Product_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", productEntities.ProductName);
                cmd.Parameters.AddWithValue("@Price", productEntities.Price);
                cmd.Parameters.AddWithValue("@PictureData", productEntities.PictureData);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }     
}
