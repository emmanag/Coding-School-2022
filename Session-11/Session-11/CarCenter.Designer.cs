namespace Session_11
{
    partial class CarCenter
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
            this.Btnload = new DevExpress.XtraEditors.SimpleButton();
            this.Btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.Btncar = new DevExpress.XtraEditors.SimpleButton();
            this.Btncustomer = new DevExpress.XtraEditors.SimpleButton();
            this.Btnengineer = new DevExpress.XtraEditors.SimpleButton();
            this.Btnmanager = new DevExpress.XtraEditors.SimpleButton();
            this.Btnmonthlyledger = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btntransaction = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Btnload
            // 
            this.Btnload.Location = new System.Drawing.Point(215, 335);
            this.Btnload.Name = "Btnload";
            this.Btnload.Size = new System.Drawing.Size(75, 23);
            this.Btnload.TabIndex = 0;
            this.Btnload.Text = "Load";
            this.Btnload.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(445, 335);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 1;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Btncar
            // 
            this.Btncar.Location = new System.Drawing.Point(215, 137);
            this.Btncar.Name = "Btncar";
            this.Btncar.Size = new System.Drawing.Size(75, 23);
            this.Btncar.TabIndex = 2;
            this.Btncar.Text = "Car";
            this.Btncar.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Btncustomer
            // 
            this.Btncustomer.Location = new System.Drawing.Point(336, 137);
            this.Btncustomer.Name = "Btncustomer";
            this.Btncustomer.Size = new System.Drawing.Size(75, 23);
            this.Btncustomer.TabIndex = 3;
            this.Btncustomer.Text = "Customer";
            this.Btncustomer.Click += new System.EventHandler(this.Btncustomer_Click);
            // 
            // Btnengineer
            // 
            this.Btnengineer.Location = new System.Drawing.Point(445, 137);
            this.Btnengineer.Name = "Btnengineer";
            this.Btnengineer.Size = new System.Drawing.Size(75, 23);
            this.Btnengineer.TabIndex = 4;
            this.Btnengineer.Text = "Engineer";
            this.Btnengineer.Click += new System.EventHandler(this.Btnengineer_Click);
            // 
            // Btnmanager
            // 
            this.Btnmanager.Location = new System.Drawing.Point(445, 203);
            this.Btnmanager.Name = "Btnmanager";
            this.Btnmanager.Size = new System.Drawing.Size(75, 23);
            this.Btnmanager.TabIndex = 5;
            this.Btnmanager.Text = "Manager";
            this.Btnmanager.Click += new System.EventHandler(this.Btnmanager_Click);
            // 
            // Btnmonthlyledger
            // 
            this.Btnmonthlyledger.Location = new System.Drawing.Point(326, 266);
            this.Btnmonthlyledger.Name = "Btnmonthlyledger";
            this.Btnmonthlyledger.Size = new System.Drawing.Size(96, 23);
            this.Btnmonthlyledger.TabIndex = 6;
            this.Btnmonthlyledger.Text = "Monthly Ledger";
            this.Btnmonthlyledger.Click += new System.EventHandler(this.Btnmonthlyledger_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(215, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Service Task";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // Btntransaction
            // 
            this.Btntransaction.Location = new System.Drawing.Point(336, 203);
            this.Btntransaction.Name = "Btntransaction";
            this.Btntransaction.Size = new System.Drawing.Size(75, 23);
            this.Btntransaction.TabIndex = 8;
            this.Btntransaction.Text = "Transaction";
            this.Btntransaction.Click += new System.EventHandler(this.Btntransaction_Click);
            // 
            // CarCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btntransaction);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Btnmonthlyledger);
            this.Controls.Add(this.Btnmanager);
            this.Controls.Add(this.Btnengineer);
            this.Controls.Add(this.Btncustomer);
            this.Controls.Add(this.Btncar);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.Btnload);
            this.Name = "CarCenter";
            this.Text = "CarCenter";
            this.Load += new System.EventHandler(this.CarCenter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnload;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.SimpleButton Btncar;
        private DevExpress.XtraEditors.SimpleButton Btncustomer;
        private DevExpress.XtraEditors.SimpleButton Btnengineer;
        private DevExpress.XtraEditors.SimpleButton Btnmanager;
        private DevExpress.XtraEditors.SimpleButton Btnmonthlyledger;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btntransaction;
    }
}

