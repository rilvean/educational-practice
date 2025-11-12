namespace FurnitureShop
{
	partial class LogInForm
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
			label1 = new Label();
			label2 = new Label();
			txtPassword = new TextBox();
			txtLogin = new TextBox();
			chkShowPassword = new CheckBox();
			btnLogin = new Button();
			pnlCaptcha = new Panel();
			txtCaptcha = new TextBox();
			picCaptcha = new PictureBox();
			btnCaptchaRefresh = new Button();
			pnlCaptcha.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(191, 116);
			label1.Name = "label1";
			label1.Size = new Size(171, 27);
			label1.TabIndex = 9999;
			label1.Text = "Enter your login:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(191, 214);
			label2.Name = "label2";
			label2.Size = new Size(211, 27);
			label2.TabIndex = 9999;
			label2.Text = "Enter your password:";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(408, 211);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(513, 34);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			txtPassword.KeyPress += txt_KeyPress;
			// 
			// txtLogin
			// 
			txtLogin.Location = new Point(408, 109);
			txtLogin.Name = "txtLogin";
			txtLogin.Size = new Size(513, 34);
			txtLogin.TabIndex = 0;
			txtLogin.KeyPress += txt_KeyPress;
			// 
			// chkShowPassword
			// 
			chkShowPassword.AutoSize = true;
			chkShowPassword.Location = new Point(942, 213);
			chkShowPassword.Name = "chkShowPassword";
			chkShowPassword.Size = new Size(83, 31);
			chkShowPassword.TabIndex = 2;
			chkShowPassword.Text = "Show";
			chkShowPassword.UseVisualStyleBackColor = true;
			chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(531, 288);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(251, 39);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Log in";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// pnlCaptcha
			// 
			pnlCaptcha.Controls.Add(txtCaptcha);
			pnlCaptcha.Controls.Add(picCaptcha);
			pnlCaptcha.Controls.Add(btnCaptchaRefresh);
			pnlCaptcha.Location = new Point(488, 356);
			pnlCaptcha.Name = "pnlCaptcha";
			pnlCaptcha.Size = new Size(433, 230);
			pnlCaptcha.TabIndex = 4;
			pnlCaptcha.Visible = false;
			// 
			// txtCaptcha
			// 
			txtCaptcha.Location = new Point(77, 146);
			txtCaptcha.Name = "txtCaptcha";
			txtCaptcha.Size = new Size(190, 34);
			txtCaptcha.TabIndex = 6;
			txtCaptcha.KeyPress += txt_KeyPress;
			// 
			// picCaptcha
			// 
			picCaptcha.BorderStyle = BorderStyle.FixedSingle;
			picCaptcha.Location = new Point(77, 0);
			picCaptcha.Name = "picCaptcha";
			picCaptcha.Size = new Size(190, 111);
			picCaptcha.TabIndex = 0;
			picCaptcha.TabStop = false;
			// 
			// btnCaptchaRefresh
			// 
			btnCaptchaRefresh.Location = new Point(294, 35);
			btnCaptchaRefresh.Name = "btnCaptchaRefresh";
			btnCaptchaRefresh.Size = new Size(106, 45);
			btnCaptchaRefresh.TabIndex = 5;
			btnCaptchaRefresh.Text = "refresh";
			btnCaptchaRefresh.UseVisualStyleBackColor = true;
			btnCaptchaRefresh.Click += btnCaptchaRefresh_Click;
			// 
			// LogInForm
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(1184, 761);
			Controls.Add(pnlCaptcha);
			Controls.Add(btnLogin);
			Controls.Add(chkShowPassword);
			Controls.Add(txtLogin);
			Controls.Add(txtPassword);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "LogInForm";
			Text = "LogInForm";
			pnlCaptcha.ResumeLayout(false);
			pnlCaptcha.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtPassword;
		private TextBox txtLogin;
		private CheckBox chkShowPassword;
		private Button btnLogin;
		private Panel pnlCaptcha;
		private Button btnCaptchaRefresh;
		private PictureBox picCaptcha;
		private TextBox txtCaptcha;
	}
}