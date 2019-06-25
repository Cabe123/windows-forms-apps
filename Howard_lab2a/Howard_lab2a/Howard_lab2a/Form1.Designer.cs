namespace Howard_lab2a
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
            this.tempOutputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tempInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertToFahrenheitButton = new System.Windows.Forms.Button();
            this.convertToCelsiusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tempOutputTextBox
            // 
            this.tempOutputTextBox.Location = new System.Drawing.Point(182, 106);
            this.tempOutputTextBox.Name = "tempOutputTextBox";
            this.tempOutputTextBox.ReadOnly = true;
            this.tempOutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.tempOutputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculated Temperature:";
            // 
            // tempInputTextBox
            // 
            this.tempInputTextBox.Location = new System.Drawing.Point(182, 48);
            this.tempInputTextBox.Name = "tempInputTextBox";
            this.tempInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.tempInputTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature Input:";
            // 
            // convertToFahrenheitButton
            // 
            this.convertToFahrenheitButton.Location = new System.Drawing.Point(50, 159);
            this.convertToFahrenheitButton.Name = "convertToFahrenheitButton";
            this.convertToFahrenheitButton.Size = new System.Drawing.Size(92, 60);
            this.convertToFahrenheitButton.TabIndex = 4;
            this.convertToFahrenheitButton.Text = "Convert to Fahrenheit";
            this.convertToFahrenheitButton.UseVisualStyleBackColor = true;
            this.convertToFahrenheitButton.Click += new System.EventHandler(this.convertToFahrenheitButton_Click);
            // 
            // convertToCelsiusButton
            // 
            this.convertToCelsiusButton.Location = new System.Drawing.Point(172, 159);
            this.convertToCelsiusButton.Name = "convertToCelsiusButton";
            this.convertToCelsiusButton.Size = new System.Drawing.Size(94, 60);
            this.convertToCelsiusButton.TabIndex = 5;
            this.convertToCelsiusButton.Text = "Convert to Celsius";
            this.convertToCelsiusButton.UseVisualStyleBackColor = true;
            this.convertToCelsiusButton.Click += new System.EventHandler(this.convertToCelsiusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 231);
            this.Controls.Add(this.convertToCelsiusButton);
            this.Controls.Add(this.convertToFahrenheitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempInputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempOutputTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempOutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertToFahrenheitButton;
        private System.Windows.Forms.Button convertToCelsiusButton;
    }
}

