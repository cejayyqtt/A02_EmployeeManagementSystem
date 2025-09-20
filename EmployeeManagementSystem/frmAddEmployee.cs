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

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exist. Are you sure to edit your details?", "EDIT RECORD?.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Your record has been updated!");
                }

                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Your record didn't change.");
                }
            }


            else if (string.IsNullOrWhiteSpace(txtEmpID.Text) || string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text))
            {
                MessageBox.Show("Incomplete / Missing Data", "Please complete your information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }

            else
            {
                    string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) values('" + txtEmpID.Text + "', '" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                    CRUD.CRUD.CUD(add_requestor);
                    MessageBox.Show("Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtRequestorName.Text = frmMasterData.RequestorName;
            cmbSection.Text = frmMasterData.Section;
            txtEmpID.Text = frmMasterData.selectedTransaction;
        }
            //private void btnDelete_Click(object sender, EventArgs e)
            //{   
        //}
    }
}
