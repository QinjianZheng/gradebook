public class Book
{
  public Book(string name)
  {
    _grades = new List<double>();
    _name = name;
    Name = name;
  }

  public void AddGrade(double grade)
  {
    _grades.Add(grade);
  }

  public List<double> GetGrades()
  {
    return _grades;

  }
  public Statistics GetStatistics()
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

    return new Statistics
    {
      Average = averageGrade,
      High = highGrade,
      Low = lowGrade
    };
  }

  public string GetName() { return _name; }


  private List<double> _grades;
  private string _name;
  public string Name { get; set; }
}
