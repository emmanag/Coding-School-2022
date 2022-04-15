namespace Gas_Station.Win.TransactionFomrs
{
    partial class TransactionList
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
            this.bntRefresh = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.grvTransactionList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionList)).BeginInit();
            this.SuspendLayout();
            // 
            // bntRefresh
            // 
            this.bntRefresh.Location = new System.Drawing.Point(12, 407);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(154, 31);
            this.bntRefresh.TabIndex = 10;
            this.bntRefresh.Text = "Refresh";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(634, 407);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(154, 31);
            this.btnDeleteTransaction.TabIndex = 9;
            this.btnDeleteTransaction.Text = "Delete";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(474, 407);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(154, 31);
            this.btnEditTransaction.TabIndex = 8;
            this.btnEditTransaction.Text = "Edit ";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(314, 407);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(154, 31);
            this.btnAddTransaction.TabIndex = 7;
            this.btnAddTransaction.Text = "Add ";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // grvTransactionList
            // 
            this.grvTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionList.Location = new System.Drawing.Point(12, 12);
            this.grvTransactionList.Name = "grvTransactionList";
            this.grvTransactionList.RowTemplate.Height = 25;
            this.grvTransactionList.Size = new System.Drawing.Size(776, 374);
            this.grvTransactionList.TabIndex = 6;
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnEditTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.grvTransactionList);
            this.Name = "TransactionList";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionListF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bntRefresh;
        private Button btnDeleteTransaction;
        private Button btnEditTransaction;
        private Button btnAddTransaction;
        private DataGridView grvTransactionList;
    }
}