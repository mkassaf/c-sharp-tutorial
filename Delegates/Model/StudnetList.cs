using System;
using System.Collections.Generic;

namespace Delegates.Model
{
    public class StudnetList
    {
        private List<Student> students = null;



        public delegate void PrintDelagate();

        public event PrintDelagate Print ;


        public delegate void StudentDelegate(Student student);


        public event StudentDelegate OnAdd;
        public event StudentDelegate OnRemove;


        public StudnetList()
        {
            students = new List<Student>();
        }

        public void Add(Student student)
        {
            students.Add(student);
            if(OnAdd != null)
            {
                OnAdd(student);
            }
            

        }
        public Student GetItem(int index)
        {
            if (students.Count == 0)
            {
                throw new Exception("The list is empty!.");
            }
            else if (index >= students.Count)
            {
                throw new Exception($"index[ {index} ] out of bound exception. List size is {students.Count}");
            }
            Student student = students[index];
            return student;
        }

        public void RemoveAt(int index)
        {
            if (students.Count == 0)
            {
                throw new Exception("The list is empty!.");
            }
            else if (index >= students.Count)
            {
                throw new Exception($"index[ {index} ] out of bound exception. List size is {students.Count}");
            }


            if(OnRemove != null)
            {
                Student student = students[index];
                OnRemove(student);
            }

            students.RemoveAt(index);
        }

    }
}
