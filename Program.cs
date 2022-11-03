using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ass2_Cource1
{             //Write a program which will retrieve student data from a text file,
              //sort it, and display it.
              //Allow searching of students by name.
    class Program
    {
        static void Main(string[] args)
        {
            // calling class of students
            Students std = new Students();
        

            //TO repeate this calling using while statmnte
            int answer = 1;
            while(answer != 5)
            {
                        Console.WriteLine("\nChoose the operation you want to perform:");
                        Console.WriteLine("\nto RETRIVE student data and Display it Choose: \t 1");
                        Console.WriteLine("to  SORT student data and Display it Choose: \t 2 ");
                        Console.WriteLine("to   SEARCHING of students by name Choose: \t 3 ");
                        int Choose1 = Convert.ToInt32(Console.ReadLine());
                        switch (Choose1)
                        {
                            case 1: Students.PrintDataStudent(); break;// TO Retrive Data Enter 1
                            case 2: Students.PrintSortData(); break;// TO Sort Data Enter 2
                            case 3: Students.SearchByName(); break;// TO Search Data Enter 3
                            default: Console.WriteLine("Please Enter Correct Value! "); break;
                        }
                        answer++;
            }

            Console.ReadLine();

        }// end main
        
           
    } //end class of program

    //Class for Data Students and Operations on it (Retrive / Sort / Search)
    public class Students
    {
        // Retrive Data Of Students from file 
        public static void PrintDataStudent()
        {
            string readText = File.ReadAllText("C:/Users/Dell/myProjectNawal/DataStudent_2.txt");  // Read the contents of the file
            Console.WriteLine("RETRIVE student data from a text file:" + "\n"+readText);  // Output the content
        }


        //Sort Data Of Students from file 
        public static void PrintSortData()
        {
            string nameOfFile = @"C:/Users/Dell/myProjectNawal/DataStudent_2.txt";
            List<string> lines = new List<string>(File.ReadAllLines(nameOfFile));
            lines.Sort();
            Console.WriteLine("SORT student data from a text file:");
            foreach (var line in lines)
            {
                Console.WriteLine( line);
            }
        }


        //Search by Name  Of  Data  Students from file
        public static void SearchByName()
        {   
            // to display the list of name
                    PrintDataStudent();

            // Enter the name for searching
                Console.WriteLine("what is the name is find?");
                string sSearch = Console.ReadLine();

            // the file path and store in list
                string nameOfFile = @"C:\Users\Dell\myProjectNawal\‏‏DataStudent_2 - نسخة.txt";
                List<string> lines = new List<string>(File.ReadAllLines(nameOfFile));

            // code for searching
                string findStd = lines.Find(searchName => searchName.Contains(sSearch));
                if (findStd != null)
                {
                    Console.WriteLine("YES! founded! " + ": " + findStd);
                }
                else
                    Console.WriteLine("is not exict!");
        }

    }// end class of students
  
}
