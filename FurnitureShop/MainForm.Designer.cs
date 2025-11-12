namespace FurnitureShop
{
	partial class MainForm
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
			tabControlMain = new TabControl();
			tabMaterialsList = new TabPage();
			tabMaterialsManagement = new TabPage();
			tabProductsAnalysation = new TabPage();
			tabLoginHistory = new TabPage();
			label1 = new Label();
			dataLoginHistory = new DataGridView();
			picLogo = new PictureBox();
			lblUserInfo = new Label();
			lblLogo = new Label();
			txtFilterByLogin = new TextBox();
			tabControlMain.SuspendLayout();
			tabLoginHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataLoginHistory).BeginInit();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			SuspendLayout();
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tabMaterialsList);
			tabControlMain.Controls.Add(tabMaterialsManagement);
			tabControlMain.Controls.Add(tabProductsAnalysation);
			tabControlMain.Controls.Add(tabLoginHistory);
			tabControlMain.Dock = DockStyle.Bottom;
			tabControlMain.Location = new Point(0, 81);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(1184, 680);
			tabControlMain.TabIndex = 0;
			// 
			// tabMaterialsList
			// 
			tabMaterialsList.Location = new Point(4, 35);
			tabMaterialsList.Name = "tabMaterialsList";
			tabMaterialsList.Padding = new Padding(3);
			tabMaterialsList.Size = new Size(1176, 641);
			tabMaterialsList.TabIndex = 0;
			tabMaterialsList.Text = "Materials List";
			tabMaterialsList.UseVisualStyleBackColor = true;
			// 
			// tabMaterialsManagement
			// 
			tabMaterialsManagement.Location = new Point(4, 35);
			tabMaterialsManagement.Name = "tabMaterialsManagement";
			tabMaterialsManagement.Padding = new Padding(3);
			tabMaterialsManagement.Size = new Size(1176, 641);
			tabMaterialsManagement.TabIndex = 1;
			tabMaterialsManagement.Text = "Materials Management";
			tabMaterialsManagement.UseVisualStyleBackColor = true;
			// 
			// tabProductsAnalysation
			// 
			tabProductsAnalysation.Location = new Point(4, 35);
			tabProductsAnalysation.Name = "tabProductsAnalysation";
			tabProductsAnalysation.Size = new Size(1176, 641);
			tabProductsAnalysation.TabIndex = 2;
			tabProductsAnalysation.Text = "Products Analysation";
			tabProductsAnalysation.UseVisualStyleBackColor = true;
			// 
			// tabLoginHistory
			// 
			tabLoginHistory.Controls.Add(txtFilterByLogin);
			tabLoginHistory.Controls.Add(label1);
			tabLoginHistory.Controls.Add(dataLoginHistory);
			tabLoginHistory.Location = new Point(4, 35);
			tabLoginHistory.Name = "tabLoginHistory";
			tabLoginHistory.Size = new Size(1176, 641);
			tabLoginHistory.TabIndex = 3;
			tabLoginHistory.Text = "Login History";
			tabLoginHistory.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(263, 562);
			label1.Name = "label1";
			label1.Size = new Size(150, 27);
			label1.TabIndex = 1;
			label1.Text = "Filter by login:";
			// 
			// dataLoginHistory
			// 
			dataLoginHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataLoginHistory.Dock = DockStyle.Top;
			dataLoginHistory.Location = new Point(0, 0);
			dataLoginHistory.Name = "dataLoginHistory";
			dataLoginHistory.Size = new Size(1176, 513);
			dataLoginHistory.TabIndex = 0;
			// 
			// picLogo
			// 
			picLogo.Image = Properties.Resources.Logo;
			picLogo.Location = new Point(0, 1);
			picLogo.Name = "picLogo";
			picLogo.Size = new Size(74, 74);
			picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			picLogo.TabIndex = 1;
			picLogo.TabStop = false;
			picLogo.Click += picLogo_Click;
			// 
			// lblUserInfo
			// 
			lblUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblUserInfo.AutoSize = true;
			lblUserInfo.Location = new Point(1077, 9);
			lblUserInfo.Name = "lblUserInfo";
			lblUserInfo.Size = new Size(95, 27);
			lblUserInfo.TabIndex = 2;
			lblUserInfo.Text = "UserInfo";
			// 
			// lblLogo
			// 
			lblLogo.AutoSize = true;
			lblLogo.Font = new Font("Constantia", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblLogo.Location = new Point(80, 9);
			lblLogo.Name = "lblLogo";
			lblLogo.Size = new Size(252, 59);
			lblLogo.TabIndex = 3;
			lblLogo.Text = "Obraz Plus";
			// 
			// txtFilterByLogin
			// 
			txtFilterByLogin.Location = new Point(419, 555);
			txtFilterByLogin.Name = "txtFilterByLogin";
			txtFilterByLogin.Size = new Size(354, 34);
			txtFilterByLogin.TabIndex = 2;
			txtFilterByLogin.TextChanged += txtFilterByLogin_TextChanged;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(1184, 761);
			Controls.Add(lblLogo);
			Controls.Add(lblUserInfo);
			Controls.Add(picLogo);
			Controls.Add(tabControlMain);
			Name = "MainForm";
			Text = "Obraz Plus - MainForm";
			tabControlMain.ResumeLayout(false);
			tabLoginHistory.ResumeLayout(false);
			tabLoginHistory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataLoginHistory).EndInit();
			((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControlMain;
		private TabPage tabMaterialsList;
		private TabPage tabMaterialsManagement;
		private PictureBox picLogo;
		private Label lblUserInfo;
		private TabPage tabProductsAnalysation;
		private TabPage tabLoginHistory;
		private Label lblLogo;
		private DataGridView dataLoginHistory;
		private Label label1;
		private TextBox txtFilterByLogin;
	}
}