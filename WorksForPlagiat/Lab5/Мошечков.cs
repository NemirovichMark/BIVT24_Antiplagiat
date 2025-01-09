using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
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

        // create and use Combinations(n, k);

        static int fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * (fact(n - 1));
        }

        static int Combinations(int n, int k)
        {
            return fact(n) / (fact(k) * (fact(n - k)));
        }
        // create and use Factorial(n);
        if (k == 0 || k > 0 && k == n)
        {
            return 1;
        }
        if (!(k > 0 && k < n))
        {
            return 0;
        }
        answer = Combinations(n, k);


        // end

        return answer;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        double a = first[0];
        double b = first[1];
        double c = first[2];

        double a_1 = second[0];
        double b_1 = second[1];
        double c_1 = second[2];
        // create and use GeronArea(a, b, c);
        static double GeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        if (a + b <= c || a + c <= b || c + b <= a || a_1 + b_1 <= c_1 || b_1 + c_1 <= a_1 || c_1 + a_1 <= b_1)
        {
            return -1;
        }

        if (GeronArea(a, b, c) > GeronArea(a_1, b_1, c_1))
        {
            return 1;
        }
        else if (GeronArea(a, b, c) < GeronArea(a_1, b_1, c_1))
        {
            return 2;
        }
        else if (GeronArea(a, b, c) == GeronArea(a_1, b_1, c_1))
        {
            return 0;
        }

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }

    static double GetDistance(double v, double a, double t)
    {

        return v * t + a * t * t / 2;
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours

        if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time))
        {
            return 1;
        }

        if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time))
        {
            return 2;
        }
        else
        {
            return 0;
        }
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        for (int t = 1; ; t++)
        {
            if (GetDistance(v1, a1, t) <= GetDistance(v2, a2, t))
                return t;
        }

        // use GetDistance(v, a, t); t - hours

        // end

        return answer;
    }
    #endregion

   #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        static int FindMaxIndex(double[] array)
        {
            double maxVal = double.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        if (A.Length != 7 || B.Length != 9)
        {
            return;
        }

        int aIndex = FindMaxIndex(A);
        int bIndex = FindMaxIndex(B);
        int aLenght = A.Length - aIndex;
        int bLenght = B.Length - bIndex;
        double sum = 0;
        int count = 0;
        if (aLenght > bLenght)
        {
            for (int i = aIndex + 1; i < A.Length; i++)
            {
                sum += A[i];
                count++;
            }

            double med = sum / count;
            A[aIndex] = med;
        }
        else if (aLenght < bLenght)
        {
            for (int i = bIndex + 1; i < B.Length; i++)
            {
                sum += B[i];
                count++;
            }
            double med = sum / count;
            B[bIndex] = med;
        }
        // only 1 array has to be changed!

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }


    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here
        static int FindDiagonalMaxIndex(int[,] matrix)
        {
            int maxVal = int.MinValue;
            int maxIndex = -1;
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (row != col || row == 0)
            {
                return -1;
            }
            for (int i = 0; i < row; i++)
            {
                if (matrix[i, i] > maxVal)
                {
                    maxVal = matrix[i, i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }



        int rowA = A.GetLength(0);
        int colA = A.GetLength(1);
        int rowB = B.GetLength(0);
        int colB = B.GetLength(1);
        if (rowB != rowA || rowA != colA || colA != colB || colB != 5)
        {
            return;
        }

        int bIndex = FindDiagonalMaxIndex(B);
        int cIndex = FindDiagonalMaxIndex(A);
        for (int i = 0; i < rowB; i++)
        {
            int tmp = A[bIndex, i];
            A[bIndex, i] = B[i, cIndex];
            B[i, cIndex] = tmp;
        }
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here
        void FindMax(int[] array, out int row)
        {
            row = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[row])
                {
                    row = i;
                }
            }
        }

        static int[] DeleteElement(int[] array, int index)
        {
            int[] Arr = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    Arr[i] = array[i];
                }
                else if (i > index)
                {
                    Arr[i - 1] = array[i];
                }
                else
                {
                    continue;
                }
            }
            return Arr;
        }
        static int[] ConnectArrays(int[] arrayA, int[] arrayB)
        {
            int[] connectArr = new int[arrayA.Length + arrayB.Length];
            for (int i = 0; i < arrayA.Length; i++)
            {
                connectArr[i] = arrayA[i];
            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                connectArr[i + arrayA.Length] = arrayB[i];
            }
            return connectArr;
        }
        if (A.Length != 7 || B.Length != 8)
        {
            return;
        }

        FindMax(A, out int rowA);
        A = DeleteElement(A, rowA);
        FindMax(B, out int rowB);
        B = DeleteElement(B, rowB);
        A = ConnectArrays(A, B);

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);

        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        void SortArrayPart(int[] array, int startIndex)
        {
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                int k = i; int j = i - 1;
                while (j >= startIndex + 1)
                {
                    if (array[j] > array[k])
                    {
                        int tmp = array[j];
                        array[j] = array[k];
                        array[k] = tmp;
                        k = j;
                    }
                    j--;
                }
            }
        }
        // create and use SortArrayPart(array, startIndex);
        if (A.Length != 9 || B.Length != 11)
        {
            return;
        }
        int maxIndex = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > A[maxIndex])
            {
                maxIndex = i;
            }
        }
        SortArrayPart(A, maxIndex);

        maxIndex = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] > B[maxIndex])
            {
                maxIndex = i;
            }
        }
        SortArrayPart(B, maxIndex);
        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here


        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 1)
        {
            return;
        }
        int maxI = 0; int maxJ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (matrix[i, j] > matrix[maxI, maxJ])
                {
                    maxI = i;
                    maxJ = j;
                }
            }
        }
        int maxI2 = 0; int maxJ2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[maxI2, maxJ2])
                {
                    maxI2 = i;
                    maxJ2 = j;
                }
            }
        }
        if (maxJ == maxJ2)
        {
            matrix = RemoveColumn(ref matrix, maxJ);
        }

        else if (maxJ > maxJ2)
        {
            matrix = RemoveColumn(ref matrix, maxJ);
            matrix = RemoveColumn(ref matrix, maxJ2);
        }

        else
        {
            matrix = RemoveColumn(ref matrix, maxJ2);
            matrix = RemoveColumn(ref matrix, maxJ);
        }
        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }
    int[,] RemoveColumn(ref int[,] matrix, int columnIndex)
    {

        int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (j < columnIndex)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    temp[i, j] = matrix[i, j];
                }
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    temp[i, j] = matrix[i, j + 1];
                }
            }
        }
        matrix = temp;
        return matrix;
    }
    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        int index_A = A.GetLength(0), index_A2 = A.GetLength(1);

        int index_B = B.GetLength(0), index_B2 = B.GetLength(1);

        if (index_A != index_B && index_A2 != index_B2) return;

        int max_a = FindMaxColumnIndex(A), max_b = FindMaxColumnIndex(B);

        for (int i = 0; i < index_A; i++)
        {
            int temp = A[i, max_a];
            A[i, max_a] = B[i, max_b];
            B[i, max_b] = temp;
        }
        // create and use FindMaxColumnIndex(matrix);
        static int FindMaxColumnIndex(int[,] matrix)
        {

            int max_j = 0, max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        max_j = j;
                    }
                }
            }

            return max_j;
        }
    }



    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    public void Task_2_14(int[,] matrix)
    {
        {
            // code here
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                SortRow(matrix, i);
            }

        }
        // create and use SortRow(matrix, rowIndex);
        void SortRow(int[,] matrix, int rowIndex)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int k = i;
                int j = k - 1;
                while (j >= 0)
                {
                    if (matrix[rowIndex, j] > matrix[rowIndex, k])
                    {
                        int temp = matrix[rowIndex, j];
                        matrix[rowIndex, j] = matrix[rowIndex, k];
                        matrix[rowIndex, k] = temp;
                        k = j;
                    }
                    j--;
                }
            }
        }
    }

    // end
    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);
        void SortNegative(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    int curr = array[i], j = i - 1;
                    while (j >= 0)
                    {
                        if (curr > array[j])
                        {
                            array[i] = array[j];
                            array[j] = curr;
                            i = j;
                        }
                        j--;
                    }
                }
            }
        }

        SortNegative(A);
        SortNegative(B);

        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end

    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);

        void SortDiagonal(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int k = i;
                int j = k - 1;
                while (j >= 0)
                {
                    if (matrix[j, j] > matrix[k, k])
                    {
                        int tmp = matrix[j, j];
                        matrix[j, j] = matrix[k, k];
                        matrix[k, k] = tmp;
                        k = j;
                    }
                    j--;
                }
            }
        }
        // end
        SortDiagonal(A);
        SortDiagonal(B);
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10
        int[,] RemoveColumn(int[,] matrix, int columnIndex)
        {
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < columnIndex)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                    else if (j > columnIndex)
                    {
                        newMatrix[i, j - 1] = matrix[i, j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return newMatrix;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            bool f = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 0)
                {
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                A = RemoveColumn(A, j);
                j--;
            }
        }

        for (int j = 0; j < B.GetLength(1); j++)
        {
            bool f = false;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0)
                {
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                B = RemoveColumn(B, j);
                j--;
            }
        }

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }
    int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, j] < 0)
            {
                count++;
            }
        }
        return count;
    }
    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here

        // create and use CountNegativeInRow(matrix, rowIndex);


        // create and use FindMaxNegativePerColumn(matrix);


        rows = new int[matrix.GetLength(0)];

        cols = new int[matrix.GetLength(1)];


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            cols[j] = FindMaxNegativePerColumn(matrix, j);
        }
        // end
    }
    int FindMaxNegativePerColumn(int[,] matrix, int columnIndex)
    {
        int max_n = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, columnIndex] > max_n && matrix[i, columnIndex] < 0)
            {
                max_n = matrix[i, columnIndex];
            }
        }
        return max_n;
    }
    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        void FindMaxIndex(int[,] matrix, out int row, out int column)
        {
            int max_row = 0; int max_col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[max_row, max_col])
                    {
                        max_row = i;
                        max_col = j;
                    }
                }
            }
            row = max_row; column = max_col;
        }
        // create and use SwapColumnDiagonal(matrix, columnIndex);

        void SwapColumnDiagonal(int[,] matrix, int columnIndex)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, columnIndex];
                matrix[i, columnIndex] = matrix[i, i];
                matrix[i, i] = temp;
            }
        }


        FindMaxIndex(A, out int _, out int maxJ);
        SwapColumnDiagonal(A, maxJ);

        FindMaxIndex(B, out int _, out int maxJ2);
        SwapColumnDiagonal(B, maxJ2);
        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22

        int FindRowWithMaxNegativeCount(int[,] matrix)
        {

            int row = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int c1 = CountNegativeInRow(matrix, row);
                int c2 = CountNegativeInRow(matrix, i);
                if (c1 < c2) row = i;
            }
            return row;
        }


        for (int j = 0; j < A.GetLength(1); j++)
        {
            int temp = A[FindRowWithMaxNegativeCount(A), j];
            A[FindRowWithMaxNegativeCount(A), j] = B[FindRowWithMaxNegativeCount(B), j];
            B[FindRowWithMaxNegativeCount(B), j] = temp;
        }
        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }
    int FindSequence(int[] array, int A, int B)
    {


        for (int i = A; i < B; i++)
        {
            if (array[A] < array[A + 1] && array[i] > array[i + 1] || (array[A] >= array[A + 1]) && array[i] < array[i + 1])
            {
                return 0;
            }
        }
        if (array[A] < array[A + 1])
        {
            return 1;
        }
        return -1;
    }
    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing

        // A and B - start and end indexes of elements from array for search
        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);
        // end
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search

        int a1 = 0,
            b1 = 0,
            a2 = 0,
            b2 = 0;

        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                if (FindSequence(first, i, j) == 1 || FindSequence(first, i, j) == -1)
                {
                    a2++;
                }
                else
                {
                    break;
                }
            }
        }
        answerFirst = new int[a2, 2];
        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                if (FindSequence(first, i, j) == 1 || FindSequence(first, i, j) == -1)
                {
                    answerFirst[a1, 0] = i;
                    answerFirst[a1, 1] = j;
                    a1++;
                }
            }
        }
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                if (FindSequence(second, i, j) == 1 || FindSequence(second, i, j) == -1)
                {
                    b2++;
                }
            }
        }
        answerSecond = new int[b2, 2];
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                if (FindSequence(second, i, j) == 1 || FindSequence(second, i, j) == -1)
                {
                    answerSecond[b1, 0] = i;
                    answerSecond[b1, 1] = j;
                    b1++;
                }
            }
        }
        // end
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search

        int a = 0,
            b = 0;
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                int s = FindSequence(first, i, j);
                if (s != 0 && b - a < j - i)
                {
                    a = i;
                    b = j;
                }
            }
        }

        answerFirst = new int[] { a, b };

        a = 0;
        b = 0;
        for (int i = 0; i < second.Length; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                int s = FindSequence(second, i, j);
                if (s != 0 && b - a < j - i)
                {
                    a = i;
                    b = j;
                }
            }
        }
        answerSecond = new int[] { a, b };
        // end
    }
    #endregion
    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        // end
    }

    public void Task_3_2(int[,] matrix)
    {
        SortRowStyle sortStyle = default(SortRowStyle);

        // code here
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                sortStyle = SortAscending;
            }
            else
            {
                sortStyle = SortDescending;
            }
            sortStyle(matrix, i);
        }
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        void SortAscending(int[,] matrix, int rowIndex)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int k = i;
                int j = k - 1;
                while (j >= 0)
                {
                    if (matrix[rowIndex, j] > matrix[rowIndex, k])
                    {
                        int temp = matrix[rowIndex, j];
                        matrix[rowIndex, j] = matrix[rowIndex, k];
                        matrix[rowIndex, k] = temp;
                        k = j;
                    }
                    j--;
                }
            }
        }
        // change method in variable sortStyle in the loop here and use it for row sorting
        void SortDescending(int[,] matrix, int rowIndex)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int k = i;
                int j = k - 1;
                while (j >= 0)
                {
                    if (matrix[rowIndex, j] < matrix[rowIndex, k])
                    {
                        int temp = matrix[rowIndex, j];
                        matrix[rowIndex, j] = matrix[rowIndex, k];
                        matrix[rowIndex, k] = temp;
                        k = j;
                    }
                    j--;
                }
            }

        }
        // end
    }
    public delegate void SortRowStyle(int[,] matrix, int rowIndex);

    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)

        // end

        return answer;
    }

    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here
        GetTriangle whichTriangle;
        whichTriangle = (isUpperTriangle) ? GetUpperTriange : GetLowerTriange;
        answer = GetSum(whichTriangle, matrix);
        // create and use public delegate GetTriangle(matrix);


        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)

        int[,] GetUpperTriange(int[,] matrix)
        {

            int[,] mat2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        mat2[i, j] = matrix[i, j];
                    }
                }
            }
            return mat2;
        }

        int[,] GetLowerTriange(int[,] matrix)
        {

            int[,] mat2 = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        mat2[i, j] = matrix[i, j];
                    }
                }
            }
            return mat2;
        }
        // create and use GetSum(GetTriangle, matrix)

        int GetSum(GetTriangle triangle, int[,] matrix)
        {
            int sum = 0;
            int[,] mat2 = triangle(matrix);
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    sum = sum + mat2[i, j] * mat2[i, j];
                }
            }
            return sum;
        }

        // end

        return answer;
    }

    public delegate int[,] GetTriangle(int[,] matrix);



    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public void Task_3_6(int[,] matrix)
    {
        // code here
        FindElementDelegate diagonalSearch = FindDiagonalMaxIndex;
        FindElementDelegate columnSearch = FindFirstRowMaxIndex;

        int diagonalIndex = diagonalSearch(matrix);
        int columnIndex = columnSearch(matrix);
        SwapColumns(matrix, diagonalIndex, columnIndex);
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;

        int FindDiagonalMaxIndex(int[,] matrix)
        {
            int maxVal = int.MinValue;
            int maxIndex = -1;
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (row != col || row == 0)
            {
                return -1;
            }
            for (int i = 0; i < row; i++)
            {
                if (matrix[i, i] > maxVal)
                {
                    maxVal = matrix[i, i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        // create and use method FindFirstRowMaxIndex(matrix);
        int FindFirstRowMaxIndex(int[,] matrix)
        {
            int max_j = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[0, j] > matrix[0, max_j])
                {
                    max_j = j;
                }
            }
            return max_j;
        }
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);
        void SwapColumns(int[,] matrix, int col1, int col2)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }

        }
        // end
    }

    public delegate int FindElementDelegate(int[,] matrix);




    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }

    public void Task_3_10(ref int[,] matrix)
    {
        FindIndex searchArea = default(FindIndex);

        // code here
        searchArea = FindMaxBelowDiagonalIndex;
        FindIndex searchArea1 = FindMinAboveDiagonalIndex;
        RemoveColumns(ref matrix, searchArea, searchArea1);
        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        static int FindMaxBelowDiagonalIndex(int[,] matrix)
        {
            int max_j = 0;
            int max = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        if (max < matrix[i, j])
                        {
                            max_j = j;
                            max = matrix[i, j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return max_j;
        }
        // create and use method FindMinAboveDiagonalIndex(matrix);
        static int FindMinAboveDiagonalIndex(int[,] matrix)
        {
            int min_j = 0;
            int min = int.MaxValue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i < j)
                    {
                        if (min > matrix[i, j])
                        {
                            min_j = j;
                            min = matrix[i, j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return min_j;
        }


        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)
        void RemoveColumns(ref int[,] matrix, FindIndex findMaxBelowDiagonalIndex, FindIndex findMinAboveDiagonalIndex)
        {
            int col1 = findMaxBelowDiagonalIndex(matrix), col2 = findMinAboveDiagonalIndex(matrix);
            if (col1 == col2)
            {
                RemoveColumn(ref matrix, col1);
            }
            else
            {
                RemoveColumn(ref matrix, col1);
                RemoveColumn(ref matrix, col2 - 1);
            }
        }

        // end
    }
    public delegate int FindIndex(int[,] matrix);

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here
        GetNegativeArray searcherRows;
        GetNegativeArray searcherCols;
        searcherRows = CountNegativeInRow;
        searcherCols = FindMaxNegativePerColumn;
        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            rows = new int[n];
            cols = new int[m];
            for (int i = 0; i < n; i++)
            {
                rows[i] = searcherRows(matrix, i);
            }
            for (int j = 0; j < m; j++)
            {
                cols[j] = searcherCols(matrix, j);
            }
        }
        // end
    }
    public delegate int GetNegativeArray(int[,] matrix, int index);

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }

    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        answerFirst = DefineSequence(first, FindIncreasingSequence, FindDecreasingSequence);
        IsSequence findIncreasingSequence = FindIncreasingSequence;
        IsSequence findDecreasingSequence = FindDecreasingSequence;
        answerFirst = DefineSequence(first, findIncreasingSequence, findDecreasingSequence);
        answerSecond = DefineSequence(second, findIncreasingSequence, findDecreasingSequence);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a

        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a

        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);
        int DefineSequence(int[] array, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence)
        {
            if (findIncreasingSequence(array, 0, array.Length - 1))
            {
                return 1;
            }
            if (findDecreasingSequence(array, 0, array.Length - 1))
            {
                return -1;
            }
            return 0;
        }

        // end
    }
    public delegate bool IsSequence(int[] array, int left, int right);
    bool FindIncreasingSequence(int[] array, int A, int B)
    {
        return FindSequence(array, A, B) == 1;
    }

    bool FindDecreasingSequence(int[] array, int A, int B)
    {
        return FindSequence(array, A, B) == -1;
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence findIncreasingSequence = FindIncreasingSequence;
        IsSequence findDecreasingSequence = FindDecreasingSequence;
        answerFirstIncrease = FindLongestSequence(first, findIncreasingSequence);
        answerFirstDecrease = FindLongestSequence(first, findDecreasingSequence);
        answerSecondIncrease = FindLongestSequence(second, findIncreasingSequence);
        answerSecondDecrease = FindLongestSequence(second, findDecreasingSequence);
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);
        static int[] FindLongestSequence(int[] array, IsSequence sequence)
        {
            int[] temp = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (sequence(array, i, j))
                    {
                        if (j - i > temp[1] - temp[0])
                        {
                            temp[0] = i;
                            temp[1] = j;
                        }
                    }
                }
            }
            return temp;
        }

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
