using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent;
using StudentComponent.Data;
using StudentComponent.View;

namespace StudentCRUDApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApplication = false;

            Students students = new Students();

            StudentRecordsView studentRecordsView = StudentObjectFactory.StudentRecordsView(students);

            while (!endApplication)
            {
                Console.Clear();

                Console.WriteLine(StudentOutputText.GetApplicationHeading());

                studentRecordsView.RunRecordsView();

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(StudentOutputText.GetInstructions());

                ConsoleKey instructionKey = Console.ReadKey().Key;

                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        StudentCreateView studentCreateView = StudentObjectFactory.StudentCreateViewObject(students);
                        studentCreateView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        StudentReadView studentReadView = StudentObjectFactory.StudentReadViewObject(students);
                        studentReadView.RunReadView();
                        break;
                    case ConsoleKey.U:
                        StudentUpdateView studentUpdateView = StudentObjectFactory.StudentUpdateViewObject(students);
                        studentUpdateView.RunUpdateView();
                        break;
                    case ConsoleKey.D:
                        StudentDeleteView studentDeleteView = StudentObjectFactory.StudentDeleteViewObject(students);
                        studentDeleteView.RunDeleteView();
                        break;
                    default:
                        endApplication = true;
                        break;
                }
            }

        }
    }
}