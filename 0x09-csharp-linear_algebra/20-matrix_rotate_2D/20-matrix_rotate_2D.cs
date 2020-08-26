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
        var res = new Double[matrix.GetLength(0),matrix.GetLength(1)];
        double radians = (System.Math.PI / 180) * angle;
        for (int y = 0; y < matrix.GetLength(0); y++){
            for (int x = 0; x < matrix.GetLength(1); x++){
                res[y, x] = matrix[y, x] * radians;
            }
        }
        return res;
    }
}
