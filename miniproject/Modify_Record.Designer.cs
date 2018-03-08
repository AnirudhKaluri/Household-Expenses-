namespace miniproject
{
    partial class Modify_Record
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DATE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "FOOD",
            "CLOTHING",
            "GROCERY",
            "RENT",
            "ELECTRONICS",
            "MAINTENANCE",
            "EDUCATION",
            "MEDICAL",
            "CONVEYANCE"});
            this.ComboBox1.Location = new System.Drawing.Point(202, 62);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 1;
            this.ComboBox1.Text = "CATEGORY";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // DATE
            // 
            this.DATE.AutoSize = true;
            this.DATE.Location = new System.Drawing.Point(49, 19);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(45, 17);
            this.DATE.TabIndex = 3;
            this.DATE.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AMOUNT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "MODIFY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Modify_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Modify_Record";
            this.Text = "Modify_Record";
            this.Load += new System.EventHandler(this.Modify_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}