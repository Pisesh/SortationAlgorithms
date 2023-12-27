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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Tbp_Sort = new System.Windows.Forms.TabPage();
            this.Tbp_Find = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rdb_Descending = new System.Windows.Forms.RadioButton();
            this.Rdb_Ascending = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Algorithm = new System.Windows.Forms.ComboBox();
            this.Chb_NR = new System.Windows.Forms.CheckBox();
            this.Btn_Genrate = new System.Windows.Forms.Button();
            this.Tbx_Distance_End = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbx_Distance_First = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbx_Count = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_SortTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_Output = new System.Windows.Forms.TextBox();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.Tbp_Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Tbp_Sort);
            this.tabControl.Controls.Add(this.Tbp_Find);
            this.tabControl.Location = new System.Drawing.Point(5, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(599, 612);
            this.tabControl.TabIndex = 13;
            // 
            // Tbp_Sort
            // 
            this.Tbp_Sort.BackColor = System.Drawing.SystemColors.Control;
            this.Tbp_Sort.Controls.Add(this.splitContainer1);
            this.Tbp_Sort.Controls.Add(this.Lbl_SortTime);
            this.Tbp_Sort.Controls.Add(this.label5);
            this.Tbp_Sort.Controls.Add(this.Tbx_Output);
            this.Tbp_Sort.Controls.Add(this.Btn_Sort);
            this.Tbp_Sort.Controls.Add(this.label2);
            this.Tbp_Sort.Controls.Add(this.label1);
            this.Tbp_Sort.Controls.Add(this.Tbx_Input);
            this.Tbp_Sort.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Sort.Name = "Tbp_Sort";
            this.Tbp_Sort.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Sort.Size = new System.Drawing.Size(591, 586);
            this.Tbp_Sort.TabIndex = 0;
            this.Tbp_Sort.Text = "Sort";
            // 
            // Tbp_Find
            // 
            this.Tbp_Find.BackColor = System.Drawing.SystemColors.Control;
            this.Tbp_Find.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Find.Name = "Tbp_Find";
            this.Tbp_Find.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Find.Size = new System.Drawing.Size(591, 586);
            this.Tbp_Find.TabIndex = 1;
            this.Tbp_Find.Text = "Find";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 213);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Cmb_Algorithm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Chb_NR);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Genrate);
            this.splitContainer1.Panel2.Controls.Add(this.Tbx_Distance_End);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.Tbx_Distance_First);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.Tbx_Count);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(579, 167);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdb_Descending);
            this.groupBox1.Controls.Add(this.Rdb_Ascending);
            this.groupBox1.Location = new System.Drawing.Point(87, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 12;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sort by : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sortation Algorithm : ";
            // 
            // Cmb_Algorithm
            // 
            this.Cmb_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Algorithm.FormattingEnabled = true;
            this.Cmb_Algorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Insertion Sort",
            "Quick Sort"});
            this.Cmb_Algorithm.Location = new System.Drawing.Point(166, 27);
            this.Cmb_Algorithm.Name = "Cmb_Algorithm";
            this.Cmb_Algorithm.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Algorithm.TabIndex = 9;
            // 
            // Chb_NR
            // 
            this.Chb_NR.AutoSize = true;
            this.Chb_NR.Location = new System.Drawing.Point(25, 131);
            this.Chb_NR.Name = "Chb_NR";
            this.Chb_NR.Size = new System.Drawing.Size(79, 17);
            this.Chb_NR.TabIndex = 20;
            this.Chb_NR.Text = "Non reapet";
            this.Chb_NR.UseVisualStyleBackColor = true;
            // 
            // Btn_Genrate
            // 
            this.Btn_Genrate.Location = new System.Drawing.Point(167, 127);
            this.Btn_Genrate.Name = "Btn_Genrate";
            this.Btn_Genrate.Size = new System.Drawing.Size(75, 23);
            this.Btn_Genrate.TabIndex = 18;
            this.Btn_Genrate.Text = "Genrate";
            this.Btn_Genrate.UseVisualStyleBackColor = true;
            this.Btn_Genrate.Click += new System.EventHandler(this.Btn_Genrate_Click);
            // 
            // Tbx_Distance_End
            // 
            this.Tbx_Distance_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Distance_End.Location = new System.Drawing.Point(191, 81);
            this.Tbx_Distance_End.Name = "Tbx_Distance_End";
            this.Tbx_Distance_End.Size = new System.Drawing.Size(80, 26);
            this.Tbx_Distance_End.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "To :";
            // 
            // Tbx_Distance_First
            // 
            this.Tbx_Distance_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Distance_First.Location = new System.Drawing.Point(71, 81);
            this.Tbx_Distance_First.Name = "Tbx_Distance_First";
            this.Tbx_Distance_First.Size = new System.Drawing.Size(74, 26);
            this.Tbx_Distance_First.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "From :";
            // 
            // Tbx_Count
            // 
            this.Tbx_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Count.Location = new System.Drawing.Point(71, 42);
            this.Tbx_Count.Name = "Tbx_Count";
            this.Tbx_Count.Size = new System.Drawing.Size(149, 26);
            this.Tbx_Count.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Genrate random number for test";
            // 
            // Lbl_SortTime
            // 
            this.Lbl_SortTime.AutoSize = true;
            this.Lbl_SortTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SortTime.Location = new System.Drawing.Point(176, 550);
            this.Lbl_SortTime.Name = "Lbl_SortTime";
            this.Lbl_SortTime.Size = new System.Drawing.Size(12, 18);
            this.Lbl_SortTime.TabIndex = 19;
            this.Lbl_SortTime.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "algorithm time: ";
            // 
            // Tbx_Output
            // 
            this.Tbx_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Output.Location = new System.Drawing.Point(46, 427);
            this.Tbx_Output.Multiline = true;
            this.Tbx_Output.Name = "Tbx_Output";
            this.Tbx_Output.Size = new System.Drawing.Size(461, 103);
            this.Tbx_Output.TabIndex = 17;
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(239, 386);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sort.TabIndex = 16;
            this.Btn_Sort.Text = "Sort";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter number of your array (splite numbers with \",\"): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sortation Algorithms Test";
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Input.Location = new System.Drawing.Point(46, 104);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(461, 103);
            this.Tbx_Input.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(608, 628);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Sortation Algorithms Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Tbp_Sort.ResumeLayout(false);
            this.Tbp_Sort.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Tbp_Sort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rdb_Descending;
        private System.Windows.Forms.RadioButton Rdb_Ascending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_Algorithm;
        private System.Windows.Forms.CheckBox Chb_NR;
        private System.Windows.Forms.Button Btn_Genrate;
        private System.Windows.Forms.TextBox Tbx_Distance_End;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tbx_Distance_First;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbx_Count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_SortTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_Output;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Input;
        private System.Windows.Forms.TabPage Tbp_Find;
    }
}

