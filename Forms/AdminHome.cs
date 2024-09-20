using GameServer_Management.Class;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            //AddCat();
        }
        private void AddCat()
        {
            string query = "Select * from categorytbl";
            using (SqlConnection con = DBconnect.GetConnection())
            {
                if (con == null)
                {
                    MessageBox.Show("Database connection is not established.");
                    return;
                }
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        CategoryPanel.Controls.Clear();

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["catName"] == DBNull.Value || row["catName"] == null)
                                {
                                    MessageBox.Show("catName column is missing or has null value.");
                                    continue;
                                }

                                KryptonCheckButton b = new KryptonCheckButton();
                                b.ButtonStyle = ButtonStyle.LowProfile;
                                b.Cursor = Cursors.Hand;
                                b.Size = new Size(263, 53);
                                b.Text = row["catName"].ToString();

                                b.OverrideDefault.Back.Color1 = Color.FromArgb(23, 23, 26);
                                b.OverrideDefault.Back.Color2 = Color.FromArgb(23, 23, 26);

                                b.StateCheckedNormal.Back.Color1 = Color.FromArgb(60, 115, 120, 255);
                                b.StateCheckedNormal.Back.Color2 = Color.FromArgb(60, 115, 120, 255);
                                b.StateCheckedNormal.Border.Color1 = Color.Transparent;
                                b.StateCheckedNormal.Border.Color2 = Color.Transparent;
                                b.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StateCheckedNormal.Content.AdjacentGap = 20;
                                b.StateCheckedNormal.Content.ShortText.Color1 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedNormal.Content.ShortText.Color2 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedNormal.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StateCheckedNormal.Content.ShortText.Font = new Font(b.StateCheckedNormal.Content.ShortText.Font.FontFamily, 16);
                                b.StateCheckedNormal.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StateCheckedNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StateCheckedNormal.Content.ShortText.Trim = PaletteTextTrim.Character;

                                b.StateCheckedPressed.Back.Color1 = Color.FromArgb(60, 115, 120, 255);
                                b.StateCheckedPressed.Back.Color2 = Color.FromArgb(60, 115, 120, 255);
                                b.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StateCheckedPressed.Border.Color1 = Color.Transparent;
                                b.StateCheckedPressed.Border.Color2 = Color.Transparent;
                                b.StateCheckedPressed.Content.AdjacentGap = 20;
                                b.StateCheckedPressed.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StateCheckedPressed.Content.ShortText.Color1 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedPressed.Content.ShortText.Color2 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedPressed.Content.ShortText.Font = new Font(b.StateCheckedPressed.Content.ShortText.Font.FontFamily, 16);
                                b.StateCheckedPressed.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StateCheckedPressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StateCheckedPressed.Content.ShortText.Trim = PaletteTextTrim.Word;

                                b.StateCheckedTracking.Back.Color1 = Color.FromArgb(40, 115, 120, 255);
                                b.StateCheckedTracking.Back.Color2 = Color.FromArgb(40, 115, 120, 255);
                                b.StateCheckedTracking.Border.Color1 = Color.Transparent;
                                b.StateCheckedTracking.Border.Color2 = Color.Transparent;
                                b.StateCheckedTracking.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StateCheckedTracking.Content.AdjacentGap = 20;
                                b.StateCheckedTracking.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StateCheckedTracking.Content.ShortText.Color1 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedTracking.Content.ShortText.Color2 = Color.FromArgb(115, 120, 255);
                                b.StateCheckedTracking.Content.ShortText.Font = new Font(b.StateCheckedTracking.Content.ShortText.Font.FontFamily, 16);
                                b.StateCheckedTracking.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StateCheckedTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StateCheckedTracking.Content.ShortText.Trim = PaletteTextTrim.Word;

                                b.StateNormal.Back.Color1 = Color.FromArgb(23, 23, 26);
                                b.StateNormal.Back.Color2 = Color.FromArgb(23, 23, 26);
                                b.StateNormal.Border.Color1 = Color.Transparent;
                                b.StateNormal.Border.Color2 = Color.Transparent;
                                b.StateNormal.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StateNormal.Content.AdjacentGap = 20;
                                b.StateNormal.Content.ShortText.Color1 = Color.White;
                                b.StateNormal.Content.ShortText.Color2 = Color.White;
                                b.StateNormal.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StateNormal.Content.ShortText.Font = new Font(b.StateCheckedTracking.Content.ShortText.Font.FontFamily, 16);
                                b.StateNormal.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StateNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StateNormal.Content.ShortText.Trim = PaletteTextTrim.Word;

                                b.StatePressed.Back.Color1 = Color.FromArgb(60, 115, 120, 255);
                                b.StatePressed.Back.Color2 = Color.FromArgb(60, 115, 120, 255);
                                b.StatePressed.Border.Color1 = Color.Transparent;
                                b.StatePressed.Border.Color2 = Color.Transparent;
                                b.StatePressed.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StatePressed.Content.AdjacentGap = 20;
                                b.StatePressed.Content.ShortText.Color1 = Color.FromArgb(115, 120, 255);
                                b.StatePressed.Content.ShortText.Color2 = Color.FromArgb(115, 120, 255);
                                b.StatePressed.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StatePressed.Content.ShortText.Font = new Font(b.StateCheckedTracking.Content.ShortText.Font.FontFamily, 16);
                                b.StatePressed.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StatePressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StatePressed.Content.ShortText.Trim = PaletteTextTrim.Word;

                                b.StateTracking.Back.Color1 = Color.DimGray;
                                b.StateTracking.Back.Color2 = Color.DimGray;
                                b.StateTracking.Border.Color1 = Color.Transparent;
                                b.StateTracking.Border.Color2 = Color.Transparent;
                                b.StateTracking.Back.ColorStyle = PaletteColorStyle.Solid;
                                b.StateTracking.Content.AdjacentGap = 20;
                                b.StateTracking.Content.ShortText.Color1 = Color.White;
                                b.StateTracking.Content.ShortText.Color2 = Color.White;
                                b.StateTracking.Content.Padding = new Padding(19, -1, 0, -1);
                                b.StateTracking.Content.ShortText.Font = new Font(b.StateCheckedTracking.Content.ShortText.Font.FontFamily, 16);
                                b.StateTracking.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                                b.StateTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
                                b.StateTracking.Content.ShortText.Trim = PaletteTextTrim.Word;

                                CategoryPanel.Controls.Add(b);
                            }
                        }
                    }
                }catch (Exception ex) { MessageBox.Show($"Error! {ex.Message}"); }
                /*finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }   */
            }
                
            //SqlCommand cmd = new SqlCommand(query,DBconnect.con);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
