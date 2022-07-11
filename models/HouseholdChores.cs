using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient.models
{


    class HouseholdChores
    {
        private string[] ChoresName = { "Wash and Mop the floor", "Do the laundry ", "Garage sale of all the rest of the items", "Cooking and Meal preparation for the next week" };
        private string[] ChoresDeadline = { "5 August 2037", "2 November 2042", "1 January 2059" };
        int[] choresId = { 1, 2, 3, 4 };
        public static object choresIds { get; private set; }
        public static object iChoresIds { get; private set; }

        // Define query static expressions //
        IEnumerable<int> choresQuery = from choresId in choresIds
                                       where choresId > 1
                                       select choresId;

        IEnumerable<string> choresmthdQuery1 = from choresName in choresNames
                                               where choresName != null
                                               select choresName;

        //   foreach (int iChoresIds in choresIds)
        //    {
        //          return private choresQuery(iChoresId);
        //          Console.Write(iChoresId + "This is the Chore Id returned for XXXX");
        //    }
        //   foreach (string ichoreNames in choresNames) 
        //{
        //       return private choresmthdQuery1(iChoresNames);
        //       Console.Write(ichoreNames + "This is the chore Name returned for chored Name: XXXX");
        //}
    }
}

