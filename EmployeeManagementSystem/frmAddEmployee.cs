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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void inputDataLoad()
        {
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmpID.Text = frmMasterData.EmployeeNumber;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;

        }
        private void clearAllFields()
        {
            txtEmpID.Clear();
            txtEmailAddress.Clear();
            txtLocalNumber.Clear();
            txtRequestorName.Clear();
            cmbSection.Text = "";

        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            bool empIDChecker = string.IsNullOrWhiteSpace(txtEmpID.Text);
            bool empNameChecker = string.IsNullOrWhiteSpace(txtRequestorName.Text);
            bool emailChecker = string.IsNullOrWhiteSpace(txtEmailAddress.Text);
            bool numberChecker = string.IsNullOrWhiteSpace(txtLocalNumber.Text);
            bool sectionChecker = string.IsNullOrWhiteSpace(cmbSection.Text);

            if (empIDChecker || empNameChecker || emailChecker || numberChecker || sectionChecker)
            {
                MessageBox.Show("Please fill up the empty field.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
            {
                MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool recordExists = CRUD.CRUD.RETRIEVESINGLE("SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = " + txtEmpID.Text);

            if (recordExists)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists! Do you want to update it?", "Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    string update_requestor = "UPDATE [tblEmployeeData] SET " +
                        "[RequestorName] = '" + txtRequestorName.Text + "', " +
                        "[RequestorEmail] = '" + txtEmailAddress.Text + "', " +
                        "[Section] = '" + cmbSection.Text + "', " +
                        "[LocalNumber] = " + txtLocalNumber.Text + ", " +
                        "[EmployeeNumber] = " + txtEmpID.Text +
                        " WHERE [ID] = " + frmMasterData.selectedTransaction +
                        " OR [EmployeeNumber] = " + txtEmpID.Text;

                    CRUD.CRUD.CUD(update_requestor); // ✅ EXECUTE UPDATE
                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAllFields();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAllFields();
                    this.Close();
                }
            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] " +
                    "([EmployeeNumber],[RequestorName],[RequestorEmail],[Section],[LocalNumber]) " +
                    "VALUES (" + txtEmpID.Text + ", '" + txtRequestorName.Text + "', '" + txtEmailAddress.Text + "', '" + cmbSection.Text + "', " + txtLocalNumber.Text + ")";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAllFields();
                this.Close();
            }
        }


        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            inputDataLoad();
        }

        string selectedTransaction = frmMasterData.selectedTransaction;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gboxInsertUpdate_Enter(object sender, EventArgs e)
        {

        }

        public void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTransaction == null || selectedTransaction == "0" || string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show("No record selected to delete.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE [ID] = " + selectedTransaction;
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Deleted Succesfully!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAllFields();
                this.Close();
            }

            else
            {
                return;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee Number to search.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!txtEmpID.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string search_query = "SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = " + txtEmpID.Text;

            bool recordExists = CRUD.CRUD.RETRIEVESINGLE(search_query);

            if (recordExists)
            {
                MessageBox.Show("Employee with ID: " + txtEmpID.Text + "found. ", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpID.Clear();
            }
            else
            {
                MessageBox.Show("No employee found with ID: " + txtEmpID.Text + ". Please try again.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpID.Clear();
            }

        }

        private void txtRequestorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
