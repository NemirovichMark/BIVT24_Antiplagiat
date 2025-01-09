using System;
using System.Collections;
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
        int n = A.GetLength(0),m = A.GetLength(1);
        if (n == m)
        {
            for (int i = 0; i < n; i++)
            {
                answer += A[i, i];
            }
        }
        else
            return 0;
        
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
        int n = A.GetLength(0),m = A.GetLength(1),min = int.MaxValue,index = -1;
        answer = new int[n];
        if (n != 4 || m != 7)
            return default(int[]);
        else
        {
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        index = j;
                    }
                }
                answer[k++] = index;
                
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) 
            return null;
        for (int i = 0; i < n; i++)
        {
            int max=int.MinValue, index = -1; 
            for (int j = 0; j < m; j++)
                if (A[i, j] > max) 
                { 
                    max = A[i, j];
                    index = j; 
                }
            int a = A[i, index]; 
            A[i, index] = A[i, 0]; 
            A[i, 0] = a;

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
        int n = A.GetLength(0), m = A.GetLength(1), max = int.MinValue, ini = -1, inj = -1;
        if (n!= 6 || m != 7) 
            return null;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            { 
                if (A[i, j] > max) 
                { 
                    max = A[i, j]; 
                    ini = i; 
                    inj = j;
                } 
            }

        int[,] B = new int[n - 1, m - 1];
        for (int i = 0, a = 0; i < n; i++)
        {
            for (int j = 0, b = 0; j < m; j++)
                if (j != inj) 
                { 
                    B[a, b++] = A[i, j]; 
                }
            if (i != ini) 
                a++;
        }

        A = new int[n - 1, m - 1];
        A = B;

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
        if (n != 5 || m != 7) 
            return null;
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue, index = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max) 
                { 
                    max = A[i, j]; 
                    index = j; 
                }
            }
                
            A[i, index] *= (i + 1);
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
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = int.MinValue, imax = 0, ilast = 0, ifirst = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0)
                {
                    ilast = j;
                    if (ifirst == -1) 
                        ifirst = j;
                }
            }
            for (int j = 0; j < ifirst; j++)
                if (D[i, j] > max) 
                { 
                    max = D[i, j]; 
                    imax = j; 
                }

            if (ifirst != 0 && ilast != 0 && max != int.MinValue)
            {
                D[i, imax] = D[i, ilast];
                D[i, ilast] = max;
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
        int n = H.GetLength(0), m = H.GetLength(1);
        if (n!= 5 || m != 7) 
            return null;
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue, imax = -1;
            for (int j = 0; j < m; j++)
            {
                if (H[i, j] > max) 
                { 
                    max = H[i, j]; 
                    imax = j; 
                }
                
            }
            H[i, m - 1] = H[i, m - 2];
            H[i, m - 2] = max;
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
        int n = Y.GetLength(0), m = Y.GetLength(1);

        if (n != 6 || m != 5)
            return null;

        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue, sr = 0, count = 0;
            int jmax = 0;
            for (int j = 0; j < m; j++)
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    jmax = j;
                }
            for (int j = jmax + 1; j < m; j++)
            {
                if (Y[i, j] >= 0)
                {
                    count++;
                    sr += Y[i, j];
                }
            }
            if (sr > 0)
                sr /= count;
            else
                sr = 0;
            for (int j = 0; j < jmax; j++)
            {
                if (Y[i, j] < 0)
                    Y[i, j] = sr;
                
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
        int n = B.GetLength(0), m = B.GetLength(1);
        int[] array = new int[n];

        if ( n != 5 || m != 7)
            return null;
   

        for (int i = 0; i < n; i++)
        {
            int max=int.MinValue;
            for (int j = 0; j<m; j++)
            {
                if (B[i, j] > max)
                    max= B[i, j];
                
            }
            array[i] = max;
        }
        for (int i = 0; i < n; i++)
        {
            B[i, 3] = array[n- i - 1];
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

        int n = B.GetLength(0), m= B.GetLength(1),max = int.MinValue, imax = 0, ifirst = 0, temp = 0;

        if (n != 5 || m != 5)
            return null;

        for (int i = 0; i < n; i++)   
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                imax = i;
            }
        }
        for (int i = 0; i < n; i++)      
        {                                    
            if (B[i, 2] < 0)
            {
                ifirst = i;
                break;
            }
        }
        for (int j = 0; j < n; j++)      
        {
            temp = B[imax, j];
            B[imax, j] = B[ifirst, j];
            B[ifirst, j] = temp;
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
        int n = A.GetLength(0), m = A.GetLength(1), count = 0,k=0;

        if (n != 5 || m != 7)
            return null;
        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0)
                    count++;
            }
        }
        answer = new int[count];
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0)
                    answer[k++] = A[i, j];
                
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
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 5 || m != 7)
            return null;
        


        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue;
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }

            if (jmax == 0 || A[i, jmax - 1] > A[i, jmax + 1])
            {
                if (A[i, jmax + 1] > 0)
                    A[i, jmax + 1] *= 2;
                else if (A[i, jmax + 1] < 0)
                    A[i, jmax + 1] /= 2;
            }
            else if (jmax == m - 1 || A[i, jmax - 1] < A[i, jmax + 1])
            {
                if (A[i, jmax - 1] > 0)
                    A[i, jmax - 1] *= 2;
                else if (A[i, jmax - 1] < 0)
                    A[i, jmax - 1] /= 2;
            }
        }


        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 7 || m != 5)
            return null;


        for (int j = 0; j < m; j++)
        {
            int countpos = 0, countneg = 0;
            int max =int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
                if (A[i, j] >= 0) 
                    countpos += 1;
                else 
                    countneg += 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (countpos > countneg)
                    A[imax, j] = 0;
                else
                    A[imax, j] = imax + 1;
            }
        }


        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 10 || m != 5)
            return null;
        


        for (int j = 0; j < m; j++)
        {
            int max = int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (imax < (n / 2))
            {
                int sum = 0;
                for (int i = imax + 1; i < n; i++)
                    sum += A[i, j];
                
                A[0, j] = sum;
            }

        }


        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        int n = A.GetLength(0), m = A.GetLength(1), nl = B.Length;

        if (n != 7 || m!= 5 || nl != 5)
            return null;


        for (int j = 0; j < m; j++)
        {
            int max = int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (max < B[j])
            {
                A[imax, j] = B[j];
            }
        }



        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 7 || m != 5)
            return null;
    

        for (int j = 0; j < m; j++)
        {
            double max = double.MinValue;
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            double p = (A[0, j] + A[n - 1, j]) / 2;
            if (p > max) 
                A[imax, j] = p; 
            else 
                A[imax, j] = imax + 1; 
        }



        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) 
            return answer;

        answer = new int[n, 3 * n];

        int[,] A = new int[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i == j) 
                    A[i, j] = 1;

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (count == 3) 
                    count = 0;

                answer[i, j] = A[i, count];
                count++;
            }
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1), max = int.MinValue, imax = -1;
        if (n != 6 || m != 6) 
            return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j)
                { 
                    if (A[i, j] > max) 
                    { 
                        max = A[i, j]; 
                        imax = i; 
                    }
                }
            }
        }

        for (int i = 0; i < imax; i++)
            for (int j = i + 1; j < m; j++)
                A[i, j] = 0;
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1), max1 = int.MinValue, imax1 = -1, max2 = int.MinValue, imax2 = -1;

        if (n != 6 || m != 6) 
            return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > max1)
                    { 
                        max1 = B[i, j]; 
                        imax1 = j; 
                    }
                }

                if (i % 2 != 0)
                { 
                    if (B[i, j] > max2) 
                    { 
                        max2 = B[i, j]; 
                        imax2 = j; 
                    } 
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, imax1] = max2;
                B[i, imax2] = max1;
                max1 = max2 = int.MinValue;
                imax1 = imax2 = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1),temp;

        if (n != 6 || m != 7) 
            return null;

        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < m / 2; j++)
            {
                temp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);

        if (n != 7 && m != 5) 
            return null;

 
        int[,] newmatrix = new int[n, 2];

        const int min = int.MaxValue;

        
        for (int i = 0; i < n; i++)
        {
            newmatrix[i, 0] = i;
            newmatrix[i, 1] = min;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < newmatrix[i, 1])
                    newmatrix[i, 1] = matrix[i, j];
            }
        }

        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0 || newmatrix[i, 1] <= newmatrix[i - 1, 1]) 
            { 
                i = j; 
                j++; 
            }
            else
            {
                int temp = newmatrix[i, 1],
                itemp = newmatrix[i, 0],
                inext = newmatrix[i - 1, 0];

                for (int k = 0; k < m; k++)
                {
                    int temp1 = matrix[i, k];
                    matrix[i, k] = matrix[i - 1, k];
                    matrix[i - 1, k] = temp1;
                }

                newmatrix[i, 1] = newmatrix[i - 1, 1];
                newmatrix[i, 0] = newmatrix[i - 1, 0];

                newmatrix[i - 1, 1] = temp;
                newmatrix[i - 1, 0] = itemp;
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
        if (n != m || n < 3) 
            return answer;

        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
            }
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
        if (n != m || k < 1) 
            return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]])) 
                { 
                    max[0] = i; 
                    max[1] = j;
                } 
            }
        }

        if (max[1] != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
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
        int l1 = A.Length, l2 = B.Length, index = 0; 
        if (l1 < 2 || l2 < 2) return answer;

        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix2[i, j] = B[index];
                matrix1[j, i] = A[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }

        int[] matrix3 = new int[n * n];

        int index3 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    matrix3[index3] += matrix1[i, k] * matrix2[k, j];
                index3++;
            }
        }
        answer = matrix3;
      
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
            return default;
        bool an;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            an = false;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int ci= 0, cj = 0;
                for (int z = 0; z < matrix.GetLength(0); z++)
                {
                    if (matrix[z, j] < 0)
                        ci++;
                    if (matrix[z, j + 1] < 0)
                        cj++;
                }
                if (ci > cj)
                {
                    for (int z = 0; z < matrix.GetLength(0); z++)
                    {
                        int temp = matrix[z, j];
                        matrix[z, j] = matrix[z, j + 1];
                        matrix[z, j + 1] = temp;
                    }
                    an = true;
                }
            }
            if (an == false)
                break;
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
        int n= matrix.GetLength(0), m = matrix.GetLength(1);
        int mn= 0;

        if (matrix == null)
            return null;
        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    mn++;
                    break;
                }
            }
        }
        int[,] array = new int[n - mn, m];
        for (int i = 0, z = 0; i < n; i++)
        {
            int an = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    an++;
                    break;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (an == 0)
                    array[z, j] = matrix[i, j];
            }
            if (an == 0)
                z++;
        }

        matrix = array;


        // end

        return matrix;
    }
    #endregion
}