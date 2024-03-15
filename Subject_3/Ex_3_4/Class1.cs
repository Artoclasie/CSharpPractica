using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_4
{
    class StudentGroup
    {
        private List<Student> students;

        public StudentGroup()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool RemoveStudent(string lastName)
        {
            Student studentToRemove = students.Find(s => s.LastName == lastName);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                return true;
            }
            return false;
        }

        public Student FindStudentByLastName(string lastName)
        {
            return students.Find(s => s.LastName == lastName);
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("Студенты в группе:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void SortStudentsByLastName()
        {
            students.Sort((s1, s2) => s1.LastName.CompareTo(s2.LastName));
        }

        public Student GetStudentByIndex(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                return students[index];
            }
            return null;
        }
    }
}
