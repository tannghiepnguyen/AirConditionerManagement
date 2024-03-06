using BusinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_NguyenLeTanNghiep
{
	public partial class frmLogin : Form
	{
		private IStaffMemberRepository repository;
		public frmLogin()
		{
			repository = new StaffMemberRepository();
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string password = txtPassword.Text;
			StaffMember? member = repository.CheckLogin(email, password);
			if (member != null && member.Role == 1)
			{
				frmAirConditionerManagement frm = new frmAirConditionerManagement();
				frm.Show();
			}
			else
			{
				MessageBox.Show("You have no permission to access this function!", "Login Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			
		}
	}
}
