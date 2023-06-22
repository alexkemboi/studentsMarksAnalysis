using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to students marks analysis"); 
        StudentsScores studentsScores = new StudentsScores();
        studentsScores.Main();
    }
}
class StudentsScores
{
    public List<int> marks;
    public  StudentsScores()
    {
        marks = new List<int>();
    }
    public void AddMarks()
    {
        Console.WriteLine("Enter the number of students you want to record marks for");
        int noOfStudents=int.Parse(Console.ReadLine());
        while (marks.Count <= noOfStudents) {
            Console.WriteLine($"Enter marks scored by student {marks.Count}");
            int newMark = int.Parse(Console.ReadLine());
            marks.Add(newMark);
            if(marks.Count==noOfStudents)
            {
                Console.WriteLine($"All {marks.Count} entered succefully");
                StudentsScores studentsScores = new StudentsScores();
                studentsScores.Main();
            }
        }
    }

    public void ViewMarks()
    {
        for (int i = 0; i < marks.Count; i++)
        {
            Console.WriteLine($"Student {i + 1}: {marks[i]}");
        }
    }

    public void RemoveMarks()
    {
        int index = int.Parse(Console.ReadLine());
        marks.RemoveAt(index);
    }
   


    public void ExitApp()
    {
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    public void Main()
    {
        StudentsScores studentsScores = new StudentsScores();
        Console.WriteLine("Choose an option");
        Console.WriteLine("1:Add Marks");
        Console.WriteLine("2:View analysis");
        Console.WriteLine("3:Exit app");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                studentsScores.AddMarks();
                break;
            case 2:
                studentsScores.ViewMarks();
                break;
            case 3:
                studentsScores.ExitApp();
                break;
            default:
                Console.WriteLine("Wrong entry try again");
                break;
        }
    }
}