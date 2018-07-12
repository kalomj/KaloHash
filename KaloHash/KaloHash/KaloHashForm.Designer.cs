namespace KaloHash
{
    partial class KaloHashForm
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
            this.hashDiskButton = new System.Windows.Forms.Button();
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hashDiskButton
            // 
            this.hashDiskButton.Location = new System.Drawing.Point(291, 28);
            this.hashDiskButton.Name = "hashDiskButton";
            this.hashDiskButton.Size = new System.Drawing.Size(121, 23);
            this.hashDiskButton.TabIndex = 0;
            this.hashDiskButton.Text = "Hash Disk";
            this.hashDiskButton.UseVisualStyleBackColor = true;
            this.hashDiskButton.Click += new System.EventHandler(this.hashDiskButton_Click);
            // 
            // driveComboBox
            // 
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.Location = new System.Drawing.Point(84, 30);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(121, 21);
            this.driveComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Drive";
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(16, 57);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.ReadOnly = true;
            this.hashTextBox.Size = new System.Drawing.Size(396, 20);
            this.hashTextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 87);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // KaloHashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 112);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driveComboBox);
            this.Controls.Add(this.hashDiskButton);
            this.Name = "KaloHashForm";
            this.Text = "Kalo Hash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._Closing);
            this.Shown += new System.EventHandler(this._Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hashDiskButton;
        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.Label statusLabel;
    }
}

