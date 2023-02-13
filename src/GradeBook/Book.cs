// event delegate convention
// two arguments
public delegate void GradeAddedDelegate(object sender, EventArgs args);


public class NamedObject
{
  public NamedObject(string name)
  {
    Name = name;
  }

  public string Name
  {
    get; set;
  }
}

public interface IBook
{
  void AddGrade(double grade);
  Statistics GetStatistics();
  string Name { get; }
  event GradeAddedDelegate GradeAdded;
}

public abstract class Book : NamedObject, IBook
{
  protected Book(string name) : base(name)
  {
  }

  public abstract event GradeAddedDelegate? GradeAdded;

  public abstract void AddGrade(double grade);

  public abstract Statistics GetStatistics();


}


public class InMemoryBook : Book
{
  public InMemoryBook(string name) : base(name)
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

  public override void AddGrade(double grade)
  {
    if (grade <= 100 && grade >= 0)
    {

      _grades.Add(grade);
      if (GradeAdded != null)
      {
        GradeAdded(this, new EventArgs());
      }
    }
    else
    {

      throw new ArgumentException($"Invalid {nameof(grade)}");
    }
  }

  public override event GradeAddedDelegate? GradeAdded;

  public List<double> GetGrades()
  {
    return _grades;

  }



  public override Statistics GetStatistics()

  {

    if (_grades.Count == 0)
    {
      throw new ArgumentException("No grades found in the grade book");
    }

    var result = new Statistics();


    foreach (var grade in _grades)
    {
      result.Add(grade);

    }



    return result;
  }


  private List<double> _grades;

  public const string CATEGORY = "Science";
}
