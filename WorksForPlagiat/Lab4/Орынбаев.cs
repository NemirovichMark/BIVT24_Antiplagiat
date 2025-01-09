using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (A != null && rows == columns)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                answer += A[i, i];
            }
            Console.WriteLine($"Ответ есть {answer}.");
        }
        else { Console.WriteLine($"Матрица не квадратная."); }
        // end

        return answer;
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        answer = new int[rows];
        if (rows == 4 && columns == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                int index = 0;
                int minValue = 100000;
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] < minValue)
                    {
                        minValue = A[i, j];
                        index = j;
                    }
                }
                answer[i] = index;
                Console.WriteLine($"{index} есть нужный индекс." );
            }
        }
        else { answer = null; }
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            int rows = A.GetLength(0);
            int columns = A.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < rows; i++)
            {
                int index = 0;
                int max = -10000;
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index = j;
                    }
                }
                if (index != 0)
                {
                    int ak = A[i, 0];
                    A[i, 0] = max;
                    A[i, index] = ak;
                    Console.WriteLine($"{max} и {ak} были поменяны местами.");
                }
            }
        }
        else { A = null; }
        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        if (A.GetLength(0) == 6 && A.GetLength(1) == 7)
        {
            int rows = A.GetLength(0);
            int columns = A.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
            int max = -100000;
            int index_1 = 0;
            int index_2 = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_1 = i;
                        index_2 = j;
                    }
                }
            }
            int[,] ak = new int[rows - 1, columns - 1];
            for (int i = 0, newRow = 0; i < rows; i++)
            {
                if (i == index_1) continue;
                for (int j = 0, newCol = 0; j < columns; j++)
                {
                    if (j == index_2) continue;
                    ak[newRow, newCol] = A[i, j];
                    newCol++;
                    Console.Write(A[i, j] + "t");
                }
                newRow++;
                Console.WriteLine();
            }
            A = ak;
        }
        else { A = null; }
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            int rows = A.GetLength(0);
            int columns = A.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < rows; i++)
            {
                int max = -100000;
                int index_max = -1;
                for (int j = 0;j < columns; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_max = j;
                    }
                    Console.Write(A[i, j] + "t");
                }
                A[i, index_max] *= i + 1;
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        int rows = D.GetLength(0);
        int columns = D.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(D[i, j] + "t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            if (D[i, 0] < 0) continue;
            int max = -10000;
            int index_max = -1;
            int index_last_neg = -1;
            bool found_first_neg = false;
            for (int j = 0; j < columns; j++)
            {
                if (D[i, j] < 0)
                {
                    found_first_neg = true;
                    index_last_neg = j;
                }
                else if (!found_first_neg && D[i, j] > max)
                {
                    max = D[i, j];
                    index_max = j;
                }
            }
            if (index_last_neg != -1 && index_max != -1)
            {
                int ak = D[i, index_max];
                D[i, index_max] = D[i, index_last_neg];
                D[i, index_last_neg] = ak;
            }
        }
        // end

        return D;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        int rows = H.GetLength(0);
        int columns = H.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(H[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 5 && columns == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                int max = -10000;
                for (int j = 0; j < columns; j++)
                {
                    if (H[i, j] > max)
                    {
                        max = H[i, j];
                    }
                }
                int ak = H[i, 5];
                H[i, 5] = max;
                H[i, 6] = ak;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(H[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { H = null; }
        // end

        return H;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        int rows = Y.GetLength(0);
        int columns = Y.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(Y[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 6 && columns == 5)
        {
            for (int i = 0; i < rows; i++)
            {
                double max = -10000;
                double sredn = 0;
                int count_for_sredn = 0;
                int count_for_neg = 0;
                int index_max = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (Y[i, j] > max)
                    {
                        max = Y[i, j];
                        index_max = j;
                    }
                }
                for (int j = index_max + 1; j < columns; j++)
                {
                    if (Y[i, j] > 0)
                    {
                        sredn += Y[i, j];
                        count_for_neg++;
                    }
                }
                if (count_for_neg != 0)
                {
                    sredn /= count_for_neg;
                }
                for (int j = 0; j < index_max; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Console.WriteLine($"{Y[i, j]} будет заменён на {sredn}");
                        Y[i, j] = sredn;
                    }
                }
            }
        }
        else { Y = null; }

        // end

        return Y;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        int rows = B.GetLength(0);
        int columns = B.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(B[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 5 && columns == 7)
        {
            int[] array = new int[5];
            for (int i = 0; i < rows; i++)
            {
                int max = -10000;
                for (int j = 0; j < columns; j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                }
                array[i] = max;
            }
            for (int i = 0; i < rows; ++i)
            {
                Console.WriteLine($"{B[i, 3]} будет заменён на {array[rows - i - 1]}");
                B[i, 3] = array[rows - i - 1];
            }
        }
        else { B = null; }
        // end

        return B;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        int rows = B.GetLength(0);
        int columns = B.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(B[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 5 && columns == 5)
        {
            int max = -10000;
            int index_max = 0;
            for (int i = 0; i < rows; i++)
            {
                if (B[i, i] > max)
                {
                    max = B[i, i];
                    index_max = i;
                }
            }
            int index_neg = -1;
            for (int i = 0; i < rows; ++i)
            {
                if (B[i, 2] < 0)
                {
                    index_neg = i;
                    break;
                }
            }
            if (index_neg != -1)
            {
                for (int k = 0; k < columns; k++)
                {
                    int ak = B[index_max, k];
                    B[index_max, k] = B[index_neg, k];
                    B[index_neg, k] = ak;
                    Console.WriteLine($"{B[index_max, k]} и {B[index_neg, k]} были поменяны местами.");
                }
            }
        }
        else { B = null; }
        // end

        return B;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 5 && columns == 7)
        {
            int count_neg = 0;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] < 0)
                    {
                        count_neg++;
                    }
                }
            }
            answer = new int[count_neg];
            int index_for_answer = 0;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] < 0)
                    {
                        answer[index_for_answer] = A[i, j];
                        Console.WriteLine($"{answer[index_for_answer]} и есть элемент искомого символа.");
                        index_for_answer++;
                    }
                }
            }
            if (count_neg == 0)
            {
                answer = null;
            }
        }
        else { answer = null; }
        // end

        return answer;
    }
    #endregion
    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 5 && columns == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                int index_max = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] > A[i, index_max])
                    {
                        index_max = j;
                    }
                }
                if (index_max != 0 && index_max < columns - 1)
                {
                    if (A[i, index_max - 1] < A[i, index_max + 1])
                    {
                        double number = A[i, index_max - 1];
                        A[i, index_max - 1] = number >= 0 ? number * 2 : (number < 0 ? number / 2 : number);
                    }
                    else if (A[i, index_max - 1] > A[i, index_max + 1])
                    {
                        double number = A[i, index_max + 1];
                        A[i, index_max + 1] = number >= 0 ? number * 2 : (number < 0 ? number / 2 : number);
                    }
                }
                else if (index_max == 0)
                {
                    double number = A[i, 1];
                    A[i, 1] = number >= 0 ? number * 2 : (number < 0 ? number / 2 : number);
                }
                else if (index_max == columns - 1)
                {
                    double number = A[i, columns - 2];
                    A[i, columns - 2] = number >= 0 ? number * 2 : (number < 0 ? number / 2 : number);
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 7 && columns == 5)
        {
            for (int j = 0; j < columns; j++)
            {
                int max = -100000;
                int count_neg = 0;
                int count_pos = 0;
                int index_max = -1;
                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] < 0)
                    {
                        count_neg++;
                    }
                    if (A[i, j] > 0)
                    {
                        count_pos++;
                    }
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_max = i;
                    }
                }
                if (count_pos > count_neg)
                {
                    A[index_max, j] = 0;
                }
                else { A[index_max, j] = index_max + 1; }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 10 && columns == 5)
        {
            for (int j = 0; j < columns; j++)
            {
                int max = -100000;
                int index_max = -1;
                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_max = i;
                    }
                }
                if (index_max <= 4)
                {
                    int sum = 0;
                    for (int i = index_max + 1; i < rows; i++)
                    {
                        sum += A[i, j];
                    }
                    A[0, j] = sum;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 7 && columns == 5 && B.Length == 5)
        {
            for (int j = 0; j < columns; j++)
            {
                int max = -100000;
                int index_max = -1;
                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_max = i;
                    }
                }
                if (B[j] > max)
                {
                    A[index_max, j] = B[j];
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }
        if (rows == 7 && columns == 5)
        {
            for (int j = 0; j < columns; j++)
            {
                int index_max = 0;
                double max = -100000;
                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        index_max = i;
                    }
                }
                if (max < (A[0, j] + A[6, j]) / 2)
                {
                    A[index_max, j] = (A[0, j] + A[6, j]) / 2;
                }
                else { A[index_max, j] = index_max + 1; }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        Console.WriteLine($"{n} — входное число.");
        if (n > 0 && !(n > (int.MaxValue / 3)))
        {
            answer = new int[n, 3 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    answer[i, j] = (j % 3 == i) ? 1 : 0;
                }
            }
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Console.Write(answer[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { answer = null; }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == 6 && columns == 6)
        {
            int index_max = -1;
            int max = -100000;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    index_max = i;
                }
            }
            for (int i = 0; i < index_max; i++)
            {
                for (int j = i + 1; j < columns; j++)
                {
                    A[i, j] = 0;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int rows = B.GetLength(0);
        int columns = B.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(B[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == 6 && columns == 6)
        {
            for (int i = 0; i < rows; i = i + 2)
            {
                int max_1 = -10000;
                int index_max_1 = -1;
                int max_2 = -10000;
                int index_max_2 = -1;
                for (int j = 0; j < columns; j++)
                {
                    if (B[i, j] > max_1)
                    {
                        max_1 = B[i, j];
                        index_max_1 = j;
                    }
                    if (B[i + 1, j] > max_2)
                    {
                        max_2 = B[i + 1, j];
                        index_max_2 = j;
                    }
                }
                int temp = max_1;
                B[i, index_max_1] = B[i + 1, index_max_2];
                B[i + 1, index_max_2] = temp;
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { B = null; }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(A[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == 6 && columns == 7)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < (columns)/2; j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[i, columns - j - 1];
                    A[i, columns - j - 1] = temp;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { A = null; }
        // end

        return A;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == columns)
        {
            int n = rows;
            for (int i = 0; i < n; i++)
            {
                matrix[0, i] = 0;
                matrix[n - 1, i] = 0;
                matrix[i, 0] = 0;
                matrix[i, n - 1] = 0;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { matrix = null; }
        // end

        return matrix;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == columns)
        {
            int n = rows;
            for (int i = rows/2; i < rows; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    matrix[i, j] = 1;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { matrix = null; }
        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == columns)
        {
            int n = rows;
            upper = new int[n * (n + 1) / 2];
            lower = new int[n * (n - 1) / 2];
            int upper_index = 0;
            int lower_index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j >= i)
                    {
                        upper[upper_index++] = matrix[i, j];
                    }
                    else { lower[lower_index++] = matrix[i, j]; }
                }
            }
            for (int i = 0; i < upper.Length; i++)
            {
                Console.WriteLine($"{upper[i]} — и есть элемент верхнего треугольника.");
            }
            for (int i = 0; i < lower.Length; i++)
            {
                Console.WriteLine($"{lower[i]} — и есть элемент нижнего треугольника.");
            }
        }
        else { upper = null;
            lower = null;
        }
        // end

        return (upper, lower);
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        if (rows == 7 && columns == 5)
        {
            int[] positive_counts = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
                positive_counts[i] = count;
            }
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (positive_counts[j] < positive_counts[j + 1])
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = temp;
                        }
                        int tempCount = positive_counts[j];
                        positive_counts[j] = positive_counts[j + 1];
                        positive_counts[j + 1] = tempCount;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
        else { matrix = null; }
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "t");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "/t");
            }
            Console.WriteLine();
        }
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            bool has_zero = false;
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] == 0)
                {
                    has_zero = true;
                    break;
                }
            }
            if (!has_zero)
            {
                count++;
            }
        }
        int[,] answer = new int[count, columns];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            bool has_zero = false;
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] == 0)
                {
                    has_zero = true;
                    break;
                }
            }
            if (!has_zero)
            {
                for (int j = 0; j < columns; j++)
                {
                    answer[index, j] = matrix[i, j];
                }
                index++;
            }
        }
        matrix = answer;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "t");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    #endregion
}