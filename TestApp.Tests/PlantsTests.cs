using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string [0];

        //Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(result, Is.EqualTo(""));

    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] 
        {
            "@--\\-"
        };
        
        // Act
        string result = Plants.GetFastestGrowing(plants);
        string expected = $"Plants with 5 letters:{Environment.NewLine}@--\\-";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //666
    //6666

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new string[]
            {
            "@--\\-" ,
            "*---" ,
            "----" ,
            "*-\\-\\"
        };
        
        
        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}*---{Environment.NewLine}----{Environment.NewLine}Plants with 5 letters:{Environment.NewLine}@--\\-{Environment.NewLine}*-\\-\\"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[]
        { 
            "rOse",
            "liLy",
            "aBcde",
            "Fdgre"
        };

        // Act
        string result = Plants.GetFastestGrowing(input);
        string expected = $"Plants with 4 letters:{Environment.NewLine}rOse{Environment.NewLine}liLy{Environment.NewLine}Plants with 5 letters:{Environment.NewLine}aBcde{Environment.NewLine}Fdgre";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
   
}
