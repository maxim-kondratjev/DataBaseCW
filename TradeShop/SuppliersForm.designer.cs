namespace TradeShop
{
    partial class SuppliersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label адресLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Suppliers_FL = new System.Windows.Forms.TabPage();
            this.Адрес = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарооборот_магазинаDataSet = new TradeShop.Товарооборот_магазинаDataSet();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.акцияDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Suppliers_Suply = new System.Windows.Forms.TabPage();
            this.Suplier = new System.Windows.Forms.ComboBox();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splrToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sup_SupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_SupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager();
            this.sup_SupTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Sup_SupTableAdapter();
            названиеLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Suppliers_FL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).BeginInit();
            this.Suppliers_Suply.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sup_SupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_SupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(511, 16);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 20;
            названиеLabel.Text = "Название:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(511, 42);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 22;
            адресLabel.Text = "Адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Адрес:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Suppliers_FL);
            this.tabControl.Controls.Add(this.Suppliers_Suply);
            this.tabControl.Location = new System.Drawing.Point(14, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 407);
            this.tabControl.TabIndex = 2;
            // 
            // Suppliers_FL
            // 
            this.Suppliers_FL.AutoScroll = true;
            this.Suppliers_FL.Controls.Add(this.Адрес);
            this.Suppliers_FL.Controls.Add(this.Название);
            this.Suppliers_FL.Controls.Add(this.label1);
            this.Suppliers_FL.Controls.Add(this.label2);
            this.Suppliers_FL.Controls.Add(названиеLabel);
            this.Suppliers_FL.Controls.Add(this.названиеTextBox);
            this.Suppliers_FL.Controls.Add(адресLabel);
            this.Suppliers_FL.Controls.Add(this.адресTextBox);
            this.Suppliers_FL.Controls.Add(this.Change);
            this.Suppliers_FL.Controls.Add(this.Delete);
            this.Suppliers_FL.Controls.Add(this.акцияDataGridView);
            this.Suppliers_FL.Controls.Add(this.Update);
            this.Suppliers_FL.Controls.Add(this.Add);
            this.Suppliers_FL.Location = new System.Drawing.Point(4, 22);
            this.Suppliers_FL.Name = "Suppliers_FL";
            this.Suppliers_FL.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers_FL.Size = new System.Drawing.Size(782, 381);
            this.Suppliers_FL.TabIndex = 0;
            this.Suppliers_FL.Text = "Полный список поставщиков";
            this.Suppliers_FL.UseVisualStyleBackColor = true;
            // 
            // Адрес
            // 
            this.Адрес.Location = new System.Drawing.Point(577, 164);
            this.Адрес.Name = "Адрес";
            this.Адрес.Size = new System.Drawing.Size(157, 20);
            this.Адрес.TabIndex = 28;
            // 
            // Название
            // 
            this.Название.Location = new System.Drawing.Point(577, 138);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(157, 20);
            this.Название.TabIndex = 27;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(577, 13);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(157, 20);
            this.названиеTextBox.TabIndex = 21;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарооборот_магазинаDataSet
            // 
            this.товарооборот_магазинаDataSet.DataSetName = "Товарооборот_магазинаDataSet";
            this.товарооборот_магазинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(577, 39);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(157, 20);
            this.адресTextBox.TabIndex = 23;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(576, 65);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(158, 23);
            this.Change.TabIndex = 20;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(6, 340);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // акцияDataGridView
            // 
            this.акцияDataGridView.AllowUserToAddRows = false;
            this.акцияDataGridView.AllowUserToDeleteRows = false;
            this.акцияDataGridView.AutoGenerateColumns = false;
            this.акцияDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.акцияDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.акцияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.акцияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.акцияDataGridView.DataSource = this.поставщикBindingSource;
            this.акцияDataGridView.Location = new System.Drawing.Point(6, 6);
            this.акцияDataGridView.Name = "акцияDataGridView";
            this.акцияDataGridView.ReadOnly = true;
            this.акцияDataGridView.Size = new System.Drawing.Size(470, 328);
            this.акцияDataGridView.TabIndex = 11;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(401, 340);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 11;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(576, 187);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Suppliers_Suply
            // 
            this.Suppliers_Suply.Controls.Add(this.Suplier);
            this.Suppliers_Suply.Controls.Add(this.fillToolStrip);
            this.Suppliers_Suply.Controls.Add(this.sup_SupDataGridView);
            this.Suppliers_Suply.Location = new System.Drawing.Point(4, 22);
            this.Suppliers_Suply.Name = "Suppliers_Suply";
            this.Suppliers_Suply.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers_Suply.Size = new System.Drawing.Size(782, 381);
            this.Suppliers_Suply.TabIndex = 1;
            this.Suppliers_Suply.Text = "Поставки постащиков";
            this.Suppliers_Suply.UseVisualStyleBackColor = true;
            // 
            // Suplier
            // 
            this.Suplier.DataSource = this.поставщикBindingSource;
            this.Suplier.DisplayMember = "Название";
            this.Suplier.FormattingEnabled = true;
            this.Suplier.Location = new System.Drawing.Point(188, 353);
            this.Suplier.Name = "Suplier";
            this.Suplier.Size = new System.Drawing.Size(195, 21);
            this.Suplier.TabIndex = 4;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton,
            this.splrToolStripLabel});
            this.fillToolStrip.Location = new System.Drawing.Point(3, 353);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(776, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillToolStripButton.Text = "Найти";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // splrToolStripLabel
            // 
            this.splrToolStripLabel.Name = "splrToolStripLabel";
            this.splrToolStripLabel.Size = new System.Drawing.Size(132, 22);
            this.splrToolStripLabel.Text = "Название поставщика:";
            // 
            // sup_SupDataGridView
            // 
            this.sup_SupDataGridView.AllowUserToAddRows = false;
            this.sup_SupDataGridView.AllowUserToDeleteRows = false;
            this.sup_SupDataGridView.AutoGenerateColumns = false;
            this.sup_SupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sup_SupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sup_SupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7});
            this.sup_SupDataGridView.DataSource = this.sup_SupBindingSource;
            this.sup_SupDataGridView.Location = new System.Drawing.Point(3, 3);
            this.sup_SupDataGridView.Name = "sup_SupDataGridView";
            this.sup_SupDataGridView.ReadOnly = true;
            this.sup_SupDataGridView.Size = new System.Drawing.Size(773, 347);
            this.sup_SupDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата поставки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата поставки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn12.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Количество товара";
            this.dataGridViewTextBoxColumn10.HeaderText = "Количество товара";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Склад";
            this.dataGridViewTextBoxColumn7.HeaderText = "Склад";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // sup_SupBindingSource
            // 
            this.sup_SupBindingSource.DataMember = "Sup_Sup";
            this.sup_SupBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АкцияTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Продажи_товаровTableAdapter = null;
            this.tableAdapterManager.РаботникTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СменаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Товары_в_поставкахTableAdapter = null;
            this.tableAdapterManager.Товары_на_складахTableAdapter = null;
            // 
            // sup_SupTableAdapter
            // 
            this.sup_SupTableAdapter.ClearBeforeFill = true;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SuppliersForm";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.tabControl.ResumeLayout(false);
            this.Suppliers_FL.ResumeLayout(false);
            this.Suppliers_FL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).EndInit();
            this.Suppliers_Suply.ResumeLayout(false);
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sup_SupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_SupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Suppliers_FL;
        public System.Windows.Forms.Button Change;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView акцияDataGridView;
        public new System.Windows.Forms.Button Update;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.TabPage Suppliers_Suply;
        private Товарооборот_магазинаDataSet товарооборот_магазинаDataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Адрес;
        private System.Windows.Forms.TextBox Название;
        private System.Windows.Forms.BindingSource sup_SupBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Sup_SupTableAdapter sup_SupTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel splrToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox Suplier;
        private System.Windows.Forms.DataGridView sup_SupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}