using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using static Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        static int Factorial(int n)
        {
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= i;
            }
            return a;
        }
        if ((n >= 0) && (k >= 0))
        {
            answer = Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        // create and use Combinations(n, k);
        // create and use Factorial(n);

        // end

        return answer;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        // create and use GeronArea(a, b, c);
        static double GeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        if ((first[0] >= first[1] + first[2]) || (first[2] >= first[1] + first[0]) || (first[1] >= first[2] + first[0]) || (second[0] >= second[1] + second[2]) || (second[1] >= second[2] + second[0]) || (second[2] >= second[1] + second[0]))
            answer = -1;
        else if (GeronArea(first[0], first[1], first[2]) > GeronArea(second[0], second[1], second[2]))
            answer = 1;
        else if (GeronArea(first[0], first[1], first[2]) < GeronArea(second[0], second[1], second[2]))
            answer = 2;
        else
            answer = 0;
        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        // create and use GetDistance(v, a, t); t - hours
        if (GetDistance(v1, a1, time) == GetDistance(v2, a2, time))
            answer = 0;
        else if (GetDistance(v2, a2, time) < GetDistance(v1, a1, time))
            answer = 1;
        else
            answer = 2;

        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public double GetDistance(double v, double a, double t)
        {
            return v * t + a * t * t / 2;
        }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        // use GetDistance(v, a, t); t - hours
        answer = 1;
        while (GetDistance(v1, a1, answer) > GetDistance(v2, a2, answer))
            answer++;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here
        // create and use FindMaxIndex(matrix, out row, out column);
        int bi = 0, bj = 0, ai = 0, aj = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 6 || B.GetLength(0) != 3 || B.GetLength(1) != 5) return;
        (ai, aj) = FindMax(A);
        (bi, bj) = FindMax(B);
        (A[ai, aj], B[bi, bj]) = (B[bi, bj], A[ai, aj]);
        // end
    }
    public (int, int) FindMax(int[,] A)
        {
            int maxel = A[0, 0];
            int row = 0, column = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > maxel)
                    {
                        maxel = A[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
            return (row, column);
        }
    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here
        //  create and use method FindDiagonalMaxIndex(matrix);
        if ((B.GetLength(0) != 5) && (C.GetLength(0) != 6) && (C.GetLength(1) != 6) && (B.GetLength(1) != 5)) return;
        B = Del(B, FindDiagonalMaxIndex(B));
        C = Del(C, FindDiagonalMaxIndex(C));
        // end
    }
    public int FindDiagonalMaxIndex(int[,] matrix)
        {
            int maxel = int.MinValue;
            int ind_i = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] > maxel)
                {
                    maxel = matrix[i, i];
                    ind_i = i;
                }
            }
            return ind_i;
        }
    public int[,] Del(int[,] matrix, int a)
        {
            int[,] matrix1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix[i, j];
                }
            }
            for (int i = a; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix[i + 1, j];
                }
            }
            return matrix1;
        }
    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);
        int[] array = new int[A.GetLength(1)];
        int ai = FindMaxInColumn(A);
        int bi = FindMaxInColumn(B);
        for (int j = 0; j < B.GetLength(1); j++)
        {
            array[j] = B[bi, j];
        }
        for (int i = 0; i < 6; i += 1)
        {
            B[bi, i] = A[ai, i];
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            A[ai, j] = array[j];
        }

        return;
        // end
    }
    public int FindMaxInColumn(int[,] C)
        {
            int maxel = int.MinValue;
            int ind_i = 0;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                if (C[i, 0] > maxel)
                {
                    maxel = C[i, 0];
                    ind_i = i;
                }
            }
            return ind_i;
        }
    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);

        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);
        int[,] A = new int[5, 5];
        for (int i = 0; i < CountRowPositive(B) + 1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A[i, j] = B[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            A[CountRowPositive(B) + 1, i] = C[i, CountColumnPositive(C)];
        }
        for (int i = CountRowPositive(B) + 1; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A[i + 1, j] = B[i, j];
            }
        }
        B = A;
        // end
    }
    public int CountRowPositive(int[,] C)
    {
        int maxel = int.MinValue;
        int count = 0;
        int ind_i = 0;
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] > 0)
                    count++;
            }
            if (count > maxel)
            {
                maxel = count;
                ind_i = i;
            }
            count = 0;
        }
        return count;
    }
    public int CountColumnPositive(int[,] C)
    {
        int maxel = int.MinValue;
        int count = 0;
        int ind_j = 0;
        for (int j = 0; j < C.GetLength(1); j++)
        {
            for (int i = 0; i < C.GetLength(0); i++)
            {
                if (C[i, j] > 0)
                    count++;
            }
            if (count > maxel)
            {
                maxel = count;
                ind_j = j;
            }
            count = 0;
        }

        return count;
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);

        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here
        // create and use SumPositiveElementsInColumns(matrix);
        answer = new int[9];
        for (int i = 0; i < 4; i++)
        {
            answer[i] = SumPositiveElementsInColumns(A, i);
        }

        for (int i = 4; i < 9; i++)
        {
            answer[i] = SumPositiveElementsInColumns(C, i - 4);
        }
        // end

        return answer;
    }
    public int SumPositiveElementsInColumns(int[,] matrix, int a)
    {
        int summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, a] > 0)
                summ += matrix[i, a];

        }
        return summ;
    }
    public void Task_2_10(ref int[,] matrix)
    {
        // code here

        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here
        // use FindMaxIndex(matrix, out row, out column); from Task_2_1
        int ai, aj, bi, bj;
        (ai, aj) = FindMax(A);
        (bi, bj) = FindMax(B);
        (A[ai, aj], B[bi, bj]) = (B[bi, bj], A[ai, aj]);
        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here
        // create and use RemoveRow(matrix, rowIndex);
        int[,] A = new int[3, 5];
        int[,] B = new int[4, 5];
        if (FindMaxElem(matrix) != FindMinElem(matrix))
        {
            B = RemoveRow(matrix, FindMaxElem(matrix));
            A = RemoveRow(B, FindMinElem(B));
            matrix = A;
        }
        else
        {
            B = RemoveRow(matrix, FindMaxElem(matrix));
            matrix = B;
        }
        // end
    }
    public int FindMaxElem(int[,] matrix)
    {
        int maxelem = matrix[0, 0];
        int ind_i = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > maxelem)
                {
                    maxelem = matrix[i, j];
                    ind_i = i;
                }
            }
        }
        return ind_i;
    }
    public int FindMinElem(int[,] matrix)
    {
        int minelem = matrix[0, 0];
        int ind_i = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < minelem)
                {
                    minelem = matrix[i, j];
                    ind_i = i;
                }
            }
        }
        return ind_i;
    }
    public int[,] RemoveRow(int[,] matrix, int rowIndex)
    {
        int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        for (int i = 0; i < rowIndex; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix2[i, j] = matrix[i, j];
            }
        }
        for (int i = rowIndex; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix2[i, j] = matrix[i + 1, j];
            }
        }
        return matrix2;
    }
    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);

        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here
        // create and use GetAverageWithoutMinMax(matrix);
        // 1 - increasing   0 - no sequence   -1 - decreasing
        if ((GetAverageWithoutMinMaxmma(A) < GetAverageWithoutMinMaxmma(B)) && (GetAverageWithoutMinMaxmma(B) < GetAverageWithoutMinMaxmma(C)))
        {
            answer = 1;
        }
        else if ((GetAverageWithoutMinMaxmma(A) >= GetAverageWithoutMinMaxmma(B)) && (GetAverageWithoutMinMaxmma(B) >= GetAverageWithoutMinMaxmma(C)))
            answer = -1;
        else
        {
            answer = 0;
        }
        // end

        return answer;
    }
    public int GetAverageWithoutMinMaxmma(int[,] matrix)
        {
            int ai, aj, bi, bj;
            (ai, aj) = FindMax(matrix); //from 2_1
            (bi, bj) = FindMin(matrix);
            matrix[ai, aj] = 0;
            matrix[bi, bj] = 0;
            int count = matrix.GetLength(0) * matrix.GetLength(1) - 2;
            int summ = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    summ += matrix[i, j];
                }
            }
            return summ / count;
        }
    public (int, int) FindMin(int[,] matrix)
        {
            int min = matrix[0, 0];
            int row = 0;
            int column = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
            return (row, column);
        }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);

        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here
        // create and use SortRowsByMaxElement(matrix);

        A = SortRowsByMaxElement(A);
        B = SortRowsByMaxElement(B);
 
        // end
    }
    public int[,] SortRowsByMaxElement(int[,] matrix)
    {
        int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix2[i, j] = matrix[i, j];
            }
        }
        int bi, bj;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            (bi, bj) = FindMax(matrix2);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = matrix2[bi, j];
                matrix2[bi, j] = int.MinValue;
            }
        }
        return matrix;
    }
    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);

        // end
    }
   
    public void Task_2_19(ref int[,] matrix)
    {
        // code here
        // use RemoveRow(matrix, rowIndex); from 2_13
        int[,] B = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        int count = 0;
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) count++;
                }
                if (count > 0) matrix = RemoveRow(matrix, i);
                count = 0;
            }
        }

        // end
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here
        answerA = [5];
        answerB = [6];
        // create and use CreateArrayFromMins(matrix);
        answerA = CreateArrayFromMins(A);
        answerB = CreateArrayFromMins(B);

        // end
    }
    public int FindMinElem(int[,] matrix, int ind)
    {
        int max = matrix[0, 0];
        int ind_i = ind;
        for (int i = ind; i < matrix.GetLength(0); i++)
        {

            if (matrix[ind, i] < max)
            {
                max = matrix[ind, i];
                ind_i = i;
            }

        }
        return ind_i;
    }
    public int[] CreateArrayFromMins(int[,] matrix)
    {
        int[] array = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int j = FindMinElem(matrix, i);
            array[i] = matrix[i, j];
        }
        return array;
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here

        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);

        // end
    }
    public void CreateArray(double[,] matrix, ref double[] array)
    {
        int k = 0;
        array = new double[matrix.GetLength(0) * matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[k++] = matrix[i, j];
            }
        }
    }
    public void Sort(ref double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            }
        }
    }
    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here
        // create and use MatrixValuesChange(matrix);
        double[] arrmxA = new double[2];
        double[] arrmxB = new double[3];
        CreateArray(A, ref arrmxA);
        CreateArray(B, ref arrmxB);
        Sort(ref arrmxA);
        Sort(ref arrmxB);
        double[] arrmxAA = arrmxA.Length >= 5 ? new double[5] : new double[arrmxA.Length];
        double[] arrmxBB = arrmxB.Length >= 5 ? new double[5] : new double[arrmxB.Length];
        arrmxAA = arrmxA;
        arrmxBB = arrmxB;
        MatrixValuesChange(ref A, arrmxAA);
        MatrixValuesChange(ref B, arrmxBB);
        // end
    }
    public void MatrixValuesChange(ref double[,] matrix, double[] arrmx)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (arrmx[0] == matrix[i, j] || arrmx[1] == matrix[i, j] || arrmx[2] == matrix[i, j] || arrmx[3] == matrix[i, j] || arrmx[4] == matrix[i, j])
                {
                    matrix[i, j] *= matrix[i, j] > 0 ? 2 : 0.5;
                }
                else matrix[i, j] *= matrix[i, j] > 0 ? 0.5 : 2;
            }
        }
    }
    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);

        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22
        maxA = FindRowWithMaxNegativeCount(A);
        maxB = FindRowWithMaxNegativeCount(B);
        // end
    }
    public int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int maxelem = 0;
        int ind_i = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    count++;
                }
            }
            if (count > maxelem)
            {
                maxelem = count;
                ind_i = i;
            }
            count = 0;
        }
        return ind_i;
    }
    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22

        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);
        A = Change(A);
        B = Change(B);
        // end
    }
    public int FindMaxElem(int[,] matrix, int rowIndex)
    {
        int maxelem = matrix[rowIndex, 0];
        int ind_j = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((matrix[rowIndex, j] > maxelem))
            {
                maxelem = matrix[rowIndex, j];
                ind_j = j;

            }
        }
        return ind_j;
    }
    public int[,] Change(int[,] matrix)
    {
        if (matrix.GetLength(0) % 2 == 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                int j = FindMaxElem(matrix, i);
                matrix[i, j] = matrix[i, j] * (j + 1);
                j = FindMaxElem(matrix, i + 1);
                matrix[i + 1, j] = 0;
            }
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i += 2)
            {
                int j = FindMaxElem(matrix, i);
                matrix[i, j] = matrix[i, j] * (j + 1);
                j = FindMaxElem(matrix, i + 1);
                matrix[i + 1, j] = 0;
            }

            int c = FindMaxElem(matrix, matrix.GetLength(0) - 1);
            matrix[matrix.GetLength(0) - 1, c] *= (c + 1);
        }
        return matrix;
    }
    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search

        // end
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search

        // end
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search

        // end
    }
    #endregion

    #region Level 3
    public delegate double SumFunction(int i, double x, ref int change);
    public delegate double YFunction(double x);
    public double Part1(int i, double x, ref int i_fact)
    {
        if (i > 0)
            i_fact *= i;

        return Math.Cos(i * x) / i_fact;
    }
    public double Part2(int i, double x, ref int el)
    {
        el *= -1;
        return el * Math.Cos(i * x) / (i * i);
    }
    public double FindY_1(double x)
    {
        return Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
    }
    public double FindY_2(double x)
    {
        return ((x * x) - Math.PI * Math.PI / 3) / 4;
    }
    public double CalculateSum(SumFunction sumFunction, double x, int i)
    {
        double eps = 0.0001, summ = 0;
        int change = 1;
        double current = sumFunction(i, x, ref change);
        while (Math.Abs(current) > eps)
        {
            summ += current;
            current = sumFunction(++i, x, ref change);
        }
        return summ;
    }
    public void GetSumAndY(SumFunction sFunction, YFunction yFunction, double a, double b, double h, double[,] sum_y, int si = 0)
    {
        for (int i = 0; i < (b - a) / h + 1; i++)
        {
            double x = a + i * h;
            double sum = CalculateSum(sFunction, x, si);
            double y = yFunction(x);
            sum_y[i, 0] = sum;
            sum_y[i, 1] = y;
        }
    }
    public void Task_3_1(ref double[,] sum_y_1, ref double[,] sum_y_2)
    {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        double a1 = 0.1, b1 = 1, h1 = 0.1;
        sum_y_1 = new double[(int)((b1 - a1) / h1) + 1, 2];
        GetSumAndY(Part1, FindY_1, a1, b1, h1, sum_y_1);

        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;
        sum_y_2 = new double[(int)((b2 - a2) / h2) + 1, 2];
        GetSumAndY(Part2, FindY_2, a2, b2, h2, sum_y_2, 1);

        // end
    }

    public void Task_3_2(int[,] matrix)
    {
        // SortRowStyle sortStyle = default(SortRowStyle); - uncomment me

        // code here

        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        // end
    }

    public delegate void SwapDirection(double[] array);

    public void SwapRight(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i += 2)
        {
            (array[i], array[i + 1]) = (array[i + 1], array[i]);
        }
    }

    public void SwapLeft(double[] array)
    {
        for (int i = array.Length - 1; i > 0; i -= 2)
        {
            (array[i], array[i - 1]) = (array[i - 1], array[i]);
        }
    }

    public double GetSum(double[] array)
    {
        double summ = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            summ += array[i];
        }
        return summ;
    }
    public double Task_3_3(double[] array)
    {
        double answer = 0;
        SwapDirection swapper = default(SwapDirection);

        // code here
        double summ = 0;
        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)

        foreach (double elem in array)
        {
            summ += elem;
        }
        double average = summ / array.Length;
        if (array[0] > average) swapper = SwapRight;
        else swapper = SwapLeft;
        swapper(array);
        answer = GetSum(array);
        // end

        return answer;
    }

    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

        // end

        return answer;
    }

    public delegate int Function(double a, double b, double h);
    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here
        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions
        Function function = CountSignFlips1;
        func1 = function(0, 2, 0.1);
        Function function1 = CountSignFlips2;
        func2 = function1(-1, 1, 0.2);

        // end
    }
    public int CountSignFlips1(double a, double b, double h)
    {
        int k = 1;
        double f = a * a - Math.Sin(a);
        int el = 0;
        if (f < 0) el = -1;
        else el = 1;

        for (double i = a + h; i <= b; i += h)
        {
            f = i * i + Math.Sin(i);
            if (((f < 0) && (el > 0)) || ((f > 0) && (el < 0))) k++;
            if (f < 0) el = -1;
            else el = 1;
        }
        return k;
    }

    public int CountSignFlips2(double a, double b, double h)
    {
        int k = 1;
        double f = Math.Exp(a) - 1;
        int el = 0;
        if (f < 0) el = -1;
        else el = 1;

        for (double i = a + h; i <= b; i += h)
        {
            f = Math.Exp(i) - 1;
            if (((f < 0) && (el > 0)) || ((f > 0) && (el < 0))) k++;
            if (f < 0) el = -1;
            else el = 1;
        }
        return k;
    }
    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }

    public delegate int CountPositive(int[,] matrix);
    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);
        int[,] newMatrix = new int[5, 5];
        CountPositive find = CountRowPositive;
        CountPositive find1 = CountColumnPositive;
        for (int i = 0; i < find(B) + 1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newMatrix[i, j] = B[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            newMatrix[find(B) + 1, i] = C[i, find1(C)];
        }
        for (int i = CountRowPositive(B) + 1; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newMatrix[i + 1, j] = B[i, j];
            }
        }
        B = newMatrix;
        // end
    }
    public void Task_3_10(ref int[,] matrix)
    {
        // FindIndex searchArea = default(FindIndex); - uncomment me

        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }

    public delegate int FindElementDelegate(int[,] matrix);
    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)
        int[,] A = new int[3, 5];
        int[,] B = new int[4, 5];
        FindElementDelegate find = FindMinElem;
        FindElementDelegate find1 = FindMaxElem;
        if (find1(matrix) != find(matrix))
        {
            B = Remove(matrix, find1(matrix));
            A = Remove(B, find(B));
            matrix = A;
        }
        else
        {
            B = Remove(matrix, FindMaxElem(matrix));
            matrix = B;
        }

        // end
    }
    public int[,] Remove(int[,] matrix, int a)
    {
        int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix2[i, j] = matrix[i, j];
            }
        }
        for (int i = a; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                matrix2[i, j] = matrix[i + 1, j];
            }
        }
        return matrix2;
    }
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here

        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }

    public delegate int Find(int[,] A, int a);
    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);
        A = Change(A);
        B = Change(B);
        // end
    }
    public int Ind_J(int[,] matrix, int ind)
    {
        int maxel = matrix[ind, 0];
        int ind_j = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((matrix[ind, j] > maxel))
            {
                maxel = matrix[ind, j];
                ind_j = j;
            }
        }
        return ind_j;
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        // end
    }
    #endregion
    #region bonus part
    public double[,] Task_4(double[,] matrix, int index)
    {
        // MatrixConverter[] mc = new MatrixConverter[4]; - uncomment me

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        // end

        return matrix;
    }
    #endregion
}
