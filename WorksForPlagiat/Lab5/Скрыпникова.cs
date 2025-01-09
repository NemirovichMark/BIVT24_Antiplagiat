using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
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
        if (k <= 0 || k > 0 && k == n) answer = 1;
        else if (k > 0 && k < n)
            answer = Combinations(n, k);
        else answer = 0;

        // create and use Combinations(n, k);
        static int Combinations(int n, int k)
        {
            int c = 0;
            c = Factorial(n) / (Factorial(k) * Factorial(n - k));
            return c;
        }
        // create and use Factorial(n);
        static int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

        // end

        return answer;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;
        // create and use GeronArea(a, b, c);
        static double GeronArea(double a, double b, double c)
        {
            double s = 0;
            double p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        // code here
        double a = first[0], b = first[1], c = first[2];
        double a1 = second[0], b1 = second[1], c1 = second[2];

        if (a + b <= c || a + c <= b || c + b <= a) return -1;
        if (a1 + b1 <= c1 || a1 + c1 <= b1 || c1 + b1 <= a1) return -1;

        if (GeronArea(a, b, c) == GeronArea(a1, b1, c1)) return 0;
        else if (GeronArea(a, b, c) > GeronArea(a1, b1, c1)) return 1;
        else if (GeronArea(a, b, c) < GeronArea(a1, b1, c1)) return 2;

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }

    public double GetDistance(double v, double a, double t)
    {
        double s = 0;
        s = v * t + (a * t * t) / 2;
        return s;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        if (time <= 0 || v1 <= 0 || v2 <= 0) return 0;
        else if (GetDistance(v1, a1, time) == GetDistance(v2, a2, time)) return 0;
        else if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time)) return 1;
        else if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time)) return 2;
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        int t;
        for (t = 1; ; t++)
        {
            if (GetDistance(v1, a1, t) <= GetDistance(v2, a2, t))
            {
                return t;
            }
        }
        answer = t;

        // end

        return answer;
    }
    #endregion

    #region Level 2

    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here
        // create and use FindMaxIndex(matrix, out row, out column);
        FindMax(A, out int iA, out int jA);
        FindMax(B, out int iB, out int jB);
        int temp = A[iA, jA];
        A[iA, jA] = B[iB, jB];
        B[iB, jB] = temp;

        // end
    }
    public void FindMax(int[,] matrix, out int row, out int column)
    {
        row = 0;
        column = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[row, column])
                {
                    row = i;
                    column = j;
                }
            }
        }
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
        int strB = B.GetLength(0);
        int stoB = B.GetLength(1);
        int strC = C.GetLength(0);
        int stoC = C.GetLength(1);
        int maxB = FindDiagonalMax(B);
        int maxC = FindDiagonalMax(C);
        int[,] newB = new int[strB - 1, stoB];
        int[,] newC = new int[strC - 1, stoC];
        for (int i = 0; i < strB - 1; i++)
        {
            for (int j = 0; j < stoB; j++)
            {
                if (i < maxB)
                {
                    newB[i, j] = B[i, j];
                }
                else newB[i, j] = B[i + 1, j];
            }

        }
        for (int i = 0; i < strC - 1; i++)
        {
            for (int j = 0; j < stoC; j++)
            {
                if (i < maxC)
                {
                    newC[i, j] = C[i, j];
                }
                else newC[i, j] = C[i + 1, j];
            }
        }

        B = newB;
        C = newC;
        // end
    }
    public int FindDiagonalMax(int[,] matrix)
    {
        int imax = 0;
        int Max = matrix[0, 0];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > matrix[imax, imax])
            {
                imax = i;
                Max = matrix[i, i];
            }
        }

        return imax;
    }
    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        // end
    }


    // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here
        int strA = A.GetLength(0);
        int stoA = A.GetLength(1);
        int strB = B.GetLength(0);
        int stoB = B.GetLength(1);
        int maxA = FindMaxInColumn(A, 0);
        int maxB = FindMaxInColumn(B, 0);
        for (int j = 0; j < stoA; j++)
        {
            int temp = A[maxA, j];
            A[maxA, j] = B[maxB, j];
            B[maxB, j] = temp;
        }

        // end
    }
    public int FindMaxInColumn(int[,] matrix, int columnIndex)
    {
        int imax = 0;
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, columnIndex] > matrix[imax, columnIndex])
            {
                imax = i;
            }
        }
        return imax;
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
        int strB = B.GetLength(0);
        int stoB = B.GetLength(1);
        int strC = C.GetLength(0);
        int stoC = C.GetLength(1);

        int[,] newB = new int[strB + 1, stoB];
        int iB = 0, jC = 0;
        int MaxB = 0, MaxC = 0;
        for (int i = 0; i < strB; i++)
        {
            int k = CountRowPositive(B, i);
            if (k > MaxB)
            {
                MaxB = k;
                iB = i;
            }
        }
        for (int j = 0; j < stoC; j++)
        {
            int k = CountColumnPositive(C, j);
            if (k > MaxC)
            {
                MaxC = k;
                jC = j;
            }
        }
        for (int i = 0; i < strB; i++)
        {
            if (i <= iB)
                for (int j = 0; j < stoB; j++)
                {
                    newB[i, j] = B[i, j];
                }
            else
            {
                for (int j = 0; j < stoB; j++)
                {
                    newB[i + 1, j] = B[i, j];
                }
            }
        }
        for (int j = 0; j < stoB; j++)
        {
            newB[iB + 1, j] = C[j, jC];
        }
        B = newB;

        // end
    }

    public int CountRowPositive(int[,] matrix, int rowIndex)
    {
        int count = 0;
        int sto = matrix.GetLength(1);

        for (int i = 0; i < sto; i++)
        {
            if (matrix[rowIndex, i] > 0)
            {
                count++;
            }
        }
        return count;
    }
    public int CountColumnPositive(int[,] matrix, int colIndex)
    {
        int count = 0;
        int str = matrix.GetLength(0);

        for (int i = 0; i < str; i++)
        {
            if (matrix[i, colIndex] > 0)
            {
                count++;
            }
        }
        return count;
    }
    // end


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
        int strA = A.GetLength(0), stoA = A.GetLength(1);
        int strC = C.GetLength(0), stoC = C.GetLength(1);

        int[] newA = new int[stoA];
        int[] newC = new int[stoC];
        newA = SumPositiveElementsInColumns(A);
        newC = SumPositiveElementsInColumns(C);
        answer = new int[stoA + stoC];
        for (int i = 0; i < stoA; i++)
        {
            answer[i] = newA[i];
        }
        for (int i = stoA; i < stoA + stoC; i++)
        {
            answer[i] = newC[i - stoA];
        }

        return answer;
    }
    public int[] SumPositiveElementsInColumns(int[,] matrix)
    {
        int str = matrix.GetLength(0), sto = matrix.GetLength(1);
        int[] answer = new int[sto];
        for (int j = 0; j < sto; j++)
        {
            for (int i = 0; i < str; i++)
            {
                if (matrix[i, j] > 0)
                {
                    answer[j] += matrix[i, j];
                }
            }
        }
        return answer;
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
        FindMax(A, out int iA, out int jA);
        FindMax(B, out int iB, out int jB);
        int temp = A[iA, jA];
        A[iA, jA] = B[iB, jB];
        B[iB, jB] = temp;
        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

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
        FindMin(matrix, out int iMin, out int jMin);
        FindMax(matrix, out int iMax, out int jMax);
        if (iMin > iMax)
        {
            RemoveRow(ref matrix, iMin);
            RemoveRow(ref matrix, iMax);
        }
        else if (iMin < iMax)
        {
            RemoveRow(ref matrix, iMax);
            RemoveRow(ref matrix, iMin);
        }
        else RemoveRow(ref matrix, iMin);
        // end
    }
    public void FindMin(int[,] matrix, out int row, out int column)
    {
        row = 0;
        column = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < matrix[row, column])
                {
                    row = i;
                    column = j;
                }
            }
        }
    }
    public void RemoveRow(ref int[,] matrix, int rowIndex)
    {

        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        int[,] newA = new int[str - 1, sto];
        for (int i = 0; i < str - 1; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                if (i < rowIndex)
                {
                    newA[i, j] = matrix[i, j];
                }
                else
                {
                    newA[i, j] = matrix[i + 1, j];
                }
            }
        }
        matrix = newA;
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
        double[] ans = new double[3];
        ans[0] = GetAverageWithoutMinMax(A);
        ans[1] = GetAverageWithoutMinMax(B);
        ans[2] = GetAverageWithoutMinMax(C);
        if (ans[0] > ans[1] && ans[1] > ans[2]) return -1;
        else if (ans[0] < ans[1] && ans[1] < ans[2]) return 1;
        else return 0;

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
    }
    public double GetAverageWithoutMinMax(int[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0) return 0;
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        int sum = 0;
        int max = -100000, min = 100000;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                sum += matrix[i, j];
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        int k = str * sto;
        sum = (sum - min - max) / (k - 2);
        return sum;
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
        SortRowsByMaxElement(A);
        SortRowsByMaxElement(B);

        // end
    }
    public void SortRowsByMaxElement(int[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0) return;
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        int[] Max = new int[str];
        for (int i = 0; i < str; i++)
        {
            Max[i] = matrix[i, 0];
            for (int j = 0; j < sto; j++)
            {
                if (matrix[i, j] > Max[i])
                {
                    Max[i] = matrix[i, j];
                }
            }
        }
        for (int i = 1, k = 2; i < str;)
        {
            if (i == 0 || Max[i] <= Max[i - 1])
            {
                i = k;
                k++;
            }
            else
            {
                int temp = Max[i];
                Max[i] = Max[i - 1];
                Max[i - 1] = temp;

                for (int j = 0; j < sto; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i - 1, j];
                    matrix[i - 1, j] = temp;
                }
                i--;
            }
        }
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
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        for (int i = str - 1; i >= 0; i--)
            for (int j = sto - 1; j >= 0; j--)
                if (matrix[i, j] == 0)
                {
                    RemoveRow(ref matrix, i);
                    break;
                }
        // use RemoveRow(matrix, rowIndex); from 2_13

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
        answerA = CreateArrayFromMins(A);
        answerB = CreateArrayFromMins(B);
        // create and use CreateArrayFromMins(matrix);

        // end
    }
    int[] CreateArrayFromMins(int[,] matrix)
    {
        int str = matrix.GetLength(0);
        var newmtr = new int[str];
        for (int i = 0; i < str; i++)
        {
            int min = matrix[i, i];
            for (int j = i + 1; j < str; j++)
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            newmtr[i] = min;
        }
        return newmtr;
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

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here
        // create and use MatrixValuesChange(matrix);

        MatrixValuesChange(A);
        MatrixValuesChange(B);

        // end
    }
    public void MatrixValuesChange(double[,] matrix)
    {
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        double[] val = new double[str * sto];
        int[] irow = new int[str * sto];
        int[] icol = new int[str * sto];

        int ind = 0;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < sto; j++)
            {
                val[ind] = matrix[i, j];
                irow[ind] = i;
                icol[ind] = j;
                ind++;
            }
        }
        for (int i = 0; i < str * sto; i++)
        {
            for (int j = 0; j < str * sto - i - 1; j++)
            {
                if (val[j] < val[j + 1])
                {
                    double temp1 = val[j];
                    val[j] = val[j + 1];
                    val[j + 1] = temp1;

                    int temp2 = irow[j];
                    irow[j] = irow[j + 1];
                    irow[j + 1] = temp2;

                    int temp3 = icol[j];
                    icol[j] = icol[j + 1];
                    icol[j + 1] = temp3;
                }
            }
        }
        for (int i = 0; i < str * sto; i++)
        {
            if (i < 5 && matrix[irow[i], icol[i]] > 0)
            {
                matrix[irow[i], icol[i]] *= 2;
            }
            else if (i < 5 && matrix[irow[i], icol[i]] < 0)
            {
                matrix[irow[i], icol[i]] /= 2;
            }
            else if (i >= 5 && matrix[irow[i], icol[i]] > 0)
            {
                matrix[irow[i], icol[i]] /= 2;
            }
            else
            {
                matrix[irow[i], icol[i]] *= 2;
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
        // create and use FindMaxNegativeRow(int);
        // use GetNegativeCountPerRow(matrix); from 2_22
        maxA = FindRowWithMaxNegativeCount(A);
        maxB = FindRowWithMaxNegativeCount(B);
        // end
    }
    public int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int count = 0;
        int sto = matrix.GetLength(1);
        for (int j = 0; j < sto; j++)
        {
            if (matrix[rowIndex, j] < 0)
            {
                count++;
            }
        }
        return count;
    }
    public int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int maxCount = 0;
        int str = matrix.GetLength(0);
        int maxRowIndex = 0;
        for (int i = 0; i < str; i++)
        {
            int CountNeg = CountNegativeInRow(matrix, i);
            if (CountNeg > maxCount)
            {
                maxCount = CountNeg;
                maxRowIndex = i;
            }
        }
        return maxRowIndex;
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
        Replace(A);
        Replace(B);

        // end
    }
    public bool FindRowMaxIndex(int[,] matrix, int rowIndex, out int columnIndex)
    {
        int max = -100000;
        int sto = matrix.GetLength(1);
        columnIndex = -1;
        bool prosto = false;
        for (int j = 0; j < sto; j++)
        {
            if (matrix[rowIndex, j] > max)
            {
                max = matrix[rowIndex, j];
                columnIndex = j;
                prosto = true;
            }
        }
        return prosto;
    }
    public void Replace(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int columnIndex;
            if (FindRowMaxIndex(matrix, i, out columnIndex))
            {
                if ((i + 1) % 2 == 0)
                {
                    ReplaceMaxElementEven(matrix, i, columnIndex);
                }
                else
                {
                    ReplaceMaxElementOdd(matrix, i, columnIndex);
                }
            }

        }
    }
    static void ReplaceMaxElementOdd(int[,] matrix, int row, int column)
    {
        matrix[row, column] *= (column + 1);
    }
    static void ReplaceMaxElementEven(int[,] matrix, int row, int column)
    {
        matrix[row, column] = 0;
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
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here
        double a1 = 0.1, b1 = 1, h1 = 0.1;
        firstSumAndY = new double[(int)((b1 - a1) / h1) + 1, 2];
        GetSumAndY(s1, y1, a1, b1, h1, firstSumAndY, 0);


        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;
        secondSumAndY = new double[(int)((b2 - a2) / h2) + 1, 2];
        GetSumAndY(s2, y2, a2, b2, h2, secondSumAndY, 1);

        //1 create and use public delegate SumFunction(x) and public delegate YFunction(x)
        //2 create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        //3 create and use 2 methods for both functions calculating at specific x

        // end
    }
    //1 create and use public delegate SumFunction(x) and public delegate YFunction(x)
    public delegate double SumFunction(int i, double x, ref int change);
    public delegate double YFunction(double x);

    //2 create and use method GetSumAndY(sFunction, yFunction, a, b, h);
    public void GetSumAndY(SumFunction sFunction, YFunction yFunction, double a, double b, double h, double[,] sumAndY, int firstI = 0)
    {
        for (int i = 0; i < (b - a) / h + 1; i++)
        {
            double x = a + i * h, y = yFunction(x);
            double sum = Sum(sFunction, x, firstI);

            sumAndY[i, 0] = sum;
            sumAndY[i, 1] = y;
        }
    }
    //3 create and use 2 methods for both functions calculating at specific x
    public double s1(int i, double x, ref int factorial)
    {
        if (i > 0)
        {
            factorial *= i;
        }
        return Math.Cos(i * x) / factorial;
    }
    public double s2(int i, double x, ref int sign)
    {
        sign *= -1;
        return sign * Math.Cos(i * x) / (i * i);
    }
    public double y1(double x)
    {
        return Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
    }
    public double y2(double x)
    {
        return ((x * x) - Math.PI * Math.PI / 3) / 4;
    }
    public double Sum(SumFunction sumFunction, double x, int i)
    {
        int sign = 1;
        double num = sumFunction(i, x, ref sign);
        double sum = 0;
        while (Math.Abs(num) > 0.0001)
        {
            sum += num;
            i++;
            num = sumFunction(i, x, ref sign);
        }
        return sum;
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

    public double Task_3_3(double[] array)
    {
        double answer = 0;
        SwapDirection swapper = default(SwapDirection); //- uncomment me

        // code here
        double s = 0;
        if (array != null && array.Length > 0)
        {
            double sum = 0;
            foreach (double num in array) sum += num;
            s = sum / array.Length;
        }

        if (array[0] > s) swapper = SwapRight;
        else swapper = SwapLeft;
        swapper(array);
        answer = GetSum(array);

        //1 create and use public delegate SwapDirection(array);
        //2 create and use methods SwapRight(array) and SwapLeft(array)
        //3 create and use method GetSum(array, start, h) that sum elements with a negative indexes
        //4 change method in variable swapper in the if/else and than use swapper(matrix)

        // end
        return answer;
    }
    //1 create and use public delegate SwapDirection(array);
    public delegate void SwapDirection(double[] array);

    //2 create and use methods SwapRight(array) and SwapLeft(array)
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
    //3 create and use method GetSum(array, start, h) that sum elements with a negative indexes
    public double GetSum(double[] array)
    {
        double s = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            s += array[i];
        }
        return s;
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


    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;
        YFunction function1 = GetF1();
        YFunction function2 = GetF2();

        double a1 = 0, b1 = 2, h1 = 0.1;
        double a2 = -1, b2 = 1, h2 = 0.2;

        func1 = CountSignFlips(function1, a1, b1, h1);
        func2 = CountSignFlips(function2, a2, b2, h2);
        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public int CountSignFlips(YFunction function, double a, double b, double h)
    {
        int csf = 0;
        double doY = function(a);
        bool dowasY = false;
        if (doY == 0) dowasY = true;
        for (double x = a + h; x <= b; x += h)
        {
            double curY = function(x);
            if (dowasY)
            {
                if (curY != 0)
                {
                    dowasY = false;
                    doY = curY;
                    continue;
                }
                else
                {
                    doY = curY;
                }
            }
            if (Math.Sign(curY) != Math.Sign(doY) && doY != 0)
            {
                csf++;
            }
            doY = curY;
            dowasY = (curY == 0);
        }
        return csf;
    }
    public YFunction GetF1()
    {
        double func1(double x)
        {
            return x * x - Math.Sin(x);
        }
        return func1;
    }
    private YFunction GetF2()
    {
        double func2(double x)
        {
            return Math.Exp(x) - 1;
        }
        return func2;
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
    public delegate int CountPositive(int[,] matrix, int index);

    public int funct_3_7(int[,] B, CountPositive CP)
    {
        int index = -1;
        int max = int.MinValue;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (CP(B, i) > max)
            {
                max = CP(B, i);
                index = i;
            }
        }
        return index;
    }
    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here
        int maxB = -1; int maxC = -1;
        int iB = -1; int iC = -1;

        int[,] newB = new int[B.GetLength(0) + 1, B.GetLength(1)];

        iB = funct_3_7(B, CountRowPositive);
        iC = funct_3_7(C, CountColumnPositive);

        for (int i = 0; i < newB.GetLength(0); i++)
            for (int j = 0; j < newB.GetLength(1); j++)
            {
                if (i <= iB)
                {
                    newB[i, j] = B[i, j];
                }

                else
                    if (i >= iB + 1)
                {
                    newB[i, j] = B[i - 1, j];
                }
            }
        for (int k = 0; k < newB.GetLength(1); k++)
        {
            newB[iB + 1, k] = C[k, iC];
        }
        B = newB;

    }

    // create and use public delegate CountPositive(matrix, index);
    // use CountRowPositive(matrix, rowIndex) from Task_2_7
    // use CountColumnPositive(matrix, colIndex) from Task_2_7
    // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

    // end

    public void InsertColumn(ref int[,] matrixB, int CountRow, int[,] matrixC, int CountColumn)
    {
        int[,] newB = new int[matrixB.GetLength(0) + 1, matrixB.GetLength(1)];

        for (int i = 0; i < CountRow + 1; i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                newB[i, j] = matrixB[i, j];
            }
        }
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            newB[CountRow + 1, i] = matrixC[i, CountColumn];
        }
        for (int i = CountRow + 1; i < matrixB.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                newB[i + 1, j] = matrixB[i, j];
            }
        }
        matrixB = newB;
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

    public void Task_3_13(ref int[,] matrix)
    { //1 use public delegate FindElementDelegate(matrix) from Task_3_6
        //2 create and use method RemoveRows(matrix, findMax, findMin)


        // code here
        //1 use public delegate FindElementDelegate(matrix) from Task_3_6
        matrix = RemoveRows(matrix, FindMax, FindMin);
        // end
    }
    public delegate void FindElementDelegate(int[,] matrix, out int x, out int y);

    //2 create and use method RemoveRows(matrix, findMax, findMin)
    public int[,] RemoveRows(int[,] matrix, FindElementDelegate findMax, FindElementDelegate findMin)
    {
        findMax(matrix, out int iMax, out int jMax);
        findMin(matrix, out int iMin, out int jMin);
        if (iMin > iMax)
        {
            RemoveRow(ref matrix, iMin);
            RemoveRow(ref matrix, iMax);
        }
        else if (iMin < iMax)
        {
            RemoveRow(ref matrix, iMax);
            RemoveRow(ref matrix, iMin);
        }
        else RemoveRow(ref matrix, iMin);

        return matrix;
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
  
        public void Task_3_27(int[,] A, int[,] B)
    {
        // code here
        EvenOddRowsTransform(A, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        EvenOddRowsTransform(B, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        //1 create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        //2 use ReplaceMaxElementOdd(matrix) from Task_2_27
        //3 use ReplaceMaxElementEven(matrix) from Task_2_27
        //4 create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }
    //1
    public delegate void ReplaceMaxElement(int[,] matrix, int row, int column);
    //4
    public void EvenOddRowsTransform(int[,] matrix, ReplaceMaxElement replaceMaxElementOdd, ReplaceMaxElement replaceMaxElementEven)
    {
        int str = matrix.GetLength(0);
        int sto = matrix.GetLength(1);
        for (int i = 0; i < str; i++)
        {
            int columnIndex;
            FindRowMaxIndex(matrix, i, out columnIndex);
            if (i % 2 == 0)
            {
                ReplaceMaxElementOdd(matrix, i, columnIndex);
            }
            else ReplaceMaxElementEven(matrix, i, columnIndex);
        }
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
