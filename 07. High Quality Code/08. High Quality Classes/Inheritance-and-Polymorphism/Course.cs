namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "No students in course";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        private string CourseType()
        {
            return this.GetType().Name;
        }

        protected virtual string GetVenueAsString()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(CourseType() + " { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append(GetVenueAsString());
            result.Append(" }");
            return result.ToString();
        }
    }
}
