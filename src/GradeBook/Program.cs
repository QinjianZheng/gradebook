var book = new Book("Neal's Book");
book.AddGrade(90.1);
book.AddGrade(89.6);
book.GetGrades().Add(20);


var result = book.GetStatistics();


Console.WriteLine($"{book.GetName()} Stats");
Console.WriteLine($"The highest grade is {result.High}");
Console.WriteLine($"The lowest grade is {result.Low}");
Console.WriteLine($"The average grade is {result.Average:N1}");
