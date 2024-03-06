namespace AirConditionerShop_NguyenLeTanNghiep
{
	partial class frmAirConditionerManagement
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
			panel1 = new Panel();
			numericQuantity = new NumericUpDown();
			btnExit = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnSave = new Button();
			btnNew = new Button();
			cboSupplierCompany = new ComboBox();
			lbSupplierCompany = new Label();
			lbQuantity = new Label();
			txtDollarPrice = new TextBox();
			lbDollarPrice = new Label();
			txtFeatureFunction = new TextBox();
			lbFearuteFuntion = new Label();
			txtSoundPressureLevel = new TextBox();
			lbSoundPressureLevel = new Label();
			txtWarranty = new TextBox();
			lbWarranty = new Label();
			txtAirConditionerName = new TextBox();
			lbAirCOnditionerName = new Label();
			txtID = new TextBox();
			lbID = new Label();
			panel2 = new Panel();
			dgvAirConditionerList = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvAirConditionerList).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(numericQuantity);
			panel1.Controls.Add(btnExit);
			panel1.Controls.Add(btnDelete);
			panel1.Controls.Add(btnUpdate);
			panel1.Controls.Add(btnSave);
			panel1.Controls.Add(btnNew);
			panel1.Controls.Add(cboSupplierCompany);
			panel1.Controls.Add(lbSupplierCompany);
			panel1.Controls.Add(lbQuantity);
			panel1.Controls.Add(txtDollarPrice);
			panel1.Controls.Add(lbDollarPrice);
			panel1.Controls.Add(txtFeatureFunction);
			panel1.Controls.Add(lbFearuteFuntion);
			panel1.Controls.Add(txtSoundPressureLevel);
			panel1.Controls.Add(lbSoundPressureLevel);
			panel1.Controls.Add(txtWarranty);
			panel1.Controls.Add(lbWarranty);
			panel1.Controls.Add(txtAirConditionerName);
			panel1.Controls.Add(lbAirCOnditionerName);
			panel1.Controls.Add(txtID);
			panel1.Controls.Add(lbID);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(539, 517);
			panel1.TabIndex = 0;
			// 
			// numericQuantity
			// 
			numericQuantity.Location = new Point(173, 360);
			numericQuantity.Name = "numericQuantity";
			numericQuantity.Size = new Size(248, 27);
			numericQuantity.TabIndex = 4;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(423, 465);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 3;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(323, 465);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(94, 29);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(223, 465);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(94, 29);
			btnUpdate.TabIndex = 3;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnSave
			// 
			btnSave.Enabled = false;
			btnSave.Location = new Point(123, 465);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 3;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnNew
			// 
			btnNew.Location = new Point(23, 465);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(94, 29);
			btnNew.TabIndex = 3;
			btnNew.Text = "New";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// cboSupplierCompany
			// 
			cboSupplierCompany.FormattingEnabled = true;
			cboSupplierCompany.Location = new Point(173, 405);
			cboSupplierCompany.Name = "cboSupplierCompany";
			cboSupplierCompany.Size = new Size(249, 28);
			cboSupplierCompany.TabIndex = 2;
			// 
			// lbSupplierCompany
			// 
			lbSupplierCompany.AutoSize = true;
			lbSupplierCompany.Location = new Point(36, 408);
			lbSupplierCompany.Name = "lbSupplierCompany";
			lbSupplierCompany.Size = new Size(131, 20);
			lbSupplierCompany.TabIndex = 0;
			lbSupplierCompany.Text = "Supplier Company";
			// 
			// lbQuantity
			// 
			lbQuantity.AutoSize = true;
			lbQuantity.Location = new Point(81, 360);
			lbQuantity.Name = "lbQuantity";
			lbQuantity.Size = new Size(65, 20);
			lbQuantity.TabIndex = 0;
			lbQuantity.Text = "Quantity";
			// 
			// txtDollarPrice
			// 
			txtDollarPrice.Location = new Point(173, 312);
			txtDollarPrice.Name = "txtDollarPrice";
			txtDollarPrice.Size = new Size(249, 27);
			txtDollarPrice.TabIndex = 1;
			// 
			// lbDollarPrice
			// 
			lbDollarPrice.AutoSize = true;
			lbDollarPrice.Location = new Point(81, 315);
			lbDollarPrice.Name = "lbDollarPrice";
			lbDollarPrice.Size = new Size(86, 20);
			lbDollarPrice.TabIndex = 0;
			lbDollarPrice.Text = "Dollar Price";
			// 
			// txtFeatureFunction
			// 
			txtFeatureFunction.Location = new Point(173, 222);
			txtFeatureFunction.Multiline = true;
			txtFeatureFunction.Name = "txtFeatureFunction";
			txtFeatureFunction.Size = new Size(249, 70);
			txtFeatureFunction.TabIndex = 1;
			// 
			// lbFearuteFuntion
			// 
			lbFearuteFuntion.AutoSize = true;
			lbFearuteFuntion.Location = new Point(49, 225);
			lbFearuteFuntion.Name = "lbFearuteFuntion";
			lbFearuteFuntion.Size = new Size(118, 20);
			lbFearuteFuntion.TabIndex = 0;
			lbFearuteFuntion.Text = "Feature Function";
			// 
			// txtSoundPressureLevel
			// 
			txtSoundPressureLevel.Location = new Point(173, 170);
			txtSoundPressureLevel.Name = "txtSoundPressureLevel";
			txtSoundPressureLevel.Size = new Size(249, 27);
			txtSoundPressureLevel.TabIndex = 1;
			// 
			// lbSoundPressureLevel
			// 
			lbSoundPressureLevel.AutoSize = true;
			lbSoundPressureLevel.Location = new Point(20, 173);
			lbSoundPressureLevel.Name = "lbSoundPressureLevel";
			lbSoundPressureLevel.Size = new Size(147, 20);
			lbSoundPressureLevel.TabIndex = 0;
			lbSoundPressureLevel.Text = "Sound Pressure Level";
			// 
			// txtWarranty
			// 
			txtWarranty.Location = new Point(173, 120);
			txtWarranty.Name = "txtWarranty";
			txtWarranty.Size = new Size(249, 27);
			txtWarranty.TabIndex = 1;
			// 
			// lbWarranty
			// 
			lbWarranty.AutoSize = true;
			lbWarranty.Location = new Point(97, 123);
			lbWarranty.Name = "lbWarranty";
			lbWarranty.Size = new Size(68, 20);
			lbWarranty.TabIndex = 0;
			lbWarranty.Text = "Warranty";
			// 
			// txtAirConditionerName
			// 
			txtAirConditionerName.Location = new Point(173, 72);
			txtAirConditionerName.Name = "txtAirConditionerName";
			txtAirConditionerName.Size = new Size(249, 27);
			txtAirConditionerName.TabIndex = 1;
			// 
			// lbAirCOnditionerName
			// 
			lbAirCOnditionerName.AutoSize = true;
			lbAirCOnditionerName.Location = new Point(15, 75);
			lbAirCOnditionerName.Name = "lbAirCOnditionerName";
			lbAirCOnditionerName.Size = new Size(150, 20);
			lbAirCOnditionerName.TabIndex = 0;
			lbAirCOnditionerName.Text = "AirConditioner Name";
			// 
			// txtID
			// 
			txtID.Enabled = false;
			txtID.Location = new Point(173, 21);
			txtID.Name = "txtID";
			txtID.Size = new Size(249, 27);
			txtID.TabIndex = 1;
			// 
			// lbID
			// 
			lbID.AutoSize = true;
			lbID.Location = new Point(117, 24);
			lbID.Name = "lbID";
			lbID.Size = new Size(24, 20);
			lbID.TabIndex = 0;
			lbID.Text = "ID";
			// 
			// panel2
			// 
			panel2.Controls.Add(dgvAirConditionerList);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(539, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(366, 517);
			panel2.TabIndex = 1;
			// 
			// dgvAirConditionerList
			// 
			dgvAirConditionerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAirConditionerList.Dock = DockStyle.Fill;
			dgvAirConditionerList.Location = new Point(0, 0);
			dgvAirConditionerList.Name = "dgvAirConditionerList";
			dgvAirConditionerList.RowHeadersWidth = 51;
			dgvAirConditionerList.RowTemplate.Height = 29;
			dgvAirConditionerList.Size = new Size(366, 517);
			dgvAirConditionerList.TabIndex = 0;
			// 
			// frmAirConditionerManagement
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(905, 517);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "frmAirConditionerManagement";
			Text = "frmAirConditionerManagement";
			Load += frmAirConditionerManagement_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvAirConditionerList).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label lbSupplierCompany;
		private TextBox txtDollarPrice;
		private Label lbDollarPrice;
		private TextBox txtFeatureFunction;
		private Label lbFearuteFuntion;
		private TextBox txtSoundPressureLevel;
		private Label lbSoundPressureLevel;
		private TextBox txtWarranty;
		private Label lbWarranty;
		private TextBox txtAirConditionerName;
		private Label lbAirCOnditionerName;
		private TextBox txtID;
		private Label lbID;
		private Panel panel2;
		private DataGridView dgvAirConditionerList;
		private ComboBox cboSupplierCompany;
		private Button btnNew;
		private Button btnExit;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnSave;
		private NumericUpDown numericQuantity;
		private Label lbQuantity;
	}
}