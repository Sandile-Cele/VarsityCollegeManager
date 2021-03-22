using Name;

namespace VarsityCollegeManager{
    //S, accessing FullTimeStudent obj
    class FullTimeStudent : Student{
        
        int venueNum;//Based on assumption that Full Time Students only have on venue

        public FullTimeStudent()
        {
        }
        public FullTimeStudent(string name, string surname, int studentNumber, int age, int venueNum)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNumber = studentNumber;
            this.Age = age;
            this.VenueNum = venueNum;
        }

        public int VenueNum { get => venueNum; set => venueNum = value; }
    }

}