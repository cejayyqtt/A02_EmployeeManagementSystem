namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnClose = new Button();
            lblHeader = new Label();
            btnMaximize = new Button();
            btnMinimize = new Button();
            gboxInsertUpdate = new GroupBox();
            btnDelete = new Button();
            btnInsertUpdate = new Button();
            cmbSection = new ComboBox();
            txtLocalNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            btnSearch = new Button();
            txtEmpID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            gboxInsertUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 56);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblHeader);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 75);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(179, 242, 202);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(179, 242, 202);
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(1083, 21);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 31);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Transparent;
            lblHeader.Location = new Point(456, 18);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(195, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ADD EMPLOYEE";
            lblHeader.TextAlign = ContentAlignment.TopRight;
            lblHeader.Click += label1_Click;
            lblHeader.MouseDown += lblHeader_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(179, 242, 202);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.FromArgb(179, 242, 202);
            btnMaximize.Image = Properties.Resources.maximize;
            btnMaximize.Location = new Point(1042, 21);
            btnMaximize.Margin = new Padding(4, 5, 4, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 31);
            btnMaximize.TabIndex = 15;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(179, 242, 202);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.FromArgb(179, 242, 202);
            btnMinimize.Image = Properties.Resources.minimize_2;
            btnMinimize.Location = new Point(998, 21);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 31);
            btnMinimize.TabIndex = 14;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // gboxInsertUpdate
            // 
            gboxInsertUpdate.BackColor = SystemColors.ControlLight;
            gboxInsertUpdate.Controls.Add(btnDelete);
            gboxInsertUpdate.Controls.Add(btnInsertUpdate);
            gboxInsertUpdate.Controls.Add(cmbSection);
            gboxInsertUpdate.Controls.Add(txtLocalNumber);
            gboxInsertUpdate.Controls.Add(txtEmailAddress);
            gboxInsertUpdate.Controls.Add(txtRequestorName);
            gboxInsertUpdate.Controls.Add(btnSearch);
            gboxInsertUpdate.Controls.Add(txtEmpID);
            gboxInsertUpdate.Controls.Add(label6);
            gboxInsertUpdate.Controls.Add(label5);
            gboxInsertUpdate.Controls.Add(label4);
            gboxInsertUpdate.Controls.Add(label3);
            gboxInsertUpdate.Controls.Add(label2);
            gboxInsertUpdate.Dock = DockStyle.Fill;
            gboxInsertUpdate.FlatStyle = FlatStyle.Flat;
            gboxInsertUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxInsertUpdate.ForeColor = SystemColors.ActiveCaptionText;
            gboxInsertUpdate.Location = new Point(0, 75);
            gboxInsertUpdate.Margin = new Padding(4, 5, 4, 5);
            gboxInsertUpdate.Name = "gboxInsertUpdate";
            gboxInsertUpdate.Padding = new Padding(4, 5, 4, 5);
            gboxInsertUpdate.Size = new Size(1143, 675);
            gboxInsertUpdate.TabIndex = 1;
            gboxInsertUpdate.TabStop = false;
            gboxInsertUpdate.Text = "Employee Details Manual Insert and Update";
            gboxInsertUpdate.Enter += gboxInsertUpdate_Enter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(179, 242, 202);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(503, 310);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = Color.FromArgb(179, 242, 202);
            btnInsertUpdate.FlatStyle = FlatStyle.Flat;
            btnInsertUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnInsertUpdate.Location = new Point(256, 310);
            btnInsertUpdate.Margin = new Padding(4, 5, 4, 5);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(211, 38);
            btnInsertUpdate.TabIndex = 11;
            btnInsertUpdate.Text = "INSERT / UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // cmbSection
            // 
            cmbSection.BackColor = SystemColors.ControlLightLight;
            cmbSection.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSection.FormattingEnabled = true;
            cmbSection.ItemHeight = 25;
            cmbSection.Items.AddRange(new object[] { "BSIT 2A", "BSBA 2B", "BSEd 2A", "BSHM 2C", "BSCRIM 2B" });
            cmbSection.Location = new Point(197, 267);
            cmbSection.Margin = new Padding(4, 5, 4, 5);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(270, 33);
            cmbSection.TabIndex = 10;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.BackColor = SystemColors.ControlLightLight;
            txtLocalNumber.Location = new Point(197, 218);
            txtLocalNumber.Margin = new Padding(4, 5, 4, 5);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(271, 31);
            txtLocalNumber.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = SystemColors.ControlLightLight;
            txtEmailAddress.Location = new Point(197, 168);
            txtEmailAddress.Margin = new Padding(4, 5, 4, 5);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(455, 31);
            txtEmailAddress.TabIndex = 8;
            // 
            // txtRequestorName
            // 
            txtRequestorName.BackColor = SystemColors.ControlLightLight;
            txtRequestorName.Location = new Point(197, 115);
            txtRequestorName.Margin = new Padding(4, 5, 4, 5);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(455, 31);
            txtRequestorName.TabIndex = 7;
            txtRequestorName.TextChanged += txtRequestorName_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(179, 242, 202);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(367, 60);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 32);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEmpID
            // 
            txtEmpID.BackColor = SystemColors.ControlLightLight;
            txtEmpID.Location = new Point(197, 60);
            txtEmpID.Margin = new Padding(4, 5, 4, 5);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(141, 31);
            txtEmpID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(105, 275);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 4;
            label6.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(53, 224);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 3;
            label5.Text = "Local Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(53, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 2;
            label4.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(33, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 1;
            label3.Text = "Requestor Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 0;
            label2.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(gboxInsertUpdate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gboxInsertUpdate.ResumeLayout(false);
            gboxInsertUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblHeader;
        public GroupBox gboxInsertUpdate;
        private ComboBox cmbSection;
        private TextBox txtLocalNumber;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        public Button btnSearch;
        private TextBox txtEmpID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public Button btnInsertUpdate;
        public Button btnDelete;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}