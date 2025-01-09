using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Formats.Tar;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 25, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            };
        int rowIndex = 3;
        // gnome up

        for (int i=1, j=2; i<matrix.GetLength(1);) {
            if (i == 0 || matrix[rowIndex, i] > matrix[rowIndex, i-1]) {
                i = j;
                j++;
            } else {
                int tmp = matrix[rowIndex, i];
                matrix[rowIndex, i] = matrix[rowIndex, i-1];
                matrix[rowIndex, i-1] = tmp;
                i--;
            }
        }

        for (int i=0; i<matrix.GetLength(0); i++) {
            for (int j=0; j<matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + " ");
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
    public double Task_1_2(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_1_2Test
    {
        double answer = 0;
        // code here
        int count = 0, sum = 0;
        for (int i=0; i<A.GetLength(0); i++) {
            for (int j=0; j<A.GetLength(1); j++) {
                int el = A[i, j];
                if (el > 0) {sum+=el; count++;}
            }
        }
        if (count == 0) count = 1;
        answer = (double) sum/count;
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
    public (int, int) Task_1_5(int[,] A, int colIndex) // dotnet test --filter Tests.ProgramTests.Task_1_5Test
    {
        int value = 0, rowIndex = -1;
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0, 0);
        
        for (int i=0; i<A.GetLength(0); i++) {
            int el = A[i, colIndex];
            if (el < 0) {
                value = el;
                rowIndex = i;
                break;
            } 
        }
        Console.WriteLine((value, rowIndex));

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
    public double[] Task_1_8(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_1_8Test
    {
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        double[] answer = new double[4];
        // code here
        for (int i=0; i<A.GetLength(0); i++) {
            double sum = 0, count = 0;
            for (int j=0; j<A.GetLength(1); j++) {
                int el = A[i, j];
                if (el > 0) {
                    sum += el;
                    count++;
                }
            }
            if (count != 0) {
                answer[i] = Math.Round(sum/count, 2);
            } else answer[i] = 0;
            Console.WriteLine((answer[i], i));
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
    public int[,] Task_1_11(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_1_11Test
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return (null);
        int iMinEl = 0, jMinEl = 0;
        for (int i=0; i<A.GetLength(0); i++) {
            for (int j=0; j<A.GetLength(1); j++) {
                int el = A[i, j];
                if (el < A[iMinEl, jMinEl] && j==0) {
                    iMinEl = i;
                    jMinEl = j;
                }
            }
        }

        int[,] newA = new int[A.GetLength(0)-1, A.GetLength(1)];
        for (int i=0, ii=0; i<A.GetLength(0); i++) {
            if (i == iMinEl) continue;
            for (int j=0; j<A.GetLength(1); j++) {
                    int el = A[i, j];
                    if (i != iMinEl) {
                        newA[ii, j] = el;
                    }
                }
                ii++;
        }
        A = newA;
        for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
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
    public int[] Task_1_14(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_1_14Test
    {
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return (null);
        int[] answer = {0, 0, 0};
        // code here
        for (int i=0; i<A.GetLength(0); i++) {
            for (int j=0; j<A.GetLength(1); j++) {
                int el = A[i, j];
                if (el < 0) {
                    answer[j] += 1;
                }
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
    public int[,] Task_1_17(int[,] B, int n, int m) // dotnet test --filter Tests.ProgramTests.Task_1_17Test
    {
        // code here
        int[,] newResult = new int[B.GetLength(0), B.GetLength(1)];

        for (int i=0; i<B.GetLength(0); i++) {
            newResult[i, 0] = int.MaxValue;
        }
        for (int i=0; i<B.GetLength(0); i++) {
            for (int j=0; j<B.GetLength(1); j++) {
                int el = B[i, j];
                if (el < newResult[i, 0]) newResult[i, 0] = el;
            }
        }
        for (int i=0; i<B.GetLength(0); i++) {
            for (int j=0, jj=1; j<B.GetLength(1); j++) {
                int el = B[i, j];
                if (el != newResult[i, 0]) {
                    newResult[i, jj] = el;
                    jj++;
                }
            }
        }
        B = newResult;
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
    public double[,] Task_1_20(double[,] F, int n, int m) // dotnet test --filter Tests.ProgramTests.Task_1_20Test
    {
        // code here
        for (int i=0; i<F.GetLength(0); i++) {
            int indMaxEl = 0;
            int indFirstNegative = int.MaxValue, indLastNegative = int.MaxValue;
            for (int j=0; j<F.GetLength(1); j++) {
                double el = F[i, j];
                if (el > F[i, indMaxEl]) indMaxEl = j;
                if (el < 0 && indFirstNegative == int.MaxValue) indFirstNegative = j;
                if (el < 0) indLastNegative = j;
            }
            Console.WriteLine((indMaxEl, indFirstNegative, indLastNegative));
            if (indFirstNegative != int.MaxValue && indLastNegative != int.MaxValue)
            F[i, indMaxEl] = (F[i, indFirstNegative] + F[i, indLastNegative]) / 2;
        }
        for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    Console.Write(F[i, j] + " ");
                }
                Console.WriteLine();
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
    public int[,] Task_1_23(int[,] G) // dotnet test --filter Tests.ProgramTests.Task_1_23Test
    {
        // code here
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return (null);
        int[,] newG = new int[5, 7];
        for (int i=0; i<5; i++) {
            int indMax = 0;
            for (int j=1; j<6; j++) {
                if (G[i, j] > G[i, indMax]) {
                    indMax = j;
                }
            }
            for (int j = 0; j <= indMax; j++) {
                newG[i, j] = G[i, j];
            }
            newG[i, indMax + 1] = G[i, indMax];
            for (int j = indMax + 1; j < 6; j++) {
                newG[i, j + 1] = G[i, j];
            }
        }
        G = newG;
        for (int i = 0; i < G.GetLength(0); i++)
            {
                for (int j = 0; j < G.GetLength(1); j++)
                {
                    Console.Write(G[i, j] + " ");
                }
                Console.WriteLine();
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
    public int[,] Task_1_26(int[,] A, int[] B) // dotnet test --filter Tests.ProgramTests.Task_1_26Test
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length!=7) return (null);
        int maxRowIndex = 0;
        int maxValue = A[0, 5];

        for (int i = 1; i < 5; i++) {
            if (A[i, 5] > maxValue) {
                maxValue = A[i, 5];
                maxRowIndex = i;
            }
        }
        for (int j = 0; j < 7; j++) {
            A[maxRowIndex, j] = B[j];
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
    public int[,] Task_1_29(int[,] F) // dotnet test --filter Tests.ProgramTests.Task_1_29Test
    {
        // code here
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7 ) return (null);
        int[,] newF = new int[5, 6];
        int minIndex = 0;
        int minAbsValue = Math.Abs(F[1, 0]);

        for (int j = 1; j < 7; j++) {
            if (Math.Abs(F[1, j]) < minAbsValue) {
                minAbsValue = Math.Abs(F[1, j]);
                minIndex = j;
            }
        }
        int removeIndex = -1;
        if (minIndex + 1 < 7) {
            removeIndex = minIndex + 1;
        }

        for (int i = 0; i < 5; i++) {
            int newColumn = 0; 
            for (int j = 0; j < 7; j++) {
                if (j != removeIndex) {
                    newF[i, newColumn] = F[i, j];
                    newColumn++;
                }
            }
        }
        F = newF;
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
    public double[,] Task_1_32(double[,] A) // dotnet test --filter Tests.ProgramTests.Task_1_32Test
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 ) return (null);
        for (int i=0; i<A.GetLength(0); i++) {
            int indMaxEl = 0;
            double sum = 0;
            int count = 0;
            for (int j=0; j<A.GetLength(1); j++) {
                double el = A[i, j];
                if (el > A[i, indMaxEl]) indMaxEl = j;
                if (el > 0) {count++; sum += el;}
            }
            if (count != 0) A[i, indMaxEl] = sum/count;
            else A[i, indMaxEl] = 0;
        }

        
        for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
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
    public double[,] Task_2_1(double[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_1Test
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 ) return (null);

        for (int i=0; i<A.GetLength(0); i++) {
            int indMaxEl = 0;
            for (int j=0; j<A.GetLength(1); j++) {
                double el = A[i, j];
                if (el > A[i, indMaxEl]) indMaxEl = j;
            }
            if (indMaxEl == 0) {
                if (A[i, 1] > 0) A[i, 1] *= 2; else A[i, 1] /= 2;
            }
            else if (indMaxEl == 6) {
                if (A[i, 5] > 0) A[i, 5] *= 2; else A[i, 5] /= 2;
            }
            else {
                if (A[i, indMaxEl - 1] > A[i, indMaxEl + 1]) {
                    if (A[i, indMaxEl + 1] > 0) A[i, indMaxEl + 1] *= 2; else A[i, indMaxEl + 1] /= 2;
                }
                else {
                    if (A[i, indMaxEl - 1] > 0) A[i, indMaxEl - 1] *= 2; else A[i, indMaxEl - 1] /= 2;
                }
            }
        }
        
        for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_2Test
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int positiveCount = 0, negativeCount = 0;
            int maxElement = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) positiveCount++;
                else if (A[i, j] < 0) negativeCount++;

                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            if (positiveCount > negativeCount)
            {
                A[maxIndex, j] = 0;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1;
            }
        }

        // end
        return A;
    }
    public int[,] Task_2_3(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_3Test
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxElement = A[0, j];
            int maxIndex = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
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
    public int[,] Task_2_4(int[,] A, int[] B) // dotnet test --filter Tests.ProgramTests.Task_2_4Test
    {
        // code here
        if (A == null || B == null) return null;

        if (A.GetLength(1) != B.Length) return null;

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int j = 0; j < cols; j++) {
            int maxVal = A[0, j];
            int maxRowIndex = 0;

            for (int i = 1; i < rows; i++) {
                if (A[i, j] > maxVal) {maxVal = A[i, j]; maxRowIndex = i;}
            }

            if (B[j] > maxVal) A[maxRowIndex, j] = B[j];
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_5Test
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++) {
            double max = double.MinValue;
            int maxRowIndex = -1;

            for (int i = 0; i < A.GetLength(0); i++) {
                if (A[i, j] > max) {max = A[i, j]; maxRowIndex = i;}
            }

            double hSum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (max < hSum) A[maxRowIndex, j] = hSum;
            else A[maxRowIndex, j] = maxRowIndex + 1;
        }

        return A;
    }
    public int[,] Task_2_6(int n) // dotnet test --filter Tests.ProgramTests.Task_2_6Test
    {
        if (n % 1 != 0 || n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here
        for (int k = 0; k < 3; k++) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j) answer[i, j + k * n] = 1;
                }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_7Test
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return (null);
        int maxVal = int.MinValue;
        int maxRow = -1;

        for (int i = 0; i < 6; i++) {
            if (A[i, i] > maxVal) {maxVal = A[i, i]; maxRow = i;}
        }
        for (int i = 0; i < maxRow; i++) {
            for (int j = i + 1; j < 6; j++) A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B) // dotnet test --filter Tests.ProgramTests.Task_2_8Test
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return (null);
        int max1Col = 0, max2Col = 0;

        for (int j=0; j<6; j++) {
            if (B[0, j] > B[0, max1Col]) max1Col = j;
            if (B[1, j] > B[1, max2Col]) max2Col = j;
        }
        int tmp = B[0, max1Col];
        B[0, max1Col] = B[1, max2Col];
        B[1, max2Col] = tmp;

        int max3Col = 0, max4Col = 0;
        for (int j=0; j<6; j++) {
            if (B[2, j] > B[2, max3Col]) max3Col = j;
            if (B[3, j] > B[3, max4Col]) max4Col = j;
        }
        tmp = B[2, max3Col];
        B[2, max3Col] = B[3, max4Col];
        B[3, max4Col] = tmp;

        int max5Col = 0, max6Col = 0;
        for (int j=0; j<6; j++) {
            if (B[4, j] > B[4, max5Col]) max5Col = j;
            if (B[5, j] > B[5, max6Col]) max6Col = j;
        }

        tmp = B[4, max5Col];
        B[4, max5Col] = B[5, max6Col];
        B[5, max6Col] = tmp;

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A) // dotnet test --filter Tests.ProgramTests.Task_2_9Test
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int left = 0, right = A.GetLength(1) - 1;
            while (left<right) {
                int temp = A[i, left];
                A[i, left] = A[i, right];
                A[i, right] = temp;
                right--;
                left++;
            }
        }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_1Test
    {
        // code here
        
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_2Test
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i=0; i<matrix.GetLength(0); i++) {
            for (int j=0; j<matrix.GetLength(1); j++) {
                if (i != 0 && i != matrix.GetLength(1)-1) {
                    matrix[i, 0] = 0;
                    matrix[i, matrix.GetLength(1)-1] = 0;
                    break;
                } else matrix[i, j] = 0;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
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
    public int[,] Task_3_4(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_4Test
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int n = matrix.GetLength(0);
        for (int i=n/2; i<n; i++) {
            for (int j=0; j<=i; j++) matrix[i, j] = 1;
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
    public (int[], int[]) Task_3_6(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_6Test
    {
        int[] upper = new int[(matrix.GetLength(0) * (matrix.GetLength(0) + 1)) / 2]; 
        int[] lower = new int[(matrix.GetLength(0) * (matrix.GetLength(0) - 1)) / 2];
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int upperInd = 0, lowerInd = 0;
        for (int i=0; i<matrix.GetLength(0); i++) {
            for (int j=0; j<matrix.GetLength(0); j++) {
                if (j >= i) upper[upperInd++] = matrix[i, j];
                if (j < i) lower[lowerInd++] = matrix[i, j];
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
    public int[,] Task_3_8(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_8Test
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] possitiveValues = new int[7];
        for (int i=0; i<matrix.GetLength(0); i++) {
            int sumPossitive = 0;
            for (int j=0; j<matrix.GetLength(1); j++) {
                int el = matrix[i, j];
                if (el > 0) sumPossitive++;
            }
            possitiveValues[i] = sumPossitive;
        }

        for (int i=0; i<matrix.GetLength(0) - 1; i++) {
            for (int j=0; j<matrix.GetLength(0) - 1- i; j++) {
                if (possitiveValues[j] < possitiveValues[j+1]) {
                    for (int k=0; k<matrix.GetLength(1); k++) {
                        int tmpp = matrix[j, k];
                        matrix[j, k] = matrix[j+1, k];
                        matrix[j+1, k] = tmpp;
                    }
                    int tmp = possitiveValues[j];
                    possitiveValues[j] = possitiveValues[j+1];
                    possitiveValues[j+1] = tmp;
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
    public int[,] Task_3_10(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_10Test
    {
        // code here
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i=0; i<matrix.GetLength(0); i++) {
            for (int j=0; j<matrix.GetLength(1) - 1; j++) {
                for (int jj=0; jj<matrix.GetLength(1) - 1 - j; jj++) {
                    if (i % 2 == 0) {
                        if (matrix[i, jj] < matrix[i, jj+1]) {
                            int tmp = matrix[i, jj];
                            matrix[i, jj] = matrix[i, jj+1];
                            matrix[i, jj+1] = tmp;
                        } 
                    } else {
                        if (matrix[i, jj] > matrix[i, jj+1]) {
                            int tmp = matrix[i, jj];
                            matrix[i, jj] = matrix[i, jj+1];
                            matrix[i, jj+1] = tmp;
                        } 
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix) // dotnet test --filter Tests.ProgramTests.Task_3_11Test
    {
        // code here
        if (matrix.Length == 0) return null;

        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.Length / rowCount;
        bool[] hasNoZero = new bool[rowCount];
        int validRowCount = 0;

        for (int row=0; row < rowCount; row++) {
            hasNoZero[row] = true;
            for (int col=0; col < columnCount; col++) {
                if (matrix[row, col] == 0) hasNoZero[row] = false;
            }
            if (hasNoZero[row]) validRowCount++;
        }
        if (validRowCount==0) return null;

        int[,] filteredMatrix = new int[validRowCount, columnCount];
        int currentRow = 0;

        for (int row=0; row<rowCount; row++) {
            if (hasNoZero[row]) {
                for (int col=0; col<columnCount; col++) {
                    filteredMatrix[currentRow, col] = matrix[row, col];
                }
                currentRow++;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        
        // end

        return filteredMatrix;
    }
    #endregion
}