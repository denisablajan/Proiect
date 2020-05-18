namespace Cinema
{
    partial class Movie_info
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
            this.backtomoviesBtn = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.ageRatingLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.threeDLbl = new System.Windows.Forms.Label();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.genreTb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.roomTb = new System.Windows.Forms.TextBox();
            this.imdbLinkLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backtomoviesBtn
            // 
            this.backtomoviesBtn.Location = new System.Drawing.Point(639, 29);
            this.backtomoviesBtn.Name = "backtomoviesBtn";
            this.backtomoviesBtn.Size = new System.Drawing.Size(123, 31);
            this.backtomoviesBtn.TabIndex = 0;
            this.backtomoviesBtn.Text = "Back to Movies";
            this.backtomoviesBtn.UseVisualStyleBackColor = true;
            this.backtomoviesBtn.Click += new System.EventHandler(this.backtomoviesBtn_Click);
            // 
            // picBox
            // 
            this.picBox.InitialImage = null;
            this.picBox.Location = new System.Drawing.Point(64, 58);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(265, 353);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(61, 29);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(22, 17);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "lbl";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(413, 120);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(42, 17);
            this.yearLbl.TabIndex = 3;
            this.yearLbl.Text = "Year:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(413, 173);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(52, 17);
            this.genreLbl.TabIndex = 4;
            this.genreLbl.Text = "Genre:";
            // 
            // ageRatingLbl
            // 
            this.ageRatingLbl.AutoSize = true;
            this.ageRatingLbl.Location = new System.Drawing.Point(413, 225);
            this.ageRatingLbl.Name = "ageRatingLbl";
            this.ageRatingLbl.Size = new System.Drawing.Size(77, 17);
            this.ageRatingLbl.TabIndex = 5;
            this.ageRatingLbl.Text = "Age rating:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(413, 281);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(85, 17);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "Ticket price:";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Location = new System.Drawing.Point(413, 332);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(49, 17);
            this.roomLbl.TabIndex = 7;
            this.roomLbl.Text = "Room:";
            // 
            // threeDLbl
            // 
            this.threeDLbl.AutoSize = true;
            this.threeDLbl.Location = new System.Drawing.Point(413, 394);
            this.threeDLbl.Name = "threeDLbl";
            this.threeDLbl.Size = new System.Drawing.Size(26, 17);
            this.threeDLbl.TabIndex = 8;
            this.threeDLbl.Text = "3D";
            this.threeDLbl.Visible = false;
            // 
            // yearTb
            // 
            this.yearTb.Location = new System.Drawing.Point(504, 120);
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(100, 22);
            this.yearTb.TabIndex = 9;
            // 
            // genreTb
            // 
            this.genreTb.Location = new System.Drawing.Point(504, 173);
            this.genreTb.Name = "genreTb";
            this.genreTb.Size = new System.Drawing.Size(100, 22);
            this.genreTb.TabIndex = 10;
            // 
            // ageTb
            // 
            this.ageTb.Location = new System.Drawing.Point(504, 220);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(100, 22);
            this.ageTb.TabIndex = 11;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(504, 281);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(100, 22);
            this.priceTb.TabIndex = 12;
            // 
            // roomTb
            // 
            this.roomTb.Location = new System.Drawing.Point(504, 332);
            this.roomTb.Name = "roomTb";
            this.roomTb.Size = new System.Drawing.Size(100, 22);
            this.roomTb.TabIndex = 13;
            // 
            // imdbLinkLbl
            // 
            this.imdbLinkLbl.AutoSize = true;
            this.imdbLinkLbl.Location = new System.Drawing.Point(532, 394);
            this.imdbLinkLbl.Name = "imdbLinkLbl";
            this.imdbLinkLbl.Size = new System.Drawing.Size(40, 17);
            this.imdbLinkLbl.TabIndex = 14;
            this.imdbLinkLbl.TabStop = true;
            this.imdbLinkLbl.Text = "IMDb";
            this.imdbLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.imdbLinkLbl_LinkClicked);
            // 
            // Movie_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imdbLinkLbl);
            this.Controls.Add(this.roomTb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.genreTb);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.threeDLbl);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.ageRatingLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.backtomoviesBtn);
            this.Name = "Movie_info";
            this.Text = "Movie information";
            this.Load += new System.EventHandler(this.Movie_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtomoviesBtn;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label ageRatingLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Label threeDLbl;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.TextBox genreTb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.TextBox roomTb;
        private System.Windows.Forms.LinkLabel imdbLinkLbl;
    }
}