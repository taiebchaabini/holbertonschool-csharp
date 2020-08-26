using System;

/// <summary>
/// MatrixMath main class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">Matrix to rotate</param>
    /// <param name="angle">New angle</param>
    /// <returns>returns the resulting matrix.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle){
        if (matrix.Length <= 1 ||
            matrix.GetLength(0) != matrix.GetLength(1)){
            return (new Double[,]{{-1}});
        }

        double cosAngle = System.Math.Cos(angle);
        double sinAngle = System.Math.Sin(angle);
        var rotation = new Double[2,2]{{cosAngle, -sinAngle}, {sinAngle, cosAngle}};
        var res = new double[matrix.GetLength(0),matrix.GetLength(1)];
        double sum = 0.0;
        for (int y = 0; y < matrix.GetLength(0); y++){
            for (int x2 = 0; x2 < rotation.GetLength(1); x2++){
                sum = 0;
                for (int x = 0; x < matrix.GetLength(1); x++){
                    sum += matrix[y,x] * rotation[x, x2];
                }
                res[y, x2] = sum;
            }
        }
        return res;
    }
}
