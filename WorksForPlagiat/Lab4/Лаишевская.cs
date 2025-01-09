using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        for (int i =0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
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
        int min = 1000000;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) return (0, 0);
        for(int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if ( A[i, j] < min)
                {
                    min=A[i, j];
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
        int max = 0;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return answer;
        answer = new int[A.GetLength(1)];
        for(int j = 0; j < A.GetLength(1); j++)
        {
            max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;
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
        
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        int rowmax = 0, max = A[0,2];
        for (int i=0; i< A.GetLength(0); i++)
        {
            if (A[i, 2] > max) 
            {
                max = A[i,2];
                rowmax = i;
            }
        }
        for(int j=0;j< A.GetLength(1); j++)
        {
            var p = A[rowmax, j];
            A[rowmax, j] = A[3, j];
            A[3, j] = p;
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
        if(A.GetLength(0)!=5 || A.GetLength(1)!= 5) return default;
        int max = A[0, 0], jmax = 0;
        for(int i =1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                jmax = i;
            }
        }
        for(int i = 0; i < A.GetLength(0); i++)
        {
            var p = A[i, jmax];
            A[i, jmax] = A[i, 3];
            A[i, 3] = p;
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
        if (A.GetLength(0) != n || A.GetLength(1) != m) return default;
        int[,] B = new int[n, m];
        for(int i = 0; i< n; i++)
        {
            int max = A[i, 0], jmax = 0;
            for(int j = 1; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            for(int j = 0; j < m; j++)
            {
                var p = A[i, jmax];
                if(j<jmax) B[i,j]= A[i, j];
                else if(j==m-1) B[i, j] = p;
                else
                {
                    B[i, j] = A[i, j + 1];
                }
            }
        }
        A = B;
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
        for(int i = 0; i < n; i++)
        {
            double max = C[i, 0];
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    jmax = j;
                }
            }
            for(int j = 0;j<jmax; j++)
            {
                if (C[i, j] < 0) C[i, j] /= max;
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
        int n = Z.GetLength(0), m = Z.GetLength(1);
        if (n != 6 || m != 8) return default;
        int imax = 0, jmax = 0, k = 0;
        double sum = 0;
 
        for( int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if( Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    k += 1;
                }
                if(Z[i, j] > Z[imax, jmax])
                {
                    imax = i;
                    jmax = j;
                }
            }
        }
        Z[imax, jmax] = sum / k;
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
        int n = X.GetLength(0), m = X.GetLength(1);
        if (n != 6 || m != 5) return default;
        int imax = 0, imin = 0, kmin = 5, kmax = 0;
        for(int i = 0; i < n; i++)
        {
            int kotr = 0;
            for (int j = 0; j < m; j++)
            {
                if(X[i, j] < 0) kotr++;
            }
            if (kotr < kmin)
            {
                kmin= kotr;
                imin= i;
            }
            if (kotr > kmax)
            {
                kmax = kotr;
                imax = i;
            }
        }
        for(int j = 0; j < m; j++)
        {
            var p = X[imin, j];
            X[imin, j] = X[imax,j];
            X[imax, j] = p;
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
        int n =A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        int imax = 0, maxs = 0;
        for(int i = 0; i < n; i++)
        {
            int sum = 0;
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] > 0) sum += A[i, j];
            }
            if (sum > maxs)
            {
                maxs = sum;
                imax = i;
            }
        }
        int[,]B = new int[n-1, m];
        for (int i = 0; i < n-1; i++)
        {
            if (i < imax)
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = A[i + 1, j];
                }
            }
        }
        A = B;
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
        if (n != 5 || m != 8) return default;
        if (B.Length != 5) return default;
        int min = A[4,0], jmin = 0;
        for(int j = 1; j< m-1; j++)
        {
            if (A[4, j] < min)
            {
                min = A[4, j];
                jmin = j;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = m - 1; j > jmin + 1; j--)
            {
                A[i, j] = A[i, j - 1];
            }
            A[i, jmin + 1] = B[i];
        }
        //2ой способ с доп массивом
        //int[,]C = new int[n, m];
        //for (int i = 0; i < n; i++)
        //{
        //    for(int j = 0; j < jmin+1; j++)
        //    {
        //        C[i, j] = A[i, j];
        //    }
        //    C[i, jmin+1] = B[i];
        //    for(int j = jmin + 2; j < m; j++)
        //    {
        //        C[i, j] = A[i, j - 1];
        //    }
        //}
        //A = C;

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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > A[i, jmax]) jmax = j;
            }
            
            if (jmax == 0 || (A[i, jmax + 1] < A[i, jmax - 1]))
            {
                if (A[i, jmax + 1] > 0) A[i, jmax + 1] *= 2;
                else if (A[i, jmax + 1] < 0) A[i, jmax + 1] /= 2;
            }
            else if (jmax == m - 1 || (A[i, jmax + 1] > A[i, jmax - 1]))
            {
                if (A[i, jmax - 1] > 0) A[i, jmax - 1] *= 2;
                else if (A[i, jmax - 1] < 0) A[i, jmax - 1] /= 2;
            }
            
        }
            // end

            return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n=A.GetLength(0), m =A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for(int j=0; j < m; j++)
        {
            int ko = 0, kp = 0, imax = 0;
            for(int i =0; i < n; i++)
            {
                if (A[i, j] > 0) kp++;
                else if (A[i, j] < 0) ko++;
                if (A[i, j] > A[imax, j]) imax = i;
            }
            if (kp > ko) A[imax, j] = 0;
            else { A[imax, j] = imax+1; }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n=A.GetLength(0), m = A.GetLength(1);
        if(n!=10 || m != 5) return default;
        for(int j = 0; j < m; j++)
        {
            int imax = 0, sum=0;
            for(int i = 0;i < n; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            if (imax < n / 2)
            {
                for(int i = imax+1; i < n; i++)
                {
                    sum+= A[i, j];
                }
                A[0,j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return default;
        for(int j = 0; j < m; j++)
        {
            int imax = 0;
            for(int i = 1; i < n; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            if (B[j] > A[imax, j]) A[imax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n =A.GetLength(0), m =A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int imax = 0;
            double psum = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            psum = (A[0, j] - A[n - 1, j])/ 2;
            if (A[imax, j] < psum) A[imax, j] = psum;
            else { A[imax, j] = imax + 1; }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        
        if (n<0) return default;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            for(int j = 0; j < 3 * n; j++)
            {
                if (j == i + k * n)
                {
                    answer[i, i + k * n] = 1;
                    k++;
                }
                else { answer[i, j] = 0; }
            }
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n =A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return default;
        int imax = 0;
        for(int i = 1; i< n; i++)
        {
            if (A[i, i] > A[imax, imax]) imax = i;
        }
        for(int i = 0; i < imax; i++)
        {
            for(int j = i+1; j < m; j++)
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
        int n =B.GetLength(0), m =B.GetLength(1);
        if (n != 6 || m != 6) return default;
        int j1max = 0;
        for (int i = 0; i< n; i++)
        {
            int jmax = 0;
            for(int j = 1; j < m; j++)
            {
                if (B[i, j] > B[i, jmax]) jmax = j;
            }
            if (i % 2 == 0) { j1max = jmax; }
            else
            {
                var p = B[i - 1, j1max];
                B[i-1, j1max] = B[i, jmax];
                B[i,jmax] = p;
            }
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m=A.GetLength(1);
        if (n != 6 || m != 7) return default;
        for(int i = 0; i < n; i++)
        {
            for(int j = 1; j <= m / 2; j++)
            {
                var p = A[i, (n / 2 + j)];
                A[i, n / 2 + j] = A[i, n / 2 - j];
                A[i, n / 2 - j] = p;
            }
        }
        // end

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return default;
        int jmin1 = -1;
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                int jmin = 0;
                //поиск минимального эл в строке
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < matrix[i, jmin]) jmin = j;
                }

                if (i != 0 && matrix[i,jmin]>matrix[i-1,jmin1])
                {
                    for (int j = 0; j < m; j++)
                    {
                        var p = matrix[i, j];
                        matrix[i, j] = matrix[i - 1, j];
                        matrix[i - 1, j] = p;
                    }
                }
                else { jmin1 = jmin; }
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
        int n = matrix.GetLength(0), m =matrix.GetLength(1);
        if (n != m) return default;
        answer = new int[2*n-1];
        int k = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j+k] += matrix[i, j];
            }
            k++;
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
        if (n != m || k<1 || k>n) return default;
        int imax = 0, jmax = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(Math.Abs(matrix[i, j]) > Math.Abs(matrix[imax, jmax]))
                {
                    imax = i;
                    jmax = j;
                }
            }
        }
        for(int i = 0; i < n; i++)
        {
            var p = matrix[i, k-1];
            matrix[i, k-1] = matrix[i, jmax];
            matrix[i, jmax] = p;
        }
        for(int j = 0; j < n; j++)
        {
            var p = matrix[imax, j];
            matrix[imax, j] = matrix[k - 1, j];
            matrix[k - 1, j] = p;
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
        if (A.Length / 2 != n || B.Length / 2 != n) return answer;
        int[,] A1 = new int[n, n];
        int[,] B1 = new int[n, n];
        int k = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                A1[i, j] = A[k];
                if(i!=j) A1[j, i] = A1[i, j];
                B1[i, j] = B[k];
                if (i != j) B1[j, i] = B1[i, j];
                k++;
            }
        }
        answer = new int[n * n];
        k = 0;
        for(int i = 0; i < n; i++)
        {
            int m = 0;
            while (m < n)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[k] += A1[i, j] * B1[j, m];
                }
                k++;
                m++;
            }
        }
        //вывод в привычном виде исходных матриц
        //for(int i = 0; i < n; i++)
        //{
        //    for(int j = 0; j < n; j++)
        //    {
        //        Console.Write("{0:d}", A1[i,j]);
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("вторая матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write("{0:d}", B1[i, j]);
        //    }
        //    Console.WriteLine();
        //}
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
        int n=matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return default;
        int c1 = 0;
        for(int k = 0; k < m; k++)
        {
            for(int j = 0; j < m; j++)
            {
                int c = 0;
                for(int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < 0) c++;
                }
                if (j != 0 && c < c1)
                {
                    for(int i = 0; i < n; i++)
                    {
                        var p = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = p;
                    }
                }
                else { c1 = c; }
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
        int k = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(matrix[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
        }
        int[,] A = new int[n-k,m];
        int iA = 0;
        for(int i = 0; i < n; i++)
        {
            k = 0;
            for(int j = 0;j<m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
            if (k == 0)
            {
                for(int j = 0; j < m; j++)
                {
                    A[iA, j] = matrix[i, j];
                }
                iA++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}