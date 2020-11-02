using System;
using System.Collections.Generic;

namespace GradeBook
{


    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Praveen's Grade Book");
             book.GradeAdded += OnGradeAdded;
             book.GradeAdded += OnGradeAdded;
             book.GradeAdded -= OnGradeAdded;
           

           
           while(true)
           {
                      Console.WriteLine("Enter the grade or press 'Q' quit");
                       var input = Console.ReadLine();
                  if(input == "q")
                  {
                     break;

                  }

                  try

                  {
                       var grade = double.Parse(input);
                  book.AddGrade(grade);
                  }
                  catch(ArgumentException exec )
                  {
                      Console.WriteLine(exec.Message);

                  }
                  catch(FormatException exec)
                  {
                      Console.WriteLine(exec.Message);

                  }
                  finally
                  {
                      Console.WriteLine("QIt's an error");
                  }

           }
          //  book.AddGrade(85.6);
           // book.AddGrade(90.5);
             //book.AddGrade(77.3);
            //book.GetStatistics();

        var stats = book.GetStatistics();
        Console.WriteLine(Book.CATEGORY);
        Console.WriteLine($"For the book named {book.Name}");
        Console.WriteLine($" The Avarage grade is {stats.Average:N1}, Highest Grade is {stats.High:N1}, Lowest grade {stats.Low:N1}, The Grade is {stats.Letter} ");

          
     }

     static void OnGradeAdded(object sender, EventArgs e)
     {
                  Console.WriteLine("A grade was added");
     }
    }
}

