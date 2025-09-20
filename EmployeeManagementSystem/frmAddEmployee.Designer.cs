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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnInsertUpdate = new Button();
            cmbSection = new ComboBox();
            txtLocalNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            button1 = new Button();
            txtEmpID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 116, 181);
            label1.Location = new Point(311, 17);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 0;
            label1.Text = "👥 ADD EMPLOYEE";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Bookman Old Style", 9F);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 392);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual Insert and Update";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Window;
            btnDelete.Location = new Point(302, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = SystemColors.ButtonHighlight;
            btnInsertUpdate.Font = new Font("Bookman Old Style", 9F);
            btnInsertUpdate.ForeColor = SystemColors.HotTrack;
            btnInsertUpdate.Location = new Point(139, 205);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(148, 23);
            btnInsertUpdate.TabIndex = 11;
            btnInsertUpdate.Text = "INSERT / UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(139, 165);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(190, 24);
            cmbSection.TabIndex = 10;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(138, 131);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(191, 22);
            txtLocalNumber.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(138, 101);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(373, 22);
            txtEmailAddress.TabIndex = 8;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(138, 69);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(373, 22);
            txtRequestorName.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Bookman Old Style", 9F);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(254, 36);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(138, 36);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(100, 22);
            txtEmpID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 9F);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(64, 168);
            label6.Name = "label6";
            label6.Size = new Size(56, 16);
            label6.TabIndex = 4;
            label6.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 9F);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(26, 134);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 3;
            label5.Text = "Local Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9F);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(23, 104);
            label4.Name = "label4";
            label4.Size = new Size(97, 16);
            label4.TabIndex = 2;
            label4.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(112, 16);
            label3.TabIndex = 1;
            label3.Text = "Requestor Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 9F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(8, 39);
            label2.Name = "label2";
            label2.Size = new Size(120, 16);
            label2.TabIndex = 0;
            label2.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbSection;
        private TextBox txtLocalNumber;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private Button button1;
        private TextBox txtEmpID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnInsertUpdate;
        private Button btnDelete;
    }
}