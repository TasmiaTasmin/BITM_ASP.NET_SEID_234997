namespace DisplayWindowsForms
{
    partial class HomeApplication
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
            this.showButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.textBoxDisplayCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(307, 135);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(30, 90);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Pen",
            "Pencil"});
            this.comboBoxCategory.Location = new System.Drawing.Point(151, 82);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(33, 176);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(41, 13);
            this.displayLabel.TabIndex = 10;
            this.displayLabel.Text = "Display";
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Location = new System.Drawing.Point(33, 214);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(0, 13);
            this.labelDisplayName.TabIndex = 11;
            // 
            // textBoxDisplayCategory
            // 
            this.textBoxDisplayCategory.Location = new System.Drawing.Point(151, 214);
            this.textBoxDisplayCategory.Name = "textBoxDisplayCategory";
            this.textBoxDisplayCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisplayCategory.TabIndex = 12;
            // 
            // HomeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDisplayCategory);
            this.Controls.Add(this.labelDisplayName);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "HomeApplication";
            this.Text = "Home Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.TextBox textBoxDisplayCategory;
    }
}

