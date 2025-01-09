using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;

        for (int i = 0; i < 4; i++) answer += A[i, i];
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;

        int[] answer = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int imin = 0;
            for (int j = 1; j < 7; j++)
                if (A[i, j] < A[i, imin]) imin = j;
            answer[i] = imin;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int imax = 0;
            for (int j = 1; j < 7; j++)
                if (A[i, j] > A[i, imax]) imax = j;
            int temp = A[i, imax];
            A[i, imax] = A[i, 0];
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        int imax = 0, jmax = 0;
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 7; j++)
                if (A[i, j] > A[imax, jmax])
                { imax = i; jmax = j; }

        int[,] N = new int[5, 6];
        for (int i = 0, ki = 0; i < 6; i++)
        {
            if (i == imax) continue;
            for (int j = 0, kj = 0; j < 7; j++)
            {
                if (j == jmax) continue;
                N[ki, kj] = A[i, j];
                kj++;
            }
            ki++;
        }
        A = N;
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

        for (int i = 0; i < 5; i++)
        {
            int imax = 0;
            for (int j = 1; j < 7; j++)
                if (A[i, j] > A[i, imax]) imax = j;
            A[i, imax] = A[i, imax] * (i + 1);
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
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;
        if (n <= 0 || m <= 0) return null;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            if (D[i, 0] < 0) continue;
            int first = -1, last = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    if (first == -1)
                        first = j;
                    last = j;
                }
            }

            if (first == -1 || last == -1)
                continue;

            int max = 0;
            for (int k = 0; k < first; k++)
            {
                if (D[i, k] > D[i, max])
                    max = k;
            }
            int temp = D[i, max];
            D[i, max] = D[i, last];
            D[i, last] = temp;
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

        int[,] A = new int[5, 7];
        for (int i  = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1)-1; j++)
                A[i,j] = H[i,j];
            A[i, 6] = H[i,5];

        }  

        for (int i = 0; i < 5; i++)
        {
            int max = 0;
            for (int j = 0; j < 6; j++)
                if (H[i, j] > H[i, max]) max = j;
            A[i, 5] = H[i, max];
        }
        H = A;
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

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            int max = 0, cnt = 0;
            double srednee = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
                if (Y[i, j] > Y[i, max]) max = j;
            
            for (int k = max+1; k <  Y.GetLength(1); k++)
                if (Y[i, k]>0)
                {
                    cnt++;
                    srednee += Y[i, k];
                }

            if (cnt != 0) srednee /= cnt;
            
            for (int n = 0; n < max; n++)
            {
                if (Y[i, n] < 0) Y[i, n] = srednee;
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

        int[] maxs = new int[B.GetLength(0)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
                if (B[i, j] > max)
                    max = B[i, j];
            maxs[i] = max;
        }

        for (int i = 0; i < B.GetLength(0); i++)
            B[i, 3] = maxs[B.GetLength(0) - 1 - i];

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

        int max = 0, fn = 0;
        for (int i = 1; i < B.GetLength(0); i++)
        {
            if (B[i, i] > B[max, max])
                max = i;
        }

        for (int j = 0; j < B.GetLength(0); j++)
        {
            if (B[j, 2] < 0)
            {
                fn = j; break;
            }
        }

        if (fn != max)
        {
            int[] temp = new int[B.GetLength(1)];
            for (int i = 0; i < B.GetLength(1); i++)
            {
                temp[i] = B[fn, i];
                B[fn, i] = B[max, i];
                B[max, i] = temp[i];
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
        int k = 0, count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] < 0) count++;

        answer = new int[count];
        
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] < 0) answer[k++] = A[i, j];
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
            int jmax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
                if (A[i, j] > A[i, jmax]) jmax = j;

            if (jmax == 0) A[i, 1] *= (A[i, 1] > 0) ? 2 : 0.5;
            else if (jmax == 6) A[i, 5] *= (A[i, 5] > 0) ? 2 : 0.5;
            else if (A[i, jmax-1] < A[i, jmax+1]) A[i, jmax -1] *= (A[i, jmax - 1] > 0) ? 2 : 0.5;
            else A[i, jmax + 1] *= (A[i, jmax + 1] > 0) ? 2 : 0.5;

        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A == null) return null;

        for (int j = 0; j <  A.GetLength(1); j++)
        {
            int max = 0, pos = 0, neg = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[max, j]) max = i;
                if (A[i, j] > 0) pos++;
                if (A[i, j] < 0) neg++;
            }
            if (pos > neg) A[max, j] = 0;
            else A[max, j] = max + 1;
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
            int max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[max, j]) max = i;
            }

            if (max <= 4)
            {
                int sum = 0;
                for (int i = max + 1; i < A.GetLength(0); i++)
                    sum += A[i, j];
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
            int max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[max, j]) max = i;
            }

            if (B[j] > A[max, j]) A[max, j] = B[j];
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
            int max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[max, j]) max = i;
            }

            double half_sum = (A[0, j] + A[6, j]) / 2;
            if (A[max, j] < half_sum) A[max, j] = half_sum;
            else A[max, j] = max + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;

        answer = new int[n, n * 3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                answer[j, i*n + j] = 1;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            if (A[i,i] > A[max, max]) max = i;

        if (max != 5)
        {
            for (int i = 0; i < max; i++)
                for (int j = i + 1; j < A.GetLength(1); j++)
                    A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int[] max_index = new int[6];
        int k = 0;
        for(int i = 0; i < B.GetLength(0); i++)
        {
            int max = 0;
            for (int j = 0; j < B.GetLength(1); j++)
                if (B[i, j] > B[i, max]) max = j;
            max_index[k++] = max;
        }

        for (int i = 0; i < max_index.Length - 1; i += 2)
        {
            int temp = B[i, max_index[i]];
            B[i, max_index[i]] = B[i + 1, max_index[i + 1]];
            B[i + 1, max_index[i + 1]] = temp;
        }
            
            
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int n = A.GetLength(1);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < n/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, n - j -1];
                A[i, n - j - 1] = temp;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;

        int[] mins = new int[matrix.GetLength(0)];
        int[] inds = new int[matrix.GetLength(0)];
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] < matrix[i, min]) min = j;
            inds[i] = i;
            mins[i] = matrix[i, min];
            
        }

        for (int i = 0; i < mins.Length; i++)
            for (int j = 0; j < mins.Length - i -1; j++)
                if (mins[j] < mins[j + 1])
                {
                    int temp1 = mins[j], temp2 = inds[j];
                    mins[j] = mins[j + 1];
                    mins[j + 1] = temp1;

                    inds[j] = inds[j + 1];
                    inds[j + 1] = temp2;
                }

        int[,] A = new int[7, 5]; 
        for (int i = 0; i < 7; i++)
            for (int j = 0; j < 5; j++)
            {
                A[i, j] = matrix[inds[i], j];
            }
        matrix = A;

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];

        int sum1, sum2;
        int ind1 = n - 1, ind2 = n - 1;

        for (int i = 0; i < n; i++)
        {
            sum1 = 0; sum2 = 0;
            for (int j = 0; i + j < n; j++)
            {
                sum1 += matrix[i + j, j];
                sum2 += matrix[j, i + j];
            }
            answer[ind1--] = sum1;
            answer[ind2++] = sum2;

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k <= 0) return null;

        int ind_i = 0, ind_j = 0;
        int max = matrix[0, 0];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    ind_i = i;
                    ind_j = j;
                }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, ind_j];
            matrix[i, ind_j] = matrix[i, k - 1];
            matrix[i, k - 1] = temp;

        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[ind_i, j];
            matrix[ind_i, j] = matrix[k - 1, j];
            matrix[k - 1, j] = temp;
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
        if (A.Length != (n * (n + 1) / 2) || B.Length != (n * (n + 1) / 2)) return null;

        answer = new int[n * n];

        int[,] matr_A = new int[n, n], matr_B = new int[n, n], AB = new int[n, n];
        int ind = 0;

        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                matr_A[i, j] = A[ind];
                matr_A[j, i] = A[ind];
                matr_B[i, j] = B[ind];
                matr_B[j, i] = B[ind++];
            }
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    AB[i, j] += matr_A[i, k] * matr_B[k, j];

                answer[j + i * n] = AB[i, j];
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int neg;
        int ind = 0, t = 0;
        int[] Neg = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            neg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (matrix[i, j] < 0)
                    neg++;

            Neg[j] = neg;
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (Neg[i] > Neg[i + 1])
                {
                    t = Neg[i + 1];
                    Neg[i + 1] = Neg[i];
                    Neg[i] = t;

                    for (int k = 0; k < 5; k++)
                    {
                        t = matrix[k, i];
                        matrix[k, i] = matrix[k, i + 1];
                        matrix[k, i + 1] = t;
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
        if (matrix.GetLength(0) ==0 || matrix.GetLength(1) == 0) return null;

        int n = matrix.GetLength(0), cnt = 0;
        bool flag = false;
        int[] neg = new int[n];

        for (int i = 0; i < n; i++)
        {
            flag = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    flag = true;
                    break;
                }

            if (flag) neg[i] = 1;
            else cnt++;
        }

        int[,] temp = new int[cnt, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            if (neg[i] == 1) continue;
            for(int j = 0;j < matrix.GetLength(1); j++)
                temp[k, j] = matrix[i, j];
            k++;
        }
        matrix = temp;
        // end

        return matrix;
    }
    #endregion
}