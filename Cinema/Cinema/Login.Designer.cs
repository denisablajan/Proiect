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
            this.signup = new System.Windows.Forms.TabPage();
            this.goBtn = new System.Windows.Forms.Button();
            this.authpasswordTB = new System.Windows.Forms.TextBox();
            this.authemailTB = new System.Windows.Forms.TextBox();
            this.authpasswordLbl = new System.Windows.Forms.Label();
            this.authemailLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.repassLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.repassTB = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.signin.SuspendLayout();
            this.signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.signin);
            this.tabControl1.Controls.Add(this.signup);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // signin
            // 
            this.signin.Controls.Add(this.goBtn);
            this.signin.Controls.Add(this.authpasswordTB);
            this.signin.Controls.Add(this.authemailTB);
            this.signin.Controls.Add(this.authpasswordLbl);
            this.signin.Controls.Add(this.authemailLbl);
            this.signin.Location = new System.Drawing.Point(4, 25);
            this.signin.Name = "signin";
            this.signin.Padding = new System.Windows.Forms.Padding(3);
            this.signin.Size = new System.Drawing.Size(793, 424);
            this.signin.TabIndex = 0;
            this.signin.Text = "Sign in";
            this.signin.UseVisualStyleBackColor = true;
            // 
            // signup
            // 
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
            this.signup.Location = new System.Drawing.Point(4, 25);
            this.signup.Name = "signup";
            this.signup.Padding = new System.Windows.Forms.Padding(3);
            this.signup.Size = new System.Drawing.Size(793, 424);
            this.signup.TabIndex = 1;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = true;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(378, 275);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 9;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // authpasswordTB
            // 
            this.authpasswordTB.Location = new System.Drawing.Point(312, 182);
            this.authpasswordTB.Name = "authpasswordTB";
            this.authpasswordTB.Size = new System.Drawing.Size(267, 22);
            this.authpasswordTB.TabIndex = 8;
            // 
            // authemailTB
            // 
            this.authemailTB.Location = new System.Drawing.Point(312, 126);
            this.authemailTB.Name = "authemailTB";
            this.authemailTB.Size = new System.Drawing.Size(267, 22);
            this.authemailTB.TabIndex = 7;
            // 
            // authpasswordLbl
            // 
            this.authpasswordLbl.AutoSize = true;
            this.authpasswordLbl.Location = new System.Drawing.Point(214, 182);
            this.authpasswordLbl.Name = "authpasswordLbl";
            this.authpasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.authpasswordLbl.TabIndex = 6;
            this.authpasswordLbl.Text = "Password:";
            // 
            // authemailLbl
            // 
            this.authemailLbl.AutoSize = true;
            this.authemailLbl.Location = new System.Drawing.Point(214, 126);
            this.authemailLbl.Name = "authemailLbl";
            this.authemailLbl.Size = new System.Drawing.Size(46, 17);
            this.authemailLbl.TabIndex = 5;
            this.authemailLbl.Text = "Email:";
            // 
            // fnameLbl
            // 
            this.fnameLbl.AutoSize = true;
            this.fnameLbl.Location = new System.Drawing.Point(153, 61);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(78, 17);
            this.fnameLbl.TabIndex = 0;
            this.fnameLbl.Text = "First name:";
            // 
            // lnameLbl
            // 
            this.lnameLbl.AutoSize = true;
            this.lnameLbl.Location = new System.Drawing.Point(153, 102);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(78, 17);
            this.lnameLbl.TabIndex = 1;
            this.lnameLbl.Text = "Last name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(153, 145);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(64, 17);
            this.addressLbl.TabIndex = 2;
            this.addressLbl.Text = "Address:";
            // 
            // repassLbl
            // 
            this.repassLbl.AutoSize = true;
            this.repassLbl.Location = new System.Drawing.Point(153, 284);
            this.repassLbl.Name = "repassLbl";
            this.repassLbl.Size = new System.Drawing.Size(73, 17);
            this.repassLbl.TabIndex = 3;
            this.repassLbl.Text = "Password:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(153, 236);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(73, 17);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(153, 190);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(46, 17);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email:";
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(279, 61);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(408, 22);
            this.fnameTB.TabIndex = 6;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(279, 102);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(408, 22);
            this.lnameTB.TabIndex = 7;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(279, 142);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(408, 22);
            this.addressTB.TabIndex = 8;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(279, 187);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(408, 22);
            this.emailTB.TabIndex = 9;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(279, 233);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(408, 22);
            this.passTB.TabIndex = 10;
            // 
            // repassTB
            // 
            this.repassTB.Location = new System.Drawing.Point(279, 281);
            this.repassTB.Name = "repassTB";
            this.repassTB.Size = new System.Drawing.Size(408, 22);
            this.repassTB.TabIndex = 11;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(335, 355);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "Create account";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
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