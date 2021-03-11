using System;

namespace VarsityCollegeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Populating data...");
            StudentData.populateDic();
            Console.WriteLine("Done.");
            
            Console.WriteLine("Printing list...");
            
            StudentData obj1 = new StudentData();

            int i = 1;
            foreach(FullTimeStudent stuLst in StudentData.fullTimeStudentDic){
                Console.WriteLine("Name of no." + i + " student is: " + stuLst.Name);
                Console.WriteLine("Age of no." + i++ + " student is: " + stuLst.Age);
                Console.WriteLine("------------------------\n");
            }
        }
    }
}
