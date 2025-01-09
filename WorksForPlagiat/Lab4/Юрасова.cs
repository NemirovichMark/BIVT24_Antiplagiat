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

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a == b)
        {
            for (int i = 0; i < 4; i++)
                answer += A[i, i];
        }
        else
            return 0;
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int min = 1234567;
        int index = -1;
        answer = new int[a];
        if (a != 4 || b != 7)
            return default(int[]);
        else
        {
            for (int i = 0, j = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    if (A[i,k] < min)
                    {
                        min = A[i, k];
                        index = k;
                    }
                }
                answer[j] = index;
                j++;
            }
        }
        foreach (int i in answer)
            Console.Write(i + " ");
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
        void swap(int[,] arr, int i, int j, int h) { int a = arr[h, j]; arr[h, j] = arr[h, i]; arr[h, i] = a; }
        int b = A.GetLength(0);
        int c = A.GetLength(1);
        int max = -1234567;
        int index = -1;
        if (b != 5 || c != 7)
            return null;
        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            swap(A, 0, index, i);
            max = -1234567;
            index = -1;
        }
        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int max = -1234567;
        int index1 = -1;
        int index2 = -1;
        if (a != 6 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    index1 = i;
                    index2 = j;
                }
            }
        }
        int[,] B = new int[a - 1, b - 1];
        for (int i = 0, k = 0; i < a; i++)
        {
            for (int j = 0, l = 0; j < b; j++)
            {
                if (j != index2)
                {
                    B[k, l] = A[i, j];
                    l++;
                }
            }
            if (i != index1)
                k++;
        }
        A = new int[a - 1, b - 1];
        A = B;
        for (int i = 0; i < a - 1; i++)
        {
            for (int j = 0; j < b - 1; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int max = -1234567;
        int index = -1;
        if (a != 5 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            A[i, index] *= (i + 1);
            index = -1;
            max = -1234567;
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = -1234567;
            int imax = 0;
            int index1 = 0;
            int index2 = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i,j] < 0)
                {
                    index1 = j;
                    if (index2 == -1)
                        index2 = j;
                }
            }
            for (int j = 0; j < index2; j++)
            {
                if (D[i,j] > max)
                {
                    max = D[i, j];
                    imax = j;
                }
            }
            if (index2 != 0 && index1 != 0 && max != -1234567)
            {
                D[i, imax] = D[i, index1];
                D[i, index1] = max;
            }
        }
        for (int i = 0; i < D.GetLength(0); i++)
        {
            for (int j = 0; j < D.GetLength(1); j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
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
        int a = H.GetLength(0);
        int b = H.GetLength(1);
        int max = -1234567;
        int imax = -1;
        int maxabs = -1234567;
        int imaxabs = -1;
        if (a != 5 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (Math.Abs(H[i,j]) > max)
                {
                    maxabs = H[i, j];
                    imaxabs = j;
                }
                if (H[i,j] > max)
                {
                    max = H[i, j];
                    imax = j;
                }
            }
            if (maxabs >= 0)
                H[i, b - 1] = maxabs;
            if (maxabs < 0)
            {
                H[i, b - 1] = maxabs;
                H[i, b - 2] = max;
            }
            max = maxabs = -1234567;
            imax = imaxabs = -1;
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(H[i, j] + " ");
            Console.WriteLine();
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
        int a = Y.GetLength(0);
        int b = Y.GetLength(1);
        int index = -1;
        double max = -1234567;
        double sum = 0;
        double c = 0;
        if (a != 6 || b != 5)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (Y[i,j] > max)
                {
                    max = Y[i, j];
                    index = j;
                }
            }
            if (index != b - 1)
            {
                for (int j = index + 1; j < b; j++)
                {
                    if (Y[i, j] > 0)
                    {
                        sum += Y[i, j];
                        c++;
                    }
                    else
                        sum = c = 0;
                }
            }
            if (c == 0)
                sum = 0;
            else
                sum /= c;
            for (int j = 0; j < index; j++)
            {
                if (Y[i, j] < 0)

                    Y[i, j] = sum;
            }
            sum = c = 0;
            max = -1234567;
            index = -1;
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(Y[i, j] + " ");
            Console.WriteLine();
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
        int a = B.GetLength(0);
        int b = B.GetLength(1);
        int max = -1234567;
        int[] array = new int[a];
        if (a != 5 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (B[i,j] > max)
                    max = B[i, j];
            }
            array[i] = max;
            max = -1234567;
        }
        for (int i = 0, j = a - 1; i < a; i++, j--)
            B[i, 3] = array[j];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
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
        int a = B.GetLength(0);
        int b = B.GetLength(1);
        if (a != 5 || b != 5)
            return null;
        for (int i = 0; i < a; i++)
        {
            int t = B[0, i];
            B[0, i] = B[3, i];
            B[3, i] = t;
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int c = 0;
        int k = 0;
        if (a != 5 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < 0)
                    c++;
            }
        }
        answer = new int[c];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[k] = A[i, j];
                    k++;
                }
            }
        }
        foreach (int i in answer)
            Console.Write(i + " ");
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int imax = -1;
        int i1 = -1;
        int i2 = -1;
        double max = -1234567;
        if (a != 5 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            if (imax == b)
            {
                if (A[i, i1] > 0)
                    A[i, i1] *= 2;
                else
                    A[i, i1] /= 2;
            }
            else if (imax == 0)
            {
                if (A[i, i2] > 0)
                    A[i, i2] *= 2;
                else
                    A[i, i2] /= 2;
            }
            else if (A[i, imax - 1] > A[i, imax + 1])
            {
                if (A[i, imax + 1] > 0)
                    A[i, imax + 1] *= 2;
                else
                    A[i, imax + 1] /= 2;
            }
            else
            {
                if (A[i, imax - 1] > 0)
                    A[i, imax - 1] *= 2;
                else
                    A[i, imax - 1] /= 2;
            }
            max = -1234567;
            imax = -1;
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 7 || b != 5)
            return null;
        for (int i = 0; i < b; i++)
        {
            int c = 0;
            int d = 0;
            int max = -1234567;
            int imax = 0;
            for (int j = 0; j < a; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i]; imax = j;
                }
                if (A[j, i] > 0)
                    c++;
                else
                    d++;
            }
            if (c > d)
                A[imax, i] = 0;
            else
                A[imax, i] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 10 || b != 5)
            return null;
        for (int i = 0; i < b; i++)
        {
            int c = 0;
            int max = -1234567;
            int imax = -1;
            for (int j = 0; j < a; j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j, i];
                    imax = j;
                }
            }
            if (imax < 5)
            {
                for (int j = imax + 1; j < a; j++)
                    c += A[j, i];
                A[0, i] = c;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 7 || b != 5 || B.Length != 5)
            return null;
        for (int i = 0; i < b; i++)
        {
            int max = -1234567;
            int imax = -1;
            for (int j = 0; j < a; j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j, i];
                    imax = j;
                }
            }
            if (max < B[i])
            {
                A[imax, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 7 || b != 5)
            return null;
        for (int i = 0; i < b; i++)
        {
            double max = -1234567;
            int imax = -1;
            for (int j = 0; j < a; j++)
            {
                if (A[j,i] > max)
                {
                    max = A[j, i];
                    imax = j;
                }
            }
            double s = (A[0, i] + A[a - 1, i]) / 2;
            if (max < s)
                A[imax, i] = s;
            else
                A[imax, i] = imax + 1;
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0)
            return answer;
        answer = new int[n, 3 * n];
        int[,] A = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    A[i, j] = 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int c = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (c == 3)
                    c = 0;
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int max = -1234567;
        int imax = -1;
        if (a != 6 || b != 6)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (i == j)
                {
                    if (A[i,j] > max)
                    {
                        max = A[i, j];
                        imax = i;
                    }
                }
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i + 1; j < b; j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int a = B.GetLength(0);
        int b = B.GetLength(1);
        int max = -1234567;
        int imax = -1;
        int max1 = -1234567;
        int imax1 = -1;
        if (a != 6 || b != 6)
            return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i,j] > max)
                    {
                        max = B[i, j];
                        imax = j;
                    }
                }
                if (i % 2 != 0)
                {
                    if (B[i,j] > max1)
                    {
                        max1 = B[i, j];
                        imax1 = j;
                    }
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, imax] = max1;
                B[i, imax1] = max;
                max = max1 = -1234567;
                imax = imax1 = -1;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 6 || b != 7)
            return null;
        for (int i = 0; i < a; i++)
        {
            int t;
            for (int j = 0; j < b / 2; j++)
            {
                t = A[i, j];
                A[i, j] = A[i, b - j - 1];
                A[i, b - j - 1] = t;
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        if (a != b && a <= 2)
            return null;
        int c = 0;
        bool d = false;
        for (int i = 0; i < a; i++)
        {
            if (i == 0 && c != b - 1 && d == false)
            {
                matrix[i, c] = 0;
                matrix[a - 1, c] = 0;
                c++;
                i--;
            }
            else
            {
                d = true;
                c = 0;
            }
            if ( i != -1 && i != b - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, a - 1] = 0;
            }
        }
        matrix[a - 1, b - 1] = 0;
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
        int b = matrix.GetLength(1);
        if (a != b && a <= 2)
            return null;
        int c = b / 2;
        for (int i = a / 2; i < a; i++)
        {
            for (int j = 0; j <= c; j++)
                matrix[i, j] = 1;
            c++;
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        if (a != b && a <= 2)
            return (null, null);
        int upper1 = 0;
        int lower1 = 0;
        int c = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (j >= c)
                    upper1++;
                else
                    lower1++;
            }
            c++;
        }
        c = 0;
        int[] upper = new int[upper1];
        int[] lower = new int[lower1];
        upper1 = 0;
        lower1 = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (j >= c)
                {
                    upper[upper1] = matrix[i, j];
                    upper1++;
                }
                else
                {
                    lower[lower1] = matrix[i, j];
                    lower1++;
                }
            }
            c++;
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        if (a != 7 && a != 5)
            return null;
        int[,] array1 = new int[a, b];
        int[,] array2 = new int[a, 2];
        int c = 0;
        for (int i = 0; i < a; i++)
        {
            c = 0;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] >= 0)
                    c++;
            }
            array2[i, 0] = c;
            array2[i, 1] = i;
        }
        int max = 0;
        int max1 = 0;
        int max2 = 0;
        bool p = true;
        for (int i = 0; i < a; i++)
        {
            p = false;
            for (int j = 0; j < a; j++)
            {
                if (array2[j,0] > max)
                {
                    p = true;
                    max = array2[j, 0];
                    max1 = array2[j, 1];
                    max2 = j;
                }
            }
            array2[max2, 0] = 0;
            if (p == false)
                break;
            for (int j = 0; j < b; j++)
                array1[i, j] = matrix[max1, j];
            max = 0;
            max1 = 0;
            max2 = 0;
        }
        // end

        return array1;
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        for (int i = 0; i < a; i++)
        {
            if (i % 2 == 0)
            {
                bool c;
                do
                {
                    c = false;
                    for (int j = 0; j < b - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            int t = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = t;
                            c = true;
                        }
                    }
                } while (c);
            }
            else
            {
                bool c;
                do
                {
                    c = false;
                    for (int j = 0; j < b - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                        {
                            int t = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = t;
                            c = true;
                        }
                    }
                } while (c);
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        int c = 0;
        int d = 0;
        for (int i = 0; i < a; i++)
        {
            bool p = true;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    p = false;
                }
            }
            if (p == true)
            {
                d++;
            }
        }
        int[] matrix2 = new int[a - d];
        int e = 0;
        for (int i = 0; i < a; i++)
        {
            c = -1;
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                    c = i;
            }
            if (c != -1)
            {
                matrix2[e] = c;
                e++;
            }
        }
        int[,] result = new int[d, b];
        int a2 = result.GetLength(0);
        int b2 = result.GetLength(1);
        e = 0;
        for (int i = 0; i < a; i++)
        {
            bool p = true;
            for (int g = 0; g < matrix2.Length; g++)
            {
                if (i == matrix2[g])
                {
                    p = false;
                }
            }
            if (p == true)
            {
                Console.WriteLine(i);
                for (int j = 0; j < b; j++)
                {
                    result[e, j] = matrix[i, j];
                }
                e++;
            }

        }
        for (int i = 0; i < a2; i++)
        {
            for (int j = 0; j < b2; j++)
            {
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }

        // end

        return result;
    }
    #endregion
}