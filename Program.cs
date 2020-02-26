  
using System;
using System.Collections.Generic;
using System.Linq;

namespace My_First_Console_App
{
    class Program
    {
        static List<Student> studentsList = new List<Student>();
        static void Main(string[] args)
        {
            var inputtingStudent = true;
            
            while (inputtingStudent) 
        {
            DisplayMenu();
            var option = Console.ReadLine();
            
            switch (int.Parse(option))
        {       
            case 1:
            InputStudent();
            break;

            case 2:
            DisplayStudents();
            break;

            case 3:
            SearchStudents();
            break;

            case 4:
                inputtingStudent = false;
            break;
        }
    }
}
            private static void DisplayStudents(IEnumerable<Student> students)
            {
             if (students.Any())
                {   
                Console.WriteLine($"Student Id | Name |  Class ");
                studentsList.ForEach(x =>
            {
                Console.WriteLine("No students found.");
            });
        } 
         else
        {
                System.Console.WriteLine("No students found.");
        }        
    } 
            private static void DisplayStudents() => DisplayStudents(studentsList);                           
            private static void SearchStudents()
            {
                Console.WriteLine("Search string:");
                var searchString = Console.ReadLine();
                var students = studentsList.Where(x => x.FullName.Contains(searchString)).ToList();
                DisplayStudents(students);
            }
            private static void DisplayMenu()
            {
                Console.WriteLine("Select from the following operations:");
                Console.WriteLine("1: Enter new student");
                Console.WriteLine("2: List all students");
                Console.WriteLine("3: Search for student by name");
                Console.WriteLine("4: Exit");
            }

            static Student InputStudent()
            {
            
            Console.WriteLine("Enter Student Id");
            var studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            var studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var studentLastName = Console.ReadLine();
            Console.WriteLine("Enter Class Name");
            var className = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed");
            var lastClass = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
            var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
            Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
            var startDate = DateTimeOffset.Parse(Console.ReadLine());

            var studentRecord = new Student();
            studentRecord.StudentId = studentId;
            studentRecord.FirstName = studentFirstName;
            studentRecord.LastName = studentLastName;
            studentRecord.ClassName = className;
            studentRecord.StartDate = startDate;
            studentRecord.LastClassCompleted = lastClass;
            studentRecord.LastClassCompletedOn = lastCompletedOn;
            Console.WriteLine($"Student Id | Name |  Class "); ;
            Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} ");
            Console.ReadKey();    
            return studentRecord;
         }
    }
}