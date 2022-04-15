namespace Gas_Station.Win.CustomerForms
{
    partial class CustomersListF
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
            this.grvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.bntRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCustomerList
            // 
            this.grvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomerList.Location = new System.Drawing.Point(12, 12);
            this.grvCustomerList.Name = "grvCustomerList";
            this.grvCustomerList.RowTemplate.Height = 25;
            this.grvCustomerList.Size = new System.Drawing.Size(776, 374);
            this.grvCustomerList.TabIndex = 1;
            this.grvCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCustomerList_CellContentClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(314, 407);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(474, 407);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Edit ";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(634, 407);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // bntRefresh
            // 
            this.bntRefresh.Location = new System.Drawing.Point(12, 407);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(154, 31);
            this.bntRefresh.TabIndex = 5;
            this.bntRefresh.Text = "Refresh";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // CustomersListF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grvCustomerList);
            this.Name = "CustomersListF";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerListF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView grvCustomerList;
        private Button btnAddCustomer;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
        private Button bntRefresh;
    }
}