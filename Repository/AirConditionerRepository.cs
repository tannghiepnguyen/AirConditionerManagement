using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class AirConditionerRepository : IAirConditionerRepository
	{
		public void Add(AirConditioner airConditioner) => AirConditionerDAO.Instance.AddAirConditioner(airConditioner);

		public void Delete(AirConditioner airConditioner) => AirConditionerDAO.Instance.DeleteAirConditioner(airConditioner);

		public List<AirConditioner> GetAll() => AirConditionerDAO.Instance.GetAirConditionerList();

		public void Update(AirConditioner airConditioner) => AirConditionerDAO.Instance.UpdateAirConditioner(airConditioner);

		public int GetNewId() => AirConditionerDAO.Instance.GetNewId();
	}
}
