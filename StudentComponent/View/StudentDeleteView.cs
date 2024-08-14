using StudentComponent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComponent.View
{
    public class StudentDeleteView
    {
        private Students students;

        public StudentDeleteView(Students students)
        {
            this.students = students;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Id of the student you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = students.Find(id);

            if (index != -1)
            {
                Student student = students[index];

                Console.WriteLine($"Are you sure you wish to delete student with Id({student.StudentId})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    students.Delete(index);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(StudentOutputText.GetApplicationHeading());
                Console.WriteLine(StudentOutputText.GetStudentNotFoundMessage(id));
                Console.ReadKey();
            }
        }
    }
}
