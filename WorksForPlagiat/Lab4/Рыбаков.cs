using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Web;
using System.Xml;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
        int[] vector = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        //program.Task_1_2(matrix);
        //program.Task_1_8(matrix);
        //program.Task_1_11(matrix);
        program.Task_1_20(matrix, 5, 7);
        //program.Task_1_23(matrix);
        //program.Task_1_26(matrix, vector);
        //program.Task_2_1(matrix);
        //program.Task_2_2(matrix);
        //program.Task_2_6(3);
        //program.Task_3_2(matrix);
        //program.Task_3_6(matrix);
        //program.Task_3_8(matrix);

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
        int n = A.GetLength(0), m = A.GetLength(1), c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    c++;
                }
            }
        }
        if (answer == 0) return answer;
        answer /= c;
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
        int n = A.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (value == 0)
        {
            rowIndex = 0;
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
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        int c = 0;
        if (n != 4 || m != 6)
        {
            return answer;
        }
        answer = new double[n];
        for (int i = 0; i < n; i++)
        {
            double mid = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    mid += A[i, j];
                    c++;
                }
            }
            if (c == 0)
            {
                continue;
            }
            mid /= c;
            c = 0;
            answer[i] = Math.Round(mid, 2);
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
        int n = A.GetLength(0), m = A.GetLength(1), min_i = 0;
        double min = 100000;
        if (n != 5 || m != 7)
        {
            return default(int[,]);
        }
        int[,] B = new int[(n - 1), m];
        for (int i = 0; i < n; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                min_i = i;
            }
        }
        for (int j = 0; j < n; j++)
        {
            if (j < min_i)
            {
                for (int _ = 0; _ < m; _++)
                {
                    B[j, _] = A[j, _];
                }
            }
            else
            {
                if (j == n - 1)
                {
                    break;
                }
                for (int _ = 0; _ < m; _++)
                {
                    B[j, _] = A[j+1, _];
                }
            }
        }
        A = B;
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
        int[] answer = default(int[]);
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 3)
        {
            return answer;
        }
        answer = new int[m];
        for (int i = 0; i < m; i++)
        {
            int c = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] < 0)
                {
                    c++;
                }
            }
            answer[i] = c;
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
        for (int i = 0; i < n; i++)
        {
            int min = 1000000, min_i = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    min_i = j;
                }
            }
            for (int _ = min_i; _ > 0; _--)
            { 
                int temp = B[i, _ - 1];
                B[i, _ - 1] = B[i, _];
                B[i, _] = temp;
            }
            B[i, 0] = min;
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
        for (int i = 0; i < n; i++)
        {
            double max = -100000, first_neg = 0, last_neg = 0;
            int max_i = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i , j] > max)
                {
                    max = F[i , j];
                    max_i = j;
                }
                if (F[i, j] < 0)
                {
                    if (first_neg == 0)
                    {
                        first_neg = F[i, j];
                    }
                    else
                    {
                        last_neg = F[i, j];
                    }
                }
            }
            if (last_neg != 0 && first_neg != 0)
            {
                F[i, max_i] = Math.Round((first_neg + last_neg) / 2, 2);
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
        int n = G.GetLength(0), m = G.GetLength(1);
        if (n != 5 || m != 7)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n; i++)
        {
            int max = -100000;
            int max_i = 0;
            for (int j = 0; j < m; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    max_i = j;
                }
            }
            for (int _ = m - 1; _ > max_i; _--)
            {
                G[i, _] = G[i, _ - 1];
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7 || B.Length != 7)
        {
            return default(int[,]);
        }
        double max = -100000;
        int max_i = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                max_i = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            A[max_i, j] = B[j];
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
        int n = F.GetLength(0), m = F.GetLength(1);
        if (n != 5 || m != 7)
        {
            return default(int[,]);
        }
        int del_i = 0;
        double min = 1000000;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(F[i, j]) < min)
                {
                    min = Math.Abs(F[i, j]);
                    if (j != 6) del_i = j + 1;
                    else del_i = 0;
                }
            }
        }
        int[,] A = new int[5, 6];
        for (int _ = 0; _ < m - 1; _++)
        {
            if (_ < del_i)
            {
                for (int c = 0; c < n; c++)
                {
                    A[c, _] = F[c, _];
                }
            }
            else
            {
                for (int c = 0; c < n; c++)
                {
                    A[c, _] = F[c, _ + 1];
                }
            }
        }
        F = A;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return default(double[,]);
        }
        for (int i = 0; i < n; i++)
        {
            double max = -100000, mid_pos = 0;
            int max_i = 0, c_pos = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_i = j;
                }
                if (A[i, j] > 0)
                {
                    c_pos++;
                    mid_pos += A[i, j];
                }
            }
            if (c_pos != 0)
            {
                mid_pos /= c_pos;
                A[i, max_i] = mid_pos;
            }
            else A[i, max_i] = 0;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return default(double[,]);
        }
        for (int i = 0; i < n; i++)
        {
            double max = -100000;
            int max_i = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i,j];
                    max_i = j;
                }
            }
            if (max_i == 0)
            {
                A[i,1] *= 2;
            }
            else if (max_i == m - 1)
            {
                A[i,m - 2] *= 2;
            }
            else
            {
                if (A[i, max_i - 1] < A[i, max_i + 1])
                {
                    if (A[i, max_i - 1] < 0)
                    {
                        A[i, max_i - 1] /= 2;
                    }
                    else
                    {
                        A[i, max_i - 1] *= 2;
                    }
                }
                else if (A[i, max_i - 1] > A[i, max_i + 1])
                {
                    if (A[i, max_i + 1] < 0)
                    {
                        A[i, max_i + 1] /= 2;
                    }
                    else
                    {
                        A[i, max_i + 1] *= 2;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            int c_pos = 0, c_not_pos = 0, max = -10000000, max_i = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
                if (A[j, i] > 0)
                {
                    c_pos++;
                }
                else
                {
                    c_not_pos++;
                }
            }
            if (c_pos > c_not_pos)
            {
                A[max_i, i] = 0;
            }
            else
            {
                A[max_i, i] = max_i + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            System.Console.WriteLine();
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
            return default(int[,]);
        }
        for (int i = 0; i < m; i++)
        {
            int s = 0, max = -100000, max_i = -1;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            if (max_i < 5)
            {
                for (int _ = max_i + 1; _ < n; _++)
                {
                    s += A[_, i];
                }
                A[0, i] = s;
            }

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
            return default(int[,]);
        }
        for (int i = 0; i < m; i++)
        {
            int max = -100000, max_i = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            if (max < B[i])
            {
                A[max_i, i] = B[i];
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
            return default(double[,]);
        }
        for (int i = 0; i < m; i++)
        {
            double max = -10000;
            int max_i = -1;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            double s = (A[0, i] + A[n - 1, i]) / 2;
            if (max < s)
            {
                A[max_i, i] = s;
            }
            else
            {
                A[max_i, i] = max_i + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0)
        {
            return answer;
        }
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
            int c = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (c == 3)
                {
                    c = 0;
                }
                answer[i, j] = A[i, c];
                c++;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6)
        {
            return default(int[,]);
        }
        int max = -100000, max_i = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        max_i = i;
                    }
                }
            }
        }
        for (int i = 0; i < max_i; i++)
        {
            for (int j = i + 1; j < m; j++)
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
            return default(int[,]);
        }
        int max1 = -100000, max1_i = 0, max2 = -100000, max2_i = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > max1)
                    {
                        max1 = B[i, j];
                        max1_i = j;
                    }
                }
                if (i % 2 != 0)
                {
                    if (B[i, j] > max2)
                    {
                        max2 = B[i, j];
                        max2_i = j;
                    }
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, max1_i] = max2;
                B[i, max2_i] = max1;
                max1 = -100000;
                max2 = -100000;
                max1_i = 0;
                max2_i = 0;
            }
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
            return default(int[,]);
        }
        for (int i = 0; i < n; i++)
        {
            int temp;
            for (int j = 0; j < m / 2; j++)
            {
                temp = A[i,j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m)
        {
            return default(int[,]);
        }
        for (int i = 0, j = 0; i < n && j < m;)
        {
            if (i == 0)
            {
                matrix[i, j] = 0;
                j++;
            }
            else if (i == n - 1)
            {
                matrix[i, j] = 0;
                j++;
            }
            else
            {
                matrix[i, 0] = 0;
                matrix[i, m - 1] = 0;
                i++;
            }
            if (j == m)
            {
                i++;
                j = 0;
            }
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
            return default(int[,]);
        }
        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j <= i)
                {
                    matrix[i, j] = 1;
                }
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m)
        {
            return (upper, lower);
        }
        int c = 0;
        for (int _ = n; _ > 1; _--)
        {
            c += _;
        }  
        c++;
        upper = new int[c];
        lower = new int[c - n];
        for (int i = 0, c1 = 0, c2 = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j >= i)
                {
                    upper[c1] = matrix[i, j];
                    c1++;
                }
                else
                {
                    lower[c2] = matrix[i, j];
                    c2++;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 && m != 5)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n;i++)
        {
            for (int j = 0; j < m; j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
        }
        
        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0)
            {
                i = j;
                j++;
            }
            else
            {
                int c_pos1 = 0, c_pos2 = 0;
                for (int _ = 0; _ < m; _++)
                {
                    if (matrix[i - 1, _] > 0)
                    {
                        c_pos1++;
                    }
                    if (matrix[i, _] > 0)
                    {
                        c_pos2++;
                    } 
                }
                if (c_pos2 <= c_pos1)
                {
                    i = j;
                    j++;
                }
                else
                {
                    for (int c = 0; c < m; c++)
                    {
                        int temp = matrix[i, c];
                        matrix[i, c] = matrix[i - 1, c];
                        matrix[i - 1, c] = temp;
                    }
                    i--;
                }
            }
        }
        System.Console.WriteLine();
        for (int i = 0; i < n;i++)
        {
            for (int j = 0; j < m; j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
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
        for (int i = 0; i < n; i++)
        {
            int gap = m / 2;
            if (i % 2 == 0)
            {
                while(gap > 0)
                {
                    for (int _ = gap; _ < m; _++)
                    {
                        int key = matrix[i, _], c = _ - gap;
                        while (c >= 0 && matrix[i, c] < key)
                        {
                            matrix[i, c + gap] = matrix[i, c];
                            c -= gap;
                        }
                        matrix[i, c + gap] = key;
                    }
                    gap /= 2;
                }
            }
            if (i % 2 != 0)
            {
                while(gap > 0)
                {
                    for (int _ = gap; _ < m; _++)
                    {
                        int key = matrix[i, _], c = _ - gap;
                        while (c >= 0 && matrix[i, c] > key)
                        {
                            matrix[i, c + gap] = matrix[i, c];
                            c -= gap;
                        }
                        matrix[i, c + gap] = key;
                    }
                    gap /= 2;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    int[,] A = new int[matrix.GetLength(0) - 1,m];
                    for (int _ = 0; _ < matrix.GetLength(0) - 1; _++)
                    {
                        if (_ < i)
                        {
                            for (int c = 0; c < m; c++)
                            {
                                A[_, c] = matrix[_, c];
                            }
                        }
                        else
                        {
                            for (int c = 0; c < m; c++)
                            {
                                A[_, c] = matrix[_ + 1, c];
                            }
                        }
                    }
                    matrix = A;
                }
            }
        }
        // end

        return matrix;
    }
    #endregion
}