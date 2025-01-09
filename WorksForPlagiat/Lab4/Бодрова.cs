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
        
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0;
        }
        double s = 0; double n = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j]; n++;
                }
            }
        }
        answer = s / n;
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

        if ((A.GetLength(0) == 5) && (colIndex <= 4))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, colIndex] < 0)
                {
                    value = A[i, colIndex];
                    rowIndex = i;
                    break;
                }
            }
        }
        // end
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
        double[] answer = new double[A.GetLength(0)];
        // code here
        double a = 0;
        double summ = 0;
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (A[i, j] > 0)
                    {
                        a++;
                        summ += A[i, j];
                    }
                }
                if (a != 0)
                    summ = Math.Round(summ / a, 2);
                else
                    summ = 0;
                a = 0;

                answer[i] = summ;
                summ = 0;
            }
        }
        else
        {
            answer = null;
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
        int[,] NB = new int[4, 7];
        int n = 0;
        double mini = double.MaxValue;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 0] < mini)
                {
                    mini = A[i, 0];
                    n = i;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    NB[i, j] = A[i, j];
                }
                for (int i = n + 1; i < 5; i++)
                {
                    NB[i - 1, j] = A[i, j];
                }
            }
            mini = double.MaxValue;
            n = 0;
        }
        else
            NB = null;
        // end

        return NB;
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
        
        
        int[] answer = new int[A.GetLength(1)];
        // code here
        int n = 0;
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 3))
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[j, i] < 0)
                    {
                        n++;
                    }
                }
                answer[i] = n;
                n = 0;
            }
        }
        else
        {
            answer = null;
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
        int r = n, c = m;

        for (int i = 0; i < r; i++)
        {
            int min_index = 0, temp;
            for (int j = 0; j < c; j++)
                if (B[i, j] < B[i, min_index]) min_index = j;
            temp = B[i, min_index];
            for (int j = min_index; j > 0; j--)
                B[i, j] = B[i, j - 1];
            B[i, 0] = temp;
        }
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
        int r = n, c = m;

        for (int i = 0; i < r; i++)
        {
            int max_index = 0, first_index = -1, last_index = -1;
            for (int j = 0; j < c; j++)
            {
                if (F[i, j] > F[i, max_index]) max_index = j;
                if (F[i, j] < 0)
                {
                    if (first_index == -1) first_index = j;
                    last_index = j;
                }
            }
            if (first_index != -1) F[i, max_index] = (F[i, first_index] + F[i, last_index]) / 2;
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
        int r = G.GetLength(0), c = G.GetLength(1);
        if (r != 5 || c != 7) return default(int[,]);

        for (int i = 0; i < r; i++)
        {
            int max_index = 0;
            for (int j = 0; j < c - 1; j++)
                if (G[i, j] > G[i, max_index]) max_index = j;
            for (int j = c - 1; j > max_index; j--)
                G[i, j] = G[i, j - 1];
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
        int r = A.GetLength(0), c= A.GetLength(1), maxi = 0;
        if (r != 5 || c != 7 || B.Length != 7) return default(int[,]);

        for (int i = 0; i < r; i++)
            if (A[i, 6 - 1] > A[maxi, 6 - 1]) maxi = i;

        for (int j = 0; j < c; j++)
        {
            A[maxi, j] = B[j];
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
        int r = F.GetLength(0), c = F.GetLength(1), mini = 0;
        int[,] v = new int[r, c - 1];
        if (r != 5 || c != 7) return default(int[,]);

        for (int j = 0; j < c; j++)
            if (Math.Abs(F[2 - 1, j]) < Math.Abs(F[2 - 1, mini])) mini = j;

        for (int j = 0; j < c- 1; j++)
        {
            for (int i = 0; i < r; i++)
            {
                if (j > mini) v[i, j] = F[i, j + 1];
                else v[i, j] = F[i, j];
            }
        }
        F = v;
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
        int r = A.GetLength(0), c = A.GetLength(1);
        if (r != 5 || c != 7) return default(double[,]);

        for (int i = 0; i < r; i++)
        {
            double sum = 0;
            int cn = 0, maxi = 0;
            for (int j = 0; j < c; j++)
            {
                if (A[i, j] > A[i, maxi]) maxi = j;
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cn++;
                }
            }
            if (cn != 0) sum /= cn;
            A[i, maxi] = sum;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j]) { max = A[i, j]; index = j; }
            }

            double temp;
            if (A[i, index + 1] > A[i, index - 1] || index == A.GetLength(1) - 1)
            {
                temp = A[i, index - 1];
                if (temp >= 0) { temp *= 2; }
                else { temp /= 2; }
                A[i, index - 1] = temp;
            }
            else if (A[i, index + 1] < A[i, index - 1] || index == 0)
            {
                temp = A[i, index + 1];
                if (temp >= 0) { temp *= 2; }
                else { temp /= 2; }
                A[i, index + 1] = temp;
            }
        }
        return A;
        // end

        
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) { return null; }

        for (int j = 0; j < m; j++)
        {
            int max = A[0, j];
            int index = 0;
            int neg = 0, pos = 0;

            for (int i = 0; i < n; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    index = i;
                }

                if (A[i, j] > 0) pos++;
                else if (A[i, j] < 0) neg++;
            }

            if (pos > neg) { A[index, j] = 0; }
            else { A[index, j] = index +1; } 
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        int maxi = 0;
        for (int j = 0; j < m; j++)
        {
            int max = -100000, sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (maxi > 5) break;
            for (int i = maxi + 1; i < n; i++)
            {
                sum += A[i, j];
            }
            A[0, j] = sum;
            // end
        }
            return A;
        
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = -10000, maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }

            }
            if (A[maxi, j] < B[j])
            {
                A[maxi, j] = B[j];
            }
            else
                break;
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        int maxi = 0;
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[maxi, j])
                    maxi = i;

            }
            double s = (A[0, j] + A[n - 1, j]) / 2;
            if (A[maxi, j] < s)
                A[maxi, j] = s;
            else
                A[maxi, j] = maxi + 1;

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
            return answer;
        }
        answer = new int[n, n * 3];
        int c = answer.GetLength(0);
        int r = answer.GetLength(1);
        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                answer[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < c; i++)
        {
            count++;
            for (int j = count; j < r;)
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
        if (n != 6 || m != 6) return null;
        int maxi = A[0, 0];
        int imax = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    imax = j;

                }
            }
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int maxi = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int imax = 0;
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, imax])
                {
                    imax = j;
                }
            }
            if (i % 2 == 0)
            {
                maxi = imax;
            }
            else
            {
                var temp = B[i - 1, maxi];
                B[i - 1, maxi] = B[i, imax];
                B[i, imax] = temp;
            }
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

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - j - 1]) = (A[i, A.GetLength(1) - j - 1], A[i, j]);
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return default;
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            int ind = 0, mini = 1000000000;
            for (int j = 1; j < m; j++)
                if (matrix[i, j] < mini)
                {
                    mini = matrix[i, j];
                    ind = j;
                }
            a[i] = matrix[i, ind];
        }
        for (int x = 1; x < n; x++)
        {
            int i = x;
            while (i > 0 && a[i - 1] < a[i])
            {
                int temp = a[i - 1];
                a[i - 1] = a[i];
                a[i] = temp;
                for (int j = 0; j < m; j++)
                {
                    temp = matrix[i - 1, j];
                    matrix[i - 1, j] = matrix[i, j];
                    matrix[i, j] = temp;
                }
                i--;
            }
        }
        // end

        return matrix;
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
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || matrix.GetLength(1) == 0 || matrix.GetLength(0) == 0) return default;
        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];
     
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int ind = j - i + (n - 1);
                answer[ind] += matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k < 1) return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]])) { max[0] = i; max[1] = j; }

        if (max[1] != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
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
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int index = 0;
        bool nul = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != 0 || B[i] != 0)
                nul = true;
        }
        if (nul == false)
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
        int sum;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                answer[index++] = sum;
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
        int n = 5, m = 7;
        if ((matrix.GetLength(0) != n && matrix.GetLength(0) != m) || matrix == null) return null;
        int[] cnt = new int[m];
        for (int j = 0; j < m; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) count++;

            cnt[j] = count;
        }

        for (int i = 0; i < m; i++)
            for (int j = 0; j < m - i - 1; j++)
                if (cnt[j] > cnt[j + 1])
                {
                    int temp = cnt[j];
                    cnt[j] = cnt[j + 1];
                    cnt[j + 1] = temp;
                    for (int k = 0; k < n; k++)
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
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
        int z = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    z--;
                    matrix[i, 0] = 0;
                    break;
                }
            }
        }
        int[,] A = new int[z, m];
        int q = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, 0] != 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[q, j] = matrix[i, j];
                }
                q++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}