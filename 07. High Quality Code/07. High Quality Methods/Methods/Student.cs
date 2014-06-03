using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public int YearBorn { get; set; }

        public bool IsOlderThan(Student other)
        {
            int firstDate = this.YearBorn;
            int secondDate = other.YearBorn;
            if (firstDate>secondDate)
            {
                return false;
            }
            return true;
        }
    }
}
