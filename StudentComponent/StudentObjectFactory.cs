using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentComponent.Data;
using StudentComponent.View;


namespace StudentComponent
{
    public static class StudentObjectFactory
    {
        private static StudentCreateView studentCreateView = null;
        private static StudentReadView studentReadView = null;
        private static StudentUpdateView studentUpdateView = null;
        private static StudentDeleteView studentDeleteView = null;

        public static Student CreateNewStudentObject(string firstName, string lastName, decimal grade, string course, char gender)
        {
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Grade = grade,
                Course = course,
                Gender = gender
            };
        }

        public static StudentRecordsView StudentRecordsView(Students students)
        {
            return new StudentRecordsView(students);
        }

        /// <summary>
        /// lazy-loading
        /// </summary>
        /// <returns></returns>
        public static StudentCreateView StudentCreateViewObject(Students students)
        {
            if (studentCreateView == null)
            {
                studentCreateView = new StudentCreateView(students);
            }

            return studentCreateView;
        }

        public static StudentReadView StudentReadViewObject(Students students)
        {
            if (studentReadView == null)
            {
                studentReadView = new StudentReadView(students);
            }

            return studentReadView;
        }

        public static StudentUpdateView StudentUpdateViewObject(Students students)
        {
            if (studentUpdateView == null)
            {
                studentUpdateView = new StudentUpdateView(students);
            }

            return studentUpdateView;
        }

        public static StudentDeleteView StudentDeleteViewObject(Students students)
        {
            if (studentDeleteView == null)
            {
                studentDeleteView = new StudentDeleteView(students);
            }

            return studentDeleteView;
        }
    }
}