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

}
