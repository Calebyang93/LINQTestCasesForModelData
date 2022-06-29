using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class TodoItem
    {
            string taskName { get; set; }
            DateTime taskDate { get; set; }
            string taskOwner { get; set; }
            Guid taskId { get; set; }
        }
        
    }
