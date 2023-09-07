using System.ComponentModel.Design.Serialization;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students would you like to add?");
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)  /*i++ means add 1 to i each time*/
            {
                Student student = new Student();

                Console.WriteLine("Please enter student's first name.");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter student's last name.");
                student.LastName = Console.ReadLine();
                Console.WriteLine("Please enter student's gender.");
                student.Gender = Console.ReadLine();
                Console.WriteLine("Please assign the student's ID.");
                int.TryParse(Console.ReadLine(), out int result);
                student.StudentID = result;
                Console.WriteLine("Please enter student's GPA.");
                decimal.TryParse(Console.ReadLine(), out decimal gpa);
                student.GPA = gpa;
                Console.WriteLine("Please enter student's Major.");
                student.Major = Console.ReadLine();

                studentsList.Add(student);
            }
            foreach (var student in studentsList)
            {
                Console.WriteLine($"Student's first name is: {student.FirstName}\n" +
                                  $"Student's last name is:  {student.LastName}\n" +
                                  $"Student's Gender is:     {student.Gender}\n" +
                                  $"Student's StudentID is:  {student.StudentID}\n" +
                                  $"Student's Major is:      {student.Major}\n");
            }

        }
    }
}