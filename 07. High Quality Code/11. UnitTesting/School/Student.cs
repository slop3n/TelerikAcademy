namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be less than 10000 or greater than 99999");
                }

                this.id = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student name is: {0}, with id: {1}", Name, Id);
        }
    }
}
