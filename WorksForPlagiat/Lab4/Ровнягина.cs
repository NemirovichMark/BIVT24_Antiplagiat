using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1);
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) { return 0; }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                answer += A[i, j];
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) { return (0, 0); }
        double min_el = double.PositiveInfinity;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < min_el) 
                { 
                    min_el = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
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
        int n = 3, m = 5;
        int[] answer = new int[m];
        // code here        
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return (null); }
        for (int j = 0; j < m; j++) // Проходим по столбцам
            {
                int max_el = int.MinValue; 
                for (int i = 0; i < n; i++) // Проходим по строкам
                {
                    if (A[i, j] > max_el)
                    {
                        max_el = A[i, j]; 
                    }
                }
                answer[j] = max_el; 
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
        int row = 5, col = 7;
        if (A.GetLength(0) != row || A.GetLength(1) != col) { return (null); }
        int max_row = 0;
        int max_el = int.MinValue;
        for (int i = 0; i < row; i++)
        {
            if (A[i, 2] > max_el) 
            { 
                max_el = A[i, 2];
                max_row = i;
            }
        }
        for (int j = 0; j < col; j++)
        {
            int temp = A[max_row, j];
            A[max_row, j] = A[3, j];
            A[3, j] = temp; 
        }
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
        int row = 5, col = 5;
        int index_max = 0;
        if (A.GetLength(0) != row || A.GetLength(1) != col) { return (null); }
        int max_el = int.MinValue;
        for (int i = 0; i < row; i++)
        {
            if (A[i, i] > max_el)
            {
                max_el = A[i, i];
                index_max = i;             
            }
        }
        for (int i = 0; i < row; i++)
        {
            int temp = A[i, index_max];
            A[i, index_max] = A[i, 3];
            A[i, 3] = temp;
        }
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
        for (int i = 0; i < n; i++)
        {
            int max_el = int.MinValue;
            int max_index = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    max_index = j;
                }
            }
            for (int j = max_index; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = max_el;
        }
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
        for (int i = 0; i < n; i++)
        {
            double max_el = double.MinValue;
            int max_index = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i,j] > max_el)
                {
                    max_el = C[i,j];
                    max_index = j;

                }
            }
            for (int j = 0; j < max_index; j++)
            {
                if (C[i,j] < 0)
                {
                    C[i,j] /= max_el; 
                }
            }
        }
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) { return null; }
        double max_el = double.MinValue;
        int max_i = 0, max_j = 0;
        double s_positive = 0;
        int cout_positive = 0, positive_i = 0, positive_j = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i,j] > max_el)
                {
                    max_el = Z[i, j];
                    max_i = i;
                    max_j = j;
                }
                if (Z[i,j] > 0)
                {
                    s_positive += Z[i, j];
                    cout_positive++;
                    positive_i = i;
                    positive_j = j;
                }
            }
        }
        double sr = s_positive / cout_positive;
        Z[max_i, max_j] = sr;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) { return null; }
        int max_negative_count = int.MinValue;
        int min_negative_count = int.MaxValue;
        int min_index = -1, max_index = -1;
        for (int i = 0; i < 6; i++)
        {
            int cout_negative = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    cout_negative++;
                }
            }
            if (cout_negative < min_negative_count)
            {
                min_negative_count = cout_negative;
                min_index = i;
            }
            else if (cout_negative > max_negative_count)
            {
                max_negative_count = cout_negative;
                max_index = i;
            }
        }
        if (min_index != -1 && max_index != -1)
        {
            for (int j = 0; j < 5; j++)
            {
                int temp = X[min_index, j];
                X[min_index, j] = X[max_index, j];
                X[max_index, j] = temp;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        int row = 7, col = 5, max_sum = int.MinValue, index_i = -1;
        for (int i = 0; i < row; i++)
        {
            int sum = 0;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > max_sum)
            {
                max_sum = sum;
                index_i = i; 
            }
        }

        if (index_i == -1)
        {
            return A;
        }

        int[,] result = new int[row - 1, col];

        for (int i = 0, newRow = 0; i < row; i++)
        {
            if (i != index_i) // пропускаем строку с максимальной суммой
            {
                for (int j = 0; j < col; j++)
                {
                    result[newRow, j] = A[i, j];
                }
                newRow++;
            }
        }      

        return result;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) { return null; }
        int row = 5, col = 8, min_el = int.MaxValue, index_j = -1;      
        for (int j = 0; j < col - 1; j++)
        {
            if (A[4, j] < min_el)
            {
                min_el = A[4, j];
                index_j = j;
            }
        }
        if (index_j == -1) { return null; } 
        for (int i = 0; i < row; i++)
        {
            for (int j = 7; j < index_j; j--)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < row; i++)
        {
            A[i, index_j + 1] = B[i];
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        int row = 5, col = 7;        
        for (int i = 0; i < row; i++)
        {
            double max_el = double.MinValue;
            int max_index = -1;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    max_index = j;
                }
            }
            if (max_index == 0)
            {
                if (A[i, 1] < 0)
                {
                    A[i, 1] /= 2;
                }
                else
                {
                    A[i, 1] *= 2;
                }
            }
            else if (max_index == col - 1)
            {
                if (A[i, col - 2] < 0)
                {
                    A[i, col - 2] /= 2;
                }
                else
                {
                    A[i, col - 2] *= 2;
                }
                
            }
            else
            {
                if (A[i, max_index - 1] < A[i, max_index + 1])
                {
                    if (A[i, max_index - 1] < 0)
                    {
                        A[i, max_index - 1] /= 2;
                    }
                    else
                    {
                        A[i, max_index - 1] *= 2;
                    }                   
                }
                else
                {
                    if (A[i, max_index + 1] < 0)
                    {
                        A[i, max_index + 1] /= 2;
                    }
                    else
                    {
                        A[i, max_index + 1] *= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        
        for (int j = 0; j < 5; j++)
        {
            int cout_pol = 0, cout_neg = 0, max_el = int.MinValue, index_i = -1;
            for (int i = 0; i < 7; i++)
            {                
                if (A[i, j] > 0)
                {
                    cout_pol++;
                }
                if (A[i, j] < 0)
                {
                    cout_neg++;
                }
                if (A[i,j] > max_el)
                {
                    max_el = A[i,j];
                    index_i = i;
                }
            }
            if (cout_pol > cout_neg)
            {
                A[index_i, j] = 0;
            }
            else
            {
                A[index_i, j] = index_i + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < 5; j++)
        {
            int max_el = int.MinValue, index_i = -1;
            for (int i = 0; i < 10; i++)
            {
                if ((A[i, j]) > max_el)
                {
                    max_el = A[i, j];
                    index_i = i;
                }
            }
            if (index_i < 5)
            {
                int sum = 0;
                for (int i = index_i + 1; i < 10; i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5 ) { return null; }

        for (int j = 0; j < 5; j++)
        {
           int max_el = int.MinValue, index_i = -1;
            for (int i = 0; i < 7; i++)
            {
                if (A[i,j] > max_el) 
                { 
                    max_el = A[i, j];
                    index_i = i;
                }
            }  
            if (max_el < B[j])
            {
                A[index_i, j] = B[j];
            }
        }
        // end
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }

        for (int j = 0; j < 5; j++)
        {
            double max_el = double.MinValue;
            int index_i = -1;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    index_i = i;
                }
            }
            if (max_el < ((A[0,j] + A[4,j]) / 2)) 
            {
                A[index_i, j] = (A[0, j] + A[4, j]) / 2;
            }
            else
            {
                A[index_i, j] = index_i + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) { return null; }
        int[,] resultMatrix = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            resultMatrix[i, i] = 1;         // Первая единичная матрица
            resultMatrix[i, i + n] = 1;     // Вторая единичная матрица
            resultMatrix[i, i + 2 * n] = 1; // Третья единичная матрица
        }
        // end

        return resultMatrix;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) { return null; }
        int max_el = int.MinValue, index_i = -1;
        for (int i = 0; i < 6; i++)
        {
             if (A[i,i] > max_el)
             {
                max_el = A[i,i];
                index_i = i;
             }            
        }
        for (int i = 0; i < index_i; i++)
        {
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) { return null; }
        int maxIndex1 = 0, maxIndex2 = 0;
        int maxEl1 = int.MinValue, maxEl2 = int.MinValue;

        for (int j = 0; j < 6; j++)
        {
            if (B[0, j] > maxEl1)
            {
                maxEl1 = B[0, j];
                maxIndex1 = j;
            }
        }

        for (int j = 0; j < 6; j++)
        {
            if (B[1, j] > maxEl2)
            {
                maxEl2 = B[1, j];
                maxIndex2 = j;
            }
        }

        int temp = B[0, maxIndex1];
        B[0, maxIndex1] = B[1, maxIndex2];
        B[1, maxIndex2] = temp;

        maxIndex1 = 0;
        maxIndex2 = 0;
        maxEl1 = int.MinValue;
        maxEl2 = int.MinValue;

        for (int j = 0; j < 6; j++)
        {
            if (B[2, j] > maxEl1)
            {
                maxEl1 = B[2, j];
                maxIndex1 = j;
            }
        }

        for (int j = 0; j < 6; j++)
        {
            if (B[3, j] > maxEl2)
            {
                maxEl2 = B[3, j];
                maxIndex2 = j;
            }
        }

        temp = B[2, maxIndex1];
        B[2, maxIndex1] = B[3, maxIndex2];
        B[3, maxIndex2] = temp;

        maxIndex1 = 0;
        maxIndex2 = 0;
        maxEl1 = int.MinValue;
        maxEl2 = int.MinValue;

        for (int j = 0; j < 6; j++)
        {
            if (B[4, j] > maxEl1)
            {
                maxEl1 = B[4, j];
                maxIndex1 = j;
            }
        }

        for (int j = 0; j < 6; j++)
        {
            if (B[5, j] > maxEl2)
            {
                maxEl2 = B[5, j];
                maxIndex2 = j;
            }
        }

        temp = B[4, maxIndex1];
        B[4, maxIndex1] = B[5, maxIndex2];
        B[5, maxIndex2] = temp;


        return B;
    }

    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) { return null; }
        
        for (int i = 0; i < 6; i++)
        {
            int col = 6;
            for (int j = 0; j < 3; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i,col];
                A[i, col] = temp;
                col--;
            }
        }
        // end

        return A;
    }

    #region Level 3
   public int[,] Task_3_1(int[,] matrix)
   {
        return matrix; 
   }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
            matrix[0, i] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        for (int i = row/2; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
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
        
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int size = matrix.GetLength(0);
        int[] upper = new int[size * (size + 1) / 2]; 
        int[] lower = new int[size * (size - 1) / 2];
        int k = 0; 
        int l = 0;
        for (int i = 0; i < size; i++)
        {
            
            for (int j = 0; j < size; j++)
            {
                if (j >= i)
                {
                    upper[k] = matrix[i, j];
                    k++;
                }
                else
                {
                    lower[l] = matrix[i, j];
                    l++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] positiveCounts = new int[7];
                
        for (int i = 0; i < 7; i++)
        {
            int countPos = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0)
                {
                    countPos++;
                }
            }
            positiveCounts[i] = countPos;
        }
        
        for (int i = 0; i < 7 - 1; i++)
        {
            for (int j = 0; j < 7 - i - 1; j++)
            {
                
                if (positiveCounts[j] < positiveCounts[j + 1])
                {                    
                    int tempCount = positiveCounts[j];
                    positiveCounts[j] = positiveCounts[j + 1];
                    positiveCounts[j + 1] = tempCount;
                                        
                    for (int k = 0; k < 5; k++)
                    {
                        int tempValue = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = tempValue;
                    }
                }
            }
        }

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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);        
        for (int i = 0; i < row; i += 2) 
        {
            for (int j = 0; j < col - 1; j++)
            {
                for (int k = 0; k < col - j - 1; k++)
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
        for (int i = 1; i < row; i += 2) 
        {
            for (int j = 0; j < col - 1; j++)
            {
                for (int k = 0; k < col - j - 1; k++)
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

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0) return null;

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int nonZeroRowCount = 0;

        for (int i = 0; i < row; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < col; j++)
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

        int[,] result = new int[nonZeroRowCount, col];
        int resultRowIndex = 0;
        
        for (int i = 0; i < row; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break; 
                }
            }
            if (!hasZero)
            {
                
                for (int j = 0; j < col; j++)
                {
                    result[resultRowIndex, j] = matrix[i, j];
                }
                resultRowIndex++; 
            }
        }

        return result;
    }


    #endregion
}