using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks.Dataflow;
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
        for (int i = 0; i < A.GetLength(0); i++)
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 4 || n != 7) return null;
        answer = new int[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int ind = 0;
            int min = 999;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    ind = j;
                }
            }
            answer[i] = ind;
        }
        foreach (int x in answer)
        {
            Console.WriteLine(x);
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = -999;
            int ind = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }
            Console.WriteLine(ind);
            int a = A[i, 0];
            A[i, 0] = A[i, ind];
            A[i, ind] = a;
        }
        foreach (int x in A)
        {
            Console.WriteLine(x);
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 7) return null;
        int imax = 0;
        int jmax = 0;
        int max = -999;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(imax);
        Console.WriteLine(jmax);

        int[,] B = new int[5, 7];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (i < imax)
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            else
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = A[i + 1, j];
                }
        }

        foreach (int i in B)
        {
            Console.WriteLine(i);
        }

        int[,] C = new int[5, 6];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int c = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j == jmax)
                {
                    continue;
                }
                C[i, c] = B[i, j];
                c++;
            }
        }
        A = C;
       
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
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
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 5 || f != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = -999;
            int jmax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            A[i, jmax] = (max * (i + 1));
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
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
        int[] d = new int[D.GetLength(0)];
        int k = 0;
        //найти last отриц - first otr - max before otr
        for (int i = 0; i < D.GetLength(0); i ++)
        {
            int max = -999;
            int jmax = 0;
            int lastj = 0;
            int fj = 0;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    lastj = j;
                }
            }
            Console.WriteLine(lastj);
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    fj = j;
                    break;
                }
            }
            Console.WriteLine(fj);
            for (int j = 0; j < fj; j ++)
            {
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    jmax = j;
                }
            }
            Console.WriteLine(max);
            if (fj != 0 && lastj != 0 && max != -999)
            {
                D[i, jmax] = D[i, lastj];
                D[i, lastj] = max;
            }
        }
        foreach (int i in D)
        {
            Console.WriteLine(i);
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
        int m = H.GetLength(0), f = H.GetLength(1);
        if (m != 5 || f != 7) return null;
        int[] a = new int[m];
        int k = 0;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = -999;
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }
            a[k] = max;
            k++;
        }
        for (int i = 0; i < H.GetLength(0); i++)
        {
            H[i, 6] = H[i, 5];
            H[i, 5] = a[i];
        }
        foreach (int i in H)
        {
            Console.WriteLine(i);
        }

        /*for (int i = 0; i < H.GetLength(0); i++)
        {
            H[i, 5] = a[i];
        }*/

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
        int m = Y.GetLength(0), f = Y.GetLength(1);
        if (m != 6 || f != 5) return null;
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = -999;
            int jmax = 0;
            double sum = 0;
            int n = 0;
            double sr = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    jmax = j;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(jmax);
            for (int j = jmax + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    sum += Y[i, j];
                    n++;
                }
            }
            Console.WriteLine(n);
            if (n > 0)
            {
                sr = sum / n;
                for (int j = 0; j < jmax; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = sr;
                    }
                }
            }
            else
            {
                for (int j = 0; j < jmax; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = 0;
                    }
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
        int m = B.GetLength(0), f = B.GetLength(1);
        if (m != 5 || f != 7) return null;
        int[] A = new int[5];
        int k = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = -999;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            A[k] = max;
            k++;
        }
        for (int i = 0; i < A.Length / 2; i ++)
        {
            int a = A[i];
            A[i] = A[A.Length - i - 1];
            A[A.Length - i - 1] = a;
        }

        foreach (int i in A)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = A[i];
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
        int m = B.GetLength(0), f = B.GetLength(1);
        if (m != 5 || f != 5) return null;
        int n = 0;
        int max = -999;
        int imax = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                imax = i;
            }
        }
        int otr = 0;
        int iort = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                otr = B[i, 2];
                iort = i;
                break;
            }
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int p = B[imax, j];
            B[imax, j] = B[iort, j];
            B[iort, j] = p;
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
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 5 || f != 7) return null;
        int n = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    n++;
                }
            }
        }
        Console.WriteLine(n);
        int[] B = new int[n];
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    B[k] = A[i, j];
                    k++;
                }
            }
        }
        answer = B;
        foreach (int i in answer)
        {
            Console.WriteLine(i);
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 5 || f != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = -999;
            int jmax = 0;
            for (int j = 0; j < A.GetLength(1);j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            Console.WriteLine(max);
            if (jmax == 0)
            {
                if (A[i, jmax + 1] > 0)
                {
                    A[i, jmax + 1] *= 2;
                }
                else
                {
                    A[i, jmax + 1] /= 2;
                }
            }
            else if (jmax == A.GetLength(1) - 1)
            {
                if (A[i, jmax - 1] > 0)
                {
                    A[i, jmax - 1] *= 2;
                }
                else
                {
                    A[i, jmax - 1] /= 2;
                }
            }
            else
            {
                if (A[i, jmax - 1] > A[i, jmax + 1])
                {
                    if (A[i, jmax + 1] > 0)
                    {
                        A[i, jmax + 1] *= 2;
                    }
                    else
                    {
                        A[i, jmax + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, jmax - 1] > 0)
                    {
                        A[i, jmax - 1] *= 2;
                    }
                    else
                    {
                        A[i, jmax - 1] /= 2;
                    }
                }
            }
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 7 || f != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = -999;
            int jmax = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
                if (A[j, i] > 0)
                {
                    count++;
                }
            }
            if (count >= 4)
            {
                A[jmax, i] = 0;
            }
            else
            {
                A[jmax, i] = jmax + 1;
            }
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 10 || f != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = -999;
            int jmax = 0;
            int sum = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            for (int j = jmax + 1; j <  A.GetLength(0); j++)
            {
                sum += A[j, i];
            }
            if (jmax < A.GetLength(0) / 2)
            {
                A[0, i] = sum;
            }
            else
            {
                continue;
            }
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 7 || f != 5 || B.Length != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = -999;
            int jmax = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            if (A[jmax, i] < B[i])
            {
                A[jmax, i] = B[i];
            }
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 7 || f != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = -999;
            int jmax = 0;
            int count = 0;
            double sum = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            sum = A[0, i] + A[A.GetLength(0) - 1, i];
            sum /= 2;
            if (max < sum)
            {
                A[jmax, i] = sum;
            }
            else
                A[jmax, i] = jmax + 1;
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
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
        for (int i = 0; i < answer.GetLength(0); i ++)
        {
            for (int j = 0;j < answer.GetLength(1); j ++)
            {
                answer[i, j] = 0;
            }
        }
        int count = 0;
        for (int i = 0; i < answer.GetLength(0); i ++)
        {
            for (int j = count; j < answer.GetLength(1); j += 3)
            {
                answer[i, j] = 1;
            }
            count++;
        }
        foreach (int i in answer)
        {
            Console.WriteLine(i);
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 6 || f != 6) return null;
        int max = -999;
        int imax = 0;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                imax = i;
            }
        }
        Console.WriteLine(max);
        int count = 1;
        for (int i = 0; i < imax; i++)
        {
            for (int j = count; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
            count++;
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int m = B.GetLength(0), f = B.GetLength(1);
        if (m != 6 && f != 6) return null;


        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = -999;
            int jmax1 = 0;
            int max2 = -999;
            int jmax2 = 0;
            for (int j = 0; j < B.GetLength(1); j ++)
            {
                if (B[i, j] > max1) //по четным относительно i
                {
                    max1 = B[i, j];
                    jmax1 = j;
                }
            }
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i + 1, j] > max2) //по нечетным относительно i
                {
                    max2 = B[i + 1, j];
                    jmax2 = j;
                }
            }
            int a = B[i, jmax1];
            B[i, jmax1] = B[i + 1, jmax2];
            B[i + 1, jmax2] = a;
        }
        
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int m = A.GetLength(0), f = A.GetLength(1);
        if (m != 6 && f != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int a = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = a;
            }
        }
        foreach(int i in A)
        {
            Console.WriteLine(i);
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
        int m = matrix.GetLength(0), f = matrix.GetLength(1);
        if (m != f && m <= 2) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == 0 || i == (matrix.GetLength(0) - 1))
                {
                    matrix[i, j] = 0;
                }
                if (j == 0 || j == (matrix.GetLength(1) - 1))
                {
                    matrix[i, j] = 0;
                }

            }
        }
        foreach (int i in matrix)
        {
            Console.WriteLine(i);
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
        int m = matrix.GetLength(0), f = matrix.GetLength(1);
        if (m != f && m <= 2) return null;
        int count = m / 2;
        Console.WriteLine(count);
        for (int i = count; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= count; j++)
            {
                matrix[i, j] = 1;
            }
            count++;
        }
        foreach(int i in matrix)
        {
            Console.WriteLine(i);
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
        int m = matrix.GetLength(0), f = matrix.GetLength(1);
        if (m != f && m <= 2) return (null, null);
        int countupp = 0;
        int countlow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                countupp++;
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                countlow++;
            }
        }
        upper = new int[countupp];
        lower = new int[countlow];
        countupp = 0;
        countlow = 0;
        for (int i = 0; i < matrix.GetLength(0);i ++)
        {
            for (int j = i; j < matrix.GetLength(1); j ++)
            {
                upper[countupp] = matrix[i,j];
                countupp++;
            }
        }
        foreach (int i in upper)
        {
            Console.WriteLine(i);
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[countlow] = matrix[i,j];
                countlow++;
            }
        }
        foreach (int i in lower)
        {
            Console.WriteLine(i);
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
        int m = matrix.GetLength(0), f = matrix.GetLength(1);
        if (m != 7 && f != 5) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                int counts = 0; //тек. строка
                int countp = 0; //след. строка
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    if (matrix[j, g] >= 0)
                    {
                        counts++;
                    }
                    if (matrix[j + 1, g] >= 0)
                    {
                        countp++;
                    }
                }
                Console.WriteLine(counts + " " + j);
                Console.WriteLine(countp + " " + (j + 1));
                if (counts < countp)
                {
                    int[] matrix2 = new int[m];
                    for (int g = 0; g < matrix.GetLength(1); g++)
                    {
                        matrix2[g] = matrix[j, g];
                        matrix[j, g] = matrix[j + 1, g];
                        matrix[j + 1, g] = matrix2[g];
                    }
                }
            }
        }
        foreach (int i in matrix)
        {
            Console.WriteLine(i);
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int g = 0; g < matrix.GetLength(1) - j - 1; g++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, g] < matrix[i, g + 1])
                        {
                            int b = matrix[i, g];
                            matrix[i, g] = matrix[i, g + 1];
                            matrix[i, g + 1] = b;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        if (matrix[i, g] > matrix[i, g + 1])
                        {
                            int a = matrix[i, g];
                            matrix[i, g] = matrix[i, g + 1];
                            matrix[i, g + 1] = a;
                        }
                    }
                }
            }
        }
        foreach (int i in matrix)
        {
            Console.WriteLine(i);
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int count = 0; // кол-во строк с 0
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = 0; j < matrix.GetLength(1); j ++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine(count);
        int[,]matrix2 = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        int counts = 0; //номер строки
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool f = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    f = true;
                    break;
                }
            }
            Console.WriteLine(f);
            if (f == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j ++)
                {
                    matrix2[counts, j] = matrix[i, j];
                }
                counts++;
            }
        }
        matrix = matrix2;
        foreach (int i in matrix)
        {
            Console.WriteLine(matrix);
        }
        // end

        return matrix;
    }
    #endregion
}