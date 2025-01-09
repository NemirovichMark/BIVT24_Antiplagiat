using System.Collections.Generic;
using System.ComponentModel;
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
        double da = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    da++;
                }

            }
        }
        answer /= da;
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
        int j = colIndex;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, j] < 0)
            {
                value = A[i, j];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1)
        {
            value = 0;
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
        answer = new double[A.GetLength(0)];
        double sumik = 0, da = 0, meow = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sumik += A[i, j];
                    da++;
                }

            }
            if (da == 0)
            {
                meow = 0;
            }
            else
            {
                meow = sumik / da;
            }
            answer[i] = meow;
            sumik = 0; da = 0; meow = 0;
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
        int[,] DA = new int[4, 7];
        double min = double.MaxValue;
        int da = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                da++;

            }
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < da; j++)
            {
                DA[j, i] = A[j, i];
            }
            for (int j = da + 1; j < A.GetLength(0); j++)
            {
                DA[j - 1, i] = A[j, i];
            }
        }
        A = DA;
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
        answer = new int[A.GetLength(1)];
        int da = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    da++;
                }
            }
            answer[i] = da;
            da = 0;
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
        int mini = int.MaxValue, indi = 0;
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        int[,] DA = new int[n, m];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < mini)
                {
                    mini = B[i, j];
                    indi = j;
                }
            }
            DA[i, 0] = B[i, indi];
            for (int j = 0; j < indi; j++)
            {
                DA[i, j + 1] = B[i, j];
            }
            for (int j = indi + 1; j < m; j++)
            {
                DA[i, j] = B[i, j];
            }
            indi = 0;
            mini = int.MaxValue;
        }
        B = DA;

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
        double maxi = double.MinValue;
        int indi = 0, od = 0, di = 0, t = 0;
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > maxi)
                {
                    maxi = F[i, j];
                    indi = j;
                }
                if (F[i, j] < 0 && t == 0)
                {
                    od = j;
                    t++;
                }
                else if (F[i, j] < 0)
                {
                    di = j;
                }

            }
            if (t > 0)
            {
                F[i, indi] = (F[i, di] + F[i, od]) / 2;
            }
            indi = 0;
            maxi = double.MinValue;
            t = 0;

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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        int da = 0, maxi = int.MinValue;
        int[,] DA = new int[5, 7];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (G[i, j] > maxi)
                {
                    maxi = G[i, j];
                    da = j;
                }
            }
            for (int j = 0; j < da; j++)
            {
                DA[i, j] = G[i, j];
            }
            DA[i, da] = G[i, da];
            DA[i, da + 1] = G[i, da];
            for (int j = da + 2; j < 7; j++)
            {
                DA[i, j] = G[i, j - 1];
            }
            da = 0;
            maxi = int.MinValue;
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                G[i, j] = DA[i, j];
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
        int maxi = int.MinValue, indi = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 6] > maxi)
            {
                maxi = A[i, 6];
                indi = i;
            }
        }
        for (int i = 0; i < 7; i++)
        {
            A[indi + 1, i] = B[i];
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
        int da = F.GetLength(0), DA = F.GetLength(1);

        if (da != 5 || DA != 7) return null;

        int min = int.MaxValue;
        int del = 0;

        for (int j = 0; j < DA; j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = F[1, j];
                del = j;
            }
        }

        del++;

        int[,] G = new int[da, DA - 1];
        for (int i = 0; i < da; i++)
        {
            for (int j = 0; j < DA - 1; j++)
            {
                if (j < del)
                    G[i, j] = F[i, j];
                else
                    G[i, j] = F[i, j + 1];
            }
        }
        F = G;
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
        double maxi = double.MinValue, sum = 0;
        int k1 = 0, k2 = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    k1 = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k2++;
                }
            }
            if (k2 > 0)
                sum = sum / k2;
            else sum = 0;
            A[i, k1] = sum;
            k1 = 0;
            maxi = double.MinValue;
            k2 = 0;
            sum = 0;
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
        double maxi = double.MinValue;
        int da = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    da = j;
                }
            }
            if (A[i, da + 1] > A[i, da - 1])
            {
                if (A[i, da - 1] > 0)
                {
                    A[i, da - 1] *= 2;
                }
                else A[i, da - 1] /= 2;
            }
            else
            {
                if (A[i, da + 1] > 0)
                {
                    A[i, da + 1] *= 2;
                }
                else A[i, da + 1] /= 2;
            }
            maxi = int.MinValue;
            da = 0;
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 7 || k != 5)
        {
            return null;
        }
        for (int j = 0; j < k; j++)
        {
            int schpol = 0, schotr = 0, max = -99999;
            int d = 0;
            for (int i = 0; i < p; i++)
            {
                if (A[i, j] > 0)
                {
                    schpol++;
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        d = i;
                    }
                }
                else
                {
                    schotr++;
                }
            }
            if (schpol > schotr)
            {
                A[d, j] = 0;
            }
            else
            {
                A[d, j] = d + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 10 || b != 5) return null;
        for (int j = 0; j < b; j++)
        {
            int imax = 0, sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            if (imax < a / 2)
            {
                for (int i = imax + 1; i < a; i++)
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
        int strok = A.GetLength(0), stolb = A.GetLength(1), dlina = B.Length;

        if (A == null || strok != 7 || stolb != 5 || B == null || dlina != 5)
        {
            return null;
        }

        for (int j = 0; j < stolb; j++)
        {
            int elemax = int.MinValue, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
            }
            if (elemax < B[j])
            {
                A[indmax, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int imax = 0;
            double psum = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            psum = (A[0, j] - A[n - 1, j]) / 2;
            if (A[imax, j] < psum) A[imax, j] = psum;
            else { A[imax, j] = imax + 1; }
        }
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
            int k = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (j == i + k * n)
                {
                    answer[i, i + k * n] = 1;
                    k++;
                }
                else { answer[i, j] = 0; }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return null; 
        int imax = 0;
        for (int i = 1; i < n; i++)
        {
            if (A[i, i] > A[imax, imax]) imax = i;
        }
        for (int i = 0; i < imax; i++)
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
        if (n != 6 || m != 6) return null;
        int j1max = 0;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] > B[i, jmax]) jmax = j;
            }
            if (i % 2 == 0) { j1max = jmax; }
            else
            {
                var p = B[i - 1, j1max];
                B[i - 1, j1max] = B[i, jmax];
                B[i, jmax] = p;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a = A.GetLength(0), b = A.GetLength(1);
        if (a != 6 || b != 7) return null;
        for (int i = 0; i < a; i++)
        {
            for (int j = 1; j <= b / 2; j++)
            {
                var p = A[i, (a / 2 + j)];
                A[i, a / 2 + j] = A[i, b / 2 - j];
                A[i, a / 2 - j] = p;
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
        int n = matrix.GetLength(0);

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, 0] = 0;
                    matrix[i, n - 1] = 0;
                }
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
        int n = matrix.GetLength(0);

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= j)
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
        int n = matrix.GetLength(0), nomerupper = 0, nomerlower = 0;

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (null, null);
        }


        upper = new int[n * n / 2 + n / 2];
        lower = new int[n * n - n * n / 2 - n / 2];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                    upper[nomerupper++] = matrix[i, j];
                else
                    lower[nomerlower++] = matrix[i, j];
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
        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);

        if (matrix == null || strok != 7 || stolb != 5)
        {
            return null;
        }

        for (int i = 0; i < strok - 1; i++)
        {
            int kolvootriz1 = 0, kolvootriz2 = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] < 0)
                    kolvootriz1++;
            }
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i + 1, j] < 0)
                    kolvootriz2++;
            }
            if (kolvootriz1 > kolvootriz2)
            {
                int reserv = 0;
                for (int j = 0; j < stolb; j++)
                {
                    reserv = matrix[i + 1, j];
                    matrix[i + 1, j] = matrix[i, j];
                    matrix[i, j] = reserv;
                }
                i = -1;
            }
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
        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);

        if (matrix == null)
        {
            return null;
        }

      

        for (int i = 0; i < strok; i += 2)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[i, j], k = j - 1;
                while (k >= 0 && matrix[i, k] < key)
                {
                    matrix[i, k + 1] = matrix[i, k];
                    k--;
                }
                matrix[i, k + 1] = key;
            }
        }
        for (int i = 1; i < strok; i += 2)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[i, j], k = j - 1;
                while (k >= 0 && matrix[i, k] > key)
                {
                    matrix[i, k + 1] = matrix[i, k];
                    k--;
                }
                matrix[i, k + 1] = key;
            }
        }
        if (strok / 2 == 0)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[strok - 1, j], k = j - 1;
                while (k >= 0 && matrix[strok - 1, k] < key)
                {
                    matrix[strok - 1, k + 1] = matrix[strok - 1, k];
                    k--;
                }
                matrix[strok - 1, k + 1] = key;
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
        int minusstrok = 0;

        if (matrix == null)
        {
            return null;
        }



        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] == 0)
                {
                    minusstrok++;
                    break;
                }
            }
        }
        int[,] array = new int[strok - minusstrok, stolb];
        for (int i = 0, k = 0; i < strok; i++)
        {
            int flag = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag++;
                    break;
                }
            }
            for (int j = 0; j < stolb; j++)
            {
                if (flag == 0)
                    array[k, j] = matrix[i, j];
            }
            if (flag == 0)
                k++;
        }

        matrix = array;

        // end

        return matrix;
    }
    #endregion
}