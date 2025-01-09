using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[] A = { 1, 2, 3, 4, 5, 6 };
        int[] B = { 10, 11, 12, 13, 14, 15 };
        int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        program.Task_3_7(A, B, 3);
        program.Task_3_3(matrix);
    }
    public void Print(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) 
                Console.Write($"{matrix[i, j]} ");
            System.Console.WriteLine();
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 4) return 0;
        for (int i = 0; i < A.GetLength(0); i++)
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
        int[] answer = default(int[]);
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 7) return null;
        answer = new int[n];
        int indexMin;
        for (int i = 0; i < n; i++) {
            indexMin = 0;
            for (int j = 1; j < m; j++) 
                if (A[i, j] < A[i, indexMin]) indexMin = j;
            answer[i] = indexMin;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        int indexMax;
        for (int i = 0; i < n; i++) {
            indexMax = 0;
            for (int j = 1; j < m; j++)
                if (A[i, j] > A[i, indexMax]) indexMax = j;
            int tmp = A[i, 0];
            A[i, 0] = A[i, indexMax];
            A[i, indexMax] = tmp;
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
        
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return null;
        int iMax = 0, jMax = 0;        

        var output = new int[n-1, m-1];
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < m; j++)
                if (A[i, j] > A[iMax, jMax]) {
                    iMax = i;
                    jMax = j;
                }
            
        for (int i = 0; i < iMax; i++) 
            for (int j = 0; j < jMax; j++)
                output[i, j] = A[i, j];
        
        for (int i = iMax+1; i < n; i++)
            for (int j = 0; j < jMax; j++)
                output[i-1, j] = A[i, j];
        
        for (int i = 0; i < iMax; i++)
            for (int j = jMax+1; j < m; j++)
                output[i, j-1] = A[i, j];

        for (int i = iMax+1; i < n; i++)
            for (int j = jMax+1; j < m; j++)
                output[i-1, j-1] = A[i, j];

        A = output;
        
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        int indexMax;
        for (int i = 0; i < n; i++) {
            indexMax = 0;
            for (int j = 1; j < m; j++)
                if (A[i, j] > A[i, indexMax]) indexMax = j;
            A[i, indexMax] *= i + 1;
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
        int indexMax, indexLastNegative = -1;
        bool flag;
        for (int i = 0; i < n; i++) {
            flag = D[i, 0] >= 0;
            if (!flag) continue;
            indexMax = 0;
            for (int j = 1; j < m; j++) {
                if (flag) 
                    if (D[i, j] > D[i, indexMax]) indexMax = j;
                if (D[i, j] < 0) {
                    flag = false;
                    indexLastNegative = j;
                }
            }
            int tmp = D[i, indexMax];
            D[i, indexMax] = D[i, indexLastNegative];
            D[i, indexLastNegative] = tmp;
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
        int n = H.GetLength(0), m = H.GetLength(1);
        if (n != 5 || m != 7) return null;
        int max;
        for (int i = 0; i < n; i++) {
            max = H[i, 0];  
            for (int j = 1; j < m; j++) 
                if (H[i, j] > max) max = H[i, j];
            H[i, m-1] = H[i, m-2];
            H[i, m-2] = max;
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
        int n = Y.GetLength(0), m = Y.GetLength(1), count, indexMax;
        if (n != 6 || m != 5) return null;
        double sum, average;
        for (int i = 0; i < n; i++) {
            indexMax = 0;
            for (int j = 1; j < m; j++)
                if (Y[i, j] > Y[i, indexMax]) indexMax = j;

            if (indexMax == 0) continue;
            sum = 0;
            count = 0;

            for (int j = indexMax+1; j < m; j++)
                if (Y[i, j] > 0) { sum += Y[i, j]; count++; }

            average = sum == 0 ? 0 : sum / count;

            for (int j = 0; j < indexMax; j++)
                if (Y[i, j] < 0) Y[i, j] = average;
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
        int n = B.GetLength(0), m = B.GetLength(1), max;
        if (n != 5 || m != 7) return null;
        int[] arrayOfMax = new int[n];
        for (int i = n-1; i >= 0; i--) {
            max = B[i, 0];
            for (int j = 1; j < m; j++) 
                if (B[i, j] > max) max = B[i, j];
            arrayOfMax[n-i-1] = max;
        }
        for (int i = 0; i < n; i++)
            B[i, 3] = arrayOfMax[i];
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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 5) return null;
        int lineMax = 0, lineFirstNegative = -1;

        for (int i = 1; i < n; i++) 
            if (B[i, i] > B[lineMax, lineMax]) lineMax = i; 
        
        for (int i = 0; i < n; i++)
            if (B[i, 2] < 0) { lineFirstNegative = i; break; }

        if (lineFirstNegative == -1) return B;

        for (int j = 0; j < m; j++) {
            int tmp = B[lineMax, j];
            B[lineMax, j] = B[lineFirstNegative, j];
            B[lineFirstNegative, j] = tmp;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        int size = 0;
        foreach (var i in A)
            if (i < 0) size++;

        answer = new int[size];
        int j = 0;

        foreach (var i in A)
            if (i < 0) { answer[j] = i; j++; }

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        int indexMax;
        for (int i = 0; i < n; i++) {
            indexMax = 0;
            for (int j = 1; j < m; j++) 
                if (A[i, j] > A[i, indexMax]) indexMax = j;

            if (indexMax == 0) {
                A[i, indexMax+1] = A[i, indexMax+1] > 0 ? A[i, indexMax+1] * 2 : A[i, indexMax+1] / 2; 
            }
            else if (indexMax == m-1) {
                A[i, indexMax-1] = A[i, indexMax-1] > 0 ? A[i, indexMax-1] * 2 : A[i, indexMax-1] / 2; 
            }
            
            indexMax = A[i, indexMax+1] < A[i, indexMax-1] ? indexMax+1 : indexMax-1;
            A[i, indexMax] = A[i, indexMax] > 0 ? A[i, indexMax] * 2 : A[i, indexMax] / 2;
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        int countPositive, countNegative, indexMax;
        for (int j = 0; j < m; j++) {
            countPositive = 0; countNegative = 0; indexMax = 0;
            for (int i = 0; i < n; i++) {
                if (A[i, j] > 0) countPositive++;
                else if (A[i, j] < 0) countNegative++;
                if (A[i, j] > A[indexMax, j]) indexMax = i;
            }
            A[indexMax, j] = countPositive > countNegative ? 0 : indexMax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        int indexMax, sumAfterMax;
        for (int j = 0; j < m; j++) {
            indexMax = 0;
            sumAfterMax = 0;
            for (int i = 1; i < n; i++)
                if (A[i, j] > A[indexMax, j]) { indexMax = i; sumAfterMax = 0; }
                else sumAfterMax += A[i, j];
            if (indexMax < 5) A[0, j] = sumAfterMax;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;
        int indexMax;
        for (int j = 0; j < m; j++) {
            indexMax = 0;
            for (int i = 1; i < n; i++)
                if (A[i, j] > A[indexMax, j]) indexMax = i;

            if (A[indexMax, j] < B[j]) A[indexMax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        int indexMax;
        double sum;
        for (int j = 0; j < m; j++) {
            indexMax = 0;
            sum = (A[0, j] + A[n-1, j]) / 2;
            for (int i = 1; i < n; i++)
                if (A[i, j] > A[indexMax, j]) indexMax = i;
            A[indexMax, j] = A[indexMax, j] < sum ? sum : indexMax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, 3*n];
        for (int i = 0; i < n; i++) {
            answer[i, i] = 1;
            answer[i, i + n] = 1;
            answer[i, i + 2*n] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return null;
        int indexMax = 0;
        for (int i = 1; i < n; i++)
            if (A[i, i] > A[indexMax, indexMax]) indexMax = i;
        
        for (int i = 0; i < indexMax; i++)
            for (int j = i+1; j < m; j++)
                A[i, j] = 0;
            
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) return null;
        int indexMax, tmpIndex = -1, tmp;
        for (int i = 0; i < n; i++) {
            indexMax = 0;
            for (int j = 1; j < m; j++)
                if (B[i, j] > B[i, indexMax]) indexMax = j;
            if (i % 2 == 0) tmpIndex = indexMax;
            else {
                tmp = B[i-1, tmpIndex];
                B[i-1, tmpIndex] = B[i, indexMax];
                B[i, indexMax] = tmp;
            }
        }

            

        
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return null;
        int tmp;
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < m/2; j++) {
                tmp = A[i, j];
                A[i, j] = A[i, m-j-1];
                A[i, m-j-1] = tmp;
            }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return null;
        int[] arrayOfMin = new int[n]; 
        
        for (int i = 0; i < n; i++) {
            int indexMin = 0;
            for (int j = 1; j < m; j++)
                if (matrix[i, j] < matrix[i, indexMin]) indexMin = j;
            arrayOfMin[i] = matrix[i, indexMin];
        }
        for (int pos = 1; pos < n; pos++) {
            int i = pos;
            while (i > 0 && arrayOfMin[i-1] < arrayOfMin[i]) {
                int tmp = arrayOfMin[i-1];
                arrayOfMin[i-1] = arrayOfMin[i];
                arrayOfMin[i] = tmp;
                for (int j = 0; j < m; j++) {
                    tmp = matrix[i-1, j];
                    matrix[i-1, j] = matrix[i, j];
                    matrix[i, j] = tmp;
                }
                i--;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m) return null;
        answer = new int[2*n-1];
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < n; j++) {
                int index = j - i + n-1;
                answer[index] += matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k > n || k < 1) return null;
        --k;
        int iMax = 0, jMax = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[iMax, jMax])) { iMax = i; jMax = j; }

        if (iMax == k && jMax == k) return matrix;

        for (int j = 0; j < n; j++) {
            int tmp = matrix[k, j]; 
            matrix[k, j] = matrix[iMax, j];
            matrix[iMax, j] = tmp;
        }
        for (int i = 0; i < n; i++) {
            int tmp = matrix[i, k]; 
            matrix[i, k] = matrix[i, jMax];
            matrix[i, jMax] = tmp;
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
        int m1 = A.Length, m2 = B.Length;
        if (m1 != m2 || m1 == 0 || m2 == 0) return answer;
        var matrixA = new int[n, n];
        var matrixB = new int[n, n];
        var matrixRes = new int[n, n];
        answer = new int[n*n];
        int p = 0;
        for (int i = 0; i < n; i++) 
            for (int j = i; j < n; j++, p++) {
                matrixA[i, j] = A[p];
                matrixA[j, i] = A[p];
                matrixB[i, j] = B[p];
                matrixB[j, i] = B[p];
            }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++) 
                for (int k = 0; k < n; k++) {
                    matrixRes[i, j] += matrixA[i, k] * matrixB[k, j];
                }
        p = 0;
        foreach (var i in matrixRes) {
            answer[p] = i;
            p++;
        }
        Print(matrixA);
        System.Console.WriteLine("  X  ");
        Print(matrixB);
        System.Console.WriteLine("  =  ");
        Print(matrixRes);
        
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return null;
        var countNegative = new int[m];
        for (int j = 0; j < m; j++) {
            int k = 0;
            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) k++;
            countNegative[j] = k;
        }
        for (int pos = 1; pos < m; pos++) {
            int j = pos;
            while (j > 0 && countNegative[j-1] > countNegative[j]) {
                int tmp = countNegative[j-1];
                countNegative[j-1] = countNegative[j];
                countNegative[j] = tmp;
                for (int line = 0; line < n; line++) {
                    tmp = matrix[line, j-1];
                    matrix[line, j-1] = matrix[line, j];
                    matrix[line, j] = tmp;
                }
                j--;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int size = n;
        var breakPoint = new bool[n];
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0) {
                    breakPoint[i] = true;
                    size--;
                    break; 
                }

        if (size == n) return null;

        var output = new int[size, m];
        for (int i = 0, p = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (breakPoint[i]) break;
                output[p, j] = matrix[i, j];
            }
            p++;
        }
        matrix = output;
        // end

        return matrix;
    }
    #endregion
}