namespace Gas_Station.Win.CustomerForms
{
    partial class CustomerEditF
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(44, 83);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(54, 15);
            this.lblSurName.TabIndex = 1;
            this.lblSurName.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(135, 75);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(177, 23);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(12, 171);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(134, 36);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(188, 171);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(134, 36);
            this.bntClose.TabIndex = 5;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(44, 125);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(76, 15);
            this.lblCardNumber.TabIndex = 6;
            this.lblCardNumber.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(135, 117);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(177, 23);
            this.txtCardNumber.TabIndex = 7;
            // 
            // CustomerEditF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 228);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblName);
            this.Name = "CustomerEditF";
            this.Text = "Customer Edit";
            this.Load += new System.EventHandler(this.CustomerEditF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblSurName;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button bntSave;
        private Button bntClose;
        private BindingSource bsCustomer;
        private Label lblCardNumber;
        private TextBox txtCardNumber;
    }
}