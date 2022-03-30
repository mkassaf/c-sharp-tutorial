using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoItemApp.Model;

namespace TodoItemApp
{
    public class TodoListViewModel
    {

        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            TodoItems.Add(new TodoItem(){
                Id = 1,
                Complete = false,
                TodoText = "Hello"
            });
        }

        public string NewTodoInputValue { get; set; }
        public ICommand AddTodoCommand => new Command(AddTodoIteam);

        private async void AddTodoIteam()
        {
            if (String.IsNullOrEmpty(NewTodoInputValue))
            {
                Console.WriteLine("Invalid data");
                return;
            }
            Console.WriteLine($" a new Value {NewTodoInputValue}");
            TodoItem newTodoItem = new TodoItem
            {
                TodoText = NewTodoInputValue,
                Complete = false
            };

            TodoItems.Add(newTodoItem);
            NewTodoInputValue = String.Empty;
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        private async void RemoveTodoItem(object o)
        {

            Console.WriteLine($" a new Value {NewTodoInputValue}");
            TodoItem newTodoIteam = o as TodoItem;
            
            TodoItems.Remove(newTodoIteam);
        }

    }

    
}
