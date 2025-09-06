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
            pnlSideMenu = new Panel();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.FromArgb(101, 89, 248);
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Location = new Point(0, 59);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(222, 438);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.Location = new Point(0, 60);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(222, 60);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = "👥 ADD EMPLOYEE";
            btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // btnMasterData
            // 
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(222, 60);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "📁 MASTER DATA";
            btnMasterData.UseVisualStyleBackColor = true;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(101, 89, 248);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 60);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(782, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 28);
            btnClose.TabIndex = 2;
            btnClose.Text = "🗙";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = SystemColors.ControlText;
            btnMaximize.Location = new Point(743, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 28);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = SystemColors.ControlText;
            btnMinimize.Location = new Point(703, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 28);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlStage
            // 
            pnlStage.Location = new Point(425, 202);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(200, 100);
            pnlStage.TabIndex = 2;
            pnlStage.Paint += pnlStage_Paint;
            // 
            // FrmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlStage);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlSideMenu);
            Name = "FrmMotherForm";
            Text = "Form1";
            Load += FrmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMasterData;
        private Button btnAddEmp;
        private Panel pnlStage;
    }
}
