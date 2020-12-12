namespace SentryPOS.Forms
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSupplierStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createItemGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPricingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMessageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseByItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseByGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseBySupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPuchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOnHandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesByItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesByGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesBalanceForTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemSellingPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bar_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buying_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrid_Received = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGrid_Sales = new System.Windows.Forms.DataGridView();
            this.Item_Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bar_Code_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_Pay_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Submited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Received)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageSuppliersToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.changeUserStatusToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.manageUsersToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserToolStripMenuItem.Image")));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewUserToolStripMenuItem.Text = "Create New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // changeUserStatusToolStripMenuItem
            // 
            this.changeUserStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeUserStatusToolStripMenuItem.Image")));
            this.changeUserStatusToolStripMenuItem.Name = "changeUserStatusToolStripMenuItem";
            this.changeUserStatusToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.changeUserStatusToolStripMenuItem.Text = "Change User Status";
            this.changeUserStatusToolStripMenuItem.Click += new System.EventHandler(this.changeUserStatusToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // manageSuppliersToolStripMenuItem
            // 
            this.manageSuppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewSupplierToolStripMenuItem,
            this.changeSupplierStatusToolStripMenuItem,
            this.deleteSupplierToolStripMenuItem});
            this.manageSuppliersToolStripMenuItem.Name = "manageSuppliersToolStripMenuItem";
            this.manageSuppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.manageSuppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // createNewSupplierToolStripMenuItem
            // 
            this.createNewSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewSupplierToolStripMenuItem.Image")));
            this.createNewSupplierToolStripMenuItem.Name = "createNewSupplierToolStripMenuItem";
            this.createNewSupplierToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createNewSupplierToolStripMenuItem.Text = "Create New Supplier";
            this.createNewSupplierToolStripMenuItem.Click += new System.EventHandler(this.createNewSupplierToolStripMenuItem_Click);
            // 
            // changeSupplierStatusToolStripMenuItem
            // 
            this.changeSupplierStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeSupplierStatusToolStripMenuItem.Image")));
            this.changeSupplierStatusToolStripMenuItem.Name = "changeSupplierStatusToolStripMenuItem";
            this.changeSupplierStatusToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.changeSupplierStatusToolStripMenuItem.Text = "Change Supplier Status";
            this.changeSupplierStatusToolStripMenuItem.Click += new System.EventHandler(this.changeSupplierStatusToolStripMenuItem_Click);
            // 
            // deleteSupplierToolStripMenuItem
            // 
            this.deleteSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteSupplierToolStripMenuItem.Image")));
            this.deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            this.deleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            this.deleteSupplierToolStripMenuItem.Click += new System.EventHandler(this.deleteSupplierToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.itemPricingToolStripMenuItem,
            this.inventoryMessageToolStripMenuItem,
            this.receiveOrderToolStripMenuItem,
            this.inventoryMessageToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createItemGroupsToolStripMenuItem,
            this.createNewItemsToolStripMenuItem});
            this.addNewItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemToolStripMenuItem.Image")));
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addNewItemToolStripMenuItem.Text = "Inventory Items";
            // 
            // createItemGroupsToolStripMenuItem
            // 
            this.createItemGroupsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createItemGroupsToolStripMenuItem.Image")));
            this.createItemGroupsToolStripMenuItem.Name = "createItemGroupsToolStripMenuItem";
            this.createItemGroupsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createItemGroupsToolStripMenuItem.Text = "Create Item Groups";
            this.createItemGroupsToolStripMenuItem.Click += new System.EventHandler(this.createItemGroupsToolStripMenuItem_Click);
            // 
            // createNewItemsToolStripMenuItem
            // 
            this.createNewItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewItemsToolStripMenuItem.Image")));
            this.createNewItemsToolStripMenuItem.Name = "createNewItemsToolStripMenuItem";
            this.createNewItemsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createNewItemsToolStripMenuItem.Text = "Create New Items";
            this.createNewItemsToolStripMenuItem.Click += new System.EventHandler(this.createNewItemsToolStripMenuItem_Click);
            // 
            // itemPricingToolStripMenuItem
            // 
            this.itemPricingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemPricingToolStripMenuItem.Image")));
            this.itemPricingToolStripMenuItem.Name = "itemPricingToolStripMenuItem";
            this.itemPricingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.itemPricingToolStripMenuItem.Text = "Item Quantity && Pricing";
            this.itemPricingToolStripMenuItem.Click += new System.EventHandler(this.itemPricingToolStripMenuItem_Click);
            // 
            // inventoryMessageToolStripMenuItem
            // 
            this.inventoryMessageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryMessageToolStripMenuItem.Image")));
            this.inventoryMessageToolStripMenuItem.Name = "inventoryMessageToolStripMenuItem";
            this.inventoryMessageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.inventoryMessageToolStripMenuItem.Text = "Purchase Order";
            this.inventoryMessageToolStripMenuItem.Click += new System.EventHandler(this.inventoryMessageToolStripMenuItem_Click);
            // 
            // receiveOrderToolStripMenuItem
            // 
            this.receiveOrderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("receiveOrderToolStripMenuItem.Image")));
            this.receiveOrderToolStripMenuItem.Name = "receiveOrderToolStripMenuItem";
            this.receiveOrderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.receiveOrderToolStripMenuItem.Text = "Receive Order";
            this.receiveOrderToolStripMenuItem.Click += new System.EventHandler(this.receiveOrderToolStripMenuItem_Click);
            // 
            // inventoryMessageToolStripMenuItem1
            // 
            this.inventoryMessageToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inventoryMessageToolStripMenuItem1.Image")));
            this.inventoryMessageToolStripMenuItem1.Name = "inventoryMessageToolStripMenuItem1";
            this.inventoryMessageToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.inventoryMessageToolStripMenuItem1.Text = "Inventory Message";
            this.inventoryMessageToolStripMenuItem1.Click += new System.EventHandler(this.inventoryMessageToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReportsToolStripMenuItem,
            this.inventoryReportsToolStripMenuItem,
            this.salesReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // purchaseReportsToolStripMenuItem
            // 
            this.purchaseReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseByItemToolStripMenuItem,
            this.purchaseByGroupToolStripMenuItem,
            this.purchaseBySupplierToolStripMenuItem,
            this.totalPuchasesToolStripMenuItem});
            this.purchaseReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseReportsToolStripMenuItem.Image")));
            this.purchaseReportsToolStripMenuItem.Name = "purchaseReportsToolStripMenuItem";
            this.purchaseReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purchaseReportsToolStripMenuItem.Text = "Purchase Reports";
            // 
            // purchaseByItemToolStripMenuItem
            // 
            this.purchaseByItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseByItemToolStripMenuItem.Image")));
            this.purchaseByItemToolStripMenuItem.Name = "purchaseByItemToolStripMenuItem";
            this.purchaseByItemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.purchaseByItemToolStripMenuItem.Text = "Purchase by Item";
            this.purchaseByItemToolStripMenuItem.Click += new System.EventHandler(this.purchaseByItemToolStripMenuItem_Click);
            // 
            // purchaseByGroupToolStripMenuItem
            // 
            this.purchaseByGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseByGroupToolStripMenuItem.Image")));
            this.purchaseByGroupToolStripMenuItem.Name = "purchaseByGroupToolStripMenuItem";
            this.purchaseByGroupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.purchaseByGroupToolStripMenuItem.Text = "Purchase by Group";
            this.purchaseByGroupToolStripMenuItem.Click += new System.EventHandler(this.purchaseByGroupToolStripMenuItem_Click);
            // 
            // purchaseBySupplierToolStripMenuItem
            // 
            this.purchaseBySupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseBySupplierToolStripMenuItem.Image")));
            this.purchaseBySupplierToolStripMenuItem.Name = "purchaseBySupplierToolStripMenuItem";
            this.purchaseBySupplierToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.purchaseBySupplierToolStripMenuItem.Text = "Purchase by Supplier";
            this.purchaseBySupplierToolStripMenuItem.Click += new System.EventHandler(this.purchaseBySupplierToolStripMenuItem_Click);
            // 
            // totalPuchasesToolStripMenuItem
            // 
            this.totalPuchasesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalPuchasesToolStripMenuItem.Image")));
            this.totalPuchasesToolStripMenuItem.Name = "totalPuchasesToolStripMenuItem";
            this.totalPuchasesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.totalPuchasesToolStripMenuItem.Text = "Total Puchases";
            this.totalPuchasesToolStripMenuItem.Click += new System.EventHandler(this.totalPuchasesToolStripMenuItem_Click);
            // 
            // inventoryReportsToolStripMenuItem
            // 
            this.inventoryReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockOnHandToolStripMenuItem});
            this.inventoryReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryReportsToolStripMenuItem.Image")));
            this.inventoryReportsToolStripMenuItem.Name = "inventoryReportsToolStripMenuItem";
            this.inventoryReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventoryReportsToolStripMenuItem.Text = "Inventory Reports";
            // 
            // stockOnHandToolStripMenuItem
            // 
            this.stockOnHandToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockOnHandToolStripMenuItem.Image")));
            this.stockOnHandToolStripMenuItem.Name = "stockOnHandToolStripMenuItem";
            this.stockOnHandToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockOnHandToolStripMenuItem.Text = "Stock on Hand";
            this.stockOnHandToolStripMenuItem.Click += new System.EventHandler(this.stockOnHandToolStripMenuItem_Click);
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesByItemToolStripMenuItem,
            this.salesByGroupToolStripMenuItem,
            this.totalSalesToolStripMenuItem,
            this.salesBalanceForTodayToolStripMenuItem});
            this.salesReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesReportsToolStripMenuItem.Image")));
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            // 
            // salesByItemToolStripMenuItem
            // 
            this.salesByItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesByItemToolStripMenuItem.Image")));
            this.salesByItemToolStripMenuItem.Name = "salesByItemToolStripMenuItem";
            this.salesByItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesByItemToolStripMenuItem.Text = "Sales by Item";
            this.salesByItemToolStripMenuItem.Click += new System.EventHandler(this.salesByItemToolStripMenuItem_Click);
            // 
            // salesByGroupToolStripMenuItem
            // 
            this.salesByGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesByGroupToolStripMenuItem.Image")));
            this.salesByGroupToolStripMenuItem.Name = "salesByGroupToolStripMenuItem";
            this.salesByGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesByGroupToolStripMenuItem.Text = "Sales by Group";
            this.salesByGroupToolStripMenuItem.Click += new System.EventHandler(this.salesByGroupToolStripMenuItem_Click);
            // 
            // totalSalesToolStripMenuItem
            // 
            this.totalSalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalSalesToolStripMenuItem.Image")));
            this.totalSalesToolStripMenuItem.Name = "totalSalesToolStripMenuItem";
            this.totalSalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalSalesToolStripMenuItem.Text = "Total Sales";
            this.totalSalesToolStripMenuItem.Click += new System.EventHandler(this.totalSalesToolStripMenuItem_Click);
            // 
            // salesBalanceForTodayToolStripMenuItem
            // 
            this.salesBalanceForTodayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesBalanceForTodayToolStripMenuItem.Image")));
            this.salesBalanceForTodayToolStripMenuItem.Name = "salesBalanceForTodayToolStripMenuItem";
            this.salesBalanceForTodayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesBalanceForTodayToolStripMenuItem.Text = "Sales  for Today";
            this.salesBalanceForTodayToolStripMenuItem.Click += new System.EventHandler(this.salesBalanceForTodayToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailsToolStripMenuItem,
            this.inventoryLimitsToolStripMenuItem,
            this.updateItemSellingPriceToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("companyDetailsToolStripMenuItem.Image")));
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.companyDetailsToolStripMenuItem.Text = "Company Details";
            this.companyDetailsToolStripMenuItem.Click += new System.EventHandler(this.companyDetailsToolStripMenuItem_Click);
            // 
            // inventoryLimitsToolStripMenuItem
            // 
            this.inventoryLimitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryLimitsToolStripMenuItem.Image")));
            this.inventoryLimitsToolStripMenuItem.Name = "inventoryLimitsToolStripMenuItem";
            this.inventoryLimitsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.inventoryLimitsToolStripMenuItem.Text = "Inventory Limits";
            this.inventoryLimitsToolStripMenuItem.Click += new System.EventHandler(this.inventoryLimitsToolStripMenuItem_Click);
            // 
            // updateItemSellingPriceToolStripMenuItem
            // 
            this.updateItemSellingPriceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateItemSellingPriceToolStripMenuItem.Image")));
            this.updateItemSellingPriceToolStripMenuItem.Name = "updateItemSellingPriceToolStripMenuItem";
            this.updateItemSellingPriceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.updateItemSellingPriceToolStripMenuItem.Text = "Update Item Selling Price";
            this.updateItemSellingPriceToolStripMenuItem.Click += new System.EventHandler(this.updateItemSellingPriceToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory Items";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Quantity,
            this.Buying_Price,
            this.Selling_Price});
            this.dataGridList.Location = new System.Drawing.Point(3, 3);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.RowHeadersVisible = false;
            this.dataGridList.Size = new System.Drawing.Size(985, 433);
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
            this.Bar_Code.Width = 200;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Sum_Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Buying_Price
            // 
            this.Buying_Price.DataPropertyName = "Avg_BP";
            this.Buying_Price.HeaderText = "Buying Price";
            this.Buying_Price.Name = "Buying_Price";
            this.Buying_Price.ReadOnly = true;
            this.Buying_Price.Width = 150;
            // 
            // Selling_Price
            // 
            this.Selling_Price.DataPropertyName = "Avg_SP";
            this.Selling_Price.HeaderText = "Selling Price";
            this.Selling_Price.Name = "Selling_Price";
            this.Selling_Price.ReadOnly = true;
            this.Selling_Price.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrid_Received);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Received Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Received
            // 
            this.dataGrid_Received.AllowUserToAddRows = false;
            this.dataGrid_Received.AllowUserToDeleteRows = false;
            this.dataGrid_Received.AllowUserToResizeColumns = false;
            this.dataGrid_Received.AllowUserToResizeRows = false;
            this.dataGrid_Received.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Received.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid_Received.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Received.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Order_ID,
            this.Supplier,
            this.Received_Date});
            this.dataGrid_Received.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Received.Name = "dataGrid_Received";
            this.dataGrid_Received.RowHeadersVisible = false;
            this.dataGrid_Received.Size = new System.Drawing.Size(985, 433);
            this.dataGrid_Received.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item_Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bar Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Unit_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Buying Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Order_ID
            // 
            this.Order_ID.DataPropertyName = "Order_ID";
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 150;
            // 
            // Received_Date
            // 
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.ReadOnly = true;
            this.Received_Date.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid_Sales);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(991, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Sales
            // 
            this.dataGrid_Sales.AllowUserToAddRows = false;
            this.dataGrid_Sales.AllowUserToDeleteRows = false;
            this.dataGrid_Sales.AllowUserToResizeColumns = false;
            this.dataGrid_Sales.AllowUserToResizeRows = false;
            this.dataGrid_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Sales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name_,
            this.Bar_Code_,
            this.Price_,
            this.To_Pay_,
            this.Amount_Submited,
            this.Balance_,
            this.Sales_ID,
            this.Date_,
            this.Time_});
            this.dataGrid_Sales.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Sales.Name = "dataGrid_Sales";
            this.dataGrid_Sales.RowHeadersVisible = false;
            this.dataGrid_Sales.Size = new System.Drawing.Size(985, 433);
            this.dataGrid_Sales.TabIndex = 35;
            // 
            // Item_Name_
            // 
            this.Item_Name_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name_.DataPropertyName = "Item_Name";
            this.Item_Name_.HeaderText = "Item Name";
            this.Item_Name_.Name = "Item_Name_";
            this.Item_Name_.ReadOnly = true;
            // 
            // Bar_Code_
            // 
            this.Bar_Code_.DataPropertyName = "Bar_Code";
            this.Bar_Code_.HeaderText = "Bar Code";
            this.Bar_Code_.Name = "Bar_Code_";
            this.Bar_Code_.ReadOnly = true;
            this.Bar_Code_.Width = 150;
            // 
            // Price_
            // 
            this.Price_.DataPropertyName = "Price";
            this.Price_.HeaderText = "Price";
            this.Price_.Name = "Price_";
            this.Price_.ReadOnly = true;
            // 
            // To_Pay_
            // 
            this.To_Pay_.DataPropertyName = "To_Pay";
            this.To_Pay_.HeaderText = "To Pay";
            this.To_Pay_.Name = "To_Pay_";
            this.To_Pay_.ReadOnly = true;
            // 
            // Amount_Submited
            // 
            this.Amount_Submited.DataPropertyName = "Amount_Submited";
            this.Amount_Submited.HeaderText = "Amount Paid";
            this.Amount_Submited.Name = "Amount_Submited";
            this.Amount_Submited.ReadOnly = true;
            // 
            // Balance_
            // 
            this.Balance_.DataPropertyName = "Balance";
            this.Balance_.HeaderText = "Balance";
            this.Balance_.Name = "Balance_";
            this.Balance_.ReadOnly = true;
            // 
            // Sales_ID
            // 
            this.Sales_ID.DataPropertyName = "Sales_ID";
            this.Sales_ID.HeaderText = "Sales ID";
            this.Sales_ID.Name = "Sales_ID";
            this.Sales_ID.ReadOnly = true;
            this.Sales_ID.Width = 70;
            // 
            // Date_
            // 
            this.Date_.DataPropertyName = "Date";
            this.Date_.HeaderText = "Date";
            this.Date_.Name = "Date_";
            this.Date_.ReadOnly = true;
            this.Date_.Width = 70;
            // 
            // Time_
            // 
            this.Time_.DataPropertyName = "Time";
            this.Time_.HeaderText = "Time";
            this.Time_.Name = "Time_";
            this.Time_.ReadOnly = true;
            this.Time_.Width = 70;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEM ADMINISTRATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Received)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSupplierStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPricingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem createItemGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMessageToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bar_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buying_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Price;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGrid_Received;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemSellingPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseByItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseByGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseBySupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPuchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOnHandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesByItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesByGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesBalanceForTodayToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bar_Code_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Pay_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Submited;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}