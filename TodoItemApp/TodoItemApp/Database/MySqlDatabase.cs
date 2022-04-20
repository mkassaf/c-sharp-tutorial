using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TodoItemApp.Model;

namespace TodoItemApp.Database
{
    public class MySqlDatabase : MyDatabase
    {

        private SQLiteAsyncConnection _database;//Mysql instead of SQLite

        public MySqlDatabase(String dbPath)
        {
            Init(dbPath);
        }


        public void Init(String dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<TodoItem>();

        }

        public Task<List<TodoItem>> GetTodoItemsAsync()
        {

            return _database.Table<TodoItem>().ToListAsync();
        }

        public Task InsertTodoIteamAsync(TodoItem todoItem)
        {
            return _database.InsertAsync(todoItem);
        }

        public Task DeleteTodoIteamAsync(TodoItem todoItem)
        {
            return _database.DeleteAsync(todoItem);
        }

        public Task UpdateTodoIteamAsync(TodoItem todoItem)
        {
            return _database.UpdateAsync(todoItem);
        }


        public Task ExecuteAsync(String query)
        {
            return _database.ExecuteAsync(query);
        }
    }
}
