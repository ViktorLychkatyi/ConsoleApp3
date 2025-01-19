namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Student =====
            Student student = new Student();
            //student.Name = "Максим";
            student.SetSurname("Кузьменко");
            student.SetName("Максим");
            student.SetPatronymic("Сергеевич");
            student.SetBirthday("17.02.2000");
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

            // ===== Group (with class Student) =====
            Group group = new Group();
            group.SetGroup("ПИ-1");
            group.SetSpeciality("Прикладная информатика");
            group.SetNumberCourse("1");

            Student student1 = new Student();
            student1.SetFullName("Кузьменко", "Максим", "Александрович", 12);
            group.AddStudent(student1);
            //group.TransferStudent(student1);

            Student student2 = new Student();
            student2.SetFullName("Попова", "Евгения", "Викторивна", 5);
            group.AddStudent(student2);

            Student student3 = new Student();
            student3.SetFullName("Сытник", "Анатолий", "Владимирович", 7);
            group.AddStudent(student3);
            //group.RemoveStudent(student3);

            //group.ExpulsionStudent();
            //group.FailingStudent();

            //group.EditGroup();
            //group.EditSpeciality();
            //group.EditNumberCourse();

            group.ShowGroup();
        }
    }
}
