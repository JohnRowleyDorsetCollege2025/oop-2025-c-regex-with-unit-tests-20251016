using RegexDemoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemoApp.Tests;

public  class SimpleRegexHelperTests
{
    [Theory]
    [InlineData("12345", true)]
    [InlineData("abnhhh", false)]
    [InlineData("1acc2345", false)]
    public void IsOnlyDigits_Works(string input, bool expect)
    {
        Assert.Equal(expect, SimpleRegexHelper.IsOnlyDigits(input));
    }

    [Theory]
    [InlineData("abcde", true)]
    [InlineData("ABCD", false)]
    [InlineData("aBcD", false)]
    public void IsOnlyLowerCase_Works(string input, bool expect)
    {
        Assert.Equal(expect, SimpleRegexHelper.IsOnlyLowerCase(input));
    }


    [Theory]
    [InlineData("ABCD", true)]
    [InlineData("Abcd", true)]
    [InlineData("abcde", false)]
    [InlineData("aBcD", false)]
    [InlineData("23BcD", false)]
    public void StartsWithCapitalLetter_Works(string input, bool expect)
    {
        Assert.Equal(expect, SimpleRegexHelper.StartsWithCapitalLetter(input));
    }

    [Theory]
    [InlineData("A65 F4E2", true)]
    [InlineData("D02 X285", true)]
    [InlineData("123 4567", true)]
    [InlineData("A6 F4E2", false)]      // Too short before space
    [InlineData("A65F4E2", false)]      // Missing space
    [InlineData("A65  F4E2", false)]    // Extra space
    [InlineData("A65 F4E", false)]      // Too short after space
    [InlineData("A65 F4E22", false)]    // Too long after space
    [InlineData("", false)]             // Empty string
    [InlineData("   ", false)]          // Only spaces
    public void IsValidEirCode_ShouldMatchExpected(string input, bool expected)
    {
        bool result = SimpleRegexHelper.IsValidEirCode(input);
        Assert.Equal(expected, result);
    }

}
