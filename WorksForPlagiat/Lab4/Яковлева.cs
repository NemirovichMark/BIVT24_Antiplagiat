using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            };
         //program.Task_1_32(matrix);
        int[,] A = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        //program.Task_2_7(A);
        int[,] B = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, -5 }
            };
        //program.Task_2_8(B);
        int[,] C = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        //program.Task_3_2(C);
        //program.Task_3_6(C);
        int[,] D = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };
        //program.Task_3_11(D);
        int[,] E = {
                { 1, 2, -3, 7, 7 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9 },
                { 0, 0, -1, -2, -3 }
            };
        program.Task_3_4(E);

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
        double k = 0;
        for (int i = 0;i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] > 0)
                {
                    answer += A[i,j];
                    k++;
                }
            }
        }
        if (k != 0)
        {
            answer /= k;
        }
        else answer = 0;
        
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
        if (colIndex < 0) return (0, 0);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex < 0) return (0, 0);
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
        double[] answer = new double[A.GetLength(0)];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double s = 0, k = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }
            if (k != 0)
            {
                answer[i] = s / k;
            }
            else answer[i] = 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] b = new int[A.GetLength(0)-1, A.GetLength(1)];
        int imin = -1, vmin = 1000000000;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 1] < vmin)
            {
                vmin = A[i, 1];
                imin = i;
            }
        }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            if (i < imin)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    b[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    b[i, j] = A[i+1, j];
                }
            }
        }
        A = b;
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

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = new int[A.GetLength(1)];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                    k++;
            }
            answer[j] = k;
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int nmin = 100000000, jmin = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i,j] < nmin)
                {
                    nmin = B[i,j];
                    jmin = j;
                }
            }
            while (jmin > 0)
            {
                B[i,jmin] = B[i, jmin-1];
                jmin--;
            }
            B[i, 0] = nmin;
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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            double nmax = -100000000, n1 = 0, n2 = 0 , s = 0;
            int jmax = 0, j1 = -1, j2 = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i,j] > nmax)
                {
                    nmax = F[i,j];
                    jmax = j;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    n1 = F[i,j];
                    j1 = j;
                    break;
                }
            }
            for (int j = m-1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    n2 = F[i, j];
                    j2 = j;
                    break;
                }
            }
            s = (n1 + n2) / 2;
            if (s < 0) F[i,jmax] = s;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        for (int i = 0; i < G.GetLength(0); i++)
        {
            double nmax = -100000000;
            int jmax = 0;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > nmax)
                {
                    nmax = G[i, j];
                    jmax = j;
                }
            }
            int n = G.GetLength(1)-1;
            while (jmax < n)
            {
                G[i, n] = G[i, n - 1];
                n--;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (B.Length != 7) return null;
        int w = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > A[w, 5]) w = i;
        }
        for (int j = 0; j < B.Length; j++)
        {
            A[w, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        int jmin = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < Math.Abs(F[1, jmin])) jmin = j;
        }
        jmin += 1;
        int[,] temp = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int i = 0; i< F.GetLength(0); i++)
        {
            for(int j = 0;j < F.GetLength(1)-1; j++)
            {
                if (j < jmin) temp[i, j] = F[i, j];
                else temp[i, j] = F[i, j + 1];
            }
        }
        F = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        Print(A);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double k = 0, sr = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sr += A[i, j];
                    k++;
                }
            }
            if (k != 0)
            {
                sr /= k;
            }
            else sr = 0;
            int imax = 0;
            double nmax = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = j;
                }
            }
            A[i, imax] = sr;
            
        }
        Print(A);
        void Print(double[,] L)
        {
            for (int i = 0;i < L.GetLength(0); i++)
            {
                for(int j = 0;j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i,j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int imax = 0;
            double nmax = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = j;
                }

            }
            if (imax == 0)
            {
                if (A[i, 1] > 0)
                {
                    A[i, 1] *= 2;
                }
                else A[i, 1] /= 2;
            }
            else if (imax == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0)
                {
                    A[i, A.GetLength(1) - 2] *= 2;
                }
                else A[i, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[i, imax - 1] <= A[i, imax + 1])
                {
                    if (A[i, imax - 1] > 0)
                    {
                        A[i, imax - 1] *= 2;
                    }
                    else A[i, imax - 1] /= 2;
                }
                else
                {
                    if (A[i, imax + 1] > 0)
                    {
                        A[i, imax + 1] *= 2;
                    }
                    else A[i, imax + 1] /= 2;

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
        int row = A.GetLength(0), col = A.GetLength(1);
       
        for (int j = 0;j<col; j++)
        {
            int kpos = 0, kneg = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > 0) kpos++;
                else if (A[i, j] < 0) kneg++;
            }
            int imax = 0;
            double nmax = double.MinValue;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = i;
                }
            }
            if (kpos > kneg)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax+1;
            }

        }
        
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);

        for (int j = 0; j < col; j++)
        {
            int imax = 0;
            double nmax = double.MinValue;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = i;
                }
            }
            if (imax < row / 2)
            {
                int s = 0;
                for (int i = imax+1; i < row; i++)
                {
                    s += A[i, j];
                }
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        if (B.Length != 5) return null;
        for (int j = 0; j < col; j++)
        {
            int imax = 0;
            double nmax = double.MinValue;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = i;
                }
            }
            if (B[j] > nmax)
            {
                A[imax, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        for (int j = 0; j < col; j++)
        {
            int imax = 0;
            double nmax = double.MinValue;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = i;
                }
            }
            if (nmax < (A[0, j] + A[row-1, j]) / 2)
            {
                A[imax, j] = (A[0, j] + A[row - 1, j]) / 2;
            }
            else
            {
                A[imax, j] = imax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n <= 0) return null;
        int[,] answer = new int[n,3*n];
        int i = 0;
        for (int j = 0; j < 3 * n; j++)
        {
            answer[i, j] = 1;
            i++;
            if (i > n-1)
            {
                i = 0;
            }
        }
        Print(answer);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        int gmax = 0;
        for (int i = 0; i < row; i++)
        {
            if (A[i,i] > A[gmax, gmax]) gmax = i;
        }
        int k = 0;
        Console.WriteLine(gmax);
        for (int i = 0; i < gmax; i++)
        {
            for (int j = 1 + k; j < col; j++)
            {
                A[i, j] = 0;
            }
            k++;
        }
        Print(A);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int row = B.GetLength(0), col = B.GetLength(1);
        int i = 0, max1 = 0, max2 = 0;
        for (int l = 0; l < 3; l++)
        {
            max1 = 0; max2 = 0;
            for (int j = 0; j < col; j++)
            {
                if (B[i, j] > B[i, max1]) max1 = j;
                if (B[i+1, j] > B[i+1, max2]) max2 = j;
            }
            (B[i, max1], B[i + 1, max2]) = (B[i + 1, max2], B[i, max1]);
            i += 2;
        }
        Print(B);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
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
        int row = A.GetLength(0), col = A.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col/2; j++)
            {
                (A[i, j], A[i, col - j - 1]) = (A[i, col - j - 1], A[i, j]);
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int row = matrix.GetLength(0), col = matrix.GetLength(1);

        int k = 1;
        for (int j = 0; j < col; j++)
        {
            matrix[j, 0] = 0;
            matrix[0, j] = 0;
            matrix[col - j - 1, col - 1] = 0;
            matrix[col - 1, col - j - 1] = 0;

        }
        Print(matrix);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int n = matrix.GetLength(0);
        if (n % 2 != 0)
        {
            for (int i = n/2; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        else
        {
            for (int i = n/2 - 1; i < n; i++)
            {
                for (int j = 0; j <= i + 1; j++)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        Console.WriteLine(n/2);
        Print(matrix);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return (null, null);
        int n = matrix.GetLength(0);
        // code here
        int k1 = 0, k2 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                k1++;
            }
        }
        Console.WriteLine(k1);
        k2 = n*n - k1;
        Console.WriteLine(k2);
        Console.WriteLine(n);
        int[] upper = new int[k1];
        int[] lower = new int[k2];
        k1 = 0; k2 = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                lower[k2++] = matrix[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                upper[k1++] = matrix[i, j];
            }
        }
        Print(matrix);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Print1(lower);
        Print1(upper);
        void Print1(int[] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                Console.Write($"{L[i]}  ");
            }
            Console.WriteLine();
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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5) return null;
        int row  = matrix.GetLength(0), col = matrix.GetLength(1);
        
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row - i - 1; j++)
            {
                int k1 = 0, k2 = 0;
                for (int l = 0; l < col; l++)
                {
                    if (matrix[j, l] > 0) k1++;
                    if (matrix[j+1, l] > 0) k2++;
                }
                if (k1 < k2)
                {
                    for (int l = 0; l < col; l++)
                    {
                        (matrix[j, l], matrix[j + 1, l]) = (matrix[j + 1, l], matrix[j, l]);
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            if (i % 2 == 0)
            {
                for (int c = 0; c < col; c++)
                {
                    for (int j = 0; j < col - c - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
                    }
                }
            }
            else
            {
                for (int c = 0; c < col; c++)
                {
                    for (int j = 0; j < col - c - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool t = false;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0) 
                {
                    t = true;
                    break;
                }
            }
            Console.WriteLine(t);
            if (t)
            {
                int[,] temp = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
                for (int l = 0; l < matrix.GetLength(0) - 1; l++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (l < i) temp[l, j] = matrix[l, j];
                        else temp[l, j] = matrix[l + 1, j];
                    }
                }
                matrix = temp;
                i--;
            }
        }
        Print(matrix);
        void Print(int[,] L)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    Console.Write($"{L[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    #endregion
}