using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent.Data;

namespace StudentComponent.View
{
    public class StudentCreateView
    {
        private Students students;

        public StudentCreateView(Students students)
        {
            this.students = students;
        }

        public void RunCreateView()
        {
            string firstName = null;
            string lastName = null;
            decimal grade = 0.0m;
            string course = null;
            char gender = '\0';

            Console.Clear();

            Console.WriteLine(StudentOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(StudentOutputText.GetCreateHeading());

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Grade: ");
            grade = decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            Console.Write("Course: ");
            course = Console.ReadLine();

            Console.Write("Gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please press [S] key to save the new student to the system or any other key to cancel.");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                students.AddStudent(StudentObjectFactory.CreateNewStudentObject(firstName, lastName, grade, course, gender));
            }

        }
    }
}