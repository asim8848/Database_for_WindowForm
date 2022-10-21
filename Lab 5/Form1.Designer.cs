namespace Lab_5
{
    partial class Form1
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
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactname = new System.Windows.Forms.TextBox();
            this.phoneS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(139, 285);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company Name";
            // 
            // companyname
            // 
            this.companyname.Location = new System.Drawing.Point(207, 112);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(100, 22);
            this.companyname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Name";
            // 
            // contactname
            // 
            this.contactname.Location = new System.Drawing.Point(207, 171);
            this.contactname.Name = "contactname";
            this.contactname.Size = new System.Drawing.Size(100, 22);
            this.contactname.TabIndex = 7;
            // 
            // phoneS
            // 
            this.phoneS.Location = new System.Drawing.Point(207, 223);
            this.phoneS.Name = "phoneS";
            this.phoneS.Size = new System.Drawing.Size(100, 22);
            this.phoneS.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 178);
            this.dataGridView1.TabIndex = 10;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(649, 297);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 11;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 561);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.phoneS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contactname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactname;
        private System.Windows.Forms.TextBox phoneS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show;
    }
}

