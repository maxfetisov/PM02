
namespace film_service
{
    partial class FeedbackForm
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
            this.feedbackDGV = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.NumericUpDown();
            this.text = new System.Windows.Forms.RichTextBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.addFeedbackButton = new System.Windows.Forms.Button();
            this.deleteFeedbackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackDGV
            // 
            this.feedbackDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feedbackDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackDGV.Location = new System.Drawing.Point(-1, 124);
            this.feedbackDGV.Name = "feedbackDGV";
            this.feedbackDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feedbackDGV.Size = new System.Drawing.Size(804, 328);
            this.feedbackDGV.TabIndex = 0;
            // 
            // mark
            // 
            this.mark.DecimalPlaces = 1;
            this.mark.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mark.Location = new System.Drawing.Point(12, 44);
            this.mark.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(120, 20);
            this.mark.TabIndex = 1;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(269, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(519, 77);
            this.text.TabIndex = 2;
            this.text.Text = "";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(13, 25);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(48, 13);
            this.markLabel.TabIndex = 3;
            this.markLabel.Text = "Оценка:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(220, 44);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(43, 13);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Отзыв:";
            // 
            // addFeedbackButton
            // 
            this.addFeedbackButton.Location = new System.Drawing.Point(12, 95);
            this.addFeedbackButton.Name = "addFeedbackButton";
            this.addFeedbackButton.Size = new System.Drawing.Size(358, 23);
            this.addFeedbackButton.TabIndex = 5;
            this.addFeedbackButton.Text = "Отправить отзыв";
            this.addFeedbackButton.UseVisualStyleBackColor = true;
            this.addFeedbackButton.Click += new System.EventHandler(this.addFeedbackButton_Click);
            // 
            // deleteFeedbackButton
            // 
            this.deleteFeedbackButton.Location = new System.Drawing.Point(376, 95);
            this.deleteFeedbackButton.Name = "deleteFeedbackButton";
            this.deleteFeedbackButton.Size = new System.Drawing.Size(412, 23);
            this.deleteFeedbackButton.TabIndex = 6;
            this.deleteFeedbackButton.Text = "Удалить отзыв";
            this.deleteFeedbackButton.UseVisualStyleBackColor = true;
            this.deleteFeedbackButton.Click += new System.EventHandler(this.deleteFeedbackButton_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteFeedbackButton);
            this.Controls.Add(this.addFeedbackButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.text);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.feedbackDGV);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView feedbackDGV;
        private System.Windows.Forms.NumericUpDown mark;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button addFeedbackButton;
        private System.Windows.Forms.Button deleteFeedbackButton;
    }
}