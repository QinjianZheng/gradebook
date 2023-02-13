public class Statistics
{
  public double Average { get { return Sum / Count; } }
  public double High;
  public double Low;
  public char Letter { get { return GetLetterGrade(Average); } }

  public double Sum;
  public int Count;

  public Statistics()
  {
    Count = 0;
    Sum = 0d;
    High = double.MinValue;
    Low = double.MaxValue;
  }


  public void Add(double number)
  {
    Sum += number;
    Count += 1;
    High = Math.Max(number, High);
    Low = Math.Min(number, Low);
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

}
