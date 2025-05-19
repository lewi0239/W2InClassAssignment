namespace MyNamespace
{
    class Student
    {
        private string name;
        private int grade;

        //define properties that are available pubicly
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        //created a constructor for future use
        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public void studentInfo()
        {
            Console.WriteLine($"{name} has a grade of {grade}");
        }

        public int IsPassing()
        {
            if (grade <= 0 || grade >= 100)
            {
                Console.WriteLine("values are out of range");
                return 0;
            } else if (grade <= 50)
            {
                Console.WriteLine("Student is failing!");
            } else if (grade >= 50)
            {
                Console.WriteLine("Student is passing!");
            }
            return grade;
        }
        
        
}
}

