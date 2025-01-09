using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Formats.Asn1;
using System.Numerics;
using System.Runtime.ExceptionServices;
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

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

        int n = A.GetLength(0);

        for (int i = 0; i < n; i++)
            answer += A[i, i];

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

        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
            return answer;

        int[] min_idx_arr = new int[A.GetLength(0)];

        for (int i = 0, k = 0; i < A.GetLength(0); i++, k++)
        {
            int min_row_elem = A[i, 0];
            int idx = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (min_row_elem > A[i, j])
                {
                    min_row_elem = A[i, j];
                    idx = j;
                }
            }

            min_idx_arr[k] = idx;
        }

        answer = min_idx_arr;

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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max_row_elem = A[i, 0], max_row_idx = 0;

            for (int j = 0; j < A.GetLength(1); j++)
                if (max_row_elem < A[i, j])
                {
                    max_row_elem = A[i, j];
                    max_row_idx = j;
                }

            int tmp = A[i, 0];
            A[i, 0] = A[i, max_row_idx];
            A[i, max_row_idx] = tmp;
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

        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);
        int max = A[0, 0], max_row_idx = 0, max_col_idx = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (max < A[i, j])
                {
                    max = A[i, j];
                    max_row_idx = i;
                    max_col_idx = j;
                }

        int[,] tmp = new int[n - 1, m - 1];

        for (int i = 0, k = 0; i < n - 1; i++)
            for (int j = 0, l = 0; j < m - 1; j++)
            {
                if (i == max_row_idx)
                    k = 1;
                if (j == max_col_idx)
                    l = 1;

                tmp[i, j] = A[i + k, j + l];
            }

        A = tmp;

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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;

            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > A[i, jmax])
                    jmax = j;
            }

            A[i, jmax] *= i + 1;
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

        if (D.GetLength(0) != n || D.GetLength(1) != m)
            return null;

        for (int i = 0; i < n; i++)
        {

            int jmax = 0, j_last_neg = -1;

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] > D[i, jmax] && j_last_neg == -1)
                    jmax = j;
                if (D[i, j] < 0)
                    j_last_neg = j;
            }

            if (j_last_neg != -1 && D[i, jmax] >= 0)
            {
                int tmp = D[i, j_last_neg];
                D[i, j_last_neg] = D[i, jmax];
                D[i, jmax] = tmp;
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

        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
            return null;

        int n = H.GetLength(0), m = H.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;

            for (int j = 0; j < m - 1; j++)
                if (H[i, j] > H[i, jmax])
                    jmax = j;
            H[i, m - 1] = H[i, m - 2];
            H[i, m - 2] = H[i, jmax];
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

        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
            return null;

        int n = Y.GetLength(0), m = Y.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            double pos_avg = 0;

            for (int j = 0; j < m; j++)
            {
                if (Y[i, j] > Y[i, jmax])
                {
                    jmax = j;
                    pos_avg = 0;
                }
                if (Y[i, j] > 0 && j > jmax)
                    pos_avg += Y[i, j];
            }

            pos_avg = m - jmax == 1 ? 0 : pos_avg /= m - jmax - 1;

            for (int j = 0; j < jmax; j++)
                if (Y[i, j] < 0)
                    Y[i, j] = pos_avg;
        }

        Display_matrix(Y);

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

        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
            return null;

        int n = B.GetLength(0), m = B.GetLength(1);
        int[] max_arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
                if (B[i, j] > B[i, jmax])
                    jmax = j;
            max_arr[i] = B[i, jmax];
        }

        for (int i = n - 1; i >= 0; i--)
            B[i, 3] = max_arr[n - i - 1];

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

        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
            return null;

        int n = B.GetLength(0);
        int ijmax = 0, ifirst_neg = -1;

        for (int i = 0; i < n; i++)
        {
            if (B[i, i] > B[ijmax, ijmax])
                ijmax = i;
            if (B[n - i - 1, 2] < 0)
                ifirst_neg = n - i - 1;
        }

        if (ifirst_neg != ijmax)
            for (int i = 0; i < n; i++)
            {
                int tmp = B[ijmax, i];
                B[ijmax, i] = B[ifirst_neg, i];
                B[ifirst_neg, i] = tmp;
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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);
        int count = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (A[i, j] < 0)
                    count++;

        answer = new int[count];

        for (int i = 0, k = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (A[i, j] < 0)
                    answer[k++] = A[i, j];

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

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
                if (A[i, j] > A[i, jmax])
                    jmax = j;

            switch (jmax)
            {
                case 0:
                    A[i, 1] *= 2;
                    break;
                case 6:
                    A[i, 6] *= 2;
                    break;
                default:
                    if (A[i, jmax - 1] < A[i, jmax + 1])
                        if (A[i, jmax - 1] < 0)
                            A[i, jmax - 1] /= 2;
                        else
                            A[i, jmax - 1] *= 2;
                    else
                        if (A[i, jmax + 1] < 0)
                        A[i, jmax + 1] /= 2;
                    else
                        A[i, jmax + 1] *= 2;
                    break;
            }

        }

        // end

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int j = 0; j < m; j++)
        {
            int pos_count = 0, neg_count = 0, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0)
                    neg_count++;
                else
                    pos_count++;

                if (A[i, j] > A[imax, j])
                    imax = i;
            }
            A[imax, j] = (neg_count > pos_count) ? imax + 1 : 0;
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int j = 0; j < m; j++)
        {
            int sum = 0, imax = 0;
            for (int i = 0; i < n; i++)
            {
                sum += A[i, j];
                if (A[i, j] > A[imax, j])
                {
                    imax = i;
                    sum = 0;
                }
            }

            if (imax <= n / 2)
                A[0, j] = sum;
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int j = 0; j < m; j++)
        {
            int imax = 0;
            for (int i = 0; i < n; i++)
                if (A[i, j] > A[imax, j])
                    imax = i;
            if (B[j] > A[imax, j])
                A[imax, j] = B[j];
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int j = 0; j < m; j++)
        {
            int imax = 0;
            for (int i = 0; i < n; i++)
                if (A[i, j] > A[imax, j])
                    imax = i;
            double half_sum = (A[0, j] + A[n - 1, j]) / 2;
            A[imax, j] = (half_sum > A[imax, j]) ? half_sum : imax + 1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0)
            return null;

        answer = new int[n, 3 * n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n * 3; j++)
                answer[i, j] = ((j - i) % n == 0) ? 1 : 0;

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);
        int ijmax = 0;

        for (int i = 0; i < n; i++)
            if (A[i, i] > A[ijmax, ijmax])
                ijmax = i;

        for (int i = 0; i < ijmax; i++)
            for (int j = i + 1; j < m; j++)
                A[i, j] = 0;

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;

        int n = B.GetLength(0);
        int previous_jmax = 0;

        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < n; j++)
                if (B[i, j] > B[i, jmax])
                    jmax = j;

            if (i % 2 == 0)
                previous_jmax = jmax;
            else
            {

                int tmp = B[i, jmax];
                B[i, jmax] = B[i - 1, previous_jmax];
                B[i - 1, previous_jmax] = tmp;
            }
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here


        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m / 2; j++)
            {
                int tmp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = tmp;
            }

        Display_matrix(A);

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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
                matrix[i, i] = 0;
            else
            {
                matrix[0, i] = 0;
                matrix[n - 1, i] = 0;

                matrix[i, 0] = 0;
                matrix[i, n - 1] = 0;
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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        int n = matrix.GetLength(0);

        for (int i = n / 2; i < n; i++)
            for (int j = 0; j < i + 1; j++)
            {
                matrix[i, j] = 1;
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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);

        int n = matrix.GetLength(0);
        upper = new int[(n * n - n) / 2 + n];
        lower = new int[(n * n - n) / 2];

        for (int i = 0, row_i = 0, col_j = 0; i < n; i++)
            for (int j = 0, ri = row_i, cj = col_j; j < n; j++)
            {
                if (j >= i)
                {
                    upper[ri] = matrix[i, j];
                    ri++;
                }
                else
                {
                    lower[cj] = matrix[i, j];
                    cj++;
                }
                row_i = ri;
                col_j = cj;
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

        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return null;

        int n = matrix.GetLength(0), m = matrix.GetLength(1);

        int[] pos_elem_arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] > 0)
                    count++;
            pos_elem_arr[i] = count;
        }

        for (int i = n - 1, z = i; i > 0; i--, z = i)
        {
            for (int l = i - 1; l >= 0; l--)
            {
                if (pos_elem_arr[i] > pos_elem_arr[l])
                {
                    int tmp = pos_elem_arr[i];
                    pos_elem_arr[i] = pos_elem_arr[l];
                    pos_elem_arr[l] = tmp;
                    z = l;
                }
            }

            for (int j = 0; j < m; j++)
            {
                int tmp = matrix[i, j];
                matrix[i, j] = matrix[z, j];
                matrix[z, j] = tmp;
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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return null;

        int n = matrix.GetLength(0), m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for (int l = j + 1; l < m; l++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, j] < matrix[i, l])
                        {
                            int tmp = matrix[i, l];
                            matrix[i, l] = matrix[i, j];
                            matrix[i, j] = tmp;
                        }
                    }
                    else if (i % 2 != 0)
                        if (matrix[i, j] > matrix[i, l])
                        {
                            int tmp = matrix[i, l];
                            matrix[i, l] = matrix[i, j];
                            matrix[i, j] = tmp;
                        }
                }
            }
        }

        Display_matrix(matrix);

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return null;

        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        
        bool[] zero_row_arr = new bool[n];        

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0)               
                    zero_row_arr[i] = true;

        int zero_row_count = 0;
        for (int i = 0; i < n; i++)
            if (zero_row_arr[i] == true)
                zero_row_count++;

        if (zero_row_count == n)
            return default(int[,]);

        int[,] tmp = new int[n - zero_row_count, m];

        for (int i = 0, k = 0; i < n; i++)
        {
            if (zero_row_arr[i] != true)
            {
                for (int j = 0; j < m; j++)                
                    tmp[k, j] = matrix[i, j];
                k++;
            }
        }            

        matrix = tmp;

        // end

        return matrix;
    }
    #endregion

    public void Display_matrix(int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Display_matrix(double[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void Display_array(int[] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
            Console.Write($"{A[i]} ");

    }
}