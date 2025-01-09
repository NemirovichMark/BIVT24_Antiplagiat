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

    public void increaseElem(ref int a)
    {
        if (a > 0)
        {
            a *= 2;
        } else
        {
            a /= 2;
        }
    }
    public void increaseElem(ref double a)
    {
        if (a > 0)
        {
            a *= 2;
        }
        else
        {
            a /= 2;
        }
    }

    public bool validateArray(int[] A, int len)
    {
        return A.Length == len;
    }
    public bool validateArray(double[] A, int len)
    {
        return A.Length == len;
    }

    public bool validateMatrix(int[,] A, int rows, int cols)
    {
        return A.GetLength(0) == rows && A.GetLength(1) == cols;
    }

    public bool validateMatrix(double[,] A, int rows, int cols)
    {
        return A.GetLength(0) == rows && A.GetLength(1) == cols;
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
        if (!validateMatrix(A, 5, 7))
        {
            return 0;
        }
        int posCnt = 0;
        double posSum = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    posSum += A[i, j];
                    posCnt++;
                }
            }
        }
        if (posCnt == 0)
        {
            return 0;
        }
        answer = posSum / posCnt;
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
        if (!validateMatrix(A, 5, 4))
        {
            return (0, 0);
        }
        if (colIndex >= 4)
        {
            return (0, 0);
        }

        for (int i = 0; i < 5; i++)
        {
            if (A[i, colIndex] < 0)
            {
                return (A[i, colIndex], i);
            }
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

        if (!validateMatrix(A, 4, 6))
        {
            return null;
        }

        answer = new double[4];

        for (int i = 0; i < 4; i++)
        {
            int positiveCount = 0;
            double sum = 0;

            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    positiveCount++;
                }
            }

            if (positiveCount > 0)
            {
                answer[i] = sum / positiveCount;
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
        // code here
        if (!validateMatrix(A, 5, 7))
        {
            return null;
        }

        int minVal = int.MaxValue;
        int minIdx = -1;

        for (int i = 0; i < 5; i++)
        {
            if (A[i, 0] < minVal)
            {
                minVal = A[i, 0];
                minIdx = i;
            }
        }

        int[,] answer = new int[4, 7];

        int rowIter = 0;
        for (int i = 0; i < 5; i++)
        {
            if (i == minIdx)
            {
                continue;
            }
            for (int j = 0; j < 7; j++)
            {
                answer[rowIter, j] = A[i, j];
            }
            rowIter++;
        }

        A = answer;

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
        if (!validateMatrix(A, 4, 3))
        {
            return null;
        }

        answer = new int[3];
        for (int i = 0; i < 3; i++)
        {
            int negCnt = 0;
            for (int j = 0; j < 4; j++)
            {
                if (A[j, i] < 0)
                {
                    negCnt++;
                }
            }
            answer[i] = negCnt;
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
        if (!validateMatrix(B, n, m))
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            int minIdx = -1;
            int minVal = int.MaxValue;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < minVal)
                {
                    minVal = B[i, j];
                    minIdx = j;
                }
            }
            for (int j = minIdx; j > 0; j--)
            {
                int temp = B[i, j - 1];
                B[i, j - 1] = B[i, j];
                B[i, j] = temp;
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
        if (!validateMatrix(F, n, m))
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            int firstNeg = -1, lastNeg = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxElem)
                {
                    maxElem = F[i, j];
                    maxIdx = j;
                }
                if (F[i, j] < 0)
                {
                    if (firstNeg == -1)
                    {
                        firstNeg = j;
                    }
                    lastNeg = j;
                }
            }
            if (firstNeg == -1)
                continue;
            F[i, maxIdx] = (F[i, firstNeg] + F[i, lastNeg]) / 2.0;
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
        if (!validateMatrix(G, 5, 7))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            int maxIdx = -1;
            int maxValue = int.MinValue;
            for (int j = 0; j < 6; j++)
            {
                if (G[i, j] > maxValue)
                {
                    maxValue = G[i, j];
                    maxIdx = j;
                }
            }
            for (int j = 6; j > maxIdx + 1; j--)
            {
                int temp = G[i, j - 1];
                G[i, j - 1] = G[i, j];
                G[i, j] = temp;
            }
            G[i, maxIdx + 1] = maxValue;
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
        if (!validateMatrix(A, 5, 7))
        {
            return null;
        }

        if (!validateArray(B, 7))
        {
            return null;
        }
        int maxIDx = -1;
        int maxVal = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            
            if (A[i, 5] > maxVal)
            {
                maxVal = A[i, 5];
                maxIDx = i;
            } 
        }

        for (int j = 0; j < 7; j++)
        {
            A[maxIDx, j] = B[j]; 
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
        if (!validateMatrix(F, 5, 7))
        {
            return null;
        }

        int minIdx = -1;
        int minVal = int.MaxValue;
        for (int i = 0; i < 7; i++)
        {
            if (Math.Abs(F[1, i]) < minVal)
            {
                minVal = Math.Abs(F[1, i]);
                minIdx = i;
            }
        }
        int[,] answer = new int[5, 6];
        int iterCol = 0;

        if (minIdx == 4)
        {
            return F;
        }
        for (int i = 0; i < 7; i++)
        {
            
            if (i == minIdx + 1)
            {
                continue;
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
                answer[j, iterCol] = F[j, i];
            }
            iterCol++;
        }

        F = answer;

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
        if (!validateMatrix(A, 5, 7))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            int maxIdx = -1;
            double maxVal = double.MinValue;
            double posSum = 0;
            int posCnt = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxIdx = j;
                }
                if (A[i, j] > 0)
                {
                    posCnt++;
                    posSum += A[i, j];
                }
            }
            A[i, maxIdx] = posSum;
            if (posCnt != 0)
                A[i, maxIdx] /= posCnt;
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
        if (!validateMatrix(A, 5, 7))
        {
            return null;
        }
        
        for (int i = 0; i < 5; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    maxIdx = j;
                }
            }
            if (maxIdx == 0)
            {
                increaseElem(ref A[i, 1]);
                continue;
            }
            if (maxIdx == 6)
            {
                increaseElem(ref A[i, 5]);
                continue;
            }
            if (A[i, maxIdx - 1] < A[i, maxIdx + 1])
            {
                increaseElem(ref A[i, maxIdx - 1]);
            } else
            {
                increaseElem(ref A[i, maxIdx + 1]);
            }
        
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (!validateMatrix(A, 7, 5))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            int posCnt = 0, negCnt = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxElem)
                {
                    maxElem = A[j, i];
                    maxIdx = j;
                }
                if (A[j, i] > 0)
                {
                    posCnt++;
                } else if (A[j, i] < 0)
                {
                    negCnt++;
                }
            }
            if (posCnt > negCnt)
            {
                A[maxIdx, i] = 0;
            } else
            {
                A[maxIdx, i] = maxIdx + 1;
            }
            
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (!validateMatrix(A, 10, 5))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > maxElem)
                {
                    maxElem = A[j, i];
                    maxIdx = j;
                }
                if (maxIdx > 4)
                {
                    break;
                }
            }
            if (maxIdx > 4)
            {
                continue;
            }

            int elemSum = 0;
            for (int j = maxIdx + 1; j < 10; j++)
            {
                elemSum += A[j, i];
            }
            A[0, i] = elemSum;

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (!validateMatrix(A, 7, 5))
        {
            return null;
        }

        if (!validateArray(B, 5))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxElem)
                {
                    maxElem = A[j, i];
                    maxIdx = j;
                }
            }
            if (maxElem < B[i])
            {
                A[maxIdx, i] = B[i];
            }

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (!validateMatrix(A, 7, 5))
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxElem)
                {
                    maxElem = A[j, i];
                    maxIdx = j;
                }
            }
            double avgSum = (A[0, i] + A[6, i]) / 2.0;
            if (maxElem < avgSum)
            {
                A[maxIdx, i] = avgSum;
            } else
            {
                A[maxIdx, i] = maxIdx + 1;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return null;
        }
        answer = new int[n, 3 * n];

        for (int i = 0; i < 3; i ++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j, i * n + j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (!validateMatrix(A, 6, 6))
        {
            return null;
        }

        int maxIdx = -1;
        int maxVal = int.MinValue;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxVal)
            {
                maxVal = A[i, i];
                maxIdx = i;
            }
        }

        for (int i = 0; i < maxIdx; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < j)
                {
                    A[i, j] = 0;
                }
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (!validateMatrix(B, 6, 6))
        {
            return null;
        }

        for (int i = 0; i < 6; i += 2)
        {
            Console.WriteLine(i);
            int maxIdx1 = -1;
            int maxVal1 = int.MinValue;

            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxVal1)
                {
                    maxVal1 = B[i, j];
                    maxIdx1 = j;
                }
            }

            int maxIdx2 = -1;
            int maxVal2 = int.MinValue;

            for (int j = 0; j < 6; j++)
            {
                if (B[i + 1, j] > maxVal2)
                {
                    maxVal2 = B[i + 1, j];
                    maxIdx2 = j;
                }
            }
            int temp = B[i, maxIdx1];
            B[i, maxIdx1] = B[i + 1, maxIdx2];
            B[i + 1, maxIdx2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (!validateMatrix(A, 6, 7))
        {
            return null;
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }
        // end

        return A;
    }
    #endregion

    #region Level 3

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0); // Получаем количество строк
        int cols = matrix.GetLength(1); // Получаем количество столбцов

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t"); // Вывод элементов матрицы
            }
            Console.WriteLine(); // Переход на следующую строку
        }
    }
    public static int[,] SymMatrix(int[] upper, int size)
    {
        int[,] matrix = new int[size, size];

        int index = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i; j < size; j++)
            {
                matrix[i, j] = upper[index]; 
                matrix[j, i] = upper[index]; 
                index++;
            }
        }

        return matrix;
    }

    public static void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);
        for (int i = 0; i < cols; i++)
        {
            int temp = matrix[row1, i];
            matrix[row1, i] = matrix[row2, i];
            matrix[row2, i] = temp;
        }
    }

    public static void SwapCols(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (!validateMatrix(matrix, 7, 5))
        {
            return null;
        }

        int rows = 7;
        int cols = 5;

        int[] minElems = new int[rows];
        int[] rowIdxs = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            minElems[i] = matrix[i, 0];
            rowIdxs[i] = i; 
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] < minElems[i])
                {
                    minElems[i] = matrix[i, j];
                }
            }
        }

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                if (minElems[i] < minElems[j])
                {
                    int tempMin = minElems[i];
                    minElems[i] = minElems[j];
                    minElems[j] = tempMin;

                    int tempIndex = rowIdxs[i];
                    rowIdxs[i] = rowIdxs[j];
                    rowIdxs[j] = tempIndex;
                }
            }
        }

        int[,] sortedMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sortedMatrix[i, j] = matrix[rowIdxs[i], j];
            }
        }

        matrix = sortedMatrix;
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n <= 0)
        {
            return null;
        }

        answer = new int[2 * n - 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[n - 1 - (i - j)] += matrix[i, j];
            }
        }

        for (int i = 0; i < 2 * n -1; i++)
        {
            Console.Write($"{answer[i]} ");
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
        if (n != matrix.GetLength(1) || n <= 0)
        {
            return null;
        }

        if (k < 1 || k > n)
        {
            return null;
        }

        int maxCol = -1, maxRow = -1;
        int maxVal = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > maxVal)
                {
                    maxVal = Math.Abs(matrix[i, j]);
                    maxCol = j;
                    maxRow = i;
                }
            }
        }

        SwapCols(matrix, maxCol, k - 1);
        SwapRows(matrix, maxRow, k - 1);
       
        PrintMatrix(matrix);
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
        if (!validateArray(A, n * (n+1)/2))
        {
            return null;
        }
        
        if (!validateArray(B, n * (n + 1) / 2))
        {
            return null;
        }
        int[,] matrixA = SymMatrix(A, n);
        int[,] matrixB = SymMatrix(B, n);
        PrintMatrix(matrixA);
        PrintMatrix(matrixB);

        answer = new int[n * n]; 

        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                int sum = 0;
                for (int k = 0; k < n; k++) 
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"{sum} ");
                answer[i * n + j] = sum; 
            }
            Console.WriteLine();
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
        if (!validateMatrix(matrix, 5, 7))
        {
            return null;
        }

        int rows = 5;
        int cols = 7;

        int[] negCnts = new int[cols];
        int[] colIdxs = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            colIdxs[j] = j;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < 0)
                {
                    negCnts[j]++;
                }
            }
        }

        for (int i = 0; i < cols - 1; i++)
        {
            for (int j = 0; j < cols - i - 1; j++)
            {
                if (negCnts[colIdxs[j]] > negCnts[colIdxs[j + 1]])
                {
                   
                    int temp = colIdxs[j];
                    colIdxs[j] = colIdxs[j + 1];
                    colIdxs[j + 1] = temp;
                }
            }
        }

        int[,] sortedMatrix = new int[rows, cols];

       
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                sortedMatrix[i, j] = matrix[i, colIdxs[j]];
            }
        }

        matrix = sortedMatrix;
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
        int rowCnt = 0;
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    rowCnt++;
                    break;
                }
            }
        }
        if (rowCnt == 0) {
            return matrix;
        }
        int iter = 0;
        int[,] answer = new int[rows - rowCnt, cols];
        for (int i = 0; i < rows; i++)
        {   
            if (iter == rows - rowCnt)
            {
                break;
            }
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Row {i} Cols{j}");
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                } else
                {
                    answer[iter, j] = matrix[i, j];
                }
            }
            if (!hasZero)
            {
                iter++;
            }
            Console.WriteLine($"Iter {iter}");
        }

        matrix = answer;

        // end

        return matrix;
    }
    #endregion
}