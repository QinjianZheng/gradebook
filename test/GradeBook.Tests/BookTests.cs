using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
  // Mark the method is a test
  [Fact]
  public void BookCalAnAverageGrade()
  {
    // arrange
    var book = new InMemoryBook("Test Grade Book");
    book.AddGrade(89.1);
    book.AddGrade(90.5);
    book.AddGrade(77.3);
    // act

    var result = book.GetStatistics();
    // assert

    Assert.Equal(85.6, result.Average, 1);
    Assert.Equal(90.5, result.High, 1);
    Assert.Equal(77.3, result.Low, 1);
    Assert.Equal('B', result.Letter);
  }
}
