using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToDoList
{
    internal class ToDoItem
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }
        public ToDoItem(string TodoText)
        {
            this.TodoText = TodoText;
            this.Complete = false;
        }

    }
}
