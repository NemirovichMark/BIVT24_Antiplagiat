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
        /*int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
        */
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };

        Program program = new Program();
        matrix = program.Task_3_10(matrix);
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0;
        }
        for (int i = 0; i<5; i++)
        {
            for (int j =0; j<7; j++)
            {
                //Console.WriteLine(A[i,j]);
                answer += A[i,j];
            }
        }
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

        int mn = 1000000;
        // code here
        if (A.GetLength(0)!=3 || A.GetLength(1) != 6)
        {
            return (0,0);
        }
        for (int i = 0; i<3; i++)
        {
            for (int j = 0; j<6; j++)
            {
                if (A[i,j] < mn)
                {
                    mn = A[i, j];
                    row = i; col = j;
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
        int cnt = 0;
        // code here
        if (A.GetLength(0)!=3 || A.GetLength(1)!=5)
        {

            return answer;
        }
        answer = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int mx = -10000;
            for (int j = 0; j<3; j++)
            {
                if (mx < A[j, i])
                {
                    mx = A[j, i];
                }
            }
            answer[cnt++] = mx;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int r1 = 0, c1= 0, r2 = 0, c2 = 0;
        int mx = -1000000;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 2] > mx)
            {
                mx = (A[i, 2]);
                r1 = i; c1 = 2;
            }
        }
        for (int i = 0; i<7; i++)
        {
            (A[r1, i], A[3,i]) = (A[3, i], A[r1,i]);
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=5)
        {
            return null;
        }

        int mx = -1000000, c = 0;
        for (int i = 0, j = 0; i < 5 && j < 5; i++, j++)
        {
            if (A[i, j] > mx)
            {
                mx = A[i, j];
                c = j;
            }
        }

        for (int i = 0; i<5; i++)
        {
            (A[i, 3], A[i, c]) = (A[i, c], A[i, 3]);
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
        if (A.GetLength(0)!=n || A.GetLength(1) != m)
        {
            return null;
        }

        for (int i = 0; i<n; i++)
        {
            int mx = -1000000, c = 0;
            for (int j = 0; j<m; j++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    c = j;
                }
            }

            for (int j = c + 1; j<m; j++)
            {
                (A[i, j], A[i, j - 1]) = (A[i, j - 1], A[i, j]);
            }
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
        if (C.GetLength(0) != n || C.GetLength(1) != m)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            double mx = -1000000; int c = 0;
            for (int j = 0; j < m; j++)
            {
                if (mx < C[i, j])
                {
                    mx = C[i, j];
                    c = j;
                }
            }
            if (mx == 0) continue;
            for (int j = 0; j < c; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] /= mx;
                }
            }
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
        {
            return null;
        }
        int n = 6, m = 8;
        int c = 0, r = 0;
        double sum = 0; int cnt = 0;
        double mx = -1000000;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    cnt++;
                }
                if (mx < Z[i, j])
                {
                    mx = Z[i, j];
                    c = j; r = i;
                }
            }
        }

        Z[r,c] = sum/cnt;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }
        int n = 6, m = 5;
        int r1= 0, r2 =0;
        int cnt1 = -1000, cnt2 = 1000;
        for (int i = 0; i < n; i++)
        {
            int cnt = 0;
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] < 0)
                {
                    cnt++;
                }
            }
            if (cnt > cnt1)
            {
                cnt1 = cnt;
                r1 = i;
            }

            if (cnt < cnt2)
            {
                cnt2 = cnt;
                r2 = i;
            }
        }

        for (int i =0; i<m; i++)
        {
            (X[r1, i], X[r2, i]) = (X[r2, i], X[r1, i]);
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
        // code here
        int[,] B = new int[6, 5];
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int n = 7, m = 5;
        int mx = -100000, r = 0;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j] > 0) sum += A[i, j];
            }
            if (sum > mx)
            {
                mx = sum; r = i;
            }
        }

        int cnt = 0;
        for (int i =0; i<n; i++)
        {
            if (i == r) continue;
            for (int j = 0; j<m; j++)
            {
                B[cnt, j] = A[i, j];
            }
            cnt++;
        }
        // end

        return B;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length!=5)
        {
            return null;
        }
        int n = 5, m = 8;
        int mn = 100000, c = 0;
        for (int i = 0; i < m; i++)
        {
            if (mn > A[4, i])
            {
                mn = A[4, i];
                c = i;
            }
        }

        for (int j = c + 1; j < m; j++)
        {
            for (int i =0; i<n; i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }

        for (int i =0; i<5; i++)
        {
            A[i, c + 1] = B[i];
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n!=5 || m != 7)
        {
            return null;
        }
        for (int i =0; i<n; i++)
        {
            int pos = 0; double mx = -1e9;
            for (int j = 0; j<m; j++)
            {
                if (mx < A[i, j])
                {
                    pos = j;
                    mx = A[i, j];
                }
            }

            double l = 1e9, r = 1e9;
            if (pos>0) l = A[i, pos - 1];
            if (pos < m) r = A[i, pos + 1];

            if (l < r) {
                if (A[i, pos - 1] > 0) A[i, pos - 1] *= 2;
                else A[i, pos - 1] /= 2;
            }
            else if (l > r) {
                if (A[i, pos + 1] > 0) A[i, pos + 1] *= 2;
                else A[i, pos + 1] /= 2;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int pos = 0; int mx = -10000000;
            int cnt0 = 0, cnt1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0) cnt0++;
                else if (A[i, j] > 0) cnt1++;
                if (mx<A[i, j])
                {
                    mx = A[i, j];
                    pos = i;
                }
            }
            //Console.WriteLine("{0:d}, {1:d}, {2:d}, {3:d}", pos, j, cnt0, cnt1);
            if (cnt0 < cnt1)
            {
                A[pos,j] = 0;
            }
            else
            {
                A[pos, j] = pos;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int pos = 0; int mx = -10000000;
            for (int i = 0; i < n; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    pos = i;
                }
            }

            if (pos > n / 2) continue;

            int sum = 0;
            for (int i = pos + 1; i<n; i++)
            {
                sum+= A[i, j];
            }

            A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int pos = 0; int mx = -10000000;
            for (int i = 0; i < n; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    pos = i;
                }
            }
            //Console.WriteLine("{0:d}, {1:d}, {2:d}, {3:d}", pos, j, B[j], A[pos,j]);
            if (B[j] > A[pos, j])
            {
                A[pos, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int pos = 0; double mx = -10000000;
            for (int i = 0; i < n; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    pos = i;
                }
            }
            double sum = (A[0, j] + A[n - 1, j]) / 2;

            if (sum > A[pos, j])
            {
                A[pos, j] = sum;
            }
            else
            {
                A[pos, j] = pos;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3*n];
        // code here
        for (int i =0; i<n; i++)
        {
            for (int j =0; j < 3 * n; j++)
            {
                if ((j - i) % n == 0)
                {
                    answer[i, j] = 1;
                }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int r = 0, c = 0;
        int mx = -1000000;
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6)
        {
            return null;
        }
        for (int i = 0, j = 0; i < 6 && j < 6; j++, i++)
        {
            if (mx < A[i, j])
            {
                mx = A[i, j];
                c = j; r = i;
            }
        }

        for (int i = 0; i<r; i++)
        {
            for (int j = i+1; j<6; j++)
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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6)
        {
            return null;
        }
        for (int i =0; i<n; i+=2)
        {
            int r = 0, c = 0;
            int mx = -1000000;
            for (int j = 0; j<n; j++)
            {
                if (B[i,j] > mx)
                {
                    mx = B[i, j]; c = j; r = i;
                }
            }

            int r1 = 0, c1 = 0;
            mx = -1000000;
            for (int j = 0; j<n; j++)
            {
                if (B[i + 1, j] > mx)
                {
                    mx = B[i + 1, j]; c1 = j; r1 = i + 1;
                }
            }

            (B[r, c], B[r1, c1]) = (B[r1, c1], B[r, c]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7)
        {
            return null;
        }
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m/2; j++)
            {
                (A[i,j], A[i,m-j-1]) = (A[i,m-j-1], A[i,j]);
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m)
        {
            return null;
        }
        for (int i = 0; i<4*n; i++)
        {
            if (i < n && i >= 0) matrix[0, i] = 0;
            else if (i >= n && i < 2 * n) matrix[i % n, n - 1] = 0;
            else if (i >= n * 2 && i < 3 * n) matrix[n - 1, i % n] = 0;
            else matrix[i % n, 0] = 0;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m)
        {
            return null;
        }
        for (int i = n/2; i < n; i++)
        {
            for (int j = 0; j<n; j++)
            {
                if (j>i) continue;
                matrix[i, j] = 1;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m)
        {
            return (null, null);
        }
        int[] upper = new int[(n * (n + 1)) / 2];
        int[] lower = new int[(n * (n + 1)) / 2 - n];
        int cnt = 0;
        for (int i =0; i<n; i++)
        {
            for (int j = i; j<n; j++)
            {
                upper[cnt++] = matrix[i, j];
            }
        }
        cnt = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[cnt++] = matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5)
        {
            return null;
        }
        int[] positive = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                if (matrix[i, j] > 0) positive[i]++;
            }
        }

        for (int i =0; i<n; i++)
        {
            int mx = -10000, pos = 0;
            for (int j = i; j<n; j++)
            {
                if (positive[j] > mx)
                {
                    mx = positive[i];
                    pos = j;
                }
            }

            for (int j = 0; j<m; j++)
            {
                (matrix[i, j], matrix[pos, j]) = (matrix[pos, j], matrix[i, j]);
            }

            (positive[i], positive[pos]) = (positive[pos], positive[i]);
        }

        for (int i =0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                Console.Write("{0:d} ", matrix[i, j]);
            }
            Console.WriteLine();
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int k = 0; k < n; k++)
        {
            if (k % 2 == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    int j = i - 1;
                    int now = matrix[k, i];
                    while (j >= 0 && matrix[k, j] < now)
                    {
                        (matrix[k, j + 1]) = matrix[k, j];
                        j -= 1;
                    }
                    matrix[k, j + 1] = now;
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    int j = i - 1;
                    int now = matrix[k, i];
                    while (j >= 0 && matrix[k, j] > now)
                    {
                        (matrix[k, j + 1]) = matrix[k, j];
                        j -= 1;
                    }
                    matrix[k, j + 1] = now;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0:d} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}