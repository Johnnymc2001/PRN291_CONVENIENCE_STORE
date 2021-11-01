﻿
namespace ConvenienceStoreApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_currentUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_permission = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_storeName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hlightBtn1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hlightBtn5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.hlightBtn4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.hlightBtn3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.hlightBtn2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderManagement1 = new ConvenienceStoreApp.OrderManagement();
            this.ucOrder1 = new ConvenienceStoreApp.ucOrder();
            this.ucSelfOrdersView1 = new ConvenienceStoreApp.ucSelfOrdersView();
            this.ucStaffManagement1 = new ConvenienceStoreApp.ucStaffManagement();
            this.ucProductManagement1 = new ConvenienceStoreApp.ucProductManagement();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.hlightBtn1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.hlightBtn5.SuspendLayout();
            this.hlightBtn4.SuspendLayout();
            this.hlightBtn3.SuspendLayout();
            this.hlightBtn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(246, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1240, 76);
            this.panel4.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1189, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.label_currentUser);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label_permission);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(246, 76);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 145);
            this.panel5.TabIndex = 2;
            // 
            // label_currentUser
            // 
            this.label_currentUser.AutoSize = true;
            this.label_currentUser.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_currentUser.ForeColor = System.Drawing.Color.White;
            this.label_currentUser.Location = new System.Drawing.Point(210, 73);
            this.label_currentUser.Name = "label_currentUser";
            this.label_currentUser.Size = new System.Drawing.Size(148, 38);
            this.label_currentUser.TabIndex = 8;
            this.label_currentUser.Text = "Fullname";
            this.label_currentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current User:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_permission
            // 
            this.label_permission.AutoSize = true;
            this.label_permission.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_permission.ForeColor = System.Drawing.Color.Red;
            this.label_permission.Location = new System.Drawing.Point(210, 25);
            this.label_permission.Name = "label_permission";
            this.label_permission.Size = new System.Drawing.Size(79, 38);
            this.label_permission.TabIndex = 6;
            this.label_permission.Text = "Role";
            this.label_permission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permission:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_storeName);
            this.panel3.Controls.Add(this.logo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 221);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convenience Store";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_storeName
            // 
            this.label_storeName.AutoSize = true;
            this.label_storeName.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_storeName.ForeColor = System.Drawing.Color.White;
            this.label_storeName.Location = new System.Drawing.Point(59, 149);
            this.label_storeName.Name = "label_storeName";
            this.label_storeName.Size = new System.Drawing.Size(112, 23);
            this.label_storeName.TabIndex = 3;
            this.label_storeName.Text = "Akihabara";
            this.label_storeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(59, 16);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(106, 129);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // hlightBtn1
            // 
            this.hlightBtn1.BackColor = System.Drawing.Color.White;
            this.hlightBtn1.Controls.Add(this.panel6);
            this.hlightBtn1.Location = new System.Drawing.Point(0, 244);
            this.hlightBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hlightBtn1.Name = "hlightBtn1";
            this.hlightBtn1.Size = new System.Drawing.Size(16, 79);
            this.hlightBtn1.TabIndex = 3;
            this.hlightBtn1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(-111, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 79);
            this.panel6.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.hlightBtn5);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.hlightBtn4);
            this.panel1.Controls.Add(this.hlightBtn3);
            this.panel1.Controls.Add(this.hlightBtn2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.hlightBtn1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 960);
            this.panel1.TabIndex = 0;
            // 
            // hlightBtn5
            // 
            this.hlightBtn5.BackColor = System.Drawing.Color.White;
            this.hlightBtn5.Controls.Add(this.panel8);
            this.hlightBtn5.Location = new System.Drawing.Point(0, 865);
            this.hlightBtn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hlightBtn5.Name = "hlightBtn5";
            this.hlightBtn5.Size = new System.Drawing.Size(16, 79);
            this.hlightBtn5.TabIndex = 8;
            this.hlightBtn5.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(-111, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(24, 79);
            this.panel8.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(17, 865);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 79);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.btnLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // hlightBtn4
            // 
            this.hlightBtn4.BackColor = System.Drawing.Color.White;
            this.hlightBtn4.Controls.Add(this.panel11);
            this.hlightBtn4.Location = new System.Drawing.Point(0, 779);
            this.hlightBtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hlightBtn4.Name = "hlightBtn4";
            this.hlightBtn4.Size = new System.Drawing.Size(16, 79);
            this.hlightBtn4.TabIndex = 7;
            this.hlightBtn4.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(-111, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(24, 79);
            this.panel11.TabIndex = 4;
            // 
            // hlightBtn3
            // 
            this.hlightBtn3.BackColor = System.Drawing.Color.White;
            this.hlightBtn3.Controls.Add(this.panel9);
            this.hlightBtn3.Location = new System.Drawing.Point(0, 417);
            this.hlightBtn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hlightBtn3.Name = "hlightBtn3";
            this.hlightBtn3.Size = new System.Drawing.Size(16, 79);
            this.hlightBtn3.TabIndex = 6;
            this.hlightBtn3.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(-111, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(24, 79);
            this.panel9.TabIndex = 4;
            // 
            // hlightBtn2
            // 
            this.hlightBtn2.BackColor = System.Drawing.Color.White;
            this.hlightBtn2.Controls.Add(this.panel7);
            this.hlightBtn2.Location = new System.Drawing.Point(0, 331);
            this.hlightBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hlightBtn2.Name = "hlightBtn2";
            this.hlightBtn2.Size = new System.Drawing.Size(16, 79);
            this.hlightBtn2.TabIndex = 5;
            this.hlightBtn2.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(-111, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 79);
            this.panel7.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 779);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 79);
            this.button4.TabIndex = 6;
            this.button4.Text = "About Us";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 417);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 79);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(14, 331);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // orderManagement1
            // 
            this.orderManagement1.Location = new System.Drawing.Point(246, 221);
            this.orderManagement1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.orderManagement1.Name = "orderManagement1";
            this.orderManagement1.Size = new System.Drawing.Size(1240, 739);
            this.orderManagement1.TabIndex = 9;
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucOrder1.Location = new System.Drawing.Point(246, 221);
            this.ucOrder1.loggedStaff = null;
            this.ucOrder1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1240, 739);
            this.ucOrder1.TabIndex = 9;
            // 
            // ucSelfOrdersView1
            // 
            this.ucSelfOrdersView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucSelfOrdersView1.Location = new System.Drawing.Point(246, 221);
            this.ucSelfOrdersView1.loggedStaff = null;
            this.ucSelfOrdersView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucSelfOrdersView1.Name = "ucSelfOrdersView1";
            this.ucSelfOrdersView1.Size = new System.Drawing.Size(1240, 739);
            this.ucSelfOrdersView1.TabIndex = 11;
            // 
            // ucStaffManagement1
            // 
            this.ucStaffManagement1.Location = new System.Drawing.Point(246, 221);
            this.ucStaffManagement1.Name = "ucStaffManagement1";
            this.ucStaffManagement1.Size = new System.Drawing.Size(1550, 924);
            this.ucStaffManagement1.TabIndex = 12;
            // 
            // ucProductManagement1
            // 
            this.ucProductManagement1.Location = new System.Drawing.Point(246, 221);
            this.ucProductManagement1.Name = "ucProductManagement1";
            this.ucProductManagement1.Size = new System.Drawing.Size(1550, 924);
            this.ucProductManagement1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.ucProductManagement1);
            this.Controls.Add(this.ucStaffManagement1);
            this.Controls.Add(this.ucSelfOrdersView1);
            this.Controls.Add(this.ucOrder1);
            this.Controls.Add(this.orderManagement1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Convenience Store Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.hlightBtn1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.hlightBtn5.ResumeLayout(false);
            this.hlightBtn4.ResumeLayout(false);
            this.hlightBtn3.ResumeLayout(false);
            this.hlightBtn2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_storeName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel hlightBtn1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel hlightBtn2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel hlightBtn4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel hlightBtn3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label_permission;
        private System.Windows.Forms.Label label_currentUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel hlightBtn5;
        private System.Windows.Forms.Panel panel8;
        private OrderManagement orderManagement1;
        private ucOrder ucOrder1;
        private ucSelfOrdersView ucSelfOrdersView1;
        private ucStaffManagement ucStaffManagement1;
        private ucProductManagement ucProductManagement1;
    }
}

