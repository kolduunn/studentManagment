namespace studentManagment
{
//Методы управления студентами.
//Входные данные примерные, напиши свои с клавиатуры:
//var manager = new StudentManager();
//manager.AddStudent(1, "Иван");
//manager.AddGrade(1, 5);
//manager.AddGrade(1, 4);
//Ожидаемый результат:
//Средний балл "Иван": 4.5.
    internal class Program
    {
        static void Main()
        {
            var manager = new StudentManager();
            manager.AddStudent(1, "Иван");
            manager.AddGrade(1, 5);
            manager.AddGrade(1, 4);

            Console.WriteLine($"Средний балл {manager.IdStudentPairs[1]._name}: {manager.GetAverageGrade(1)}");
        }
    }
}
