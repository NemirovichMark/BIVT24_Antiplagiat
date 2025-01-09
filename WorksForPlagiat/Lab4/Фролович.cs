using System;
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
        for (int i = 0; i < A.GetLength(0); i++)
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
        int counter = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);

            }
            Console.WriteLine();
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    counter++;
                    answer += A[i, j];
                }
            }
        }
        answer = answer / counter;
        if (counter <= 0)
        {
            answer = 0;
        }
        Console.WriteLine(answer);
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
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
            }
        }
        if (value == 0 && rowIndex == -1)
        {
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
        if (A.GetLength(0) != 4 && (A.GetLength(1) != 6))
        {
            return default(double[]);

        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);

            }
            Console.WriteLine();
        }
        answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int counter = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    counter++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(counter);
            sum = sum / counter;
            if (counter > 0)
            {
                answer[i] = sum;
            }
            else
            {
                answer[i] = 0;
            }
            Console.WriteLine(answer[i]);
        }
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
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
        double minn = double.MaxValue;
        int stringg = -1;
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
        {
            return default(int[,]);

        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }

        for (int i = A.GetLength(0) - 1; i >= 0; i--)
        {
            if (A[i, 0] < 0)
            {
                minn = A[i, 0];
                stringg = i;
            }
        }

        Console.WriteLine(stringg);
        Console.WriteLine(minn);
        Console.WriteLine(A.GetLength(0) - 1);

        if (stringg != -1)
        {
            int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < stringg; i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = A[i, j];
                }
            }
            for (int i = stringg; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = A[i + 1, j];
                }
            }
            A = answer;
        }

        else
        {
            int[,] answer = new int[A.GetLength(0), A.GetLength(1)];
            stringg = 0;
            A = answer;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
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
            if (A.GetLength(0) != 4 && (A.GetLength(1) != 3))
            {
                return default(int[]);

            }
            answer = new int[A.GetLength(1)];
            Console.WriteLine(A.GetLength(1));
            for (int i = 0; i < A.GetLength(1); i++)
            {
                int counter = 0;
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    if (A[j, i] < 0)
                    {
                        counter++;
                    }
                }
                answer[i] = counter;
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
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            int bmin = B[i, 0];
            int min = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < bmin)
                {
                    bmin = B[i, j];
                    min = j;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(bmin);

            int num = B[i, min];
            for (int k = min; k > 0; k--)
            {
                B[i, k] = B[i, k - 1];
                Console.Write("{0:d} ", B[i, k]);
            }
            Console.WriteLine();
            B[i, 0] = num;

            for (int k = 0; k < m; k++)
            {
                Console.Write("{0:d} ", B[i, k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
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
        for (int i = 0; i < n; i++)
        {
            double first_neg = 1;
            double last_neg = 1;
            double max = double.MinValue;
            int maxindex = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    maxindex = j;
                }
                if (F[i, j] < 0)
                {
                    last_neg = F[i, j];
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    first_neg = F[i, j];
                    break;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(first_neg);
            Console.WriteLine(last_neg);
            if (first_neg < 0 && last_neg < 0)
            {
                double halfsum = (first_neg + last_neg) / 2;
                F[i, maxindex] = halfsum;
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
        for (int i = 0; i < G.GetLength(0); i++)
        {
            for (int j = 0; j < G.GetLength(1); j++)
            {
                Console.Write("{0:d} ", G[i, j]);
            }
            Console.WriteLine();
        }
        if (G.GetLength(0) != 5 && (G.GetLength(1) != 7))
        {
            return default(int[,]);
        }
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int max = -999999999;
            int maxindex = -1;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    maxindex = j;
                }
            }
            Console.WriteLine(maxindex);
            int num = G[i, maxindex + 1];
            for (int j = G.GetLength(1) - 1; j > maxindex + 1; j--)
            {
                G[i, j] = G[i, j - 1];
            }
            G[i, maxindex + 1] = max;
        }
        Console.WriteLine();
        for (int i = 0; i < G.GetLength(0); i++)
        {
            for (int j = 0; j < G.GetLength(1); j++)
            {
                Console.Write("{0:d} ", G[i, j]);
            }
            Console.WriteLine();
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
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
        {
            return default(int[,]);
        }
        if (B.Length != 7)
        {
            return default(int[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write("{0:d} ", B[i]);
        }
        Console.WriteLine();
        int max = -99999999;
        int indexmax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                indexmax = i;
            }
        }
        Console.WriteLine(indexmax);
        Console.WriteLine(A.GetLength(1));
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[indexmax, j] = B[j];
        }
        //for (int i = 0; i < A.GetLength(1); i++)
        //{
        //    A[indexmax, i] = B[i];
        //    Console.WriteLine(A[indexmax,i]);
        //}


        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine(A.GetLength(0));
        Console.WriteLine(A.GetLength(1));
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
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                Console.Write("{0:d} ", F[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if (F.GetLength(0) != 5 && (F.GetLength(1) != 7))
        {
            return default(int[,]);
        }
        int min = int.MaxValue;
        int minindex = -1;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = F[1, j];
                minindex = j;
            }
        }
        Console.WriteLine(minindex);
        Console.WriteLine(min);
        if (minindex != -1)
        {
            int[,] answer = new int[F.GetLength(0), F.GetLength(1) - 1];
            //if (minindex > 0) { 
            //}
            for (int j = 0; j <= minindex; j++)
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    answer[i, j] = F[i, j];
                }
            }
            for (int j = minindex + 2; j < F.GetLength(1); j++)
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    answer[i, j - 1] = F[i, j];
                }
            }
            F = answer;
        }
        Console.WriteLine();
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                Console.Write("{0:d} ", F[i, j]);
            }
            Console.WriteLine();
        }
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
        {
            return default(double[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int maxindex = -1;
            double sum = 0;
            int counter = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    counter++;
                }
            }
            if (counter > 0)
            {
                sum = sum / counter;
            }
            A[i, maxindex] = sum;
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
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
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
        {
            return default(double[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int imax = -1;
            for (int j = 0;j < A.GetLength(1); j++)
            {
                if(A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            if (imax == 0)
            {
                if (A[i,imax+1]>0)
                {
                    A[i, imax + 1] *= 2;
                }
                else
                {
                    A[i,imax+1] /= 2;
                }
            }
            else if (imax == A.GetLength(1)-1)
            {
                if (A[i, imax - 1] > 0)
                {
                    A[i, imax - 1] *= 2;
                }
                else
                {
                    A[i, imax - 1] /= 2;
                }
            }
            else
            {
                if (A[i, imax - 1] < A[i,imax+1])
                {
                    if (A[i, imax - 1] > 0)
                    {
                        A[i, imax - 1] *= 2;
                    }
                    else
                    {
                        A[i, imax - 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, imax + 1] > 0)
                    {
                        A[i, imax + 1] *= 2;
                    }
                    else
                    {
                        A[i, imax + 1] /= 2;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
        {
            return default(int[,]);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int imax = -1;
            int pcounter = 0;
            int ncounter = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if ((A[i, j] > max))
                {
                    max = A[i, j];
                    imax = i;
                }
                if((A[i, j] > 0))
                {
                    pcounter++;
                }
                else if((A[i, j] < 0))
                {
                    ncounter++;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(imax);
            if (pcounter > ncounter)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax+1;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 && (A.GetLength(1) != 5))
        {
            return default(int[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int imax = -1;
            for(int i = 0;i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (imax < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = imax+1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0,j] = sum;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
        {
            return default(int[,]);
        }
        if (B.Length > 7)
        {
            return default(int[,]);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int imax = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (max < B[j])
            {
                A[imax,j] = B[j];
            }
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
        {
            return default(double[,]);
        }
        for(int j = 0; j < A.GetLength(1); j++)
        {   
            double max = double.MinValue;
            int imax = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if ((A[i, j] > max))
                {
                    max= A[i, j];
                    imax = i;
                }
            }
            double halfsum = A[0, j] + A[A.GetLength(0)-1, j];
            if (halfsum > max)
            {
                A[imax, j] = halfsum;
            }
            else
            {
                A[imax, j] = imax+1;
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
        {
            return answer;
        }
        int[,] N = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j < n; j++)
            {
                if (i == j)
                {
                    N[i,j] = 1;
                }
                else
                {
                    N[i, j] = 0;
                }
            }
        }
        for (int i = 0; i < N.GetLength(0); i++)
        {
            for (int j = 0; j < N.GetLength(1); j++)
            {
                Console.Write("{0:d} ", N[i, j]);
            }
            Console.WriteLine();
        }
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3*n; j++)
            {
                int x = j;
                if (j/3 == 1)
                {
                    x = j - 3;
                }
                else if (j/3 == 2)
                {
                    x = j - 6;
                }
                answer[i, j] = N[i,x];
            }
        }
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                Console.Write("{0:d} ", answer[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && (A.GetLength(1) != 6))
        {
            return default(int[,]);
        }
        int max = int.MinValue;
        int maxindex = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j && A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = i;
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i && i < maxindex)
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
        if (B.GetLength(0) != 6 && (B.GetLength(1) != 6))
        {
            return default(int[,]);
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0;i < B.GetLength(0) - 1; i+= 2)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int maxindex1 = -1;
            int maxindex2 = -1;
            for (int j = 0;j < B.GetLength(1); j++)
            {
                if ((B[i,j] > max1))
                {
                    max1 = B[i,j];
                    maxindex1 = j;
                }
                if ((B[i+1,j] > max2))
                {
                    max2 = B[i+1,j];
                    maxindex2 = j;
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.WriteLine(maxindex1);
            Console.WriteLine(maxindex2);
            B[i, maxindex1] = max2;
            B[i+1, maxindex2] = max1;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0:d} ", B[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && (A.GetLength(1) != 7))
        {
            return default(int[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            var temp = 0;
            for (int j = 0; j < A.GetLength(1)/2; j++)
            {
                temp = A[i,j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = temp;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0:d} ", A[i, j]);
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    #endregion


    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5)
        {
            return default(int[,]);
        }
        int[] mins = new int [matrix.GetLength(0)];
        int[] minindexses = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = int.MaxValue; 
            minindexses[i] = i;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                    min = matrix[i, j];
            }
            mins[i] = min;
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int min = mins[i];
            int minindex = minindexses[i];
            int j = i - 1;
            while (j >= 0 && mins[j] < min)
            {
                mins[j + 1] = mins[j];
                minindexses[j + 1] = minindexses[j];
                j -= 1;
            }
            mins[j + 1] = min;
            minindexses[j + 1] = minindex;
        }
        int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int index = minindexses[i];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[i, j] = matrix[index, j];
            }
        }
        // end

        return answer;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return default(int[]);
        }
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
            }
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
        if (matrix.GetLength (0) != matrix.GetLength(1))
        {
            return default(int[,]);
        }
        if (1 > k || k > matrix.GetLength(0))
        {
            return default(int[,]);
        }
        int max = matrix[0,0];
        int max1 = -1;
        int max2 = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i,j]) > Math.Abs(max))
                {
                    max = matrix[i,j];
                    max1 = i;
                    max2 = j;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(max1);
        Console.WriteLine(max2);
        if (max1 != k - 1)
        {
            for(int j = 0;j < matrix.GetLength(0); j++)
            {
                var temp = matrix[max1,j];
                matrix[max1, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max2 != k - 1)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var temp = matrix[i,max2];
                matrix[i,max2] = matrix[i,k-1];
                matrix[i,k-1] = temp;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
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
        if (A.Length < 2 || B.Length < 2)
        {
            return default(int[]);
        }
        int index = 0;
        int[,] Amat = new int[n, n], Bmat = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Amat[i, j] = A[index];
                Bmat[i, j] = B[index];
                Amat[j, i] = A[index];
                Bmat[j, i] = B[index];
                index++;
            }
        }

        int[] mnmat = new int[n * n];

        int mnindex = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    mnmat[mnindex] += Amat[i, k] * Bmat[k, j];
                } 
                mnindex++;
            }
        }
        answer = mnmat;
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
        if (matrix.GetLength(0) != 5 && matrix.GetLength(1) != 7)
        {
            return null;
        }

        int[] minmat = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                if (matrix[i, j] < 0) counter++;

            minmat[j] = counter;
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (minmat[j] > minmat[j + 1])
                {
                    int temp = minmat[j];
                    minmat[j] = minmat[j + 1];
                    minmat[j + 1] = temp;

                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                }
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
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0)
        {
            return default;
        }
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
        }
        int[,] answer = new int[matrix.GetLength(0) - k-1, matrix.GetLength(1)];
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    break;
                }
                answer[c, j] = matrix[i, j];
            }
            c++;
            if (c >= matrix.GetLength(0) - k)
            {
                break;
            }

        }
        matrix = answer;
        // end

        return matrix;
    }
    #endregion
}