using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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

        // create and use Combinations(n, k);
        // create and use Factorial(n);
        answer = Combinations(n, k);
        // end

        return answer;
    }
   public int Combinations(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }
    public int Factorial(int n)
    {
        if (n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        double a1= first[0], b1=first[1], c1=first[2];
        double a2 = second[0], b2=second[1], c2=second[2];
        // create and use GeronArea(a, b, c);
        if (GeronArea(a1, b1, c1) > GeronArea(a2, b2, c2))
            answer = 1;
        else if (GeronArea(a1, b1, c1) == GeronArea(a2, b2, c2))
            answer = 0;
        else
            answer = 2;
        if (!(a1 < b1 + c1 && b1 < a1 + c1 && c1 < a1 + b1) || !(a2 < b2 + c2 && b2 < a2 + c2 && c2 < a2 + b2))
            answer = -1;
        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }
    public double GeronArea(double a, double b, double c)
    {
        double s = 0, p=(a+b+c)/2;
        s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        return s;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time))
            answer = 1;
        else if (GetDistance(v1, a1, time) == GetDistance(v2, a2, time))
            answer = 0;
        else
            answer = 2;
        // end

            // first = 1, second = 2, equal = 0
        return answer;
    }
    public double GetDistance( double v, double a,  double t)
    {
        double s = 0;
        s = v * t + a * t * t / 2;
        return s;
    }
    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        
        // use GetDistance(v, a, t); t - hours
        answer = 1;
        while  (GetDistance(v1, a1, answer) > GetDistance(v2, a2, answer))
        {
            answer++;
        }
        // end

        return answer;
    }
   
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here
        int ai, aj, bi, bj;
        FindMaxIndex(A, out ai, out aj);
        FindMaxIndex(B, out bi, out bj);
        // create and use FindMaxIndex(matrix, out row, out column);
        int t = A[ai,aj];
        A[ai, aj] = B[bi, bj];
        B[bi, bj] = t;
        // end
    }
    public void FindMaxIndex (int [,] matrix,  out int row ,out int column)
    {
        int max = -1000000;
        row=column=0;
        for ( int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max=matrix[i, j];
                    row=i;
                    column=j;
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
        int[,] b = new int[B.GetLength(0) - 1, B.GetLength(1)];
        int[,] c = new int[C.GetLength(0) - 1, C.GetLength(1)];
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i < FindDiagonalMaxIndex(B))
                    b[i, j] = B[i, j];
                else
                    b[i, j] = B[i + 1, j];
            }
        }
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (i < FindDiagonalMaxIndex(C))
                    c[i, j] = C[i, j];
                else
                    c[i, j] = C[i + 1, j];
            }
        }
        B = b;
        C = c;
        // end
    }
    public int FindDiagonalMaxIndex( int [,] matrix)
    {
        int max = -100000, ind =0;
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            if (matrix[i,i] > max)
            {
                max=matrix[i,i];
                ind = i;
            }
        }
        return ind;
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
        int aind=0, bind=0;
        FindMaxInColumn(A,0, out aind);
        FindMaxInColumn(B,0, out bind);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int t = A[aind,j];
            A[aind,j] = B[bind,j];
            B[bind,j] = t;
        }
        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }
    public int FindMaxInColumn( int [,] matrix, int columnIndex, out  int rowIndex)
    {
        rowIndex = 0;
        int max = -10000000;
        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i,columnIndex] > max)
            {
                max=matrix[i,columnIndex];
                rowIndex = i;
            }
        }
        return rowIndex;
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
        int ii = 0, jj = 0, bmax = -100000000, cmax = -100000000;
        int[,] b = new int[5, 5];
        for ( int i = 0;i< 4; i++)
        {
            if (bmax < CountRowPositive(B, i))
            {
                bmax= CountRowPositive(B, i);
                ii= i;
            }
        }
        for ( int j=0; j<6; j++)
        {
            if (cmax< CountColumnPositive(C, j))
            {
                cmax= CountColumnPositive(C, j);
                jj = j;
            }
        }
        for ( int i = 0;i<5l; i++)
        {
            for ( int j = 0; j < 5; j++)
            {
                if (i<= ii)
                {
                    b[i,j]= B[i,j];
                }
                else if (i == ii + 1)
                {
                    b[i, j] = C[j, jj];
                }
                else
                {
                    b[i, j] = B[i - 1, j];
                }
            }
        }
        B = b;
        // end
    }
    public int CountRowPositive(int [,]matrix, int rowIndex)
    {
        int k=0;
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, j] > 0)
            {
                k++;
            }
        }
        return k;
    }
    public int CountColumnPositive(int [,] matrix, int colIndex)
    {
        int k=0;
        for (int i=0; i< matrix.GetLength(0); i++)
        {
            if (matrix[i,colIndex] > 0)
            {
                k++;
            }
        }
        return k;
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
        answer = new int[A.GetLength(1)+ C.GetLength(1)];
        // create and use SumPositiveElementsInColumns(matrix);
        int[] a1 = SumPositiveElementsInColumns(A);
        int[] a2 = SumPositiveElementsInColumns(C);

        for (int i = 0; i < a1.Length; i++)
            answer[i] = a1[i];
        for (int i = 0; i < a2.Length; i++)
            answer[i + a1.Length] = a2[i];
        // end

        return answer;
    }
    public int [] SumPositiveElementsInColumns(int[,] matrix)
    {
        int[] a = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int s = 0;
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                if (matrix[i, j] > 0)
                {
                    s += matrix[i, j];
                }
            }
            a[j]= s;
        }
        return a;
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
        FindMaxIndex(A, out ai, out aj);
        FindMaxIndex(B, out bi, out bj);
        int t = A[ai, aj];
        A[ai, aj] = B[bi, bj];
        B[bi,bj] = t;
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
        int max = -1000000000, maxi = 0, min = 1000000000, mini = 0;
        for ( int i=0; i < matrix.GetLength(0); i++)
        {
            for ( int j=0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max= matrix[i, j];
                    maxi = i;
                }
                if (matrix[i, j] < min)
                {
                    min= matrix[i, j];
                    mini = i;
                }
            }
        }
        RemoveRow(ref matrix, maxi);
        if (mini != maxi)
        {
            if (mini > maxi)
            {
                RemoveRow(ref matrix, mini - 1);
            }
            else
            {
                RemoveRow(ref matrix, mini);
            }
        }
        // end
    }
    public void RemoveRow( ref int [,] matrix, int rowIndex)
    {
        int[,] a = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i < rowIndex)
                {
                    a[i, j] = matrix[i, j];
                }
                else
                {
                    a[i, j] = matrix[i + 1, j];
                }
            }
        }

        matrix = a;
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
        int[] a = { GetAverageWithoutMinMax(A), GetAverageWithoutMinMax(B), GetAverageWithoutMinMax(C) };
        // create
        //and use GetAverageWithoutMinMax(matrix);
        if (a[0] < a[1] && a[1] < a[2])
            answer = 1;
        else if (a[0] > a[1] && a[1] > a[2])
            answer = -1;
        else
            answer = 0;
        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }
    public int GetAverageWithoutMinMax(int [,] matrix)
    {
        int maxi = 0, maxj = 0, mini = 0, minj = 0, max = -1000000, min = 100000;
        for ( int i=0; i<matrix.GetLength(0); i++)
        {
            for ( int j=0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] > max)
                {
                    max=matrix[i,j];
                    maxi = i;
                    maxj = j;
                }
                if (matrix[i,j] < min)
                {
                    min=matrix[i,j];
                    mini = i;
                    minj = j;
                }
            }
        }
        int k = 0,sr=0;
        for ( int i=0;i<matrix.GetLength(0); i++)
        {
            for ( int j=0; j<matrix.GetLength(1); j++)
            {
                if ((i!=maxi && j!=maxj)&&(i!=mini && j != minj))
                {
                    sr += matrix[i, j];
                    k++;
                }
            }
        }
        if (sr!=0)
            sr = sr / k;
        return sr;

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
        SortRowsByMaxElement(A);
        SortRowsByMaxElement(B);
        // create and use SortRowsByMaxElement(matrix);

        // end
    }
    public void SortRowsByMaxElement (int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] max = new int[n];
        for (int i = 0; i < n; i++)
        {
            max[i] = matrix[i, 0];
            for (int j = 1; j < m; j++) 
            {
                if (matrix[i, j] > max[i])
                {
                    max[i] = matrix[i, j];
                }
            }
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (max[i] < max[j])
                {
                    int tempMax = max[i];
                    max[i] = max[j];
                    max[j] = tempMax;
                    for (int k = 0; k < m; k++)
                    {
                        int tempVal = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = tempVal;
                    }
                }
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
        // use RemoveRow(matrix, rowIndex); from 2_13
        int k = 0;
        for (int i = matrix.GetLength(0)-1; i >=0; i--)
        {
            for (int j = matrix.GetLength(1)-1; j >=0; j--)
            {
                if (matrix[i, j] == 0)
                {
                    RemoveRow(ref matrix, i - k);
                    break;
                }
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

        // create and use CreateArrayFromMins(matrix);
        answerA = CreateArrayFromMins(A);
        answerB= CreateArrayFromMins(B);
        // end
    }
    public int [] CreateArrayFromMins( int [,] matrix)
    {
        int[] array=new int[matrix.GetLength(0)];
        for ( int i=0; i<matrix.GetLength(0); i++)
        {
            int min = 1000000;
            for ( int j = i; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            array[i] = min;
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

        double[] t = new double[matrix.GetLength(0) * matrix.GetLength(1)];
        int ind = 0;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                t[ind++] = matrix[i, j];
            }
        }
        for (int i = 0; i < t.Length - 1; i++)
        {
            for (int j = 0; j < t.Length - i - 1; j++)
            {
                if (t[j] < t[j + 1])
                {
                    double p = t[j];
                    t[j] = t[j + 1];
                    t[j + 1] = p;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool flag = false;


                for (int k = 0; k < 5; k++)
                {
                    if (matrix[i, j] == t[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    matrix[i, j] *= (matrix[i, j] > 0) ? 2 : 0.5;
                }
                else
                {
                    matrix[i, j] *= (matrix[i, j] > 0) ? 0.5 : 2;
                }
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
        maxA = FindRowWithMaxNegatives(A);
        maxB = FindRowWithMaxNegatives(B);
        // end
    }
    public int CountNegativeElementsInRow(int[,] matrix, int row)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] < 0)
            {
                count++;
            }
        }
        return count;
    }

    
    public int FindRowWithMaxNegatives(int[,] matrix)
    {
        int maxNegatives = -1;
        int rowIndex = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int negativeCount = CountNegativeElementsInRow(matrix, i);
            if (negativeCount > maxNegatives)
            {
                maxNegatives = negativeCount;
                rowIndex = i;
            }
        }

        return rowIndex;
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
        int[] maxIndexA = FindRowMaxIndex(A);
        int[] maxIndexB = FindRowMaxIndex(B);

        for (int i = 0; i < maxIndexA.Length; i++)
        {
            if (i % 2 == 0) ReplaceMaxElementOdd(A, i, maxIndexA[i]);
            else ReplaceMaxElementEven(A, i, maxIndexA[i]);
        }
        for (int i = 0; i < maxIndexB.Length; i++)
        {
            if (i % 2 == 0) ReplaceMaxElementOdd(B, i, maxIndexB[i]);
            else ReplaceMaxElementEven(B, i, maxIndexB[i]);
        }
        // end
    }
    public int[] FindRowMaxIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] answer = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > matrix[i, answer[i]]) answer[i] = j;
            }
        }
        return answer;
    }

    public void ReplaceMaxElementOdd(int[,] matrix, int row, int column)
    {
        matrix[row, column] *= (column + 1);
    }
    public void ReplaceMaxElementEven(int[,] matrix, int row, int column)
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

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x
        double a1 = 0.1, b1 = 1, h1 = 0.1;
        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;
        firstSumAndY = GetSumAndY(FirstSum, FirstY, a1, b1, h1);
        secondSumAndY = GetSumAndY(SecondSum, SecondY, a2, b2, h2);
        // end
    }
    public delegate double SumFunction(double x);
    public delegate double YFunction(double x);
    public double[,] GetSumAndY(SumFunction sFunction, YFunction yFunction, double a, double b, double h)
    {
        double[,] A = new double[(int)((b - a) / h) + 1, 2];
        int ind = 0;
        for (double x = a; x <= b + h / 10; x += h)
        {
            double sum = sFunction(x);
            double y = yFunction(x);
            A[ind, 0] = sum;
            A[ind, 1] = y;
            ind++;
        }
        return A;
    }
    public double FirstSum(double x)
    {
        double s = 1;
        int i = 1;
        double l;
        while (true)
        {
            l = Math.Cos(i * x) / (double)Factorial(i);
            if (Math.Abs(l) <= 0.0001)
            {
                break;
            }
            s += l;
            i++;
        }
        return s;
    }

    public double FirstY(double x)
    {
        return Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
    }

    public double SecondSum(double x)
    {
        double s = 0;
        int i = 1;
        double l;
        while (true)
        {
            l = Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
            if (Math.Abs(l) <= 0.0001)
            {
                break;
            }
            s += l;
            i++;
        }
        return s;
    }
    public double SecondY(double x)
    {
        return (x * x - Math.PI * Math.PI / 3) / 4;
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
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)
        double s = 0;
        int n = array.Length;
        SwapDirection swapper;

        for (int i = 0; i < n; i++)
        {
            s += array[i];
        }
        double average = s / n;

        if (array[0] > average) swapper = SwapRight;
        else swapper = SwapLeft;
        swapper(array);
        answer = GetSum(array);
        // end

        return answer;
    }
    public delegate void SwapDirection(double[] array);
    static void SwapRight(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i += 2)
        {
            double t = array[i];
            array[i] = array[i + 1];
            array[i + 1] = t;
        }
    }
    static void SwapLeft(double[] array)
    {
        for (int i = array.Length - 1; i > 0; i -= 2)
        {
            double t = array[i];
            array[i] = array[i - 1];
            array[i - 1] = t;
        }
    }
    static double GetSum(double[] array)
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

        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions
        double a1 = 0, b1 = 2, h1 = 0.1;
        func1 = CountSignFlips(y1, a1, b1, h1);
        double a2 = -1, b2 = 1, h2 = 0.2;
        func2 = CountSignFlips(y2, a2, b2, h2);

        // end
    }
    public int CountSignFlips(YFunction yFunction, double a, double b, double h)
    {
        int cnt = 0;
        double prev = yFunction(a);
        for (double x = a + h; x <= b; x += h)
        {
            double cur = yFunction(x);
            if ((prev > 0 && cur < 0) || (prev < 0 && cur > 0) || (x == b))
                cnt++;
            prev = cur;
        }

        return cnt;
    }

    public double y1(double x)
    {
        return x * x - Math.Sin(x);
    }

    public double y2(double x)
    {
        return Math.Exp(x) - 1;
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

    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);
        B = InsertColumn(B, CountRowPositive, C, CountColumnPositive);
        // end
    }
    public delegate int CountPositive(int[,] matrix, int index);

    public static int[,] InsertColumn(int[,] matrixB, CountPositive CountRow, int[,] matrixC, CountPositive CountColumn)
    {
        int c1 = 0, c2 = 0;
        int mi = 0, mj = 0;
        int mv = -1, mvc = -1;
        for (int i = 0; i < matrixB.GetLength(0); i++)
        {
            c1 = CountRow(matrixB, i);
            c2 = CountColumn(matrixC, i);
            if (c1 > mv)
            {
                mv = c1;
                mi = i;
            }
            if (c2 > mvc)
            {
                mvc = c2;
                mj = i;
            }
        }
        int[,] b = new int[matrixB.GetLength(0) + 1, matrixB.GetLength(1)];
        for (int i = 0; i < matrixB.GetLength(1); ++i)
        {
            b[mi + 1, i] = matrixC[i, mj];
        }
        for (int i = 0; i <= mi; ++i)
        {
            for (int j = 0; j < b.GetLength(1); ++j)
            {
                b[i, j] = matrixB[i, j];
            }
        }
        for (int i = mi + 2; i < b.GetLength(0); ++i)
        {
            for (int j = 0; j < b.GetLength(1); ++j)
            {
                b[i, j] = matrixB[i - 1, j];
            }
        }
        return b;
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
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)
        RemoveRows(ref matrix, FindMaxIndex, FindMinIndex);
        // end
    }
    public void FindMinIndex(int[,] matrix, out int indi, out int indj)
    {
        int min = matrix[0, 0];
        indi = 0;
        indj = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    indi = i;
                    indj = j;
                }
            }
        }
    }

    public delegate void FindElementDelegate(int[,] matrix, out int indexI, out int indexJ);

    public void RemoveRows(ref int[,] matrix, FindElementDelegate findMax, FindElementDelegate findMin)
    {
        int maxI, maxJ, minI, minJ;
        findMax(matrix, out maxI, out maxJ);
        findMin(matrix, out minI, out minJ);

        if (minI < maxI)
        {
            RemoveRow(ref matrix, maxI);
            RemoveRow(ref matrix, minI);
        }
        else if (minI > maxI)
        {
            RemoveRow(ref matrix, minI);
            RemoveRow(ref matrix, maxI);
        }
        else
        {
            RemoveRow(ref matrix, minI);
        }
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

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);
        EvenOddRowsTransform(A, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        EvenOddRowsTransform(B, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        // end
    }
    public delegate void ReplaceMaxElement(int[,] matrix, int row, int column);

    public void EvenOddRowsTransform(int[,] matrix, ReplaceMaxElement replaceMaxElementOdd, ReplaceMaxElement replaceMaxElementEven)
    {
        int[] maxIndexA = FindRowMaxIndex(matrix);

        for (int i = 0; i < maxIndexA.Length; i++)
        {
            if (i % 2 == 0) replaceMaxElementOdd(matrix, i, maxIndexA[i]);
            else replaceMaxElementEven(matrix, i, maxIndexA[i]);
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
