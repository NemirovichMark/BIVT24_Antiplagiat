using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
        int n = 5, m = 7;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++) answer += A[i, j];
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
        int row = 0, col = 0, n = 3, m = 6;
        double min = double.MaxValue;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m) return (0, 0);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            if (A[i, j] < min) 
            {
                min = A[i, j];
                row = i; //row = i+1;
                col = j; //col = j+1;
            }

        //end
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
        int n = 3, m = 5;
        answer = new int[m];
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int j = 0; j < m; j++)
        {
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }              
            answer[j] = A[imax, j];  
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
        int n = 5, m = 7;
        int imax = 0, max = int.MinValue, temp = 0, count = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
            if (A[i, 2] > max)
            {
                imax = i;
                max = A[i, 2];
            }
        for (int i = 0; i < n; i++)
            if (A[i, 2] == max) count++;
        if (count != 1) return null;
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (i == imax && imax < 3)
                {
                    temp = A[i, j];
                    A[i, j] = A[3, j];
                    A[3, j] = temp;
                }
                if (i == 3 && imax > 3)
                {
                    temp = A[3, j];
                    A[3, j] = A[i, j];
                    A[i, j] = temp;
                }
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
        int n = 5;
        int imax = 0, max = int.MinValue;
        if (A.GetLength(0) != n || A.GetLength(1) != n) return null;
        for (int i = 0; i < n; i++)
            if (A[i, i] > max)
            {
                imax = i;
                max = A[i, i];
            }
        if (imax == 3) return A;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {   
                if (j == imax && imax < 3)
                {
                    int temp = A[i, j];
                    A[i, j] = A[i, 3];
                    A[i, 3] = temp;
                }
                if (j == 3 && imax > 3)
                {
                    int temp = A[i, 3];
                    A[i, 3] = A[i, j];
                    A[i, j] = temp;
                }
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
        int[] maxA = new int[n];
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > A[i, jmax])
                    jmax = j;
            }              
            maxA[i] = jmax;  
        }
        for (int i=0; i < n; i++)
        {
            int temp = A[i, maxA[i]];
            for (int j = maxA[i] + 1; j < m; j++) A[i, j - 1] = A[i, j];
            A[i, m - 1] = temp;
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
        int [] maxA = new int[n];
        if (C.GetLength(0) != n || C.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > C[i, jmax])
                    jmax = j;
            }              
            maxA[i] = jmax;  
        }
        for(int i = 0; i < n; i++)
            for(int j = 0; j < maxA[i]; j++)
                if (C[i, j] < 0)
                    C[i, j] /= C[i, maxA[i]];
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
        int n = 6, m = 8, count = 0;
        double max = double.MinValue, average = 0;
        if (Z.GetLength(0) != n || Z.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (Z[i, j] > 0) 
                {
                    average += Z[i, j];
                    count++;
                }
        average /= count;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
        {
            if(Z[i, j] > max) max = Z[i, j];
        }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (Z[i, j] == max) Z[i, j] = average;
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
        int n = 6, m = 5;
        int countmax = 0, countmin = 5;
        int indMin = 0, indMax = 0;

        if (X.GetLength(0) != n || X.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] < 0)
                    count++;
            }              
            if (count > countmax) 
            {
                countmax = count;
                indMax = i;
            }
            if (count < countmin) 
            {
                countmin = count;
                indMin = i;
            }
        }

        for (int i = 0; i < m; i++)
        {
            int temp = X[indMin, i];
            X[indMin, i] = X[indMax, i];
            X[indMax, i] = temp;
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
        int n = 7, m = 5, max = int.MinValue, ind = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                    sum += A[i, j];
            }              
            if (sum > max) 
            {
                max = sum;
                ind = i;
            }
        }
        if (ind == n) return A;
        int[,] A2 = new int[n-1, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (i < ind)
                    A2[i, j] = A[i, j];
                else if (i > ind)
                    A2[i - 1, j] = A[i, j];
            }
        A = A2;
                   
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        int n = 5, m = 8, min = int.MaxValue, index = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m || B.Length != 5) return null;
        for (int i = 0; i < m; i++)
            if (A[4, i] < min)
            {
                min = A[4, i];
                index = i+1;
            }
        if (index != m)
        {
            for (int i = 0; i < n; i++)
            {
                A[i, index] = B[i];
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
        int n = 5, m = 7;
        double max = double.MinValue;
        int[] index = new int[n];
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
                if (A[i, j] > max)
                    {
                        jmax = j;
                        max = A[i, j];
                    }
            switch (jmax)
            {
                case 0:
                    if (A[i, jmax+1] > 0)
                        A[i, jmax+1] *= 2;
                    else A[i, jmax+1] /= 2;
                    break;
                case 6:
                    if (A[i, jmax-1] > 0)
                        A[i, jmax-1] *= 2;
                    else A[i, jmax-1] /= 2;
                    break;
                default:
                    if(A[i, jmax-1] < A[i, jmax+1]) 
                    {
                        if (A[i, jmax-1] < 0) A[i, jmax-1] /= 2;
                        else A[i,jmax-1] *= 2;
                    }
                    else
                    {
                        if (A[i, jmax+1] < 0) A[i, jmax+1] /= 2;
                        else A[i,jmax+1] *= 2;
                    }
                    break;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = 7, m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int j = 0; j < m; j++)
        {
            int countNeg = 0, countPos = 0, max = int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0) countNeg++;
                else countPos++;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (countPos > countNeg) A[imax, j] = 0;
            else A[imax, j] = imax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = 10, m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int j = 0; j < m; j++)
        {
            int sum = 0, max = int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                sum += A[i, j];
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                    sum = 0;
                }
            }
            if (imax < n/2) A[0, j] = sum;

        } 
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = 7, m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m || B.Length != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = 0, imax = int.MinValue;
            for (int i = 0; i < n; i++)
            if (A[i, j] > max)
            {
                max = A[i, j];
                imax = i;
            }
            if(B[j] > max) A[imax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = 7, m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int j = 0; j < m; j++)
        {
            double max = 0;
            int imax = int.MinValue;
            for (int i = 0; i < n; i++)
            if (A[i, j] > max)
            {
                max = A[i, j];
                imax = i;
            }
            double sum = (A[0, j] + A[n-1, j])/2;
            if (max < sum) A[imax, j] = sum;
            else A[imax, j] = imax+1;
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
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 3*n; j++)
            {
                if ((j - i) % n == 0) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = 6, max = int.MinValue, imax = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != n) return null;
        for (int i = 0; i < n; i++)
            if (A[i, i] > max) 
            {
                max = A[i, i];
                imax = i;
            }
        for (int i = 0; i < imax; i++)
            for (int j = 0; j < n; j++)
                if (j > i) A[i, j] = 0;
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = 6, tmp = 0;
        if (B.GetLength(0) != n || B.GetLength(1) != n) return null;
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue, jmax = 0;
            for (int j = 0; j < n; j++)
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    jmax= j;
                }
            if (i % 2 == 0)
                tmp = jmax;
            else
            {

                int temp = B[i, jmax];
                B[i, jmax] = B[i - 1, tmp];
                B[i - 1, tmp] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = 6, m = 7;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m/2; j++)
            {   
            int temp = A[i, j];
            A[i, j] = A[i, m - j - 1];
            A[i, m - j - 1] = temp;
            }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        /*int n = 7, m = 5, min = int.MaxValue;
        if (matrix == null || matrix.GetLength(0) != n || matrix.GetLength(1) != m) return null;
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(0); j++)
            {
                int min_i = 1000, min_j = 1000;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] < min_i)
                        min_i = matrix[i, k];
                    if (matrix[j, k] < min_j)
                        min_j = matrix[j, k];
                }
                if (min_i < min_j)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }
                }
            }
        */
        int n = 7, m = 5;
        int[,] mins = new int[n, 2];
        if (matrix == null || matrix.GetLength(0) != n || matrix.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmin = 0, min = int.MaxValue;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    jmin = j;
                }
            }
            mins[i, 0] = jmin;
            mins[i, 1] = min;
        }
        for (int i = 1, k = 2; i < n; )
        {
            if (i == 0 || mins[i, 1] <= mins[i-1, 1])
            {
                i = k;
                k++;
            }
            else
            {
                int temp0 = mins[i, 0], temp1 = mins[i, 1];
                for (int j = 0; j < m; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] =  matrix[i-1, j];
                    matrix[i-1, j] = temp;
                }
                mins[i, 0] = mins[i-1, 0];
                mins[i-1, 0] = temp0;
                
                mins[i, 1] = mins[i-1, 1];
                mins[i-1, 1] = temp1;
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
        int n = matrix.GetLength(0);
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1)) return null;
        answer = new int[2*n - 1];
        for(int i = 0; i < n; i++)
            for(int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
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
        int n = matrix.GetLength(0), max = int.MinValue;
        if (n != matrix.GetLength(1) || k < 1 || k > n || matrix == null) return null;
        int[] index = new int[2];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > max) 
                {
                    max = Math.Abs(matrix[i, j]);
                    index[0] = i; 
                    index[1] = j; 
                }

        if (index[1] != k-1)
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[index[0], j];
                matrix[index[0], j] = matrix[k-1, j];
                matrix[k-1, j] = temp;
            }
        if (index[0] != k-1)
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, index[1]];
                matrix[i, index[1]] = matrix[i, k-1];
                matrix[i, k-1] = temp;
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
        int index = 0;
        if (A.Length < 2 || B.Length < 2 || A == null || B == null || n == 0) return null;
        int[,] matrixA = new int[n, n], matrixB = new int[n, n];
        answer = new int[n*n];
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[index];
                matrixA[j, i] = A[index];

                matrixB[i, j] = B[index];
                matrixB[j, i] = B[index];
                index++;
            }
        int ind = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    answer[ind] += matrixA[i, k]*matrixB[k, j];
                ind++;
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
        int n = 5, m = 7;
        if ((matrix.GetLength(0) != n && matrix.GetLength(0) != m) || matrix == null) return null;
        int[] cnt = new int[m];
        for (int j = 0; j < m; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) count++;

            cnt[j] = count;
        }

        for (int i = 0; i < m; i++)
            for (int j = 0; j < m - i - 1; j++)
                if (cnt[j] > cnt[j+1])
                {
                    int temp = cnt[j];
                    cnt[j] = cnt[j+1];
                    cnt[j+1] = temp;
                    for(int k = 0; k < n; k++)
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j+1];
                        matrix[k, j+1] = temp;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1), count = 0;
        if (n == 0 || m == 0 || matrix == null || n < 2) return null;
        for (int i = 0; i < n; i++)
        {
            bool zero = true;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0)
                {
                    zero = false;
                    break; 
                }
            if (zero == true)
                count++;
        }
        int[,] matrix1 = new int[count, m];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            bool zero = true;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0)
                {
                    zero = false;
                    break; 
                }

            if (zero == true)
            {
                for (int j = 0; j < m; j++)
                    matrix1[index, j] = matrix[i, j];
                index++;
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion

   public void PrintMatr(int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++) Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }            
    }
    public void PrintArr(int[] A)
    {
        for (int i = 0; i < A.GetLength(0); i++) Console.Write(A[i] + " ");
    }
}