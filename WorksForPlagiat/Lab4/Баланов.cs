using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
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
        double summ = 0,count = 0;

        // code here
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 7; ++j)
                {
                    if (A[i, j] > 0)
                    {
                        summ += A[i, j];
                        count++;
                    }
                }
            }
            answer = summ / count;
        }

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
        bool flag = true;
        // code here

        for (int i = 0; i < A.GetLength(0); ++i)
        {
            if (flag && (A[i, colIndex] < 0))
            {
                value = A[i, colIndex];
                rowIndex = i;
                flag = false;
            }
        }
        if (rowIndex == -1)
        {
            rowIndex = 0;
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
        double[] answer = new double[A.GetLength(0)];
        double summ = 0;
        double count = 0;
        // code here
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    if ((A[i, j] > 0))
                    {
                        summ += A[i, j];
                        count++;
                    }
                }
                if (count != 0) answer[i] = (summ / count);
                else answer[i] = 0;
                summ = 0;
                count = 0;
            }
        }
        else
        {
            answer = null;
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
        double min = double.MaxValue;
        int index = 0;
        int[,] B = new int[4, 7];
        // code here
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0;i < 5; ++i)
            {
                if(A[i, 0] < min)
                {
                    min = A[i, 0];
                    index = i;
                }
            }
            for (int j = 0; j < 7; ++j)
            {
                for (int i = 0; i < index; ++i)
                {
                    B[i, j] = A[i, j];
                }
                for (int i = index + 1; i < 5; ++i)
                {
                    B[i - 1, j] = A[i, j];
                }
            }
            A = B;
        }
        else
        {
            A = null;
        }
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
        int[] answer = new int[A.GetLength(1)];
        int count = 0;
        // code here
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 3))
        {
            for(int i = 0;i < 3; ++i)
            {
                for(int j = 0;j < 4; ++j)
                {
                    if (A[j,i] < 0)
                    {
                        count++;
                    }
                }
                answer[i] = count;
                count = 0;
            }
        }
        else
        {
            answer = null;
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
        int min = int.MaxValue;
        int index = 0;
        // code here
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                        index = j;
                    }
                }
                for (int j = index; j > 0; --j)
                {  
                    B[i, j] = B[i,j-1];
                }
                B[i, 0] = min;
                min = int.MaxValue;
                index = 0;
            }
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
        double max = double.MinValue;
        int index = 0;
        int first = -1,last = -1;
        bool fl = true;
        // code here
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    index = j;
                }
                if (F[i, j] < 0 && fl)
                {
                    first = j;
                    fl = false;
                }
            }
            for (int j = m - 1; j >= 0; --j)
            {
                if (F[i, j] < 0){
                    last = j;
                    break;
                }
            }
            if(first != -1)
            {
                F[i, index] = (F[i, first] + F[i, last])/2;
            }
            first = -1; last = -1; fl = true; max = double.MinValue;
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
        int max = int.MinValue;
        int index = -1;
        // code here
        if ((G.GetLength(0) == 5) && (G.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        index = j;
                    }
                }
                for (int j = 6; j > index + 1; --j)
                {
                    G[i, j] = G[i, j - 1];
                }
                G[i, index + 1] = max;
                max = int.MinValue; index = -1;
            }
        }
        else
        {
            G = null;
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
        double max = double.MinValue;
        int index = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7) && (B.Length == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 6] > max)
                {
                    max = A[i, 6];
                    index = i;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                A[index + 1, i] = B[i];
            }
        }
        else
        {
            A = null;
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
        double max = double.MaxValue;
        int index = 0;
        int[,] A = new int[5, 6];
        if ((F.GetLength(0) == 5) && (F.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (Math.Abs(F[2, i]) < max)
                {
                    max = F[2, i];
                    index = i;
                }
            }
            index += 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < index; j++)
                    A[i, j] = F[i, j];
                for (int j = index + 1; j < 7; j++)
                    A[i, j - 1] = F[i, j];
            }
            index = 0;
            F = A;

        }
        else
        {
            F = null;
        }
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
        double max = double.MinValue;
        int index = 0;
        double summ = 0;
        int count = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = j;
                    }
                    if (A[i, j] > 0)
                    {
                        summ += A[i, j];
                        count++;
                    }
                }
                if (count > 0)
                    summ = summ / count;
                else summ = 0;
                A[i, index] = summ;
                index = 0;
                max = double.MinValue;
                count = 0;
                summ = 0;
            }
        }
        else
        {
            A = null;
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
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0;i < 5; ++i)
            {
                double max = double.MinValue;
                int index = 0;
                for (int j = 0; j < 7; ++j)
                {
                    if(A[i, j] > max)
                    {
                        max = A[i, j];
                        index = j;
                    }
                }
                int el = 0;
                if (index == 0 || index == 6)
                {
                    if (index == 0)
                        el = 1;
                    else
                        el = 5;
                }
                else
                {
                    if (A[i, index - 1] < A[i, index + 1])
                        el = index - 1;
                    else
                        el = index + 1;
                }
                if (A[i, el] < 0)
                    A[i, el] /= 2;
                else
                {
                    A[i, el] *= 2;
                }
            }
        }
        else
        {
            A = null;
        }
        // end
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if ((A.GetLength(0) == 7) && (A.GetLength(1) == 5))
        {
            int pl = 0;
            int min = 0;
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                int max = int.MinValue;
                pl = 0;
                min = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (A[j, i] > 0)
                    {
                        pl++;
                    }
                    else if (A[j, i] < 0)
                    {
                        min++;
                    }
                    if (A[j, i] > max)
                    {
                        max = A[j, i];
                        index = j;
                    }
                }
                if (pl > min)
                {
                    A[index, i] = 0;
                }
                else
                {
                    A[index, i] = index;
                }
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if ((A.GetLength(0) == 10) && (A.GetLength(1) == 5))
        {
            
            for (int i = 0; i < 5; i++)
            {
                int max = int.MinValue;
                int summa = 0;
                int index = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (A[j, i] > max)
                    {
                        max = A[j, i];
                        index = j;
                    }
                }
                for (int j = index + 1; j < 10; j++)
                {
                    summa += A[j, i];
                }
                if (index < 5)
                {
                    A[0, i] = summa;
                }
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int index = 0;
        bool fl = false;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] != 0)
            {
                fl = true;
                break;
            }
        }
        if ((A.GetLength(0) == 7) && (A.GetLength(1) == 5) && fl)
        {
            for(int i = 0;i < 5; ++i)
            {
                int max = int.MinValue;
                for(int j = 0; j < 7; ++j)
                {
                    if (A[j, i] > max)
                    {
                        max = A[j, i];
                        index = j;
                    }
                }
                if (max < B[i])
                {
                    A[index, i] = B[i];
                }
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int index = 0;
        // code here
        if ((A.GetLength(0) == 7) && (A.GetLength(1) == 5))
        {
            for (int i = 0; i < 5; ++i)
            {
                double max = double.MinValue;
                for (int j = 0; j < 7; ++j)
                {
                    if (A[j, i] > max)
                    {
                        max = A[j, i];
                        index = j;
                    }
                }
                if ((A[0, i] + A[6, i]) / 2 > max)
                {
                    A[index, i] = (A[0, i] + A[6, i]) / 2;
                }
                else
                {
                    A[index, i] = index;
                }
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return answer;
        }
        answer = new int[n, n * 3];
        for(int i = 0;i < n; ++i)
        {
            for (int j = 0;j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = i; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if ((A.GetLength(0) == 6) && (A.GetLength(1) == 6))
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < 6; i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    index = i;
                }
            }

            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < 6; j++)
                    A[i, j] = 0;
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if ((B.GetLength(0) == 6) && (B.GetLength(1) == 6))
        {
            int index_1 = 0;
            int index_2 = 0;
            for (int i = 0; i < 6; i += 2)
            {
                int max_1 = int.MinValue;
                int max_2 = int.MinValue;
                for (int j = 0; j < 6; j++)
                {
                    if (B[i, j] > max_1)
                    {
                        max_1 = B[i, j];
                        index_1 = j;
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    if (B[i + 1, j] > max_2)
                    {
                        max_2 = B[i + 1, j];
                        index_2 = j;
                    }
                }
                B[i, index_1] = max_2;
                B[i + 1, index_2] = max_1;
            }
        }
        else
        {
            B = null;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if ((A.GetLength(0) == 6) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7 / 2; j++)
                {
                    int P = A[i, j];
                    A[i, j] = A[i, 6 - j];
                    A[i, 6 - j] = P;
                }
            }
        }
        else
        {
            A = null;
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int index = 0, min = int.MaxValue, max = int.MinValue;
        int[,] A = new int[7, 5];
        int[] B = new int[7];
        if ((matrix.GetLength(0) == 7) && (matrix.GetLength(1) == 5))
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        index = j;
                    }
                }
                B[i] = matrix[i,index];
                index = 0;
                min = int.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (B[j] > max)
                    {
                        max = B[j];
                        index = j;
                    }
                }
                B[index] = int.MinValue;
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = matrix[index, j];
                }
                max = int.MinValue;
                index = 0;
            }

        }
        else
        {
            A = null;
        }
        matrix = A;
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
        bool flag = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    flag = false;
                    break;
                }
            }
        }
        if(matrix.GetLength(0) != matrix.GetLength(1)) { flag = true; }
        answer = new int[2 * matrix.GetLength(0) - 1];
        if (flag)
        {
            return null;
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                int summa_l = 0;
                int summa_r = 0;
                for(int j = 0;j < i + 1 ; ++j)
                {
                    summa_l += matrix[matrix.GetLength(0) - i - 1 + j, j];
                    summa_r += matrix[j, matrix.GetLength(0) - i - 1 + j];
                }
                answer[i] = summa_l;
                answer[2 * matrix.GetLength(0) - 1 - i - 1] = summa_r;
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
        int index1 = 0, index2 = 0;
        int max = int.MinValue;
        int[] A = new int[matrix.GetLength(0)];
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || k <= 0)
        {
            return null;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    index1 = i;
                    index2 = j;

                }
            }
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int t = matrix[k - 1, i];
            matrix[k - 1, i] = matrix[index1, i];
            matrix[index1, i] = t;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int t = matrix[i, k - 1];
            matrix[i, k - 1] = matrix[i,index2];
            matrix[i,index2] = t;
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
        int[,] first_matrix = new int[n, n];
        int[,] second_matrix = new int[n, n];
        int index = 0;

        bool flag = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != 0 || B[i] != 0)
                flag = true;
        }

        if (!flag)
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                first_matrix[i, j] = A[index];
                second_matrix[i, j] = B[index];
                index++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                first_matrix[j, i] = first_matrix[i, j];
                second_matrix[j, i] = second_matrix[i, j];
            }
        }

        index = 0;
        int s;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                s = 0;
                for (int l = 0; l < n; l++)
                {
                    s = s + first_matrix[i, l] * second_matrix[l, j];
                }
                answer[index++] = s;
            }
        }
        return answer;
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
        if (matrix.GetLength(0) == 5 && matrix.GetLength(1) == 7)
        {
            int[,] A = new int[5, 7];
            int[] B = new int[matrix.GetLength(1)];
            for (int i = 0; i < 7; i++)
            {
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        count++;
                    }
                }
                B[i] = count;
            }
            for (int i = 0; i < 7; i++)
            {
                int min = int.MaxValue;
                int index = -1;
                for (int j = 0; j < 7; j++)
                {
                    if (B[j] < min)
                    {
                        min = B[j];
                        index = j;
                    }
                }
                B[index] = int.MaxValue;
                for (int j = 0; j < 5; j++)
                {
                    A[j, i] = matrix[j, index];
                }
            }
            matrix = A;
        }
        else
        {
            matrix = null;
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
        int a = 0;
        bool flag = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                flag = false;
                continue;
            }
        }
        int count = 0;
        int[,] A = new int[matrix.GetLength(0) - a, matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    flag = true;
                    break;
                }
                A[count, j] = matrix[i, j];
            }
            if (flag)
            {
                flag = false;
                continue;
            }
            count++;
            if (count >= matrix.GetLength(0) - a)
                break;
        }
        matrix = A;

        // end

        return matrix;
    }
    #endregion
}