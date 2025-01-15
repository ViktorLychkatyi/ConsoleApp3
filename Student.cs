﻿using System;
using System.Collections.Generic;
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

        // сеттеры
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }

        public void SetBirthday(string birthday)
        {
            this.birthday = birthday;
        }

        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
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

        // конструктор
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
            $"Phone: {phone}";
        }

        public void Print()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Фамилия: {GetSurname()}");
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Отчество: {GetPatronymic()}");
            Console.WriteLine($"Дата рождения: {GetBirthday()}");
            Console.WriteLine($"Адрес: {GetAdress()}");
            Console.WriteLine($"Телефон: {GetPhone()}");
        }
    }
}
