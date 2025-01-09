using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Pipes;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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

        double n = A.GetLength(0), m = A.GetLength(1);
        if (n != 3 || m != 6) return (row, col);
        int min = int.MaxValue;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j]<min)
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


        // code here
        int[] answer = new int[5];
        double n = A.GetLength(0), m = A.GetLength(1);
        // code here

        // end

        return answer;
        // end

    }
    public int[] Task_1_7(int[,] A)
    {

        int[] answer = new int[5];
        double n = A.GetLength(0), m = A.GetLength(1);
        if (n != 3 || m != 5) return null;
        // code here
        for (int j=0;j<m;j++)
        {
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max) max = A[i, j];
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

        double n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        // code here
        int max = int.MinValue, row = -1, temp;
        for (int i = 0; i < n; i++)
        {
            if (max <= A[i, 2]) { 
                max = A[i, 2]; 
                row = i; 
            }
        }

            for (int j = 0; j < 7; j++)
            {
                temp = A[3, j];
                A[3, j] = A[row, j];
                A[row, j] = temp;
            }
            // end

            return A;
//        В матрице А размера 5 × 7 поменять местами строку, содержащую максимальный
//элемент в 3 - м столбце, с 4 - й строкой.
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
        double n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 5) return null;
        // code here

        int max=int.MinValue, row = -1, k;
        for (int i=0;i<n;i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i,j]>max && i==j)
                {
                    max = A[i,j];
                    row = j;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
                k = A[i, 3];
                A[i, 3] = A[i,row];
                A[i, row] = k;
        }
        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end
