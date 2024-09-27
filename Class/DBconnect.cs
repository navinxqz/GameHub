using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using GameServer_Management.Forms;

namespace GameServer_Management.Class
{
    public class DBconnect
    {
        public static readonly string cs = @"Data Source=NAVINNAWSHIN\SQLEXPRESS;Initial Catalog=GameServerDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }

        public static bool IsValidAdmin(string username, string password)
        {
            bool isValid = false;
            string query = @"select username, upass from admintbl where username = @username and upass = @password";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                isValid = true;
                                USER = dt.Rows[0]["username"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error! {ex.Message}"); }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
            }
            return isValid;
        }

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            string query = @"select username, upass from usertbl where username = @username and upass = @password";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                isValid = true;
                                USER = dt.Rows[0]["username"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error! {ex.Message}"); }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
            }
            return isValid;
        }

        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        //reuseable method for insert update & delete operation
        public static int SQL(string query, Hashtable h)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (DictionaryEntry item in h)
                        {
                            cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                        }
                        //if(con.State == ConnectionState.Closed) { con.Open(); }
                        result = cmd.ExecuteNonQuery();
                        //if (con.State == ConnectionState.Open) { con.Close(); }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error! {ex.Message}"); }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
            }
            return result;
        }

        //load Data
        public static void LoadData(string query, DataGridView g,ListBox l)
        {
            g.CellFormatting += new DataGridViewCellFormattingEventHandler(g_CellFormatting);
            using (SqlConnection con = new SqlConnection(cs)) 
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        //cmd.CommandType = CommandType.Text;
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (l.Items.Count != dt.Columns.Count)
                            {
                                MessageBox.Show("Column count does not match with the ListBox items.");
                                return;
                            }
                            for (int i = 0; i < l.Items.Count; i++)
                            {
                                if (l.Items[i] is DataGridViewColumn col)
                                {
                                    string colName = col.Name;
                                    g.Columns[colName].DataPropertyName = dt.Columns[i].ColumnName;
                                }
                                else
                                {
                                    MessageBox.Show($"Item at index {i} is not a DataGridViewColumn.");
                                    return;
                                }
                            }
                            g.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error loading data! {ex.Message}"); }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
            }
        }
        private static void g_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView g = (DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in g.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBg(Form f)
        {
            Form Bg = new Form();
            using (f)
            {
                Bg.StartPosition = FormStartPosition.Manual;
                Bg.FormBorderStyle = FormBorderStyle.None;
                Bg.Opacity = 0.5d;
                Bg.BackColor = Color.Black;
                Bg.Size = AdminPanel.Instance(true).Size;
                Bg.Location = AdminPanel.Instance(true).Location;
                Bg.ShowInTaskbar = false;
                Bg.Show();
                f.Owner = Bg;
                f.ShowDialog(Bg);
                Bg.Dispose();
            }
        }
        public static void CBFill(string query,Krypton.Toolkit.KryptonComboBox cb) 
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        //cmd.CommandType = CommandType.Text;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cb.DisplayMember = "name";
                            cb.ValueMember = "id";
                            cb.DataSource = dt;
                            cb.SelectedIndex = -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
            }
        }
    }
}
