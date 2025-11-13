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
			cmbFilterByType = new ComboBox();
			label3 = new Label();
			cmbSort = new ComboBox();
			label2 = new Label();
			lblSearch = new Label();
			txtSearch = new TextBox();
			flowLayoutPanelMaterials = new FlowLayoutPanel();
			tabMaterialsManagement = new TabPage();
			btnRemove = new Button();
			btnAdd = new Button();
			btnEdit = new Button();
			dataMaterials = new DataGridView();
			tabProductsAnalysation = new TabPage();
			lblProductionResult = new Label();
			dataProductsByMaterial = new DataGridView();
			btnCalculateProduction = new Button();
			numMaterialAmount = new NumericUpDown();
			cmbMaterialType = new ComboBox();
			cmbProductType = new ComboBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			tabLoginHistory = new TabPage();
			txtFilterByLogin = new TextBox();
			label1 = new Label();
			dataLoginHistory = new DataGridView();
			picLogo = new PictureBox();
			lblUserInfo = new Label();
			lblLogo = new Label();
			tabControlMain.SuspendLayout();
			tabMaterialsList.SuspendLayout();
			tabMaterialsManagement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataMaterials).BeginInit();
			tabProductsAnalysation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataProductsByMaterial).BeginInit();
			((System.ComponentModel.ISupportInitialize)numMaterialAmount).BeginInit();
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
			tabControlMain.Location = new Point(0, 111);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(1184, 650);
			tabControlMain.TabIndex = 0;
			// 
			// tabMaterialsList
			// 
			tabMaterialsList.Controls.Add(cmbFilterByType);
			tabMaterialsList.Controls.Add(label3);
			tabMaterialsList.Controls.Add(cmbSort);
			tabMaterialsList.Controls.Add(label2);
			tabMaterialsList.Controls.Add(lblSearch);
			tabMaterialsList.Controls.Add(txtSearch);
			tabMaterialsList.Controls.Add(flowLayoutPanelMaterials);
			tabMaterialsList.Location = new Point(4, 35);
			tabMaterialsList.Name = "tabMaterialsList";
			tabMaterialsList.Padding = new Padding(3);
			tabMaterialsList.Size = new Size(1176, 611);
			tabMaterialsList.TabIndex = 0;
			tabMaterialsList.Text = "Materials List";
			tabMaterialsList.UseVisualStyleBackColor = true;
			// 
			// cmbFilterByType
			// 
			cmbFilterByType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbFilterByType.FormattingEnabled = true;
			cmbFilterByType.Location = new Point(828, 540);
			cmbFilterByType.Name = "cmbFilterByType";
			cmbFilterByType.Size = new Size(247, 34);
			cmbFilterByType.TabIndex = 6;
			cmbFilterByType.SelectedIndexChanged += cmbMaterialType_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(828, 505);
			label3.Name = "label3";
			label3.Size = new Size(144, 27);
			label3.TabIndex = 5;
			label3.Text = "Filter by type:";
			// 
			// cmbSort
			// 
			cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbSort.FormattingEnabled = true;
			cmbSort.Items.AddRange(new object[] { "No sort", "Ascending", "Descending" });
			cmbSort.Location = new Point(597, 540);
			cmbSort.Name = "cmbSort";
			cmbSort.Size = new Size(201, 34);
			cmbSort.TabIndex = 4;
			cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(597, 505);
			label2.Name = "label2";
			label2.Size = new Size(201, 27);
			label2.TabIndex = 3;
			label2.Text = "Sort by qty in stock:";
			// 
			// lblSearch
			// 
			lblSearch.AutoSize = true;
			lblSearch.Location = new Point(95, 505);
			lblSearch.Name = "lblSearch";
			lblSearch.Size = new Size(82, 27);
			lblSearch.TabIndex = 2;
			lblSearch.Text = "Search:";
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(95, 540);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(476, 34);
			txtSearch.TabIndex = 1;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// flowLayoutPanelMaterials
			// 
			flowLayoutPanelMaterials.AutoScroll = true;
			flowLayoutPanelMaterials.Dock = DockStyle.Top;
			flowLayoutPanelMaterials.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanelMaterials.Location = new Point(3, 3);
			flowLayoutPanelMaterials.Name = "flowLayoutPanelMaterials";
			flowLayoutPanelMaterials.Size = new Size(1170, 472);
			flowLayoutPanelMaterials.TabIndex = 0;
			flowLayoutPanelMaterials.WrapContents = false;
			// 
			// tabMaterialsManagement
			// 
			tabMaterialsManagement.Controls.Add(btnRemove);
			tabMaterialsManagement.Controls.Add(btnAdd);
			tabMaterialsManagement.Controls.Add(btnEdit);
			tabMaterialsManagement.Controls.Add(dataMaterials);
			tabMaterialsManagement.Location = new Point(4, 35);
			tabMaterialsManagement.Name = "tabMaterialsManagement";
			tabMaterialsManagement.Padding = new Padding(3);
			tabMaterialsManagement.Size = new Size(1176, 611);
			tabMaterialsManagement.TabIndex = 1;
			tabMaterialsManagement.Text = "Materials Management";
			tabMaterialsManagement.UseVisualStyleBackColor = true;
			// 
			// btnRemove
			// 
			btnRemove.Location = new Point(892, 531);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(192, 41);
			btnRemove.TabIndex = 3;
			btnRemove.Text = "Remove";
			btnRemove.UseVisualStyleBackColor = true;
			btnRemove.Click += btnRemove_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(240, 531);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(112, 41);
			btnAdd.TabIndex = 2;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(76, 531);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(112, 41);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// dataMaterials
			// 
			dataMaterials.AllowUserToAddRows = false;
			dataMaterials.AllowUserToDeleteRows = false;
			dataMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataMaterials.Dock = DockStyle.Top;
			dataMaterials.Location = new Point(3, 3);
			dataMaterials.Name = "dataMaterials";
			dataMaterials.ReadOnly = true;
			dataMaterials.Size = new Size(1170, 493);
			dataMaterials.TabIndex = 0;
			// 
			// tabProductsAnalysation
			// 
			tabProductsAnalysation.Controls.Add(lblProductionResult);
			tabProductsAnalysation.Controls.Add(dataProductsByMaterial);
			tabProductsAnalysation.Controls.Add(btnCalculateProduction);
			tabProductsAnalysation.Controls.Add(numMaterialAmount);
			tabProductsAnalysation.Controls.Add(cmbMaterialType);
			tabProductsAnalysation.Controls.Add(cmbProductType);
			tabProductsAnalysation.Controls.Add(label6);
			tabProductsAnalysation.Controls.Add(label5);
			tabProductsAnalysation.Controls.Add(label4);
			tabProductsAnalysation.Location = new Point(4, 35);
			tabProductsAnalysation.Name = "tabProductsAnalysation";
			tabProductsAnalysation.Size = new Size(1176, 611);
			tabProductsAnalysation.TabIndex = 2;
			tabProductsAnalysation.Text = "Products Analysation";
			tabProductsAnalysation.UseVisualStyleBackColor = true;
			// 
			// lblProductionResult
			// 
			lblProductionResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblProductionResult.AutoSize = true;
			lblProductionResult.Location = new Point(535, 559);
			lblProductionResult.Name = "lblProductionResult";
			lblProductionResult.Size = new Size(67, 27);
			lblProductionResult.TabIndex = 1003;
			lblProductionResult.Text = "result";
			// 
			// dataProductsByMaterial
			// 
			dataProductsByMaterial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			dataProductsByMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataProductsByMaterial.Location = new Point(40, 104);
			dataProductsByMaterial.Name = "dataProductsByMaterial";
			dataProductsByMaterial.Size = new Size(1100, 424);
			dataProductsByMaterial.TabIndex = 4;
			// 
			// btnCalculateProduction
			// 
			btnCalculateProduction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCalculateProduction.Location = new Point(985, 34);
			btnCalculateProduction.Name = "btnCalculateProduction";
			btnCalculateProduction.Size = new Size(155, 64);
			btnCalculateProduction.TabIndex = 3;
			btnCalculateProduction.Text = "Calculate";
			btnCalculateProduction.UseVisualStyleBackColor = true;
			btnCalculateProduction.Click += btnCalculateProduction_Click;
			// 
			// numMaterialAmount
			// 
			numMaterialAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			numMaterialAmount.Location = new Point(655, 64);
			numMaterialAmount.Name = "numMaterialAmount";
			numMaterialAmount.Size = new Size(262, 34);
			numMaterialAmount.TabIndex = 2;
			numMaterialAmount.TextAlign = HorizontalAlignment.Center;
			// 
			// cmbMaterialType
			// 
			cmbMaterialType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			cmbMaterialType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMaterialType.FormattingEnabled = true;
			cmbMaterialType.Location = new Point(345, 64);
			cmbMaterialType.Name = "cmbMaterialType";
			cmbMaterialType.Size = new Size(208, 34);
			cmbMaterialType.TabIndex = 1;
			// 
			// cmbProductType
			// 
			cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbProductType.FormattingEnabled = true;
			cmbProductType.Location = new Point(40, 64);
			cmbProductType.Name = "cmbProductType";
			cmbProductType.Size = new Size(202, 34);
			cmbProductType.TabIndex = 0;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Bottom;
			label6.AutoSize = true;
			label6.Location = new Point(655, 33);
			label6.Name = "label6";
			label6.Size = new Size(262, 27);
			label6.TabIndex = 999;
			label6.Text = "Enter the qty of materials:";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom;
			label5.AutoSize = true;
			label5.Location = new Point(345, 34);
			label5.Name = "label5";
			label5.Size = new Size(208, 27);
			label5.TabIndex = 999;
			label5.Text = "Select material type:";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Bottom;
			label4.AutoSize = true;
			label4.Location = new Point(40, 34);
			label4.Name = "label4";
			label4.Size = new Size(202, 27);
			label4.TabIndex = 999;
			label4.Text = "Select product type:";
			// 
			// tabLoginHistory
			// 
			tabLoginHistory.Controls.Add(txtFilterByLogin);
			tabLoginHistory.Controls.Add(label1);
			tabLoginHistory.Controls.Add(dataLoginHistory);
			tabLoginHistory.Location = new Point(4, 35);
			tabLoginHistory.Name = "tabLoginHistory";
			tabLoginHistory.Size = new Size(1176, 611);
			tabLoginHistory.TabIndex = 3;
			tabLoginHistory.Text = "Login History";
			tabLoginHistory.UseVisualStyleBackColor = true;
			// 
			// txtFilterByLogin
			// 
			txtFilterByLogin.Location = new Point(424, 539);
			txtFilterByLogin.Name = "txtFilterByLogin";
			txtFilterByLogin.Size = new Size(354, 34);
			txtFilterByLogin.TabIndex = 2;
			txtFilterByLogin.TextChanged += txtFilterByLogin_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(268, 542);
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
			tabMaterialsList.ResumeLayout(false);
			tabMaterialsList.PerformLayout();
			tabMaterialsManagement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataMaterials).EndInit();
			tabProductsAnalysation.ResumeLayout(false);
			tabProductsAnalysation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataProductsByMaterial).EndInit();
			((System.ComponentModel.ISupportInitialize)numMaterialAmount).EndInit();
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
		private FlowLayoutPanel flowLayoutPanelMaterials;
		private Label lblSearch;
		private TextBox txtSearch;
		private ComboBox cmbSort;
		private Label label2;
		private ComboBox cmbFilterByType;
		private Label label3;
		private Button btnRemove;
		private Button btnAdd;
		private Button btnEdit;
		private DataGridView dataMaterials;
		private Label label6;
		private Label label5;
		private Label label4;
		private NumericUpDown numMaterialAmount;
		private ComboBox cmbMaterialType;
		private ComboBox cmbProductType;
		private DataGridView dataProductsByMaterial;
		private Button btnCalculateProduction;
		private Label lblProductionResult;
	}
}