//        Сформировать одномерный массив из количеств отрицательных элементов
//столбцов матрицы А размера 4 × 3.
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
        n = A.GetLength(0); m = A.GetLength(1);
        int max = int.MinValue, k;
        int[] maxi = new int[n];
        int[] index = new int[n];
        int mx, col = -1;

        for (int i = 0; i < n; i++)
        {
            mx = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; col = j; }
            }
            maxi[i] = mx;
            index[i] = col;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = index[i]; j < m; j++)
            {
                if (j == m - 1) A[i, j] = maxi[i];
                else A[i, j] = A[i, j + 1];
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
        double max=double.MinValue;
        
        double[] maxi = new double[n];
        int[] index = new int[n];
        int k = -1;
        for (int i = 0; i < n; i++)
        {
            max = double.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (max < C[i, j]) 
                { 
                    max = C[i, j];
                    k = j;
                }
            }
            maxi[i] = max; 
            index[i] = k;
        }

        for (int i = 0; i < n; i++)
        {  
            for (int j = 0; j < index[i]; j++)
            {
                if (C[i, j] < 0) C[i, j] /= maxi[i];
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

         int n=Z.GetLength(0), m=Z.GetLength(1);
        if (n != 6 || m != 8) return null;
        double sr, sum = 0, k = 0, max = double.MinValue; int row=-1, col=-1;
        for (int i = 0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                if (Z[i, j] > 0) { sum = sum + Z[i, j]; k++; }
                if (Z[i, j] > max) { max = Z[i, j];row = i;col = j;  }
            }
        }
        sr = sum / k;
        Z[row,col]=sr;
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
        int n = X.GetLength(0), m = X.GetLength(1);
        if (n != 6 || m != 5) return null;
        int max = 0, min = int.MaxValue, k=0, maxi=-1, mini=-1, temp;
        for (int i = 0; i < n; i++)
        {
            k = 0;
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] < 0) k++;
            }
            
            if (max<k) { max = k; maxi = i; }
            if (min > k) { min = k; mini = i; }
        }
        for (int j=0; j < m; j++)
        {
            temp = X[mini, j];
            X[mini, j] = X[maxi,j];
            X[maxi, j] = temp;
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
        int n=A.GetLength(0), m=A.GetLength(1);
        if ( n!= 7 || m!= 5) return null;
        int max = int.MinValue, k = -1, sum=0;

        for (int i = 0; i < 7; i++)
        {
            sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0) sum += A[i, j];
            }
            if (max < sum) 
            { 
                max = sum; 
                k = i;
            }
        }

        int[,] B = new int[6, 5];
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B[i, j] = A[i, j];
            }
        }
        for (int i = k+ 1; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B[i - 1, j] = A[i, j];
            }
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
        int n=A.GetLength(0), m=A.GetLength(1), c=B.Length;
        if (n != 5 || m!=8 || c!=5) return null;
        

        int index = -1, min = int.MaxValue;

        for (int j = 0; j < 8; j++)
        {
            if (A[4, j] < min) 
            { 
                index = j;
                min = A[4, j]; 
            }
        }
        for (int i = 0; i < 5; i++)
        {
            A[i, index + 1] = B[i];
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
        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 5 || m != 7) return null;

        for (int i = 0; i < n; i++)
        {
            double maximum = double.MinValue;
            int max = 0;
            for (int j = 0; j < m; j++)
            {
                if (maximum < A[i, j])
                {
                    maximum = A[i, j];
                    max = j;
                }
            }
            if (max == 0 && A[i, max + 1] > 0) A[i, max + 1] *= 2;

            else if (max == 0 && A[i, max + 1] < 0) A[i, max + 1] /= 2;

            else if (max == m - 1 && A[i, max + 1] > 0) A[i, max - 1] *= 2;

            else if (max == m - 1 && A[i, max + 1] < 0) A[i, max - 1] /= 2;

            else
            {
                if (A[i, max - 1] > A[i, max + 1] && A[i, max + 1] > 0) A[i, max + 1] *= 2;

                else if (A[i, max - 1] > A[i, max + 1] && A[i, max + 1] < 0) A[i, max + 1] /= 2;

                else if (A[i, max - 1] < A[i, max + 1] && A[i, max - 1] > 0) A[i, max - 1] *= 2;

                else if (A[i, max - 1] < A[i, max + 1] && A[i, max - 1] < 0) A[i, max - 1] /= 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
       
        for (int j = 0 ; j < m; j++ )
        { int pol=0, otr=0;

            double max = double.MinValue;
            int maxi=0;
            for (int i = 0 ; i < n; i++)
            {
                if (A[i, j] > 0) pol++;
                if (A[i, j] < 0) otr++;
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (pol > otr) A[maxi, j]=0; 
            else A[maxi, j] = maxi+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = int.MinValue;
            int maxi = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxi = i;
                    sum = 0;
                }
                else sum += A[i, j];
            }
            if (maxi <= n / 2) A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
         int n = A.GetLength(0), m = A.GetLength(1), h= B.Length;

        if (n != 7 || m != 5 || h!=5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = int.MinValue;
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (A[maxi, j] < B[j]) A[maxi, j] = B[j];
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 7 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            double max = double.MinValue;
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (A[maxi, j] < (A[0, j] + A[n - 1, j]) / 2) A[maxi, j] = (A[0, j] + A[n - 1, j]) / 2;
            else A[maxi, j] = maxi+1;
        }
        // end
       
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        //int[,] answer = default(int[,]);
        // code here

        if (n <= 0) return default(int[,]);
        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++) answer[j, j + i] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        int maxi = 0; double max = double.MinValue;
        if (n != 6 || m != 6) return null;
        for (int i = 0; i < m; i++)
        {

            for (int j = 0; j < n; j++)
            {
                if (A[i, j] > max && i==j)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
        }
        for (int i = 0; i < maxi; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < j)
                {
                    A[i, j]=0;
                }
            }
        }
        // end
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        
        if (n != 6 || m != 6) return null;

            int max, max2, maxi1 = 0, maxi2 = 0;
        for (int i = 0; i < n-1; i += 2)
        {
            max = B[i, 0];
            max2 = B[i+1, 0];
            maxi1 = 0;
            maxi2 = 0;
            for (int j = 0; j < m; j++)
            {
                if (max < B[i, j])
                {
                    max = B[i, j];
                    maxi1 = j;
                }
                if (max2 < B[i+1, j])
                {
                    max2 = B[i+1, j];
                    maxi2 = j;
                }
            }
            B[i, maxi1] = max2;
            B[i+1 , maxi2] = max;
        }
        // end
       
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 6 || m != 7) return null;

        int temp;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m/2; j++)
            {
                temp = A[i, m - 1 - j];
                A[i, m - 1 - j] = A[i, j];
                A[i, j] = temp;
            }

        }

        return A;
    }
   

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n=matrix.GetLength(0), m=matrix.GetLength(1);
        if (n != 7 || m != 5) return null;
        int[] a= new int[n];
        int mini = -1,k;
        for (int i = 0;i<n;i++)
        {
            int min = int.MaxValue;
            for (int j=0;j<m;j++)
            {
                if (matrix[i, j] < min) {
                    min = matrix[i, j]; mini = j;
                }
            }
            a[i]=min;
        }
            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        k= a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = k;
                        swapRows(ref matrix, j, j + 1);
                    }
                }
            }
        
        // end
