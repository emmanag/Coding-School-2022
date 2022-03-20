namespace Session_11
{
    partial class ServiceTaskF
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
            this.Ctrlcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsServiceTask = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrldescription = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlhours = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlhours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(382, 354);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 29;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(180, 354);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 28;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Ctrlcode
            // 
            this.Ctrlcode.Location = new System.Drawing.Point(180, 39);
            this.Ctrlcode.Name = "Ctrlcode";
            this.Ctrlcode.Size = new System.Drawing.Size(277, 20);
            this.Ctrlcode.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Hours";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 137);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Code";
            // 
            // Ctrldescription
            // 
            this.Ctrldescription.Location = new System.Drawing.Point(180, 130);
            this.Ctrldescription.Name = "Ctrldescription";
            this.Ctrldescription.Size = new System.Drawing.Size(277, 20);
            this.Ctrldescription.TabIndex = 30;
            // 
            // Ctrlhours
            // 
            this.Ctrlhours.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ctrlhours.Location = new System.Drawing.Point(180, 85);
            this.Ctrlhours.Name = "Ctrlhours";
            this.Ctrlhours.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrlhours.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Ctrlhours.Properties.MaxValue = new decimal(new int[] {
            80,
            0,
            0,
            65536});
            this.Ctrlhours.Size = new System.Drawing.Size(277, 20);
            this.Ctrlhours.TabIndex = 25;
            // 
            // ServiceTaskF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.Ctrlcode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Ctrldescription);
            this.Controls.Add(this.Ctrlhours);
            this.Name = "ServiceTaskF";
            this.Text = "Service Task";
            this.Load += new System.EventHandler(this.ServiceTaskF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlhours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.TextEdit Ctrlcode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsServiceTask;
        private DevExpress.XtraEditors.TextEdit Ctrldescription;
        private DevExpress.XtraEditors.SpinEdit Ctrlhours;
    }
}