namespace Session_11
{
    partial class MonthlyLedgersF
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
            this.GrdMonthlyLedgers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsMonthlyLedger = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMonthlyLedgers
            // 
            this.GrdMonthlyLedgers.Location = new System.Drawing.Point(2, 2);
            this.GrdMonthlyLedgers.MainView = this.gridView1;
            this.GrdMonthlyLedgers.Name = "GrdMonthlyLedgers";
            this.GrdMonthlyLedgers.Size = new System.Drawing.Size(795, 444);
            this.GrdMonthlyLedgers.TabIndex = 15;
            this.GrdMonthlyLedgers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdMonthlyLedgers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // MonthlyLedgersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdMonthlyLedgers);
            this.Name = "MonthlyLedgersF";
            this.Text = "MonthlyLedgers";
            this.Load += new System.EventHandler(this.MonthlyLedgersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdMonthlyLedgers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsMonthlyLedger;
    }
}