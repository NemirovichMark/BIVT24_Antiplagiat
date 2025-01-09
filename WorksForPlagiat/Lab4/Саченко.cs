using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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


        if (A != null && A.GetLength(0) == 4 && A.GetLength(1) == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                answer += A[i, i];
            }
        }
        else
        {
            return 0;
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
        int[] answer = new int[A.GetLength(0)];
        if (A == null || A.GetLength(0) < 4 || A.GetLength(1) > 7)
        {
            return null;
        }
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = j;
                }
            }
            answer[i] = min;

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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue, maxind = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxind = j;
                }
            }

            int vrem = A[i, 0];
            A[i, 0] = A[i, maxind];
            A[i, maxind] = vrem;

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
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) { return null; }
        // end
        int max = int.MinValue;
        int strok = 0, stolb = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    strok = i;
                    stolb = j;
                }
            }
        }
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0, strok2 = 0; i < A.GetLength(0); i++)
        {
            if (i == strok)
            {
                continue;
            }
            for (int j = 0, stolb2 = 0; j < A.GetLength(1); j++)
            {
                if (j == stolb)
                {
                    continue;
                }
                B[strok2, stolb2] = A[i, j];
                stolb2++;

            }
            strok2++;
        }
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int stolb = 0, max = int.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stolb = j;
                }
            }
            A[i, stolb] *= i + 1;
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
        if (D == null || D.GetLength(0) != n || D.GetLength(1) != m) { return null; }
        // code here
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = int.MinValue, maxstolb = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    break;
                }
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    maxstolb = j;
                }
            }
            int minindexstolb = -1;
            for (int l = m - 1; l >= 0; l--)
            {
                if (D[i, l] < 0)
                {
                    minindexstolb = l;
                    break;
                }
            }
            if (maxstolb != -1 && minindexstolb != -1)
            {
                int vrem = D[i, maxstolb];
                D[i, maxstolb] = D[i, minindexstolb];
                D[i, minindexstolb] = vrem;
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
        if (H == null || H.GetLength(0) != 5 || H.GetLength(1) != 7) { return null; }
        // code here
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = int.MinValue, stolb = 0;
            for (int j = 0; j < H.GetLength(1) - 1; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                    stolb = j;
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max;
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

        if (Y == null || Y.GetLength(0) != 6 || Y.GetLength(1) != 5) { return null; }
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = double.MinValue;
            int stolb = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    stolb = j;
                }
            }
            double sum = 0;
            int k = 0;
            for (int j2 = stolb + 1; j2 < Y.GetLength(1); j2++)
            {
                if (Y[i, j2] > 0)
                {
                    sum += Y[i, j2];
                    k++;
                }
            }
            double srar = 0;
            if (k != 0)
            {
                srar = sum / k;
            }
            for (int j3 = stolb - 1; j3 >= 0; j3--)
            {
                if (Y[i, j3] < 0)
                {
                    Y[i, j3] = srar;
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
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 7) { return null; }
        int[] mas = new int[5];
        int num = 0;
        for (int i = B.GetLength(0) - 1; i >= 0; i--, num++)
        {
            int max = int.MinValue, stolb = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    stolb = j;
                }
            }
            mas[num] = B[i, stolb];
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = mas[i];
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
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 5) { return null; }
        int max = int.MinValue, stroka = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                stroka = i;
            }
        }
        int stroka2 = -1;
        for (int j = 2, i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, j] < 0)
            {
                stroka2 = i;
                break;
            }
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int vrem = B[stroka, j];
            B[stroka, j] = B[stroka2, j];
            B[stroka2, j] = vrem;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        // code here
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    k++;
                }
            }
        }
        int[] answer = new int[k]; int d = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[d] = A[i, j];
                    d++;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = int.MinValue;
            int stolb = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stolb = j;
                }
            }
            if (stolb == 0)
            {
                A[i, 1] *= 2;
            }
            else if (stolb == 6)
            {
                A[i, 5] *= 2;
            }
            else if (stolb != 6 && stolb != 0)
            {
                if (A[i, stolb + 1] < A[i, stolb - 1])
                {
                    if (A[i, stolb + 1] > 0)
                    {
                        A[i, stolb + 1] *= 2;
                    }
                    else
                    {
                        A[i, stolb + 1] /= 2;
                    }
                }
                else if (A[i, stolb + 1] > A[i, stolb - 1])
                {
                    if (A[i, stolb - 1] > 0)
                    {
                        A[i, stolb - 1] *= 2;
                    }
                    else
                    {
                        A[i, stolb - 1] /= 2;
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
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue, stroka = 0, pol = 0, otr = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stroka = i;
                }
                if (A[i, j] > 0)
                {
                    pol++;
                }
                if (A[i, j] < 0)
                {
                    otr++;
                }
            }
            if (pol > otr)
            {
                A[stroka, j] = 0;
            }
            else
            {
                A[stroka, j] = stroka + 1;
            }

        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue, strok = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    strok = i;
                }
            }
            if (strok <= 5)
            {
                for (int i = strok + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue, stroka = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stroka = i;
                }
            }
            if (B[j] > max)
            {
                A[stroka, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = int.MinValue;
            int stroka = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stroka = i;
                }
            }
            double sum = (A[0, j] + A[6, j]) / 2;
            if (max < sum)
            {
                A[stroka, j] = sum;
            }
            else
            {
                A[stroka, j] = stroka + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) { return null; }
        answer = new int[n, n * 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j % 3)
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
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6) { return null; }
        int stolb = 0;
        int max = int.MinValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                stolb = i;
            }
        }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            if (i == stolb)
            {
                break;
            }
            for (int s = i + 1; s < A.GetLength(1); s++)
            {
                A[i, s] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) { return null; }
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            int stolb1 = 0, stolb2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    stolb1 = j;
                }
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    stolb2 = j;
                }
            }
            B[i, stolb1] = max2;
            B[i + 1, stolb2] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) { return null; }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < (A.GetLength(1) - 1) / 2; j++)
            {
                int vrem = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = vrem;
            }
        }
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // code here
        int A = matrix.GetLength(0), B = matrix.GetLength(1);

        if (A != 7 && B != 5)
        {
            return default(int[,]);
        }

        int[] MinVal = new int[A];
        int[] MinIND = new int[A];


        for (int i = 0; i < A; i++)
        {
            int MinEl = matrix[i, 0];
            MinIND[i] = i;

            for (int j = 0; j < B; j++)
            {
                if (matrix[i, j] < MinEl)
                    MinEl = matrix[i, j];
            }
            MinVal[i] = MinEl;
        }


        for (int i = 1; i < A; i++)
        {
            int k = MinVal[i];
            int k2 = MinIND[i];
            int j = i - 1;
            while (j >= 0 && MinVal[j] < k)
            {
                MinVal[j + 1] = MinVal[j];
                MinIND[j + 1] = MinIND[j];
                j -= 1;
            }
            MinVal[j + 1] = k;
            MinIND[j + 1] = k2;
        }


        int[,] newmatrix = new int[A, B];
        for (int i = 0; i < A; i++)
        {
            int index = MinIND[i];
            for (int j = 0; j < B; j++)
            {
                newmatrix[i, j] = matrix[index, j];
            }
        }





        // end

        return newmatrix;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 3) { return null; }
        // end
        answer = new int[matrix.GetLength(0) * 2 - 1];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int k = j - i + matrix.GetLength(0) - 1;
                answer[k] += matrix[i, j];
            }
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1) return null;
        int max = int.MinValue, stolb = 0, strok = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[strok, stolb]))
                {
                    strok = i;
                    stolb = j;
                }
            }
        }


        if (stolb != k - 1)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int temp = matrix[strok, j];
                matrix[strok, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (strok != k - 1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, stolb];
                matrix[i, stolb] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
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

        int[] mas = new int[n * n];
        int[,] Am = new int[n, n];
        int[,] Bm = new int[n, n];
        int c = 0;
        if (A.Length < 2 || B.Length < 2)
        {
            return answer;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Am[i, j] = A[c];
                Bm[i, j] = B[c];
                c++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Am[i, j] = Am[j, i];
                Bm[i, j] = Bm[j, i];
            }
        }
        c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += Am[i, k] * Bm[k, j];
                }
                mas[c++] = sum;
            }
        }
        return mas;

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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        {
            return null;
        }
        int[] otr = new int[matrix.GetLength(1)];
        int[,] mat = new int[5, 7];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    c++;
                }
            }
            otr[j] = c;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int min = 1000000;
            int index = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (otr[i] < min)
                {
                    min = otr[i];
                    index = i;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mat[i, j] = matrix[i, index];
            }
            otr[index] = 1000000;
        }

        // end

        return mat;

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
        if (matrix.GetLength(0) < 2)
        {
            return null;
        }
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool zero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if (zero == false)
            {
                c++;
            }
        }
        int[,] mat = new int[c, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool zero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if (zero == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mat[k, j] = matrix[i, j];
                }
                k++;
            }
        }

        // end

        return mat;
    }
    #endregion
}