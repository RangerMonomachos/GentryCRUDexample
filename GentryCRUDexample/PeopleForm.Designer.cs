
namespace GentryCRUDexample
{
    partial class PeopleForm
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.ItemBotton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adventureWorksLT2019DataSet = new GentryCRUDexample.AdventureWorksLT2019DataSet();
            this.adventureWorksLT2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2019DataSet1 = new GentryCRUDexample.AdventureWorksLT2019DataSet1();
            this.getCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomersTableAdapter = new GentryCRUDexample.AdventureWorksLT2019DataSet1TableAdapters.GetCustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordSaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleatBotten = new System.Windows.Forms.Button();
            this.InsertUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(13, 13);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ItemBotton
            // 
            this.ItemBotton.Location = new System.Drawing.Point(95, 12);
            this.ItemBotton.Name = "ItemBotton";
            this.ItemBotton.Size = new System.Drawing.Size(75, 23);
            this.ItemBotton.TabIndex = 1;
            this.ItemBotton.Text = "Items";
            this.ItemBotton.UseVisualStyleBackColor = true;
            this.ItemBotton.Click += new System.EventHandler(this.ItemBotton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.suffixDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.salesPersonDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.passwordSaltDataGridViewTextBoxColumn,
            this.addressIDDataGridViewTextBoxColumn,
            this.addressTypeDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateProvinceDataGridViewTextBoxColumn,
            this.countryRegionDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCustomersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // adventureWorksLT2019DataSet
            // 
            this.adventureWorksLT2019DataSet.DataSetName = "AdventureWorksLT2019DataSet";
            this.adventureWorksLT2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adventureWorksLT2019DataSetBindingSource
            // 
            this.adventureWorksLT2019DataSetBindingSource.DataSource = this.adventureWorksLT2019DataSet;
            this.adventureWorksLT2019DataSetBindingSource.Position = 0;
            // 
            // adventureWorksLT2019DataSet1
            // 
            this.adventureWorksLT2019DataSet1.DataSetName = "AdventureWorksLT2019DataSet1";
            this.adventureWorksLT2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomersBindingSource
            // 
            this.getCustomersBindingSource.DataMember = "GetCustomers";
            this.getCustomersBindingSource.DataSource = this.adventureWorksLT2019DataSet1;
            // 
            // getCustomersTableAdapter
            // 
            this.getCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            this.suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            this.suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            this.suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // salesPersonDataGridViewTextBoxColumn
            // 
            this.salesPersonDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson";
            this.salesPersonDataGridViewTextBoxColumn.HeaderText = "SalesPerson";
            this.salesPersonDataGridViewTextBoxColumn.Name = "salesPersonDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            // 
            // passwordSaltDataGridViewTextBoxColumn
            // 
            this.passwordSaltDataGridViewTextBoxColumn.DataPropertyName = "PasswordSalt";
            this.passwordSaltDataGridViewTextBoxColumn.HeaderText = "PasswordSalt";
            this.passwordSaltDataGridViewTextBoxColumn.Name = "passwordSaltDataGridViewTextBoxColumn";
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            // 
            // addressTypeDataGridViewTextBoxColumn
            // 
            this.addressTypeDataGridViewTextBoxColumn.DataPropertyName = "AddressType";
            this.addressTypeDataGridViewTextBoxColumn.HeaderText = "AddressType";
            this.addressTypeDataGridViewTextBoxColumn.Name = "addressTypeDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateProvinceDataGridViewTextBoxColumn
            // 
            this.stateProvinceDataGridViewTextBoxColumn.DataPropertyName = "StateProvince";
            this.stateProvinceDataGridViewTextBoxColumn.HeaderText = "StateProvince";
            this.stateProvinceDataGridViewTextBoxColumn.Name = "stateProvinceDataGridViewTextBoxColumn";
            // 
            // countryRegionDataGridViewTextBoxColumn
            // 
            this.countryRegionDataGridViewTextBoxColumn.DataPropertyName = "CountryRegion";
            this.countryRegionDataGridViewTextBoxColumn.HeaderText = "CountryRegion";
            this.countryRegionDataGridViewTextBoxColumn.Name = "countryRegionDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // DeleatBotten
            // 
            this.DeleatBotten.Location = new System.Drawing.Point(713, 13);
            this.DeleatBotten.Name = "DeleatBotten";
            this.DeleatBotten.Size = new System.Drawing.Size(75, 23);
            this.DeleatBotten.TabIndex = 3;
            this.DeleatBotten.Text = "Deleat";
            this.DeleatBotten.UseVisualStyleBackColor = true;
            this.DeleatBotten.Click += new System.EventHandler(this.DeleatBotten_Click);
            // 
            // InsertUpdate
            // 
            this.InsertUpdate.Location = new System.Drawing.Point(622, 13);
            this.InsertUpdate.Name = "InsertUpdate";
            this.InsertUpdate.Size = new System.Drawing.Size(85, 23);
            this.InsertUpdate.TabIndex = 4;
            this.InsertUpdate.Text = "Insert/Update";
            this.InsertUpdate.UseVisualStyleBackColor = true;
            this.InsertUpdate.Click += new System.EventHandler(this.InsertUpdate_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertUpdate);
            this.Controls.Add(this.DeleatBotten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ItemBotton);
            this.Controls.Add(this.HomeButton);
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ItemBotton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource adventureWorksLT2019DataSetBindingSource;
        private AdventureWorksLT2019DataSet adventureWorksLT2019DataSet;
        private AdventureWorksLT2019DataSet1 adventureWorksLT2019DataSet1;
        private System.Windows.Forms.BindingSource getCustomersBindingSource;
        private AdventureWorksLT2019DataSet1TableAdapters.GetCustomersTableAdapter getCustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordSaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleatBotten;
        private System.Windows.Forms.Button InsertUpdate;
    }
}