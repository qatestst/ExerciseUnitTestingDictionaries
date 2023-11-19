using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new List<int>();
        // Act
        string result = Grouping.GroupNumbers(list);
       
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>{ 1, 2, 3, 4, 5, 6};
        // Act
        string result = Grouping.GroupNumbers(list);

        StringBuilder sb = new StringBuilder();
        
        sb.AppendLine("Odd numbers: 1, 3, 5");
        sb.AppendLine("Even numbers: 2, 4, 6");


        string expected = sb.ToString().Trim();
        // Assert
        Assert.That (result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int> { 2, 4, 6, 8, 10 };
        // Act
        string result = Grouping.GroupNumbers(list);

        StringBuilder sb = new StringBuilder();

       
        sb.AppendLine("Even numbers: 2, 4, 6, 8, 10");


        string expected = sb.ToString().Trim();
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int> { 1, 3, 5, 7, 9 };
        // Act
        string result = Grouping.GroupNumbers(list);

        StringBuilder sb = new StringBuilder();


        sb.AppendLine("Odd numbers: 1, 3, 5, 7, 9");


        string expected = sb.ToString().Trim();
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int> { -1, -2, 1, 2, 3, 5, 7, 9 ,4 , 6};
        // Act
        string result = Grouping.GroupNumbers(list);

        StringBuilder sb = new StringBuilder();


        sb.AppendLine("Odd numbers: -1, 1, 3, 5, 7, 9");
        sb.AppendLine("Even numbers: -2, 2, 4, 6");


        string expected = sb.ToString().Trim();
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
