using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };
        program.Task_3_11(matrix);
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for ( int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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
        double min = 100000000;
        for ( int i = 0;i< A.GetLength(0); i++)
        {
            for ( int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
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
        int[] answer = default(int[]);
        // code here
        int k = 0;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return default;
        answer= new int[A.GetLength(1)];
        for ( int j = 0; j< A.GetLength(1); j++)
        {
            int max = -1000000;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if ((A[i, j] > max))
                {
                    max = A[i, j];
                }
            }
            answer[k] = max;
            k++;
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
        int n=A.GetLength(0), m=A.GetLength(1);
        if (n != 5 || m != 7) return default;
        int max = -100000, ii=0, p=0;
        for (int j = 1;j<m;j++ )
        {
            for ( int i = 0; i<n;i++)
            {
                if (A[i, 2] > max)
                {
                    max = A[i, 2];
                    ii = i;
                }   
            }
        }
        for (int j = 0; j < m; j++)
        {
            p = A[3, j];
            A[3, j] = A[ii, j];
            A[ii,j] = p;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 5) return default;
        int max = -1000000, ii = 0, p = 0;
        for (int i = 1; i < n; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                ii = i;
            }
        }
        for (int j = 0; j< m; j++)
        {
            p = A[j, 3];
            A[j, 3] = A[j, ii];
            A[j, ii] = p;
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
        int max = int.MinValue, ii = 0, jj = 0;
        int p = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return default;
        for ( int i = 0; i< n; i++)
        {
            max = int.MinValue;
            for ( int j =0; j<m; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    jj = j;
                }
            }
            if (jj != m - 1)
            {
                p = A[i, jj];
                for ( int j = jj; j<m-1; j++)
                {
                    A[i, j] = A[i,j+1];
                }
                A[i, m-1] = p;
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
        if (C.GetLength(0) != n || C.GetLength(1) != m) return default;
        for( int i = 0; i < n; i++)
        {
            double max = C[i,0], jj=0;
            for ( int j = 0; j < m; j++) 
            {
                if (C[i,j]> max)
                {
                    max=C[i,j];
                    jj = j;
                }
            }
            if (max != 0)
            {
                for (int j = 0; j < jj; j++)
                {
                    if (C[i, j] < 0 )
                    {
                        C[i, j] /= max;
                    }
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
        double max = 0, s = 0, k = 0; 
        int jj = 0,ii=0 ;
        int n = Z.GetLength(0), m = Z.GetLength(1);
        if (Z.GetLength(0)!=6 || Z.GetLength(1) != 8) return default;
        for ( int i = 0; i< n; i++)
        {
            for ( int j = 0;j< m; j++)
            {
                if ((Z[i, j] > max))
                {
                    max = Z[i, j];
                    jj = j;
                    ii = i;
                }
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
            }
        }
        Z[ii, jj] = s / k;
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
        int n=X.GetLength(0), m=X.GetLength(1);
        if (n != 6 || m != 5) return default;
        int maxn = 0, minn =m,maxi=0,maxj=0,mini=0, minj=0,p=0;
        for (int i = 0; i < n; i++)
        {
            int max = 0, min = 0;
            for (int j = 0; j < m; j++)
            {
                if ((X[i, j]<0))
                {
                    max++;
                    min++;

                }
            }
            if (max > maxn)
            {
                maxn = max;
                mini = i;
            }
            if (min < minn)
            {
                minn = min;
                maxi = i;
            }
        }
        for (int j=0; j < m; j++)
        {
            p = X[mini,j];
            X[mini,j] = X[maxi,j];
            X[maxi, j] = p;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;

        int maxsum = -1, maxsumi = -1;

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > maxsum)
            {
                maxsum = sum;
                maxsumi = i;
            }
        }

        if (maxsumi == -1) return default; 
        int[,] newA = new int[n - 1, m];
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == maxsumi)
            {
                k++;
                continue;
            }
            for (int j = 0; j < m; j++)
            {
                newA[i - k, j] = A[i, j];
            }
        }
        A = newA;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 8 || B.Length != 5) return default;
        int mini = A[4, 0], minj = 0;
        for (int j = 1; j < m; j++) 
        {
            if (A[4, j] < mini) 
            {
                mini = A[4, j];
                minj = j;
            }
        }
        for (int j = m - 1; j > minj + 1; j--)
        {
            for (int i = 0; i < n; i++)
            {
                A[i, j] = A[i, j - 1]; 
            }
        }
        for (int i = 0; i < n; i++)
        {
            A[i, minj + 1] = B[i]; 
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
        int n= A.GetLength(0), m=A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            double max = A[i,0];
            int maxi = 0;
            for (int j=1; j < m; j++)
            {
                if (A[i, j] > max)
                {
                     max= A[i, j];
                     maxi = j;

                }
            }
            if (maxi == 0)
            {
                A[i, 1] *= 2;
            }
            if (maxi == m - 1)
            {
                A[i, m - 2] *= 2;
            }
            if (maxi!=0 && maxi!=m-1)
            {
                if (A[i, maxi - 1] > A[i, maxi + 1])
                {
                    if (A[i, maxi + 1] > 0)
                        A[i, maxi + 1] *= 2;
                    else
                        A[i, maxi + 1] /= 2;
                }
                else
                {
                    if (A[i, maxi - 1] > 0)
                        A[i, maxi - 1] *= 2;
                    else
                        A[i, maxi - 1] /= 2;

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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int max = 0, min = 0, maxe = A[0, j], maxi = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > 0)
                {
                    max++;
                }
                else if (A[i, j] < 0)
                {
                    min++;
                }
                if (A[i, j] > maxe)
                {
                    maxe = A[i, j];
                    maxi = i;
                }
            }
            if (max > min)
            {
                A[maxi, j] = 0; 
            }
            else
            {
                A[maxi, j] = maxi+1; 
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int sum = 0, max = A[0,j], ii=0 ;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ii = i;
                }
            }
            if (ii < n / 2)
            {
                for ( int i = ii + 1; i < n; i++)
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
        int n=A.GetLength(0), m=A.GetLength(1);
        if (n != 7 || m != 5 || B.Length!=5) return default;
        for (int j = 0;j<m; j++)
        {
            int max = A[0, j], ii = 0;
            for (int i = 0;i < n; i++)
            {
                if (A[i,j] > max)
                {
                    max= A[i,j];
                    ii = i;
                }
            }
            if (A[ii,j] < B[j])
            {
                A[ii,j]=B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n=A.GetLength(0), m =A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for ( int j = 0; j < m; j++)
        {
            double max = A[0, j], sum = 0;
            int ii = 0;
            for ( int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max=A[i,j];
                    ii = i;
                }
            }
            sum = (A[0, j] + A[n - 1, j]) / 2;
            if (sum> A[ii, j])
            {
                A[ii, j] = sum;
            }
            else
            {
                A[ii, j] = ii + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        int m = n * 3;
        if (n != 3 || m != 9) return default;
        answer =  new int [n, 3 * n];
        for ( int i=0; i<n; i++)
        {
            for ( int j=0; j<n; j++)
            {
                if (i== j)
                    answer [i,j] = 1;
                if (i == j)
                    answer[i, j+n] = 1;

                if (i == j)
                    answer[i, j+2*n] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n=A.GetLength(0), m=A.GetLength(1);
        if (n != 6 || m != 6) return default;
        int max = -100000, ii=0,jj=0;
        for ( int i =0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                   
                    ii = i;
                }
            }
        }
        for ( int i = 0; i< ii; i++)
        {
            for ( int j = i+1;j<m; j++)
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
        int n=B.GetLength(0), m=B.GetLength(1);
        if (n != 6 || m != 6) return default;
        for (int i = 0; i<n; i+=2)
        {
            int max1=-10000000,max2=-10000000, j1=0,j2=0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    j1 = j;
                }
                if (B[i+1, j] > max2)
                {
                    max2 = B[i+1, j];
                    j2 = j;
                }
            }
            int p = B[i, j1];
            B[i, j1] = B[i+1, j2];
            B[i+1, j2] = p;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n= A.GetLength(0), m=A.GetLength(1);
        if (n != 6 || m != 7) return default;
        int p = 0;
        for ( int i=0; i<n; i++)
        {
            for ( int j=0; j<m/2; j++)
            {
                p = A[i, j];
                A[i, j] = A[i, m-j-1];
                A[i, m- j-1] = p;
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
        if (n != 7 || m != 5) return default;
        int[]a=new int[n];
        for (int i = 0; i < n; i++)
        {
            int ind = 0, min=1000000000;
            for (int j = 1; j < m; j++)
                if (matrix[i, j] < min)
                {
                    min= matrix[i, j];
                    ind = j;
                } 
            a[i] = matrix[i, ind];
        }
        for (int x = 1; x < n; x++)
        {
            int i = x;
            while (i > 0 && a[i - 1] < a[i])
            {
                int p = a[i - 1];
                a[i - 1] = a[i];
                a[i] = p;
                for (int j = 0; j < m; j++)
                {
                    p = matrix[i - 1, j];
                    matrix[i - 1, j] = matrix[i, j];
                    matrix[i, j] = p;
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
        int n=matrix.GetLength(0);
        answer = new int[2 * n - 1];
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        for (int i= 0; i <n; i++)
        {
            for ( int j=0; j<n; j++)
            {
                int ind = j - i + (n - 1);
                answer[ind] += matrix[i, j];
            }  
        }
        Console.WriteLine("");
        foreach (var sum in answer)
        {
            Console.WriteLine(sum);
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
        int n = matrix.GetLength(0), m=matrix.GetLength(1);
        if (n != m || k<1|| k>n) return default;
        int  ind_i = 0, ind_j = 0, max = -1000000000;
        for ( int i=0; i < n; i++)
        {
            for (int j=0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max=Math.Abs(matrix[i, j]);
                    ind_j = j;
                    ind_i = i;
                }
            }
        }
        if (ind_i == k-1 && ind_j == k-1)
            return matrix;
        if (ind_j != k-1)
        {
            for (int j = 0; j < n; j++)
            {
                int p = matrix[k-1, j];
                matrix[k-1, j] = matrix[ind_i, j];
                matrix[ind_i, j] = p;
            }
        }
        if (ind_i != k-1)
        {
            for (int i = 0; i < n; i++)
            {
                int p = matrix[i, k-1];
                matrix[i, k-1] = matrix[i, ind_j];
                matrix[i, ind_j] = p;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
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
        int h=A.Length, m=B.Length;
        if (h <= 0 || m <= 0 || h != m) return default;
        int[,] a = new int[n, n];
        int[,] b= new int[n, n];
        int k = 0;
        int[] x = new int[n * n];
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = i; j < n; j = j + 1)
            {
                a[i, j] = A[k];
                a[j, i] = A[k];
                b[i, j] = B[k];
                b[j, i] = B[k];
                k = k + 1;
            }
        }
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = 0; j < n; j = j + 1)
            {
                for (int p = 0; p < n; p = p + 1)
                {
                    x[i * n + j] = x[i * n + j] + a[i, p] * b[p, j];
                }
            }
        }
        answer = x;
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
        int n= matrix.GetLength(0), m= matrix.GetLength(1);
        if (n != 5 || m != 7) return default;
        int[] a = new int[m];
        for ( int j=0; j<m; j++)
        {
            int k = 0;
            for (int i=0; i<n; i++)
            {
                if (matrix[i, j] < 0)
                    k++;
            }
            a[j]= k;
        }
        for (int x = 1; x < m; x++)
        {
            int j = x;
            while (j > 0 && a[j - 1] > a[j])
            {
                int p = a[j - 1];
                a[j - 1] = a[j];
                a[j] = p;
                for (int line = 0; line < n; line++)
                {
                    p = matrix[line, j - 1];
                    matrix[line, j - 1] = matrix[line, j];
                    matrix[line, j] = p;
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
        int n=matrix.GetLength(0), m=matrix.GetLength(1);
        if (n <= 0 || m <= 0) return default;
        n = n - 1;
        int k = 0;
        for (int i=0; i<n;i++)
        {
            for (int j=0; j<m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k ++;
                    break;
                }
            }
        }
        int[,] a = new int[n - k, m];
        int c = 0;
        for (int i = 0; i <n-1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) break;
                a[c, j] = matrix[i, j];
            }
            c++;
            if (c >= matrix.GetLength(0) - k)
            {
                break;
            }
        
        }
        matrix = a;


        // end

        return matrix;
    }
    #endregion
}