using SQLite;
namespace TodoItemApp.Model
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string TodoText { get; set; }
        public bool Complete { get; set; }
    }
}
