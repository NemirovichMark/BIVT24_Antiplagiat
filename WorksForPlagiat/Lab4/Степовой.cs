using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System;


public class Program
{
    public static void Main()
    {
        Program program = new Program();
    // program.Task_1_11(new int[,] {
    //             { 1, 2, 3, 4, -5, -6, -7 },
    //             { 5, 11, -17, 11, -10, 6, 5 },
    //             { -9, -10, -11, -14, -15, -16, 1 },
    //             { -9, -10, -11, -14, -15, -6, -2 },
    //             { -9, -10, -11, -14, -15, 6, 4 }
    //         });
        program.Task_2_1(new double[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, -30, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
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

        double sum = 0, count = 0; 
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int i = 0; i < rows; i++) 
        { 
            for (int j = 0; j < cols; j++) 
            { 
                if (A[i, j] > 0) 
                { 
                    count++; 
                    sum += A[i, j]; 
                } 
            } 
        }

        answer = (count > 0) ? (sum / count) : 0;

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
        int count=0;

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        for (int i = 0; i < rows; i++) 
        { 
            for (int j = 0; j < cols; j++) 
            {
                count++;
                if (A[i, j] < 0) 
                { 
                    value=A[i,j];
                    rowIndex = i; 
                } 
            } 
        }

        rowIndex = (value < 0) ? (rowIndex) : 0;

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
        answer = new double[A.GetLength(0)];

        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) 
        return null;

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double count,sum;
        for (int i = 0; i < rows; i++) 
        {
            count=0;sum=0;
            for (int j = 0; j < cols; j++) 
            {
                if (A[i, j] > 0) 
                {
                    count++;
                    sum+=A[i,j];
                } 
            }
            answer[i] = (count > 0) ? (sum/count) : 0;
        }


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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        int[,] answer = new int[rows-1,cols];

        double amin=double.MaxValue;
        int amin_rows=0;

        for (int i = 0; i < rows; i++) 
        {
            if(A[i,0]<amin)
            {
                amin=A[i,0];
                amin_rows=i;
            }
        }

        int k=0;

        for (int i = 0; i < rows; i++) 
        {
            if (i==amin_rows)
            {
                continue;
            }
            for (int j = 0; j < cols; j++) 
            {
                answer[k,j]=A[i,j];
            }
            k++;
        }
        return answer;
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


        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 4 || cols != 3) 
        return null;

        answer = new int[cols];

        int count;

