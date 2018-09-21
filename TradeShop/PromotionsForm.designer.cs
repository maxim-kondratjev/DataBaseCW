namespace TradeShop
{
    partial class PromotionsForm
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
            System.Windows.Forms.Label типLabel1;
            System.Windows.Forms.Label дата_начала_акцииLabel1;
            System.Windows.Forms.Label дата_конца_акцииLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromotionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.дата_конца_акцииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.акцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарооборот_магазинаDataSet = new TradeShop.Товарооборот_магазинаDataSet();
            this.дата_начала_акцииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Дата_конца = new System.Windows.Forms.DateTimePicker();
            this.Дата_начала = new System.Windows.Forms.DateTimePicker();
            this.Тип = new System.Windows.Forms.TextBox();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.акцияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.текущие_акцииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текущие_акцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.акцияTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.АкцияTableAdapter();
            this.tableAdapterManager = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager();
            this.текущие_акцииTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Текущие_акцииTableAdapter();
            типLabel1 = new System.Windows.Forms.Label();
            дата_начала_акцииLabel1 = new System.Windows.Forms.Label();
            дата_конца_акцииLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.акцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.текущие_акцииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.текущие_акцииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // типLabel1
            // 
            типLabel1.AutoSize = true;
            типLabel1.Location = new System.Drawing.Point(567, 33);
            типLabel1.Name = "типLabel1";
            типLabel1.Size = new System.Drawing.Size(29, 13);
            типLabel1.TabIndex = 20;
            типLabel1.Text = "Тип:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Дата начала акции:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дата конца акции:";
            // 
            // дата_начала_акцииLabel1
            // 
            дата_начала_акцииLabel1.AutoSize = true;
            дата_начала_акцииLabel1.Location = new System.Drawing.Point(489, 62);
            дата_начала_акцииLabel1.Name = "дата_начала_акцииLabel1";
            дата_начала_акцииLabel1.Size = new System.Drawing.Size(107, 13);
            дата_начала_акцииLabel1.TabIndex = 29;
            дата_начала_акцииLabel1.Text = "Дата начала акции:";
            // 
            // дата_конца_акцииLabel
            // 
            дата_конца_акцииLabel.AutoSize = true;
            дата_конца_акцииLabel.Location = new System.Drawing.Point(494, 88);
            дата_конца_акцииLabel.Name = "дата_конца_акцииLabel";
            дата_конца_акцииLabel.Size = new System.Drawing.Size(102, 13);
            дата_конца_акцииLabel.TabIndex = 30;
            дата_конца_акцииLabel.Text = "Дата конца акции:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 407);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(дата_конца_акцииLabel);
            this.tabPage3.Controls.Add(this.дата_конца_акцииDateTimePicker);
            this.tabPage3.Controls.Add(дата_начала_акцииLabel1);
            this.tabPage3.Controls.Add(this.дата_начала_акцииDateTimePicker);
            this.tabPage3.Controls.Add(this.Дата_конца);
            this.tabPage3.Controls.Add(this.Дата_начала);
            this.tabPage3.Controls.Add(this.Тип);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(типLabel1);
            this.tabPage3.Controls.Add(this.типTextBox);
            this.tabPage3.Controls.Add(this.Change);
            this.tabPage3.Controls.Add(this.Delete);
            this.tabPage3.Controls.Add(this.акцияDataGridView);
            this.tabPage3.Controls.Add(this.Update);
            this.tabPage3.Controls.Add(this.Add);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 381);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Полный список акций";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // дата_конца_акцииDateTimePicker
            // 
            this.дата_конца_акцииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.акцияBindingSource, "Дата конца акции", true));
            this.дата_конца_акцииDateTimePicker.Location = new System.Drawing.Point(607, 82);
            this.дата_конца_акцииDateTimePicker.Name = "дата_конца_акцииDateTimePicker";
            this.дата_конца_акцииDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.дата_конца_акцииDateTimePicker.TabIndex = 31;
            // 
            // акцияBindingSource
            // 
            this.акцияBindingSource.DataMember = "Акция";
            this.акцияBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарооборот_магазинаDataSet
            // 
            this.товарооборот_магазинаDataSet.DataSetName = "Товарооборот_магазинаDataSet";
            this.товарооборот_магазинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дата_начала_акцииDateTimePicker
            // 
            this.дата_начала_акцииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.акцияBindingSource, "Дата начала акции", true));
            this.дата_начала_акцииDateTimePicker.Location = new System.Drawing.Point(607, 56);
            this.дата_начала_акцииDateTimePicker.Name = "дата_начала_акцииDateTimePicker";
            this.дата_начала_акцииDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.дата_начала_акцииDateTimePicker.TabIndex = 30;
            // 
            // Дата_конца
            // 
            this.Дата_конца.Location = new System.Drawing.Point(607, 226);
            this.Дата_конца.Name = "Дата_конца";
            this.Дата_конца.Size = new System.Drawing.Size(158, 20);
            this.Дата_конца.TabIndex = 29;
            // 
            // Дата_начала
            // 
            this.Дата_начала.Location = new System.Drawing.Point(607, 200);
            this.Дата_начала.Name = "Дата_начала";
            this.Дата_начала.Size = new System.Drawing.Size(158, 20);
            this.Дата_начала.TabIndex = 28;
            // 
            // Тип
            // 
            this.Тип.Location = new System.Drawing.Point(607, 176);
            this.Тип.Name = "Тип";
            this.Тип.Size = new System.Drawing.Size(158, 20);
            this.Тип.TabIndex = 27;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.акцияBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(607, 30);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(158, 20);
            this.типTextBox.TabIndex = 21;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(607, 108);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.акцияDataGridView.DataSource = this.акцияBindingSource;
            this.акцияDataGridView.Location = new System.Drawing.Point(6, 6);
            this.акцияDataGridView.Name = "акцияDataGridView";
            this.акцияDataGridView.ReadOnly = true;
            this.акцияDataGridView.Size = new System.Drawing.Size(470, 328);
            this.акцияDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID акции";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID акции";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата начала акции";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала акции";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата конца акции";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата конца акции";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.Add.Location = new System.Drawing.Point(607, 252);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.текущие_акцииDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(782, 381);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Действующие акции";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // текущие_акцииDataGridView
            // 
            this.текущие_акцииDataGridView.AllowUserToAddRows = false;
            this.текущие_акцииDataGridView.AllowUserToDeleteRows = false;
            this.текущие_акцииDataGridView.AutoGenerateColumns = false;
            this.текущие_акцииDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.текущие_акцииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.текущие_акцииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.текущие_акцииDataGridView.DataSource = this.текущие_акцииBindingSource;
            this.текущие_акцииDataGridView.Location = new System.Drawing.Point(6, 6);
            this.текущие_акцииDataGridView.Name = "текущие_акцииDataGridView";
            this.текущие_акцииDataGridView.ReadOnly = true;
            this.текущие_акцииDataGridView.Size = new System.Drawing.Size(770, 369);
            this.текущие_акцииDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID акции";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID акции";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата начала акции";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата начала акции";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата конца акции";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата конца акции";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // текущие_акцииBindingSource
            // 
            this.текущие_акцииBindingSource.DataMember = "Текущие акции";
            this.текущие_акцииBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // акцияTableAdapter
            // 
            this.акцияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АкцияTableAdapter = this.акцияTableAdapter;
            this.tableAdapterManager.ОтделTableAdapter = null;
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
            // текущие_акцииTableAdapter
            // 
            this.текущие_акцииTableAdapter.ClearBeforeFill = true;
            // 
            // PromotionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 435);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PromotionsForm";
            this.Text = "Акции";
            this.Load += new System.EventHandler(this.PromotionsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.акцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.текущие_акцииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.текущие_акцииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Button Add;
        public new System.Windows.Forms.Button Update;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button Change;
        private System.Windows.Forms.DataGridView акцияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Товарооборот_магазинаDataSet товарооборот_магазинаDataSet;
        private System.Windows.Forms.BindingSource акцияBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.АкцияTableAdapter акцияTableAdapter;
        private Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.DateTimePicker Дата_конца;
        private System.Windows.Forms.DateTimePicker Дата_начала;
        private System.Windows.Forms.TextBox Тип;
        private System.Windows.Forms.DateTimePicker дата_конца_акцииDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_начала_акцииDateTimePicker;
        private System.Windows.Forms.BindingSource текущие_акцииBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Текущие_акцииTableAdapter текущие_акцииTableAdapter;
        private System.Windows.Forms.DataGridView текущие_акцииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}