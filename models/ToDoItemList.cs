using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient.models
{
    class ToDoItemList
    {
        public string ToDoItemName { get; set; }
        public int ToDoItemId { get; set; }
        public int TaskId { get; set; }
        public enum taskStatus
        {
            NotYetStarted,
            InProgress,
            Completed,
            Archived
        }

        internal static void Add(ToDoItemList toDoItemList)
        {
            throw new NotImplementedException();
        }

        internal static object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal static object OrderByAscending(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
