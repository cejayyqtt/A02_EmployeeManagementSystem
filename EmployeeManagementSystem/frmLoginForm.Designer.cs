namespace EmployeeManagementSystem
{
    partial class frmLoginForm
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
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            label7 = new Label();
            btnMaximize = new Button();
            btnMinimize = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.ForeColor = SystemColors.ButtonHighlight;
            lbl.Location = new Point(204, 244);
            lbl.Name = "lbl";
            lbl.Size = new Size(91, 25);
            lbl.TabIndex = 0;
            lbl.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(204, 319);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(158, 165);
            label3.Name = "label3";
            label3.Size = new Size(415, 32);
            label3.TabIndex = 2;
            label3.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(326, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(208, 272);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 31);
            txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(179, 242, 202);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(279, 399);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 37);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 52);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(179, 242, 202);
            label6.Location = new Point(208, 197);
            label6.Name = "label6";
            label6.Size = new Size(313, 25);
            label6.TabIndex = 8;
            label6.Text = "Secure Access to Your Workforce Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 242, 202);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 65);
            panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(179, 242, 202);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(179, 242, 202);
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(722, 21);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 31);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(40, 21);
            label7.Name = "label7";
            label7.Size = new Size(138, 28);
            label7.TabIndex = 0;
            label7.Text = "System Login";
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(179, 242, 202);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.FromArgb(179, 242, 202);
            btnMaximize.Image = Properties.Resources.maximize;
            btnMaximize.Location = new Point(681, 21);
            btnMaximize.Margin = new Padding(4, 5, 4, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 31);
            btnMaximize.TabIndex = 12;
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
            btnMinimize.Location = new Point(637, 21);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 31);
            btnMinimize.TabIndex = 11;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(293, 439);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 21);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 56);
            ClientSize = new Size(767, 594);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginForm";
            Text = "System Login ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label4;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private LinkLabel linkLabel1;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}