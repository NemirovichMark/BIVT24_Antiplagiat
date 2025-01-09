using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
        int str=A.GetLength(0);
        int sto=A.GetLength(1);
        // code here
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
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
        int row = 0, col = 0; int Min = 100000;
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        // code here
        for (int i=0; i<str; i++)
            for (int j=0; j<sto; j++)
                if (A[i,j]<Min)
                {
                    Min= A[i,j];
                    row = i;
                    col=j;
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
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        // code here
        int[] cool = new int[sto];

        if (str != 3 || sto != 5) return null;

        int Max = -100000;
        for (int j = 0; j < sto; j++)
        {
            for (int i = 0; i < str; i++)
            {
                if (A[i,j] > Max)
                Max = A[i,j];
            }
            cool[j] = Max;
            Max = -100000;
        }
        answer = cool;
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
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        int str1 = 0; int str4 = 0;
        int Max = -100000;
        if (str != 5 || sto != 7) return null;
        for (int i = 0; i < str; i++)
        {
            if (A[i, 2] > Max)
            {
                Max = A[i, 2];
                str1 = i; // запоминаем эту строку
            }
        }
        if (str1 != 3)
        {
            for (int j = 0; j < sto; j++)
            {
                str4 = A[str1, j]; //загрузили в переменную найденную строку
                A[str1, j] = A[3, j]; //записали в искомую строку 4ую
                A[3, j] = str4; //запис в 4ую искомую
            }
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
        int str=A.GetLength(0);
        int sto=A.GetLength(1);
        int Max = -100000;
        int maxSto = 0;
        int i=0, j=0;
        int str1 = 0;
        if (str != 5 || sto != 5) return null;
        for (int y=0; y<5; y++)
        {
            if (A[i, j] > Max)
            {
                maxSto = j;
                Max = A[i, j];
            }
            i++;
            j++;
        }
       for (int x=0; x<5; x++)//по строкам
        {
            str1 = A[x, maxSto];
            A[x, maxSto] = A[x, 3];
            A[x,3]= str1;
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
        //int str = A.GetLength(0);
        //int sto = A.GetLength(1);
        
        for (int i=0; i< n; i++)
        {
            int Max = A[i, 0];
            int maxindex = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j]>Max)
                {
                    Max = A[i, j];
                    maxindex = j;
                }
            }
            for (int x=maxindex; x<m-1; x++)
            {

                int temp = A[i, x];
                A[i, x] = A[i, x + 1];
                A[i, x + 1] = temp;
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
        //int str = C.GetLength(0);
        //int sto = C.GetLength(1);
        double Max = -100000;
        int stolb = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > Max)
                {
                    Max = C[i, j];
                    stolb = j;
                }
            }
            for (int y = 0; y < stolb; y++)
            {
                if (Max != 0)
                {
                    if (C[i, y] < 0)
                    {
                        C[i, y] /= Max;
                    }
                }
            }
            Max = -100000;
        }

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
        int str = Z.GetLength(0);
        int sto = Z.GetLength(1);
       
        if (str != 6 && sto != 8) return null;
        double max = -100000;
        double sum = 0;
        int imax = 0, jmax = 0, count = 0;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    count++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        sum=sum/count;
        Z[imax, jmax] = sum;
        return Z; 
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
        // code here
        int str = X.GetLength(0);
        int sto = X.GetLength(1);
        if (str != 6 && sto != 5) return null;
        int Min = 100000; int Max = -100000;
        int maxindex = 0, minindex = 0;
        for (int i=0; i<str; i++)
        {
            int count = 0;
            for (int j=0; j<sto; j++)
            {
                if (X[i,j]<0)
                {
                    count++;
                }
            }
            if (count>Max) // обновляем макс кол-во
            {
                maxindex = i;
                Max = count;
            }
            if (count <Min)// обновляем мин кол-во
            {
                minindex = i;
                Min = count;

            }
        }
        for (int x=0; x<sto; x++)
        {
            int temp = X[Max, x];
            X[Max, x] = X[minindex, x];
            X[minindex, x] = temp;
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
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 7 && sto != 5) return null;
        int Max = -100000;
        int maxindex = 0;
        for (int i = 0; i < str; i++)
        {
            int sum = 0;
            for (int j = 0; j < sto; j++)
            {
                if (A[i,j]>0)
                {
                    sum += A[i, j];
                }
            }
            if (sum>Max)
            {
                maxindex = i;
                Max = sum;
            }
        }
        int[,] newA = new int[str - 1, sto];
        int g = 0;
        for (int i=0; i<str; i++)
        {
            if (i == maxindex) continue;
            for (int j = 0;j < sto; j++)
            {
                newA[g,j]=A[i,j];
            }
            g++;
        }
        A = newA;
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
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 5 && sto != 8 || B.Length!=5) return null;
        int Min = 100000;
        int minindex = 0;
        for (int j=0; j<sto; j++)
        {
            if (A[4,j]<Min)
            {
                Min= A[4,j];
                minindex = j;
            }
        }
        if (Min!=sto-1)
        {
            for (int i=0; i<str; i++)
            {
                A[i, minindex + 1] = B[i];
            }
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
        int str=A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 5 && sto != 7) return null;

        for (int i=0; i<str; i++)
        {
            double Max = -100000;
            int maxindex = 0;
            for (int j=0; j<sto;j++)
            {
                if (A[i,j]>Max)
                {
                    Max= A[i,j];
                    maxindex = j;
                }

            }
            if (maxindex==0)
            {
                if (A[i, maxindex+1] > 0)
                {
                    A[i, maxindex+1] *= 2;
                }
                else
                {
                    A[i, maxindex+1] /= 2;
                }
            }
            if (maxindex==(sto-1))
            {
                if (A[i,maxindex-1]>0)
                {
                    A[i, maxindex - 1] *= 2;
                }
                else
                {
                    A[i, maxindex - 1] /= 2;
                }
            }
            if (maxindex>0 && maxindex<(sto-1))
            {
                if (A[i, maxindex - 1] < A[i,maxindex+1])
                {
                    if (A[i, maxindex-1]>0)
                    {
                        A[i, maxindex - 1] *= 2;
                    }
                    else
                    {
                        A[i, maxindex - 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, maxindex + 1] > 0)
                    {
                        A[i, maxindex + 1] *= 2;
                    }
                    else
                    {
                        A[i, maxindex + 1] /= 2;
                    }
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
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 7 && sto != 5) return null;

        for (int j=0; j<sto; j++)
        {
            int Max = -100000;
            int imax = 0;
            int count = 0;
            for (int i=0; i<str; i++)
            {
                if (A[i,j] > 0)
                {
                    count++;
                }
                if (A[i,j]>Max)
                {
                    Max= A[i,j];
                    imax = i;
                }

            }
            if (count >= 4)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax+1;
            }

        }
       
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 10 && sto != 5) return null;

        for (int j = 0; j < sto; j++)
        {
            double Max = -100000;
            int imax = 0;
            int sum = 0;
            for (int i = 0; i < str; i++)
            {
                if (A[i, j] > Max)
                {
                    Max = A[i, j];
                    imax = i;
                }
            }
            for (int i = imax + 1; i < str; i++)
            {
                sum += A[i, j];
            }
            if (imax < str / 2)
            {
                A[0, j] = sum;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 7 && sto != 5 || B.Length!=5) return null;

        for (int j=0; j<sto; j++)
        {
            int Max = 0;
            int imax = 0;
            for (int i=0; i<str; i++)
            {
                if (A[i,j]>Max)
                {
                    Max = A[i, j];
                    imax = i;
                }
            }
            if (B[j] > A[imax,j])
            {
                A[imax,j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 7 && sto != 5 ) return null;

        for ( int j = 0; j<sto; j++)
        {
            double Max = 0;
            int imax = 0;
            double sum = 0;
            for (int i=0; i<str;i++)
            {
                if (A[i,j]>Max)
                {
                    Max= A[i,j];
                    imax = i;
                }
            }
            sum = (A[0, j] + A[str - 1, j])/2;
            if (Max<sum)
            {
                A[imax, j] = sum;
            }
            else
            {
                A[imax, j] = imax + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i, j] = 0;
            }
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = count; j <n*3; j += 3)
            {
                answer[i, j] = 1;
            }
            count++;
        }
        
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 6 && sto != 6) return null;
        int Max = -100000;
        int imax = 0;
        for (int i=0; i<str; i++)
        {
            if (A[i,i]>Max)
            {
                Max=A[i,i];
                imax = i;
            }
        }
        int count = 1;
        for (int i = 0; i < imax; i++)
        {
            for (int j = count; j < sto; j++)
            {
                A[i, j] = 0;
            }
            count++;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int str = B.GetLength(0);
        int sto  = B.GetLength(1);
        if (str != 6 || sto != 6) return null;
        for (int i = 0; i < str; i += 2)
        {
            int Max1 = B[i, 0];
            int imax1 = 0;
            int Max2 = B[i + 1, 0];
            int imax2 = 0; ;
            for (int j = 0; j < sto; j++)
            {
                if (B[i, j] > Max1)
                {
                    Max1 = B[i, j];
                    imax1 = j;
                }
            }
            for (int j = 0; j < sto; j++)
            {
                if (B[i + 1, j] > Max2)
                {
                    Max2 = B[i + 1, j];
                    imax2 = j;
                }
            }
            int temp = B[i, imax1];
            B[i, imax1] = B[i + 1, imax2];
            B[i + 1, imax2] = temp;
            
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int str = A.GetLength(0);
        int sto = A.GetLength(1);
        if (str != 6 || sto != 7) return null;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto / 2; j++)
            {
                int temp = A[i, sto - j - 1];
                A[i, sto - j - 1] = A[i, j];
                A[i, j] = temp;

            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        if (str != 7 || sto != 5) return null;
        int[] minind = new int[str];
        int[] index = new int[str];
        for (int i = 0; i < str; i++) 
        {
            int Min = matrix[i, 0];
            for (int j = 1; j < sto; j++)
            {
                if (matrix[i, j] < Min)
                {
                    Min = matrix[i, j];
                }
            }
            minind[i] = Min;
            index[i] = i;

        }
        for (int i=0; i<str-1; i++)//сорт по индексам
        {
            for (int j=i+1; j<str;j++)
            {
                if (minind[i] < minind[j])
                {
                    int temp = minind[i];//меняем мин знач и их индексы
                    int idx = index[i];
                    minind[i]= minind[j];
                    index[i] = index[j];
                    minind[j] = temp;
                    index[j]= idx; 
 
                }
            }
        }
        int[,] nMatrix = new int[str, sto];
        for (int i=0; i<str; i++)
        {
            int newind = index[i];
            for (int j=0; j<sto; j++)
            {
                nMatrix[i,j]=matrix[newind, j];
            }
        }
        matrix= nMatrix;
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
        answer = new int[2*matrix.GetLength(0)-1];
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);

        if ( str != sto || str == 0) return null;
        for (int x = -str + 1; x < str; x++)
        {
            int sum = 0;
            for (int i = 0; i < str; i++)
            {
                int j = i + x;
                if (j >= 0 && j < str)
                {
                    sum += matrix[i, j];
                }
            }
            answer[x + str - 1] = sum;
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
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        if (str != sto || k < 1 || k > str) return null;

        int Max = -1000;
        int iMax = 0;
        int jMax = 0;

        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                if (Math.Abs(matrix[i, j]) > Max)
                {
                    Max = Math.Abs(matrix[i, j]);
                    iMax = i;
                    jMax = j;
                }
            }
        }

        if (iMax != k - 1)
        {
            for (int i = 0; i < str; i++)
            {
                int temp = matrix[iMax, i];
                matrix[iMax, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;
            }
        }
        if (jMax != k - 1)
        {
            for (int i = 0; i < sto; i++)
            {
                int temp = matrix[i, jMax];
                matrix[i, jMax] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
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
        answer = new int[n * n];
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int ind = 0;

        if ( n <= 0 || A.Length / 2 != n || B.Length / 2 != n) return null;


        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[ind];
                matrixB[i, j] = B[ind];
                ind++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixA[j, i] = matrixA[i, j];
                matrixB[j, i] = matrixB[i, j];
            }
        }

        ind = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int l = 0; l < n; l++)
                {
                    sum = sum +( matrixA[i, l] * matrixB[l, j]);
                }
                answer[ind++] = sum;
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
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        if (str != 5 || sto != 7) return null;
        
        for (int k = 0; k < sto; k++)
        {
            int count = 0;
            for (int j = 0; j < sto; j++)
            {
                int count2 = 0;
                for (int i = 0; i < str; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count2++;
                    }
                }
                if (j != 0 && count2 < count)
                {
                    for (int i = 0; i < str; i++)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = temp;
                    }
                }
                else { count = count2; }
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
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        int count = 0;
        if (matrix == null) return default; ;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] newMatr = new int[str - count, sto];
        int k = 0;
        for (int i = 0; i < str; i++)
        {
            count = 0;
            for (int j = 0; j < sto; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                for (int j = 0; j < sto; j++)
                {
                    newMatr[k, j] = matrix[i, j];
                }
                k++;
            }
        }
        matrix = newMatr;
        // end

        return matrix;
    }
    #endregion
}