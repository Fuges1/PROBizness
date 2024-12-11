namespace PROBizness
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Openpass2 = new System.Windows.Forms.Button();
            this.Openpass1 = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.textBoxrepeatpassword = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lableClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lableClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 349);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Openpass2);
            this.panel2.Controls.Add(this.Openpass1);
            this.panel2.Controls.Add(this.Registration);
            this.panel2.Controls.Add(this.buttonregister);
            this.panel2.Controls.Add(this.textBoxrepeatpassword);
            this.panel2.Controls.Add(this.textBoxSurname);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxMiddlename);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 302);
            this.panel2.TabIndex = 0;
            // 
            // Openpass2
            // 
            this.Openpass2.Location = new System.Drawing.Point(260, 222);
            this.Openpass2.Name = "Openpass2";
            this.Openpass2.Size = new System.Drawing.Size(16, 10);
            this.Openpass2.TabIndex = 12;
            this.Openpass2.UseVisualStyleBackColor = true;
            this.Openpass2.MouseLeave += new System.EventHandler(this.Openpass2_MouseLeave);
            this.Openpass2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Openpass2_MouseMove);
            // 
            // Openpass1
            // 
            this.Openpass1.Location = new System.Drawing.Point(260, 166);
            this.Openpass1.Name = "Openpass1";
            this.Openpass1.Size = new System.Drawing.Size(16, 10);
            this.Openpass1.TabIndex = 11;
            this.Openpass1.UseVisualStyleBackColor = true;
            this.Openpass1.MouseLeave += new System.EventHandler(this.Openpass1_MouseLeave);
            this.Openpass1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Openpass1_MouseMove);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.Registration.Location = new System.Drawing.Point(184, 3);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(203, 36);
            this.Registration.TabIndex = 10;
            this.Registration.Text = "Регистрация";
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregister.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.buttonregister.Location = new System.Drawing.Point(291, 166);
            this.buttonregister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(252, 96);
            this.buttonregister.TabIndex = 5;
            this.buttonregister.Text = "Зарегистрироваться";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // textBoxrepeatpassword
            // 
            this.textBoxrepeatpassword.AccessibleDescription = "";
            this.textBoxrepeatpassword.AccessibleName = "";
            this.textBoxrepeatpassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxrepeatpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxrepeatpassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxrepeatpassword.Location = new System.Drawing.Point(24, 222);
            this.textBoxrepeatpassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxrepeatpassword.Name = "textBoxrepeatpassword";
            this.textBoxrepeatpassword.Size = new System.Drawing.Size(252, 39);
            this.textBoxrepeatpassword.TabIndex = 6;
            this.textBoxrepeatpassword.Text = "Повтор пароля";
            this.textBoxrepeatpassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxrepeatpassword_MouseClick);
            this.textBoxrepeatpassword.MouseLeave += new System.EventHandler(this.textBoxrepeatpassword_MouseLeave);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AccessibleDescription = "";
            this.textBoxSurname.AccessibleName = "";
            this.textBoxSurname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Black;
            this.textBoxSurname.Location = new System.Drawing.Point(291, 42);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(252, 42);
            this.textBoxSurname.TabIndex = 8;
            this.textBoxSurname.Tag = "";
            this.textBoxSurname.Text = "Фамилия";
            this.textBoxSurname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSurname_MouseClick);
            this.textBoxSurname.MouseLeave += new System.EventHandler(this.textBoxSurname_MouseLeave);
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "";
            this.textBoxName.AccessibleName = "";
            this.textBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(24, 42);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 42);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.Tag = "";
            this.textBoxName.Text = "Имя";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxname_MouseClick);
            this.textBoxName.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AccessibleDescription = "";
            this.textBoxPassword.AccessibleName = "";
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(24, 166);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(252, 39);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseClick);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.AccessibleDescription = "";
            this.textBoxMiddlename.AccessibleName = "";
            this.textBoxMiddlename.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxMiddlename.ForeColor = System.Drawing.Color.Black;
            this.textBoxMiddlename.Location = new System.Drawing.Point(24, 103);
            this.textBoxMiddlename.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMiddlename.Multiline = true;
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(252, 42);
            this.textBoxMiddlename.TabIndex = 7;
            this.textBoxMiddlename.Tag = "";
            this.textBoxMiddlename.Text = "Отчество";
            this.textBoxMiddlename.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMiddlename_MouseClick);
            this.textBoxMiddlename.MouseLeave += new System.EventHandler(this.textBoxMiddlename_MouseLeave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AccessibleDescription = "";
            this.textBoxEmail.AccessibleName = "";
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(291, 103);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(252, 42);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Tag = "";
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.MouseLeave += new System.EventHandler(this.textBoxEmail_MouseLeave);
            // 
            // lableClose
            // 
            this.lableClose.AutoSize = true;
            this.lableClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lableClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lableClose.Location = new System.Drawing.Point(583, 2);
            this.lableClose.Name = "lableClose";
            this.lableClose.Size = new System.Drawing.Size(17, 17);
            this.lableClose.TabIndex = 1;
            this.lableClose.Text = "X";
            this.lableClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lableClose_MouseClick);
            this.lableClose.MouseEnter += new System.EventHandler(this.lableClose_MouseEnter);
            this.lableClose.MouseLeave += new System.EventHandler(this.lableClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(196, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Уже есть аккаунт";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 349);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lableClose;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.TextBox textBoxrepeatpassword;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Button Openpass1;
        private System.Windows.Forms.Button Openpass2;
        private System.Windows.Forms.Label label1;
    }
}