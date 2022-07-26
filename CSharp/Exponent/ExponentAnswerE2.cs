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

    // get the absolute value of the exponent. Make that the number of loops
    var counter = Math.Abs(b);

    // loop through values and multiply value as many times as the exponent
    for (int i = 0; i < counter; i++)
    {
        // multiply (or divide if exponent negative) the answer with the number
        // e.g. 2^3 => 2 * 2 * 2;   2^-2 => 1/2 * 1/2
        //              logical expression ? value if true : value if false
        answer = answer * ((b < 0) ? (1.0 / a) : (a));
    }
    return answer;
}