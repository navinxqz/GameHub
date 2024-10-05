using GameServer_Management.Class;
using GameServer_Management.Controller;
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
    public partial class AdminPanel : Form
    {
        private KryptonCheckButton cb = new KryptonCheckButton();
        private GameCatView catView = new GameCatView();
        private GameDB gameDB = new GameDB();
        private AdminHome home = new AdminHome();
        private UserDB userDB = new UserDB();
        private AdminDB adminDB = new AdminDB();
        private Download download = new Download();
        //private SignUp signUp = new SignUp();
        
        private AdminHome adminhome;
        private bool isAdmin;
        private string code;

        public AdminPanel(bool isAdmin)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cb = btnHome;
            cb.Checked = true;

            this.isAdmin = isAdmin;
            adminhome = new AdminHome(this);
        }
        public AdminPanel(bool isAdmin, string username)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            cb = btnHome;
            cb.Checked = true;

            this.isAdmin = isAdmin;
            usertxt.Text = username;
            adminhome = new AdminHome(this);
        }
        public AdminPanel(string code)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            
            this.code = code;
            next();
        }

        private void next()
        {
            //this.Close();
            //getGame.Show();
            //MessageBox.Show("Hello");
            //LoadForm(getGame);
            //getGame.BringToFront();
            //Button(btnHome);
            GetGame getGame = new GetGame();
            mainpanel.Controls.Clear();
            getGame.Dock = DockStyle.Fill;  // Make it fill the panel
            mainpanel.Controls.Add(getGame);
            mainpanel.Refresh();
        }

        static AdminPanel obj;
        public static AdminPanel Instance(bool isAdmin)
        {
            if (obj == null)
            {
                obj = new AdminPanel(isAdmin);
            }
            return obj;
        }
        public void LoadForm(Form f)
        {
            if (f == null)
            {
                MessageBox.Show("The form to load is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            //f.Parent = this;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            //f.Show();
            f.Visible = true;
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void sliderShowTimer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Size.Width < 222)
            {
                int targetWidth = 230;
                int i = 50;

                if (slidePanel.Size.Width + i > targetWidth)
                {
                    i = targetWidth - slidePanel.Size.Width;
                }
                int x = slidePanel.Size.Width + i;  //increment dynamically
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int a = mainpanel.Size.Width - i;
                int b = mainpanel.Size.Height;
                mainpanel.Size = new Size(a, b);

                int lx = mainpanel.Location.X + i;
                int ly = mainpanel.Location.Y;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderShowTimer.Stop();
            }
        }

        private void sliderHideTimer_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Size.Width > 70)
            {
                int targetWidth = 70;
                int i = 50;

                if (slidePanel.Size.Width - i > targetWidth)
                {
                    i = slidePanel.Size.Width - targetWidth;
                }
                int x = slidePanel.Size.Width - i;  //decrement dynamically
                int y = slidePanel.Size.Height;
                slidePanel.Size = new Size(x, y);

                int a = mainpanel.Size.Width + i;
                int b = mainpanel.Size.Height;
                mainpanel.Size = new Size(a, b);

                int ly = mainpanel.Location.Y;
                int lx = mainpanel.Location.X - i;
                mainpanel.Location = new Point(lx, ly);
            }
            else
            {
                sliderHideTimer.Stop();
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            if (!sliderShowTimer.Enabled && !sliderHideTimer.Enabled)
            {
                if (slidePanel.Size.Width == 230)
                {
                    sliderHideTimer.Start();
                }
                else if (slidePanel.Size.Width == 70)
                {
                    sliderShowTimer.Start();
                }
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadForm(home);
            this.Opacity = 0;
            faddingTimer.Start();
            obj = this;
            downloadbtn.Visible = false;
            userpanel.Visible = false;

            if (!isAdmin)
            {
                categoryBtn.Visible = false;
                GameDBbtn.Visible = false;
                adminDBbtn.Visible = false;
                userDBbtn.Visible = false;
                userpanel.Visible = true;
                downloadbtn.Visible = true;
                kryptonPanel1.Location = new Point(0, 318);
                downloadbtn.Location = new Point(3, 62);
            }
        }

        private void faddingTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                faddingTimer.Stop();
            }
        }
        private void Button(KryptonCheckButton button)
        {
            cb.Checked = false;
            cb = button;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!btnHome.Checked)
            {
                btnHome.Checked = true;
                return;
            }
            LoadForm(home);
            Button(btnHome);
        }

        private void userDBbtn_Click(object sender, EventArgs e)
        {
            if (!userDBbtn.Checked)
            {
                userDBbtn.Checked = true;
                return;
            }
            LoadForm(userDB);
            Button(userDBbtn);
        }

        private void adminDBbtn_Click(object sender, EventArgs e)
        {
            if (!adminDBbtn.Checked)
            {
                adminDBbtn.Checked = true;
                return;
            }
            LoadForm(adminDB);
            Button(adminDBbtn);
        }

        private void GameDBbtn_Click(object sender, EventArgs e)
        {
            if (!GameDBbtn.Checked)
            {
                GameDBbtn.Checked = true;
                return;
            }
            LoadForm(gameDB);
            Button(GameDBbtn);
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            if (!categoryBtn.Checked)
            {
                categoryBtn.Checked = true;
                return;
            }
            LoadForm(catView);
            Button(categoryBtn);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
            else
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Close();
            }
        }

        private void downloadbtn_Click(object sender, EventArgs e)
        {
            if (!downloadbtn.Checked)
            {
                downloadbtn.Checked = true;
                return;
            }
            LoadForm(download);
            Button(downloadbtn);
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void userpanel_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            string user = usertxt.Text;
            string query = @"select u.firstname, u.lastname, u.gender,u.email,u.username, u.upass, u.dob from usertbl u where u.username = @username";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBconnect.cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    if (dt.Rows.Count > 0)
                    {
                        // Populate the SignUp form fields with the data
                        DataRow row = dt.Rows[0];

                        s.txtFirstName.Text = row["firstname"].ToString();
                        s.txtLastName.Text = row["lastname"].ToString();

                        string gender = row["gender"].ToString().ToLower();
                        if (gender == "Male")
                        {
                            s.maleRB.Checked = true;
                        }
                        else
                        {
                            s.femaleRB.Checked = true;
                        }

                        s.txtEmail.Text = row["email"].ToString();
                        s.txtUsername.Text = row["username"].ToString();
                        s.txtpass.Text = row["upass"].ToString();
                        //s.txtDob.Text = row["dob"].ToString();
                        DateTime dob;
                        if (DateTime.TryParse(row["dob"].ToString(), out dob))
                        {
                            s.txtDob.Text = dob.ToString("dd-MM-yyyy"); // Convert the date to "dd-MM-yyyy" format
                        }
                        else
                        {
                            s.txtDob.Text = row["dob"].ToString(); // If parsing fails, just use the original string
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                    return;
                }
            }s.Show();
        }
    }
}
