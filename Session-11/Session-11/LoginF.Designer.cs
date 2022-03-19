namespace Session_11
{
    partial class LoginF
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlPassword = new DevExpress.XtraEditors.TextEdit();
            this.Btnenter = new DevExpress.XtraEditors.SimpleButton();
            this.Btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlUsername = new DevExpress.XtraEditors.LookUpEdit();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(170, 116);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(170, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Location = new System.Drawing.Point(245, 161);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(222, 20);
            this.ctrlPassword.TabIndex = 3;
            // 
            // Btnenter
            // 
            this.Btnenter.Location = new System.Drawing.Point(245, 268);
            this.Btnenter.Name = "Btnenter";
            this.Btnenter.Size = new System.Drawing.Size(75, 23);
            this.Btnenter.TabIndex = 4;
            this.Btnenter.Text = "Enter";
            this.Btnenter.Click += new System.EventHandler(this.Btnenter_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(392, 268);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(75, 23);
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Location = new System.Drawing.Point(245, 113);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlUsername.Properties.NullText = "";
            this.ctrlUsername.Properties.ShowHeader = false;
            this.ctrlUsername.Size = new System.Drawing.Size(222, 20);
            this.ctrlUsername.TabIndex = 2;
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnenter);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlUsername);
            this.Name = "LoginF";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
        private DevExpress.XtraEditors.SimpleButton Btnenter;
        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.LookUpEdit ctrlUsername;
        private System.Windows.Forms.BindingSource bsUsers;
    }
}