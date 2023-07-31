namespace Cafe_Managment_System
{
    partial class DashBoard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnLogOut = new LinkLabel();
            guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            btnRemoveItems = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateItems = new Guna.UI2.WinForms.Guna2Button();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_Welcome1 = new AllUserControls.UC_Welcome();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(guna2GradientCircleButton1);
            panel1.Controls.Add(btnRemoveItems);
            panel1.Controls.Add(btnUpdateItems);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(btnPlaceOrder);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 523);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.LinkColor = Color.White;
            btnLogOut.Location = new Point(58, 419);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(78, 28);
            btnLogOut.TabIndex = 2;
            btnLogOut.TabStop = true;
            btnLogOut.Text = "LogOut";
            btnLogOut.LinkClicked += btnLogOut_LinkClicked;
            // 
            // guna2GradientCircleButton1
            // 
            guna2GradientCircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientCircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientCircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientCircleButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientCircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientCircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GradientCircleButton1.ForeColor = Color.White;
            guna2GradientCircleButton1.Location = new Point(3, 0);
            guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            guna2GradientCircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2GradientCircleButton1.Size = new Size(39, 41);
            guna2GradientCircleButton1.TabIndex = 4;
            guna2GradientCircleButton1.Text = "X";
            guna2GradientCircleButton1.Click += guna2GradientCircleButton1_Click;
            // 
            // btnRemoveItems
            // 
            btnRemoveItems.BorderRadius = 16;
            btnRemoveItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnRemoveItems.CheckedState.FillColor = Color.White;
            btnRemoveItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnRemoveItems.CustomizableEdges = customizableEdges2;
            btnRemoveItems.DisabledState.BorderColor = Color.DarkGray;
            btnRemoveItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemoveItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemoveItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemoveItems.FillColor = Color.FromArgb(0, 118, 225);
            btnRemoveItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveItems.ForeColor = Color.White;
            btnRemoveItems.Location = new Point(9, 249);
            btnRemoveItems.Name = "btnRemoveItems";
            btnRemoveItems.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnRemoveItems.Size = new Size(202, 41);
            btnRemoveItems.TabIndex = 3;
            btnRemoveItems.Text = "Remove Items";
            // 
            // btnUpdateItems
            // 
            btnUpdateItems.BorderRadius = 16;
            btnUpdateItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnUpdateItems.CheckedState.FillColor = Color.White;
            btnUpdateItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnUpdateItems.CustomizableEdges = customizableEdges4;
            btnUpdateItems.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateItems.FillColor = Color.FromArgb(0, 118, 225);
            btnUpdateItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateItems.ForeColor = Color.White;
            btnUpdateItems.Location = new Point(9, 187);
            btnUpdateItems.Name = "btnUpdateItems";
            btnUpdateItems.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnUpdateItems.Size = new Size(202, 41);
            btnUpdateItems.TabIndex = 2;
            btnUpdateItems.Text = "Update Items";
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 16;
            btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddItems.CheckedState.FillColor = Color.White;
            btnAddItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnAddItems.CustomizableEdges = customizableEdges6;
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(9, 125);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnAddItems.Size = new Size(202, 41);
            btnAddItems.TabIndex = 1;
            btnAddItems.Text = "Add Items";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BorderRadius = 16;
            btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnPlaceOrder.CheckedState.FillColor = Color.White;
            btnPlaceOrder.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.CustomizableEdges = customizableEdges8;
            btnPlaceOrder.DisabledState.BorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlaceOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlaceOrder.FillColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(9, 67);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnPlaceOrder.Size = new Size(202, 41);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(uC_Welcome1);
            panel2.Location = new Point(195, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 523);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = panel2;
            // 
            // uC_Welcome1
            // 
            uC_Welcome1.BackColor = Color.White;
            uC_Welcome1.Location = new Point(0, 0);
            uC_Welcome1.Name = "uC_Welcome1";
            uC_Welcome1.Size = new Size(976, 642);
            uC_Welcome1.TabIndex = 2;
            uC_Welcome1.Load += uC_Welcome1_Load;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItems;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItems;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
    }
}