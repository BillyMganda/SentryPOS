namespace SentryPOS.Forms
{
    partial class Inventory_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Message));
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bar_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_on_Hand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lower_Limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buying_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridList
            // 
            this.dataGridList.AllowUserToAddRows = false;
            this.dataGridList.AllowUserToDeleteRows = false;
            this.dataGridList.AllowUserToResizeColumns = false;
            this.dataGridList.AllowUserToResizeRows = false;
            this.dataGridList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Bar_Code,
            this.Units,
            this.Stock_on_Hand,
            this.Lower_Limit,
            this.Buying_Price});
            this.dataGridList.Location = new System.Drawing.Point(2, 3);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.RowHeadersVisible = false;
            this.dataGridList.Size = new System.Drawing.Size(797, 446);
            this.dataGridList.TabIndex = 33;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Bar_Code
            // 
            this.Bar_Code.DataPropertyName = "Bar_Code";
            this.Bar_Code.HeaderText = "Bar Code";
            this.Bar_Code.Name = "Bar_Code";
            this.Bar_Code.ReadOnly = true;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 80;
            // 
            // Stock_on_Hand
            // 
            this.Stock_on_Hand.DataPropertyName = "Sum_Quantity";
            this.Stock_on_Hand.HeaderText = "Stock on Hand";
            this.Stock_on_Hand.Name = "Stock_on_Hand";
            this.Stock_on_Hand.ReadOnly = true;
            this.Stock_on_Hand.Width = 120;
            // 
            // Lower_Limit
            // 
            this.Lower_Limit.DataPropertyName = "Lower_Limit";
            this.Lower_Limit.HeaderText = "Lower Limit";
            this.Lower_Limit.Name = "Lower_Limit";
            this.Lower_Limit.ReadOnly = true;
            // 
            // Buying_Price
            // 
            this.Buying_Price.DataPropertyName = "Avg_BP";
            this.Buying_Price.HeaderText = "Buying Price";
            this.Buying_Price.Name = "Buying_Price";
            this.Buying_Price.ReadOnly = true;
            // 
            // Inventory_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inventory_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MESSAGE";
            this.Load += new System.EventHandler(this.Inventory_Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bar_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_on_Hand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lower_Limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buying_Price;
    }
}