namespace AirConditionerShop_NguyenLeTanNghiep
{
	partial class frmLogin
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
			lbEmail = new Label();
			txtEmail = new TextBox();
			lbPassword = new Label();
			txtPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Location = new Point(151, 73);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new Size(46, 20);
			lbEmail.TabIndex = 0;
			lbEmail.Text = "Email";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(203, 70);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(271, 27);
			txtEmail.TabIndex = 1;
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new Point(127, 136);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new Size(70, 20);
			lbPassword.TabIndex = 0;
			lbPassword.Text = "Password";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(203, 133);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(271, 27);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(274, 208);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(102, 29);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(647, 306);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(lbPassword);
			Controls.Add(txtEmail);
			Controls.Add(lbEmail);
			Name = "frmLogin";
			Text = "frmLogin";
			Load += frmLogin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbEmail;
		private TextBox txtEmail;
		private Label lbPassword;
		private TextBox txtPassword;
		private Button btnLogin;
	}
}