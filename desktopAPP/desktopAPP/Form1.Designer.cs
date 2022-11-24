namespace desktopAPP
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regionDataGridView = new System.Windows.Forms.DataGridView();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Search_DataSet = new desktopAPP.Product_Search_DataSet();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.paymentTypeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paymentTypeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.paymentTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleKeywordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.titleKeywordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productTableAdapter = new desktopAPP.Product_Search_DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new desktopAPP.Product_Search_DataSetTableAdapters.TableAdapterManager();
            this.paymentTypeTableAdapter = new desktopAPP.Product_Search_DataSetTableAdapters.PaymentTypeTableAdapter();
            this.regionTableAdapter = new desktopAPP.Product_Search_DataSetTableAdapters.RegionTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.regionIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.regionIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Search_DataSet)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fillBy3ToolStrip);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.regionDataGridView);
            this.tabPage1.Controls.Add(this.fillBy2ToolStrip);
            this.tabPage1.Controls.Add(this.paymentTypeDataGridView);
            this.tabPage1.Controls.Add(this.fillBy1ToolStrip);
            this.tabPage1.Controls.Add(this.fillByToolStrip);
            this.tabPage1.Controls.Add(this.productDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SerchProduct";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(43, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Information";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(354, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Region Reference";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(43, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payment Type Reference";
            // 
            // regionDataGridView
            // 
            this.regionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionDataGridView.AutoGenerateColumns = false;
            this.regionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.regionDataGridView.DataSource = this.regionBindingSource;
            this.regionDataGridView.Location = new System.Drawing.Point(308, 406);
            this.regionDataGridView.Name = "regionDataGridView";
            this.regionDataGridView.RowTemplate.Height = 24;
            this.regionDataGridView.Size = new System.Drawing.Size(670, 196);
            this.regionDataGridView.TabIndex = 5;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.product_Search_DataSet;
            // 
            // product_Search_DataSet
            // 
            this.product_Search_DataSet.DataSetName = "Product_Search_DataSet";
            this.product_Search_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.fillBy2ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy2ToolStrip.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentTypeToolStripLabel,
            this.paymentTypeToolStripTextBox,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(402, 3);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(278, 25);
            this.fillBy2ToolStrip.TabIndex = 1;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // paymentTypeToolStripLabel
            // 
            this.paymentTypeToolStripLabel.Name = "paymentTypeToolStripLabel";
            this.paymentTypeToolStripLabel.Size = new System.Drawing.Size(104, 22);
            this.paymentTypeToolStripLabel.Text = "paymentType:";
            // 
            // paymentTypeToolStripTextBox
            // 
            this.paymentTypeToolStripTextBox.Name = "paymentTypeToolStripTextBox";
            this.paymentTypeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.fillBy2ToolStripButton.Text = "Search";
            this.fillBy2ToolStripButton.ToolTipText = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // paymentTypeDataGridView
            // 
            this.paymentTypeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentTypeDataGridView.AutoGenerateColumns = false;
            this.paymentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.paymentTypeDataGridView.DataSource = this.paymentTypeBindingSource;
            this.paymentTypeDataGridView.Location = new System.Drawing.Point(0, 406);
            this.paymentTypeDataGridView.Name = "paymentTypeDataGridView";
            this.paymentTypeDataGridView.RowTemplate.Height = 24;
            this.paymentTypeDataGridView.Size = new System.Drawing.Size(302, 196);
            this.paymentTypeDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "paymentID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "typename";
            this.dataGridViewTextBoxColumn8.HeaderText = "typename";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // paymentTypeBindingSource
            // 
            this.paymentTypeBindingSource.DataMember = "PaymentType";
            this.paymentTypeBindingSource.DataSource = this.product_Search_DataSet;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy1ToolStrip.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel,
            this.idToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(3, 3);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(238, 25);
            this.fillBy1ToolStrip.TabIndex = 1;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // idToolStripLabel
            // 
            this.idToolStripLabel.Name = "idToolStripLabel";
            this.idToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.idToolStripLabel.Text = "bookID:";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.fillBy1ToolStripButton.Text = "Search";
            this.fillBy1ToolStripButton.ToolTipText = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleKeywordToolStripLabel,
            this.titleKeywordToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(402, 28);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(286, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // titleKeywordToolStripLabel
            // 
            this.titleKeywordToolStripLabel.Name = "titleKeywordToolStripLabel";
            this.titleKeywordToolStripLabel.Size = new System.Drawing.Size(112, 22);
            this.titleKeywordToolStripLabel.Text = "titleKeyword:";
            // 
            // titleKeywordToolStripTextBox
            // 
            this.titleKeywordToolStripTextBox.Name = "titleKeywordToolStripTextBox";
            this.titleKeywordToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.fillByToolStripButton.Text = "Search";
            this.fillByToolStripButton.ToolTipText = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // productDataGridView
            // 
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(0, 97);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(984, 263);
            this.productDataGridView.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.product_Search_DataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopAPP.Product_Search_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentTypeTableAdapter
            // 
            this.paymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn9.HeaderText = "regionID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn10.HeaderText = "country";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn11.HeaderText = "location";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "bookID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "paymentID";
            this.dataGridViewTextBoxColumn3.HeaderText = "paymentID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "countryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "regionID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn5.HeaderText = "condition";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.fillBy3ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy3ToolStrip.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regionIDToolStripLabel,
            this.regionIDToolStripTextBox,
            this.fillBy3ToolStripButton});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(3, 28);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(254, 25);
            this.fillBy3ToolStrip.TabIndex = 1;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            // 
            // regionIDToolStripLabel
            // 
            this.regionIDToolStripLabel.Name = "regionIDToolStripLabel";
            this.regionIDToolStripLabel.Size = new System.Drawing.Size(80, 22);
            this.regionIDToolStripLabel.Text = "regionID:";
            // 
            // regionIDToolStripTextBox
            // 
            this.regionIDToolStripTextBox.Name = "regionIDToolStripTextBox";
            this.regionIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.fillBy3ToolStripButton.Text = "Search";
            this.fillBy3ToolStripButton.ToolTipText = "FillBy3";
            this.fillBy3ToolStripButton.Click += new System.EventHandler(this.fillBy3ToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Textbook Changed System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Search_DataSet)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Product_Search_DataSet product_Search_DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Product_Search_DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private Product_Search_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel titleKeywordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox titleKeywordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel paymentTypeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paymentTypeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private Product_Search_DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter;
        private System.Windows.Forms.DataGridView paymentTypeDataGridView;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private Product_Search_DataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.DataGridView regionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripLabel regionIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox regionIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
    }
}

