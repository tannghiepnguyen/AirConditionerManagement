using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccessObject
{
	public class AirConditionerDAO
	{
		private static AirConditionerDAO? instance = null;
		private static object lockObject = new object();

		private AirConditionerDAO() { }
		public static AirConditionerDAO Instance
		{
			get
			{
				lock (lockObject)
				{
					if (instance == null)
					{
						instance = new AirConditionerDAO();
					}
					return instance;
				}
			}
		}

		public List<AirConditioner> GetAirConditionerList()
		{
			using var db = new AirConditionerShop2023DBContext();
			return db.AirConditioners.Include(c => c.Supplier).ToList();
		}

		public void AddAirConditioner(AirConditioner airConditioner)
		{
			using var db = new AirConditionerShop2023DBContext();
			db.AirConditioners.Add(airConditioner);
			db.SaveChanges();
		}
		public void UpdateAirConditioner(AirConditioner airConditioner)
		{
			using var db = new AirConditionerShop2023DBContext();
			db.Update(airConditioner);
			db.SaveChanges();
		}
		public void DeleteAirConditioner(AirConditioner airConditioner)
		{
			using var db = new AirConditionerShop2023DBContext();
			db.AirConditioners.Remove(airConditioner);
			db.SaveChanges();
		}
		public int GetNewId()
		{
			using var db = new AirConditionerShop2023DBContext();
			return db.AirConditioners.Max(c => c.AirConditionerId) + 1;
		}
	}
}
