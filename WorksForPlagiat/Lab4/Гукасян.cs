using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7) { return 0; }
        for (int i = 0; i < 35; i++) {
            answer += A[i / 7, i % 7];
        }
        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        
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
        int irow = 0;
        int icol = 0;
        double amin = 100000;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 3 || cols != 6) { return (0,0); }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i,j] < amin)
                {
                    amin = A[i,j];
                    irow = i;
                    icol= j;
                }
            }
        }

        return (irow, icol);
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

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if ((rows != 3) || (cols != 5)) { return default; }
        int[] answer = new int[cols];
        int k = 0;
        for (int j = 0; j < cols; j++)
        {
            int max = A[0, j];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max =A[i,j];
                    index = i;
                }
            }
            answer[k] = A[index, j];
            k++;
        }
        
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int p;
        int amax = 0;
        int imax = 0;
        if (rows != 5 || cols != 7) { return default; }
        for (int i = 0; i < rows; i++)
        {
            if (A[i, 2] > amax)
            { 
                amax= A[i, 2];
                imax = i;
            }
        }
        for (int k = 0; k < cols ; k++)
        {
            p = A[imax, k];
            A[imax, k] = A[3,k];
            A[3, k] = p;
        }
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int p;
        int amax = 0;
        int jmax = 0;
        if (rows != 5 || cols != 5) { return default; }
        for (int i=0;i<rows; i++)
        {
            for (int j=0; j<cols; j++)
            {
                if ((A[i, j] > amax) && (i == j))
                {
                    amax = A[i, j];
                    jmax = j;
                }
            }

        }
        
        for (int k = 0; k < rows; k++)
        {
            p = A[k, jmax];
            A[k, jmax] = A[k, 3];
            A[k, 3] = p;
        }

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
        if ((A.GetLength(0)!=n) || (A.GetLength(1) != m)) { return default; }
        
        int rows = n;
        int cols = m;
        int[,] B = new int[rows,cols];
        for (int i = 0; i < rows; i++)
        {
            int amax = -100;
            int jmax = 0;
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    jmax = j;
                }
                
            }
            for (int k = 0; k < jmax; k++)
            {
                B[i,k]= A[i, k];
            }
            for (int l = jmax; l < cols-1; l++)
            {
                B[i,l]= A[i,l+1];
            }
            B[i, cols - 1] = amax;
           
        }

        A = B;
        
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
        if ((C.GetLength(0) != n) || (C.GetLength(1) != m)) { return null; }
        int rows = n;
        int cols = m;
        double cmax = 0;
        int imax = 0;
        int jmax = 0;
        for (int i = 0; i < rows; i++)
        {
            cmax = 0;
            imax = 0;
            jmax = 0;
            for (int j=0; j < cols; j++)
            {
                if (C[i, j] > cmax)
                {
                    cmax= C[i, j];
                    imax = i;
                    jmax = j;
                    
                }
                
            }
            for (int l = 0; l < cols; l++)
            {
                if ((C[i, l] < 0) && (l < jmax))
                {
                    C[i, l] = C[i, l] / cmax;
                }
            }

        }
        

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
        

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        int rows = Z.GetLength(0);
        int cols = Z.GetLength(1);
        double p = 0;
        double sr = 0;
        double amax = 0;
        int jmax = 0;
        int imax = 0;
        int k = 0;
        if (rows != 6 || cols != 8) { return default; }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                if (Z[i, j] > 0)
                {
                    p += Z[i, j];
                    k++;
                }
            }
        }
        sr = p / k;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if(Z[i, j] >amax)
                {
                    amax = Z[i, j];
                    imax = i;
                    jmax = j;
                }
            }

        }
        Z[imax, jmax] = sr;
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
        int rows = X.GetLength(0);
        int cols = X.GetLength(1);
        int p;
        int kmax = 0;
        int kmin = 1000;
        int imax = 0;
        int imin = 0;
        if (rows != 6 || cols != 5) { return default; }
        for (int i = 0; i < rows; i++)
        {
            int k = 0;
            for (int j = 0; j < cols; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k > kmax)
            {
                kmax = k;
                imax = i;
            }
            if (k < kmin)
            {
                kmin = k;
                imin = i;
            }
        }
        for (int j = 0; j < cols; j++)
        {
            p = X[imax, j];
            X[imax, j] = X[imin, j];
            X[imin, j] = p;
        }

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
        
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        int[,] B = new int[rows - 1, cols];
        int imax = 0;
        int smax = 0;
        for (int i = 0; i < rows; i++)
        {
            int s = 0;
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > 0)
                {
                    s+=A[i,j];
                    
                }
                
            }
            if (s > smax)
            {
                smax = s;
                imax = i;

            }
        }
        for (int i = 0; i < rows - 1; i++)
        {
            if (i < imax)
            {
                for (int j = 0;j < cols; j++)
                {
                    B[i,j]= A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = A[i+1, j];
                }
            }
            
        }
        A = B;


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
        
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int amin = 100000;
        int jmax = 0;
        if (rows != 5 || cols != 8) { return default; }
        if (B.Length != 5) { return default; }
        for (int j = 0; j < cols; j++)
        {
            if (A[4, j] < amin)
            {
                amin= A[4, j];
                jmax= j;
            }
        }
       
        for (int j = 0; j < cols; j++)
        {
            if (j > jmax)
            {
                for (int i = 0; i < rows; i++)
                {
                    A[i, j] = B[i];
                }
            }
            
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{A[i, j],3} ");
            }
            Console.WriteLine();
        }

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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7) { return default; }
        for (int i = 0; i < rows; i++)
        {
            double maxel = -1000000;
            int colmax = 0;
            for (int j=0;j<cols; j++)
            {
                if (A[i,j] > maxel)
                {
                    if (A[i, j] <= maxel) { continue; }
                    maxel= A[i,j];
                    colmax = j;
                }
            }
            if (colmax == 0)
            {
                if (A[i, 1] > 0)
                {
                    A[i, 1] *= 2.0;

                }
                else
                {
                    A[i, 1] /= 2.0;

                }
            }
            else if (colmax == cols)
            {
                if (A[i, cols - 1] > 0)
                {
                    A[i, cols - 1] *= 2.0;

                }
                else
                {
                    A[i, cols - 1] /= 2.0;
                }
            }
            else
            {
                if (A[i, colmax - 1] > A[i,colmax+1])
                {
                    if (A[i, colmax + 1] > 0)
                    {
                        A[i, colmax + 1] *= 2.0;
                    }
                    else
                    {
                        A[i, colmax + 1] /= 2.0;
                    }
                }
                else if (A[i, colmax - 1] < A[i, colmax + 1])
                {
                    if (A[i, colmax - 1] > 0)
                    {
                        A[i, colmax - 1] *= 2.0;
                    }
                    else
                    {
                        A[i, colmax - 1] /= 2.0;
                    }
                }
            }
        }
        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        for (int j = 0; j < cols; j++)
        {
            int kpol = 0;
            int kotr = 0;
            int amax = A[0,j];
            int imax = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > 0)
                {
                    kpol++;

                }
                else if (A[i,j]<0)
                {
                    kotr++;
                }
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
            }
            if (kpol > kotr)
            {
                A[imax,j] = 0;
            }
            else
            {
                A[imax, j] = imax+1;
            }
            
        }
        
        return A;

    }
    public int[,] Task_2_3(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 10 || cols != 5) { return default; }
        for (int j = 0; j < cols; j++)
        {
            int imax = 0;
            int amax = A[0, j];
            for (int i=0; i<rows; i++)
            {
                
                if (A[i, j] > amax)
                {
                    amax= A[i, j];
                    imax= i;
                }
 
            }
            if (imax < rows/2)
            {
                int s = 0;
                for (int k = imax+1; k < rows; k++)
                {
                    s += A[k, j];
                }
                A[0, j] = s;
            }
            
        }
       
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        if (B.Length != 5) { return default; }
        for (int j = 0; j < cols; j++)
        {
            int amax = A[0, j];
            int imax = 0;
            for (int i=0;i < rows; i++)
            {
                if (A[i, j] > amax)
                {
                    amax=A[i, j];
                    imax = i;
                }
            }
            if (B[j] > amax)
            {
                A[imax,j] = B[j];
            }
        }
        
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        for (int j=0;j< cols; j++)
        {
            double amax = A[0,j];
            int imax = 0;
            double s = 0;
            for (int i=0;i < rows; i++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    imax = i;
                }
                
            }
            s = (A[0, j] + A[rows - 1, j]) / 2;
            if (amax < s)
            {
                A[imax,j] = s;
            }
            else
            {
                A[imax, j] = imax+1;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{A[i, j],3} ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        if (n<=0) { return answer; }
        answer = new int[n,3*n];
        int rows = answer.GetLength(0);
        int cols = answer.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                answer[i, j] = 0;
            }
        }
        int k = -1;
        for (int i = 0; i < rows; i++)
        {
            k++;
            for (int j = k;j<cols; j += 3)
            {
                answer[i,j] = 1;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 6 || cols != 6) { return default; }
        int imax = 0;
        for (int i=0;i< rows; i++)
        {
            if (A[imax, imax] < A[i, i])
            {
                imax = i;
            }
        }
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                if ((i < j) && (i < imax))
                {
                    A[i, j] = 0;
                }
            }
        }
        
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);
        if (rows != 6 || cols != 6) { return default; }
        for (int i = 0; i < rows; i+=2)
        {
            int amax1 = B[i, 0];
            int amax2= B[i+1, 0];
            int imax1 = 0;
            int imax2 = 0;
            for (int j=0;j<cols; j++)
            {
                if (B[i, j] > amax1)
                {
                    amax1 = B[i, j];
                    imax1 = j;
                }
                if (B[i+1, j] > amax2)
                {
                    amax2 = B[i+1, j];
                    imax2 = j;
                }
            }
            int temp = B[i, imax1];
            B[i, imax1] = B[i+1, imax2];
            B[i+1, imax2] = temp;

        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 6 || cols != 7) { return default; }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols/2; j++)
            {
                int temp = A[i,j];
                A[i, j] = A[i, cols - j - 1];
                A[i, cols - j - 1] = temp;
            }
        }
        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        
        for (int i = 0; i < rows; i++)
        {
            if ((i == 0) || (i == rows - 1))
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            matrix[i, 0] = 0;
            matrix[i, cols - 1] = 0;
        }
        
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        for (int i = rows / 2; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
            }
        }
            
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        int kup = 0;
        int klow = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j=0;j < i; j++)
            {
                klow++;
            }
            
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j++)
            {
                kup++;
            }

        }
        lower = new int[klow];
        upper = new int[kup];
        int t = 0;
        int y = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[t++]=matrix[i,j];
            }

        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j++)
            {
                upper[y++]=matrix[i,j];
            }

        }
        
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if ((rows != 7) || (cols != 5)) { return default; }
        for (int i = 0; i < rows; i++)
        {
            
            for(int j = 0;j < cols-i-1; j++)
            {
                int kk = 0;
                int nn = 0;
                for (int l = 0; l < cols; l++)
                {
                    if (matrix[j, l] > 0)
                    {
                        kk++;
                    }
                    if (matrix[j + 1, l] > 0)
                    {
                        nn++;
                    }
                }
                if (kk < nn)
                {
                   for (int m=0;m< cols; m++)
                   {
                        int temp = matrix[j, m];
                        matrix[j, m] = matrix[j + 1, m];
                        matrix[j + 1, m] = temp;
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if ((rows != 5) || (cols != 7)) { return default; }
        for (int i = 0; i < rows; i++)
        {
            for (int j=0; j < cols-1; j++)
            {
                for (int l=0; l < cols-j-1; l++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, l] <  matrix[i, l + 1])
                        {
                            int temp = matrix[i, l];
                            matrix[i, l] = matrix[i, l + 1];
                            matrix[i, l + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i,l] > matrix[i, l + 1])
                        {
                            int temp = matrix[i, l];
                            matrix[i, l] = matrix[i, l + 1];
                            matrix[i, l+1]= temp;
                        }
                    }
                }
            }
        }
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int kudal = 0;
        for (int i = 0; i < rows; i++)
        {
            
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i,j] == 0)
                {
                    kudal++;
                    break;
                }
            }
        }
        int[,] A = new int[rows - kudal, cols];
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            
            for (int j=0;j<cols; j++)
            {
                if (matrix[i, j] == 0) { break; }
                A[count,j]= matrix[i,j];
            }
            count++;
            if (count >= rows - kudal) { break; }
        }

        return A;
    }
    #endregion
}