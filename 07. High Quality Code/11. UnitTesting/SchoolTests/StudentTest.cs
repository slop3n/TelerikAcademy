namespace SchoolTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentInitializeTestName()
        {
            string name = "Pesho";
            int id = 10103;
            var student = new Student("Pesho", 10103);
            Assert.AreEqual(student.Name, "Pesho");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentInitializeTestNullName()
        {
            string name = null;
            int id = 10103;
            var student = new Student("", 10103);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentInitializeTestEmptyName()
        {
            string name = "";
            int id = 10103;
            var student = new Student("", 10103);
        }

        [TestMethod]
        public void StudentInitializeTestId()
        {
            var student = new Student("Pesho", 10103);
            Assert.AreEqual(student.Id, 10103);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentInitializeTestBelowRange()
        {
            var student = new Student("Pesho", 101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentInitializeTestAboveRange()
        {
            var student = new Student("Pesho", 100000);
        }

        [TestMethod]
        public void StudentToStringTest()
        {
            var student = new Student("Pesho", 12345);
            string expected = "Student name is: Pesho, with id: 12345";
            string actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StudentCountTest()
        {
            var course = new Course("Javascript");
            for (int i = 10100; i < 10105; i++)
            {
                course.AddStudent(new Student("ivan", i));
            }
            Assert.AreEqual(5, course.Students.Count);
        }
    }
}
