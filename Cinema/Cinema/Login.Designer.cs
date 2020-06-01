namespace Cinema
{
    partial class Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.signin = new System.Windows.Forms.TabPage();
            this.goBtn = new System.Windows.Forms.Button();
            this.authpasswordTB = new System.Windows.Forms.TextBox();
            this.authemailTB = new System.Windows.Forms.TextBox();
            this.authpasswordLbl = new System.Windows.Forms.Label();
            this.authemailLbl = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.TabPage();
            this.createBtn = new System.Windows.Forms.Button();
            this.repassTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.repassLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.signin.SuspendLayout();
            this.signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.signin);
            this.tabControl1.Controls.Add(this.signup);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.DimGray;
            this.signin.Controls.Add(this.goBtn);
            this.signin.Controls.Add(this.authpasswordTB);
            this.signin.Controls.Add(this.authemailTB);
            this.signin.Controls.Add(this.authpasswordLbl);
            this.signin.Controls.Add(this.authemailLbl);
            this.signin.Location = new System.Drawing.Point(4, 33);
            this.signin.Name = "signin";
            this.signin.Padding = new System.Windows.Forms.Padding(3);
            this.signin.Size = new System.Drawing.Size(647, 343);
            this.signin.TabIndex = 0;
            this.signin.Text = "Sign in";
            // 
            // goBtn
            // 
            this.goBtn.FlatAppearance.BorderSize = 0;
            this.goBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBtn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.ForeColor = System.Drawing.Color.White;
            this.goBtn.Location = new System.Drawing.Point(97, 233);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(92, 42);
            this.goBtn.TabIndex = 9;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // authpasswordTB
            // 
            this.authpasswordTB.Location = new System.Drawing.Point(251, 147);
            this.authpasswordTB.Name = "authpasswordTB";
            this.authpasswordTB.PasswordChar = '*';
            this.authpasswordTB.Size = new System.Drawing.Size(267, 31);
            this.authpasswordTB.TabIndex = 8;
            // 
            // authemailTB
            // 
            this.authemailTB.Location = new System.Drawing.Point(251, 91);
            this.authemailTB.Name = "authemailTB";
            this.authemailTB.Size = new System.Drawing.Size(267, 31);
            this.authemailTB.TabIndex = 7;
            // 
            // authpasswordLbl
            // 
            this.authpasswordLbl.AutoSize = true;
            this.authpasswordLbl.Location = new System.Drawing.Point(93, 150);
            this.authpasswordLbl.Name = "authpasswordLbl";
            this.authpasswordLbl.Size = new System.Drawing.Size(110, 24);
            this.authpasswordLbl.TabIndex = 6;
            this.authpasswordLbl.Text = "Password:";
            // 
            // authemailLbl
            // 
            this.authemailLbl.AutoSize = true;
            this.authemailLbl.Location = new System.Drawing.Point(93, 94);
            this.authemailLbl.Name = "authemailLbl";
            this.authemailLbl.Size = new System.Drawing.Size(72, 24);
            this.authemailLbl.TabIndex = 5;
            this.authemailLbl.Text = "Email:";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.DimGray;
            this.signup.Controls.Add(this.createBtn);
            this.signup.Controls.Add(this.repassTB);
            this.signup.Controls.Add(this.passTB);
            this.signup.Controls.Add(this.emailTB);
            this.signup.Controls.Add(this.addressTB);
            this.signup.Controls.Add(this.lnameTB);
            this.signup.Controls.Add(this.fnameTB);
            this.signup.Controls.Add(this.emailLbl);
            this.signup.Controls.Add(this.passLbl);
            this.signup.Controls.Add(this.repassLbl);
            this.signup.Controls.Add(this.addressLbl);
            this.signup.Controls.Add(this.lnameLbl);
            this.signup.Controls.Add(this.fnameLbl);
            this.signup.Location = new System.Drawing.Point(4, 33);
            this.signup.Name = "signup";
            this.signup.Padding = new System.Windows.Forms.Padding(3);
            this.signup.Size = new System.Drawing.Size(647, 343);
            this.signup.TabIndex = 1;
            this.signup.Text = "Sign up";
            // 
            // createBtn
            // 
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(175, 293);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(263, 50);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "Create account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // repassTB
            // 
            this.repassTB.Location = new System.Drawing.Point(193, 258);
            this.repassTB.Name = "repassTB";
            this.repassTB.Size = new System.Drawing.Size(408, 31);
            this.repassTB.TabIndex = 11;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(193, 210);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(408, 31);
            this.passTB.TabIndex = 10;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(193, 164);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(408, 31);
            this.emailTB.TabIndex = 9;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(193, 119);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(408, 31);
            this.addressTB.TabIndex = 8;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(193, 79);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(408, 31);
            this.lnameTB.TabIndex = 7;
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(193, 38);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(408, 31);
            this.fnameTB.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(23, 167);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(72, 24);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(23, 213);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(110, 24);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password:";
            // 
            // repassLbl
            // 
            this.repassLbl.AutoSize = true;
            this.repassLbl.Location = new System.Drawing.Point(23, 261);
            this.repassLbl.Name = "repassLbl";
            this.repassLbl.Size = new System.Drawing.Size(110, 24);
            this.repassLbl.TabIndex = 3;
            this.repassLbl.Text = "Password:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(23, 122);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(94, 24);
            this.addressLbl.TabIndex = 2;
            this.addressLbl.Text = "Address:";
            // 
            // lnameLbl
            // 
            this.lnameLbl.AutoSize = true;
            this.lnameLbl.Location = new System.Drawing.Point(23, 79);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(117, 24);
            this.lnameLbl.TabIndex = 1;
            this.lnameLbl.Text = "Last name:";
            // 
            // fnameLbl
            // 
            this.fnameLbl.AutoSize = true;
            this.fnameLbl.Location = new System.Drawing.Point(23, 38);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(120, 24);
            this.fnameLbl.TabIndex = 0;
            this.fnameLbl.Text = "First name:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.signin.ResumeLayout(false);
            this.signin.PerformLayout();
            this.signup.ResumeLayout(false);
            this.signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage signin;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox authpasswordTB;
        private System.Windows.Forms.TextBox authemailTB;
        private System.Windows.Forms.Label authpasswordLbl;
        private System.Windows.Forms.Label authemailLbl;
        private System.Windows.Forms.TabPage signup;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox repassTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label repassLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.Label fnameLbl;
    }
}