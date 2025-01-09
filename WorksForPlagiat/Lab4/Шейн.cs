using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        /*program.Task_1_18(new int[,]{
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            }, 5, 7); */
        /*
        program.Task_2_1(new double[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, -30, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            });
            */
        /*program.Task_2_3(new int[,]
        {
            { 1, 2, -3, 7, 7 },
            { 5, 6, -7, 9, -11 },
            { 9, 10, 11, 15, 15 },
            { -13, 14, 25, 25, -19 },
            { 5, 6, -7, 8, 9 },
            { -13, 14, 2, 3, -19 },
            { 1, 2, -3, 7, 0 },
            { 5, 0, -1, 9, -1 },
            { 9, 10, 11, 2, 15 },
            { 0, 0, -1, -2, -3 }
        });*/

        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };

        int[,] sortedMatrix = program.Task_3_11(matrix);

        // Вывод отсортированной матрицы
        for (int i = 0; i < sortedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sortedMatrix.GetLength(1); j++)
            {
                Console.Write(sortedMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;
        for (int i = 0; i < 4; i++)
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
        int[] answer = new int[A.GetLength(0)];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int n = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < A[i, n])
                {
                    n = j;
                }
            }
            answer[i] = n;

        }
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

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int X = int.MinValue;
            int n = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > X)
                {
                    X = A[i, j];
                    n = j;
                }
            }
            A[i, n] = A[i, 0];
            A[i, 0] = X;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        // code here
        int X = int.MinValue, n0 = -1, n1 = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if ((A[i, j] > X))
                {
                    X = A[i, j];
                    n0 = i; n1 = j;
                }
            }
        }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                if (i < n0 && j < n1) B[i, j] = A[i, j];
                if (i < n0 && j >= n1) B[i, j] = A[i, j + 1];
                if (i >= n0 && j < n1) B[i, j] = A[i + 1, j];
                if (i >= n0 && j >= n1) B[i, j] = A[i + 1, j + 1];
            }
        }
        // end

        return B;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int X = int.MinValue;
            int i0 = -1, j0 = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > X)
                {
                    X = A[i, j]; i0 = i; j0 = j;
                }

            }
            A[i0, j0] = A[i0, j0] * (i + 1);
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
            int X = int.MinValue;
            int jNegative = -1, jMax = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    jNegative = j;
                }
                if (jNegative == -1 && D[i, j] > X)
                {
                    X = D[i, j];
                    jMax = j;
                }
            }
            if (jNegative != -1 && jMax != -1)
            {
                int temp = D[i, jMax];
                D[i, jMax] = D[i, jNegative];
                D[i, jNegative] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{D[i, j]} ");
            }
            Console.WriteLine();
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
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int X = int.MinValue;

            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (j != H.GetLength(1) - 1 && H[i, j] > X) X = H[i, j];
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = X;
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
        int rows = Y.GetLength(0);
        int cols = Y.GetLength(1);
        if (rows != 6 || cols != 5) return null;
        for (int i = 0; i < rows; i++)
        {
            double sum = 0;
            double X = double.MinValue;
            int jMax = -1;
            int n = 0;
            for (int j = 0; j < cols; j++)
            {
                if ((Y[i, j] > 0))
                {
                    sum += Y[i, j];
                    n++;
                }
                if (Y[i, j] > X)
                {
                    X = Y[i, j];
                    sum = 0;
                    n = 0;
                    jMax = j;
                }

            }

            double sr;
            if (n != 0) sr = sum / (5 - jMax - 1);
            else sr = 0;
            for (int j = 0; j < jMax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = sr;
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
        int rows = B.GetLength(0), cols = B.GetLength(1);
        int[] A = new int[rows];
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        for (int i = 0; i < rows; i++)
        {
            int X = int.MinValue;
            for (int j = 0; j < cols; j++)
            {
                if (B[i, j] > X) X = B[i, j];
            }
            A[i] = X;
        }
        for (int i = 0; i < rows / 2; i++)
        {
            int temp = A[i];
            A[i] = A[rows - 1 - i];
            A[rows - i - 1] = temp;
        }
        for (int i = 0; i < rows; i++)
        {
            B[i, 3] = A[i];
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
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);
        if (rows != 5 || cols != 5) return null;
        int X = int.MinValue;
        int iMin = -1;
        int iNegative = -1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j && B[i, i] > X)
                {
                    X = B[i, i];
                    iMin = i;
                }
                if (j == 2 && B[i, j] < 0 && iNegative == -1) iNegative = i;
            }
        }
        for (int j = 0; j < cols; j++)
        {
            int temp = B[iMin, j];
            B[iMin, j] = B[iNegative, j];
            B[iNegative, j] = temp;
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int n = 0;
        if (rows != 5 || cols != 7) return null;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] < 0) n++;
            }
        }
        answer = new int[n];
        n = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[n] = A[i, j];
                    n++;
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

        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 5 || cols != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxIndex = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxIndex])
                {
                    maxIndex = j;
                }
            }
            if (maxIndex > 0 && maxIndex < A.GetLength(1) - 1)
            {
                if (A[i, maxIndex - 1] < A[i, maxIndex + 1])
                {
                    if (A[i, maxIndex - 1] < 0) A[i, maxIndex - 1] /= 2;
                    else A[i, maxIndex - 1] *= 2;
                }
                else
                {
                    if (A[i, maxIndex + 1] < 0) A[i, maxIndex + 1] /= 2;
                    else A[i, maxIndex + 1] *= 2;
                }
            }
            else if (maxIndex == 0)
            {
                if (A[i, maxIndex + 1] < 0) A[i, maxIndex + 1] /= 2;
                else A[i, maxIndex + 1] *= 2;
            }
            else if (maxIndex == A.GetLength(1) - 1)
            {
                if (A[i, maxIndex - 1] < 0) A[i, maxIndex - 1] /= 2;
                else A[i, maxIndex - 1] *= 2;

            }
        }
        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        for (int j = 0; j < cols; j++)
        {
            int countNegative = 0, countPostive = 0;
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }

                if (A[i, j] > 0) countPostive++;
                else if (A[i, j] < 0) countNegative++;
            }

            if (countPostive > countNegative) A[maxIndex, j] = 0;
            else A[maxIndex, j] = maxIndex + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 10 || cols != 5) return null;
        for (int j = 0; j < cols; j++)
        {
            int maxIndex = 0, s = 0, X = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > X)
                {
                    X = A[i, j];
                    maxIndex = i;
                }
            }

            if (maxIndex < rows / 2)
            {
                for (int i = maxIndex + 1; i < rows; i++) s += A[i, j];
                A[0, j] = s;
            }

        }
        // end

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j]);
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 7 || cols != 5 || B.Length != 5) return null;
        for (int j = 0; j < cols; j++)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            if (max < B[j]) A[maxIndex, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        for (int j = 0; j < cols; j++)
        {
            int maxIndex = 0;
            double sum = (A[0, j] + A[rows - 1, j]) / 2;
            for (int i = 0; i < rows; i++)
            {
                if (A[maxIndex, j] < A[i, j]) maxIndex = i;
            }
            if (A[maxIndex, j] < sum) A[maxIndex, j] = sum;
            else A[maxIndex, j] = maxIndex + 1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here

        for (int j = 0; j < 3 * n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == j % n) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 6 || cols != 6) return null;
        int maxIndex = 0;
        for (int i = 0; i < rows; i++)
        {
            if (A[maxIndex, maxIndex] < A[i,i]) maxIndex = i;
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i < maxIndex && j > i) A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int rows = B.GetLength(0), cols = B.GetLength(1);
        if (rows != 6 || cols != 6) return null; 
        int maxIndexOdd = 0, maxIndexEven = 0; bool flagOdd = false, flagEven = false;
        for (int i = 0; i < rows; i++)
        { 
            for (int  j = 0; j < cols; j ++)
            {
                if ((i + 1) % 2 != 0 && B[i, maxIndexOdd] < B[i, j]) maxIndexOdd = j;
                else if ((i + 1) % 2 == 0 && B[i, maxIndexEven] < B[i, j]) maxIndexEven = j;
            }
            if ((i + 1)% 2 ==0)
            {
                int temp = B[i-1, maxIndexOdd];
                B[i - 1, maxIndexOdd] = B[i, maxIndexEven];
                B[i, maxIndexEven] = temp;
                maxIndexOdd = 0; maxIndexEven = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int rows = A.GetLength(0), cols = A.GetLength(1);
        if (rows != 6 || cols != 7) return null;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, cols - 1 - j];
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

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int length = matrix.GetLength(0);
        if (length != matrix.GetLength(1)) return null;
        for (int i = 0; i < length; i++)
        {
            matrix[i, 0] = 0;
            matrix[i, length - 1] = 0;
            matrix[0, i] = 0;
            matrix[length - 1, i] = 0;
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
        int length = matrix.GetLength(0);
        if (length != matrix.GetLength(1)) return null;
        for (int i = length / 2; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (j <= i) matrix[i, j] = 1;
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1)) return (null, null);
        int countup = 0, countdown = 0;
        int [] upper = new int[n * (n + 1) / 2];
        int [] lower = new int[n * (n - 1) / 2];
        // code here
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
               if (i <= j)
                {
                    upper[countup] = matrix[i, j];
                    countup++;
                }
                else
                {
                    lower[countdown] = matrix[i, j];
                    countdown++;
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        int[] A = new int[7];
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0) A[i]++;
            }
        }
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                if (A[j] < A[j+1])
                {
                    for (int s = 0; s < matrix.GetLength(1); s++)
                    {
                        int temp1 = matrix[j, s];
                        matrix[j, s] = matrix[j + 1, s];
                        matrix[j + 1, s] = temp1;
                    }
                    int temp2 = A[j];
                    A[j] = A[j+1];
                    A[j+1] = temp2;
                }
            }

        }

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0) 
            {
                for (int k = 0; k < cols - 1; k++)
                {
                    for (int j = 0; j < cols - k - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1]) 
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = temp;
                        }
                    }
                }
            }
            else 
            {
                for (int k = 0; k < cols - 1; k++)
                {
                    for (int j = 0; j < cols - k - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                        {
                            int tempc = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = tempc;
                        }
                    }
                }
            }
        }

        return matrix; 
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
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

        // end

        return result;
    }
    #endregion
}