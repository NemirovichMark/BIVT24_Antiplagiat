using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    
    public static double IncreaseByTwo(double value) {
        return (value >= 0) ? value * 2 : value / 2;
    }

    public static (int, double) MaxRowValue(int[,] matrix, int rowIndex, bool absValue = false) {
        double maxValue = double.MinValue;
        int maxIndex = 0;

        for (int j = 0; j < matrix.GetLength(1); j++) {
            int curValue = matrix[rowIndex, j];

            if (absValue)
                curValue = Math.Abs(curValue);

            if (curValue > maxValue) {
                maxValue = curValue;
                maxIndex = j;
            }
        }

        return (maxIndex, maxValue);
    }

    public static (int, double) MaxRowValue(double[,] matrix, int rowIndex) {
        double maxValue = double.MinValue;
        int maxIndex = 0;

        for (int j = 0; j < matrix.GetLength(1); j++) {
            double curValue = matrix[rowIndex, j];

            if (curValue > maxValue) {
                maxValue = curValue;
                maxIndex = j;
            }
        }

        return (maxIndex, maxValue);
    }

    public static (int, double) MinRowValue(int[,] matrix, int rowIndex, bool absValue = false) {
        double minValue = double.MaxValue;
        int minIndex = 0;


        for (int j = 0; j < matrix.GetLength(1); j++) {
            int curValue = matrix[rowIndex, j];

            if (absValue)
                curValue = Math.Abs(curValue);

            if (curValue < minValue) {
                minValue = curValue;
                minIndex = j;
            }
        }

        return (minIndex, minValue);
    }

    public static (int, double) MaxColumnValue(int[,] matrix, int colIndex) {
        double maxValue = double.MinValue;
        int maxIndex = 0;

        for (int i = 0; i < matrix.GetLength(0); i++) {
            int curValue = matrix[i, colIndex];

            if (curValue > maxValue) {
                maxValue = curValue;
                maxIndex = i;
            }
        }

        return (maxIndex, maxValue);
    }

    public static (int, double) MaxColumnValue(double[,] matrix, int colIndex) {
        double maxValue = double.MinValue;
        int maxIndex = 0;

        for (int i = 0; i < matrix.GetLength(0); i++) {
            double curValue = matrix[i, colIndex];

            if (curValue > maxValue) {
                maxValue = curValue;
                maxIndex = i;
            }
        }

        return (maxIndex, maxValue);
    }
    public static (int, double) MinColumnValue(int[,] matrix, int colIndex) {
        double minValue = double.MaxValue;
        int minIndex = 0;

        for (int i = 0; i < matrix.GetLength(0); i++) {
            int curValue = matrix[i, colIndex];

            if (curValue < minValue) {
                minValue = curValue;
                minIndex = i;
            }
        }

        return (minIndex, minValue);
    }


    public static int ColumnNegativeCount(int[,] matrix, int colIndex) {
        
        int negativeCount = 0;

        for (int i = 0; i < matrix.GetLength(0); i++) {
            if (matrix[i, colIndex] < 0)
                negativeCount++;
        }

        return negativeCount;
    }
    
    public static void Main()
    {
        Program program = new Program();
              int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            };

            program.Task_3_5(matrix, 2);

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return 0;

        double sum = 0;
        int n = 0;

        for (int i = 0; i < 5; i++) {

            for (int j = 0; j < 7; j++) {
                int curElement = A[i, j];
                
                if (curElement > 0) {
                    sum += curElement;
                    n++;
                }
            }
        }
        answer = sum / n;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) 
            return (0, 0);

        for (int row = 0; row < 5; row++) {
            int curValue = A[row, colIndex];
            if (curValue < 0) {
                rowIndex = row;
                value = curValue;
                break;
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
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) 
            return null;


        answer = new double[4];

        for (int i = 0; i < 4; i++) {
            
            double sum = 0, curAverage = 0;
            int n = 0;
            for (int j = 0; j < 6; j++) {
                int curValue = A[i, j];
                if (curValue > 0) {
                    sum += curValue;
                    n++;
                }
            }

            if (n != 0)
                curAverage = sum / n;

            answer[i] = curAverage;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) 
            return null;

        var (minRowIndex, minValue) = MinColumnValue(A, 0); 

        int[,] answer = new int[4, 7];

        for (int i = 0; i < 4; i++) {
            
            for (int j = 0; j < 7; j++) {

                if (i < minRowIndex) 
                    answer[i, j] = A[i, j];
                else
                    answer[i, j] = A[i + 1, j]; 
            }
        }
        // end

        return answer;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) 
            return null;

        answer = new int[3];

        for (int j = 0; j < 3; j++) {
            
            int negativeCount = 0;

            for (int i = 0; i < 4; i++) {
                if (A[i, j] < 0)
                    negativeCount++;
            }

            answer[j] = negativeCount;
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

        for (int i = 0; i < n; i++) {
            var (minIndex, minValue) = MinRowValue(B, i);

            for (int k = minIndex; k > 0; k--) 
                (B[i, k], B[i, k - 1]) = (B[i, k - 1], B[i, k]);
            
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
        for (int i = 0; i < n; i++) {
            
            double firstNegativeValue = 0, lastNegativeValue = 0;

            for (int j = 0; j < m; j++) {

                double curValue = F[i, j];

                if (curValue < 0) {
                    if (firstNegativeValue == 0)
                        firstNegativeValue = curValue;

                    lastNegativeValue = curValue;
                }
            }
            
            var (maxIndex, maxValue) = MaxRowValue(F, i);

            if (firstNegativeValue != 0)
                F[i, maxIndex] = (firstNegativeValue + lastNegativeValue) / 2;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return null;

        for (int i = 0; i < 5; i++) {
            var (maxIndex, maxValue) = MaxRowValue(G, i);

            for (int j = 6; j > maxIndex + 1; j--) {
                (G[i, j], G[i, j - 1]) = (G[i, j - 1], G[i, j]);
            }
            
            G[i, maxIndex + 1] = (int) maxValue;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
            return null;
        // end

        var (maxIndex, maxValue) = MaxColumnValue(A, 5);

        for (int j = 0; j < 7; j++) {
            A[maxIndex, j] = B[j];
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
        // code here
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return null;

        var (minIndex, minValue) = MinRowValue(F, 1, true);
        
        minIndex += 1;
        
        int[,] modifiedArr = new int[5, 6];

        for (int i = 0; i < 5; i++) {

            for (int j = 0; j < 6; j++) {

                if (j < minIndex) 
                    modifiedArr[i, j] = F[i, j];
                else
                    modifiedArr[i, j] = F[i, j + 1];

            }
        }

        // end

        return modifiedArr;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < 5; i++) {

            var (maxIndex, maxValue) = MaxRowValue(A, i);

            double positiveSum = 0, average = 0;
            int n = 0;

            for (int j = 0; j < 7; j++) {
                double curValue = A[i, j];

                if (curValue > 0) {
                    positiveSum += curValue;
                    n++;
                }
            }

            if (n != 0)
                average = positiveSum / n;

            A[i, maxIndex] = average;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < 5; i++) {
            var (maxIndex, maxValue) = MaxRowValue(A, i);

            if (maxIndex == 0)
                A[i, 1] = IncreaseByTwo(A[i, 1]);
            else if (maxIndex == 4)
                A[i, 3] = IncreaseByTwo(A[i, 3]);
            else if (A[i, maxIndex - 1] < A[i, maxIndex + 1])
                A[i, maxIndex - 1] = IncreaseByTwo(A[i, maxIndex - 1]);
            else    
                A[i, maxIndex + 1] = IncreaseByTwo(A[i, maxIndex + 1]);
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < 5; j++) {
            int negativeCount = 0, positiveCount = 0;

            var (maxIndex, maxValue) = MaxColumnValue(A, j);

            for (int i = 0; i < 7; i++) {
                if (A[i, j] > 0)
                    positiveCount++;
                else
                    negativeCount++;
            }

            if (positiveCount > negativeCount)
                A[maxIndex, j] = 0;
            else    
                A[maxIndex, j] = maxIndex;

        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < 5; j++) {
            
            var (maxIndex, maxValue) = MaxColumnValue(A, j);

            if (maxIndex < 5) {
                int afterMaxSum = 0;
                for (int i = maxIndex + 1; i < 10; i++) {
                    afterMaxSum += A[i, j];
                }   

                A[0, j] = afterMaxSum;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;

        for (int j = 0; j < 5; j++) {

            var (maxIndex, maxValue) = MaxColumnValue(A, j);

            if (B[j] > maxValue)
                A[maxIndex, j] = B[j];  
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < 5; j++) {

            var (maxIndex, maxValue) = MaxColumnValue(A, j);

            double halfSum = (A[0, j] + A[6, j]) / 2;

            if (maxValue < halfSum) 
                A[maxIndex, j] = halfSum;
            else
                A[maxIndex, j] = maxIndex;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0)
            return null;

        answer = new int[n, 3 * n];
        
        for (int i = 0; i < n; i++) {

            for (int j = 0; j < 3 * n; j++) {

                if (i == j % 3)
                    answer[i, j] = 1;
                else
                    answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;


        int maxValue = int.MinValue; 
        int maxIndex = 0;

        for (int i = 0; i < 6; i++) {
            if (A[i, i] > maxValue) {
                maxValue = A[i, i];
                maxIndex = i;
            }
        }

        for (int i = 0; i < maxIndex; i++) {

            for (int j = i + 1; j < 6; j++) {
                A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;

        for (int i = 0; i < 3; i++) {
            var (maxIndex1, maxValue1) = MaxRowValue(B, i * 2);
            var (maxIndex2, maxValue2) = MaxRowValue(B, i * 2 + 1);

            (B[i * 2, maxIndex1], B[i * 2 + 1, maxIndex2]) = (B[i * 2 + 1, maxIndex2], B[i * 2, maxIndex1]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < 6; i++) {

            int l = 0, r = 6;

            while (l < r) {
                (A[i, l], A[i, r]) = (A[i, r], A[i, l]);
                l++;
                r--;
            }


        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return null;
        

        for (int i = 0; i < 6; i++) {
            int curMaxValue = int.MinValue;
            int curMaxIndex = -1;

            for (int k = i; k < 7; k++) {
                var (minIndex, minValue) = MinRowValue(matrix, k);

                if (minValue > curMaxValue) {
                    curMaxValue = (int) minValue;
                    curMaxIndex = k;
                }
            }

            if (curMaxIndex != i) {
                for (int j = 0; j < 5; j++) {
                    (matrix[i, j], matrix[curMaxIndex, j]) = (matrix[curMaxIndex, j], matrix[i, j]);
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1))
            return null;

        answer = new int[2 * n - 1];

        for (int i = 0; i < 2 * n - 1; i++) {
            int curDiagonalSum = 0;

            if (i < n) {
                for (int diagI = n - i - 1, diagJ = 0; diagI < n; diagI++, diagJ++) {
                    curDiagonalSum += matrix[diagI, diagJ];
                }
            } else {
                for (int diagI = 0, diagJ = i - n + 1; diagJ < n; diagI++, diagJ++) {
                    curDiagonalSum += matrix[diagI, diagJ];
                }
            }
            answer[i] = curDiagonalSum;
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

        if (n != matrix.GetLength(1) || k <= 0 || k > n)
            return null;

        k -= 1;
        int maxValue = 0, maxI = 0, maxJ = 0;

        for (int i = 0; i < n; i++) {
            var (rowMaxIndex, rowMaxValue) = MaxRowValue(matrix, i, true);

            if (rowMaxValue > maxValue) {
                maxValue = (int) rowMaxValue;
                maxI = i;
                maxJ = rowMaxIndex;
            }
    
        }


        if (maxI != k) {
            for (int j = 0; j < n; j++) {
                (matrix[k, j], matrix[maxI, j]) = (matrix[maxI, j], matrix[k, j]);
            }
        }

        if (maxJ != k) {
            for (int i = 0; i < n; i++) {
                (matrix[i, k], matrix[i, maxJ]) = (matrix[i, maxJ], matrix[i, k]);
            }
        }
        
        // end

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

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
        if (n != (-1 + Math.Sqrt(1 + 8 * A.Length)) / 2 || A.Length != B.Length)
            return null;

        answer = new int[n * n];

        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        
        for (int i = 0, k = 0; i < n; i++) {

            for (int j = i; j < n; j++) {
                matrixA[i, j] = A[k];
                matrixA[j, i] = matrixA[i, j];

                matrixB[i, j] = B[k];
                matrixB[j, i] = matrixB[i, j];

                k++;
            }

        }
        // end


        int[,] matrixProduct = new int[n, n];

        for (int i = 0; i < n; i++) {

            for (int j = 0; j < n; j++) {
                int curSum = 0;

                for (int r = 0; r < n; r++) {
                    curSum += matrixA[i, r] * matrixB[r, j];
                }

                matrixProduct[i, j] = curSum;
            }
        }

        Console.WriteLine("Matrix A:");
        for (int i = 0; i < n; i++) {
            
            for (int j = 0; j < n; j++) {
                Console.Write(matrixA[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nMatrix B:");
        for (int i = 0; i < n; i++) {

            for (int j = 0; j < n; j++) {
                Console.Write(matrixB[i, j] + " ");
            }

            Console.WriteLine();
        }

        
        Console.WriteLine("\nMatrix A x B:");
        for (int i = 0, k = 0; i < n; i++) {

            for (int j = 0; j < n; j++) {
                int curEl = matrixProduct[i, j];
                Console.Write(curEl + " ");
                answer[k] = curEl;
                k++;
            }

            Console.WriteLine();
        }


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
            return null;


        for (int j = 1; j < 7; j++) {
            
            int curColNegativeCount = ColumnNegativeCount(matrix, j);

            int[] curCol = new int[7];
            for (int row = 0; row < 5; row++) {
                curCol[row] = matrix[row, j];
            }

            int jInsert = j - 1;

            while (jInsert >= 0 && ColumnNegativeCount(matrix, jInsert) > curColNegativeCount) {
                
                
                for (int row = 0; row < 5; row++) {
                    matrix[row, jInsert + 1] = matrix[row, jInsert];
                }

                jInsert--;
            }

            for (int row = 0; row < 5; row++) {
                matrix[row, jInsert + 1] = curCol[row];
            }

        }
        // end

        for (int i = 0; i < 5; i++) {
            
            for (int j = 0; j < 7; j++) {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

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

        int rowsNum = matrix.GetLength(0), colsNum = matrix.GetLength(1);
        int nonZeroRowsCount = rowsNum;

        for (int i = 0; i < rowsNum; i++) {

            for (int j = 0; j < colsNum; j++) {
                if (matrix[i, j] == 0) {
                    nonZeroRowsCount--;
                    break;
                }
            }
        }
        
        int[] nonZeroRowsIndexes = new int[nonZeroRowsCount];
        int k = 0;

        for (int i = 0; i < rowsNum; i++) {

            bool zeroNotFound = true;

            for (int j = 0; j < colsNum; j++) {
                if (matrix[i, j] == 0) {
                    zeroNotFound = false;
                    break;
                }
            }

            if (zeroNotFound) {
                nonZeroRowsIndexes[k] = i;
                k++;
            }
        }

        int[,] resultMatrix = new int[nonZeroRowsCount, colsNum];

        for (int i = 0; i < nonZeroRowsCount; i++) {

            for (int j = 0; j < colsNum; j++) {
                resultMatrix[i, j] = matrix[nonZeroRowsIndexes[i], j];
            }
        }
        // end

        return resultMatrix;
    }
    #endregion
}