using System;

var book = new Book("Neal's Book");
book.GradeAdded += OnGradeAdded;
book.GradeAdded += OnGradeAdded;
book.GradeAdded -= OnGradeAdded;
book.GradeAdded += OnGradeAdded;

while (true)
{

  Console.WriteLine("Please enter a grade or 'q' to quit");
  var input = Console.ReadLine();
  if (input == "q" || input is null)
  {
    break;
  }

  try
  {
    var grade = double.Parse(input);
    book.AddGrade(grade);

  }
  catch (Exception e)
  {
    Console.WriteLine(e.Message);
  }


}
try
{

  var result = book.GetStatistics();

  Console.WriteLine(Book.CATEGORY);
  Console.WriteLine($"{book.Name} Stats");
  Console.WriteLine($"The highest grade is {result.High}");
  Console.WriteLine($"The lowest grade is {result.Low}");
  Console.WriteLine($"The average grade is {result.Average:N1}");
  Console.WriteLine($"The letter grade is {result.Letter}");
}
catch (Exception e)
{
  Console.WriteLine(e.Message);

}

static void OnGradeAdded(object sender, EventArgs e)
{
  Console.WriteLine("A grade is added");
}

