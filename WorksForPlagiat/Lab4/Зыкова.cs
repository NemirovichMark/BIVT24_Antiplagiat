using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
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
        if (A.GetLength(0)==5 && A.GetLength(1)==7)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write("       ");
                    Console.Write(i);
                    Console.WriteLine(j);
                    answer += A[i, j];
                }
            }
        }
        Console.WriteLine(answer);
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
        double mn = 100000000;
        // code here
        if (A.GetLength(0)!=3 || A.GetLength(1)!=6) return (0,0);
        for(int i = 0; i<3; i++)
        {
            for (int j = 0; j<6; j++)
            {
                if (A[i, j] < mn)
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
        if (A.GetLength(0)!=3  || A.GetLength(1)!=5) return answer;
        answer = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int mx = -100;
            for (int j = 0; j<3; j++)
            {
                if (A[j,i] >mx) mx = A[j,i];
            }
            answer[i] = mx;
            Console.WriteLine(mx);
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
        double mx = -10000;
        int index = 0;
        int[,] answer = default(int[,]);
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return answer;
        for (int i = 0; i<5; i++)
        {
            if (A[i, 2] > mx)
            {
                mx = A[i, 2];
                index = i;
            }
        }
        int[] def = new int[7];
        for (int i = 0; i < 7; i++)
        {
            def[i] = A[index, i];
            Console.Write(A[index, i]);
        }
        Console.WriteLine("");
        for (int i = 0; i < 7; i++)
        {
            A[index, i] = A[3, i];
            A[3, i] = def[i];
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
        int row = 0;
        double mx = -100000000;
        int[,] answer = default(int[,]);
        // code here
        if (A.GetLength(0)!=5 || A.GetLength(1)!=5) return answer;
        for (int i = 0; i < 3; i++)
        {
            if (A[i, i] >mx)
            {
                mx = A[i, i];

                row = i;
            }
        }
        Console.WriteLine(mx);
        Console.WriteLine(row);
        int elem = 0;
        for (int i = 0; i<5; i++)
        {
            elem = A[i, row];
            Console.Write(elem);
            A[i, row] = A[i, 3];
            A[i, 3] = elem;
        }
        Console.WriteLine("");
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
        for(int i = 0; i<n; i++)
        {
            int mx = -10000;
            int index = 0;
            for (int j = 0; j<m; j++)
            {
                if(A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = j;
                }
            }
            for (int j = index; j<m-1; j++)
            {
                A[i, j] = A[i, j+1];
            }
            A[i, m-1] = mx;
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
        for (int i = 0; i < n; i++)
        {
            double mx = -10000;
            int index = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > mx)
                {
                    mx = C[i, j];
                    index = j;
                }
            }
            for (int j=0; j<index; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] /= mx;
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
        double[,] answer = default(double[,]);
        // code here
        if (Z.GetLength(0)!=6 || Z.GetLength(1)!=8) return answer;
        double mx = 0;
        int index1 = 0;
        int index2 = 0;
        double s = 0;
        int k = 0;
        for (int i =0; i<6; i++)
        {
            for (int j = 0; j<8; j++)
            {
                if (Z[i, j] > mx)
                {
                    mx = Z[i, j];
                    index1 = i;
                    index2 = j;
                }
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
            }
        }
        Z[index1, index2] = s/k;
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
        int mx = -100000;
        int i_max = 0;
        int mn = 100000;
        int i_min = 0;
        int[,] answer = default(int[,]);
        if (X.GetLength(0)!=6 || X.GetLength(1)!=8) return answer;
        for (int i = 0; i < 6; i++)
        {
            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0) k++;
            }
            if (k>mx)
            {
                mx = k;
                i_max = i;
            }
            if (k < mn)
            {
                mn = k;
                i_min = i;
            }
        }
        for (int i = 0; i<5; i++)
        {
            int elem = X[i_max, i];
            X[i_max, i] = X[i_min, i];
            X[i_min, i] = elem;
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
        int mx = 0;
        int index = 0;
        int[,] answer = default(int[,]);
        if (A.GetLength(0) != 7 || A.GetLength(1)!=5) return answer;
        for (int i = 0; i < 7; i++)
        {
            int s = 0;
            for (int j = 0; j<5; j++)
            {
                if (A[i, j] > 0) s += A[i, j];
            }
            if (s > mx)
            {
                mx = s;
                index = i;
            }
        }
        for(int i = index; i<6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A[i, j] = A[i+1,j];
            }
        }
        int[,] A1 = new int [6,5];
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A1[i,j] = A[i,j];
            }
        }

        // end

        return A1;
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
        int mn = 100000;
        int index = 0;
        int[,] answer = default(int[,]);
        if (A.GetLength(0) != 5|| A.GetLength(1)!=8 || B.Length != 5) return answer;
        for (int i = 0; i<7; i++)
        {
            if (A[4, i] < mn)
            {
                mn = A[4, i];
                index = i;
            }
        }
        Console.WriteLine(index);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 7; j>index+1; j--)
            {
                A[i, j] = A[i, j - 1];
                Console.Write(A[i,j]);
            }
            Console.WriteLine("");
        }

        for(int i = 0; i<5; i++)
        {
            A[i, index+1] = B[i];
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
        double[,] answer = default(double[,]);
        if (A.Length != 35) return answer;
        for (int i = 0; i<5; i++)
        {
            int index = 0;
            double mx = -100000;
            for (int j = 0; j<7; j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = j;
                }
            }
            if (index == 0) A[i, 1] *= 2;
            else if (index == 6) A[i, 5] *= 2;
            else
            {
                if (A[i, index - 1] < A[i, index + 1])
                {
                    if (A[i, index - 1]<0) A[i, index - 1] /= 2;
                    else A[i, index-1] *= 2;
                }
                else 
                {
                    if (A[i, index + 1] < 0) A[i, index + 1] /= 2;
                    else A[i, index + 1] *= 2;
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
        int[,] answer = default(int[,]);
        if (A.Length != 35) return answer;
        for (int j =0; j<5; j++)
        {
            int k_pol = 0;
            int k_otr = 0;
            int mx = -100000;
            int index = 0;
            for (int i = 0; i<7; i++)
            {
                if (A[i, j] < 0) k_otr++;
                else if (A[i, j] > 0) k_pol++;
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = i;
                }
            }
            Console.WriteLine(A[index,j]);
            if (k_pol > k_otr)
            {
                A[index, j] = 0;
            }
            else A[index, j] = index+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int[,] answer = default(int[,]);
        if (A.Length != 50) return answer;
        for (int j = 0; j<5; j++)
        {
            int mx = 0;
            int index = 0;
            int s = 0;
            for (int i = 0; i<10; i++)
            {
                s += A[i, j];
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = i;
                    s = 0;
                }
            }
            if (index < 5) A[0, j] = s;
            
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int[,] answer = default(int[,]);
        if (A.Length != 35 || B.Length!=5) return answer;
        for (int j = 0; j < 5; j++)
        {
            int mx = 0;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = i;
                }
            }
            Console.WriteLine(mx);
            if (A[index, j] < B[j]) A[index, j] = B[j];
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        double[,] answer = default(double[,]);
        if (A.Length != 35) return answer;
        for (int j = 0; j < 5; j++)
        {
            double mx = 0;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = i;
                }
            }
            double sr = (A[0, j] + A[6, j]) / 2;
            if (A[index,j]<sr) A[index,j] = sr;
            else A[index,j] = index+1;
            Console.WriteLine(mx);
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        int[,] answer = default(int[,]);
        if (n <= 0) return null;
        int[,] B = new int[n,n];
        for (int i =0; i<n; i++)
        {
            B[i, i] = 1;
        }
        int[,] C = new int[n, 3*n];
        for ( int i = 0; i<n; i++)
        {
            for (int j = 0; j<3*n; j++)
            {
                C[i, j] = B[i, j % n];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                Console.Write(C[i,j]);
            }
            Console.WriteLine();
        }

        // end

        return C;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.Length!=36) return null;
        int mx = 0;
        int index = 0;
        for (int i = 0; i<6; i++)
        {
            if (A[i,i] > mx)
            {
                mx = A[i,i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = i + 1; j < 6; j++)
            {
                //Console.Write(A[i,j]);
                A[i, j] = 0;
            }
            //Console.WriteLine("");
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(A[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.Length != 36) return null;
        int mx_1 = -10000;
        int index_1 = 0;
        int mx_2 = -10000;
        int index_2 = 0;
        for (int i = 0;i<6; i++)
        {
            for (int j=0; j<6; j++)
            {
                if (i%2==0 && B[i, j] > mx_1)
                {
                    mx_1 = B[i, j];
                    index_1 = j;
                }
                else if (i % 2 != 0 && B[i, j] > mx_2)
                {
                    mx_2 = B[i, j];
                    index_2 = j;
                }
            }
            if (i % 2 != 0)
            {
                int elem = B[i - 1, index_1];
                B[i - 1, index_1] = B[i, index_2];
                B[i, index_2] = elem;
                mx_1 = -10000;
                index_1 = 0;
                mx_2 = -10000;
                index_2 = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.Length != 42) return null;
        for (int i=0; i<6; i++)
        {
            for (int k = 0; k < 6; k++)
            {
                int elem = A[i, 6];
                for (int j = 6; j > k; j--)
                {
                    A[i, j] = A[i, j - 1];
                }
                A[i, k] = elem;
            }
        }
        for(int i=0; i < 6; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Console.Write(A[i,j]);
            }
            Console.WriteLine("");
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.Length != 35) return null;

        int[] min_elem = new int[7];
        int[] min_index = new int[7];


        for (int i = 0; i < 7; i++)
        {
            int mn = 100000000;
            min_index[i] = i;

            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < mn)
                {
                    mn = matrix[i, j];
                }
            }
            min_elem[i] = mn;
        }


        for (int i = 1; i < 7; i++)
        {
            int elem = min_elem[i];
            int index_elem = min_index[i];
            int j = i - 1;

            while (j >= 0 && min_elem[j] < elem)
            {
                min_elem[j + 1] = min_elem[j];
                min_index[j + 1] = min_index[j];
                j -= 1;
            }
            min_elem[j + 1] = elem;
            min_index[j + 1] = index_elem;
        }


        int[,] sort = new int[7, 5];
        for (int i = 0; i < 7; i++)
        {
            int row = min_index[i];
            for (int j = 0; j < 5; j++)
            {
                sort[i, j] = matrix[row, j];
            }
        }
        // end

        return sort;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[] answer = new int[2 * n - 1];
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int j = n;
        int k = 0;
        int count = 0;
        for (int i = 0; i< 2*n-1; i++)
        {
            if (j > 0)
            {
                j--;
                k = 0;
            }
            else
            {
                count++;
                k = count;
            }
            int s = 0;
            int f = j;
            int d = k;
            while (f < n && d < n)
            {
                s += matrix[f, d];
                f++;
                d++;
            }
            
            Console.WriteLine(s);
            answer[i] = s;
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
        int mx = -10000;
        int index_i = 0;
        int index_j = 0;
        int n = matrix.GetLength(0);
        if (matrix.GetLength(0) != matrix.GetLength(1) || k>n|| k<1) return null;
        for (int i = 0; i<n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i,j]) > mx)
                {
                    mx = Math.Abs(matrix[i,j]);
                    index_i = i;
                    index_j = j;
                }
            }
        }
        Console.WriteLine(mx);
        for (int i = 0; i<n; i++)
        {
            int elem = matrix[i,index_j];
            matrix[i, index_j] = matrix[i, k - 1];
            matrix[i, k - 1] = elem;
        }
        for (int j = 0; j < n; j++)
        {
            int elem = matrix[index_i, j];
            matrix[index_i, j] = matrix[k-1, j];
            matrix[k-1, j] = elem;
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
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                A1[i, j] = A[k];
                if (i != j) A1[j, i] = A1[i, j];
                B1[i, j] = B[k];
                if (i != j) B1[j, i] = B1[i, j];
                k++;
            }
        }
        answer = new int[n * n];
        k = 0;
        
        for (int i = 0; i < n; i++)
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
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0:d}", A1[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("    ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:d}", B1[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("    ");
        for (int i = 0; i < 2*n-1; i++)
        {
            Console.Write("{0:d}  ", answer[i]);
            
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        int c1 = 0;
        for (int k = 0; k < 7; k++)
        {
            for (int j = 0; j < 7; j++)
            {
                int c = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] < 0) c++;
                }
                if (j != 0 && c < c1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int elem = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = elem;
                    }
                }
                else c1 = c; 
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
        int[] answer = new int[n];
        int k = 0;
        for(int i =0; i<n; i++)
        {
            bool flag = true;
            for (int j = 0;j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = false; break; 
                }
            }
            if (flag) { answer[i] = 1; k++; }
            else answer[i] = 0;
        }
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine(answer[i]);
        }
        Console.WriteLine(k);
        int[,] matrix1 = new int[k,m];
        int c = 0;
        for (int i = 0; i<n; i++)
        {
            if (answer[i] == 1)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[c, j] = matrix[i, j];
                    Console.Write(matrix1[c,j]);
                }
                c++;
            }
        }
        Console.WriteLine(c);
        // end

        return matrix1;
    }
    #endregion
}