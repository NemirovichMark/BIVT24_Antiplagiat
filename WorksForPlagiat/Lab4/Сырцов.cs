using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
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
        if (A.GetLength(0) < 4 || A.GetLength(1) < 4) return 0;
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
        int[] x = new int[4];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return answer;
        for (int i = 0; i < 4; i++)
        {
            int minElement = int.MaxValue;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < minElement)
                {
                    minElement = A[i, j];
                    x[i] = j;
                }
            }
        }
        // end

        return x;
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
            int maxElement = A[i, 0];
            int maxIndex = 0;
            for (int j = 1; j < 7; j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    maxIndex = j;
                }
            }
            int x = A[i, 0];
            A[i, 0] = maxElement;
            A[i, maxIndex] = x;
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
        int[,] answer = new int[5, 6];
        int maxElement = int.MinValue;
        int max_i = -1;
        int max_j = -1;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    max_i = i;
                    max_j = j;
                }
            }
        }
        int ii = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == max_i) continue;
            int jj = 0;
            for (int j = 0; j < 7; j++)
            {
                if (j == max_j) continue;
                answer[ii, jj] = A[i, j];
                jj++;
            }
            ii++;
        }
        // end

        return answer;
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
            int maxElement = int.MinValue;
            int index = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    index = j;
                }
            }
            A[i, index] = maxElement * (i + 1);
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
        if (D.GetLength(0) != n || D.GetLength(1) != m || D == null) return null;
        for (int i = 0; i < n; i++)
        {
            int maxElement = int.MinValue;
            int jMaxElement = -1;
            int indexFirstNegative = 0;
            int indexLastNegative = -1;
            int flag = 0;

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0 && flag == 0)
                {
                    indexFirstNegative = j;
                    flag = 1;
                }

                if (D[i, j] < 0)
                {
                    indexLastNegative = j;
                }
            }

            if (indexFirstNegative == 0) continue;

            for (int l = 0; l < indexFirstNegative; l++)
            {
                if (D[i, l] > maxElement)
                {
                    maxElement = D[i, l];
                    jMaxElement = l;
                }
            }

            int x = D[i, indexLastNegative];
            D[i, indexLastNegative] = D[i, jMaxElement];
            D[i, jMaxElement] = x;
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
        int[] maxElements = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int maxElement = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > maxElement)
                {
                    maxElement = H[i, j];
                }
            }
            maxElements[i] = maxElement;
        }

        int[] dop = new int[5];
        for (int i = 0; i < 5; i++)
        {
            dop[i] = H[i, 5];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 6] = dop[i];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 5] = maxElements[i];
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i = 0; i < 6; i++)
        {
            double sr = 0;
            double maxElement = double.MinValue;
            int indexMaxElement = 0;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > maxElement)
                {
                    maxElement = Y[i, j];
                    indexMaxElement = j;
                }
            }

            int count = 0;
            double sum = 0;
            for (int l = indexMaxElement + 1; l < 5; l++)
            {
                if (Y[i, l] > 0)
                {
                    count++;
                    sum += Y[i, l];
                }
            }

            if (count == 0)
            {
                sr = 0;
            }
            else
            {
                sr = Math.Round(sum / count, 2);
            }

            for (int h = 0; h < indexMaxElement; h++)
            {
                if (Y[i, h] < 0)
                {
                    Y[i, h] = sr;
                }
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

        int[] array = new int[5];
        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            int maxElement = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > maxElement)
                {
                    maxElement = B[i, j];
                }
            }
            array[index] = maxElement;
            index++;
        }

        index = 0;
        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = array[4 - index];
            index++;
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int indexFirstStr = -1;
        int maxElement = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > maxElement)
            {
                indexFirstStr = i;
                maxElement = B[i, i];
            }
        }
        int indexSecondStr = -1;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, 2] < 0)
            {
                indexSecondStr = i;
                break;
            }
        }
        if (indexSecondStr == -1) return B;

        for (int i = 0; i < 5; i++)
        {
            int x = B[indexFirstStr, i];
            B[indexFirstStr, i] = B[indexSecondStr, i];
            B[indexSecondStr, i] = x;
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

        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) count++;
            }
        }
        if (count == 0) return null;
        int[] x = new int[count];
        int index = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    x[index] = A[i, j];
                    index++;
                }
            }
        }
        // end

        return x;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            double maxElem = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                }
            }
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] == maxElem && j != 7 - 1 && j != 0)
                {
                    if (A[i, j + 1] < A[i, j - 1])
                    {
                        j++;
                    }
                    else
                    {
                        j--;
                    }
                    if (A[i, j] > 0)
                    {
                        A[i, j] *= 2;
                    }
                    else
                    {
                        A[i, j] /= 2;
                    }
                    break;
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

        for (int j = 0; j < 5; j++)
        {
            int maxElement = int.MinValue;
            int iMaxElement = -1;
            int jMaxElement = -1;
            int countNegative = 0;
            int countPlus = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    iMaxElement = i;
                    jMaxElement = j;
                }
                if (A[i, j] < 0) countNegative++;
                else countPlus++;
            }
            if (countPlus > countNegative)
            {
                A[iMaxElement, jMaxElement] = 0;
            }
            else
            {
                A[iMaxElement, jMaxElement] = iMaxElement + 1;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            if (index < 5 && index != 0)
            {
                int sum = 0;
                for (int i = index + 1; i < 10; i++)
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
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return null;
        if (B.Length != 5) return null;

        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > max)
                {
                    index = i;
                    max = A[i, j];
                }
            }
            if (B[j] > A[index, j])
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
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++)
        {
            double max = int.MinValue;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > max)
                {
                    index = i;
                    max = A[i, j];
                }
            }
            double sum = Math.Round((A[0, j] + A[6, j]) / 2, 2);
            if (max < sum)
            {
                A[index, j] = sum;
            }
            else
            {
                A[index, j] = index + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n < 0) return null;

        answer = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, n + i] = 1;
            answer[i, 2 * n + i] = 1;
        }

        // end
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int maxElem = int.MinValue;
        int indexElem = -1;

        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxElem)
            {
                maxElem = A[i, i];
                indexElem = i;
            }
        }
        int test = 0;
        for (int i = 0; i < 6; i++)
        {
            test = i;
            if (test == indexElem) break;
            for (int j = 0; j < 6; j++)
            {
                if (j > i)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        for (int i = 0; i < 6; i += 2)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int firstI = -1;
            int secondI = -1;

            for (int j = 0; j < 6; j++)
            {
                if (first < B[i, j])
                {
                    first = B[i, j];
                    firstI = j;
                }
                if (second < B[i + 1, j])
                {
                    second = B[i + 1, j];
                    secondI = j;
                }
            }
            int k = first;
            B[i, firstI] = second;
            B[i + 1, secondI] = k;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 6; i++)
        {
            int[] str = new int[7];
            for (int j = 0; j < 7; j++)
            {
                str[j] = A[i, j];
            }

            int index = 6;
            for (int k = 0; k < 7; k++)
            {
                A[i, k] = str[index];
                index--;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5) return null;
        int[] minElements = new int[7];

        for (int i = 0; i < 7; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            minElements[i] = min;
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                if (minElements[j] < minElements[j + 1])
                {
                    int tempMin = minElements[j];
                    minElements[j] = minElements[j + 1];
                    minElements[j + 1] = tempMin;

                    for (int k = 0; k < 5; k++)
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

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int diagonalI = (n - 1) + (j - i);
                answer[diagonalI] += matrix[i, j];
            }
        }

        return answer;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0)) return null;

        int n = matrix.GetLength(0);
        int maxElement = matrix[0, 0];
        int indexI = -1;
        int indexJ = -1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(maxElement))
                {
                    maxElement = matrix[i, j];
                    indexI = i;
                    indexJ = j;
                }
            }
        }
        if (indexJ != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, indexJ];
                matrix[i, indexJ] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        if (indexI != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[indexI, j];
                matrix[indexI, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
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
        if (A.Length == 0 || B.Length == 0) return null;

        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];

        for (int i1 = 0, i2 = 0; i1 < n; i1++)
        {
            for (int j = i1; j < n; j++)
            {
                matrixA[i1, j] = A[i2];
                matrixB[i1, j] = B[i2];
                i2++;
            }
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                matrixA[i, j] = matrixA[j, i];
                matrixB[i, j] = matrixB[j, i];
            }
        }

        int[,] newM = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    newM[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        int[] answerNew = new int[newM.Length];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answerNew[i * n + j] = newM[i, j];
            }
        }

        // end

        return answerNew;
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

        
        int[] numbers = new int[matrix.GetLength(1)];
        int[] negativeCount = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0) count++;
            }
            numbers[j] = j;
            negativeCount[j] = count;
        }
        for (int i = 1, j = i + 1; i < matrix.GetLength(1);)
        {
            if (i == 0 || negativeCount[i] >= negativeCount[i - 1])
            {
                i = j;
                j++;
            }
            else if (negativeCount[i] < negativeCount[i - 1])
            {
                int dop = negativeCount[i];
                negativeCount[i] = negativeCount[i - 1];
                negativeCount[i - 1] = dop;
                int dop_num = numbers[i];
                numbers[i] = numbers[i - 1];
                numbers[i - 1] = dop_num;
                i--;
            }
        }

        int[,] newM = new int[5, 7];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                newM[i, j] = matrix[i, numbers[j]];
            }
        }
        matrix = newM;     
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

        int newI = matrix.GetLength(0) - count;
        int newJ = matrix.GetLength(1); 
        int[,] newM = new int[newI, newJ];  

        int ai = 0; 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newM[ai, j] = matrix[i, j];
                }
                ai++;
            }
        }

        return newM;
        #endregion
    }
}