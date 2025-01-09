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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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
        int minn = int.MaxValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minn)
                {
                    minn = A[i, j];
                    row = i;
                    col = j;
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
        if (A.GetLength(0) == 0 || A.GetLength(1) == 0) return answer;
        answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxx = int.MinValue;
            for (int i = 0;i < A.GetLength(0); i++)
            {
                if ((A[i, j] > maxx))
                {
                    maxx = A[i,j];
                } 
            }
            answer[j] = maxx;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int maxi = 0;
        int maxx = A[0, 2];
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        for (int i = 1; i < n; i++)
        {
            if (A[i, 2] > maxx)
            {
                maxx = A[i, 2];
                maxi = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            int temp = A[maxi, j];
            A[maxi, j] = A[3, j];
            A[3, j] = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        int maxi = 0;
        int maxx = A[0, 0];
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxx)
            {
                maxx = A[i, i];
                maxi = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int temp = A[i, 3];
            A[i, 3] = A[i, maxi];
            A[i, maxi] = temp;
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
        for (int i = 0; i < n; i++)
        {
            int maxx = A[i, 0];
            int maxI = 0;
            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = j;
                }
            }
            for (int j = maxI; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = maxx;
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
        for (int i = 0; i < n; i++)
        {
            int maxI = 0;
            double maxx = C[i, 0];
            for (int j = 1; j < m; j++)
            {
                if (C[i, j] > maxx)
                {
                    maxx = C[i, j];
                    maxI = j;
                }
            }
            for (int j = 0; j < maxI; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] /= maxx;
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        int maxI = 0, maxJ = 0;
        double maxx  = Z[0, 0];
        double sa = 0 , c = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > maxx)
                {
                    maxx = Z[i, j];
                    maxI = i; 
                    maxJ = j;
                }
            }
        }
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    sa += Z[i, j];
                    c++;
                }
            }
        }
        double average = c > 0 ? sa / c : 0;
        sa = sa / c;
        Z[maxI, maxJ] = average;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int minOI = 0, maxOI = 0;
        int minOC = int.MaxValue, maxOC = int.MinValue;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int otr = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    otr++;
                }
            }
            if (otr < minOC)
            {
                minOC = otr;
                minOI = i;
            }
            if (otr > maxOC)
            {
                maxOC = otr;
                maxOI = i;
            }
        }
        for (int j = 0; j < X.GetLength(1); j++)
        {
            int temp = X[minOI, j];
            X[minOI, j] = X[maxOI, j];
            X[maxOI, j] = temp;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int maxs = int.MinValue;
        int indexstr = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > maxs)
            {
                maxs = sum;
                indexstr = i;
            }
        }
        int[,] tempMatrix = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int ind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i != indexstr)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    tempMatrix[ind, j] = A[i, j];
                }
                ind++;
            }
        }
        A = tempMatrix;
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;
        int minn = A[4, 0];
        int indexstlb = 0;
        for (int j = 1; j < A.GetLength(1)-1; j++)
        {
            if (A[4, j] < minn)
            {
                minn = A[4, j];
                indexstlb = j;
            }
        }
        int[,] tempMatrix = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < tempMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < tempMatrix.GetLength(1); j++)
            {
                if (j <= indexstlb)
                {
                    tempMatrix[i, j] = A[i, j];
                }
                else if (j == indexstlb + 1)
                {
                    tempMatrix[i, j] = B[i];
                }
                else
                {
                    tempMatrix[i, j] = A[i, j - 1];
                }
            }
        }
        A = tempMatrix;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxI = 0;
            double maxx = A[i, 0];
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = j;
                }
            }
            if (maxI == 0)
            {
                A[i, maxI + 1] *= 2;
            }
            if (maxI == A.GetLength(1) - 1)
            {
                A[i, A.GetLength(1) - 2] *= 2;
            }
            if (maxI != 0 && maxI != (A.GetLength(1) - 1))
            {
                if (A[i, maxI - 1] > A[i, maxI + 1])
                {
                    if (A[i, maxI + 1] > 0)
                    {
                        A[i, maxI + 1] *= 2;
                    }
                    else
                    {
                        A[i, maxI + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, maxI - 1] > 0)
                    {
                        A[i, maxI - 1] *= 2;
                    }
                    else
                    {
                        A[i, maxI - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int pc = 0;
            int oc = 0;
            int maxx = A[0, j];
            int maxI = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0)
                {
                    pc++;
                }
                if (A[i, j] < 0)
                {
                    oc++;
                }
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = i;
                }
            }
            if (pc > oc)
            {
                A[maxI, j] = 0;
            }
            else
            {
                A[maxI, j] = maxI + 1;
            }
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
            int maxx = A[0, j];
            int maxI = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = i;
                }
            }
            if (maxI < 5)
            {
                int sum = 0;
                for (int i = maxI + 1; i < A.GetLength(0); i++)
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
            int maxx = A[0, j];
            int maxI = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = i;
                }
            }
            if (B[j] > maxx)
            {
                A[maxI, j] = B[j];
            }
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
            double maxx = A[0, j];
            int maxI = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    maxI = i;
                }
            }
            double polusumma = (A[0, j] + A[6, j]) / 2;
            if (maxx < polusumma)
            {
                A[maxI, j] = polusumma;
            }
            else
            {
                A[maxI, j] = maxI + 1;
            }
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i == j || i + n == j || i + 2 * n == j) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int maxI = 0;
        for (int i = 1; i < A.GetLength(0); i++)
            if (A[i, i] > A[maxI, maxI])
            {
                maxI = i;
            }
        for (int i = 0; i < maxI; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
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
        int[] maxI = new int[6];
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int maxInd1 = 0, maxInd2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, maxInd1])
                {
                    maxInd1 = j;
                }
                if (B[i + 1, j] > B[i + 1, maxInd2])
                {
                    maxInd2 = j;
                }
            }
            maxI[i] = maxInd1;
            maxI[i + 1] = maxInd2;
            int temp = B[i, maxInd1];
            B[i, maxInd1] = B[i + 1, maxInd2];
            B[i + 1, maxInd2] = temp;
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
            for (int j = 0; j < A.GetLength(1)/2; j++)
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] minn = new int[matrix.GetLength(0)];
        int[] ind = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            minn[i] = matrix[i, 0];
            ind[i] = i;

            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < minn[i])
                {
                    minn[i] = matrix[i, j];
                }
            }
        }
        for (int i = 0; i < minn.Length; i++)
        {
            for (int j = i + 1; j < minn.Length; j++)
            {
                if (minn[i] < minn[j])
                {
                    int tempminn = minn[i];
                    minn[i] = minn[j];
                    minn[j] = tempminn;
                    int tempind = ind[i];
                    ind[i] = ind[j];
                    ind[j] = tempind;
                }
            }
        }
        int[,] sortedmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int oi = ind[i];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sortedmatrix[i, j] = matrix[oi, j];
            }
        }
        matrix = sortedmatrix;
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int dind = j - i + (n - 1);
                answer[dind] += matrix[i, j];
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || k < 1 || k > n || matrix == null) return null;
        int maxx = matrix[0, 0], maxi = 0, maxj = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(maxx))
                {
                    maxx = matrix[i, j];
                    maxi = i;
                    maxj = j;
                }
            }
        }
        if (maxi != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[maxi, j];
                matrix[maxi, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (maxj != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, maxj];
                matrix[i, maxj] = matrix[i, k - 1];
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
        if (A.Length < 2 || B.Length < 2 || n == 0) return null;
        int I = 0;
        int[,] matA = new int[n, n], matB = new int[n, n];
        answer = new int[n * n];
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                matA[i, j] = A[I];
                matA[j, i] = A[I];
                matB[i, j] = B[I];
                matB[j, i] = B[I];
                I++;
            }
        int index = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    answer[index] += matA[i, k] * matB[k, j];
                }
                index++;
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
        if ((matrix.GetLength(0) != 5 && matrix.GetLength(0) != 7) || matrix == null) return null;
        int[] oc = new int[matrix.GetLength(1)];
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int j = 0; j < m; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) count++;

            oc[j] = count;
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m - i - 1; j++)
            {
                if (oc[j] > oc[j + 1])
                {
                    int temp = oc[j];
                    oc[j] = oc[j + 1];
                    oc[j + 1] = temp;
                    for (int k = 0; k < n; k++)
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1), c = 0;
        if (n == 0 || m == 0 || matrix == null || n < 2) return null;
        for (int i = 0; i < n; i++)
        {
            bool o = true;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    o = false;
                    break;
                }
            }
            if (o == true)
            {
                c++;
            }      
        }
        int[,] tempm = new int[c, m];
        int ind = 0;
        for (int i = 0; i < n; i++)
        {
            bool o = true;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    o = false;
                    break;
                }
            }
            if (o == true)
            {
                for (int j = 0; j < m; j++)
                {
                    tempm[ind, j] = matrix[i, j];
                }
                ind += 1;
            }
        }
        matrix = tempm;
        // end

        return matrix;
    }
    #endregion
}