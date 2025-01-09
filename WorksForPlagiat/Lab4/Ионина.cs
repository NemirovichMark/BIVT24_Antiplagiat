using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        // code here 9
        if (a0 == 5 || a1 == 7)
        {
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1; j++)
                {
                    answer += A[i, j];
                }
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
        // code here 9
        double answer = 1000000;
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int i1 = 0, i2 = 0;
        if (a0 == 3 || a1 == 6)
        {
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1; j++)
                {
                    if (A[i, j] < answer)
                    {
                        answer = A[i, j];
                        row = i;
                        col = j;
                    }

                }
            }
        }

        // end
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
        int[] answer = { -11111, -11111, -11111, -111111, -11111 };
        // code here 9
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 3 || a1 == 5)
        {
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1; j++)
                {
                    if (A[i, j] > answer[j])
                    {
                        answer[j] = A[i, j];
                    }
                }
            }
            return answer;
        }
        else
        {
            return default;
        }
        // end
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
        // code here 9
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int i1 = 0;
        int max = 0, max_j = 0;

        if (a0 == 5 && a1 == 7)
        {
            for (int i = 0; i < a0; i++)
            {
                if (A[i, 2] > max)
                {
                    max = A[i, 2];
                    max_j = i;
                }
            }
            for (int y = 0; y < a1; y++)
            {
                int num = A[max_j, y];
                A[max_j, y] = A[3, y];
                A[3, y] = num;
            }
            return A;
        }

        else
        {
            return default;
        }
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
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int max = 0, j1 = 0;
        if(a0 == 5 && a1 == 5)
        {
            for(int i = 0; i < a0; i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    j1 = i;
                } 
            }
            for(int m = 0; m < a0; m++)
            {
                int num = A[m, 3];
                A[m, 3] = A[m, j1];
                A[m, j1] = num;
            }
            return A;
        }
        // end
        else
        {
            return default;
        }
        
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
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == n && a1 == m)
        {
            for (int i = 0; i < a0; i++)
            {
                int max = -1000000;
                int ind = 0;
                for (int j = 0; j < a1; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        ind = j;
                    }
                }
                for (int h = 0; h < a1 - 1; h++)
                {
                   
                    if (h >= ind)
                    {
                        A[i, h] = A[i, h + 1];
                        
                    }
                }
                A[i, a1 - 1] = max;
            }
            return A;
        }
        else
            return default;

            // end

            
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
        int a0 = C.GetLength(0);
        int a1 = C.GetLength(1);
        if(a0 == n && a1 == m)
        {
            for(int i = 0; i < a0; i++)
            {
                double max = 0;
                int ind = 0;
                for(int j = 0; j < a1; j++)
                {
                    if (C[i, j] > max)
                    {
                        max = C[i, j];
                        ind = j;
                    }
                }
                for(int k = 0; k < ind; k++)
                {
                    if(C[i, k] < 0)
                    {
                        C[i, k] = C[i, k] / max;
                    }
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
        int a0 = H.GetLength(0);
        int a1 = H.GetLength(1);
        
        if(a0 == 5 && a1 == 7)
        {
            for(int i = 0; i < a0; i++)
            {
                int max = -100000000;
                for(int j = 0; j < a1; j++)
                {
                    if(H[i, j] > max)
                    {
                        max = H[i, j];
                    }
                }
                int num = H[i, a1 - 2];
                H[i, a1 - 2] = max;
                H[i, a1 - 1] = num;
            }
        return H;
        }
        else
        {
            return default;
        }
        // end

       
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here j
        int a0 = Z.GetLength(0);
        int a1 = Z.GetLength(1);

        if (a0 == 6 && a1 == 8)
        {
            double max = -100000000;
                int ind_j = 0, ind_i = 0;
                double sr_summ = 0;
                int sr = 0;
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1; j++)
                { 
                    if(Z[i, j] > max)
                    {
                        max = Z[i, j];
                        ind_j = j;
                        ind_i = i;
                    }
                    if(Z[i, j] > 0)
                    {
                        sr_summ += Z[i, j];
                        sr += 1;
                    }
                }
               
            }
            Z[ind_i, ind_j] = (sr_summ) / (sr);
            return Z;
        }
        else
        {
            return default;
        }
                    // end

                    
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
        // code here j
        int a0 = X.GetLength(0);
        int a1 = X.GetLength(1);
        int min_i = 0, min_num = int.MaxValue;
        int max_j = 0,max_num = 0;
        if (a0 == 6 && a1 == 5)
        {

            for (int i = 0; i < a0; i++)
            {
                int min = 0;
                for (int j = 0; j < a1; j++)
                {
                    if (X[i, j] < 0)
                        min++;
                }
                if (min < min_num)
                {
                    min_num = min;
                    min_i = i;
                }
                else if (min > max_num)
                {
                    max_num = min;
                    max_j = i;
                }
            }
            for (int n = 0; n < a1; n++)
            {
                int num = X[min_i, n];
                X[min_i, n] = X[max_j, n];
                X[max_j, n] = num;
            }
            return X;
        }
        else
            return default;
                    // end

                    
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
        // code here j
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int max_j = 0, max_num = int.MinValue;
        if (a0 == 7 && a1 == 5)
        {
            for (int i = 0; i < a0; i++)
            {
                int sum = 0;
                for (int j = 0; j < a1; j++)
                {
                    if(A[i, j] > 0)
                        sum += A[i, j];
                }
                if (sum > max_num)
                {
                    max_num = sum;
                    max_j = i;
                }
            }
            int[,] A1 = new int[6, 5];
            for (int n = 0; n < a0; n++)
            {
                for (int m = 0; m < a1; m++)
                {
                    if (n < max_j)
                    {
                        A1[n, m] = A[n, m];
                    }
                    if (n > max_j)
                    {
                        A1[n - 1, m] = A[n, m];
                    }
                }
            }
            return A1;
        }
        else
            return default;
                    // end

                    
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
        // code here j
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int a2 = B.Length;
        int min_j = 0, max_num = int.MinValue;
        if (a0 == 5 && a1 == 8 && a2 == 5)
        {
            int min = int.MaxValue;
            for (int j = 0; j < a1; j++)
            {
                if (A[a0 - 1, j] < min)
                {
                    min = A[a0 - 1, j];
                    min_j = j;
                }
            }
            if (min_j == a1 - 2)
            {

                for (int i = 0; i < a0; i++)
                {
                    Console.WriteLine(A[i, min_j + 1]);
                    Console.WriteLine(B[i]);
                    A[i, min_j + 1] = B[i];
                }
            }
            return A;
        }
        else
            return default;
                   // end

                    
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
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 5 && a1 == 7)
        {
            for (int i = 0; i < a0; i++)
            {
                int max_j = 0;
                double max_num = int.MinValue;
                for (int j = 0; j < a1; j++)
                {
                    if (A[i, j] > max_num)
                    {
                        max_num = A[i, j];
                        max_j = j;
                    }
                }
                if (max_j == 0)
                {
                    if (A[i, max_j + 1] > 0)
                        A[i, max_j + 1] = A[i, max_j + 1] * 2;
                    else
                        A[i, max_j + 1] = A[i, max_j + 1] / 2;
                }
                else if (max_j == a1 - 1)
                {
                    if (A[i, a1 - 1] > 0)
                        A[i, a1 - 1] = A[i, a1 - 1] * 2;
                    else
                        A[i, a1 - 1] = A[i, a1 - 1] / 2;
                }
                else
                {
                    if (A[i, max_j - 1] > A[i, max_j + 1])
                    {
                        if (A[i, max_j + 1] > 0)
                            A[i, max_j + 1] = A[i, max_j + 1] * 2;
                        else
                            A[i, max_j + 1] = A[i, max_j + 1] / 2;
                    }
                    else
                    {
                        if (A[i, max_j - 1] > 0)
                            A[i, max_j - 1] = A[i, max_j - 1] * 2;
                        else
                            A[i, max_j - 1] = A[i, max_j - 1] / 2;

                    }
                }
            }
            return A;
        }
        else
            return default;
                    // end      
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 7 && a1 == 5)
        {
            for (int i = 0; i < a1; i++)
            {
                int max_j = 0, min = 0, max = 0;
                double max_num = int.MinValue;
                for (int j = 0; j < a0; j++)
                {
                    if (A[j, i] > 0)
                        max++;
                    if (A[j, i] < 0) {
                        min++;
                    }
                    if (A[j, i] > max_num)
                    {
                        max_num = A[j, i];
                        max_j = j;
                    }
                }
                if (max > min)
                {
                    A[max_j, i] = 0;
                }
                else
                    A[max_j, i] = max_j + 1;
            }
            return A;
        }
        else
            return default;
                    // end

                    
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 10 && a1 == 5)
        {
            for (int i = 0; i < a1; i++)
            {
                int max_j = 0;
                double max_num = int.MinValue;
                int sum = 0;
                for (int j = 0; j < a0; j++)
                {

                    if (A[j, i] > max_num)
                    {
                        max_num = A[j, i];
                        max_j = j;
                    }
                }
                if (max_j != 0)
                {
                    for (int n = 0; n < a0; n++)
                    {
                        if (n > max_j)
                            sum += A[n, i];
                    }
                    A[0, i] = sum;
                }
            }
            
            return A;
        }
        else
            return default;
                    // end

                    
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        int b0 = B.Length;
        if (a0 == 7 && a1 == 5 && b0 == 5)
        {
            for (int i = 0; i < a1; i++)
            {
                int max_j = 0;
                double max_num = int.MinValue;
                int sum = 0;
                for (int j = 0; j < a0; j++)
                {
                    if (A[j, i] > max_num)
                    {
                        max_num = A[j, i];
                        max_j = j;
                    }
                }
                if (max_num < B[i])
                    A[max_j, i] = B[i];
            }
            return A;
        }
        else
            return default;
                    // end

                    
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 7 && a1 == 5)
        {
            for (int i = 0; i < a1; i++)
            {
                int max_j = 0;
                double max_num = int.MinValue;
                for (int j = 0; j < a0; j++)
                {
                    if (A[j, i] > max_num)
                    {
                        max_num = A[j, i];
                        max_j = j;
                    }
                }
                double pol = (A[0, i] + A[a1 - 1, i]) / 2;
                if (max_num < pol)
                    A[max_j, i] = pol;
                else A[max_j, i] = max_j + 1;
            }
            return A;
        }
        else
            return default;
                    // end

                    
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
            return default;
        answer = new int[n, 3 * n];
        for(int i = 0; i < 3 * n; i += 3) 
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
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 6 && a1 == 6)
        {
            int max = int.MinValue, max_i = 0;
            for (int i = 0; i < a1; i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    max_i = i;
                }
            }
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1 - 1 - i; j++)
                {
                    if (i < max_i)
                    {
                        A[i, j + 1 + i] = 0;
                    }
                }
            }
            return A;
        }
        else
            return default;

                    // end

                    
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int a0 = B.GetLength(0);
        int a1 = B.GetLength(1);
        int max_num = int.MinValue;
        int max_num_2 = int.MinValue;
        int max_j = 0, max_j_2 = 0;
        if (a0 == 6 && a1 == 6)
        {
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a1; j++)
                {
                    if (B[i, j] > max_num && i % 2 == 0)
                    {
                        max_num = B[i, j];
                        max_j = j;
                    }
                    else if (B[i, j] > max_num_2 && i % 2 == 1)
                    {
                        max_num_2 = B[i, j];
                        max_j_2 = j;
                    }
                }
                if (i % 2 == 1)
                {
                    int num = B[i - 1, max_j];
                    B[i - 1, max_j] = B[i, max_j_2];
                    B[i, max_j_2] = num;
                    max_num = int.MinValue;
                    max_num_2 = int.MinValue;
                    max_j = 0;
                    max_j_2 = 0;
                }
            }
            return B;
        }
        else
            return default;
                    // end

                    
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a0 = A.GetLength(0);
        int a1 = A.GetLength(1);
        if (a0 == 6 && a1 == 7)
        {
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1 / 2; j++)
                { 
                    int num = A[i, j];
                    A[i, j] = A[i, a1 - j - 1];
                    A[i, a1 - j - 1] = num;
                }
            }
            return A;
        }
        else
            return default;
                    // end

                    
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int a0 = matrix.GetLength(0);
        int a1 = matrix.GetLength(1);
        if (a0 == 7 && a1 == 5)
        {
            int[] index = new int[a0];
            int[] znahenie = new int[a0];
            for (int i = 0; i < a0; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < a1; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                index[i] = i;
                znahenie[i] = min;
            }
            for (int i = 1; i < a0; i++)
            {
                for (int r = 0; r < a0 - i; r++)
                    if (znahenie[r] < znahenie[r + 1])
                    {
                        int temp = znahenie[r];
                        int ind_2 = index[r];
                        znahenie[r] = znahenie[r + 1];
                        index[r] = index[r + 1];
                        znahenie[r + 1] = temp;
                        index[r + 1] = ind_2;
                    }
            }
            int[,] matrix_2 = new int[a0, a1];
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a1; j++)
                {
                    matrix_2[i, j] = matrix[index[i], j];
                }
            }
            return matrix_2;
        }
        else
            return default;
                    // end

                    
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
        int a0 = matrix.GetLength(0);
        int a1 = matrix.GetLength(1);
        answer = new int[2 * a0 - 1];

        if (a0 == a1)
        {
            for (int i = 0; i < 2 * a0 - 1; i++)
            {
                int summ = 0;
                if (i < a0)
                {
                    for (int j = a0 - i - 1, j2 = 0; j < a0; j++, j2++)
                    {
                        summ += matrix[j, j2];
                    }
                }
                else
                {
                    for (int j = i - a0 + 1, j2 = 0; j < a0; j++, j2++)
                    {
                        summ += matrix[j2, j];
                    }
                }
                answer[i] = summ;
                
            }
            return answer;
        }
        else
            return default;
        // end

        
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
        int a0 = matrix.GetLength(0);
        int a1 = matrix.GetLength(1);
        if (a0 == a1 && k >= 1 && k <= a0)
        {
            int ind_i = 0, ind_j = 0;
            int max = 0;
            for (int i = 0; i < a0; i++)
            {
                for (int j = 0; j < a0; j++)
                {
                    if (Math.Abs(matrix[i, j]) > Math.Abs(max))
                    {
                        max = matrix[i, j];
                        ind_i = i;
                        ind_j = j;
                    }
                }
            }
            for (int i = 0; i < a0; i++)
            {
                int num = matrix[i, ind_j];
                matrix[i, ind_j] = matrix[i, k - 1];
                matrix[i, k - 1] = num;
            }
            for (int i = 0; i < a0; i++)
            {
                int num = matrix[ind_i, i];
                matrix[ind_i, i] = matrix[k - 1, i];
                matrix[k - 1, i] = num;
            }
            return matrix;
        }
        else
            return
                default;
        // end

        
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
        int a0 = A.Length;
        int b0 = B.Length;
        int[,] C = new int[n, n];
        int[,] D = new int[n, n];
        answer = new int[n * n];
        int count = 0;
        if (a0 == (n + 1) / 2 * n && b0 == (n + 1) / 2 * n && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    C[j, i] = A[count];
                    C[i, j] = A[count];
                    D[j, i] = B[count];
                    D[i, j] = B[count];
                    count++;
                }
            }
            count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for(int k = 0; k < n; k++)
                    {
                        sum += C[i, k] * D[k, j];
                    }
                    answer[count] = sum;
                    count++;
                }
            }
            return answer;
        }
        else
            return
                default;

                // end

               
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
        int a0 = matrix.GetLength(0);
        int a1 = matrix.GetLength(1);
        if (a0 == 5 && a1 == 7)
        {
            int[] index = new int[a1];
            int[] znahenie = new int[a1];
            for (int i = 0; i < a1; i++)
            {
                int sum = 0;
                for (int j = 0; j < a0; j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        sum++;
                    }
                }
                znahenie[i] = sum;
                index[i] = i;
            }
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a1 - i - 1; j++)
                {
                    if (znahenie[j] > znahenie[j + 1])
                    {
                        int temp = znahenie[j];
                        int ind_2 = index[j];
                        znahenie[j] = znahenie[j + 1];
                        index[j] = index[j + 1];
                        znahenie[j + 1] = temp;
                        index[j + 1] = ind_2;
                    }
                }
            }
            int[,] t = new int[a0, a1];
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a0; j++)
                {
                    t[j, i] = matrix[j, index[i]];
                }
            }
            return t;
        } 
        else
            return default;
                    // end

                    
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
        int a0 = matrix.GetLength(0);
        int a1 = matrix.GetLength(1);
        int k = 0;
        for (int i = 0; i < a0; i++)
        {
            int sum = 0;
            for (int j = 0; j < a1; j++)
            {
                if (matrix[i, j] == 0)
                {
                    sum++;
                }
            }
            if (sum > 0)
            {
                k++;
            }
        }
        int[,] matrix_2 = new int[a0 - k, a1];
        for (int i = 0; i < a0; i++)
        {
            int sum = 0;
            for (int j = 0; j < a1; j++)
            {
                if (matrix[i, j] == 0)
                {
                    sum++;
                }
            }
            if(sum == 0)
            {
                for (int j = 0; j < a1; j++)
                {
                    matrix_2[i, j] = matrix[i, j];
                }
            }
            
        }
        return matrix_2;
                // end

                
    }
    #endregion
}