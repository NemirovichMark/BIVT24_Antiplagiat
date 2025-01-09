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
        program.Task_3_11(new int[,]{
            { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
        });
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        double sum = 0; int kol =0;
        for (int i =0; i<5;i++)
        {
            for (int j=0;j<7;j++)
            {
                if (A[i,j] > 0)
                {
                    sum+=A[i,j];
                    kol+=1;
                }
            }
        }
        if (kol!=0) answer = sum/kol;
        else answer=0;
        System.Console.WriteLine(answer);
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=4) return default;
        for (int i=0;i<A.GetLength(0);i++)
        {
            if ((A[i,colIndex]<0) && (rowIndex ==-1)) 
            {
                value = A[i,colIndex];
                rowIndex = i;
            }
        }
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
        if (A.GetLength(0)!=4 || A.GetLength(1)!=6) return default;
        double[] answer = new double[4];
        int z =0;
        for (int i =0;i<4;i++)
        {
            double sum=0;
            int kol=0;
            double sr=0;
            for (int j = 0;j<6;j++)
            {
                if (A[i,j]>0)
                {
                    sum += A[i,j];
                    kol++;
                }
            }
            if (kol!=0) sr=sum/kol;
            answer[z] = sr;
            z++;
            Console.WriteLine(sr);
        }
        foreach(double x in answer)
        {
            Console.Write(x + ' ');
        }
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return default;
        int[,] B = new int[4,7];
        int imin = -1;
        int amin = 1000000;
        for (int i =0;i<5;i++)
        {
            if (A[i,1]<amin)
            {
                amin=A[i,1];
                imin=i;
            }
        }
        for (int i = 0; i<imin;i++)
        {
            for (int j=0;j<7;j++)
            {
                B[i,j] = A[i,j];
            }
        }
        for (int i = imin+1;i<5;i++)
        {
            for (int j=0;j<7;j++)
            {
                B[i-1,j] = A[i,j];
            }
        }
        A=B;
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
        if (A.GetLength(0)!=4 || A.GetLength(1)!=3) return default;
        int[] answer = new int[3];
        int z = 0;
        for (int j =0;j<3;j++)
        {
            int kol =0;
            for (int i=0;i<4;i++)
            {
                if (A[i,j]<0) kol++;
            }
            answer[z] = kol;
            z++;
        }
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
        if (B.GetLength(0)!=n || B.GetLength(1)!=m) return default;
        for (int i=0;i<n;i++)
        {
            int bmin = 100000;
            int jmin = -1;
            for (int j=0;j<m;j++)
            {
                if (B[i,j]<bmin)
                {
                    bmin = B[i,j];
                    jmin = j;
                }
            }
            for (int j = jmin; j>0;j--)
            {
                B[i,j] = B[i,j-1];
                
            }
            B[i,0] = bmin;
        }
        for (int i =0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                Console.WriteLine(B[i,j]);
            }
            Console.WriteLine();
        }
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
        if (F.GetLength(0)!=n || F.GetLength(1)!=m) return default;
        for (int i=0;i<n;i++)
        {
            int jper = -1;
            double per = 0;
            for (int j = 0;j < m;j++)
            {
                if (F[i,j] < 0) 
                {
                    per = F[i,j];
                    jper = j;
                    break;
                }
            }
            double pos = 0;
            int jpos =-1;
            for (int j = m-1;j>0;j--)
            {
                if (F[i,j] < 0)
                {
                    jpos = j;
                    pos = F[i,j];
                    break;
                }
            }
            int jmax = -1;
            double fmax = -1000000000;
            for (int j =0;j<m;j++)
            {
                if (F[i,j] > fmax)
                {
                    fmax=F[i,j];
                    jmax= j;
                }
            }
            if (jpos != -1 || jper!=-1) 
            {
                F[i,jmax] = (pos+per)/2;
            }
        }
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
        if (G.GetLength(0)!= 5 || G.GetLength(1)!=7) return default;
        for (int i =0; i<5;i++)
        {
            int jmax= -1;
            int gmax = -1000000000;
            for (int j=0;j<6;j++)
            {
                if (G[i,j] > gmax)
                {
                    gmax=G[i,j];
                    jmax = j;
                }
            }
            for (int j = 6;j > jmax;j--)
            {
                G[i,j] = G[i,j-1];
            }
            G[i,jmax+1] = gmax;
        }
        for (int i=0;i<5;i++)
        {
            for (int j=0;j<7;j++)
            {
                Console.WriteLine(G[i,j]);
            }
            Console.WriteLine();
        }
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
        if (A.GetLength(0) !=5 || A.GetLength(1)!=7 || B.Length != 7) return default;
        int imax = -1;
        int amax=-1000000000;
        for (int i =0; i < 5;i++)
        {
            if (A[i,5] > amax) 
            {
                amax= A[i,5];
                imax=i;
            }
        }
        int z =0;
        for (int j =0; j<7;j++)
        {
            A[imax,j] = B[z];
            z++;
        }
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
        if (F.GetLength(0)!= 5 || F.GetLength(1) != 7) return default;
        int[,]F2 = new int [5,6];
        int min2 = 10000000;
        int jmin = -1;
        for (int j =0;j<7;j++)
        {
            if (Math.Abs(F[1,j]) <min2)
            {
                min2 = Math.Abs(F[1,j]);
                jmin = j;
            }
        }
        jmin =jmin+1;
        int z =0;
        for (int i = 0; i<5;i++)
        {
            z =0;
            for (int j =0; j<jmin;j++)
            {
                F2[i,z] = F[i,j];
                z++;
            }
            for (int j = jmin+1;j<7;j++)
            {
                F2[i,z] = F[i,j];
                z++;
            }
        }
        F=F2;
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
        if (A.GetLength(0)!= 5 || A.GetLength(1) != 7) return default;
        for (int i =0; i<5;i++)
        {
            double amax = -1000000000;
            int jmax = -1;
            for (int j =0;j<7;j++)
            {
                if (A[i,j] > amax)
                {
                    amax=A[i,j];
                    jmax = j;
                }
            }
            double sum =0;
            int k =0;
            for (int j = 0;j<7;j++)
            {
                if (A[i,j] > 0)
                {
                    sum+=A[i,j];
                    k++;
                }
            }
            double srp =0;
            if (k!=0)
            {
                srp = sum/k;
            }
            A[i,jmax] = srp;
        }
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
        if (A.GetLength(0)!= 5 || A.GetLength(1) != 7) return default;
        for (int i =0;i<5;i++)
        {
            double amax = -10000000;
            int jmax =-1;
            for (int j =0;j<7;j++)
            {
                if (A[i,j] > amax)
                {
                    amax=A[i,j];
                    jmax = j;
                }
            }
            if (jmax == 0)
            {
                if (A[i,1] >=0) A[i,1] = A[i,1] *2;
                else A[i,1] = A[i,1]*0.5;
            }
            else if (jmax == 6)
            {
                if (A[i,5] >=0) A[i,5] = A[i,5] *0.5;
                else A[i,5] = A[i,5]*0.5;
            }
            else
            {
                if (A[i,jmax-1] > A[i,jmax+1])
                {
                    if (A[i,jmax+1] >=0) A[i,jmax+1] = A[i,jmax+1]*2;
                    else A[i,jmax+1] = A[i,jmax+1]*0.5;
                }
                else
                {
                    if (A[i,jmax-1] >=0) A[i,jmax-1] = A[i,jmax-1]*2;
                    else A[i,jmax-1] = A[i,jmax-1]*0.5;
                }
            }
        }
        for (int i=0;i<5;i++)
        {
            for (int j=0;j<7;j++)
            {
                Console.Write(A[i,j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0)!= 7 || A.GetLength(1) != 5) return default;
        for (int j =0;j <5;j++)
        {
            int amax =-10000000;
            int imax =-1;
            int pol = 0;
            int otr =0;
            for (int i =0; i<7;i++)
            {
                if (A[i,j] > amax)
                {
                    amax = A[i,j];
                    imax =i;
                }
                if (A[i,j] >0) pol++;
                if (A[i,j]<0) otr++;
            }
            if (pol > otr) A[imax,j] = 0;
            else A[imax,j] = imax+1;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0)!= 10 || A.GetLength(1) != 5) return default;
        for (int j =0 ;j<5;j++)
        {
            int amax =-100000000;
            int imax = -1;
            for (int i =0 ;i<10;i++)
            {
                if (A[i,j] > amax)
                {
                    amax = A[i,j];
                    imax = i;
                }
            }
            if (imax <5)
            {
                int sum =0;
                for (int i = imax+1;i<10;i++)
                {
                    sum+=A[i,j];
                }
                A[0,j] = sum;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0)!= 7 || A.GetLength(1) != 5 || B.Length!=5) return default;
        int z =0;
        for (int j =0;j<5;j++)
        {
            int amax =-10000000;
            int imax =-1;
            for (int i =0;i<7;i++)
            {
                if (A[i,j] > amax)
                {
                    amax =A[i,j];
                    imax = i;
                }
            }
            if (A[imax,j] < B[z]) A[imax,j] = B[z];
            z++;
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0)!= 7 || A.GetLength(1) != 5) return default;
        for (int j =0;j<5;j++)
        {
            double amax =-10000000;
            int imax =-1;
            for (int i =0;i<7;i++)
            {
                if (A[i,j] > amax)
                {
                    amax = A[i,j];
                    imax = i;
                }
            }
            double psum = (A[0,j]+A[6,j])/2;
            if (A[imax,j] < psum) A[imax,j] = psum;
            else A[imax,j] = imax+1;
        } 
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n<0) return default;
        int[,] answer = new int[n,3*n];
        for (int i =0; i<n;i++)
        {
            for (int j = i;j<3*n;j+=n)
            {
                answer[i,j] = 1;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0)!= 6 || A.GetLength(1) != 6) return default;
        int maxd = -1000000;
        int imax = -1;
        for (int i =0;i<6;i++)
        {
            for (int j =0; j<6;j++)
            {
                if (i==j && (A[i,j] > maxd))
                {
                    maxd = A[i,j];
                    imax = i;
                }
            }
        }
        for (int i =0; i<imax;i++)
        {
            for (int j=1;j<6;j++)
            {
                if (j>i)
                {
                    A[i,j] = 0;
                }
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0)!= 6 || B.GetLength(1) != 6) return default;
        for (int i=0;i<6;i+=2)
        {
            int max1 = -100000000;
            int jmax1 =-1;
            for (int j=0;j<6;j++)
            {
                if (B[i,j] > max1)
                {
                    max1 =B[i,j];
                    jmax1 = j;
                }
            }
            int max2 = -100000000;
            int jmax2 =-1;
            for (int j=0;j<6;j++)
            {
                if (B[i+1,j] > max2)
                {
                    max2 =B[i+1,j];
                    jmax2 = j;
                }
            }
            B[i,jmax1] = max2;
            B[i+1,jmax2] = max1;
        }
        for (int i=0;i<6;i++)
        {
            for (int j=0;j<6;j++)
            {
                Console.Write(B[i,j] + " ");
            }
            Console.WriteLine();
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0)!=6 || A.GetLength(1)!=7) return default;
        for (int i =0;i<6;i++)
        {
            for (int j =0;j < 3;j++)
            {
                int temp = A[i,j];
                A[i,j] = A[i,7-j-1];
                A[i,7-j-1] = temp;
            }
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        int ki = matrix.GetLength(0);
        int kj = matrix.GetLength(1);
        for (int i = 0; i<ki;i++)
        {
            if (i == 0 || i == ki-1)
            {
                for (int j =0; j< kj;j++)
                {
                    matrix[i,j] = 0;
                }
            }
            else
            {
                matrix[i,0] = 0;
                matrix[i,kj-1] = 0;
            }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        int ki = matrix.GetLength(0);
        int kj = matrix.GetLength(1);
        for (int i = ki/2; i<ki;i++)
        {
            for (int j=0;j<kj;j++)
            {
                if (j<=i)
                {
                    matrix[i,j] = 1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        int ki = matrix.GetLength(0);
        int kj = matrix.GetLength(1);
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        int zu = 0;
        int zl = 0;
        int ku =0;
        int kl = 0;
        for (int i =0 ;i<ki;i++)
        {
            for (int j = 0;j<kj;j++)
            {
                if (j>=i)
                {
                    ku++;
                }
                else
                {
                    kl++;
                }
            }
        }
        System.Console.WriteLine(ku);
        System.Console.WriteLine(kl);
        upper = new int[ku];
        lower = new int[kl];
        for (int i =0 ;i<ki;i++)
        {
            for (int j = 0;j<kj;j++)
            {
                if (j>=i)
                {
                    upper[zu] = matrix[i,j];
                    zu++;
                }
                else
                {
                    lower[zl] = matrix[i,j];
                    zl++;
                }
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
        if (matrix.GetLength(0)!=7 || matrix.GetLength(1)!=5) return default;
        for (int z =0;z<6;z++)
        {
            for (int i =1; i<7;i++)
            {
                int k1 =0;
                for (int j =0; j<5;j++)
                {
                    if (matrix[i,j] >0) k1++;
                }
                int k2 = 0;
                for (int j =0; j<5;j++)
                {
                    if (matrix[i-1,j] >0) k2++;
                }
                if (k1>k2)
                {
                    for (int j=0;j<5;j++)
                    {
                        int temp = matrix[i-1,j];
                        matrix[i-1,j] = matrix[i,j];
                        matrix[i,j] = temp;
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
        int ki = matrix.GetLength(0);
        int kj = matrix.GetLength(1);
        for (int i =0 ;i<ki;i+=2)
        {
            for (int k =0;k < kj-1;k++)
            {
                for (int j = 1; j<kj;j++)
                {
                    if (matrix[i,j] > matrix[i,j-1])
                    {
                        int temp = matrix[i,j-1];
                        matrix[i,j-1] = matrix[i,j];
                        matrix[i,j] = temp;
                    }
                }
            }
            for (int j =0;j<kj;j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            System.Console.WriteLine();
        }
        for (int i =1 ;i<ki;i+=2)
        {
            for (int k =0;k < kj-1;k++)
            {
                for (int j = 1; j<kj;j++)
                {
                    if (matrix[i,j] < matrix[i,j-1])
                    {
                        int temp = matrix[i,j-1];
                        matrix[i,j-1] = matrix[i,j];
                        matrix[i,j] = temp;
                    }
                }
            }
            for (int j =0;j<kj;j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            System.Console.WriteLine();
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int ki = matrix.GetLength(0);
        int kj = matrix.GetLength(1);
        int k2 = ki;
        for (int i = 0;i<ki;i++)
        {
            for (int j =0;j<kj;j++)
            {
                if (matrix[i,j]==0)
                {
                    k2--;
                    matrix[i,0] = 0;
                    break;
                }
            }
        }
        System.Console.WriteLine(k2);
        int[,]A = new int[k2,kj];
        int ii =0;
        for (int i =0;i<ki;i++)
        {
            if (matrix[i,0] !=0)
            {
                for (int j =0;j<kj;j++)
                {
                    A[ii,j] = matrix[i,j];
                }
                ii++;
            }
        }
        matrix = A;
        return matrix;
    }
    #endregion
}