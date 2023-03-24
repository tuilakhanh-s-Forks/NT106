// https://www.codewars.com/kata/587731fda577b3d1b0001196

// Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. All words must have their first letter capitalized without spaces.

// For instance:

// camelCase("hello case"); // => "HelloCase"
// camelCase("camel case word"); // => "CamelCaseWord"

// Don't forget to rate this kata! Thanks :)

using System;
using System.Linq;
namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str) 
		  => String.Join("", str.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(substr => substr[0].ToString().ToUpper() + substr.Substring(1)));
  }
}
