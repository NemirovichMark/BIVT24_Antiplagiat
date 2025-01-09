using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_8(new int[,] { { 1, 2, 3, 4, -5, -6 }, { 5, 11, -17, 11, -10, 6 }, { -9, -10, -11, -14, -15, -6 }, { -9, -10, -11, -14, -15, 6 } });

    }
    //10%3 + 1 = 2 => 2,5,8,11,14,17,20,23,26,29,32
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        double sum = 0;
        int k = 0;
        for(int i=0; i < n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k += 1;
                }
            }
        }
        if (k == 0) return 0;
        answer = sum / k;

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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A==null || n!=5 || m != 4)
        {
            return default; 
        }
        for(int i = 0; i < n; i++)
        { 
            if (A[i, colIndex] <= 0)
            {
                Console.WriteLine(A[i, colIndex]);
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        //for (int i=0;i < n;i++){
        //    for(int j = 0; j < m; j++)
        //    {
        //        Console.Write(A[i,j]+" ");
        //    }
        //    Console.WriteLine();
        //}
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
        double avg;
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 6)
        {
            return null;
        }

        answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int k = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k += 1;
                }

            }
            Console.WriteLine($"Сумма {i} строки: {sum}, а кол-во элементов: {k}");
            if (k == 0) answer[i] = 0;
            if (k > 0)
            {
                avg = sum / k;
                Console.WriteLine(avg);
                answer[i] = avg;
            } 

        }
        Console.WriteLine("Massiv itog:");
        for(int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) 
        {
            return null;
        }
        int minValue = A[0,0];
        int rowIndex=0;
        for (int i = 1; i < rows; i++)
        {
            if (A[i, 0] < minValue)
            {
                minValue = A[i, 0];
                rowIndex = i;
            }
        }
        Console.WriteLine($"Row: {rowIndex}");

        int[,] newAnswer = new int[rows - 1, columns];
        int newRowIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            if (i != rowIndex) 
            {
                for (int j = 0; j < columns; j++)
                {
                    newAnswer[newRowIndex, j] = A[i, j];
                }
                newRowIndex++;
            }
        }
        A = newAnswer;
        for (int i = 0; i < newAnswer.GetLength(0); i++)
        {
            for (int j = 0; j < newAnswer.GetLength(1); j++)
            {
                Console.Write(newAnswer[i,j]+" ");
            }
            Console.WriteLine();
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
        int[] answer = default(int[]);
        // code here
        int rows  = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null  || A.GetLength(0) != 4 ||  A.GetLength(1) != 3) 
        {
            return null;
        }
        answer = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            for (int i= 0; i<rows; i++)
            {
                if (A[i, j] < 0) k += 1;
            }
            answer[j] = k;
            Console.WriteLine($"Answer[{j}]: {k}");
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
        if (B == null || B.GetLength(0) != n ||  B.GetLength(1) != m) 
        {
            return null;
        }
        int[,] newB = new int[n,m];
        for(int i = 0; i < n; i++)
        {
            int min_el = B[i, 0];
            int min_index = 0;
            for(int j = 0; j < m; j++)
            {
                if (B[i, j] < min_el)
                {
                    min_el = B[i, j];
                    min_index = j;
                }
            }
            newB[i, 0] = min_el;
            int newColIndex = 1;
            for (int j = 0; j < m; j++)
            {
                if (j != min_index) 
                {
                    newB[i, newColIndex] = B[i, j];
                    newColIndex++;
                }
            }

        }
        B = newB;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
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
        // code here
        if (F == null || F.GetLength(0) != n || F.GetLength(1) != m)
        {
            return null;
        }
        for(int i = 0; i < n; i++)
        {
            double max_el = -100;
            int max_el_index = 0;
            int first_otr_index = -1;
            int last_otr_index = -1;
            double polusum;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max_el)
                {
                    max_el = F[i, j];
                    max_el_index = j;
                }
                if (first_otr_index == -1 && F[i, j] < 0)
                {
                    first_otr_index = j;
                }

            }
            Console.WriteLine($"Max el: {max_el}");
            Console.WriteLine($"Fist otr index: {first_otr_index}");
            for(int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    last_otr_index = j;
                    break;
                }
            }
            Console.WriteLine($"Last otr index: {last_otr_index}");
            if (first_otr_index != -1 && last_otr_index != -1)
            {
                polusum = (F[i, first_otr_index] + F[i, last_otr_index]) / 2;
                Console.WriteLine($"Polusum: {polusum}");

                F[i, max_el_index] = polusum;
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
        int rows = G.GetLength(0);
        int columns = G.GetLength(1);
        if (G == null || G.GetLength(0) != 5 || G.GetLength(1) != 7)
        {
            return null;
        }
        for(int i = 0; i < rows; i++)
        {
            int max_el = -100;
            int max_el_index = -1;
            for(int j = 0; j < columns; j++)
            {
                if (G[i, j] > max_el)
                {
                    max_el = G[i, j];
                    max_el_index = j;
                }
            }
            for (int j = columns - 1; j >max_el_index; j--)
            {
                G[i, j] = G[i, j - 1];
            }
            //G[i, max_el_index + 1] = max_el;
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || rows != 5 || columns != 7 || B.Length != 7)
        {
            return null;
        }

        for (int i = 0; i < rows; i++)
        {
            int max_el = -100;
            int max_el_index = -1;
            for (int j = 0; j < columns; j++)
            {
                if (A[i, j] >= max_el)
                {
                    max_el = A[i, j];
                    max_el_index = j;
                }
            }
            Console.WriteLine($"Max index: {max_el_index}");
            //if (max_el_index == 5) 6 индекс 5
            if (max_el_index == 3)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"B[{j}]: {B[j]}");
                    A[i, j] = B[j];
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        int min_el = 100;
        int min_el_index = -1;
        int n = F.GetLength(0);
        int m = F.GetLength(1);
        int[,] newF = new int[n, m - 1];
        if (F == null || F.GetLength(0) != 5 || F.GetLength(1) != 7)
        {
            return null;
        }
        for(int j = 0; j < m; j++)
        {
            if (Math.Abs(F[2, j]) < min_el)
            {
                min_el = F[2, j];
                min_el_index = j;
            }
        }
        min_el_index += 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < min_el_index; j++)
            {
                newF[i, j] = F[i, j];
            }
            for (int j = min_el_index + 1; j < m; j++)
            {
                newF[i, j - 1] = F[i, j];
            }
        }
        F = newF;

        for (int i=0; i < n; i++)
        {
            for(int j = 0;j < m-1; j++)
            {
                Console.Write(F[i,j]+" ");
            }
            Console.WriteLine();
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
        int n =A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for(int i = 0; i < n; i++)
        {
            double max_el = double.MinValue;
            int max_el_index = -1;
            double avg;
            double sum_p_el = 0;
            int k = 0;
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    max_el_index = j;
                }
                if (A[i, j] > 0)
                {
                    sum_p_el += A[i, j];
                    k += 1;
                }
            }
            Console.WriteLine($"{i} stroka; max el: {max_el},ind: {max_el_index}, sum: {sum_p_el}, k: {k}");
            if (max_el_index != -1 && k!=0)
            {
                avg = sum_p_el / k;
                A[i, max_el_index] = avg;
            } else if (k == 0)
            {
                A[i, max_el_index] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || n !=5 || m != 7)
        {
            return null;
        }
        for(int i = 0; i < n; i++)
        {
            double max_el = A[i, 0];
            int max_el_index = 0;
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    max_el_index = j;
                }
            }
            Console.WriteLine(max_el);
            if (max_el_index==0)
            {
                if (A[i, 0] > 0) A[i, 0] *= 2;
                else A[i, 0] /= 2;
            }
            else if (max_el_index == m - 1)
            {
                if (A[i, m - 1] > 0) A[i, m - 1] *= 2;
                else A[i, m - 1] /= 2;
            }
            else 
            {
                if (A[i, max_el_index - 1] < A[i, max_el_index + 1])
                {
                    if (A[i,max_el_index-1]>0) A[i, max_el_index - 1] *= 2;
                    else A[i, max_el_index - 1] /= 2;
                }
                else
                {
                    if (A[i, max_el_index + 1]>0) A[i, max_el_index + 1] *= 2;
                    else A[i, max_el_index + 1] /= 2;
                }
                    
            }

            //if (max_el == A[i, 0] || max_el == A[i, m - 1])
            //{
            //    A[i, max_el_index + 1] *= 2;
            //}
            //else
            //{
            //    if (A[i, max_el_index - 1] < A[i, max_el_index + 1]) A[i, max_el_index - 1] *= 2;
            //    else A[i, max_el_index + 1] *= 2;
            //}
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(A[i,j]+ " ");
            }
            Console.WriteLine();
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for(int j = 0; j < m; j++)
        {
            int kolvo_polozh = 0;
            int kolvo_otr = 0;
            int max_el = A[0,j];
            int max_el_index = 0;
            for(int i = 0; i < n; i++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i,j];
                    max_el_index = i;
                }
                if (A[i, j] > 0) kolvo_polozh++;
                else if (A[i, j] < 0) kolvo_otr++;
            }
            if (kolvo_polozh > kolvo_otr)
            {
                A[max_el_index, j] = 0;
            }
            else
            {
                A[max_el_index, j] = max_el_index;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for(int j = 0; j < m; j++)
        {
            int max_el = A[0, j];
            int max_el_index = 0;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (A[i,j]> max_el)
                {
                    max_el = A[i, j];
                    max_el_index = i;
                }
            }
            Console.WriteLine($"Max el index: {max_el_index}");
            if (max_el_index <= 4)
            {
                for(int i = max_el_index+1; i < n; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0)!=7 || A.GetLength(1)!=5 || B.Length != 5)
        {
            return null;
        }
        for(int j = 0; j < m; j++)
        {
            int max_el = A[0, j];
            int max_el_index = 0;
            for(int i = 0; i < n; i++)
            {
                if (A[i,j] > max_el)
                {
                    max_el = A[i, j];
                    max_el_index = i;
                }
            }
            if (B[j] > max_el)
            {
                A[max_el_index, j] = B[j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for(int j=0; j < m; j++)
        {
            double max_el = A[0, j];
            int max_el_index = 0;
            double polusum = 0;
            for(int i=0;i<n; i++)
            {
                if (A[i, j] > max_el)
                {
                    max_el = A[i, j];
                    max_el_index = i;
                }
            }
            polusum = (A[0, j] + A[n-1,j]) / 2;
            if (max_el < polusum)
            {
                A[max_el_index,j] = polusum;
            }
            else
            {
                A[max_el_index, j] = max_el_index;
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
        int r = answer.GetLength(0);
        int c = answer.GetLength(1);
        for (int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < r; i++)
        {
            answer[i, i] = 1;
            answer[i, i + r] = 1;
            answer[i, i + 2 * r] = 1;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(answer[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int max_el = A[0, 0];
        int max_el_index = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i,i] > max_el)
            {
                max_el = A[i, i];
                max_el_index = i;
            }
        }
        Console.WriteLine(max_el);
        for(int i = 0; i < max_el_index; i++)
        {
            for(int j = i+1; j < m; j++)
            {
                A[i, j] = 0;
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j=0; j < m; j++)
            {
                Console.Write(A[i,j]+" ");
            }
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        for (int rowPair = 0; rowPair < 3; rowPair++) // 0 для 1-й и 2-й, 1 для 3-й и 4-й, 2 для 5-й и 6-й
        {
            int row1 = rowPair * 2;       // Первая строка в паре
            int row2 = rowPair * 2 + 1;   // Вторая строка в паре

            int max_el1 = B[row1, 0]; ;
            int max_el1_index = 0;
            int max_el2 = B[row2, 0];
            int max_el2_index = 0;

            for (int j = 0; j < m; j++)
            {
                if (B[row1, j] > max_el1)
                {
                    max_el1 = B[row1, j];
                    max_el1_index = j;
                }
                if (B[row2, j] > max_el2)
                {
                    max_el2 = B[row2, j];
                    max_el2_index = j;
                }
            }

            B[row1, max_el1_index] = max_el2;
            B[row2, max_el2_index] = max_el1;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, m - 1- j];
                A[i, m - 1 - j] = temp;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            matrix[0, i % n] = 0;
            matrix[n - 1, i % n] = 0;
            matrix[i % n, 0] = 0;
            matrix[i % n, n - 1] = 0;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m)
        {
            return null;
        }
        for(int i = n/2; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                //Console.WriteLine($"Sravnenit {i} and {j}");
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
                
            }
        }
        for (int i =0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m)
        {
            return default;
        }
        int k1 = 0;
        int k2 = 0;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if (i <= j) k1++;
                else k2++;
            }
        }
        upper = new int[k1];
        int upper_index = 0;
        lower = new int[k2];
        int lower_index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j) {
                    upper[upper_index] = matrix[i, j];
                    upper_index++;
                }
                else {
                    lower[lower_index] = matrix[i, j];
                    lower_index++;
                }

            }
        }
        for(int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i]+" ");
        }
        Console.WriteLine();
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i]+" ");
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
        int rows = matrix.GetLength(0), columns = matrix.GetLength(1);
        if (rows != 7 || columns != 5) return null; ;

        int[] positiveCounts = new int[7];
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCounts[i]++;
                }
            }
        }


        //// Сортировка пузырьковая
        for (int i = 0; i < positiveCounts.Length - 1; i++)
        {
            for (int j = 0; j < positiveCounts.Length - 1 - i; j++)
            {
                if (positiveCounts[j] < positiveCounts[j + 1])
                {
                    for (int k = 0; k < 5; k++)
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

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        //// Коктейльная сортировка
        //bool swapped = true;

        //while (swapped)
        //{
        //    swapped = false;

        //    for(int i = 0; i < rows - 1; i++)
        //    {
        //        if (positiveCounts[i] < positiveCounts[i + 1])
        //        {
        //            for (int j = 0; j < 5; j++)
        //            {
        //                int temp = matrix[i, j];
        //                matrix[i, j] = matrix[i + 1, j];
        //                matrix[i + 1, j] = temp;
        //            }
        //            //Замена кол-ва положительных элементов  
        //            int tempCount = positiveCounts[i];
        //            positiveCounts[i] = positiveCounts[i + 1];
        //            positiveCounts[i + 1] = tempCount;
        //            swapped = true;
        //        }
        //    }

        //    if (!swapped) break;
        //    swapped = false;

        //    for(int i = rows - 2; i >= 0; i--)
        //    {
        //        if (positiveCounts[i] < positiveCounts[i+1])
        //        {
        //            for (int j = 0; j < 5; j++)
        //            {
        //                int temp = matrix[i, j];
        //                matrix[i, j] = matrix[i+1, j];
        //                matrix[i+1, j] = temp;
        //            }
        //            int tempCount = positiveCounts[i];
        //            positiveCounts[i] = positiveCounts[i+1];
        //            positiveCounts[i+1] = tempCount;
        //            swapped = true;
        //        }
        //    }
        //}

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        bool swapped = true;
        for(int i = 0; i < n; i++)
        {
            swapped = true;

            if (i % 2 == 0)
            {
                while (swapped)
                {
                    swapped = false;
                    for(int j = 0; j < m-1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            int temp = matrix[i, j];
                            matrix[i,j] = matrix[i, j + 1];
                            matrix[i, j + 1] = temp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                    swapped = false;
                    for(int j = m-2; j >= 0; j--)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = temp;
                            swapped = true;
                        }
                    }
                }
            }
            else
            {
                while (swapped)
                {
                    swapped = false;
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = temp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                    swapped = false;
                    for (int j = m - 2; j >= 0; j--)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = temp;
                            swapped = true;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int count = 0;
        for(int i=0; i<n; i++)
        {
            for(int  j=0; j<m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine(count);
        int[,] matrix1 = new int[n-count,m];
        int matrix1_stroka = 0;
        for(int i = 0; i < n; i++)
        {
            bool nuli = false;
            for(int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    nuli = true;
                    break;
                }
                
            }
            if (!nuli)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[matrix1_stroka, j] = matrix[i, j];
                }
                matrix1_stroka++;
            }
        }
        matrix = matrix1;
        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            for(int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }


        // end

        return matrix;
    }
    #endregion
}