using System;

class LinearSystemSolver
{
    static double[] SystemSolve(double[,] S)
    {
        int rows = S.GetLength(0);
        

        int cols = S.GetLength(1) - 1; 

        bool SwapRowsIfZero(int row)
        {

            for (int i = row + 1; i < rows; i++)
            {

                if (S[i, row] != 0)
                {

                    for (int j = 0; j <= cols; j++)
                    {

                        double temp = S[row, j];

                        S[row, j] = S[i, j];

                        S[i, j] = temp;

                    }
                    return true;
                }
            }
            return false;
        }


        for (int pivotRow = 0; pivotRow < rows; pivotRow++)
        {
            double pivot = S[pivotRow, pivotRow];

            if (pivot == 0 && !SwapRowsIfZero(pivotRow))

                return new double[0];

            for (int j = pivotRow; j <= cols; j++)
                S[pivotRow, j] /= pivot;


            for (int i = 0; i < rows; i++)
            {
                if (i != pivotRow)
                {

                    double factor = S[i, pivotRow];

                    for (int j = pivotRow; j <= cols; j++)
                        S[i, j] -= factor * S[pivotRow, j];
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {

            bool allZeros = true;


            for (int j = 0; j < cols; j++)
            {

                if (S[i, j] != 0)
                {

                    allZeros = false;
                    break;
                }
            }

            if (allZeros && S[i, cols] != 0)

                return new double[0];
        }

        double[] solutions = new double[cols];



        for (int i = 0; i < rows && i < cols; i++)

            solutions[i] = S[i, cols];


        return solutions;
    }

    static void Main()
    {
        double[,] matrix1 = 
            {
            {0, 4, 2, -2},
            {-2, 3, 1, -7},
            {4, 5, 2, 4}
        };

        double[,] matrix2 = 
            {
            {1, 3, 5},
            {2, 6, 5}
        };

        double[,] matrix3 = 
            {
            {1, 3, 5},
            {3, -2, 4},
            {4, -1, 9},
            {7, -3, 13}
        };

        double[] solution1 = SystemSolve(matrix1);
        double[] solution2 = SystemSolve(matrix2);
        double[] solution3 = SystemSolve(matrix3);



        Console.WriteLine("Solution 1: " + string.Join(", ", solution1));
        Console.WriteLine("Solution 2: " + string.Join(", ", solution2));
        Console.WriteLine("Solution 3: " + string.Join(", ", solution3));
    
    
    }

}



