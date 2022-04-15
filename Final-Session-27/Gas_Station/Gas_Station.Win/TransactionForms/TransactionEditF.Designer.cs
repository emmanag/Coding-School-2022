namespace Gas_Station.Win.TransactionForms
{
    partial class TransactionEditF
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
            this.bntClose = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.ctrPayMethod = new System.Windows.Forms.ComboBox();
            this.grvTransactionLine = new System.Windows.Forms.DataGridView();
            this.bntDeleteTL = new System.Windows.Forms.Button();
            this.bntAddTL = new System.Windows.Forms.Button();
            this.bntEditTL = new System.Windows.Forms.Button();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.ctrEmployee = new System.Windows.Forms.ComboBox();
            this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
            this.bntRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(654, 402);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(134, 36);
            this.bntClose.TabIndex = 11;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(498, 402);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(134, 36);
            this.bntSave.TabIndex = 10;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(26, 92);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(59, 15);
            this.lblSurName.TabIndex = 7;
            this.lblSurName.Text = "Employee";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Payment Method";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(135, 41);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(228, 23);
            this.txtCustomerName.TabIndex = 16;
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(135, 167);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.Size = new System.Drawing.Size(114, 23);
            this.txtTotalValue.TabIndex = 18;
            // 
            // ctrPayMethod
            // 
            this.ctrPayMethod.FormattingEnabled = true;
            this.ctrPayMethod.Location = new System.Drawing.Point(135, 125);
            this.ctrPayMethod.Name = "ctrPayMethod";
            this.ctrPayMethod.Size = new System.Drawing.Size(228, 23);
            this.ctrPayMethod.TabIndex = 19;
            // 
            // grvTransactionLine
            // 
            this.grvTransactionLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionLine.Location = new System.Drawing.Point(26, 213);
            this.grvTransactionLine.Name = "grvTransactionLine";
            this.grvTransactionLine.RowTemplate.Height = 25;
            this.grvTransactionLine.Size = new System.Drawing.Size(762, 183);
            this.grvTransactionLine.TabIndex = 20;
            // 
            // bntDeleteTL
            // 
            this.bntDeleteTL.Location = new System.Drawing.Point(701, 186);
            this.bntDeleteTL.Name = "bntDeleteTL";
            this.bntDeleteTL.Size = new System.Drawing.Size(88, 21);
            this.bntDeleteTL.TabIndex = 22;
            this.bntDeleteTL.Text = "Delete";
            this.bntDeleteTL.UseVisualStyleBackColor = true;
            this.bntDeleteTL.Click += new System.EventHandler(this.bntDeleteTL_Click);
            // 
            // bntAddTL
            // 
            this.bntAddTL.Location = new System.Drawing.Point(513, 186);
            this.bntAddTL.Name = "bntAddTL";
            this.bntAddTL.Size = new System.Drawing.Size(88, 21);
            this.bntAddTL.TabIndex = 21;
            this.bntAddTL.Text = "Add";
            this.bntAddTL.UseVisualStyleBackColor = true;
            this.bntAddTL.Click += new System.EventHandler(this.bntAddTL_Click);
            // 
            // bntEditTL
            // 
            this.bntEditTL.Location = new System.Drawing.Point(607, 186);
            this.bntEditTL.Name = "bntEditTL";
            this.bntEditTL.Size = new System.Drawing.Size(88, 21);
            this.bntEditTL.TabIndex = 23;
            this.bntEditTL.Text = "Edit";
            this.bntEditTL.UseVisualStyleBackColor = true;
            
            // 
            // ctrEmployee
            // 
            this.ctrEmployee.FormattingEnabled = true;
            this.ctrEmployee.Location = new System.Drawing.Point(135, 84);
            this.ctrEmployee.Name = "ctrEmployee";
            this.ctrEmployee.Size = new System.Drawing.Size(228, 23);
            this.ctrEmployee.TabIndex = 25;
            // 
            // bntRefresh
            // 
            this.bntRefresh.Location = new System.Drawing.Point(26, 402);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(134, 36);
            this.bntRefresh.TabIndex = 26;
            this.bntRefresh.Text = "Refresh";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // TransactionEditF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.ctrEmployee);
            this.Controls.Add(this.bntEditTL);
            this.Controls.Add(this.bntDeleteTL);
            this.Controls.Add(this.bntAddTL);
            this.Controls.Add(this.grvTransactionLine);
            this.Controls.Add(this.ctrPayMethod);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblName);
            this.Name = "TransactionEditF";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionEditF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntClose;
        private Button bntSave;
        private Label lblSurName;
        private Label lblName;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerName;
        private TextBox txtTotalValue;
        private ComboBox ctrPayMethod;
        private DataGridView grvTransactionLine;
        private Button bntDeleteTL;
        private Button bntAddTL;
        private Button bntEditTL;
        private BindingSource bsTransaction;
        private ComboBox ctrEmployee;
        private BindingSource bsEmployees;
        private Button bntRefresh;
        private BindingSource bsTransactionLine;
    }
}