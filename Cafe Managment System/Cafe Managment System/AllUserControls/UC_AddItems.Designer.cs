namespace Cafe_Managment_System.AllUserControls
{
    partial class UC_AddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            Category = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 44);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Category.Location = new Point(158, 120);
            Category.Name = "Category";
            Category.Size = new Size(110, 31);
            Category.TabIndex = 1;
            Category.Text = "Category";
            Category.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 214);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(158, 312);
            label4.Name = "label4";
            label4.Size = new Size(68, 31);
            label4.TabIndex = 3;
            label4.Text = "Price";
            label4.Click += label4_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 118, 225);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(246, 420);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "Add Item";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.Black;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(158, 154);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(291, 36);
            guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2ComboBox1.TabIndex = 5;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges5;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(158, 248);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(291, 36);
            guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox1.TabIndex = 6;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.CustomizableEdges = customizableEdges7;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox2.ForeColor = Color.Black;
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(158, 346);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox2.Size = new Size(291, 36);
            guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox2.TabIndex = 7;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // UC_AddItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2ComboBox1);
            Controls.Add(guna2Button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Category);
            Controls.Add(label1);
            Name = "UC_AddItems";
            Size = new Size(781, 514);
            Load += UC_AddItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Category;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}
