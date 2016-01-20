namespace AmazonTemplatesComparer
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
            this.FirstFileLabel = new System.Windows.Forms.Label();
            this.SecondFileLabel = new System.Windows.Forms.Label();
            this.FirstFileTextBox = new System.Windows.Forms.TextBox();
            this.SecondFileTextBox = new System.Windows.Forms.TextBox();
            this.FirstFIleSearchButton = new System.Windows.Forms.Button();
            this.SecondFileSearchButton = new System.Windows.Forms.Button();
            this.CompareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstFileLabel
            // 
            this.FirstFileLabel.AutoSize = true;
            this.FirstFileLabel.Location = new System.Drawing.Point(12, 9);
            this.FirstFileLabel.Name = "FirstFileLabel";
            this.FirstFileLabel.Size = new System.Drawing.Size(42, 13);
            this.FirstFileLabel.TabIndex = 0;
            this.FirstFileLabel.Text = "First file";
            // 
            // SecondFileLabel
            // 
            this.SecondFileLabel.AutoSize = true;
            this.SecondFileLabel.Location = new System.Drawing.Point(12, 39);
            this.SecondFileLabel.Name = "SecondFileLabel";
            this.SecondFileLabel.Size = new System.Drawing.Size(60, 13);
            this.SecondFileLabel.TabIndex = 1;
            this.SecondFileLabel.Text = "Second file";
            // 
            // FirstFileTextBox
            // 
            this.FirstFileTextBox.Location = new System.Drawing.Point(82, 6);
            this.FirstFileTextBox.Name = "FirstFileTextBox";
            this.FirstFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstFileTextBox.TabIndex = 2;
            this.FirstFileTextBox.TextChanged += new System.EventHandler(this.FirstFileTextBox_TextChanged);
            // 
            // SecondFileTextBox
            // 
            this.SecondFileTextBox.Location = new System.Drawing.Point(82, 36);
            this.SecondFileTextBox.Name = "SecondFileTextBox";
            this.SecondFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondFileTextBox.TabIndex = 3;
            this.SecondFileTextBox.TextChanged += new System.EventHandler(this.SecondFileTextBox_TextChanged);
            // 
            // FirstFIleSearchButton
            // 
            this.FirstFIleSearchButton.Location = new System.Drawing.Point(197, 6);
            this.FirstFIleSearchButton.Name = "FirstFIleSearchButton";
            this.FirstFIleSearchButton.Size = new System.Drawing.Size(75, 23);
            this.FirstFIleSearchButton.TabIndex = 4;
            this.FirstFIleSearchButton.Text = "Search";
            this.FirstFIleSearchButton.UseVisualStyleBackColor = true;
            this.FirstFIleSearchButton.Click += new System.EventHandler(this.FirstFIleSearchButton_Click);
            // 
            // SecondFileSearchButton
            // 
            this.SecondFileSearchButton.Location = new System.Drawing.Point(197, 35);
            this.SecondFileSearchButton.Name = "SecondFileSearchButton";
            this.SecondFileSearchButton.Size = new System.Drawing.Size(75, 23);
            this.SecondFileSearchButton.TabIndex = 5;
            this.SecondFileSearchButton.Text = "Search";
            this.SecondFileSearchButton.UseVisualStyleBackColor = true;
            this.SecondFileSearchButton.Click += new System.EventHandler(this.SecondFileSearchButton_Click);
            // 
            // CompareButton
            // 
            this.CompareButton.Enabled = false;
            this.CompareButton.Location = new System.Drawing.Point(197, 84);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 23);
            this.CompareButton.TabIndex = 6;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.SecondFileSearchButton);
            this.Controls.Add(this.FirstFIleSearchButton);
            this.Controls.Add(this.SecondFileTextBox);
            this.Controls.Add(this.FirstFileTextBox);
            this.Controls.Add(this.SecondFileLabel);
            this.Controls.Add(this.FirstFileLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstFileLabel;
        private System.Windows.Forms.Label SecondFileLabel;
        private System.Windows.Forms.TextBox FirstFileTextBox;
        private System.Windows.Forms.TextBox SecondFileTextBox;
        private System.Windows.Forms.Button FirstFIleSearchButton;
        private System.Windows.Forms.Button SecondFileSearchButton;
        private System.Windows.Forms.Button CompareButton;
    }
}

