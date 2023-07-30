namespace Cafe_Managment_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnGeust = new LinkLabel();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 258);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 329);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 118, 221);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(123, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnGeust
            // 
            btnGeust.AutoSize = true;
            btnGeust.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeust.LinkColor = Color.FromArgb(0, 192, 0);
            btnGeust.Location = new Point(114, 466);
            btnGeust.Name = "btnGeust";
            btnGeust.Size = new Size(123, 17);
            btnGeust.TabIndex = 7;
            btnGeust.TabStop = true;
            btnGeust.Text = "Continue as a guest";
            btnGeust.LinkClicked += btnGeust_LinkClicked;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(85, 285);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(188, 27);
            txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(85, 356);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 27);
            txtPassword.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(373, 540);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnGeust);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private LinkLabel btnGeust;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}