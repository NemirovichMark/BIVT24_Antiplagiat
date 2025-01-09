using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
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
        int s = A.GetLength(0);
        for (int i = 0; i < s; i++)
        {
            answer += A[i, i];
        }
        Console.WriteLine(answer);
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
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        int min = 1000, imin = 0;
        answer = new int[stroka]; 
        if (stroka != 4 || stolb != 7) return null;
        else
            for (int i = 0, k = 0; i < stroka; i++)
            {
                for (int h = 0; h < stolb; h++)
                    if (A[i, h] < min) { min = A[i, h]; imin = h; }
                answer[k] = imin;
                k++;
            }
        foreach (int x in answer) Console.WriteLine(x);
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
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 5 || stolb != 7) return null;
        else
        {
            for (int i = 0; i < stroka; i++)
            {
                int max = -1000, imax = 0;
                for (int k = 0; k < stolb; k++)
                {
                    if (A[i, k] > max)
                    {
                        max = A[i, k];
                        imax = k;
                    }
                }
                int s = A[i, 0];
                A[i, imax] = s;
                A[i, 0] = max;
            }
        }
        foreach (int x in A) Console.WriteLine(x);
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
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        int max = -1000, ind1 = -1, ind2 = -1;
        if (stroka != 6 || stolb != 7) return null;
        for (int i = 0; i < stroka; i++)
            for (int k = 0; k < stolb; k++)
                if (A[i, k] > max) { max = A[i, k]; ind1 = i; ind2 = k; }

        int[,] B = new int[stroka - 1, stolb - 1];

        for (int i = 0, s1 = 0; i < stroka; i++)
        {
            for (int k = 0, s2 = 0; k < stolb; k++)
                if (k != ind2) { B[s1, s2] = A[i, k]; s2++; }
            if (i != ind1) s1++;
        }

        A = new int[stroka - 1, stolb - 1];
        A = B;

        for (int i = 0; i < stroka - 1; i++)
        {
            for (int k = 0; k < stolb - 1; k++) Console.Write(B[i, k] + " ");
        }
        foreach (int i in A) Console.WriteLine(i);
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
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 5 || stolb != 7) return null;
        int imax;
        for (int i = 0; i < stroka; i++)
        {
            imax = 0;
            for (int k = 1; k < stolb; k++)
                if (A[i, k] > A[i, imax]) imax = k;
            A[i, imax] *= i + 1;
        }
        foreach (int i in A) Console.WriteLine(i);
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
        for (int i = 0; i < n; i++)
        {
            int ind1 = 0, ind2 = 0, max = D[i, 0], imax = 0, s = D[i, imax];
            for (int k = 0; k < m; k++)
            {
                if (D[i, k] < 0) { ind1 = k; break; }
            }

            for (int h = 0; h < ind1; h++)
            {
                if (D[i, h] > max) { max = D[i, h]; imax = h; }
            }
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0) ind2 = j;

            }
            if (ind1 != 0) { s = D[i, imax]; D[i, imax] = D[i, ind2]; D[i, ind2] = s; }
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
        int stroka = H.GetLength(0), stolb = H.GetLength(1);
        if (stroka != 5 || stolb != 7) return null;
        else
        {
            for (int i = 0; i < stroka; i++)
            {
                int max = -1000;
                for (int k = 0; k < stolb - 1; k++)
                {
                    if (H[i, k] > max) max = H[i, k];
                }
                H[i, stolb - 1] = H[i, stolb - 2];
                H[i, stolb - 2] = max;
            }
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
        int stroka = Y.GetLength(0), stolb = Y.GetLength(1);
        if (stroka != 6 || stolb != 5) return null;
        else
        {
            for (int i = 0; i < stroka; i++)
            {
                double max = -1000, s = 0;
                int a = 0, count = 0;
                for (int k = 0; k < stolb; k++)
                {
                    if (Y[i, k] > max) { max = Y[i, k]; a = k; }
                }
                for (int h = a + 1; h < stolb; h++)
                {
                    if (Y[i, h] > 0) { s += Y[i, h]; count++; }
                }
                s /= count;
                if (count == 0) s = 0;
                for (int j = 0; j < a; j++)
                {
                    if (Y[i, j] < 0) Y[i, j] = s;
                }
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
        int[] array = new int[5];
        int stroka = B.GetLength(0), stolb = B.GetLength(1);
        if (stroka != 5 || stolb != 7) return null;
        else
        {
            for (int i = 0; i < stroka; i++)
            {
                int max = -1000;
                for (int k = 0; k < stolb; k++)
                {
                    if (B[i, k] > max) max = B[i, k];
                }
                array[i] = max;
            }
            int s = 4;
            for (int h = 0; h < stroka; h++) { B[h, 3] = array[s]; s--; }
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
        int stroka = B.GetLength(0), stolb = B.GetLength(1);
        if (stroka != 5 || stolb != 5) return null;
        else
        {
            int max = -1000, s = 0;
            for (int i = 0; i < stroka; i++)
            {
                if (B[i, i] > max) { max = B[i, i]; s = i; }
            }
            int a = 0;
            for (int i = 0; i < stroka; i++)
            {
                int count = 0;
                for (int k = 0; k < stolb; k++)
                {
                    if (B[i, k] < 0 && k == 2 && count == 0) a = i;
                    count++;
                }
            }
            for (int h = 0; h < stolb; h++)
            {
                int term = B[s, h];
                B[s, h] = B[a, h];
                B[a, h] = term;
            }
            Console.WriteLine(a);
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
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 5 || stolb != 7) return null;
        else
        {
            int s1 = 0;
            for (int i = 0; i < stroka; i++)
            {
                for (int k = 0; k < stolb; k++)
                {
                    if (A[i, k] < 0) s1++;
                }
            }
            answer = new int[s1];
            int s2 = 0;
            for (int i = 0; i < stroka; i++)
            {
                for (int h = 0; h < stolb; h++)
                {
                    if (A[i, h] < 0) { answer[s2] = A[i, h]; s2++; }
                }
            }
        }
        foreach (int i in answer) Console.WriteLine(i);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        double max = -1000;
        int imax = 0;
        if (stroka != 5 || stolb != 7) return null;
        for (int i = 0; i < stroka; i++)
        {
            for (int k = 0; k < stolb; k++)
            {
                if (A[i,k] > max)
                {
                    max = A[i, k];
                    imax = k;
                }
            }
            Console.WriteLine(max);
            if (imax == 0)
            {
                if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2;
                else A[i, imax + 1] /= 2;
            }
            else if (imax == stolb - 1)
            {
                if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                else A[i, imax - 1] /= 2;
            }
            else
            {
                if (A[i, imax - 1] > A[i, imax + 1])
                {
                    if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2;
                    else A[i, imax + 1] /= 2;
                }
                else
                {
                    if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                    else A[i, imax - 1] /= 2;
                }
            }
        }
        foreach (int i in A) Console.WriteLine(i);
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 7 || stolb != 5) return null;
        for (int i = 0; i < stolb; i++)
        {
            int imax = 0, max = -1000, count = 0;
            for (int k = 0; k < stroka; k++)
            {
                if (A[k, i] > 0) count++;
                if (A[k, i] > max)
                {
                    max = A[k, i];
                    imax = k;
                }
            }
            if (count >= 4) A[imax, i] = 0;
            else A[imax, i] = imax + 1;
        }
        foreach (int i in A) Console.WriteLine(i);
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 10 || stolb != 5) return null;
        for (int i = 0; i < stolb; i++)
        {
            int max = -1000, sum = 0, imax = 0;
            for (int k = 0; k < stroka; k++)
            {
                if (A[k, i] > max)
                {
                    max = A[k, i];
                    imax = k;
                }
            }
            if (imax > 5) break; 
            for (int j = imax + 1; j < stroka; j++) sum += A[j, i];
            A[0, i] = sum;
        }
        foreach (int i in A) Console.WriteLine(i);
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 7 || stolb != 5 || B.Length != 5) return null;
        for (int i = 0; i < stolb; i++)
        {
            int imax = 0, max = -1000;
            for (int k = 0; k < stroka; k++)
            {
                if (A[k, i] > max)
                {
                    max = A[k, i];
                    imax = k;
                }
            }
            if (A[imax, i] < B[i]) A[imax, i] = B[i];
        }
        foreach (int i in A) Console.WriteLine(i);
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 7 || stolb != 5) return null;
        for (int i = 0; i < stolb; i++)
        {
            double max = -1000;
            int imax = 0;
            for (int k = 0; k < stroka; k++)
            {
                if (A[k, i] > max)
                {
                    max = A[k, i];
                    imax = k;
                }
            }
            double s = (A[0, i] + A[stroka - 1, i]) / 2;
            if (A[imax, i] < s) A[imax, i] = s;
            else A[imax, i] = imax + 1;
        }
        foreach (int i in A) Console.WriteLine(i);
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < 3 * n; k++) answer[i, k] = 0;
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = count; k < 3 * n; k += 3) answer[i, k] = 1;
            count++;
        }
        foreach (int i in answer) Console.WriteLine(i);
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 6 || stolb != 6) return null;
        int max = -1000, imax = 0;
        for (int i = 0; i < stroka; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                imax = i;
            }
        }
        int count = 1;
        for (int i = 0; i < imax; i++)
        {
            for (int k = count; k < stolb; k++) A[i, k] = 0;
            count++;
        }
        foreach (int i in A) Console.WriteLine(i);
            // end

            return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int stroka = B.GetLength(0), stolb = B.GetLength(1);
        if (stroka != 6 && stolb != 6) return null;


        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = -999, imax1 = 0;
            int max2 = -999, imax2 = 0;
            for (int k = 0; k < stolb; k++)
            {
                if (B[i, k] > max1)
                {
                    max1 = B[i, k];
                    imax1 = k;
                }
            }
            for (int k = 0; k < stolb; k++)
            {
                if (B[i + 1, k] > max2)
                {
                    max2 = B[i + 1, k];
                    imax2 = k;
                }
            }
            int s = B[i, imax1];
            B[i, imax1] = B[i + 1, imax2];
            B[i + 1, imax2] = s;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int stroka = A.GetLength(0), stolb = A.GetLength(1);
        if (stroka != 6 || stolb != 7) return default;
        for (int i = 0; i < stroka; i++)
        {
            for (int k = 0; k < stolb / 2; k++)
            {
                int s = A[i, stolb - k - 1];
                A[i, stolb - k - 1] = A[i, k];
                A[i, k] = s;
            }
        }
        foreach (int i in A) Console.WriteLine(i);
            // end

            return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int[,] sort = new int[A.GetLength(0), 2];
        int[,] ans = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min) min = A[i, j];
            }
            sort[i, 0] = min;
            sort[i, 1] = i;
        }
        for (int i = 0; i < sort.GetLength(0); i++)
            Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i, 1]);
        while (true)
        {
            int flag = 0;
            for (int i = 1; i < sort.GetLength(0); i++)
                if (sort[i, 0] > sort[i - 1, 0])
                {
                    int p0 = sort[i - 1, 0];
                    int p1 = sort[i - 1, 1];
                    sort[i - 1, 0] = sort[i, 0];
                    sort[i - 1, 1] = sort[i, 1];
                    sort[i, 0] = p0;
                    sort[i, 1] = p1;
                }
                else flag += 1;
            if (flag == sort.GetLength(0) - 1) break;
        }
        Console.WriteLine();
        for (int i = 0; i < sort.GetLength(0); i++)
            Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i, 1]);
        for (int i = 0; i < ans.GetLength(0); i++)
            for (int j = 0; j < ans.GetLength(1); j++) ans[i, j] = A[sort[i, 1], j];
        // end

        return ans;
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
        int stroki = matrix.GetLength(0);
        int stolbi = stroki;
        // code here
        bool cont = false;
        for (int q = 0; q < stroki; q++)
        {
            for (int m = 0; m < stolbi; m++)
            {
                if (matrix[q, m] != 0) { cont = true; break; }
            }
            if (cont) break;
        }
        if (cont == false) return null;
        answer = new int[2 * stolbi - 1];
        int half = (int)answer.Length / 2;
        for (int i = 0; i < stolbi; i++)
        {
            int sum_l = 0;
            int sum_r = 0;
            for (int j = 0; j < stroki; j++)
            {
                if (i - j >= 0) sum_l = sum_l + matrix[stroki - 1 - j, i - j];
                if (i + j < stroki) sum_r = sum_r + matrix[j, i + j];
            }
            answer[i] = sum_l;
            answer[i + half] = sum_r;
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
        int n1 = 0, n2 = 0, max = -1000;
        int[] A = new int[matrix.GetLength(0)];
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || k <= 0) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    n1 = i;
                    n2 = j;

                }
            }
        }
        for (int j = 0; j < matrix.GetLength(0); j++) A[j] = matrix[n1, j];
        for (int j = 0; j < matrix.GetLength(0); j++) matrix[n1, j] = matrix[k - 1, j];
        for (int j = 0; j < matrix.GetLength(0); j++) matrix[k - 1, j] = A[j];

        for (int j = 0; j < matrix.GetLength(0); j++) A[j] = matrix[j, n2];
        for (int j = 0; j < matrix.GetLength(0); j++) matrix[j, n2] = matrix[j, k - 1];
        for (int j = 0; j < matrix.GetLength(0); j++) matrix[j, k - 1] = A[j];
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
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int index = 0;

        bool continueProgram = false;
        for (int q = 0; q < A.Length; q++)
        {
            if (A[q] != 0 || B[q] != 0)
                continueProgram = true;
        }

        if (!continueProgram)
            return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix2[i, j] = B[index];
                index++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix1[j, i] = matrix1[i, j];
                matrix2[j, i] = matrix2[i, j];
            }
        }
        index = 0;
        int s;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                s = 0;
                for (int l = 0; l < n; l++)
                {
                    s = s + matrix1[i, l] * matrix2[l, j];
                }
                answer[index++] = s;
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
        int stroki = matrix.GetLength(0);
        int stolbi = matrix.GetLength(1);
        // code here
        bool continueProgram = false;
        for (int i = 0; i < stroki; i++)
        {
            for (int j = 0; j < stolbi; j++)
            {
                if (matrix[i, j] != 0)
                {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;
        for (int k = 0; k < stolbi; k++)
        {
            for (int h = 0; h < stolbi - k - 1; h++)
            {
                int countCurrent = 0;
                int countNext = 0;
                for (int g = 0; g < stroki; g++)
                {
                    if (matrix[g, h] < 0)
                        countCurrent++;
                    if (matrix[g, h + 1] < 0)
                        countNext++;
                }
                if (countCurrent > countNext)
                {
                    int[] t = new int[stroki];
                    for (int f = 0; f < stroki; f++)
                    {
                        t[f] = matrix[f, h];
                        matrix[f, h] = matrix[f, h + 1];
                        matrix[f, h + 1] = t[f];
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
        int stroka = matrix.GetLength(0);
        int stolb = matrix.GetLength(1);
        int s = 0;
        bool f = false;

        for (int i = 0; i < stroka; i++)
        {
            for (int k = 0; k < stolb; k++)
            {
                if (matrix[i, k] == 0)
                {
                    s++;
                    f = true;
                    break;
                }
            }
            if (f) { f = false; continue; }
        }
        int h = 0;
        int[,] A = new int[stroka - s, stolb];
        for (int i = 0; i < stroka; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] == 0)
                {
                    s++;
                    f = true;
                    break;
                }
                A[h, j] = matrix[i, j];
            }
            if (f) { f = false; continue; }
            h++;
            if (h >= stroka - s) break;
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}