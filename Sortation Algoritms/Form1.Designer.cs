namespace Sortation_Algoritms
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
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Algorithm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Rdb_Ascending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rdb_Descending = new System.Windows.Forms.RadioButton();
            this.Tbx_Output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_SortTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.Location = new System.Drawing.Point(52, 118);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(461, 103);
            this.Tbx_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortation Algorithms Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your array (splite numbers with \",\"): ";
            // 
            // Cmb_Algorithm
            // 
            this.Cmb_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Algorithm.FormattingEnabled = true;
            this.Cmb_Algorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertation Sort"});
            this.Cmb_Algorithm.Location = new System.Drawing.Point(164, 264);
            this.Cmb_Algorithm.Name = "Cmb_Algorithm";
            this.Cmb_Algorithm.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Algorithm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sortation Algorithm : ";
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(245, 364);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sort.TabIndex = 5;
            this.Btn_Sort.Text = "Sort";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sort by : ";
            // 
            // Rdb_Ascending
            // 
            this.Rdb_Ascending.AutoSize = true;
            this.Rdb_Ascending.Location = new System.Drawing.Point(6, 18);
            this.Rdb_Ascending.Name = "Rdb_Ascending";
            this.Rdb_Ascending.Size = new System.Drawing.Size(75, 17);
            this.Rdb_Ascending.TabIndex = 7;
            this.Rdb_Ascending.TabStop = true;
            this.Rdb_Ascending.Text = "Ascending";
            this.Rdb_Ascending.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdb_Descending);
            this.groupBox1.Controls.Add(this.Rdb_Ascending);
            this.groupBox1.Location = new System.Drawing.Point(85, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Rdb_Descending
            // 
            this.Rdb_Descending.AutoSize = true;
            this.Rdb_Descending.Location = new System.Drawing.Point(97, 18);
            this.Rdb_Descending.Name = "Rdb_Descending";
            this.Rdb_Descending.Size = new System.Drawing.Size(82, 17);
            this.Rdb_Descending.TabIndex = 8;
            this.Rdb_Descending.TabStop = true;
            this.Rdb_Descending.Text = "Descending";
            this.Rdb_Descending.UseVisualStyleBackColor = true;
            // 
            // Tbx_Output
            // 
            this.Tbx_Output.Location = new System.Drawing.Point(52, 405);
            this.Tbx_Output.Multiline = true;
            this.Tbx_Output.Name = "Tbx_Output";
            this.Tbx_Output.Size = new System.Drawing.Size(461, 103);
            this.Tbx_Output.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort algorithm  time: ";
            // 
            // Lbl_SortTime
            // 
            this.Lbl_SortTime.AutoSize = true;
            this.Lbl_SortTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SortTime.Location = new System.Drawing.Point(179, 553);
            this.Lbl_SortTime.Name = "Lbl_SortTime";
            this.Lbl_SortTime.Size = new System.Drawing.Size(12, 18);
            this.Lbl_SortTime.TabIndex = 11;
            this.Lbl_SortTime.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 628);
            this.Controls.Add(this.Lbl_SortTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbx_Output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Sort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_Algorithm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Input);
            this.Name = "Form1";
            this.Text = "Sortation Algorithms Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Algorithm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Rdb_Ascending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rdb_Descending;
        private System.Windows.Forms.TextBox Tbx_Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_SortTime;
    }
}

