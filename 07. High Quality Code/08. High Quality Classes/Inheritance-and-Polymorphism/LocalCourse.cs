using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string name)
            : base(name)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        protected override string GetVenueAsString()
        {
            if (this.Lab != null)
            {
                return "; Lab = " + this.Lab;
            }

            return string.Empty;
        }
    }
}
