using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class StaffMemberRepository : IStaffMemberRepository
	{
		public StaffMember? CheckLogin(string email, string password) => StaffMemberDAO.Instance.CheckLogin(email, password);
	}
}
