using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
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
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
        int n = 3;
        int[] vector = new int[] { 10, 20, 30, 0, -50 };
        program.Task_3_10(matrix);

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i,j]+ " ");
            }
            Console.WriteLine();
        }
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        // code here
        if (rows == 5 && cols == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    answer += A[i, j];
                }
            }
        }
        else
        {
            Console.WriteLine("Pizza");
            return 0;

        }
            
        // end
        Console.WriteLine();
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        double s = 0;
        int count = 0;
        // code here
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows == 5 && cols == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i, j] > 0)
                    {
                        s += A[i, j];
                        count++;
                    }
                        
                }
            }
        }
        else
            return 0;
        // end
        answer = s / count;
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
        int num_row = A.GetLength(0);
        int num_col = A.GetLength(1);
        double m = double.MaxValue;
        if (num_row == 3 && num_col == 6)
        {
            for (int i = 0; i < num_row; i++)
            {
                for (int j = 0; j < num_col; j++)
                {
                    if (A[i, j] < m)
                    {
                        Console.WriteLine(A[i,j]);
                        row = i;
                        col = j;
                        m = A[i, j];
                        Console.WriteLine("Pizza " + m);
                    }
                }
            }
        }
        else

        {
            Console.WriteLine("j");
            return (0, 0);
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
        
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int m = int.MinValue;
        //int[] answer = default(int[]);
        int[] answer = new int[col];
        if (row == 3 && col == 5)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (A[j, i] > m)
                    {
                        m = A[j, i];
                    }
                }
                Console.WriteLine(m);
                answer[i] = m;
                m = int.MinValue;
            }
        }
        else
        {
            Console.WriteLine("Pizza");
            return null;
        }
        // end
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
        }
        
        return answer;
        // end
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end
        Console.WriteLine(answer);
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

        
        double max = double.MinValue;
        int index = 0;
        int cnt = 0;
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[] temp = new int[col];
        if (row == 5 && col == 7)
        {
            for (int i = 0; i < row; i++)
            {
                if (A[i, 2] > max)
                {
                    max = A[i, 2];
                    index = i;
                }
            }

            for (int i = 0; i < col; i++)
            {
                temp[cnt] = A[index, i];
                
                A[index, i] = A[3, i];
                A[3, i] = temp[cnt];
                cnt++;
            }
        }
        else
            return null;
        Console.WriteLine();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < temp.Length; i++)
        {
            Console.Write(temp[i] +" ");
        }
        Console.WriteLine();
        Console.WriteLine("index "+ index);
        Console.WriteLine("max " + max);

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
        int[] temp = new int[A.GetLength(0)];
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int index = 0;
        
        double max = double.MinValue;
        if (row == 5 && col == 5)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    index = 1;
                }
            }
            Console.WriteLine("max "+ max);
            Console.WriteLine("index " + index + " " + index);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                temp[i] = A[i, index];
                A[i, index] = A[i, 3];
                A[i, 3] = temp[i];
            }
        }
        else
            return null;
        // end
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(A[i,j]+" ");
            }
            Console.WriteLine();
        }
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
        int[,] B = new int[n, m];
        int[] max_index = new int[n];
        double max = double.MinValue;
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            //Console.WriteLine(max);
            max_index[i] = index;
            max = double.MinValue;
            index = -1;
        }
        for (int i = 0;i < n; i++)
        {
            for (int j = 0;j < m-1; j++)
            {
                if (j < max_index[i])
                {
                    B[i, j] = A[i, j];
                }
                else
                {
                    B[i,j] = A[i, j+1];
                }

                
            }
            B[i, m - 1] = A[i, max_index[i]];
        }
        
        for (int i = 0; i < max_index.Length; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(B[i,j] + " ");
            }
            Console.WriteLine();

        }
        // end

        return B;
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
        int[,] B = new int[n,m];
        int[] index = new int[n];
        double max = double.MinValue;
        int max_index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j=0; j < m; j++)
            {
                if (C[i,j] > max)
                {
                    max = C[i,j];
                    max_index = j;
                }
                
            }
            if (max != 0)
                index[i] = max_index;
            else
                index[i] = -1;
            max = double.MinValue;
            max_index = 0;
        }
        bool flag = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (index[i] == -1)
                    {
                        break;
                    }
                if (flag == false)
                {   
                    if (j == index[i])
                    {
                        flag= true;
                        continue;
                    }
                    if (C[i,j]<0)
                        C[i, j] = C[i, j]/C[i,index[i]];
                }
            }
            flag = false;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j < m; j++)
            {
                Console.Write(C[i,j]+ " ");
            }
            Console.WriteLine();
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
        double max = double.MinValue;
        int max_index_row = 0;
        int max_index_col = 0;
        int count = 0;
        int row = Z.GetLength(0);
        int col = Z.GetLength(1);
        double sr=0;
        if (row!=6 || col != 8)
        {
            return null;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (Z[i, j] > 0)
                {
                    sr += Z[i, j];
                    count++;
                }
                    

                if (Z[i,j] > max)
                {
                    max = Z[i, j];
                    max_index_row = i;
                    max_index_col = j;
                }
            }
        }
        sr /= count;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                if (i==max_index_row && j == max_index_col)
                {
                    Z[i, j] = sr;
                }
            }
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
        int[] temp = new int [X.GetLength(0)];
        int row = X.GetLength(0);
        int col = X.GetLength(1);
        int count_min = int.MaxValue;
        int count_min_row = -1;
        int count_max = int.MinValue;
        int count_max_row = -1;
        int count = 0;
        if (row != 6 || col != 5)
        {
            return null;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (X[i,j] < 0)
                {
                    count++;
                }
            }
            if (count < count_min)
            {
                count_min = count;
                count_min_row = i;
            }
            else if (count > count_max)
            {
                count_max = count;
                count_max_row = i;
            }
            count = 0;
        }
        // end
        for (int i = 0; i < col; i++)
        {
            temp[i] = X[count_min_row, i];
            X[count_min_row, i] = X[count_max_row, i];
            X[count_max_row, i] = temp[i];
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                Console.Write(X[i,j] +" ");
            }
            Console.WriteLine();
        }
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        
        double sum = 0;
        int max_sum_index = int.MinValue;
        double max_sum = double.MinValue;
        if (row != 7 || col != 5)
        {
            return null;
        }
        int[,] B = new int[row-1,col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i,j] > 0)
                    sum += A[i, j];
            }
            if (sum > max_sum)
            {
                max_sum_index = i;
                max_sum = sum;
            }
            sum = 0;
        }
        Console.WriteLine(max_sum_index);
        int index = 0;
        for ( int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                if (max_sum_index != i)
                {
                    B[index, j] = A[i, j];
                }
                else
                {
                    index--;
                    break;
                }

                    
            }
            index++;
        }
        // end
        //for (int i = 0; i < row-1; i++)
        //{
        //    for (int j = 0; j < col; j++)
        //    {
        //        Console.Write(B[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double min = double.MaxValue;
        int index_min = 0;
        int[,] res= new int[row,col];
        if (row != 5 || col != 8 || B.Length != 5)
            return null;
        Console.WriteLine(row + " * " + col);
        for (int j = 0;j < col-1; j++)
        {
            if (A[4,j] < min)
            {
                index_min = j;
                min = A[4, j];
            }
        }
        Console.WriteLine(min);
        bool flag = false;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (flag == false)
                {
                    if (j <= index_min)
                    {
                        res[i, j] = A[i, j];
                    }
                    else if (j > index_min)
                    {
                        res[i, j] = B[i];
                        flag = true;
                    }
                }
                else
                {
                    res[i, j] = A[i, j];
                }
            }
            flag = false;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return res;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int max_index = -1;
        double elem = 0, a=0,b=0;
        double max = double.MinValue;
        if (row != 5 || col != 7)
            return null;
        for (int i = 0; i < row; i++)
        {
            for(int j = 0;j < col; j++)
            {
                if (A[i,j] > max)
                {
                    max=A[i,j];
                    max_index = j;
                }
            }
            if (max_index == 0)
            {
                elem = A[i, 1];
                A[i, 1] = elem*2;
            }
            else if (max_index == 6)
            {
                elem=A[i, 5];
                A[i,5] = elem*2;
            }
            else
            {
                a=A[i, max_index-1];
                b = A[i, max_index+1];
                if (a > b)
                {
                    if (b>0)
                        A[i, max_index + 1] = b * 2;
                    else
                        A[i, max_index + 1] = b / 2;
                }
                else
                {
                    if (a>0)
                        A[i, max_index - 1] = a * 2;
                    else
                        A[i, max_index - 1] = a / 2;
                }
                    
            }
        }
        // end
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int cnt_pol = 0, cnt_otr = 0, row = A.GetLength(0), col = A.GetLength(1), index_max = 0;
        double max = double.MinValue;
        if (row != 7 || col != 5)
            return null;
        for (int i = 0; i < col; i++)
        {
            for (int j = 0;j < row; j++)
            {
                if (A[j,i] > max)
                {
                    index_max = j;
                    max = A[j,i];
                }
                if (A[j,i] > 0)
                {
                    cnt_pol++;
                }
                else if (A[j,i] < 0)
                {
                    cnt_otr++;
                }

            }
            if (cnt_pol > cnt_otr)
            {
                A[index_max, i] = 0;
            }
            else
            {
                A[index_max, i] = index_max;
            }
            cnt_pol = 0;
            cnt_otr = 0;
            max = double.MinValue;
            index_max = -1;

        }
        // end
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double max = double.MinValue;
        int sum = 0;
        int index_max = -1;
        int now_col = 0;
        if (row!=10 || col != 5)
        {
            return null;
        }
        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index_max = i;
                }
            }

            if (index_max < 4)
            {
                //Console.WriteLine(index_max+" "+max);
                for ( int k = index_max+1; k < row; k++)
                {
                    sum += A[k,j];
                    


                }
                //Console.Write(sum+" ");
                A[0, j] = sum;
                
            }
            sum = 0;
            max = double.MinValue;
            index_max = 0;
            
        }
        // end
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double max = double.MinValue;
        int index_max = -1;
        if (row != 7 || col != 5 || B.Length != 5)
            return null;
        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row; i++)
            {
                if (A[i,j] > max)
                {
                    index_max = i;
                    max = A[i,j];
                }
            }
            if (B[j] > max)
            {
                Console.WriteLine("Pizza");
                A[index_max, j] = B[j];
            }
            max = double.MinValue;
            index_max = -1;

               
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double max = double.MinValue;
        int index_max = 0;
        double sum = 0;
        if (row != 7 || col != 5)
            return null;
        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row; i++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    index_max = i;

                }
                
            }
            sum = (A[0, j] + A[6, j])/2;
            if (sum > max)
            {
                A[index_max, j] = sum;
            }
            else
                A[index_max, j] = index_max;
            sum = 0;
            max = double.MinValue;
            index_max = 0;

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0)
        {
            return null;
        }
        int[,] answer = new int[n,3*n];
        // code here

        int row = answer.GetLength(0);
        int col = answer.GetLength(1);
        Console.WriteLine(row+" "+ col);
        for (int i = 0; i < col; i++)
        {
            answer[i % 3, i] = 1;
        }
        // end
        
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int max = int.MinValue;
        int index_max = 0;
        if (row != 6 || col != 6)
        {
            return null;
        }
        for (int i = 0; i < row; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                index_max = i;
            }
        }
        int row_cnt = 1;
        for (int i = 0; i < index_max; i++)
        {

            for (int j = row_cnt; j < row; j++)
            {
                A[i, j] = 0;
            }
            row_cnt++;
            if (row_cnt > 5)
            {
                break;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int row = B.GetLength(0);
        int col = B.GetLength(1);
        int[] maxes = new int[6];
        int index_max = 0;
        int max = int.MinValue;
        if (row != 6 || col != 6)
            return null;
        for (int i = 0; i < row; i++)
        {
            for (int j =0; j < col; j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    index_max = j;
                }

            }
            maxes[i] = index_max;
            max = int.MinValue;
            index_max = 0;
        }
        for (int i = 0; i < maxes.Length; i++)
        {
            Console.Write(maxes[i] +" ");
        }
        Console.WriteLine();
        Console.WriteLine();
        int temp = 0;
        for (int i = 0; i < row; i+=2)
        {
            temp = B[i, maxes[i]];
            B[i, maxes[i]] = B[i+1, maxes[i+1]];
            B[i+1, maxes[i+1]] = temp;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int[,] B = new int[6, 7];
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        if (row != 6 || col != 7)
            return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                B[i,j] = A[i,6-j];
            }
        }
        // end
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        return B;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != col)
            return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                if (i==0 || j==0 || i==row-1 || j==col - 1)
                {
                    matrix[i, j] = 0;
                }
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != col)
            return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if ((i> (row / 2) - 1) && (i>=j))
                {
                    matrix[i, j] = 1;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int[] upper = new int[row*(col - 1)/2 + row];
        int[] lower = new int[row * (col - 1) / 2];
        // code here
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] +" ");
        }
        if (row != col)
            return (null, null);
        int cnt1 = 0, cnt2 = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                if (i > j)
                {
                    lower[cnt1] = matrix[i,j];
                    cnt1++;
                }
                else
                {
                    upper[cnt2] = matrix[i,j];
                    cnt2++;
                }
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != 7 || col != 5)
            return null;
        int[,] res = new int[row, col];
        int[] cnt_pos = new int[row];
        int[] cnt_pos_index = new int[row];
        for (int i = 0; i < row; i++)
        {
            int count = 0;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] > 0)
                    count++;
            }
            cnt_pos[i] = count;
            cnt_pos_index[i] = i;
        }
        for (int i = 0; i < cnt_pos.Length; i++)
        {
            Console.Write(cnt_pos[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < cnt_pos.Length; i++)
        {
            Console.Write(cnt_pos_index[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < cnt_pos.Length; i++)
        {
            for (int j = 0;j<cnt_pos.Length-i-1; j++)
            {
                if (cnt_pos[j+1] > cnt_pos[j])
                {
                    int temp = cnt_pos[j+1];
                    cnt_pos[j+1] = cnt_pos[j];
                    cnt_pos[j] = temp;
                    int temp2 = cnt_pos_index[j+1];
                    cnt_pos_index[j + 1] = cnt_pos_index[j];
                    cnt_pos_index[j] = temp2;
                }
            }
        }
        for (int i = 0; i < cnt_pos.Length; i++)
        {
            Console.Write(cnt_pos[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < cnt_pos.Length; i++)
        {
            Console.Write(cnt_pos_index[i] + " ");
        }
        Console.WriteLine();
        // end
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                res[i,j] = matrix[cnt_pos_index[i],j];
            }
        }
        return res;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        
        int[,] res = new int [row,col];
        for (int i = 0; i < row; i++)
        {
            int[] array = new int[col];
            for (int j = 0; j < col; j++)
            {
                array[j] = matrix[i, j];
            } 
            for (int l = 0; l < array.Length; l++)
            {

                for (int k = 0; k < array.Length-l-1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (array[k] < array[k + 1])
                        {
                            int temp = array[k];
                            array[k] = array[k + 1];
                            array[k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (array[k] > array[k + 1])
                        {
                            int temp = array[k];
                            array[k] = array[k + 1];
                            array[k + 1] = temp;
                        }
                    }
                }
                //for (int k = 0; k < array.Length-l -2; k++)
                //{
                //    if (k % 2 == 0)
                //    {
                //        if (array[k] < array[k + 2])
                //        {
                //            int temp = array[k];
                //            array[k] = array[k + 2];
                //            array[k + 2] = temp;
                //        }
                //    }
                //    else
                //    {
                //        if (array[k] > array[k + 2])
                //        {
                //            int temp = array[k];
                //            array[k] = array[k + 2];
                //            array[k + 2] = temp;
                //        }
                //    }
                //}
                //for (int t = 0;t< col; t++)
                //{
                //    Console.Write(array[t] +" ");
                //}
                //Console.WriteLine();
                //Console.WriteLine();

            }
            for (int j = 0;j< col; j++)
            {
                res[i,j] = array[j];
            }

        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return res;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength (0);
        int col = matrix.GetLength (1);
        int[] a = new int[row];
        int cnt_0 = 0;
        for (int i = 0; i < row; i++)
        {
            bool flag = false;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i,j] == 0)
                {
                    flag = true;
                    cnt_0++;
                    break;
                }
            }
            if (!flag)
            {
                a[i] = i;
            }
        }
        for (int z = 0; z < row; z++)
        {
            Console.Write(a[z] +" ");
        }
        Console.WriteLine();
        Console.WriteLine("Pepperoni");
        int[] none_zero = new int[row-cnt_0];
        int index = 0;
        for (int i = 0; i < row-cnt_0; i++)
        {
            if (a[i] != 0)
            {
                none_zero[index] = a[i];
                index++;
            }
        }
        for (int k = 0;k < none_zero.Length; k++)
        {
            Console.Write(none_zero[k]+" ");
            
        }
        Console.WriteLine();
        Console.WriteLine("Pizza");
        Console.WriteLine();
        int n = none_zero.Length
;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (none_zero[j] > none_zero[j + 1])
                {
                    int temp = none_zero[j];
                    none_zero[j] = none_zero[j + 1];
                    none_zero[j + 1] = temp;
                }
            }
        }
        int[,] res = new int[row - cnt_0, col];
        
        for (int i = 0;i < res.GetLength(0); i++)
        {
            for (int j = 0; j < col; j++)
            {
                res[i,j] = matrix[none_zero[i],j];
            }
        }
        // end
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
        return res;
    }
    #endregion
}