using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoItemApp.Model;

namespace TodoItemApp.Database
{
    public class DatabaseTwo : MyDatabase
    {
        public DatabaseTwo()
        {
        }

        public Task DeleteTodoIteamAsync(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> GetTodoItemsAsync()
        {
            throw new NotImplementedException();
        }

        public void Init(string dbPath)
        {
            throw new NotImplementedException();
        }

        public Task InsertTodoIteamAsync(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodoIteamAsync(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }
    }
}
