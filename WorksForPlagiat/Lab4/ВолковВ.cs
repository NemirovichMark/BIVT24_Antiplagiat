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
        int size_stroke = A.GetLength(0);
        int size_cols = A.GetLength(1);

        if (size_cols * size_stroke != 16) return answer;

            for (int i = 0; i < 4; i++)
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
        int[] answer = default(int[]);
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1); 

        if (rows != 4 || cols != 7) return default;

        answer = new int[rows]; 
        
        for (int i = 0; i < rows; i++)
        {
            int min = A[i, 0];
            int index = 0;
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    index = j;
                }
            }
            answer[i] = index; 
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
        int rows = A.GetLength(0); 
        int cols = A.GetLength(1); 

        if (rows != 5 || cols != 7) return default;

        for (int i = 0; i < rows; i++)
        {
            int maxIndex = 0; 
            int maxValue = A[i, 0]; 

            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j]; 
                    maxIndex = j; 
                }
            }

            if (maxIndex != 0) 
            {
                int temp = A[i, 0]; 
                A[i, 0] = A[i, maxIndex]; 
                A[i, maxIndex] = temp; 
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        // Проверка на размер матрицы
        if (rows != 6 || cols != 7) return default;

        int maxValue = A[0, 0];
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int[,] newMatrix = new int[rows - 1, cols - 1];

        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == maxRow) continue;
            for (int j = 0, newCol = 0; j < cols; j++)
            {
                if (j == maxCol) continue;
                newMatrix[newRow, newCol] = A[i, j];
                newCol++;
            }
            newRow++;
        }

        A = newMatrix;
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7) return default;

        for (int i = 0; i < rows; i++)
        {
            int maxValue = A[i, 0];
            int maxCol = 0;

            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    maxCol = j;
                }
            }

            A[i, maxCol] *= (i + 1);
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
        if (D.GetLength(0) != n || D.GetLength(1) != m) return default;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxindexj = -1;
            int negindexj1 = -1; // Индекс первого отрицательного
            int negindexj2 = -1; // Индекс последнего отрицательного

            for (int j = D.GetLength(1) - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    negindexj2 = j;
                    break;
                }
            }

            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    negindexj1 = j;
                    break;
                }
            }

            if (negindexj1 == -1) continue;
            for (int j = 0; j < negindexj1; j++)
            {
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    maxindexj = j;
                }
            }

            if (maxindexj != -1 && negindexj2 != -1)
            {
                int temp = D[i, maxindexj];
                D[i, maxindexj] = D[i, negindexj2];
                D[i, negindexj2] = temp;
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return default;

        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0]; 

            for (int j = 1; j < 6; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }

            int temp = max;
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = temp;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return default;

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0];
            int maxindexj = 0;

            for (int j = 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    maxindexj = j;
                }
            }

            double sum = 0;
            int count = 0;
            for (int j = maxindexj + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    sum += Y[i, j];
                    count++;
                }
            }

            double avarage = (count == 0) ? 0 : sum / count;

            for (int j = 0; j < maxindexj; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = avarage;
                }
            }
        }
        // end

        return Y; // Возвращаем измененную матрицу
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return default;
      
        int[] maxElements = new int[B.GetLength(0)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[i, 0];

            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            maxElements[i] = max; 
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = maxElements[B.GetLength(0) - 1 - i];
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return default;

        int maxDiagonalValue = int.MinValue;
        int maxDiagonalRowIndex = -1;

        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > maxDiagonalValue)
            {
                maxDiagonalValue = B[i, i];
                maxDiagonalRowIndex = i;
            }
        }

        int negativeRowIndex = -1;

        for (int i = 0; i < 5; i++)
        {
            if (B[i, 2] < 0)
            {
                negativeRowIndex = i;
                break;
            }
        }

        if (negativeRowIndex != -1 && maxDiagonalRowIndex != -1)
        {
            for (int j = 0; j < 5; j++)
            {
                int temp = B[maxDiagonalRowIndex, j];
                B[maxDiagonalRowIndex, j] = B[negativeRowIndex, j];
                B[negativeRowIndex, j] = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;

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

        answer = new int[count];
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
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int index = 0;

            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }

            double temp;

            if (A[i, index + 1] > A[i, index - 1] || index == A.GetLength(1) - 1)
            {
                temp = A[i, index - 1];
                temp = temp >= 0 ? temp *= 2 : temp /= 2;
                A[i, index - 1] = temp;
            }
            else if (A[i, index + 1] < A[i, index - 1] || index == 0)
            {
                temp = A[i, index + 1];
                temp = temp >= 0 ? temp *= 2 : temp /= 2;
                A[i, index + 1] = temp;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int maxElement = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                {
                    positiveCount++;
                }
                else if (A[i, j] < 0)
                {
                    negativeCount++;
                }

                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            A[maxIndex, j] = positiveCount > negativeCount ? 0 : maxIndex + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return default;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            if (maxIndex < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = maxIndex + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default;
        
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int index = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (B[j] > max)
            {
                A[index, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = A[0, j];
            int index = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            
            double halfsum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;

            A[index, j] = (max < halfsum) ? halfsum : index + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return default;

        answer = new int[n, 3 * n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = count; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
            count++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return default;

        int max = A[0, 0];
        int index = 0;

        for (int i = 0; i < 6; i++) 
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                index = i;
            }
        }

        for (int i = 0; i < index; i++) 
        {
            for (int j = i + 1; j < 6; j++) 
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default;

        for (int i = 0; i < 6; i += 2)
        {
            int maxFirstRow = B[i, 0];
            int maxSecondRow = B[i + 1, 0];
            int indexMaxFirstRow = 0;
            int indexMaxSecondRow = 0;

            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxFirstRow)
                {
                    maxFirstRow = B[i, j];
                    indexMaxFirstRow = j;
                }

                if (B[i + 1, j] > maxSecondRow)
                {
                    maxSecondRow = B[i + 1, j];
                    indexMaxSecondRow = j;
                }
            }

            int temp = B[i, indexMaxFirstRow];
            B[i, indexMaxFirstRow] = B[i + 1, indexMaxSecondRow];
            B[i + 1, indexMaxSecondRow] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = temp;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;

        for (int i = 0; i < matrix.Length; i++)
        {
            int row = i / matrix.GetLength(1);
            int col = i % matrix.GetLength(1);

            if (row == 0 || row == matrix.GetLength(0) - 1 || col == 0 || col == matrix.GetLength(1) - 1)
            {
                matrix[row, col] = 0; 
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols) return default;
        
        for (int i = rows / 2; i < rows; i++)
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols) return default;

        int upperSize = 0;
        int lowerSize = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j++)
            {
                upperSize++;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lowerSize++;
            }
        }

        upper = new int[upperSize];
        lower = new int[lowerSize];

        int l = 0; // Индекс для верхнего треугольника
        int k = 0; // Индекс для нижнего треугольника

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i <= j) // Верхний треугольник (включая диагональ)
                {
                    upper[l] = matrix[i, j];
                    l++;
                }
                else if (i >= j) // Нижний треугольник
                {
                    lower[k] = matrix[i, j];
                    k++;
                }
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        if (rows != 7 || cols != 5) return default;

        for (int i = 0; i < 6; i++) 
        {
            for (int j = 0; j < 6 - i; j++)
            {
                int currentCount = 0, nextCount = 0;

                for (int k = 0; k < cols; k++)
                {
                    if (matrix[j, k] > 0) currentCount++;
                    if (matrix[j + 1, k] > 0) nextCount++;
                }

                if (currentCount < nextCount)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                }
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    for (int k = 0; k < cols - 1 - j; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1]) 
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    for (int k = 0; k < cols - 1 - j; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1]) 
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int count = 0;

        // Подсчет строк, содержащих нулевые элементы
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }

        int[,] A = new int[rows - count, cols];
        int k = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0) break; 
                A[k, j] = matrix[i, j];
            }

            k++;
            if (k >= rows - count) break; 
        }

        matrix = A;
        // end

        return matrix;
    }
    #endregion
}