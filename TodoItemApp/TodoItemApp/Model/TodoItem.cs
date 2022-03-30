using System;
namespace TodoItemApp.Model
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string TodoText { get; set; }
        public bool Complete { get; set; }
    }
}
