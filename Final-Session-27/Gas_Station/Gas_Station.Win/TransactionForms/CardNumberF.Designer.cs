namespace Gas_Station.Win.TransactionForms
{
    partial class CardNumberF
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
            this.bntContiue = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntContiue
            // 
            this.bntContiue.Location = new System.Drawing.Point(98, 125);
            this.bntContiue.Name = "bntContiue";
            this.bntContiue.Size = new System.Drawing.Size(134, 36);
            this.bntContiue.TabIndex = 9;
            this.bntContiue.Text = "Continue";
            this.bntContiue.UseVisualStyleBackColor = true;
            this.bntContiue.Click += new System.EventHandler(this.bntContiue_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "CardNumber";
            // 
            // CardNumberF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 173);
            this.Controls.Add(this.bntContiue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "CardNumberF";
            this.Text = "Card Number ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntContiue;
        private TextBox txtName;
        private Label lblName;
    }
}