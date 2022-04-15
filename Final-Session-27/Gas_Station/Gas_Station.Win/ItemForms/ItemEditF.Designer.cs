namespace Gas_Station.Win.ItemForms
{
    partial class ItemEditF
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboItemType = new System.Windows.Forms.ComboBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.txtCost = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(44, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 15);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Item Type";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(44, 125);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(44, 167);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 33);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 23);
            this.txtDescription.TabIndex = 4;
            // 
            // comboItemType
            // 
            this.comboItemType.FormattingEnabled = true;
            this.comboItemType.Location = new System.Drawing.Point(117, 75);
            this.comboItemType.Name = "comboItemType";
            this.comboItemType.Size = new System.Drawing.Size(175, 23);
            this.comboItemType.TabIndex = 7;
            
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(185, 216);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(134, 36);
            this.bntClose.TabIndex = 9;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(12, 216);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(134, 36);
            this.bntSave.TabIndex = 8;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // txtCost
            // 
            this.txtCost.DecimalPlaces = 3;
            this.txtCost.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCost.Location = new System.Drawing.Point(117, 117);
            this.txtCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(175, 23);
            this.txtCost.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.DecimalPlaces = 3;
            this.txtPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrice.Location = new System.Drawing.Point(117, 159);
            this.txtPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 23);
            this.txtPrice.TabIndex = 11;
            // 
            // ItemEditF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 264);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.comboItemType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Name = "ItemEditF";
            this.Text = "ItemEditF";
            this.Load += new System.EventHandler(this.CustomerEditF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblType;
        private Label lblCost;
        private Label lblPrice;
        private TextBox txtDescription;
        private ComboBox comboItemType;
        private Button bntClose;
        private Button bntSave;
        private BindingSource bsItem;
        private NumericUpDown txtCost;
        private NumericUpDown txtPrice;
    }
}