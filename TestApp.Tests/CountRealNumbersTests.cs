using NUnit.Framework;

using System;
using System.Linq;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] numbers = new int[] { };

        // Act
        string result = CountRealNumbers.Count(numbers);
        string expected = string.Empty;
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        int[] numbers = { 1 };
        // Act
        string result = CountRealNumbers.Count(numbers);
        string expected = "1 -> 1";
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] numbers = { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
        // Act
        string result = CountRealNumbers.Count(numbers);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 3");
        
        string expected = sb.ToString().Trim();
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] numbers = { -1, -2, -3, -1, -2, -3, -1, -2, -3 };
        // Act
        string result = CountRealNumbers.Count(numbers);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-3 -> 3");
        sb.AppendLine("-2 -> 3");
        sb.AppendLine("-1 -> 3");

        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] numbers = { 0,0,0,0,0,0 };
        // Act
        string result = CountRealNumbers.Count(numbers);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("0 -> 6");
        

        string expected = sb.ToString().Trim();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
