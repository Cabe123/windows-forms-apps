namespace Howard_lab3
{
    partial class frmAddStudent
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scoresOutputTextBox = new System.Windows.Forms.TextBox();
            this.clearScoresBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(105, 88);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(86, 22);
            this.scoreTextBox.TabIndex = 3;
            this.scoreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreTextBox_KeyPress);
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Location = new System.Drawing.Point(245, 87);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(103, 23);
            this.addScoreBtn.TabIndex = 4;
            this.addScoreBtn.Text = "Add Score";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.addScoreBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scores:";
            // 
            // scoresOutputTextBox
            // 
            this.scoresOutputTextBox.Location = new System.Drawing.Point(105, 142);
            this.scoresOutputTextBox.Name = "scoresOutputTextBox";
            this.scoresOutputTextBox.ReadOnly = true;
            this.scoresOutputTextBox.Size = new System.Drawing.Size(243, 22);
            this.scoresOutputTextBox.TabIndex = 6;
            // 
            // clearScoresBtn
            // 
            this.clearScoresBtn.Location = new System.Drawing.Point(245, 180);
            this.clearScoresBtn.Name = "clearScoresBtn";
            this.clearScoresBtn.Size = new System.Drawing.Size(103, 23);
            this.clearScoresBtn.TabIndex = 7;
            this.clearScoresBtn.Text = "Clear Scores";
            this.clearScoresBtn.UseVisualStyleBackColor = true;
            this.clearScoresBtn.Click += new System.EventHandler(this.clearScoresBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(175, 233);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(272, 233);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 285);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.clearScoresBtn);
            this.Controls.Add(this.scoresOutputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addScoreBtn);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoresOutputTextBox;
        private System.Windows.Forms.Button clearScoresBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}