//        В матрице размера 7 × 5 переставить строки таким образом, чтобы минимальные
//элементы строк следовали в порядке убывания.
        return matrix;
    }
    public void swapRows(ref int[,] A, int row1, int row2)
    {
        int m = A.GetLength(1);
        int temp;
        for (int j = 0; j < m; j++)
        {
            temp = A[row1, j];
            A[row1, j] = A[row2, j];
            A[row2, j] = temp;
        }
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
        int[] answer = new int[matrix.GetLength(0)*2-1];
        if (matrix.GetLength(1) != matrix.GetLength(0)) return null;
        int n = matrix.GetLength(0);
        // code here
        for (int i=0;i<matrix.GetLength(0);i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[n - (i - j) - 1] += matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k <= 0) return null;
        int row = 0, col = 0, zn;
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[row, col]))
                {
                    row = i;
                    col = j;
                }
        }
            for (int i = 0; i < m; i++)
            {
                zn = matrix[i, col];
                matrix[i, col] = matrix[i, k-1];
                matrix[i, k-1] = zn;
            }
            for (int j = 0; j < m; j++)
            {
                zn = matrix[row, j];
                matrix[row, j] = matrix[k-1, j];
                matrix[k-1, j] = zn;
            }
//        В матрице размера n  n найти максимальный по модулю элемент матрицы.
//Перестановкой строк и столбцов перевести максимальный по модулю элемент на
//пересечение k-й строки и k - го столбца(1  k  n).
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
        int[] answer = new int[n*n];

        // code here
        int rows = A.Length, cols = B.Length;
        if (2*rows - n != n * n || 2*cols - n != n * n) return null;
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix1[j, i] = A[index];
                matrix2[i, j] = B[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }
        index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += matrix1[i, j] * matrix2[j, k];
                }
                answer[index] = s;
                index++;
            }
        }
        // end

        return answer;
    }

//    Перемножить две симметрические матрицы, заданные в одномерных массивах
//верхними треугольниками по строкам.Результат получить в одномерном массиве.
//Вывести в привычном виде исходные матрицы и матрицу-результат.
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return null;

        int[] indexes = new int[m]; 
        int []otr = new int[m];
        int[,] newmatrix = new int[n, m];
        int k = 0, temp, temp2;
        for (int j = 0; j < m; j++)
        {
            k = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0) k++;
            }
            indexes[j] = j; 
            otr[j] = k;
        }

        for (int i = 1, j = i + 1; i < m;)
        {
            if (i == 0 || otr[i] >= otr[i - 1])
            {
                i = j;
                j++;
            }
            else 
            {
                temp = otr[i];
                otr[i] = otr[i - 1];
                otr[i - 1] = temp;

                temp2 = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp2;
                i--;
            }
        }

        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                newmatrix[i, j] = matrix[i, indexes[j]];
            }
        }
       
        // end

        return newmatrix;
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
        int n=matrix.GetLength(0), m=matrix.GetLength(1);
        
        int[] arr = new int[n];
        int index = 0,flag=1,k=0;
        for (int i = 0; i < n; i++)
        {
            flag=1;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k++;
                    flag = 0;
                    break;
                }
            }
            if (flag == 0)
            {
                arr[index] = i;
                index++;
            }
        }

        int[,] newmatrix = new int[n - k, m];
         index = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == arr[index]) index++;
            else
            {
                for (int j = 0; j < m; j++)
                {
                    newmatrix[i, j] = matrix[i, j];
                }
            }
        }

        // end
        //В заданной матрице матрицах удалить все строки, содержащие нулевые элементы
        return newmatrix;
    }
    #endregion
}