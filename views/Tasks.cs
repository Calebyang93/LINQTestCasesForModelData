using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIClient.folder;
using WebAPIClient.models;

namespace WebAPIClient.views
{
    class Tasks
    {
        public int ToDoItemId { get; set; }
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskOwner { get; set; }
        public DateTime taskDeadline { get; set; }
        public static object TasksLsts { get; set; }

        public enum taskStatus
        {
            NotYetStarted,
            InProgress,
            Completed,
            Archived
        }
        public static List<ToDoItems> ToDoItemsLst = new List<ToDoItems>();
        public static List<Tasks> TasksLst = new List<Tasks>();
        public static List<ToDoItemList> TDILst = new List<ToDoItemList>();

        static void Main(string[] args)
        {
            //InitializeToDoItemsLst();
            InitializeToDoItemsList();
            InitializeTasksLst();

            //LINQ WHERE CLAUSE //
            var querysyntax1 = from Tasks in TasksLst
                               where Tasks.taskName.StartsWith("L")
                               select Tasks.taskOwner;
            Console.WriteLine("Where in querysyntax equals to task owner: ---");
            foreach (var item in querysyntax1)
            {
                Console.WriteLine(item);
            }
            var methodQuery1 = TasksLst.Where(e => e.taskName.StartsWith("L"));
            Console.WriteLine("Where in method Query 1: -----");
            foreach (var item in methodQuery1)
            {
                Console.WriteLine(item.taskName);
            }
            Console.WriteLine('\n');


            //LINQ ORDERBY ASC CLAUSE //
            var querysyntax2 = from Tasks in TasksLst
                               orderby Tasks.taskName
                               select Tasks.taskName;
            var methodQuery2 = TasksLst.OrderBy(e => e.taskName);
            Console.WriteLine("Order by Ascending in Query Syntax 2 -----");
            foreach (var item in querysyntax2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Order By Ascneding in Method Query 2 -----");
            foreach (var item in methodQuery2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine('\n');

            // LINQ ORDERBY DESC CLAUSE 
            var querysyntax3 = from Tasks in TasksLst
                               orderby Tasks.taskName descending
                               select Tasks.taskName;
            var methodsyntax3 = TasksLst.OrderByDescending(e => e.taskName);
            Console.WriteLine("Order by Descending in Query Syntax 3 --- ");
            foreach (var item in querysyntax3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine('\n');

            // LINQ THEN BY CLAUSE 
            var querysyntax4 = from ToDoItemList in TDILst
                               orderby ToDoItemList.ToDoItemId, ToDoItemList.ToDoItemName
                               select ToDoItemList;
            var methodsyntax4 = ToDoItemList.OrderBy(e => e.ToDoItemId)
            .ThenByDescending(e => e.ToDoItemName); 
            Console.WriteLine("Order by ToDoItem Id: ascending in querysyntax4-------");
            foreach (var item in querysyntax4)
            {
                Console.WriteLine(item.ToDoItemName + ":" + item.ToDoItemId);
            }
            Console.WriteLine("Order by TodoItem ID ------ ascending in methodsyntax4");
            foreach (var item in methodsyntax4)
            {
                Console.WriteLine(item.ToDoItemName + ":" + item.ToDoItemId);
            }
            Console.WriteLine('\n');


            // LINQ TAKE CLAUSE 
            var querysyntax5 = (from Tasks in TasksLst
                               select Tasks).Take(2);
            var methodsyntax5 = TasksLst.Take(2);
            Console.WriteLine("Take in Query and check using Take for query syntax 5 ----");
            foreach (var item in querysyntax5)
            {
                Console.WriteLine(item.taskId);
                Console.WriteLine(item.taskName);
                Console.WriteLine(item.taskOwner);
                Console.WriteLine(item.taskDeadline);
            }
            foreach (var item in methodsyntax5)
            {
                Console.WriteLine(item.taskId);
                Console.WriteLine(item.taskName);
                Console.WriteLine(item.taskOwner);
                Console.WriteLine(item.taskDeadline);
            }
            Console.WriteLine('\n');


            // LINQ SKIP Clause 
            var querysyntax6 = (from Tasks in TasksLst
                                select Tasks).Skip(1);
            var methodsyntax6 = TasksLst.Skip(1);
            Console.WriteLine("Skip the QuerySyntax for TodoItem[2]");
            foreach (var item in querysyntax6)
            {
                Console.WriteLine(item.taskName);
                Console.WriteLine(item.taskOwner);
                Console.WriteLine(item.taskDeadline);
            }
            Console.WriteLine("Skip the MethodSyntax for ToDoItem[2]");
            foreach (var item in methodsyntax6)
            {
                Console.WriteLine(item.taskName);
                Console.WriteLine(item.taskOwner);
                Console.WriteLine(item.taskDeadline);
            }
            Console.WriteLine('\n');

            // LINQ GROUP CLAUSE 
            var querysyntax7 = from Tasks in TasksLst
                               group Tasks by Tasks.taskName;
            var methodsyntax7 = TasksLst.GroupBy(e => e.taskName);
            Console.WriteLine("Group to Do Item Tasks by their QuerySyntax: Group to Do Item Tasks by their task names ---");
            foreach (var item in querysyntax7)
            {
                Console.WriteLine(item.Key + ":" + item.Count());
            }
            Console.WriteLine("Group to Do Item Tasks by their Method Syntax : Group to Do Item Tasks by their tasks names ---");
            foreach (var item in methodsyntax7)
            {
                Console.WriteLine(item.Key + ":" + item.Count());
            }
            Console.WriteLine('\n');


            // LINQ FIRST CLAUSE 
            var querysyntax8 = (from Tasks in TasksLst select Tasks).First();
            var methodsyntax8 = TasksLst.First();
            Console.WriteLine(" Checking for First ToDoItem Tasks in entry field---- ");
            if (querysyntax8 != null)
            {
                Console.WriteLine(querysyntax8.taskOwner);
            }
            if (methodsyntax8 != null)
            {
                Console.WriteLine(methodsyntax8.taskOwner);
            }
            Console.WriteLine('\n');

            // LINQ FIRST OR DEFAULT CLAUSE 
            var querysyntax9 = (from Tasks in TasksLst select Tasks).FirstOrDefault();
            var methodsyntax9 = TasksLst.FirstOrDefault();
            Console.WriteLine("First or Default in querySyntax to show First or Default ToDoItem Task");
            if (querysyntax9 != null)
            {
                Console.WriteLine(querysyntax9.taskName);
            }
            if (methodsyntax9 != null)
            {
                Console.WriteLine(methodsyntax9.taskName);
            }
            Console.WriteLine('\n');

            //LINQ JOIN QUERY CLAUSE
            var querysyntax10 = from TasksLst in TasksLsts
                                join ToDoItemList in ToDoItemsLst on TasksLst.ToDoItemId equals ToDoItemList.taskId into groupId1
                                select new { TasksLsts.taskName, ToDoItemName = ToDoItemList?.ToDoItemName ?? "NULL" };
            var methodsyntax10 = TasksLst.Join(ToDoItemsLst,
                                            t => t.taskId,
                                            d => d.taskId,
                                            (t, d) => new { t.taskName, t.taskOwner, d.taskDeadline, });
            Console.WriteLine("Join in query syntax of mxing between TaskLst table and ToDoItem table");
            foreach (var item in querysyntax10)
            {
                Console.WriteLine(item.taskName + ":" + item.taskOwner + ":" + item.taskDeadline);
            }
            foreach (var item in methodsyntax10)
            {
                Console.WriteLine(item.taskName + ":" + item.taskOwner + ":" + item.taskDeadline);
            }

        }

        private static object Skip(int v)
        {
            throw new NotImplementedException();
        }

        private static object Take(int v)
        {
            throw new NotImplementedException();
        }

        private static void InitializeToDoItemsList()
        {
            ToDoItemList.Add(new ToDoItemList
            {
                ToDoItemName = "Learn Language",
                ToDoItemId = 1
            });
            ToDoItemList.Add(new ToDoItemList
            {
                ToDoItemName = "Family plans",
                ToDoItemId = 2
            });
            
            throw new NotImplementedException();
        }

        private static void InitializeTasksLst()
        {
            Tasks.Add(new Tasks
            {
                taskId = 1,
                taskName = "Learning German",
                taskOwner = "Samuel",
                taskDeadline = new DateTime(2022, 8, 8, 19, 30, 0),
                taskStatus = taskStatus.InProgress
            });
            Tasks.Add(new Tasks
            {
                taskId = 2,
                taskName = "Move House",
                taskOwner = "Putiner",
                taskDeadline = new DateTime(2025, 9, 9, 15, 13, 00, 0),
                taskStatus = taskStatus.NotYetStarted
            });

                
            throw new NotImplementedException();
        }

        private static void Add(Tasks tasks)
        {
            throw new NotImplementedException();
        }

        //private static void InitializeToDoItemsLst()
        //{
        //    ToDoItems.Add(new TodoItem
        //    {
        //        taskId = 1,
        //        taskName = "Learning German"
        //    });
        //    ToDoItems.Add(new TodoItem
        //    {
        //        taskId = 2,
        //        taskName = "Move House"
        //    });
        //    throw new NotImplementedException();
        //}
    }
}
  
