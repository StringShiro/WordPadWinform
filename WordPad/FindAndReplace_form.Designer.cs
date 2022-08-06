namespace WordPad
{
    partial class FindAndReplace_form
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
            this.Find_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.Relace_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_relapce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find_label
            // 
            this.Find_label.AutoSize = true;
            this.Find_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Find_label.Location = new System.Drawing.Point(12, 25);
            this.Find_label.Name = "Find_label";
            this.Find_label.Size = new System.Drawing.Size(50, 25);
            this.Find_label.TabIndex = 0;
            this.Find_label.Text = "Find";
            this.Find_label.Click += new System.EventHandler(this.Find_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(310, 25);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // Relace_label
            // 
            this.Relace_label.AutoSize = true;
            this.Relace_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Relace_label.Location = new System.Drawing.Point(12, 63);
            this.Relace_label.Name = "Relace_label";
            this.Relace_label.Size = new System.Drawing.Size(83, 25);
            this.Relace_label.TabIndex = 0;
            this.Relace_label.Text = "Replace";
            this.Relace_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_relapce
            // 
            this.btn_relapce.Location = new System.Drawing.Point(310, 65);
            this.btn_relapce.Name = "btn_relapce";
            this.btn_relapce.Size = new System.Drawing.Size(75, 23);
            this.btn_relapce.TabIndex = 2;
            this.btn_relapce.Text = "Replace";
            this.btn_relapce.UseVisualStyleBackColor = true;
            this.btn_relapce.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindAndReplace_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 117);
            this.Controls.Add(this.btn_relapce);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Relace_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Find_label);
            this.Name = "FindAndReplace_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Find_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label Relace_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_relapce;
    }
}