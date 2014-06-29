namespace School
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        public List<Course> Courses { get; set; }

        public string SchoolName { get; set; }

        public School(string name)
        {
            this.SchoolName = name;
            this.Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            this.Courses.Remove(course);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.Courses.Count; i++)
            {
                result.AppendFormat("Course number: {0}\n{1}", i+1, this.Courses[i].ToString());
            }

            return result.ToString();
        }
    }
}
