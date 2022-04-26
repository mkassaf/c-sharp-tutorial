using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoItemApp.Model;
using Firebase.Database;
using Firebase.Database.Streaming;
using Firebase.Database.Query;
using System.Linq;

namespace TodoItemApp
{
    public class TodoListViewModel
    {

        FirebaseClient firebaseClient = new FirebaseClient("https://tododatabase-4449e-default-rtdb.europe-west1.firebasedatabase.app/2");
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public static readonly string TableName = "TodoItem";

        public static bool firstRun = false;
        public  TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            try
            {
                /*
                var result = App.Database.GetTodoItemsAsync();
                result.Wait();

                var currentTodoItems = result.GetAwaiter().GetResult();

                foreach (TodoItem todoItem in currentTodoItems)
                {
                    Console.WriteLine(todoItem.TodoText);
                    TodoItems.Add(todoItem);
                }
                */
                var collection2 = firebaseClient.Child(TableName).AsObservable<TodoItem>().AsObservableCollection<TodoItem>();

                Console.WriteLine($"collection2 {collection2}");

                var collection = firebaseClient.Child(TableName).AsObservable<TodoItem>().Subscribe((dbevent) =>
                {
                    if (dbevent.Object != null)
                    {
                        
                        
                        if (dbevent.EventType.Equals(FirebaseEventType.InsertOrUpdate))
                        {
                            if (!TodoItems.Contains(dbevent.Object))
                            {
                                TodoItems.Add(dbevent.Object);
                            }
                            
                        }

                        
                    }
                });

                
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string NewTodoInputValue { get; set; }
        public ICommand AddTodoCommand => new Command(AddTodoIteam);

        private void AddTodoIteam()
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

            //TodoItems.Add(newTodoItem);
            firebaseClient.Child(TableName).PostAsync(newTodoItem);
            App.Database.InsertTodoIteamAsync(newTodoItem);
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);

        

        private async void RemoveTodoItem(object o)
        {

            try
            {
                TodoItem deletedTodoIteam = o as TodoItem;

                TodoItems.Remove(deletedTodoIteam);
                //App.Database.DeleteTodoIteamAsync(deletedTodoIteam);

                var toDeletePerson = (await firebaseClient
                .Child(TableName)
                .OnceAsync<TodoItem>()).Where(a => a.Object.Id == deletedTodoIteam.Id).FirstOrDefault();

                Console.WriteLine(toDeletePerson.Key);
                Console.WriteLine(toDeletePerson.Object.Id);

                await firebaseClient.Child(TableName).Child(toDeletePerson.Key).DeleteAsync();

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

    
}
