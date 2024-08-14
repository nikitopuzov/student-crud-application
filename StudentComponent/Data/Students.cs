using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComponent.Data
{
    public class Students
    {
        List<Student> studentList = null;

        public Students()
        {
            studentList = new List<Student>();
            SeedData();
        }

        public Student this[int index]
        {
            get
            {
                return (Student)studentList[index];
            }
        }

        private void SeedData()
        {
            AddStudent(StudentObjectFactory.CreateNewStudentObject("John", "Smith", 92.9m, "Architecture", 'm'));
            AddStudent(StudentObjectFactory.CreateNewStudentObject("Barbara", "Lopez", 89.0m, "Chemistry", 'f'));
            AddStudent(StudentObjectFactory.CreateNewStudentObject("Wiliam", "Johnson", 82.3m, "Physics", 'm'));
            AddStudent(StudentObjectFactory.CreateNewStudentObject("Susan", "Taylor", 98.1m, "Mathematics", 'f'));
            AddStudent(StudentObjectFactory.CreateNewStudentObject("Emily", "Wilson", 79.6m, "Economics", 'f'));
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public void Update(Student student, string firstName, string lastName, decimal grade, string course, char gender)
        {
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Grade = grade;
            student.Course = course;
            student.Gender = gender;
        }

        public void Delete(int index)
        {
            studentList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;

            foreach (Student student in studentList)
            {
                if (student.StudentId == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }

        public int Count()
        {
            return studentList.Count;
        }

        /// <summary>
        /// implemented to support the use of foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return studentList.GetEnumerator();
        }
    }
}