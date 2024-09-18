using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GameServer_Management.Class
{
    public class DBconnect
    {
        public static readonly string cs = @"Data Source=NAVINNAWSHIN\SQLEXPRESS;Initial Catalog=GameServerDB;Integrated Security=True";

        public static bool IsValidAdmin(string username, string password)
        {
            bool isValid = false;
            string query = @"select * from admintbl where username = @username and upass = @password";
            using(SqlConnection con =  new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if(dt.Rows.Count > 0)
                            {
                                isValid = true;
                                USER = dt.Rows[0]["username"].ToString();
                            }
                        }
                    }
                }catch (Exception ex) { Console.WriteLine($"Error! {ex.Message}"); }
                finally
                {
                    if(con.State == ConnectionState.Open) { con.Close(); }
                }
            }return isValid;
        }
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}
