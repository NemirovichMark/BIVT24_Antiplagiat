using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j], 3} ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        Program program = new Program();
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7)
            return 0.0;

        double cumSum = 0.0;
        int counter = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] <= 0)
                    continue;
                cumSum += A[i, j];
                counter++;
            }
        }

        answer = cumSum / counter;
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
        int row = 0,
            col = 0;
        // code here

        // end

        return (row, col);
    }

    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0,
            rowIndex = -1;
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 4)
            return (0, 0);

        for (int row = 0; row < rows; row++)
        {
            if (A[row, colIndex] >= 0)
                continue;
            value = A[row, colIndex];
            rowIndex = row;
            break;
        }
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
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }

    public double[] Task_1_8(int[,] A)
    {
        double[] answer = new double[4];
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 4 || cols != 6)
            return null;
        double cumSum = 0.0;
        int count = 0;
        double avg = 0.0;

        for (int row = 0; row < rows; row++)
        {
            cumSum = 0.0;
            count = 0;
            for (int col = 0; col < cols; col++)
            {
                if (A[row, col] <= 0.0)
                    continue;
                cumSum += A[row, col];
                count++;
            }

            if (count == 0)
                avg = 0;
            else
                avg = cumSum / count;

            answer[row] = avg;
        }
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
        // code here

        // end

        return A;
    }

    public int[,] Task_1_11(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7)
            return null;

        int[,] B = new int[4, 7];
        int rowToRemove = -1;
        int minInFirstCol = int.MaxValue;

        for (int row = 0; row < rows; row++)
        {
            if (A[row, 0] >= minInFirstCol)
                continue;
            minInFirstCol = A[row, 0];
            rowToRemove = row;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row < rowToRemove)
                {
                    B[row, col] = A[row, col];
                }
                else if (row > rowToRemove)
                {
                    B[row - 1, col] = A[row, col];
                }
            }
        }
        // end

        return B;
    }

    public int[,] Task_1_12(int[,] A)
    {
        // code here

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
        int[] answer = new int[3];
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 4 || cols != 3)
            return null;

        int count = 0;
        for (int col = 0; col < cols; col++)
        {
            count = 0;
            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] >= 0)
                    continue;

                count++;
            }

            answer[col] = count;
        }
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
        // code here

        // end

        return A;
    }

    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows != n || cols != m)
            return null;

        int minElement,
            minElementIndex;

        for (int row = 0; row < rows; row++)
        {
            minElement = int.MaxValue;
            minElementIndex = -1;
            for (int col = 0; col < cols; col++)
            {
                if (B[row, col] >= minElement)
                    continue;
                minElement = B[row, col];
                minElementIndex = col;
            }

            for (int col = cols - 1; col >= 0; col--)
            {
                if (col == 0)
                    continue;
                if (col <= minElementIndex)
                    B[row, col] = B[row, col - 1];
            }
            B[row, 0] = minElement;
        }
        PrintMatrix(B);

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
        // code here

        // end

        return C;
    }

    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        int rows = F.GetLength(0);
        int cols = F.GetLength(1);

        if (rows != n || cols != m)
            return null;

        double maxElement;
        int maxElementCol;
        int firstNegativeCol,
            lastNegativeCol;

        for (int row = 0; row < rows; row++)
        {
            maxElement = double.MinValue;
            maxElementCol = -1;
            firstNegativeCol = -1;
            lastNegativeCol = -1;

            for (int col = 0; col < cols; col++)
            {
                if (F[row, col] <= maxElement)
                    continue;
                maxElement = F[row, col];
                maxElementCol = col;
            }

            for (int col = 0; col < cols; col++)
            {
                if (F[row, col] < 0)
                    lastNegativeCol = col;
            }

            for (int col = cols - 1; col >= 0; col--)
            {
                if (F[row, col] < 0)
                    firstNegativeCol = col;
            }

            if (firstNegativeCol == -1 || lastNegativeCol == -1)
                continue;

            F[row, maxElementCol] = (F[row, firstNegativeCol] + F[row, lastNegativeCol]) / 2.0;
        }

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
        // code here

        // end

        return Z;
    }

    public int[,] Task_1_23(int[,] G)
    {
        // code here
        int rows = G.GetLength(0);
        int cols = G.GetLength(1);

        if (rows != 5 || cols != 7)
            return null;

        int maxElement,
            maxElementCol;

        for (int row = 0; row < rows; row++)
        {
            maxElement = int.MinValue;
            maxElementCol = -1;
            for (int col = 0; col < cols; col++)
            {
                if (G[row, col] > maxElement)
                {
                    maxElement = G[row, col];
                    maxElementCol = col;
                }
            }

            for (int col = cols - 1; col > maxElementCol; col--)
            {
                G[row, col] = G[row, col - 1];
            }
        }
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
        // code here

        // end

        return X;
    }

    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int b_len = B.GetLength(0);

        if (rows != 5 || cols != 7)
            return null;
        if (b_len != cols)
            return null;

        int maxElementInSixthCol = int.MinValue;
        int rowToReplace = 0;

        for (int row = 0; row < rows; row++)
        {
            if (A[row, 5] <= maxElementInSixthCol)
                continue;
            maxElementInSixthCol = A[row, 5];
            rowToReplace = row;
        }

        for (int col = 0; col < cols; col++)
        {
            A[rowToReplace, col] = B[col];
        }

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
        // code here

        // end

        return A;
    }

    public int[,] Task_1_29(int[,] F)
    {
        // code here
        int rows = F.GetLength(0);
        int cols = F.GetLength(1);

        if (rows != 5 || cols != 7)
            return null;

        int[,] R = new int[5, 6];
        int minAbsElementInSecondRow = int.MaxValue;
        int colToRemove = 0;

        for (int col = 0; col < cols; col++)
        {
            if (Math.Abs(F[1, col]) >= minAbsElementInSecondRow)
                continue;
            minAbsElementInSecondRow = Math.Abs(F[1, col]);
            colToRemove = col + 1;
        }

        if (colToRemove > 6)
            return null;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col < colToRemove)
                    R[row, col] = F[row, col];
                if (col > colToRemove)
                    R[row, col - 1] = F[row, col];
            }
        }
        // end

        return R;
    }

    public int[,] Task_1_30(int[,] B)
    {
        // code here

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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7)
            return null;

        double maxElement;
        int maxElementCol;
        int positiveCount;
        double cumSum;

        for (int row = 0; row < rows; row++)
        {
            maxElement = double.MinValue;
            maxElementCol = 0;
            positiveCount = 0;
            cumSum = 0.0;

            for (int col = 0; col < cols; col++)
            {
                if (A[row, col] <= maxElement)
                    continue;
                maxElement = A[row, col];
                maxElementCol = col;
            }

            for (int col = 0; col < cols; col++)
            {
                if (A[row, col] <= 0)
                    continue;
                positiveCount++;
                cumSum += A[row, col];
            }

            if (positiveCount != 0)
                A[row, maxElementCol] = cumSum / positiveCount;
            else
                A[row, maxElementCol] = 0;
        }
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7)
            return null;

        int maxElementCol;
        double maxElement;

        for (int row = 0; row < rows; row++)
        {
            maxElement = double.MinValue;
            maxElementCol = 0;

            for (int col = 0; col < cols; col++)
            {
                if (A[row, col] <= maxElement)
                    continue;
                maxElement = A[row, col];
                maxElementCol = col;
            }

            if (maxElementCol == 0)
                if (A[row, 1] > 0)
                    A[row, 1] *= 2.0;
                else
                    A[row, 1] /= 2.0;
            else if (maxElementCol == 6)
                if (A[row, 5] > 0)
                    A[row, 5] *= 2.0;
                else
                    A[row, 5] /= 2.0;
            else
            {
                if (A[row, maxElementCol - 1] > A[row, maxElementCol + 1])
                    if (A[row, maxElementCol + 1] > 0)
                        A[row, maxElementCol + 1] *= 2.0;
                    else
                        A[row, maxElementCol + 1] /= 2.0;
                else if (A[row, maxElementCol + 1] > A[row, maxElementCol - 1])
                    if (A[row, maxElementCol - 1] > 0)
                        A[row, maxElementCol - 1] *= 2.0;
                    else
                        A[row, maxElementCol - 1] /= 2.0;
            }
        }
        // end

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5)
            return null;

        int maxElement,
            maxElementRow,
            negativeAmount,
            positiveAmount;

        for (int col = 0; col < cols; col++)
        {
            maxElement = int.MinValue;
            maxElementRow = 0;
            negativeAmount = 0;
            positiveAmount = 0;

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] > 0)
                    positiveAmount++;
                else if (A[row, col] < 0)
                    negativeAmount++;
            }

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] <= maxElement)
                    continue;
                maxElement = A[row, col];
                maxElementRow = row;
            }

            if (positiveAmount > negativeAmount)
                A[maxElementRow, col] = 0;
            else if (positiveAmount < negativeAmount)
                A[maxElementRow, col] = maxElementRow;
        }
        // end

        return A;
    }

    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 10 || cols != 5)
            return null;

        int maxElement,
            maxElementRow,
            sum;

        for (int col = 0; col < cols; col++)
        {
            maxElement = int.MinValue;
            maxElementRow = 0;
            sum = 0;

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] <= maxElement)
                    continue;
                maxElement = A[row, col];
                maxElementRow = row;
            }

            if (maxElementRow > 4)
                continue;

            for (int row = maxElementRow + 1; row < rows; row++)
            {
                sum += A[row, col];
            }

            A[0, col] = sum;
        }
        // end

        return A;
    }

    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int bLen = B.GetLength(0);

        if (rows != 7 || cols != 5 || bLen != 5)
            return null;

        int maxElementInCol,
            maxElementInColRow;

        for (int col = 0; col < cols; col++)
        {
            maxElementInCol = int.MinValue;
            maxElementInColRow = 0;

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] <= maxElementInCol)
                    continue;
                maxElementInCol = A[row, col];
                maxElementInColRow = row;
            }

            if (B[col] <= maxElementInCol)
                continue;

            A[maxElementInColRow, col] = B[col];
        }
        // end

        return A;
    }

    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5)
            return null;

        double maxElementInCol,
            edgeElementsHalphSum;
        int maxElementInColRow;

        for (int col = 0; col < cols; col++)
        {
            maxElementInCol = double.MinValue;
            maxElementInColRow = 0;

            for (int row = 0; row < rows; row++)
            {
                if (A[row, col] <= maxElementInCol)
                    continue;
                maxElementInCol = A[row, col];
                maxElementInColRow = row;
            }

            edgeElementsHalphSum = (A[0, col] + A[6, col]) / 2.0;

            if (maxElementInCol < edgeElementsHalphSum)
                A[maxElementInColRow, col] = edgeElementsHalphSum;
            else if (maxElementInCol > edgeElementsHalphSum)
                A[maxElementInColRow, col] = maxElementInColRow;
        }
        // end

        return A;
    }

    public int[,] Task_2_6(int n)
    {
        if (n <= 0)
            return null;
        int[,] answer = new int[n, 3 * n];
        int rows = n;
        int cols = 3 * n;
        // code here
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col % n == row)
                    answer[row, col] = 1;
                else
                    answer[row, col] = 0;
            }
        }
        // end

        return answer;
    }

    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 6 || cols != 6)
            return null;

        int maxElementOnPrimDiag = int.MinValue;
        int maxElementOnPrimDiagRow = 0;

        for (int row = 0; row < rows; row++)
        {
            if (A[row, row] <= maxElementOnPrimDiag)
                continue;
            maxElementOnPrimDiag = A[row, row];
            maxElementOnPrimDiagRow = row;
        }

        for (int row = 0; row < maxElementOnPrimDiagRow; row++)
        {
            for (int col = row + 1; col < cols; col++)
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
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows != 6 || cols != 6)
            return null;

        int maxElementInRowA,
            maxElementInRowB,
            maxElementInRowACol,
            maxElementInRowBCol;

        for (int seg = 0; seg < 3; seg++)
        {
            maxElementInRowA = int.MinValue;
            maxElementInRowB = int.MinValue;
            maxElementInRowACol = 0;
            maxElementInRowBCol = 0;

            for (int col = 0; col < cols; col++)
            {
                if (B[seg * 2, col] <= maxElementInRowA)
                    continue;
                maxElementInRowA = B[seg * 2, col];
                maxElementInRowACol = col;
            }

            for (int col = 0; col < cols; col++)
            {
                if (B[seg * 2 + 1, col] <= maxElementInRowB)
                    continue;
                maxElementInRowB = B[seg * 2 + 1, col];
                maxElementInRowBCol = col;
            }

            B[seg * 2 + 1, maxElementInRowBCol] = maxElementInRowA;
            B[seg * 2, maxElementInRowACol] = maxElementInRowB;
        }
        // end

        return B;
    }

    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 6 || cols != 7)
            return null;

        int temp;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols / 2; col++)
            {
                temp = A[row, col];
                A[row, col] = A[row, cols - col - 1];
                A[row, cols - col - 1] = temp;
            }
        }
        // end

        return A;
    }
    #endregion


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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
            return null;

        int row,
            col;
        for (int i = 0; i < rows * cols; i++)
        {
            row = i / cols;
            col = i % cols;

            if (row == 0 || row == rows - 1)
                matrix[row, col] = 0;
            else if (col == 0 || col == cols - 1)
                matrix[row, col] = 0;
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
            return null;

        for (int row = rows / 2; row < rows; row++)
        {
            for (int col = 0; col < row + 1; col++)
            {
                matrix[row, col] = 1;
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
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
            return (null, null);

        int upperLen = 0;
        for (int i = rows; i >= 0; i--)
        {
            upperLen += i;
        }

        int lowerLen = rows * cols - upperLen;

        int[] upper = new int[upperLen];
        int[] lower = new int[lowerLen];

        int upperCnt = 0,
            lowerCnt = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col >= row)
                {
                    upper[upperCnt++] = matrix[row, col];
                }
                else
                {
                    lower[lowerCnt++] = matrix[row, col];
                }
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < (rows - row); col++)
            {
                Console.Write($"{upper[row * cols + col]}\t");
            }
            System.Console.WriteLine();
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write($"{upper[row * cols + col]}\t");
            }
            System.Console.WriteLine();
        }

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

        if (rows != 7 || cols != 5)
            return null;

        int[,] row_to_amount_of_positive = new int[7, 2];

        for (int row = 0; row < rows; row++)
        {
            row_to_amount_of_positive[row, 0] = row;

            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] > 0)
                {
                    row_to_amount_of_positive[row, 1]++;
                }
            }
        }

        for (int j = 0; j < rows - 1; j++)
        {
            for (int i = 0; i < rows - j - 1; i++)
            {
                if (row_to_amount_of_positive[i, 1] < row_to_amount_of_positive[i + 1, 1])
                {
                    int temp1 = row_to_amount_of_positive[i + 1, 0];
                    int temp2 = row_to_amount_of_positive[i + 1, 1];

                    row_to_amount_of_positive[i + 1, 0] = row_to_amount_of_positive[i, 0];
                    row_to_amount_of_positive[i + 1, 1] = row_to_amount_of_positive[i, 1];
                    row_to_amount_of_positive[i, 0] = temp1;
                    row_to_amount_of_positive[i, 1] = temp2;
                }
            }
        }

        int[,] output = new int[7, 5];

        for (int copyright = 0; copyright < rows; copyright++)
        {
            int row = row_to_amount_of_positive[copyright, 0];
            for (int col = 0; col < cols; col++)
            {
                output[copyright, col] = matrix[row, col];
            }
        }
        // end

        return output;
    }

    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }

    public int[,] Task_3_10(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        // code here
        for (int row = 0; row < rows; row++)
        {
            for (int i = 0; i < cols - 1; i++)
            {
                for (int col = 0; col < cols - 1 - i; col++)
                {
                    if ((row % 2 == 0) && (matrix[row, col] < matrix[row, col + 1]))
                    {
                        (matrix[row, col], matrix[row, col + 1]) = (
                            matrix[row, col + 1],
                            matrix[row, col]
                        );
                    }
                    if ((row % 2 != 0) && (matrix[row, col] > matrix[row, col + 1]))
                    {
                        (matrix[row, col], matrix[row, col + 1]) = (
                            matrix[row, col + 1],
                            matrix[row, col]
                        );
                    }
                }
            }
        }
        // end
        PrintMatrix(matrix);
        return matrix;
    }

    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int outputRows = rows;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == 0)
                {
                    outputRows--;
                    break;
                }
            }
        }

        int[,] output = new int[outputRows, cols];
        bool flag = true;
        int curRow = 0;

        for (int row = 0; row < rows; row++)
        {
            flag = true;

            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == 0)
                {
                    flag = false;
                    break;
                }
            }

            if (!flag)
                continue;

            for (int col = 0; col < cols; col++)
            {
                output[curRow, col] = matrix[row, col];
            }

            curRow++;
        }
        // end

        return output;
    }
    #endregion
}
