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
        int[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
        program.Task_1_18(matrix, matrix.GetLength(0), matrix.GetLength(1));

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
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                answer += A[i, j];
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4)
        {
            return 0;
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j) { answer += A[i, j]; }

            }

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
        int[] answer = new int[4];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 4; i++)
        {
            int min_i = int.MaxValue;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < min_i) { min_i = A[i, j]; answer[i] = j; }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue, ij = 0, a = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max_i) { max_i = A[i, j]; ij = j; }
            }
            a = A[i, 0];
            A[i, 0] = max_i;
            A[i, ij] = a;
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
        int[,] b = new int[5, 6];
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int max_i = int.MinValue, i_1 = 0, j_1 = 0;
        for (int i = 0; i < 6; i++)
        {

            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max_i) { max_i = A[i, j]; j_1 = j; i_1 = i; }

            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < i_1 && j < j_1) { b[i, j] = A[i, j]; }
                else if (i >= i_1 && j < j_1) { b[i, j] = A[i + 1, j]; }
                else if (i < i_1 && j >= j_1) { b[i, j] = A[i, j + 1]; }
                else { b[i, j] = A[i + 1, j + 1]; }
            }
        }
        A = b;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue, i_1 = 0, j_1 = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max_i) { max_i = A[i, j]; j_1 = j; i_1 = i; }

            }
            A[i, j_1] *= (i + 1);
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
        if (D.GetLength(0) != n || D.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int max_i = int.MinValue, j_2 = 0, j_1 = 0, n1 = 0;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0 && j == 0) { break; }
                if (D[i, j] > max_i && n1 == 0) { max_i = D[i, j]; j_1 = j; }
                if (D[i, j] < 0) { n1++; j_2 = j; }
            }
            if (n1 == 0) { continue; }
            n1 = D[i, j_2];
            D[i, j_2] = D[i, j_1];
            D[i, j_1] = n1;
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > max_i) { max_i = H[i, j]; }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max_i;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < 6; i++)
        {
            double max_i = double.MinValue, sum = 0, z = 0, n = 0;
            int j_m = -1;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > max_i) { max_i = Y[i, j]; j_m = j; }
            }
            for (int j = j_m + 1; j < 5; j++)
            {
                if (Y[i, j] > 0) { sum += Y[i, j]; n++; }
            }
            if (n != 0) { z = sum / n; }
            for (int j = 0; j < j_m; j++)
            {
                if (Y[i, j] < 0) { Y[i, j] = z; }
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return null;
        }
        int[] A = new int[B.GetLength(0)];
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > max_i) { max_i = B[i, j]; }
            }
            A[i] = max_i;
        }
        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = A[4 - i];
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return null;
        }
        int i_1 = -1, i_2 = -1, max_i = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > max_i) { max_i = B[i, i]; i_1 = i; }
        }
        for (int i = 0; i < 5; i++)
        {
            int n = 0;
            for (int j = 0; j < 3; j++)
            {
                if (B[i, j] < 0)
                {
                    n++;
                    if (j == 2 && n == 1) { i_2 = i; }
                }
            }
            if (i_2 != -1) { break; }
        }
        for (int j = 0; j < 5; j++)
        {
            int p = B[i_1, j];
            B[i_1, j] = B[i_2, j];
            B[i_2, j] = p;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int n = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) { n++; }
            }
        }
        answer = new int[n];
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) { answer[k] = A[i, j]; k++; }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            double max_i = int.MinValue;
            int ij = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max_i) { max_i = A[i, j]; ij = j; }
            }
            if (ij == 0)
            {
                if (A[i, 1] < 0) { A[i, 1] /= 2; }
                else { A[i, 1] *= 2; }
            }
            else if (ij == 6)
            {
                if (A[i, 5] < 0) { A[i, 5] /= 2; }
                else { A[i, 5] *= 2; }
            }
            else
            {
                if (A[i, ij - 1] > A[i, ij + 1])
                {
                    if (A[i, ij + 1] < 0) { A[i, ij + 1] /= 2; }
                    else { A[i, ij + 1] *= 2; }
                }
                else
                {
                    if (A[i, ij - 1] < 0) { A[i, ij - 1] /= 2; }
                    else { A[i, ij - 1] *= 2; }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue;
            int ij = 0, n = 0, m = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > 0) { n++; }
                else if (A[j, i] < 0) { m++; }
                if (A[j, i] > max_i) { max_i = A[j, i]; ij = j; }

            }
            if (n > m) { A[ij, i] = 0; }
            else { A[ij, i] = ij; }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue;
            int ij = 0, sum = 0;
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > max_i) { max_i = A[j, i]; ij = j; }

            }
            if (ij < 5)
            {
                for (int j = ij + 1; j < 10; j++)
                {
                    sum += A[j, i];
                }
                A[0, i] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int max_i = int.MinValue;
            int ij = 0, sum = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max_i) { max_i = A[j, i]; ij = j; }

            }
            if (max_i < B[i])
            {
                A[ij, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            double max_i = double.MinValue, sum = (A[0, i] + A[6, i]) / 2;
            int ij = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max_i) { max_i = A[j, i]; ij = j; }

            }
            if (max_i < sum) { A[ij, i] = sum; }
            else { A[ij, i] = ij; }
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
            return null;
        }
        answer = new int[n, 3 * n];
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j, j + i] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int ij = 0;
        int max_i = int.MinValue;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max_i) { max_i = A[i, i]; ij = i; }
        }
        for (int i = 0; i < ij; i++)
        {
            for (int j = i + 1; j < 6; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        for (int k = 0; k < 6; k += 2)
        {
            int max_i_1 = int.MinValue, max_i_2 = int.MinValue;
            int ij_1 = 0, ij_2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[k, j] > max_i_1) { max_i_1 = B[k, j]; ij_1 = j; }
                if (B[k + 1, j] > max_i_2) { max_i_2 = B[k + 1, j]; ij_2 = j; }
            }
            B[k, ij_1] = max_i_2;
            B[k + 1, ij_2] = max_i_1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 6; i++)
        {
            int p;
            for (int j = 0; j < 7 / 2; j++)
            {
                p = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = p;
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
        int a = matrix.GetLength(0);
        if (a <= 0 || a != matrix.GetLength(1)) { return null; }
        for (int i = 0; i < a; i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[a - 1, i] = 0;
            matrix[i, a - 1] = 0;

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
        int a = matrix.GetLength(0);
        if (a <= 0 || a != matrix.GetLength(1)) { return null; }
        for (int i = a / 2; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j > i) { break; }
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here


        int a = matrix.GetLength(0);
        int n = 0, m = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j >= i) { n++; }
                else { m++; }
            }
        }
        upper = new int[n];
        lower = new int[m];
        int n1 = 0, m1 = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j >= i) { upper[n1] = matrix[i, j]; n1++; }
                else { lower[m1] = matrix[i, j]; m1++; }
            }
        }
        if (a <= 0 || a != matrix.GetLength(1)) { return (null, null); }

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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5) { return null; }
        int[] arr = new int[7];
        for (int i = 0; i < 7; i++)
        {
            int n1 = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < 0) { n1++; }
            }
            arr[i] = n1;
        }
        int n = 7, gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int key = arr[i], j = i - gap;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + gap] = arr[j];
                    j -= gap;
                }
                arr[j + gap] = key;
            }
            gap /= 2;
        }
        int[,] answer = new int[7, 5];
        for (int k = 0; k < 7; k++)
        {
            for (int i = 0; i < 7; i++)
            {
                int n1 = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < 0) { n1++; }
                }
                if (n1 == arr[k])
                {
                    for (int j = 0; j < 5; j++)
                    {
                        answer[k, j] = matrix[i, j];
                        matrix[i, j] = 0;
                    }
                    break;
                }
            }
        }
        matrix = answer;

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
        int n1 = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i1 = 0; i1 < n1; i1++)
        {
            int[] arr = new int[m];
            for (int j = 0; j < m; j++)
            {
                arr[j] = matrix[i1, j];
            }
            int n = m, gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int key = arr[i], j = i - gap;
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    arr[j + gap] = key;
                }
                gap /= 2;
                if (i1 % 2 == 0)
                {

                    for (int j = 0; j < m / 2; j++)
                    {
                        int p = arr[j];
                        arr[j] = arr[m - 1 - j];
                        arr[m - 1 - j] = p;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    matrix[i1, j] = arr[j];
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1), answer = n, j = 0;
        for (int i = 0; i < n; i++)
        {
            int p = 0;
            for (int k = 0; k < m; k++)
            {
                if (matrix[i, k] == 0) { p++; }
            }
            if (p > 0) { answer--; }
        }
        int[,] arr = new int[answer, m];
        for (int i = 0; i < n; i++)
        {
            int p = 0;
            for (int k = 0; k < m; k++)
            {
                if (matrix[i, k] == 0) { p++; }
            }
            if (p <= 0)
            {
                for (int k = 0; k < m; k++)
                {
                    arr[j, k] = matrix[i, k];
                }
                j++;
            }
        }
        matrix = arr;
        // end

        return matrix;
    }
    #endregion
}