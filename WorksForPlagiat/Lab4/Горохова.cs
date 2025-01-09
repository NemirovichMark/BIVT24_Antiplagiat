using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return 0;
        }
        double s = 0;
        double count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
        }
        if (count > 0)
        {
            answer = s / count;
        }
        else
        {
            return 0;
        }
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
        int n = A.GetLength(0); //строка
        int m = A.GetLength(1); //номер
            for (int i = 0; i < n; i++)
            {
                if (A[i,colIndex] <= 0 )
                {
                    value = A[i,colIndex];
                    rowIndex = i;
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
        double[] answer = new double[A.GetLength(0)];
        // code here
        
        int n = A.GetLength (0);
        int m = A.GetLength(1);
        if (n != 4 || m != 6)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int s = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j] > 0)
                {
                    s += A[i,j];
                    count++;
                }
            }
            if (count > 0)
            {
                answer[i] =(double) s / count;
            }
            else
            {
                answer[i] = 0;
            }
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        int min = 10000;
        int k = 0;
        int[,] B = new int[4, 7];
        for (int i = 0; i < n; i++)
        {
                if (A[i, 0] < min)
                {
                    min = A[i, 0];
                    k = i;
                }
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < k; i++)
            {
                B[i, j] = A[i, j];
            }
            for (int i = k + 1; i < 5; i++)
            {
                B[i - 1, j] = A[i, j];
            }
        }
        A = B;
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
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = new int[A.GetLength(1)];
        // code here
        
        int n = A.GetLength(0); // строки
        int m = A.GetLength (1); // столбцы
        if (m != 3 || n != 4)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
            answer[j] = count;
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
        
        for(int i = 0; i < n; i++)
        {
            int jmin = 0;
            double amin = 10000;
            for (int j = 0;j < m; j++)
            {
                if (B[i, j] < amin)
                {
                    amin = B[i, j];
                    jmin = j;
                }
            }
            if (jmin != 0)
            {
                int temp = B[i, jmin];
                for (int j = jmin; j > 0; j--)
                {
                    B[i,j] = B[i, j-1];
                }
                B[i, 0] = temp;
            }
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
        
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            double amax = -1000;
            double first = 0, second = 0;
            double k  = 0;
            bool f = false;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > amax)
                {
                    amax = F[i, j];
                    jmax = j;
                }

                if (F[i, j] < 0)
                {
                    if (f == false)
                    {
                        first = F[i, j];
                        f = true;
                    }
                    second = F[i,j];
                    count++;
                }
            }
            if (count > 0)
            {
                k = (first + second) / 2;
                F[i, jmax] = k;
            }
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
        if ((G.GetLength(0) != 5) && (G.GetLength(1) != 7))
        {
            return null;
        }
        int n = G.GetLength(0);
        int m = G.GetLength(1);
        int[,] k = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int amax = -1000;
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (G[i, j] > amax)
                {
                    amax = G[i, j];
                    jmax = j;
                }
            }
            for(int j = 0; j < jmax;  j++)
            {
                k[i,j] = G[i, j];
            }
            k[i, jmax] = G[i, jmax];
            k[i, jmax + 1] = G[i, jmax];
            for (int j = jmax + 2; j < m; j++)
            {
                k[i, j] = G[i, j-1];
            }
        }
        G = k;
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
     
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if(n != 5 ||  m != 7 || B.Length != 7)
        {
            return null;
        }
        int amax = -1000, imax = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i,5] > amax)
            {
                amax = A[i,5];
                imax = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            A[imax,j] = B [j];
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
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        int[,] A = new int[5, 6];
        int n = F.GetLength(0);
        int m = F.GetLength(1);
        if (n != 5 || m != 7 )
        {
            return null;
        }
        int amin = 10000, jmin = 0;
        for (int j = 0; j < m; j++)
        {
            if (Math.Abs(F[1,j])  < amin)
            {
                amin = Math.Abs(F[1,j]);
                jmin = j;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j <= jmin; j++)
            {
                A[i, j] = F[i, j];
            }
            for (int j = jmin + 2; j < m; j++)
            {
                A[i, j-1] = F[i, j];
            }
        }
        F = A;

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
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        for ( int i = 0; i < n; i ++)
        {
            double amax = -1000;
            int jmax = 0;
            double s = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    jmax = j;
                }
                if (A[i,j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count > 0)
            {
                double k = s / count;
                A[i, jmax] = k;
            }
            else
            {
                A[i, jmax] = 0;
            }
            
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            double amax = -100;
            int jmax = -1;
            for (int j = 0; j < m ; j++)
            {
                if( A[i, j] > amax)
                {
                    amax = A[i, j];
                    jmax = j;
                }
            }
            if (jmax != 0 && jmax != m - 1)
            {
                if (A[i, jmax - 1] > A[i, jmax + 1])
                {
                    if (A[i, jmax + 1] > 0)
                    {
                        A[i, jmax + 1] *= 2;
                    }
                    else if (A[i, jmax + 1] < 0)
                    {
                        A[i, jmax + 1] /= 2;
                    }
                }
                else if (A[i, jmax - 1] < A[i, jmax + 1])
                {
                    if (A[i, jmax - 1] > 0)
                    {
                        A[i, jmax - 1] *= 2;
                    }
                    else if (A[i, jmax - 1] < 0)
                    {
                        A[i, jmax - 1] /= 2;
                    }
                }
                else if (jmax  == 0 || jmax == m-1)
                {
                    if (jmax == m - 1)
                    {
                        if (A[i, jmax - 1] > 0)
                        {
                            A[i, jmax - 1] *= 2;
                        }
                        else if (A[i, jmax - 1] < 0)
                        {
                            A[i, jmax - 1] /= 2;
                        }
                    }
                    else if (jmax ==0)
                    {
                        if (A[i, jmax + 1] > 0)
                        {
                            A[i, jmax + 1] *= 2;
                        }
                        else if (A[i, jmax + 1] < 0)
                        {
                            A[i, jmax + 1] /= 2;
                        }
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int pol = 0, otr = 0;
            int amax = -100000, imax = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > 0)
                {
                    pol++;
                }
                else if (A[i, j] < 0)
                {
                    otr++;
                }
                if(A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
                
            }
            if (pol > otr)
            {
                A[imax, j] = 0;
            }
            else 
            {
                A[imax, j] = imax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 10 || m != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int amax = -100000, imax = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }

            }
            int s = 0;
            for (int i = imax+1;  i < n; i++)
            {
                s += A[i, j];
            }
            if (imax >= 0 && imax <= 4)
            {
                A[0, j] = s;
            }
        }
                // end

                return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            int amax = -1000000, imax = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }

            }
            if (amax < B[j])
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return null;
        }
        for(int j = 0; j < m; j++)
        {
            double amax = -1000;
            int imax = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
                
            }
            double sum = (A[0, j] + A[n-1, j]) / 2;
            if (amax < sum)
            {
                A[imax, j] = sum;
            }
            else if (amax > sum)
            {
                A[imax, j] = imax+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {

        // code here
        if (n < 0)
        {
            return null;
        }
        int[,] answer = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
               
                if (i == j)
                    answer[i, j] = 1; 
                if (i == j)
                    answer[i, j + n] = 1; 
                if (i == j)
                    answer[i, j + 2 * n] = 1; 
            }
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int amax = -1000, imax = -1;
        if ( n != 6 || m != 6)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > amax)
            {
                amax = A[i, i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i +1; j < m; j++)
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
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        if (n != 6 || m != 6)
        {
            return null;
        }
        for (int i = 0; i < n; i += 2)
        {
            int max1 = -1000, max2 = -1000;
            int jmax1 = -1, jmax2 = -1;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    jmax1 = j;
                }
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    jmax2 = j;
                }
            }
            int temp = B[i, jmax1];
            B[i, jmax1] = B[i + 1, jmax2];
            B[i + 1, jmax2] = temp;


        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, m - 1 - j]; 
                A[i, m - 1 - j] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (matrix == null || n != 7 || m != 5)
        {
            return null;
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int imin = 100000, jmin = 100000;
                for (int k = 0; k < m; k++)
                {
                    if (matrix[i, k] < imin)
                    {
                        imin = matrix[i, k];
                    }
                    if (matrix[j, k] < jmin)
                    {
                        jmin = matrix[j, k];
                    }
                }
                if (imin < jmin)
                {
                    for (int k = 0; k < m; k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }
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
        int m = matrix.GetLength(1);
        
        if (n != m)
        {
            return answer;
        }
        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int ind = j - i + (n - 1);
                answer[ind] += matrix[i, j];
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m || k < 1 || k > n)
        {
            return null;
        }

        int amax = -100000, imax = 0, jmax = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (amax < Math.Abs(matrix[i, j]))
                {
                    amax = Math.Abs(matrix[i, j]);
                    imax = i;
                    jmax = j;
                }
            }
        }
        if (jmax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, jmax];
                matrix[i, jmax] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        if (imax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[imax, i];
                matrix[imax, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;
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
        answer = new int[n * n];
        int[,] mA = new int[n, n];
        int[,] mB = new int[n, n];
        int k = 0;
        int c = 0;
        if (n <= 0 || A.Length / 2 != n || B.Length / 2 != n)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                mA[i, j] = A[k];
                mB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mA[j, i] = mA[i, j];
                mB[j, i] = mB[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int s = 0;
                for (int q = 0; q < n; q++)
                {
                    s += (mA[i, q] * mB[q, j]);
                }
                answer[c++] = s;
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
        int[] array = new int[7];
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k = 0;
        int c = 0;

        if (n != 5 && m != 7)
        {
            return null;
        }

        for (int j = 0; j < 7; j++)
        {
            int g = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                {
                    g++;
                }
            }
             array[j] = g;
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (array[i] >  array[i + 1])
                {
                    c = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = c;

                    for (int q = 0; q < 5; q++)
                    {
                        c = matrix[q, i];
                        matrix[q, i] = matrix[q, i + 1];
                        matrix[q, i + 1] = c;
                    }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int z = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    z--;
                    matrix[i, 0] = 0;
                    break;
                }
            }
        }
        int[,] A = new int[z, m];
        int q = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, 0] != 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[q, j] = matrix[i, j];
                }
                q++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}