namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student
            Student student = new Student();
            student.SetSurname("Овчаренко");
            student.SetName("Максин");
            student.SetPatronymic("Сергеевич");
            student.SetBirthday("02.01.2006");
            student.SetAdress("г. Харьков, ул. Халтурина, д. 10, кв. 5");
            student.SetPhone("380 75 345 689");
            Console.WriteLine(student);

            List<int> zachet = new List<int>();
            zachet.Add(12);
            zachet.Add(12);
            zachet.Add(12);
            zachet.Add(12);

            Console.WriteLine("\nЗачеты:");
            foreach (int z in zachet)
            {
                Console.WriteLine(z);
            }

            List<int> exams = new List<int>();
            exams.Add(12);
            exams.Add(12);
            exams.Add(12);
            exams.Add(12);

            Console.WriteLine("\nЭкзамены:");
            foreach (int e in exams)
            {
                Console.WriteLine(e);
            }

            List<int> course_works = new List<int>();
            course_works.Add(12);
            course_works.Add(12);
            course_works.Add(12);
            course_works.Add(12);

            Console.WriteLine("\nКурсовые работы:");
            foreach (int cw in course_works)
            {
                Console.WriteLine(cw);
            }
        }
    }
}
