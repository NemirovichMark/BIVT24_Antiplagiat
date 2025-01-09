using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
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
        int a = int.MaxValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < a)
                {

                    a = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        Console.WriteLine($"{row} {col}");
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
        {
            return null;
        }

        int a = int.MaxValue;
        answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            a = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                
                if (A[i, j] > a)
                {

                    a = A[i, j];

                }
              
            }
            answer[j] = a;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        int min = int.MinValue;
        int idex = -1;
        int s;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > min)
            {
                min = A[i, 2];
                idex = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            s = A[3, j];
            A[3, j] = A[idex, j];
            A[idex, j] = s;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }

        int max = int.MinValue;
        int index = -1;
        int s;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                index = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            s = A[j, 3];
            A[j, 3] = A[j, index];
            A[j, index] = s;
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

       
        int max = int.MinValue;
        int[] temp = new int[A.GetLength(1)];
        int a = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            max = int.MinValue;
            temp = new int[A.GetLength(1)];
            a = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                   
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == max)
                {
                    a = 1;
                }
                if (j == A.GetLength(1) - 1)
                {
                    temp[j] = max;
                }
                else
                {
                    temp[j] = A[i, j + a];
                }
            }
            a = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = temp[j];
            }
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
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue;
            index = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i,j]>max)
                {
                    max = C[i,j];
                    index  = j;
                }
                  
            }
            if (max == 0) continue;
            for (int j = 0; j < index; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j] = C[i, j] / max;
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

        double awg = 0;
        double max = double.MinValue;
        int n = 0;
        int a = 0;
        int b = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j]>max)
                {
                    max = Z[i, j];
                    a = i;
                    b = j;
                }
                if (Z[i, j] > 0)
                {
                    awg += Z[i, j];
                    n++;
                }
            }
            

        }
        awg = Math.Round( awg / n , 2);
        Z[a, b] = awg;

        for (int i = 0; i < Z.GetLength(0); i++)
        {

            for (int j = 0; j < Z.GetLength(1); j++)
            {
                Console.Write($"{Z[i,j]} ");
            }
            Console.WriteLine();

        }



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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }
        int k = 0;
        int min = 5, min_i = -1, max = -1, max_i = -1;
        for (int i = 0; i < 6; i++)
        {
            k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k < min)
            { 
                min = k;
                min_i = i; 
            }
            if (k > max)
            {
                max = k;
                max_i = i ; 
            }
        }
        int s = 0;
        for (int i = 0; i < 5; i++)
        {
            s = X[min_i, i];
            X[min_i, i] = X[max_i, i];
            X[max_i, i] = s;
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
        {
            return null;
        }
        int[,] B = new int[6,5];
        int max = int.MinValue;
        int sum = 0;
        int index = -1;
        for (int i = 0; i < 7; i++)
        {
            sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i,j]>0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > max)
            {
                max = sum;
                index = i;
            }
        }

        int x = 0;

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i== index)
                {
                    x = 1;
                    continue;
                   
                }
                B[i - x, j] = A[i, j];
            }
        }
        

        for (int i = 0; i < B.GetLength(0); i++)
        {

            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();

        }

        // end

        return B;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8)
        {
            return null;
        }
        if (B.Length != 5)
        {
            return null;
        }

        int min = int.MaxValue, index = -1;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[4, j] < min)
            {
                min = A[4, j];
                index = j;
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i,7]=A[i,index+1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            double max = double.MinValue;
            int index = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    index = j;
                }
            }
            
            if (i == 0)
            {
                if (A[i, index + 1] >= 0)
                    A[i, index + 1] = 2 * A[i, index + 1];
                else A[i, index + 1] = A[i, index + 1]/2;
            }
            else if (i == 6)
               {
                if (A[i, index - 1] >= 0)
                    A[i, index - 1] = 2 * A[i, index - 1];
                else
                    A[i, index - 1] = A[i, index - 1]/2;
            }

            else if (A[i, index + 1] > A[i, index - 1])
               {
                if (A[i, index - 1] >= 0)
                    A[i, index - 1] = 2 * A[i, index - 1];
                else
                    A[i, index - 1] = A[i, index - 1]/2;
            }

            else
            {
                if (A[i, index - 1] >= 0)
                    A[i, index + 1] = 2 * A[i, index + 1];
                else
                    A[i, index + 1] = A[i, index + 1]/2;
            }

        }


        for (int i = 0; i < A.GetLength(0); i++)
        {

            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();

        }
        // end

        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < 5; i++)
        {
            int a = 0;
            int b = 0;
            double max = double.MinValue;
            int index = -1; 
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
                if (A[j, i] > 0) a++;
                else   b++; 
            }
            if (a > b)
                A[index, i] = 0;
            else
                A[index, i] = index+1;
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {

            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();

        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = -1;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += A[i, j];
                if (A[i,j]>max)
                {
                    max=A[i,j];
                    index = i;
                    sum = 0;
                }
                if (index <= 4)
                    A[0, j] = sum;

            }
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }

        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int index = -1;
            
            for (int i = 0; i < 7; i++)
            {
                
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            if (max < B[j])
            {
                A[index, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            double max = double.MinValue;
            int index = -1;
            

            for (int i = 0; i < 7; i++)
            {

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                    
                }
            }
                if (max < (A[0, j] + A[6, j]) / 2)
                {
                    A[index, j] = (A[0, j] + A[6, j]) / 2;
                }
                else A[index, j] = (index+1);
            
        }

            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0) 
        { return null; }

        int[,] A = new int[n, 3 * n];
        int N = 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                A[i, j] = ((j + N) % 3) / 2;
            }
            N--;
        }

        answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        return null;

        int max = int.MinValue;
        int index = -1;

        for (int i = 0; i < 6; i++)
        {
            if (A[i, i]>max)
            {
                max = A[i, i];
                index = i;
            }
        }

        if (index == -1) return null;

        for (int i = 0; i < index; i++)
        {
            for (int j = i+1; j < 6; j++)
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
        if (6 != B.GetLength(0) || 6 != B.GetLength(1)) 
        return null;

        int index_1 = -1;
        int index_2 = -1;

        for (int i = 0; i < 6; i+=2)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int temp = 0;
            for (int j = 0; j < 6; j++)
            {

                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    index_1 = j;
                }

            }

            for (int j = 0; j < 6; j++)
            {

                if (B[i+1, j] > max2)
                {
                    max2 = B[i+1, j];
                    index_2 = j;
                }

            }

            temp = B[i, index_1];
            B[i, index_1]=B[i+1, index_2];
            B[i + 1, index_2]=temp;


        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        if (6 != A.GetLength(0) || 7 != A.GetLength(1))
        return null;

        int N;

        int[] s;

        for (int i = 0; i < 6; i ++)
        {
            N = 6;
            s = new int[7];
            for (int j = 0; j < 7; j ++)
            {
                s[j] = A[i, N];
                N--;
            }
            for (int j = 0; j < 7; j ++)
            {
                A[i, j] = s[j]; 
            }

        }



        // end

        return A;
    }
    #endregion

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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) return null;
        int a1 = 0,
            b1 = 0,
            a2 = n - 1,
            b2 = n - 1;

        for (int i = 0; i < n; i++)
        {
            matrix[i - a1, i] = 0;
            matrix[i, i - b1] = 0;
            matrix[i + a2, i] = 0;
            matrix[i, i + b2] = 0;
            a1++;
            b1++;
            a2--;
            b2--;
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) return null;

        for (int i = (n / 2); i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 2) return (null, null);
        int u = (int)((n * n) / 2 + 0.5 * n);
        int uk = 0,
            lk = 0,
            v1 = n;
        upper = new int[u];
        lower = new int[n * n - u];
        for (int i = 0; i < n; i += 1)
        {
            for (int j= 0; j < n; j += 1)
            {
                if (j >= i)
                {
                    upper[uk] = matrix[i, j];
                    uk++;
                }
                else
                {
                    lower[lk] = matrix[i, j];
                    lk++;
                }
            }
        }

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int i = 0; j > i; i++)
                Console.Write($" ");
            for (int i = j; i < matrix.GetLength(0); i++)
            { Console.Write($"{matrix[j,i]} "); }
            Console.WriteLine();
        }

        Console.WriteLine(" ");
         for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int i = 0; j > i; i++)
            { Console.Write($"{matrix[j,i]} "); }
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        int[,] c = new int[a, b + 1];
        int n = 0;
        if (a != 7 || b != 5) return null;
        for (int i = 0; i < a; i++)
        {

            n= 0;
            for (int j = 1; j < b + 1; j++)
            {
                c[i, j] = matrix[i, j - 1];
                if (c[i, j] > 0)
                {
                    n++;
                }
            }
            c[i, 0] = n;
        }
       
        int g;
        bool flag = true;
        while (flag)
        {
            flag = false;
            for (int i = 0; i < a - 1; i++)
            {
                if (c[i, 0] < c[i + 1, 0])
                {
                    for (int j = 0; j < b + 1; j++)
                    {
                        g = c[i, j];
                        c[i, j] = c[i + 1, j];
                        c[i + 1, j] = g;
                    }
                    flag = true;
                }
            }

        }

       
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matrix[i, j] = c[i, j + 1];
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);

        for (int n = 0; n < a; n++)
        {
            for (int i = 0; i <b - 1; i++)
            {
                for (int j = 0; j < b - i - 1; j++)
                {

                    if (n % 2 == 0)
                    {
                        if (matrix[n, j] < matrix[n, j + 1])
                        {
                            int temp = matrix[n, j];
                            matrix[n, j] = matrix[n, j + 1];
                            matrix[n, j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[n, j] > matrix[n, j + 1])
                        {
                            int temp = matrix[n, j];
                            matrix[n, j] = matrix[n, j + 1];
                            matrix[n, j + 1] = temp;
                        }
                    }


                }
            }
        }

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        // code here
        int count = 0;
        bool found = false;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                found = false;
                continue;
            }
        }

        int index = 0;
        int[,] temp = new int[a - count, b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (matrix[i, j] == 0)
                {
                    found = true;
                    break;
                }
                temp[index, j] = matrix[i, j];
            }
            if (found)
            {
                found = false;
                continue;
            }
            index++;
            if (index >= a - count)
                break;
        }
        matrix = temp;

        a = matrix.GetLength(0);
        b = matrix.GetLength(1);


        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        
    
        // end

        return matrix;
    }
    #endregion
}