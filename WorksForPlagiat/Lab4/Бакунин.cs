using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
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
        for (int i = 0;i < A.GetLength(0); i++)
        {
            for (int j = 0;j < A.GetLength(1); j++)
            {
                answer += A[i, j];
            }
        }

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
       
        int max = A[0,0];

        return max;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int min = int.MaxValue;
        int Line = 0;
        int Column = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    Line = i;
                    Column = j;
                }
            }
        }

        return (Line,Column);
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
            return null;
        int[] res = new int[A.GetLength(1)];
        for (int i = 0;i < A.GetLength(1); i++)
        {
            res[i] = int.MinValue;
            for (int j = 0;j < A.GetLength(0); j++)
            {
                res[i] = Math.Max(res[i], A[j, i]);
            }
        }
        

        return res;
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
        int max = int.MinValue;
        int Ind = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i,2] > max)
            {
                max = A[i,2];
                Ind = i;
            }
        }
        
        for (int j = 0;j < A.GetLength(1); j++)
        {
            int temp = A[Ind, j];
            A[Ind, j] = A[3,j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }
        int max = int.MinValue;
        int Ind = -1;
        for (int i = 0; i < A.GetLength(0);i++)
        {
            if (A[i,i] > max)
            {
                max = A[i,i];
                Ind = i;
            }
        }
        for (int j = 0;j < A.GetLength(0); j++)
        {
            int temp = A[j, Ind];
            A[j,Ind] = A[j,3];
            A[j,3] = temp;
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
        int[,] res = new int[n,m]; 
        for (int i = 0;i < n; i++)
        {
            int Ind = 0;
            for (int j = 0;j < m; j++)
            {
                if (A[i, j] > A[i, Ind])
                    Ind = j;
            }
            for (int j = 0,k = 0; j < m; j++)
            {
                if (j != Ind)
                {
                    res[i,k++] = A[i,j];
                }
            }
            res[i,m-1] = A[i,Ind];
        }
        
        return res;
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
        double [,] res = new double[n, m];
        for (int i = 0;i < n; i++)
        {
            double max = int.MinValue;
            int Ind = -1;
            for (int j = 0;j < m; j++)
            {
                if (C[i,j] > max)
                {
                    max = C[i, j];
                    Ind = j;
                }
            }
            for (int j = 0;j < Ind; j++)
            {
                if (C[i,j] < 0)
                {
                    res[i, j] = C[i, j] / max;
                }
                else
                {
                    res[i, j] = C[i, j];
                }
            }
            for (int j = Ind; j < m; j++)
            {
                res[i, j] = C[i, j];
            }
        }

        return res;
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
        double max = double.MinValue;
        double sum = 0;
        int cnt = 0;
        int IndRow = -1;
        int IndCol = -1;
        for (int i = 0;i < Z.GetLength(0);i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i,j] > 0)
                {
                    sum += Z[i,j];
                    cnt++;
                }
                if (Z[i,j] > max)
                {
                    max = Z[i,j];
                    IndRow = i;
                    IndCol = j;
                }
            }
        }
        double avg = sum / cnt;
        Z[IndRow, IndCol] = avg;


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
        if (X == null || X.GetLength(0) != 6 && X.GetLength(1) != 5)
        {
            return null;
        }
        int IndMin = 0;
        int IndMax = 0;
        int cntMin = int.MaxValue; 
        int cntMax = int.MinValue; 
        for (int i = 0;i < X.GetLength(0); i++)
        {
            int cnt = 0;
            for (int j = 0;j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                    cnt++;
            }
            if (cnt < cntMin)
            {
                cntMin = cnt;
                IndMin = i;
            }
            if (cnt > cntMax)
            {
                cntMax = cnt;
                IndMax = i;
            }
        }

        if (IndMin != IndMax)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            { 
                int temp = X[IndMin, j];
                X[IndMin,j] = X[IndMax,j];
                X[IndMax,j] = temp;
            }
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
        if (A == null || A.GetLength(0) != 7 && A.GetLength(1) != 5)
        {
            return null;
        }
        int maxsum = int.MinValue;
        int maxInd = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                    sum += A[i, j];
            }
            if (sum > maxsum)
            {
                maxsum = sum;
                maxInd = i;
            }
        }
        int[,] res = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int k = 0;
        for (int i = 0;i < A.GetLength(0); i++)
        {
            if (i != maxInd)
            {
                for (int j = 0;j < A.GetLength(1); j++)
                {
                    res[k,j] = A[i,j];
                }
                k++;
            }
        }

        return res;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) 
            return null;

        int min = int.MaxValue; int Ind = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                Ind = i;
            }
        }

        if (Ind != A.GetLength(1) - 1)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, Ind + 1] = B[i];
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
        if (A == null || A.GetLength(0) != 5 && A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0;i < A.GetLength(0);i++)
        {
            double max = double.MinValue;
            int Ind = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    Ind = j;
                }
            }
            if (A[i,Ind+1] > A[i,Ind - 1])
            {
                if (A[i, Ind - 1] > 0)
                    A[i, Ind - 1] *= 2;
                else
                    A[i, Ind - 1] /= 2;
            }
            else if( A[i, Ind + 1] <= A[i, Ind - 1])
            {
                if (A[i, Ind + 1] > 0)
                    A[i, Ind + 1] *= 2;
                else
                    A[i, Ind + 1] /= 2;
            }
            else if(Ind == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (Ind == (A.GetLength(1) - 1))
            {
                if (A[i, Ind - 1] > 0) A[i, Ind - 1] *= 2;
                else A[i, Ind - 1] /= 2;
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int cntPos = 0;
            int cntNeg = 0;
            int max = int.MinValue;
            int Ind = 0;
            for (int j = 0;j < A.GetLength(0); j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j,i];
                    Ind = j;
                }
                if (A[j, i] > 0)
                    cntPos++;
                else if(A[j, i] < 0)
                    cntNeg++;
            }
            if (cntPos > cntNeg)
                A[Ind, i] = 0;
            else
            {
                A[Ind, i] = Ind + 1;
            }
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0;i < A.GetLength(1); i++)
        {
            int max = int.MinValue;
            int Ind = 0;
            
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j,i];
                    Ind = j;
                }
            }
            if (Ind < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int j = Ind + 1;j <  A.GetLength(0); j++)
                {
                    sum += A[j, i];
                }
                A[0, i] = sum;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {

        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = int.MinValue;
            int Ind = 0;
            for (int j = 0; j <  A.GetLength(0); j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j,i];
                    Ind = j;
                }
            }
            if (B[i] > max)
            {
                A[Ind, i] = B[i];
            }
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 )
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = double.MinValue;
            int Ind = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j,i];
                    Ind = j;
                }
            }
            double halfsum = (A[0,i] + A[A.GetLength(0) - 1,i])/ 2.0;
            if (max < halfsum)
                A[Ind, i] = halfsum;
            else
                A[Ind, i] = Ind + 1;
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) 
            return null;
        int[,] answer = new int[n, 3 * n];
        int k = 0;
        for (int i = 0; i < answer.GetLength(1); i++)
        {
            for (int j = 0; j < answer.GetLength(0); j++)
            {
                answer[j, i] = 0;
            }
            answer[k++, i] = 1;
            if (k == 3) 
                k = 0;
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int max = int.MinValue;
        int Ind = -1;
        for (int i = 0;i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                Ind = i;
            }
        }

        for (int i = 0;i < Ind;i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int max1 = int.MinValue;
        int indexMax1 = -1;
        for (int i = 0;i < 6; i++)
        {
            if (B[0,i] > max1)
            {
                max1 = B[0,i];
                indexMax1 = i;
            }
        }
        int max2 = B[1, 0];
        int indexMax2 = 0;
        for (int j = 1; j < 6; j++)
        {
            if (B[1, j] > max2)
            {
                max2 = B[1, j];
                indexMax2 = j;
            }
        }
        int temp = B[0, indexMax1];
        B[0, indexMax1] = B[1, indexMax2];
        B[1, indexMax2] = temp;

        int max3 = B[2, 0];
        int indexMax3 = 0;
        for (int j = 1; j < 6; j++)
        {
            if (B[2, j] > max3)
            {
                max3 = B[2, j];
                indexMax3 = j;
            }
        }
        int max4 = B[3, 0];
        int indexMax4 = 0;
        for (int j = 1; j < 6; j++)
        {
            if (B[3, j] > max4)
            {
                max4 = B[3, j];
                indexMax4 = j;
            }
        }
        temp = B[2, indexMax3];
        B[2, indexMax3] = B[3, indexMax4];
        B[3, indexMax4] = temp;
        int max5 = B[4, 0];
        int indexMax5 = 0;

        for (int j = 1; j < 6; j++)
        {
            if (B[4, j] > max5)
            {
                max5 = B[4, j];
                indexMax5 = j;
            }
        }
        int max6 = B[5, 0];
        int indexMax6 = 0;
        for (int j = 1; j < 6; j++)
        {
            if (B[5, j] > max6)
            {
                max6 = B[5, j];
                indexMax6 = j;
            }
        }

        temp = B[4, indexMax5];
        B[4, indexMax5] = B[5, indexMax6];
        B[5, indexMax6] = temp;

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0;i < 6; i++)
        {
            for (int j = 0,k = 6;j < k; j++, k--)
            {
                int temp = A[i,j];
                A[i,j] = A[i,k];
                A[i,k] = temp;
            }
        }

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
        int[] minim = new int[7];
        int[,] res = new int[7, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];

                }
            }
            minim[i] = min;
        }
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int max = int.MinValue;
            for (int k = 0; k < minim.Length; k++)
            {
                if (minim[k] > max)
                {
                    max = minim[k];
                    index = k;
                }
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                res[i, j] = matrix[index, j];
            }
            minim[index] = int.MinValue;
        }

        return res;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int[] sums = new int[2 * n - 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int dIndex = j - i + (n - 1);
                sums[dIndex] += matrix[i, j];
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1)
            return null;
        int[] maxIndex = new int[] { 0, 0 };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (Math.Abs(matrix[row, col]) > Math.Abs(matrix[maxIndex[0], maxIndex[1]]))
                {
                    maxIndex[0] = row;
                    maxIndex[1] = col;
                }
            }
        }

        if (maxIndex[1] != k - 1)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                int temp = matrix[maxIndex[0], col];
                matrix[maxIndex[0], col] = matrix[k - 1, col];
                matrix[k - 1, col] = temp;
            }
        }

        if (maxIndex[0] != k - 1)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int temp = matrix[row, maxIndex[1]];
                matrix[row, maxIndex[1]] = matrix[row, k - 1];
                matrix[row, k - 1] = temp;
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
        int[] resultArray = new int[n * n];
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int index = 0;
        bool foundNonZero = false;

        for (int k = 0; k < A.Length; k++)
        {
            if (A[k] != 0 || B[k] != 0)
            {
                foundNonZero = true;
                break;
            }
        }

        if (!foundNonZero)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[index];
                matrixB[i, j] = B[index];
                index++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                matrixA[i, j] = matrixA[j, i];
                matrixB[i, j] = matrixB[j, i];
            }
        }

        index = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixA[row, k] * matrixB[k, col];
                }
                resultArray[index++] = sum;
            }
        }

        return resultArray;

    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return default;
        int[] negCount = new int[matrix.GetLength(1)];

        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            int cnt = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                if (matrix[r, c] < 0)
                    cnt++;
            }
            negCount[c] = cnt;
        }

        for (int curCol = 1; curCol < matrix.GetLength(1); curCol++)
        {
            int compCol = curCol;
            while (compCol > 0 && negCount[compCol - 1] > negCount[compCol])
            {
                (negCount[compCol - 1], negCount[compCol]) = (negCount[compCol], negCount[compCol - 1]);

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    (matrix[r, compCol - 1], matrix[r, compCol]) = (matrix[r, compCol], matrix[r, compCol - 1]);
                }

                compCol--;
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
        int cnt = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    cnt++;
                    break;
                }
            }
        }
        int[,] res = new int[matrix.GetLength(0) - cnt, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    break;
                }
                res[k, j] = matrix[i, j];
            }
            k++;
            if (k >= matrix.GetLength(0) - cnt)
            {
                break;
            }
        }
        matrix = res;

        return matrix;
    }
    #endregion
}