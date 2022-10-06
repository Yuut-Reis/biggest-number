using Xunit;
using FluentAssertions;
using BiggestNumber.Test;
using System;

namespace BiggestNumber.Test.Test;

public class TestTestBiggestNumber1
{
    [Trait("Category", "1 - Criou testes para o TestIdentifyBiggestNumberSucess")]
    [Theory(DisplayName = "TestIdentifyBiggestNumberSucess deve ser executado com sucesso")] 
    [InlineData(1,2,3,3)]
    [InlineData(7,6,5,7)]
    [InlineData(10,11,9,11)]
    public void TestSucessTestIdentifyBiggestNumberSucess(int first, int second, int third, int expected)
    {   
        TestBiggestNumber instance = new();
        Action act = () => instance.TestIdentifyBiggestNumberSucess(first, second, third, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();

    } 
}

public class TestTestBiggestNumber2
{
    [Trait("Category", "2 - Criou testes para o TestIdentifyBiggestNumberSucess")]
    [Theory(DisplayName = "TestIdentifyBiggestNumberSucess deve falhar com input de falha")] 
    [InlineData(1,2,3,1)]
    [InlineData(1,2,3,2)]
    [InlineData(7,6,5,6)]
    [InlineData(7,6,5,5)]
    [InlineData(10,11,9,10)]
    [InlineData(10,11,9,9)]
    public void TestFailTestIdentifyBiggestNumberSucess(int first, int second, int third, int expected)
    {   
        TestBiggestNumber instance = new();
        Action act = () => instance.TestIdentifyBiggestNumberSucess(first, second, third, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
