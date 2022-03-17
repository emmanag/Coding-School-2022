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
            this.GrdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdTransactions
            // 
            this.GrdTransactions.Location = new System.Drawing.Point(2, 1);
            this.GrdTransactions.MainView = this.gridView1;
            this.GrdTransactions.Name = "GrdTransactions";
            this.GrdTransactions.Size = new System.Drawing.Size(795, 162);
            this.GrdTransactions.TabIndex = 15;
            this.GrdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdTransactions;
            this.gridView1.Name = "gridView1";
            // 
            // Btnclose
            // 
            this.Btnclose.Location = new System.Drawing.Point(501, 309);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(80, 23);
            this.Btnclose.TabIndex = 19;
            this.Btnclose.Text = "Close";
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(385, 309);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 23);
            this.Btndelete.TabIndex = 18;
            this.Btndelete.Text = "Delete";
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(264, 309);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(75, 23);
            this.Btnedit.TabIndex = 17;
            this.Btnedit.Text = "Edit";
            // 
            // Btnnew
            // 
            this.Btnnew.Location = new System.Drawing.Point(150, 309);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(75, 23);
            this.Btnnew.TabIndex = 16;
            this.Btnnew.Text = "New";
            // 
            // TransactionsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdTransactions);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.Btnnew);
            this.Name = "TransactionsF";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
    }
}