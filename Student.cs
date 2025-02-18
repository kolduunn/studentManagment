using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagment
{
    // Student: ID, Имя, Список оценок (List<int>).
    internal class Student
    {
        public int _id;
        public string _name;
        public List<int> _gradeList = new List<int>();

        public Student(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
