namespace PayrollSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.ButtonCancelLogin = new System.Windows.Forms.Button();
            this.UsernameLabelLogin = new System.Windows.Forms.Label();
            this.Usernametxtboxlogin = new System.Windows.Forms.TextBox();
            this.Passwordtxtboxlogin = new System.Windows.Forms.TextBox();
            this.PasswordLabelLogin = new System.Windows.Forms.Label();
            this.ForgotPasswordlnklbl = new System.Windows.Forms.LinkLabel();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "";
            this.LoginButton.Location = new System.Drawing.Point(155, 212);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(87, 25);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ButtonCancelLogin
            // 
            this.ButtonCancelLogin.Location = new System.Drawing.Point(155, 243);
            this.ButtonCancelLogin.Name = "ButtonCancelLogin";
            this.ButtonCancelLogin.Size = new System.Drawing.Size(87, 25);
            this.ButtonCancelLogin.TabIndex = 1;
            this.ButtonCancelLogin.Text = "Cancel";
            this.ButtonCancelLogin.UseVisualStyleBackColor = true;
            this.ButtonCancelLogin.Click += new System.EventHandler(this.ButtonCancelLogin_Click);
            // 
            // UsernameLabelLogin
            // 
            this.UsernameLabelLogin.AutoSize = true;
            this.UsernameLabelLogin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabelLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UsernameLabelLogin.Location = new System.Drawing.Point(152, 108);
            this.UsernameLabelLogin.Name = "UsernameLabelLogin";
            this.UsernameLabelLogin.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.UsernameLabelLogin.Size = new System.Drawing.Size(87, 14);
            this.UsernameLabelLogin.TabIndex = 2;
            this.UsernameLabelLogin.Text = "Username";
            this.UsernameLabelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Usernametxtboxlogin
            // 
            this.Usernametxtboxlogin.Location = new System.Drawing.Point(142, 126);
            this.Usernametxtboxlogin.Name = "Usernametxtboxlogin";
            this.Usernametxtboxlogin.Size = new System.Drawing.Size(116, 20);
            this.Usernametxtboxlogin.TabIndex = 3;
            this.Usernametxtboxlogin.TextChanged += new System.EventHandler(this.Usernametxtboxlogin_TextChanged);
            // 
            // Passwordtxtboxlogin
            // 
            this.Passwordtxtboxlogin.Location = new System.Drawing.Point(142, 167);
            this.Passwordtxtboxlogin.Name = "Passwordtxtboxlogin";
            this.Passwordtxtboxlogin.PasswordChar = '*';
            this.Passwordtxtboxlogin.Size = new System.Drawing.Size(116, 20);
            this.Passwordtxtboxlogin.TabIndex = 5;
            // 
            // PasswordLabelLogin
            // 
            this.PasswordLabelLogin.AutoSize = true;
            this.PasswordLabelLogin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabelLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PasswordLabelLogin.Location = new System.Drawing.Point(152, 149);
            this.PasswordLabelLogin.Name = "PasswordLabelLogin";
            this.PasswordLabelLogin.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.PasswordLabelLogin.Size = new System.Drawing.Size(87, 14);
            this.PasswordLabelLogin.TabIndex = 6;
            this.PasswordLabelLogin.Text = "Password";
            this.PasswordLabelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotPasswordlnklbl
            // 
            this.ForgotPasswordlnklbl.AutoSize = true;
            this.ForgotPasswordlnklbl.Location = new System.Drawing.Point(139, 271);
            this.ForgotPasswordlnklbl.Name = "ForgotPasswordlnklbl";
            this.ForgotPasswordlnklbl.Size = new System.Drawing.Size(119, 14);
            this.ForgotPasswordlnklbl.TabIndex = 7;
            this.ForgotPasswordlnklbl.TabStop = true;
            this.ForgotPasswordlnklbl.Text = "Forgot Password?";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Courier New", 30F);
            this.title.Location = new System.Drawing.Point(75, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(258, 42);
            this.title.TabIndex = 8;
            this.title.Text = "PayrollSys";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ForgotPasswordlnklbl);
            this.Controls.Add(this.PasswordLabelLogin);
            this.Controls.Add(this.Passwordtxtboxlogin);
            this.Controls.Add(this.Usernametxtboxlogin);
            this.Controls.Add(this.UsernameLabelLogin);
            this.Controls.Add(this.ButtonCancelLogin);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollSys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ButtonCancelLogin;
        private System.Windows.Forms.Label UsernameLabelLogin;
        private System.Windows.Forms.TextBox Usernametxtboxlogin;
        private System.Windows.Forms.TextBox Passwordtxtboxlogin;
        private System.Windows.Forms.Label PasswordLabelLogin;
        private System.Windows.Forms.LinkLabel ForgotPasswordlnklbl;
        private System.Windows.Forms.Label title;
    }
}

