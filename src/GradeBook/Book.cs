class Book
{
  public Book()
  {
    _grades = new List<double>();
  }

  public void AddGrade(double grade)
  {
    _grades.Add(grade);
  }

  public List<double> GetGrades()
  {
    return _grades;

  }
  public void ShowStats()
  {
    var highGrade = double.MinValue;
    var lowGrade = double.MaxValue;
    var sum = 0d;

    foreach (var grade in _grades)
    {
      highGrade = Math.Max(grade, highGrade);
      lowGrade = Math.Min(grade, lowGrade);
      sum += grade;
    }

    var averageGrade = sum / _grades.Count;

    Console.WriteLine($"{Name} Stats");
    Console.WriteLine($"The highest grade is {highGrade:N1}");
    Console.WriteLine($"The lowest grade is {lowGrade:N1}");
    Console.WriteLine($"The average grade is {averageGrade:N1}");

  }


  private List<double> _grades;
  // private string _name;
  public string? Name { get; set; }
}
