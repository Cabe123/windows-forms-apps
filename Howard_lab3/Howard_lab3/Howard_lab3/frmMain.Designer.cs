namespace Howard_lab3
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students:";
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(396, 53);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(99, 23);
            this.addNewBtn.TabIndex = 2;
            this.addNewBtn.Text = "Add New...";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(396, 93);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(99, 24);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update...";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(396, 131);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(318, 244);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(55, 22);
            this.totalTextBox.TabIndex = 8;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(318, 284);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(55, 22);
            this.countTextBox.TabIndex = 9;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(318, 321);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(55, 22);
            this.averageTextBox.TabIndex = 10;
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(28, 53);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(345, 164);
            this.studentListBox.TabIndex = 11;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 405);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.ListBox studentListBox;
    }
}

