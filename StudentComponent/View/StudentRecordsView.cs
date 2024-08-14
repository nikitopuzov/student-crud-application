using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using StudentComponent.Data;

namespace StudentComponent.View
{
    public class StudentRecordsView
    {
        /// <summary>
        /// private member variable to store the students collection
        /// </summary>
        private Students students = null;

        /// <summary>
        /// assign the students private variable with the students collection
        /// </summary>
        public StudentRecordsView(Students students)
        {
            this.students = students;
        }

        /// <summary>
        /// presenting the students collection to the console screen in a tabular format
        /// </summary> 
        public void RunRecordsView()
        {
            Console.WriteLine(StudentOutputText.GetColumnHeadings());
            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetStudentInformation());
            }
        }
    }
}