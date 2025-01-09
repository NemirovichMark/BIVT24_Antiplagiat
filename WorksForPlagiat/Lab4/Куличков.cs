using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
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
        if (A.GetLength(0) != A.GetLength(1)) return 0;
        for (int i = 0; i < A.GetLength(0); i++)
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
        int lines = A.GetLength(0);
        int cols = A.GetLength(1);
        if (lines != 4 || cols != 7) return answer;
        answer = new int[lines];
        for(int i = 0; i < lines; i++)
        {
            int min = A[i, 0];
            int minIndex = 0;
            for(int j = 1; j < cols; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    minIndex = j;
                }
            }
            answer[i] = minIndex;
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
        int lines = A.GetLength(0);
        int cols = A.GetLength(1);
        if (lines != 5 || cols != 7) return null;
        for (int i = 0; i < lines; i++)
        {
            int max = A[i, 0];
            int maxIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }
            int P = A[i, 0];
            A[i, 0] = A[i, maxIndex];
            A[i, maxIndex] = P;
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
        int lines = A.GetLength(0);
        int cols = A.GetLength(1);
        if (lines != 6 || cols != 7) return null;

        int max = A[0, 0];
        int lineIndex = 0;
        int colIndex = 0;
        for (int i = 1; i < lines; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > max) {
                    max = A[i, j];
                    lineIndex = i;
                    colIndex = j;
                }
            }
        }

        int[,] newA = new int[lines-1, cols-1];
        for (int i = 0; i < lines-1; i++)
        {
            for (int j = 0; j < cols-1; j++)
            {
                if (i < lineIndex)
                {
                    newA[i, j] = j < colIndex ? A[i, j] : A[i, j + 1];
                }
                else
                {
                    newA[i, j] = j < colIndex ? A[i + 1, j] : A[i + 1, j + 1];
                }
            }
        }

        A = newA;
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
        int lines = A.GetLength(0);
        int cols = A.GetLength(1);
        if (lines != 5 || cols != 7) return null;

        for (int i = 0; i < lines; i++)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }
            A[i, maxIndex] = max * (i+1);
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
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0) break;
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    maxIndex = j;
                }
            }
            int lastOtrIndex = -1;
            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    lastOtrIndex = j;
                    break;
                }
            }
            if (maxIndex != -1 && lastOtrIndex != -1)
            {
                int P = D[i, maxIndex];
                D[i, maxIndex] = D[i, lastOtrIndex];
                D[i, lastOtrIndex] = P;
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > max) max = H[i, j];
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max;
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
            int maxIndex = 0, count = 0;
            double max = double.MinValue, sumPost = 0;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    maxIndex = j;
                    sumPost = 0;
                    count = 0;
                }
                else if (Y[i, j] > 0) { sumPost += Y[i, j]; count++; }
            }
            double avg = count == 0 ? 0 : sumPost / count;
            for (int j = 0; j <  maxIndex; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = avg;
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

        int[] max = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int lineMax = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > lineMax) lineMax = B[i, j];
            }
            max[5 - i - 1] = lineMax;
        }
        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = max[i];
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
        int index1 = 0, index2 = -1, max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > max) { max = B[i, i]; index1 = i; }
            if (index2 == -1 && B[i, 2] < 0) index2 = i;
        }

        for (int i = 0; i < 5; i++)
        {
            int P = B[index1, i];
            B[index1, i] = B[index2, i];
            B[index2, i] = P;
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            int count = 0;
            foreach (int item in A)
            {
                if (item < 0) count++;
            }
            answer = new int[count];
            int i = 0;
            foreach (int item in A)
            {
                if (item < 0)
                {
                    answer[i] = item;
                    i++;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            double max = int.MinValue;
            int maxIndex = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max) {max = A[i, j]; maxIndex = j;}
            }
            if (maxIndex == 0)
            {
                A[i, 1] *= A[i, 1] > 0 ? 2 : 0.5;
            }
            else if (maxIndex == 6)
            {
                A[i, 5] *= A[i, 5] > 0 ? 2 : 0.5;
            }
            else if (A[i, maxIndex-1] < A[i, maxIndex + 1])
            {
                A[i, maxIndex - 1] *= A[i, maxIndex - 1] > 0 ? 2 : 0.5;
            }
            else
            {
                A[i, maxIndex + 1] *= A[i, maxIndex + 1] > 0 ? 2 : 0.5;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue, maxIndex = 0, pol = 0, otr = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxIndex = j;
                }
                if (A[j, i] < 0) otr++;
                else if (A[j, i] > 0) pol++;
            }
            if (pol > otr) A[maxIndex, i] = 0;
            else A[maxIndex, i] = maxIndex + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue, maxIndex = 0, sum = 0;
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxIndex = j;
                    sum = 0;
                }
                else sum += A[j, i];
            }
            if (maxIndex <= 5) A[0, i] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue, maxIndex = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxIndex = j;
                }
            }
            if (B[i] > max) A[maxIndex, i] = B[i];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            double max = double.MinValue; 
            int maxIndex = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxIndex = j;
                }
            }
            if (max < (A[0, i] + A[6, i]) / 2) A[maxIndex, i] = (A[0, i] + A[6, i]) / 2;
            else A[maxIndex, i] = maxIndex + 1;
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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3*n; j++)
                {
                    answer[j%3, j] = 1;
                }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int index = 0, max = int.MinValue;
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        for (int i = 0; i < 3; i++)
        {
            int maxIndex1 = 0, maxIndex2 = 0, max1 = int.MinValue, max2 = int.MinValue;
            for (int j = 0; j < 6; j++)
            {
                if (B[2*i, j] > max1)
                {
                    max1 = B[2 * i, j];
                    maxIndex1 = j;
                }
                if (B[2 * i + 1, j] > max2)
                {
                    max2 = B[2 * i + 1, j];
                    maxIndex2 = j;
                }
            }
            int P = B[2 * i, maxIndex1];
            B[2 * i, maxIndex1] = B[2 * i + 1, maxIndex2];
            B[2 * i + 1, maxIndex2] = P;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        int[,] newA = new int[6, 7];

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                newA[i, j] = A[i, 6 - j];
            }
        }

        A = newA;
        // end

        return A;
    }

    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int lines = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (lines != 7 || cols != 5) return null;

        int[,] data = new int[lines, 2];

        for (int i = 0; i < lines; i++)
        {
            int min = 0;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < min) min = matrix[i, j];
            }
            data[i, 0] = i;
            data[i, 1] = min;
        }

        for (int i = 0; i < lines - 1; i++)
        {
            for (int j = 0; j < lines - i - 1; j++)
            {
                if (data[j, 1] < data[j + 1, 1])
                {
                    int tmp1 = data[j, 0];
                    int tmp2 = data[j, 1];

                    data[j, 0] = data[j + 1, 0];
                    data[j, 1] = data[j + 1, 1];

                    data[j + 1, 0] = tmp1;
                    data[j + 1, 1] = tmp2;
                }
            }
        }

        int[,] newMatrix = new int[lines, cols];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                newMatrix[i, j] = matrix[data[i, 0], j];
            }
        }

        matrix = newMatrix;
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
        int m = matrix.GetLength(1);
        if (n != m) return answer;

        answer = new int[2*n-1];
        for (int i = 0; i < 2*n-1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j - i + (n - 1)] += matrix[i, j];
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m || k < 1) return null;

        int max = int.MinValue, line = 0, stolb = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    line = i;
                    stolb = j;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int P = matrix[line, i];
            matrix[line, i] = matrix[k-1, i];
            matrix[k-1, i] = P;
        }

        for (int i = 0; i < n; i++)
        {
            int P = matrix[i, line];
            matrix[i, line] = matrix[i, k-1];
            matrix[i, k-1] = P;
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
        if (A.Length != B.Length || A.Length != (n * n) / 2 + (n + 1) / 2 || n < 1) return answer;
        answer = new int[n * n];
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];

        Console.WriteLine("A");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j >= i ? i * n + j - (i * i) / 2 - (i + 1) / 2 : j * n + i - (j * j) / 2 - (j + 1) / 2;

                matrixA[i, j] = A[index];
                matrixB[i, j] = B[index];

                Console.Write(A[index]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("B");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrixB[i, j]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Результат");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                answer[i * n + j] = sum;

                if (j == 0 && i != 0) Console.WriteLine();
                Console.Write(sum);
                Console.Write("   ");
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
        int lines = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (lines != 5 || cols != 7) return null;

        int[,] data = new int[cols, 2];

        for (int i = 0; i < cols; i++)
        {
            int countOtr = 0;
            for (int j = 0; j < lines; j++)
            {
                if (matrix[j, i] < 0) countOtr++;
            }
            data[i, 0] = i;
            data[i, 1] = countOtr;
        }

        for (int i = 0; i < cols - 1; i++)
        {
            for (int j = 0; j < cols - i - 1; j++)
            {
                if (data[j, 1] > data[j + 1, 1])
                {
                    int tmp1 = data[j, 0];
                    int tmp2 = data[j, 1];

                    data[j, 0] = data[j + 1, 0];
                    data[j, 1] = data[j + 1, 1];

                    data[j + 1, 0] = tmp1;
                    data[j + 1, 1] = tmp2;
                }
            }
        }

        int[,] newMatrix = new int[lines, cols];

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < lines; j++)
            {
                newMatrix[j, i] = matrix[j, data[i, 0]];
            }
        }

        matrix = newMatrix;
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
        int lines = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int count = 0;
        for (int i = 0; i < lines; i++)
        {
            bool flag = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0) { flag = true; break; }
            }
            if (!flag) count++;
        }

        int[,] newMatrix = new int[count, cols];
        int currentIndex = 0;
        for (int i = 0; i < count; i++)
        {
            bool flag = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0) { flag=true; break; }
            }
            if (!flag)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[currentIndex, j] = matrix[i, j];
                }
                currentIndex++;
            }
        }
        matrix = newMatrix;
        // end

        return matrix;
    }
    #endregion
}