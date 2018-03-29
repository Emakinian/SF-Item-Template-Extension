namespace SitefinityWidgetWizard
{
    partial class Form1
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
            this.modelFieldsGridView = new System.Windows.Forms.DataGridView();
            this.addNewFieldButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.propertyNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.propertyTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isRequiredCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.modelFieldsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // modelFieldsGridView
            // 
            this.modelFieldsGridView.AllowUserToOrderColumns = true;
            this.modelFieldsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelFieldsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyName,
            this.PropertyType,
            this.IsRequired});
            this.modelFieldsGridView.Location = new System.Drawing.Point(16, 149);
            this.modelFieldsGridView.Name = "modelFieldsGridView";
            this.modelFieldsGridView.ReadOnly = true;
            this.modelFieldsGridView.Size = new System.Drawing.Size(476, 158);
            this.modelFieldsGridView.TabIndex = 0;
            // 
            // addNewFieldButton
            // 
            this.addNewFieldButton.Location = new System.Drawing.Point(209, 98);
            this.addNewFieldButton.Name = "addNewFieldButton";
            this.addNewFieldButton.Size = new System.Drawing.Size(101, 34);
            this.addNewFieldButton.TabIndex = 1;
            this.addNewFieldButton.Text = "Add new field";
            this.addNewFieldButton.UseVisualStyleBackColor = true;
            this.addNewFieldButton.Click += new System.EventHandler(this.addNewFieldButton_Click);
            // 
            // createButton
            // 
            this.createButton.CausesValidation = false;
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Location = new System.Drawing.Point(16, 313);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(105, 34);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model Fields";
            // 
            // propertyNameTextbox
            // 
            this.propertyNameTextbox.Location = new System.Drawing.Point(111, 36);
            this.propertyNameTextbox.Name = "propertyNameTextbox";
            this.propertyNameTextbox.Size = new System.Drawing.Size(199, 20);
            this.propertyNameTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Property Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Property Type";
            // 
            // propertyTypeCombobox
            // 
            this.propertyTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyTypeCombobox.FormattingEnabled = true;
            this.propertyTypeCombobox.Items.AddRange(new object[] {
            "string",
            "bool",
            "int",
            "int?",
            "double",
            "double?",
            "decimal",
            "decimal?",
            "DateTime",
            "DateTime?"});
            this.propertyTypeCombobox.Location = new System.Drawing.Point(111, 62);
            this.propertyTypeCombobox.Name = "propertyTypeCombobox";
            this.propertyTypeCombobox.Size = new System.Drawing.Size(199, 21);
            this.propertyTypeCombobox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Is Required?";
            // 
            // isRequiredCheckbox
            // 
            this.isRequiredCheckbox.AutoSize = true;
            this.isRequiredCheckbox.CausesValidation = false;
            this.isRequiredCheckbox.Location = new System.Drawing.Point(111, 89);
            this.isRequiredCheckbox.Name = "isRequiredCheckbox";
            this.isRequiredCheckbox.Size = new System.Drawing.Size(15, 14);
            this.isRequiredCheckbox.TabIndex = 11;
            this.isRequiredCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.CausesValidation = false;
            this.deleteButton.Location = new System.Drawing.Point(391, 313);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PropertyName
            // 
            this.PropertyName.DataPropertyName = "PropertyName";
            this.PropertyName.HeaderText = "Name";
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            // 
            // PropertyType
            // 
            this.PropertyType.DataPropertyName = "PropertyType";
            this.PropertyType.HeaderText = "Type";
            this.PropertyType.Name = "PropertyType";
            this.PropertyType.ReadOnly = true;
            // 
            // IsRequired
            // 
            this.IsRequired.DataPropertyName = "IsRequired";
            this.IsRequired.HeaderText = "Is Required?";
            this.IsRequired.Name = "IsRequired";
            this.IsRequired.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 356);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.isRequiredCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.propertyTypeCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.propertyNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.addNewFieldButton);
            this.Controls.Add(this.modelFieldsGridView);
            this.Name = "Form1";
            this.Text = "Model Fields";
            ((System.ComponentModel.ISupportInitialize)(this.modelFieldsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modelFieldsGridView;
        private System.Windows.Forms.Button addNewFieldButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertyNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox propertyTypeCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isRequiredCheckbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRequired;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

