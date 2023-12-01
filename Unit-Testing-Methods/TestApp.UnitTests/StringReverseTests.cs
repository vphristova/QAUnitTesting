﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = ""; 

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("a", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "abc";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("cba", actual);
    }
}
