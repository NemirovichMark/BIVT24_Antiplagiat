using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
        int[,] output = program.Task_2_6(4);
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        if (A is null || A.GetLength(0) != 5 || (A.Length / A.GetLength(0)) != 7) { return 0; }


        int answer = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                answer += A[i, j];
            }
        }

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        if (A is null || A.GetLength(0) != 3 || A.Length / A.GetLength(0) != 6) { return (0, 0); }

        int row = 0, col = 0;
        
        int minValue = A[0, 0];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < minValue)
                {
                    minValue = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        if (A is null || A.GetLength(0) != 3 || A.Length / A.GetLength(0) != 5) { return null; }
        int[] answer = new int[5];
        
        for (int j = 0; j < 5; j++)
        {
            answer[j] = A[0, j];
            for (int i = 1; i < 3; i++)
            {
                if (A[i, j] > answer[j])
                {
                    answer[j] = A[i, j];
                }
            }
        }

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        if (A is null || A.GetLength(0) != 5 || A.Length / A.GetLength(0) != 7) { return null; }

        int maxRowIndex = 0;
        int maxValue = A[0, 2];

        for (int i = 1; i < 5; i++)
        {
            if (A[i, 2] > maxValue)
            {
                maxValue = A[i, 2];
                maxRowIndex = i;
            }
        }

        for (int j = 0; j < 7; j++)
        {
            int temp = A[maxRowIndex, j];
            A[maxRowIndex, j] = A[3, j];
            A[3, j] = temp;
        }

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        if (A is null || A.GetLength(0) != 5 || A.Length / A.GetLength(0) != 5) { return null; }

        int maxDiagonalValue = A[0, 0];
        int maxDiagonalIndex = 0;

        for (int i = 1; i < 5; i++)
        {
            if (A[i, i] > maxDiagonalValue)
            {
                maxDiagonalValue = A[i, i];
                maxDiagonalIndex = i;
            }
        }

        int columnToSwap = 3;

        for (int i = 0; i < 5; i++)
        {
            int temp = A[i, columnToSwap];
            A[i, columnToSwap] = A[i, maxDiagonalIndex];
            A[i, maxDiagonalIndex] = temp;
        }

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        if (A is null || A.GetLength(0) != n || A.Length / A.GetLength(0) != m) { return null; }

        for (int i = 0; i < n; i++)
        {
            int maxIndex = 0;
            int maxValue = A[i, 0];

            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    maxIndex = j;
                }
            }
            if (maxIndex != m - 1)
            {
                for (int j = maxIndex; j < m - 1; j++)
                {
                    A[i, j] = A[i, j + 1];
                }
                A[i, m - 1] = maxValue;
            }
        }

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        if (C is null || C.GetLength(0) != n || C.Length / C.GetLength(0) != m) { return null; }

        for (int i = 0; i < n; i++)
        {
            int maxIndex = 0;
            double maxValue = C[i,0];

            for (int j = 1; j < m; j++)
            {
                if (C[i,j] > maxValue)
                {
                    maxValue = C[i,j];
                    maxIndex = j;
                }
            }

            for (int j = 0; j < maxIndex; j++)
            {
                if (C[i,j] < 0)
                {
                    C[i,j] /= maxValue;
                }
            }
        }

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        if (Z is null || Z.GetLength(0) != 6 || Z.Length / Z.GetLength(0) != 8) { return null; }

        double maxElement = Z[0, 0];
        int maxRow = 0;
        int maxCol = 0;
        double positiveSum = 0;
        int positiveCount = 0;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > maxElement)
                {
                    maxElement = Z[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (Z[i, j] > 0)
                {
                    positiveSum += Z[i, j];
                    positiveCount++;
                }
            }
        }

        double averagePositive = positiveCount > 0 ? positiveSum / positiveCount : 0;

        Z[maxRow, maxCol] = averagePositive;

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        if (X is null || X.GetLength(0) != 6 || X.Length / X.GetLength(0) != 5) { return null; }

        int minNegativeCountRow = 0;
        int maxNegativeCountRow = 0;
        int minNegativeCount = int.MaxValue;
        int maxNegativeCount = int.MinValue;

        for (int i = 0; i < 6; i++)
        {
            int negativeCount = 0;

            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    negativeCount++;
                }
            }

            if (negativeCount < minNegativeCount)
            {
                minNegativeCount = negativeCount;
                minNegativeCountRow = i;
            }

            if (negativeCount > maxNegativeCount)
            {
                maxNegativeCount = negativeCount;
                maxNegativeCountRow = i;
            }
        }

        for (int j = 0; j < 5; j++)
        {
            int temp = X[minNegativeCountRow, j];
            X[minNegativeCountRow, j] = X[maxNegativeCountRow, j];
            X[maxNegativeCountRow, j] = temp;
        }

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        if (A is null || A.GetLength(0) != 7 || A.Length / A.GetLength(0) != 5) { return null; }

        int maxRowIndex = 0;
        int maxPositiveSum = int.MinValue;

        for (int i = 0; i < 7; i++)
        {
            int positiveSum = 0;

            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0)
                {
                    positiveSum += A[i, j];
                }
            }

            if (positiveSum > maxPositiveSum)
            {
                maxPositiveSum = positiveSum;
                maxRowIndex = i;
            }
        }

        int[,] newA = new int[6, 5];
        int newRow = 0;

        for (int i = 0; i < 7; i++)
        {
            if (i != maxRowIndex)
            {
                for (int j = 0; j < 5; j++)
                {
                    newA[newRow, j] = A[i, j];
                }
                newRow++;
            }
        }

        return newA;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        if (A is null || A.Length == 0 || A.Length / A.GetLength(0) != 8 || A.GetLength(0) < 5 || B.Length != 5) { return null; }

        int minElementIndex = 0;
        for (int j = 1; j < 8; j++)
        {
            if (A[4, j] < A[4, minElementIndex])
            {
                minElementIndex = j;
            }
        }
        if (minElementIndex != A.Length / A.GetLength(0) - 1) {
            for (int i = 0; i < 5; i++)
            {
                A[i, minElementIndex + 1] = B[i];
            }
        }

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public double Increase(int a)
    {
        if(a < 0) { return a / 2; }
        return a * 2;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        if (A.Length != 35 || A.GetLength(0) != 7) return null;
        for (int j = 0; j < 5; j++)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int maxElementIndex = 0;

            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0)
                {
                    positiveCount++;
                }
                else if (A[i, j] < 0)
                {
                    negativeCount++;
                }

                if (A[i, j] > A[maxElementIndex, j])
                {
                    maxElementIndex = i;
                }
            }

            if (positiveCount > negativeCount)
            {
                A[maxElementIndex, j] = 0;
            }
            else
            {
                A[maxElementIndex, j] = maxElementIndex + 1;
            }
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.Length != 50 || A.GetLength(0) != 10) return null;
        for (int j = 0; j < 5; j++)
        {
            int maxElementIndex = 0;
            int maxElementValue = A[0, j];

            for (int i = 1; i < 10; i++)
            {
                if (A[i, j] > maxElementValue)
                {
                    maxElementValue = A[i, j];
                    maxElementIndex = i;
                }
            }

            if (maxElementIndex < 5)
            {
                int sum = 0;
                for (int i = maxElementIndex + 1; i < 10; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.Length != 35 || A.GetLength(0) != 7 || B.Length != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int maxElementIndex = 0;
            int maxElementValue = A[0, j];

            for (int i = 1; i < 7; i++)
            {
                if (A[i, j] > maxElementValue)
                {
                    maxElementValue = A[i, j];
                    maxElementIndex = i;
                }
            }

            if (B[j] > maxElementValue)
            {
                A[maxElementIndex, j] = B[j];
            }
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.Length != 35 || A.GetLength(0) != 7) return null;
        for (int j = 0; j < 5; j++)
        {
            int maxElementIndex = 0;

            for (int i = 1; i < 7; i++)
            {
                if (A[i, j] > A[maxElementIndex, j])
                {
                    maxElementIndex = i;
                }
            }

            double firstElement = A[0, j];
            double lastElement = A[6, j];
            double halfSum = (firstElement + lastElement) / 2;

            if (A[maxElementIndex, j] < halfSum)
            {
                A[maxElementIndex, j] = halfSum;
            }
            else
            {
                A[maxElementIndex, j] = maxElementIndex + 1;
            }
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;

        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < n; i ++)
        {
            answer[i, i] = 1;
            answer[i, i + n] = 1;
            answer[i, i + n + n] = 1;
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.Length != 36 || A.GetLength(0) != 6) return null;
        
        int maxElement = A[0, 0];
        int maxElementRow = 0;

        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxElement)
            {
                maxElement = A[i, i];
                maxElementRow = i;
            }
        }

        for (int i = 0; i < maxElementRow; i++)
        {
            for (int j = i + 1; j < 6; j++)
            {
                A[i, j] = 0;
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.Length != 36 || B.GetLength(0) != 6) return null;

        int[] maxIndices = new int[6];

        for (int i = 0; i < 6; i++)
        {
            int maxElement = B[i, 0];
            int maxIndex = 0;

            for (int j = 1; j < 6; j++)
            {
                if (B[i, j] > maxElement)
                {
                    maxElement = B[i, j];
                    maxIndex = j;
                }
            }
            
            maxIndices[i] = maxIndex;
        }

        for (int i = 0; i < 3; i++)
        {
            int temp = B[i * 2, maxIndices[i * 2]];
            B[i * 2, maxIndices[i * 2]] = B[i * 2 + 1, maxIndices[i * 2 + 1]];
            B[i * 2 + 1, maxIndices[i * 2 + 1]] = temp;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.Length != 42 || A.GetLength(0) != 6) return null;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.Length != 35 || matrix.GetLength(0) != 7) return null;

        int[] mini = new int[7];
        for (int i = 0; i < 7; i++)
        {
            mini[i] = 0;
            for (int j = 1; j < 5; j++)
            {
                if (matrix[i, j] < matrix[i, mini[i]])
                {
                    mini[i] = j;
                }
            }
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                if (matrix[j, mini[j]] < matrix[j + 1, mini[j + 1]])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int tempIndex = mini[j];
                    mini[j] = mini[j + 1];
                    mini[j + 1] = tempIndex;
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        if (matrix.Length == 0 || matrix.GetLength(0) != matrix.Length / matrix.GetLength(0)) { return null; }

        int n = matrix.GetLength(0);

        int[] sums = new int[2 * n - 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int diagonalIndex = j - i + (n - 1);
                sums[diagonalIndex] += matrix[i, j];
            }
        }

        return sums;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        if (matrix.Length == 0 || matrix.GetLength(0) != matrix.Length / matrix.GetLength(0) || k > matrix.GetLength(0) || k < 1) { return null; }
        int maxAbsValue = int.MinValue;
        int maxRow = -1;
        int maxCol = -1;
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > maxAbsValue)
                {
                    maxAbsValue = Math.Abs(matrix[i, j]);
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        if (maxRow != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[k - 1, j];
                matrix[k - 1, j] = matrix[maxRow, j];
                matrix[maxRow, j] = temp;
            }
        }
        if (maxCol != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, k - 1];
                matrix[i, k - 1] = matrix[i, maxCol];
                matrix[i, maxCol] = temp;
            }
        }

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        if (matrix.Length != 35 || matrix.GetLength(0) != 5) return null;

        int[] negativeCounts = new int[7];

        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                {
                    negativeCounts[j]++;
                }
            }
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                if (negativeCounts[j] > negativeCounts[j + 1])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                    int tempCount = negativeCounts[j];
                    negativeCounts[j] = negativeCounts[j + 1];
                    negativeCounts[j + 1] = tempCount;
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        if (matrix.Length == 0) return null;

        int n = matrix.GetLength(0);
        int m = matrix.Length / matrix.GetLength(0);
        bool[] withoutzero = new bool[n];
        int numwz = 0;
        for (int i = 0; i < n; i++)
        {
            withoutzero[i] = true;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) withoutzero[i] = false;
            }
            if (withoutzero[i]) numwz++;
        }
        if (numwz == 0) return null;
        int[,] newmatrix = new int[numwz, m];
        int cur = 0;
        for (int i = 0; i < n; i++)
        {
            if (withoutzero[i])
            {
                for (int j = 0; j < m; j++)
                {
                    newmatrix[cur, j] = matrix[i, j];
                }
                cur++;
            }
        }

        return newmatrix;
    }
    #endregion
}