using System;
using GradeBook;
using Xunit;


namespace Gradebook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void BookCalculatesStatistics()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert                      
            Assert.Equal(90.5, result.High);
            Assert.Equal(85, Math.Floor(result.Average));
            Assert.Equal(77.3, result.Low);

        }


    }
}
