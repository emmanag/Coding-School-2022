namespace Gas_Station.Win.TransactionLineForms
{
    partial class TransactionLineF
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.ctrItem = new System.Windows.Forms.ComboBox();
            this.ctrQuantity = new System.Windows.Forms.NumericUpDown();
            this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
            this.bntRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(397, 125);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(134, 36);
            this.bntClose.TabIndex = 11;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(244, 125);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(134, 36);
            this.bntSave.TabIndex = 10;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(46, 79);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(46, 37);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(31, 15);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Item";
            // 
            // ctrItem
            // 
            this.ctrItem.FormattingEnabled = true;
            this.ctrItem.Location = new System.Drawing.Point(123, 29);
            this.ctrItem.Name = "ctrItem";
            this.ctrItem.Size = new System.Drawing.Size(408, 23);
            this.ctrItem.TabIndex = 12;
            // 
            // ctrQuantity
            // 
            this.ctrQuantity.Location = new System.Drawing.Point(123, 71);
            this.ctrQuantity.Name = "ctrQuantity";
            this.ctrQuantity.Size = new System.Drawing.Size(177, 23);
            this.ctrQuantity.TabIndex = 13;
            // 
            // bntRefresh
            // 
            this.bntRefresh.Location = new System.Drawing.Point(12, 125);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(134, 36);
            this.bntRefresh.TabIndex = 14;
            this.bntRefresh.Text = "Refresh";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // TransactionLineF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 173);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.ctrQuantity);
            this.Controls.Add(this.ctrItem);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItem);
            this.Name = "TransactionLineF";
            this.Text = "TransactionLineF";
            this.Load += new System.EventHandler(this.TransactionLineF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntClose;
        private Button bntSave;
        private Label lblQuantity;
        private Label lblItem;
        private ComboBox ctrItem;
        private NumericUpDown ctrQuantity;
        private BindingSource bsTransactionLine;
        private Button bntRefresh;
    }
}