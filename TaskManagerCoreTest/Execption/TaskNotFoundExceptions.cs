﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCoreTest.Execption
{
    class TaskNotFoundExceptions : TaskManagerExceptions
    {
        public string Messages = "Task Not Found in Tasks List";


        public TaskNotFoundExceptions() { }

        public TaskNotFoundExceptions(string message)
        {
            Messages = message;
        }
    }
    
}
