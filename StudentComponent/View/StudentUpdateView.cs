using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent.Data;

namespace StudentComponent.View
{
    public class StudentUpdateView
    {
        private Students students = null;

        public StudentUpdateView(Students students)
        {
            this.students = students;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the Id of the student you wish to edit.");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(StudentOutputText.GetApplicationHeading());

            int index = students.Find(id);

            if (index != -1)
            {
                string firstName = null;
                string lastName = null;
                string grade = null;
                string course = null;
                string gender = null;

                Student student = students[index];

                Console.WriteLine(StudentOutputText.GetUpdateHeading(student));

                Console.WriteLine(StudentOutputText.GetUpdateViewAdditionalInstructions());

                Console.Write($"First Name ({student.FirstName}): ");
                firstName = Console.ReadLine();

                Console.Write($"Last Name ({student.LastName}): ");
                lastName = Console.ReadLine();

                Console.Write($"Grade ({student.Grade}): ");
                grade = Console.ReadLine();

                Console.Write($"Course ({student.Course}): ");
                course = Console.ReadLine();

                Console.Write($"Gender ({student.Gender}): ");
                gender = Console.ReadLine();

                students.Update(student,
                    (String.IsNullOrWhiteSpace(firstName) ? student.FirstName : firstName),
                    (String.IsNullOrWhiteSpace(lastName) ? student.LastName : lastName),
                    (String.IsNullOrWhiteSpace(grade) ? student.Grade : Decimal.Parse(grade)),
                    (String.IsNullOrWhiteSpace(course) ? student.Course : course),
                    (String.IsNullOrWhiteSpace(gender) ? student.Gender : Convert.ToChar(gender))
                );
            }
            else
            {
                Console.WriteLine(StudentOutputText.GetStudentNotFoundMessage(id));
                Console.ReadKey();
            }
        }
    }
}