namespace DataPresentation
{
    partial class DetailsForm
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
            nameLabel = new Label();
            breedLabel = new Label();
            ageLabel = new Label();
            temperatureLabel = new Label();
            conditionLabel = new Label();
            empNameLabel = new Label();
            roleLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            cityLabel = new Label();
            locationLabel = new Label();
            capacityLabel = new Label();
            widthLabel = new Label();
            lengthLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(56, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "label1";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Location = new Point(56, 66);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new Size(38, 15);
            breedLabel.TabIndex = 10;
            breedLabel.Text = "label2";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(56, 94);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(38, 15);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "label3";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(56, 121);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(38, 15);
            temperatureLabel.TabIndex = 12;
            temperatureLabel.Text = "label4";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(56, 149);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(38, 15);
            conditionLabel.TabIndex = 13;
            conditionLabel.Text = "label5";
            // 
            // empNameLabel
            // 
            empNameLabel.AutoSize = true;
            empNameLabel.Location = new Point(56, 41);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new Size(38, 15);
            empNameLabel.TabIndex = 14;
            empNameLabel.Text = "label1";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(56, 66);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(38, 15);
            roleLabel.TabIndex = 15;
            roleLabel.Text = "label2";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(56, 94);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(38, 15);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "label3";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(56, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(38, 15);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "label4";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(56, 149);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(38, 15);
            cityLabel.TabIndex = 18;
            cityLabel.Text = "label5";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(56, 41);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(38, 15);
            locationLabel.TabIndex = 20;
            locationLabel.Text = "label7";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(56, 94);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(38, 15);
            capacityLabel.TabIndex = 21;
            capacityLabel.Text = "label8";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(56, 66);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(38, 15);
            widthLabel.TabIndex = 22;
            widthLabel.Text = "label9";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(56, 121);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(44, 15);
            lengthLabel.TabIndex = 24;
            lengthLabel.Text = "label11";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(352, 218);
            Controls.Add(lengthLabel);
            Controls.Add(widthLabel);
            Controls.Add(capacityLabel);
            Controls.Add(locationLabel);
            Controls.Add(cityLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(roleLabel);
            Controls.Add(empNameLabel);
            Controls.Add(conditionLabel);
            Controls.Add(temperatureLabel);
            Controls.Add(ageLabel);
            Controls.Add(breedLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DetailsForm";
            Text = "Детали";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private Label breedLabel;
        private Label ageLabel;
        private Label temperatureLabel;
        private Label conditionLabel;
        private Label empNameLabel;
        private Label roleLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label cityLabel;
        private Label locationLabel;
        private Label capacityLabel;
        private Label widthLabel;
        private Label lengthLabel;
    }
}