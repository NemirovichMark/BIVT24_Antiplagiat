using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json.Serialization;
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
        double s = 0;
        int k = 0;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        for (int i = 0;i<A.GetLength(0);i++)
            for (int j = 0;j < A.GetLength(1);j++)
            {
                if (A[i,j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }
        if (k == 0) return 0;
        answer = s / k;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0,0);
        for (int i = 0;i < A.GetLength(0);i++)
        {
            if (A[i,colIndex] < 0)
            {
                value  = A[i,colIndex];
                rowIndex = i;
                break;
            }
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return default(double[]);
        double[] B = new double[A.GetLength(0)];
        for(int i = 0;i < A.GetLength(0);i++)
        {
            double a = 0,s = 0;
            int k = 0;
            for(int j = 0;j < A.GetLength(1);j++)
            {
                if (A[i,j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
                if (k != 0) a = s / k;
            }
            B[i] = a;
        }
        answer = B;
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
        if (A.GetLength(0) <= 2) return default(int[,]);
        int mi = A[0, 0], k = 0;
        for (int i = 0;i < A.GetLength(0);i++)
        {
            if (A[i,0] < mi)
            {
                mi = A[i,0];
                k = i;
            }
        }
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0)-1; i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (i < k) B[i, j] = A[i, j];
                else B[i, j] = A[i + 1, j];
        A = B;
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
        int k = 0;
        if (A.GetLength(0) == 0 || A.GetLength(1) == 0) return answer;
        answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1);j++)
        {
            int m = 0;
            for(int i = 0;i < A.GetLength(0);i++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                    m++;
                }
            }
            answer[j] = m;
        }
        if (k == 0) return default(int[]);
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
        if (m <= 0 || n <= 0) return default(int[,]);
        for ( int i = 0;i<n;i++)
        {
            int mi = B[i, 0], k = -1;
            for (int j = 0;j < m;j++)
            {
                if (B[i,j] < mi)
                {
                    mi = B[i,j];
                    k = j;
                }
            }
            if (k != -1)
            {
                for ( int p = k;p > 0; p--) B[i,p] = B[i,p-1];
                B[i, 0] = mi;
            }
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
        if (n == 0 || m == 0) return default (double[,]);
        for( int i = 0;i < n;i++)
        {
            double mi1 = 0,mi2 = 0,ma = F[i,0];
            int k = 0;
            for ( int j = 0; j < m;j++)
            {
                if (F[i,j] > ma)
                {
                    ma = F[i,j];
                    k = j;
                }
                if (F[i, j] < 0 && mi1 == 0) mi1 = F[i, j];
                if (F[i,j] < 0 && mi1 != 0) mi2 = F[i, j];
            }
            if (mi1 != 0 && mi2 != 0) F[i, k] = (mi1 + mi2) / 2;
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
        if (G.GetLength(0) < 3) return default(int[,]);
        for ( int i = 0;i < G.GetLength(0);i++)
        {
            int ma = G[i,0], k = 0;
            for ( int j = 0;j < G.GetLength(1);j++)
            {
                if (ma < G[i,j])
                {
                    ma = G[i,j];
                    k = j;
                }
            }
            if (k == G.GetLength(1) - 2) G[i, G.GetLength(1) - 1] = ma;
            else
            {
                for (int t = G.GetLength(1) - 1; t > k; t--)
                {
                    G[i, t] = G[i, t - 1];
                }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return default(int[,]);
        int ma = A[0, 5], k = 0;
        for(int i = 0;i < A.GetLength(0);i++)
        {
            if (A[i,5] > ma)
            {
                ma = A[i, 5];
                k = i;
            }
        }
        for(int j = 0;j < A.GetLength(1);j++)
        {
            A[k, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return default(int[,]);
        int mi = F[0, 0],k = 0;
        for(int j = 0;j < F.GetLength(1);j++)
        {
            if (F[2,j] < mi)
            {
                mi = F[2,j];
                k = j;
            }
        }
        k++;
        int[,] A = new int[F.GetLength(0),F.GetLength(1) - 1];
        for(int i = 0;i < F.GetLength(0);i++)
            for(int j = 0;j < k;j++)
                A[i,j] = F[i,j];
        for (int i = 0; i < F.GetLength(0); i++)
            for (int j = k; j < F.GetLength(1)-1; j++)
                A[i, j] = F[i, j + 1];
        F = A;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for( int i = 0;i < A.GetLength(0);i++)
        {
            double ma = A[i, 0],s = 0,a = 0;
            int ima = 0, k = 0;
            for ( int j = 0; j < A.GetLength(1); j++)
            {
                if (ma < A[i, j])
                {
                    ma = A[i, j];
                    ima = j;
                }
                if (A[i,j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
                if (k != 0) a = s / k;
            }
            A[i, ima] = a;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double ma = A[i, 0];
            int k = 0;
            for (int j = 0;j <  A.GetLength(1); j++)
            {
                if (ma < A[i,j])
                {
                    ma = A[i, j];
                    k = j;
                }
            }
            if (k == 0) A[i, k + 1] *= 2;
            else if (k == A.GetLength(1) - 1) A[i, k - 1] *= 2;
            else
            {
                if (A[i,k-1] >  A[i, k+1])
                {
                    if (A[i, k + 1] > 0) A[i, k + 1] *= 2;
                    else A[i, k + 1] /= 2;
                }
                else
                {
                    if (A[i,k-1] > 0) A[i,k-1] *= 2;
                    else A[i, k-1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default(int[,]);
        for(int j = 0;j < A.GetLength(1);j++)
        {
            int ma = A[0, j], p = 0, n = 0, k = 0;
            for(int i = 0;i < A.GetLength(0);i++)
            {
                if (A[i,j] > ma)
                {
                    ma = A[i,j];
                    k = i;
                }
                if (A[i, j] > 0) p++;
                else if (A[i, j] != 0) n++;
            }
            if (p > n) A[k, j] = 0;
            else A[k, j] = k+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return default(int[,]);
        for(int j = 0;j < A.GetLength(1);j++)
        {
            int s = 0, ma = A[0, j], k = 0;
            for(int i = 0;i < A.GetLength(0);i++)
            {
                s += A[i, j];
                if(A[i,j] > ma)
                {
                    ma = A[i,j];
                    k = i;
                    s = 0;
                }

            }
            if (k <= A.GetLength(0) / 2) A[0, j] = s;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if ( A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default(int[,]);
        for(int j = 0;j < A.GetLength(1);j++)
        {
            int ma = A[0,j], k = 0;
            for(int i = 0; i < A.GetLength(0);i++)
            {
                if (A[i,j] > ma)
                {
                    ma= A[i,j];
                    k = i;
                }
            }
            if (ma < B[j]) A[k, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default(double[,]);
        for(int j = 0;j < A.GetLength(1);j++)
        {
            double ma = A[0,j];
            int k = 0;
            for(int i = 0;i < A.GetLength(0);i++)
            {
                if (A[i,j] > ma)
                {
                    ma = A[i,j];
                    k = i;
                }
            }
            if (ma < (A[0, j] + A[A.GetLength(0)-1, j]) / 2) A[k, j] = (A[0, j] + A[A.GetLength(0)-1, j]) / 2;
            else A[k, j] = k+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3) return answer;
        int[,] A = new int[n, n * 3];
        for(int i = 0;i < A.GetLength(0);i++)
            for(int j = 0;j < A.GetLength(1);j++)
            {
                if (i == j || i == j - 3 || i == j - 6) A[i, j] = 1;
                else A[i,j] = 0;
            }
        answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return default(int[,]);
        int ma = A[0, 0], k = 0;
        for(int i = 0;i < A.GetLength(0);i++)
            if(A[i,i] > ma)
            {
                 ma = A[i,i];
                 k = i;
            }
        for (int i = 0; i < k; i++)
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < j) A[i, j] = 0;
            }
                // end

                return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default(int[,]);
        for(int i = 0;i < B.GetLength(0);i+=2)
        {
            int ma1 = B[i,0],ma2 = B[i+1,0],k1 = 0,k2 = 0;
            for (int j = 0;j < B.GetLength(1);j++)
            {
                if (B[i,j] > ma1)
                {
                    ma1 = B[i,j];
                    k1 = j;
                }
                if (B[i+1,j] > ma2)
                {
                    ma2 = B[i+1,j];
                    k2 = j;
                }
            }
            B[i, k1] = ma2;
            B[i + 1, k2] = ma1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default(int[,]);
        for (int i = 0; i < A.GetLength(0); i++)
            for(int j = 0; j < A.GetLength(1)/2;j++)
            {
                var p = A[i,j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = p;
            }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default(int[,]);
        int[] nm = new int[matrix.GetLength(0)];
        int[] knm = new int[matrix.GetLength(0)];
        for(int i = 0;i < matrix.GetLength(0);i++)
        {
            int mi = matrix[i, 0];
            knm[i] = i;
            for(int j = 0;j < matrix.GetLength(1);j++)
            {
                if (matrix[i,j] < mi)
                    mi = matrix[i,j];
            }
            nm[i] = mi;
        }
        for(int i = 1;i < matrix.GetLength(0);i++)
        {
            int key = nm[i];
            int ikey = knm[i];
            int j = i - 1;
            while(j >= 0 && nm[j] < key)
            {
                nm[j+1] = nm[j];
                knm[j+1] = knm[j];
                j -= 1;
            }
            nm[j+1] = key;
            knm[j + 1] = ikey;
        }
        int[,] tm = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int tk = knm[i];
            for (int j = 0; j < matrix.GetLength(1); j++)
                tm[i, j] = matrix[tk, j];
        }
        matrix = tm;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 3) return answer;
        answer = new int[matrix.GetLength(0) * 2 - 1];
        for(int i = 0; i < matrix.GetLength(0);i++)
            for(int j = 0;j < matrix.GetLength(1);j++)
            {
                int k = j - i + matrix.GetLength(0) - 1;
                answer[k] += matrix[i, j];
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
        if (k < 1 || k > matrix.GetLength(0)) return default(int[,]);
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 3) return default(int[,]);
        int ma = matrix[0, 0],ik = -1,jk = -1;
        for(int i = 0;i < matrix.GetLength(0);i++)
            for(int j = 0;j < matrix.GetLength(1);j++)
            {
                if (Math.Abs(matrix[i,j]) > Math.Abs(ma))
                {
                    ma = matrix[i, j];
                    ik = i;
                    jk = j;
                }
            }
        if (jk != k-1)
        {
            for(int i = 0;i < matrix.GetLength(0);i++)
            {
                var p = matrix[i,jk];
                matrix[i, jk] = matrix[i, k - 1];
                matrix[i,k-1] = p;
            }
        }
        if (ik != k - 1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                var p = matrix[ik, j];
                matrix[ik, j] = matrix[k-1, j];
                matrix[k-1, j] = p;
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
        int a = A.Length, b = B.Length;
        if (a != b || b == 0 || a == 0) return answer;

        int[,] GA = new int[n, n], GB = new int[n, n];
        answer = new int[n * n];
        int[] answer2 = new int[n * n];
        // code here
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++, c++)
            {
                GA[i, j] = A[c];
                GA[j, i] = A[c];
                GB[i, j] = B[c];
                GB[j, i] = B[c];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    answer[i * n + j] += GA[i, k] * GB[k, j];
                }

            }
        }
        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != 7 && AWeight != 5)
            return default(int[,]);

        int[] countPos = new int[AHeight];

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] > 0)
                {
                    countPos[i]++;
                }
            }
        }

        int maxVal = countPos[0], maxInd = 0;
        for (int i = 0; i < AHeight; i++)
        {
            if (countPos[i] > maxVal)
            {
                maxVal = countPos[i];
                maxInd = i;
            }
        }

        for (int i = 0; i < AHeight - 1; i++)
        {
            for (int j = 0; j < AHeight - i - 1; j++)
            {
                if (countPos[j] < countPos[j + 1])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int tempCount = countPos[j];
                    countPos[j] = countPos[j + 1];
                    countPos[j + 1] = tempCount;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return default(int[,]);
        int[] cn = new int[matrix.GetLength(1)];
        for(int j = 0; j < matrix.GetLength(1);j++)
            for(int i = 0;i < matrix.GetLength(0);i++)
            {
                if (matrix[i, j] < 0) cn[j]++;
            }
        int mi = cn[0], imi = 0;
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            if (cn[j] < mi)
            {
                mi = cn[j];
                imi = j;
            }
        }
        for(int j = 0;j < matrix.GetLength(1)-1;j++)
            for(int i = 0;i < matrix.GetLength(0)-j-1;j++)
            {
                if (cn[i] > cn[i+1])
                {
                    for(int k = 0;k < 5;k++)
                    {
                        var p = matrix[k, i];
                        matrix[k, i] = matrix[k, i + 1];
                        matrix[k, i + 1] = p;
                    }
                    var t = cn[i];
                    cn[i] = cn[i + 1];
                    cn[i + 1] = t;
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
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight < 2)
            return default(int[,]);

        int nonZeroRowsCount = 0;
        for (int i = 0; i < AHeight; i++) {
            bool hasZero = false;
            for (int j = 0; j < AWeight; j++){
                if (matrix[i, j] == 0) {
                    hasZero = true;
                    break; 
                }
            }
            
            if (hasZero == false)
                nonZeroRowsCount++; 
        }

        int[,] filteredMatrix = new int[nonZeroRowsCount, AWeight];
        int currentRow = 0;

        for (int i = 0; i < AHeight; i++){
            bool hasZero = false;

            for (int j = 0; j < AWeight; j++){
                if (matrix[i, j] == 0){
                    hasZero = true;
                    break; 
                }
            }
            if (hasZero == false){
                for (int j = 0; j < AWeight; j++){
                    filteredMatrix[currentRow, j] = matrix[i, j];
                }
                currentRow++;  
            }
        }
        matrix = filteredMatrix;
        // end

        return matrix;
    }
    #endregion
}