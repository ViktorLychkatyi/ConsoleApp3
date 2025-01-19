using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        // поля класса
        private List<Student> students;
        private string group_name;
        private string speciality;
        private string number_course;

        // свойства 
        public List<Student> Students { get; set; }
        public string GroupName { get; set; }
        public string Speciality { get; set; }
        public int NumberCourse { get; set; }

        public Group()
        {
            students = new List<Student>();
        }
        
        // сеттеры
        public void SetGroup(string group_name)
        {
            this.group_name = group_name;
        }

        public void SetSpeciality(string speciality)
        {
            this.speciality = speciality;
            try
            {
                if (speciality == "" || speciality == null || speciality.StartsWith(" ") || speciality.EndsWith(" "))
                {
                    throw new Exception("Поле специальности не может быть пустым");
                }
                else if (speciality.Any(char.IsDigit))
                {
                    throw new Exception("Поле специальности не может состоять из цифр");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetNumberCourse(string number_course)
        {
            this.number_course = number_course;
            try
            {
                if (number_course == "" || number_course == null || number_course.StartsWith(" ") || number_course.EndsWith(" "))
                {
                    throw new Exception("Поле специальности не может быть пустым");
                }
                else if (speciality.Any(char.IsDigit))
                {
                    throw new Exception("Поле специальности не может состоять из цифр");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // геттеры
        public string GetGroup()
        {
            return group_name;
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
            Console.WriteLine($"\nГруппа: {group_name}, Специализация: {speciality}, Курс: {number_course}");
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
