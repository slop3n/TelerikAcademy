namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name) : base(name)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName) : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) :this(courseName, teacherName)
        {
            this.Students = students;
        }

        protected override string GetVenueAsString()
        {
            if (this.Town != null)
            {
                return "; Town = " + this.Town;
            }

            return string.Empty;
        }
    }
}
