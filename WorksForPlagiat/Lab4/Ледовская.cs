using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };

        int count = 0;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }

        int[] con_null = new int[count];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    con_null[index] = i;
                    index++;
                    break;
                }
            }
        }

        int[,] B = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        index = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int fl = 0;
            for (int k = 0; k < count; k++)
            {
                if (i == con_null[k])
                {
                    fl = 1;
                    break;
                }
            }
            if (fl == 1) break;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                B[index, j] = matrix[i, j];
            }
            index++;
        }


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0:d} ", matrix[i, j]);

            }
            Console.WriteLine();
        }
        // end


    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                answer += A[i, j];
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return (0,0);

        int mn = int.MaxValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] < mn)
                {
                    mn= A[i, j];
                    row = i;
                    col = j;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return null;

        fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] != 0) fl = 1;
        if (fl==0) return answer;
        answer = new int[A.GetLength(1)];
        int index = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = int.MinValue;
            for (int j = 0; j < A.GetLength(0); j++)
                if (A[j, i] > mx) mx = A[j, i];
            answer[index] = mx;
            index++;
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
        int mx = int.MinValue;
        int line_index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > mx)
            {
                mx = A[i, 2];
                line_index = i;
            }
        }
        if (A.GetLength(0) < 4) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int save = A[line_index, i];
            A[line_index, i] = A[3, i];
            A[3,i]= save;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return null;

        int mx = int.MinValue, column_index = 0;
        if (A.GetLength(1) < 4 || A.GetLength(0) != A.GetLength(1)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > mx)
            {
                mx= A[i, i];
                column_index = i;
            }
        }
      
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int save = A[i, column_index];
            A[i, column_index] = A[i, 3];
            A[i,3]= save;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return null;

        for (int i = 0; i < n; i++)
        {
            int mx = A[i, 0], mxindex = 0;
            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > mx)
                {
                    mx= A[i, j];
                    mxindex = j;
                }
            }
            for (int j = mxindex; j < m - 1; j++)
                A[i, j] = A[i, j + 1];
            A[i, m - 1] = mx;
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
        int fl = 0;
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (C.GetLength(0) == 0 || C.GetLength(1) == 0 || fl == 0) return null;

        for (int i = 0; i < n; i++)
        {
            double mx = C[i, 0];
            int mxindex = 0;
            for (int j = 1; j < m; j++)
            {
                if (C[i, j] > mx)
                {
                    mx = C[i, j];
                    mxindex = j;
                }
            }
            for (int j = 0; j < mxindex; j++)
            {
                if (C[i, j] < 0) C[i, j] /= mx;
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
        int fl = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (Z.GetLength(0) == 0 || Z.GetLength(1) == 0 || fl == 0) return null;

        double mx = Z[0, 0];
        int[] mxindex=new int[2];
        double sumpos = 0;
        int countpos = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > mx)
                {
                    mx = Z[i, j];
                    mxindex=new int[2]{i,j};
                }
                if (Z[i, j] > 0)
                {
                    sumpos += Z[i, j];
                    countpos++;
                }
            }
        }
        if (sumpos == 0) return null;
        Z[mxindex[0], mxindex[1]] = sumpos / countpos;
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
        int fl = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (X.GetLength(0) == 0 || X.GetLength(1)==0 || fl==0) return null;


        int max=0, min= int.MaxValue, index_max = 0, index_min =0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0) count++;
            }
            if (count < min) 
            {
                    index_min = i;
                    min= count;

            }
            if (count > max)
            {
                index_max =i;
                max = count;
            }
        }
        for (int i = 0; i < X.GetLength(1); i++)
        {
            int save = X[index_min, i];
            X[index_min, i] = X[index_max, i];
            X[index_max,i]= save;
        }
        if (index_max == index_min) return null;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    fl = 1;
                }
            }
        }

        if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || fl == 0) return null;

        int max_sum = 0, index_max_sum = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) sum += A[i, j];
            }
            if (sum > max_sum)
            { 
                max_sum = sum;
                index_max_sum = i;
            }
        }
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < index_max_sum; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                B[i, j] = A[i, j];
        }
        for (int i = index_max_sum+1; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                B[i-1, j] = A[i, j];
        }
        if (max_sum == 0) return null;
        A = B;
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
 
        int fl = 0;
        foreach (int i in A)
        {
            if (i != 0) fl = 1;
        }
        if (fl == 0) return null;

        fl = 0;
        foreach (int i in B)
        {
            if (i != 0) fl = 1;
        }
        if (fl == 0) return null;

        int min_column = 0, min = int.MaxValue;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                min_column = i;
            }
        }

        int[,] C = new int[5, 8];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < min_column + 1; j++)
                C[i, j] = A[i, j];
        }


        for (int i = 0; i < A.GetLength(0); i++)
        {
            C[i, min_column + 1] = B[i];
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = min_column + 2; j < 8; j++)
                C[i, j] = A[i, j];
        }

        A = C;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null; 

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double mx = A[i, 0];
            int index_mx = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index_mx = j;
                }
            }

            if (index_mx == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else
                {
                    A[i, 1] /= 2;
                }
            }
            if (index_mx == A.GetLength(1) - 1)
            {
                if (A[i, 1] > 0) A[i, A.GetLength(1) - 2] *= 2; 
                else
                {
                    A[i, A.GetLength(1) - 2] /= 2;
                }

            }
           
            else
            {
                int index = index_mx - 1;
                if (A[i, index_mx + 1] < A[i, index_mx - 1]) 
                    index = index_mx + 1;
           
                if (A[i, index] > 0) A[i, index] *= 2; 
                else
                {
                    A[i, index] /= 2;
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
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int count_pos = 0, count_neg = 0, mx = A[0, i], mx_index = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j,i]>0) count_pos++;
                if (A[j,i]<0) count_neg++;

                if (A[j, i] > mx)
                {
                    mx= A[j,i];
                    mx_index = j;
                }
            }
            if (count_pos > count_neg) A[mx_index, i] = 0;
            else A[mx_index, i] = mx_index+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = A[0, i], mx_line = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx= A[j, i];
                    mx_line = j;
                }
            }
            if (mx_line < 5)
            {
                int sum = 0;
                for (int j=mx_line+1;j<A.GetLength(0);j++)
                    sum += A[j, i];
                A[0, i] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        fl = 0;
        for (int i = 0; i < B.Length; i++)
        {

            if (B[i] != 0) fl = 1;

        }
        if (fl == 0) return null;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = A[0,i], index_line = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j,i]>mx)
                {
                    mx=A[j,i];
                    index_line = j;
                }
            }
            if (B[i] > mx) A[index_line, i] = B[i];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            double mx = A[0, i];
            int index_line = 0;

            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    index_line = j;
                }
            }
            if (mx < (A[0, i] + A[A.GetLength(0) - 1, i] / 2)) A[index_line, i] = (A[0, i] + A[A.GetLength(0) - 1, i] / 2);
            else A[index_line, i] = index_line+1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return null;

        answer =new  int[n, 3 * n];
        int start = 0;
        for (int i = 0; i < n; i++)
        {
            int start1 = start;
            for (int j = 0; j < 3; j++)
            {
                answer[i, start1] = 1;
                start1 += n;
            }
            start += 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        int mx = A[0, 0], mx_line = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > mx)
            {
                mx= A[i, i];
                mx_line = i;
            }
        }

        int start_column = 1;
        for (int i = 0; i < mx_line; i++,start_column++)
        {
            for (int j = start_column; j < A.GetLength(1); j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int k = 0; k < (B.GetLength(0) / 2); k++)
        {
            int mx1 = B[k * 2, 0], index_column1 = 0;
            int mx2 = B[k * 2 + 1, 0], index_column2 = 0;

            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[k * 2, j]> mx1)
                {
                    mx1 = B[k * 2, j];
                    index_column1 = j;
                }

                if (B[k * 2+1, j]> mx2)
                {
                    mx2 = B[k * 2+1, j];
                    index_column2 = j;
                }
            }

            B[k * 2+1, index_column2] = mx1;
            B[k * 2, index_column1] = mx2; 

        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int fl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j=0;j<(A.GetLength(1)/2);j++)
            {
                int save = A[i, A.GetLength(1)-j-1];
                A[i, A.GetLength(1)-j-1] = A[i, j];
                A[i, j] = save;

            }
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
        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;


        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[0, i] = 0;
            matrix[matrix.GetLength(1) - 1, i] = 0;

            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;

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
        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        int end_column = matrix.GetLength(1)/2;
        for (int i = (matrix.GetLength(0) / 2); i< matrix.GetLength(0); i++,end_column++)
        {
            for (int j = 0; j <= end_column; j++)
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
        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return (null, null);

        int[] upper = default(int[]);
        int[] lower = default(int[]);
        //code here

        int count_upper = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            count_upper += (matrix.GetLength(0) - i);

        int n = matrix.GetLength(0);
        upper = new int[count_upper];
        lower = new int[n * n - count_upper];

        int start_column = 0;
        int index = 0;
        for (int i = 0; i < n; i++, start_column++)
        {
            for (int j = start_column; j < n; j++)
            {
                upper[index] = matrix[i, j];
                index++;
            }
        }

        int end_column = 0;
        index = 0;
        for (int i = 0; i < n; i++, end_column++)
        {
            for (int j = 0; j < end_column; j++)
            {
                lower[index] = matrix[i, j];
                index++;
            }
        }

        //end

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

        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {

            for (int j = 1; j < matrix.GetLength(0) - i; j++)
            {
                int count1 = 0;
                int count2 = 0;

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[j - 1, k] > 0) count1++;
                    if (matrix[j, k] > 0) count2++;
                }

                if (count2 > count1)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        int save = matrix[j, k];
                        matrix[j, k] = matrix[j - 1, k];
                        matrix[j - 1, k] = save;
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

        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                for (int k = 1; k < matrix.GetLength(1) - j; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] > matrix[i, k - 1])
                        {
                            int save=matrix[i, k];
                            matrix[i, k] = matrix[i, k - 1];
                            matrix[i, k - 1] = save;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        if (matrix[i, k] < matrix[i, k - 1])
                        {
                            int save = matrix[i, k];
                            matrix[i, k] = matrix[i, k - 1];
                            matrix[i, k - 1] = save;
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
        int fl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) fl = 1;
            }
        }
        if (fl == 0) return null;

        int count = 0;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j]==0)
                {
                    count++;
                    break;
                }
            }
        }

        int[] con_null = new int[count];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    con_null[index] = i;
                    index++;
                    break;
                }
            }
        }

        int[,] B = new int[matrix.GetLength(0)-count, matrix.GetLength(1)];
        index = 0;

        for (int i = 0; i< matrix.GetLength(0); i++)
        {
            fl = 0;
            for (int k=0; k < count; k++)
            {
                if (i == con_null[k])
                {
                    fl = 1;
                    break;
                }
            }
            if (fl == 1) break;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                B[index, j] = matrix[i, j];
            }
            index++;
        }
        matrix = B;

        // end

        return matrix;
    }
    #endregion
}