using GameServer_Management.Class;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class SignUp : Form
    {
        public string Gender;
        public int id = 0;

        public SignUp()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            //if(id != 0) { toplabel.Text = $"{txtLastName.Text}'s Profile"; }
        }
        private void GetGender()
        {
            if (maleRB.Checked) { Gender = "Male"; }
            else if (femaleRB.Checked) { Gender = "Female"; }
        }
        private bool EmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool PassMatch()
        {
            if (txtpass.Text != txtconpass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtpass.Text == string.Empty && txtconpass.Text == string.Empty)
            {
                MessageBox.Show("Passwords can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            GetGender();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!EmailValid(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format! Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PassMatch())
            {
                return;
            }
            string query = id == 0 ? "AddUser" : "UpdateUser";

            Hashtable h = new Hashtable();
            if (id != 0) { h.Add("@userid", id); }

            h.Add("@firstname", txtFirstName.Text);
            h.Add("@lastname", txtLastName.Text);
            h.Add("@gender", Gender);
            h.Add("@email", txtEmail.Text);
            h.Add("@username", txtUsername.Text);
            h.Add("@upass", txtpass.Text);
            
            DateTime birthday;
            if (DateTime.TryParseExact(txtDob.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out birthday))
            {
                h.Add("@dob", birthday.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Invalid date format! Please enter a valid date in dd-MM-yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBconnect.SQL(query, h) > 0)
            {
                //MessageBox.Show("Sign up Successfull", "GameHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                signupmsg.Visible = true;
                signupmsg.txt = id != 0 ? "User info updated" : "Sign up successful";

                await Task.Delay(3000);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            GetGender();
        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            txtDob.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }

        private void hide_pass_btn_Click_1(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = false;
            show_pass_btn.Visible = true;
            txtpass.PasswordChar = '\0';
        }

        private void show_pass_btn_Click_1(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
            show_pass_btn.Visible = false;
            txtpass.PasswordChar = '*';
        }

        private void showpassbtn_Click_1(object sender, EventArgs e)
        {
            hidepassbtn.Visible = true;
            showpassbtn.Visible = false;
            txtconpass.PasswordChar = '*';
        }

        private void hidepassbtn_Click_1(object sender, EventArgs e)
        {
            hidepassbtn.Visible = false;
            showpassbtn.Visible = true;
            txtconpass.PasswordChar = '\0';
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
        }

        private void txtconpass_TextChanged(object sender, EventArgs e)
        {
            hidepassbtn.Visible = true;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imgPath = Path.Combine(projectDir, "asset", "x_red(39).png");
            exitbtn.Image = Image.FromFile(imgPath);
        }

        private void SignUp_MouseHover(object sender, EventArgs e)
        {
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imgPath = Path.Combine(projectDir, "asset", "x(39).png");
            exitbtn.Image = Image.FromFile(imgPath);
        }
    }
}
