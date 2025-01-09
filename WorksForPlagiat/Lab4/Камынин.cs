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
        int min = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    row = i;
                    col = j;
                    min = A[i, j];
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
        int[] M = new int[A.GetLength(1)];
        if (A.GetLength(0) != 3 && A.GetLength(1) != 5) return answer;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) max = A[i, j];
            }
            M[j] = max;
        }
        answer = M;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return default(int[,]);
        int[,] answer = default(int[,]);
        int max = A[0, 0];
        int n_max = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] >= max)
            {
                n_max = i;
                max = A[i, 2];
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int t = A[n_max, j];
            A[n_max, j] = A[3, j];
            A[3, j] = t;
        }
        //A[1, 1] = n_max;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 5) return default(int[,]);
        int max_di = A[0, 0], i_max = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max_di)
            {
                max_di = A[i, i];
                i_max = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int t = A[i, i_max];
            A[i, i_max] = A[i, 3];
            A[i, 3] = t;
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
        int max, j_max;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            max = A[i, 0];
            j_max = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    j_max = j;
                }
            }
            for (int j = j_max; j < A.GetLength(1) - 1; j++)
            {
                int t = A[i, j];
                A[i, j] = A[i, j + 1];
                A[i, j + 1] = t;
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
    public double[,] Task_1_19(double[,] A, int n, int m)
    {
        // code here
        int j_max;
        double max;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            max = A[i, 0];
            j_max = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    j_max = j;
                }
            }
            if (max != 0)
            {
                for (int j = 0; j < j_max; j++)
                {
                    if (A[i, j] < 0) A[i, j] /= max;
                }
            }
        }
        // end

        return A;
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
        if (Z.GetLength(0) != 6 && Z.GetLength(1) != 8) return default(double[,]);
        double max = Z[0, 0], mean = 0;
        int i_max = 0, j_max = 0, count = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    mean += Z[i, j];
                    count++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    i_max = i;
                    j_max = j;
                }
            }
        }
        Z[i_max, j_max] = mean / count;

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
        if (X.GetLength(0) != 6 && X.GetLength(1) != 5) return default(int[,]);
        int min_neg = X.GetLength(1), max_neg = 0, i_min = 0, i_max = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int max = 0, min = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    max++;
                    min++;
                }
            }
            if (max > max_neg)
            {
                max_neg = max;
                i_min = i;
            }
            if (min < min_neg)
            {
                min_neg = min;
                i_max = i;
            }
        }
        for (int j = 0; j < X.GetLength(1); j++)
        {
            int t = X[i_min, j];
            X[i_min, j] = X[i_max, j];
            X[i_max, j] = t;
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
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return default(int[,]);
        int[,] m = new int[6, 5];
        int max = 0, i_max = 0, k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int summ = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) summ += A[i, j];
            }
            if (summ > max)
            {
                max = summ;
                i_max = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == i_max) { k++; continue; }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                m[i - k, j] = A[i, j];
            }
        }
        A = m;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return default(int[,]);
        int min = A[4, 0], j_min = 0;
        for (int j = 0; j < A.GetLength(1) - 1; j++)
        {
            if (A[4, j] < min)
            {
                min = A[4, j];
                j_min = j;
            }
        }
        for (int j = A.GetLength(1) - 1; j > j_min + 1; j--)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, j_min + 1] = B[i];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int j_max = 0;
            double max = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    j_max = j;
                }
            }
            if (j_max == 0) A[i, 1] *= 2;
            if (j_max == (A.GetLength(1) - 1)) A[i, A.GetLength(1) - 2] *= 2;
            if (j_max != 0 && j_max != (A.GetLength(1) - 1))
            {
                if (A[i, j_max - 1] > A[i, j_max + 1])
                {
                    if (A[i, j_max + 1] > 0) A[i, j_max + 1] *= 2;
                    else A[i, j_max + 1] /= 2;
                }
                else
                {
                    if (A[i, j_max - 1] > 0) A[i, j_max - 1] *= 2;
                    else A[i, j_max - 1] /= 2;
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
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int num_pos = 0, num_neg = 0, i_max = 0, max = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) num_pos++;
                if (A[i, j] < 0) num_neg++;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i_max = i;
                }
            }
            if (num_pos > num_neg) A[i_max, j] = 0;
            else A[i_max, j] = i_max+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j], i_max = 0, summ = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i_max = i;
                }
            }
            if (i_max <= A.GetLength(0) / 2)
            {
                for (int i = i_max + 1; i < A.GetLength(0); i++)
                {
                    summ = summ + A[i, j];
                }
                A[0, j] = summ;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j], i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i_max = i;
                }
            }
            if (A[i_max, j] < B[j]) A[i_max, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default(double[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int i_max = 0;
            double max = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i_max = i;
                }
            }
            if (A[i_max, j] < (A[0, j] + A[A.GetLength(0) - 1, j]) / 2) A[i_max, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            else A[i_max, j] = i_max+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return answer;
        int[,] x = new int[n, 3*n];
        answer = x;
        for(int i = 0; i < n; i++)
        {
            for (int j = 0;j < 3*n; j++)
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return default(int[,]);
        double max = A[0, 0];
        int i_max = 0;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                i_max = i;
            }
        }
        for(int i = 0; i < i_max; i++)
        {
            for (int j = i+1; j < A.GetLength(1); j++) A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default(int[,]);
        for(int i = 0; i < B.GetLength(0)-1; i += 2)
        {
            int max1 = B[i, 0], max2 = B[i+1, 0], j_max1 = 0, j_max2 = 0;
            for(int j=0; j < B.GetLength(1); j++)
            {
                if (B[i,j] > max1)
                {
                    max1= B[i, j];
                    j_max1 = j;
                }
                if (B[i+1, j] > max2)
                {
                    j_max2 = j;
                    max2 = B[i+1, j];
                }
            }
            int t = B[i, j_max1];
            B[i, j_max1] = B[i + 1, j_max2];
            B[i+1, j_max2] = t;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default(int[,]);
        for(int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1)/2; j++)
            {
                int t = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1 ] = t;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default(int[,]);
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 || i == matrix.GetLength(0) - 1)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            else
            {
                matrix[i,0] = 0;
                matrix[i, matrix.GetLength(1) - 1] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default(int[,]);
        for(int i=matrix.GetLength(0)/2; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j<=i; j++)
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (default(int[]), default(int[]));
        int[] up= new int[matrix.GetLength(0)*(matrix.GetLength(0) + 1)/2];
        int[] low = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2];
        int count_up=0, count_low=0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= i)
                {
                    up[count_up] = matrix[i, j];
                    count_up++;
                }
                else
                {
                    low[count_low] = matrix[i, j];
                    count_low++;
                }
            }
        }
        upper = up;
        lower = low;
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
        if (matrix.GetLength(0) !=7 || matrix.GetLength(1)!=5) return (default(int[,]));
        int[] order = new int[matrix.GetLength(0)];
        int count = 0, num = 0;
        //создаём массив с количеством пол э-тов в каждой строке
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) num++;
            }
            order[count] = num;
            count++;
            num = 0;
        }
        //упорядочиваем(от макс к мин) массив методом эффективных гномов
        //парарллельно перемещая строки в таком же порядке
        for(int i = 1, k = 2; i < order.Length;)
        {
            if ((i==0) || (order[i] <= order[i - 1]))
            {
                i = k;
                k++;
            }
            else
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i - 1, j];
                    matrix[i - 1, j] = temp;
                }
                int t = order[i];
                order[i] = order[i - 1];
                order[i - 1] = t;
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j], k = j - 1;
                    while (k >= 0 && matrix[i, k] < key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k -= 1;
                    }
                    matrix[i, k + 1] = key;
                }
            }
            else
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j], k = j - 1;
                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k -= 1;
                    }
                    matrix[i, k + 1] = key;
                }
            }
            //for(int j = 2; j < matrix.GetLength(1) - 1; j += 2)
            //{
            //    int key = matrix[i, j], k = j - 2;
            //    while (k >= 0 && matrix[i, k] < key)
            //    {
            //        matrix[i, k + 2] = matrix[i, k];
            //        k -= 2;
            //    }
            //    matrix[i, k + 2] = key;
            //}
            //for(int j = 1; j < matrix.GetLength(1) - 1; j += 2)
            //{
            //    int key = matrix[i, j], k = j - 2;
            //    while (k >= 0 && matrix[i, k] > key)
            //    {
            //        matrix[i, k + 2] = matrix[i, k];
            //        k -= 2;
            //    }
            //    matrix[i, k + 2] = key;
            //}
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int count_str = 0;
        int[] zeros= new int[matrix.GetLength(0)];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int count_elem = 0;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count_elem++;
                }
            }
            if (count_elem == 0)
            {
                zeros[count_str] = i;
                count_str++;
            }
        }
        int[,] a = new int[count_str, matrix.GetLength(1)];
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                a[i, j] = matrix[zeros[i], j];
            }
        }
        matrix = a;
        // end

        return matrix;
    }
    #endregion
}