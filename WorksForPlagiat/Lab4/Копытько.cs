using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
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

        for (int i = 0; i < A.GetLength(0); i ++)
        {
            answer += A[i, i];
        }
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

        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int[] indexes = new int[4];
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int mni = 0;
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i, j] < A[i, mni]) mni = j;
            }
            indexes[i] = mni;
        }
        answer = indexes;
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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int mxi = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, mxi]) mxi = j;
            }
            int temp = A[i, mxi];
            A[i, mxi] = A[i, 0];
            A[i, 0] = temp;
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

        if ((A.GetLength(0) != 6 || A.GetLength(1) != 7)) return null;
        int[,] A1 = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        int mxi = 0, mxj = 0;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[mxi, mxj] <= A[i, j])
                {
                    mxi = i;
                    mxj = j;
                }
            }
        }
        int i1 = 0, j1 = 0;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            if (i != mxi)
            {
                j1 = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (j != mxj)
                    {
                        A1[i1, j1] = A[i, j];
                        j1++;
                    }
                }
                i1++;
            }
        }
        A = A1;
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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int mxi = 0;
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i, j] > A[i, mxi]) mxi = j;
            }
            A[i, mxi] *= i + 1;
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

        for (int i = 0; i < n; i ++)
        {
            int fs = -1, ls = -1, mxi = 0;
            for (int j = 0; j < m; j ++)
            {
                if (D[i, j] < 0)
                {
                    if (fs == -1) fs = j;
                    ls = j;
                }
            }
            for (int j = 0; j < fs; j ++)
            {
                if ((D[i, j] > D[i, mxi])) mxi = j;
            }
            if (fs != -1 && mxi != fs)
            {
                int temp = D[i, ls];
                D[i, ls] = D[i, mxi];
                D[i, mxi] = temp;
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
        // code here

        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i < H.GetLength(0); i ++)
        {
            int mxi = 0;
            for (int j = 0; j < H.GetLength(1) - 1; j ++)
            {
                if (H[i,j] > H[i, mxi]) mxi = j;
            }
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength (1) - 2];
            H[i, H.GetLength(1) - 2] = H[i, mxi];
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

        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i = 0; i < Y.GetLength(0); i ++)
        {
            int mxi = 0;
            for (int j = 0; j < Y.GetLength(1); j ++)
            {
                if (Y[i, j] > Y[i, mxi]) mxi = j;
            }
            double smP = 0, pKlv = 0; 
            for (int j = mxi + 1; j < Y.GetLength(1); j ++)
            {
                if (Y[i, j] > 0)
                {
                    pKlv++;
                    smP += Y[i, j];
                }
            }
            if (pKlv  > 0) smP /= pKlv;
            for (int j = 0; j < mxi; j ++)
            {
                if (Y[i, j] < 0) Y[i, j] = smP;
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

        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        int[] maxElements = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i  ++)
        {
            int mxi = 0;
            for (int j = 0; j < B.GetLength(1); j ++)
            {
                if (B[i, j] > B[i, mxi]) mxi = j;
            }
            maxElements[B.GetLength(0) - 1 - i] = B[i, mxi];
        }
        for (int i = 0; i < B.GetLength(0); i ++)
        {
            B[i, 3] = maxElements[i];
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

        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int mxi = 0, fsi = -1;
        for (int i = 0; i < B.GetLength(0); i ++)
        {
            if (B[i, i] > B[mxi, mxi]) mxi = i;
            if (B[i, 2] < 0 && fsi == -1) fsi = i;
        }
        if (fsi != -1)
        {
            for (int j = 0; j < B.GetLength(1); j ++)
            {
                int temp = B[mxi, j];
                B[mxi, j] = B[fsi, j];
                B[fsi, j] = temp;
            }
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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[] negatives = new int[0];
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    int[] n1 = new int[negatives.Length + 1];
                    n1[negatives.Length] = A[i, j];
                    for (int k = 0; k < negatives.Length; k++)
                    {
                        n1[k] = negatives[k];
                    }
                    negatives = n1;

                }
            }
        }
        answer = negatives;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int mxi = 0;
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i, mxi] < A[i, j]) mxi = j;
            }
            if (mxi == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (mxi == A.GetLength(1))
            {
                if (A[i, A.GetLength(1) - 1] > 0) A[i, A.GetLength(1) - 1] *= 2;
                else A[i, A.GetLength(1) - 1] /= 2;
            }
            else
            {
                if ((A[i, mxi - 1] < A[i, mxi + 1]))
                {
                    if (A[i, mxi - 1] > 0) A[i, mxi - 1] *= 2;
                    else A[i, mxi - 1] /= 2;
                }
                else if (A[i, mxi + 1] > 0) A[i, mxi + 1] *= 2;
                else A[i, mxi + 1] /= 2;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j ++)
        {
            int klv1 = 0, klv2 = 0, mxi = 0;
            for (int i = 0; i < A.GetLength(0); i ++)
            {
                if (A[i, j] > 0) klv1++;
                else if (A[i, j] < 0) klv2++;
                if (A[mxi, j] < A[i, j]) mxi = i;
            }
            if (klv1 > klv2) A[mxi, j] = 0;
            else A[mxi, j] = mxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mxi = 0, sm = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[mxi, j] < A[i, j]) mxi = i;
            }
            if (mxi < A.GetLength(0) / 2)
            {
                for (int i = mxi + 1; i < A.GetLength(0); i ++)
                {
                    sm += A[i, j];
                }
                A[0, j] = sm;
            } 
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j ++)
        {
            int mxi = 0;
            for (int i = 0; i < A.GetLength(0); i ++)
            {
                if (A[i, j] > A[mxi, j]) mxi = i;
            }
            if (A[mxi, j] < B[j]) A[mxi, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j ++)
        {
            double p = (A[0, j] + A[A.GetLength(0) - 1, j]);
            int mxi = 0;
            for (int i = 0; i < A.GetLength(0); i ++)
            {
                if (A[i, j] > A[mxi, j]) mxi = i;
            }
            if (A[mxi, j] < p) A[mxi, j] = p;
            else A[mxi, j] = mxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0) return null;
        int[,] answer1 = new int[n, 3 * n];
        for (int i = 0; i < n; i ++)
        {
            answer1[i, i] = 1;
            answer1[i, i + n] = 1;
            answer1[i, i + 2 * n] = 1;
        }
        answer = answer1;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int mxi = 0;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            if (A[i, i] > A[mxi, mxi]) mxi = i;
        }
        for (int i = 0; i < mxi; i ++)
        {
            for (int j = i + 1; j < A.GetLength(1); j ++)
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
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int mxi1 = 0, mxi2 = 0;
            for (int j = 0; j < B.GetLength(1); j ++)
            {
                if (B[i, mxi1] < B[i, j]) mxi1 = j;
                if (B[i + 1, mxi2] < B[i + 1, j]) mxi2 = j;
            }
            int temp = B[i, mxi1];
            B[i, mxi1] = B[i + 1, mxi2];
            B[i + 1, mxi2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j ++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = temp;
            }
        }
        // end

        return A;
    }
    #endregion

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

        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;
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
        for (int i = (int)Math.Floor((double)(matrix.GetLength(0) / 2)); i < matrix.GetLength(0); i ++)
        {
            for (int j = 0; j <= i; j ++)
            {
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

        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int[] u1 = new int[0];
        int[] l1 = new int[0];
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = 0; j < matrix.GetLength(1); j ++)
            {
                if (i > j)
                {
                    int[] l2 = new int[l1.Length + 1];
                    l2[l1.Length] = matrix[i, j];
                    for (int k = 0; k < l1.Length; k ++)
                    {
                        l2[k] = l1[k];
                    }
                    l1 = l2;
                }
                else
                {
                    int[] u2 = new int[u1.Length + 1];
                    u2[u1.Length] = matrix[i, j];
                    for (int k = 0; k < u1.Length; k++)
                    {
                        u2[k] = u1[k];
                    }
                    u1 = u2;
                }
            }
            upper = u1;
            lower = l1;
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

        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] klvs = new int[7];
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            int klv = 0;
            for (int j = 0; j < matrix.GetLength(1); j ++)
            {
                if (matrix[i, j] > 0) klv++;
            }
            klvs[i] = klv;
        }
        foreach (int current in klvs)
        {
            Console.WriteLine(current);
        }
        for (int i = 1, j = 2; i < klvs.Length;)
        {
            if (i == 0 || klvs[i] <= klvs[i-1])
            {
                i = j;
                j++;
            }
            else
            {
                for (int k = 0; k < matrix.GetLength(1); k ++)
                {
                    int temp1 = matrix[i, k];
                    matrix[i, k] = matrix[i - 1, k];
                    matrix[i - 1, k] = temp1;
                }
                int temp = klvs[i];
                klvs[i] = klvs[i - 1];
                klvs[i - 1] = temp;
                i--;
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

        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = 1, j1 = 2; j < matrix.GetLength(1);)
            {
                if (j == 0 || ((i % 2 == 0 && matrix[i, j] <= matrix[i, j - 1]) || (i % 2 == 1 && matrix[i, j] >= matrix[i, j - 1])))
                {
                    j = j1;
                    j1 ++;
                }
                else
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                    j --;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        int[,] m1 = new int[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool fl = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) fl = false;
            }
            if (fl == true)
            {
                int[,] m2 = new int[m1.GetLength(0) + 1, matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j ++)
                {
                    m2[m1.GetLength(0), j] = matrix[i, j];
                }
                for (int k = 0; k < m1.GetLength(0); k ++)
                {
                    for (int j = 0; j <  m1.GetLength(1); j ++)
                    {
                        m2[k, j] = m1[k, j];
                    }
                }
                m1 = m2;
            }
        }
        matrix = m1;
        // end

        return matrix;
    }
    #endregion
}