
namespace film_service
{
    partial class OtherTablesForm
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
            this.genreDGV = new System.Windows.Forms.DataGridView();
            this.postDGV = new System.Windows.Forms.DataGridView();
            this.personDGV = new System.Windows.Forms.DataGridView();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.saveChangesGenreButton = new System.Windows.Forms.Button();
            this.deleteGenreButton = new System.Windows.Forms.Button();
            this.deletePostButton = new System.Windows.Forms.Button();
            this.saveChangesPostButton = new System.Windows.Forms.Button();
            this.addPostButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.saveChangesPersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // genreDGV
            // 
            this.genreDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDGV.Location = new System.Drawing.Point(12, 12);
            this.genreDGV.Name = "genreDGV";
            this.genreDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genreDGV.Size = new System.Drawing.Size(333, 277);
            this.genreDGV.TabIndex = 0;
            // 
            // postDGV
            // 
            this.postDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postDGV.Location = new System.Drawing.Point(447, 12);
            this.postDGV.Name = "postDGV";
            this.postDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postDGV.Size = new System.Drawing.Size(341, 277);
            this.postDGV.TabIndex = 1;
            // 
            // personDGV
            // 
            this.personDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDGV.Location = new System.Drawing.Point(12, 349);
            this.personDGV.Name = "personDGV";
            this.personDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personDGV.Size = new System.Drawing.Size(776, 161);
            this.personDGV.TabIndex = 3;
            this.personDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personDGV_CellDoubleClick);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(12, 285);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(98, 23);
            this.addGenreButton.TabIndex = 4;
            this.addGenreButton.Text = "Добавить";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // saveChangesGenreButton
            // 
            this.saveChangesGenreButton.Location = new System.Drawing.Point(106, 285);
            this.saveChangesGenreButton.Name = "saveChangesGenreButton";
            this.saveChangesGenreButton.Size = new System.Drawing.Size(133, 23);
            this.saveChangesGenreButton.TabIndex = 14;
            this.saveChangesGenreButton.Text = "Сохранить изменение";
            this.saveChangesGenreButton.UseVisualStyleBackColor = true;
            this.saveChangesGenreButton.Click += new System.EventHandler(this.saveChangesGenreButton_Click);
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.Location = new System.Drawing.Point(234, 285);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(111, 23);
            this.deleteGenreButton.TabIndex = 15;
            this.deleteGenreButton.Text = "Удалить";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // deletePostButton
            // 
            this.deletePostButton.Location = new System.Drawing.Point(685, 285);
            this.deletePostButton.Name = "deletePostButton";
            this.deletePostButton.Size = new System.Drawing.Size(103, 23);
            this.deletePostButton.TabIndex = 18;
            this.deletePostButton.Text = "Удалить";
            this.deletePostButton.UseVisualStyleBackColor = true;
            this.deletePostButton.Click += new System.EventHandler(this.deletePostButton_Click);
            // 
            // saveChangesPostButton
            // 
            this.saveChangesPostButton.Location = new System.Drawing.Point(550, 285);
            this.saveChangesPostButton.Name = "saveChangesPostButton";
            this.saveChangesPostButton.Size = new System.Drawing.Size(137, 23);
            this.saveChangesPostButton.TabIndex = 17;
            this.saveChangesPostButton.Text = "Сохранить изменение";
            this.saveChangesPostButton.UseVisualStyleBackColor = true;
            this.saveChangesPostButton.Click += new System.EventHandler(this.saveChangesPostButton_Click);
            // 
            // addPostButton
            // 
            this.addPostButton.Location = new System.Drawing.Point(447, 285);
            this.addPostButton.Name = "addPostButton";
            this.addPostButton.Size = new System.Drawing.Size(106, 23);
            this.addPostButton.TabIndex = 16;
            this.addPostButton.Text = "Добавить";
            this.addPostButton.UseVisualStyleBackColor = true;
            this.addPostButton.Click += new System.EventHandler(this.addPostButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(503, 506);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(285, 23);
            this.deletePersonButton.TabIndex = 24;
            this.deletePersonButton.Text = "Удалить";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(12, 506);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(285, 23);
            this.addPersonButton.TabIndex = 22;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // saveChangesPersonButton
            // 
            this.saveChangesPersonButton.Location = new System.Drawing.Point(295, 506);
            this.saveChangesPersonButton.Name = "saveChangesPersonButton";
            this.saveChangesPersonButton.Size = new System.Drawing.Size(211, 23);
            this.saveChangesPersonButton.TabIndex = 23;
            this.saveChangesPersonButton.Text = "Изменить";
            this.saveChangesPersonButton.UseVisualStyleBackColor = true;
            this.saveChangesPersonButton.Click += new System.EventHandler(this.saveChangesPersonButton_Click);
            // 
            // OtherTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.saveChangesPersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.deletePostButton);
            this.Controls.Add(this.saveChangesPostButton);
            this.Controls.Add(this.addPostButton);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.saveChangesGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.personDGV);
            this.Controls.Add(this.postDGV);
            this.Controls.Add(this.genreDGV);
            this.Name = "OtherTablesForm";
            this.Text = "OtherTablesForm";
            ((System.ComponentModel.ISupportInitialize)(this.genreDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView genreDGV;
        private System.Windows.Forms.DataGridView postDGV;
        private System.Windows.Forms.DataGridView personDGV;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button saveChangesGenreButton;
        private System.Windows.Forms.Button deleteGenreButton;
        private System.Windows.Forms.Button deletePostButton;
        private System.Windows.Forms.Button saveChangesPostButton;
        private System.Windows.Forms.Button addPostButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button saveChangesPersonButton;
    }
}