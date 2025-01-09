using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
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
        double count = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    count++;
                }
            }
        }
        if (count == 0) return answer;
        answer /= count;
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
        if (A.GetLength(1) < colIndex) return (value, 0);
        int ind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1) return (value, 0);
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        double[] answer = new double[A.GetLength(0)];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double count = 0; 
            double am = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    count++;
                    am += A[i, j];
                }
            }
            if (count == 0) answer[i] = 0;
            else
                answer[i] = am / count;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int min = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < A[min, 0]) min = i;
        }
        for (int i = 0; i < min; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                answer[i, j] = A[i, j];
        }
        for (int i = min + 1; i < A.GetLength(0); i++)
        {
            for (int j = 0;  j < A.GetLength(1); j++)
                answer[i-1,j] = A[i, j];
        }
        // end

        return answer;
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
        // code here
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
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int min = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < B[i, min]) min = j;
            }
            for (int h = min; h > 0; h--)
                (B[i, h], B[i, h - 1]) = (B[i, h - 1], B[i, h]);
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
        for (int i = 0; i < F.GetLength(0); i++)
        {
            int indmax = 0;
            int first = -1;
            int last = -1;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < 0)
                {
                    first = j;
                    break;
                }
            }
            for (int j = F.GetLength(1) - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    last = j;
                    break;
                }
            }
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > F[i, indmax]) indmax = j;
            }
            if (first != -1) F[i, indmax] = (F[i, first] + F[i, last]) / 2;
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
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int indmax = 0;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > G[i, indmax]) indmax = j;
            }
            for (int j = G.GetLength(1) - 1; j > indmax; j--)
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
        int indmax = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return null;
        indmax = 0;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            if (A[j, 5] > A[indmax, 5]) indmax = j;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[indmax, i] = B[i];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        int indmin = 0;
        for (int i = 1; i < F.GetLength(1); i++)
        {
            if (Math.Abs(F[1, indmin]) > Math.Abs(F[1, i])) indmin = i;
        }
        if (indmin == F.GetLength(1) - 1) return F;
        int[,] answer = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j <= indmin; j++)
            {
                answer[i, j] = F[i, j];
            }
            for (int j = indmin + 2; j < F.GetLength(1); j++)
            {
                answer[i, j - 1] = F[i, j];
            }
        }
        // end

        return answer;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int indmax = 0;
            double am = 0;
            double count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, indmax]) indmax = j;
                if (A[i, j] > 0)
                {
                    am += A[i, j];
                    count++;
                }
            }
            if (count == 0) am = 0;
            else am /= count;
            A[i, indmax] = am;
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
            int indmax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, indmax] < A[i, j]) indmax = j;
            }
            int ind = 0;
            if (indmax == 0) ind = 1;
            else if (indmax == A.GetLength(1) - 1) ind = A.GetLength(-1) - 2;
            else
            {
                if (A[i, indmax - 1] < A[i, indmax + 1]) ind = indmax - 1;
                else ind = indmax + 1;
            }
            if (A[i, ind] < 0) A[i, ind] /= 2;
            else A[i, ind] *= 2;
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indmax = 0;
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indmax, j]) indmax = i;
                if (A[i, j] > 0) pos++;
                if (A[i, j] < 0) neg++;
            }
            if (pos > neg) A[indmax, j] = 0;
            else A[indmax, j] = indmax + 1;
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
            int indmax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[indmax, j] < A[i, j]) indmax = i;
            }
            if (indmax < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = indmax + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indmax = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[indmax, j] < A[i, j]) indmax = i;
            }
            if (A[indmax, j] < B[j]) A[indmax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indmax = 0;
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[indmax, j] < A[i, j]) indmax = i;
            }
            double halfS = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (A[indmax, j] < halfS) A[indmax, j] = halfS;
            else A[indmax, j] = indmax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, n + i] = 1;
            answer[i, n + n + i] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int indmax = 0;
        for (int i = 1; i < Math.Min(A.GetLength(0), A.GetLength(1)); i++)
        {
            if (A[indmax, indmax] < A[i, i]) indmax = i;
        }
        for (int i = 0; i < indmax; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++) A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int[] max = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int indmax = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, indmax] < B[i, j]) indmax = j;
            }
            max[i] = indmax;
        }
        for (int i = 0; i < B.GetLength(0) - 1; i += 2)
        {
            (B[i, max[i]], B[i + 1, max[i + 1]]) = (B[i + 1, max[i + 1]], B[i, max[i]]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - 1 - j]) = (A[i, A.GetLength(1) - 1 - j], A[i, j]);
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[0, i] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
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
            for (int j = 0; j <= i; j++)
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
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int n = matrix.GetLength(0);
        int[] upper = new int[n * (n + 1) / 2];
        int[] lower = new int[n * (n - 1) / 2];
        int indUp = 0, indDown = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i > j) lower[indDown++] = matrix[i, j];
                else upper[indUp++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[,] ind = new int[matrix.GetLength(0), 2];
        int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            ind[i, 0] = i;
            ind[i, 1] = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) ind[i, 1]++;
            }
            int curind = i;
            while (curind > 0 && ind[curind, 1] > ind[curind - 1, 1])
            {
                (ind[curind, 1], ind[curind - 1, 1]) = (ind[curind - 1, 1], ind[curind, 1]);
                (ind[curind, 0], ind[curind - 1, 0]) = (ind[curind - 1, 0], ind[curind, 0]);
                curind--;
            }

        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[i, j] = matrix[ind[i, 0], j];
            }
        }
            
        // end

        return answer;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i += 2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int l = 0; l < matrix.GetLength(1) - j - 1; l++)
                {
                    if (matrix[i, l] < matrix[i, l + 1])
                        (matrix[i, l], matrix[i, l + 1]) = (matrix[i, l + 1], matrix[i, l]);
                }
                    
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i += 2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int l = 0; l < matrix.GetLength(1) - j - 1; l++)
                {
                    if (matrix[i, l] > matrix[i, l + 1]) 
                        (matrix[i, l], matrix[i, l + 1]) = (matrix[i, l + 1], matrix[i, l]);
                }
                    
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    c++;
                    break;
                }
            }
        }
        int[,] answer = new int[matrix.GetLength(0) - c, matrix.GetLength(1)];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) break;
                answer[count, j] = matrix[i, j];
            }
            count++;
            if (count >= matrix.GetLength(0) - c) break;
        }
        // end

        return answer;
    }
    #endregion
}