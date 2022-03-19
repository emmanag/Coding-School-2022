namespace Session_11
{
    partial class CarCenter
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItemSystem = new DevExpress.XtraBars.BarSubItem();
            this.buttonLoad = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemTransactions = new DevExpress.XtraBars.BarSubItem();
            this.buttonTransShow = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemLedgers = new DevExpress.XtraBars.BarSubItem();
            this.buttonLedgersShow = new DevExpress.XtraBars.BarButtonItem();
            this.buttonLedgersCreate = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemManagement = new DevExpress.XtraBars.BarSubItem();
            this.buttonCars = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEngineers = new DevExpress.XtraBars.BarButtonItem();
            this.buttonManagers = new DevExpress.XtraBars.BarButtonItem();
            this.buttonServiceTask = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemSystem,
            this.buttonLoad,
            this.buttonSave,
            this.barButtonItem3,
            this.barSubItemTransactions,
            this.buttonTransShow,
            this.barSubItemManagement,
            this.buttonManagers,
            this.buttonEngineers,
            this.buttonCustomers,
            this.buttonServiceTask,
            this.barSubItemLedgers,
            this.buttonLedgersShow,
            this.buttonLedgersCreate,
            this.buttonCars,
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.UseF10KeyForMenu = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSystem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemTransactions, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemLedgers),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemManagement)});
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItemSystem
            // 
            this.barSubItemSystem.Caption = "System";
            this.barSubItemSystem.Id = 0;
            this.barSubItemSystem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonLoad, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonSave, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
            this.barSubItemSystem.Name = "barSubItemSystem";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Caption = "Load";
            this.buttonLoad.Id = 1;
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonLoad_ItemClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Caption = "Save";
            this.buttonSave.Id = 2;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSave_ItemClick);
            // 
            // barSubItemTransactions
            // 
            this.barSubItemTransactions.Caption = "Transactions";
            this.barSubItemTransactions.Id = 4;
            this.barSubItemTransactions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonTransShow, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
            this.barSubItemTransactions.Name = "barSubItemTransactions";
            // 
            // buttonTransShow
            // 
            this.buttonTransShow.Caption = "Show";
            this.buttonTransShow.Id = 5;
            this.buttonTransShow.Name = "buttonTransShow";
            this.buttonTransShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonTransShow_ItemClick);
            // 
            // barSubItemLedgers
            // 
            this.barSubItemLedgers.Caption = "Ledgers";
            this.barSubItemLedgers.Id = 11;
            this.barSubItemLedgers.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonLedgersShow, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonLedgersCreate, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
            this.barSubItemLedgers.Name = "barSubItemLedgers";
            // 
            // buttonLedgersShow
            // 
            this.buttonLedgersShow.Caption = "Show";
            this.buttonLedgersShow.Id = 12;
            this.buttonLedgersShow.Name = "buttonLedgersShow";
            this.buttonLedgersShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonLedgersShow_ItemClick);
            // 
            // buttonLedgersCreate
            // 
            this.buttonLedgersCreate.Caption = "Create Ledger";
            this.buttonLedgersCreate.Id = 13;
            this.buttonLedgersCreate.Name = "buttonLedgersCreate";
            this.buttonLedgersCreate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonLedgersCreate_ItemClick);
            // 
            // barSubItemManagement
            // 
            this.barSubItemManagement.Caption = "Management";
            this.barSubItemManagement.Id = 6;
            this.barSubItemManagement.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonCars, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonCustomers, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonEngineers, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonManagers, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonServiceTask, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
            this.barSubItemManagement.Name = "barSubItemManagement";
            // 
            // buttonCars
            // 
            this.buttonCars.Caption = "Cars";
            this.buttonCars.Id = 14;
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCars_ItemClick);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Caption = "Customers";
            this.buttonCustomers.Id = 9;
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCustomers_ItemClick);
            // 
            // buttonEngineers
            // 
            this.buttonEngineers.Caption = "Engineers";
            this.buttonEngineers.Id = 8;
            this.buttonEngineers.Name = "buttonEngineers";
            this.buttonEngineers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEngineers_ItemClick);
            // 
            // buttonManagers
            // 
            this.buttonManagers.Caption = "Managers";
            this.buttonManagers.Id = 7;
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonManagers_ItemClick);
            // 
            // buttonServiceTask
            // 
            this.buttonServiceTask.Caption = "Service Tasks";
            this.buttonServiceTask.Id = 10;
            this.buttonServiceTask.Name = "buttonServiceTask";
            this.buttonServiceTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonServiceTask_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skins";
            this.skinBarSubItem1.Id = 15;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // CarCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "CarCenter";
            this.Text = "CarCenter";
            this.Load += new System.EventHandler(this.CarCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItemSystem;
        private DevExpress.XtraBars.BarButtonItem buttonLoad;
        private DevExpress.XtraBars.BarButtonItem buttonSave;
        private DevExpress.XtraBars.BarSubItem barSubItemTransactions;
        private DevExpress.XtraBars.BarButtonItem buttonTransShow;
        private DevExpress.XtraBars.BarSubItem barSubItemLedgers;
        private DevExpress.XtraBars.BarButtonItem buttonLedgersShow;
        private DevExpress.XtraBars.BarButtonItem buttonLedgersCreate;
        private DevExpress.XtraBars.BarSubItem barSubItemManagement;
        private DevExpress.XtraBars.BarButtonItem buttonManagers;
        private DevExpress.XtraBars.BarButtonItem buttonEngineers;
        private DevExpress.XtraBars.BarButtonItem buttonCustomers;
        private DevExpress.XtraBars.BarButtonItem buttonServiceTask;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem buttonCars;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    }
}

