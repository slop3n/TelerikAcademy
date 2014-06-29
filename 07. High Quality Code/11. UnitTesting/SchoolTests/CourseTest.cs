namespace SchoolTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void InitializeCourseTest()
        {
            var course = new Course("C# HQC");
            Assert.AreEqual("C# HQC", course.CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseUniqueIdTest()
        {
            var course = new Course("Javascript");
            course.AddStudent(new Student("Ivan", 10101));
            course.AddStudent(new Student("Dragan", 10101));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseOverflowTest()
        {
            var course = new Course("C# HQC");
            for (int i = 10100; i < 10135; i++)
            {
                course.AddStudent(new Student("Pesho", i));
            }
        }

        [TestMethod]
        public void CourseRemoveStudentTest()
        {
            var course = new Course("Javascript");
            var pesho = new Student("Pesho", 10131);
            var gosho = new Student("Gosho", 10132);
            course.AddStudent(pesho);
            course.AddStudent(gosho);
            course.RemoveStudent(gosho);
            var actual = course.ToString();
            var expected = "Course name: Javascript\nStudent name is: Pesho, with id: 10131\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CourseToStringTest()
        {
            var course = new Course("C# HQC");
            var pesho = new Student("Pesho", 10132);
            var gosho = new Student("Gosho", 10123);
            course.AddStudent(pesho);
            course.AddStudent(gosho);
            string expected = "Course name: C# HQC\nStudent name is: Pesho, with id: 10132\nStudent name is: Gosho, with id: 10123\n";
            string actual = course.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
