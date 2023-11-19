using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);
        string expected = string.Empty;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() {"", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a" };

        // Act
        string result = CountCharacters.Count(input);
        string expected = "a -> 1";
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "aabbccc", "ababcba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!a", "!!aabbccc", "abab!cba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!a", "!!aabbccc", "abab!cba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleUpperAndSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "AAaa!aBB123C", "!!BBaabbcccA2CC31", "CCabab!cba312", "333" , "AAA", "!!!" };

        StringBuilder sb = new();
        sb.AppendLine("A -> 6");
        sb.AppendLine("a -> 8");
        sb.AppendLine("! -> 7");
        sb.AppendLine("B -> 4");
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 6");
        sb.AppendLine("C -> 5");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test1_Count_WhiteSpaces_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { " ", "   ", "  " };

        StringBuilder sb = new();
        
        string expected = "-> 6";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
