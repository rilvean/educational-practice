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
			picLogo = new PictureBox();
			lblUserInfo = new Label();
			tabControlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			SuspendLayout();
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tabMaterialsList);
			tabControlMain.Controls.Add(tabMaterialsManagement);
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
			tabMaterialsList.Size = new Size(1176, 658);
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
			// picLogo
			// 
			picLogo.Location = new Point(0, 1);
			picLogo.Name = "picLogo";
			picLogo.Size = new Size(74, 74);
			picLogo.TabIndex = 1;
			picLogo.TabStop = false;
			picLogo.Click += picLogo_Click;
			// 
			// lblUserInfo
			// 
			lblUserInfo.AutoSize = true;
			lblUserInfo.Location = new Point(843, 32);
			lblUserInfo.Name = "lblUserInfo";
			lblUserInfo.Size = new Size(95, 27);
			lblUserInfo.TabIndex = 2;
			lblUserInfo.Text = "UserInfo";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(1184, 761);
			Controls.Add(lblUserInfo);
			Controls.Add(picLogo);
			Controls.Add(tabControlMain);
			Name = "MainForm";
			Text = "MainForm";
			tabControlMain.ResumeLayout(false);
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
	}
}