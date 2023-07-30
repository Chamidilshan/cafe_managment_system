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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 118, 221);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(123, 405);
            button1.Name = "button1";
            button1.Size = new Size(102, 31);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 0);
            linkLabel1.Location = new Point(114, 466);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Continue as a guest";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(373, 540);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}