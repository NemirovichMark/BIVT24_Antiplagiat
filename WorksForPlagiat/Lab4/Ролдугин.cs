using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
        PrintMatrix(program.Task_3_8(matrix));

    }
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString().PadRight(6)); // 6 символов на элемент для выравнивания
            }
            Console.WriteLine(); // Переход на новую строку после каждого ряда
        }
    }
    public void show(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine(A[i]);
        }
    }
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    #region Level 1
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        int sum = 0;
        double count = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) { return 0; }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    count++;
                    sum += A[i, j];
                }
            }
        }
        answer = sum / count;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) { return (0, 0); }
        Console.WriteLine(colIndex);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }


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
        int column = A.GetLength(0);
        int lines = A.GetLength(1);
        double[] answer = new double[column];
        if (column != 4 || lines != 6) { return default(double[]); }
        for (int i = 0; i < column; i++)
        {
            int sum = 0;
            double count = 0;
            for (int j = 0; j < lines; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            if (count != 0)
            {
                answer[i] = sum / count;
            }
            else
            {
                answer[i] = 0;
            }
        }

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
        int[,] A2 = new int[4, 7];
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(int[,]);
        int min = int.MaxValue;
        int mini = 0;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                mini = i;
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i < mini)
                {
                    A2[i, j] = A[i, j];
                }
                else if (i > mini)
                {
                    A2[i - 1, j] = A[i, j];
                }
            }
        }


        return A2;
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
        int[] answer = new int[3];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
        {
            return default(int[]);
        }
        for (int i = 0; i < 3; i++)
        {
            int count = 0;
            for (int j = 0; j < 4; j++)
            {
                if (A[j, i] < 0)
                {
                    count++;
                }
            }
            answer[i] = count;
        }
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

        int[,] B2 = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int min = int.MaxValue;
            int minJ = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    minJ = j;
                    min = B[i, j];
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (j == 0) B2[i, j] = min;
                else if (j <= minJ) B2[i, j] = B[i, j - 1];
                else if (j > minJ) B2[i, j] = B[i, j];
            }
        }

        return B2;
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
        for (int i = 0; i < n; i++)
        {
            int first = -1;
            int last = -1;
            double max = double.MinValue;
            int maxIndex = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0 && first == -1)
                {
                    first = j;
                    last = j;
                }
                else if (F[i, j] < 0 && first != -1)
                {
                    last = j;
                }
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    maxIndex = j;
                }
            }
            if (first != -1) F[i, maxIndex] = (F[i, first] + F[i, last]) / 2;

        }

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
        int[,] G2 = new int[G.GetLength(0), G.GetLength(1)];
        if (G.GetLength(0) != 5 || G2.GetLength(1) != 7) return default(int[,]);
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    maxIndex = j;
                }
            }
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                if (j < maxIndex)
                {
                    G2[i, j] = G[i, j];
                }
                else if (j == maxIndex)
                {
                    G2[i, j] = G[i, maxIndex];
                    G2[i, j + 1] = G[i, maxIndex];
                }
                else if (j > maxIndex)
                {
                    G2[i, j + 1] = G[i, j];
                }
            }
        }
        return G2;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return default(int[,]);
        int max = int.MinValue;
        int indexMax = 0;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                indexMax = i;
            }
        }
        for (int i = 0; i < 7; i++)
        {
            A[indexMax, i] = B[i];
        }
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return default(int[,]);
        int[,] F2 = new int[5, 6];
        int min = int.MaxValue;
        int indexMin = 0;
        for (int i = 0; i < 7; i++)
        {
            if (Math.Abs(F[1, i]) < min)
            {
                min = Math.Abs(F[1, i]);
                indexMin = i;
            }
        }
        indexMin += 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j < indexMin)
                {
                    F2[i, j] = F[i, j];
                }
                else if (j > indexMin)
                {
                    F2[i, j - 1] = F[i, j];
                }

            }
        }

        return F2;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < 5; i++)
        {
            double sum = 0;
            double count = 0;
            double max = double.MinValue;
            int maxIndex = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count += 1;
                }
            }
            if (count == 0)
            {
                A[i, maxIndex] = 0;
                continue;

            }
            A[i, maxIndex] = (sum / count);
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    index = j;
                }
            }
            if (index == 0)
            {
                if (A[i, 1] > 0)
                {
                    A[i, 1] *= 2;
                }
                else
                {
                    A[i, 1] /= 2;
                }
            }
            else if (index == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0)
                {
                    A[i, A.GetLength(1) - 2] *= 2;
                }
                else
                {
                    A[i, A.GetLength(1) - 2] /= 2;
                }
            }
            else if (A[i, index - 1] < A[i, index + 1])
            {
                if (A[i, index - 1] > 0)
                {
                    A[i, index - 1] *= 2;
                }
                else
                {
                    A[i, index - 1] /= 2;
                }
            }
            else if (A[i, index - 1] > A[i, index + 1])
            {
                if (A[i, index + 1] > 0)
                {
                    A[i, index + 1] *= 2;
                }
                else
                {
                    A[i, index + 1] /= 2;
                }
            }

        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default(int[,]);
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = int.MinValue;
            int indexMax = 0;
            int count_of_plus = 0;
            int count_of_minus = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > 0)
                {
                    count_of_plus++;
                }
                if (A[j, i] < 0) count_of_minus++;
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    indexMax = j;
                }
            }
            if (count_of_plus > count_of_minus) A[indexMax, i] = 0;
            else A[indexMax, i] = indexMax + 1;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int sum = 0;
            int maxIndex = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                    sum = 0;
                }

            }
            if (maxIndex < A.GetLength(0) / 2 - 1)
            {
                A[0, j] = sum;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int indexMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexMax = i;
                }
            }
            if (B[j] > A[indexMax, j]) A[indexMax, j] = B[j];
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default(double[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = double.MinValue;
            int indexMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexMax = i;
                }
            }
            double half_a_sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (A[indexMax, j] < half_a_sum) A[indexMax, j] = half_a_sum;
            else A[indexMax, j] = indexMax + 1;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return default(int[,]);
        int[,] matrix = {
            { 1, 0, 0 },
            { 0, 1, 0},
            { 0, 0, 1}
        }; //это примерная изначальная матрица (пример, т.к в методе не передается)

        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int s = 0; s <= 2; s++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[i, j + s * n] = matrix[i, j];
                }
            }
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int max = int.MinValue;
        int indexMax = 0;
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return default(int[,]);
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                indexMax = i;
            }
        }

        for (int i = 0; i < indexMax; i++)
        {
            for (int j = i + 1; j < 6; j++)
            {
                A[i, j] = 0;

            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default(int[,]);
        for (int i = 0; i < 5 ; i+=2)
        {
            int nechet = 0;
            int chet = 0;
            int nechetMax = int.MinValue;
            int chetMax = int.MinValue;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > nechetMax)
                {
                    nechetMax = B[i, j];
                    nechet = j;
                }
                if (B[i + 1, j] > chetMax)
                {
                    chetMax = B[i + 1, j];
                    chet = j;
                }

            }
            int temp = nechetMax;
            B[i, nechet] = chetMax;
            B[i + 1, chet] = temp;

        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default(int[,]);
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return default(int[,]);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return default(int[,]);
        int strok = matrix.GetLength(0);
        int stolb = matrix.GetLength(1);
        for (int i = strok / 2 - 1 + strok % 2; i < strok; i++)
        {
            for (int g = 0; g <= i; g++)
            {
                matrix[i, g] = 1;

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
        int[] upper = default(int[]);
        int f = 0, k = 0;
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return (null, null);
        upper = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2];
        int[] lower = default(int[]);
        lower = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2 + matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (i > g) upper[f++] = matrix[i, g];
                else lower[k++] = matrix[i, g];
            }
        }
        return (lower, upper);
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default(int[,]);
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (count_elements(j, matrix) < count_elements(j + 1, matrix))
                {
                    for (int s = 0; s < matrix.GetLength(1); s++)
                    {
                        int templ = matrix[j, s];
                        matrix[j, s] = matrix[j + 1, s];
                        matrix[j + 1, s] = templ;
                    }
                }
            }

        }

        return matrix;
    }
    int count_elements(int strok, int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[strok, i] > 0) count++;
        }
        return count;

    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j += 1)
                {
                    for (int j1 = 0; j1 < matrix.GetLength(1) - j - 1; j1 += 1)
                    {
                        if (matrix[i, j1] < matrix[i, j1 + 1])
                        {
                            int t = matrix[i, j1];
                            matrix[i, j1] = matrix[i, j1 + 1];
                            matrix[i, j1 + 1] = t;
                        }
                    }
                }
            }
            if (i % 2 != 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j += 1)
                {
                    for (int j1 = 0; j1 < matrix.GetLength(1) - j - 1; j1 += 1)
                    {
                        if (matrix[i, j1] > matrix[i, j1 + 1])
                        {
                            int t = matrix[i, j1];
                            matrix[i, j1] = matrix[i, j1 + 1];
                            matrix[i, j1 + 1] = t;
                        }
                    }
                }
            }

        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine(count);
        int s = 0;
        int[,] new_matrix = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            bool flag = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                new_matrix[s, j] = matrix[i, j];
                if (matrix[i, j] == 0)
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(s);
            if (s == new_matrix.GetLength(0) - 1) break;
            if (flag) s++;

        }
        PrintMatrix(new_matrix);
        return new_matrix;
    }
    #endregion
}