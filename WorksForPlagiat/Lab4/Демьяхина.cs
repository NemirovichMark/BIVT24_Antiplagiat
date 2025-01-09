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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        double s = 0;
        int k = 0;
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<7; j++)
            {
                if (A[i, j]> 0)
                    {
                    s += A[i, j];
                    k++;
                }
            }
        }
        // end
        if (k == 0) return 0;
        else answer = s / k;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return default;
        int value = 0, rowIndex = -1;
        // code here
        for (int i=0; i<5;i++)
        {
            if (A[i,colIndex]<0)
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return default;
        double[] answer = new double[4];
        // code here
        for (int i=0; i<4; i++)
        {
            double s = 0;
            int k = 0;
            for (int j=0; j<6; j++)
            {
                if (A[i,j]>0)
                {
                    s += A[i, j];
                    k++;
                }
            }
            if (k == 0) answer[i] = 0;
            else answer[i] = s / k;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        int m = A[0, 1];
        int k = 0;
        for (int i=0; i<5; i++)
        {
            if (A[i, 1] < m)
            {
                m = A[i, 1];
                k = i;
            }
        }
        // end
        int[,]B=new int[4,7];
        for (int i=0; i<k; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                B[i,j] = A[i, j];
            }
        }
        for (int i=k+1; i<5; i++)
        {
            for (int j = 0;j < 7; j++)
            {
                B[i-1,j]= A[i,j];
            }
        }
        A = B;
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
        int[] answer = new int[3];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return default;
        
        for (int j=0; j<3; j++)
        {
            int k = 0;
            for (int i=0; i<4; i++)
            {
                if (A[i, j] < 0) k++;
            }
            answer[j] = k;
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
        if ((B.GetLength(0) != n || B.GetLength(1) != m)) return default;
        for (int i=0; i<n; i++)
        {
            int h = B[i, 0];
            int o = 0;
            for (int j=0; j<m; j++)
            {
                if (B[i, j] < h)
                {
                    h = B[i, j];
                    o = j;
                }
            }
            for (int j=o; j>0; j--)
            {
                B[i, j] = B[i,j-1];
            }
            B[i, 0] = h;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine(B[i, j]);
            }
            Console.WriteLine();
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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return default;
        for (int i = 0; i<n; i++)
        {
            double p = 0, o = 0;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                { 
                    p= F[i, j];
                    break;
                }
            }
            for (int j=m-1; j>0; j--)
            {
                if (F[i, j] < 0)
                {
                    o = F[i, j];
                    break;
                }
            }
            double ma = F[i, 0];
            int d = 0;
            for (int j=0; j<m; j++)
            {
                if (F[i, j] > ma)
                {
                    ma = F[i, j];
                    d = j;
                }
            }
            if (p!= 0 || o!=0) F[i, d] = (p + o) / 2;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return default;
        for (int i=0; i<5; i++)
        {
            int m = G[i, 0];
            int im = 0;
            for (int j=0; j<7; j++)
            {
                if (G[i, j] > m)
                {
                    m = G[i, j];
                    im = j;
                }
            }
            for (int j=6; j>im+1;j--)
            {
                G[i, j] = G[i, j - 1];
            }
            G[i, im + 1] = m;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length!=7) return default;
        int m = A[0, 5];
        int im = 0;
        for (int i=0; i<5; i++)
        {
            if (A[i,5]>m)
            {
                m = A[i, 5];
                im = i;
            }
        }
        for (int j=0; j<7; j++)
        {
            A[im,j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return default;
        int[,] B = new int[5, 6];
        int m= Math.Abs(F[1, 0]);
        int im = 0;
        for (int j=0; j<7; j++)
        {
            if (Math.Abs(F[1,j]) <m)
            {
                m= Math.Abs(F[1,j]);
                im = j;
            }
        }
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<im+1; j++)
            {
                B[i, j] = F[i,j];
            }
            for (int j = im + 2; j < 7; j++)
            {
                B[i, j - 1] = F[i, j];
            }
        }
        // end
        F = B;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        for (int i=0; i<5; i++)
        {
            double s = 0;
            int k = 0;
            double m = A[i, 0];
            int im = 0;
            for (int j=0; j<7; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > m)
                {
                    m = A[i, j];
                    im = j;
                }
            }
            if (k != 0) A[i, im] = (s / k);
            else A[i, im] = 0;

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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        for (int i = 0; i < 5; i++)
        {
            double m = 0;
            int im = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > m)
                {
                    m = A[i, j];
                    im = j;
                }
            }
            if (im == 0)
            {
                if (A[i, im] >= 0) A[i, im+1] *= 2;
                else A[i, im+1] *= 0.5;
            }
            else if (im == 6)
            {
                if (A[i,im]>=0) A[i, im - 1] *= 2;
                else A[i,im-1]*=0.5;
            }
            else if (A[i, im - 1] > A[i, im + 1])
            {
                if (A[i, im+1] >= 0) A[i, im+ 1] *= 2;
                else A[i, im+1] *= 0.5;
            }
            else if (A[i, im - 1] < A[i, im + 1])
            {
                if (A[i, im-1] >= 0) A[i, im - 1] *= 2;
                else A[i, im-1] *= 0.5;
            }
            // end
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A == null  || A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        for (int j=0; j<5; j++)
        {
            int p = 0;
            int o = 0;
            int ma = A[0,j];
            int ima = 0;
            for (int i=0; i<7; i++)
            {
                if (A[i,j]>0) p++;
                if (A[i,j]<0) o++;
            }
            for (int i = 0; i < 7; i++)
            {
               if (A[i,j]>ma)
                {
                    ma= A[i,j];
                    ima = i;
                }
            }
            if (p>o)
            {
                A[ima,j] = 0;
            }
            else
            {
                A[ima, j] = ima;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5) return default;
        for (int j=0; j<5; j++)
        {
            int m = A[0,j];
            int im = 0;
            for ( int i=0; i<10;i++)
            {
                if (A[i, j] > m)
                {
                    im=i;
                    m = A[i, j];
                }
            }
            if (im < 5)
            {
                int s = 0;
                for (int i=im+1; i<10; i++)
                {
                    s += A[i, j];
                }
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B==null || B.Length!=5) return default;
        for (int j=0; j<5; j++)
        {
            int m = A[0, j];
            int im = 0;
            for (int i=0; i<7; i++)
            {
                if (A[i,j] > m)
                {
                    m= A[i,j];
                    im = i;
                }
            }
            if (m < B[j])
            {
                A[im, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        for (int j=0; j<5; j++)
        {
            double m = A[0, j];
            int im = 0;
            for (int i=0; i<7;i++)
            {
                if (A[i,j]>m)
                {
                    m = A[i, j];
                    im = i;
                }
            }
            double p = (A[0, j] + A[6, j])/2.0;
            if (m<p)
            {
                A[im, j] = p;
            }
            else
            {
                A[im, j] = im;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        
        // code here
        if (n<0) return default;
        int[,] A = new int[n,3*n];
        for (int i=0; i<n; i++)
        {
            for (int j=i; j<3*n;j+=n)
            {
                A[i, j] = 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A==null || A.GetLength(0)!=6 || A.GetLength(1)!=6) return default;
        int m = A[0,0];
        int im = 0;
        for (int i=0; i<6; i++)
        {
            if (A[i,i]>m)
            {
                m = A[i, i];
                im = i;
            }
        }
        for (int k=1; k<=im; k++)
        {
            for (int j = k; j < 6; j++)
                {
                    A[k-1,j]=0;
                }
        
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) return default;
        int[] D = new int[6];
        for (int i = 0; i < 6; i++)
        {
            int m = B[i, 0];
            int im = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > m)
                {
                    m = B[i, j];
                    im=j;
                }
            }
            D[i] = im;
        }
        for (int i = 0; i < 6; i+=2)
        {
            (B[i, D[i]], B[i + 1, D[i+1]])= (B[i+1, D[i+1]], B[i, D[i]]);
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return default;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                (A[i, j], A[i, 7 - j - 1]) = (A[i, 7 - j - 1], A[i, j]);
            }
            // end
        }
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default;
        for (int i=0; i<7; i++)
        {
            for (int k = 0; k < 7 - 1 - i; k++)
            {
                int mi = int.MaxValue;
                int mi2 = int.MaxValue;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[k, j] < mi)
                    {
                       mi = matrix[k, j];
                    }
                    if (matrix[k + 1, j] < mi2)
                    {
                       mi2 = matrix[k + 1, j];
                    }
                    
                }
                if (mi<mi2)
                {
                    for (int j=0; j<5; j++)
                    {
                        (matrix[k, j], matrix[k + 1, j]) = (matrix[k + 1, j], matrix[k, j]);
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0) return default;
        
        // code here
        int[] A = new int[2 * matrix.GetLength(0) - 1];
        int d = 0;
        
        for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
        {
            int s = 0;
            for (int k = i, l = 0; k < matrix.GetLength(1) && l < matrix.GetLength(0); k++, l++)
            {
                s += matrix[k, l];
            }
            A[d] = s;
            d++;
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int s = 0;
            for (int k = i, l = 0; k < matrix.GetLength(0) && l < matrix.GetLength(1); k++, l++)
            {
                s += matrix[l, k];
            }
            A[d] = s;
            d++;
        }
        // end

        return A;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] A, int k)
    {
        // code here
        k = k - 1;
        if (A==null || A.GetLength(0)==0 || A.GetLength(0)!=A.GetLength(1) || k<1 || k>=A.GetLength(0) || k>=A.GetLength(1)) return default;
        int m = Math.Abs(A[0, 0]);
        int im = 0;
        int jm = 0;
        for (int i=0; i<A.GetLength(0); i++)
        {
            for (int j=0; j<A.GetLength(1); j++)
            {
                if (Math.Abs(A[i, j]) > m)
                {
                    m=Math.Abs(A[i, j]);
                    im = i;
                    jm = j;
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            (A[i, k], A[i, jm]) = (A[i, jm], A[i, k]);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            (A[k ,j], A[im, j]) = (A[im, j], A[k, j]);
        }
        
        // end

        return A;
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
        if (A == null || A.Length !=(n+1)/2*n || B.Length!=(n+1)/2*n) return default;
        int[] C = new int[n*n];
        int[,]D= new int[n,n];
        int[,]F= new int[n,n];
        int z = 0;
        
        for (int i = 0; i < n; i++)
        {
                for (int j = i; j < n; j++)
                {
                    D[i, j] = A[z];
                    D[j, i] = A[z];
                    z++;
                }
        }
        z = 0;
        for (int i=0; i<n; i++)
        {
            for (int j=i; j < n; j++)
            {
                F[i, j] = B[z];
                F[j, i] = B[z];
                z++;
            }
        }
        z = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int a = 0;
                for (int i1 = 0, j1 = 0; i1 < n; i1++, j1++)
                {
                    a += D[i, j1] * F[i1, j];
                }
                C[z] = a;
                z += 1;
            }
        }
        // code here

        // end

        return C;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        int[]B= new int[A.GetLength(1)];
        for (int k = 0; k < 7; k++)
        {
           for (int j = 0; j < 6; j++)
            {
                int u = 0;
                int v = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (A[i, j] < 0) u++;
                    if (A[i, j+1] < 0) v++;
                }
                if (u>v)
                {
                    for (int i=0; i<5; i++)
                    {
                        (A[i, j], A[i, j + 1]) = (A[i, j + 1], A[i, j]);
                    }
                }
            }
            
        }
        // end

        return A;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) == 0 || A.GetLength(1) == 0) return default;
        int k = 0;
        for ( int i=0; i<A.GetLength(0); i++)
        {            
            for (int j=0; j<A.GetLength(1); j++)
            {
                if (A[i,j]==0)
                {
                    k++;
                    break;  
                }
            }
   
        }
        int[]R= new int[k];
        int[,] D = new int[A.GetLength(0) - k, A.GetLength(1)];
        k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 0)
                {
                    R[k] = i;
                    k++;
                    break;
                }
            }

        }
        k = 0;
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == R[k])
            {
                k++;
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    D[i-k, j] = A[i, j];
                }
            }
            
        }
        // end
        A = D;
        return A;
    }
    #endregion
}