using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        answer += A[i, j];
        //    }
        //}
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        double summa = 0; int count = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        else
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        summa += A[i, j];
                        count++;
                    }
                }
            }
            answer = summa / count;
        }

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
        if (A.GetLength(0) == 5 || A.GetLength(1) == 4)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        value = A[i, j];
                        rowIndex = i;
                    }
                }

            }
        }
        else
        {
            return (0, 0);
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
        answer = new double[A.GetLength(0)];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        else
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double summa = 0; int count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        summa += A[i, j];
                        count++;
                    }
                }
                if (count != 0)
                {
                    answer[i] = summa / count;
                }
            }
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
        else
        {
            int minimum = int.MaxValue;
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, 0] < minimum)
                {
                    index = i;
                    minimum = A[i, 0];
                }
            }
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (i < index)
                    {
                        B[i, j] = A[i, j];
                    }
                    if (i >= index)
                    {
                        B[i, j] = A[i + 1, j];
                    }
                }
            }
            A = B;
        }
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
        int count = 0;
        answer = new int[3];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] < 0) count++;
                }
                answer[j] = count;
                count = 0;
            }
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
        int count = 0, min_n = 0, min_m = 0;
        for (int i = 0; i < n; i++)
        {
            int minimum = int.MaxValue;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < minimum)
                {
                    minimum = B[i, j];
                    min_n = i;
                    min_m = j;
                }
            }
            for (int j = min_m; j > 0; j--)
            {
                int temp = B[i, j];
                B[i, j] = B[i, j - 1];
                B[i, j - 1] = temp;
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
        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue;
            double[] negative;
            int max_i = 0, max_j = 0, count = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    max_i = i;
                    max_j = j;
                }
                if (F[i, j] < 0) count++;
            }
            negative = new double[count];
            count = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    negative[count] = F[i, j];
                    count++;
                }
            }
            if (negative.Length > 1) F[max_i, max_j] = (negative[0] + negative[negative.Length - 1]) / 2;
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
        else
        {
            for (int i = 0; i < G.GetLength(0); i++)
            {
                int j_max = 0; int max = int.MinValue;
                for (int j = 0; j < G.GetLength(1); j++)
                {
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        j_max = j;
                    }
                }
                for (int j = G.GetLength(1) - 1; j > j_max; j--)
                {
                    G[i, j] = G[i, j - 1];
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
        int index = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A.GetLength(1) != B.Length) return null;
        else
        {
            for(int j = 5; j < 6; j++)
            {
                int maximum = int.MinValue;
                for(int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i,j] > maximum)
                    {
                        maximum = A[i, j];
                        index = i;
                    }
                }
            }
            for (int p = 0; p < 7; p++)
            {
                A[index,p] = B[p];
            }
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
        else
        {
            int index = 0;
            for (int i = 1; i < 2; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    if(min > Math.Abs(F[i, j]))
                    {
                        min = F[i,j];
                        index = j;
                    }
                }
            }
            int[,] E = new int[5, 6];
            for(int j = 0; j < E.GetLength(1); j++)
            {
                for(int i = 0; i < E.GetLength(0); i++)
                {
                    if (j <= index) E[i, j] = F[i, j];
                    else E[i, j] = F[i, j+1];
                }
            }
            F = E;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        else
        {
            for(int i = 0; i < A.GetLength(0); i++)
            {
                double max = double.MinValue; double summa = 0;
                int max_j = 0; int count = 0;
                double final = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        summa += A[i, j];
                        count++;
                    }
                }
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        max_j = j;
                    }
                }
                if (count != 0) final = summa / count;
                A[i, max_j] = final;
            }
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double max = double.MinValue;
                int max_index = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        max_index = j;
                    }
                }
                if (max_index == 0)
                {
                    if (A[i, max_index + 1] >= 0) A[i, max_index + 1] *= 2;
                    else A[i, max_index + 1] /= 2;
                }
                else if (max_index == A.GetLength(1) - 1)
                {
                    if (A[i, max_index - 1] >= 0) A[i, max_index - 1] *= 2;
                    else A[i, max_index - 1] /= 2;
                }
                else
                {
                    if (A[i, max_index - 1] < A[i, max_index + 1])
                    {
                        if (A[i, max_index - 1] >= 0) A[i, max_index - 1] *= 2;
                        else A[i, max_index - 1] /= 2;
                    }
                    else
                    {
                        if (A[i, max_index + 1] >= 0) A[i, max_index + 1] *= 2;
                        else A[i, max_index + 1] /= 2;
                    }
                }
            }
        }
        else return null;
        
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int p_count = 0, n_count = 0, index = 0;
                int max = int.MinValue;
                for(int i = 0;  i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = i;
                    }
                    if (A[i, j] > 0) p_count++;
                    if (A[i, j] < 0) n_count++;
                }
                if (p_count > n_count) A[index, j] = 0;
                else A[index,j] = index+1;
            }
        }
         // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        else
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                int max = int.MinValue, index = 0, summa = 0;
                for(int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = i;
                    }
                }
                if(index <= A.GetLength(0) / 2)
                {
                    for (int i = index + 1; i < A.GetLength(0); i++) summa += A[i, j];
                    A[0, j] = summa;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int max = int.MinValue, index = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = i;
                    }
                }
                if (B[j] > A[index, j])
                {
                    A[index, j] = B[j];
                }
            }
            // end
        }
            return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                double max = double.MinValue;
                int index = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = i;
                    }
                }
                double sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
                if (sum > A[index, j]) A[index, j] = sum;
                else A[index, j] = index + 1;
            }
            // end
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n > 0)
        {
            answer = new int[n, 3 * n];
            for (int i = 0; i < answer.GetLength(1); i++)
            {
                answer[i%3, i] = 1;
            }
        }
        else return null;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        else
        {
            int max = int.MinValue, max_i = 0, max_j = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (A[i, j] > max)
                        {
                            max = A[i, j];
                            max_i = i;
                            max_j = j;
                        }
                    }
                }
            }
            for (int i = 0; i < max_i; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        A[i, j] = 0;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int[] values = new int[6];
        int[] indexes_i = new int[6];
        int[] indexes_j = new int[6];
        int count = 0;
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        else
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                int max = int.MinValue, index_i = 0, index_j = 0;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                        index_i = i;
                        index_j = j;
                    }

                }
                values[count] = max;
                indexes_i[count] = index_i;
                indexes_j[count] = index_j;
                count++;
            }
            for (int i = 0; i < 6; i+=2)
            {
                int temp = values[i];
                B[indexes_i[i], indexes_j[i]] = temp;
                B[indexes_i[i], indexes_j[i]] = B[indexes_i[i + 1], indexes_j[i + 1]];
                B[indexes_i[i + 1], indexes_j[i + 1]] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        else
        {

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1) / 2; j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[i, A.GetLength(1) - 1 - j];
                    A[i, A.GetLength(1) - 1 - j] = temp;
                }
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
        else
        {
            int[] minimum = new int[matrix.GetLength(0)];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = int.MaxValue;
                int index = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < min)
                    {
                        min = matrix[i,j];
                        index = i;
                    }
                }
                minimum[i] = min;
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0) -1 - i; j++)
                {
                    if (minimum[j] < minimum[j + 1])
                    {
                        int temp = minimum[j + 1];
                        minimum[j + 1] = minimum[j];
                        minimum[j] = temp;
                        for (int p = 0; p < matrix.GetLength(1); p++)
                        {
                            temp = matrix[j, p];
                            matrix[j, p] = matrix[j + 1, p];
                            matrix[j + 1, p] = temp;
                        }
                    }
                }
            }
        }
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
        answer = new int[2 * matrix.GetLength(0) - 1];
        for (int i = 0; i < 2 * matrix.GetLength(0) - 1; i++) 
        {
            answer[i] = 0;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(0); j++)
            {
                answer[j - i + (matrix.GetLength(0) - 1)] += matrix[i, j];
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
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || k <= 0) return null;
        int row = 0, column = 0, x = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[row, column]))
                {
                    row = i;
                    column = j;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            x = matrix[i, column];
            matrix[i, column] = matrix[i, k - 1];
            matrix[i, k - 1] = x;
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            x = matrix[row, i];
            matrix[row, i] = matrix[k-1, i];
            matrix[k-1, i] = x;
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
        if (A.Length != ((n + 1) * n / 2) || B.Length != ((n + 1) * n / 2)) return null;
        else
        {
            answer = new int[n * n];
            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            int[,] matrix = new int[n, n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matrixA[i, j] = A[index];
                    matrixB[i, j] = B[index];
                    matrixA[j, i] = A[index];
                    matrixB[j, i] = B[index];
                    index++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        matrix[i, j] += matrixA[i, p] * matrixB[p, j];
                    }
                    answer[i*n + j] = matrix[i,j];
                }
            }
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
        else
        {
            int[] count = new int[7];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int local_count = 0;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,j] < 0)
                    {
                        local_count++;
                    }
                }
                count[j] = local_count;
            }
            for (int j = 0; j < 7; j++)
            {
                for(int i = 0;i < 5; i++)
                {
                    if (count[i] > count[i + 1])
                    {
                        int temp = count[i + 1];
                        count[i+1] = count[i];
                        count[i] = temp;
                        for(int p = 0; p < 5; p++)
                        {
                            temp = matrix[p,i];
                            matrix[p, i] = matrix[p, i+1];
                            matrix[p, i+1] = temp;
                        }
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
        int n = matrix.GetLength(0);
        int[] exist = new int[n];
        bool check;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            check = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    n--;
                    check = false;
                    break;
                }
            }
            if(check == true)
            {
                exist[i] = 1;
            }
        }
        int[,] result = new int[n, matrix.GetLength(1)];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (exist[i] == 1)
                {
                    result[count, j] = matrix[i, j];
                }
            }
            count++;
        }
        matrix = result;
        // end

        return matrix;
    }
    #endregion
}