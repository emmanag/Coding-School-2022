namespace Session_11
{
    partial class TransactionsF
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
            this.GrdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.CarLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ManagerLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CustomerLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCarColumns = new System.Windows.Forms.BindingSource(this.components);
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.bsManagerColumns = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomerColumns = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdTransactions
            // 
            this.GrdTransactions.Location = new System.Drawing.Point(2, 1);
            this.GrdTransactions.MainView = this.gridView1;
            this.GrdTransactions.Name = "GrdTransactions";
            this.GrdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.CarLookUp,
            this.ManagerLookUp,
            this.CustomerLookUp});
            this.GrdTransactions.Size = new System.Drawing.Size(795, 162);
            this.GrdTransactions.TabIndex = 15;
            this.GrdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // CarLookUp
            // 
            this.CarLookUp.AutoHeight = false;
            this.CarLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CarLookUp.Name = "CarLookUp";
            // 
            // ManagerLookUp
            // 
            this.ManagerLookUp.AutoHeight = false;
            this.ManagerLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ManagerLookUp.Name = "ManagerLookUp";
            // 
            // CustomerLookUp
            // 
            this.CustomerLookUp.AutoHeight = false;
            this.CustomerLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerLookUp.Name = "CustomerLookUp";
            // 
            // Btnclose
            // 
            this.Btnclose.Location = new System.Drawing.Point(392, 309);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(80, 23);
            this.Btnclose.TabIndex = 19;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(271, 309);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 23);
            this.Btndelete.TabIndex = 18;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnnew
            // 
            this.Btnnew.Location = new System.Drawing.Point(150, 309);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(75, 23);
            this.Btnnew.TabIndex = 16;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // TransactionsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdTransactions);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnnew);
            this.Name = "TransactionsF";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private System.Windows.Forms.BindingSource bsTransactions;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource bsManagerColumns;
        private System.Windows.Forms.BindingSource bsCustomerColumns;
        private System.Windows.Forms.BindingSource bsCarColumns;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CarLookUp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ManagerLookUp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CustomerLookUp;
    }
}