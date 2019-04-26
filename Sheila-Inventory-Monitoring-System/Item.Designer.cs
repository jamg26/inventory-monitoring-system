namespace Sheila_Inventory_Monitoring_System
{
    partial class Item
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemSlot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItemOwner = new System.Windows.Forms.ComboBox();
            this.numItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.inventory_SystemDataSet = new Sheila_Inventory_Monitoring_System.Inventory_SystemDataSet();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownersTableAdapter = new Sheila_Inventory_Monitoring_System.Inventory_SystemDataSetTableAdapters.OwnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(15, 25);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(257, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(15, 64);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(257, 20);
            this.txtItemPrice.TabIndex = 1;
            // 
            // txtItemSlot
            // 
            this.txtItemSlot.Location = new System.Drawing.Point(15, 183);
            this.txtItemSlot.Name = "txtItemSlot";
            this.txtItemSlot.Size = new System.Drawing.Size(120, 20);
            this.txtItemSlot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Owner";
            // 
            // cmbItemOwner
            // 
            this.cmbItemOwner.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ownersBindingSource, "name", true));
            this.cmbItemOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemOwner.FormattingEnabled = true;
            this.cmbItemOwner.Location = new System.Drawing.Point(15, 104);
            this.cmbItemOwner.Name = "cmbItemOwner";
            this.cmbItemOwner.Size = new System.Drawing.Size(257, 21);
            this.cmbItemOwner.TabIndex = 8;
            // 
            // numItemQuantity
            // 
            this.numItemQuantity.Location = new System.Drawing.Point(15, 144);
            this.numItemQuantity.Name = "numItemQuantity";
            this.numItemQuantity.Size = new System.Drawing.Size(120, 20);
            this.numItemQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Slot";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // inventory_SystemDataSet
            // 
            this.inventory_SystemDataSet.DataSetName = "Inventory_SystemDataSet";
            this.inventory_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.inventory_SystemDataSet;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 308);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numItemQuantity);
            this.Controls.Add(this.cmbItemOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemSlot);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtItemPrice;
        public System.Windows.Forms.TextBox txtItemSlot;
        public System.Windows.Forms.ComboBox cmbItemOwner;
        public System.Windows.Forms.NumericUpDown numItemQuantity;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        private Inventory_SystemDataSet inventory_SystemDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private Inventory_SystemDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
    }
}