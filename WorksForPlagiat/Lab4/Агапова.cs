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
        int sum1 = 0;
        for(int i = 0; i < A.GetLength(0); i++)
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
        // code here
        int[] answer = new int[A.GetLength(0)];
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 7) { return null; }
        for(int i = 0; i < A.GetLength(0); i++)
        {
            int min = 10000;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] < min) { min = j; }
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
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        for(int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i,0], maxint = 0;
            for(int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] > max) { max = A[i, j]; maxint = j; }
            }
            if (maxint != 0)
            {
                int zag = A[i, 0];
                A[i, 0] = A[i, maxint];
                A[i, maxint] = zag;
            }
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
        int max = A[0, 0];
        int in1 = 0;
        int in2 = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max) {max = A[i, j];in1 = i;in2 = j;}
            }
        }
        int[,] ans = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0, ni = 0; i < A.GetLength(0); i++)
        {
            if (i == in1) { continue; }
            for (int j = 0, nj = 0; j < A.GetLength(1); j++)
            {
                if (j == in2) { continue; }
                ans[ni, nj] = A[i, j];
                nj++;
            }
            ni++;
        }
        // end
        return ans;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0], in1 = 0, in2 = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max) { max = A[i, j]; in2 = j; in1 = i; }
            }
            A[in1, in2] *= i+1;
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
        if (D == null || D.GetLength(0) != n || D.GetLength(1) != m) { return null; }
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = -10000, inmax = -1, inot = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0) { break; }
                if (D[i, j] > max) { max = D[i, j]; inmax = j; }
            }
            for (int j1 = m-1; j1 >= 0; j1--)
            {
                if (D[i, j1] < 0) { inot = j1; break; }
            }
            if (inmax != -1 && inot != -1)
            {
                int zag = D[i, inmax];
                D[i, inmax] = D[i, inot];
                D[i, inot] = zag;
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
        if (H == null || H.GetLength(0) != 5 || H.GetLength(1) != 7) { return null; }
        for(int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0], maxin = 0;
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i, j] > max) { max = H[i, j]; maxin = j; }
            }
            if(maxin != -1)
            {
                int zag = max;
                H[i, 6] = H[i, 5];
                H[i, 5] = zag; 
            }
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
        for(int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0]; int maxin = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max) { max = Y[i, j]; maxin = j; }
            }
            double sred = 0; int count = 0;
            for (int j = maxin+1; j < Y.GetLength(1); j++)
            {
                if(Y[i, j] > 0) { sred += Y[i, j]; count++; }
            }
            if (count != 0) { sred = sred / count; }
            for(int j = maxin-1; j >= 0; j--)
            {
                if(Y[i, j] < 0)
                {
                    Y[i, j] = sred;
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
        int[] forstrok = new int[5]; int a = 0;
        for (int i = B.GetLength(0)-1; i >= 0; i--)
        {
            int max = B[i, 0], maxind = 0;
            for(int j = B.GetLength(1)-1; j >= 0; j--)
            {
                if (B[i, j] > max) { max = B[i, j]; maxind = j; }
            }
            forstrok[a] = B[i, maxind];
            a++;
        }
        int in1 = 0;
        for (int i1 = 0; i1 < B.GetLength(0); i1++)
        {
            B[i1, 3] = forstrok[in1];
            in1++;
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
        int max = B[0, 0], mind = 0, inot = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if(B[i, i] > max) { max = B[i, i]; mind = i; }
        }
        for(int j = 0; j<B.GetLength(0); j++)
        {
            if (B[j, 2] < 0) { inot = j; break; }
        }
        for(int k = 0; k < B.GetLength(1); k++)
        {
            int zag = B[mind, k];
            B[mind, k] = B[inot, k];
            B[inot, k] = zag;
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
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) { count++; }
            }
        }
        int[] answer = new int[count]; int in1 = 0;
        for (int k = 0; k < A.GetLength(0); k++)
        {
            for (int l = 0; l < A.GetLength(1); l++)
            {
                if (A[k, l] < 0) { answer[in1] = A[k, l]; in1++; }
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
            double max = -10000;
            int maxint = 0;
            for (int j = 0; j < A.GetLength(1); j++) { if (max < A[i, j]) { max = A[i, j]; maxint = j; } }
            if (maxint == 0) { if (A[i, maxint + 1] > 0) { A[i, maxint + 1] *= 2; } else { A[i, maxint + 1] /= 2; }; }
            else
            if (maxint == A.GetLength(1) - 1) { if (A[i, maxint - 1] > 0) { A[i, maxint - 1] *= 2; } else { A[i, maxint - 1] /= 2; }; }
            else
            {
                if (A[i, maxint - 1] < A[i, maxint + 1])
                {
                    if (A[i, maxint - 1] > 0) { A[i, maxint - 1] *= 2; } else { A[i, maxint - 1] /= 2; };
                }
                else
                {
                    if (A[i, maxint + 1] > 0) { A[i, maxint + 1] *= 2; } else { A[i, maxint + 1] /= 2; };
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
            int polcount = 0, otrcount = 0, max = -10000, maxin1 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) { polcount++; }
                if (A[i, j] < 0) { otrcount++; }
                if (A[i, j] > max) { max = A[i, j]; maxin1 = i; }
            }
            if (polcount > otrcount) { A[maxin1, j] = 0; } else { A[maxin1, j] = maxin1 + 1; }
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
            int summ = 0;
            int max = -10000, maxin = 10000;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; maxin = i; }
            }
            if (maxin < 5)
            {
                for (int k = maxin + 1; k < A.GetLength(0); k++) { summ += A[k, j]; }
                A[0, j] = summ;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B == null || B.Length != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -10000, maxin = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; maxin = i; }
            }
            if (A[maxin, j] < B[j]) { A[maxin, j] = B[j]; }
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
            double max = -10000;
            int maxin = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j]; maxin = i; }
            }
            if (max < (A[0, j] + A[A.GetLength(0) - 1, j]) / 2)
            {
                A[maxin, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            }
            else
            {
                A[maxin, j] = maxin + 1;
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
                if (i == j % 3) { answer[i, j] = 1; }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6) { return null; }
        int max = -10000, maxin = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max) { max = A[i, i]; maxin = i; }
        }
        for (int j = 0; j < A.GetLength(0) - 1; j++)
        {
            if (j == maxin) break;
            for (int k = j + 1; k < A.GetLength(1); k++) A[j, k] = 0;
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
            int max1 = -10000, max2 = -10000, maxin1 = 0, maxin2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1) { max1 = B[i, j]; maxin1 = j; }
                if (B[i + 1, j] > max2) { max2 = B[i + 1, j]; maxin2 = j; }
            }
            B[i, maxin1] = max2;
            B[i + 1, maxin2] = max1;
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
                int zag = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = zag;
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
        if (matrix == null || matrix.GetLength(0) != 6 || matrix.GetLength(1) != 6) { return null; }
        int n = matrix.GetLength(0) - 1;
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[i, n] = 0;
            matrix[n, n - i] = 0;
            matrix[n - i, 0] = 0;
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5) { return null; }
        int n = matrix.GetLength(0);
        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j <= i; j++) { matrix[i, j] = 1; }
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
        if (matrix == null || matrix.GetLength(0) != 6 || matrix.GetLength(1) != 6) { return (null, null); }
        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2];
        lower = new int[n * (n - 1) / 2];
        int count1 = 0, count2 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j) { upper[count1] = matrix[i, j]; count1++; } else { lower[count2] = matrix[i, j]; count2++; }
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
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) { return null; }
        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] polcountrows = new int[matrix.GetLength(0)], pattern = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int polcount = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) { polcount++; }
                matrix1[i, j] = matrix[i, j];
            }
            polcountrows[i] = polcount;
            pattern[i] = i;
        }
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int l = 0; l < matrix.GetLength(0) - k - 1; l++)
            {
                if (polcountrows[l] < polcountrows[l + 1])
                {
                    int temp1 = polcountrows[l + 1], temp2 = pattern[l + 1];
                    polcountrows[l + 1] = polcountrows[l];
                    polcountrows[l] = temp1;
                    pattern[l + 1] = pattern[l];
                    pattern[l] = temp2;
                }
            }
        }
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                matrix[i1, j1] = matrix1[pattern[i1], j1];
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k + 1];
                            matrix[i, k + 1] = matrix[i, k];
                            matrix[i, k] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k + 1];
                            matrix[i, k + 1] = matrix[i, k];
                            matrix[i, k] = temp;
                        }
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) { return null; }
        bool[] skip = new bool[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) { skip[i] = true; break; }
            }
        }
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) { if (skip[i] == false) { count++; } }
        int[,] matrix1 = new int[count, matrix.GetLength(1)];
        for (int i1 = 0, k = 0; i1 < matrix.GetLength(0); i1++, k++)
        {
            if (skip[i1] == true) { k--; continue; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                matrix1[k, j1] = matrix[i1, j1];
            }
        }
        matrix = matrix1;
        
        // end

        return matrix;
    }
    #endregion
}
