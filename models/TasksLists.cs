﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient.models
{
    class TasksList
    {
        public int ToDoItemId { get; set; }
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskOwner { get; set; }
        public DateTime taskDeadline { get; set; }
        public enum taskStatus
        {
            NotYetStarted,
            InProgress,
            Completed,
            Archived
        }
    }
}
