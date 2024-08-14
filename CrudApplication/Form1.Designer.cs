namespace CrudApplication
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(198, 486);
            button1.Name = "button1";
            button1.Size = new Size(152, 64);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(376, 486);
            button2.Name = "button2";
            button2.Size = new Size(152, 64);
            button2.TabIndex = 1;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(554, 486);
            button3.Name = "button3";
            button3.Size = new Size(152, 64);
            button3.TabIndex = 2;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Font = new Font("Segoe UI", 16F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(726, 486);
            button4.Name = "button4";
            button4.Size = new Size(152, 64);
            button4.TabIndex = 3;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 16F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(906, 486);
            button5.Name = "button5";
            button5.Size = new Size(152, 64);
            button5.TabIndex = 4;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(228, 102);
            label1.Name = "label1";
            label1.Size = new Size(51, 45);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(228, 166);
            label2.Name = "label2";
            label2.Size = new Size(96, 45);
            label2.TabIndex = 6;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(232, 229);
            label3.Name = "label3";
            label3.Size = new Size(105, 45);
            label3.TabIndex = 7;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(232, 296);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(228, 373);
            label5.Name = "label5";
            label5.Size = new Size(153, 45);
            label5.TabIndex = 9;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16F);
            numericUpDown1.Location = new Point(512, 100);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(347, 50);
            numericUpDown1.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16F);
            txtEmail.Location = new Point(512, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 50);
            txtEmail.TabIndex = 11;
            txtEmail.Text = " ";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(512, 229);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 50);
            txtName.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(512, 298);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(347, 50);
            txtUsername.TabIndex = 13;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(512, 368);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(347, 50);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(860, 268);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1174, 736);
            Controls.Add(dataGridView1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "CRUD Application";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private DataGridView dataGridView1;
    }
}
