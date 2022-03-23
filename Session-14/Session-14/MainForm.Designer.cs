namespace Session_14
{
    partial class MainForm
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnadd = new System.Windows.Forms.Button();
            this.Btnfinish = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(548, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btnadd
            // 
            this.Btnadd.Location = new System.Drawing.Point(12, 33);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(75, 23);
            this.Btnadd.TabIndex = 1;
            this.Btnadd.Text = "Add";
            this.Btnadd.UseVisualStyleBackColor = true;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Btnfinish
            // 
            this.Btnfinish.Location = new System.Drawing.Point(485, 33);
            this.Btnfinish.Name = "Btnfinish";
            this.Btnfinish.Size = new System.Drawing.Size(75, 23);
            this.Btnfinish.TabIndex = 2;
            this.Btnfinish.Text = "Finish";
            this.Btnfinish.UseVisualStyleBackColor = true;
            this.Btnfinish.Click += new System.EventHandler(this.Btnfinish_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btnfinish);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Btnadd;
        private Button Btnfinish;
        private TextBox textBox1;
    }
}