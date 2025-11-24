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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private Panel pnlChildTitle;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            lblTransactionNo = new Label();
            btnEditData = new Button();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = Color.FromArgb(57, 62, 56);
            pnlChildTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(1156, 73);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.FlatStyle = FlatStyle.Flat;
            lblMasterData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.ForeColor = Color.FromArgb(179, 242, 202);
            lblMasterData.Location = new Point(26, 20);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(164, 31);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "MASTER DATA";
            lblMasterData.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = SystemColors.ControlLight;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(179, 242, 202);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgMasterData.DefaultCellStyle = dataGridViewCellStyle1;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.EditMode = DataGridViewEditMode.EditOnF2;
            dtgMasterData.Location = new Point(0, 73);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dtgMasterData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgMasterData.Size = new Size(1156, 415);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionNo.ForeColor = SystemColors.ButtonHighlight;
            lblTransactionNo.Location = new Point(3, 456);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(256, 28);
            lblTransactionNo.TabIndex = 3;
            lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            lblTransactionNo.Click += lblTransactionNo_Click;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.BackColor = Color.FromArgb(57, 62, 56);
            btnEditData.FlatStyle = FlatStyle.Flat;
            btnEditData.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditData.ForeColor = SystemColors.ButtonHighlight;
            btnEditData.Location = new Point(1002, 452);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(154, 32);
            btnEditData.TabIndex = 4;
            btnEditData.Text = "Edit Data";
            btnEditData.UseVisualStyleBackColor = false;
            btnEditData.Click += btnEditData_Click;
            // 
            // frmMasterData
            // 
            BackColor = Color.FromArgb(57, 62, 56);
            ClientSize = new Size(1156, 538);
            Controls.Add(btnEditData);
            Controls.Add(lblTransactionNo);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMasterData";
            Padding = new Padding(0, 0, 0, 50);
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblTransactionNo;
        private Button btnEditData;
        private Label lblMasterData;
        private DataGridView dtgMasterData;

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        public static string RequestorName, EmailAddress, Section, LocalNumber, selectedTransaction, EmployeeNumber;

        private void btnEditData_Click(object sender, EventArgs e)
        {
            frmAddEmployee OpenfrmAddEmployee = new frmAddEmployee();
            if (frmMasterData.selectedTransaction == null || frmMasterData.selectedTransaction == "0" || frmMasterData.selectedTransaction == "")
            {
                MessageBox.Show("Please select a record to edit.", "No record selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            OpenfrmAddEmployee.btnSearch.Visible = true;
            OpenfrmAddEmployee.btnDelete.Visible = true;
            OpenfrmAddEmployee.btnInsertUpdate.Visible = true;
            OpenfrmAddEmployee.gboxInsertUpdate.Location = new Point(35, 48);
            OpenfrmAddEmployee.btnInsertUpdate.Text = "INSERT/UPDATE";
            OpenfrmAddEmployee.StartPosition = FormStartPosition.CenterScreen;
            OpenfrmAddEmployee.panel1.MouseDown += OpenfrmAddEmployee.panel1_MouseDown;
            // OpenfrmAddEmployee.pictureBox1.MouseDown += openForm.pictureBox1_MouseDown;
            OpenfrmAddEmployee.lblHeader.MouseDown += OpenfrmAddEmployee.lblHeader_MouseDown;
            OpenfrmAddEmployee.ShowDialog();
            this.Close();
            // frmMasterData_Load(sender, e);
        }

        private void lblTransactionNo_Click(object sender, EventArgs e)
        {

        }

        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)  
                return;

            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            EmailAddress = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
            EmployeeNumber = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
        }
    }
}

