
namespace film_service
{
    partial class Registration
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(63, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(192, 20);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(63, 95);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(192, 20);
            this.password.TabIndex = 1;
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(63, 144);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(192, 20);
            this.nickname.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(63, 194);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(192, 20);
            this.phone.TabIndex = 3;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(63, 244);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(192, 20);
            this.mail.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(63, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(45, 13);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Логин:*";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(63, 76);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Пароль:*";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(63, 122);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(110, 13);
            this.nicknameLabel.TabIndex = 7;
            this.nicknameLabel.Text = "Имя пользователя:*";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(63, 175);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Телефон:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(63, 225);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(38, 13);
            this.mailLabel.TabIndex = 9;
            this.mailLabel.Text = "E-mail:";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(98, 295);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(131, 23);
            this.register.TabIndex = 10;
            this.register.Text = "Зарегистрироваться";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 338);
            this.Controls.Add(this.register);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Registration";
            this.Text = "Registrstion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button register;
    }
}