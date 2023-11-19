﻿using NUnit.Framework;

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
        string expected = "Plants with 5 letters:\r\n@--\\-";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

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
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n*---\r\n----\r\nPlants with 5 letters:\r\n@--\\-\r\n*-\\-\\"));
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
        string expected = "Plants with 4 letters:\r\nrOse\r\nliLy\r\nPlants with 5 letters:\r\naBcde\r\nFdgre";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
   
}
