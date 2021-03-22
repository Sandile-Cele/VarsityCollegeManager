
namespace VarsityCollegeManager{

    class StudentDataManager{//responsible for managing data in "StudentData.cs"
        
        public void deleteAt(int inElement){//remove element at
            //Delete element at 
        }

        public static void populateDic()//Populate data
        {
            FullTimeStudent fts1 = new FullTimeStudent();
            fts1.Name = "Sandile";
            fts1.Surname = "Cele";
            fts1.StudentNumber = 8738348;
            fts1.Age = 21;
            fts1.VenueNum = 4;

            FullTimeStudent fts2 = new FullTimeStudent();
            fts2.Name = "Bob";
            fts2.Surname = "Ross";
            fts2.StudentNumber = 878785;
            fts2.Age = 99;
            fts2.VenueNum = 4;

            StudentData.fullTimeStudentDic.Add(fts1);
            StudentData.fullTimeStudentDic.Add(fts2);
        }

        public void addFullTimeStudent(FullTimeStudent inFullTimeStudent){// add

        }

        public void addPartTimeStudent(PartimeStudent inPartTimeStudent){

        }
    }
}
    