namespace Gas_Station.Win.ItemForms
{
    partial class ItemListF
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
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grvItemList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvItemList)).BeginInit();
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
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(634, 407);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(474, 407);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnEditCustomer.TabIndex = 8;
            this.btnEditCustomer.Text = "Edit ";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(314, 407);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(154, 31);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grvItemList
            // 
            this.grvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvItemList.Location = new System.Drawing.Point(12, 12);
            this.grvItemList.Name = "grvItemList";
            this.grvItemList.RowTemplate.Height = 25;
            this.grvItemList.Size = new System.Drawing.Size(776, 374);
            this.grvItemList.TabIndex = 6;
            this.grvItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvItemList_CellContentClick);
            // 
            // ItemListF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grvItemList);
            this.Name = "ItemListF";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemListF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bntRefresh;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private Button btnAddCustomer;
        private DataGridView grvItemList;
    }
}