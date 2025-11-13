namespace FurnitureShop
{
	partial class MaterialForm
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
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			btnSave = new Button();
			lblId = new Label();
			txtQtyInPack = new TextBox();
			txtMinQty = new TextBox();
			txtQtyInStock = new TextBox();
			txtUnitPrice = new TextBox();
			txtName = new TextBox();
			cmbType = new ComboBox();
			txtUoM = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(160, 37);
			label1.Name = "label1";
			label1.Size = new Size(37, 27);
			label1.TabIndex = 999;
			label1.Text = "Id:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(160, 81);
			label2.Name = "label2";
			label2.Size = new Size(75, 27);
			label2.TabIndex = 999;
			label2.Text = "Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(160, 122);
			label3.Name = "label3";
			label3.Size = new Size(64, 27);
			label3.TabIndex = 999;
			label3.Text = "Type:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(160, 168);
			label4.Name = "label4";
			label4.Size = new Size(113, 27);
			label4.TabIndex = 999;
			label4.Text = "Unit price:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(160, 214);
			label5.Name = "label5";
			label5.Size = new Size(136, 27);
			label5.TabIndex = 999;
			label5.Text = "Qty in stock:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(160, 260);
			label6.Name = "label6";
			label6.Size = new Size(93, 27);
			label6.TabIndex = 999;
			label6.Text = "Min qty:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(160, 306);
			label7.Name = "label7";
			label7.Size = new Size(130, 27);
			label7.TabIndex = 999;
			label7.Text = "Qty in pack:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(160, 354);
			label8.Name = "label8";
			label8.Size = new Size(66, 27);
			label8.TabIndex = 999;
			label8.Text = "UoM:";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(384, 455);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 38);
			btnSave.TabIndex = 7;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new Point(302, 37);
			lblId.Name = "lblId";
			lblId.Size = new Size(31, 27);
			lblId.TabIndex = 10;
			lblId.Text = "Id";
			// 
			// txtQtyInPack
			// 
			txtQtyInPack.Location = new Point(302, 299);
			txtQtyInPack.Name = "txtQtyInPack";
			txtQtyInPack.Size = new Size(373, 34);
			txtQtyInPack.TabIndex = 5;
			txtQtyInPack.KeyPress += txt_NumOnly_KeyPress;
			// 
			// txtMinQty
			// 
			txtMinQty.Location = new Point(302, 253);
			txtMinQty.Name = "txtMinQty";
			txtMinQty.Size = new Size(373, 34);
			txtMinQty.TabIndex = 4;
			txtMinQty.KeyPress += txt_NumOnly_KeyPress;
			// 
			// txtQtyInStock
			// 
			txtQtyInStock.Location = new Point(302, 207);
			txtQtyInStock.Name = "txtQtyInStock";
			txtQtyInStock.Size = new Size(373, 34);
			txtQtyInStock.TabIndex = 3;
			txtQtyInStock.KeyPress += txt_NumOnly_KeyPress;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(302, 161);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(373, 34);
			txtUnitPrice.TabIndex = 2;
			txtUnitPrice.KeyPress += txt_NumOnly_KeyPress;
			// 
			// txtName
			// 
			txtName.Location = new Point(302, 74);
			txtName.Name = "txtName";
			txtName.Size = new Size(373, 34);
			txtName.TabIndex = 0;
			// 
			// cmbType
			// 
			cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbType.FormattingEnabled = true;
			cmbType.Location = new Point(302, 115);
			cmbType.Name = "cmbType";
			cmbType.Size = new Size(373, 34);
			cmbType.TabIndex = 1;
			// 
			// txtUoM
			// 
			txtUoM.Location = new Point(302, 347);
			txtUoM.Name = "txtUoM";
			txtUoM.Size = new Size(373, 34);
			txtUoM.TabIndex = 6;
			// 
			// MaterialForm
			// 
			AutoScaleDimensions = new SizeF(12F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 561);
			Controls.Add(txtUoM);
			Controls.Add(cmbType);
			Controls.Add(txtName);
			Controls.Add(txtUnitPrice);
			Controls.Add(txtQtyInStock);
			Controls.Add(txtMinQty);
			Controls.Add(txtQtyInPack);
			Controls.Add(lblId);
			Controls.Add(btnSave);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "MaterialForm";
			Text = "Obraz Plus - MaterialForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Button btnSave;
		private Label lblId;
		private TextBox txtQtyInPack;
		private TextBox txtMinQty;
		private TextBox txtQtyInStock;
		private TextBox txtUnitPrice;
		private TextBox txtName;
		private ComboBox cmbType;
		private TextBox txtUoM;
	}
}