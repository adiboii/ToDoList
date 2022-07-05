using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoList
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }


        public ToDoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem("Water the plants", false));
            ToDoItems.Add(new ToDoItem("Feed the dogs", false));
            ToDoItems.Add(new ToDoItem("Take out the trash", false));
        }

        public string NewToDoInputValue { get; set; }
        public ICommand AddToDoCommand => new Command(AddToDoItem);
        void AddToDoItem()
        {
            ToDoItems.Add(new ToDoItem(NewToDoInputValue, false));
            NewToDoInputValue.Remove(0);
        }

        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);
        void RemoveToDoItem(object o)
        {
            ToDoItem todoItemBeingRemoved = o as ToDoItem;
            ToDoItems.Remove(todoItemBeingRemoved);
        }


    }
}
