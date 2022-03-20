namespace Session_11
{
    partial class CarF
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
            this.Ctrlmodel = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlbrand = new DevExpress.XtraEditors.TextEdit();
            this.Btncarregistrationumber = new DevExpress.XtraEditors.LabelControl();
            this.Btnmodel = new DevExpress.XtraEditors.LabelControl();
            this.Btnbrand = new DevExpress.XtraEditors.LabelControl();
            this.bsCar = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrlcarregistrationnumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlbrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcarregistrationnumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(371, 349);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 19;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(169, 349);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 18;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Ctrlmodel
            // 
            this.Ctrlmodel.Location = new System.Drawing.Point(169, 80);
            this.Ctrlmodel.Name = "Ctrlmodel";
            this.Ctrlmodel.Size = new System.Drawing.Size(277, 20);
            this.Ctrlmodel.TabIndex = 14;
            // 
            // Ctrlbrand
            // 
            this.Ctrlbrand.Location = new System.Drawing.Point(169, 34);
            this.Ctrlbrand.Name = "Ctrlbrand";
            this.Ctrlbrand.Size = new System.Drawing.Size(277, 20);
            this.Ctrlbrand.TabIndex = 13;
            // 
            // Btncarregistrationumber
            // 
            this.Btncarregistrationumber.Location = new System.Drawing.Point(46, 132);
            this.Btncarregistrationumber.Name = "Btncarregistrationumber";
            this.Btncarregistrationumber.Size = new System.Drawing.Size(112, 13);
            this.Btncarregistrationumber.TabIndex = 12;
            this.Btncarregistrationumber.Text = "CarRegistrationNumber";
            // 
            // Btnmodel
            // 
            this.Btnmodel.Location = new System.Drawing.Point(46, 83);
            this.Btnmodel.Name = "Btnmodel";
            this.Btnmodel.Size = new System.Drawing.Size(28, 13);
            this.Btnmodel.TabIndex = 11;
            this.Btnmodel.Text = "Model";
            // 
            // Btnbrand
            // 
            this.Btnbrand.Location = new System.Drawing.Point(46, 37);
            this.Btnbrand.Name = "Btnbrand";
            this.Btnbrand.Size = new System.Drawing.Size(28, 13);
            this.Btnbrand.TabIndex = 10;
            this.Btnbrand.Text = "Brand";
            // 
            // Ctrlcarregistrationnumber
            // 
            this.Ctrlcarregistrationnumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ctrlcarregistrationnumber.Location = new System.Drawing.Point(169, 125);
            this.Ctrlcarregistrationnumber.Name = "Ctrlcarregistrationnumber";
            this.Ctrlcarregistrationnumber.Size = new System.Drawing.Size(277, 20);
            this.Ctrlcarregistrationnumber.TabIndex = 15;
            // 
            // CarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.Ctrlmodel);
            this.Controls.Add(this.Ctrlbrand);
            this.Controls.Add(this.Btncarregistrationumber);
            this.Controls.Add(this.Btnmodel);
            this.Controls.Add(this.Btnbrand);
            this.Controls.Add(this.Ctrlcarregistrationnumber);
            this.Name = "CarF";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.CarF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlbrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcarregistrationnumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.TextEdit Ctrlmodel;
        private DevExpress.XtraEditors.TextEdit Ctrlbrand;
        private DevExpress.XtraEditors.LabelControl Btncarregistrationumber;
        private DevExpress.XtraEditors.LabelControl Btnmodel;
        private DevExpress.XtraEditors.LabelControl Btnbrand;
        private System.Windows.Forms.BindingSource bsCar;
        private DevExpress.XtraEditors.TextEdit Ctrlcarregistrationnumber;
    }
}