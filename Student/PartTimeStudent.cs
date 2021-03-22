using Name;

namespace VarsityCollegeManager
{
    //S, accessing PartTimeStudent
    class PartimeStudent : Student{
        string onlineClassLink;

        public PartimeStudent(){
            
        }

        public PartimeStudent(string name, string surname, int studentNumber, int age, string onlineClassLink)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNumber = studentNumber;
            this.Age = age;
            this.onlineClassLink = onlineClassLink;
        }
        
        public string OnlineClassLink { get => onlineClassLink; set => onlineClassLink = value; }

    }
}
        