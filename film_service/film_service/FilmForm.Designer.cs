
namespace film_service
{
    partial class FilmForm
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
            this.filmName = new System.Windows.Forms.TextBox();
            this.filmDescription = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.filmGenre = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPerson = new System.Windows.Forms.DataGridView();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.filmDuration = new System.Windows.Forms.NumericUpDown();
            this.filmTallage = new System.Windows.Forms.NumericUpDown();
            this.duratiomLabel = new System.Windows.Forms.Label();
            this.tallageLabel = new System.Windows.Forms.Label();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.deleteGenreButton = new System.Windows.Forms.Button();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.personCB = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.postCB = new System.Windows.Forms.ComboBox();
            this.sveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTallage)).BeginInit();
            this.SuspendLayout();
            // 
            // filmName
            // 
            this.filmName.Location = new System.Drawing.Point(214, 12);
            this.filmName.Name = "filmName";
            this.filmName.Size = new System.Drawing.Size(363, 20);
            this.filmName.TabIndex = 0;
            // 
            // filmDescription
            // 
            this.filmDescription.Location = new System.Drawing.Point(12, 51);
            this.filmDescription.Name = "filmDescription";
            this.filmDescription.Size = new System.Drawing.Size(776, 147);
            this.filmDescription.TabIndex = 1;
            this.filmDescription.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 35);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Описание:";
            // 
            // filmGenre
            // 
            this.filmGenre.AllowUserToAddRows = false;
            this.filmGenre.AllowUserToDeleteRows = false;
            this.filmGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.name});
            this.filmGenre.Location = new System.Drawing.Point(12, 211);
            this.filmGenre.Name = "filmGenre";
            this.filmGenre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmGenre.Size = new System.Drawing.Size(234, 150);
            this.filmGenre.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Идентификатор";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Жанр";
            this.name.Name = "name";
            // 
            // filmPerson
            // 
            this.filmPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmPerson.Location = new System.Drawing.Point(268, 211);
            this.filmPerson.Name = "filmPerson";
            this.filmPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmPerson.Size = new System.Drawing.Size(520, 150);
            this.filmPerson.TabIndex = 5;
            this.filmPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmPerson_CellDoubleClick);
            // 
            // feedbackButton
            // 
            this.feedbackButton.Location = new System.Drawing.Point(338, 485);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(138, 23);
            this.feedbackButton.TabIndex = 6;
            this.feedbackButton.Text = "Посмотреть отзывы";
            this.feedbackButton.UseVisualStyleBackColor = true;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // filmDuration
            // 
            this.filmDuration.Location = new System.Drawing.Point(237, 438);
            this.filmDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.filmDuration.Name = "filmDuration";
            this.filmDuration.Size = new System.Drawing.Size(120, 20);
            this.filmDuration.TabIndex = 7;
            // 
            // filmTallage
            // 
            this.filmTallage.Location = new System.Drawing.Point(528, 438);
            this.filmTallage.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.filmTallage.Name = "filmTallage";
            this.filmTallage.Size = new System.Drawing.Size(158, 20);
            this.filmTallage.TabIndex = 8;
            // 
            // duratiomLabel
            // 
            this.duratiomLabel.AutoSize = true;
            this.duratiomLabel.Location = new System.Drawing.Point(132, 440);
            this.duratiomLabel.Name = "duratiomLabel";
            this.duratiomLabel.Size = new System.Drawing.Size(83, 13);
            this.duratiomLabel.TabIndex = 9;
            this.duratiomLabel.Text = "Длительность:";
            // 
            // tallageLabel
            // 
            this.tallageLabel.AutoSize = true;
            this.tallageLabel.Location = new System.Drawing.Point(455, 440);
            this.tallageLabel.Name = "tallageLabel";
            this.tallageLabel.Size = new System.Drawing.Size(43, 13);
            this.tallageLabel.TabIndex = 10;
            this.tallageLabel.Text = "Сборы:";
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(171, 361);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 11;
            this.addGenreButton.Text = "Добавить";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.Location = new System.Drawing.Point(12, 383);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(234, 23);
            this.deleteGenreButton.TabIndex = 12;
            this.deleteGenreButton.Text = "Удалить";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // genreCB
            // 
            this.genreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(13, 362);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(157, 21);
            this.genreCB.TabIndex = 13;
            // 
            // personCB
            // 
            this.personCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personCB.FormattingEnabled = true;
            this.personCB.Location = new System.Drawing.Point(268, 362);
            this.personCB.Name = "personCB";
            this.personCB.Size = new System.Drawing.Size(230, 21);
            this.personCB.TabIndex = 16;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(268, 383);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(520, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(713, 361);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 14;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // postCB
            // 
            this.postCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postCB.FormattingEnabled = true;
            this.postCB.Location = new System.Drawing.Point(499, 362);
            this.postCB.Name = "postCB";
            this.postCB.Size = new System.Drawing.Size(214, 21);
            this.postCB.TabIndex = 17;
            // 
            // sveButton
            // 
            this.sveButton.Location = new System.Drawing.Point(15, 485);
            this.sveButton.Name = "sveButton";
            this.sveButton.Size = new System.Drawing.Size(138, 23);
            this.sveButton.TabIndex = 18;
            this.sveButton.Text = "Сохранить";
            this.sveButton.UseVisualStyleBackColor = true;
            this.sveButton.Click += new System.EventHandler(this.sveButton_Click);
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.sveButton);
            this.Controls.Add(this.postCB);
            this.Controls.Add(this.personCB);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.tallageLabel);
            this.Controls.Add(this.duratiomLabel);
            this.Controls.Add(this.filmTallage);
            this.Controls.Add(this.filmDuration);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.filmPerson);
            this.Controls.Add(this.filmGenre);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.filmDescription);
            this.Controls.Add(this.filmName);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.filmGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTallage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filmName;
        private System.Windows.Forms.RichTextBox filmDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DataGridView filmGenre;
        private System.Windows.Forms.DataGridView filmPerson;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.NumericUpDown filmDuration;
        private System.Windows.Forms.NumericUpDown filmTallage;
        private System.Windows.Forms.Label duratiomLabel;
        private System.Windows.Forms.Label tallageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button deleteGenreButton;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.ComboBox personCB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ComboBox postCB;
        private System.Windows.Forms.Button sveButton;
    }
}