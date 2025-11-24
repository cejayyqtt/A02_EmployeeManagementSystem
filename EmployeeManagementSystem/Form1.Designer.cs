namespace EmployeeManagementSystem
{
    partial class FrmMotherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotherForm));
            pnlSideMenu = new Panel();
            btnSettings = new Button();
            lblAge = new Label();
            lblSection = new Label();
            lblFullName = new Label();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            lblSub = new Label();
            lblEms = new Label();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            pnlStage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.FromArgb(57, 62, 56);
            pnlSideMenu.Controls.Add(btnSettings);
            pnlSideMenu.Controls.Add(lblAge);
            pnlSideMenu.Controls.Add(lblSection);
            pnlSideMenu.Controls.Add(lblFullName);
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 65);
            pnlSideMenu.Margin = new Padding(4, 5, 4, 5);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(317, 529);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(179, 242, 202);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSettings.ForeColor = SystemColors.ActiveCaptionText;
            btnSettings.Image = Properties.Resources.bolt;
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(13, 305);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(296, 63);
            btnSettings.TabIndex = 5;
            btnSettings.Text = " Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.FromArgb(179, 242, 202);
            lblAge.Location = new Point(13, 101);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(81, 25);
            lblAge.TabIndex = 4;
            lblAge.Text = "< Age >";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.FromArgb(179, 242, 202);
            lblSection.Location = new Point(12, 62);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(110, 25);
            lblSection.TabIndex = 3;
            lblSection.Text = "< Section >";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(179, 242, 202);
            lblFullName.Location = new Point(12, 18);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(160, 30);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "< Full Name >";
            lblFullName.Click += lblName_Click;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = Color.FromArgb(179, 242, 202);
            btnAddEmp.FlatStyle = FlatStyle.Flat;
            btnAddEmp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.ForeColor = SystemColors.ActiveCaptionText;
            btnAddEmp.Image = Properties.Resources.user_round_plus;
            btnAddEmp.Location = new Point(13, 234);
            btnAddEmp.Margin = new Padding(4, 5, 4, 5);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(296, 63);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = " ADD EMPLOYEE";
            btnAddEmp.TextAlign = ContentAlignment.MiddleRight;
            btnAddEmp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = Color.FromArgb(179, 242, 202);
            btnMasterData.FlatStyle = FlatStyle.Flat;
            btnMasterData.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.ForeColor = SystemColors.ActiveCaptionText;
            btnMasterData.Image = (Image)resources.GetObject("btnMasterData.Image");
            btnMasterData.ImageAlign = ContentAlignment.MiddleRight;
            btnMasterData.Location = new Point(12, 161);
            btnMasterData.Margin = new Padding(4, 5, 4, 5);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(297, 63);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = " MASTER DATA";
            btnMasterData.TextAlign = ContentAlignment.MiddleLeft;
            btnMasterData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(179, 242, 202);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(4, 5, 4, 5);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1178, 65);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(31, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 28);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Employee Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            lblTitle.Click += lblTitle_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(179, 242, 202);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(179, 242, 202);
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(1129, 17);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 31);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(179, 242, 202);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.FromArgb(179, 242, 202);
            btnMaximize.Image = Properties.Resources.maximize;
            btnMaximize.Location = new Point(1088, 17);
            btnMaximize.Margin = new Padding(4, 5, 4, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 31);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.FromArgb(179, 242, 202);
            btnMinimize.Image = Properties.Resources.minimize_2;
            btnMinimize.Location = new Point(1044, 17);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 31);
            btnMinimize.TabIndex = 0;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = SystemColors.ControlLightLight;
            pnlStage.Controls.Add(lblSub);
            pnlStage.Controls.Add(lblEms);
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Font = new Font("Microsoft Sans Serif", 8.25F);
            pnlStage.ForeColor = Color.FromArgb(179, 242, 202);
            pnlStage.Location = new Point(317, 65);
            pnlStage.Margin = new Padding(4, 5, 4, 5);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(861, 529);
            pnlStage.TabIndex = 2;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.FromArgb(179, 242, 202);
            lblSub.ImageAlign = ContentAlignment.MiddleLeft;
            lblSub.Location = new Point(127, 260);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(588, 45);
            lblSub.TabIndex = 5;
            lblSub.Text = "Organize. Track. Empower your Team.";
            lblSub.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEms
            // 
            lblEms.AutoSize = true;
            lblEms.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEms.ForeColor = Color.Black;
            lblEms.ImageAlign = ContentAlignment.MiddleLeft;
            lblEms.Location = new Point(51, 215);
            lblEms.Name = "lblEms";
            lblEms.Size = new Size(769, 45);
            lblEms.TabIndex = 4;
            lblEms.Text = "WELCOME TO EMPLOYEE MANAGEMENT SYSTEM";
            lblEms.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmMotherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 594);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMotherForm";
            Text = "Employee Management System";
            Load += FrmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlSideMenu.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlStage.ResumeLayout(false);
            pnlStage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnAddEmp;
        private Panel pnlStage;
        private Label lblFullName;
        private Button btnMasterData;
        private Label lblAge;
        private Label lblSection;
        private Button btnSettings;
        private Label lblTitle;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label lblSub;
        private Label lblEms;
    }
}
