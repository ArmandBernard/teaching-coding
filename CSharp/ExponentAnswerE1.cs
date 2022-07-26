using System;

namespace TeachingCoding.Challenges;

/// <summary>
/// Function to raise a number to an exponent.
/// </summary>
/// <param name="a">The number to apply the exponent to</param>
/// <param name="b">The exponent</param>
/// <returns></returns>
public static double Exponent(double a, int b)
{
    // start with 1
    var answer = 1.0;

    // loop through values and multiply value as many times as the exponent
    for (int i = 0; i < b; i++)
    {
        // multiply the answer with the number
        // e.g. 2^3 => 2 * 2 * 2;
        answer = answer * a;
    }
    return answer;
}