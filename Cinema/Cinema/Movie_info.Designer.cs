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
            // Movie_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backtomoviesBtn);
            this.Name = "Movie_info";
            this.Text = "Movie information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backtomoviesBtn;
    }
}