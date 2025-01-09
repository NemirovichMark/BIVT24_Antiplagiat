using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

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
        int mini = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (mini > A[i,j])
                {
                    mini = A[i, j];
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
            return null;

            answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = -1000000000;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                }
            }
            answer[j] = maxi;
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
        if ((A.GetLength(0) != 5 || A.GetLength(1) != 7))
            return null;
        int maxi = int.MinValue;
        int row = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (maxi < A[i, 2])
            {
                maxi = A[i, 2];
                row = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int temp = A[row, j];
            A[row, j] = A[3, j];
            A[3, j] = temp;
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
        //code here
        if ((A.GetLength(0) != 5 || A.GetLength(1) != 5))
            return null;

        int col = 0;
        int maxi = int.MinValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i,i] > maxi)
            {
                maxi =A[i,i];
                col = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int temp = A[i, col];
            A[i, col] = A[i, 3];
            A[i, 3] = temp;
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
        int maxi = int.MinValue;
        int imax = 0, jmax = 0;
        int[,] num_max = new int[n, 2];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    num_max[i, 0] = j;
                    num_max[i, 1] = A[i, j];
                }
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = num_max[i, 0]; j < A.GetLength(1); j++)
            {
                if (j == m - 1)
                    A[i, j] = num_max[i, 1];
                else
                    A[i, j] = A[i, j + 1];
            }

        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        double[,] num_max = new double[n, 2];
        double maxi =double.MinValue;
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j =0 ; j < C.GetLength(1);j++)
            {
                if (C[i, j] > maxi)
                {
                    maxi = C[i, j];
                    num_max[i, 0] = j;
                    num_max[i, 1] = maxi;
                }
            }
        }
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j =0; j < num_max[i, 0]; j++)
            {
                if (C[i,j] < 0)
                {
                    C[i, j] = C[i, j] / num_max[i, 1];
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
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
            return null;
        double maxi = Z[0, 0];
        int imax = 0, jmax=0;
        double sr = 0;
        int count = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if ((Z[i, j] > maxi))
                {
                    maxi = Z[i, j];
                    imax = i;
                    jmax = j;
                }
                if ((Z[i, j] >0))
                {
                    sr += Z[i, j];
                    count++;
                } 
            }
        }
        sr /= count;
        Z[imax, jmax] = sr;

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
        if (X.GetLength(0) != 6 || X.GetLength(1) !=5)
            return null;
        int max_count = int.MinValue, min_count = int.MaxValue;
        int imax = 0, imin = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    count++;
                }
            }
            if (count > max_count)
            {
                max_count = count;
                imax = i;
            }
            else if (count < min_count)
            {
                min_count = count;
                imin = i;
            }
        }
        for (int j = 0; j < X.GetLength(1); j++)
        {
            int temp = X[imax, j];
            X[imax, j] = X[imin, j];
            X[imin, j] = temp;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        int index = 0, maxsumma = 0; ;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int summa = 0;
            for (int j=0; j < A.GetLength(1); j++)
            {
                if (A[i,j] >0)
                {
                    summa += A[i,j];
                }
            }
            if (maxsumma < summa)
            {
                maxsumma = summa;
                index = i;
            }
        }
        for (int i = index; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == A.GetLength(0) - 1)
                {
                    A[i, j] = 0;
                }
                else
                {
                    A[i,j] = A[i+1,j];
                }
            }
        }
        int[,] A1 = new int[6, A.GetLength(1)];
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A1[i, j] = A[i, j];
            }
        }
        A = A1;



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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
            return null;

        int index = 0; int mini = int.MaxValue;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[5-1, j] < mini)
            {
                mini = A[5-1, j];
                index = j;
            }      
        }
        //Console.WriteLine(index);
        index += 1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1) - 1; j >= index; j--)
            {
                if (j < A.GetLength(1) - 1)
                {
                    int temp = A[i, j + 1];
                    A[i, j + 1] = A[i, j];
                    A[i, j] = temp;
                }
            }
            A[i, index] = B[i];
        }

        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}


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
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        int[] index = new int[5];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxi = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                    index[i] = j;
                }
            }

            if (index[i] == 0)
            {
                if (A[i, index[i] + 1] < 0) A[i, index[i] + 1] /= 2;
                else A[i, index[i] + 1] *= 2;
            }
            else if (index[i] == 6)
            {
                if (A[i, index[i] - 1] < 0) A[i, index[i] - 1] /= 2;
                else A[i, index[i] - 1] *= 2;
            }
            else
            {
                if (A[i, index[i] - 1] > A[i, index[i] + 1])
                {
                    if (A[i, index[i] + 1] < 0) A[i, index[i] + 1] /= 2;
                    else A[i, index[i] + 1] *= 2;
                }
                else
                {
                    if (A[i, index[i] - 1] < 0) A[i, index[i] - 1] /= 2;
                    else A[i, index[i] - 1] *= 2;
                }
            }
        }

        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int index = 0;
            int maxi = int.MinValue;
            int above = 0, below = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) above++;
                else if (A[i, j] < 0) below++;

                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                    index = i;
                }
            }
            if (above > below) A[index, j] = 0;
            else if (above < below) A[index, j] = index+1;
        }


        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;
        int[,] index = new int[5, 2];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index[j, 0] = i;
                    index[j, 1] = maxi;
                }
            }


        }
        //for (int i = 0; i < index.GetLength(0); i++)
        //{
        //    for (int j = 0; j < index.GetLength(1); j++)
        //    {
        //        Console.Write(index[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int summa = 0;
            for (int i = index[j, 0] + 1; i < A.GetLength(0); i++)
            {
                if (index[j, 0] < 5)
                    summa += A[i, j];
            }
            A[0, j] = summa;
        }

        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = int.MinValue, imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    imax = i;
                }
            }
            if (B[j] > maxi) A[imax, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int j =0; j < A.GetLength(1); j++)
        {
            double maxi = double.MinValue;
            int imax = 0;
            double summa = 0;
            for (int i = 0;i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    imax = i;
                }
                summa += (A[0, j] + A[6, j]) / 2;

                
            }
            if (maxi < summa)
            {
                A[imax, j] = summa;
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
        if (n <= 0)
            return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j, j + i] = 1;
            }
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int maxi = int.MinValue, index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxi)
            {
                maxi = A[i, i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }


        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}



        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        for (int i = 0; i < B.GetLength(0); i+=2)
        {
            int max_1= int.MinValue, max_2 = int.MinValue;
            int jmax_1 = 0, jmax_2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (max_1 < B[i, j])
                {
                    max_1 = B[i, j];
                    jmax_1 = j;
                }
                if (max_2 < B[i + 1, j])
                {
                    max_2 = B[i + 1, j];
                    jmax_2 = j;
                }
            }
            int temp = B[i, jmax_1];
            B[i, jmax_1] = B[i + 1, jmax_2];
            B[i+1, jmax_2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i<A.GetLength(0); i++)
        {
            for (int j = 0; j < 7/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) -1 - j];
                A[i, A.GetLength(1) -1 - j] = temp;
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
            return null;
        int[,] min_num = new int[matrix.GetLength(0), 2];
        int[,] A = new int[7, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (min > matrix[i, j])
                {
                    min = matrix[i, j];
                    min_num[i, 1] = min;
                    min_num[i, 0] = i;
                }
            }
        }
        //for (int i = 0; i < min_num.GetLength(0); i++)
        //{
        //    for (int j = 0; j < min_num.GetLength(1); j++)
        //    {
        //        Console.Write(min_num[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        for (int i = 0; i < min_num.GetLength(0); i++)
        {
            for (int j = 0; j < min_num.GetLength(0) - i - 1; j++)
            {
                if (min_num[j, 1] < min_num[j + 1, 1])
                {
                    int temp0 = min_num[j, 0];
                    int temp1 = min_num[j, 1];
                    min_num[j, 0] = min_num[j + 1, 0];
                    min_num[j, 1] = min_num[j + 1, 1];
                    min_num[j + 1, 0] = temp0;
                    min_num[j + 1, 1] = temp1;
                }
            }
        }
        //Console.WriteLine();
        //for (int i = 0; i < min_num.GetLength(0); i++)
        //{
        //    for (int j = 0; j < min_num.GetLength(1); j++)
        //    {
        //        Console.Write(min_num[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = matrix[min_num[i, 0], j];
            }
        }
        Console.WriteLine();

        matrix = A;



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
        if (matrix.GetLength(0) != matrix.GetLength(1)) 
            return null;
        answer = new int[2*matrix.GetLength(0) -1];
        int n = matrix.GetLength(0);
        int sm1, sm2, index1 = n - 1, index2 = n - 1;
        for (int i = 0; i < n; i++)
        {
            sm1 = 0; sm2 = 0;
            for (int j = 0; i+j < n; j++)
            {
                sm1 += matrix[i+j, j];
                sm2 += matrix[j, i+j];
            }
            answer[index1--] = sm1;
            answer[index2++] = sm2;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) 
            return null;
        int len = matrix.GetLength(0);
        if (!(1 <= k && k <= len)) 
            return null;
        int maxi = matrix[0, 0], jmax = 0, imax = 0;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                if (maxi < Math.Abs(matrix[i, j]))
                {
                    maxi = Math.Abs(matrix[i, j]);
                    jmax = j;
                    imax = i;
                }
            }
        }
        //row
        for (int i = 0; i < len; i++)
        {
            int temp = matrix[imax, i];
            matrix[imax, i] = matrix[k-1, i];
            matrix[k - 1, i] = temp;
        }
        //col
        for (int i = 0; i < len; i++)
        {
            int temp = matrix[i, jmax];
            matrix[i, jmax] = matrix[i, k-1];
            matrix[i, k - 1] = temp;
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
        if (A.Length != (n * (n + 1) / 2) && B.Length != (n * (n + 1) / 2))
            return null;
        answer = new int[n * n];
        int[,] matrA = new int[n, n];
        int[,] matrB = new int[n, n];
        int[,] multi = new int[n, n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrA[i, j] = A[index];
                matrA[j, i] = A[index];
                matrB[i, j] = B[index];
                matrB[j, i] = B[index];
                index++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    multi[i, j] += matrA[i, k] * matrB[k, j];
                }
                answer[j + i * n] = multi[i, j];
            }
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
            return null;
        int[,] negative = new int[matrix.GetLength(1), 2];
        int[,] A = new int[5, 7];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (0 > matrix[i, j])
                {
                    count++;

                }
            }
            negative[j, 0] = j;
            negative[j, 1] = count;
        }


        for (int i = 0; i < negative.GetLength(0); i++)
        {
            for (int j = 0; j < negative.GetLength(0) - i - 1; j++)
            {
                if (negative[j, 1] > negative[j + 1, 1])
                {
                    int temp0 = negative[j, 0];
                    int temp1 = negative[j, 1];
                    negative[j, 0] = negative[j + 1, 0];
                    negative[j, 1] = negative[j + 1, 1];
                    negative[j + 1, 0] = temp0;
                    negative[j + 1, 1] = temp1;
                }
            }
        }
        for (int i = 0; i < negative.GetLength(0); i++)
        {
            for (int j = 0; j < negative.GetLength(1); j++)
            {
                Console.Write(negative[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        for (int i = 0; i < A.GetLength(0); i++)  //j 0-7
        {
            for (int j = 0; j < A.GetLength(1); j++)//i 0-5
            {
                A[i, j] = matrix[i, negative[j, 0]];
            }
        }

        matrix = A;

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
        //считаю кол-во срок с нулями (2)
        int index_count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                    count++;
            }
            if (count > 0) index_count++;
        }

        int[] zero = new int[index_count];
        ////добавление индексов срок с нулями
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero[k++] = i;
                    break;
                }
            }
        }

        int[,] A = new int[matrix.GetLength(0) - index_count, matrix.GetLength(1)];
        int iA = 0;
        for (int i = 0, ia = 0; i < matrix.GetLength(0) && ia < matrix.GetLength(0); i++, ia++)
        {
            bool flag = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
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