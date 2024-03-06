using BusinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_NguyenLeTanNghiep
{
	public partial class frmAirConditionerManagement : Form
	{
		private IAirConditionerRepository repository;
		private ISupplier supplier;
		public frmAirConditionerManagement()
		{
			repository = new AirConditionerRepository();
			supplier = new Supplier();
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

		private void LoadAirConditioner()
		{
			BindingSource source = new BindingSource();
			source.DataSource = repository.GetAll().Select(c => new
			{
				c.AirConditionerId,
				c.AirConditionerName,
				c.Warranty,
				c.SoundPressureLevel,
				c.FeatureFunction,
				c.DollarPrice,
				c.Quantity,
				c.Supplier?.SupplierName,
			});

			ClearBinding();

			txtID.DataBindings.Add("Text", source, "AirConditionerId", true, DataSourceUpdateMode.OnPropertyChanged);
			txtAirConditionerName.DataBindings.Add("Text", source, "AirConditionerName", true, DataSourceUpdateMode.OnPropertyChanged);
			txtWarranty.DataBindings.Add("Text", source, "Warranty", true, DataSourceUpdateMode.OnPropertyChanged);
			txtSoundPressureLevel.DataBindings.Add("Text", source, "SoundPressureLevel", true, DataSourceUpdateMode.OnPropertyChanged);
			txtFeatureFunction.DataBindings.Add("Text", source, "FeatureFunction", true, DataSourceUpdateMode.OnPropertyChanged);
			txtDollarPrice.DataBindings.Add("Text", source, "DollarPrice", true, DataSourceUpdateMode.OnPropertyChanged);
			cboSupplierCompany.DataBindings.Add("Text", source, "SupplierName", true, DataSourceUpdateMode.OnPropertyChanged);
			numericQuantity.DataBindings.Add("Value", source, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);

			dgvAirConditionerList.DataSource = null;
			dgvAirConditionerList.DataSource = source;
		}

		private void ClearText()
		{
			txtID.Text = string.Empty;
			txtAirConditionerName.Text = string.Empty;
			txtWarranty.Text = string.Empty;
			txtSoundPressureLevel.Text = string.Empty;
			txtFeatureFunction.Text = string.Empty;
			txtDollarPrice.Text = string.Empty;
			cboSupplierCompany.SelectedIndex = 0;
			numericQuantity.Value = 0;
		}

		private void frmAirConditionerManagement_Load(object sender, EventArgs e)
		{
			LoadAirConditioner();
			cboSupplierCompany.DataSource = supplier.GetAll();
			cboSupplierCompany.ValueMember = "SupplierId";
			cboSupplierCompany.DisplayMember = "SupplierName";
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			if (btnNew.Text.Equals("New"))
			{
				btnNew.Text = "Cancel";
				btnSave.Enabled = true;
				ClearBinding();
				ClearText();
				txtID.Text = repository.GetNewId().ToString();
			}
			else
			{
				btnNew.Text = "New";
				btnSave.Enabled = false;
				LoadAirConditioner();
			}
		}

		private bool checkEmptyString(string s)
		{
			return s.Trim().Equals(string.Empty);
		}

		private void CreateOrUpdateForm(bool isCreate)
		{
			TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
			string titleCase = textInfo.ToTitleCase(txtAirConditionerName.Text);
			string txtAirConditionerNameTitleCase = string.Join(" ", Regex.Split(titleCase.Trim(), @"\s+"));
			if (checkEmptyString(txtAirConditionerName.Text) || checkEmptyString(txtWarranty.Text) || checkEmptyString(txtSoundPressureLevel.Text) || checkEmptyString(txtFeatureFunction.Text) || checkEmptyString(txtDollarPrice.Text) || checkEmptyString(numericQuantity.Text))
			{
				MessageBox.Show("Please fill in all fields", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else if (double.Parse(txtDollarPrice.Text) < 0 || double.Parse(txtDollarPrice.Text) >= 4000000)
			{
				MessageBox.Show("Dollar price must be greater than or equal 0 and less than 4000000", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else if (int.Parse(numericQuantity.Value.ToString()) < 0 || int.Parse(numericQuantity.Value.ToString()) >= 4000000)
			{
				MessageBox.Show("Quantity must be greater than or equal 0 and less than 4000000", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else if (txtAirConditionerNameTitleCase.Length < 5 || txtAirConditionerNameTitleCase.Length > 90)
			{
				MessageBox.Show("Air conditioner name must be from 5 to 90 characters", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else
			{
				AirConditioner airConditioner = new AirConditioner
				{
					AirConditionerId = int.Parse(txtID.Text),
					AirConditionerName = txtAirConditionerNameTitleCase,
					Warranty = txtWarranty.Text,
					SoundPressureLevel = txtSoundPressureLevel.Text,
					FeatureFunction = txtFeatureFunction.Text,
					DollarPrice = double.Parse(txtDollarPrice.Text),
					Quantity = int.Parse(numericQuantity.Value.ToString()),
					SupplierId = (string)cboSupplierCompany.SelectedValue
				};
				if (isCreate)
				{
					repository.Add(airConditioner);
					btnNew.Text = "New";
					btnSave.Enabled = false;
				}
				else
				{
					repository.Update(airConditioner);
				}
				LoadAirConditioner();
			}
			
			
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			CreateOrUpdateForm(true);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			CreateOrUpdateForm(false);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			ClearBinding();
			AirConditioner airConditioner = new AirConditioner
			{
				AirConditionerId = int.Parse(txtID.Text),
				AirConditionerName = txtAirConditionerName.Text,
				Warranty = txtWarranty.Text,
				SoundPressureLevel = txtSoundPressureLevel.Text,
				FeatureFunction = txtFeatureFunction.Text,
				DollarPrice = double.Parse(txtDollarPrice.Text),
				Quantity = int.Parse(numericQuantity.Text),
				SupplierId = (string)cboSupplierCompany.SelectedValue
			};
			repository.Delete(airConditioner);
			LoadAirConditioner();
		}

		private void ClearBinding()
		{
			txtID.DataBindings.Clear();
			txtAirConditionerName.DataBindings.Clear();
			txtWarranty.DataBindings.Clear();
			txtSoundPressureLevel.DataBindings.Clear();
			txtFeatureFunction.DataBindings.Clear();
			txtDollarPrice.DataBindings.Clear();
			cboSupplierCompany.DataBindings.Clear();
			numericQuantity.DataBindings.Clear();
		}
	}
}
