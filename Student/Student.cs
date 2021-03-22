namespace Name
{
    //S, accessing student
    public abstract class Student
    {
        private string name, surname;
        private int studentNumber, age;

        public string getName(){
            return name;
        }

        public Student(){
            
        }

        public Student(string name, string surname, int studentNumber, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNumber = studentNumber;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int Age { get => age; set => age = value; }
    }
}