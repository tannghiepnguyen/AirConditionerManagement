using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
	public class SupplierDAO
	{
		private static SupplierDAO instance = null;
		private static object lockObject = new object();

		private SupplierDAO() { }
		public static SupplierDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SupplierDAO();
				}
				return instance;
			}
		}

		public List<SupplierCompany> GetSupplierList()
		{
			using var db = new AirConditionerShop2023DBContext();
			return db.SupplierCompanies.ToList();
		}
	}
}
