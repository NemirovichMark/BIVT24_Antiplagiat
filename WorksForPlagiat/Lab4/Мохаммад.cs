using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Http.Headers;
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
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a == b)
        {
            for (int i = 0; i < 4; i++)
            {
                answer += A[i, i];
            }
        }
        else return 0;
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
        int a = A.GetLength(0), b = A.GetLength(1), mini = 10000000, n = -1;
        answer = new int[a];
        if (a != 4 || b != 7)
        {
            return default(int[]);
        }
        else
        {
            for (int i = 0, j = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    if (A[i, k] < mini)
                    {
                        mini = A[i, k];
                        n = k;
                    }
                }
                answer[j] = n;
                j++;
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
        int a = A.GetLength(0), b = A.GetLength(1), n = 0;
        if (a != 5 || b != 7)
        {
            return null;
        }
        for (int i = 0; i < a; i++)
        {
            int maxi = -10000000, m = 0;
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    n = j;
                }
            }
            m = A[i, n];
            A[i, n] = A[i, 0];
            A[i, 0] = m;
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
        int a = A.GetLength(0), b = A.GetLength(1), maxi = -1000000, my = 0, mx = 0;
        if (a != 6 || b != 7) return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    my = i;
                    mx = j;
                }
            }
        }
        int[,] B = new int[a - 1, b - 1];
        int x = 0, y = 0;
        for (int i = 0; i < a; i++)
        {
            if (my != i)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mx != j)
                    {
                        B[x, y] = A[i, j];
                        y++;
                    }
                }
                y = 0;
                x++;
            }
        }
        // end

        return B;
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
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 5 || b != 7) return null;
        for (int i = 0; i < a; i++)
        {
            int n = 0, maxi = -1000000;
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    n = j;
                }
            }
            A[i, n] = maxi * (i + 1);
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
        int a = D.GetLength(0), b = D.GetLength(1);
        for (int i = 0; i < a; i++)
        {
            int n1 = 0, n2 = -1, maxi = -1000000, imaxi = 0;
            for (int j = 0; j < b; j++)
            {
                if (D[i, j] < 0)
                {
                    n1 = j;
                    if (n2 == -1)
                    {
                        n2 = j;
                    }
                }
            }
            for (int j = 0; j < n2; j++)
            {
                if (D[i, j] > maxi)
                {
                    maxi = D[i, j];
                    imaxi = j;
                }
            }
            if (n2 != 0 && n1 != 0 && maxi != -1000000)
            {
                D[i, imaxi] = D[i, n1];
                D[i, n1] = maxi;
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
        int a = H.GetLength(0), b = H.GetLength(1);
        if (a != 5 || b != 7) return null;
        int[] max = new int[b];
        for (int i = 0; i < a; i++)
        {
            int maxi = -1000000;
            for (int j = 0; j < b; j++)
            {
                if (H[i, j] > maxi)
                {
                    maxi = H[i, j];
                }
            }
            max[i] = maxi;
        }
        int[,] x = new int[a, b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (j == 5)
                {
                    x[i, j] = max[i];
                }
                else if (j == 6)
                {
                    x[i, j] = H[i, j - 1];
                }
                else
                {
                    x[i, j] = H[i, j];
                }
            }
        }
        // end

        return x;
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
        int a = Y.GetLength(0), b = Y.GetLength(1), n = -1;
        double maxi = -100000, sums = 0, c = 0;
        if (a != 6 || b != 5) return null;
        int[] max = new int[b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (Y[i, j] > maxi)
                {
                    maxi = Y[i, j];
                    n = j;
                }
            }
            if (n != b - 1)
            {
                for (int j = n + 1; j < b; j++)
                {
                    if (Y[i, j] > 0)
                    {
                        sums += Y[i, j];
                        c++;
                    }
                    else
                    {
                        sums = c = 0;
                    }
                }
            }
            if (c == 0)
            {
                sums = 0;
            }
            else
            {
                sums /= c;
            }
            for (int j = 0; j < n; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = sums;
                }
            }
            sums = c = 0;
            maxi = -100000;
            n = -1;
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
        int a = B.GetLength(0), b = B.GetLength(1), maxi = -1000000;
        if (a != 5 || b != 7) return null;
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (B[i, j] > maxi)
                {
                    maxi = B[i, j];
                }
            }
            arr[i] = maxi;
            maxi = -1000000;
        }
        for (int i = 0, j = a - 1; i < a; i++, j--)
        {
            B[i, 3] = arr[j];
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
        int a = B.GetLength(0), b = B.GetLength(1);
        if (a != 5 || b != 5) return null;
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            int x = B[0, i];
            B[0, i] = B[3, i];
            B[3, i] = x;
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
        int a = A.GetLength(0), b = A.GetLength(1), x = 0, y = 0;
        if (a != 5 || b != 7) return null;
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < 0)
                {
                    x++;
                }
            }
        }
        answer = new int[x];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[y] = A[i, j];
                    y++;
                }
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1), m = -1, n1 = -1, n2 = -1;
        double maxi = -1000000;
        if (a != 5 || b != 7) return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    m = j;
                }
            }
            if (m == b)
            {
                if (A[i, n1] > 0)
                {
                    A[i, n1] *= 2;
                }
                else
                {
                    A[i, n1] /= 2;
                }
            }
            else if (m == 0)
            {
                if (A[i, n2] > 0)
                {
                    A[i, n2] *= 2;
                }
                else
                {
                    A[i, n2] /= 2;
                }
            }
            else if (A[i, m - 1] > A[i, m + 1])
            {
                if (A[i, m + 1] > 0)
                {
                    A[i, m + 1] *= 2;
                }
                else
                {
                    A[i, m + 1] /= 2;
                }
            }
            else
            {
                if (A[i, m - 1] > 0)
                {
                    A[i, m - 1] *= 2;
                }
                else
                {
                    A[i, m - 1] /= 2;
                }
            }
            maxi = -1000000;
            m = -1;
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 7 || b != 5) return null;
        for (int i = 0; i < b; i++)
        {
            int x = 0, y = 0, maxi = -1000000, m = 0;
            for (int j = 0; j < a; j++)
            {
                if (A[j, i] > maxi)
                {
                    maxi = A[j, i];
                    m = j;
                }
                if (A[j, i] > 0)
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }
            if (x > y)
            {
                A[m, i] = 0;
            }
            else
            {
                A[m, i] = m + 1;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 10 || b != 5) return null;
        for (int i = 0; i < b; i++)
        {
            int x = 0, maxi = -1000000, m = -1;
            for (int j = 0; j < a; j++)
            {
                if (A[j, i] > maxi)
                {
                    maxi = A[j, i];
                    m = j;
                }
            }
            if (m < 5)
            {
                for (int j = m + 1; j < a; j++)
                {
                    x += A[j, i];
                }
                A[0, i] = x;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1), c = B.Length;
        if (a != 7 || b != 5 || c != 5) return null;
        for (int i = 0; i < b; i++)
        {
            int maxi = -1000000, m = -1;
            for (int j = 0; j < a; j++)
            {
                if (A[j, i] > maxi)
                {
                    maxi = A[j, i];
                    m = j;
                }
            }
            if (maxi < B[i])
            {
                A[m, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 7 || b != 5) return null;
        for (int i = 0; i < b; i++)
        {
            int m = -1;
            double maxi = -1000000;
            for (int j = 0; j < a; j++)
            {
                if (A[j, i] > maxi)
                {
                    maxi = A[j, i];
                    m = j;
                }
            }
            double x = (A[0, i] + A[a - 1, i]) / 2;
            if (maxi < x)
            {
                A[m, i] = x;
            }
            else
            {
                A[m, i] = m + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return answer;
        answer = new int[n, 3 * n];
        int[,] A = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    A[i, j] = 1;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int x = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (x == 3)
                {
                    x = 0;
                }
                answer[i, j] = A[i, x];
                x++;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1), maxi = -100000, m = -1;
        if (a != 6 || b != 6) return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (i == j)
                {
                    if (A[i, j] > maxi)
                    {
                        maxi = A[i, j];
                        m = i;
                    }
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < b; j++)
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
        int a = B.GetLength(0), b = B.GetLength(1), maxi = -100000, m = -1, maxi2 = -100000, m2 = -1;
        if (a != 6 || b != 6) return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > maxi)
                    {
                        maxi = B[i, j];
                        m = j;
                    }
                }
                if (i % 2 != 0)
                {
                    if (B[i, j] > maxi2)
                    {
                        maxi2 = B[i, j];
                        m2 = j;
                    }
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, m] = maxi2;
                B[i, m2] = maxi;
                maxi = maxi2 = -100000;
                m = m2 = -1;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 6 || b != 7) return null;
        for (int i = 0; i < a; i++)
        {
            int x;
            for (int j = 0; j < b / 2; j++)
            {
                x = A[i, j];
                A[i, j] = A[i, b - j - 1];
                A[i, b - j - 1] = x;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int[] arr = new int[7];
        int a = matrix.GetLength(0), b = matrix.GetLength(1);
        if (a != 7 || b != 5) return null;
        for (int i = 0; i < a; i++)
        {
            int mini = 100000;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] < mini)
                {
                    mini = matrix[i, j];
                }
            }
            arr[i] = mini;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            int[] x = new int[7];
            for (int j = 0; j < 6; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    for (int z = 0; z < 5; z++)
                    {
                        x[z] = matrix[j, z];
                        matrix[j, z] = matrix[j + 1, z];
                        matrix[j + 1, z] = x[z];
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
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
        // code here
        int a = matrix.GetLength(0), b = matrix.GetLength(1);
        if (matrix == null || a != b) return null;
        int[] result = new int[2 * a - 1];
        for (int i = 0; i < a; i++)
        {
            int mini = 100000;
            for (int j = 0; j < a; j++)
            {
                int x = j - i + (a - 1);
                result[x] += matrix[i, j];
            }
        }
        // end

        return result;
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
        int a = matrix.GetLength(0), b = matrix.GetLength(1), maxi = -1000000, x = 0, y = 0;
        if (k <= 0 || a != b) return null;
        int[] result = new int[2 * a - 1];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (Math.Abs(matrix[i, j]) > maxi)
                {
                    maxi = Math.Abs(matrix[i, j]);
                    x = i;
                    y = j;
                }
            }
        }
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            arr[i] = matrix[x, i];
            matrix[x, i] = matrix[k - 1, i];
            matrix[k - 1, i] = arr[i];
        }
        for (int i = 0; i < a; i++)
        {
            arr[i] = matrix[i, y];
            matrix[i, y] = matrix[i, k - 1];
            matrix[i, k - 1] = arr[i];
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
        // code here
        int[] arr = new int[n * n];
        int[,] ma = new int[n, n];
        int[,] mb = new int[n, n];
        int c = 0;
        bool f = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != 0 || B[i] != 0)
            {
                f = true;
                break;
            }
        }
        if (!f) return null;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                ma[i, j] = A[c];
                mb[i, j] = B[c];
                c++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                ma[i, j] = ma[j, i];
                mb[i, j] = mb[j, i];
            }
        }
        c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sums = 0;
                for (int k = 0; k < n; k++)
                {
                    sums += ma[i, k] * mb[k, j];
                }
                arr[c++] = sums;
            }
        }
        // end

        return arr;
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
        int a = matrix.GetLength(0), b = matrix.GetLength(1);
        if (a != 5 || b != 7) return null;
        int[] arr = new int[7];
        for (int i = 0; i < b; i++)
        {
            int c = 0;
            for (int j = 0; j < a; j++)
            {
                if (matrix[j, i] < 0)
                {
                    c += 1;
                }
            }
            arr[i] = c;
        }
        for (int i = 0; i < 7; i++)
        {
            int[] x = new int[7];
            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    for (int z = 0; z < 5; z++)
                    {
                        x[z] = matrix[z, j];
                        matrix[z, j] = matrix[z, j + 1];
                        matrix[z, j + 1] = x[z];
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
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
        int a = matrix.GetLength(0), b = matrix.GetLength(1), x = 0, y = 0;
        for (int i = 0; i < a; i++)
        {
            bool t = true;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    t = false;
                }
            }
            if (t == true)
            {
                y++;
            }
        }
        int[] matrix1 = new int[a - y];
        int m = 0;
        for (int i = 0; i < a; i++)
        {
            x = -1;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    x = i;
                }
            }
            if (x != -1)
            {
                matrix1[m] = x;
                m++;
            }
        }
        int[,] answer = new int[y, b];
        int a2 = answer.GetLength(0), b2 = answer.GetLength(1);
        m = 0;
        for (int i = 0; i < a; i++)
        {
            bool t = true;
            for (int k = 0; k < matrix1.Length; k++)
            {
                if (i == matrix1[k])
                {
                    t = false;
                }
            }
            if (t == true)
            {
                for (int j = 0; j < b; j++)
                {
                    answer[m, j] = matrix[i, j];
                }
                m++;
            }
        }
        // end

        return answer;
    }
    #endregion
}