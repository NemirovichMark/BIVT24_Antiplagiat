using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        program.Task_1_12(new int[,] {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 }
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
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int s = 0;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows * cols != 16) { return 0; }
        for(int i = 0; i < 4; i++)
        {
            s += A[i, i];
        }
        answer = s;
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
        int k = 0;
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        answer = new int[rows];
        if (rows != 4 || cols != 7)  return default; 
        else
        {
            for (int i = 0; i < rows; i++)
            {
                int min = A[i, 0];
                int index = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        index = j;
                    }
                }
                answer[k] = index;
                k++;
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
        int rows = A.GetLength (0);
        int cols = A.GetLength (1);
        if(rows != 5 || cols != 7) { return default; }
        for(int i = 0; i < rows; i++)
        {
            int p = A[i, 0];
            int mx = A[i, 0];
            int index = 0;
            for(int j = 0; j <  cols; j++)
            {
                if(A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = j;
                }

            }
            A[i, 0] = A[i, index];
            A[i, index] = p;
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
        int[,] B = new int[5, 7];
        int[,] C = new int[5, 6];
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 6 || cols != 7) { return default; }
        int max = A[0, 0];
        int iindex = 0, jindex = 0;
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    iindex = i;
                    jindex = j;
                }
            }
        }


        for(int i = 0; i < rows-1; i++)
        {
            if(i < iindex)
            {
                for(int j = 0; j < cols; j++)
                {
                    B[i, j] = A[i, j];
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

        for (int j = 0; j < 7 - 1; j++)
        {
            if (j < jindex)
            {
                for (int i = 0; i < 5; i++)
                {
                    C[i, j] = B[i, j];
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    C[i, j] = B[i, j+1];
                }
            }
        }

        A = C;

        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < 6; j++)
                Console.Write("{0}", C[i, j]);
            Console.WriteLine();
        }
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7) { return default; }
        for(int i = 0; i < rows; i++)
        {
            int max = A[i, 0];
            int jindex = 0;
            for(int j = 0; j < cols; j++)
            {
                if(A[i, j] > max)
                {
                    max = A[i, j];
                    jindex = j;
                }    
            }
            A[i, jindex] = A[i, jindex]*(i+1);
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
        for(int i = 0; i < n; i++)
        {
            int k = 0;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    k++;
                }
            }
            if (k > 0 && k != D.Length)
            {
                int otrperv = -1;
                for (int j = 0; j < m; j++)
                {
                    if (D[i, j] < 0)
                    {
                        otrperv = j;
                        break;
                    }
                }

                int otrposl = -1;
                for (int j = m - 1; j > 0; j--)
                {
                    if (D[i, j] < 0)
                    {
                        otrposl = j;
                        break;
                    }
                }

                if (otrperv != 0)
                {
                    int max = D[i, 0];
                    int jindex = 0;
                    for (int j = 0; j < otrperv; j++)
                    {
                        if (D[i, j] > max)
                        {
                            max = D[i, j];
                            jindex = j;
                        }
                    }
                    int temp = D[i, jindex];
                    D[i, jindex] = D[i, otrposl];
                    D[i, otrposl] = temp;
                }
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
        int rows = H.GetLength(0);
        int cols = H.GetLength(1);
        int[] a = new int[5];
        int k = 0;
        if (rows != 5 || cols != 7) return default;
        for(int i = 0; i < rows; i++)
        {
            int max = H[i, 0];
            int jindex = 0;
            for(int j = 0; j < cols; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                    jindex = j;
                }
            }
            a[k] = max;
            k++;
        }


        int l = 0;
        for (int i = 0; i < rows; i++)
        {
            H[i, 6] = H[i, 5];
            H[i, 5] = a[l];
            l++;
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
        int rows = Y.GetLength(0);
        int cols = Y.GetLength(1);
        if (rows != 6 || cols != 5) { return default; }
        for(int i = 0; i < rows; i++)
        {
            double max = Y[i, 0];
            int jmax = 0;
            for(int j = 0; j < cols; j++)
            {
                if(Y[i, j] > max)
                {
                    max = Y[i, j];
                    jmax = j;
                }
            }
            if(jmax == cols - 1)
            {
                for (int j = 0; j < jmax; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = 0;
                    }
                }
            }
            if (jmax != cols - 1 && jmax != 0)
            {
                double s = 0;
                int k = 0;
                for (int j = jmax + 1; j < cols; j++)
                {
                    if (Y[i, j] > 0)
                    {
                        s += Y[i, j];
                        k++;
                    }
                }
                double sr = 0;
                if (k > 0) { sr = s / k; }
                
                if (k != cols)
                {
                    for (int j = 0; j < jmax; j++)
                    {
                        if (Y[i, j] < 0)
                        {
                            Y[i, j] = sr;
                        }
                    }
                }
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7 || B.Length != 7) { return default; }
        int max = A[0, 5];
        int iindex = 0;
        for(int i= 0; i < rows; i++)
        {
            if (A[i,5] > max)
            {
                max = A[i, 5];
                iindex = i;
            }
        }

        int k = 0;
        for (int j = 0; j < cols; j++)
        {
            A[iindex, j] = B[k];
            k++;
        }
        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);
        if (rows != 5 || cols != 7) { return default; }

        int[] m = new int[5];
        int k = 0;
        for(int i = 0; i < rows; i++)
        {
            int max = B[i, 0];
            for(int j = 0; j < cols; j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            m[k] = max;
            k++;
        }

        for(int g = 0; g < m.Length/2; g++)
        {
            int temp = m[g];
            m[g] = m[m.Length - g - 1];
            m[m.Length - g - 1] = temp;
        }


        for(int i = 0; i < rows; i++)
        {
            B[i, 3] = m[i];
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
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);
        if (rows * cols != 25) { return default; }

        int max = B[0, 0];
        int iindex1 = 0;
        for(int i = 0; i < rows; i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                iindex1 = i;
            }
        }

        int iindex2 = -1;
        for(int i = 0; i < cols; i++)
        {
            int jindex = 0;
            for(int j = 0; j < rows; j++)
            {
                if(B[i, j] < 0)
                {
                    jindex = j;
                    break;
                }
            }
            if(jindex == 2)
            {
                iindex2 = i;
                break;
            }
        }

        Console.WriteLine(iindex1);
        Console.WriteLine(iindex2);

        for (int j = 0; j < cols; j ++)
        {
            int temp = B[iindex1, j];
            B[iindex1, j] = B[iindex2, j];
            B[iindex2, j] = temp;
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7) { return default; }

        int k = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (A[i, j] < 0)
                {
                    k += 1;
                }
            }
        }
        if (k != 0)
        {

            int[] b = new int[k];
            int n = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i, j] < 0)
                    {
                        b[n] = A[i, j];
                        n++;
                    }
                }
            }
            answer = b;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7) { return default; }
        for(int i = 0; i < rows; i++)
        {
            double max = A[i, 0];
            int jmax = 0;
            for(int j = 0; j < cols; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            if(jmax != 0 && jmax != cols-1)
            {
                if (A[i, jmax - 1] < A[i, jmax + 1])
                {
                    if (A[i, jmax - 1] >= 0)
                    {
                        A[i, jmax - 1] = A[i, jmax - 1] * 2;
                    }
                    else
                    {
                        A[i, jmax - 1] = A[i, jmax - 1] / 2;
                    }
                }
                else
                {
                    if (A[i, jmax + 1] >= 0)
                    {
                        A[i, jmax + 1] = A[i, jmax + 1] * 2;
                    }
                    else
                    {
                        A[i, jmax + 1] = A[i, jmax + 1] / 2;
                    }
                }
            }
            else if(jmax == 0)
            {
                A[i, jmax + 1] = A[i, jmax + 1] * 2;
            }
            else
            {
                A[i, jmax - 1] = A[i, jmax - 1] * 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        for(int j = 0; j < cols; j++)
        {
            int kp = 0;
            int ko = 0;
            int max = A[0, j];
            int imax = 0;
            for(int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
                if(A[i, j] > 0)
                {
                    kp++;
                }
                if(A[i, j] < 0)
                {
                    ko++;
                }
            }
            if(kp > ko)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 10 || cols != 5) { return default; }
        for(int j = 0; j < cols; j++)
        {
            int max = A[0, j];
            int imax = 0;
            for(int i = 0; i < rows; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if(imax < rows/2)
            {
                int s = 0;
                for(int i = imax+1; i < rows; i++)
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int k = 0;
        if (rows != 7 || cols != 5 || B.Length != 5) { return default; }
        for(int j = 0; j < cols; j++)
        {
            int max = A[0, j];
            int imax = 0;
            for(int i = 0; i < rows; i++)
            {
                if(A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (B[k] > A[imax, j])
            {
                A[imax, j] = B[k];
                k++;
            }

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) { return default; }
        for(int j = 0; j < cols; j++)
        {
            double max = A[0, j];
            int imax = 0;
            double ps = (A[0, j] + A[rows - 1, j]) / 2;
            for (int i = 0; i< rows; i++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if(max < ps)
            {
                A[imax, j] = ps;
            }
            else
            {
                A[imax, j] = imax;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) { return default; }
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }

        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = k; j < 3 * n; j+=3)
            {
                answer[i, j] = 1;
            }
            k++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows * cols != 36) { return default; }
        int max = A[0, 0];
        int imax = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (j == i && A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
        }
        
        for(int i = 0; i < imax; i++)
        {
            for(int j = 0; j < cols; j++)
            { 
                if(j > i)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);
        if (rows != 6 || cols != 6) { return default; }
        for (int i = 0; i < rows; i+=2)
        {
            int max1 = B[i, 0];
            int jmax1 = 0;
            for(int j = 0; j < cols; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    jmax1 = j;
                }
            }

            int max2 = B[i+1, 0];
            int jmax2 = 0;
            for (int j = 0; j < cols; j++)
            {
                if (B[i+1, j] > max2)
                {
                    max2 = B[i+1, j];
                    jmax2 = j;
                }
            }

            int temp = B[i, jmax1];
            B[i, jmax1] = B[i + 1, jmax2];
            B[i+1, jmax2] = temp;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
                Console.Write($"{B[i, j]} ");
            Console.WriteLine();
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 6 || cols != 7) { return default; }
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols/2; j++)
            {
                int temp = A[i,j];
                A[i, j] = A[i, cols - j - 1];
                A[i, cols - j - 1] = temp;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
                Console.Write("{0}", A[i, j]);
            Console.WriteLine();
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        for (int i = 0; i < rows; i++)
        {
            if (i == 0 || i == rows - 1)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            else
            {
                matrix[i, 0] = 0;
                matrix[i, cols - 1] = 0;
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        for (int i = rows/2; i < rows; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                matrix[i, j] = 1;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write("{0}", matrix[i, j]);
            Console.WriteLine();
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols) { return default; }
        int up = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = i; j < cols; j++)
            {
                up++;
            }
        }
        int down = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                down++;
            }
        }

        upper = new int[up];
        lower = new int[down];

        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < cols; j++)
            {
                upper[k] = matrix[i, j];
                k++;
            }
        }
        int m = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[m] = matrix[i, j];
                m++;
            }
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return default;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - i - 1; j++)
            {
                int current = 0, next = 0;
                for (int k = 0; k < cols; k++)
                {
                    if (matrix[j, k] > 0)
                    { 
                        current++; 
                    }
                    if (matrix[j + 1, k] > 0)
                    { 
                        next++; 
                    }

                }
                if (current < next)
                {
                    int[] temp = new int[cols];
                    for (int k = 0; k < cols; k++)
                    {
                        temp[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp[k];
                    }
                }
            }
        }
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i ++)
        { 
            for(int j = 0; j < cols - 1; j++)
            {
                for(int k = 0; k < cols - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write("{0}", matrix[i, j]);
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int count = 0;
        for (int i = 0; i < rows; i++)
        {

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] A = new int[rows - count, cols];
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0) break;
                A[k, j] = matrix[i, j];
            }
            k++;
            if (k >= rows - count) break;
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}