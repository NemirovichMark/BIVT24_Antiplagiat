using System;
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
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 }
            };
        program.Task_1_12(matrix);

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
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
        int n = A.GetLength(0);
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) { return 0; }
        for (int i = 0; i < n; i++)
        {
            answer += A[i, i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
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

        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int row = A.GetLength(0); 
        int col = A.GetLength(1); 
        int[] answer = new int[row];
        for (int i = 0; i < row; i++)
        {
            int amin = A[i, 0]; 
            int imin = 0; 

            
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] < amin) 
                {
                    amin = A[i, j]; 
                    imin = j;
                }
            }
            answer[i] = imin;
        
        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        for (int i = 0; i < row;i++)
        {
            int amax = A[i, 0];
            int imax = 0;
            for (int j = 0; j < col;j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = j;
                }
            }
            int p = A[i, imax];
            A[i, imax] = A[i,0];
            A[i, 0] = p;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int amax = A[0, 0];
        int imax = 0;
        int jmax = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col;j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        int[,] temp = new int[row-1, col-1];
        for (int i = 0, itemp = 0; i < row; i++)
        {
            if (i == imax) continue;

            for (int j = 0, jtemp = 0; j < col; j++)
            {
                if (j == jmax) continue;

                temp[itemp, jtemp] = A[i, j];
                jtemp++;
            }
            itemp++;

        }
        A = temp;
        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        for (int i =0; i < row; i++)
        {
            int amax = A[i, 0];
            int imax = 0;
            for (int j = 0;j < col; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = j;
                }
            }
            A[i, imax] *= (i + 1);
        }
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
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
        
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;

        for (int row = 0; row < n; row++)
        {
            int maxIndex = -1;
            int maxValue = int.MinValue;
            int lastNegativeIndex = -1;
            int firstNegativeIndex = -1;

            for (int col = m - 1; col >= 0; col--)
            {
                if (D[row, col] < 0)
                {
                    lastNegativeIndex = col;
                    break;
                }
            }

            for (int col = 0; col < m; col++)
            {
                if (D[row, col] < 0)
                {
                    firstNegativeIndex = col;
                    break;
                }
            }

            if (firstNegativeIndex == -1) continue;

            for (int col = 0; col < firstNegativeIndex; col++)
            {
                if (D[row, col] > maxValue)
                {
                    maxValue = D[row, col];
                    maxIndex = col;
                }
            }

            if (maxIndex != -1)
            {
                int buffer = D[row, maxIndex];
                D[row, maxIndex] = D[row, lastNegativeIndex];
                D[row, lastNegativeIndex] = buffer;
            }
        }


            // end

            return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int maxElement = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > maxElement)
                {
                    maxElement = H[i, j];
                }
            }
            int temp = H[i, 5];
            H[i, 5] = maxElement;
            H[i, 6] = temp;
        }
        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;

        for (int row = 0; row < 6; row++)
        {
            double maxElement = double.MinValue;
            int maxIndex = -1;
            for (int col = 0; col < 5; col++)
            {
                if (Y[row, col] > maxElement)
                {
                    maxElement = Y[row, col];
                    maxIndex = col;
                }
            }

            double positiveSum = 0;
            int positiveCount = 0;

            for (int col = maxIndex + 1; col < 5; col++)
            {
                if (Y[row, col] > 0)
                {
                    positiveCount++;
                    positiveSum += Y[row, col];
                }
            }

            double avgPositive = positiveCount == 0 ? 0 : positiveSum / positiveCount;

            for (int col = 0; col < maxIndex; col++)
            {
                if (Y[row, col] < 0)
                {
                    Y[row, col] = avgPositive;
                }
            }
        }
        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
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
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        if (n != 5 || m != 7) return null;

        for (int i = 0; i <= n / 2; i++)  // Правильный цикл, включающий среднюю строку
        {
            int maxFirstRow = B[i, 0];
            int maxFirstRowIndex = 0;
            int maxSecondRow = B[n - i - 1, 0];
            int maxSecondRowIndex = 0;

            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > maxFirstRow)
                {
                    maxFirstRow = B[i, j];
                    maxFirstRowIndex = j;
                }

                if (B[n - i - 1, j] > maxSecondRow)
                {
                    maxSecondRow = B[n - i - 1, j];
                    maxSecondRowIndex = j;
                }
            }

            int temp = maxSecondRow;
            B[n - i - 1, 3] = maxFirstRow;
            B[i, 3] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;

        int maxElement = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > maxElement)
            {
                maxElement = B[i, i];
                maxIndex = i;
            }
        }

        int rowWithNegative = -1;

        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                rowWithNegative = i;
                break;
            }
        }

        if (rowWithNegative == -1) return B;  // если нет отрицательных элементов в 3-м столбце, вернуть без изменений

        for (int j = 0; j < B.GetLength(1); j++)
        {
            int temp = B[maxIndex, j];
            B[maxIndex, j] = B[rowWithNegative, j];
            B[rowWithNegative, j] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
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

        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        int negativeCount = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    negativeCount++;
                }
            }
        }

        if (negativeCount == 0) return null;

        int[] answer = new int[negativeCount];
        int index = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[index] = A[i, j];
                    index++;
                }
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        if (n != 5 || m != 7)
            return null;

        int maxColumn;
        double maxElement;

        for (int row = 0; row < n; row++)
        {
            maxElement = double.MinValue;
            maxColumn = 0;

            for (int col = 0; col < m; col++)
            {
                if (A[row, col] <= maxElement)
                    continue;
                maxElement = A[row, col];
                maxColumn = col;
            }

            if (maxColumn == 0)
            {
                if (A[row, 1] > 0)
                    A[row, 1] *= 2.0;
                else
                    A[row, 1] /= 2.0;
            }
            else if (maxColumn == 6)
            {
                if (A[row, 5] > 0)
                    A[row, 5] *= 2.0;
                else
                    A[row, 5] /= 2.0;
            }
            else
            {
                if (A[row, maxColumn - 1] > A[row, maxColumn + 1])
                {
                    if (A[row, maxColumn + 1] > 0)
                        A[row, maxColumn + 1] *= 2.0;
                    else
                        A[row, maxColumn + 1] /= 2.0;
                }
                else if (A[row, maxColumn + 1] > A[row, maxColumn - 1])
                {
                    if (A[row, maxColumn - 1] > 0)
                        A[row, maxColumn - 1] *= 2.0;
                    else
                        A[row, maxColumn - 1] /= 2.0;
                }
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);

        if (rows != 7 || columns != 5)
            return null;

        for (int col = 0; col < columns; col++)
        {
            int maxVal = A[0, col];
            int maxIdx = 0;
            int positiveCount = 0;
            int negativeCount = 0;

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] > maxVal)
                {
                    maxVal = A[row, col];
                    maxIdx = row;
                }

                if (A[row, col] > 0)
                    positiveCount++;
                else if (A[row, col] < 0)
                    negativeCount++;
            }

            if (positiveCount > negativeCount)
            {
                A[maxIdx, col] = 0;
            }
            else
            {
                A[maxIdx, col] = maxIdx + 1; 
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0); 
        int columns = A.GetLength(1); 

        if (rows != 10 || columns != 5)
            return null; 


        for (int col = 0; col < columns; col++)
        {
            int maxVal = A[0, col]; 
            int maxIdx = 0; 
            int sum = 0;


            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] > maxVal)
                {
                    maxVal = A[row, col];
                    maxIdx = row; 
                }
            }


            if (maxIdx < rows / 2)
            {
                sum = 0;

                for (int row = maxIdx + 1; row < rows; row++)
                {
                    sum += A[row, col];
                }


                A[0, col] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5 || B.Length != 5)
            return null;

        for (int j = 0; j < cols; j++)
        {
            int currentMax = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > currentMax)
                {
                    currentMax = A[i, j];
                    maxIndex = i;
                }
            }

            if (B[j] > currentMax)
            {
                A[maxIndex, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            double halfSum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;

            if (max < halfSum)
                A[maxIndex, j] = halfSum;
            else
                A[maxIndex, j] = maxIndex + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {

        // code here
        if (n < 0) return null;

        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j += 3)
            {
                answer[i, j] = 1;
                answer[i, j + n] = 1;
                answer[i, j + 2 * n] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int maxDiagonalValue = int.MinValue;
        int maxIndex = -1;

        for (int row = 0; row < 6; row++)
        {
            if (A[row, row] > maxDiagonalValue)
            {
                maxDiagonalValue = A[row, row];
                maxIndex = row;
            }
        }


        for (int row = 0; row < maxIndex; row++)
        {
            for (int col = row + 1; col < 6; col++)
            {
                A[row, col] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        for (int i = 0; i < 6; i += 2)
        {
            int maxFirstRow = int.MinValue, indexFirstRow = -1;
            int maxSecondRow = int.MinValue, indexSecondRow = -1;


            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxFirstRow)
                {
                    maxFirstRow = B[i, j];
                    indexFirstRow = j;
                }
                if (B[i + 1, j] > maxSecondRow)
                {
                    maxSecondRow = B[i + 1, j];
                    indexSecondRow = j;
                }
            }


            int temp = B[i, indexFirstRow];
            B[i, indexFirstRow] = B[i + 1, indexSecondRow];
            B[i + 1, indexSecondRow] = temp;
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 7 / 2; col++)
            {
                int temp = A[row, col];
                A[row, col] = A[row, 7 - col - 1];
                A[row, 7 - col - 1] = temp;
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
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (n != m) return default;

        for (int i = 0; i < n; i++)
        {

            matrix[i, 0] = 0;
            matrix[i, m - 1] = 0;


            if (i == 0 || i == n - 1)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = 0;
                }
            }
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
        // code here
        int n = matrix.GetLength(0);

        if (n != matrix.GetLength(1)) return default;

        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= j) 
                {
                    matrix[i, j] = 1;
                }
            }
        }

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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols) return default;

 


        int upperCount = (rows * (rows + 1)) / 2; 
        int lowerCount = (rows * (rows - 1)) / 2; 


        upper = new int[upperCount];
        lower = new int[lowerCount];

        int upperIndex = 0;
        int lowerIndex = 0;


        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j++)
            {
                upper[upperIndex++] = matrix[i, j]; 
            }
        }

        for (int i = 1; i < rows; i++) 
        {
            for (int j = 0; j < i; j++)
            {
                lower[lowerIndex++] = matrix[i, j]; 
            }
        }
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 7 || cols != 5) return default;


        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                int positiveCountCurrentRow = 0;
                int positiveCountNextRow = 0;


                for (int k = 0; k < cols; k++)
                {
                    if (matrix[j, k] > 0)
                        positiveCountCurrentRow++;
                    if (matrix[j + 1, k] > 0)
                        positiveCountNextRow++;
                }


                if (positiveCountCurrentRow < positiveCountNextRow)
                {
                    for (int m = 0; m < cols; m++)
                    {
                        int temp = matrix[j, m];
                        matrix[j, m] = matrix[j + 1, m];
                        matrix[j + 1, m] = temp;
                    }
                }
            }
        }

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
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 5 || cols != 7)
        {
            return default;
        }


        for (int i = 0; i < rows; i++)
        {

            int gap = cols / 2;

            while (gap > 0)
            {
                for (int j = gap; j < cols; j++)
                {
                    int temp = matrix[i, j];
                    int k = j;


                    if (i % 2 == 0)
                    {
                        while (k >= gap && matrix[i, k - gap] < temp)
                        {
                            matrix[i, k] = matrix[i, k - gap];
                            k -= gap;
                        }
                    }

                    else
                    {
                        while (k >= gap && matrix[i, k - gap] > temp)
                        {
                            matrix[i, k] = matrix[i, k - gap];
                            k -= gap;
                        }
                    }
                    matrix[i, k] = temp;
                }


                gap /= 2;
            }
        }


        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int countZeroRows = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasZero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (hasZero)
                countZeroRows++;
        }

        int[,] resultMatrix = new int[5 - countZeroRows, 7];
        int rowIndex = 0;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasZero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[rowIndex, j] = matrix[i, j];
                }
                rowIndex++;
            }
        }
        // end

        return resultMatrix;
    }
    #endregion
}