using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        //program.Task_1_1(new int[,] { { 111, 4}, { 7, 7}, { 99, 100} });

    }
    void WriteIntMatrix(int[,] matrix)
    {
        for (int i = 0; i<matrix.GetLength(0); i++)
        {
            for (int j = 0; j<matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    void WriteDoubleMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],5} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    #region Level 1   
    public int Task_1_1(int[,] A)   //2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32
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
        WriteIntMatrix(A);
        int n = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        for (int i = 0; i<5; i++)
        {
            for (int j = 0;j<7; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    n++;
                }
            }
        }
        
        answer /= n;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0, 0);
        WriteIntMatrix(A);
        for (int i = 0; i<5; i++)
        {
            if (A[i, colIndex] < 0){
                value = A[i, colIndex];
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
        double[] answer = default(double[]);
        // code here
        WriteIntMatrix(A);
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return answer;
        answer = new double[A.GetLength(0)];
        for (int i = 0;i<4; i++)
        {
            int s = 0, n = 0;
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] > 0){
                    n++;
                    s += A[i, j];
                }
            }
            if (n == 0)
            {
                answer[i] = 0;
                continue;
            }
            answer[i] = (double)s / n;
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
        WriteIntMatrix(A);
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int minind = 0;
        for (int i = 1; i<5; i++)
        {
            if (A[i, 0] < A[minind, 0]) minind = i;
        }
        int[,] B = new int[4, 7];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i < minind) B[i, j] = A[i, j];
                else B[i, j] = A[i + 1, j];
            }
        }
        A = B;
        WriteIntMatrix(A);
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
        int[] answer = default(int[]);
        // code here
        WriteIntMatrix(A);
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return answer;
        answer = new int[3];
        for (int j = 0; j<3; j++)
        {
            int n = 0;
            for (int i = 0; i<4; i++)
            {
                if (A[i, j] < 0) n++;
            }
            answer[j] = n;
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
        WriteIntMatrix(B);
        for (int i = 0; i<n; i++)
        {
            int minind = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] < B[i, minind]) minind = j;
            }
            int temp = B[i, minind];
            for (int k = minind; k>0; k--)
            {
                B[i, k] = B[i, k - 1];
            }
            B[i, 0] = temp;
        }
        WriteIntMatrix(B);
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
        WriteDoubleMatrix(F);
        for (int i = 0; i<n; i++)
        {
            int maxind = 0;
            int otr1 = -1;
            int otr2 = -1;
            for (int j = 0; j<m; j++)
            {
                if (F[i, j] > F[i, maxind]) maxind = j;
                if (F[i, j] < 0)
                {
                    otr2 = j;
                    if (otr1 == -1) otr1 = j;
                }
            }
            if (otr1 == -1) continue;
            F[i, maxind] = (F[i, otr1] + F[i, otr2]) / 2;
        }
        WriteDoubleMatrix(F);
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        WriteIntMatrix(G);
        for (int i = 0; i<5; i++)
        {
            int indmax = 0;
            for (int j = 1; j < 6; j++)
            {
                if (G[i, j] > G[i, indmax]) indmax = j;
            }
            for (int j = 6; j>indmax; j--)
            {
                G[i, j] = G[i, j - 1];
            }
        }
        WriteIntMatrix(G);
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
        if ((A.GetLength(0) != 5 || A.GetLength(1) != 7) || B.Length!=7) return null;
        WriteIntMatrix(A);
        int indmax = 0;
        for (int i = 1; i<5; i++)
        {
            if (A[i, 5] > A[indmax, 5]) indmax = i;
        }
        for (int j = 0; j<7; j++)
        {
            A[indmax, j] = B[j];
        }
        WriteIntMatrix(A);
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        WriteIntMatrix(F);
        int[,] A = new int[5, 6];
        int minind = 0;
        for (int j = 1; j<7; j++)
        {
            if (Math.Abs(F[1, j]) < Math.Abs(F[1, minind])) minind = j;
        }
        if (minind == 6) return F;
        for (int  j = 0; j<6; j++)
        {
            for (int i = 0; i<5; i++)
            {
                if (j <= minind) A[i, j] = F[i, j];
                else A[i, j] = F[i, j + 1];
            }
        }
        F = A;
        WriteIntMatrix(F);

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        WriteDoubleMatrix(A);
        for (int i = 0; i<5; i++)
        {
            int indmax = 0, n=0;
            double s = 0;
            for (int j = 0; j<7; j++)
            {
                if (A[i, j] > A[i, indmax]) indmax = j;
                if (A[i, j] > 0)
                {
                    n++;
                    s += A[i, j];
                }
            }
            if (n == 0) A[i, indmax] = 0;
            else A[i, indmax] = s / n;
        }
        WriteDoubleMatrix(A);
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
        WriteDoubleMatrix(A);
        for (int i = 0; i<5; i++)
        {
            int indmax = 0;
            for (int j = 1;j<7; j++)
            {
                if (A[i, j]>A[i, indmax])indmax = j;
            }
            if (indmax == 0) A[i, 1] *= 2;
            else if (indmax == 6) A[i, 5] *= 2;
            else
            {
                if (A[i, indmax - 1] < A[i, indmax + 1])
                {
                    if (A[i, indmax - 1] > 0) A[i, indmax - 1] *= 2;
                    else A[i, indmax - 1] /= 2;
                }
                else
                {
                    if (A[i, indmax + 1] > 0) A[i, indmax + 1] *= 2;
                    else A[i, indmax + 1] /= 2;
                }
            }
        }
        WriteDoubleMatrix(A);
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        WriteIntMatrix(A);
        for (int j = 0; j<5; j++)
        {
            int colpol = 0, colotr = 0, indmax = 0;
            for (int i = 0; i<7; i++)
            {
                int a = A[i, j];
                if (a > 0) colpol++;
                else if (a < 0) colotr++;
                if (a > A[indmax, j]) indmax = i;
            }
            if (colpol > colotr) A[indmax, j] = 0;
            else A[indmax, j] = indmax+1;
            
        }
        WriteIntMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        WriteIntMatrix(A);
        for (int j = 0;j<5; j++)
        {
            int indmax = 0, sum=0;
            for (int i = 1; i<10; i++)
            {
                if (A[i, j] > A[indmax, j])
                {
                    indmax = i; sum = 0;
                }
                else sum += A[i, j];
            }
            if (indmax<5) A[0, j] = sum;
        }
        WriteIntMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length !=5) return null;
        WriteIntMatrix(A);
        for (int j = 0; j<5; j++)
        {
            int indmax = 0;
            for (int i = 1; i<7; i++)
            {
                if (A[i, j] > A[indmax, j]) indmax = i;
            }
            if (B[j] > A[indmax, j]) A[indmax, j] = B[j];
        }
        WriteIntMatrix(A);
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        WriteDoubleMatrix(A);
        for (int j = 0; j<5; j++)
        {
            double s = (A[0, j]+A[6, j])/2;
            int indmax = 0;
            for (int i = 1; i<7; i++)
            {
                if (A[i, j]> A[indmax, j])indmax = i;
            }
            if (A[indmax, j] < s) A[indmax, j] = s; else A[indmax, j] = indmax + 1;
        }
        WriteDoubleMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 1) return answer;
        answer = new int[n, 3*n];
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i == j % n) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        }
        WriteIntMatrix(answer);
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        WriteIntMatrix(A);
        int indmax = 0;
        for (int i = 1; i<6; i++)
        {
            if (A[i, i] > A[indmax, indmax]) indmax = i;
        }
        for (int i = 0; i<indmax; i++)
        {
            for (int j = i+1; j<6; j++)
            {
                A[i, j] = 0;
            }
        }
        WriteIntMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        WriteIntMatrix(B);
        int ind1=0, ind2=0;
        for (int i = 0; i<6; i++)
        {
            if (i % 2 == 0)
            {
                ind1 = 0;
                ind2 = 0;
                for (int j = 0; j<6; j++)
                {
                    if (B[i, j] > B[i, ind1]) ind1 = j;
                }
            }
            else
            {
                for (int j = 0; j < 6; j++)
                {
                    if (B[i, j] > B[i, ind2]) ind2 = j;
                }
                int temp = B[i-1, ind1];
                B[i - 1, ind1] = B[i, ind2];
                B[i, ind2] = temp;
            }
        }
        WriteIntMatrix(B);
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        WriteIntMatrix(A);
        for (int i = 0;i<6; i++)
        {
            for (int j = 0; j<3; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 7 - 1 - j];
                A[i, 7 - 1 - j] = temp;
            }
        }
        WriteIntMatrix(A);
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        WriteIntMatrix(matrix);
        int n = matrix.GetLength(0);
        for (int i = 0; i<n; i++)
        {
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
            matrix[0, i] = 0;
            matrix[n - 1, i] = 0;

        }
        WriteIntMatrix(matrix);
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
        WriteIntMatrix(matrix);
        int n = matrix.GetLength(0);
        for (int i = n/2;i<n; i++)
        {
            for (int j = 0; j<i; j++)
            {
                matrix[i, j] = 1;
            }
            if (n % 2 == 1) matrix[i, i] = 1;
        }
        WriteIntMatrix(matrix);
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1)) return (null, null);
        int s = 0, a = 1 ;
        while (a <= n)
        {
            s += a;
            a++;
        }
        upper = new int[s];
        lower = new int[n * n - s];
        for (int i = 0, u=0, l=0; i<n; i++)
        {
            for (int j = 0; j<n; j++)
            {
                if (j >= i)
                {
                    upper[u]= matrix[i, j];
                    u++;
                }
                else
                {
                    lower[l] = matrix[i, j];
                    l++;
                }
            }
        }
        //вывод треугольников по строкам
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<n; j++)
            {
                if (j >= i)
                {
                    Console.Write($"{matrix[i, j], 3} ");
                    
                }
                else
                {
                    Console.Write("    ");
                }
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j<i)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                else
                {
                    Console.Write("    ");
                }
            }
            Console.WriteLine();
        }

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
        WriteIntMatrix(matrix);
        int[] count = new int[7];
        int n = matrix.GetLength(0);
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<5; j++)
            {
                if (matrix[i, j] > 0) count[i]++;
            }
            int ii = i;
            while (ii!=0 && count[ii] > count[ii - 1])
            {
                for (int j = 0; j<5; j++)
                {
                    int temp = matrix[ii, j];
                    matrix[ii, j] = matrix[ii - 1, j];
                    matrix[ii-1, j] = temp;

                }
                int temp2=count[ii];
                count[ii] = count[ii - 1];
                count[ii - 1] = temp2;
                ii--;
            }
        }
        WriteIntMatrix(matrix);

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
        WriteIntMatrix(matrix);
        for (int i = 0; i<matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < matrix.GetLength(1);j++)
                {
                    int key = matrix[i,j];
                    int jj = j;
                    while(jj>0 &&key > matrix[i, jj - 1])
                    {
                        matrix[i, jj] = matrix[i, jj - 1];
                        jj--;
                    }
                    matrix[i, jj] = key;
                }
            }
            else
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int jj = j;
                    while (jj > 0 && key < matrix[i, jj - 1])
                    {
                        matrix[i, jj] = matrix[i, jj - 1];
                        jj--;
                    }
                    matrix[i, jj] = key;
                }
            }
        }
        WriteIntMatrix(matrix);
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        WriteIntMatrix(matrix);
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int count = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j< m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, 0] = 0;
                    count++;
                    break;
                }
            }
        }
        int[,] B = new int[n - count, m];
        for (int i = 0, ii = 0; i < n; i++, ii++) { 
            if (matrix[i, 0] == 0)
            {
                ii--;
                continue;
            }
            for (int j = 0;j<m; j++)
            {
                B[ii, j] = matrix[i, j];
            }
        }
        matrix = B;
        WriteIntMatrix(matrix);
        // end

        return matrix;
    }
    #endregion
}