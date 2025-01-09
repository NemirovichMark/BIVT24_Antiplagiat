using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{

    public static int PositiveCount(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) { count++; }
        }
        return count;
    }
    public static void Main()
    {
        Program program = new Program();
        int[] a = { 9, 6, 5, 4, 2, 3, 1, 1};
        foreach (int el in program.bubble(a))
        {
            Console.WriteLine(el);
        }
    }

    public int[] insert(int[] a, int el, int index)
    {
        int[] a_1 = new int[a.Length + 1];
        for (int i = 0; i < a.Length; i++)
        {
            if (i < index) a_1[i] = a[i];
            else if (i == index) a_1[i] = el;
            else a_1[i] = a[i-1];
        }
        return a_1;
    }
    public int[] bubble(int[] a)
    {
        int mid = a.Length /2;
        for (int i = mid; i < a.Length; i++)
        {
            for (int j = mid; j < a.Length - 1- i + mid; j++)
            {
                if (a[j] > a[j+1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j+1] = temp;
                }
            }
        }
        return a;
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
        if (A.GetLength(0) < 4 || A.GetLength(1) < 4) { return 0; }
        for (int i = 0; i < 4; i++)
        {
            answer += A[i, i];
        }

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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) { return answer; }
        int[] answer1 = new int[4];

        for (int i = 0; i < 4; i++)
        {
            int min_el = int.MaxValue;
            for (int k = 0; k < 7; k++)
            {
                if (A[i, k] < min_el) { min_el = A[i, k]; answer1[i] = k; }
            }

        }


        return answer1;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            int max = A[i, 0];
            int maxIndex = 0;

            for (int j = 1; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }

            int temp = A[i, 0];
            A[i, 0] = max;
            A[i, maxIndex] = temp;
        }

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
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        if (A[i, j] > max) { max = A[i, j]; j_max = j; i_max = i; }
        //    }
        //}



        //for (int i = 0; i < i_max; i++)
        //{
        //    for (int j = 0; j < j_max; j++)
        //    {
        //        answer[i, j] = A[i, j];
        //    }
        //}

        //for (int i = i_max + 1; i < 5; i++)
        //{
        //    for (int j = j_max + 1; j < 6; j++)
        //    {
        //        answer[i, j] = A[i, j];
        //    }
        //}

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[,] answer = new int[5, 6];

        int max = int.MinValue;
        int j_max = -1;
        int i_max = -1;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    j_max = j;
                    i_max = i;
                }
            }
        }

        int answer_i = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == i_max) continue;
            int answer_j = 0;
            for (int j = 0; j < 7; j++)
            {
                if (j == j_max) continue;
                answer[answer_i, answer_j] = A[i, j];
                answer_j++;
            }
            answer_i++;
        }

        return answer;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }

            A[i, maxIndex] = A[i, maxIndex] * (i + 1);
        }

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
        if (D == null || D.GetLength(0) != n || D.GetLength(1) != m)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue, maxIndex = -1;
            int index = 0;

            while (index < m && D[i, index] >= 0)
            {
                if (D[i, index] > max)
                {
                    max = D[i, index];
                    maxIndex = index;
                }
                index++;
            }

            int negIndex = -1;
            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    negIndex = j;
                    break;
                }
            }
            if (maxIndex != -1 && negIndex != -1)
            {
                int temp = D[i, negIndex];
                D[i, negIndex] = D[i, maxIndex];
                D[i, maxIndex] = temp;
            }
        }

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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null;
        }

        int[] max = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int m = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > m)
                {
                    m = H[i, j];
                }
            }
            max[i] = m;
        }

        int[] temp = new int[5];
        for (int i = 0; i < 5; i++)
        {
            temp[i] = H[i, 5];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 5] = max[i];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 6] = temp[i];
        }


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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return null;
        }

        for (int i = 0; i < 6; i++)
        {

            double max = int.MinValue;
            int maxIndex = -1;
            double med = 0;
            int count = 0;

            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    maxIndex = j;
                }
            }

            for (int j = maxIndex + 1; j < 5; j++)
            {
                if (Y[i, j] > 0)
                {
                    med += Y[i, j];
                    count++;
                }
            }
            if (count > 0) { med /= count; }
            else { med = 0; }


            for (int j = 0; j < maxIndex; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = med;
                }
            }

        }

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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return null;
        }

        int[] max = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int m = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > m)
                {
                    m = B[i, j];
                }
            }
            max[4 - i] = m;
        }

        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = max[i];
        }


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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return null;
        }

        int max = int.MinValue;
        int maxIndex = -1;
        int negIndex = -1;

        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                maxIndex = i;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (B[i, 2] < 0)
            {
                negIndex = i;
                break;
            }
        }

        int[] temp = new int[5];
        for (int i = 0; i < 5; i++)
        {
            temp[i] = B[maxIndex, i];
        }
        for (int i = 0; i < 5; i++)
        {
            B[maxIndex, i] = B[negIndex, i];
        }
        for (int i = 0; i < 5; i++)
        {
            B[negIndex, i] = temp[i];
        }


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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }


        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }
        if (count == 0) { return null; }

        int[] answer = new int[count];

        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[index] = A[i, j];
                    index++;
                }
            }
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            double max = int.MinValue;
            int index = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            }
            if (index == 0)
            {
                if (A[i, 1] < 0) A[i, 1] /= 2;
                else A[i, 1] *= 2;
            }
            else if (index == 6)
            {
                if (A[i, 5] < 0) A[i, 5] /= 2;
                else A[i, 5] *= 2;
            }
            else
            {
                if (A[i, index - 1] < A[i, index + 1])
                {
                    if (A[i, index - 1] < 0) { A[i, index - 1] /= 2; }
                    else { A[i, index - 1] *= 2; }
                }
                else
                {
                    if (A[i, index + 1] < 0) { A[i, index + 1] /= 2; }
                    else { A[i, index + 1] *= 2; }
                }
            }
        }

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j ++)
        {
            int positive_count = 0;
            int negative_count = 0;
            int max = int.MinValue;
            int index = -1;

            for(int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) {  positive_count++; }
                else { negative_count++; }

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (positive_count > negative_count) { A[index, j] = 0; }
            else { A[index, j] = index + 1; }

        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }

        for ( int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = -1;

            for( int i = 0; i < 10; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (index < 5)
            {
                int s = 0;
                for (int i = index+1; i < 10; i++)
                {
                    s += A[i, j];
                }
                A[0, j] = s;
            }

        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }

        if (B.Length != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < 7; i++)
            {
                if (A[i,j] > max)
                {
                    max= A[i,j];
                    index = i;
                }
            }

            if (B[j] >  max)
            {
                A[index, j] = B[j];
            }
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            double max = int.MinValue;
            int index = -1;

            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i,j];
                    index = i;
                }
            }

            double demisum = (A[0, j] + A[6, j])/2;
            if (max <  demisum)
            {
                A[index, j] = demisum;
            }
            else { A[index, j] = index+1; }

        }

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) { return null; }
        int[,] answer = new int[n, 3 * n];
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < n; i++)
            {
                answer[i, i + (n * k)] = 1;
            }
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }

        int max = int.MinValue;
        int index = -1;
        for (int i = 0; i < 6; i++)
        {
            if (A[i,i] > max)
            {
                max = A[i,i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (j > i)
                {
                    A[i, j] = 0;
                }
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }

        int[] max = new int[6];

        for (int i = 0; i < 6; i++)
        {
            int max_el = int.MinValue, index = -1;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > max_el)
                {
                    max_el = B[i, j];
                    index = j;
                }
            }
            max[i] = index;

            
        }
        for (int i = 0; i < 6; i+=2) { 
        int temp = B[i, max[i]];
        B[i, max[i]] = B[i+1, max[i+1]];
        B[i+1, max[i+1]] = temp;
        }



        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 6-j];
                A[i, 6-j] = temp;
            }


        }


        return A;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        
        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[n-1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, n-1] = 0;
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        int n = matrix.GetLength (0);

        for (int i = n/2; i < n; i ++)
        {
            for (int j = 0; j < n; j ++)
            {
                if (j <= i)
                {
                    matrix[i,j] = 1;
                }
            }
        }

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

        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1))
        {
            return (null, null);
        }
        int count_up = 0;
        int count_down = 0;
        int[] upper = new int[n * (n + 1) / 2];
        int[] lower = new int[n * (n - 1) / 2];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                {
                    upper[count_up] = matrix[i, j];
                    count_up++;
                }
                else
                {
                    lower[count_down] = matrix[i, j];
                    count_down++;
                }
            }
        }

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

        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        int[] A = new int[7];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0) A[i]++;
            }
        }
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                if (A[j] < A[j + 1])
                {
                    for (int s = 0; s < cols; s++)
                    {
                        int temp1 = matrix[j, s];
                        matrix[j, s] = matrix[j + 1, s];
                        matrix[j + 1, s] = temp1;
                    }
                    int temp2 = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp2;
                }
            }
        }


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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < cols - 1; k++)
            {
                for (int j = 0; j < cols - k - 1; j++)
                {
                    if ((i % 2 == 0 && matrix[i, j] < matrix[i, j + 1]) ||
                        (i % 2 != 0 && matrix[i, j] > matrix[i, j + 1]))
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, j + 1];
                        matrix[i, j + 1] = temp;
                    }
                }
            }
        }

        return matrix;

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int nonZeroRowCount = 0;

        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero)
            {
                nonZeroRowCount++;
            }
        }
        int[,] result = new int[nonZeroRowCount, cols];
        int resultRow = 0;

        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[resultRow, j] = matrix[i, j];
                }
                resultRow++;
            }
        }

        return result;
    }
    #endregion
}
