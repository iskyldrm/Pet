using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.BL.Concrete
{
    public class CityManager:ManagerBase<City>,ICityManager
    {

        public override int Add(City input)
        {

            var cities = base.GetAll(p => p.CityName == input.CityName);

            if (cities == null)
                return base.Add(input);
            else
                return -1;
        }
    }
}
