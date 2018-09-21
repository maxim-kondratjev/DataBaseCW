namespace TradeShop
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.Main_StartForm_panel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.ComboBox();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарооборот_магазинаDataSet = new TradeShop.Товарооборот_магазинаDataSet();
            this.MainPict = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.ProgramName = new System.Windows.Forms.Label();
            this.пользователиTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.ПользователиTableAdapter();
            this.Main_StartForm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPict)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_StartForm_panel
            // 
            this.Main_StartForm_panel.AutoSize = true;
            this.Main_StartForm_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_StartForm_panel.Controls.Add(this.login);
            this.Main_StartForm_panel.Controls.Add(this.MainPict);
            this.Main_StartForm_panel.Controls.Add(this.password);
            this.Main_StartForm_panel.Controls.Add(this.pass_label);
            this.Main_StartForm_panel.Controls.Add(this.login_label);
            this.Main_StartForm_panel.Controls.Add(this.Login_button);
            this.Main_StartForm_panel.Controls.Add(this.ProgramName);
            this.Main_StartForm_panel.Location = new System.Drawing.Point(12, 12);
            this.Main_StartForm_panel.Name = "Main_StartForm_panel";
            this.Main_StartForm_panel.Size = new System.Drawing.Size(340, 375);
            this.Main_StartForm_panel.TabIndex = 11;
            // 
            // login
            // 
            this.login.DataSource = this.пользователиBindingSource;
            this.login.DisplayMember = "login";
            this.login.FormattingEnabled = true;
            this.login.Location = new System.Drawing.Point(75, 226);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(208, 21);
            this.login.TabIndex = 21;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарооборот_магазинаDataSet
            // 
            this.товарооборот_магазинаDataSet.DataSetName = "Товарооборот_магазинаDataSet";
            this.товарооборот_магазинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainPict
            // 
            this.MainPict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPict.BackgroundImage")));
            this.MainPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPict.Location = new System.Drawing.Point(34, 84);
            this.MainPict.Name = "MainPict";
            this.MainPict.Size = new System.Drawing.Size(288, 123);
            this.MainPict.TabIndex = 20;
            this.MainPict.TabStop = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(75, 267);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(208, 20);
            this.password.TabIndex = 19;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(31, 270);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(45, 13);
            this.pass_label.TabIndex = 17;
            this.pass_label.Text = "Пароль";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(31, 226);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(38, 13);
            this.login_label.TabIndex = 16;
            this.login_label.Text = "Логин";
            // 
            // Login_button
            // 
            this.Login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_button.Location = new System.Drawing.Point(75, 322);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(208, 50);
            this.Login_button.TabIndex = 15;
            this.Login_button.Text = "Войти";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramName.Location = new System.Drawing.Point(19, 40);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(318, 25);
            this.ProgramName.TabIndex = 9;
            this.ProgramName.Text = "АИС \"Товарооборот магазина\"";
            this.ProgramName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 402);
            this.Controls.Add(this.Main_StartForm_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товарооборот магазина";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.Main_StartForm_panel.ResumeLayout(false);
            this.Main_StartForm_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Main_StartForm_panel;
        private System.Windows.Forms.PictureBox MainPict;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.ComboBox login;
        private Товарооборот_магазинаDataSet товарооборот_магазинаDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
    }
}

