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
            student.SetPhone("380 75 345 689\n");
            Console.WriteLine(student);

            //Student student2 = new Student();
            ////student.Name = "Максим";
            //student2.SetSurname("Попова");
            //student2.SetName("Евгения");
            //student2.SetPatronymic("Викторивна");
            //student2.SetBirthday("17.02.2000");
            //student2.SetAdress("г. Харьков, ул. Халтурина, д. 10, кв. 5");
            //student2.SetPhone("380 75 345 689\n");
            //Console.WriteLine(student2);

            student.zachet = new List<int>();
            student.zachet.Add(8);
            student.zachet.Add(11);
            student.zachet.Add(12);
            student.zachet.Add(8);
            student.AverageZachet(student);

            student.exams = new List<int>();
            student.exams.Add(8);
            student.exams.Add(11);
            student.exams.Add(12);
            student.exams.Add(8);
            student.AverageExams(student);

            student.courses_works = new List<int>();
            student.courses_works.Add(8);
            student.courses_works.Add(11);
            student.courses_works.Add(12);
            student.courses_works.Add(8);
            student.AverageCoursesWorks(student);

            // ===== Group (with class Student) =====
            Group group = new Group();
            group.SetGroup("ПИ-1");
            group.SetSpeciality("Прикладная информатика");
            group.SetNumberCourse("1");

            student.SetFullName(student.GetSurname(), student.GetName(), student.GetPatronymic());
            group.AddStudent(student);
            //group.TransferStudent(student);

            //student2.SetFullName(student2.GetSurname(), student2.GetName(), student2.GetPatronymic());
            //group.AddStudent(student2);

            //Student student3 = new Student();
            //student3.SetFullName("Сытник", "Анатолий", "Владимирович");
            //group.AddStudent(student3);
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
