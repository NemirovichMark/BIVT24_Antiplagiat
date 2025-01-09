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
        for (int i = 0; i < A.GetLength(0); i++)
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
        if (A.GetLength(1) != 7)
            return null;

        int[] answer = new int[A.GetLength(0)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int minIdx = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] < A[i, minIdx])
                {
                    minIdx = j;
                }
            }
            answer[i] = minIdx;
        }

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
        if (A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxIdx = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxIdx])
                {
                    maxIdx = j;
                }
            }

            int temp = A[i, 0];
            A[i, 0] = A[i, maxIdx];
            A[i, maxIdx] = temp;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        int maxRow = 0, maxCol = 0, maxVal = int.MinValue;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int[,] result = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];

        for (int i = 0, r = 0; i < A.GetLength(0); i++)
        {
            if (i == maxRow) continue;

            for (int j = 0, c = 0; j < A.GetLength(1); j++)
            {
                if (j == maxCol) continue;

                result[r, c] = A[i, j];
                c++;
            }
            r++;
        }

        return result;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxIdx = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxIdx])
                {
                    maxIdx = j;
                }
            }
            A[i, maxIdx] *= (i + 1);
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
        if (D == null || D.GetLength(0) == 0 || D.GetLength(1) == 0)
            return null;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int maxIdx = -1, lastNegIdx = -1;
            int maxVal = int.MinValue;

            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    lastNegIdx = j;
                }
                else if (lastNegIdx == -1 && D[i, j] > maxVal)
                {
                    maxVal = D[i, j];
                    maxIdx = j;
                }
            }

            if (maxIdx != -1 && lastNegIdx != -1)
            {
                int temp = D[i, maxIdx];
                D[i, maxIdx] = D[i, lastNegIdx];
                D[i, lastNegIdx] = temp;
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
        int rows = H.GetLength(0);
        int columns = H.GetLength(1);

        if (rows == 5 && columns == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < columns - 1; j++)
                {
                    if (H[i, j] > max)
                    {
                        max = H[i, j];
                    }
                }

                int temp = H[i, 5];
                H[i, 5] = max;
                H[i, 6] = temp;
            }

            return H;
        }

        return null;
        // end
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
        if (Y.GetLength(1) != 5)
            return null;

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            int maxIdx = 0;
            for (int j = 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > Y[i, maxIdx])
                {
                    maxIdx = j;
                }
            }

            double posSum = 0;
            int posCount = 0;

            for (int j = maxIdx + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    posSum += Y[i, j];
                    posCount++;
                }
            }

            double avg = posCount > 0 ? posSum / posCount : 0;

            for (int j = 0; j < maxIdx; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = avg;
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        return null;

        int[] maxVals = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            maxVals[i] = B[i, 0];
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxVals[i])
                {
                    maxVals[i] = B[i, j];
                }
            }
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = maxVals[B.GetLength(0) - 1 - i];
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
            return null;

        int maxRow = 0;
        int maxDiag = B[0, 0];

        for (int i = 1; i < B.GetLength(0); i++)
        {
            if (B[i, i] > maxDiag)
            {
                maxDiag = B[i, i];
                maxRow = i;
            }
        }

        int firstNegRow = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                firstNegRow = i;
                break;
            }
        }

        if (firstNegRow != -1)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                int temp = B[maxRow, j];
                B[maxRow, j] = B[firstNegRow, j];
                B[firstNegRow, j] = temp;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                    count++;
            }
        }

        if (count == 0)
            return new int[0];

        int[] answer = new int[count];
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[index] = A[i, j];
                    index++;
                }
            }
        }

        return answer;
    }
    #endregion

    #region Level 2

    public double[,] Task_2_1(double[,] A)
    {
        double AdjustValue(double value)
        {
            return value >= 0 ? value * 2 : value / 2;
        }

        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (rows != 5 || columns != 7)
            return null;

        for (int i = 0; i < rows; i++)
        {
            int maxIdx = 0;
            for (int j = 1; j < columns; j++)
            {
                if (A[i, j] > A[i, maxIdx])
                    maxIdx = j;
            }

            if (maxIdx > 0 && maxIdx < columns - 1)
            {
                int neighbor = A[i, maxIdx - 1] < A[i, maxIdx + 1] ? maxIdx - 1 : maxIdx + 1;
                A[i, neighbor] = AdjustValue(A[i, neighbor]);
            }
            else if (maxIdx == 0 && columns > 1)
            {
                A[i, 1] = AdjustValue(A[i, 1]);
            }
            else if (maxIdx == columns - 1 && columns > 1)
            {
                A[i, columns - 2] = AdjustValue(A[i, columns - 2]);
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);

        if (rows != 7 || columns != 5)
            return null;

        for (int j = 0; j < columns; j++)
        {
            int max = int.MinValue; 
            int count_neg = 0;      
            int count_pos = 0;
            int maxIdx = -1;

            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] < 0)
                    count_neg++;
                if (A[i, j] > 0)
                    count_pos++;

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIdx = i;
                }
            }

            if (count_pos > count_neg)
                A[maxIdx, j] = 0;
            else
                A[maxIdx, j] = maxIdx + 1;
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxIdx = 0;

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxIdx, j])
                    maxIdx = i;
            }

            if (maxIdx < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = maxIdx + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxIdx = 0;

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxIdx, j])
                    maxIdx = i;
            }

            if (B[j] > A[maxIdx, j])
            {
                A[maxIdx, j] = B[j];
            }
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);

        if (rows != 7 || columns != 5)
            return null;

        for (int j = 0; j < columns; j++)
        {
            int maxIdx = 0;
            double max = double.MinValue;

            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIdx = i;
                }
            }

            double avg = (A[0, j] + A[6, j]) / 2;
            if (max < avg)
            {
                A[maxIdx, j] = avg;
            }
            else
            {
                A[maxIdx, j] = maxIdx + 1;
            }
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0)
            return null;

        int[,] result = new int[n, 3 * n];

        for (int block = 0; block < 3; block++)
        {
            for (int i = 0; i < n; i++)
            {
                result[i, block * n + i] = 1;
            }
        }

        return result;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;

        int maxDiagIdx = 0;

        for (int i = 1; i < 6; i++)
        {
            if (A[i, i] > A[maxDiagIdx, maxDiagIdx])
                maxDiagIdx = i;
        }

        for (int i = 0; i < maxDiagIdx; i++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;

        int FindMaxIndex(int[,] matrix, int row)
        {
            int maxIdx = 0;
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] > matrix[row, maxIdx])
                    maxIdx = col;
            }
            return maxIdx;
        }

        int[][] pairs = new int[][] { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };

        foreach (var pair in pairs)
        {
            int maxIdx1 = FindMaxIndex(B, pair[0]);
            int maxIdx2 = FindMaxIndex(B, pair[1]);

            int temp = B[pair[0], maxIdx1];
            B[pair[0], maxIdx1] = B[pair[1], maxIdx2];
            B[pair[1], maxIdx2] = temp;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int left = 0, right = A.GetLength(1) - 1;

            while (left < right)
            {
                int temp = A[i, left];
                A[i, left] = A[i, right];
                A[i, right] = temp;
                left++;
                right--;
            }
        }

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

        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[n - 1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
        }

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
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        if (r == c)
        {
            int size = r;

            for (int row = size / 2; row < size; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[row, col] = 1;
                }
            }
        }
        else
        {
            matrix = null;
        }

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
        int[] upper = default;
        int[] lower = default;

        int numR = matrix.GetLength(0);
        int numC = matrix.GetLength(1);

        if (numR == numC)
        {
            int size = numR;

            upper = new int[size * (size + 1) / 2];
            lower = new int[size * (size - 1) / 2];

            int upperI = 0;
            int lowerI = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < numC; col++)
                {
                    if (col >= row)
                    {
                        upper[upperI++] = matrix[row, col];
                    }
                    else
                    {
                        lower[lowerI++] = matrix[row, col];
                    }
                }
            }
        }
        else
        {
            upper = null;
            lower = null;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }

        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        int[] pc = new int[r];

        for (int i = 0; i < r; i++)
        {
            int cnt = 0;
            for (int j = 0; j < c; j++)
            {
                if (matrix[i, j] > 0)
                {
                    cnt++;
                }
            }
            pc[i] = cnt;
        }

        for (int i = 0; i < r - 1; i++)
        {
            for (int j = 0; j < r - 1 - i; j++)
            {
                if (pc[j] < pc[j + 1])
                {
                    int tC = pc[j];
                    pc[j] = pc[j + 1];
                    pc[j + 1] = tC;

                    for (int k = 0; k < c; k++)
                    {
                        int tV = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = tV;
                    }
                }
            }
        }

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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int r = 0; r < rows; r++)
        {
            bool desc = (r % 2 == 0);

            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < cols - 1 - i; j++)
                {
                    bool swap = desc 
                        ? (matrix[r, j] < matrix[r, j + 1]) 
                        : (matrix[r, j] > matrix[r, j + 1]);

                    if (swap)
                    {
                        int tmp = matrix[r, j];
                        matrix[r, j] = matrix[r, j + 1];
                        matrix[r, j + 1] = tmp;
                    }
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int c = 0;
        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero) c++;
        }

        int[,] result = new int[c, cols];
        int newR = 0;
        
        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[newR, j] = matrix[i, j];
                }
                newR++;
            }
        }
        
        return result;
    }
    #endregion
}