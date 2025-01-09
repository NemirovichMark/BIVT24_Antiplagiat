using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Random rand = new Random();
        //program.Task_1_1(new int[,]{
        //{ 1, 2, 3, 4, 5, 6, 7 },
        //{ 5, 6, 7, 8, 9, 10, 11 },
        //{ 9, 10, 11, 12, 13, 14, 15 },
        //{ 13, 14, 15, 16, 17, 18, 19 },
        //{ 0, 1, 2, 3, 4, 5, 6 } });
        //program.Task_1_4(new int[,]{
        //{ 1, 2, 3, 4, 5, 6 },
        //{ 5, 6, 7, 8, 9, 11 },
        //{ 0, 2, 3, 4, 5, 6 } });
        //program.Task_1_7(new int[rand.Next(0, 3), rand.Next(8, 10)]);
        //program.Task_1_10(new int[,]{
        //{ 1, 2, 3, 4, -5, -6, -7 },
        //{ 5, 11, -17, 11, -10, 6, 5 },
        //{ -9, -10, -11, -14, -15, -16, 1 },
        //{ -9, -10, -11, -14, -15, -6, -2 },
        //{ -9, -10, -11, -14, -15, 6, 4 } });
        //program.Task_1_13(new int[,]{
        //{ 1, 2, 3, 4, -5 },
        //{ 5, 11, -17, 11, 7 },
        //{ -9, -10, -11, -14, -15 },
        //{ -9, -10, -11, -14, -6 },
        //{ 0, -2, -3, -4, -5 } });
        //program.Task_1_16(new int[,]{
        //{ 1, 2, -3, 4, -5, 6, 7 },
        //{ 5, 6, -7, 8, 9, -10, -11 },
        //{ 9, 10, 11, -12, 13, 14, 15 },
        //{ -13, 14, 15, 16, 17, -18, -19 },
        //{ 0, -1, -2, -3, -4, -5, -6 } },5,7);
        //program.Task_1_19(new double[,]{
        //{ 1, 2, -3, 4, -5, 6, 7 },
        //{ 5, 6, -7, 8, 9, -10, -11 },
        //{ 9, 10, 11, 12, 13, 14, 15 },
        //{ -13, 14, 15, 16, 17, -18, -19 },
        //{ 0, -1, -2, -3, -4, -5, -6 } }, 5, 7);
        //program.Task_1_25(new int[rand.Next(0, 3), rand.Next(8, 10)]);
        //pogram.Task_1_28(new int[rand.Next(0, 3), rand.Next(8, 10)]);
        //program.Task_1_31(new int[,] {
        //{ 1, 2, -3, 7, -5, 7, 7, 0 },
        //{ 5, 6, -7, 8, 9, 9, -11, 0},
        //{ 9, 10, 11, 12, 13, 15, 15, 0 },
        //{ -13, 14, 25, 25, 16, 17, -19, 0 },
        //{ 0, 0, -1, -2, -3, -4, -6, 0 } }, new int[] { 1, 2, 3, 4, 5 });
        //program.Task_2_1(new double[,] {{ 1, 2, -3, 7, -5, 7, 7 },
        //{ 5, 6, -7, 8, 9, 9, -11 },
        //{ 9, 10, 11, 12, 13, 15, 15 },
        //{ -13, -30, 25, 25, 16, 17, -19 },
        //{ -6, -5, -1, -2, -3, -4, -6 } });
        //program.Task_2_4(new int[,] {{ 1, 2, -3, 7, 7 },
        //{ 5, 6, -7, 9, -11 },
        //{ 9, 10, 11, 15, 15 },
        //{ -13, 14, 25, 25, -19 },
        //{ 5, 6, -7, 8, 9},
        //{ -13, 14, 25, 25, -19 },
        //{ 0, 0, -1, -2, -3 } }, new int[] { 10, 20, 30, 0, -50 });
        //program.Task_2_6(3);
        //program.Task_3_1(new int[,] {
        //{ 9, 10, 11, 15, 15 },
        //{ 1, 2, -3, 7, 7 },
        //{ 0, 0, -1, -2, -3 },
        //{ 5, 6, -7, 8, 9},
        //{ 5, 6, -7, 9, -11 },
        //{ -13, 14, 25, 25, -19 },
        //{ -13, 14, 25, 25, -19 }
        //});
        //program.Task_3_2(new int[,] {
        //{ 1, 2, -3, 7, 7, 0 },
        //{ 5, 6, -7, 9, -11, 1 },
        //{ 9, 10, 11, 15, 15, 2 },
        //{ -13, 14, 25, 25, -19, 3 },
        //{ 5, 6, -7, 8, 9, 4},
        //{ 0, 0, -1, -2, -3, 5 }
        //});
        //program.Task_3_8(new int[,] {
        //{ 1, 2, -3, 7, 7 },
        //{ 5, 6, -7, 9, -11 },
        //{ 9, 10, 11, 15, 15 },
        //{ -13, 14, 25, 25, -19 },
        //{ 5, 6, -7, 8, 9},
        //{ -13, 14, 25, 25, -19 },
        //{ 0, 0, -1, -2, -3 }
        //});
        //program.Task_1_28(new int[,] {
        //{ 1, 2, -3, 7, 7 },
        //{ 5, 6, -7, 9, -11 },
        //{ 9, 10, 11, 15, 15 },
        //{ -13, 14, 25, 25, -19 },
        //{ 5, 6, -7, 8, 9},
        //{ -13, 14, 25, 25, -19 },
        //{ 0, 0, -1, -2, -3 }
        //});
        program.Task_3_10(new int[,] {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            });
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);

        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
                answer += A[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("Сумма элементов матрицы:");
        Console.WriteLine(answer);
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii == 0) || (jj == 0))
        {
            Console.WriteLine("Ошибка!");
            return (row, col);
        }
        int min = 1000;
        int mini = -1;
        int minj = -1;
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");

                if (A[i, j] < min)
                {
                    min = A[i, j];
                    mini = i;
                    minj = j;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Номер строки и столбца, содержащих минимальный элемент:");
        Console.WriteLine(mini + " " + minj);
        row = mini;
        col = minj;
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 3) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return (answer);
        }
        answer = new int[jj];
        for (int i = 0; i < ii; i++) { for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < jj; i++)
            answer[i] = -1000;
        for (int j = 0; j < jj; j++)
        {
            for (int i = 0; i < ii; i++)
            {
                if (answer[j] < A[i, j])
                {
                    answer[j] = A[i, j];
                }
            }
        }
        Console.WriteLine("Максимальные элементы столбцов:");
        for (int i = 0; i < jj; i++)
            Console.Write(answer[i] + " ");
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 5) || (jj != 7))
        {
            Console.WriteLine("Ошибка!");
            return (null);
        }
        int max = -1000;
        int maxi = -1;
        for (int i = 0; i < ii; i++)
        {
            if (max < A[i, 2])
            {
                maxi = i;
                max = A[i, 2];
            }
        }
        Console.WriteLine(max);
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Изменённая матрица:");

        int[] p = new int[jj];
        for (int j = 0; j < jj; j++) { p[j] = A[3, j]; }
        for (int j = 0; j < jj; j++) { A[3, j] = A[maxi, j]; A[maxi, j] = p[j]; }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 5) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return (null);
        }
        int max = -1000;
        int maxj = -1;
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            if (max < A[i, i])
            {
                max = A[i, i];
                maxj = i;
            }
        }
        int[] p = new int[ii];
        for (int i = 0; i < ii; i++)
        {
            p[i] = A[i, 3];
            A[i, 3] = A[i, maxj];
            A[i, maxj] = p[i];
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++)
        {
            int max = -1000;
            int maxj = -1;
            for (int j = 0; j < m; j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxj = j;
                }
            }
            for (int j = maxj + 1; j < m; j++)
            {
                A[i, j - 1] = A[i, j];
            }
            A[i, m - 1] = max;
        }
        Console.WriteLine("Изменённая матрица:");
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++)
        {
            double max = -1000;
            int maxj = -1;
            for (int j = 0; j < m; j++)
            {
                if (max < C[i, j])
                {
                    max = C[i, j];
                    maxj = j;
                }
            }
            for (int j = 0; j < maxj; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] = Math.Round(C[i, j] / max, 2);
                }
            }
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
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
        int ii = Z.GetLength(0);
        int jj = Z.GetLength(1);
        if ((ii != 6) || (jj != 8))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        double max = -1000;
        int maxi = -1;
        int maxj = -1;
        double s = 0;
        double count = 0;
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(Z[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    count++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    maxi = i;
                    maxj = j;
                }
            }
        }
        Z[maxi, maxj] = Math.Round(s / count, 2);
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(Z[i, j] + " ");
            }
            Console.WriteLine();
        }
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
        int ii = X.GetLength(0);
        int jj = X.GetLength(1);
        if ((ii != 6) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        int imax = -1;
        int imin = -1;
        int cmax = -1000;
        int cmin = 1000;
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(X[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            int c = 0;
            for (int j = 0; j < jj; j++)
            {
                if (X[i, j] < 0)
                {
                    c++;
                }
            }
            if (cmax < c)
            {
                cmax = c;
                imax = i;
            }
            if (cmin > c)
            {
                cmin = c;
                imin = i;
            }
        }

        int[] p = new int[jj];
        for (int j = 0; j < jj; j++)
        {

            p[j] = X[imax, j];

            X[imax, j] = X[imin, j];

            X[imin, j] = p[j];
        }
        Console.WriteLine(2);
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(X[i, j] + " ");
            }
            Console.WriteLine();
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 7) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        int[,] p = new int[ii - 1, jj];
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        int max = -10000;
        int maxi = -1;
        for (int i = 0; i < ii; i++)
        {
            int s = 0;
            for (int j = 0; j < jj; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                }
            }
            if (s > max) { max = s; maxi = i; }
        }
        for (int i = 0; i < maxi + 1; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                p[i, j] = A[i, j];
            }
        }
        for (int i = maxi + 1; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                p[i - 1, j] = A[i, j];
            }
        }
        A = p;
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii - 1; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 5) || (jj != 8) || (B.Length != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        int max = -1000;
        int maxj = -1;

        for (int j = 0; j < jj; j++)
        {
            if (max <= A[4, j])
            {
                max = A[4, j];
                maxj = j;
            }
        }

        for (int j = jj - 1; j > maxj; j--)
        {
            for (int i = 0; i < ii; i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < ii; i++) { A[i, maxj] = B[i]; }
        Console.WriteLine("Изменённый массив:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 5)||(jj!=7))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            double max = -1000;
            int maxj = -1;
            for (int j = 0; j < jj; j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxj = j;
                }
            }
            if ((maxj == 0) || (maxj == jj - 1))
            {
                if (maxj == 0) { if (A[i, maxj + 1] > 0) A[i, maxj + 1] *= 2; else A[i, maxj + 1] /= 2.0; }
                if (maxj == jj - 1) { if (A[i, maxj - 1] > 0) A[i, maxj - 1] *= 2; else A[i, maxj - 1] /= 2.0; }
            }
            else
            {
                if (A[i, maxj - 1] < A[i, maxj + 1])
                {
                    if (A[i, maxj - 1] > 0)
                        A[i, maxj - 1] *= 2;
                    else
                        A[i, maxj - 1] /= 2.0;
                }
                else
                {
                    if (A[i, maxj + 1] > 0)
                        A[i, maxj + 1] *= 2;
                    else
                        A[i, maxj + 1] /= 2;
                }
            }
        }
        Console.WriteLine("Изменённый массив:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 7) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < jj; j++)
        {
            int cp = 0;
            int co = 0;
            double max = -1000;
            int maxi = -1;
            for (int i = 0; i < ii; i++)
            {
                if (A[i, j] < 0)
                    co++;
                if (A[i, j] > 0)
                    cp++;
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (cp > co)
                A[maxi, j] = 0;
            else
                A[maxi, j] = maxi + 1;

        }
        Console.WriteLine("Ихменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 10) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < jj; j++)
        {
            int max = -1000;
            int maxi = -1;
            for (int i = 0; i < ii; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (maxi < ii / 2)
            {
                int s = 0;
                for (int i = maxi + 1; i < ii; i++)
                    s += A[i, j];
                A[0, j] = s;
            }
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 7) || (jj != 5) || (B.Length != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < jj; j++)
        {
            int max = -1000;
            int maxi = -1;
            for (int i = 0; i < ii; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (max < B[j])
                A[maxi, j] = B[j];
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 7) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < jj; j++)
        {
            double max = -1000;
            int maxi = -1;
            for (int i = 0; i < ii; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            double ps = ((A[0, j]) + A[ii - 1, j]);
            if (ps > max)
                A[maxi, j] = ps;
            else
                A[maxi, j] = maxi + 1;
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
            Console.WriteLine("Ошибка!");
            return answer;
        }
        answer = new int[n, n * 3];
        int[,] m = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            m[i, i] = 1;
            for (int j = 0; j < n; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[i, j + n * k] = m[i, j];
                }
            }
        }
        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n * 3; j++)
            {
                Console.Write(answer[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 6)||(jj!=6))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        double max = -1000;
        int maxi = -1;
        for (int i = 0; i < ii; i++)
        {
            if (max < A[i, i])
            {
                max = A[i, i];
                maxi = i;
            }
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i <maxi; i++)
        {
            for (int j = i+1; j < jj; j++)
            {
                A[i, j] = 0;
            }
        }
        
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int ii = B.GetLength(0);
        int jj = B.GetLength(1);
        if ((ii != 6)||(jj!=6))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 3; i++)
        {
            int i1 = i * 2; int i2 = i * 2 + 1;
            int max1 = -1000;
            int maxj1 = -1;
            int max2 = -1000;
            int maxj2 = -1;
            for (int j =0; j < jj; j++)
            {
                if (max1 < B[i1, j])
                {
                    max1 = B[i1, j];
                    maxj1 = j;
                }
            }
            for (int j = 0; j < jj; j++)
            {
                if (max2 < B[i2, j])
                {
                    max2 = B[i2, j];
                    maxj2 = j;
                }
            }
            B[i1, maxj1] = max2;
            B[i2, maxj2] = max1;
        }
        Console.WriteLine("Изменённый массив:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int ii = A.GetLength(0);
        int jj = A.GetLength(1);
        if ((ii != 6)||(jj!=7))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[,] B = new int[ii, jj];
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j<jj;j++)
            {
                B[i, j] = A[i, jj - 1 - j];
            }
        }
        A = B;
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if (ii == 0)
        {
            Console.WriteLine("Ошибка!");
            return matrix;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[] minsort = new int[ii];
        for (int i = 0; i<ii; i++)
        {
            minsort[i] = 1000;
            for (int j =0; j <jj; j++)
            {
                if (minsort[i] > matrix[i, j])
                    minsort[i] = matrix[i, j];
            }
        }
        int[] min = new int[ii];
        for (int i = 0; i < ii; i++) { min[i] = minsort[i]; }
        Array.Sort(minsort);
        int[] index = new int[ii];
        for (int i = 0; i <ii;i++)
        {
            index[i] = Array.IndexOf(min, minsort[i]);
            min[index[i]] = -1000;
        }
        int[,] p = new int[ii, jj];
        
        for (int k = 0; k<ii; k++)
        {
            int i = index[index.Length-1-k];
            for (int j = 0; j<jj;j++)
            {
                p[k, j] = matrix[i, j];
            }
        }
        matrix = p;
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if ((ii == 0)||(jj !=ii))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[ii - 1, i] = 0;
            matrix[i, ii - 1] = 0;
        }
        Console.WriteLine("Измеённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
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
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if ((ii == 0)||(ii!=jj))
        {
            Console.WriteLine("Ошибка!");
            return null;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i=  ii/2; i < ii ; i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                matrix[i, j] = 1;
            }
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if ((ii == 0) || (ii!= jj))
        {
            Console.WriteLine("Ошибка!");
            return (upper, lower);
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        upper = new int[(int)(((jj + 1) / 2.0) * ii)];
        lower = new int[(int)(((1 + jj - 1) / 2.0) * (ii - 1))];
        int up = 0;
        int low = 0;
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j <jj; j++)
            {
                if (j >= i)
                {
                    upper[up] = matrix[i, j];
                    up++;
                }
                else
                {
                    lower[low] = matrix[i, j];
                    low++;
                }
            }
        }
        Console.WriteLine("Верхний массив:");
        for (int i = 0; i < upper.Length; i++)
        {
            Console.WriteLine(upper[i] + " ");
        }
        Console.WriteLine("Нижний массив:");
        for (int i = 0; i<lower.Length; i++)
        {
            Console.WriteLine(lower[i]+" ");
        }
        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = new int[1];
        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if ((ii != 7) || (jj != 5))
        {
            Console.WriteLine("Ошибка!");
            return (null);
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] mat = new int[ii, jj + 1];
        for (int i = 0; i < ii; i++)
        {
            int count_p = 0;
            for (int j = 0; j < jj; j++)
            {
                if (matrix[i, j] > 0)
                    count_p++;
                mat[i, j] = matrix[i, j];
            }
            mat[i, jj] = count_p;
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj+1; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 1, j = 2; i < ii;)
        {
            if (i == 0 || mat[i, jj] <= mat[i - 1, jj])
            {
                i = j;
                j++;
            }
            else
            {
                int[] temp = new int[jj+1];
                for (int k = 0; k < jj+1; k++) { temp[k] = mat[i, k]; }
                for (int k = 0; k < jj+1; k++) { mat[i,k] = mat[i-1, k]; }
                for (int k = 0; k < jj+1; k++) { mat[i-1,k] = temp[ k]; }
                i--;
            }
        }
        for (int i = 0; i <ii; i++)
            Console.WriteLine(mat[i,jj]);
        for (int i =0; i < ii; i++)
        {
            for (int j =0; j<jj;j++)
            {
                matrix[i, j] = mat[i, j];
            }
        }
        
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
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
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if (ii == 0)
        {
            Console.WriteLine("Ошибка!");
            return (matrix);
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j <jj; j++)
            {
                for (int k = 0; k < jj - j - 1; k++)
                {
                    if (matrix[i,k] > matrix[i, k + 1])
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, k + 1];
                        matrix[i, k + 1] = temp;
                    }
                }
            }
            if (i %2== 0)
            {
                for (int j =0; j < jj/2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, jj - 1 - j];
                    matrix[i, jj - 1 - j] = temp;
                }
            }
        }
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int ii = matrix.GetLength(0);
        int jj = matrix.GetLength(1);
        if (ii == 0)
        {
            Console.WriteLine("Ошибка!");
            return (matrix);
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[] nul = new int[ii];
        for (int i = 0; i < ii; i++)
        {
            for (int j = 0; j < jj; j++)
            {
                if (matrix[i, j] == 0)
                {
                    nul[i] = 1;
                    break;
                }
            }
        }
        int[,] p = new int[nul.Count(i => i == 0),jj];
        int ip = 0;
        for (int i = 0; i < ii; i++)
        {
            if (nul[i] == 0)
            {
                for (int j = 0; j < jj; j++)
                {
                    p[ip, j] = matrix[i, j];
                }
                ip++;
            }
        }
        matrix = p;
        Console.WriteLine("Изменённая матрица:");
        for (int i = 0; i < nul.Count(i => i == 0); i++)
        {
            for (int j = 0; j < jj; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    #endregion
}