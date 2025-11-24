using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        public static string fullName, section, age;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool usernameEmpty = string.IsNullOrEmpty(username);
            bool passwordEmpty = string.IsNullOrEmpty(password);

            if (usernameEmpty && passwordEmpty)
            {
                MessageBox.Show("Please enter your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usernameEmpty)
            {
                MessageBox.Show("Please enter your username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passwordEmpty)
            {
                MessageBox.Show("Please enter your password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = $"SELECT [FULLNAME], [SECTION], [AGE], [USERNAME], [PASSWORD] FROM tblUsers WHERE username = '{username}' AND '{password}' = '{password}'";
                bool isAuth = CRUD.CRUD.RETRIEVESINGLE(query);

                string dbEmail, dbPassword;
                int count = CRUD.CRUD.dt.Rows.Count;

                if (isAuth && count > 0)
                {
                    dbEmail = CRUD.CRUD.dt.Rows[0]["USERNAME"].ToString();
                    dbPassword = CRUD.CRUD.dt.Rows[0]["Password"].ToString();
                    if (dbEmail.Equals(username, StringComparison.Ordinal) && dbPassword.Equals(password, StringComparison.Ordinal))
                    {
                        fullName = CRUD.CRUD.dt.Rows[0]["FULLNAME"].ToString();
                        section = CRUD.CRUD.dt.Rows[0]["SECTION"].ToString();
                        age = CRUD.CRUD.dt.Rows[0]["AGE"].ToString();

                        MessageBox.Show("Login successful! Welcome " + fullName + ".", "Login Successful");
                        this.Hide();

                        FrmMotherForm openForm = new FrmMotherForm();
                        openForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username and password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username and password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
