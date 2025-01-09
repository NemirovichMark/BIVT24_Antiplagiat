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
        /*
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣉⠟⣋⢻⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠇⠃⠐⠀⣼⣿⣿
        ⡿⠟⠛⠛⢉⣭⣥⣆⠀⢹⠁⠉⣽⣆⢿⣿⣿
        ⡇⠀⠀⠀⠈⣿⣿⣿⣶⣾⣷⣶⣿⣿⢸⣿⣿
        ⡇⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿
        ⣿⣦⣀⠠⠼⢿⢿⣿⡿⠛⣋⣬⣿⣿⣸⣿⣿
        ⣿⣿⣿⣿⣷⡶⢈⠛⠻⠶⠚⠛⠋⣡⡜⢿⣿
        ⣿⣿⣿⣿⣿⠇⢨⣿⣶⣶⣶⣾⣿⢀⡿⡌⣿
        ⣿⣿⣿⣿⣿⡆⠘⠿⣿⣿⣿⣿⠿⢠⣴⡇⣽
        ⣿⣿⣿⣿⣿⣿⡄⣦⠀⠀⠀⠀⣰⠌⠉⢸⣿
        ⣿⣿⣿⣿⣿⣿⣷⢹⠿⢧⠸⡿⣿⣷⡇⢸⣿
        ⣿⣿⣿⣿⣿⣿⣿⠈⣓⡛⡀⠓⠬⠽⠇⢸⣿
        ⣿⣿⣿⣿⣿⣿⢋⣥⠉⠉⣛⠘⠛⠛⢃⢸⣿
        ⣿⣿⣿⣿⣿⣿⣌⠒⠛⢈⡀⠜⠵⠄⠁⣼⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣶⣾⣿⣿
        */
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;

        double answer = 0;
        int counter = 0;
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 7; j++) {
                if (A[i, j] > 0) {
                    answer += A[i, j];
                    counter++;
                }
            }
        }
        answer /= counter;

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0, 0);
        
        int value = 0, rowIndex = -1;
        
        for (int i = 0; i < A.GetLength(0); i++) {
            if (A[i, colIndex] < 0) {
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        
        double[] answer = new double[4];
        int jj = 0;
        
        for (int i = 0; i < 4; i++) {
            double avg = 0;
            int c = 0;
            for (int j = 0; j < 6; j++) {
                if (A[i, j] > 0) {
                    avg += A[i, j];
                    c++;
                }
            }
            answer[jj] = (c != 0) ? avg / c : 0;
            jj++;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] newA = new int[4, 7];
        int minVal = int.MaxValue, toDelete = -1;

        for (int i = 0; i < 5; i++) {
            if (A[i, 0] < minVal) {
                minVal = A[i, 0];
                toDelete = i;
            }
        }   

        for (int i = 0; i < 5; i++) {
            if (i == toDelete) continue;
            for (int j = 0; j < 7; j++) {
                newA[(i < toDelete) ? i : i - 1, j] = A[i, j];
            }
        }

        return newA;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        int[] answer = new int[3];

        int jj = 0;
        for (int j = 0; j < 3; j++) {
            int c = 0;
            for (int i = 0; i < 4; i++) {
                if (A[i, j] < 0) c++;
            }
            answer[jj] = c;
            jj++;
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
       if (B.GetLength(0) != n || B.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++) {
            int minVal = int.MaxValue, pos = -1;
            for (int j = 0; j < m; j++) {
                if (B[i, j] < minVal) {
                    minVal = B[i, j];
                    pos = j;
                }
            }
            
            for (int j = pos; j > 0; j--) {
                B[i, j] = B[i, j - 1];
            }

            B[i, 0] = minVal;
        }

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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++) {
            
            double firstNeg = double.NaN, lastNeg = double.NaN;

            for (int j = 0; j < m; j++) {
                if (F[i, j] < 0) { 
                    firstNeg = F[i, j];
                    break;
                }
            }

            for (int j = m - 1; j >= 0; j--) {
                if (F[i, j] < 0) {
                    lastNeg = F[i, j];
                    break;
                }
            }

            double maxVal = double.MinValue;
            int maxPos = -1;

            for (int j = 0; j < m; j++) {
                if (maxVal < F[i, j]) {
                    maxVal = F[i, j];
                    maxPos = j;
                }
            }

            if (!double.IsNaN(firstNeg) && !double.IsNaN(lastNeg))
                F[i, maxPos] = (firstNeg + lastNeg) / 2.0;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++) {
            int maxVal = int.MinValue, maxPos = -1;
            for (int j = 0; j < 6; j++) {
                if (maxVal < G[i, j]) {
                    maxVal = G[i, j];
                    maxPos = j;
                }
            }

            for (int j = 6; j > maxPos + 1; j--) {
                G[i, j] = G[i, j - 1];
            }

            G[i, maxPos + 1] = maxVal;
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (B.Length != 7) return null;

        int maxVal = int.MinValue, maxPos = -1;

        for (int i = 0; i < 5; i++) {
            if (maxVal < A[i, 5]) {
                maxVal = A[i, 5];
                maxPos = i;
            }
            
        }

        for (int j = 0; j < 7; j++) {
            A[maxPos, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;

        int[,] newF = new int[5, 6];

        int minAbsVal = int.MaxValue, minAbsPos = -1;

        for (int j = 0; j < 7; j++) {
            if (minAbsVal > Math.Abs(F[1, j])) {
                minAbsVal = Math.Abs(F[1, j]);
                minAbsPos = j;
            }
        }

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 7; j++) {
                if (j < minAbsPos + 1) newF[i, j] = F[i, j];
                else if (j > minAbsPos + 1) newF[i, j - 1] = F[i, j];
            }
        }
        
        F = newF;

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++) {
            double maxVal = double.MinValue;
            int maxPos = -1;

            double avgPositive = 0;
            int positiveCounter = 0; // :)
            for (int j = 0; j < 7; j++) {
                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = j;
                }

                if (A[i, j] > 0) {
                    avgPositive += A[i, j];
                    positiveCounter++;
                }
            }
            if (positiveCounter != 0)
                A[i, maxPos] = (avgPositive / positiveCounter);
            else
                A[i, maxPos] = 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++) {
            double maxVal = double.MinValue;
            int maxPos = -1;
            for (int j = 0; j < 7; j++) {
                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = j;
                }
            }

            if (maxPos == 0) {
                A[i, 1] *= A[i, 1] > 0 ? 2 : 0.5;
            } else if (maxPos == 6) {
                A[i, 5] *= A[i, 5] > 0 ? 2 : 0.5;
            } else {
                if (A[i, maxPos - 1] < A[i, maxPos + 1]) {
                    A[i, maxPos - 1] *= A[i, maxPos - 1] > 0 ? 2 : 0.5;
                } else {
                    A[i, maxPos + 1] *= A[i, maxPos + 1] > 0 ? 2 : 0.5;                   
                }
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++) {
            int maxVal = int.MinValue, maxPos = -1;
            int pos = 0, neg = 0;
            for (int i = 0; i < 7; i++) {
                if (A[i, j] > 0) pos++;
                else if (A[i, j] < 0) neg++;

                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = i;
                }
            }

            if (pos > neg) A[maxPos, j] = 0;
            else A[maxPos, j] = maxPos + 1;
        }
        
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++) {
            int maxVal = int.MinValue, maxPos = -1;
            for (int i = 0; i < 10; i++) {
                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = i;
                }
            }

            if (maxPos <= 4) {
                int sum = 0;
                for (int i = maxPos + 1; i < 10; i++) {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        if (B.Length != 5) return null;

        for (int j = 0; j < 5; j++) {
            int maxVal = int.MinValue, maxPos = -1;
            for (int i = 0; i < 7; i++) {
                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = i;
                }
            }
            if (B[j] > A[maxPos, j]) A[maxPos, j] = B[j];
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++) {
            double maxVal = double.MinValue;
            int maxPos = -1;
            for (int i = 0; i < 7; i++) {
                if (maxVal < A[i, j]) {
                    maxVal = A[i, j];
                    maxPos = i;
                }
            }
            double sum = (A[0, j] + A[6, j]) / 2.0;

            if (maxVal < sum)
                A[maxPos, j] = sum;
            else 
                A[maxPos, j] = maxPos + 1;
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;

        int[,] answer = new int[n, 3*n];
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < 3 * n; j++) {
                int columnMod = j % n;
                answer[i, j] = i == columnMod ? 1 : 0;
            }
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int maxDiag = int.MinValue, maxDiagPos = -1;

        for (int i = 0; i < 6; i++) {
            if (maxDiag < A[i, i]) {
                maxDiag = A[i, i];
                maxDiagPos = i;
            }
        }

        for (int i = 0; i < maxDiagPos; i++) {
            for (int j = 0; j < 6; j++) {
                if (j > i) A[i, j] = 0;
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        int lastMax = int.MinValue, lastMaxPos = -1;
        for (int i = 0; i < 6; i++) {
            int maxVal = int.MinValue, maxPos = -1;
            for (int j = 0; j < 6; j++) {
                if (maxVal < B[i, j]) {
                    maxVal = B[i, j];
                    maxPos = j;
                }
            }

            if (lastMax != int.MinValue && (i % 2 != 0)) {
                B[i, maxPos] = lastMax;
                B[i - 1, lastMaxPos] = maxVal;
            }

            lastMax = maxVal;
            lastMaxPos = maxPos;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < 6; i++) {
            int temp;
            for (int j = 0; j < 7 / 2; j++) {
                temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;

        int[] minElements = new int[7];

        for (int i = 0; i < 7; i++) {
            int minVal = int.MaxValue;
            for (int j = 0; j < 5; j++) {
                if (minVal > matrix[i, j]) {
                    minVal = matrix[i, j];
                }
            }
            minElements[i] = minVal;
        }

        for (int i = 1; i < minElements.Length; i++) {
            int key = minElements[i], j = i - 1;

            while (j >= 0 && minElements[j] < key) {
                minElements[j + 1] = minElements[j];
                for (int k  = 0; k < 5; k++) {
                    int temp = matrix[j, k];
                    matrix[j, k] = matrix[j + 1, k];
                    matrix[j + 1, k] = temp;
                }
                j--;
            }
            minElements[j + 1] = key;
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        int len = matrix.GetLength(0);

        int[] answer = new int[2 * len - 1];
        
        for (int sum = 0; sum < len; sum++) {
            for (int row = len - 1, col = sum; row >= 0 && col >= 0 && col < len; row--, col--) {
                answer[sum] += matrix[row, col];
            }
        }

        for (int sum = len; sum < 2 * len - 1; sum++) {
            for (int row = 2 * (len - 1) - sum, col = len - 1; row >= 0 && col >= 0; row--, col--) {
                answer[sum] += matrix[row, col];
            }
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        int n = matrix.GetLength(0);
        if (!(1 <= k && k <= n)) return null;

        int maxVal = int.MinValue, maxRow = -1, maxCol = -1;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (maxVal < Math.Abs(matrix[i, j])) {
                    maxVal = Math.Abs(matrix[i, j]);
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        // Переставляем столбцы, затем строки

        for (int i = 0; i < n; i++) {
            int temp = matrix[i, maxCol];
            matrix[i, maxCol] = matrix[i, k - 1];
            matrix[i, k - 1] = temp;
        }

        for (int i = 0; i < n; i++) {
            int temp = matrix[maxRow, i];
            matrix[maxRow, i] = matrix[k - 1, i];
            matrix[k - 1, i] = temp;
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
        int expected = n * (n + 1) / 2;
        if (A.Length != expected || B.Length != expected) return null;
        
        int[] answer = new int[n * n];

        int[] fullA = new int[n * n], fullB = new int[n * n];

        int indexA = 0, indexB = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= i)
                {
                    fullA[i * n + j] = A[indexA++];
                    fullB[i * n + j] = B[indexB++];
                }
                else
                {
                    fullA[i * n + j] = fullA[j * n + i];
                    fullB[i * n + j] = fullB[j * n + i];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    answer[i * n + j] += fullA[i * n + k] * fullB[k * n + j];
                }
            }
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 5 || cols != 7) return null;

        int[] negCount = new int[cols];
        int[] indexes = new int[cols];

        for (int j = 0; j < cols; j++) {
            indexes[j] = j;
            for (int i = 0; i < rows; i++) {
                if (matrix[i, j] < 0) negCount[j]++;
            }
        }

        for (int i = 0; i < negCount.Length - 1; i++) {
            for (int j = 0; j < negCount.Length - 1 - i; j++) {
                if (negCount[j] > negCount[j + 1]) {
                    int temp = negCount[j];
                    negCount[j] = negCount[j + 1];
                    negCount[j + 1] = temp;

                    int temp2 = indexes[j];
                    indexes[j] = indexes[j + 1];
                    indexes[j + 1] = temp2;
                }
            }
        }

        int[,] newMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                newMatrix[i, j] = matrix[i, indexes[j]];
            }
        }

        matrix = newMatrix;
        
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

        int rowsWithZero = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    rowsWithZero++;
                    break;
                }
            }
        }
        
        int[,] newMatrix = new int[rows - rowsWithZero, cols];
        int[] rowsWithZeroIndexes = new int[rowsWithZero];
        int c = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    rowsWithZeroIndexes[c] = i;
                    c++;
                    break;
                }
            }
        }

        int rowsCounter = 0;

        for (int i = 0; i < rows; i++) {
            bool check = false;
            for (int q = 0; q < rowsWithZeroIndexes.Length; q++) {
                if (rowsWithZeroIndexes[q] == i) check = true;
            }
            if (check) continue;
            for (int j = 0; j < cols; j++) {
                newMatrix[rowsCounter, j] = matrix[i, j];
            }
            rowsCounter++;
        }

        matrix = newMatrix;

        return matrix;
    }
    #endregion
}
