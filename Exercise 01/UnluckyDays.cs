// https://www.codewars.com/kata/56eb0be52caf798c630013c0

// Friday 13th or Black Friday is considered as unlucky day. Calculate how many unlucky days are in the given year.

// Find the number of Friday 13th in the given year.

// Input: Year in Gregorian calendar as integer.

// Output: Number of Black Fridays in the year as an integer.

// Examples:

// unluckyDays(2015) == 3
// unluckyDays(1986) == 1

public class Kata
{
  private static int Zellercongruence(int day, int month, int year)
  {
    if (month < 3)
    {
        month += 12;
        year--;
    }
    int c = year / 100;
    year = year % 100;
    int h = (c / 4 - 2 * c + year + year / 4 + 13 * (month + 1) / 5 + day - 1) % 7;
    return (h + 7) % 7;
  }
  public static int UnluckyDays(int year)
  {
    int count = 0;
    for (int m = 1; m <= 12; m++)
    {
      if (Zellercongruence(13, m, year) == 5) 
        count++;
    }
    return count;
  }
}
