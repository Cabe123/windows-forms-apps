namespace Howard_lab1
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
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.Flushes = new System.Windows.Forms.GroupBox();
            this.tranFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partsInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalFeesTextBox = new System.Windows.Forms.TextBox();
            this.partsTaxTextBox = new System.Windows.Forms.TextBox();
            this.partsOutputTextBox = new System.Windows.Forms.TextBox();
            this.serviceAndLaborTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Flushes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeJobCheckBox);
            this.groupBox1.Controls.Add(this.oilChangeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(20, 50);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(143, 21);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(20, 22);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(158, 21);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Flushes
            // 
            this.Flushes.Controls.Add(this.tranFlushCheckBox);
            this.Flushes.Controls.Add(this.radFlushCheckBox);
            this.Flushes.Location = new System.Drawing.Point(247, 13);
            this.Flushes.Name = "Flushes";
            this.Flushes.Size = new System.Drawing.Size(242, 87);
            this.Flushes.TabIndex = 1;
            this.Flushes.TabStop = false;
            this.Flushes.Text = "Flushes";
            // 
            // tranFlushCheckBox
            // 
            this.tranFlushCheckBox.AutoSize = true;
            this.tranFlushCheckBox.Location = new System.Drawing.Point(18, 50);
            this.tranFlushCheckBox.Name = "tranFlushCheckBox";
            this.tranFlushCheckBox.Size = new System.Drawing.Size(210, 21);
            this.tranFlushCheckBox.TabIndex = 1;
            this.tranFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.tranFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radFlushCheckBox
            // 
            this.radFlushCheckBox.AutoSize = true;
            this.radFlushCheckBox.Location = new System.Drawing.Point(18, 22);
            this.radFlushCheckBox.Name = "radFlushCheckBox";
            this.radFlushCheckBox.Size = new System.Drawing.Size(180, 21);
            this.radFlushCheckBox.TabIndex = 0;
            this.radFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tireRotationCheckBox);
            this.groupBox2.Controls.Add(this.replaceMufflerCheckBox);
            this.groupBox2.Controls.Add(this.inspectionCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(19, 78);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(170, 21);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(19, 50);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(195, 21);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(19, 22);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(152, 21);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.laborTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.partsInputTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(249, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(96, 67);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 22);
            this.laborTextBox.TabIndex = 3;
            this.laborTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Labor ($)";
            // 
            // partsInputTextBox
            // 
            this.partsInputTextBox.Location = new System.Drawing.Point(96, 33);
            this.partsInputTextBox.Name = "partsInputTextBox";
            this.partsInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.partsInputTextBox.TabIndex = 1;
            this.partsInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalFeesTextBox);
            this.groupBox4.Controls.Add(this.partsTaxTextBox);
            this.groupBox4.Controls.Add(this.partsOutputTextBox);
            this.groupBox4.Controls.Add(this.serviceAndLaborTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 187);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summary";
            // 
            // totalFeesTextBox
            // 
            this.totalFeesTextBox.Location = new System.Drawing.Point(137, 131);
            this.totalFeesTextBox.Name = "totalFeesTextBox";
            this.totalFeesTextBox.ReadOnly = true;
            this.totalFeesTextBox.Size = new System.Drawing.Size(147, 22);
            this.totalFeesTextBox.TabIndex = 7;
            // 
            // partsTaxTextBox
            // 
            this.partsTaxTextBox.Location = new System.Drawing.Point(137, 93);
            this.partsTaxTextBox.Name = "partsTaxTextBox";
            this.partsTaxTextBox.ReadOnly = true;
            this.partsTaxTextBox.Size = new System.Drawing.Size(147, 22);
            this.partsTaxTextBox.TabIndex = 6;
            // 
            // partsOutputTextBox
            // 
            this.partsOutputTextBox.Location = new System.Drawing.Point(137, 56);
            this.partsOutputTextBox.Name = "partsOutputTextBox";
            this.partsOutputTextBox.ReadOnly = true;
            this.partsOutputTextBox.Size = new System.Drawing.Size(147, 22);
            this.partsOutputTextBox.TabIndex = 5;
            // 
            // serviceAndLaborTextBox
            // 
            this.serviceAndLaborTextBox.Location = new System.Drawing.Point(137, 19);
            this.serviceAndLaborTextBox.Name = "serviceAndLaborTextBox";
            this.serviceAndLaborTextBox.ReadOnly = true;
            this.serviceAndLaborTextBox.Size = new System.Drawing.Size(147, 22);
            this.serviceAndLaborTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(49, 427);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(94, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(194, 427);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(345, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(499, 462);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Flushes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Flushes.ResumeLayout(false);
            this.Flushes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox Flushes;
        private System.Windows.Forms.CheckBox tranFlushCheckBox;
        private System.Windows.Forms.CheckBox radFlushCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partsInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partsOutputTextBox;
        private System.Windows.Forms.TextBox serviceAndLaborTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox partsTaxTextBox;
        private System.Windows.Forms.TextBox totalFeesTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

