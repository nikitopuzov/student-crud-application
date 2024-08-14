using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent.Data;

namespace StudentComponent
{
    public static class StudentOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "Id";
            string firstName = "First Name";
            string lastName = "Last Name";
            string grade = "Grade";
            string course = "Course";
            string gender = "Gender";

            string heading = $"{id.PadRight(6)}\t{firstName.PadRight(15)}\t{lastName.PadRight(15)}\t{grade.PadRight(6)}\t{course.PadRight(15)}\t{gender.PadRight(6)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 6)}\n";

            return heading;
        }

        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length);
        }

        public static string GetApplicationHeading()
        {
            string heading = "Student CRUD Application\n";

            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetInstructions()
        {
            return $"[C] Create\n[R] Read\n[U] Update\n[D] Delete\nPress any other key to end session.";
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Student\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetStudentNotFoundMessage(int id)
        {
            return $"Could not find student with Id({id}). Please press any key to return to the main view...";
        }

        public static string GetStudentRecordHeading(Student student)
        {
            string heading = $"Student Details for {student.FirstName} {student.LastName} Id: {student.StudentId}\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateHeading(Student student)
        {
            string heading = $"Update Student Details for {student.FirstName} {student.LastName} Id: {student.StudentId}\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }
    }
}