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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPlaceTB
            // 
            this.leftPlaceTB.Location = new System.Drawing.Point(556, 384);
            this.leftPlaceTB.Name = "leftPlaceTB";
            this.leftPlaceTB.Size = new System.Drawing.Size(100, 22);
            this.leftPlaceTB.TabIndex = 40;
            this.leftPlaceTB.Visible = false;
            // 
            // leftPlaceLB
            // 
            this.leftPlaceLB.AutoSize = true;
            this.leftPlaceLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPlaceLB.Location = new System.Drawing.Point(316, 379);
            this.leftPlaceLB.Name = "leftPlaceLB";
            this.leftPlaceLB.Size = new System.Drawing.Size(121, 24);
            this.leftPlaceLB.TabIndex = 39;
            this.leftPlaceLB.Text = "Left places:";
            this.leftPlaceLB.Visible = false;
            // 
            // movieBtn
            // 
            this.movieBtn.FlatAppearance.BorderSize = 0;
            this.movieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieBtn.ForeColor = System.Drawing.Color.Black;
            this.movieBtn.Location = new System.Drawing.Point(589, 471);
            this.movieBtn.Name = "movieBtn";
            this.movieBtn.Size = new System.Drawing.Size(167, 45);
            this.movieBtn.TabIndex = 37;
            this.movieBtn.Text = "Movie info";
            this.movieBtn.UseVisualStyleBackColor = true;
            this.movieBtn.Visible = false;
            this.movieBtn.Click += new System.EventHandler(this.movieBtn_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(310, 492);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(54, 22);
            this.priceTB.TabIndex = 36;
            // 
            // priceLB
            // 
            this.priceLB.AutoSize = true;
            this.priceLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLB.Location = new System.Drawing.Point(240, 488);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(64, 24);
            this.priceLB.TabIndex = 35;
            this.priceLB.Text = "Price:";
            // 
            // movieTB
            // 
            this.movieTB.FormattingEnabled = true;
            this.movieTB.Location = new System.Drawing.Point(556, 142);
            this.movieTB.Name = "movieTB";
            this.movieTB.Size = new System.Drawing.Size(200, 24);
            this.movieTB.TabIndex = 34;
            this.movieTB.SelectedIndexChanged += new System.EventHandler(this.movieTB_SelectedIndexChanged);
            // 
            // movieLB
            // 
            this.movieLB.AutoSize = true;
            this.movieLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLB.Location = new System.Drawing.Point(317, 139);
            this.movieLB.Name = "movieLB";
            this.movieLB.Size = new System.Drawing.Size(156, 24);
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
            this.ticketsCB.Location = new System.Drawing.Point(556, 323);
            this.ticketsCB.Name = "ticketsCB";
            this.ticketsCB.Size = new System.Drawing.Size(200, 24);
            this.ticketsCB.TabIndex = 32;
            this.ticketsCB.SelectedIndexChanged += new System.EventHandler(this.ticketsCB_SelectedIndexChanged);
            // 
            // ticketsLB
            // 
            this.ticketsLB.AutoSize = true;
            this.ticketsLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsLB.Location = new System.Drawing.Point(317, 323);
            this.ticketsLB.Name = "ticketsLB";
            this.ticketsLB.Size = new System.Drawing.Size(194, 24);
            this.ticketsLB.TabIndex = 31;
            this.ticketsLB.Text = "Number of tickets:";
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(556, 263);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 22);
            this.datePick.TabIndex = 30;
            // 
            // dateLB
            // 
            this.dateLB.AutoSize = true;
            this.dateLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLB.Location = new System.Drawing.Point(317, 260);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(139, 24);
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
            this.roomsCB.Location = new System.Drawing.Point(556, 205);
            this.roomsCB.Name = "roomsCB";
            this.roomsCB.Size = new System.Drawing.Size(200, 24);
            this.roomsCB.TabIndex = 28;
            this.roomsCB.SelectedIndexChanged += new System.EventHandler(this.roomsCB_SelectedIndexChanged);
            // 
            // roomsLB
            // 
            this.roomsLB.AutoSize = true;
            this.roomsLB.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLB.Location = new System.Drawing.Point(317, 202);
            this.roomsLB.Name = "roomsLB";
            this.roomsLB.Size = new System.Drawing.Size(148, 24);
            this.roomsLB.TabIndex = 27;
            this.roomsLB.Text = "Choose room:";
            // 
            // ronLbl
            // 
            this.ronLbl.AutoSize = true;
            this.ronLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ronLbl.Location = new System.Drawing.Point(370, 490);
            this.ronLbl.Name = "ronLbl";
            this.ronLbl.Size = new System.Drawing.Size(56, 24);
            this.ronLbl.TabIndex = 41;
            this.ronLbl.Text = "RON";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.buyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 553);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 79);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 79);
            this.panel3.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinema";
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.Image = global::Cinema.Properties.Resources.back_button;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 471);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 79);
            this.exitBtn.TabIndex = 42;
            this.exitBtn.Text = "   Exit";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.FlatAppearance.BorderSize = 0;
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.buyBtn.Image = global::Cinema.Properties.Resources.ticket;
            this.buyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyBtn.Location = new System.Drawing.Point(0, 165);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(200, 85);
            this.buyBtn.TabIndex = 38;
            this.buyBtn.Text = "   Buy tickets";
            this.buyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ronLbl);
            this.Controls.Add(this.leftPlaceTB);
            this.Controls.Add(this.leftPlaceLB);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Movies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}