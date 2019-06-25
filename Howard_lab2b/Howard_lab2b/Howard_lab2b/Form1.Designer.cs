namespace Howard_lab2b
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalOutputTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.classCOutputTextBox = new System.Windows.Forms.TextBox();
            this.classBOutputTextBox = new System.Windows.Forms.TextBox();
            this.classAOutputTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classCTextBox);
            this.groupBox1.Controls.Add(this.classBTextBox);
            this.groupBox1.Controls.Add(this.classATextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(108, 160);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(100, 22);
            this.classCTextBox.TabIndex = 6;
            this.classCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(108, 124);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(100, 22);
            this.classBTextBox.TabIndex = 5;
            this.classBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(108, 89);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(100, 22);
            this.classATextBox.TabIndex = 4;
            this.classATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalOutputTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.classCOutputTextBox);
            this.groupBox2.Controls.Add(this.classBOutputTextBox);
            this.groupBox2.Controls.Add(this.classAOutputTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(319, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // totalOutputTextBox
            // 
            this.totalOutputTextBox.Location = new System.Drawing.Point(111, 178);
            this.totalOutputTextBox.Name = "totalOutputTextBox";
            this.totalOutputTextBox.ReadOnly = true;
            this.totalOutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalOutputTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total:";
            // 
            // classCOutputTextBox
            // 
            this.classCOutputTextBox.Location = new System.Drawing.Point(111, 139);
            this.classCOutputTextBox.Name = "classCOutputTextBox";
            this.classCOutputTextBox.ReadOnly = true;
            this.classCOutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.classCOutputTextBox.TabIndex = 7;
            // 
            // classBOutputTextBox
            // 
            this.classBOutputTextBox.Location = new System.Drawing.Point(111, 94);
            this.classBOutputTextBox.Name = "classBOutputTextBox";
            this.classBOutputTextBox.ReadOnly = true;
            this.classBOutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.classBOutputTextBox.TabIndex = 6;
            // 
            // classAOutputTextBox
            // 
            this.classAOutputTextBox.Location = new System.Drawing.Point(111, 52);
            this.classAOutputTextBox.Name = "classAOutputTextBox";
            this.classAOutputTextBox.ReadOnly = true;
            this.classAOutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.classAOutputTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class A:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(135, 304);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 52);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(253, 304);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 52);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(367, 304);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(627, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalOutputTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox classCOutputTextBox;
        private System.Windows.Forms.TextBox classBOutputTextBox;
        private System.Windows.Forms.TextBox classAOutputTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

