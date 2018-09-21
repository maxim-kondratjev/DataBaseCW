namespace TradeShop
{
    partial class DepartmentsForm
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
            System.Windows.Forms.Label наименование_отделаLabel;
            System.Windows.Forms.Label расположение_отделаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Dep_FL = new System.Windows.Forms.TabPage();
            this.Update = new System.Windows.Forms.Button();
            this.Расположение = new System.Windows.Forms.TextBox();
            this.Наименование = new System.Windows.Forms.TextBox();
            this.наименование_отделаTextBox = new System.Windows.Forms.TextBox();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарооборот_магазинаDataSet = new TradeShop.Товарооборот_магазинаDataSet();
            this.расположение_отделаTextBox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.акцияDataGridView = new System.Windows.Forms.DataGridView();
            this.iDОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расположениеОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Dep_Items = new System.Windows.Forms.TabPage();
            this.dep_ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dep = new System.Windows.Forms.ComboBox();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.depToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.акцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.ОтделTableAdapter();
            this.tableAdapterManager = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager();
            this.акцияTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.АкцияTableAdapter();
            this.dep_ItemTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Dep_ItemTableAdapter();
            наименование_отделаLabel = new System.Windows.Forms.Label();
            расположение_отделаLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Dep_FL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).BeginInit();
            this.Dep_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dep_ItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_ItemBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.акцияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // наименование_отделаLabel
            // 
            наименование_отделаLabel.AutoSize = true;
            наименование_отделаLabel.Location = new System.Drawing.Point(477, 52);
            наименование_отделаLabel.Name = "наименование_отделаLabel";
            наименование_отделаLabel.Size = new System.Drawing.Size(124, 13);
            наименование_отделаLabel.TabIndex = 22;
            наименование_отделаLabel.Text = "Наименование отдела:";
            // 
            // расположение_отделаLabel
            // 
            расположение_отделаLabel.AutoSize = true;
            расположение_отделаLabel.Location = new System.Drawing.Point(477, 78);
            расположение_отделаLabel.Name = "расположение_отделаLabel";
            расположение_отделаLabel.Size = new System.Drawing.Size(123, 13);
            расположение_отделаLabel.TabIndex = 24;
            расположение_отделаLabel.Text = "Расположение отдела:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Наименование отдела:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Расположение отдела:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Dep_FL);
            this.tabControl.Controls.Add(this.Dep_Items);
            this.tabControl.Location = new System.Drawing.Point(14, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 407);
            this.tabControl.TabIndex = 2;
            // 
            // Dep_FL
            // 
            this.Dep_FL.AutoScroll = true;
            this.Dep_FL.Controls.Add(this.Update);
            this.Dep_FL.Controls.Add(this.Расположение);
            this.Dep_FL.Controls.Add(this.Наименование);
            this.Dep_FL.Controls.Add(this.label1);
            this.Dep_FL.Controls.Add(this.label2);
            this.Dep_FL.Controls.Add(наименование_отделаLabel);
            this.Dep_FL.Controls.Add(this.наименование_отделаTextBox);
            this.Dep_FL.Controls.Add(расположение_отделаLabel);
            this.Dep_FL.Controls.Add(this.расположение_отделаTextBox);
            this.Dep_FL.Controls.Add(this.Change);
            this.Dep_FL.Controls.Add(this.Delete);
            this.Dep_FL.Controls.Add(this.акцияDataGridView);
            this.Dep_FL.Controls.Add(this.Add);
            this.Dep_FL.Location = new System.Drawing.Point(4, 22);
            this.Dep_FL.Name = "Dep_FL";
            this.Dep_FL.Padding = new System.Windows.Forms.Padding(3);
            this.Dep_FL.Size = new System.Drawing.Size(782, 381);
            this.Dep_FL.TabIndex = 0;
            this.Dep_FL.Text = "Полный список отделов";
            this.Dep_FL.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(401, 340);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 31;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Расположение
            // 
            this.Расположение.Location = new System.Drawing.Point(607, 196);
            this.Расположение.Name = "Расположение";
            this.Расположение.Size = new System.Drawing.Size(158, 20);
            this.Расположение.TabIndex = 30;
            // 
            // Наименование
            // 
            this.Наименование.Location = new System.Drawing.Point(607, 170);
            this.Наименование.Name = "Наименование";
            this.Наименование.Size = new System.Drawing.Size(158, 20);
            this.Наименование.TabIndex = 29;
            // 
            // наименование_отделаTextBox
            // 
            this.наименование_отделаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделBindingSource, "Наименование отдела", true));
            this.наименование_отделаTextBox.Location = new System.Drawing.Point(607, 49);
            this.наименование_отделаTextBox.Name = "наименование_отделаTextBox";
            this.наименование_отделаTextBox.Size = new System.Drawing.Size(158, 20);
            this.наименование_отделаTextBox.TabIndex = 23;
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарооборот_магазинаDataSet
            // 
            this.товарооборот_магазинаDataSet.DataSetName = "Товарооборот_магазинаDataSet";
            this.товарооборот_магазинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расположение_отделаTextBox
            // 
            this.расположение_отделаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделBindingSource, "Расположение отдела", true));
            this.расположение_отделаTextBox.Location = new System.Drawing.Point(607, 75);
            this.расположение_отделаTextBox.Name = "расположение_отделаTextBox";
            this.расположение_отделаTextBox.Size = new System.Drawing.Size(158, 20);
            this.расположение_отделаTextBox.TabIndex = 25;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(607, 101);
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
            this.iDОтделаDataGridViewTextBoxColumn,
            this.наименованиеОтделаDataGridViewTextBoxColumn,
            this.расположениеОтделаDataGridViewTextBoxColumn});
            this.акцияDataGridView.DataSource = this.отделBindingSource;
            this.акцияDataGridView.Location = new System.Drawing.Point(6, 6);
            this.акцияDataGridView.Name = "акцияDataGridView";
            this.акцияDataGridView.ReadOnly = true;
            this.акцияDataGridView.Size = new System.Drawing.Size(470, 328);
            this.акцияDataGridView.TabIndex = 11;
            // 
            // iDОтделаDataGridViewTextBoxColumn
            // 
            this.iDОтделаDataGridViewTextBoxColumn.DataPropertyName = "ID отдела";
            this.iDОтделаDataGridViewTextBoxColumn.HeaderText = "ID отдела";
            this.iDОтделаDataGridViewTextBoxColumn.Name = "iDОтделаDataGridViewTextBoxColumn";
            this.iDОтделаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеОтделаDataGridViewTextBoxColumn
            // 
            this.наименованиеОтделаDataGridViewTextBoxColumn.DataPropertyName = "Наименование отдела";
            this.наименованиеОтделаDataGridViewTextBoxColumn.HeaderText = "Наименование отдела";
            this.наименованиеОтделаDataGridViewTextBoxColumn.Name = "наименованиеОтделаDataGridViewTextBoxColumn";
            this.наименованиеОтделаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // расположениеОтделаDataGridViewTextBoxColumn
            // 
            this.расположениеОтделаDataGridViewTextBoxColumn.DataPropertyName = "Расположение отдела";
            this.расположениеОтделаDataGridViewTextBoxColumn.HeaderText = "Расположение отдела";
            this.расположениеОтделаDataGridViewTextBoxColumn.Name = "расположениеОтделаDataGridViewTextBoxColumn";
            this.расположениеОтделаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(607, 222);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Dep_Items
            // 
            this.Dep_Items.AutoScroll = true;
            this.Dep_Items.Controls.Add(this.dep_ItemDataGridView);
            this.Dep_Items.Controls.Add(this.dep);
            this.Dep_Items.Controls.Add(this.fillToolStrip);
            this.Dep_Items.Location = new System.Drawing.Point(4, 22);
            this.Dep_Items.Name = "Dep_Items";
            this.Dep_Items.Padding = new System.Windows.Forms.Padding(3);
            this.Dep_Items.Size = new System.Drawing.Size(782, 381);
            this.Dep_Items.TabIndex = 1;
            this.Dep_Items.Text = "Товары по отделам";
            this.Dep_Items.UseVisualStyleBackColor = true;
            // 
            // dep_ItemDataGridView
            // 
            this.dep_ItemDataGridView.AllowUserToAddRows = false;
            this.dep_ItemDataGridView.AllowUserToDeleteRows = false;
            this.dep_ItemDataGridView.AutoGenerateColumns = false;
            this.dep_ItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dep_ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dep_ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dep_ItemDataGridView.DataSource = this.dep_ItemBindingSource;
            this.dep_ItemDataGridView.Location = new System.Drawing.Point(6, 6);
            this.dep_ItemDataGridView.Name = "dep_ItemDataGridView";
            this.dep_ItemDataGridView.ReadOnly = true;
            this.dep_ItemDataGridView.Size = new System.Drawing.Size(770, 342);
            this.dep_ItemDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Артикул";
            this.dataGridViewTextBoxColumn1.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dep_ItemBindingSource
            // 
            this.dep_ItemBindingSource.DataMember = "Dep_Item";
            this.dep_ItemBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // dep
            // 
            this.dep.DataSource = this.отделBindingSource;
            this.dep.DisplayMember = "Наименование отдела";
            this.dep.FormattingEnabled = true;
            this.dep.Location = new System.Drawing.Point(194, 354);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(182, 21);
            this.dep.TabIndex = 4;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton,
            this.depToolStripLabel});
            this.fillToolStrip.Location = new System.Drawing.Point(6, 353);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(465, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillToolStripButton.Text = "Найти";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // depToolStripLabel
            // 
            this.depToolStripLabel.Name = "depToolStripLabel";
            this.depToolStripLabel.Size = new System.Drawing.Size(133, 22);
            this.depToolStripLabel.Text = "Наименование отдела:";
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АкцияTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = this.отделTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Продажи_товаровTableAdapter = null;
            this.tableAdapterManager.РаботникTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СменаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Товары_в_поставкахTableAdapter = null;
            this.tableAdapterManager.Товары_на_складахTableAdapter = null;
            // 
            // акцияTableAdapter
            // 
            this.акцияTableAdapter.ClearBeforeFill = true;
            // 
            // dep_ItemTableAdapter
            // 
            this.dep_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DepartmentsForm";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.Dep_FL.ResumeLayout(false);
            this.Dep_FL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).EndInit();
            this.Dep_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dep_ItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dep_ItemBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.акцияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Dep_FL;
        public System.Windows.Forms.Button Change;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView акцияDataGridView;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.TabPage Dep_Items;
        private Товарооборот_магазинаDataSet товарооборот_магазинаDataSet;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox наименование_отделаTextBox;
        private System.Windows.Forms.TextBox расположение_отделаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расположениеОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Расположение;
        private System.Windows.Forms.TextBox Наименование;
        private System.Windows.Forms.BindingSource акцияBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.АкцияTableAdapter акцияTableAdapter;
        private System.Windows.Forms.ComboBox dep;
        public new System.Windows.Forms.Button Update;
        private System.Windows.Forms.BindingSource dep_ItemBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Dep_ItemTableAdapter dep_ItemTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel depToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView dep_ItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}