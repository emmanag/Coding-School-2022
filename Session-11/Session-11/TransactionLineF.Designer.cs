namespace Session_11
{
    partial class TransactionLineF
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
            this.CtrlservicetaskID = new DevExpress.XtraEditors.LookUpEdit();
            this.CtrlengineerID = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlservicetaskID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlengineerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(379, 362);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 29;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(177, 362);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 28;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Engineer";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "ServiceTask";
            // 
            // CtrlservicetaskID
            // 
            this.CtrlservicetaskID.Location = new System.Drawing.Point(188, 47);
            this.CtrlservicetaskID.Name = "CtrlservicetaskID";
            this.CtrlservicetaskID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlservicetaskID.Properties.NullText = "";
            this.CtrlservicetaskID.Size = new System.Drawing.Size(277, 20);
            this.CtrlservicetaskID.TabIndex = 24;
            this.CtrlservicetaskID.EditValueChanged += new System.EventHandler(this.CtrlservicetaskID_EditValueChanged);
            // 
            // CtrlengineerID
            // 
            this.CtrlengineerID.Location = new System.Drawing.Point(188, 92);
            this.CtrlengineerID.Name = "CtrlengineerID";
            this.CtrlengineerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlengineerID.Properties.NullText = "";
            this.CtrlengineerID.Size = new System.Drawing.Size(277, 20);
            this.CtrlengineerID.TabIndex = 25;
            // 
            // TransactionLineF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.CtrlservicetaskID);
            this.Controls.Add(this.CtrlengineerID);
            this.Name = "TransactionLineF";
            this.Text = "TransactionLine";
            this.Load += new System.EventHandler(this.TransactionLineF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlservicetaskID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlengineerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bsTransactionLine;
        private DevExpress.XtraEditors.LookUpEdit CtrlservicetaskID;
        private DevExpress.XtraEditors.LookUpEdit CtrlengineerID;
    }
}