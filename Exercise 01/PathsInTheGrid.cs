// https://www.codewars.com/kata/56a127b14d9687bba200004d
// You have a grid with mmm rows and nnn columns. Return the number of unique ways that start from the top-left corner and go to the bottom-right corner. You are only allowed to move right and down.

// For example, in the below grid of 222 rows and 333 columns, there are 101010 unique paths:

// o----o----o----o
// |    |    |    |
// o----o----o----o
// |    |    |    |
// o----o----o----o

// Note: there are random tests for grids up to 1000 x 1000 in most languages, so a naive solution will not work.

using System;
using System.Numerics;
using System.Linq;

    public class GridPath
    {
        public static BigInteger NumberOfRoutes(int m, int n)
        {
          return Factorial(m + n) / (Factorial(m) * Factorial(n));
        }
        private static BigInteger Factorial(int n) => n == 0 ? 1 : Enumerable.Range(1, n)
          .Aggregate(BigInteger.One, (i, j) => i * j);
    }
