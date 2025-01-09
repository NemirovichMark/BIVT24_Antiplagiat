using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
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
        int s = 0;
        int row = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < row; i ++)
        {
            for (int j = 0; j < columns; j ++)
            {
                s += A[i, j];
            }
        }
        answer = s;
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
        int row = 0, col = 0;
        // code here
        int min = 100000*10000;
        int lines = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < lines; i ++)
        {
            for (int j = 0; j < columns; j ++)
            {
                if (A[i, j] < min)
                {
                    min =  A[i, j];
                    row = i;
                    col = j;
                }
            }
        }

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
        int[] answer = default(int[]);
        // code here
        answer = new int[A.GetLength(1)];
        int lines = A.GetLength(0);
        int columns = A.GetLength(1);
        int max = -10000*10000;
        if (lines != 3 || columns != 5)
        {
            return null;
        }
        for (int j = 0; j < columns; j ++)
        {
            max = -10000*10000;
            for (int i = 0; i < lines; i ++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }  
            }
            answer[j] = max;
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
        // code here
        int lines = A.GetLength(0);
        int columns = A.GetLength(1);
        int max = -10000*10000;
        int maxIndex = -1;
        int[] maxArr = new int[5];
        if (lines != 5 || columns != 7)
        {
            return null;
        }
        for (int i = 0; i < lines; i ++)
        {
            if (A[i, 2] > max)
            {
                max = A[i, 2];
                maxIndex = i;

            }
        }
        int k;
        if (maxIndex != -1)
        {   for (int i = 0; i < columns; i ++)
            {
                k = A[3, i];
                A[3, i] = A[maxIndex, i];
                A[maxIndex,i] = k;
            }
        }

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
        // code here
        int col = A.GetLength(1);
        int lin = A.GetLength(0);
        int numCol = -1;
        int max = -10000*10000;
        if (col != 5 || lin != 5)
        {
            return null;
        }
        for (int i = 0; i < lin;i ++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                numCol = i;;
            }
        }

        int s = 0;
        for (int j = 0; j < lin; j++)
        {
            s = A[j, 3];
            A[j, 3] = A[j, numCol];
            A[j, numCol] = s;
        }

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
        // code here
        for (int i = 0; i < n; i ++)
        {
            int max = -10000*10000;
            int index = 0;
            for (int j = 0; j < m ; j ++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            for (int s = index; s < m - 1; s++)
            {
                A[i, s] = A[i, s + 1];
            }
            A[i, m -1] = max;

        }

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
        // code here
        double max = -100000*10000;
        int index = 0;
        int lin = C.GetLength(0);
        int col = C.GetLength(1);
        for( int i = 0; i < lin; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    index = j;
                }
            }
            for (int s = 0; s < index ; s++)
            {
                if (C[i, s] < 0 && max!=0)
                {
                    C[i, s] /=max;
                }
            }
            max = -10000*10000;
            index = 0;
        }
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
        // code here
        int lin = Z.GetLength(0);
        int col = Z.GetLength(1);
        double sum = 0, max = -1000000*1000;
        double sr = 0;
        int k = 0, iMax = 0, jMax = 0;
        if (lin != 6 || col != 8) 
        {
            return null;
        }
        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    k++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    iMax = i;
                    jMax = j;
                }
            }
        }
        sr = sum / k;
        sr = Math.Round(sr, 2);
        Z[iMax, jMax] = sr;
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
        //code here
        int lin = X.GetLength(0);
        int col = X.GetLength(1);
        int max = -100000; 
        int min = 10000;
        int k = 0;
        int iMin = 0; 
        int iMax= 0;
        if (lin != 6 || col != 5)
        {
            return null;
        }
        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k > max)
            {
                max = k;
                iMax = i;
            }
            if (k < min)
            {
                min = k;
                iMin = i;
            }
            k = 0;
        }
        int s = 0;
        for (int q = 0; q < col; q ++)
        {
            s = X[iMax, q];
            X[iMax, q] = X[iMin, q];
            X[iMin, q] = s;
        }
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
        int lin = A.GetLength(0);
        int col = A.GetLength(1);
        double max = -100000; 
        double s = 0; 
        int iMax = 0;
        if (lin != 7 || col != 5)
        {
            return null;
        }
        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                }
            }
            if (max < s)
            {
                max = s; 
                iMax = i;
            }
            s = 0;
        }
        int[,] newA = new int [lin - 1, col];
        int n = 0;
        for (int i = 0; i < lin; i++)
        {
            if (i == iMax)
            {
                continue;
            }
            for (int j = 0; j < col; j ++)
            {
                newA[n, j] = A[i, j];
            }
            n++;
        }
        A = newA;

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
        // code here
        int lin = A.GetLength(0);
        int col = A.GetLength(1);
        int min = 100000*10000;
        int indA = 0;
        if (lin != 5 || col != 8 || B.Length != 5)
        {
            return null;
        }
        for (int i = 0; i < col; i ++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                indA = i;
            }
        }

        if (indA != A.GetLength(1) - 1)
        {
            for (int i = 0; i < lin; i++)
            {
                A[i, indA + 1] = B[i];
            }   
        } 
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
        // code here
        int lin = A.GetLength(0);
        int col = A.GetLength(1);
        int[] newA = new int [5];
        if (lin != 5 || col != 7)
        {
            return null;
        }
        for (int i = 0; i < lin; i ++)
        {
            double max = -10000;
            int index = 0;
            for (int j = 0; j < col; j ++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            newA[i] =  index;
        }
        
        for (int s = 0; s < lin; s++)
        {
            if (newA[s] == 0)
            {
                A[s, newA[s] + 1] *= 2;
            }
            else if (newA[s] == A.GetLength(1) - 1)
            {
                A[s, newA[s] - 1] *= 2;
            }
            else
            {
                if (A[s, newA[s] + 1] > A[s, newA[s] - 1])
                {
                    if(A[s, newA[s] - 1]>0) A[s, newA[s] - 1] *= 2;
                    else 
                    {
                        A[s, newA[s] - 1] /= 2;
                    }
                }
                
                else
                {
                    if (A[s, newA[s] + 1] > 0)
                    { 
                        A[s, newA[s] + 1] *= 2;
                    }
                    else 
                    {
                        A[s, newA[s] + 1] /= 2;
                    }
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = -10000*10000, index = 0, counterP = 0, counterN=0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
                if (A[j, i] > 0) counterP++;
                else counterN++;
            }
            if (counterP >= counterN) 
            {
                A[index, i] = 0;
            }
            else 
            {
                A[index, i] = index + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) 
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i ++)
        {
            int max = - 100000000;
            int sum = 0; 
            int index = 0;
            for (int j = 0; j < A.GetLength(0); j ++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
            }
            if (index < 5)
            {
                for (int j = index + 1; j < A.GetLength(0); j ++)
                {
                    sum += A[j, i];
                }
                A[0, i] = sum;
            }
        }
        
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) 
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i ++)
        {
            int max = -1000000;
            int index = 0; 
            for (int j = 0; j < A.GetLength(0); j ++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
            }
            if (max < B[i])
            {
                A[index, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i ++)
        {
            double max = -100000;
            int index = 0;
            double pS = (A[0, i] + A[6, i])/2;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
            }
            if (max < pS)
            { 
                A[index, i] = pS;
            }
            else 
            {
                A[index, i] = index + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return null;
        }
        int[,] newA = new int[n, 3*n];
        int s = 2;
        for (int i = 0; i < newA.GetLength(0); i ++)
        {
            for (int j = 0; j < newA.GetLength(1); j ++)
            {
                newA[i, j] = ((s + j) % 3) / 2;
            }
            s--;
        }
        answer = newA;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int max = -1000000;
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                index = i;
            }
        }
        if (index != 0)
        {
            int s = 1; 
            for (int i = 0; i < index; i ++)
            {
                for (int j = i + s; j < A.GetLength(1); j ++)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int[] Max = new int[6];
        int[] Index = new int[6];
        for (int i = 0; i < B.GetLength(0); i ++)
        {
            int max = -100000;
            int index = 0;
            for (int j = 0; j < B.GetLength(1); j ++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    index = j;
                }
            }
            Max[i] = max;
            Index[i] = index;
        }
        B[0, Index[0]] = Max[1];
        B[1, Index[1]] = Max[0];
        B[2, Index[2]] = Max[3];
        B[3, Index[3]] = Max[2];
        B[4, Index[4]] = Max[5];
        B[5, Index[5]] = Max[4];
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int[] newA = new int[7];
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                newA[j] = A[i, j];
            }
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                A[i, j] = newA[A.GetLength(1) - 1 - j];
            }
        }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) 
        {
            return null;
        }
        int[] newArray = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int index = 0;
            int min = 1000000*1000;
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    index = j;
                }
            newArray[i] = matrix[i, index];
        }
        for (int x = 1; x < matrix.GetLength(0); x++)
        {
            int i = x;
            while (i > 0 && newArray[i - 1] < newArray[i])
            {
                (newArray[i - 1], newArray[i]) = (newArray[i], newArray[i - 1]);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    (matrix[i - 1, j], matrix[i, j]) = (matrix[i, j], matrix[i - 1, j]);
                }
                i--;
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
        int[] answer = default(int[]);
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int n = matrix.GetLength(0);
        answer = new int[2*n - 1];
        for (int i = 0; i < n; i ++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0)) 
        {
            return null;
        }
        int max = -1000000*1000;
        int indexI = 0, indexJ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (max < Math.Abs(matrix[i, j]))
                {
                    max = Math.Abs(matrix[i, j]);
                    indexI = i;
                    indexJ = j;
                }
            }
        }
        if (indexI == k - 1 && indexJ == k - 1)
        {
            return matrix;
        }
        if (indexJ != k - 1)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                (matrix[k - 1, j],  matrix[indexI, j]) = (matrix[indexI, j], matrix[k - 1, j]);
            }
        }
        if (indexI != k - 1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                (matrix[i, k - 1], matrix[i, indexJ]) = (matrix[i, indexJ], matrix[i, k - 1]);
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
        int[] answer = default(int[]);

        // code here
        if (A.Length <= 0 || B.Length <= 0 || A.Length != B.Length) 
        {
            return null;
        }
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];
        int index = 0;
        int[] c = new int[n * n];
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = i; j < n; j = j + 1)
            {
                a[i, j] = A[index];
                a[j, i] = A[index];
                b[i, j] = B[index];
                b[j, i] = B[index];
                index++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int f = 0; f < n; f++)
                {
                    c[i * n + j] = c[i * n + j] + a[i, f] * b[f, j];
                }
            }
        }
        answer = c;

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
        int[] a = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                    count++;
            }
            a[j] = count;
        }
        for (int x = 1; x < matrix.GetLength(1); x++)
        {
            int j = x;
            while (j > 0 && a[j - 1] > a[j])
            {
                (a[j - 1], a[j]) = (a[j], a[j - 1]);
                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    (matrix[l, j - 1], matrix[l, j]) = (matrix[l, j], matrix[l, j - 1]);
                }
                j--;
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
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0)
        {
            return null;
        }
        int s = matrix.GetLength(0) - 1;
        int counter = 0;
        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    counter++;
                    break;
                }
            }
        }
        int[,] a = new int[s - counter, matrix.GetLength(1)];
        int n = 0;
        for (int i = 0; i < s - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) 
                {
                    break;
                }
                a[n, j] = matrix[i, j];
            }
            n++;
            if (n >= matrix.GetLength(0) - counter)
            {
                break;
            }

        }
        matrix = a;

        // end

        return matrix;
    }
    #endregion
}