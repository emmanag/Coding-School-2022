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
            this.grvMothlyLedger = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsMonthlyLedger = new System.Windows.Forms.BindingSource(this.components);
            this.bsLedgers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMothlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedgers)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMonthlyLedgers
            // 
            this.GrdMonthlyLedgers.Location = new System.Drawing.Point(2, 2);
            this.GrdMonthlyLedgers.MainView = this.grvMothlyLedger;
            this.GrdMonthlyLedgers.Name = "GrdMonthlyLedgers";
            this.GrdMonthlyLedgers.Size = new System.Drawing.Size(795, 444);
            this.GrdMonthlyLedgers.TabIndex = 15;
            this.GrdMonthlyLedgers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMothlyLedger});
            // 
            // grvMothlyLedger
            // 
            this.grvMothlyLedger.GridControl = this.GrdMonthlyLedgers;
            this.grvMothlyLedger.Name = "grvMothlyLedger";
            this.grvMothlyLedger.OptionsBehavior.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.grvMothlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedgers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdMonthlyLedgers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMothlyLedger;
        private System.Windows.Forms.BindingSource bsMonthlyLedger;
        private System.Windows.Forms.BindingSource bsLedgers;
    }
}