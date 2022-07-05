using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace ToDoList
{
    internal class ToDoListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }


        public ToDoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem("Water the plants"));
            ToDoItems.Add(new ToDoItem("Feed the dogs"));
            ToDoItems.Add(new ToDoItem("Take out the trash"));
        }
        public string newToDoInputValue;

        

        public string NewToDoInputValue 
        {
            get{ return newToDoInputValue; }
            set{ newToDoInputValue = value;  OnPropertyChanged(); }
        }

        public ICommand AddToDoCommand => new Command(AddToDoItem);
        void AddToDoItem()
        {
            ToDoItem newTask = new ToDoItem(NewToDoInputValue);
            ToDoItems.Add(newTask);
            NewToDoInputValue = "";
        }

        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);
        void RemoveToDoItem(object o)
        {
            ToDoItem todoItemBeingRemoved = o as ToDoItem;
            ToDoItems.Remove(todoItemBeingRemoved);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
