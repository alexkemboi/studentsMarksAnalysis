using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to students marks analysis");
        StudentsScores studentsScores = new StudentsScores();
        studentsScores.Options();
    }
}
class StudentsScores
{
    public List<int> marks;
    public StudentsScores()
    {
        marks = new List<int>();
    }
    public void AddMarks()
    {
        Console.WriteLine("Enter the number of students you want to record marks for");
        int noOfStudents = int.Parse(Console.ReadLine());
        while (marks.Count != noOfStudents)
        {
            Console.WriteLine($"Enter marks scored by student {marks.Count + 1}");
            int newMark = int.Parse(Console.ReadLine());
            marks.Add(newMark);
            if (marks.Count == noOfStudents)
            {
                Console.WriteLine($"All {marks.Count} studnet's marks entered succefully");
                Options();
            }
        }



    }

    public void ViewMarks()
    {
        int totalMarks = 0;
        int noOfPassed = 0;
        int noOfFailed = 0;
        int highestMark = 0;
        if (marks.Count > 0)
        {
            for (int i = 0; i < marks.Count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {marks[i]}");
                totalMarks = totalMarks + marks[i];
                if (marks[i] > highestMark)
                {
                    highestMark= marks[i];
                }
                if (marks[i] < 60)
                {
                    noOfFailed++;
                }
                else
                {
                    noOfPassed++;
                }
            }
            Console.WriteLine($"Averege Mark:{totalMarks / marks.Count}");
            Console.WriteLine($"Total Students Passed:{noOfPassed}");
            Console.WriteLine($"Total Students Passed:{noOfFailed}");
            Console.WriteLine($"Highest Mark:{highestMark}");
        }
        else
        {
            Console.Write("Marks is empty");
        }
    }

    public void RemoveMarks()
    {
        Console.WriteLine("Enter the index of element you want to remove");
        int index = int.Parse(Console.ReadLine());
        marks.RemoveAt(index);
    }


    public void ExitApp()
    {
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    
    public void Options()
    {
        Console.WriteLine("Choose an option");
        Console.WriteLine("1:Add Marks");
        Console.WriteLine("2:View analysis");
        Console.WriteLine("3:Exit app");
        Console.WriteLine("4:Remove Mark");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
              AddMarks();
                break;
            case 2:
              ViewMarks();
                break;
            case 3:
               ExitApp();
                break;
            case 4:
               RemoveMarks();
                break;
            default:
                Console.WriteLine("Wrong entry try again");
                break;
        }
    }
}