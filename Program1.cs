using System;

namespace _2pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Ліза", 19, 2, 40);

            Console.WriteLine($"Студент: {stud.Name}, Вік: {stud.Age}, Курс: {stud.Course}, Рейтинг: {stud.Rating}");
            Console.WriteLine($"Ступінь: {stud.GetRole(stud.Course)}");
            stud.StudentRating();

            stud.EditStudent("Єлизавета", 20, 93);
            Console.WriteLine("\nВідредагована інформація:");
            Console.WriteLine($"Студент: {stud.Name}, Вік: {stud.Age}, Курс: {stud.Course}, Рейтинг: {stud.Rating}");
            Console.WriteLine($"Ступінь: {stud.GetRole(stud.Course)}");
            stud.StudentRating();

            Console.ReadLine();
        }
    }
}
