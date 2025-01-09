using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return answer;
        answer = new int[A.GetLength(0)];
        int min;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            min = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    answer[i] = j;
                }
            }
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
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i,0]; int t; int f = 0; 
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    f = j;
                }

            }
            t = A[i, 0];
            A[i, 0] = A[i, f];
            A[i, f] = t;
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
        int i0 = 0; int i1 = 0; int max = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i0 = i;
                    i1 = j;
                }
            }
        }
        int[,] b = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0; i < i0; i++)
        {
            for (int j = 0; j < i1; j++)
            {
                b[i, j] = A[i, j];
            }
        }
        for (int i = i0 + 1; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < i1; j++)
            {
                b[i - 1, j] = A[i, j];
            }
        }
        for (int i = 0; i < i0; i++)
        {
            for (int j = i1 + 1; j < A.GetLength(1); j++)
            {
                b[i, j - 1] = A[i, j];
            }
        }
        for (int i = i0 + 1; i < A.GetLength(0); i++)
        {
            for (int j = i1 + 1; j < A.GetLength(1); j++)
            {
                b[i - 1, j - 1] = A[i, j];
            }
        }
        return b;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0]; int ind = 0;
            A[i, ind] *= (i + 1);
            for (int j = 0; j < A.GetLength(1); j++)
            {

                if (A[i, j] > max)
                {

                    A[i, ind] /= (i + 1);
                    max = A[i, j];
                    ind = j;
                    A[i, ind] *= (i + 1);
                }
            }
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
        for (int i = 0; i < n; i++)
        {
            int max = D[i, 0]; int i0 = 0; int i1 = 0; int j = 0;
            if (D[i, 0] >= 0) 
            {
                max = D[i, 0]; i0 = 0; i1 = 0; j = 0;
                while (D[i, j] >= 0 && j < m - 1)
                {
                    if (D[i, j] > max)
                    {
                        max = D[i, j]; i0 = j;
                    }
                    j++;
                }
                for (j = 0; j < m; j++)
                {
                    if (D[i, j] < 0)
                    {
                        i1 = j;
                    }
                }
                if (i1 != 0)
                {
                    int t = D[i, i1];
                    D[i, i1] = D[i, i0];
                    D[i, i0] = t;
                }
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
        if(H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0]; 
            for (int j = 0; j < H.GetLength(1) - 1; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max;
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
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0]; int ind = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    ind = j;
                }
            }
            if (max != Y[i, 0])
            {
                double avg = 0; double k = 0;
                for (int j = ind + 1; j < Y.GetLength(1); j++)
                {
                    if (Y[i, j] > 0)
                    {
                        avg += Y[i, j]; k++;
                    }
                }
                if (k != 0)
                {
                    avg /= k;
                }
                for (int j = 0; j < ind; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = avg;
                    }
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        int[,] B1 = new int[B.GetLength(0), B.GetLength(1)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B1[i, j] = B[i, j];
            }
        }
        for (int i = B.GetLength(0) - 1; i >= 0; i--)
        {
            int max = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            B1[B1.GetLength(0) - i - 1, 3] = max;
        }
        return B1;
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
        int max = B[0, 0]; int i0 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                i0 = i;
            }
        }
        int i1 = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                i1 = i;
                break;
            }
        }
        if (i1 == -1)
        {
            return B;
        }
        int[] t = new int[B.GetLength(1)];
        for (int j = 0; j < B.GetLength(0); j++)
        {
            t[j] = B[i0, j];
        }
        for (int j = 0; j < B.GetLength(0); j++)
        {
            B[i0, j] = B[i1, j];
            B[i1, j] = t[j];
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
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        int k=0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    k++;
                }
            }
        }
        answer = new int[k];
        k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[k] = A[i, j];
                    k++;
                }
            }
        }
        Console.WriteLine(answer.Length);
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i]);
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = -10000000000000;
            int ind = 0;
            for (int j = 0; j < A.GetLength(1); j++) 
            { 
                if (max < A[i, j]) 
                {
                    max = A[i, j]; ind = j;
                } 
            }
            if (ind == 0) 
            { 
                if (A[i, ind + 1] > 0) 
                {
                    A[i, ind + 1] *= 2; 
                } 
                else 
                { 
                    A[i, ind + 1] /= 2;
                }
            }
            if (ind == A.GetLength(1) - 1)
            {
                if (A[i, ind - 1] > 0)
                {
                    A[i, ind - 1] *= 2;
                }
                else
                {
                    A[i, ind - 1] /= 2;
                }
            }
            else
            {
                if (A[i, ind - 1] > A[i, ind + 1])
                {
                    if (A[i, ind + 1] > 0)
                    {
                        A[i, ind + 1] *= 2;
                    }
                    else
                    {
                        A[i, ind + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, ind - 1] > 0)
                    {
                        A[i, ind - 1] *= 2;
                    }
                    else
                    {
                        A[i, ind - 1] /= 2;
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
        if(A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int polk = 0, negk = 0, max = -10000, maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) polk++; 
                if (A[i, j] < 0) negk++;
                if (A[i, j] > max)
                { 
                    max = A[i, j]; 
                    maxi = i;
                }
            }
            if (polk > negk) A[maxi, j] = 0; 
            else  A[maxi, j] = maxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -10000000, ind = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            for (int i = ind + 1; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
            }
            if (ind <= 4)
            {
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B == null || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -1000000, maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) 
                {
                    max = A[i, j];
                    maxi = i; 
                }
            }
            if (A[maxi, j] < B[j]) A[maxi, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = -1000000;
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) 
                { 
                    max = A[i, j];
                    maxi = i; 
                }
            }
            if (max < (A[0, j] + A[A.GetLength(0) - 1, j]) / 2)
            {
                A[maxi, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            }
            else
            {
                A[maxi, j] = maxi + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)  return null; 
        answer = new int[n, n * 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j % 3) answer[i, j] = 1; 
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6) { return null; }
        int max = -100000; int maxi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max) 
            { 
                max = A[i, i];
                maxi = i; 
            }
        }
        for (int j = 0; j < A.GetLength(0) - 1; j++)
        {
            if (j == maxi) break;
            for (int k = j + 1; k < A.GetLength(1); k++) A[j, k] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) return null; 
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = -1000000, max2 = -1000000, maxi1 = 0, maxi2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1)
                { 
                    max1 = B[i, j];
                    maxi1 = j; 
                }
                if (B[i + 1, j] > max2)
                { 
                    max2 = B[i + 1, j];
                    maxi2 = j;
                }
            }
            B[i, maxi1] = max2;
            B[i + 1, maxi2] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < (A.GetLength(1) - 1) / 2; j++)
            {
                int t = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = t;
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
        if (matrix == null || matrix.GetLength(0) != 6 || matrix.GetLength(1) != 6) return null;
        int n = matrix.GetLength(0) - 1;
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[i, n] = 0;
            matrix[n, n - i] = 0;
            matrix[n - i, 0] = 0;
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5) return null; 
        int n = matrix.GetLength(0);
        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j <= i; j++) matrix[i, j] = 1; 
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
        if (matrix == null || matrix.GetLength(0) != 6 || matrix.GetLength(1) != 6)  return (null, null); 
        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2];
        lower = new int[n * (n - 1) / 2];
        int k1 = 0, k2 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j) 
                { 
                    upper[k1] = matrix[i, j];
                    k1++; 
                } 
                else 
                {
                    lower[k2] = matrix[i, j];
                    k2++;
                }
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
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] polk = new int[matrix.GetLength(0)], pind = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) { k++; }
                matrix1[i, j] = matrix[i, j];
            }
            polk[i] = k;
            pind[i] = i;
        }
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int l = 0; l < matrix.GetLength(0) - k - 1; l++)
            {
                if (polk[l] < polk[l + 1])
                {
                    int t1 = polk[l + 1], t2 = pind[l + 1];
                    polk[l + 1] = polk[l];
                    polk[l] = t1;
                    pind[l + 1] = pind[l];
                    pind[l] = t2;
                }
            }
        }
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                matrix[i1, j1] = matrix1[pind[i1], j1];
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int t = matrix[i, k + 1];
                            matrix[i, k + 1] = matrix[i, k];
                            matrix[i, k] = t;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int t = matrix[i, k + 1];
                            matrix[i, k + 1] = matrix[i, k];
                            matrix[i, k] = t;
                        }
                    }

                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null; 
        bool[] a = new bool[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) 
                {
                    a[i] = true; 
                    break;
                }
            }
        }
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        { 
            if (a[i] == false)  k++;
        }
        int[,] matrix1 = new int[k, matrix.GetLength(1)];
        for (int i1 = 0, ik = 0; i1 < matrix.GetLength(0); i1++, ik++)
        {
            if (a[i1] == true)
            {
                ik--; 
                continue;
            }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                matrix1[ik, j1] = matrix[i1, j1];
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}