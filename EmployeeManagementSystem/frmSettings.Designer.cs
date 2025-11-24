namespace EmployeeManagementSystem
{
    partial class frmSettings
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            dtg = new TabPage();
            dgvUsers = new DataGridView();
            panel2 = new Panel();
            btnExecute = new Button();
            lblNumber = new Label();
            lblMatch = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            cmbSection = new ComboBox();
            lblSection = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            pnlUserRegistration = new Panel();
            btnDownload = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtPassword = new TextBox();
            tabControl1.SuspendLayout();
            dtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel2.SuspendLayout();
            pnlUserRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(dtg);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1121, 632);
            tabControl1.TabIndex = 0;
            // 
            // dtg
            // 
            dtg.Controls.Add(dgvUsers);
            dtg.Controls.Add(panel2);
            dtg.Controls.Add(pnlUserRegistration);
            dtg.Location = new Point(4, 34);
            dtg.Name = "dtg";
            dtg.Padding = new Padding(3);
            dtg.Size = new Size(1113, 594);
            dtg.TabIndex = 0;
            dtg.Text = "User Registration";
            dtg.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(179, 242, 202);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(268, 64);
            dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(179, 242, 202);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(179, 242, 202);
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.Size = new Size(842, 527);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellContentDoubleClick += dgvUsers_CellContentDoubleClick;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 62, 56);
            panel2.Controls.Add(btnExecute);
            panel2.Controls.Add(lblNumber);
            panel2.Controls.Add(lblMatch);
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(lblConfirmPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtAge);
            panel2.Controls.Add(lblAge);
            panel2.Controls.Add(cmbSection);
            panel2.Controls.Add(lblSection);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(lblFullName);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 527);
            panel2.TabIndex = 1;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.FromArgb(179, 242, 202);
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExecute.Location = new Point(129, 460);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(98, 32);
            btnExecute.TabIndex = 15;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            btnExecute.MouseEnter += btnExecute_MouseEnter;
            btnExecute.MouseLeave += btnExecute_MouseLeave;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = SystemColors.ControlLightLight;
            lblNumber.Location = new Point(17, 479);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(73, 19);
            lblNumber.TabIndex = 14;
            lblNumber.Text = "✓ Number";
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatch.ForeColor = SystemColors.ControlLightLight;
            lblMatch.Location = new Point(17, 460);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(62, 19);
            lblMatch.TabIndex = 13;
            lblMatch.Text = "✓ Match";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.ForeColor = Color.Gray;
            txtConfirmPassword.Location = new Point(17, 410);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm paswword";
            txtConfirmPassword.Size = new Size(214, 31);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.ForeColor = SystemColors.ControlLightLight;
            lblConfirmPassword.Location = new Point(17, 382);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 25);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(17, 308);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(17, 262);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(214, 31);
            txtAge.TabIndex = 8;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = SystemColors.ControlLightLight;
            lblAge.Location = new Point(17, 234);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age";
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(17, 189);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(214, 33);
            cmbSection.TabIndex = 6;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.ForeColor = SystemColors.ControlLightLight;
            lblSection.Location = new Point(17, 161);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(70, 25);
            lblSection.TabIndex = 5;
            lblSection.Text = "Section";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(17, 113);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(214, 31);
            txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = SystemColors.ControlLightLight;
            lblFullName.Location = new Point(17, 85);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(17, 41);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(17, 13);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // pnlUserRegistration
            // 
            pnlUserRegistration.BackColor = Color.FromArgb(57, 62, 56);
            pnlUserRegistration.Controls.Add(btnDownload);
            pnlUserRegistration.Controls.Add(label1);
            pnlUserRegistration.Dock = DockStyle.Top;
            pnlUserRegistration.Location = new Point(3, 3);
            pnlUserRegistration.Name = "pnlUserRegistration";
            pnlUserRegistration.Size = new Size(1107, 61);
            pnlUserRegistration.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(179, 242, 202);
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(988, 15);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(98, 32);
            btnDownload.TabIndex = 17;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.UseWaitCursor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(179, 242, 202);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "User Registration";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1113, 594);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Section Registration";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(17, 336);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Create a password";
            txtPassword.Size = new Size(214, 31);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 632);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            tabControl1.ResumeLayout(false);
            dtg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlUserRegistration.ResumeLayout(false);
            pnlUserRegistration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage dtg;
        private TabPage tabPage2;
        private Panel pnlUserRegistration;
        private Label lblUsername;
        private Label label1;
        private Panel panel2;
        private TextBox txtUsername;
        private Label lblSection;
        private TextBox txtFullName;
        private Label lblFullName;
        private ComboBox cmbSection;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Button btnExecute;
        private Label lblNumber;
        private Label lblMatch;
        private TextBox txtConfirmPassword;
        private Button btnDownload;
        private DataGridView dgvUsers;
        private TextBox txtPassword;
    }
}