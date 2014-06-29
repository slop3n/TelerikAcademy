namespace SchoolTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void InitializeSchoolTest()
        {
            var school = new School("Telerik Academy");
            var javascript = new Course("Javascript");
            var pesho = new Student("Pesho", 10111);
            javascript.AddStudent(pesho);
            school.AddCourse(javascript);
            string expected = "Course number: 1\nCourse name: Javascript\nStudent name is: Pesho, with id: 10111\n";
            string actual = school.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveCourseFromSchool()
        {
            var school = new School("Telerik Academy");
            var javascript = new Course("Javascript");
            var html = new Course("HTML");
            school.AddCourse(javascript);
            school.AddCourse(html);
            school.RemoveCourse(html);
            string expected = school.ToString();
            string actual = "Course number: 1\nCourse name: Javascript\n";
            Assert.AreEqual(expected, actual);
        }
    }
}
