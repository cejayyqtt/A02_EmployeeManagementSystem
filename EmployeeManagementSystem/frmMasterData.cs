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
            // InitializeComponent();
        }

        private Panel pnlChildTitle;

        private void InitializeComponent()
        {
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 100);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(12, 44);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(102, 14);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "MASTER DATA";
            // 
            // dtgMasterData
            // 
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Location = new Point(0, 98);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 277);
            dtgMasterData.TabIndex = 1;
            // 
            // frmMasterData
            // 
            ClientSize = new Size(748, 373);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
        }

        private Label lblMasterData;
        private DataGridView dtgMasterData;
    }
}
