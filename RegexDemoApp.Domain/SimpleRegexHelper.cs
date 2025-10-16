using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemoApp.Domain;

public static class SimpleRegexHelper
{
    public static bool IsOnlyDigits(string input)
    {
        return Regex.IsMatch(input, @"^\d+$");
    }

    public static bool IsOnlyLowerCase(string input)
    {
        
        return Regex.IsMatch(input, @"^[a-z]+$");
      
    }

    public static bool StartsWithCapitalLetter(string input)
    {
        return Regex.IsMatch(input, @"^[A-Z]"); // no $ at the end, because we only care about the start
    }

    public static bool IsValidEirCode(string input)
    {
        return Regex.IsMatch(input, @"^.{3}\s.{4}$");
    }
}