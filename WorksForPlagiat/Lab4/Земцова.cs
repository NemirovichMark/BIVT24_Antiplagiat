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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        double sum = 0;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k += 1;
                }
            }
        }
        if (k == 0) return 0;
        answer = sum / k;
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
        int m = A.GetLength(1);
        if (A == null || n != 5 || m != 4)
        {
            return default;
        }
        for (int i = 0; i < n; i++)
        {
            if (A[i, colIndex] <= 0)
            {
                Console.WriteLine(A[i, colIndex]);
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
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
        double[] answer = new double[A.GetLength(0)];

        // code here
        double a = 0, sum = 0;
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (A[i, j] > 0)
                    {
                        a++;
                        sum += A[i, j];
                    }
                }
                if (a != 0)
                    sum = Math.Round(sum / a, 2);
                else
                    sum = 0;
                a = 0;
                answer[i] = sum;
                sum = 0;
            }
        }
        else
            answer = null;
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        int minValue = A[0, 0];
        int rowIndex = 0;
        for (int i = 1; i < rows; i++)
        {
            if (A[i, 0] < minValue)
            {
                minValue = A[i, 0];
                rowIndex = i;
            }
        }
        Console.WriteLine($"Row: {rowIndex}");

        int[,] B = new int[rows - 1, columns];
        int B_rowIndex = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i != rowIndex)
            {
                for (int j = 0; j < columns; j++)
                {
                    B[B_rowIndex, j] = A[i, j];
                }
                B_rowIndex++;
            }
        }
        A = B;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + "");
            }
            Console.WriteLine();
        }
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 3)
            return null;
        answer = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] < 0) k++;
            }
            answer[j] = k;
            Console.WriteLine($"Answer[{j}]: {k}");
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
        int max = int.MaxValue;
        int ind = 0;
        int[,] A = new int[B.GetLength(0), B.GetLength(1)];
        if ((B.GetLength(0) == n) && (B.GetLength(1) == m))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (B[i, j] < max)
                    {
                        max = B[i, j];
                        ind = j;
                    }
                }
                A[i, 0] = B[i, ind];
                for (int j = 0; j < ind; j++)
                {
                    A[i, j + 1] = B[i, j];
                }
                for (int j =  ind + 1; j < m; j++)
                {
                    A[i, j] = B[i, j];
                }
                ind = 0;
                max = int.MaxValue;
            }
        }
        else
            A = null;
        // end

        return A;
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
        if (F == null || F.GetLength(0) != n || F.GetLength(1) != m)
            return null;
        for (int i = 0; i < n; i++)
        {
            double fmax = -999;
            int imax = 0, first_neg_index = -1, last_neg_index = -1;
            double polsum;
            for (int j = 0; j < m; j++)
            {
                if (F[i,j] > fmax)
                {
                    fmax = F[i, j];
                    imax = j;
                }
                if (first_neg_index == -1 && F[i,j] < 0)
                {
                    first_neg_index = j;
                }
            }
            Console.WriteLine($"Max f: {fmax}");
            Console.WriteLine($"First neg index: {first_neg_index}");
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i,j] < 0)
                {
                    last_neg_index = j;
                    break;
                }
            }
            Console.WriteLine($"Last neg index: {last_neg_index}");
            if (first_neg_index != -1 && last_neg_index != -1)
            {
                polsum = (F[i, first_neg_index] + F[i, last_neg_index]) / 2;
                Console.WriteLine($"Polsum: {polsum}");
                F[i, imax] = polsum;
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
        int rows = G.GetLength(0);
        int columns = G.GetLength(1);
        if (G == null || G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return null;
        for (int i = 0; i < rows; i++)
        {
            int gmax = -999;
            int imax = -1;
            for(int j = 0; j < columns; j++)
            {
                if (G[i,j] > gmax)
                {
                    gmax = G[i, j];
                    imax = j;
                }
            }
            for (int j = columns - 1; j > imax; j--)
            {
                G[i, j] = G[i, j - 1];
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
            return null;
        for (int i = 0; i < rows; i++)
        {
            int amax = -999;
            int imax = -1;
            for (int j = 0; j < columns; j++)
            {
                if (A[i, j] >= amax)
                {
                    amax = A[i, j];
                    imax = j;
                }
            }
            Console.WriteLine($"Max index: {imax}");
            if (imax == 3)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"B[{j}]: {B[j]}");
                    A[i, j] = B[j];
                }
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine(A[i, j] + " ");
            }
            Console.WriteLine();
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
        int fmin = 999;
        int imin = -1;
        int n = F.GetLength(0);
        int m = F.GetLength(1);
        int[,] newF = new int[n, m - 1];
        if (F == null || F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return null;
        for (int j = 0; j < m; j++)
        {

            if (Math.Abs(F[2, j]) < fmin)
            {
                fmin = F[2, j];
                imin = j;
            }
        }
        imin += 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < imin; j++)
            {
                newF[i, j] = F[i, j];
            }
            for (int j = imin + 1; j < m; j++)
            {
                newF[i, j - 1] = F[i, j];
            }
        }
        F = newF;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                Console.WriteLine(F[i, j] + " ");
            }
            Console.WriteLine();
        }
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int[,] newF = new int[n, m - 1];
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < n; i++)
        {
            double amax = double.MinValue;
            int imax = -1, k = 0;
            double avg = 0, sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j] > amax)
                {
                    amax = A[i, j];
                    imax = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k += 1;
                }
            }
            Console.WriteLine($"{i} stroka; max element: {amax}, index: {imax}, sum: {sum}, k: {k}");
            if (imax != -1 && k != 0)
            {
                avg = sum / k;
                A[i, imax] = avg;
            }
            else if (k == 0)
            {
                A[i, imax] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < n; i++)
        {
            double amax = A[i, 0];
            int imax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = j;
                }
            }
            Console.WriteLine(amax);
            if (imax == 0)
            {
                if (A[i, 0] > 0) A[i, 0] *= 2;
                else A[i, 0] /= 2;
            }
            else if (imax == m - 1)
            {
                if (A[i, m - 1] > 0) A[i, m - 1] *= 2;
                else A[i, m - 1] /= 2;
            }
            else
            {
                if (A[i, imax - 1] < A[i, imax + 1])
                {
                    if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                    else A[i, imax - 1] /= 2;
                }
                else
                {
                    if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int k_pos = 0, k_neg = 0, amax = -100000000, imax = 0;
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int i = 0; i < m; i++)
        {
            k_pos = 0;
            k_neg = 0;
            amax = -100000000;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > 0)
                {
                    k_pos++;
                }
                else if (A[j, i] < 0)
                {
                    k_neg++;
                }
                if (A[j, i] > amax)
                {
                    amax = A[j, i];
                    imax = j;
                }
            }
            if (k_pos > k_neg)
            {
                A[imax, i] = 0;
            }
            else
            {
                A[imax, i] = imax + 1;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < 5; j++)
        {
            int amax = 0, imax = -1, sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += A[i, j];
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                    sum = 0;
                }
            }
                if (imax <= 4)
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int[,] C = default(int[,]);
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        bool bol1 = false;
        for (int j = 0; j < B.Length; j++)
        {
            if (B[j] != 0)
            {
                bol1 = true;
                break;
            }
        }
        if (bol1 == false)
            return C;
        for (int j = 0; j < m; j++)
        {
            int amax = A[0, j], imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
            }
            if (amax < B[j])
                A[imax, j] = B[j];
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < m; j++)
        {
            double amax = A[0, j], polsum = 0;
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
            }
            polsum = (A[0, j] + A[n - 1, j]) / 2;
            if (amax < polsum)
                A[imax, j] = polsum;
            else
                A[imax, j] = imax + 1;
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, 3 * n];
        int a = answer.GetLength(0);
        int b = answer.GetLength(1);
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                answer[i, j] = 0;
            }
        }
        int k = -1;
        for (int i = 0; i < a; i++)
        {
            k++;
            for (int j = k; j < b;)
            {
                answer[i, j] = 1;
                j += 3;
            }
        }
       
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int[,] answer = default(int[,]);
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int amax = -99999999, imax = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > amax)
            {
                amax = A[i, i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i + 1; j < m; j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        int amax_1 = -99999999, imax_1 = 0, amax_2 = -99999999, imax_2 = 0;
        int[,] answer = default(int[,]);
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        for (int i = 0; i < n; i += 2)
        {
            amax_1 = -99999999;
            amax_2 = -99999999;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > amax_1)
                {
                    amax_1 = B[i, j];
                    imax_1 = j;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (B[i + 1, j] > amax_2)
                {
                    amax_2 = B[i + 1, j];
                    imax_2 = j;
                }
            }
            B[i, imax_1] = amax_2;
            B[i + 1, imax_2] = amax_1;
        }
        
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                int p = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = p;

            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int[,] A = new int[7, 5];
        int[] B = new int[7];
        int min = 1000000, max = -1000000, index = 0;
        if ((matrix.GetLength(0) == 7) && (matrix.GetLength(1) == 5))
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        index = j;
                    }
                }
                B[i] = matrix[i, index];
                index = 0;
                min = 1000000;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (B[j] > max)
                    {
                        max = B[j];
                        index = j;
                    }
                }
                B[index] = -1000000;
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = matrix[index, j];
                }
                max = -1000000;
                index = 0;
            }
        }
        else
            A = null;

        // end

        return A;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m)
            return answer;
        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j - i + (n - 1);
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m || k < 1 || k > n)
            return null;
        int amax = -100000, imax = 0, jmax = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (amax < Math.Abs(matrix[i, j]))
                {
                    amax = Math.Abs(matrix[i, j]);
                    imax = i;
                    jmax = j;
                }
            }
        }
        if (jmax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, jmax];
                matrix[i, jmax] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;

            }
        }
        if (imax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[imax, i];
                matrix[imax, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;

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
        answer = new int[n * n];
        int[,] mA = new int[n, n];
        int[,] mB = new int[n, n];
        int k = 0, b = 0;
        if (n <= 0 || A.Length / 2 != n || B.Length / 2 != n)
            return null;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                mA[i, j] = A[k];
                mB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mA[j, i] = mA[i, j];
                mB[j, i] = mB[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                int c = 0;
                for (int g = 0; g < n; g++)
                { 
                    c += (mA[i, g] * mB[g, j]);
                }
                answer[b++] = c;
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
        int[] array = new int[7];
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k = 0, b = 0;
        if (n != 5 && m != 7)
            return null;
        for (int j = 0; j < 7; j++)
        {
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                    c++;
            }
            array[j] = c;
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (array[i] > array[i + 1])
                {
                    b = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = b;

                    for (int g = 0; g < 5; g++)
                    {
                        b = matrix[g, i];
                        matrix[g, i] = matrix[g, i + 1];
                        matrix[g, i + 1] = b;

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int c = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    c--;
                    matrix[i, 0] = 0;
                    break;
                }
            }
        }
        int[,] A = new int[c, m];
        int g = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, 0] != 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[g, j] = matrix[i, j];
                }
                g++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}