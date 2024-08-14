using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComponent.Data
{
    public class Student
    {
        private static int nextId = 0;
        private int studentId = 0;

        public int StudentId
        {
            get { return studentId; }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Grade { get; set; }

        public string Course { get; set; }

        public char Gender { get; set; }

        /// <summary>
        /// Auto generation of the IDs
        /// </summary>
        public Student()
        {
            nextId++;
            studentId = nextId;
        }

        public string GetStudentInformation()
        {
            string studentInformation =
                $"{StudentId.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t" +
                $"{LastName.PadRight(15)}\t{Grade.ToString().PadRight(6)}\t" +
                $"{Course.PadRight(15)}\t{Gender.ToString().PadRight(6)}\n";

            return studentInformation;
        }
    }
}