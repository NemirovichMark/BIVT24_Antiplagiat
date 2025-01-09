using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;


public class Program
{
    //    // Циклический сдвиг
    //    int temp;
    //    int shift = 3;
    //    for (int i = 0; i < shift % array.Length; i++)
    //    {
    //        temp = array[n - 1];
    //        for (int j = n - 1; j > 0; j--) 
    //        {
    //            array[j] = array[j - 1];
    //        }
    //        array[0] = temp;


    //    }
    public static void Main()
    {
        Program program = new Program();
        int[,] A = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };

        //int[] sums = new int[A.GetLength(0)*2 - 1];

        
        //for (int count = 0; count < A.GetLength(0); count++)
        //{
        //    int diag_sum = 0;
        //    int k = count+1;
        //    for (int j = 0; j < A.GetLength(0); j++)
        //    {
        //        if (k < A.GetLength(0))
        //        {
        //            diag_sum += A[j, k+j- 1];  
        //        } 
                
        //    }
            
            
            
        //    Console.WriteLine(diag_sum);
        //}



    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int sum = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                sum += A[i, j];
            }
        }
        answer = sum;
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
        double min = double.MaxValue;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
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
        answer = new int[A.GetLength(1)];

        if (A.GetLength(0) != 3 && A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;

        int max = int.MinValue;
        int row = 0;
        int fourth_row = 3;
        int variable = 0;

        for (int i = 0; i < A.GetLength(0); i++) 
        {
            if (A[i, 2] > max)
            {
                max = A[i, 2];
                row = i;
                
            }
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            variable = A[row, j];
            A[row, j] = A[fourth_row, j];
            A[fourth_row, j] = variable;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 5) return null;
        int max = int.MinValue;
        int column = 0;
        int fourth_column = 3;
        int variable = 0;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                column = i;
            }
        }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            variable = A[i, column];
            A[i, column] = A[i, fourth_column];
            A[i, fourth_column] = variable;
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
        int max_col = 0;
        int max_row = 0;
        int variable = 0;
        

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_row = i;
                    max_col = j;
                }
            }
            for (; max_col < m - 1; max_col++)
            {
                variable = A[i, max_col];
                A[i, max_col] = A[i,max_col+1];
                A[i, max_col + 1] = variable;
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

        for (int i = 0; i < C.GetLength(0); i++)
        {
            double maxi = double.MinValue;
            int max_col = 0;

            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j]>maxi)
                {
                    max_col = j;
                    maxi = C[i, j];
                }
            }
            
            for (int j_new = 0; j_new < max_col; j_new++)
            {
                if (maxi == 0) C[i, j_new] = C[i, j_new];
                else if (C[i, j_new] < 0) C[i, j_new] /= maxi; 
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
        if (Z.GetLength(0) != 6 && Z.GetLength(1) != 8) return null;
        double maxi = double.MinValue;
        int max_row = 0, max_col = 0;
        double sum = 0;
        double counter = 0;

        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    counter++;
                    sum += Z[i, j];
                }

                if (Z[i, j] > maxi)
                {
                    maxi = Z[i, j];
                    max_row = i;
                    max_col = j;
                }
            }
        }

        Z[max_row,max_col] = (sum) / (counter); 


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
        if (X.GetLength(0) != 6 && X.GetLength(1) != 5) return null;

        int variable = 0;
        //int count_max = 0, count_min = 0;
        int temporary_max = int.MinValue, temporary_min = int.MaxValue;
        int count = 0;
        int row_max = 0, row_min = 0;
        int[] neg_count = new int[X.GetLength(0)];

        for (int i = 0; i < X.GetLength(0); i++)
        {
            count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    count++;
                }
            }
            neg_count[i] = count;
        }

        for (int i = 0; i < neg_count.GetLength(0); i++)
        {
            if (neg_count[i] > temporary_max)
            {
                temporary_max = neg_count[i];
                row_max = i;
            }
            if (neg_count[i] < temporary_min)
            {
                temporary_min = neg_count[i];
                row_min = i;
            }

        }
        Console.WriteLine(row_max);
        Console.WriteLine(row_min);

        for (int i = 0; i < X.GetLength(1); i++)
        {
            variable = X[row_max, i];
            X[row_max, i] = X[row_min, i];
            X[row_min, i] = variable;
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
        int[] sum = new int[A.GetLength(0)];
        int count = 0, max_row = 0, max = int.MinValue;
        int[,] new_A = new int[A.GetLength(0) - 1, A.GetLength(1)];


        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) count += A[i, j];
            }
            sum[i] = count;
        }

        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] > max)
            {
                max = sum[i];
                max_row = i;
            }
        }

        for (int i = 0; i < new_A.GetLength(0); i++)
        {
            if (i < max_row)
            {
                for (int j = 0; j < new_A.GetLength(1); j++)
                {
                    new_A[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < new_A.GetLength(1); j++)
                {
                    new_A[i, j] = A[i + 1, j];
                }
            }

        }


        // end

        return new_A;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;

        int min_element = int.MaxValue;
        int min_index = 0;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min_element)
            {
                min_element = A[4, i];
                min_index = i;
            }

        }

        if (min_index == A.GetLength(1) - 1) return null;
        //Console.WriteLine(min_index);

        int temp = 0;


        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1) - 1; j > min_index + 1; j--)
            {
                A[i, j] = temp;
                A[i, j] = A[i, j - 1];
                A[i, j - 1] = temp;
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, min_index + 1] = B[i];
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

        int[] max = new int[A.GetLength(0)];
        double local_mx = double.MinValue;
        int index_mx = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            local_mx = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > local_mx)
                {
                    local_mx = A[i, j];
                    index_mx = j;
                }
            }
            max[i] = index_mx;
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {

                if (j == max[i])
                {
                    if (A[i, j - 1] < A[i, j + 1])
                    {
                        if (A[i, j - 1] < 0)
                        {
                            A[i, j - 1] = A[i, j - 1] / 2;
                        }
                        if (A[i, j - 1] > 0)
                        {
                            A[i, j - 1] = A[i, j - 1] * 2;
                        }
                    }
                    else
                    {
                        if (A[i, j + 1] < 0)
                        {
                            A[i, j + 1] = A[i, j + 1] / 2;
                        }
                        if (A[i, j + 1] > 0)
                        {
                            A[i, j + 1] = A[i, j + 1] * 2;
                        }
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;


        int index_mx = 0;

        int[] max = new int[A.GetLength(1)];
        int[] pos = new int[A.GetLength(1)];
        int[] neg = new int[A.GetLength(1)];


        for (int j = 0; j < A.GetLength(1); j++)
        {
            int local_max = int.MinValue;
            int count_pos = 0;
            int count_neg = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > local_max)
                {
                    local_max = A[i, j];
                    index_mx = i;
                }
                if (A[i, j] > 0)
                {
                    count_pos++;
                }
                if (A[i, j] < 0)
                {
                    count_neg++;
                }

            }
            max[j] = index_mx;
            pos[j] = count_pos;
            neg[j] = count_neg;
        }


        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (i == max[j])
                {
                    if (pos[j] > neg[j])
                    {
                        A[i, j] = 0;
                    }
                    if (pos[j] < neg[j])
                    {
                        A[i, j] = max[j] + 1;
                    }
                }

            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        int[] max = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maximum = int.MinValue;
            int max_index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maximum < A[i, j])
                {
                    maximum = A[i, j];
                    max_index = i;
                }
            }
            max[j] = max_index;
        }

        int[] sum = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int summa = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (i > max[j])
                {
                    summa += A[i, j];
                }
            }
            sum[j] = summa;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max[j] < A.GetLength(0) / 2)
                {
                    A[0, j] = sum[j];
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        int[] max = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maximum = int.MinValue;
            int max_index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maximum < A[i, j])
                {
                    maximum = A[i, j];
                    max_index = i;
                }
            }
            max[j] = max_index;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max[j] == i && max[j] < B[j])
                {
                    A[i, j] = B[j];
                }
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int[] max = new int[A.GetLength(1)];
        double[] summa = new double[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maximum = double.MinValue;
            int max_index = 0;
            double sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maximum < A[i, j])
                {
                    maximum = A[i, j];
                    max_index = i;
                }
                if (i == 0 || i == A.GetLength(0) - 1) sum += A[i, j];
            }
            max[j] = max_index;
            summa[j] = sum / 2;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max[j] == i && max[j] < summa[j])
                {
                    A[i, j] = summa[j];
                }
                if (max[j] == i && max[j] >= summa[j])
                {
                    A[i, j] = max[j] + 1;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        //int[,] answer = default(int[,]);
        // code here
        if (n < 0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < answer.GetLength(1); i++)
        {
            answer[i % 3, i] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int max = int.MinValue;
        int max_col = 0;
        int max_row = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j && A[i, j] > max)
                {
                    max = A[i, j];
                    max_col = j;
                    max_row = i;
                }
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < max_row && j > i)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int[] maximum = new int[A.GetLength(0)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            int max_index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    max_index = j;
                }
            }
            maximum[i] = max_index;
        }

        int temp = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maximum[i] == j && i % 2 == 0)
                {
                    temp = A[i, maximum[i]];
                    A[i, maximum[i]] = A[i + 1, maximum[i + 1]];
                    A[i + 1, maximum[i + 1]] = temp;
                }
            }

        }

        // end

        return A;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        int[,] backwards = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0, l = 0; i < A.GetLength(0); i++, l++)
        {
            for (int j = A.GetLength(1) - 1, k = 0; j >= 0; j--, k++)
            {
                backwards[l, k] = A[i, j];
            }
        }

        // end

        return backwards;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        int[] minimum = new int[A.GetLength(0)];
        int[] sorted = new int[A.GetLength(0)];
        int[] indexes = new int[A.GetLength(0)];


        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    index = i;
                }
            }
            minimum[i] = min;
            sorted[i] = min;
            indexes[i] = index;
        }


        //  Эффективная гномья сортировка

        for (int i = 1, j = 2; i < sorted.Length;)
        {
            if (i == 0 || sorted[i] <= sorted[i - 1])
            {
                i = j;
                j++;
            }
            else
            {
                int temp = sorted[i];
                sorted[i] = sorted[i - 1];
                sorted[i - 1] = temp;
                i--;
            }
        }
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.WriteLine(sorted[i]);
        }
        int[] sorted_ind = new int[A.GetLength(0)];

        for (int i = 0; i < minimum.Length; i++)
        {
            for (int j = 0; j < sorted.Length; j++)
            {
                if (minimum[j] == sorted[i])
                {
                    indexes[i] = j;
                    minimum[j] = int.MaxValue;
                    sorted[i] = int.MinValue;
                }
            }

        }

        int[,] matrix = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int k = 0; k < indexes.Length; k++)
            {
                if (indexes[k] == i)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        matrix[k, j] = A[i, j];
                    }
                }
            }

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
        //int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        answer = new int[2 * matrix.GetLength(0) - 1];

        for (int i = matrix.GetLength(0) - 1, index = 0; i >= 0; i--, index++)
        {
            int row = i, col = 0, sum_left = 0, sum_right = 0;
            while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                sum_left += matrix[row, col];
                sum_right += matrix[col, row];
                row++; col++;
            }
            answer[index] = sum_left;
            answer[2 * matrix.GetLength(0) - 2 - index] = sum_right;
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

        if (matrix.GetLength(0) != matrix.GetLength(1) || k <= 0) return null;
        int max_row = 0, max_col = 0;
        k--;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max_row, max_col]))
                {
                    max_row = i;
                    max_col = j;
                }
        }

        if (max_col != k)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int temp = matrix[i, max_col];
                matrix[i, max_col] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        if (max_row != k)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[max_row, j];
                matrix[max_row, j] = matrix[k, j];
                matrix[k, j] = temp;
            }
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

        if (A.Length + A.Length - n != n*n || B.Length + B.Length - n != n * n) return null;

        int[,] matrix_A = new int[n, n];
        int[,] matrix_B = new int[n, n];

        for (int i = 0, index_mas = 0; i < matrix_A.GetLength(0); i++)
        {
            for (int j = i; j < matrix_A.GetLength(1); j++)
            {
                matrix_A[i, j] = A[index_mas];
                matrix_A[j, i] = A[index_mas];
                matrix_B[i, j] = B[index_mas];
                matrix_B[j, i] = B[index_mas];
                index_mas++;
            }
        }

        answer = new int[matrix_A.GetLength(0) * matrix_A.GetLength(0)];

        for (int i = 0, k = 0; i < matrix_A.GetLength(0); i++)
        {

            for (int index = 0; index < matrix_A.GetLength(0); index++)
            {
                int sum = 0;
                for (int j = 0; j < matrix_A.GetLength(1); j++)
                {
                    sum += matrix_A[i, j] * matrix_B[j, index];
                }
                answer[k] = sum;
                k++;
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
    public int[,] Task_3_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        int[] count_neg = new int[A.GetLength(1)];
        int[] sorted = new int[A.GetLength(1)];
        int[] indexes = new int[A.GetLength(1)];


        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                {
                    count++;

                }
            }
            count_neg[j] = count;
            sorted[j] = count;
            indexes[j] = j;
        }


        //  Эффективная гномья сортировка

        for (int i = 1, j = 2; i < sorted.Length;)
        {
            if (i == 0 || sorted[i] >= sorted[i - 1])
            {
                i = j;
                j++;
            }
            else
            {
                int temp = sorted[i];
                sorted[i] = sorted[i - 1];
                sorted[i - 1] = temp;
                i--;
            }
        }

        int[] sorted_ind = new int[A.GetLength(1)];

        for (int i = 0; i < sorted.Length; i++)
        {
            for (int j = 0; j < count_neg.Length; j++)
            {
                if (sorted[i] == count_neg[j] && sorted[i] != -1 && count_neg[j] != -1)
                {
                    sorted_ind[i] = j;
                    sorted[i] = -1;
                    count_neg[j] = -1;
                }
            }
        }

        int[,] matrix = new int[A.GetLength(0), A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int k = 0; k < sorted_ind.Length; k++)
            {
                if (sorted_ind[k] == j)
                {
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        matrix[i, k] = A[i, j];
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
    public int[,] Task_3_11(int[,] A)
    {
        // code here
        int[] count_neg = new int[A.GetLength(0)];
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 0)
                {
                    count++;
                }
            }
            count_neg[i] = count;
        }

        int count_ind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (count_neg[i] == 0)
                count_ind++;
        }
        int[] indexes = new int[count_ind];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (count_neg[i] == 0)
                indexes[i] = i;
        }

        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    Console.WriteLine(indexes[i]);
        //}

        int[,] new_A = new int[indexes.Length, A.GetLength(1)];
        for (int i = 0; i < indexes.Length; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (indexes[i] == i)
                {
                    new_A[i, j] = A[i, j];
                }
            }
        }
        //for (int i = 0; i < new_A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < new_A.GetLength(1); j++)
        //    {
        //        Console.WriteLine(new_A[i, j]);
        //    }
        //}
        // end

        return new_A;
    }
    #endregion
}