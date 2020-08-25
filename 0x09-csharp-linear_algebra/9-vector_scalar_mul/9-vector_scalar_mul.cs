using System;

/// <summary>
/// VectorMath main class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">Vector to multiply</param>
    /// <param name="scalar">Number of multiplication</param>
    /// <returns>returns the resulting vector after multiplication.</returns>
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length != vector.Length){
                return (new Double[1]{-1});
        }
        var sum = new Double[3];
        for (int i = 0; i < vector.Length; i++){
            sum[i] = vector[i] * scalar;
        }
        return sum;
    }
}
