using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        private List<Student> students;
        private string group;
        private string speciality;
        private string number_course;

        public Group()
        {
            students = new List<Student>();
        }
        
        // сеттеры
        public void SetGroup(string group)
        {
            this.group = group;
        }

        public void SetSpeciality(string speciality)
        {
            this.speciality = speciality;
        }

        public void SetNumberCourse(string number_course)
        {
            this.number_course = number_course;
        }

        // геттеры
        public string GetGroup()
        {
            return group;
        }

        public string GetSpeciality()
        {
            return speciality;
        }

        public int GetAverageMark()
        {
            int sum = 0;
            foreach (var student in students)
            {
                sum += student.GetAverageMark();
            }
            return sum / students.Count;
        }

        // методы

        // показ всех студентов в группе
        public void ShowGroup()
        {
            int number;
            Console.WriteLine($"\nГруппа: {group}, Специализация: {speciality}, Курс: {number_course}");
            Console.WriteLine("\nСписок студентов:");
            foreach (var student in students)
            {
                number = students.IndexOf(student) + 1;
                Console.WriteLine(number + ". " + student.GetFullName());
            }
            students.Sort((a, b) => a.GetFullName().CompareTo(b.GetFullName()));
        }

        // действия с студентами и группой
        public void AddStudent(Student student)
        {
            students.Add(student);
            //Console.WriteLine($"Студент {student.GetFullName()} добавлен");
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            //Console.WriteLine($"Студент {student.GetFullName()} удалён");
        }

        public void TransferStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine($"Студент {student.GetFullName()} переведён в группу");
        }

        public void EditStudent(Student student)
        {
            student.SetSurname("Ильгова");
            student.SetName("Анна");
            student.SetPatronymic("Владимировна");
            student.SetAverageMark(10);
        }

        public void EditGroup()
        {
            SetGroup("ПИ-6");
        }

        public void EditSpeciality()
        {
            SetSpeciality("Высшая математика");
        }

        public void EditNumberCourse()
        {
            SetNumberCourse("6");
        }

        public void ExpulsionStudent()
        {
            for (int i = students.Count - 1; i >= 0; i--)
            {
                var student = students[i];

                if (student.GetAverageMark() < 7)
                {
                    students.RemoveAt(i);
                    Console.WriteLine($"Студент {student.GetFullName()} отчислен");
                }
                else if (student.GetAverageMark() > 12)
                {
                    Console.WriteLine($"Студент {student.GetFullName()} недопустимое значение");
                }
                else
                {
                    Console.WriteLine($"Студент {student.GetFullName()} остаётся в группе");
                }
            }
        }

        public void FailingStudent()
        {
            int min_mark = int.MaxValue;
            foreach (var student in students)
            {
                int average_mark = student.GetAverageMark();
                if (average_mark < min_mark)
                {
                    min_mark = average_mark;
                }
            }

            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].GetAverageMark() == min_mark)
                {
                    Console.WriteLine($"Студент {students[i].GetFullName()} не успевающий и отчислен");
                    students.RemoveAt(i);
                }
            }
        }
    }
}
