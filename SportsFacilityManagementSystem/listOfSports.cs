using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFacilityManagementSystem
{
    class listOfSports
    {

        private static List<String> sportsList = new List<String>();
        private static SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
        
        
        public static List<String> getSportList()
        {
            sportsList = ctx.Facilities.OrderBy(x => x.facilityname).Select(y => y.facilityname).ToList();
            return sportsList;
        }
    }
}
