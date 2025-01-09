using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return 0;
        double count = 0;
        double s = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] != 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
        }
        answer = s / count;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1) return (0, 0);
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6 || A == null || A.GetLength(0) == 0)
            return null;
        int n = A.GetLength(0);
        answer = new double[n];
        for (int i = 0; i < n; i++)
        {
            double s = 0;
            double count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count == 0) answer[i] = 0;
            else answer[i] = s / count;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A == null || A.GetLength(0) == 0)
            return null;
        int mini = -1;
        int min = int.MaxValue;
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                mini = i;
            }
        }
        if (mini == -1) return A;
        int[,] b = new int[n - 1, m];
        for (int i = 0, g = 0; i < n; i++)
        {
            if (i != mini)
            {
                for (int j = 0; j < m; j++)
                {
                    b[g, j] = A[i, j];
                }
                g++;
            }

        }
        return b;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        answer = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int term = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                    term++;
            }
            answer[i] = term;
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
        int[,] A = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            int min = int.MaxValue;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                }
                A[i, 0] = min;
            }
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] == min) continue;
                A[i, k + 1] = B[i, j];
                k++;
            }
        }
        B = A;
        // end

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
        // code here
        for (int i = 0; i < n; i++)
        {
            int mini1 = -1, mini2 = -1;
            int maxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > F[i, maxi])
                    maxi = j;
            }
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0) 
                { 
                    mini1 = j; 
                    break; 
                }

            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    mini2 = j;
                    break;
                }
            }
            if (mini1 != -1 && mini2 != -1)
            {
                F[i, maxi] = (F[i, mini1] + F[i, mini2]) / 2;
            }
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return null;
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int maxi = 0;
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                if (G[i, j] > G[i, maxi])
                {
                    maxi = j;
                }
            }
            for (int j = G.GetLength(1) - 1; j > maxi ; j--)
            {
                G[i, j] = G[i, j - 1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A.GetLength(1) != B.Length)
            return null;
        int maxi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > A[maxi, 5]) maxi = i;
        }
        for (int i = 0; i < A.GetLength(1); i++)
            A[maxi, i] = B[i];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return null;
        int mini = 0;
        for (int i = 0; i < F.GetLength(1); i++)
        {
            if (Math.Abs(F[1, i]) < Math.Abs(F[1, mini]))
                mini = i;
        }
        int[,] matrix = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j <= mini; j++)
                {
                    matrix[i, j] = F[i, j];
                }
            for (int j = mini + 2; j < F.GetLength(1); j++)
                matrix[i, j - 1] = F[i, j];

        }
        F = matrix;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        double[,] B = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double s = 0;
            int count = 0, imax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count > 0) s = s / count;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, imax])
                { 
                    imax = j; 
                }
            }
            A[i, imax] = s;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxi = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxi]) maxi = j;
            }
            int index;
            if (maxi == 0) index = 1;
            else if (maxi == A.GetLength(1) - 1) index = A.GetLength(1) - 2;
            else
            {
                if (A[i, maxi - 1] < A[i, maxi + 1]) 
                    index = maxi - 1;
                else
                    index = maxi + 1;
            }
            if (A[i, index] < 0) A[i, index] /= 2;
            else
                A[i, index] *= 2;
        }
        //for (int j = 0; j < A.GetLength(1); j++)
        //{
        //    if (A[i, maxi - 1] > A[i, maxi + 1]) A[i, maxi + 1] *= 2;
        //    if (A[i, maxi - 1] < A[i, maxi + 1]) A[i, maxi - 1] *= 2;
        //    if (maxi == 0) A[i, maxi + 1] *= 2;
        //    if (maxi == A.GetLength(1)) A[i, maxi - 1] *= 2;
        //}
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int count1 = 0, count2 = 0; 
            int maxi = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > A[maxi, i]) maxi = j;
                if (A[j, i] > 0) count1++;
                else if (A[j, i] < 0) count2++;
            }
            if (count1 > count2) A[maxi, i] = 0;
            else A[maxi, i] = maxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxi, j]) maxi = i;
            }
            if (maxi < A.GetLength(0) / 2)
            {
                int s = 0;
                for (int i = maxi + 1; i < A.GetLength(0); i++)
                    s += A[i, j];
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A.GetLength(1) != B.Length)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxi, j])
                    maxi = i;
            }
            if (B[j] > A[maxi, j])
                A[maxi, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxi, j])
                    maxi = i;
            }
            double s = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (A[maxi, j] < s) A[maxi, j] = s;
            else A[maxi, j] = maxi + 1;
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
            return null;
        int maxi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > A[maxi, maxi]) maxi = i; 
     
        }
        for (int i = 0; i < maxi; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        int[] A = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int maxi = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, maxi]) maxi = j; 
            }
            A[i] = maxi;
        }
        for (int i = 0; i < B.GetLength(0); i+=2)
        {
            int temp = B[i, A[i]];
            B[i, A[i]] = B[i + 1, A[i + 1]];
            B[i + 1, A[i + 1]] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < (A.GetLength(1) / 2); j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = temp;
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
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
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
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int a = matrix.GetLength(0);
        for (int i = a / 2; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j > i) break;
                matrix[i, j] = 1;
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
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2];
        lower = new int[n * (n - 1) / 2];
        int i1 = 0, i2 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= i) upper[i1++] = matrix[i, j];
                if (j < i) lower[i2++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5)
            return null;
        int[] A = new int[matrix.GetLength(0)];
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0) count++;
            }
            A[i] = count;
        }
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int key = A[i], j = i - gap;
                while (j >= 0 && A[j] > key)
                {
                    A[j + gap] = A[j];
                    j -= gap;
                }
                A[j + gap] = key;
            }
            gap /= 2;
        }
        int[,] ans = new int[7, 5];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int count = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[j, k] < 0) count++;
                }
                if (count == A[i])
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        ans[i, k] = matrix[j, k];
                        matrix[j, k] = 0;
                    }
                    break;
                }
            }
        }
        matrix = ans;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 || matrix == null)
            return null;
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            int[] temp = new int[m];
            for (int j = 0; j < m; j++)
            {
                temp[j] = matrix[i, j];
            }
            if (i % 2 == 0)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    for (int k = 0; k < m - j - 1; k++)
                        if (temp[k] < temp[k + 1])
                        {
                            int t = temp[k];
                            temp[k] = temp[k + 1];
                            temp[k + 1] = t;
                        }

                }
            }
            else
            {
                for (int j = 0; j < m - 1; j++)
                {
                    for (int k = 0; k < m - j - 1; k++)
                    {
                        if (temp[k] > temp[k + 1])
                        {
                            int t = temp[k];
                            temp[k] = temp[k + 1];
                            temp[k + 1] = t;
                        }
                    }
                }
            }
            for (int j = 0; j < m; j++)
                matrix[i, j] = temp[j] ;
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int ans = n;
        int l = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) count++;
            }
            if (count > 0) ans--;
        }
        int[,] A = new int[ans, m];
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) count++;
            }
            if (count <= 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[l, j] = matrix[i, j];
                }
                l++;
            }

        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}