        for (int j = 0; j < cols; j++) 
        {
            count=0;
            for (int i = 0; i < rows; i++) 
            {
                if (A[i,j]<0)
                count++;
            }
            answer[j]=count;
        }

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
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows != n || cols != m) 
        return null;

        for (int i = 0; i < rows; i++) 
        {
            int a_min=int.MaxValue;
            int a_min_index=0;
            for (int j = 0; j < cols; j++) 
            {
                if (B[i,j]<a_min)
                {
                    a_min=B[i,j];
                    a_min_index=j;
                }
            }
            for (int k=a_min_index;k>0;k--)
            {
                int temp=B[i,k-1];
                B[i,k-1]=B[i,k];
                B[i,k]=temp;
            }
        }

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
        int rows = F.GetLength(0);
        int cols = F.GetLength(1);

        if (rows != n || cols != m) 
        return null;

        for (int i = 0; i < rows; i++) 
        {
            double first_negative=1;
            double last_negative=1;
            int counter=0;
            double a_max=double.MinValue;
            int a_max_index=0;
            for (int j = 0; j < cols; j++) 
            {
                if(a_max<F[i,j])
                {
                    a_max=F[i,j];
                    a_max_index=j;
                }
                if(F[i,j]<0)
                {
                    if(counter==0)
                    first_negative=F[i,j];
                    counter++;
                    last_negative=F[i,j];
                }
            }
            if (counter>0)
            F[i,a_max_index]=(first_negative+last_negative)/2;
        }

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
        int rows = G.GetLength(0);
        int cols = G.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        for (int i = 0; i < rows; i++) 
        {
            int a_max=int.MinValue;
            int a_max_index=-1;
            for (int j = 0; j < cols; j++) 
            {
                if(a_max<G[i,j])
                {
                    a_max=G[i,j];
                    a_max_index=j;
                }
            }
            for(int k=cols-1;k>a_max_index+1;k--)
            {
                G[i,k]=G[i,k-1];
            }

            G[i,a_max_index+1]=a_max;
        }

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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        if (B.Length != 7)
        return null;

        int a_max=int.MinValue;
        int a_max_index=-1;

        for(int k=0;k<rows;k++)
        {
            if (a_max<A[k,5])
            {
                a_max=A[k,5];
                a_max_index=k;
            }
        }

        for(int l=0;l<cols;l++)
        {
            A[a_max_index,l]=B[l];
        }

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
        int rows = F.GetLength(0);
        int cols = F.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        int[,]A=new int[5,6];

        double a_min=double.MaxValue;
        int a_min_index=-1;
        for (int j = 0; j < cols; j++) 
        {
            if(a_min>Math.Abs(F[1,j]))
            {
                a_min=F[1,j];
                a_min_index=j;
            }
        }
        a_min_index++;

        for (int i = 0; i < rows; i++) 
        {
            for (int k=0;k<a_min_index;k++)
            {
                A[i,k]=F[i,k];
            }
            for (int k=a_min_index+1;k<cols;k++)
            {
                A[i,k-1]=F[i,k];
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
        System.Console.WriteLine(a_min_index);



        return A;
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        for (int i = 0; i < rows; i++) 
        {
            double a_max=int.MinValue;
            int a_max_index=-1;
            double sum=0;
            double counter=0;
            for (int j = 0; j < cols; j++) 
            {
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=j;
                }
                if (A[i,j]>0)
                {
                    sum+=A[i,j];
                    counter++;
                }
            }
            A[i,a_max_index] = (counter > 0) ? (sum / counter) : 0;

        }

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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 5 || cols != 7) 
        return null;

        for (int i = 0; i < rows; i++) 
        { 
            double a_max=int.MinValue;
            int a_max_index=-1;
            for (int j = 0; j < cols; j++) 
            {
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=j;
                }
            } 
            if(a_max_index==0)
            A[i,a_max_index+1]*=2;
            else if(a_max_index==cols-1)
            A[i,a_max_index-1]*=2;
            else
            {
                if(A[i,a_max_index-1]<A[i,a_max_index+1])
                {
                    if(A[i,a_max_index-1]>0)
                    A[i,a_max_index-1]*=2;
                    else
                    A[i,a_max_index-1]*=0.5;
                }
                else
                {
                    if(A[i,a_max_index+1]>0)
                    A[i,a_max_index+1]*=2;
                    else
                    A[i,a_max_index+1]*=0.5;
                }
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }


        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5) 
        return null;


        for (int j = 0; j < cols; j++) 
        { 
            double a_max=int.MinValue;
            int a_max_index=-1;
            int count_negatives=0;
            int count_positive=0;
            for (int i = 0; i < rows; i++) 
            {
                if(A[i,j]>0)
                count_positive++;
                else if(A[i,j]<0)
                count_negatives++;
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=i;
                }
            }
            if(count_positive>count_negatives)
            A[a_max_index,j]=0;
            else
            A[a_max_index,j]=a_max_index+1;
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 10 || cols != 5) 
        return null;


        for (int j = 0; j < cols; j++) 
        { 
            double a_max=int.MinValue;
            int a_max_index=-1;
            int summa=0;
            for (int i = 0; i < rows; i++) 
            {
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=i;
                }
            }
            for (int i = 0; i < rows; i++) 
            {
                if(a_max_index<i)
                {
                    summa+=A[i,j];
                }
            }
            if(a_max_index<=rows/2)
            {
                A[0,j]=summa;
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5 || B.Length!=5) 
        return null;


        for (int j = 0; j < cols; j++) 
        { 
            double a_max=int.MinValue;
            int a_max_index=-1;
            for (int i = 0; i < rows; i++) 
            {
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=i;
                }
            }
            if(a_max<B[j])
            {
                A[a_max_index,j]=B[j];
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 7 || cols != 5) 
        return null;


        for (int j = 0; j < cols; j++) 
        { 
            double a_max=int.MinValue;
            int a_max_index=-1;
            for (int i = 0; i < rows; i++) 
            {
                if(a_max<A[i,j])
                {
                    a_max=A[i,j];
                    a_max_index=i;
                }
            }
            if(a_max<(A[0,j]+A[rows-1,j])/2)
            A[a_max_index,j]=(A[0,j]+A[rows-1,j])/2;
            else
            A[a_max_index,j]=a_max_index+1;
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        if (n <= 0) return answer;
        answer = new int[n,3*n];
        for(int i=0;i<n;i++)
        {
            for (int j=0; j<n;j++)
            {
            answer[i,j]= (i==j) ? (1) : 0;
            answer[i,j+n]= (i==j) ? (1) : 0;
            answer[i,j+n+n]= (i==j) ? (1) : 0;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3*n; j++)
            {
                Console.Write(answer[i, j] + "\t");
            }
            Console.WriteLine();
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != 6 || cols != 6) 
        return null;

        double a_max=int.MinValue;
        int a_max_index=-1;
        for (int i = 0; i < rows; i++) 
        {
            if(a_max<A[i,i])
            {
                a_max=A[i,i];
                a_max_index=i;
            }
        }

        for(int i=0;i<a_max_index;i++)
        {
            for (int j=i+1; j<rows;j++)
            {
            A[i,j]= 0;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows != 6 || cols != 6) 
        return null;


        for (int i = 0; i < cols; i+=2) 
        { 
            double a_max_1=int.MinValue;
            int a_max_index_1=-1;
            for (int j = 0; j < rows; j++) 
            {
                if(a_max_1<B[i,j])
                {
                    a_max_1=B[i,j];
                    a_max_index_1=j;
                }
            }
            double a_max_2=int.MinValue;
            int a_max_index_2=-1;
            for (int j = 0; j < rows; j++) 
            {
                if(a_max_2<B[i+1,j])
                {
                    a_max_2=B[i+1,j];
                    a_max_index_2=j;
                }
            }
            int temp=B[i,a_max_index_1];
            B[i,a_max_index_1]=B[i+1,a_max_index_2];
            B[i+1,a_max_index_2]=temp;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int temp;

        if (rows != 6 || cols != 7) 
        return null;


        for (int i = 0; i < rows; i++) 
        { 
            for(int j=0;j<cols/2;j++)
            {
                temp=A[i,j];
                A[i,j]=A[i,cols-j-1];
                A[i,cols-j-1]=temp;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        //

        //
        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int r = matrix.GetLength(1);
        if (n!=r)
        return null;

        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[n - 1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || rows!=cols) 
        return null;

        for(int i=rows/2;i<rows;i++)
        {
            for (int j=0; j<rows;j++)
            {
                if (i>=j)
                {
                matrix[i,j]= 1;
                }
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

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

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || rows!=cols) 
        return (null,null);

        upper = new int[(rows*cols-rows)/2+rows];
        lower = new int[(rows*cols-rows)/2];

        int count_l=0;
        int count_u=0;

        for(int i=0;i<rows;i++)
        {
            for (int j=0; j<rows;j++)
            {
                if (i>j)
                {
                lower[count_l]= matrix[i,j];
                count_l++;
                }
                if (i<=j)
                {
                upper[count_u]= matrix[i,j];
                count_u++;
                }
            }
        }

        for (int i = 0; i < count_u; i++)
        {
            Console.Write(upper[i] + "\t");
        }
        System.Console.WriteLine();
        for (int i = 0; i < count_l; i++)
        {
            Console.Write(lower[i] + "\t");
        }

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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 7 || cols!=5) 
        return null;

        int[] positiveCounts = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCounts[i]++;
                }
            }
        }

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - 1 - i; j++)
            {
                if (positiveCounts[j] < positiveCounts[j + 1])
                {
                    for (int k = 0; k < cols; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int tempCount = positiveCounts[j];
                    positiveCounts[j] = positiveCounts[j + 1];
                    positiveCounts[j + 1] = tempCount;
                }
            }
        }

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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols==0) 
        return null;

        for (int i = 0; i < rows; i++)
        {
            if (i%2 == 0)
            {
                for (int j=0; j<cols;j++)
                {
                    for (int k=0;k<cols-j-1;k++)
                    {
                        if (matrix[i,k]<matrix[i,k+1])
                        {
                            int temp=matrix[i,k];
                            matrix[i,k]=matrix[i,k+1];
                            matrix[i,k+1]=temp;
                        }
                    }
                }
            }
            else
            {
                for (int j=0; j<cols;j++)
                {
                    for (int k=0;k<cols-j-1;k++)
                    {
                        if (matrix[i,k]>matrix[i,k+1])
                        {
                            int temp=matrix[i,k];
                            matrix[i,k]=matrix[i,k+1];
                            matrix[i,k+1]=temp;
                        }
                    }
                }
            }
        }
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols==0) 
        return null;

        int nonZero = 0;

        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero)
            {
                nonZero++;
            }
        }

        int[,] newMatrix = new int[nonZero, cols];
        int newRowIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[newRowIndex, j] = matrix[i, j];
                }
                newRowIndex++;
            }
        }


        return newMatrix;
    }
    #endregion
}
