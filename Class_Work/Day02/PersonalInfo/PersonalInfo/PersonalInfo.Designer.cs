namespace PersonalInfo
{
    partial class PersonalInfo
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
            this.labelPersonalInfo = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.ParentsNameButton = new System.Windows.Forms.Button();
            this.AddressButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelFathersName = new System.Windows.Forms.Label();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.labelMothersName = new System.Windows.Forms.Label();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.Location = new System.Drawing.Point(179, 9);
            this.labelPersonalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new System.Drawing.Size(363, 39);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information";
            this.labelPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(52, 60);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(276, 274);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(136, 23);
            this.ShowButton.TabIndex = 2;
            this.ShowButton.Text = "Show All Information";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(168, 274);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(144, 316);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 3;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // ParentsNameButton
            // 
            this.ParentsNameButton.Location = new System.Drawing.Point(253, 316);
            this.ParentsNameButton.Name = "ParentsNameButton";
            this.ParentsNameButton.Size = new System.Drawing.Size(105, 23);
            this.ParentsNameButton.TabIndex = 4;
            this.ParentsNameButton.Text = "Parent\'s Name";
            this.ParentsNameButton.UseVisualStyleBackColor = true;
            this.ParentsNameButton.Click += new System.EventHandler(this.ParentsNameButton_Click);
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(392, 316);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(75, 23);
            this.AddressButton.TabIndex = 5;
            this.AddressButton.Text = "Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(168, 60);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(52, 96);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(168, 96);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // labelFathersName
            // 
            this.labelFathersName.AutoSize = true;
            this.labelFathersName.Location = new System.Drawing.Point(52, 136);
            this.labelFathersName.Name = "labelFathersName";
            this.labelFathersName.Size = new System.Drawing.Size(75, 13);
            this.labelFathersName.TabIndex = 1;
            this.labelFathersName.Text = "Father\'s Name";
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(168, 136);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.fathersNameTextBox.TabIndex = 6;
            // 
            // labelMothersName
            // 
            this.labelMothersName.AutoSize = true;
            this.labelMothersName.Location = new System.Drawing.Point(52, 172);
            this.labelMothersName.Name = "labelMothersName";
            this.labelMothersName.Size = new System.Drawing.Size(78, 13);
            this.labelMothersName.TabIndex = 1;
            this.labelMothersName.Text = "Mother\'s Name";
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(168, 172);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.mothersNameTextBox.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(52, 210);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(168, 210);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(160, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.ParentsNameButton);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.labelMothersName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.labelFathersName);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelPersonalInfo);
            this.Name = "PersonalInfo";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonalInfo;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button ParentsNameButton;
        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label labelFathersName;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.Label labelMothersName;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}

