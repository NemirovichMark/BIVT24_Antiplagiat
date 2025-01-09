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
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
        program.Task_3_9(matrix);


    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 5 || cols != 7) return 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                answer += A[i, j];
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1), cnt = 0;
        if (rows != 5 || cols != 7) return 0;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0;j < cols; j++)
            {
                if (A[i,j] > 0)
                {
                    answer += A[i,j];
                    cnt++;
                }
            }
        }
        answer /= cnt;
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
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 5 || cols != 4) return (0, 0);

        for(int i = 0;i < rows; i++)
        {
            if (A[i,colIndex] < 0)
            {
                rowIndex = i;
                break;
            }
        }
        value = A[rowIndex,colIndex];
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
        int rows = A.GetLength(0), cols = A.GetLength(1);
        double[] values = new double[rows];
        if (rows != 4 || cols != 6) return default(double[]);

        for(int i = 0; i < rows; i++)
        {
            double sum = 0;
            int cnt = 0;
            for(int j = 0; j < cols; j++)
            {
                if (A[i,j] > 0)
                {
                    sum += A[i,j];
                    cnt++;
                }
            }
            if(cnt != 0) values[i] = sum/cnt;
            else values[i] = 0;
        }
        answer = values;
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
        int rows = A.GetLength(0), cols = A.GetLength(1), min_index = 0;
        int[,] values = new int[rows - 1, cols];
        if (rows != 5 || cols != 7) return default(int[,]);

        for(int i = 0;i < rows; i++)
        {
            if (A[i,1 - 1] < A[min_index,1 - 1]) min_index = i;
        }

        Console.WriteLine(min_index);

        for (int i = 0; i < rows - 1; i++)
        { 
            for(int j = 0;j < cols; j++)
            {
                if (i >= min_index) values[i,j] = A[i + 1,j];
                else values[i, j] = A[i, j];
            }
        }
        A = values;
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
        int rows = A.GetLength(0), cols = A.GetLength(1);
        int[] values = new int[cols];
        if (rows != 4 || cols != 3) return default(int[]);

        for(int j = 0; j < cols; j++)
        {
            int cnt = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] < 0) cnt++;
            }
            values[j] = cnt;
        }
        answer = values;
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
        int rows = n, cols = m;

        for (int i = 0;i < rows; i++)
        {
            int min_index = 0, temp;
            for (int j = 0; j < cols; j++)
                if (B[i, j] < B[i,min_index]) min_index = j;
            temp = B[i, min_index];
            for (int j = min_index; j > 0; j--)
                B[i,j] = B[i,j-1];
            B[i, 0] = temp;
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
        int rows = n, cols = m;

        for(int i = 0; i < rows; i++)
        {
            int max_index = 0, first_index = -1, last_index = -1;
            for (int j = 0;j < cols; j++)
            {
                if (F[i,j] > F[i,max_index]) max_index = j;
                if (F[i,j] < 0)
                {
                    if (first_index == -1) first_index = j;
                    last_index = j;
                }
            }
            if (first_index != -1) F[i, max_index] = (F[i,first_index] + F[i,last_index]) / 2;
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
        int rows = G.GetLength(0), cols = G.GetLength(1);
        if (rows != 5 || cols != 7) return default(int[,]);
        
        for(int i = 0; i < rows; i++)
        {
            int max_index = 0;
            for (int j = 0; j < cols - 1; j++)
                if (G[i, j] > G[i,max_index]) max_index = j;
            for (int j = cols - 1; j > max_index; j--)
                G[i, j] = G[i, j - 1];
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
        int rows = A.GetLength(0), cols = A.GetLength(1), max_index = 0;
        if (rows != 5 || cols != 7 || B.Length != 7) return default(int[,]);

        for (int i = 0;i<rows;i++)
            if (A[i,6-1] > A[max_index,6-1]) max_index = i;

        for (int j = 0;j < cols; j++)
        {
            A[max_index,j] = B[j];
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
        int rows = F.GetLength(0), cols = F.GetLength(1), min_index = 0;
        int[,] values = new int[rows, cols - 1];
        if (rows != 5 || cols != 7) return default(int[,]);

        for (int j = 0; j < cols; j++)
            if (Math.Abs(F[2 - 1, j]) < Math.Abs(F[2 - 1, min_index])) min_index = j;

        for (int j = 0;j < cols - 1; j++)
        {
            for (int i = 0;i < rows; i++)
            {
                if (j > min_index) values[i, j] = F[i, j + 1];
                else values[i, j] = F[i, j];
            }
        }
        F = values;
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
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 5 || cols != 7) return default(double[,]);

        for(int i = 0;i < rows; i++)
        {
            double sum = 0;
            int cnt = 0, max_index = 0;
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > A[i, max_index]) max_index = j;
                if (A[i,j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
            if (cnt != 0) sum /= cnt;
            A[i, max_index] = sum;
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
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 5 || cols != 7) return default(double[,]);

        for (int i = 0;i < rows; i++)
        {
            int max_index = 0;
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > A[i, max_index]) max_index = j;
            }
            if (max_index == cols - 1 || A[i, max_index - 1] < A[i, max_index + 1])
            {
                double elem = A[i, max_index - 1];
                if (elem < 0)  A[i, max_index - 1] /= 2;
                else A[i, max_index - 1] *= 2;
            }
            else if (max_index == 0 || A[i, max_index + 1] < A[i, max_index - 1])
            {
                double elem = A[i, max_index + 1];
                if (elem < 0) A[i, max_index + 1] /= 2;
                else A[i, max_index + 1] *= 2;
            }
        }
        // end

        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 7 || cols != 5) return default(int[,]);

        for (int j = 0; j < cols; j++)
        {
            int max_index = 0, negatives = 0, positives = 0;
            for (int i = 0;i < rows; i++)
            {
                if (A[i, j] < 0) negatives++;
                if (A[i, j] > 0) positives++;
                if (A[i, j] > A[max_index, j]) max_index = i;
            }
            if (positives > negatives) A[max_index, j] = 0;
            else A[max_index, j] = max_index;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 10 || cols != 5) return default(int[,]);

        for(int j = 0; j < cols; j++)
        {
            int max_index = 0, s = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > A[max_index, j])
                {
                    max_index = i;
                    s = 0;
                    continue;
                }
                s += A[i, j];
            }
            if (max_index < rows / 2) A[0, j] = s;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 7 || cols != 5 || B.Length != 5) return default(int[,]);

        for (int j = 0; j < cols; j++)
        {
            int max_index = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > A[max_index, j]) max_index = i;
            }
            if (A[max_index,j] < B[j]) A[max_index,j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 7 || cols != 5) return default(double[,]);

        for (int j = 0; j < cols; j++)
        {
            int max_index = 0;
            double s = (A[0, j] + A[rows - 1, j]) / 2;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > A[max_index, j]) max_index = i;
            }
            if (A[max_index, j] < s) A[max_index, j] = s;
            else A[max_index, j] = max_index;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        int rows = n, cols = 3 * n;
        if (rows < 0 || cols < 0) return answer;
        int[,] matrix = new int[n, 3 * n];

        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j += 3)
                matrix[i, j] = 1;
        }
        answer = matrix;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1), max_index = 0;
        if (rows != 6 || cols != 6) return default(int[,]);

        for(int i = 1; i < rows;i++)
        {
            if (A[i, i] > A[max_index,max_index]) max_index = i;
        }

        for(int i = 0; i < max_index; i++)
        {
            for (int j = i + 1; j < rows; j++) A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int rows = B.GetLength(0), cols = B.GetLength(1);
        if (rows != 6 || cols != 6) return default(int[,]);

        for (int i = 0;i<rows; i += 2)
        {
            int max_1 = 0, max_2 = 0;
            for (int j = 0; j < cols; j++)
            {
                if (B[i,j] > B[i,max_1]) max_1 = j;
            }
            for (int k = 0; k < cols; k++)
            {
                if (B[i + 1, k] > B[i + 1, max_2]) max_2 = k;
            }
            int temp = B[i, max_1];
            B[i,max_1] = B[i+1,max_2];
            B[i+1,max_2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 6 || cols != 7) return default(int[,]);

        for (int i = 0;i < rows; i++)
        {
            for (int j = 0;j < cols / 2; j++)
            {
                int temp = A[i,j];
                A[i, j] = A[i, cols - j - 1];
                A[i, cols - j - 1] = temp;
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return default(int[,]);
        int[] indexes = new int[rows], elems = new int[rows];
        int[,] new_matrix = new int[rows,cols];

        for (int i = 0;i < rows; i++)
        {
            int min_elem = 0;
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i,j] < min_elem) min_elem = matrix[i,j];
            }
            indexes[i] = i; elems[i] = min_elem;
        }

        for (int i = 1, j = i + 1; i < rows;)
        {
            if (i == 0 || elems[i] <= elems[i - 1])
            {
                i = j;
                j++;
            }
            else if (elems[i] > elems[i - 1])
            {
                int temp = elems[i];
                elems[i] = elems[i - 1];
                elems[i - 1] = temp;
                int temp_index = indexes[i];    
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for(int i = 0; i < rows; i++) Console.Write(elems[i] + " ");

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                new_matrix[i,j] = matrix[indexes[i],j];
            }
        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows !=  cols) return default(int[,]);

        for (int i = 0;i < rows; i++)
        {
            if (i > 0 && i < rows - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, rows - 1] = 0;
            }
            else
            {
                for(int j = 0; j < cols; j++) matrix[i, j] = 0;
            }
        }
        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != cols) return default(int[]);
        int[] vector = new int[2 * rows - 1];

        for (int i = rows - 1, index = 0; i >= 0; i--, index++)
        {
            int row = i, col = 0, sum_left = 0, sum_right = 0;
            while(row < rows && col < cols)
            {
                sum_left += matrix[row, col];
                sum_right += matrix[col,row];
                row++;col++;
            }
            vector[index] = sum_left;
            vector[2 * rows - 2 - index] = sum_right;
        }
        for (int i = 0; i < rows; i++) Console.Write(vector[i] + " ");
        answer = vector;
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != cols || k <= 0) return default (int[,]);
        int max_row = 0, max_col = 0;
        k--;

        for (int i = 0;i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
                if (Math.Abs(matrix[i,j]) > Math.Abs(matrix[max_row,max_col]))
                {
                    max_row = i;
                    max_col = j;
                }
        }

        if (max_col != k)
        {
            for (int i = 0; i < cols; i++)
            {
                int temp = matrix[i, max_col];
                matrix[i, max_col] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        if (max_row != k)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[max_row, j];
                matrix[max_row, j] = matrix[k, j];
                matrix[k, j] = temp;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0;j < cols; j++)
            Console.Write(matrix[i,j] + " ");
            Console.WriteLine();
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
        int rows = A.Length, cols = B.Length;
        if (rows + rows - n != n * n || cols + cols - n != n * n) return default(int[]);
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        int[] result = new int[n*n];
        for (int i = 0, index = 0;i < n; i++)
        {
            for(int j = i;j< n; j++)
            {
                matrix1[i, j] = A[index];
                matrix1[j, i] = A[index];
                matrix2[i, j] = B[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }

        for (int i = 0, index = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += matrix1[i, j] * matrix2[j, k];
                }
                result[index] = s;
                index++;
            }
        }
        answer = result;

        for (int i = 0; i < n * n; i++)
        {
                Console.Write(result[i] + " ");
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 5 || cols != 7) return default(int[,]);
        int[] indexes = new int[cols], negative_counts = new int[cols];
        int[,] new_matrix = new int[rows, cols];

        for (int j = 0; j < cols; j++)
        {
            int cnt = 0;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < 0) cnt++;
            }
            indexes[j] = j; negative_counts[j] = cnt;
        }

        for (int i = 1, j = i + 1; i < cols;)
        {
            if (i == 0 || negative_counts[i] >= negative_counts[i - 1])
            {
                i = j;
                j++;
            }
            else if (negative_counts[i] < negative_counts[i - 1])
            {
                int temp = negative_counts[i];
                negative_counts[i] = negative_counts[i - 1];
                negative_counts[i - 1] = temp;
                int temp_index = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for (int i = 0; i < cols; i++) Console.Write(negative_counts[i] + " ");

        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                new_matrix[i, j] = matrix[i, indexes[j]];
            }
        }
        matrix = new_matrix;
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1), count_0 = 0;
        int[] indexes = new int[rows];

        for (int i = 0, index = 0; i < rows; i++)
        {
            bool flag = true;
            for (int j = 0; j < cols; j++) 
                if(matrix[i, j] == 0)
                {
                    count_0++;
                    flag = false;
                    break;
                }
            if (!flag) indexes[index++] = i;
        }

        int[,] new_matrix = new int[rows - count_0, cols];

        for (int i = 0, index = 0; i < rows;i++)
        {
            if (i == indexes[index]) index++;
            else 
                for (int j = 0;j < cols;j++) new_matrix[i, j] = matrix[i, j];

        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    #endregion
}