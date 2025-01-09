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
        int[] a = { 1, 4, -5, -7, 0, 9, 6, 5, 4, 2, 3, 1, 1 };
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
        // code her
        if (A.GetLength(0) != 4) { return answer; }
     
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
        int[] answer = new int[A.Length];
        // code here
        int m = 0;
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        answer = new int[A.GetLength(0)];
        if (rows != 4 || columns != 7)
        {
            return default;
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                int min = A[i, 0];
                int index = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        index = j;
                    }
                }
                answer[m] = index;
                m++;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default;
        }

        for (int i = 0; i < 5; i++)
        {
            int max = A[i, 0];
            int maxIndex = 0;

            for (int j = 1; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }

            int temp = A[i, 0];
            A[i, 0] = max;
            A[i, maxIndex] = temp;
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

        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return default;
        }
        int[,] answer = new int[5, 6];

        int max = int.MinValue;
        int j_max = -1;
        int i_max = -1;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    i_max = i;
                    j_max = j;
                    
                }
            }
        }
        int k = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == i_max) continue;
            int m = 0;
            for (int j = 0; j < 7; j++)
            {
                if (j == j_max) continue;
                answer[k, m] = A[i, j];
                m++;
            }
            k++;
        }
        A = answer;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxElement = A[i, 0];
            int maxIndex = 0;

            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    maxIndex = j;
                }
            }

            
            A[i, maxIndex] *= (i + 1);
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
        if (D == null || D.Length == 0) return default;
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int maxIndex = -1;
            int lastNegi = -1;

            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    if (lastNegi == -1)
                    {
                        lastNegi = j; 
                    }

                    lastNegi = j;
                }
                else if (lastNegi == -1) 
                {
                    if (maxIndex == -1 || D[i, j] > D[i, maxIndex])
                    {
                        maxIndex = j; 
                    }
                }
            }
            
            if (maxIndex != -1 && lastNegi != -1)
            {
                int temp = D[i, maxIndex];
                D[i, maxIndex] = D[i, lastNegi];
                D[i, lastNegi] = temp;
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
        if (H == null || H.Length == 0) return default;
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return default;
        }
        int[] maxElements = new int[H.GetLength(0)];
        for (int i = 0; i < 5; i++)
        {
            int m = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > m)
                {
                    m = H[i, j];
                }
            }
            maxElements[i] = m;
        }

        int[] temp = new int[5];
        for (int i = 0; i < 5; i++)
        {
            temp[i] = H[i, 5];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 5] = maxElements[i];
        }
        for (int i = 0; i < 5; i++)
        {
            H[i, 6] = temp[i];
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
        int columns = Y.GetLength(1);
        if (rows != 6 || columns != 5) return default; 
        if (Y == null || Y.Length == 0) return default;
        for (int i = 0; i < rows; i++)
        {
            double max = Y[i, 0];
            int jmax = 0;
            for (int j = 0; j < columns; j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    jmax = j;
                }
            }
            if (jmax == columns - 1)
            {
                for (int j = 0; j < jmax; j++)
                {
                    if (Y[i, j] < 0) Y[i, j] = 0;
                }
            }
            if (jmax != columns - 1 && jmax != 0)
            {
                double sum = 0;
                int count = 0;
                for (int j = jmax + 1; j < columns; j++)
                {
                    if (Y[i, j] > 0)
                    {
                        sum += Y[i, j];
                        count++;
                    }
                }
                double average = 0.0;
                if (count > 0) { average = sum / count; }

                if (count != columns)
                {
                    for (int j = 0; j < jmax; j++)
                    {
                        if (Y[i, j] < 0)
                        {
                            Y[i, j] = average;
                        }
                    }
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return null;
        }
        if (B == null || B.Length == 0) return default;
        int[] max = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int min = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > min) min = B[i, j];
            }
            max[4 - i] = min;
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return default;
        if (B == null || B.Length == 0) return default;
        int rows = B.GetLength(0);
        int columns = B.GetLength(1);
        int max = B[0, 0];
        int i1 = 0;
        for (int i = 0; i < rows; i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                i1 = i;
            }
        }
        int i2 = -1;
        for (int i = 0; i < columns; i++)
        {
            int jindex = 0;
            for (int j = 0; j < rows; j++)
            {
                if (B[i, j] < 0)
                {
                    jindex = j;
                    break;
                }
            }
            if (jindex == 2)
            {
                i2 = i;
                break;
            }
        }
        for (int j = 0; j < columns; j++)
        {
            int temp = B[i1, j];
            B[i1, j] = B[i2, j];
            B[i2, j] = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (A == null || A.Length == 0) return null;
        int[] answer = default(int[]);
        // code here
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }
        answer = new int[count];
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (A == null || A.Length == 0) return null;
        for (int i = 0; i < 5; i++)
        {
            double max = int.MinValue;
            int index = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            }
            if (index == 0)
            {
                if (A[i, 1] < 0) A[i, 1] /= 2;
                else A[i, 1] *= 2;
            }
            else if (index == 6)
            {
                if (A[i, 5] < 0) A[i, 5] /= 2;
                else A[i, 5] *= 2;
            }
            else
            {
                if (A[i, index - 1] < A[i, index + 1])
                {
                    if (A[i, index - 1] < 0) 
                    { 
                        A[i, index - 1] /= 2; 
                    }
                    else 
                    { 
                        A[i, index - 1] *= 2; 
                    }
                }
                else
                {
                    if (A[i, index + 1] < 0) 
                    { 
                        A[i, index + 1] /= 2; 
                    }
                    else 
                    { 
                        A[i, index + 1] *= 2; 
                    }
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
        if (A == null || A.Length == 0) return null;
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        int max, maxI, neg, pos;

        for (int j = 0; j < 5; j++)
        {
            max = int.MinValue; maxI = -1;
            neg = 0; pos = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) pos++;
                else neg++;

                if (max < A[i, j]) { max = A[i, j]; maxI = i; }
            }

            if (pos > neg) A[maxI, j] = 0;
            else A[maxI, j] = maxI + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.Length == 0) return null;
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = A[0, i];
            int maxIndex = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxIndex = j;
                }
            }

            if (maxIndex <= A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int j = maxIndex + 1; j < A.GetLength(0); j++)
                    sum += A[j, i];
                A[0, i] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.Length == 0) return null;
        if (B.GetLength(0) != 5) return default;
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        int max, maxI;

        for (int j = 0; j < 5; j++)
        {
            max = int.MinValue; maxI = -1;
            for (int i = 0; i < 7; i++)
            {
                if (max < A[i, j]) { max = A[i, j]; maxI = i; }
            }

            if (B[j] > max) A[maxI, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.Length == 0) return null;
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            double max = int.MinValue;
            int index = -1;

            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            double demisum = (A[0, j] + A[6, j]) / 2;
            if (max < demisum)
            {
                A[index, j] = demisum;
            }
            else { A[index, j] = index + 1; }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n < 0) { return default; }
        answer = new int[n, 3*n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        int cashe = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = cashe; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
            cashe++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.Length == 0) return null;
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int rows = A.GetLength(0);
        int maxI = 0;
        for (int i = 1; i < rows; i++)
        {
            if (A[i, i] > A[maxI, maxI]) maxI = i;
        }
        for (int i = 0; i < maxI; i++)
        {
            for (int j = i + 1; j < rows; j++) A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.Length == 0) return null;
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int rows = B.GetLength(0), cols = B.GetLength(1);
        for (int i = 0; i < rows; i += 2)
        {
            int maxJ = 0;
            int maxI = 0;
            for (int j = 0; j < cols; j++)
            {
                if (B[i, j] > B[i, maxJ]) maxJ = j;
            }
            for (int j = 0; j < cols; j++)
            {
                if (B[i + 1, j] > B[i + 1, maxI]) maxI = j;
            }
            int cashe = B[i, maxJ];
            B[i, maxJ] = B[i + 1, maxI];
            B[i + 1, maxI] = cashe;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.Length == 0) return null;
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int cashe;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                cashe = A[i, 7 - 1 - j];
                A[i, 7 - 1 - j] = A[i, j];
                A[i, j] = cashe;
            }
        }
        // end

        return A;
    }

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
        if (matrix == null || matrix.Length == 0) return null;
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[0, i] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
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
        if (matrix == null || matrix.Length == 0) return null;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        if (rows != columns) { return default; }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int length = matrix.GetLength(0);
        int[] upper = new int[length * (length - 1) / 2 + length];
        int[] lower = new int[length * (length - 1) / 2];
        int count1 = 0, count2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j)
                {
                    upper[count1] = matrix[i, j];
                    count1++;
                }
                else
                {
                    lower[count2] = matrix[i, j];
                    count2++;
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
        if (matrix == null || matrix.Length == 0) return null;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        if (rows != 7 || columns != 5) return null;
        int[] positive = new int[rows];
        if (rows != 7 || columns != 5) return default;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - i - 1; j++)
            {
                int current = 0, next = 0;
                for (int k = 0; k < columns; k++)
                {
                    if (matrix[j, k] > 0)
                    {
                        current++;
                    }
                    if (matrix[j + 1, k] > 0)
                    {
                        next++;
                    }

                }
                if (current < next)
                {
                    int[] temp = new int[columns];
                    for (int k = 0; k < columns; k++)
                    {
                        temp[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp[k];
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
        if (matrix == null || matrix.Length == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 != 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;
                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;
                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1];
                    matrix[i, matrix.GetLength(1) - j - 1] = temp;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.Length == 0) return null;
        int length = matrix.GetLength(0);
        int[] cashe = new int[length];
        bool isTrue = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            isTrue = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    length--;
                    isTrue = false;
                    break;
                }
            }
            if (isTrue)
            {
                cashe[i] = 1;
            }
        }
        int[,] A = new int[length, matrix.GetLength(1)];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (cashe[i] == 1)
                {
                    A[count, j] = matrix[i, j];
                }
            }
            count++;
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}