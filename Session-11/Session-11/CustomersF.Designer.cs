namespace Session_11
{
    partial class CustomersF
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
            this.GrdCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdCustomers
            // 
            this.GrdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdCustomers.Location = new System.Drawing.Point(3, 1);
            this.GrdCustomers.MainView = this.gridView1;
            this.GrdCustomers.Name = "GrdCustomers";
            this.GrdCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.GrdCustomers.Size = new System.Drawing.Size(795, 300);
            this.GrdCustomers.TabIndex = 5;
            this.GrdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdCustomers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Btnclose
            // 
            this.Btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnclose.Location = new System.Drawing.Point(504, 339);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(80, 23);
            this.Btnclose.TabIndex = 9;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btndelete.Location = new System.Drawing.Point(388, 339);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 23);
            this.Btndelete.TabIndex = 8;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnedit.Location = new System.Drawing.Point(267, 339);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(75, 23);
            this.Btnedit.TabIndex = 7;
            this.Btnedit.Text = "Edit";
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btnnew
            // 
            this.Btnnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnnew.Location = new System.Drawing.Point(153, 339);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(75, 23);
            this.Btnnew.TabIndex = 6;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // CustomersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdCustomers);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.Btnnew);
            this.Name = "CustomersF";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private System.Windows.Forms.BindingSource bsCustomers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}