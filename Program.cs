using System;

namespace VarsityCollegeManager
{
    //S, running the program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Populating data...");
            StudentDataManager.populateFtlList();
            Console.WriteLine("Done.\nPrinting list...");

            printStdLst();
            Console.Write("Enter a new of a PTstudent:");
            PartimeStudent PtsObj = new PartimeStudent();
            PtsObj.Name = Console.ReadLine();
            Console.Write("Done.");

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
                Console.WriteLine("------------Done" + i++ + "------------\n");
            }
            i = 1;//reset
        }
    }
}
