using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.ExceptionServices;
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

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }


        int row = A.GetLength(0);
        int col = A.GetLength(1);
        if (row == 0 | col == 0 | A == null)
        {
            return 0;
        }
        int c = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    c++;
                }
            }
        }
        if (c > 0) answer /= c;

        Console.WriteLine($"Ответ: {answer}");
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

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        if (row != 5 || col != 4)
        {
            return default;
        }
        for (int i = 0; i < row; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
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

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        answer = new double[row];

        if (row != 4 || col != 6 || A == null) return default;

        for (int i = 0; i < row; i++)
        {
            double sum = 0;
            int c = 0;
            double sr = 0;
            for (int j = 0; j < col; j++)
            {
                if ((A[i, j] > 0))
                {
                    sum += A[i, j];
                    c++;
                }
            }
            if (c > 0)
            {
                sr = sum / c;
                answer[i] = sr;
            }
            else answer[i] = 0;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] B = new int[row - 1, col];
        int min = 0;
        int imin = 0;

        if (row != 5 || col != 7 || A == null) return default;

        for (int i = 0; i < row; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                imin = i;
            }
        }
        for (int i = 0; i < row - 1; i++)
        {
            if (i < imin)
            {
                for (int j = 0; j < col; j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < col; j++)
                {
                    B[i, j] = A[i + 1, j];
                }
            }
        }
        A = B;
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

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        answer = new int[col];

        if (row != 4 || col != 3 || A == null) return default;

        for (int j = 0; j < col; j++)
        {
            int c = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] < 0) c++;
            }
            answer[j] = c;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        int row = B.GetLength(0);
        int col = B.GetLength(1);
        int[,] A = new int[row, col];

        if (B == null || n != row || m != col) return default;

        for (int i = 0; i < row; i++)
        {
            int min = B[i, 0];
            int indexmin = 0;
            for (int j = 1; j < col; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    indexmin = j;
                }
            }
            A[i, 0] = min;
            int newj = 1;
            for (int j = 0; j < col; j++)
            {
                if (j != indexmin)
                {
                    A[i, newj] = B[i, j];
                    newj++;
                }
            }
        }
        B = A;
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

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        int row = F.GetLength(0);
        int col = F.GetLength(1);

        if (F == null || n != row || m != col) return default;

        for (int i = 0; i < row; i++)
        {
            int jfirstmin = -1, jlastmin = -1, jmax = 0;
            for (int j = 0; j < col; j++)
            {
                if (F[i, j] > F[i, jmax]) jmax = j;
                if (jfirstmin == -1 && F[i, j] < 0) jfirstmin = j;
            }
            for (int j = col - 1; j >= 0; j--)
            {
                if (jlastmin == -1 && F[i, j] < 0) jlastmin = j;
            }
            if (jlastmin != -1 && jfirstmin != -1)
            {
                F[i, jmax] = (F[i, jfirstmin] + F[i, jlastmin]) / 2;

            }

        }
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

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here
        int row = G.GetLength(0);
        int col = G.GetLength(1);

        if (G == null || col != 7 || row != 5) return default;

        for (int i = 0; i < row; i++)
        {
            int jmax = 0;
            for (int j = 0; j < col; j++)
            {
                if (G[i, j] > G[i, jmax]) jmax = j;
            }
            for (int j = col - 1; j > jmax; j--)
            {
                G[i, j] = G[i, j - 1];
            }

        }
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

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 5 || col != 7 || B.Length != 7) return default;

        int imax = 0;

        for (int i = 0; i < row; i++)
        {
            if (A[i, 5] > A[imax, 5])
            {
                imax = i;
            }
        }
        for (int j = 0; j < col; j++)
        {
            A[imax, j] = B[j];
        }
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

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        int row = F.GetLength(0);
        int col = F.GetLength(1);

        if (F == null || row != 5 || col != 7) return default;

        int[,] result = new int[row, col - 1];

        int jmin = 0;
        for (int j = 0; j < col; j++)
        {
            if (Math.Abs(F[1, j]) < Math.Abs(F[1,jmin]) ) jmin = j;
        }

        for (int j = 0; j < col - 1; j++)
        {
            if (j < jmin + 1)
            {
                for (int i = 0; i < row; i++)
                {
                    result[i, j] = F[i, j];
                }
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    result[i, j] = F[i, j + 1];
                }
            }
        }
        F = result;
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

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        
        if (row != 5 || col != 7 || A == null) return default;
        for (int i = 0; i < row; i++)
        {
            int jmax = 0, c = 0;
            double sum = 0, sr = 0;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > A[i, jmax]) jmax = j;
                if (A[i, j] > 0)
                {
                    c++;
                    sum += A[i, j];
                }
            }
            if (c > 0)
            {
                sr = sum / c;
                A[i, jmax] = sr;
            }
            else A[i, jmax] = 0;
        }
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

        if (A == null || row != 5 || col != 7) return default;

        for (int i = 0; i < row; i++)
        {
            int jmax = 0;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > A[i, jmax]) jmax = j;
            }
            if (jmax == 0)
            {
                if (A[i, jmax + 1] > 0) A[i, jmax + 1] *= 2;
                else A[i, jmax + 1] /= 2;
            }
            else if (jmax == col - 1)
            {
                if (A[i, jmax - 1] > 0) A[i, jmax - 1] *= 2;
                else A[i, jmax - 1] /= 2;
            }
            else
            {
                if (A[i, jmax - 1] < A[i, jmax + 1])
                {
                    if (A[i, jmax - 1] > 0) A[i, jmax - 1] *= 2;
                    else A[i, jmax - 1] /= 2;
                }
                else
                {
                    if (A[i, jmax + 1] > 0) A[i, jmax + 1] *= 2;
                    else A[i, jmax + 1] /= 2;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 7 || col != 5) return default;

        for (int j = 0; j < col; j++)
        {
            int imax = 0, cpol = 0, cotr = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
                if (A[i, j] > 0) cpol++;
                if (A[i, j] < 0) cotr++;
            }
            if (cpol > cotr) A[imax, j] = 0;
            else A[imax, j] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row!=10 || col != 5) return default;

        for (int j = 0; j < col; j++)
        {
            int imax = 0, sum = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i,j] > A[imax, j]) imax = i;
            }
            for (int i = imax + 1; i < row; i++) sum += A[i, j];
            if (imax <= row / 2) A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 7 || col != 5 || B.Length != 5 || B == null) return default;

        for (int j = 0; j < col; j++)
        {
            int imax = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i,j] > A[imax, j]) imax = i;
            }
            if (B[j] > A[imax, j]) A[imax, j] = B[j];
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 7 || col != 5) return default;

        for (int j = 0; j < col; j++)
        {
            int imax = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
            }
            double sum = A[0, j] + A[row - 1, j];
            if (A[imax, j] < sum) A[imax, j] = sum;
            else A[imax, j] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return default;

        answer = new int[n, 3 * n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, i + n] = 1;
            answer[i, i + 2 * n] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 6 || col != 6) return default;

        int imax = 0, max = A[0,0];
        for (int i = 0; i < row; i++)
        {
            if (A[i,i] > max)
            {
                max = A[i,i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i + 1; j < col; j++)
            {
                A[i,j] = 0;
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

        if (B == null || row != 6 || col != 6) return default;

        for (int i = 0; i < row; i += 2)
        {
            int firstmaxi = i, firstmaxj = 0, secondmaxi = i + 1, secondmaxj = 0;
            for (int j = 0; j < col; j++)
            {
                if (B[firstmaxi, j] > B[firstmaxi, firstmaxj]) firstmaxj = j;
                if (B[secondmaxi, j] > B[secondmaxi, secondmaxj]) secondmaxj = j;
            }
            int temp = B[firstmaxi, firstmaxj];
            B[firstmaxi, firstmaxj] = B[secondmaxi, secondmaxj];
            B[secondmaxi, secondmaxj] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (A == null || row != 6 || col != 7) return default;

        for(int i = 0; i<row; i++)
        {
            for (int j = 0; j<col/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, col - 1 - j];
                A[i, col - 1 - j] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (matrix == null || row != 7 || col != 5) return default;

        for (int i = 0; i < row - 1; i++)
        {
            for (int j = i + 1; j < row; j++)
            {
                int mini = 1000, minj = 1000;
                for (int k = 0; k < col; k++)
                {
                    if (matrix[i,k] < mini) mini = matrix[i,k];
                    if (matrix[j,k] < minj) minj = matrix[j,k];
                }
                if (mini < minj)
                {
                    for (int k = 0; k < col; k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
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
        answer = new int[2*matrix.GetLength(0)-1];

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int n = row;

        if (matrix == null || row != col || row == 0) return default;

        for (int c = -row + 1; c < row; c++)
        {
            int sum = 0;
            for (int i = 0; i < row; i++) 
            {
                int j = i + c;
                if (j >= 0 && j < row) sum += matrix[i, j];
            }
            answer[c + row - 1] = sum;

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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int n = row;
        if (matrix == null || row != col || k < 1 || k > n) return default;

        int max = -1000, imax = 0, jmax = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0;  j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    imax = i;
                    jmax = j;
                }
            }
        }

        if (imax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[imax, i];
                matrix[imax, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;
            }
        }
        if (jmax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, jmax];
                matrix[i, jmax] = matrix[i, k - 1];
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
        //Симметричные матрицы обладают свойством, что matrix[i, j] == matrix[j, i]
        //Размер каждого массива определяется размером матрицы n по формуле n * (n + 1) / 2.
        //Например, верхний треугольник матрицы 3x3 состоит из 6 элементов (3 + 2 + 1).
        //answer[i, j] = sum(matrixa[i, k] * matrixb[k, j]  for k = 0 to n-1)
        //Результатом умножения также является симметричная матрица.
        //Задача состоит в том, чтобы сохранить только её верхний треугольник в одномерном массиве

        answer = new int[n * n];
        int[,] matrixa = new int[n, n];
        int[,] matrixb = new int[n, n];
        int index = 0;

        if (A == null || B == null || n <= 0 || A.Length != n * (n + 1) / 2 || B.Length != n * (n + 1) / 2) return default;

        //перевод в нормальный вид
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixa[i, j] = A[index];
                matrixb[i, j] = B[index];
                index++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixa[j, i] = matrixa[i, j];
                matrixb[j, i] = matrixb[i, j];
            }
        }

        //ищем произведение
        index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixa[i, k] * matrixb[k, j];
                }
                answer[index++] = sum;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (matrix == null || row != 5 || col != 7) return default;

        bool swap;
        for (int pass = 0; pass < col; pass++)
        {
            swap = false;
            for (int i = 0; i < col - 1; i++)
            {
                int counti = 0, countj = 0;
                for (int k = 0; k < row; k++)
                {
                    if (matrix[k, i] < 0) counti++;
                    if (matrix[k, i + 1] < 0) countj++;
                }
                if (counti > countj)
                {
                    for (int k = 0; k < row; k++)
                    {
                        int temp = matrix[k, i];
                        matrix[k, i] = matrix[k, i + 1];
                        matrix[k, i + 1] = temp;
                    }
                    swap = true;
                }

            }
            if (swap == false) break; //значит матрица уже отсортирована
        }
        //если делать сортировку как в 3.1 происходит ошибка из-зи того, что
        //она не до конца сравнивает столбцы
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int newrow = 0;

        if (matrix == null) return default;

        //ищем строки без 0
        for (int i = 0; i < row; i++)
        {
            bool zero = false;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;

                }
            }
            if (zero == false) newrow++;
        }

        int[,] newmatrix = new int[newrow, col];
        newrow = 0;

        for (int i = 0; i < row; i++)
        {
            bool zero = false;
            for (int j = 0; j < col; j++) //проверяем, чтобы не было 0
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if (zero == false) //найдена строка без 0
            {
                for (int j = 0; j < col; j++)
                {
                    newmatrix[newrow,j] = matrix[i, j];
                }
                newrow++; 
            }
        }

        matrix = newmatrix;
        // end

        return matrix;
    }
    #endregion
}