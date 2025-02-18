using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagment
{
    // StudentManager:
    // Dictionary<int, Student> (ключ – ID студента).
    // Методы:
    // AddStudent(int id, string name) : Добавить студента.
    // AddGrade(int studentId, int grade): Добавить оценку.
    // GetAverageGrade(int studentId): Получить среднюю оценку.
    // GetBestStudent(): Найти студента с наивысшей средней оценкой.
    internal class StudentManager
    {
        public Dictionary<int, Student> IdStudentPairs = new Dictionary<int, Student>();
        public void AddStudent(int id, string name)
        {
            Student student = new Student(id, name);
            IdStudentPairs.Add(id, student);
        }

        public void AddGrade(int studentId, int grade)
        {
            IdStudentPairs[studentId]._gradeList.Add(grade);
        }

        public double GetAverageGrade(int studentId)
        {
            int gradeAmount = IdStudentPairs[studentId]._gradeList.Count;
            double gradeSum = 0;

            for (int i = 0; i < gradeAmount; i++)
            {
                gradeSum += IdStudentPairs[studentId]._gradeList[i];
            }

            double averageGrade = gradeSum / gradeAmount;

            return averageGrade;
        }

        public Student GetBestStudent()
        {
            Dictionary<int, double> IdAverageGradePairs = new Dictionary<int, double>();

            foreach (Student student in IdStudentPairs.Values)
            {
                int studentId = student._id;
                double averageGrade = GetAverageGrade(studentId);
                IdAverageGradePairs.Add(studentId, averageGrade);
            }

            double bestAverageGrade = 0;
            int bestStudentId = 0;

            foreach (Student student in IdStudentPairs.Values)
            {
                if (IdAverageGradePairs[student._id] >= bestAverageGrade)
                {
                    bestAverageGrade = IdAverageGradePairs[student._id];
                    bestStudentId = student._id;
                }
            }

            return IdStudentPairs[bestStudentId];
        }

    }
}
