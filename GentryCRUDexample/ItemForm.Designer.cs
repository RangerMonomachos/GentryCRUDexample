
namespace GentryCRUDexample
{
    partial class ItemForm
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
            this.HomeBotton = new System.Windows.Forms.Button();
            this.PeopleBotton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adventureWorksLT2019DataSet = new GentryCRUDexample.AdventureWorksLT2019DataSet();
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productViewTableAdapter = new GentryCRUDexample.AdventureWorksLT2019DataSetTableAdapters.productViewTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catigoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBotton
            // 
            this.HomeBotton.Location = new System.Drawing.Point(13, 13);
            this.HomeBotton.Name = "HomeBotton";
            this.HomeBotton.Size = new System.Drawing.Size(75, 23);
            this.HomeBotton.TabIndex = 0;
            this.HomeBotton.Text = "Home";
            this.HomeBotton.UseVisualStyleBackColor = true;
            this.HomeBotton.Click += new System.EventHandler(this.HomeBotton_Click);
            // 
            // PeopleBotton
            // 
            this.PeopleBotton.Location = new System.Drawing.Point(95, 12);
            this.PeopleBotton.Name = "PeopleBotton";
            this.PeopleBotton.Size = new System.Drawing.Size(75, 23);
            this.PeopleBotton.TabIndex = 1;
            this.PeopleBotton.Text = "People";
            this.PeopleBotton.UseVisualStyleBackColor = true;
            this.PeopleBotton.Click += new System.EventHandler(this.PeopleBotton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.catigoryNameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn,
            this.sellStartDateDataGridViewTextBoxColumn,
            this.sellEndDateDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // adventureWorksLT2019DataSet
            // 
            this.adventureWorksLT2019DataSet.DataSetName = "AdventureWorksLT2019DataSet";
            this.adventureWorksLT2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataMember = "productView";
            this.productViewBindingSource.DataSource = this.adventureWorksLT2019DataSet;
            // 
            // productViewTableAdapter
            // 
            this.productViewTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "product name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "product name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // catigoryNameDataGridViewTextBoxColumn
            // 
            this.catigoryNameDataGridViewTextBoxColumn.DataPropertyName = "catigory name";
            this.catigoryNameDataGridViewTextBoxColumn.HeaderText = "catigory name";
            this.catigoryNameDataGridViewTextBoxColumn.Name = "catigoryNameDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            // 
            // sellStartDateDataGridViewTextBoxColumn
            // 
            this.sellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.Name = "sellStartDateDataGridViewTextBoxColumn";
            // 
            // sellEndDateDataGridViewTextBoxColumn
            // 
            this.sellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.HeaderText = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.Name = "sellEndDateDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PeopleBotton);
            this.Controls.Add(this.HomeBotton);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBotton;
        private System.Windows.Forms.Button PeopleBotton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorksLT2019DataSet adventureWorksLT2019DataSet;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private AdventureWorksLT2019DataSetTableAdapters.productViewTableAdapter productViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catigoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
    }
}