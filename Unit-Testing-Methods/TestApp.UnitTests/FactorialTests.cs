using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //Arrange
        int input1 = 0;

        //Act
        int result = Factorial.CalculateFactorial(input1);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int input = 5;

        //Act
        int result = Factorial.CalculateFactorial(input);

        //Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        //Arrange
        int input = -5;

        //Act + Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input);});
    }
}
