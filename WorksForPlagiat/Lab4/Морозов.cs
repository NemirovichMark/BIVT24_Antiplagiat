using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        int[] A = { 1, 2, 3, 4, 5, 6 };
        int[] B = { 10, 11, 12, 13, 14, 15 };
        program.Task_3_7(A, B, 3);

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
        if (A.GetLength(0) == 4 && A.GetLength(1) == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                answer += A[i, i];
            }
        }
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
        int min = int.MaxValue;
        int indmin = 0;

        if (A.GetLength(0) == 4 && A.GetLength(1) == 7)
        {
            answer = new int[4];
            for (int i = 0; i < 4; i++)
            {
                indmin = 0;
                min = int.MaxValue;
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        indmin = j;
                    }
                }
                answer[i] = indmin;
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
        int max = int.MinValue;
        int indmax = 0;
        int t;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                indmax = 0;
                max = int.MinValue;
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        indmax = j;
                    }
                }
                Console.WriteLine(indmax);
                t = A[i, 0];
                A[i, 0] = A[i, indmax];
                A[i, indmax] = t;
            }
        }
        else
        {
            A = default(int[,]);
        }
        /*for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(A[i,j]);
                Console.Write(" ");
            }
            Console.WriteLine(0000);

        }*/

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
        int max = int.MinValue;
        int indi = 0, indj = 0;
        int[,] B = new int[5, 6];
        if (A.GetLength(0) == 6 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        indi = i;
                        indj = j;
                    }
                }
            }

            int ii = 0, jj = 0;
            for (int i = 0; i < 6; i++)
            {
                if (i == indi) continue;
                jj = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (j != indj)
                    {
                        B[ii, jj] = A[i, j];
                        jj++;
                    }
                }
                ii++;
            }
        }
        else
        {
            B = default(int[,]);
        }
        // end

        return B;
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
        int max = int.MinValue;
        int indi = 0, indj = 0;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                indj = 0;
                max = int.MinValue;
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        indj = j;
                    }
                }
                A[i, indj] *= (i + 1);
            }
        }
        else
        {
            A = default(int[,]);
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
        int max = int.MinValue;
        bool flag;
        int indmax = 0, indotr = 0, t = 0;
        for (int i = 0; i < n; i++)
        {
            indmax = 0; indotr = 0; flag = true;
            max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    flag = false;
                    indotr = j;
                }
                if (flag)
                {
                    if (D[i, j] > max)
                    {
                        max = D[i, j];
                        indmax = j;
                    }
                }
            }
            //Console.WriteLine(indmax);
            //Console.WriteLine(indotr);
            if (!flag && D[i, 0] >= 0)
            {
                t = D[i, indmax];
                D[i, indmax] = D[i, indotr];
                D[i, indotr] = t;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(D[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine("");
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
        int max = int.MinValue;
        int indi = 0, indj = 0;
        if (H.GetLength(0) == 5 && H.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                indj = 0;
                max = int.MinValue;
                for (int j = 0; j < 6; j++)
                {
                    if (H[i, j] > max)
                    {
                        max = H[i, j];
                        indj = j;
                    }
                }
                H[i, 6] = H[i, 5];
                H[i, 5] = max;
            }
        }
        else
        {
            H = default(int[,]);
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
        double max = int.MinValue;
        int indi = 0, indj = 0;
        double sredne = 0;
        int number = 0;
        if (Y.GetLength(0) == 6 && Y.GetLength(1) == 5)
        {
            for (int i = 0; i < 6; i++)
            {
                indj = 0;
                max = int.MinValue;
                for (int j = 0; j < 5; j++)
                {
                    if (Y[i, j] > max)
                    {
                        max = Y[i, j];
                        indj = j;
                    }
                }
                sredne = 0;
                number = 0;
                for (int j = 4; j > indj; j--)
                {
                    if (Y[i, j] > 0)
                    {
                        sredne += Y[i, j];
                        number++;
                    }
                }
                if (number == 0)
                {
                    sredne = 0;
                }
                else
                {
                    sredne = sredne / number;
                }
                for (int j = indj - 1; j >= 0; j--)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = sredne;
                    }
                }
            }
        }
        else
        {
            Y = default(double[,]);
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

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        int[] A = new int[5];
        int max;
        if (B.GetLength(0) == 5 && B.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                max = int.MinValue;
                for (int j = 0; j < 7; j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                }
                A[i] = max;
            }
            for (int i = 0; i < 5; i++)
            {
                B[i, 3] = A[4 - i];
            }
        }
        else
        {
            B = default(int[,]);
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
        int max = int.MinValue;
        int ind1 = 0, ind2 = 0, t;
        if (B.GetLength(0) == 5 && B.GetLength(1) == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                if (B[i, i] > max)
                {
                    max = B[i, i];
                    ind1 = i;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (B[2, i] < 0)
                {
                    ind2 = i;
                    break;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                t = B[ind1, i];
                B[ind1, i] = B[ind2, i];
                B[ind2, i] = t;
            }
        }
        else
        {
            B = default(int[,]);
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
        int max = int.MinValue;
        int ind = 0;
        int number = 0;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] < 0)
                    {
                        number++;
                    }
                }
            }
            answer = new int[number];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] < 0)
                    {
                        answer[ind] = A[i, j];
                        ind++;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] < 0)
                    {
                        number++;
                    }
                }
            }
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        double max = double.MinValue;
        int ind = 0;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 5; i++)
            {
                max = double.MinValue;
                ind = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        ind = j;
                    }
                }
                //Console.WriteLine(ind);
                if (ind == 0)
                {
                    if (A[i, 1] > 0) A[i, 1] *= 2;
                    if (A[i, 1] < 0) A[i, 1] /= 2;
                }
                else if (ind == 6)
                {
                    if (A[i, 5] > 0) A[i, 1] *= 2;
                    if (A[i, 5] < 0) A[i, 1] /= 2;
                }
                else
                {
                    if (A[i, ind - 1] > A[i, ind + 1])
                    {
                        if (A[i, ind + 1] > 0) A[i, ind + 1] *= 2;
                        if (A[i, ind + 1] < 0) A[i, ind + 1] /= 2;
                    }
                    else
                    {
                        if (A[i, ind - 1] > 0) A[i, ind - 1] *= 2;
                        if (A[i, ind - 1] < 0) A[i, ind - 1] /= 2;
                    }
                }

            }
            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(double[,]);
        }
        // end

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int max = int.MinValue;
        int ind = 0, kol = 0;
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                max = int.MinValue;
                ind = 0;
                kol = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (A[i, j] > 0)
                    {
                        kol++;
                    }
                    else
                    {
                        kol--;
                    }
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        ind = i;
                    }
                }
                if (kol > 0)
                {
                    A[ind, j] = 0;
                }
                else
                {
                    A[ind, j] = ind + 1;
                }
                //Console.WriteLine(ind);

            }
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int max = int.MinValue;
        int ind = 0, kol = 0, sm = 0;
        if (A.GetLength(0) == 10 && A.GetLength(1) == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                max = int.MinValue;
                ind = 0;
                kol = 0;
                sm = 0;
                for (int i = 0; i < 10; i++)
                {
                    sm += A[i, j];
                    if (A[i, j] > max)
                    {
                        sm = 0;
                        max = A[i, j];
                        ind = i;
                    }
                }
                if (ind < 5)
                {
                    A[0, j] = sm;
                }
                //Console.WriteLine(ind);

            }
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int max = int.MinValue;
        int ind = 0, jj = 0;
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5 && B.Length == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                max = int.MinValue;
                ind = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        ind = i;
                    }
                }
                if (B[j] > A[ind, j]) A[ind, j] = B[j];
                //Console.WriteLine(ind);

            }
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        double max = double.MinValue, first, last;
        int ind = 0, jj = 0;
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                max = int.MinValue;
                ind = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        ind = i;
                    }
                }

                if (A[0, j] + A[1, j] > max)
                {
                    A[ind, j] = A[0, j] + A[-1, j];
                }
                else
                {
                    A[ind, j] = ind + 1;
                }
                //Console.WriteLine(ind);

            }
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(double[,]);
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n > 1)
        {
            answer = new int[n, 3 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (i % n == j % n) answer[i, j] = 1;

                }
            }
        }
        /*for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3*n; j++)
            {
                Console.WriteLine(answer[i, j] + " ");
            }
            Console.WriteLine();
        }*/
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int max = int.MinValue;
        int ind = 0, jj = 0;
        if (A.GetLength(0) == 6 && A.GetLength(1) == 6)
        {
            max = int.MinValue;
            ind = 0;
            for (int i = 0; i < 6; i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    ind = i;
                }
            }
            for (int i = 0; i < ind; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {

                    A[i, j] = 0;

                }
            }
            /*for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int max1 = int.MinValue, max2 = int.MinValue; ;
        int ind1 = 0, ind2 = 0, t = 0;
        if (B.GetLength(0) == 6 && B.GetLength(1) == 6)
        {
            for (int i = 0; i < 3; i++)
            {
                max1 = int.MinValue;
                ind1 = 0;
                max2 = int.MinValue;
                ind2 = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (B[2 * i, j] > max1)
                    {
                        max1 = B[2 * i, j];
                        ind1 = j;
                    }
                    if (B[2 * i + 1, j] > max2)
                    {
                        max2 = B[2 * i + 1, j];
                        ind2 = j;
                    }

                }
                B[2 * i, ind1] = max2;
                B[2 * i + 1, ind2] = max1;
            }
            /*for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(B[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            B = default(int[,]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int t = 0;
        if (A.GetLength(0) == 6 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 7 / 2; j++)
                {
                    t = A[i, j];
                    A[i, j] = A[i, 6 - j];
                    A[i, 6 - j] = t;
                }
            }
            /*for (int i = 0; i < 6; i++)
             {
                 for (int j = 0; j < 7; j++)
                 {
                     Console.Write(A[i, j]);
                     Console.Write(" ");
                 }
                 Console.WriteLine();
             }*/
        }
        else
        {
            A = default(int[,]);
        }
        // end

        return A;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int min = int.MaxValue;
        int ind = 0, t = 0;
        int[] mini = new int[7];
        if (matrix.GetLength(0) == 7 && matrix.GetLength(1) == 5)
        {
            for (int i = 0; i < 7; i++)
            {
                min = int.MaxValue;
                ind = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        ind = i;
                    }
                }
                mini[i] = min;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7 - 1 - i; j++)
                {
                    if (mini[j] < mini[j + 1])
                    {
                        t = mini[j + 1];
                        mini[j + 1] = mini[j];
                        mini[j] = t;
                        for (int k = 0; k < 5; k++)
                        {
                            t = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = t;
                        }
                    }
                }
            }

            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            matrix = default(int[,]);
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

        if (matrix.GetLength(0) == matrix.GetLength(1))
        {
            int n = matrix.GetLength(0);
            answer = new int[2 * n - 1];
            int sm1, sm2, ind1 = n - 1, ind2 = n - 1;
            for (int i = 0; i < n; i++)
            {
                sm1 = 0; sm2 = 0;
                for (int j = 0; i + j < n; j++)
                {
                    sm1 += matrix[i + j, j];
                    sm2 += matrix[j, i + j];
                }
                answer[ind1--] = sm1;
                answer[ind2++] = sm2;
            }
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            answer = default(int[]);
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
        int max = 0, ii = 0, jj = 0, t = 0;
        int n = matrix.GetLength(0);
        if (matrix.GetLength(0) == matrix.GetLength(1) && k <= n && k >= 1)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matrix[i, j]) > Math.Abs(max))
                    {
                        max = matrix[i, j];
                        ii = i;
                        jj = j;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                t = matrix[ii, i];
                matrix[ii, i] = matrix[k - 1, i];
                matrix[k - 1, i] = t;
            }
            for (int i = 0; i < n; i++)
            {
                t = matrix[i, jj];
                matrix[i, jj] = matrix[i, k - 1];
                matrix[i, k - 1] = t;
            }


            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/
        }
        else
        {
            matrix = default(int[,]);
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
        if (A.Length == (n * (n + 1) / 2) && B.Length == (n * (n + 1) / 2))
        {
            answer = new int[n * n];
            int[,] matrA = new int[n, n], matrB = new int[n, n], multi = new int[n, n];
            int ind = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matrA[i, j] = A[ind];
                    matrA[j, i] = A[ind];
                    matrB[i, j] = B[ind];
                    matrB[j, i] = B[ind];
                    ind++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //multi[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        multi[i, j] += matrA[i, k] * matrB[k, j];
                    }
                    answer[j + i * n] = multi[i, j];
                }
            }
            /*for (int i = 0; i < n; i++)
            {
                
                    Console.Write(answer[i]);
                    Console.Write(" ");
                
                Console.WriteLine();
            }*/
        }
        else
        {
            answer = default(int[]);
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
        int neg;
        int ind = 0, t = 0;
        int[] negative = new int[7];
        if (matrix.GetLength(0) == 5 && matrix.GetLength(1) == 7)
        {
            for (int j = 0; j < 7; j++)
            {
                neg = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        neg++;
                    }
                }
                negative[j] = neg;
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (negative[i] > negative[i + 1])
                    {
                        t = negative[i + 1];
                        negative[i + 1] = negative[i];
                        negative[i] = t;
                        for (int k = 0; k < 5; k++)
                        {
                            t = matrix[k, i];
                            matrix[k, i] = matrix[k, i + 1];
                            matrix[k, i + 1] = t;
                        }
                    }
                }
            }
        }
        else
        {
            matrix = default(int[,]);
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
        int[] negative = new int[n];
        bool flag;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            flag = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    n--;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                negative[i] = 1;
            }
        }
        int[,] arr = new int[n, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (negative[i] == 1)
                {
                    arr[k, j] = matrix[i, j];
                }
            }
            k++;
        }
        matrix = arr;
        // end

        return matrix;
    }
    #endregion
}