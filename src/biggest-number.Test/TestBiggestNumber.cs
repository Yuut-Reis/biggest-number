using Xunit;
using FluentAssertions;
using BiggestNumber;
using System;

namespace BiggestNumber.Test;

public class TestBiggestNumber
{
    [Theory(DisplayName = "Checks if the IdentifyBiggestNumber function returns the largest number passed to it.")]
    [InlineData(10, 20, 30, 30)]
    [InlineData(1, 6, 2, 6)]
    [InlineData(-15, -28, -1, -1)]
    public void TestIdentifyBiggestNumberSucess(int first, int second, int third, int expectedNumber)
    {
        var biggestNumber = BiggestNumber.IdentifyBiggestNumber(first, second, third);
        biggestNumber.Should().Be(expectedNumber);
    }
}