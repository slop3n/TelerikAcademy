namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        private const int MaxStudentsInCourse = 30;
        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.Students = new List<Student>();
        }

        public List<Student> Students { get; set; }

        public string CourseName { get; set; }

        public void AddStudent(Student student)
        {
            bool studentFound = IsIdTaken(student);
            if (studentFound)
            {
                throw new ArgumentException("Student id is already taken");
            }

            if (this.Students.Count >= MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("Students in course cannot exceed 30");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.Students.Count <= 0)
            {
                throw new ArgumentOutOfRangeException("There are no signed up students");
            }

            this.Students.Remove(student);
        }

        private bool IsIdTaken(Student student)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (Students[i].Id == student.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Course name: " + this.CourseName + "\n");

            for (int i = 0; i < Students.Count; i++)
            {
                result.Append(this.Students[i] + "\n");
            }

            return result.ToString();
        }
    }
}
