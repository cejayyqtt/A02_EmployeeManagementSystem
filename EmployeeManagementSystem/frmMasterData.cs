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
            pnlChildTitle.BackColor = Color.White;
            pnlChildTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 57);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.Anchor = AnchorStyles.Top;
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.ForeColor = Color.FromArgb(54, 116, 181);
            lblMasterData.Location = new Point(304, 17);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(133, 20);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "🗃️ MASTER DATA";
            lblMasterData.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = Color.Silver;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.EditMode = DataGridViewEditMode.EditOnF2;
            dtgMasterData.Location = new Point(0, 57);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 266);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
           // dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionNo.Location = new Point(3, 341);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(169, 17);
            lblTransactionNo.TabIndex = 3;
            lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            lblTransactionNo.Click += lblTransactionNo_Click;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.Location = new Point(644, 337);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(101, 26);
            btnEditData.TabIndex = 4;
            btnEditData.Text = "Edit Data";
            btnEditData.UseVisualStyleBackColor = true;
            btnEditData.Click += btnEditData_Click;
            // 
            // frmMasterData
            // 
            ClientSize = new Size(748, 373);
            Controls.Add(btnEditData);
            Controls.Add(lblTransactionNo);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
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

        public static string RequestorName, EmailAddress, Section, LocalNumber, selectedTransaction;

        private void btnEditData_Click(object sender, EventArgs e)
        {
            frmAddEmployee OpenfrmAddEmployee = new frmAddEmployee();
            OpenfrmAddEmployee.ShowDialog();
            this.Close();
            frmMasterData_Load(sender, e);
        }

        private void lblTransactionNo_Click(object sender, EventArgs e)
        {

        }

        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            EmailAddress = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
        }
    }
}
