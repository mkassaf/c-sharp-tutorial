using System;
using System.Collections.Generic;

namespace Generic
{
    public enum BookCategory { NA, HISTORY, SCIENCE,PROGRAMING, STORY, RELIGION }
    public class Book
    {
        private int _id;
        private string _name;
        private List<string> _author;
        private BookCategory _category;
        public BookCategory Category
        {
            get
            {
                if (_category == null)
                {
                    return BookCategory.NA;
                }
                return _category;

            }
            set
            {
                this._category = value;
            }
        }

        public List<string> GetAuthor()
        {
            return _author;
        }
        public void AddAuthor(string auther)
        {
            _author.Add(auther);
        }
        public bool RemoveAuthor(string auther)
        {
            return _author.Remove(auther);
        }

        public Book()
        {
            _author = new List<string>();
        }
        public Book(int id, string name): this()
        {
            this._id = id;
            this._name = name;
        }


        public override string ToString()
        {
            String authersNames = String.Empty;
            foreach (string auther in _author)
            {
                authersNames += auther + ",";
            }
            authersNames = authersNames.Remove(authersNames.Length-1);
            return $"Id: {_id}, Book name: {_name}, Category: {this._category}, Authers: {authersNames}";
        }

    }
}
