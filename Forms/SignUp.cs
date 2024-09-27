using GameServer_Management.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }
        private void GetGender()
        {
            if (maleRB.Checked) { Gender = "Male"; }
            else if (femaleRB.Checked) { Gender = "Female"; }
        }
        /*private bool EmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }   */

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            GetGender();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            if (id == 0) { query = "AddUser"; }

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
                h.Add("@dob", birthday.ToString("yyyy-MM-dd")); // sql recognized format
            }
            else
            {
                MessageBox.Show("Invalid date format! Please enter a valid date in dd-MM-yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBconnect.SQL(query, h) > 0)
            {
                MessageBox.Show("Saved Successfully!", "GameServer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = true;
            show_pass_btn.Visible = false;
            txtpass.PasswordChar = '*';
        }

        private void hide_pass_btn_Click(object sender, EventArgs e)
        {
            hide_pass_btn.Visible = false;
            show_pass_btn.Visible = true;
            txtpass.PasswordChar = '\0';
        }

        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            GetGender();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showpassbtn_Click(object sender, EventArgs e)
        {
            hidepassbtn.Visible = true;
            showpassbtn.Visible = false;
            txtconpass.PasswordChar = '*';
        }

        private void hidepassbtn_Click(object sender, EventArgs e)
        {
            hidepassbtn.Visible = false;
            showpassbtn.Visible = true;
            txtconpass.PasswordChar = '\0';
        }

        private void DateSelect_ValueChanged(object sender, EventArgs e)
        {
            txtDob.Text = DateSelect.Value.ToString("dd-MM-yyyy");
        }
    }
}
