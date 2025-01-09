using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Xml.Linq;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        
        int[,] matrix = {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 25, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            };
        int rowIndex = 3; 
        for (int i = 1; i<matrix.GetLength(1); i++)
        {
            int key = matrix[rowIndex, i]; int j = i-1;
            while (j>=0 && matrix[rowIndex,j]>key)
            {
                matrix[rowIndex,j+1] = matrix[rowIndex,j];
                j--;
            }
            matrix[rowIndex,j+1] = key;
        }
        
        for (int i = 0; i<matrix.GetLength(1); i++)
            Write($"{matrix[rowIndex,i]} ");
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
        for (int i =0; i<A.GetLength(0); i++)
        {
            answer+= A[i,i];
        }

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
        int[] answer = new int[A.GetLength(0)];
        if (A.GetLength(0)!=4 || A.GetLength(1)!=7) return null;
        for (int i = 0; i<A.GetLength(0); i++)
        {
            int min = A[i,0];
            int min_index = 0;
            for (int j = 0; j<A.GetLength(1); j++)
            {
                if (A[i,j]<min)
                {
                    min = A[i,j];
                    min_index = j;
                }
            }
            answer[i] = min_index;
            WriteLine(answer[i]);
        }
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return null;
        for (int i = 0; i<A.GetLength(0); i++)
        {
            int max = A[i,0];
            int max_index = 0;
            for (int j = 0; j<A.GetLength(1);j++)
            {
                if (A[i,j]>max)
                {
                    max = A[i,j];
                    max_index = j;
                }
            }
            int temp = A[i,0];
            A[i,0] = max;
            A[i, max_index] = temp;
        }
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
        if (A.GetLength(0)!=6 || A.GetLength(1)!=7) return null;
        //нахождение макс числа
        int max = A[0,0];
        int max_index_0 = 0;
        int max_index_1 = 0;
        for (int i = 0; i<A.GetLength(0); i++)
        {
            for (int j=0; j<A.GetLength(1); j++)
            {
                if (A[i,j]>max)
                {
                    max = A[i,j];
                    max_index_0=i;
                    max_index_1=j;
                }
            }
        }
        //удаление строки
        for (int k=max_index_0; k<(A.GetLength(0)-1);k++)
        {
            for (int l = 0; l<A.GetLength(1); l++)
            {
                A[k,l] = A[k+1,l];
            }
        }
        //удаление столбца
        for (int d = 0;d<A.GetLength(0);d++)
        {
            for (int x = max_index_1; x<(A.GetLength(1)-1); x++)
            {
                A[d,x] = A[d,x+1];
            }
        }
        //создание нового массива
        int[,] A_new = new int[A.GetLength(0)-1, A.GetLength(1)-1];
        for (int m = 0; m < A.GetLength(0)-1; m++)
            {
                for (int n = 0; n<A.GetLength(1)-1;n++)
                {
                    A_new[m,n] = A[m,n];
                } 
            }
        return A_new;
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return null;
        for (int i = 0; i<A.GetLength(0); i++)
        {
            int max = A[i,0];
            int max_index = 0;
            for (int j = 0; j<A.GetLength(1); j++)
            {
                if (max<A[i,j])
                {
                    max = A[i,j];
                    max_index = j;
                }
            }
            A[i, max_index] *= i+1;
        }
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
        if (D.GetLength(0)!=n || D.GetLength(1)!=m) return null;
        for (int i = 0; i<n; i++)
        {
            int max = D[i,0];
            int max_index = 0;
            int negative_index = -1;
            for (int j = 0; j<m; j++)
            {
                if (D[i,j]<0) 
                    break;
                if (max<D[i,j])
                {
                    max = D[i,j];
                    max_index = j;
                }
            }
            for (int j = m-1; j>=0; j--)
            {
                if (D[i,j]<0)
                {
                    negative_index = j;
                    break; 
                }
            }
            if (negative_index!=-1 && D[i,0] >= 0)
            {
                int temp = max;
                D[i,max_index] = D[i,negative_index];
                D[i,negative_index]=temp;
            }
        }
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i<H.GetLength(0); i++)
        {
            int max = H[i,0];
            int max_index = 0;
            for (int j = 0; j<H.GetLength(1)-1; j++)
            {
                if (max<H[i,j])
                {
                    max = H[i,j];
                    max_index=j;
                }
            }
            H[i,H.GetLength(1)-1] = H[i,H.GetLength(1)-2];
            H[i,H.GetLength(1)-2] = max;
        }
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
        int n = Y.GetLength(0); int m = Y.GetLength(1);
        if (n!=6 || m!=5) return null;
        for (int i = 0; i<n; i++)
        {
            double max = Y[i,0];
            int max_index = 0;
            for (int d = 0; d<m; d++)
            {
                if (max<Y[i,d])
                {
                    max = Y[i,d];
                    max_index = d;
                }
            }
            double midd=0;
            int counter = 0;
            for (int k = max_index+1; k<m; k++)
            {
                if (Y[i,k]>0)
                {
                    midd+=Y[i,k];
                    counter++;
                }
            }
            if (counter != 0) midd=Math.Round(midd/counter, 2);
            for (int a = 0; a<max_index; a++)
            {
                if (Y[i,a]<0)
                    Y[i,a] = midd;
            }
        }
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
        int n = B.GetLength(0); int m = B.GetLength(1);
        if (n!=5 || m!=7) return null;
        for (int i = 0; i<= n/2; i++)
        {
            int max1 = B[i,0]; int max1_index = 0;
            int max2 = B[n-i-1,0]; int max2_index = 0;
            for (int j = 0; j<m; j++)
            {
                if (B[i,j]>max1)
                {
                    max1 = B[i,j];
                    max1_index = j;
                }
                if (B[n-i-1,j]>max2)
                {
                    max2 = B[n-i-1,j];
                    max2_index = j;
                }
            }
            int temp = max2;
            B[n-i-1,3] = max1;
            B[i,3] = temp;
        }
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
        int n = B.GetLength(0); int m = B.GetLength(1);
        if (n!=5 || m!=5) return null;

        int max = B[0,0]; int max_index = 0;
        int negative_index = -1;
        for (int o = 0; o < n; o++)
        {
            if (B[o,o] > max)
            {
                max = B[o,o];
                max_index = o;
            }
            if (B[o,2] < 0 && negative_index == -1)
            {
                negative_index = o;
            }
        }
        for (int i=0; i<m; i++)
        {
            int temp = B[max_index, i];
            B[max_index, i] = B[negative_index, i];
            B[negative_index, i] = temp;
        }
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
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n!=5 || m!=7) return null;

        int count = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                if (A[i,j]<0) count++;
            }
        }
        answer = new int[count];
        int counter = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j=0;j<m;j++)
            {
                if (A[i,j]<0)
                {
                    answer[counter] = A[i,j];
                    counter++;
                }
            }
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 5 || m!=7) return null;

        for (int i = 0; i<n; i++)
        {
            double max = A[i,0];
            int max_index = 0;
            for (int j = 0; j<m; j++)
            {
                if (max < A[i,j])
                {
                    max = A[i,j];
                    max_index = j;
                }
            }
            if (max_index==0 && A[i,max_index+1]>0)
                A[i,max_index+1] *=2;
            else if (max_index==0 && A[i,max_index+1]<0)
                A[i,max_index+1] /=2;
            else if (max_index==m-1 && A[i,max_index+1]>0)
                A[i,max_index-1] *=2;
            else if (max_index==m-1 && A[i,max_index+1]<0)
                A[i,max_index-1] /=2;
            else
            {
                int index = (A[i,max_index-1]<A[i,max_index+1])?max_index-1:max_index+1;
                if (A[i,index]>0)
                    A[i,index] *=2;
                else
                    A[i,index] /=2;
            }
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        for (int j = 0; j<m; j++)
        {
            int max = A[0,j];
            int max_index = 0;
            int count = 0;
            int count0 = 0;
            for (int i = 0; i<n; i++)
            {
                if (max < A[i,j])
                {
                    max = A[i,j];
                    max_index = i;
                }
                if (A[i,j]>0)
                    count++;
                else if (A[i,j] == 0)
                    count0++;
            }
            if (count>n-count-count0)
                A[max_index,j] = 0;
            else
                A[max_index,j] = max_index;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        for (int j=0; j<m; j++)
        {
            int max = A[0,j];
            int max_index=0;
            int summa = 0;
            for (int i = 0; i<n; i++)
            {
                if (max<A[i,j])
                {
                    max = A[i,j];
                    max_index = i;
                    summa=0;
                }
                else
                    summa+=A[i,j];
            }
            if (max_index<=n/2)
            {
                A[0,j] = summa;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        int n = A.GetLength(0); int m = A.GetLength(1); int h = B.Length;
        if (n != 7 || m != 5 || h != 5) return null;

        for (int j=0; j<m;j++)
        {
            int max = A[0,j];
            int max_index = 0;
            for (int i=0; i<n; i++)
            {
                if (max < A[i,j])
                {
                    max = A[i,j];
                    max_index = i;
                }
            }
            if (max<B[j]) A[max_index,j] = B[j];
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        double summa = 0;
        for (int y=0;y<n;y++)
        {
            summa += A[y,0] + A[y,m-1];
        }
        summa /= 2;
        for (int j=0; j<m; j++)
        {
            double max = A[0,j];
            int max_index = 0;
            for (int i=0; i<n; i++)
            {
                if (max < A[i,j])
                {
                    max = A[i,j];
                    max_index = i;
                }
            }
            if (max<summa)
                A[max_index,j] = summa;
            else
                A[max_index,j] = max_index;
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n<=0) return null;
        int[,] answer = new int[n,3*n];
        for (int j=0; j<3*n; j++)
        {
            for (int i = 0; i<n; i++)
            {
                if (i == j%n)
                    answer[i,j] = 1;
                else
                    answer[i,j] = 0;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 6 || m != 6) return null;
        int max = A[0,0];
        int max_index = 0;
        for (int y = 0; y<n; y++)
        {
            if (max<A[y,y])
            {
                max = A[y,y];
                max_index = y;
            }
        }
        for (int l = 0; l<max_index; l++)
        {
            for (int u = l+1; u<n; u++)
            {
                A[l,u] = 0;
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        int n = B.GetLength(0); int m = B.GetLength(1);
        if (n != 6 || m != 6) return null;

        for (int i = 1; i<n; i+=2)
        {
            int max1 = B[i-1,0]; int max2 = B[i,0];
            int max_index_1 = 0; int max_index_2 = 0;
            for (int j = 0; j<m; j++)
            {
                if (max1 < B[i-1,j])
                {
                    max1 = B[i-1,j];
                    max_index_1 = j;
                }
                if (max2 < B[i,j])
                {
                    max2 = B[i,j];
                    max_index_2 = j;
                }
            }
            B[i-1,max_index_1] = max2;
            B[i,max_index_2] = max1;
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 6 || m != 7) return null;

        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m/2; j++)
            {
                int temp = A[i,j];
                A[i,j] = A[i,m-1-j];
                A[i,m-1-j] = temp;
            }
        }
        return A;
    }
    #region Level 3

    public int[,] Exchange(int[,] array, int num)
    {
        int n = array.GetLength(0); int m = array.GetLength(1);
        int[] copy = new int[m];
        for (int l = 0; l<m; l++)
        {
            copy[l] = array[num, l];
            array[num, l] = array[num-1,l];
            array[num-1,l] = copy[l];
        }
        return array;
    }
    

    public void WriteArray(double[,] array)
    {
        int n = array.GetLength(0); int m = array.GetLength(1);
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                Write($"{array[i,j]} ");
            }
            WriteLine("");
        }
    }

    public int[,] Increase(int[,] array, int num)
    {
        int n = array.GetLength(1);
        for (int l = 1; l<n; l++)
        {

            int key = array[num,l]; int j = l-1;
            while (j>=0 && array[num,j]>key)
            {
                array[num,j+1] = array[num,j];
                j--;
            }
            array[num,j+1] = key;
        }
        return array;
    }
    public int[,] Decrease(int[,] array, int num)
    {
        int n = array.GetLength(1);
        for (int l = 1; l<n; l++)
        {

            int key = array[num,l]; int j = l-1;
            while (j>=0 && array[num,j]<key)
            {
                array[num,j+1] = array[num,j];
                j--;
            }
            array[num,j+1] = key;
        }
        return array;
    }
    public int[,] Task_3_1(int[,] matrix)
    {

        return matrix;      
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        if (n != m) return null;

        int i = 0; int j = 0;
        int count = 0;
        while (i >= 0 && j >= 0)
        {
            if (i == 0 && j<m-1 )
            {
                matrix[i,j] = 0;
                j++;
            }
            else if (j == m-1 && i<n-1)
            {
                matrix[i,j] = 0;
                i++;
            }
            else if  (i == n-1 && j>0)
            {
                matrix[i,j] = 0;
                j--;
            }
            else if (j==0 && i>0)
            {
                matrix[i,j] = 0;
                i--;
            }
            count++;
            if (count == 4*(n-1)) break;
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
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        if (n != m) return null;

        int midd = n/2;
        for (int i = midd; i<n; i++)
        {
            for (int j = 0; j<=midd; j++)
            {
                matrix[i,j] = 1;
            }
            midd++;
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
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        if (n != m) return (null, null);

        int[] upper = new int[n*(n+1)/2];
        int[] lower = new int[n*(n-1)/2];

        int ii = 0; int jj = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                if (j>=i)
                {
                    upper[ii] = matrix[i,j];
                    ii++;
                }
                else
                {
                    lower[jj] = matrix[i,j];
                    jj++;
                }
            }
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
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        if (n != 7 || m != 5) return null;

        int last_count = -1;
        for (int i = 0; i<n; i++)
        {
            for (int k = 0; k<n-i; k++)
            {
                int count = 0; 
                for (int j = 0; j<m; j++)
                {
                    if (matrix[k,j]>0)
                        count++;
                }
                if (k == 0)
                {
                    last_count = count;
                    continue;
                }

                if (last_count < count)
                {
                    Exchange(matrix, k);
                }
                last_count = count;
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
        WriteLine("");
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            if (i%2 == 0)
                Decrease(matrix,i);
            else
                Increase(matrix,i);
        }
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int n = matrix.GetLength(0); int m = matrix.GetLength(1);
        int count = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                if (matrix[i,j] == 0)
                {
                    matrix[i,0] = 0;
                    count++;
                    break;
                }
            }
        }
        if (count == 0) return matrix;
        int[,] matrixNew = new int[n-count,m];

        int kk = 0;
        for (int k = 0; k<n; k++)
        {
            if (matrix[k,0] == 0)
                continue;
            for (int l = 0; l<m; l++)
            {
                matrixNew[kk,l] = matrix[k,l];
            }
            kk++;
        }
        return matrixNew;
    }
    #endregion
}