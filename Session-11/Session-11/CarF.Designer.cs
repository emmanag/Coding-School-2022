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
            this.Btncarregistrationumber = new DevExpress.XtraEditors.LabelControl();
            this.Btnmodel = new DevExpress.XtraEditors.LabelControl();
            this.Btnbrand = new DevExpress.XtraEditors.LabelControl();
            this.bsCar = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrlcarregistrationnumber = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlbrand = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcarregistrationnumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlbrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(467, 346);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 19;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(265, 346);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 18;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Ctrlmodel
            // 
            this.Ctrlmodel.Location = new System.Drawing.Point(241, 77);
            this.Ctrlmodel.Name = "Ctrlmodel";
            this.Ctrlmodel.Size = new System.Drawing.Size(277, 20);
            this.Ctrlmodel.TabIndex = 14;
            this.Ctrlmodel.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlmodel_Validating);
            // 
            // Btncarregistrationumber
            // 
            this.Btncarregistrationumber.Location = new System.Drawing.Point(116, 127);
            this.Btncarregistrationumber.Name = "Btncarregistrationumber";
            this.Btncarregistrationumber.Size = new System.Drawing.Size(112, 13);
            this.Btncarregistrationumber.TabIndex = 12;
            this.Btncarregistrationumber.Text = "CarRegistrationNumber";
            // 
            // Btnmodel
            // 
            this.Btnmodel.Location = new System.Drawing.Point(116, 78);
            this.Btnmodel.Name = "Btnmodel";
            this.Btnmodel.Size = new System.Drawing.Size(28, 13);
            this.Btnmodel.TabIndex = 11;
            this.Btnmodel.Text = "Model";
            // 
            // Btnbrand
            // 
            this.Btnbrand.Location = new System.Drawing.Point(116, 32);
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
            this.Ctrlcarregistrationnumber.Location = new System.Drawing.Point(241, 122);
            this.Ctrlcarregistrationnumber.Name = "Ctrlcarregistrationnumber";
            this.Ctrlcarregistrationnumber.Size = new System.Drawing.Size(277, 20);
            this.Ctrlcarregistrationnumber.TabIndex = 15;
            this.Ctrlcarregistrationnumber.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlcarregistrationnumber_Validating);
            // 
            // Ctrlbrand
            // 
            this.Ctrlbrand.Location = new System.Drawing.Point(241, 31);
            this.Ctrlbrand.Name = "Ctrlbrand";
            this.Ctrlbrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrlbrand.Properties.NullText = "";
            this.Ctrlbrand.Properties.PopupView = this.searchLookUpEdit1View;
            this.Ctrlbrand.Size = new System.Drawing.Size(277, 20);
            this.Ctrlbrand.TabIndex = 13;
            this.Ctrlbrand.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlbrand_Validating);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Ctrlcarregistrationnumber);
            this.panelControl1.Controls.Add(this.Ctrlbrand);
            this.panelControl1.Controls.Add(this.Btnbrand);
            this.panelControl1.Controls.Add(this.Ctrlmodel);
            this.panelControl1.Controls.Add(this.Btnmodel);
            this.panelControl1.Controls.Add(this.Btncarregistrationumber);
            this.panelControl1.Location = new System.Drawing.Point(57, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(635, 178);
            this.panelControl1.TabIndex = 20;
            // 
            // CarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnsave);
            this.Name = "CarF";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.CarF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcarregistrationnumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlbrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.TextEdit Ctrlmodel;
        private DevExpress.XtraEditors.LabelControl Btncarregistrationumber;
        private DevExpress.XtraEditors.LabelControl Btnmodel;
        private DevExpress.XtraEditors.LabelControl Btnbrand;
        private System.Windows.Forms.BindingSource bsCar;
        private DevExpress.XtraEditors.TextEdit Ctrlcarregistrationnumber;
        private DevExpress.XtraEditors.SearchLookUpEdit Ctrlbrand;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}