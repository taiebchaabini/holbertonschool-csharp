using System;

class MatrixMath
{
    /// <summary>
    /// Method that calculates the determinant of a 2D matrix.
    /// </summary>
    /// <param name="matrix">2D or 3D matrix.</param>
    /// <returns>returns the determinant of a matrix</returns>
    public static double Determinant2D(double[,] matrix){
        return ((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1, 0]));
    }
    /// <summary>
    /// Method that calculates the determinant of a matrix.
    /// </summary>
    /// <param name="matrix">2D or 3D matrix.</param>
    /// <returns>returns the determinant of a matrix</returns>
    public static double Determinant(double[,] matrix){
        if (matrix.GetLength(1) != matrix.GetLength(0)){
            return (-1);
        }
        if (matrix.GetLength(1) == 2){
            return (Determinant2D(matrix));
        }
        var matrixA = new Double[,]{{matrix[1,1], matrix[1,2]},{matrix[2,1], matrix[2,2]}};
        var matrixB = new Double[,]{{matrix[2,0], matrix[2,2]},{matrix[3,0], matrix[3,2]}};
        var matrixC = new Double[,]{{matrix[2,0], matrix[2,1]},{matrix[3,0], matrix[3,1]}};
        var res = Determinant2D(matrixA) - Determinant2D(matrixB) + Determinant2D(matrixC);
        return res;
    }
}
