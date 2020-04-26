namespace Cinema
{
    partial class Options
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
            this.login = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(170, 280);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(86, 40);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // movie
            // 
            this.movie.Location = new System.Drawing.Point(485, 280);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(107, 40);
            this.movie.TabIndex = 1;
            this.movie.Text = "Choose movie";
            this.movie.UseVisualStyleBackColor = true;
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(322, 373);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 29);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.login);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button movie;
        private System.Windows.Forms.Button exit;
    }
}

