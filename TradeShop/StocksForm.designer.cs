namespace TradeShop
{
    partial class StocksForm
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
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label вместимостьLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocksForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Stocks_FL = new System.Windows.Forms.TabPage();
            this.Вместимость = new System.Windows.Forms.TextBox();
            this.Адрес = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарооборот_магазинаDataSet = new TradeShop.Товарооборот_магазинаDataSet();
            this.вместимостьTextBox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.акцияDataGridView = new System.Windows.Forms.DataGridView();
            this.iDСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Stock_Item = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stocksoccupationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stock = new System.Windows.Forms.ComboBox();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stockToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stock_ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager();
            this.stock_ItemsTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Stock_ItemsTableAdapter();
            this.fKТоварыНаСкладахСкладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товары_на_складахTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Товары_на_складахTableAdapter();
            this.stocks_occupationTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.Stocks_occupationTableAdapter();
            this.ItemsInStocks = new System.Windows.Forms.TabPage();
            this.товары_на_складахDataGridView = new System.Windows.Forms.DataGridView();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new TradeShop.Товарооборот_магазинаDataSetTableAdapters.ТоварTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.складDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоТовараНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            адресLabel = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Stocks_FL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).BeginInit();
            this.Stock_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksoccupationBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварыНаСкладахСкладBindingSource)).BeginInit();
            this.ItemsInStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_на_складахDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(508, 22);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 20;
            адресLabel.Text = "Адрес:";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Location = new System.Drawing.Point(508, 48);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(79, 13);
            вместимостьLabel.TabIndex = 22;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Вместимость:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Stocks_FL);
            this.tabControl.Controls.Add(this.ItemsInStocks);
            this.tabControl.Controls.Add(this.Stock_Item);
            this.tabControl.Location = new System.Drawing.Point(14, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 407);
            this.tabControl.TabIndex = 2;
            // 
            // Stocks_FL
            // 
            this.Stocks_FL.AutoScroll = true;
            this.Stocks_FL.Controls.Add(this.Вместимость);
            this.Stocks_FL.Controls.Add(this.Адрес);
            this.Stocks_FL.Controls.Add(this.label1);
            this.Stocks_FL.Controls.Add(this.label2);
            this.Stocks_FL.Controls.Add(адресLabel);
            this.Stocks_FL.Controls.Add(this.адресTextBox);
            this.Stocks_FL.Controls.Add(вместимостьLabel);
            this.Stocks_FL.Controls.Add(this.вместимостьTextBox);
            this.Stocks_FL.Controls.Add(this.Change);
            this.Stocks_FL.Controls.Add(this.Delete);
            this.Stocks_FL.Controls.Add(this.акцияDataGridView);
            this.Stocks_FL.Controls.Add(this.Update);
            this.Stocks_FL.Controls.Add(this.Add);
            this.Stocks_FL.Location = new System.Drawing.Point(4, 22);
            this.Stocks_FL.Name = "Stocks_FL";
            this.Stocks_FL.Padding = new System.Windows.Forms.Padding(3);
            this.Stocks_FL.Size = new System.Drawing.Size(782, 381);
            this.Stocks_FL.TabIndex = 0;
            this.Stocks_FL.Text = "Полный список складов";
            this.Stocks_FL.UseVisualStyleBackColor = true;
            // 
            // Вместимость
            // 
            this.Вместимость.Location = new System.Drawing.Point(593, 162);
            this.Вместимость.Name = "Вместимость";
            this.Вместимость.Size = new System.Drawing.Size(158, 20);
            this.Вместимость.TabIndex = 28;
            // 
            // Адрес
            // 
            this.Адрес.Location = new System.Drawing.Point(593, 136);
            this.Адрес.Name = "Адрес";
            this.Адрес.Size = new System.Drawing.Size(158, 20);
            this.Адрес.TabIndex = 27;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(593, 19);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(158, 20);
            this.адресTextBox.TabIndex = 21;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарооборот_магазинаDataSet
            // 
            this.товарооборот_магазинаDataSet.DataSetName = "Товарооборот_магазинаDataSet";
            this.товарооборот_магазинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вместимостьTextBox
            // 
            this.вместимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Вместимость", true));
            this.вместимостьTextBox.Location = new System.Drawing.Point(593, 45);
            this.вместимостьTextBox.Name = "вместимостьTextBox";
            this.вместимостьTextBox.Size = new System.Drawing.Size(158, 20);
            this.вместимостьTextBox.TabIndex = 23;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(593, 71);
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
            this.iDСкладаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn});
            this.акцияDataGridView.DataSource = this.складBindingSource;
            this.акцияDataGridView.Location = new System.Drawing.Point(6, 6);
            this.акцияDataGridView.Name = "акцияDataGridView";
            this.акцияDataGridView.ReadOnly = true;
            this.акцияDataGridView.Size = new System.Drawing.Size(470, 328);
            this.акцияDataGridView.TabIndex = 11;
            // 
            // iDСкладаDataGridViewTextBoxColumn
            // 
            this.iDСкладаDataGridViewTextBoxColumn.DataPropertyName = "ID склада";
            this.iDСкладаDataGridViewTextBoxColumn.HeaderText = "ID склада";
            this.iDСкладаDataGridViewTextBoxColumn.Name = "iDСкладаDataGridViewTextBoxColumn";
            this.iDСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            this.вместимостьDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Add.Location = new System.Drawing.Point(593, 188);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Stock_Item
            // 
            this.Stock_Item.Controls.Add(this.chart1);
            this.Stock_Item.Controls.Add(this.Stock);
            this.Stock_Item.Controls.Add(this.fillToolStrip);
            this.Stock_Item.Controls.Add(this.stock_ItemsDataGridView);
            this.Stock_Item.Location = new System.Drawing.Point(4, 22);
            this.Stock_Item.Name = "Stock_Item";
            this.Stock_Item.Padding = new System.Windows.Forms.Padding(3);
            this.Stock_Item.Size = new System.Drawing.Size(782, 381);
            this.Stock_Item.TabIndex = 1;
            this.Stock_Item.Text = "Содержимое склада";
            this.Stock_Item.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.stocksoccupationBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(381, 6);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Занятость";
            series1.XValueMember = "Адрес";
            series1.YValueMembers = "Занятость";
            series2.ChartArea = "ChartArea1";
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.Name = "Вместимость";
            series2.XValueMember = "Адрес";
            series2.YValueMembers = "Вместимость";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(395, 344);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // stocksoccupationBindingSource
            // 
            this.stocksoccupationBindingSource.DataMember = "Stocks_occupation";
            this.stocksoccupationBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // Stock
            // 
            this.Stock.DataSource = this.складBindingSource;
            this.Stock.DisplayMember = "Адрес";
            this.Stock.FormattingEnabled = true;
            this.Stock.Location = new System.Drawing.Point(142, 356);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(189, 21);
            this.Stock.TabIndex = 4;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton,
            this.stockToolStripLabel});
            this.fillToolStrip.Location = new System.Drawing.Point(6, 353);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(770, 25);
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
            // stockToolStripLabel
            // 
            this.stockToolStripLabel.Name = "stockToolStripLabel";
            this.stockToolStripLabel.Size = new System.Drawing.Size(83, 22);
            this.stockToolStripLabel.Text = "Адрес склада:";
            // 
            // stock_ItemsDataGridView
            // 
            this.stock_ItemsDataGridView.AllowUserToAddRows = false;
            this.stock_ItemsDataGridView.AllowUserToDeleteRows = false;
            this.stock_ItemsDataGridView.AutoGenerateColumns = false;
            this.stock_ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stock_ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6});
            this.stock_ItemsDataGridView.DataSource = this.stock_ItemsBindingSource;
            this.stock_ItemsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.stock_ItemsDataGridView.Name = "stock_ItemsDataGridView";
            this.stock_ItemsDataGridView.ReadOnly = true;
            this.stock_ItemsDataGridView.Size = new System.Drawing.Size(369, 344);
            this.stock_ItemsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn8.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Количество товара на складе";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество товара на складе";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // stock_ItemsBindingSource
            // 
            this.stock_ItemsBindingSource.DataMember = "Stock_Items";
            this.stock_ItemsBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TradeShop.Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АкцияTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Продажи_товаровTableAdapter = null;
            this.tableAdapterManager.РаботникTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.СменаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            this.tableAdapterManager.Товары_в_поставкахTableAdapter = null;
            this.tableAdapterManager.Товары_на_складахTableAdapter = this.товары_на_складахTableAdapter;
            // 
            // stock_ItemsTableAdapter
            // 
            this.stock_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // fKТоварыНаСкладахСкладBindingSource
            // 
            this.fKТоварыНаСкладахСкладBindingSource.DataMember = "FK_Товары на складах_Склад";
            this.fKТоварыНаСкладахСкладBindingSource.DataSource = this.складBindingSource;
            // 
            // товары_на_складахTableAdapter
            // 
            this.товары_на_складахTableAdapter.ClearBeforeFill = true;
            // 
            // stocks_occupationTableAdapter
            // 
            this.stocks_occupationTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsInStocks
            // 
            this.ItemsInStocks.Controls.Add(this.button1);
            this.ItemsInStocks.Controls.Add(this.button2);
            this.ItemsInStocks.Controls.Add(this.товары_на_складахDataGridView);
            this.ItemsInStocks.Location = new System.Drawing.Point(4, 22);
            this.ItemsInStocks.Name = "ItemsInStocks";
            this.ItemsInStocks.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsInStocks.Size = new System.Drawing.Size(782, 381);
            this.ItemsInStocks.TabIndex = 2;
            this.ItemsInStocks.Text = "Товары на складе";
            this.ItemsInStocks.UseVisualStyleBackColor = true;
            // 
            // товары_на_складахDataGridView
            // 
            this.товары_на_складахDataGridView.AutoGenerateColumns = false;
            this.товары_на_складахDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.товары_на_складахDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товары_на_складахDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.товарDataGridViewTextBoxColumn,
            this.складDataGridViewTextBoxColumn,
            this.количествоТовараНаСкладеDataGridViewTextBoxColumn});
            this.товары_на_складахDataGridView.DataSource = this.fKТоварыНаСкладахСкладBindingSource;
            this.товары_на_складахDataGridView.Location = new System.Drawing.Point(6, 6);
            this.товары_на_складахDataGridView.Name = "товары_на_складахDataGridView";
            this.товары_на_складахDataGridView.Size = new System.Drawing.Size(770, 342);
            this.товары_на_складахDataGridView.TabIndex = 0;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.товарооборот_магазинаDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.DataSource = this.товарBindingSource;
            this.товарDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            this.товарDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.товарDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.товарDataGridViewTextBoxColumn.ValueMember = "Артикул";
            // 
            // складDataGridViewTextBoxColumn
            // 
            this.складDataGridViewTextBoxColumn.DataPropertyName = "Склад";
            this.складDataGridViewTextBoxColumn.DataSource = this.складBindingSource;
            this.складDataGridViewTextBoxColumn.DisplayMember = "Адрес";
            this.складDataGridViewTextBoxColumn.HeaderText = "Склад";
            this.складDataGridViewTextBoxColumn.Name = "складDataGridViewTextBoxColumn";
            this.складDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.складDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.складDataGridViewTextBoxColumn.ValueMember = "ID склада";
            // 
            // количествоТовараНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоТовараНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество товара на складе";
            this.количествоТовараНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество товара на складе";
            this.количествоТовараНаСкладеDataGridViewTextBoxColumn.Name = "количествоТовараНаСкладеDataGridViewTextBoxColumn";
            // 
            // StocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StocksForm";
            this.Text = "Склады";
            this.Load += new System.EventHandler(this.StocksForm_Load);
            this.tabControl.ResumeLayout(false);
            this.Stocks_FL.ResumeLayout(false);
            this.Stocks_FL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарооборот_магазинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцияDataGridView)).EndInit();
            this.Stock_Item.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksoccupationBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварыНаСкладахСкладBindingSource)).EndInit();
            this.ItemsInStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.товары_на_складахDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Stocks_FL;
        public System.Windows.Forms.Button Change;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView акцияDataGridView;
        public new System.Windows.Forms.Button Update;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.TabPage Stock_Item;
        private Товарооборот_магазинаDataSet товарооборот_магазинаDataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private Товарооборот_магазинаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox вместимостьTextBox;
        private System.Windows.Forms.TextBox Вместимость;
        private System.Windows.Forms.TextBox Адрес;
        private System.Windows.Forms.BindingSource stock_ItemsBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Stock_ItemsTableAdapter stock_ItemsTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel stockToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox Stock;
        private System.Windows.Forms.DataGridView stock_ItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKТоварыНаСкладахСкладBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Товары_на_складахTableAdapter товары_на_складахTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource stocksoccupationBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.Stocks_occupationTableAdapter stocks_occupationTableAdapter;
        private System.Windows.Forms.TabPage ItemsInStocks;
        private System.Windows.Forms.DataGridView товары_на_складахDataGridView;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Товарооборот_магазинаDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn складDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоТовараНаСкладеDataGridViewTextBoxColumn;
    }
}