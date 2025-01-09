using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        /* program.Task_1_6(new int[,]{
             { 1, 2, 3, 4, 5, 6, 7 },
                 { 5, 6, 7, 8, -9, 10, 11 },
                 { 9, 10, -11, -12, -13, -14, -15 },
                 { -13, -14, 15, 16, 17, 18, -19 }
         });*/
        /*program.Task_1_12(new int[,]{
            
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 }
            });*/
        /* program.Task_1_15(new int[,]{

         { 1, 2, -3, 4, -5, 6, 7 },
                 { 5, 6, -7, 8, 9, -10, -11 },
                 { 0, 10, 11, -12, 13, 14, 15 },
                 { -13, 14, 15, 16, 17, -18, -19 },
                 { 0, -1, -2, -3, -4, -5, -6 }
     });*/

        /*program.Task_3_9(new int[,]
        {
               { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
        });*/
        /* program.Task_1_9(new int[,]{
             { 1, 2, 3, 4, -5, -6, -7 },
                 { 5, 11, -17, 11, -10, 6, 5 },
                 { -9, -10, -11, -14, -15, -16, 1 },
                 { -9, -10, -11, -14, -15, -6, -2 },
                 { -9, -10, -11, -14, -15, 6, 4 }
         });*/
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
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
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
        int[] answer = new int[A.GetLength(0)];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if ((A.GetLength(0) != 4) & (A.GetLength(1) != 7)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = A[i, 0];
            int j_min = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    j_min = j;
                }

            }
            answer[i] = j_min;

        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.WriteLine(answer[i]);
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
        int max, j_max = 0, t;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if ((A.GetLength(0) != 5) & (A.GetLength(1) != 7)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {

            max = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    j_max = j;
                }
            }
            t = A[i, 0];
            A[i, 0] = max;
            A[i, j_max] = t;

        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if ((A.GetLength(0) != 6) & (A.GetLength(1) != 7)) return null;
        int max = A[0, 0], i_max = -1, j_max = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max)
                {
                    max = A[i, j];
                    i_max = i;
                    j_max = j;
                }
            }
        }
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            if (i < i_max)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    B[i, j] = A[i, j];

            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    B[i, j] = A[i + 1, j];
            }
        }
        int[,] C = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1) - 1; j++)
            {
                if (j < j_max) C[i, j] = B[i, j];
                else C[i, j] = B[i, j + 1];
            }
        }
        A = C;
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }

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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if ((A.GetLength(0) != 5) & (A.GetLength(1) != 7)) return null;
        int max, j_max;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            max = A[i, 0];
            j_max = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max)
                {
                    max = A[i, j];

                    j_max = j;
                }
            }
            A[i, j_max] *= i + 1;
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
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

        if ((D.GetLength(0) != n) || (D.GetLength(1) != m)) return null;
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = D[i, 0];
            int j_max = -1;
            int first = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0) { first = j; break; }
            }
            if (first == -1) continue;

            for (int j = 0; j < first; j++)
            {
                if (D[i, j] >= max) { max = D[i, j]; j_max = j; }
            }
            if (j_max == -1) continue;
            for (int j = D.GetLength(1) - 1; j >= 0; j--)
            {
                if (D[i, j] < 0) { int temp = D[i, j_max]; D[i, j_max] = D[i, j]; D[i, j] = temp; break; }
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
        for (int i = 0; i < H.GetLength(0); i++)
        {
            for (int j = 0; j < H.GetLength(1); j++)
            {
                Console.Write("{0:d} ", H[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if ((H.GetLength(0) != 5) & (H.GetLength(1) != 7)) return null;
        int max;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            max = H[i, 0];
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }
            H[i, H.GetLength(1) - 1] = max;
        }
        int t;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            t = H[i, H.GetLength(1) - 1];
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = t;
        }
        for (int i = 0; i < H.GetLength(0); i++)
        {
            for (int j = 0; j < H.GetLength(1); j++)
            {
                Console.Write("{0:d} ", H[i, j]);
            }
            Console.WriteLine();
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
            double max = Y[i, 0];
            int j_max = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max) { max = Y[i, j]; j_max = j; }
            }
            double sum = 0; int n = 0;
            double sr = 0;
            for (int j = j_max + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0) { sum += Y[i, j]; n++; }
            }
            if (n == 0) sr = 0; else sr = sum / n;
            for (int j = 0; j < j_max; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = sr;
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
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if ((B.GetLength(0) != 5) & (B.GetLength(1) != 7)) return null;
        int[] a = new int[B.GetLength(0)];
        int max;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            max = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max) max = B[i, j];
            }
            a[i] = max;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = a[4 - i];
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
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
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if ((B.GetLength(0) != 5) & (B.GetLength(1) != 5)) return null;
        int max_d = B[0, 0], i_max = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > B[0, 0])
            {
                max_d = B[i, i];
                i_max = i;
            }
        }
        int i_f_neg = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0) { i_f_neg = i; break; }
        }
        if (i_f_neg == -1) return B;
        int t = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (i == i_f_neg)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    t = B[i_f_neg, j];
                    B[i_f_neg, j] = B[i_max, j];
                    B[i_max, j] = t;

                }
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
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
        //int[] answer = default(int[]);
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if ((A.GetLength(0) != 5) & (A.GetLength(1) != 7)) return null;
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) k++;
            }
        }
        int[] answer = new int[k];
        int t = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) { answer[t] = A[i, j]; t++; }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            Console.Write(answer[i]);
            Console.Write(" ");
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[0, 0];
            int j_max = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max) { max = A[i, j]; j_max = j; }
            }
            if (j_max != 0 && j_max != A.GetLength(1) - 1)
            {
                if (A[i, j_max - 1] < A[i, j_max + 1]) { if (A[i, j_max - 1] > 0) A[i, j_max - 1] *= 2; else A[i, j_max - 1] *= 0.5; }
                else { if (A[i, j_max + 1] > 0) A[i, j_max + 1] *= 2; else A[i, j_max + 1] *= 0.5; }
            }
            else if (j_max == 0) { if (A[i, j_max + 1] > 0) A[i, j_max + 1] *= 2; else A[i, j_max + 1] *= 0.5; }
            else if (j_max == A.GetLength(1) - 1) { if (A[i, j_max - 1] > 0) A[i, j_max - 1] *= 2; else A[i, j_max - 1] *= 0.5; }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int c_positive = 0; int c_negative = 0;
            int max = A[0, 0], i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; i_max = i; }
                if (A[i, j] > 0) c_positive++;
                if (A[i, j] < 0) c_negative++;
            }
            if (c_positive > c_negative) A[i_max, j] = 0; else A[i_max, j] = i_max+1;
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
            int sum = 0;
            int max = A[0, 0], i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; i_max = i; }

            }
            for (int i = i_max + 1; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
            }
            if (i_max <= A.GetLength(0) / 2) A[0, j] = sum;

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5 || A.GetLength(1) != B.Length) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, 0], i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; i_max = i; }
            }
            if (B[j] > max) { int temp = A[i_max, j]; A[i_max, j] = B[j]; B[j] = temp; }

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
            double max = A[0, 0];
            int i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; i_max = i; }
            }
            double half_sum_of_f_and_l = 0.5 * (A[0, j] + A[A.GetLength(0) - 1, j]);
            if (A[i_max, j] < half_sum_of_f_and_l) A[i_max, j] = half_sum_of_f_and_l;
            else A[i_max, j] = i_max+1;

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i % n == j % n) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = A[0, 0], i_max = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max) { max = A[i, i]; i_max = i; }
        }
        for (int i = 0; i < i_max; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int[] array_max = new int[6];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[0, 0], j_max = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max) { max = B[i, j]; j_max = j; }
            }
            array_max[i] = j_max;
        }
        for (int i = 0; i < B.GetLength(0); i = i + 2)
        {
            int temp = B[i, array_max[i]];
            B[i, array_max[i]] = B[i + 1, array_max[i + 1]];
            B[i + 1, array_max[i + 1]] = temp;
        }
        Console.WriteLine();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int[] aaa = new int[A.GetLength(1)];
            for (int j = A.GetLength(1) - 1; j >= 0; j--)
            {
                aaa[A.GetLength(1) - 1 - j] = A[i, j];
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = aaa[j];
            }
        }
        // end
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[,] arr_of_min_in_rows = new int[matrix.GetLength(0),2];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min) min = matrix[i, j];
            }
            arr_of_min_in_rows[i,0] = min; arr_of_min_in_rows[i, 1] = i;
        }

        for(int i = 1; i < matrix.GetLength(0); i++)
        {
            for(int j=0; j < matrix.GetLength(0)-i; j++)
            {
                if (arr_of_min_in_rows[j,0] < arr_of_min_in_rows[j+1,0])
                {
                    int temp = arr_of_min_in_rows[j,0];
                    arr_of_min_in_rows[j,0] = arr_of_min_in_rows[j + 1,0];
                    arr_of_min_in_rows[j + 1,0] = temp;

                    int temp_2 = arr_of_min_in_rows[j, 1];
                    arr_of_min_in_rows[j, 1] = arr_of_min_in_rows[j + 1, 1];
                    arr_of_min_in_rows[j + 1, 1] = temp_2;
                }
            }
        }
        int [,] changed_array = new int[matrix.GetLength(0),matrix.GetLength(1)];
        for (int i = 0; i < changed_array.GetLength(0); i++)
        {
            for(int j = 0; j < changed_array.GetLength(1); j++)
            {
                changed_array[i, j] = matrix[arr_of_min_in_rows[i, 1], j];
            }
        }
        matrix = changed_array;

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int[] answer = new int [2*matrix.GetLength(0)-1];
        // code here
        for (int i = matrix.GetLength(0) - 1, i_of_vector_of_answer = 0; i > (-1) * matrix.GetLength(0); i--, i_of_vector_of_answer++)
        {
            int sum_of_parallel = 0;
            for(int j = 0;j < matrix.GetLength(1); j++)
            {
                if((i+j) >= 0 && (i+j) < matrix.GetLength(0)) sum_of_parallel += matrix[i+j, j];
            }
            answer[i_of_vector_of_answer] = sum_of_parallel;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k>= matrix.GetLength(1) || k >= matrix.GetLength(0) || k<=0 || matrix.GetLength(0)==0) return null;
        int max_abs = Math.Abs(matrix[0, 0]), i_max = 0, j_max = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > max_abs) { max_abs = Math.Abs(matrix[i, j]); i_max = i; j_max = j; }
            }
        }
        k-=1; //k-номер столбца/строки, а не индекс
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, k];
            matrix[i, k] = matrix[i, j_max];
            matrix[i, j_max] = temp;
        }
        for(int j=0;j < matrix.GetLength(1); j++)
        {
            int temp_2=matrix[k, j];
            matrix[k, j] = matrix[i_max, j];
            matrix[i_max, j] = temp_2;

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
        int[] answer = new int[n * n];
        // code here
        if (A.Length != B.Length) return null;
        int s = 0;
        for (int i = 1; i <= n; i++) { s += i; }
        if (A.Length != s) return null;

        int[,] matrix_A = new int[n, n]; int[,] matrix_B = new int[n, n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix_A[i, j] = A[index];
                matrix_A[j, i] = A[index];
                matrix_B[i, j] = B[index];
                matrix_B[j, i] = B[index];
                index++;
            }
        }

        int[,] result = new int[n, n]; int c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += matrix_A[i, k] * matrix_B[k, j];
                }
                answer[c] = result[i, j]; c++;
            }
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        int[,] counter_of_neg_in_col = new int[matrix.GetLength(1),2];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0) count++;
            }
            counter_of_neg_in_col[j,0] = count; counter_of_neg_in_col[j, 1] = j;
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i; j++)
            {
                if (counter_of_neg_in_col[j, 0] > counter_of_neg_in_col[j + 1, 0])
                {
                    int temp = counter_of_neg_in_col[j, 0];
                    counter_of_neg_in_col[j, 0] = counter_of_neg_in_col[j + 1, 0];
                    counter_of_neg_in_col[j + 1, 0] = temp;

                    int temp_2 = counter_of_neg_in_col[j, 1];
                    counter_of_neg_in_col[j, 1] = counter_of_neg_in_col[j + 1, 1];
                    counter_of_neg_in_col[j + 1, 1] = temp_2;
                }
            }
        }
        int[,] changed_array = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                changed_array[i, j] = matrix[i, counter_of_neg_in_col[j, 1]];
            }
        }
        matrix = changed_array;
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
        int[] a = new int[matrix.GetLength(0)];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 0;
        }
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) { a[i] = 1; c++; break; }
            }
        }
        int[,] matrix_n = new int[matrix.GetLength(0) - c, matrix.GetLength(1)];
        for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
        {
            if (a[i] == 0)
            { for (int j = 0; j < matrix.GetLength(1); j++) { matrix_n[k, j] = matrix[i, j]; } k++; }

        }
        matrix = matrix_n;

        // end

        return matrix;
    }
    #endregion
} 