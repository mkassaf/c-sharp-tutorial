using System;
namespace Delegates.Model
{
    public class Student 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }

        public Student(int Id, string Name, float Average)
        {
            this.Id = Id;
            this.Name = Name;
            this.Average = Average;
        }



        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - Average: {this.Average}";
        }

    }
}
