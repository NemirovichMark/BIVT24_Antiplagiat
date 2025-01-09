using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
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
        int sum = 0;
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
        }
        if (count == 0) answer = 0;
        else answer = (double)sum / count;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 4) return (0, 0);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
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
        if (A.GetLength(0) != 4 && A.GetLength(1) != 6) return null;
        double[] answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            if (count == 0) answer[i] = 0;
            else answer[i] = (double)sum / count;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] A1 = new int[A.GetLength(0) - 1, A.GetLength(1)];
        double imin = A[0, 0];
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < imin)
            {
                imin = A[i, 0];
                count = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < count) A1[i, j] = A[i, j];
                else if (i > count) A1[i - 1, j] = A[i, j];
            }
        }
        return A1;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        int[] answer = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int count = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0) count++;
            }
            answer[i] = count;
        }
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        int[,] A = new int[n, m];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int count = 0;
            int imin = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < imin)
                {
                    imin = B[i, j];
                    count = j;
                }
            }
            A[i, 0] = imin;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j < count)
                {
                    A[i, j + 1] = B[i, j];
                }
                else if (j > count)
                {
                    A[i, j] = B[i, j];
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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            double imax = F[i, 0];
            int count = 0;
            double one1 = 0;
            double one2 = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > imax)
                {
                    count = j;
                    imax = F[i, j];
                }
                if (one1 == 0 && F[i, j] < 0)
                {
                    one1 = F[i, j];
                }
                if (F[i, j] < 0)
                {
                    one2 = F[i, j];
                }
            }
            if (one1 != 0 || one2 != 0)
            {
                F[i, count] = (one1 + one2) / 2;
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
        int[,] A = new int[G.GetLength(0), G.GetLength(1)];
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int imax = G[i, 0];
            int count = 0;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > imax)
                {
                    count = j;
                    imax = G[i, j];
                }
            }
            A[i, count] = imax;
            A[i, count + 1] = imax;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (j < count)
                {
                    A[i, j] = G[i, j];
                }
                if (j > count + 1)
                {
                    A[i, j] = G[i, j - 1];
                }
            }
        }
        return A;
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
        int maxx = A[0, 5];
        int imax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > maxx)
            {
                maxx = A[i, 5];
                imax = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[imax, j] = B[j];
        }
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        int[,] A = new int[F.GetLength(0), F.GetLength(1) - 1];
        int minn = Math.Abs(F[1, 0]);
        int jmin = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < minn)
            {
                minn = Math.Abs(F[1, j]);
                jmin = j;
            }
        }
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (j <= jmin)
                {
                    A[i, j] = F[i, j];
                }
                else if (j > jmin + 1)
                {
                    A[i, j - 1] = F[i, j];
                }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxx = A[i, 0];
            int jmax = 0;
            double sum = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    jmax = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            if (count == 0) A[i, jmax] = 0;
            else
            {
                sum /= count;
                A[i, jmax] = sum;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxx = A[i, 0];
            int imax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    imax = j;
                }
            }
            if (imax == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                if (A[i, 1] < 0) A[i, 1] /= 2;
            }
            else if (imax == (A.GetLength(1) - 1))
            {
                if (A[i, A.GetLength(1) - 2] > 0) A[i, A.GetLength(1) - 2] *= 2;
                else if (A[i, A.GetLength(1) - 2] < 0) A[i, A.GetLength(1) - 2] /= 2;
            }
            else if (A[i, imax - 1] < A[i, imax + 1])
            {
                if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                else if (A[i, imax - 1] < 0) A[i, imax - 1] /= 2;
            }
            else if (A[i, imax + 1] < A[i, imax - 1])
            {
                if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2;
                else if (A[i, imax + 1] < 0) A[i, imax + 1] /= 2;
            }
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int maxx = A[0, i];
            int imax = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0) count++;
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    imax = j;
                }
            }
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (count < A.GetLength(0) - count)
                {
                    A[imax, i] = 0;
                }
                else
                {
                    A[imax, i] = imax + 1;
                }
            }
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int sum = 0;
            int maxx = A[0, i];
            int imax = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    imax = j;
                }
            }
            if (imax < A.GetLength(0))
            {
                for (int j = imax + 1; j < A.GetLength(0); j++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int maxx = A[0, i];
            int jmax = -1;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    jmax = j;
                }
            }
            if (B[i] > maxx)
            {
                A[jmax, i] = B[i];
            }
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double maxx = A[0, i];
            int jmax = -1;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    jmax = j;
                }
            }
            double sum = (A[0, i] + A[A.GetLength(0) - 1, i]) / 2;
            if (A[jmax, i] < sum)
            {
                A[jmax, i] = sum; 
            }
            else
            {
                A[jmax, i] = jmax + 1;
            }
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        double count = 0;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (j == count || j == n + i || j == 2 * n + i)
                {
                    answer[i, j] = 1;
                }
                else
                {
                    answer[i, j] = 0;
                }
            }
            count++;
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int imax = -1;
        double maxx = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j == i)
                {
                    if (A[i, j] > maxx)
                    {
                        maxx = A[i, j];
                        imax = i;
                    }
                }
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i; j < A.GetLength(1); j++)
            {
                if (j > i)
                {
                    A[i, j] = 0;
                }
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max1 = A[0, 0], max2 = A[1, 0], jmax1 = -1, jmax2 = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i % 2 == 0 && A[i, j] > max1)
                {
                    max1 = A[i, j];
                    jmax1 = j;
                }
                else if (A[i, j] > max2)
                {
                    max2 = A[i, j];
                    jmax2 = j;
                }
            }
            if (i % 2 == 1)
            {
                int temp = A[i - 1, jmax1];
                A[i - 1, jmax1] = A[i, jmax2];
                A[i, jmax2] = temp;
                if (i < 5)
                {
                    max1 = A[i + 1, 0];
                    max2 = A[i + 2, 0];
                }
                jmax1 = -1;
                jmax2 = -1;
            }
        }
        return A;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = temp;
            }
        }
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int k = 0; k < A.GetLength(0) - 1 - i; k++)
            {
                int min1 = int.MaxValue;
                int min2 = int.MaxValue;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[k, j] < min1)
                    {
                        min1 = A[k, j];
                    }
                    if (A[k + 1, j] < min2)
                    {
                        min2 = A[k + 1, j];
                    }
                }
                if (min1 < min2)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        int temp = A[k, j];
                        A[k, j] = A[k + 1, j];
                        A[k + 1, j] = temp;
                    }
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] A)
    {
        int[] answer = new int[2 * A.GetLength(0) - 1];
        int count = 0;
        if (A.GetLength(0) != A.GetLength(1) || A.GetLength(1) == 0) return null;
        for (int i = A.GetLength(1) - 1; i >= 0; i--)
        {
            int sum = 0;
            for (int k = i, l = 0; k < A.GetLength(1) && l < A.GetLength(0); k++, l++)
            {
                sum += A[k, l];
            }
            answer[count] = sum;
            count++;
        }
        for (int i = 1; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int k = i, l = 0; k < A.GetLength(0) && l < A.GetLength(1); k++, l++)
            {
                sum += A[l, k];
            }
            answer[count] = sum;
            count++;
        }
        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] A, int k)
    {
        if (A.GetLength(0) != A.GetLength(1) || A.GetLength(1) == 0 || k < 1 || k > A.GetLength(0)) return null;
        k = k - 1;
        int max = Math.Abs(A[0, 0]);
        int imax = -1;
        int jmax = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (Math.Abs(A[i, j]) > max)
                {
                    max = Math.Abs(A[i, j]);
                    imax = i;
                    jmax = j;
                }
            }
        }
        Console.WriteLine(A[imax, jmax]);
        int[] B = new int[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            B[i] = A[imax, i];
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[imax, i] = A[k, i];
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[k, i] = B[i];
        }
        int[] C = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            C[i] = A[i, jmax];
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[i, jmax] = A[i, k];
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[i, k] = C[i];
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
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
        if (A.Length != (n + 1) / 2 * n || B.Length != (n + 1) / 2 * n || n <= 0) return null;
        int[] answer = new int[n * n];
        int[,] C = new int[n, n];
        int[,] D = new int[n, n];
        int count = 0;
        for (int j = 0; j < n; j++)
        {
            for (int i = j; i < n; i++)
            {
                C[i, j] = A[count];
                C[j, i] = A[count];
                count++;
            }
        }
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                D[i, j] = B[count];
                D[j, i] = B[count];
                count++;
            }
        }
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int a = 0;
                for (int i1 = 0, j1 = 0; i1 < n; i1++, j1++)
                {
                    a += C[i, j1] * D[i1, j];
                }
                answer[count] = a;
                count += 1;
            }
        }
        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] A)
    {
        int count1 = 0;
        int count2 = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int h = 0; h < A.GetLength(1); h++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                count2 = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] < 0)
                    {
                        count2++;
                    }
                }
                if (j == 0)
                {
                    count1 = count2;
                }
                else
                {
                    if (count2 < count1)
                    {
                        int[] B = new int[A.GetLength(0)];
                        for (int k = 0; k < A.GetLength(0); k++)
                        {
                            B[k] = A[k, j];
                        }
                        for (int k = 0; k < A.GetLength(0); k++)
                        {
                            A[k, j] = A[k, j - 1];
                            A[k, j - 1] = B[k];
                        }
                    }
                }
                count1 = count2;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] A)
    {
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[] A1 = new int[count];
        int[,] B = new int[A.GetLength(0) - count, A.GetLength(1)];
        count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 0)
                {
                    A1[count] = i;
                    count++;
                    break;
                }
            }
        }
        count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == A1[count])
            {
                count++;
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i - count, j] = A[i, j];
                }
            }
        }
        return B;
    }
    #endregion
}