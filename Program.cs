using System;

namespace VarsityCollegeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Populating data...");
            StudentDataManager.populateDic();
            Console.WriteLine("Done.\nPrinting list...");

            printStdLst();
        }

        static void printStdLst(){
            int i = 1;
            foreach(FullTimeStudent stuLstObj in StudentData.fullTimeStudentDic){
                Console.WriteLine("Student: " + i);
                Console.WriteLine("Name: " + stuLstObj.Name);
                Console.WriteLine("surname: " + stuLstObj.Surname);
                Console.WriteLine("Age: " + stuLstObj.Age);
                Console.WriteLine("STDno: " + stuLstObj.StudentNumber);
                Console.WriteLine("Venue no: " + stuLstObj.VenueNum);
                Console.WriteLine("------------Done" + i + "------------\n");
            }
        }
    }
}
