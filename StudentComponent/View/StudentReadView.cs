using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent.Data;

namespace StudentComponent.View
{
    public class StudentReadView
    {
        private Students students = null;

        public StudentReadView(Students students)
        {
            this.students = students;
        }

        public void RunReadView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the student you wish to view.");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(StudentOutputText.GetApplicationHeading());

            int index = students.Find(id);

            if (index != -1)
            {
                Student student = students[index];

                Console.WriteLine(StudentOutputText.GetStudentRecordHeading(student));

                Console.WriteLine($"Id: {student.StudentId}");
                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine($"Grade: {student.Grade}");
                Console.WriteLine($"Course: {student.Course}");
                Console.WriteLine($"Gender: {student.Gender}");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please press any key to return to the main view...");
            }
            else
            {
                Console.WriteLine(StudentOutputText.GetStudentNotFoundMessage(id));
            }
            Console.ReadKey();
        }
    }
}