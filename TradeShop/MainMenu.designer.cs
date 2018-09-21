namespace TradeShop
{
    partial class MainMenu
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
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Account = new System.Windows.Forms.Panel();
            this.Cur_User = new System.Windows.Forms.Label();
            this.Other_Log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_panel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.menuPict = new System.Windows.Forms.PictureBox();
            this.Items = new System.Windows.Forms.Button();
            this.Stocks = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.Promotions = new System.Windows.Forms.Button();
            this.Supliers = new System.Windows.Forms.Button();
            this.Supplies = new System.Windows.Forms.Button();
            this.Departments = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.Account.SuspendLayout();
            this.Exit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPict)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.Controls.Add(this.Cur_User);
            this.Account.Controls.Add(this.Other_Log);
            this.Account.Location = new System.Drawing.Point(12, 12);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(329, 65);
            this.Account.TabIndex = 36;
            // 
            // Cur_User
            // 
            this.Cur_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cur_User.Location = new System.Drawing.Point(7, 5);
            this.Cur_User.Name = "Cur_User";
            this.Cur_User.Size = new System.Drawing.Size(319, 28);
            this.Cur_User.TabIndex = 2;
            this.Cur_User.Text = "User";
            this.Cur_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Other_Log
            // 
            this.Other_Log.Location = new System.Drawing.Point(49, 36);
            this.Other_Log.Name = "Other_Log";
            this.Other_Log.Size = new System.Drawing.Size(234, 23);
            this.Other_Log.TabIndex = 1;
            this.Other_Log.Text = "Выполнить вход с другого аккаунта";
            this.Other_Log.UseVisualStyleBackColor = true;
            this.Other_Log.Click += new System.EventHandler(this.Other_Log_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "АИС \"Товарооборот магазина\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit_panel
            // 
            this.Exit_panel.Controls.Add(this.Exit);
            this.Exit_panel.Location = new System.Drawing.Point(418, 461);
            this.Exit_panel.Name = "Exit_panel";
            this.Exit_panel.Size = new System.Drawing.Size(240, 29);
            this.Exit_panel.TabIndex = 39;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(3, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(234, 23);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Выход из программы";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuPict
            // 
            this.menuPict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPict.BackgroundImage")));
            this.menuPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPict.Location = new System.Drawing.Point(3, 3);
            this.menuPict.Name = "menuPict";
            this.menuPict.Size = new System.Drawing.Size(640, 369);
            this.menuPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuPict.TabIndex = 21;
            this.menuPict.TabStop = false;
            // 
            // Items
            // 
            this.Items.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Items.BackgroundImage")));
            this.Items.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Items.Location = new System.Drawing.Point(100, 108);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(106, 79);
            this.Items.TabIndex = 22;
            this.Items.Text = "Товары";
            this.Items.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Items.UseVisualStyleBackColor = true;
            this.Items.Click += new System.EventHandler(this.Items_Click);
            // 
            // Stocks
            // 
            this.Stocks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stocks.BackgroundImage")));
            this.Stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stocks.Location = new System.Drawing.Point(223, 108);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(106, 79);
            this.Stocks.TabIndex = 24;
            this.Stocks.Text = "Склады";
            this.Stocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stocks.UseVisualStyleBackColor = true;
            this.Stocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // Staff
            // 
            this.Staff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Staff.BackgroundImage")));
            this.Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Staff.Location = new System.Drawing.Point(346, 222);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(106, 79);
            this.Staff.TabIndex = 25;
            this.Staff.Text = "Персонал";
            this.Staff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Promotions
            // 
            this.Promotions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Promotions.BackgroundImage")));
            this.Promotions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Promotions.Location = new System.Drawing.Point(346, 108);
            this.Promotions.Name = "Promotions";
            this.Promotions.Size = new System.Drawing.Size(106, 79);
            this.Promotions.TabIndex = 26;
            this.Promotions.Text = "Акции";
            this.Promotions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Promotions.UseVisualStyleBackColor = true;
            this.Promotions.Click += new System.EventHandler(this.Promotions_Click);
            // 
            // Supliers
            // 
            this.Supliers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supliers.BackgroundImage")));
            this.Supliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Supliers.Location = new System.Drawing.Point(223, 222);
            this.Supliers.Name = "Supliers";
            this.Supliers.Size = new System.Drawing.Size(106, 79);
            this.Supliers.TabIndex = 27;
            this.Supliers.Text = "Поставщики";
            this.Supliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Supliers.UseVisualStyleBackColor = true;
            this.Supliers.Click += new System.EventHandler(this.Supliers_Click);
            // 
            // Supplies
            // 
            this.Supplies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supplies.BackgroundImage")));
            this.Supplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Supplies.Location = new System.Drawing.Point(100, 222);
            this.Supplies.Name = "Supplies";
            this.Supplies.Size = new System.Drawing.Size(106, 79);
            this.Supplies.TabIndex = 28;
            this.Supplies.Text = "Поставки";
            this.Supplies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Supplies.UseVisualStyleBackColor = true;
            this.Supplies.Click += new System.EventHandler(this.Supplies_Click);
            // 
            // Departments
            // 
            this.Departments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Departments.BackgroundImage")));
            this.Departments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Departments.Location = new System.Drawing.Point(468, 108);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(106, 79);
            this.Departments.TabIndex = 29;
            this.Departments.Text = "Отделы";
            this.Departments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Departments.UseVisualStyleBackColor = true;
            this.Departments.Click += new System.EventHandler(this.Departments_Click);
            // 
            // Sales
            // 
            this.Sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sales.BackgroundImage")));
            this.Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sales.Location = new System.Drawing.Point(468, 222);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(106, 79);
            this.Sales.TabIndex = 30;
            this.Sales.Text = "Продажи";
            this.Sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Menu.Controls.Add(this.Sales);
            this.Menu.Controls.Add(this.Departments);
            this.Menu.Controls.Add(this.Supplies);
            this.Menu.Controls.Add(this.Supliers);
            this.Menu.Controls.Add(this.Promotions);
            this.Menu.Controls.Add(this.Staff);
            this.Menu.Controls.Add(this.Stocks);
            this.Menu.Controls.Add(this.Items);
            this.Menu.Controls.Add(this.menuPict);
            this.Menu.Location = new System.Drawing.Point(12, 83);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(646, 375);
            this.Menu.TabIndex = 34;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 505);
            this.Controls.Add(this.Exit_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товарооборот магазина";
            this.Account.ResumeLayout(false);
            this.Exit_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuPict)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Account;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Cur_User;
        private System.Windows.Forms.Button Other_Log;
        private System.Windows.Forms.Panel Exit_panel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox menuPict;
        private System.Windows.Forms.Button Items;
        private System.Windows.Forms.Button Stocks;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Promotions;
        private System.Windows.Forms.Button Supliers;
        private System.Windows.Forms.Button Supplies;
        private System.Windows.Forms.Button Departments;
        private System.Windows.Forms.Button Sales;
        private new System.Windows.Forms.Panel Menu;
    }
}