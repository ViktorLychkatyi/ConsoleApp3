using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        // поля класса
        private string surname;
        private string name;
        private string patronymic;
        private string birthday;
        private string adress;
        private string phone;

        public List<int> zachet;
        public List<int> exams;
        public List<int> courses_works;

        // свойства 
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int AverageMark { get; set; }

        // сеттеры
        public void SetSurname(string surname)
        {
            this.surname = surname;
            try
            {
                if (surname == "" || surname == null || surname.StartsWith(" ") || surname.EndsWith(" "))
                {
                    throw new Exception("Поле фамилии не может быть пустым");
                }
                else if (surname.Any(char.IsDigit))
                {
                    throw new Exception("Поле фамилии не может состоять из цифр");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetName(string name)
        {
            this.name = name;
            try
            {
                if (name == "" || name == null || name.StartsWith(" ") || name.EndsWith(" "))
                {
                    throw new Exception("Поле имени не может быть пустым");
                }
                else if (name.Any(char.IsDigit))
                {
                    throw new Exception("Поле имени не может состоять из цифр");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
            try
            {
                if (patronymic == "" || patronymic == null || patronymic.StartsWith(" ") || patronymic.EndsWith(" "))
                {
                    throw new Exception("Поле отчества не может быть пустым");
                }
                else if (patronymic.Any(char.IsDigit))
                {
                    throw new Exception("Поле отчества не может состоять из цифр");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetBirthday(string birthday)
        {
            this.birthday = birthday;
            try
            {
                if (birthday == "" || birthday == null || birthday.StartsWith(" ") || birthday.EndsWith(" "))
                {
                    throw new Exception("Поле даты рождения не может быть пустым");
                }
                else if (birthday.Any(char.IsLetter))
                {
                    throw new Exception("Поле даты рождения не может состоять из букв");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetAdress(string adress)
        {
            this.adress = adress;
            try
            {
                if (adress == "" || adress == null || adress.StartsWith(" ") || adress.EndsWith(" "))
                {
                    throw new Exception("Поле адрес проживания не может быть пустым");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
            try
            {
                if (phone == "" || phone == null || phone.StartsWith(" ") || phone.EndsWith(" "))
                {
                    throw new Exception("Поле номер телефона не может быть пустым");
                }
                else if (phone.Any(char.IsLetter))
                {
                    throw new Exception("Поле номер телефона не может состоять из букв");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // геттеры
        public string GetSurname()
        {
            return surname;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPatronymic()
        {
            return patronymic;
        }

        public string GetBirthday()
        {
            return birthday;
        }

        public string GetAdress()
        {
            return adress;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetFullName(string surname, string name, string patronymic)
        {
            SetSurname(surname);
            SetName(name);
            SetPatronymic(patronymic);
        }

        public string GetFullName()
        {
            return $"{surname} {name} {patronymic}";
        }

        // конструкторы
        public Student(string surname, string name, string patronymic, string birhday, string adress, string phone)
        {
            SetSurname(surname);
            SetName(name);
            SetPatronymic(patronymic);
            SetBirthday(birhday);
            SetAdress(adress);
            SetPhone(phone);
        }

        public Student() : this("Кузьменко", "Анатолий", "Иванович", "01.07.1995", "г. Харьков, ул. Халтурина 10, кв. 5", "380 75 345 689")
        {
        }

        public override string ToString()
        {
            return
            $"Фамилия: {surname}\n" +
            $"Имя: {name}\n" +
            $"Отчество: {patronymic}\n" +
            $"Дата рождения: {birthday}\n" +
            $"Домащний адрес: {adress}\n" +
            $"Телефонный номер: {phone}";
        }

        // подсчеты средних оценок
        public double AverageZachet(Student student)
        {
            double average_zachet = student.zachet.Average();
            SetFullName(GetSurname(), GetName(), GetPatronymic());
            Console.WriteLine(GetFullName());
            Console.WriteLine("Зачеты. Оценки: ");
            foreach (int z in student.zachet)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine("Зачеты. Средний балл: " + average_zachet + "\n");
            return average_zachet;
        }

        public double AverageExams(Student student)
        {
            double average_exams = student.exams.Average();
            SetFullName(GetSurname(), GetName(), GetPatronymic());
            Console.WriteLine(GetFullName());
            Console.WriteLine("Экзамены. Оценки: ");
            foreach (int e in student.exams)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Экзамены. Средний балл: " + average_exams + "\n");
            return average_exams;
        }

        public double AverageCoursesWorks(Student student)
        {
            double average_courses_works = student.courses_works.Average();
            SetFullName(GetSurname(), GetName(), GetPatronymic());
            Console.WriteLine(GetFullName());
            Console.WriteLine("Экзамены. Оценки: ");
            foreach (int c in student.courses_works)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Курсовые работы. Средний балл: " + average_courses_works + "\n");
            return average_courses_works;
        }

        public double ResultAverageMark(Student student)
        {
            double result_average_mark = (AverageZachet(student) + AverageExams(student) + AverageCoursesWorks(student)) / 3;
            Console.WriteLine("\nОбщий средний балл за предмет: " + result_average_mark + "\n");
            return result_average_mark;
        }


        // перегрузка операции

        //public static Student operator == (Student student)
        //{
        //    if (student.SetAverageMark(5) == student.SetAverageMark(12))
        //    {
        //        return student;
        //    }
    }
}
