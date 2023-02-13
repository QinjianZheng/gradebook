public class Book
{
  public Book(string name)
  {
    _grades = new List<double>();
    Name = name;
  }


  // method overloading
  public void AddGrade(char letter)
  {
    switch (letter)
    {
      case 'A': AddGrade(90); break;
      case 'B': AddGrade(80); break;
      case 'C': AddGrade(70); break;
      case 'D': AddGrade(60); break;
      case 'F': AddGrade(0); break;

      default:
        Console.WriteLine("Invalid Letter Grade");
        break;
    }
  }

  public void AddGrade(double grade)
  {
    if (grade <= 100 && grade >= 0)
    {

      _grades.Add(grade);
    }
    else
    {

      throw new ArgumentException($"Invalid {nameof(grade)}");
    }
  }

  public List<double> GetGrades()
  {
    return _grades;

  }

  public char GetLetterGrade(double grade)
  {
    switch (grade)
    {
      case var d when d >= 90d: return 'A';
      case var d when d >= 80d: return 'B';
      case var d when d >= 70d: return 'C';
      case var d when d >= 60d: return 'D';
      default: return 'F';
    }

  }

  public Statistics GetStatistics()

  {

    if (_grades.Count == 0)
    {
      throw new ArgumentException("No grades found in the grade book");
    }

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
      Low = lowGrade,
      Letter = GetLetterGrade(averageGrade)
    };
  }


  private List<double> _grades;
  public string Name { get; set; }

  public const string CATEGORY = "Science";
}
