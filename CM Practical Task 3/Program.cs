using System;

class Program
{
    static void Main()
    {
        double[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        double[,] matrixB = {
            { 7, 8},
            {9, 10},
            {11, 12}
        };

        /*
        double[,] matrixB = {
            { 7, 8, 9 },
            { 10, 11, 12}
        };*/

        try
        {
            double[,] result = MatrixMultiply(matrixA, matrixB);
            PrintMatrix(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double[,] MatrixMultiply(double[,] A, double[,] B)
    {
        int rowA = A.GetLength(0);
        int colA = A.GetLength(1);
        int rowB = B.GetLength(0);
        int colB = B.GetLength(1);

        if (colA != rowB)
        {
            throw new Exception("Dimension mismatch");
        }

        if (rowA <= 64 || colA <= 64 || colB <= 64)
        {
            return ConventionalMatrixMultiply(A, B);
        }
        else
        {
            int newSize = Math.Max(Math.Max(rowA, colA), Math.Max(rowB, colB));
            int n = 1;
            while (n < newSize)
            {
                n *= 2;
            }

            double[,] paddedA = PadMatrix(A, n);
            double[,] paddedB = PadMatrix(B, n);

            double[,] A1 = GetSubMatrix(paddedA, 0, n / 2, 0, n / 2);
            double[,] A2 = GetSubMatrix(paddedA, 0, n / 2, n / 2, n);
            double[,] A3 = GetSubMatrix(paddedA, n / 2, n, 0, n / 2);
            double[,] A4 = GetSubMatrix(paddedA, n / 2, n, n / 2, n);
            double[,] B1 = GetSubMatrix(paddedB, 0, n / 2, 0, n / 2);
            double[,] B2 = GetSubMatrix(paddedB, 0, n / 2, n / 2, n);
            double[,] B3 = GetSubMatrix(paddedB, n / 2, n, 0, n / 2);
            double[,] B4 = GetSubMatrix(paddedB, n / 2, n, n / 2, n);

            double[,] P1 = MatrixMultiply(A1, SubtractMatrix(B2, B4));
            double[,] P2 = MatrixMultiply(AddMatrix(A1, A2), B4);
            double[,] P3 = MatrixMultiply(AddMatrix(A3, A4), B1);
            double[,] P4 = MatrixMultiply(A4, SubtractMatrix(B3, B1));
            double[,] P5 = MatrixMultiply(AddMatrix(A1, A4), AddMatrix(B1, B4));
            double[,] P6 = MatrixMultiply(SubtractMatrix(A2, A4), AddMatrix(B3, B4));
            double[,] P7 = MatrixMultiply(SubtractMatrix(A1, A3), AddMatrix(B1, B2));

            double[,] C1 = AddMatrix(SubtractMatrix(AddMatrix(P5, P4), P2), P6);
            double[,] C2 = AddMatrix(P1, P2);
            double[,] C3 = AddMatrix(P3, P4);
            double[,] C4 = SubtractMatrix(SubtractMatrix(AddMatrix(P5, P1), P3), P7);

            return CombineMatrices(C1, C2, C3, C4, rowA, colB);
        }
    }

    static double[,] ConventionalMatrixMultiply(double[,] A, double[,] B)
    {
        int rowA = A.GetLength(0);

        int colA = A.GetLength(1);
        int colB = B.GetLength(1);

        double[,] result = new double[rowA, colB];

        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < colB; j++)
            {
                for (int k = 0; k < colA; k++)
                {
                    
                 result[i, j] += A[i, k] * B[k, j];
                }
            }
        }

     return result;
    }

    static double[,] PadMatrix(double[,] matrix, int size)
    {
        int originalRows = matrix.GetLength(0);
        int originalCols = matrix.GetLength(1);

        double[,] paddedMatrix = new double[size, size];

        for (int i = 0; i < originalRows; i++)
        {
            for (int j = 0; j < originalCols; j++)
            {
            
                paddedMatrix[i, j] = matrix[i, j];
            }
        }

        return paddedMatrix;

    }

    static double[,] GetSubMatrix(double[,] matrix, int rowStart, int rowEnd, int colStart, int colEnd)
    {
        int numRows = rowEnd - rowStart;
        int numCols = colEnd - colStart;

        double[,] subMatrix = new double[numRows, numCols];

        for (int i = rowStart; i < rowEnd; i++)
        {
            for (int j = colStart; j < colEnd; j++)
            {
                
                subMatrix[i - rowStart, j - colStart] = matrix[i, j];
            }
        }

        return subMatrix;
    }

    static double[,] AddMatrix(double[,] A, double[,] B)
    {
        int n = A.GetLength(0);
        double[,] result = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = A[i, j] + B[i, j];
            }
        }
        return result;
    }

    static double[,] SubtractMatrix(double[,] A, double[,] B)
    {
        int n = A.GetLength(0);
        double[,] result = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = A[i, j] - B[i, j];
            }
        }
        return result;
    }

    static double[,] CombineMatrices(double[,] C1, double[,] C2, double[,] C3, double[,] C4, int rowA, int colB)
    {
        int n = C1.GetLength(0);
        double[,] result = new double[rowA, colB];
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < colB; j++)
            {
                if (i < n && j < n)
                    result[i, j] = C1[i, j];
                else if (i < n && j >= n)
                    result[i, j] = C2[i, j - n];
                else if (i >= n && j < n)
                    result[i, j] = C3[i - n, j];
                else
                    result[i, j] = C4[i - n, j - n];
            }
        }
        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)  { Console.Write(matrix[i, j] + " "); }
           
            
                    Console.WriteLine();
        }

    }


}



