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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(115, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(115, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlPassword.Location = new System.Drawing.Point(190, 79);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(239, 20);
            this.ctrlPassword.TabIndex = 3;
            // 
            // Btnenter
            // 
            this.Btnenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnenter.Location = new System.Drawing.Point(245, 276);
            this.Btnenter.Name = "Btnenter";
            this.Btnenter.Size = new System.Drawing.Size(92, 25);
            this.Btnenter.TabIndex = 4;
            this.Btnenter.Text = "Enter";
            this.Btnenter.Click += new System.EventHandler(this.Btnenter_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(392, 276);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(92, 25);
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlUsername.Location = new System.Drawing.Point(190, 31);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlUsername.Properties.NullText = "";
            this.ctrlUsername.Properties.ShowHeader = false;
            this.ctrlUsername.Size = new System.Drawing.Size(239, 20);
            this.ctrlUsername.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.ctrlPassword);
            this.panelControl1.Controls.Add(this.ctrlUsername);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(87, 59);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(555, 163);
            this.panelControl1.TabIndex = 6;
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(721, 452);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Btnenter);
            this.Name = "LoginF";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
        private DevExpress.XtraEditors.SimpleButton Btnenter;
        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.LookUpEdit ctrlUsername;
        private System.Windows.Forms.BindingSource bsUsers;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}