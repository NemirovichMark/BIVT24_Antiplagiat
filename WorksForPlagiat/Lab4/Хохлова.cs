using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
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
        // code here
        int S = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                S += A[i, j];
            }
        }
        answer = S;
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
        double mn = 11111111111111111;
        for (int i =0; i<A.GetLength(0); i++)
        {
            for (int j =0; j< A.GetLength(1); j++)
            {
                if (A[i,j]<mn)
                {
                    mn = A[i, j];
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
        int[] q = new int[A.GetLength(1)];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return null;
        int mx = -1111111;
        for (int i =0; i<A.GetLength(1); i++)
        {
            for (int j=0; j<A.GetLength(0); j++)
            {
                if (A[j, i] > mx) mx = A[j, i];
            }
            q[i] = mx;
            mx = -1111111;
        }
        answer = q;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int mx = -1111111, str1 = 0, str4 = 0;
        for (int i=0; i<A.GetLength(0); i++)
        {
            if (A[i, 2]>mx)
            {
                mx = A[i, 2];
                str1 = i;
            }
        }
        if (str1!=3)
        {
            for (int i = 0; i < A.GetLength(1); i++)
            {
                str4 = A[str1, i];
                A[str1, i] = A[3, i];
                A[3, i] = str4;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        int i = 0, j = 0, mx=-11111111, stolb=0, st=0;
        for (int m=0; m<5; m++)
        {

            if (A[i,j]>mx)
            {
                stolb = j;
                mx = A[i, j];
            }
            i++;
            j++;
        }
        for (int m=0; m<5; m++)
        {
            st = A[m, stolb];
            A[m, stolb] = A[m, 3];
            A[m, 3] = st;
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
        int mx = -11111111, st=0, a=0;
        for( int i=0; i < A.GetLength(0); i++)
        {
            for (int j=0; j< A.GetLength(1); j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    st = j;
                }
            }
            for(int q=st; q< A.GetLength(1) - 1; q++)
            {
                a = A[i, q+1];
                A[i, q] = a;
            }
            A[i, A.GetLength(1) - 1] = mx;
            mx = -1111111;
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
        double mx = -11111111;
        int st = 0;
        for( int i=0; i<C.GetLength(0); i++)
        {
            for (int j=0; j<C.GetLength(1); j++)
            {
                if (C[i, j] > mx)
                {
                    mx = C[i, j];
                    st = j;
                }
            }
            for (int q=0; q<st;q++)
            {
                if (C[i, q] < 0 && mx!=0) C[i, q] /=mx;
            }
            mx = -1111111111;
            st = 0;
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double S = 0, mx = -111111111;
        int STmx = 0, STRmx = 0, k = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    S += Z[i, j];
                    k++;
                }
                if (Z[i, j]>mx)
                {
                    mx = Z[i, j];
                    STmx = j;
                    STRmx = i;
                }
            }
        }
        S /= k;
        Z[STRmx, STmx] = S;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int mx = 0, mn = 11111110, K = 0, STmx=0, STmn=0;
        for( int i =0; i<X.GetLength(0);i++)
        {
            for(int j=0; j<X.GetLength(1);j++)
            {
                if (X[i, j] < 0) K++;
            }
            if (K > mx)
            {
                mx = K;
                STmx = i;
            }
            if (K < mn)
            {
                mn = K;
                STmn = i;
            }
            K = 0;
        }
        int q = 0;
        for (int i =0; i<X.GetLength(1); i++)
        {
            q = X[STmn, i];
            X[STmn, i] = X[STmx, i];
            X[STmx, i] = q;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int Smx = 0, ST=0;
        for (int i=0; i<A.GetLength(0); i++)
        {
            int S = 0;
            for (int j=0; j<A.GetLength(1); j++)
            {
                if (A[i,j]>0) S += A[i, j];
            }
            if (S>Smx)
            {
                Smx = S;
                ST = i;
            }
        }
        int[,] Anew = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int q = 0;
        for (int i=0; i<A.GetLength(0); i++)
        {
            for (int j=0; j<Anew.GetLength(1); j++)
            {
                if (i == ST) i++;
                Anew[q, j] = A[i, j];
                
            }
            q++;
        }
        A = Anew;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length!=5) return null;
        int mn = 1111111; int ST = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < mn)
            {
                mn = A[4, i];
                ST = i;
            }
        }
        if (ST != A.GetLength(1) - 1)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, ST + 1] = B[i];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[] M = new int[5]; 
        for(int i=0; i<A.GetLength(0); i++)
        {
            double mx = -111111111;
            int q = 0;
            for(int j=0; j<A.GetLength(1); j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    q = j;
                }
            }
            M[i] = q;
        }
        for (int i=0; i<A.GetLength(0); i++)
        {
            if (M[i]==0)
            {
                A[i, M[i] + 1] *= 2;
            }
            else if (M[i]==A.GetLength(1)-1)
            {
                A[i, M[i] - 1] *= 2;
            }
            else
            {
                if (A[i, M[i] + 1] > A[i, M[i] - 1])
                {
                    if(A[i, M[i] - 1]>0) A[i, M[i] - 1] *= 2;
                    else A[i, M[i] - 1] /= 2;
                }
                
                else
                {
                    if (A[i, M[i] + 1] > 0) A[i, M[i] + 1] *= 2;
                    else A[i, M[i] + 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = -1010101, STR = 0, Kpol = 0, Kotr=0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    STR = j;
                }
                if (A[j, i] > 0) Kpol++;
                else Kotr++;
            }
            if (Kpol >= Kotr) A[STR, i] = 0;
            else A[STR, i] = STR+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for(int i=0; i<A.GetLength(1); i++)
        {
            int mx = -111111, STR = 0, S = 0;
            for(int j=0; j<A.GetLength(0); j++)
            {
                if (A[j,i]>mx)
                {
                    mx = A[j, i];
                    STR = j;
                }
            }
            if (STR < 5)
            {
                for (int j = STR + 1; j < A.GetLength(0); j++)
                {
                    S += A[j, i];
                }
                A[0, i] = S;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int i=0; i<A.GetLength(1); i++)
        {
            int mx = 0, STR=0;
            for (int j=0; j<A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    STR = j;
                }
            }
            if (mx < B[i]) A[STR, i] = B[i];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i=0; i<A.GetLength(1); i++)
        {
            double mx = 0, sr = (A[0, i] + A[6, i]) / 2;
            int STR = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i]>mx)
                {
                    mx = A[j, i];
                    STR = j;
                }
            }
            if (mx < sr) A[STR, i] = sr;
            else A[STR, i] = STR+1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        int[,] Q = new int[n, 3 * n];
        int a = 2;
        for(int i=0; i<Q.GetLength(0); i++)
        {
            for(int j=0; j<Q.GetLength(1); j++)
            {
                Q[i, j] = ((j + a) % 3) / 2;
            }
            a--;
        }
        answer = Q;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int mx = -111111111, STR=0;
        for (int i=0; i<A.GetLength(0); i++)
        {
            if (A[i, i] > mx)
            {
                mx = A[i, i];
                STR = i;
            }
        }
        if (STR!=0)
        {
            int q = 1;
            for (int i=0; i<STR;i++)
            {
                for(int j=i+q; j<A.GetLength(1); j++)
                {
                    A[i, j]=0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(1) != 6 || B.GetLength(0) != 6) return null;
        int[] Mx = new int[6];
        int[] STR = new int[6];
        for(int i=0; i<B.GetLength(0); i++)
        {
            int mx = -111111, str=0;
            for(int j=0; j<B.GetLength(1); j++)
            {
                if (B[i,j]>mx)
                {
                    mx = B[i, j];
                    str = j;
                }
            }
            Mx[i]=mx;
            STR[i] = str;
        }
        B[0, STR[0]] = Mx[1];
        B[1, STR[1]] = Mx[0];
        B[2, STR[2]] = Mx[3];
        B[3, STR[3]] = Mx[2];
        B[4, STR[4]] = Mx[5];
        B[5, STR[5]] = Mx[4];
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i=0; i<A.GetLength(0); i++)
        {
            int[] STR = new int[7];
            for (int j=0; j<A.GetLength(1); j++)
            {
                STR[j] = A[i, j]; 
            }
            for (int j=0; j<A.GetLength(1); j++)
            {
                A[i, j] = STR[A.GetLength(1) - 1 - j];
            }
        }
        // end

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
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1) && matrix.GetLength(0) <= 2) return null;
        int str = matrix.GetLength(0), st = matrix.GetLength(1);
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                if (i==0 || j==0 || i==str-1 || j==st-1)
                {
                    matrix[i, j] = 0;
                }
            }
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
        int n = matrix.GetLength(0);
        if (n % 2 == 0) n /= 2;
        else n = (n-1) / 2;
        for (int i = n; i< matrix.GetLength(0);i++)
        {
            for (int j=0; j<=i; j++)
            {
                matrix[i, j] = 1;
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int s1 = 0;
        for (int i = 0; i <= matrix.GetLength(1); i++) s1 += i;
        int s2 = matrix.GetLength(0) * matrix.GetLength(1) - s1;
        int[] q1 = new int[s1];
        int[] q2 = new int[s2];
        int m1 = 0, m2 = 0;
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                if (j>=i)
                {
                    q1[m1] = matrix[i, j];
                    m1++;
                }
                else
                {
                    q2[m2] = matrix[i, j];
                    m2++;
                }
            }
        }
        upper = q1;
        lower = q2;
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
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[,] M = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] B = new int[matrix.GetLength(0)];
        int d = 0;
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            int mx = 0;
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) mx++;
            }
            B[d] = mx;
            d++;
        }
        int t = 0;
        for (int i=5; i>=0; i--)
        {
            for(int j=0; j<matrix.GetLength(0);j++)
            {
                if (B[j]==i)
                {
                    for (int b=0; b<matrix.GetLength(1); b++)
                    {
                        M[t, b] = matrix[j, b];
                    }
                    t++;
                }
            }
        }
        matrix = M;
        // end

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
        // code here
        for (int i = 0; i < matrix.GetLength(0); i += 2) //по убыванию
        {
            int t = 0;
            while (t < matrix.GetLength(1))
            {
                Console.WriteLine(t);
                int m = t;
                while (t > 0)
                {
                    if (matrix[i, t] > matrix[i, t - 1])
                    {
                        int q = matrix[i, t - 1];
                        matrix[i, t - 1] = matrix[i, t];
                        matrix[i, t] = q;
                    }
                    t--;
                }
                t = m + 1;
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i += 2) //по возраствнию
        {
            int t = 0;
            while (t < matrix.GetLength(1))
            {
                Console.WriteLine(t);
                int m = t;
                while (t > 0)
                {
                    if (matrix[i, t] < matrix[i, t - 1])
                    {
                        int q = matrix[i, t - 1];
                        matrix[i, t - 1] = matrix[i, t];
                        matrix[i, t] = q;
                    }
                    t--; 
                }
                t = m + 1;
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            int m = 0;
            for(int j=0; j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) m++;
            }
            if (m != 0) matrix[i, 0] = 0;
        }
        int c = 0;
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            if (matrix[i, 0] != 0) c++;
        }
        int[,] M = new int[c,matrix.GetLength(1)];
        int d = 0;
        for(int i=0; i<c; i++)
        {
            if (matrix[d,0]!=0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    M[i, j] = matrix[d, j];
                }
            }
            d++;
        }
        matrix = M;
        // end

        return matrix;
    }
    #endregion
}