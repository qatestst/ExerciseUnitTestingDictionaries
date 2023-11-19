using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = { };

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.Empty);


    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 5.97 1" , "banana 3.75 1" , "orange 1.98 1" };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 5 10", "banana 3 10", "orange 1 10" };
        // Act
        string result = Orders.Order(input);
        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 50.00{Environment.NewLine}banana -> 30.00{Environment.NewLine}orange -> 10.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 20 0.5", "banana 10 2.5", "orange 10 0.7" };
        // Act
        string result = Orders.Order(input);
        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 10.00{Environment.NewLine}banana -> 25.00{Environment.NewLine}orange -> 7.00"));
    }
}
