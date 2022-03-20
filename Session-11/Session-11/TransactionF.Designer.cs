namespace Session_11
{
    partial class TransactionF
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
            this.Btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Ctrltotalprice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrldate = new DevExpress.XtraEditors.DateEdit();
            this.CtrlCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.CtrlCar = new DevExpress.XtraEditors.LookUpEdit();
            this.CtrlManager = new DevExpress.XtraEditors.LookUpEdit();
            this.grdTransLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceTaskID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEngineerID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.buttonAddLine = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveLine = new DevExpress.XtraEditors.SimpleButton();
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransID = new System.Windows.Forms.BindingSource(this.components);
            this.bsServiveTask = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrltotalprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colServiceTaskID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colEngineerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiveTask)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(361, 344);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 29;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(159, 344);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 28;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Manager";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Car";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Customer";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Date";
            // 
            // Ctrltotalprice
            // 
            this.Ctrltotalprice.Location = new System.Drawing.Point(159, 206);
            this.Ctrltotalprice.Name = "Ctrltotalprice";
            this.Ctrltotalprice.Properties.ReadOnly = true;
            this.Ctrltotalprice.Size = new System.Drawing.Size(100, 20);
            this.Ctrltotalprice.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 209);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Total Price";
            // 
            // Ctrldate
            // 
            this.Ctrldate.EditValue = null;
            this.Ctrldate.Location = new System.Drawing.Point(159, 29);
            this.Ctrldate.Name = "Ctrldate";
            this.Ctrldate.Properties.Appearance.Options.UseTextOptions = true;
            this.Ctrldate.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.Ctrldate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrldate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.Ctrldate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrldate.Properties.DisplayFormat.FormatString = "";
            this.Ctrldate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Ctrldate.Properties.EditFormat.FormatString = "";
            this.Ctrldate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Ctrldate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.Ctrldate.Properties.MaskSettings.Set("mask", "");
            this.Ctrldate.Size = new System.Drawing.Size(100, 20);
            this.Ctrldate.TabIndex = 33;
            // 
            // CtrlCustomer
            // 
            this.CtrlCustomer.Location = new System.Drawing.Point(159, 75);
            this.CtrlCustomer.Name = "CtrlCustomer";
            this.CtrlCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCustomer.Size = new System.Drawing.Size(100, 20);
            this.CtrlCustomer.TabIndex = 34;
            // 
            // CtrlCar
            // 
            this.CtrlCar.Location = new System.Drawing.Point(159, 120);
            this.CtrlCar.Name = "CtrlCar";
            this.CtrlCar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCar.Size = new System.Drawing.Size(100, 20);
            this.CtrlCar.TabIndex = 35;
            // 
            // CtrlManager
            // 
            this.CtrlManager.Location = new System.Drawing.Point(159, 162);
            this.CtrlManager.Name = "CtrlManager";
            this.CtrlManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlManager.Size = new System.Drawing.Size(100, 20);
            this.CtrlManager.TabIndex = 36;
            // 
            // grdTransLines
            // 
            this.grdTransLines.Location = new System.Drawing.Point(293, 32);
            this.grdTransLines.MainView = this.grvTransLines;
            this.grdTransLines.Name = "grdTransLines";
            this.grdTransLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colServiceTaskID,
            this.colEngineerID});
            this.grdTransLines.Size = new System.Drawing.Size(400, 194);
            this.grdTransLines.TabIndex = 37;
            this.grdTransLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransLines});
            // 
            // grvTransLines
            // 
            this.grvTransLines.GridControl = this.grdTransLines;
            this.grvTransLines.Name = "grvTransLines";
            this.grvTransLines.OptionsBehavior.ReadOnly = true;
            // 
            // colServiceTaskID
            // 
            this.colServiceTaskID.AutoHeight = false;
            this.colServiceTaskID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colServiceTaskID.Name = "colServiceTaskID";
            this.colServiceTaskID.ReadOnly = true;
            // 
            // colEngineerID
            // 
            this.colEngineerID.AutoHeight = false;
            this.colEngineerID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colEngineerID.Name = "colEngineerID";
            this.colEngineerID.ReadOnly = true;
            // 
            // buttonAddLine
            // 
            this.buttonAddLine.Location = new System.Drawing.Point(293, 233);
            this.buttonAddLine.Name = "buttonAddLine";
            this.buttonAddLine.Size = new System.Drawing.Size(193, 23);
            this.buttonAddLine.TabIndex = 38;
            this.buttonAddLine.Text = "Add Line";
            this.buttonAddLine.Click += new System.EventHandler(this.buttonAddLine_Click);
            // 
            // buttonRemoveLine
            // 
            this.buttonRemoveLine.Location = new System.Drawing.Point(492, 232);
            this.buttonRemoveLine.Name = "buttonRemoveLine";
            this.buttonRemoveLine.Size = new System.Drawing.Size(201, 23);
            this.buttonRemoveLine.TabIndex = 39;
            this.buttonRemoveLine.Text = "Remove Line";
            this.buttonRemoveLine.Click += new System.EventHandler(this.buttonRemoveLine_Click);
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveLine);
            this.Controls.Add(this.buttonAddLine);
            this.Controls.Add(this.grdTransLines);
            this.Controls.Add(this.CtrlManager);
            this.Controls.Add(this.CtrlCar);
            this.Controls.Add(this.CtrlCustomer);
            this.Controls.Add(this.Ctrltotalprice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Ctrldate);
            this.Name = "TransactionF";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrltotalprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colServiceTaskID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colEngineerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiveTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Ctrltotalprice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource bsTransaction;
        private DevExpress.XtraEditors.DateEdit Ctrldate;
        private DevExpress.XtraEditors.LookUpEdit CtrlCustomer;
        private DevExpress.XtraEditors.LookUpEdit CtrlCar;
        private DevExpress.XtraEditors.LookUpEdit CtrlManager;
        private DevExpress.XtraGrid.GridControl grdTransLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransLines;
        private DevExpress.XtraEditors.SimpleButton buttonAddLine;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveLine;
        private System.Windows.Forms.BindingSource bsTransactionLines;
        private System.Windows.Forms.BindingSource bsTransID;
        private System.Windows.Forms.BindingSource bsServiveTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit colServiceTaskID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit colEngineerID;
    }
}