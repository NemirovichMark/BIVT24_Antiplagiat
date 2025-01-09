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
        if (A == null || A.Length == 0)
        {
            return 0;
        }
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int sum = 0;
        int count = 0;


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
        }


        if (count == 0)
        {
            return 0;
        }


        answer = (double)sum / count;
        
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
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        if (colIndex < 0 || colIndex >= A.GetLength(1))
        {
            
            return (0,0);
        }
        value = int.MaxValue;
        rowIndex = -1;


        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }



        if (rowIndex == -1)
        {
            return (0, 0);
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
        double[] answer = default(double[]);

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 4 || cols != 6) return answer;

        answer = new double[rows];
        
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            int count = 0;

            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            if (count == 0)
            {
                answer[i] = 0;
            }
            else
            {
                answer[i] = (double)sum / count;
            }
                
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int index = 0; int min = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                index = i;
            }
        }

        int[,] A1 = new int[4, 7];
        if (index == 0)
        {
            for (int i = index + 1; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A1[i - 1, j] = A[i, j];
                }
            }
        }
        else if (index == A.GetLength(0) - 1)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A1[i, j] = A[i, j];
                }
            }
        }
        else
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A1[i, j] = A[i, j];
                }
            }
            for (int i = index + 1; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A1[i - 1, j] = A[i, j];
                }
            }
        }
        return A1;
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
        int[] answer = default(int[]);

        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return answer;
        answer = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) count++;
            }
            answer[j] = count;
        }

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
        
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        
        for (int i = 0; i < rows; i++)
        { 
            int minVal = B[i, 0];
            int minIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (B[i, j] < minVal)
                {
                    minVal = B[i, j];
                    minIndex = j;
                }
            }

            
            if (minIndex != 0)
            {
                int temp = minVal;
                for (int j = minIndex; j > 0; j--)
                {
                    B[i, j] = B[i, j - 1];
                }
                B[i, 0] = temp;
            }
        }
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

        for (int i = 0; i < rows; i++)
        {
            double maxVal = F[i, 0];
            int maxIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (F[i, j] > maxVal)
                {
                    maxVal = F[i, j];
                    maxIndex = j;
                }
            }
            int firstNegativeIndex = -1;
            int lastNegativeIndex = -1;
            for (int j = 0; j < cols; j++)
            {
                if (F[i, j] < 0)
                {
                    if (firstNegativeIndex == -1)
                    {
                        firstNegativeIndex = j;
                    }
                    lastNegativeIndex = j;
                }
            }
            if (firstNegativeIndex != -1 && lastNegativeIndex != -1)
            {
                F[i, maxIndex] = (F[i, firstNegativeIndex] + F[i, lastNegativeIndex]) / 2;
            }
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return default;
        int rows = G.GetLength(0);
        int cols = G.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int maxVal = G[i, 0];
            int maxIndex = 0;
            for (int j = 1; j < 6; j++)
            {
                if (G[i, j] > maxVal)
                {
                    maxVal = G[i, j];
                    maxIndex = j;
                }
            }
            for (int j = cols - 1; j > maxIndex + 1; j--)
            {
                G[i, j] = G[i, j - 1];
            }
            
            G[i, maxIndex + 1] = maxVal;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return default;
        

        int maxVal = -1234567890;
        int maxRowIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            if (A[i, 5] > maxVal)
            {
                maxVal = A[i, 5];
                maxRowIndex = i;
            }
        }
        
        for (int j = 0; j < 7; j++)
        {
            A[maxRowIndex, j] = B[j];
           
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return default;
        int rows = F.GetLength(0);
        int cols = F.GetLength(1);


        int minAbsVal = Math.Abs(F[1, 0]); 
        int minAbsIndex = 0; 

        for (int j = 1; j < cols; j++)
        {
            if (Math.Abs(F[1, j]) < minAbsVal)
            {
                minAbsVal = Math.Abs(F[1, j]);
                minAbsIndex = j;
            }
        }

        if (minAbsIndex < cols - 1)
        {
            int removeColumn = minAbsIndex + 1;                                    
            int[,] newMatrix = new int[rows, cols - 1];

            for (int i = 0; i < rows; i++)
            {
                int newColIndex = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j != removeColumn)
                    {
                        newMatrix[i, newColIndex] = F[i, j];
                        newColIndex++;
                    }
                }
            }
            F = newMatrix; 

        }
        else return null;
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
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;

        for (int i = 0; i < 5; i++)
        {
            double maxVal = -1234567890;
            int maxIndex = 0;
            double positiveSum = 0;
            int positiveCount = 0;

            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = j;

                }
            }

            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    positiveSum += A[i, j];
                    positiveCount++;
                }
            }
            double k = 0;
            if (positiveCount > 0)
            {
                k = positiveSum / positiveCount;
            }
            A[i, maxIndex] = k;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        
        

        for (int i = 0; i <5 ; i++)
        {
            double maxVal = -1234567890;
            int maxIndex = 0;

            for (int j = 1; j < 7; j++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = j;
                }
            }

            if (maxIndex == 0)
            {
                A[i, 1] = A[i, 1] >= 0 ? A[i, 1] * 2 : A[i, 1] * 0.5;
            }
            else if (maxIndex == 6)
            {
                A[i, 5] = A[i, 5] * 0.5; 
            }
            else
            {
                double m;
                int neighborIndex;
                if (A[i, maxIndex - 1] > A[i, maxIndex + 1])
                {
                    neighborIndex = maxIndex + 1;
                }
                else
                {
                    neighborIndex = maxIndex - 1;
                }

                m = A[i, neighborIndex] >= 0 ? 2.0 : 0.5;
                A[i, neighborIndex] *= m;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;

        for (int j = 0; j < 5; j++)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int maxVal =-1234567890;
            int maxIndex = 0;

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
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = i;
                }
            }

            if (positiveCount > negativeCount)
            {
                A[maxIndex, j] = 0;
            }
            else
            {
                A[maxIndex, j] = maxIndex+1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(1) != 5 || A.GetLength(0) != 10) return default;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int maxVal = A[0, j];
            int maxIndex = 0;

            for (int i = 1; i < rows; i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = i;
                }
            }

            if (maxIndex < rows / 2)
            {
                int sum = 0;
                for (int i = maxIndex + 1; i < rows; i++)
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
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int maxVal = A[0, j];
            int maxIndex = 0;

            for (int i = 1; i < rows; i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = i;
                }
            }
            if (B[j] > maxVal)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int j = 0; j < 5; j++)
        {
            double maxVal = -1234567890;
            int maxIndex = 0;

            for (int i = 1; i < 7; i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIndex = i;
                }
            }
            double term = (A[0, j] + A[rows - 1, j]) / 2;
            if (A[maxIndex, j] < term) A[maxIndex, j] = (A[0, j] + A[rows - 1, j]) / 2;
            else A[maxIndex, j] = maxIndex + 1;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {

        if (n < 0) return default;

        int[,] answer = new int[n,n*3];
        // code here
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n*3; j+=n)
            {
                answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(1) != 6 || A.GetLength(0) != 6) return default;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int maxDiagonal = A[0, 0];
        int maxDiagonalRow = 0;
        for (int i = 1; i < rows; i++)
        {
            if (A[i, i] > maxDiagonal)
            {
                maxDiagonal = A[i, i];
                maxDiagonalRow = i;
            }
        }
        for (int i = 0; i < maxDiagonalRow; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                A[i, j] = 0;
            }
        }
        
        // end 
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default;
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        for (int i = 0; i < rows; i += 2)
        {
            if (i + 1 < rows) 
            {
                int maxValRow1 = B[i, 0];
                int maxIndexRow1 = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (B[i, j] > maxValRow1)
                    {
                        maxValRow1 = B[i, j];
                        maxIndexRow1 = j;
                    }
                }

                int maxValRow2 = B[i + 1, 0];
                int maxIndexRow2 = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (B[i + 1, j] > maxValRow2)
                    {
                        maxValRow2 = B[i + 1, j];
                        maxIndexRow2 = j;
                    }
                }

                int temp = B[i, maxIndexRow1];
                B[i, maxIndexRow1] = B[i + 1, maxIndexRow2];
                B[i + 1, maxIndexRow2] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, cols - 1 - j];
                A[i, cols - 1 - j] = temp;
            }
        }
        // end

        return A;   
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default;
  
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - 1 - i; j++)
            {
                int min1 = int.MaxValue;
                int min2 = int.MaxValue;

                for (int c = 0; c < cols; c++)
                {
                    min1 = Math.Min(min1, matrix[j, c]);
                    min2 = Math.Min(min2, matrix[j + 1, c]);
                }

                if (min1 < min2)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        (matrix[j, c], matrix[j + 1, c]) = (matrix[j + 1, c], matrix[j,c]);
                    }
                }
            }
        }
        // end

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0) return default;
        int n = matrix.GetLength(0);
        int[] answer = new int[2*n - 1];
        int p = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            int sum1 = 0;
            for (int row = 0, col = i; row < n && col < n; row++, col++)
            {
                sum1 += matrix[row, col];
            }
            answer[n - 1 + i] = sum1;

            if (i > 0)
            {
                int sum2 = 0;
                for (int row = i, col = 0; row < n && col < n; row++, col++)
                {
                    sum2 += matrix[row, col];
                }
                answer[n - 1 - i] = sum2;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
        
    {
        // code here
        int n = matrix.GetLength(0);
        if (k < 1 || k > n || matrix.GetLength(0) == 0 || matrix.GetLength(0) != matrix.GetLength(1)) return default;
        k--;
        int maxAbsVal = Math.Abs(matrix[0, 0]);
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > maxAbsVal)
                {
                    maxAbsVal = Math.Abs(matrix[i, j]);
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        if (maxRow != k)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[maxRow, j];
                matrix[maxRow, j] = matrix[k, j];
                matrix[k, j] = temp;
            }
        }

        if (maxCol != k)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, maxCol];
                matrix[i, maxCol] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        // end

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

        int size = n * (n + 1) / 2; 
        if (A.Length != size || B.Length != size) return default;

        int[,] a = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                a[i, j] = A[k];
                a[j, i] = A[k];
                k++;
            }
        }

        int[,] b = new int[n, n];
        k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                b[i, j] = B[k];
                b[j, i] = B[k];
                k++;
            }
        }

        int[] answer = new int[n * n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int p = 0; p < n; p++)
                {
                    sum += a[i, p] * b[p, j];
                }
                answer[index++] = sum;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] resultMatrix = new int[n, n];
        k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                resultMatrix[i, j] = answer[k++];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
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
        // code here
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return default;
        int[] negativeCounts = new int[7];
        for (int j = 0; j < 7; j++)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                {
                    count++;
                }
            }
            negativeCounts[j] = count;
        }

        for (int i = 0; i < 7 - 1; i++)
        {
            for (int j = 0; j < 7 - 1 - i; j++)
            {
                if (negativeCounts[j] > negativeCounts[j + 1])
                {
                    int tempCount = negativeCounts[j];
                    negativeCounts[j] = negativeCounts[j + 1];
                    negativeCounts[j + 1] = tempCount;

                    for (int r = 0; r < 5; r++)
                    {
                        int temp = matrix[r, j];
                        matrix[r, j] = matrix[r, j + 1];
                        matrix[r, j + 1] = temp;
                    }
                }
            }
        }
        // end

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
        // code here
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return default;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int c = 0;

        for (int i = 0; i < rows; i++)
        {
            
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    c++;
                    
                    break;
                }
            }
            
        }
        int[] rowsToRemove = new int[rows];
        int[,] newMatrix = new int[rows - c, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    rowsToRemove[i] = 1;
                    c++;
                    break;
                }
            }
        }
        c = 0;
        for (int i = 0; i < rows; i++)
        {
            if (rowsToRemove[i] == 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[c, j] = matrix[i,j];
                }
                c++;
            }
        }
        // end

        return newMatrix;
    }
    #endregion
}