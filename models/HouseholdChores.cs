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
        // Define query expressions
        IEnumerable<int> choresQuery = from choresId in choresIds
                                       where choresId > 1
                                       select choresId;
           choresmthdQuery1 = 
        foreach (int i in choresId)
	    {
            
            Console.Write(i + " ");
	    }
    }
}
