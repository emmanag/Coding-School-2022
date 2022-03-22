namespace Session_11
{
    partial class EngineerF
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
            this.Ctrlsurname = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsEngineer = new System.Windows.Forms.BindingSource(this.components);
            this.CtrlmanagerID = new DevExpress.XtraEditors.LookUpEdit();
            this.Ctrlsallarypermonth = new DevExpress.XtraEditors.SpinEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsallarypermonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(437, 350);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 19;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(235, 350);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 18;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "SallaryPerMonth";
            // 
            // Ctrlsurname
            // 
            this.Ctrlsurname.Location = new System.Drawing.Point(147, 56);
            this.Ctrlsurname.Name = "Ctrlsurname";
            this.Ctrlsurname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlsurname.TabIndex = 14;
            this.Ctrlsurname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlsurname_Validating);
            // 
            // Ctrlname
            // 
            this.Ctrlname.Location = new System.Drawing.Point(147, 10);
            this.Ctrlname.Name = "Ctrlname";
            this.Ctrlname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlname.TabIndex = 13;
            this.Ctrlname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlname_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Manager";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Surname";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Name";
            // 
            // CtrlmanagerID
            // 
            this.CtrlmanagerID.Location = new System.Drawing.Point(147, 101);
            this.CtrlmanagerID.Name = "CtrlmanagerID";
            this.CtrlmanagerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlmanagerID.Properties.NullText = "";
            this.CtrlmanagerID.Size = new System.Drawing.Size(277, 20);
            this.CtrlmanagerID.TabIndex = 15;
            this.CtrlmanagerID.Validating += new System.ComponentModel.CancelEventHandler(this.CtrlmanagerID_Validating);
            // 
            // Ctrlsallarypermonth
            // 
            this.Ctrlsallarypermonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ctrlsallarypermonth.Location = new System.Drawing.Point(147, 147);
            this.Ctrlsallarypermonth.Name = "Ctrlsallarypermonth";
            this.Ctrlsallarypermonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrlsallarypermonth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Ctrlsallarypermonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.Ctrlsallarypermonth.Size = new System.Drawing.Size(277, 20);
            this.Ctrlsallarypermonth.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Ctrlsallarypermonth);
            this.panelControl1.Controls.Add(this.CtrlmanagerID);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Ctrlsurname);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.Ctrlname);
            this.panelControl1.Location = new System.Drawing.Point(106, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(543, 206);
            this.panelControl1.TabIndex = 20;
            // 
            // EngineerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Name = "EngineerF";
            this.Text = "Engineer";
            this.Load += new System.EventHandler(this.CarF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsallarypermonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Ctrlsurname;
        private DevExpress.XtraEditors.TextEdit Ctrlname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsEngineer;
        private DevExpress.XtraEditors.LookUpEdit CtrlmanagerID;
        private DevExpress.XtraEditors.SpinEdit Ctrlsallarypermonth;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}