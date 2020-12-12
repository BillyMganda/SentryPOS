namespace SentryPOS.Forms
{
    partial class Sales_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Dashboard));
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bar_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_ToPay = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Tax = new System.Windows.Forms.Label();
            this.label_SubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnMpesa = new System.Windows.Forms.Button();
            this.btbCard = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnEndofDay = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_SalesID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(38, 5);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(758, 31);
            this.txtBarCode.TabIndex = 16;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.txtBarCode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 43);
            this.panel1.TabIndex = 18;
            // 
            // dataGridList
            // 
            this.dataGridList.AllowUserToAddRows = false;
            this.dataGridList.AllowUserToDeleteRows = false;
            this.dataGridList.AllowUserToResizeColumns = false;
            this.dataGridList.AllowUserToResizeRows = false;
            this.dataGridList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Bar_Code,
            this.Units,
            this.Avg_SP});
            this.dataGridList.Location = new System.Drawing.Point(10, 53);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.RowHeadersVisible = false;
            this.dataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridList.Size = new System.Drawing.Size(808, 325);
            this.dataGridList.TabIndex = 33;
            this.dataGridList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridList_CellMouseUp);
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.HeaderText = "Item Code";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Bar_Code
            // 
            this.Bar_Code.HeaderText = "Item Name";
            this.Bar_Code.Name = "Bar_Code";
            this.Bar_Code.ReadOnly = true;
            this.Bar_Code.Width = 200;
            // 
            // Units
            // 
            this.Units.HeaderText = "Price";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 150;
            // 
            // Avg_SP
            // 
            this.Avg_SP.HeaderText = "Quantity";
            this.Avg_SP.Name = "Avg_SP";
            this.Avg_SP.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label_ToPay);
            this.panel2.Controls.Add(this.label_Total);
            this.panel2.Controls.Add(this.label_Tax);
            this.panel2.Controls.Add(this.label_SubTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(10, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 156);
            this.panel2.TabIndex = 34;
            // 
            // label_ToPay
            // 
            this.label_ToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ToPay.AutoSize = true;
            this.label_ToPay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToPay.Location = new System.Drawing.Point(664, 126);
            this.label_ToPay.Name = "label_ToPay";
            this.label_ToPay.Size = new System.Drawing.Size(48, 23);
            this.label_ToPay.TabIndex = 22;
            this.label_ToPay.Text = "0.00";
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(664, 88);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(48, 22);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "0.00";
            // 
            // label_Tax
            // 
            this.label_Tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tax.AutoSize = true;
            this.label_Tax.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax.Location = new System.Drawing.Point(664, 50);
            this.label_Tax.Name = "label_Tax";
            this.label_Tax.Size = new System.Drawing.Size(48, 22);
            this.label_Tax.TabIndex = 20;
            this.label_Tax.Text = "0.00";
            // 
            // label_SubTotal
            // 
            this.label_SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SubTotal.AutoSize = true;
            this.label_SubTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubTotal.Location = new System.Drawing.Point(664, 12);
            this.label_SubTotal.Name = "label_SubTotal";
            this.label_SubTotal.Size = new System.Drawing.Size(48, 22);
            this.label_SubTotal.TabIndex = 19;
            this.label_SubTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "To Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 22);
            this.label16.TabIndex = 15;
            this.label16.Text = "Sub Total";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(824, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 523);
            this.panel3.TabIndex = 35;
            // 
            // btnCash
            // 
            this.btnCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(835, 12);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(133, 68);
            this.btnCash.TabIndex = 60;
            this.btnCash.Text = "F1\r\nCash Payment";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnMpesa
            // 
            this.btnMpesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMpesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMpesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMpesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMpesa.Location = new System.Drawing.Point(835, 93);
            this.btnMpesa.Name = "btnMpesa";
            this.btnMpesa.Size = new System.Drawing.Size(133, 68);
            this.btnMpesa.TabIndex = 61;
            this.btnMpesa.Text = "F2\r\nM-PESA Payment";
            this.btnMpesa.UseVisualStyleBackColor = true;
            this.btnMpesa.Click += new System.EventHandler(this.btnMpesa_Click);
            // 
            // btbCard
            // 
            this.btbCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbCard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCard.Location = new System.Drawing.Point(835, 174);
            this.btbCard.Name = "btbCard";
            this.btbCard.Size = new System.Drawing.Size(133, 68);
            this.btbCard.TabIndex = 62;
            this.btbCard.Text = "F3\r\nCard Payment";
            this.btbCard.UseVisualStyleBackColor = true;
            this.btbCard.Click += new System.EventHandler(this.btbCard_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.Location = new System.Drawing.Point(835, 255);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(133, 68);
            this.btnNewSale.TabIndex = 63;
            this.btnNewSale.Text = "F4\r\nNew Sale";
            this.btnNewSale.UseVisualStyleBackColor = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnEndofDay
            // 
            this.btnEndofDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndofDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndofDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndofDay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndofDay.Location = new System.Drawing.Point(835, 336);
            this.btnEndofDay.Name = "btnEndofDay";
            this.btnEndofDay.Size = new System.Drawing.Size(133, 68);
            this.btnEndofDay.TabIndex = 64;
            this.btnEndofDay.Text = "F5\r\nEnd of Day";
            this.btnEndofDay.UseVisualStyleBackColor = true;
            this.btnEndofDay.Click += new System.EventHandler(this.btnEndofDay_Click);
            // 
            // label_Date
            // 
            this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(843, 423);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(50, 21);
            this.label_Date.TabIndex = 66;
            this.label_Date.Text = "Date";
            // 
            // label_Time
            // 
            this.label_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(843, 447);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(46, 21);
            this.label_Time.TabIndex = 67;
            this.label_Time.Text = "Time";
            // 
            // label_SalesID
            // 
            this.label_SalesID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SalesID.AutoSize = true;
            this.label_SalesID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SalesID.Location = new System.Drawing.Point(843, 471);
            this.label_SalesID.Name = "label_SalesID";
            this.label_SalesID.Size = new System.Drawing.Size(69, 21);
            this.label_SalesID.TabIndex = 68;
            this.label_SalesID.Text = "Sales ID";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemToolStripMenuItem.Image")));
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            // 
            // Sales_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 536);
            this.Controls.Add(this.label_SalesID);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.btnEndofDay);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.btbCard);
            this.Controls.Add(this.btnMpesa);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALES DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnMpesa;
        private System.Windows.Forms.Button btbCard;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnEndofDay;
        private System.Windows.Forms.Label label_ToPay;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_Tax;
        private System.Windows.Forms.Label label_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bar_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avg_SP;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_SalesID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
    }
}