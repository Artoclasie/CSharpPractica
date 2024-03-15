using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class StudentGroup
{
    public List<Student> students = new List<Student>();

    public void AddStudent(Student newStudent)
    {
        students.Add(newStudent);
    }

    public void RemoveStudent(string lastName)
    {
        students.RemoveAll(s => s.LastName == lastName);
    }

    public Student FindStudentByLastName(string lastName)
    {
        return students.Find(s => s.LastName == lastName);
    }

    public void SortByFirstName()
    {
        students.Sort((s1, s2) => string.Compare(s1.FirstName, s2.FirstName));
    }

    public void SortByLastName()
    {
        students.Sort((s1, s2) => string.Compare(s1.LastName, s2.LastName));
    }

    public void SortByDateOfBirth()
    {
        students.Sort((s1, s2) => DateTime.Compare(s1.DateOfBirth, s2.DateOfBirth));
    }

    public Student GetStudentAt(int index)
    {
        if (index >= 0 && index < students.Count)
        {
            return students[index];
        }
        else
        {
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentGroup group = new StudentGroup();

        // Добавление студентов
        group.AddStudent(new Student { FirstName = "Иван", LastName = "Иванов", DateOfBirth = new DateTime(2000, 5, 10) });
        group.AddStudent(new Student { FirstName = "Петр", LastName = "Петров", DateOfBirth = new DateTime(2001, 8, 15) });

        // Поиск студента по фамилии
        Student foundStudent = group.FindStudentByLastName("Петров");
        if (foundStudent != null)
        {
            Console.WriteLine("Найден студент: " + foundStudent.FirstName + " " + foundStudent.LastName);
        }
        else
        {
            Console.WriteLine("Студент не найден");
        }

        // Удаление студента
        group.RemoveStudent("Иванов");

        // Сортировка по фамилии
        group.SortByLastName();

        // Вывод всех студентов
        for (int i = 0; i < group.students.Count; i++)
        {
            Student student = group.GetStudentAt(i);
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}