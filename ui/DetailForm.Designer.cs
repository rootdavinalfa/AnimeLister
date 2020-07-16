namespace AnimeLister.ui
{
    partial class DetailForm
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
            this.coverViewer = new System.Windows.Forms.PictureBox();
            this.nameCatalogue = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.packageAnime = new System.Windows.Forms.Label();
            this.synopsis = new System.Windows.Forms.Label();
            this.btnToAnimize = new System.Windows.Forms.Button();
            this.genres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // coverViewer
            // 
            this.coverViewer.Location = new System.Drawing.Point(12, 12);
            this.coverViewer.Name = "coverViewer";
            this.coverViewer.Size = new System.Drawing.Size(139, 183);
            this.coverViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverViewer.TabIndex = 0;
            this.coverViewer.TabStop = false;
            // 
            // nameCatalogue
            // 
            this.nameCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCatalogue.AutoEllipsis = true;
            this.nameCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameCatalogue.Location = new System.Drawing.Point(157, 41);
            this.nameCatalogue.Name = "nameCatalogue";
            this.nameCatalogue.Size = new System.Drawing.Size(249, 79);
            this.nameCatalogue.TabIndex = 1;
            this.nameCatalogue.Text = "x";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rating.Location = new System.Drawing.Point(12, 198);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(86, 20);
            this.rating.TabIndex = 2;
            this.rating.Text = "Rating: 0.0";
            // 
            // packageAnime
            // 
            this.packageAnime.AutoSize = true;
            this.packageAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.packageAnime.Location = new System.Drawing.Point(158, 12);
            this.packageAnime.Name = "packageAnime";
            this.packageAnime.Size = new System.Drawing.Size(16, 20);
            this.packageAnime.TabIndex = 3;
            this.packageAnime.Text = "x";
            // 
            // synopsis
            // 
            this.synopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.synopsis.AutoEllipsis = true;
            this.synopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.synopsis.Location = new System.Drawing.Point(162, 137);
            this.synopsis.Name = "synopsis";
            this.synopsis.Size = new System.Drawing.Size(244, 297);
            this.synopsis.TabIndex = 4;
            this.synopsis.Text = "x";
            // 
            // btnToAnimize
            // 
            this.btnToAnimize.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnToAnimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnToAnimize.Location = new System.Drawing.Point(12, 235);
            this.btnToAnimize.Name = "btnToAnimize";
            this.btnToAnimize.Size = new System.Drawing.Size(139, 41);
            this.btnToAnimize.TabIndex = 5;
            this.btnToAnimize.Text = "Lihat Di Animize";
            this.btnToAnimize.UseVisualStyleBackColor = false;
            this.btnToAnimize.Click += new System.EventHandler(this.btnToAnimize_Click);
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.genres.Location = new System.Drawing.Point(12, 290);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(139, 144);
            this.genres.TabIndex = 6;
            this.genres.Text = "x";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 443);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.btnToAnimize);
            this.Controls.Add(this.synopsis);
            this.Controls.Add(this.packageAnime);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.nameCatalogue);
            this.Controls.Add(this.coverViewer);
            this.MaximizeBox = false;
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverViewer;
        private System.Windows.Forms.Label nameCatalogue;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label packageAnime;
        private System.Windows.Forms.Label synopsis;
        private System.Windows.Forms.Button btnToAnimize;
        private System.Windows.Forms.Label genres;
    }
}