using static System.Console;
namespace Ex_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;
            StudentGroup group = new();

            WriteLine("Добавление студентов в группу:");

            for (int i = 0; i < 3; i++)
            {
                Write("Введите имя студента: ");
                string firstName = ReadLine();

                Write("Введите фамилию студента: ");
                string lastName = ReadLine();

                Write("Введите дату рождения студента (в формате ГГГГ-ММ-ДД): ");
                DateTime birthDate = DateTime.Parse(ReadLine());

                Student student = new(firstName, lastName, birthDate);
                group.AddStudent(student);
            }

            group.DisplayAllStudents();

            Write("Введите фамилию студента для поиска: ");
            string searchLastName = ReadLine();
            Student foundStudent = group.FindStudentByLastName(searchLastName);

            if (foundStudent != null)
            {
                WriteLine($"Найден студент: {foundStudent}");
            }
            else
            {
                WriteLine($"Студент с фамилией {searchLastName} не найден.");
            }

            Write("Введите фамилию студента для удаления: ");
            string removeLastName = ReadLine();
            if (group.RemoveStudent(removeLastName))
            {
                WriteLine($"Студент с фамилией {removeLastName} удален из группы.");
            }
            else
            {
                WriteLine($"Студент с фамилией {removeLastName} не найден.");
            }

            WriteLine("Обновленный список студентов:");
            group.DisplayAllStudents();

            group.SortStudentsByLastName();
            WriteLine("Список студентов после сортировки по фамилии:");
            group.DisplayAllStudents();

            Write("Введите индекс студента для доступа: ");
            int studentIndex = int.Parse(ReadLine());
            Student accessedStudent = group.GetStudentByIndex(studentIndex);

            if (accessedStudent != null)
            {
                WriteLine($"Студент по индексу {studentIndex}: {accessedStudent}");
            }
            else
            {
                WriteLine($"Студент с индексом {studentIndex} не найден.");
            }
        }
    }
}
