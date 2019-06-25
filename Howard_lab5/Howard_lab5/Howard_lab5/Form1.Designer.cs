namespace Howard_lab5
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
            this.positionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.robotLabel = new System.Windows.Forms.Label();
            this.northButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.goTenButton = new System.Windows.Forms.Button();
            this.goOneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(9, 19);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(56, 13);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "{X=0,Y=0}";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.robotLabel);
            this.panel1.Location = new System.Drawing.Point(9, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 204);
            this.panel1.TabIndex = 1;
            // 
            // robotLabel
            // 
            this.robotLabel.AutoSize = true;
            this.robotLabel.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.robotLabel.Location = new System.Drawing.Point(94, 102);
            this.robotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.robotLabel.Name = "robotLabel";
            this.robotLabel.Size = new System.Drawing.Size(12, 12);
            this.robotLabel.TabIndex = 0;
            this.robotLabel.Text = "N";
            this.robotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(94, 249);
            this.northButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(21, 19);
            this.northButton.TabIndex = 2;
            this.northButton.Text = "N";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(120, 272);
            this.eastButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(21, 19);
            this.eastButton.TabIndex = 3;
            this.eastButton.Text = "E";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.eastButton_Click);
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(68, 272);
            this.westButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(21, 19);
            this.westButton.TabIndex = 4;
            this.westButton.Text = "W";
            this.westButton.UseVisualStyleBackColor = true;
            this.westButton.Click += new System.EventHandler(this.westButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(94, 296);
            this.southButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(20, 19);
            this.southButton.TabIndex = 5;
            this.southButton.Text = "S";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(140, 322);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 19);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // goTenButton
            // 
            this.goTenButton.Location = new System.Drawing.Point(146, 272);
            this.goTenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goTenButton.Name = "goTenButton";
            this.goTenButton.Size = new System.Drawing.Size(50, 19);
            this.goTenButton.TabIndex = 7;
            this.goTenButton.Text = "Go 10";
            this.goTenButton.UseVisualStyleBackColor = true;
            this.goTenButton.Click += new System.EventHandler(this.goTenButton_Click);
            // 
            // goOneButton
            // 
            this.goOneButton.Location = new System.Drawing.Point(9, 273);
            this.goOneButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goOneButton.Name = "goOneButton";
            this.goOneButton.Size = new System.Drawing.Size(54, 19);
            this.goOneButton.TabIndex = 8;
            this.goOneButton.Text = "Go 1";
            this.goOneButton.UseVisualStyleBackColor = true;
            this.goOneButton.Click += new System.EventHandler(this.goOneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 350);
            this.Controls.Add(this.goOneButton);
            this.Controls.Add(this.goTenButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.positionLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label robotLabel;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button goTenButton;
        private System.Windows.Forms.Button goOneButton;
    }
}

