namespace final_bd
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
            this.BarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordLoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLoginLabel = new System.Windows.Forms.Label();
            this.EmailLoginTextBox = new System.Windows.Forms.TextBox();
            this.EmailLoginLabel = new System.Windows.Forms.Label();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PIN_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInUnderlinePanel = new System.Windows.Forms.Panel();
            this.SignUpUnderlinePanel = new System.Windows.Forms.Panel();
            this.BarPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarPanel.Controls.Add(this.MinimizeButton);
            this.BarPanel.Controls.Add(this.CloseButton);
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(500, 70);
            this.BarPanel.TabIndex = 1;
            this.BarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseDown);
            this.BarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseMove);
            this.BarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(440, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(27, 27);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(473, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignInPanel.Controls.Add(this.button1);
            this.SignInPanel.Controls.Add(this.PasswordLoginTextBox);
            this.SignInPanel.Controls.Add(this.PasswordLoginLabel);
            this.SignInPanel.Controls.Add(this.EmailLoginTextBox);
            this.SignInPanel.Controls.Add(this.EmailLoginLabel);
            this.SignInPanel.Location = new System.Drawing.Point(0, 126);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(500, 574);
            this.SignInPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 47);
            this.button1.TabIndex = 26;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PasswordLoginTextBox
            // 
            this.PasswordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginTextBox.Location = new System.Drawing.Point(250, 245);
            this.PasswordLoginTextBox.Name = "PasswordLoginTextBox";
            this.PasswordLoginTextBox.Size = new System.Drawing.Size(196, 34);
            this.PasswordLoginTextBox.TabIndex = 24;
            // 
            // PasswordLoginLabel
            // 
            this.PasswordLoginLabel.AutoSize = true;
            this.PasswordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLoginLabel.Location = new System.Drawing.Point(40, 245);
            this.PasswordLoginLabel.Name = "PasswordLoginLabel";
            this.PasswordLoginLabel.Size = new System.Drawing.Size(120, 29);
            this.PasswordLoginLabel.TabIndex = 23;
            this.PasswordLoginLabel.Text = "Password";
            // 
            // EmailLoginTextBox
            // 
            this.EmailLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLoginTextBox.Location = new System.Drawing.Point(250, 158);
            this.EmailLoginTextBox.Name = "EmailLoginTextBox";
            this.EmailLoginTextBox.Size = new System.Drawing.Size(196, 34);
            this.EmailLoginTextBox.TabIndex = 21;
            // 
            // EmailLoginLabel
            // 
            this.EmailLoginLabel.AutoSize = true;
            this.EmailLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLoginLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLoginLabel.Location = new System.Drawing.Point(40, 161);
            this.EmailLoginLabel.Name = "EmailLoginLabel";
            this.EmailLoginLabel.Size = new System.Drawing.Size(74, 29);
            this.EmailLoginLabel.TabIndex = 20;
            this.EmailLoginLabel.Text = "Email";
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpPanel.Controls.Add(this.RegisterButton);
            this.SignUpPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.SignUpPanel.Controls.Add(this.ConfirmPasswordLabel);
            this.SignUpPanel.Controls.Add(this.PasswordTextBox);
            this.SignUpPanel.Controls.Add(this.PasswordLabel);
            this.SignUpPanel.Controls.Add(this.LastNameTextBox);
            this.SignUpPanel.Controls.Add(this.EmailTextBox);
            this.SignUpPanel.Controls.Add(this.PINTextBox);
            this.SignUpPanel.Controls.Add(this.FirstNameTextBox);
            this.SignUpPanel.Controls.Add(this.PIN_label);
            this.SignUpPanel.Controls.Add(this.email_label);
            this.SignUpPanel.Controls.Add(this.LastNameLabel);
            this.SignUpPanel.Controls.Add(this.FirstNameLabel);
            this.SignUpPanel.Location = new System.Drawing.Point(0, 126);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(500, 574);
            this.SignUpPanel.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(262, 465);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(195, 47);
            this.RegisterButton.TabIndex = 25;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(262, 370);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(196, 34);
            this.ConfirmPasswordTextBox.TabIndex = 24;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(52, 370);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(208, 29);
            this.ConfirmPasswordLabel.TabIndex = 23;
            this.ConfirmPasswordLabel.Text = "Confirm password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(262, 310);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(196, 34);
            this.PasswordTextBox.TabIndex = 22;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(52, 310);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 29);
            this.PasswordLabel.TabIndex = 21;
            this.PasswordLabel.Text = "Password";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(262, 130);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(196, 34);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(262, 190);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(196, 34);
            this.EmailTextBox.TabIndex = 19;
            // 
            // PINTextBox
            // 
            this.PINTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINTextBox.Location = new System.Drawing.Point(262, 250);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(196, 34);
            this.PINTextBox.TabIndex = 18;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(262, 70);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(195, 34);
            this.FirstNameTextBox.TabIndex = 17;
            // 
            // PIN_label
            // 
            this.PIN_label.AutoSize = true;
            this.PIN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN_label.ForeColor = System.Drawing.Color.White;
            this.PIN_label.Location = new System.Drawing.Point(52, 250);
            this.PIN_label.Name = "PIN_label";
            this.PIN_label.Size = new System.Drawing.Size(53, 29);
            this.PIN_label.TabIndex = 16;
            this.PIN_label.Text = "PIN";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(52, 190);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(74, 29);
            this.email_label.TabIndex = 15;
            this.email_label.Text = "Email";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.White;
            this.LastNameLabel.Location = new System.Drawing.Point(52, 130);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(123, 29);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.White;
            this.FirstNameLabel.Location = new System.Drawing.Point(52, 70);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(126, 29);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "First name";
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(0, 71);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(250, 50);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(250, 71);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(250, 50);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInUnderlinePanel
            // 
            this.SignInUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.SignInUnderlinePanel.Location = new System.Drawing.Point(0, 121);
            this.SignInUnderlinePanel.Name = "SignInUnderlinePanel";
            this.SignInUnderlinePanel.Size = new System.Drawing.Size(250, 5);
            this.SignInUnderlinePanel.TabIndex = 0;
            // 
            // SignUpUnderlinePanel
            // 
            this.SignUpUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.SignUpUnderlinePanel.Location = new System.Drawing.Point(250, 121);
            this.SignUpUnderlinePanel.Name = "SignUpUnderlinePanel";
            this.SignUpUnderlinePanel.Size = new System.Drawing.Size(250, 5);
            this.SignUpUnderlinePanel.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.SignUpUnderlinePanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.SignInUnderlinePanel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.BarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.BarPanel.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel SignInUnderlinePanel;
        private System.Windows.Forms.Panel SignUpUnderlinePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordLoginTextBox;
        private System.Windows.Forms.Label PasswordLoginLabel;
        private System.Windows.Forms.TextBox EmailLoginTextBox;
        private System.Windows.Forms.Label EmailLoginLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label PIN_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}