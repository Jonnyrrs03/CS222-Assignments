using System;
using System.Collections.Generic;

public class PrimeFactorCalculator
{
    public static string PrimeFactors(int number)
    {
        // Handle edge cases
        if (number <= 1) return number.ToString();

        List<int> factors = new List<int>();
        int n = number;

        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        // Check odd numbers starting from 3 up to sqrt(n)
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }

        // If n is greater than 2, it means n itself is a prime factor
        if (n > 2)
        {
            factors.Add(n);
        }

        // Join the factors with " × "
        return string.Join(" × ", factors);
    }
}