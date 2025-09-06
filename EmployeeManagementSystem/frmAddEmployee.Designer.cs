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
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
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
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Bookman Old Style", 9F);
            groupBox1.Location = new Point(0, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 251);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual Insert and Update";
            // 
            // button2
            // 
            button2.Font = new Font("Bookman Old Style", 9F);
            button2.Location = new Point(139, 205);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 11;
            button2.Text = "INSERT / UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 24);
            comboBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 22);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 22);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 22);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Bookman Old Style", 9F);
            button1.Location = new Point(254, 36);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 9F);
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
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
    }
}