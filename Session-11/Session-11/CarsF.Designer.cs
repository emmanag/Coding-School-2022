﻿namespace Session_11
{
    partial class CarsF
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
            this.Grdcars = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grdcars
            // 
            this.Grdcars.Location = new System.Drawing.Point(2, 1);
            this.Grdcars.MainView = this.gridView1;
            this.Grdcars.Name = "Grdcars";
            this.Grdcars.Size = new System.Drawing.Size(795, 162);
            this.Grdcars.TabIndex = 0;
            this.Grdcars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grdcars.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grdcars;
            this.gridView1.Name = "gridView1";
            // 
            // Btnnew
            // 
            this.Btnnew.Location = new System.Drawing.Point(150, 309);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(75, 23);
            this.Btnnew.TabIndex = 1;
            this.Btnnew.Text = "New";
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(264, 309);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(75, 23);
            this.Btnedit.TabIndex = 2;
            this.Btnedit.Text = "Edit";
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(385, 309);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 23);
            this.Btndelete.TabIndex = 3;
            this.Btndelete.Text = "Delete";
            // 
            // Btnclose
            // 
            this.Btnclose.Location = new System.Drawing.Point(501, 309);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(80, 23);
            this.Btnclose.TabIndex = 4;
            this.Btnclose.Text = "Close";
            // 
            // CarsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.Btnnew);
            this.Controls.Add(this.Grdcars);
            this.Name = "CarsF";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.Grdcars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grdcars;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
    }
}