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
        if (k == 0 || k == n) answer = 1;
        if (k > 0 && k < n) answer = Factorial(n) / (Factorial(k) * Factorial(n - k));


        // create and use Combinations(n, k);

        // create and use Factorial(n);
       long Factorial(int n)
        {
            long f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            return f;
        }
        // end

        return answer;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        double a1 = first[0], b1 = first[1], c1 = first[2];
        double a2 = second[0], b2 = second[1], c2 = second[2];

        if (!(a1 < (b1 + c1) && b1 < (a1 + c1) && c1 < (a1 + b1)) || !(a2 < (b2 + c2) && b2 < (a2 + c2) && c2 < (a2 + b2))) return -1;

        double s1 = GeronArea(a1, b1, c1);
        double s2 = GeronArea(a2, b2, c2);

        if (s1 > s2) answer = 1;
        else if (s1 < s2) answer = 2;
        else answer = 0;
        return answer;
        // end
    }
    // create and use GeronArea(a, b, c);
    public double GeronArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    // first = 1, second = 2, equal = 0, error = -1



    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        double s1 = GetDistance(v1, a1, time);
        double s2 = GetDistance(v2, a2, time);

        if (s1 > s2) answer = 1;
        else if (s1 < s2) answer = 2;
        else answer = 0;
        return answer;

        // end
    }
        // create and use GetDistance(v, a, t); t - hours
    public double GetDistance(double v, double a, int t)
    {
        return v * t + 0.5 * a * t * t;
    }

        // first = 1, second = 2, equal = 0
    

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 1;

        // code here
        // use GetDistance(v, a, t); t - hours

        while (GetDistance(v1, a1, answer) > GetDistance(v2, a2, answer))
        {
            answer++;
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
        if (FindMax(A) < FindMax(B))
        {
            double sr = 0, s = 0;
            int k = 0;
            for (int i = FindMax(A) + 1; i < A.Length; i++)
            {
                s += A[i];
                k++;
            }
            sr = s / k;
            A[FindMax(A)] = sr;

        }
        else
        {
            double sr = 0, s = 0;
            int k = 0;
            for (int i = FindMax(B) + 1; i < B.Length; i++)
            {
                s += B[i];
                k++;
            }
            sr = s / k;
            B[FindMax(B)] = sr;

        }
    }
    // create and use FindMax(array);
    public int FindMax(double[] array)
    {
        int index = -1;
        double max = Int32.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        return index;
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
        int[] temp = new int[A.GetLength(1)];
        int index_A = FindDiagonalMaxIndex(A); 
        for (int j = 0; j < A.GetLength(1); j++)  
        {
            temp[j] = A[index_A, j];
        }

        int[] r = new int[B.GetLength(0)];
        int index_B = FindDiagonalMaxIndex(B); 
        for (int i = 0; i < B.GetLength(0); i++) 
        {
            r[i] = B[i, index_B];
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[index_A, j] = r[j];
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, index_B] = temp[i];
        }
    }

    public int FindDiagonalMax(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int max = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, i] > max)
            {
                max = matrix[i, i];
            }
        }
        return max;
    }
    //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
    public int FindDiagonalMaxIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int max = matrix[0, 0];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, i] > max)
            {
                max = matrix[i, i];
                index = i;
            }
        }
        return index;

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

        int maxIndexA = FindMax(A);
        int maxIndexB = FindMax(B);


        if (A.Length > 0)
            DeleteElement(ref A, maxIndexA);
        if (B.Length > 0)
            DeleteElement(ref B, maxIndexB);


        int[] C = new int[A.Length + B.Length];
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            C[k] = A[i];
            k++;
        }

        for (int j = 0; j < B.Length; j++)
        {
            C[k] = B[j];
            k++;
        }
        A = C;
    }
    // create and use DeleteElement(array, index);
    public void DeleteElement(ref int[] array, int index)
    {
        if (array.Length == 0) return; 

        int[] A = new int[array.Length - 1];
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                A[k] = array[i];
                k++;
            }
        }

        array = A;
    }
    // create and use FindMax(matrix, out row, out column); like in Task_2_1
    public int FindMax(int[] array)
    {
        if (array.Length == 0) return -1;

        int index = 0;
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }

        return index;
    }


    // end


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

        A = SortArrayPart(A, FindMax(A)); 
        B = SortArrayPart(B, FindMax(B));

        // create and use SortArrayPart(array, startIndex);
        int[] SortArrayPart(int[] array, int startIndex)
    {
        for (int i = startIndex + 1; i < array.Length; i++)
        {
            for (int j = startIndex + 1; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
    // end
}

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int max = matrix[0, 0];
        int indexMax = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    indexMax = j;
                }
            }
        }

        int min = matrix[0, 1];
        int indexMin = 1;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    indexMin = j;
                }
            }
        }
        if (indexMax == indexMin)
        {
            RemoveColumn(ref matrix, indexMax);
        }
        else
        {
            if (indexMax > indexMin)
            {
                RemoveColumn(ref matrix, indexMax);
                RemoveColumn(ref matrix, indexMin);
            }
            else
            {
                RemoveColumn(ref matrix, indexMin);
                RemoveColumn(ref matrix, indexMax);
            }
        }
    }
    // create and use RemoveColumn(matrix, columnIndex);

    public void RemoveColumn(ref int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[,] result = new int[n, m - 1];
        for (int j = 0; j < m - 1; j++)
        {
            if (j < columnIndex)
            {
                for (int i = 0; i < n; i++) result[i, j] = matrix[i, j];
            }
            else
            {
                for (int i = 0; i < n; i++) result[i, j] = matrix[i, j + 1];
            }

        }
        matrix = result;
    }
   
    // end


    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here
        int n = A.GetLength(0);
        int index_A = FindMaxColumnIndex(A);
        int index_B = FindMaxColumnIndex(B);
        for (int i = 0; i < n; i++)
        {
            int temp = A[i, index_A];
            A[i, index_A] = B[i, index_B];
            B[i, index_B] = temp;
        }
    }
    // create and use FindMaxColumnIndex(matrix);

    public int FindMaxColumnIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int index = 0;
        int max = matrix[0, 0];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    index = j;
                }
            }
        }
        return index;
    }

    // end


    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    public void Task_2_14(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            matrix = SortRow(matrix, i);
        }
    }
        // create and use SortRow(matrix, rowIndex);
    public int[,] SortRow(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1);
        for (int j = 0; j < m - 1; j++)
        {
            for (int k = 0; k < m - j - 1; k++)
            {
                if (matrix[rowIndex, k] > matrix[rowIndex, k + 1])
                {
                    int t = matrix[rowIndex, k];
                    matrix[rowIndex, k] = matrix[rowIndex, k + 1];
                    matrix[rowIndex, k + 1] = t;
                }
            }
        }
        return matrix;
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
        A = SortNegative(A);
        B = SortNegative(B);

        // end
    }

    // create and use SortNegative(array);
    public int[] SortNegative(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            if (array[i] >= 0) continue;
            int k = array[i];
            int j = i - 1;
            while (j >= 0)
            {
                if (array[j] < 0 && array[j] < k)
                {
                    array[i] = array[j];
                    array[j] = k;
                    i = j;
                }
                j--;
            }
        }
        return array;
    }

    // end


    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here
        A = SortDiagonal(A);
        B = SortDiagonal(B);
    }
    // create and use SortDiagonal(matrix);
    public int[,] SortDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, i] > matrix[j, j])
                {
                    int temp = matrix[i, i];
                    matrix[i, i] = matrix[j, j];
                    matrix[j, j] = temp;
                }
            }

        }
        return matrix;
    }

    // end


    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here
        RemoveColumnsWithZero(ref A);

        RemoveColumnsWithZero(ref B);
    }

    public void RemoveColumnsWithZero(ref int[,] matrix)
    {
        int n = matrix.GetLength(0); 
        int m = matrix.GetLength(1);  

        for (int j = m - 1; j >= 0; j--) 
        {
            bool hasZero = false;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                RemoveColumn(ref matrix, j);
            }
        }
    }




    // end


    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        CountNegativeCountPerRow(matrix, out rows);
        FindMaxNegativePerColumn(matrix, out cols);
    }
    // create and use FindMaxNegativePerColumn(matrix);
    public void FindMaxNegativePerColumn(int[,] matrix, out int[] cols)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        cols = new int[m];

        for (int j = 0; j < m; j++)
        {
            int maxNegative = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > maxNegative)
                {
                    maxNegative = matrix[i, j];
                }
            }
            cols[j] = (maxNegative == Int32.MinValue) ? 0 : maxNegative;
        }
    }
    // create and use CountNegativeInRow(matrix, rowIndex);
    public void CountNegativeCountPerRow(int[,] matrix, out int[] rows)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        rows = new int[n];

        for (int i = 0; i < n; i++)
        {
            int k = 0;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < 0)
                {
                    k++;
                }
            }

            rows[i] = k;
        }
    }

    // end


    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here
        Result(ref A);
        Result(ref B);

        // end
    }
    // use FindMaxIndex(matrix, out row, out column); like in 2_1
    public void Result(ref int[,] A)
    {
        int n = A.GetLength(0);
        int index = FindMaxColumnIndex(A);
        for (int i = 0; i < n; i++)
        {
            int t = A[i, i];
            A[i, i] = A[i, index];
            A[i, index] = t;
        }
    }


    // end


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
        int row_A = FindRowWithMaxNegativeCount(A);
        int row_B = FindRowWithMaxNegativeCount(B);
        int m = A.GetLength(1);
        for (int j = 0; j < m; j++)
        {
            int temp = A[row_A, j];
            A[row_A, j] = B[row_B, j];
            B[row_B, j] = temp;
        }
    }
    // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
    public int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int k = 0;
        int m = matrix.GetLength(1);
        for (int j = 0; j < m; j++)
        {
            if (matrix[rowIndex, j] < 0) k++;
        }
        return k;
    }
    // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
    public int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int index = -1, maxNegatives = -1;
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            int negativeCount = CountNegativeInRow(matrix, i);
            if (negativeCount > maxNegatives)
            {
                maxNegatives = negativeCount;
                index = i;
            }
        }
        return index;
    }

    // end


    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        // Определение монотонности для каждой функции
        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);
    }
    // A and B - start and end indexes of elements from array for search
    static bool IsIncreasing(int[] array, int A, int B)
    {
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1]) return false;
        }
        return true;
    }

    static bool IsDecreasing(int[] array, int A, int B)
    {
        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1]) return false;
        }
        return true;
    }
    // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
    static int FindSequence(int[] array, int A, int B)
    {
        if (IsIncreasing(array, A, B)) return 1;
        if (IsDecreasing(array, A, B)) return -1;
        return 0;
    }

    // end


    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here
        answerFirst = FindSequence1(first, 0, first.Length - 1);
        answerSecond = FindSequence1(second, 0, second.Length - 1);
    }
    // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
    static int[,] FindSequence1(int[] array, int A, int B)
    {
        int k = 0;
        for (int i = A; i < B; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0) k++;
            }
        }
        int[,] matrix = new int[k, 2];
        k = 0;
        for (int i = A; i < B; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0)
                {
                    matrix[k, 0] = i;
                    matrix[k, 1] = j;
                    k++;
                }
            }
        }
        return matrix;
    }

    // end


    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // end
    }

   
    // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
    // A and B - start and end indexes of elements from array for search

    // end

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
        // SortRowStyle sortStyle = default(SortRowStyle); - uncomment me

        // code here
        int n = matrix.GetLength(0); 
        int m = matrix.GetLength(1);


        SortRowStyle sortStyle;
        for (int i = 0; i < n; i++)
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
    }
    // create and use public delegate SortRowStyle(matrix, rowIndex);
    public delegate void SortRowStyle(int[,] matrix, int rowIndex);
    // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
    // change method in variable sortStyle in the loop here and use it for row sorting
    public void SortAscending(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1); 
        for (int j = 0; j < m - 1; j++) 
        {
            for (int k = j + 1; k < m; k++)
            {
                if (matrix[rowIndex, j] > matrix[rowIndex, k])
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, k];
                    matrix[rowIndex, k] = temp;
                }
            }
        }
    }
    public void SortDescending(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1); 
        for (int j = 0; j < m - 1; j++)
        {
            for (int k = j + 1; k < m; k++) 
            {
                if (matrix[rowIndex, j] < matrix[rowIndex, k])
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, k];
                    matrix[rowIndex, k] = temp;
                }
            }
        }
    }

    // end


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

        // code her
        GetTriangle triangleMethod = isUpperTriangle ? GetUpperTriangle : GetLowerTriangle;
        int[] triangleElements = triangleMethod(matrix);
        answer = GetSum(triangleElements);

        return answer;
    }
    // create and use public delegate GetTriangle(matrix);
    public delegate int[] GetTriangle(int[,] matrix);
    public int GetSum(int[] elements)
    {
        int sum = 0;
        foreach (var element in elements)
        {
            sum += element * element;
        }
        return sum;
    }
    // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
    public int[] GetUpperTriangle(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        List<int> elements = new List<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                elements.Add(matrix[i, j]);
            }
        }

        return elements.ToArray();
    }
    public int[] GetLowerTriangle(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        List<int> elements = new List<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                elements.Add(matrix[i, j]);
            }
        }
        return elements.ToArray();
    }

    // end
    

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
        FindElementDelegate element_diagonal;
        element_diagonal = FindDiagonalMaxIndex;
        FindElementDelegate element_firstRow;
        element_firstRow = FindFirstRowMaxIndex;
        matrix = SwapColumns(matrix, element_diagonal, element_firstRow);
    }
    // create and use public delegate FindElementDelegate(matrix);
    public delegate int FindElementDelegate(int[,] matrix);
    // create and use method FindFirstRowMaxIndex(matrix);
    public int FindFirstRowMaxIndex(int[,] matrix)
    {
        int ind = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[0, j] > matrix[0, ind]) ind = j;
        }
        return ind;
    }
    // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);
    public int[,] SwapColumns(int[,] matrix, FindElementDelegate diagonal, FindElementDelegate firstRow)
    {
        int inddiagonal = diagonal(matrix);
        int indfirstRow = firstRow(matrix);
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int t = matrix[i, inddiagonal];
            matrix[i, inddiagonal] = matrix[i, indfirstRow];
            matrix[i, indfirstRow] = t;
        }
        return matrix;
    }
    // end


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
        // code here
        FindIndex max = default(FindIndex);
        FindIndex min = default(FindIndex);
        max = FindMaxBelowDiagonalIndex;
        min = FindMinAboveDiagonalIndex;
        RemoveColumns(ref matrix, max, min);
    }
    // create and use public delegate FindIndex(matrix);
    public delegate int FindIndex(int[,] matrix);
    // create and use method FindMaxBelowDiagonalIndex(matrix);
    public int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int max = int.MinValue;
        int indexMax = -1;
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j <= i; j++) 
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    indexMax = j;
                }
            }
        }

        return indexMax;
    }
    // create and use method FindMinAboveDiagonalIndex(matrix);
    public int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int min = int.MaxValue;
        int indexMin = -1;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    indexMin = j;
                }
            }
        }

        return indexMin;
    }
    // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

    public void RemoveColumns(ref int[,] matrix, FindIndex max, FindIndex min)
    {
        int indexMax = max(matrix);
        int indexMin = min(matrix);
        if (indexMax == indexMin) RemoveColumn(ref matrix, indexMax);
        else
        {
            RemoveColumn(ref matrix, indexMax);
            RemoveColumn(ref matrix, indexMin);
        }
    }
    // use RemoveColumn(matrix, columnIndex) from Task_2_10

    // end


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
        GetNegativeArray arrayRows = GetNegativeCountPerRow;
        GetNegativeArray arrayCols = GetMaxNegativePerColumn;
        FindNegatives(matrix, arrayRows, arrayCols, out rows, out cols);
    }
    // create and use public delegate GetNegativeArray(matrix);
    public delegate int GetNegativeArray(int[,] matrix, int index);
    // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
    public void FindNegatives(int[,] matrix, GetNegativeArray rowSearcher, GetNegativeArray colSearcher, out int[] rows, out int[] cols)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        rows = new int[n];
        cols = new int[m];
        for (int i = 0; i < n; i++)
        {
            rows[i] = rowSearcher(matrix, i);
        }
        for (int j = 0; j < m; j++)
        {
            cols[j] = colSearcher(matrix, j);
        }
    }
    // use GetMaxNegativePerColumn(matrix) from Task_2_22
    public int GetMaxNegativePerColumn(int[,] matrix, int column)
    {
        int n = matrix.GetLength(0);
        int max = Int32.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, column] < 0 && matrix[i, column] > max)
            {
                max = matrix[i, column];
            }
        }
        return max;
    }
    // use GetNegativeCountPerRow(matrix) from Task_2_22
    public int GetNegativeCountPerRow(int[,] matrix, int row)
    {
        int m = matrix.GetLength(1);
        int k = 0;
        for (int j = 0; j < m; j++)
        {
            if (matrix[row, j] < 0)
            {
                k++;
            }
        }
        return k;
    }
    // end


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
        IsSequence up = FindIncreasingSequence;
        IsSequence down = FindDecreasingSequence;
        answerFirst = DefineSequence(first, up, down);
        answerSecond = DefineSequence(second, up, down);
    }
    // create public delegate IsSequence(array, left, right);
    public delegate bool IsSequence(int[] array, int left, int right);
    // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
    public bool FindIncreasingSequence(int[] array, int A, int B)
    {
        bool f = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1])
            {
                f = false;
                break;
            }
        }
        return f;
    }
    // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
    public bool FindDecreasingSequence(int[] array, int A, int B)
    {
        bool f = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1])
            {
                f = false;
                break;
            }
        }
        return f;
    }
    // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);
    public int DefineSequence(int[] array, IsSequence up, IsSequence down)
    {
        int answer = -2;
        if (up(array, 0, array.Length - 1)) answer = 1;
        else if (down(array, 0, array.Length - 1)) answer = -1;
        else answer = 0;

        return answer;
    }
    // end


    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence up = FindIncreasingSequence;
        IsSequence down = FindDecreasingSequence;
        answerFirstIncrease = FindLongestSequence(first, up);
        answerFirstDecrease = FindLongestSequence(first, down);
        answerSecondIncrease = FindLongestSequence(second, up);
        answerSecondDecrease = FindLongestSequence(second, down);
        // end
    }
    // create and use method FindLongestSequence(array, sequence);
    public int[] FindLongestSequence(int[] array, IsSequence sequence)
    {
        int max = -1;
        int[] answer = new int[2];
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (sequence(array, i, j))
                {
                    if (j - i > max)
                    {
                        max = j - i;
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }
        }
        return answer;
    }
    // create public delegate IsSequence(array, left, right);
    // use method FindIncreasingSequence(array, A, B); from Task_3_28a
    // use method FindDecreasingSequence(array, A, B); from Task_3_28a

    // end

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
