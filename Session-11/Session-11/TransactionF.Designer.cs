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
            this.CtrlmanagerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CtrlcarID = new DevExpress.XtraEditors.TextEdit();
            this.CtrlcustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Ctrltotalprice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrldate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlcarID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlcustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrltotalprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties)).BeginInit();
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
            // CtrlmanagerID
            // 
            this.CtrlmanagerID.Location = new System.Drawing.Point(159, 166);
            this.CtrlmanagerID.Name = "CtrlmanagerID";
            this.CtrlmanagerID.Size = new System.Drawing.Size(100, 20);
            this.CtrlmanagerID.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "ManagerID";
            // 
            // CtrlcarID
            // 
            this.CtrlcarID.Location = new System.Drawing.Point(159, 120);
            this.CtrlcarID.Name = "CtrlcarID";
            this.CtrlcarID.Size = new System.Drawing.Size(100, 20);
            this.CtrlcarID.TabIndex = 25;
            // 
            // CtrlcustomerID
            // 
            this.CtrlcustomerID.Location = new System.Drawing.Point(159, 75);
            this.CtrlcustomerID.Name = "CtrlcustomerID";
            this.CtrlcustomerID.Size = new System.Drawing.Size(100, 20);
            this.CtrlcustomerID.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "CarID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "CustomerID";
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
            this.Ctrldate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrldate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrldate.Properties.DisplayFormat.FormatString = "";
            this.Ctrldate.Properties.EditFormat.FormatString = "";
            this.Ctrldate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.Ctrldate.Properties.MaskSettings.Set("mask", "");
            this.Ctrldate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Ctrldate.Size = new System.Drawing.Size(100, 20);
            this.Ctrldate.TabIndex = 33;
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ctrltotalprice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.CtrlmanagerID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.CtrlcarID);
            this.Controls.Add(this.CtrlcustomerID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Ctrldate);
            this.Name = "TransactionF";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlcarID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlcustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrltotalprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.TextEdit CtrlmanagerID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit CtrlcarID;
        private DevExpress.XtraEditors.TextEdit CtrlcustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Ctrltotalprice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource bsTransaction;
        private DevExpress.XtraEditors.DateEdit Ctrldate;
    }
}