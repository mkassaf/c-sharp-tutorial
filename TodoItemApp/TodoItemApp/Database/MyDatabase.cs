using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TodoItemApp.Model;

namespace TodoItemApp.Database
{
    public interface MyDatabase
    {

        void Init(String dbPath);

        Task<List<TodoItem>> GetTodoItemsAsync();

        Task InsertTodoIteamAsync(TodoItem todoItem);

        Task DeleteTodoIteamAsync(TodoItem todoItem);

        Task UpdateTodoIteamAsync(TodoItem todoItem);

        Task ExecuteAsync(String query);
    }
}
