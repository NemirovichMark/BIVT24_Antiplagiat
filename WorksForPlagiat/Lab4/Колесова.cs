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
        //Random rand = new Random();

        Program program = new Program();

        /*
        program.Task_1_4(new int[,] {
                { 1, 2, 3, 4, 5, 6 },
                { 5, 6, 7, 8, 9, 11 },
                { 0, 2, 3, 4, 5, 6 }
            });
        */
        //program.Task_1_4(new int[rand.Next(0, 3), rand.Next(7, 10)]);
        /*program.Task_1_31(new int[,] {
                { 1, 2, -3, 7, -5, 7, 7, 0 },
                { 5, 6, -7, 8, 9, 9, -11, 0},
                { 9, 10, 11, 12, 13, 15, 15, 0 },
                { -13, 14, 25, 25, 16, 17, -19, 0 },
                { 0, 0, -1, -2, -3, -4, -6, 0 }
               }, new int[] { 1, 2, 3, 4, 5 });
        
        program.Task_2_2(new int[,]{
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            });
        program.Task_2_7(new int[,] {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            });
        program.Task_3_5(new int[,] {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            }, 2);*/
        program.Task_3_7(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 10, 11, 12, 13, 14, 15 }, 3);
    }
    
    public void printIntMatrix(int[,] A)
    {
        for (int m = 0; m < A.GetLength(0); m++)
        {
            for (int n = 0; n < A.GetLength(1); n++)
            {
                Console.Write(A[m, n] + "\t");
            }
            Console.WriteLine();
        }
    }
    public void printDoubleMatrix(double[,] A)
    {
        for (int m = 0; m < A.GetLength(0); m++)
        {
            for (int n = 0; n < A.GetLength(1); n++)
            {
                Console.Write(A[m, n] + "\t");
            }
            Console.WriteLine();
        }
    }
    //1 4 7 10 13 16 19 22 25 28 31
    #region Level 1 
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for(int m = 0; m < A.GetLength(0); m++)
        {
            for(int n = 0; n < A.GetLength(1); n++)
            {
                answer += A[m,n];
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
        if(A.GetLength(0) != 3 || A.GetLength(1) != 6)
        {
            return (row, col);
        }
        int min = A[0, 0];
        for(int m = 0; m < A.GetLength(0); m++)
        {
            for (int n = 0;n < A.GetLength(1); n++)
            {
                if(A[m,n] < min)
                {
                    min = A[m,n];
                    row = m;
                    col = n;
                }
            }
        }
        Console.WriteLine($"min = {min}, row = {row}, col = {col}");
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return answer;
        }
        answer = new int[A.GetLength(1)];
        for(int n = 0; n < A.GetLength(1); n++)
        {
            int max = A[0,n];
            for(int m = 0;  m < A.GetLength(0); m++)
            {
                if (A[m,n] > max)
                    max = A[m,n];
            }
            answer[n] = max;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        printIntMatrix(A);
        // найти строку, содержащую макс элем в 3 столб
        int max = A[0, 2];
        int maxRowIndex = 0;
        for(int m = 0; m < A.GetLength(0); m++)
        {
            if (A[m, 2] > max)
            {
                max = A[m, 2];
                maxRowIndex = m;
            }
        }
        Console.WriteLine($"maxRowIndex = {maxRowIndex+1}");
        // swap 4 & maxRowIndex rows
        if (maxRowIndex == 3)
            return A;
        for (int n = 0; n < A.GetLength(1); n++)
        {
            int tmp = A[3, n];
            A[3,n] = A[maxRowIndex, n];
            A[maxRowIndex, n] = tmp;
        }
        printIntMatrix(A);

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }
        printIntMatrix(A);
        // найти строку, содержащую макс элем на диагонали
        int max = A[0, 0];
        int maxIndex = 0;
        for (int m = 0; m < A.GetLength(0); m++)
        {
            if (A[m, m] > max)
            {
                max = A[m, m];
                maxIndex = m;
            }
        }
        Console.WriteLine($"maxRowIndex = {maxIndex + 1}");
        // swap 4 & maxRowIndex columns
        if (maxIndex == 3)
            return A;
        for (int n = 0; n < A.GetLength(0); n++)
        {
            int tmp = A[n, 3];
            A[n, 3] = A[n, maxIndex];
            A[n, maxIndex] = tmp;
        }
        printIntMatrix(A);

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
        if (A.GetLength(0) != n || A.GetLength(1) != m)
        {
            return null;
        }
        printIntMatrix(A);
        Console.WriteLine();
        for(int a = 0; a < n; a++)
        {
            int maxInRow = A[a, 0];
            int maxInRowIndex = 0;
            //найти максимальмый
            for(int b = 0; b < m; b++)
            {
                if (A[a, b] > maxInRow)
                {
                    maxInRow = A[a, b];
                    maxInRowIndex = b;
                }
            }
            //сдвинуть максимальный
            for(int c = maxInRowIndex; c < m-1; c++)
            {
                int tmp = A[a, c];
                A[a, c] = A[a, c+1];
                A[a, c+1] = tmp;

            }
        }
        printIntMatrix(A);
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
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        if (C.GetLength(0) != n || C.GetLength(1) != m)
        {
            return null;
        }
        printDoubleMatrix(C);
        Console.WriteLine();
        for (int a = 0; a < n; a++)
        {
            double maxInRow = C[a, 0];
            int maxInRowIndex = 0;
            //найти максимальмый
            for (int b = 0; b < m; b++)
            {
                if (C[a, b] > maxInRow)
                {
                    maxInRow = C[a, b];
                    maxInRowIndex = b;
                }
            }
            if (maxInRow == 0)
                continue;
            //поделить отрицательный на макс
            for (int c = 0; c < maxInRowIndex; c++)
            {
                if (C[a,c] < 0)
                {
                    C[a,c] /= maxInRow;
                }
            }
        }
        printDoubleMatrix(C);
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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
        {
            return null;
        }

        double max = Z[0, 0];
        int maxIndexRow = 0;
        int maxIndexCol = 0;
        double sumPositive = 0;
        int numPositive = 0;
        double averagePositive = 0;
        for(int n = 0; n < Z.GetLength(0); n++)
        {
            for(int m = 0; m < Z.GetLength(1); m++)
            {
                // find max
                if(Z[n,m] > max)
                {
                    max = Z[n,m];
                    maxIndexRow = n;
                    maxIndexCol = m;
                }
                //
                if(Z[n,m] > 0)
                {
                    sumPositive += Z[n,m];
                    numPositive++;
                }
            }
        }
        if(numPositive != 0)
        {
            averagePositive = sumPositive / numPositive;
            Z[maxIndexRow, maxIndexCol] = averagePositive;
        }
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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }

        int indexMinNum = 0;// отрицательных эл-тов
        int indexMaxNum = 0;
        int maxNum = 0;
        int minNum = X.GetLength(1);
        for(int a = 0; a < X.GetLength(0); a++)
        {
            int num = 0;
            for(int b = 0;  b < X.GetLength(1); b++)
            {
                if (X[a,b] < 0)
                {
                    num++;
                }
            }
            if(num > maxNum)
            {
                maxNum = num;
                indexMaxNum = a;
            }
            if(num < minNum)
            {
                minNum = num;
                indexMinNum = a;
            }
        }
        //swap
        if(indexMaxNum != indexMinNum)
        {
            for(int k = 0; k < X.GetLength(1); k++)
            {
                int tmp = X[indexMaxNum, k];
                X[indexMaxNum, k] = X[indexMinNum, k];
                X[indexMinNum, k] = tmp;

            }
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
        //удалить строку с макс суммой положительных эл-тов
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        printIntMatrix(A);
        int sumPositiveMax = 0;
        int indexPositiveMax = 0;
        for(int m = 0; m < A.GetLength(0); m++)
        {
            int sumPositiveCurrent = 0;
            for(int n = 0; n < A.GetLength(1); n++)
            {
                if (A[m, n] > 0)
                    sumPositiveCurrent += A[m, n];
            }
            if(sumPositiveCurrent > sumPositiveMax)
            {
                sumPositiveMax = sumPositiveCurrent;
                indexPositiveMax = m;
            }
        }
        Console.WriteLine();
        int[,] answer = new int[6,5];
        for(int k = 0; k < indexPositiveMax; k++)
        {
            for(int t =0; t< answer.GetLength(1); t++)
            {
                answer[k,t] = A[k,t];
            }
        }
        for(int k = indexPositiveMax; k < answer.GetLength(0); k++)
        {
            for (int t = 0; t < answer.GetLength(1); t++)
            {
                answer[k, t] = A[k + 1, t];
            }
        }
        printIntMatrix(answer);
        // end

        return answer;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
        {
            return null;
        }
        printIntMatrix(A);
        //мин эл-т в 5 стр
        int min = A[4, 0];
        int minIndex = 0;
        for(int k = 0; k < A.GetLength(1); k++)
        {
            if (A[4, k] < min)
            {
                min = A[4, k];
                minIndex = k;
            }
        }
        Console.WriteLine();
        for(int f = A.GetLength(1)-1; f > minIndex + 1; f--)
        {
            for(int e = 0; e < A.GetLength(0); e++)
            {
                A[e, f] = A[e, f-1];
            }
        }
        for(int k = 0; k < A.GetLength(0); k++)
        {
            A[k, minIndex + 1] = B[k];
        }
        printIntMatrix(A);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for(int m = 0; m < A.GetLength(0); m++)
        {
            double max = A[m, 0];
            int maxIndex = 0;

            for(int n = 0; n < A.GetLength(1); n++)
            {
                if(A[m, n] > max)
                {
                    max = A[m, n];
                    maxIndex = n;
                }
            }

            if (maxIndex == 0)
            {
                if (A[m, 1] >= 0)
                    A[m, 1] *= 2;
                else
                    A[m, 1] /= 2;
            }
            else if (maxIndex == A.GetLength(1) - 1)
            {
                if (A[m, A.GetLength(1) - 2] >= 0)
                    A[m, A.GetLength(1) - 2] *= 2;
                else
                    A[m, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[m, maxIndex - 1] < A[m, maxIndex + 1])
                {
                    if(A[m, maxIndex - 1] >=0)
                        A[m, maxIndex - 1] *= 2;
                    else
                        A[m, maxIndex - 1] /= 2;
                }
                else if (A[m, maxIndex - 1] > A[m, maxIndex + 1])
                {
                    if(A[m, maxIndex + 1] >= 0)
                        A[m, maxIndex + 1] *= 2;
                    else
                        A[m, maxIndex + 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        printIntMatrix(A);
        for(int n = 0; n < A.GetLength(1); n++)
        {
            int numPositive = 0;
            int numNegative = 0;
            int max = A[0, n];
            int maxIndex = 0;
            for(int m = 0; m < A.GetLength(0); m++)
            {
                if (A[m, n] > 0)
                    numPositive++;
                else if (A[m, n] < 0)
                    numNegative++;

                if(A[m, n] > max)
                {
                    max = A[m, n];
                    maxIndex = m;
                }
            }
            if (numPositive > numNegative)
                A[maxIndex, n] = 0;
            else
                A[maxIndex, n] = maxIndex + 1;           
        }
        Console.WriteLine();
        printIntMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }

        for(int n = 0; n < A.GetLength(1); n++)
        {
            int max = A[0, n];
            int maxIndex = 0;
            for(int m = 0; m < A.GetLength(0); m++)
            {
                if(A[m, n] > max)
                {
                    max = A[m, n];
                    maxIndex = m;
                }
            }

            if(maxIndex <= A.GetLength(0) / 2)
            {
                int sum = 0;
                for(int m = maxIndex+1; m < A.GetLength(0); m++)
                    sum+= A[m, n];
                A[0, n] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }

        for (int n = 0; n < A.GetLength(1); n++)
        {
            int max = A[0, n];
            int maxIndex = 0;
            for (int m = 0; m < A.GetLength(0); m++)
            {
                if (A[m, n] > max)
                {
                    max = A[m, n];
                    maxIndex = m;
                }
            }

            if (A[maxIndex, n] < B[n])
                A[maxIndex, n] = B[n];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }

        for (int n = 0; n < A.GetLength(1); n++)
        {
            double max = A[0, n];
            int maxIndex = 0;
            for (int m = 0; m < A.GetLength(0); m++)
            {
                if (A[m, n] > max)
                {
                    max = A[m, n];
                    maxIndex = m;
                }
            }

            double key = (A[0, n] + A[4, n]) / 2;
            if (max < key)
                A[maxIndex, n] = key + 1;
            else
                A[maxIndex, n] = maxIndex + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
            return null;

        answer = new int[n, 3 * n];
        int p = 0, q = 0;
        for (; p < n && q < n; p++, q++)
        {
            answer[p, q] = 1;
        }
        p = 0;
        for (; p < n && q < 2*n; p++, q++)
        {
            answer[p, q] = 1;
        }
        p = 0;
        for (; p < n && q < 3*n; p++, q++)
        {
            answer[p, q] = 1;
        }
        printIntMatrix(answer);
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        printIntMatrix(A);
        Console.WriteLine();
        int max = A[0, 0];
        int maxIndex = 0;
        for (int k = 0; k < 6; k++)
        {
            if (A[k, k] > max)
            {
                max = A[k, k];
                maxIndex = k;
            }
        }
        for(int p = 0; p < maxIndex; p++)
        {
            for(int q = p+1; q < 6; q++)
                A[p, q] = 0;
        }
        printIntMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }

        for(int k = 0; k < 3; k++)
        {
            //найти максимальный эл-т в 2*k строке
            int max1 = B[2*k, 0];
            int max1Index = 0;
            for(int n = 0; n < 6; n++)
            {
                if (B[2*k, n] > max1)
                {
                    max1 = B[2*k, n];
                    max1Index = n;
                }
            }
            //найти максимальный эл-т в 2*k+1 строке
            int max2 = B[2*k+1, 0];
            int max2Index = 0;
            for (int n = 0; n < 6; n++)
            {
                if (B[2 * k +1, n] > max2)
                {
                    max2 = B[2 * k+1, n];
                    max2Index = n;
                }
            }

            B[2 * k, max1Index] = max2;
            B[2 * k + 1, max2Index] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }

        for(int m = 0; m < 6; m++)
        {
            for(int n = 0; n < 3; n++)
            {
                int tmp = A[m, n];
                A[m, n] = A[m, 6 - n];
                A[m, 6-n] = tmp;
            }
        }
        // end

        return A;
    }

    //1 3 5 7 9 11
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }

        int[] min = new int[7];// массив минимальных эл-тов строк
        for(int m = 0; m < 7; m++)
        {
            int minStr = matrix[m, 0];
            int minIndex = 0;
            for(int n = 0; n < 5; n++)
            {
                if(matrix[m, n] < minStr)
                {
                    minStr = matrix[m, n];
                    minIndex = n;
                }
            }
            min[m] = minStr;
        }
        // в порядке убывания
        for (int k = 0; k < 7; k++)
        {
            for (int p = 0; p < 6 - k; p++)
            {
                if (min[p] < min[p + 1])
                {
                    for(int q =0; q < 5; q++)
                    {
                        int tmp = matrix[p, q];
                        matrix[p, q] = matrix[p + 1, q];
                        matrix[p+1, q] = tmp;
                    }

                    int tmp0 = min[p + 1];
                    min[p + 1] = min[p];
                    min[p] = tmp0;
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
        if(matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];
        int k = 0;
        for(int p = n-1; p >=0; p--)
        {
            int sum = 0;
            for(int f = 0, e = p; f < n- p && e < n; f++,e++)
            {
                sum += matrix[e, f];
            }
            answer[k] = sum;
            k++;
        }
        for(int q = 1; q < n; q++)
        {
            int sum = 0;
            for(int e = 0, f = q; e< n-q && f < n; e++, f++)
            {
                sum += matrix[e, f];
            }
            answer[k] = sum;
            k++;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int n = matrix.GetLength(0);
        k--;
        if (k < 0 || k >= n )
            return null;

        printIntMatrix(matrix);
        int max = matrix[0, 0];
        int maxIndexRow = 0;
        int maxIndexCol = 0;
        for(int p = 0; p < n; p++)
        {
            for(int q = 0; q < n; q++)
            {
                if (Math.Abs(matrix[p, q]) > max)
                {
                    max = Math.Abs(matrix[p, q]);
                    maxIndexRow = p;
                    maxIndexCol = q;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"max = {max}; ({maxIndexRow}, {maxIndexCol})");
        Console.WriteLine();
        if(maxIndexRow != k) 
        {
            for(int t = 0; t < n ; t++)
            {
                int tmp = matrix[k, t];
                matrix[k, t] = matrix[maxIndexRow, t];
                matrix[maxIndexRow, t] = tmp;
            }
        }
        printIntMatrix(matrix);
        Console.WriteLine();
        if (maxIndexCol != k) 
        {
            for (int t = 0; t < n; t++)
            {
                int tmp = matrix[t, k];
                matrix[t, k] = matrix[t , maxIndexCol];
                matrix[t, maxIndexCol] = tmp;
            }
        }
        printIntMatrix(matrix);
        Console.WriteLine();
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
        if (A.Length != B.Length)
            return null;
        int tmp = n, sum = 0;
        while(tmp > 0)
        {
            sum += tmp;
            tmp--;
        }
        if (sum != A.Length)
            return null;

        int[,] matrixA = new int[n, n];
        int k = 0;
        for(int p = 0; p < n; p++)
        {
            for(int q = p; q < n; q++)
            {
                matrixA[p, q] = A[k];
                matrixA[q, p] = A[k];
                k++;
            }
        }
        printIntMatrix(matrixA);
        Console.WriteLine();
        int[,] matrixB = new int[n, n];
        k = 0;
        for (int p = 0; p < n; p++)
        {
            for (int q = p; q < n; q++)
            {
                matrixB[p, q] = B[k];
                matrixB[q, p] = B[k];
                k++;
            }
        }
        printIntMatrix(matrixB);
        Console.WriteLine();
        int[,] res = new int[n, n];
        for(int a = 0; a < n; a++)
        {
            for(int b = 0; b < n; b++)
            {
                for( int c = 0; c < n; c++)
                {
                    res[a, b] += matrixA[a, c] * matrixB[c, b];
                }
            }
        }
        printIntMatrix(res);
        Console.WriteLine();
        answer = new int[n * n];
        k = 0;
        for(int p = 0; p < n; p++)
        {
            for(int q = 0; q < n; q++)
            {
                answer[k] = res[p, q];
                k++;
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        {
            return null;
        }

        int[] numNegative = new int[7];// массив кол-ва отриц эл-тов столбца
        for (int n = 0; n < 7; n++)
        {
            int count = 0;
            for (int m = 0; m < 5; m++)
            {
                if (matrix[m, n] < 0)
                    count++;
            }
            numNegative[n] = count;
        }
        // в порядке возрастания
        for (int k = 0; k < 7; k++)
        {
            for (int q = 0; q < 6 - k; q++)
            {
                if (numNegative[q] > numNegative[q + 1])
                {
                    for (int p = 0; p < 5; p++)
                    {
                        int tmp = matrix[p, q];
                        matrix[p, q] = matrix[p, q + 1];
                        matrix[p, q+1 ] = tmp;
                    }

                    int tmp0 = numNegative[q + 1];
                    numNegative[q + 1] = numNegative[q];
                    numNegative[q] = tmp0;
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
        int numStr = matrix.GetLength(0);
        for(int p = 0; p < matrix.GetLength(0); p++)
        {
            bool has0 = false;
            for(int q = 0;q < matrix.GetLength(1); q++)
            {
                if (matrix[p, q] == 0)
                {
                    has0 = true;
                    break;
                }
            }
            if (has0)
                numStr--;
        }
        if (numStr == 0)
            return null;

        int[,] answer = new int[numStr, matrix.GetLength(1)];
        int k = 0;
        for (int p = 0; p < matrix.GetLength(0); p++)
        {
            bool has0 = false;
            for (int q = 0; q < matrix.GetLength(1); q++)
            {
                if (matrix[p, q] == 0)
                {
                    has0 = true;
                    break;
                }
                answer[k, q] = matrix[p, q];
            }
            if (has0)
                continue;
            k++;
            if (k >= answer.GetLength(0))
                break;
        }
        // end

        return answer;
    }
    #endregion
}