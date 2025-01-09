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

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6)
        {
            return (0, 0);
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < A[row, col])
                {
                    row = i; col = j;
                }
            }
        }
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

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        answer = new int[5];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;

        }
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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int maxind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[maxind, 2] < A[i, 2])
            {
                maxind = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            (A[maxind, j], A[3, j]) = (A[3, j], A[maxind, j]);
        }
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

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }
        int maxind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[maxind, maxind] < A[i, i])
            {
                maxind = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            (A[i, maxind], A[i, 3]) = (A[i, 3], A[i, maxind]);
        }
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

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int maxind = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > A[i, maxind]) maxind = j;
            }
            for (int j = maxind; j < m - 1; j++)
            {
                if (A[i, j] > A[i, j + 1])
                {
                    (A[i, j], A[i, j + 1]) = (A[i, j + 1], A[i, j]);
                }
            }
        }
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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        if (C.GetLength(0) != n || C.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int maxind = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > C[i, maxind]) maxind = j;
            }
            for (int j = 0; j < maxind; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] /= C[i, maxind];
                }
            }
        }
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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here
        if (Z == null || Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        int maxr = 0;
        int maxc = 0;
        double sump = 0;
        double cnt = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    cnt++;
                    sump += Z[i, j];
                }
                if (Z[i, j] > Z[maxr, maxc])
                {
                    maxr = i; maxc = j;
                }
            }
        }
        sump /= cnt;
        Z[maxr, maxc] = sump;
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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }
        int indmax = 0;
        int indmin = 0;
        int[] a = new int[6];
        for (int i = 0; i < 6; i++)
        {
            int cnt = 0;
            for (int j = 0;j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    cnt++;
                }
            }
            a[i] = cnt;
        }
        for (int i = 0; i < 6; i++)
        {
            if (a[i] > a[indmax])
            {
                indmax = i;
            } else if (a[i] < a[indmin])
            {
                indmin = i;
            }
        }
        for (int j = 0; j < 5; j++)
        {
            (X[indmax, j], X[indmin, j]) = (X[indmin, j], X[indmax, j]);
        }
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int[,] B = new int[6, 5];
        int indmax = 0;
        int max = int.MinValue;
        for (int i = 0; i < 7; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i,j];
                }
            }
            if (sum > max)
            {
                max = sum;
                indmax = i;
            }
        }
        int ind = 0;
        for (int i = 0; i < 7; i++)
        {
            if (i == indmax) continue;
            for (int j = 0; j < 5; j++)
            {
                B[ind, j] = A[i, j];
            }
            ind++;
        }

        // end

        return B;
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
        {
            return null;
        }
        int minp = 0;
        for (int j = 0; j < 8; j++)
        {
            if (A[4, j] < A[4, minp]) minp = j;
        }
        for (int j = minp + 1; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                A[i, j + 1] = A[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            A[i, minp + 1] = B[i];
        }
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
        double l, r;
        for (int i = 0; i < 5; i++)
        {
            int indmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[i, indmax]) indmax = j;
            }
            if (indmax == 6 && A[i, 5] >= 0) A[i, 5] *= 2;
            if (indmax == 6 && A[i, 5] < 0) A[i, 5] /= 2;
            if (indmax == 0 && A[i, 1] >= 0) A[i, 1] *= 2;
            if (indmax == 0 && A[i, 1] < 0) A[i, 1] /= 2;
            if (indmax > 0 && indmax < 6)
            {
                l = A[i, indmax - 1];
                r = A[i, indmax + 1];
                if (l > r)
                {
                    if (r > 0) A[i, indmax + 1] *= 2;
                    if (r < 0) A[i, indmax + 1] /= 2;
                }
                else if (r > l)
                {
                    if (l > 0) A[i, indmax - 1] *= 2;
                    if (l < 0) A[i, indmax - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int cntpos = 0;
            int cntneg = 0;
            int indmax = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[indmax, j]) indmax = i;
                if (A[i, j] > 0) cntpos++;
                if (A[i, j] < 0) cntneg++;
            }
            if (cntpos > cntneg)
            {
                A[indmax, j] = 0;
            } else
            {
                A[indmax, j] = indmax + 1;
            }
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
        for (int j = 0; j < 5; j++)
        {
            int indmax = 0;
            int sum = 0;
            for (int i = 0;i < 10; i++)
            {
                if (A[i,j] > A[indmax,j]) indmax = i;
            }
            if (indmax <= 4)
            {
                for (int i = indmax + 1; i < 10; i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int indmax = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[indmax,j]) indmax = i;
            }
            if (B[j] > A[indmax, j]) A[indmax, j] = B[j];
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
        for (int j = 0; j < 5; j++)
        {
            int indmax = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[indmax, j]) indmax = i;
            }
            double ps = (A[0, j] + A[6, j]) / 2.0;
            if (A[indmax, j] < ps) A[indmax, j] = ps;
            else A[indmax, j] = indmax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        //int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        int[,] answer = new int[n, 3*n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if ((j - i) % n == 0) answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 6) return null;
        int indmax = 0;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > A[indmax, indmax]) indmax = i;
        }
        for (int i = 0; i < indmax; i++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int i = 0; i < 6; i+=2)
        {
            int indmax = 0;
            int indmax2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > B[i, indmax]) indmax = j;
                if (B[i + 1, j] > B[i + 1, indmax2]) indmax2 = j;
            }
            (B[i, indmax], B[i + 1, indmax2]) = (B[i + 1, indmax2], B[i, indmax]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7 / 2; j++)
            {
                (A[i, j], A[i, 6 - j]) = (A[i, 6 - j], A[i, j]);
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
        int m = matrix.GetLength(1);
        if (n != m) return null;
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[n - 1, i] = 0;
            matrix[i, n - 1] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j > i) continue;
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
        
        // code here

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] upper = new int[(n*n - n) / 2 + n];
        int[] lower = new int[(n * n - n) / 2];
        if (n != m) return (null, null);
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++) upper[cnt++] = matrix[i, j];
        }
        cnt = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++) lower[cnt++] = matrix[i, j];
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != 7 || m != 5) return null;
        int[] pos = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0) pos[i]++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (pos[j + 1] > pos[j])
                {
                    for (int k = 0; k < m; k++)
                    {
                        (matrix[j, k], matrix[j + 1, k]) = (matrix[j + 1, k], matrix[j, k]);
                    }

                    (pos[j], pos[j + 1]) = (pos[j + 1], pos[j]);
                }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++) { 
            if (i % 2 == 0)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < m - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1]) (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                    }
                }
            } else
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < m - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1]) (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int cnt = n;
        int[] del = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    del[i] = 1;
                    cnt--;
                    break;
                }
            }
        }
        int[,] answer = new int[cnt, m];
        cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (del[i] == 1) continue;
            for (int j = 0; j < m; j++)
            {
                answer[cnt, j] = matrix[i, j];
            }
            cnt++;
        }
        // end

        return answer;
    }
    #endregion
}