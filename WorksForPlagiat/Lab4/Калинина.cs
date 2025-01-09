using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0; // Возвращаем 0 в случае некорректной матрицы
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                answer += A[i, j];
            }
        }
        // code here

        // end

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
        int row = -1, col = -1;
        int minValue = int.MaxValue;

        if (A == null || A.GetLength(0) != 3 || A.GetLength(1) != 6)
        {
            return (0, 0); 
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minValue)
                {
                    minValue = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        // code here

        // end

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
        
        if (A == null || A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return null; 
        }

        int[] answer = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;
        }
        // code here

        // end

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

        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        int maxRowIndex = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > A[maxRowIndex, 2])
            {
                maxRowIndex = i;
            }
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int temp = A[maxRowIndex, j];
            A[maxRowIndex, j] = A[3, j];
            A[3, j] = temp;
        }
        // code here

        // end

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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }

        int maxDiagonalValue = A[0, 0];
        int maxDiagonalIndex = 0;

        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxDiagonalValue)
            {
                maxDiagonalValue = A[i, i];
                maxDiagonalIndex = i;
            }
        }

        for (int j = 0; j < A.GetLength(0); j++)
        {
            int temp = A[j, 3];
            A[j, 3] = A[j, maxDiagonalIndex];
            A[j, maxDiagonalIndex] = temp;
        }
        // code here

        // end

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
        if (A == null || n <= 0 || m <= 0)
        {
            return A;
        }

        for (int i = 0; i < n; i++)
        {
            int maxIndex = 0;
            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > A[i, maxIndex])
                {
                    maxIndex = j;
                }
            }

            int maxValue = A[i, maxIndex];
            for (int j = maxIndex; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = maxValue;
        }
        // code here

        // end

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
        for (int i = 0; i < n; i++)
        {
            double maxElement = double.MinValue;
            int maxIndex = -1;

            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > maxElement)
                {
                    maxElement = C[i, j];
                    maxIndex = j;
                }
            }

            if (maxIndex != -1)
            {
                for (int j = 0; j < maxIndex; j++)
                {
                    if (C[i, j] < 0)
                    {
                        C[i, j] /= maxElement;
                    }
                }
            }
        }

        // code here

        // end

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

        if (Z == null || Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
        {
            return null;
        }

        double maxElement = double.MinValue;
        double sumPositive = 0;
        int countPositive = 0;

        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > maxElement)
                {
                    maxElement = Z[i, j];
                }
                
                if (Z[i, j] > 0)
                {
                    sumPositive += Z[i, j];
                    countPositive++;
                }
            }
        }

        double averagePositive = countPositive > 0 ? sumPositive / countPositive : 0;

        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] == maxElement)
                {
                    Z[i, j] = averagePositive;
                }
            }
        }
        // code here

        // end

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
        if (X == null || X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }

        int minNegativeCount = int.MaxValue;
        int maxNegativeCount = int.MinValue;
        int minRowIndex = -1;
        int maxRowIndex = -1;

        for (int i = 0; i < X.GetLength(0); i++)
        {
            int negativeCount = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    negativeCount++;
                }
            }

            if (negativeCount < minNegativeCount)
            {
                minNegativeCount = negativeCount;
                minRowIndex = i;
            }
            if (negativeCount > maxNegativeCount)
            {
                maxNegativeCount = negativeCount;
                maxRowIndex = i;
            }
        }

        if (minRowIndex != -1 && maxRowIndex != -1)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                int temp = X[minRowIndex, j];
                X[minRowIndex, j] = X[maxRowIndex, j];
                X[maxRowIndex, j] = temp;
            }
        }
        // code here

        // end

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
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null; 
        }

        int maxPositiveSum = int.MinValue; 
        int maxRowIndex = -1;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int positiveSum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
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

        if (maxRowIndex != -1)
        {
            int[,] result = new int[A.GetLength(0) - 1, A.GetLength(1)];
            int resultRow = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (i != maxRowIndex)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        result[resultRow, j] = A[i, j];
                    }
                    resultRow++;
                }
            }

            return result;
        }
        // code here

        // end

        return A;
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
    if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 8 || B == null || B.Length != 5)
    {
        return null; 
    }

    int minElementIndex = 0;
    for (int j = 1; j < A.GetLength(1) - 1; j++) 
    {
        if (A[4, j] < A[4, minElementIndex])
        {
            minElementIndex = j;
        }
    }

    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = A.GetLength(1) - 1; j > minElementIndex + 1; j--)
        {
            A[i, j] = A[i, j - 1];
        }
    }

    for (int i = 0; i < B.Length; i++)
    {
        A[i, minElementIndex + 1] = B[i];
    }
        // code here

        // end

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return default(double[,]);

        for (int row = 0; row < A.GetLength(0); row++)
        {
            int maxElementIndex = 0;
            
            for (int col = 1; col < A.GetLength(1); col++)
            {
                if (A[row, maxElementIndex] < A[row, col])
                {
                    maxElementIndex = col;
                }
            }
           
            switch (maxElementIndex)
            {
                case 0:
                    if (A[row, maxElementIndex + 1] < 0)
                        A[row, maxElementIndex + 1] /= 2;
                    else
                        A[row, maxElementIndex + 1] *= 2;
                    break;
                case 6:
                    if (A[row, maxElementIndex - 1] < 0)
                        A[row, maxElementIndex - 1] /= 2;
                    else
                        A[row, maxElementIndex - 1] *= 2;
                    break;
                default:
                    if (A[row, maxElementIndex + 1] > A[row, maxElementIndex - 1])
                        if (A[row, maxElementIndex - 1] < 0)
                            A[row, maxElementIndex - 1] /= 2;
                        else
                            A[row, maxElementIndex - 1] *= 2;
                    else
                        if (A[row, maxElementIndex + 1] < 0)
                        A[row, maxElementIndex + 1] /= 2;
                    else
                        A[row, maxElementIndex + 1] *= 2;
                    break;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return default(int[,]);

        for (int col = 0; col < A.GetLength(1); col++)
        {
            int maxElementRow = 0;
            int balance = 0;
           
            for (int row = 1; row < A.GetLength(0); row++)
            {
                if (A[row, col] < 0)
                    balance--;
                else
                    balance++;
                if (A[maxElementRow, col] < A[row, col])
                    maxElementRow = row;
            }
            if (balance > 0)
                A[maxElementRow, col] = 0;
            else
                A[maxElementRow, col] = maxElementRow + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return default(int[,]);

        for (int col = 0; col < A.GetLength(1); col++)
        {
            int maxElementRow = 0;
           
            for (int row = 1; row < A.GetLength(0); row++)
            {
                if (A[maxElementRow, col] < A[row, col])
                    maxElementRow = row;
            }
            if (maxElementRow > 4)
                continue;
            int sum = 0;
            for (int row = maxElementRow + 1; row < A.GetLength(0); row++)
                sum += A[row, col];
            A[0, col] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return default(int[,]);

        for (int col = 0; col < A.GetLength(1); col++)
        {
            int maxElementRow = 0;
            
            for (int row = 1; row < A.GetLength(0); row++)
            {
                if (A[maxElementRow, col] < A[row, col])
                    maxElementRow = row;
            }
            if (A[maxElementRow, col] < B[col])
                A[maxElementRow, col] = B[col];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return default(double[,]);

        for (int col = 0; col < A.GetLength(1); col++)
        {
            int maxElementRow = 0;
            
            for (int row = 1; row < A.GetLength(0); row++)
            {
                if (A[maxElementRow, col] < A[row, col])
                    maxElementRow = row;
            }
            double halfSum = (A[0, col] + A[A.GetLength(0) - 1, col]) / 2;
            if (A[maxElementRow, col] < halfSum)
                A[maxElementRow, col] = halfSum;
            else
                A[maxElementRow, col] = maxElementRow + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0)
            return null;

        int[,] answer = default(int[,]);
        
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, i + n] = 1;
            answer[i, i + 2 * n] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;

        int maxDiaglIndex = 0;
        for (int row = 1; row < A.GetLength(0); row++)
        {
            if (A[maxDiaglIndex, maxDiaglIndex] < A[row, row])
                maxDiaglIndex = row;
        }
        for (int row = 0; row < maxDiaglIndex; row++)
        {
            for (int col = row + 1; col < A.GetLength(1); col++)
            {
                A[row, col] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;

        int lastMaxIndex = 0;
        for (int row = 0; row < B.GetLength(0); row++)
        {
            int maxElementIndex = 0;
            for (int col = 0; col < B.GetLength(1); col++)
            {
                if (B[row, col] > B[row, maxElementIndex])
                    maxElementIndex = col;
            }
            if (row % 2 == 0)
            {
                lastMaxIndex = maxElementIndex;
            }
            else
            {
                int temp = B[row - 1, lastMaxIndex];
                B[row - 1, lastMaxIndex] = B[row, maxElementIndex];
                B[row, maxElementIndex] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        for (int row = 0; row < A.GetLength(0); row++)
        {
            for (int col = 0; col < A.GetLength(1) / 2; col++)
            {
                int temp = A[row, col];
                A[row, col] = A[row, A.GetLength(1) - 1 - col];
                A[row, A.GetLength(1) - 1 - col] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        int currentRow = 0, currentCol = 0;
        for (int i = 0; i < matrix.GetLength(0) * 4 - 4; i++)
        {
            matrix[currentRow, currentCol] = 0;
            if (i < matrix.GetLength(0) - 1)
                currentCol++;
            else if (i < matrix.GetLength(0) * 2 - 2)
                currentRow++;
            else if (i < matrix.GetLength(0) * 3 - 3)
                currentCol--;
            else
                currentRow--;
        }
        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        for (int row = (matrix.GetLength(0) / 2); row < matrix.GetLength(0); row++)
            for (int col = 0; col < row + 1; col++)
                matrix[row, col] = 1;
        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);

        int[] upper = default(int[]);
        int[] lower = default(int[]);
        int len = matrix.GetLength(0);
        upper = new int[(1 + len) * len / 2];
        lower = new int[len * len - upper.Length];

        int upperPointer = 0, lowerPointer = 0;
        for (int row = 0; row < len; row++)
            for (int col = row; col < len; col++)
                upper[upperPointer++] = matrix[row, col];

        for (int row = 0; row < len; row++)
            for (int col = 0; col < row; col++)
                lower[lowerPointer++] = matrix[row, col];


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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return null;

        int[] balance = new int[matrix.GetLength(0)];
        int[] sortedIndexes = new int[matrix.GetLength(0)];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sortedIndexes[row] = row;
            for (int col = 0; col < matrix.GetLength(1); col++)
                balance[row] += matrix[row, col] < 0 ? -1 : 1;
        }

        bool isNotSorted = true;
        while (isNotSorted)
        {
            isNotSorted = false;
            for (int i = 0; i < balance.Length - 1; i++)
            {
                if (balance[i] < balance[i + 1])
                {
                    isNotSorted = true;
                    int temp = balance[i];
                    balance[i] = balance[i + 1];
                    balance[i + 1] = temp;

                    temp = sortedIndexes[i];
                    sortedIndexes[i] = sortedIndexes[i + 1];
                    sortedIndexes[i + 1] = temp;
                }
            }
        }

        // Создание нового массива для хранения отсортированных строк
        int[,] sortedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < sortedIndexes.Length; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
                sortedMatrix[row, col] = matrix[sortedIndexes[row], col];
        }
        matrix = sortedMatrix;
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // Здесь код задачи
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            bool isUnsorted = true;
            while (isUnsorted)
            {
                isUnsorted = false;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((row % 2 == 0 && matrix[row, col] < matrix[row, col + 1]) ||
                        (row % 2 != 0 && matrix[row, col] > matrix[row, col + 1]))
                    {
                        isUnsorted = true;
                        int temp = matrix[row, col];
                        matrix[row, col] = matrix[row, col + 1];
                        matrix[row, col + 1] = temp;
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0)
                {
                    rowCount--;
                    matrix[row, 0] = 0;
                    break;
                }
            }
        }

        int[,] newmatrix = new int[rowCount, matrix.GetLength(1)];
        int newRowIndex = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (matrix[row, 0] != 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    newmatrix[newRowIndex, col] = matrix[row, col];
                }
                newRowIndex++;
            }
        }
        matrix = newmatrix;
        // end

        return matrix;
    }
    #endregion
}