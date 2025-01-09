using System.Collections.Generic;
using System.ComponentModel;
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
        int s = 0, n = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if (A [i, j] > 0)
                {
                    answer += A [i, j];
                    n ++;
                }
                if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
                return 0;
                if (n == 0)
                return 0;
            }
        }
        answer = answer / n * 1.0;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A [i , colIndex] < 0)
            {
                value = A [i , colIndex];
                rowIndex = i;
                break;
            }
            if (rowIndex < 0)
                rowIndex = 0;
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
        answer = new double [A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int n = 0;
            double s = 0;
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i,j] > 0)
                {
                    s += A[i,j];
                    n ++;
                }
            }
            if (n != 0)
                answer[i] = s / n;
            else
                answer[i] = 0;
        }
        if (A.GetLength(0) != 4 && A.GetLength(1) != 6)
            return default(double[]);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return default(int [,]);
        int index = -1, min = A[0,0], k = 4;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (min > A[i, 0])
            {
                min = A[i, 0];
                index = i;
            }
        }
        int[,] B = new int [k, 7];
        if(index != -1)
        {
            for (int i = 0; i < k; i ++)
            {
                if (i < index) 
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A [i, j];
                    }
                }
                else 
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A [i + 1, j];
                    }
                }
            }
        }
        else 
            return default(int[,]);
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
        int[] answer = default(int[]);
        // code here
        int k = 0; // количество элементов массива
        answer = new int [A.GetLength(1)];
        int b = 0; // индекс массива
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }
            answer [b] = k;
            b ++;
            k = 0;
        }
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3 || k < 0 || b < 0)
            return default(int[ ]);

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
        // code here // индекс мин элемента
        for (int i = 0; i < n; i ++)
        {
            int min = 0;
            int index = 0;
            for (int j = 1; j < m; j ++)
            {
                if (B [i, j] < index)
                {
                    min = B [i,j];
                    index = j;
                }
            }
            int mini = B[i, index];
            for (int j = index; j > 0; j --)
            {
                B[i, j] = B [i, j - 1];
            }
            B [i, 0] = mini;
        }
        if (n < 0 || m < 0 || B.GetLength(0) != n || B.GetLength(1) != m )
            return default(int[,]);
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
        n = F.GetLength(0);
        m = F.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            double maxelem = -1000; 
            int maxIndex = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxelem)
                {
                    maxelem = F[i, j];
                    maxIndex = j; 
                }
            }
            double oneotr = 0, twootr = 0;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    oneotr = F[i, j];
                    break;
                }
            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    twootr = F[i, j];
                    break;
                }
            }
            double sum = 0;
            if (oneotr != 0 && twootr != 0)
            {
                sum = (oneotr + twootr) / 2;
            }
            if (maxIndex != -1 && sum != 0) 
            {
                F[i, maxIndex] = sum; 
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return default(int[,]);
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int max = G[i, 0];
            int jmax = 0;
            for(int j = 0; j < G.GetLength(1); j++)
            {
                if (max < G[i,j])
                {
                    max = G[i, j];
                    jmax = j;
                }
            }
            for (int j = G.GetLength(1) - 1; j > jmax; j--)
            {
                G[i, j] = G[i, j - 1];
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
            return default(int[,]);
        int max = A[0, 5];;
        int imax = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (max < A[i, 5])
            {
                max = A[i, 5];
                imax = i;
            }
        }        
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[imax, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return default(int[,]);
        int min = F[1, 0];
        int jmin = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(min) > Math.Abs(F[1, j]))
            {
                min = F[1, j];
                jmin = j;
            }
        }
        jmin += 1;
        int[,] A = new int [5, 6];
        for (int j = 0; j < jmin; j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, j] = F[i, j];
            }
        }
        for (int j = jmin; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, j] = F[i, j + 1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int jmax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            double sum = 0;
            int jsum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    jsum ++;
                }
            }
            if (sum != 0)
                sum = sum / jsum;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j == jmax)
                {
                    A[i, j] = sum;
                }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int jjmax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    jjmax = j;
                }
            }
            int jmax = jjmax - 1;
            int jjjmax = jjmax + 1;
            if(jmax == -1)
            {
                if (A[i, jjjmax] >= 0)
                A[i, jjjmax] *= 2;
                else
                A[i, jjjmax] /= 2;
            }
            else if (jjjmax == A.GetLength(1))
            {
                if (A[i, jmax] >= 0)
                A[i, jmax] *= 2;
                else
                A[i, jmax] /= 2;
            }
            else if (A[i, jmax] < A[i, jjjmax])
            {
                if (A[i, jmax] >= 0)
                A[i, jmax] *= 2;
                else
                A[i, jmax] /= 2;
            }
            else
            {
                if (A[i, jjjmax] >= 0)
                A[i, jjjmax] *= 2;
                else
                A[i, jjjmax] /= 2;
            }
        } 
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int imax = 0;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            int pol = 0;
            int ot = 0;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                    pol ++;
                else
                    ot ++;
            }
            if (pol > ot)
                A[imax, j] = 0;
            else 
                A[imax, j] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return default (int[,]);
        for(int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (imax <= A.GetLength(0) / 2)
            {
                int sum = 0;
                for(int i = imax + 1; i < A.GetLength(0); i ++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
            else
                return A;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return default (int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (B[j] > max)
            {
                A[imax, j] = B[j];
            }
            else
                return A;
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return default (double[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = A[0, j];
            int imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            double sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (sum > max)
            {
                A[imax, j] = sum;
            }
            else
            {
                A[imax, j] = imax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3)
            return answer;
        answer = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    answer[i, j] = 1;
                else
                    answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return default (int[,]);
        int max = A[0, 0];
        int imax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (max < A[i, i])
                {
                    max = A[i, i];
                    imax = i;
                }
        }
        for (int i = 0; i < imax; i ++)
        {
            for (int j = i + 1; j < A.GetLength(1); j ++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return default (int[,]);
        int max = B[0, 0];
        int jmax = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max < B[0, j])
            {
                max = B[0, j];
                jmax = j;
            }
        }
        int max2 = B[1, 0];
        int jmax2 = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max2 < B[1, j])
            {
                max2 = B[1, j];
                jmax2 = j;
            }
        }
        int p = B[0, jmax];
        B[0, jmax] = B[1, jmax2];
        B[1, jmax2] = p;
        int max3 = B[2, 0];
        int jmax3 = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max3 < B[2, j])
            {
                max3 = B[2, j];
                jmax3 = j;
            }
        }
        int max4 = B[3, 0];
        int jmax4 = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max4 < B[3, j])
            {
                max4 = B[3, j];
                jmax4 = j;
            }
        }
        p = B[2, jmax3];
        B[2, jmax3] = B[3, jmax4];
        B[3, jmax4] = p;
        int max5 = B[4, 0];
        int jmax5 = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max5 < B[4, j])
            {
                max5 = B[4, j];
                jmax5 = j;
            }
        }
        int max6 = B[5, 0];
        int jmax6 = 0;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            if (max6 < B[5, j])
            {
                max6 = B[5, j];
                jmax6 = j;
            }
        }
        p = B[4, jmax5];
        B[4, jmax5] = B[5, jmax6];
        B[5, jmax6] = p;
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return default (int[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int[] B = new int [7];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[j] = A[i, j];
            }
            int n = 1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = B [B.Length - n];
                n ++;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return default (int[,]);
        int[] array = new int [7];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(min > matrix[i, j])
                {
                    min = matrix[i, j];
                }
            }
            array[i] = min;
        } 
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[i + 1])
                {
                    temp = array[i];
                    array[i] = array [i + 1];
                    array[i + 1] = temp;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        int n = matrix.GetLength(0);
       for (int j = 0; j < n; j++)
       {
            matrix[0, j] = 0;
            matrix[j, 0] = 0;
            matrix[n - 1, j] = 0;
            matrix[j, n - 1] = 0;
            if (n < 0)
                break;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= n / 2 && i >= j)
                {
                    matrix[i,j] = 1;
                }
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);
        int n = matrix.GetLength(0);
        int upperrange = (n * n) / 2 + (n / 2);
        upper = new int[upperrange];
        lower = new int[n * n - upperrange];
        int m = 0;
        for(int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                upper[m++] = matrix[i, j];
            }
        }
        int d = 0;
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[d++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 && (matrix.GetLength(1) != 5))
            return default(int[,]);

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] pol = new int[n];
        for(int i = 0; i < n; i++)
        {
            int kol = 0;
            for(int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                {
                    kol++;
                }
            }
            pol[i] = kol;
        }

        int max = pol[0], maxi = 0;
        for (int i = 0; i < n; i++)
        {
            if (pol[i] > max)
            {
                max = pol[i];
                maxi = i;
            }
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (pol[j] < pol[j + 1])
                {
                    for (int k = 0; k < m; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int temp2 = pol[j];
                    pol[j] = pol[j + 1];
                    pol[j + 1] = temp2;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m - 1; j++)
            {
                for(int k = 0; k < m - j - 1; k++)
                {
                    if(i % 2 == 0)
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
                            int temp2 = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp2;
                        }
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k0 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k0++;
                    break;
                }
            }
        }
        int[,] matrix2 = new int[n - k0, m];
        int i2 = 0;
        for (int i = 0; i < n; i++)
        {
            bool proverka0 = false;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    proverka0 = true;
                    break;
                }
            }
            if (proverka0 == false)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix2[i2, j] = matrix[i, j];
                }
                i2++;
            }
        }
        return matrix2;
        // end

        return matrix;
    }
    #endregion
}