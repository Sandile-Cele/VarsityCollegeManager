
namespace VarsityCollegeManager{
    
    //S, manage student data
    class StudentDataManager{//responsible for managing data in "StudentData.cs"
        
        public void deleteAt(int inElement){//remove element at
            //Delete element at 
        }

        public static void populateFtlList()//Populate data
        {
            FullTimeStudent fts1 = new FullTimeStudent("Sandile", "Cele", 8738348, 21, 4);
            FullTimeStudent fts2 = new FullTimeStudent("Bob", "Ross", 878785, 40, 4);

            StudentData.fullTimeStudentDic.Add(fts1);
            StudentData.fullTimeStudentDic.Add(fts2);
        }

        public void addFullTimeStudent(FullTimeStudent inFullTimeStudent){// add new FTS

        }

        public void addPartTimeStudent(PartimeStudent inPartTimeStudent){//add new PTS

        }
    }
}
    