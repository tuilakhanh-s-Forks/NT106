// https://www.codewars.com/kata/567e8f7b4096f2b4b1000005
// Implement String#eight_bit_number?, which should return true if given object is a number representable by 8 bit unsigned integer (0-255), false otherwise.

// It should only accept numbers in canonical representation, so no leading +, extra 0s, spaces etc.

using System.Text.RegularExpressions;

static class SimpleExtensions {
  public static bool EightBitNumber(this string str) => Regex.IsMatch(str, @"^(\d|[1-9]\d|1\d{2}|2([0-4]\d|5[0-5]))\z");
}
