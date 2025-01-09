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

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        if (A.GetLength(0) != 5)
        {
            return 0;
        }
        
        if (A.GetLength(1) != 7)
        {
            return 0;
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
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

        if (A.GetLength(0) != 3)
        {
            return (row, col);
        } 
         
        if (A.GetLength(1) != 6)
        {
            return (row, col);
        }
   
        int MinElement = int.MaxValue;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < MinElement)
                {
                    MinElement = A[i, j];
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
        //int[] answer = default(int[]);
        // code here

        if (A.GetLength(0) != 3)
        {
            return null;
        }
            
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        int[] answer = new int[5];
        int MaxElement;

        for (int j = 0; j < 5; j++)
        {
            MaxElement = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (MaxElement < A[i, j])
                {
                    MaxElement = A[i, j];
                }
            
            }
            answer[j] = MaxElement;
           
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

        if (A.GetLength(0) != 5)
        {
            return null;
        }
           
        if (A.GetLength(1) != 7)
        {
            return null;
        }

        int MaxElement = int.MinValue;
        int MaxRow = -1;
        int tempValue;
        for (int i = 0; i < 5; i++)
        {
            if (MaxElement <= A[i, 2])
            {
                MaxElement = A[i, 2];
                MaxRow = i;
            }
            
        }

        if (MaxRow == 3)
        {
            return A;
        }
    
        else
        {
            for (int j = 0; j < 7; j++)
            {
                tempValue = A[3, j];
                A[3, j] = A[MaxRow, j];
                A[MaxRow, j] = tempValue;
            }
            
        }

        //end

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

        if (A.GetLength(0) != 5)
        {
            return null;
        }
           
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        int MaxElement = int.MinValue;
        int MaxRow = -1;
        int tempValue;
        for (int i = 0; i < 5; i++)
        {
            if (MaxElement < A[i, i])
            {
                MaxElement = A[i, i];
                MaxRow = i;
            }
          
        }

        if (MaxRow == 3)
        {
            return A;
        }

        for (int i = 0; i < 5; i++)
        {
            tempValue = A[i, 3];
            A[i, 3] = A[i, MaxRow];
            A[i, MaxRow] = tempValue;
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

        if (A.GetLength(0) != n)
        {
            return null;
        }

        if (A.GetLength(1) != m)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            int MaxElement = int.MinValue;
            int MaxIndex = 0;
            for (int j = 0; j < m; j++)
            {
                if (MaxElement < A[i, j])
                {
                    MaxElement = A[i, j];
                    MaxIndex = j;
                }
            }

            for (int j = MaxIndex + 1; j < m; j++)
            {
                (A[i, j], A[i, j - 1]) = (A[i, j - 1], A[i, j]);
            }
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

        if (C.GetLength(0) != n)
        {
            return null;
        }

        if (C.GetLength(1) != m)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            double MaxElement = double.MinValue;
            int MaxIndex = 0;
            for (int j = 0; j < m; j++)
            {
                if (MaxElement < C[i, j])
                {
                    MaxElement = C[i, j];
                    MaxIndex = j;
                }
            }

            if (MaxElement == 0)
            {
                continue;
            }
               
            for (int j = 0; j < MaxIndex; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] /= MaxElement;
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

        if (Z.GetLength(0) != 6) 
        {
            return null;
        }

        if (Z.GetLength(1) != 8)
        {
            return null;
        }

        int column = 0, line = 0;
        double sum = 0; 
        int count = 0;
        double MaxElement = double.MinValue;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    count++;
                }
                if (MaxElement < Z[i, j])
                {
                    MaxElement = Z[i, j];
                    column = j;
                    line = i;
                }
            }
        }

        Z[line, column] = sum / count;

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

        if (X.GetLength(0) != 6)
        {
            return null;
        }
            
        if (X.GetLength(1) != 5)
        {
            return null;
        }
  
        int[] count = new int[] {0, 0, 0, 0, 0, 0};

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    count[i]++;
                }
            }
        }

        int minIndex = -1, maxIndex = -1;
        int maxCount = int.MinValue;
        int minCount = int.MaxValue;
        int tempValue;

        for (int i = 0; i < 6; i++)
        {
            if (maxCount < count[i])
            {
                maxCount = count[i];
                maxIndex = i;
            }
            
            if (count[i] < minCount)
            {
                minCount = count[i];
                minIndex = i;
            }
        }

        if (minIndex == maxIndex)
        {
            return X;
        }

        for (int j = 0; j < 5; j++)
        {
            tempValue = X[minIndex, j];
            X[minIndex, j] = X[maxIndex, j];
            X[maxIndex, j] = tempValue;
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

        if (A.GetLength(0) != 7)
        {
            return null;
        }
         
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        int sum = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < 7; i++)
        {
            int tempValue = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0)
                {
                    tempValue += A[i, j];
                }
            }
            if (sum < tempValue)
            {
                sum = tempValue;
                maxIndex = i;
            }
        }

        int[,] newArray = new int[6, 5];
        for (int i = 0; i < maxIndex; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newArray[i, j] = A[i, j];
            }
        }
        for (int i = maxIndex + 1; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newArray[i - 1, j] = A[i, j];
            }
        }

        // end

        return newArray;
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

        if (A.GetLength(0) != 5)
        {
            return null;
        }
     
        if (A.GetLength(1) != 8)
        {
            return null;
        }
           
        if (B.GetLength(0) != 5)
        {
            return null;
        }

        int minElement = int.MaxValue;
        int minIndex = -1;

        for (int j = 0; j < 8; j++)
        {
            if (A[4, j] < minElement)
            {
                minIndex = j;
                minElement = A[4, j];
            }
        }

        if (minIndex < 7)
        {
            for (int i = 0; i < 5; i++)
            {
                A[i, minIndex + 1] = B[i];
            }
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

        if (A.GetLength(0) != 5)
        {
            return null;
        }

        if (A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < 5; i++)
        {
            int maxIndex = 0;
            double maxElement = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (maxElement < A[i, j])
                {
                    maxIndex = j;
                    maxElement = A[i, j];
                }
            }

            double left = int.MaxValue;
            double right = int.MaxValue;
            if (maxIndex > 0)
            {
                left = A[i, maxIndex - 1];
            }
               
            if (maxIndex < 7)
            {
                right = A[i, maxIndex + 1];
            }
           
            if (left < right)
            {
                if (A[i, maxIndex - 1] > 0)
                {
                    A[i, maxIndex - 1] *= 2;
                }
                else
                {
                    A[i, maxIndex - 1] /= 2;
                }
            }

            else if (left > right)
            {
                if (A[i, maxIndex + 1] > 0)
                {
                    A[i, maxIndex + 1] *= 2;
                }

                else
                {
                    A[i, maxIndex + 1] /= 2;
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

        if (A.GetLength(0) != 7)
        {
            return null;
        }
  
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int maxElement = int.MinValue;
            int maxIndex = -1;
            int minus = 0, plus = 0;

            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0)
                {
                    plus++;
                }
                else
                {
                    minus++;
                }

                if (maxElement < A[i, j])
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            if (plus > minus)
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
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 10)
        {
            return null;
        }
         
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int maxElement = int.MinValue;
            int maxIndex = -1;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (maxElement < A[i, j])
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            if (maxIndex < 5)
            {
                for (int i = maxIndex + 1; i < 10; i++)
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

        if (B.GetLength(0) != 5)
        {
            return null;
        }
       
        if (A.GetLength(0) != 7)
        {
            return null;
        }
            
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int maxElement = int.MinValue; 
            int maxIndex = -1;
            for (int i = 0; i < 7; i++)
            {
                if (maxElement < A[i, j])
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            if (B[j] > maxElement)
            {
                A[maxIndex, j] = B[j];
            }
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        if (A.GetLength(0) != 7)
        {
            return null;
        }
           
        if (A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            double maxElement = int.MinValue;
            int maxIndex = -1;
            double avg = (A[0, j] + A[6, j]) / 2;
            for (int i = 0; i < 7; i++)
            {
                if (maxElement < A[i, j])
                {
                    maxElement = A[i, j];
                    maxIndex = i;
                }
            }

            if (maxElement < avg)
            {
                A[maxIndex, j] = avg;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        //int[,] answer = default(int[,]);
        // code here

        if (n <= 0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j, j + i] = 1;
            }
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6)
        {
            return null;
        }
            
        if (A.GetLength(1) != 6)
        {
            return null;
        }

        int maxElement = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < 6; i++)
        {
            if (maxElement < A[i, i])
            {
                maxElement = A[i, i];
                maxIndex = i;
            }
        }

        for (int i = 0, count = 0; i < maxIndex; i++)
        {
            count++;
            for (int j = count; j < 6; j++)
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

        if (B.GetLength(0) != 6)
        {
            return null;
        }
       
        if (B.GetLength(1) != 6)
        {
            return null;
        }

        for (int i = 0; i < 6; i += 2)
        {
            int max1 = int.MinValue;
            int maxIndex1 = -1;
            int max2 = int.MinValue;
            int maxIndex2 = -1;
            for (int j = 0; j < 6; j++)
            {
                if (max1 < B[i, j])
                {
                    max1 = B[i, j];
                    maxIndex1 = j;
                }
               
                if (max2 < B[i + 1, j])
                {
                    max2 = B[i + 1, j];
                    maxIndex2 = j;
                }
            }

            B[i, maxIndex1] = max2; 
            B[i + 1, maxIndex2] = max1;
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6)
        {
            return null;
        }
     
        if (A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int tempValue = A[i, 7 - 1 - j];
                A[i, 7 - 1 - j] = A[i, j];
                A[i, j] = tempValue;
            }
        }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        if (matrix.GetLength(0) != 7)
        {
            return null;
        } 
        
        if (matrix.GetLength(1) != 5)
        {
            return null;
        }

        int row = 7;
        int col = 5;

        int[] min = new int[row];
        int[] minIndex = new int[row];

        for (int i = 0; i < row; i++)
        {
            min[i] = matrix[i, 0];
            minIndex[i] = i;
            for (int j = 1; j < col; j++)
            {
                if (matrix[i, j] < min[i])
                {
                    min[i] = matrix[i, j];
                }
            }
        }

        for (int i = 0; i < row - 1; i++)
        {
            for (int j = i + 1; j < row; j++)
            {
                if (min[i] < min[j])
                {
                    int tempMin = min[i];
                    min[i] = min[j];
                    min[j] = tempMin;

                    int tempIndex = minIndex[i];
                    minIndex[i] = minIndex[j];
                    minIndex[j] = tempIndex;
                }
            }
        }

        int[,] answer = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                answer[i, j] = matrix[minIndex[i], j];
            }
        }

        matrix = answer;

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
        //int[] answer = default(int[]);
        // code here

        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        int m = matrix.GetLength(0);

        int[] answer = new int[2 * m - 1];

        for (int i = -(m - 1); i <= (m - 1); i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (0 <= j + i && j + i < m)
                {
                    sum += matrix[j, j + i];
                }
            }
            answer[i + (m - 1)] = sum;
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

        if (matrix.GetLength(0) != matrix.GetLength(1) || k <= 0)
        {
            return null;
        }

        int m = matrix.GetLength(0);
        int row = 0;
        int col = 0;
        int max = matrix[row, col];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(max))
                {
                    max = matrix[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        k--;

        if (col != k)
        {
            for (int i = 0; i < m; i++)
            {
                int temp = matrix[i, col];
                matrix[i, col] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        if (row != k)
        {
            for (int j = 0; j < m; j++)
            {
                int temp = matrix[row, j];
                matrix[row, j] = matrix[k, j];
                matrix[k, j] = temp;
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

        if (A.Length + A.Length - n != n * n)
        {
            return null;
        }
        if (B.Length + B.Length - n != n * n)
        {
            return null;
        }
        
        int[,] m1 = new int[n, n];
        int[,] m2 = new int[n, n];
        answer = new int[n * n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                m1[i, j] = A[count];
                m1[j, i] = A[count];
                m2[i, j] = B[count];
                m2[j, i] = B[count];
                count++;
            }
        }
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += m1[i, j] * m2[j, k];
                }
                answer[count] = sum;
                count++;
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

        if (matrix.GetLength(0) != 5)
        {
            return null;
        }
        if (matrix.GetLength(1) != 7)
        {
            return null;
        }
                
        int[] minus = new int[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] < 0)
                {
                    minus[i]++;
                } 
            }
        }

        for (int i = 1; i < minus.Length; i++)
        {
            int j = i - 1;
            while (j >= 0 && minus[j] > minus[j + 1])
            {
                (minus[j], minus[j + 1]) = (minus[j + 1], minus[j]);
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    (matrix[k, j], matrix[k, j + 1]) = (matrix[k, j + 1], matrix[k, j]);
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

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[] zero = new int[n];
        count = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero[i] = 1;
                    count--;
                    break;
                }
            }
        }
        int[,] answer = new int[count, m];
        count = 0;
        for (int i = 0; i < n; i++)
        {
            if (zero[i] == 1)
            {
                continue;
            }
            for (int j = 0; j < m; j++)
            {
                answer[count, j] = matrix[i, j];
            }
            count++;
        }

        // end

        return answer;
    }
    #endregion
}