using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string[0];

        //Act
        string result = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "hello" , "hello" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "hello" };

        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "hello";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "hello", "big" , "world", "big" };

        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "hello world";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "HellO", "bIg", "woRld", "BiG" };

        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "hello world";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
