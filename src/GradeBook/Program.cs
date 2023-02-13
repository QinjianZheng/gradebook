var book = new Book();
book.AddGrade(90.1);
book.AddGrade(89.6);
book.GetGrades().Add(20);

book.Name = "Neal's Book";

book.ShowStats();
