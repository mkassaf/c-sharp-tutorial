using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TodoItemApp.Model;

namespace TodoItemApp.Database
{
    public interface MyDatabase
    {

        public void Init(String dbPath);

        public Task<List<TodoItem>> GetTodoItemsAsync();

        public Task InsertTodoIteamAsync(TodoItem todoItem);

        public Task DeleteTodoIteamAsync(TodoItem todoItem);

        public Task UpdateTodoIteamAsync(TodoItem todoItem);

        public Task ExecuteAsync(String query);
    }
}
