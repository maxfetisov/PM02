
namespace film_service
{
    partial class PersonForm
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
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.closeButton = new System.Windows.Forms.Button();
            this.lnLabel = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.mnLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.genderCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(99, 12);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(192, 20);
            this.lastName.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(99, 48);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(192, 20);
            this.firstName.TabIndex = 1;
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(99, 86);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(192, 20);
            this.middleName.TabIndex = 2;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(99, 126);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(192, 20);
            this.age.TabIndex = 3;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(99, 201);
            this.height.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(192, 20);
            this.height.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(222, 265);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(22, 15);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(59, 13);
            this.lnLabel.TabIndex = 7;
            this.lnLabel.Text = "Фамилия:";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(49, 51);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(32, 13);
            this.fnLabel.TabIndex = 8;
            this.fnLabel.Text = "Имя:";
            // 
            // mnLabel
            // 
            this.mnLabel.AutoSize = true;
            this.mnLabel.Location = new System.Drawing.Point(26, 89);
            this.mnLabel.Name = "mnLabel";
            this.mnLabel.Size = new System.Drawing.Size(57, 13);
            this.mnLabel.TabIndex = 9;
            this.mnLabel.Text = "Отчество:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(31, 128);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(52, 13);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Возраст:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(53, 165);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(30, 13);
            this.genderLabel.TabIndex = 11;
            this.genderLabel.Text = "Пол:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(49, 203);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(34, 13);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Рост:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(25, 265);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(99, 162);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(192, 21);
            this.genderCB.TabIndex = 14;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 313);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.mnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.height);
            this.Controls.Add(this.age);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label mnLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox genderCB;
    }
}