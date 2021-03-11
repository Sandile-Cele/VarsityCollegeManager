using System.Collections.Generic;

namespace VarsityCollegeManager
{
    class StudentData
    {
        public static List<FullTimeStudent> fullTimeStudentDic = new List<FullTimeStudent>();

        // public Dictionary<int, FullTimeStudent> getFullTimeStudentDic(){
        //     return fullTimeStudentDic;
        // }

        public static void populateDic()
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

            fullTimeStudentDic.Add(fts1);
            fullTimeStudentDic.Add(fts2);
        }

    }
}
