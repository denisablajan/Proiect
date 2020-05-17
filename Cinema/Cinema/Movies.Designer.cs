namespace Cinema
{
    partial class Movies
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
            this.leftPlaceTB = new System.Windows.Forms.TextBox();
            this.leftPlaceLB = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.movieBtn = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.priceLB = new System.Windows.Forms.Label();
            this.movieTB = new System.Windows.Forms.ComboBox();
            this.movieLB = new System.Windows.Forms.Label();
            this.ticketsCB = new System.Windows.Forms.ComboBox();
            this.ticketsLB = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.dateLB = new System.Windows.Forms.Label();
            this.roomsCB = new System.Windows.Forms.ComboBox();
            this.roomsLB = new System.Windows.Forms.Label();
            this.ronLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftPlaceTB
            // 
            this.leftPlaceTB.Location = new System.Drawing.Point(594, 131);
            this.leftPlaceTB.Name = "leftPlaceTB";
            this.leftPlaceTB.Size = new System.Drawing.Size(100, 22);
            this.leftPlaceTB.TabIndex = 40;
            this.leftPlaceTB.Visible = false;
            // 
            // leftPlaceLB
            // 
            this.leftPlaceLB.AutoSize = true;
            this.leftPlaceLB.Location = new System.Drawing.Point(483, 131);
            this.leftPlaceLB.Name = "leftPlaceLB";
            this.leftPlaceLB.Size = new System.Drawing.Size(81, 17);
            this.leftPlaceLB.TabIndex = 39;
            this.leftPlaceLB.Text = "Left places:";
            this.leftPlaceLB.Visible = false;
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(370, 361);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(86, 33);
            this.buyBtn.TabIndex = 38;
            this.buyBtn.Text = "Buy tickets";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // movieBtn
            // 
            this.movieBtn.Location = new System.Drawing.Point(483, 57);
            this.movieBtn.Name = "movieBtn";
            this.movieBtn.Size = new System.Drawing.Size(86, 33);
            this.movieBtn.TabIndex = 37;
            this.movieBtn.Text = "Movie info";
            this.movieBtn.UseVisualStyleBackColor = true;
            this.movieBtn.Visible = false;
            this.movieBtn.Click += new System.EventHandler(this.movieBtn_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(256, 366);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(54, 22);
            this.priceTB.TabIndex = 36;
            // 
            // priceLB
            // 
            this.priceLB.AutoSize = true;
            this.priceLB.Location = new System.Drawing.Point(107, 366);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(44, 17);
            this.priceLB.TabIndex = 35;
            this.priceLB.Text = "Price:";
            // 
            // movieTB
            // 
            this.movieTB.FormattingEnabled = true;
            this.movieTB.Location = new System.Drawing.Point(256, 62);
            this.movieTB.Name = "movieTB";
            this.movieTB.Size = new System.Drawing.Size(200, 24);
            this.movieTB.TabIndex = 34;
            this.movieTB.SelectedIndexChanged += new System.EventHandler(this.movieTB_SelectedIndexChanged);
            // 
            // movieLB
            // 
            this.movieLB.AutoSize = true;
            this.movieLB.Location = new System.Drawing.Point(107, 62);
            this.movieLB.Name = "movieLB";
            this.movieLB.Size = new System.Drawing.Size(101, 17);
            this.movieLB.TabIndex = 33;
            this.movieLB.Text = "Choose movie:";
            // 
            // ticketsCB
            // 
            this.ticketsCB.FormattingEnabled = true;
            this.ticketsCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ticketsCB.Location = new System.Drawing.Point(256, 243);
            this.ticketsCB.Name = "ticketsCB";
            this.ticketsCB.Size = new System.Drawing.Size(200, 24);
            this.ticketsCB.TabIndex = 32;
            this.ticketsCB.SelectedIndexChanged += new System.EventHandler(this.ticketsCB_SelectedIndexChanged);
            // 
            // ticketsLB
            // 
            this.ticketsLB.AutoSize = true;
            this.ticketsLB.Location = new System.Drawing.Point(107, 246);
            this.ticketsLB.Name = "ticketsLB";
            this.ticketsLB.Size = new System.Drawing.Size(122, 17);
            this.ticketsLB.TabIndex = 31;
            this.ticketsLB.Text = "Number of tickets:";
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(256, 183);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 22);
            this.datePick.TabIndex = 30;
            // 
            // dateLB
            // 
            this.dateLB.AutoSize = true;
            this.dateLB.Location = new System.Drawing.Point(107, 183);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(92, 17);
            this.dateLB.TabIndex = 29;
            this.dateLB.Text = "Choose date:";
            // 
            // roomsCB
            // 
            this.roomsCB.FormattingEnabled = true;
            this.roomsCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.roomsCB.Location = new System.Drawing.Point(256, 125);
            this.roomsCB.Name = "roomsCB";
            this.roomsCB.Size = new System.Drawing.Size(200, 24);
            this.roomsCB.TabIndex = 28;
            this.roomsCB.SelectedIndexChanged += new System.EventHandler(this.roomsCB_SelectedIndexChanged);
            // 
            // roomsLB
            // 
            this.roomsLB.AutoSize = true;
            this.roomsLB.Location = new System.Drawing.Point(107, 125);
            this.roomsLB.Name = "roomsLB";
            this.roomsLB.Size = new System.Drawing.Size(96, 17);
            this.roomsLB.TabIndex = 27;
            this.roomsLB.Text = "Choose room:";
            // 
            // ronLbl
            // 
            this.ronLbl.AutoSize = true;
            this.ronLbl.Location = new System.Drawing.Point(316, 369);
            this.ronLbl.Name = "ronLbl";
            this.ronLbl.Size = new System.Drawing.Size(39, 17);
            this.ronLbl.TabIndex = 41;
            this.ronLbl.Text = "RON";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(594, 363);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(83, 31);
            this.exitBtn.TabIndex = 42;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.ronLbl);
            this.Controls.Add(this.leftPlaceTB);
            this.Controls.Add(this.leftPlaceLB);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.movieBtn);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.priceLB);
            this.Controls.Add(this.movieTB);
            this.Controls.Add(this.movieLB);
            this.Controls.Add(this.ticketsCB);
            this.Controls.Add(this.ticketsLB);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.dateLB);
            this.Controls.Add(this.roomsCB);
            this.Controls.Add(this.roomsLB);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftPlaceTB;
        private System.Windows.Forms.Label leftPlaceLB;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button movieBtn;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label priceLB;
        private System.Windows.Forms.ComboBox movieTB;
        private System.Windows.Forms.Label movieLB;
        private System.Windows.Forms.ComboBox ticketsCB;
        private System.Windows.Forms.Label ticketsLB;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label dateLB;
        private System.Windows.Forms.ComboBox roomsCB;
        private System.Windows.Forms.Label roomsLB;
        private System.Windows.Forms.Label ronLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}