using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] A = {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 25, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            };
        int ind = 5;
        // gnome up
        // colIndex = ind

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, ind] > A[i + 1, ind])
            {
                int temp = A[i + 1, ind];
                A[i, ind] = A[i + 1, ind];
                A[i, ind] = temp;
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.WriteLine(A[i, j]);
            }
        }
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
        double sum = 0;
        int k = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k += 1;
                }
            }
        }
        if (k == 0)
        {
            return 0;
        }
        else
        {
            return (sum / k);
        }
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
        int k = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }

        if (rowIndex == -1)
        {
            return (0, 0);
        }

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
        double[] arr = new double[A.GetLength(0)];



        if ((A.GetLength(0) != 4) || (A.GetLength(1) != 6)) { return null; }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int k = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    k++;
                    sum += A[i, j];
                }
            }
            arr[i] = k > 0 ? sum / k : 0;
        }


        return arr;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; };

        double min = A[0, 0];
        int ind = -1;

        int a = A.GetLength(0);
        int b = A.GetLength(1);

        int[,] arr = new int[a - 1, b];

        for (int i = 0; i < a; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                ind = i;
            }
        }


        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (i < ind)
                {
                    arr[i, j] = A[i, j];
                }
                if (i > ind)
                {
                    arr[i - 1, j] = A[i, j];
                }
            }
        }

        return arr;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) { return null; };

        int[] arr = new int[A.GetLength(1)];


        for (int i = 0; i < A.GetLength(1); i++)
        {
            int k = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    k += 1;
                }
            }
            arr[i] = k;
        }

        return arr;
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;

        int[,] A = new int[n, m];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int min = B[i, 0];
            int ind = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    ind = j;
                }
            }

            A[i, 0] = min;

            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j > ind)
                {
                    A[i, j] = B[i, j];
                }
                if (j < ind)
                {
                    A[i, j + 1] = B[i, j];
                }
            }
        }

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
        int a = F.GetLength(0);
        int b = F.GetLength(1);

        for (int i = 0; i < a; i++)
        {
            double first = 0;
            double last = 0;
            double max = double.MinValue;
            int ind = 0;
            double aver = 0;

            for (int j = 0; j < b; j++)
            {
                if (F[i, j] < 0)
                {
                    first = F[i, j];
                    break;
                }
            }

            for (int j = 0; j < b; j++)
            {
                if (F[i, j] < 0)
                {
                    last = F[i, j];
                }
            }

            for (int j = 0; j < b; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    ind = j;
                }
            }

            if (first != 0 && last != 0)
            {
                F[i, ind] = (first + last) / 2;
            }

        }

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

        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        int a = G.GetLength(0);
        int b = G.GetLength(1);

        for (int i = 0; i < a; i++)
        {
            int max = int.MinValue;
            int ind = 99;

            for (int j = 0; j < b - 1; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    ind = j;
                }
            }

            for (int j = b - 1; j > ind; j--)
            {
                G[i, j] = G[i, j - 1];
            }

            G[i, ind + 1] = max;

        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return null;

        double max = double.MinValue;
        int ind = 99;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                ind = i;
            }
        }

        if (ind == 99) { return A; }
        else
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == ind)
                    {
                        A[ind, j] = B[j];
                    }
                }
            }
            return A;
        }



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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;

        double min = double.MaxValue;
        int ind = 99;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                ind = j;
            }
        }

        if (ind == 99 || ind == F.GetLength(1) - 1) return F;


        int[,] A = new int[F.GetLength(0), F.GetLength(1) - 1];

        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0, k = 0; j < F.GetLength(1); j++)
            {
                if (j == ind + 1) continue;
                A[i, k++] = F[i, j];
            }
        }
        return A;

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

        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) { return null; }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int k = 0;
            double sum = 0;
            int ind = -1;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
            }

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }

            if (k == 0) { A[i, ind] = 0; }
            else { A[i, ind] = sum / k; }
        }



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

        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) { return null; }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int ind = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }

            if (ind == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                if (A[i, 1] < 0) A[i, 1] /= 2;
            }
            if (ind == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0) A[i, A.GetLength(1) - 2] *= 2;
                else if (A[i, A.GetLength(1) - 2] < 0) A[i, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[i, ind - 1] < A[i, ind + 1])
                {
                    if (A[i, ind - 1] > 0) A[i, ind - 1] *= 2;
                    else if (A[i, ind - 1] < 0) A[i, ind - 1] /= 2;
                }
                else
                {

                    if (A[i, ind + 1] > 0) A[i, ind + 1] *= 2;
                    else if (A[i, ind + 1] < 0) A[i, ind + 1] /= 2;
                }
            }

        }

        return A;
    }
    #endregion
    #region Level 2
    public int[,] Task_2_2(int[,] A)
    {
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5)) { return null; }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int pol = 0;
            int otr = 0;
            int max = int.MinValue;
            int ind = -1;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) { pol++; }
                if (A[i, j] < 0) { otr++; }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }

            if (pol > otr) { A[ind, j] = 0; }
            else { A[ind, j] = ind + 1; }
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if ((A.GetLength(0) != 10) || (A.GetLength(1) != 5)) { return null; }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = int.MinValue;
            int ind = 99;
            int sum = 0;

            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    ind = j;
                }
            }

            if (ind < A.GetLength(0) / 2)
            {

                for (int j = ind + 1; j < A.GetLength(0); j++)
                {
                    sum += A[j, i];
                }

                A[0, i] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5) || B.Length != 5) { return null; }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = int.MinValue;
            int ind = 99;
            int sum = 0;

            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    ind = j;
                }
            }

            if (max < B[i])
            {
                A[ind, i] = B[i];
            }
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5)) { return null; }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = double.MinValue;
            int ind = 99;
            double sum = (A[0, i] + A[A.GetLength(0) - 1, i]) / 2;

            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    ind = j;
                }
            }

            if (max < sum)
            {
                A[ind, i] = sum;
            }
            else
            {
                A[ind, i] = ind + 1;
            }


        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {

        if (n <= 0) return null;

        int[,] answer = new int[n, 3 * n];
        int k = 0;


        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (j == i || j == n + i || j == 2 * n + i)
                {
                    answer[i, j] = 1;
                }
                else
                {
                    answer[i, j] = 0;
                }

            }

            k++;
        }

        return answer;
    }





    public int[,] Task_2_7(int[,] A)
    {
        if ((A.GetLength(0) != 6) || (A.GetLength(1) != 6)) { return null; }

        int max = A[0, 0];
        int ind = 0;
        int n = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max && i == j)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
        }




        for (int i = 0; i < ind; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i)
                {
                    A[i, j] = 0;
                }
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {

        if ((B.GetLength(0) != 6) || (B.GetLength(1) != 6)) { return null; }

        int[] arr = new int[B.GetLength(0)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = int.MinValue;
            int ind = 0;

            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    ind = j;
                }
            }
            arr[i] = ind;
        }


        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int temp = B[i, arr[i]];
            B[i, arr[i]] = B[i + 1, arr[i + 1]];
            B[i + 1, arr[i + 1]] = temp;
        }

        return B;

    }
    public int[,] Task_2_9(int[,] A)
    {
        if ((A.GetLength(0) != 6) || (A.GetLength(1) != 7)) { return null; }

        int[,] B = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[i, j] = A[i, A.GetLength(1) - j - 1];
            }
        }

        return B;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) { return null; }

        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {

            matrix[0, i] = 0;
            matrix[n - 1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) { return null; }

        int n = matrix.GetLength(0);

        for (int i = (int)(n / 2); i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                matrix[i, j] = 1;
            }
        }

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m) { return (null, null); }

        int k1 = 0;
        int k2 = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j)
                    k1++;
                else
                    k2++;
            }
        }

        int[] upper = new int[k1];
        int[] lower = new int[k2];
        int upper_index = 0;
        int lower_index = 0;


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j)
                {
                    upper[upper_index] = matrix[i, j];
                    upper_index++;
                }
                else
                {
                    lower[lower_index] = matrix[i, j];
                    lower_index++;
                }
            }
        }

        for (int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] + " ");
        }
        Console.WriteLine();

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (n != 7 || m != 5) { return null; }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                int a = 0;
                int b = 0;

                for (int k = 0; k < m; k++)
                {
                    if (matrix[j, k] > 0) a++;
                    if (matrix[j + 1, k] > 0) b++;
                }

                if (a < b)
                {
                    int[] t = new int[m];
                    for (int k = 0; k < m; k++)
                    {
                        t[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = t[k];
                    }
                }
            }
        }

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for (int k = 0; k < m - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        return matrix;

    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int b = matrix.GetLength(1);

        int nonzero = 0;
        for (int i = 0; i < n; i++)
        {
            int zero = 0;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero++;
                    break;
                }
            }
            if (zero == 0)
            {
                nonzero++;
            }
        }

        int[,] A = new int[nonzero, b];
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            int zero = 0;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero++;
                    break;
                }
            }
            if (zero > 0)
            {
                continue;
            }

            for (int j = 0; j < b; j++)
            {
                A[k, j] = matrix[i, j];
            }
            k++;
        }

        return A;
    }
    #endregion
}
#endregion