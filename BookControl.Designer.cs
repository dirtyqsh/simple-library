
namespace practice3
{
    partial class BookControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoverPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CoverPictureBox
            // 
            this.CoverPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CoverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoverPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CoverPictureBox.Name = "CoverPictureBox";
            this.CoverPictureBox.Size = new System.Drawing.Size(172, 188);
            this.CoverPictureBox.TabIndex = 0;
            this.CoverPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(196, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(540, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Автор / Название (год издания)";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(744, 13);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "✎";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.Location = new System.Drawing.Point(196, 54);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(578, 137);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Описание";
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CoverPictureBox);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(777, 192);
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CoverPictureBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}
