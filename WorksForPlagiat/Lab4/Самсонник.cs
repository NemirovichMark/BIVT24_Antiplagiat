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
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                answer += A[i, j];
        
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
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i,j] < A[row,col])
                {
                    row = i;
                    col = j;
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return answer;
        answer = new int[A.GetLength(1)];
        // code here
        int m = -int.MaxValue;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
                if (A[j, i] > m)
                    m = A[j, i];
            answer[i] = m;
            m = -int.MaxValue;
        }
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
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int m = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            if (A[i, 2] > A[m, 2]) m = i;
        if (m != 3)
            for (int i = 0; i < A.GetLength(1); i++)
                (A[m, i],A[3, i]) = (A[3, i], A[m, i]);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        int m = 0;
        for (int i = 0; i < A.GetLength(1); i++)
            if (A[i, i] > A[m, m]) m = i;
        if (m != 3)
            for (int i = 0; i < A.GetLength(0); i++)
                (A[i,m], A[i, 3]) = (A[i, 3], A[i, m]);
        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return answer;
        answer = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
            for (int j = 0; j < A.GetLength(0); j++)
                if (A[j, i] < 0) answer[i]++;
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
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        int b = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                if (A[i, j] > A[i, b]) b = j;
            for (int j = b; j < m - 1; j++)
                (A[i, j], A[i, j + 1]) = (A[i, j + 1], A[i, j]);
            b = 0;
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
        if (C.GetLength(0) != n || C.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int b = 0;
            for (int j = 0; j < m; j++)
                if (C[i, j] > C[i, b]) b = j;
            for (int j = 0; j < b; j++)
                if (C[i, j] < 0) C[i, j] /= C[i, b];
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double s = 0;
        int a = 0, b = 0, k = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
                if (Z[i, j] > Z[a, b]) { a = i; b = j; }
            }
        Z[a, b] = s / k;
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
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int a = 0, b = 0, m = 0, n = X.GetLength(1), k = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
                if (X[i, j] < 0)
                    k++;
            if (m < k)
            { m = k; a = i; }
            if (n > k)
            { n = k; b = i; }
            k = 0;
        }
        for (int i = 0; i < X.GetLength(1); i++)
            (X[a, i], X[b, i]) = (X[b, i], X[a, i]);
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
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int s = 0, m = 0, a = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] > 0)
                    s += A[i, j];
            if (s > m) {m = s; a = i; }
            s = 0;
        }

        int[,] t = new int [A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < a; i++)
            for (int j = 0; j < A.GetLength(1); j++)
                t[i, j] = A[i, j];
        for (int i = a; i < A.GetLength(0) - 1; i++)
            for (int j = 0; j < A.GetLength(1); j++)
                t[i, j] = A[i+1, j];
        A = t;
        Console.WriteLine(A);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;
        int m = 0;
        for (int i = 0; i < A.GetLength(1); i++)
            if (A[4, i]  < A[4,m]) m = i;
        m++;
        for (int i = A.GetLength(1)-1; i > m; i--)
            for (int j = 0; j < A.GetLength(0); j++) 
            { 
                A[j, i] = A[j, i - 1];
                Console.Write(A[j, i]);
                Console.Write(' ');
            }

        for (int i = 0; i < A.GetLength(0); i++)
            A[i,m] = B[i];

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int m = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] > A[i, m]) m = j;
            if (m == 0)
            {
                if (A[i, 1] > 0)
                    A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (m == A.GetLength(1) - 1) 
            {
                if (A[i, A.GetLength(1) - 2] > 0) A[i, A.GetLength(1) - 2] *= 2;
                else A[i, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[i, m - 1] > A[i, m + 1])
                {
                    if (A[i, m + 1] > 0)
                        A[i, m + 1] *= 2;
                    else A[i, m + 1] /= 2;
                }
                else
                {
                    if (A[i, m - 1] > 0)
                        A[i, m - 1] *= 2;
                    else A[i, m - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int m = 0, p = 0, n = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[m, j]) m = i;
                if (A[i, j] < 0) n++;
                if (A[i, j] > 0) p++;
            }
            if (p > n) A[m, j] = 0;
            else A[m, j] = m+1;
            p = 0;
            n = 0;
            m = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10|| A.GetLength(1) != 5) return null;
        int s = 0, m = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0;i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[m, j]) { m = i; s = 0; }
                else s += A[i, j];
            }
            if (m * 2 < A.GetLength(0))
                A[0, j] = s;
            s = 0;
            m = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        int m = 0;
        for(int j = 0; j < A.GetLength(1); j++)
        {
            for(int i = 0; i < A.GetLength(0); i++)
                if (A[i,j] > A[m,j]) m = i;
            if (A[m,j] < B[j]) A[m,j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int m = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                if (A[i, j] > A[m, j]) m = i;
            if (A[m, j] * 2 < A[0, j] + A[A.GetLength(0)-1, j])
                A[m, j] = (A[0, j] + A[A.GetLength(0)-1, j]) / 2;
            else A[m, j] = m + 1;
            m = 0;
        }

        // end

        return A;
    }
    static void Print(int[,] A)
    {
        
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 1) return null;
        answer = new int[n, 3*n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if ((j + i*2) % 3 == 0) answer[i, j] = 1;
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
        int m = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            if (A[i, i] > A[m, m]) m = i;
        for (int i = 0; i < m; i++)
            for (int j = i+1; j < A.GetLength(0); j++)
                A[i, j] = 0;

        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write($"{A[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int m = 0, n = 0;
        for (int i = 0; i < B.GetLength(0); i+=2)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, m]) m = j;
                if (B[i+1, j] > B[i+1, n]) n = j;
            }
            (B[i, m], B[i + 1, n]) = (B[i + 1, n], B[i, m]);
            n = 0;
            m = 0;
        }
        //end

            return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0;i < A.GetLength(0);i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
                (A[i, j], A[i, A.GetLength(1)-1 - j]) = (A[i, A.GetLength(1)-1 - j], A[i, j]);
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
            matrix[0, i] = matrix[i, 0] = matrix[i, matrix.GetLength(0)-1] = matrix[matrix.GetLength(0)-1, i] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int n = matrix.GetLength(0);
        for (int i = n / 2; i < n; i++)
            for (int j = 0; j <= i; j++)
                matrix[i, j] = 1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null,null);
        int n = matrix.GetLength(0);
        upper = new int[(n+1)*n/2];
        lower = new int[upper.Length - n];
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = i; j < n; j++)
        //    {
        //        upper[i + j] = matrix[i, j];
        //        Console.Write(upper[i + j]);
        //        Console.Write(' ');
        //    }
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {
        //        lower[i + j] = matrix[i, j];
        //        Console.Write(lower[i + j]);
        //        Console.Write(' ');
        //    }
        //}
        int a = 0, b = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                if ( j < i)
                {
                    lower[b] = matrix[i, j];
                    b++;
                }
                else
                {
                    upper[a] = matrix[i, j];
                    a++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[,] t = new int[matrix.GetLength(0), 2];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            t[i, 0] = i;
            t[i, 1] = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] > 0)
                    t[i, 1]++;
            int f = i;
            while (f > 0 && t[f, 1] > t[f - 1, 1])
            {
                (t[f, 1], t[f - 1, 1]) = (t[f - 1, 1], t[f, 1]);
                (t[f, 0], t[f - 1, 0]) = (t[f - 1, 0], t[f, 0]);
                f--;
            }

        }
        int[,] a = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                a[i,j] = matrix[t[i, 0], j];
        matrix = a;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i+=2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
                    if (matrix[i, k] < matrix[i, k + 1])
                        (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i += 2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
                    if (matrix[i, k] > matrix[i, k + 1])
                        (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int[] t = new int[matrix.GetLength(0)];
        int k = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0) { t[i] = 1; k--; break; }
            
        }
        int[,] a = new int[k,matrix.GetLength(1)];
        for (int i = 0, c = 0; i < matrix.GetLength(0); i++)
            if (t[i] == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    a[c, j] = matrix[i, j];
                c++;
            }
        matrix = a;

        // end

        return matrix;
    }
    #endregion
}