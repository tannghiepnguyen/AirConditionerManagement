using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface IAirConditionerRepository
	{
		List<AirConditioner> GetAll();
		void Add(AirConditioner airConditioner);
		void Update(AirConditioner airConditioner);
		void Delete(AirConditioner airConditioner);
		int GetNewId();
	}
}
