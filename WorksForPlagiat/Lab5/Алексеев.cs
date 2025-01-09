using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
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

    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 0; i < n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    static long Combinations(int n, int k)
    {
        long rezult;
        if (k == 0 || k > 0 && k == n)
        {
            rezult = 1;
        }
        else if (k>0 && k < n)
        {
            long Vn = Factorial(n) ;
            long Vk = Factorial(k) ;
            long Vr = Factorial(n - k);
            rezult = Vn / (Vk / Vr);
        }
        else
        {
            rezult = 0;
        }
        
        return rezult;
    } 


    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        answer = Combinations(n, k);
        // create and use Combinations(n, k);
        // create and use Factorial(n);



        // end

        return answer;
    }

    static double GeronArea(double a, double b,double c)
    {
        double p = (a+b+c)/2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return S;


    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here

        double f1 = first[0], f2 = first[1], f3 = first[2];
        double s1 = second[0], s2 = second[1], s3 = second[2];
        

        if (f1 + f2 <= f3 || f1 + f3 <= f2 || f2 + f3 <= f1 || s1 + s2 <= s3 || s2 + s3 <= s1 || s1 + s3 <= s2)
        {
            return -1;
        }

        if (GeronArea(f1, f2, f3) > GeronArea(s1, s2, s3))
        {
            answer = 1;
        }
        else if (GeronArea(f1, f2, f3) < GeronArea(s1, s2, s3))
        {
            answer = 2;
        }
        else if (GeronArea(f1, f2, f3) == GeronArea(s1, s2, s3))
        {
            answer = 0;
        }


        // create and use GeronArea(a, b, c);

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }





    static double GetDistance(double v, double a, int t)
    {
        double S = v * t + a * Math.Pow(t, 2) / 2;
        return S;
    }



    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        if ( GetDistance(v1, a1, time) > GetDistance(v2,a2,time) )
        {
            answer = 1;
        }
        else if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time))
        {
            answer = 2;
        }
        else
        {
            answer = 0;
        }

        

            
        // create and use GetDistance(v, a, t); t - hours

        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        int t = 1;
        while (true)
        {
            if (GetDistance(v2, a2, t) >= GetDistance(v1, a1, t))
            {
                answer = t;
                break;
            }
            t++;
        } 
        return answer;
           

        
    }
    #endregion
    public static int FindMaxIndex(int[,] matrix, out int row, out int column)
    {
        row = -1;
        column = -1;
        int maxValue = int.MinValue; 

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    row = i;
                    column = j;
                }
            }
        }

        return maxValue; 
    }

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here
        FindMaxIndex(A, out int rowA, out int columnA);
        FindMaxIndex(B, out int rowB, out int columnB);

       
        int temp = A[rowA, columnA];
        A[rowA, columnA] = B[rowB, columnB];
        B[rowB, columnB] = temp;




        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!

        // end
    }

    static int FindDiagonalMaxIndex(int [,]matrix)
    {
        int row = -1, column = -1, max = int.MinValue;
        if (matrix.GetLength(0) == matrix.GetLength(1)) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                    row = i;
                }
            }
        }
        else
        {
            matrix = null;
        }
        return row;
    }
       
    static int[,] copy(int[,] matrix, int row)
    {
        int[,] temp = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp[i, j] = matrix[i, j];
            }
        }
        for (int i = row; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp[i, j] = matrix[i+1 , j];
            }
        }
        return temp;
    } 
    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here
        
        B = copy(B, FindDiagonalMaxIndex(B));       
        C = copy(C, FindDiagonalMaxIndex(C));
        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        // end
    }

    static int FindMaxInColumn(int [,]matrix, int columnIndex)
    {
        columnIndex = -1;
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength (0); i++)
        {
            if (matrix[i,0] > max)
            {
                max = matrix[i,0];
                columnIndex = i;
            }
        }

        return columnIndex;
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here
        int a = FindMaxInColumn(A, 0);
        int b = FindMaxInColumn(B, 0);
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int temp = A[a, i];
            A[a, i] = B[b, i];
            B[b, i] = temp;
        }




        // end

    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);

        // end
    }


    static int CountRowPositive(int [,]matrix)
    {
        int rowIndex = -1;
        int max = int.MinValue;
        for (int i = 0; i <  matrix.GetLength (0); i++)
        {
            int cnt = 0;
            for (int j = 0; j < matrix.GetLength (1); j++)
            {
                if (matrix[i,j] > 0)
                {
                    cnt++;

                }

            }
            if (cnt > max)
            {
                max = cnt;
                rowIndex = i;
            }
        }
        return rowIndex;


    }

    static int CountColumnPositive(int [,]matrix)
    {
        int colIndex = -1;
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int cnt = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j,i] > 0)
                {
                    cnt++;

                }

            }
            if (cnt > max)
            {
                max = cnt;
                colIndex = i;
            }
        }
        return colIndex;
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

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
        for (int i = CountRowPositive(B) + 1; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                A[i + 1, j] = B[i, j];
            }
        }

        B = A;



        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);

        // end
    }

    static int[] SumPositiveElementsInColumns(int [,]matrix)
    {

        int[] rezult = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j,i] > 0)
                {
                    sum += matrix[j,i];
                }
            }
            rezult[i] = sum;
        }
        return rezult;
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
       
        int [] tempA = SumPositiveElementsInColumns(A);
        int[] tempC = SumPositiveElementsInColumns(C);
        int[] answer = new int [tempA.Length + tempC.Length];
        for (int i = 0; i < tempA.Length; i++)
        {
            answer[i] = tempA[i];
        }
        for (int i = 0; i < tempC.Length; i++)
        {
            answer[tempA.Length + i] = tempC[i];
        }
        // create and use SumPositiveElementsInColumns(matrix);
        // end
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
        FindMaxIndex(A, out int rowA, out int columnA);
        FindMaxIndex(B, out int rowB, out int columnB);


        int temp = A[rowA, columnA];
        A[rowA, columnA] = B[rowB, columnB];
        B[rowB, columnB] = temp;
        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);

        // end
    }


    public int[,] RemoveRow(int[,] matrix, int rowIndex)
    {
        int[,] rezult = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        for (int i = 0; i < rowIndex; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rezult[i, j] = matrix[i, j];
            }
        }
        for (int i = rowIndex; i < rezult.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rezult[i, j] = matrix[i + 1, j];
            }
        }
        return rezult;
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here
        int Indexmin = -1, min = int.MaxValue, Indexmax = -1, max = int.MinValue;
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    Indexmin = i;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    Indexmax = i;
                }
            }
        }
        matrix = RemoveRow(matrix, Indexmin);
        if (Indexmin < Indexmax)
        {
            matrix = RemoveRow(matrix, Indexmax - 1);
        }
        else if (Indexmin > Indexmax)
        {
            matrix = RemoveRow(matrix, Indexmax);
        }
        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);

        // end
    }

    static int GetAverageWithoutMinMax(int [,]matrix)
    {
        int average = 0, cnt = 0, sum = 0, max = int.MinValue, min = int.MaxValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != max && matrix[i,j] != min )
                {
                    sum += matrix[i, j];
                    cnt++;
                }
            }
        }
        average = sum / cnt;

        return average;

    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here
        int[] rezult = new int[3];
        rezult[0] = GetAverageWithoutMinMax(A);
        rezult[1] = GetAverageWithoutMinMax(B);
        rezult[2] = GetAverageWithoutMinMax(C);


        if (rezult[0] < rezult[1] && rezult[1] < rezult[2])
        {
            answer = 1;
        }
        else if (rezult[0] > rezult[1] && rezult[1] > rezult[2])
        {
            answer = -1;
        }
        else
        {
            answer = 0;
        }


        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);

        // end
    }

    public static void SortRowsByMaxElement(ref int[,] matrix)
    {   
        int[] rezult = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int max = matrix[i, 0];
            for (int j = 1; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
            rezult[i] = max; 
        }
        
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(0); j++)
            {
                if (rezult[i] < rezult[j]) 
                {
                    
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }

                    int tempMax = rezult[i];
                    rezult[i] = rezult[j];
                    rezult[j] = tempMax;
                }
            }
        }
    }




    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here
        SortRowsByMaxElement(ref A);
        SortRowsByMaxElement(ref B);
        // create and use SortRowsByMaxElement(matrix);

        // end
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            bool point = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    point = true;
                    break;
                }
            }

            
            if (point)
            {
                matrix = RemoveRow(matrix, i);
                i--; 
            }
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

    public int[] CreateArrayFromMins(int[,] matrix)
    {
        
        int []rezult = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = i; j < matrix.GetLength(0); j++)
            {
                if (min > matrix[i, j])
                {
                    min = matrix[i, j];
                }
            }
            rezult[i] = min;
        }
       
        return rezult;
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

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here

        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);

        // end
    }


    public static void MatrixValuesChange(double[,] matrix)
    {
        
        double[] Temp = new double[matrix.GetLength(0) * matrix.GetLength(1)];
        int index = 0;

        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Temp[index++] = matrix[i, j];
            }
        }

      
        for (int i = 0; i < Temp.Length - 1; i++)
        {
            for (int j = 0; j < Temp.Length - i - 1; j++)
            {
                if (Temp[j] < Temp[j + 1])
                {
                    double temp = Temp[j];
                    Temp[j] = Temp[j + 1];
                    Temp[j + 1] = temp;
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
                    if (matrix[i,j] == Temp[k])
                    {
                        flag = true;
                        break;
                    }
                }

                
                if (flag)
                {
                    matrix[i,j] *= (matrix[i,j] > 0) ? 2 : 0.5;
                }
                else
                {
                    matrix[i,j] *= (matrix[i,j] > 0) ? 0.5 : 2;
                }
            }
        }
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here
        MatrixValuesChange(A);
        MatrixValuesChange(B);
        // create and use MatrixValuesChange(matrix);

        // end
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);

        // end
    }


    public int[] GetNegativeCountPerRow(int[,] matrix)
    {
        int[] otr = new int[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int cnt = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    cnt++;
                }
            }
            otr[i] = cnt;
        }

        return otr;
    }
    public int FindMaxNegativeRow(int[,] matrix)
    {
        int[] otr = GetNegativeCountPerRow(matrix);
        int max = 0;
        for (int i = 0; i < otr.Length; i++)
        {
            if (otr[i] > otr[max])
            {
                max = i;
            }
        }
        return max;
    }


    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here
        maxA = FindMaxNegativeRow(A);
        maxB = FindMaxNegativeRow(B);
        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22

        // end
    }


    public int FindRowMaxIndex(int[,] matrix, int row)
    {
        int ind = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] > matrix[row, ind])
            {
                ind = j;
            }
        }
        return ind;
    }
    public void ReplaceMaxElementOdd(int[,] matrix)
    {
        
        for (int i = 1; i < matrix.GetLength(0); i = i + 2)
        {
            int max = FindRowMaxIndex(matrix, i);
            matrix[i, max] = 0;
        }
    }
    public void ReplaceMaxElementEven(int[,] matrix)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i = i + 2)
        {
            int max = FindRowMaxIndex(matrix, i);
            matrix[i, max] *= (max + 1);
        }
    }


    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        ReplaceMaxElementEven(A);
        ReplaceMaxElementOdd(A);
        ReplaceMaxElementEven(B);
        ReplaceMaxElementOdd(B);



        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
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



    public delegate double SumFunction(int i, double x, ref int changes);
    public delegate double YFunction(double x);
    public double s1(int i, double x, ref int f)
    {
        if (i > 0)
        {
            f *= i;
        }
        double temp = Math.Cos(i * x) / f;
        return temp;
    }
    public double s2(int i, double x, ref int p)
    {
        p *= -1;
        double temp = p * Math.Cos(i * x) / (i * i);
        return temp;
    }
    public double y1(double x)
    {
        double y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
        return y;
    }
    public double y2(double x)
    {
        double y = ((x * x) - Math.Pow(Math.PI, 2) / 3) / 4;
        return y;
    }
    public double Sum(SumFunction SumFunct, double x, int i)
    {
        double sum = 0;
        int sign = 1;

        double tekyw = SumFunct(i, x, ref sign);

        while (Math.Abs(tekyw) > 0.0001)
        {
            sum += tekyw;
            tekyw = SumFunct(++i, x, ref sign);
        }
        return sum;
    }
    public void GetSumAndY(SumFunction SumFunct, YFunction yFunct, double a, double b, double h, double[,] SumAndY, int I_perv = 0)
    {
        for (int i = 0; i < (b - a) / h + 1; i++)
        {
            double x = a + i * h;
            double sum = Sum(SumFunct, x, I_perv);
            double y = yFunct(x);
            SumAndY[i, 0] = sum;
            SumAndY[i, 1] = y;
        }
    }

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here
        double a1 = 0.1, b1 = 1, h1 = 0.1;
        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;
        firstSumAndY = new double[(int)((b1 - a1) / h1) + 1, 2];
        GetSumAndY(s1, y1, a1, b1, h1, firstSumAndY);  
        secondSumAndY = new double[(int)((b2 - a2) / h2) + 1, 2];
        GetSumAndY(s2, y2, a2, b2, h2, secondSumAndY, 1);
        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

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
        double sum = 0;
        for (int i = 1; i < array.Length; i += 2) 
        {
            sum += array[i];
        }
        return sum;
    }
    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        
        SwapDirection swapper = null;

        double average = array.Average();

        if (array[0] > average)
        {
            swapper = SwapRight;
        }
        else
        {
            swapper = SwapLeft;
        }

        
        if (swapper != null)
        {
            swapper(array); 
        }

       
        answer = GetSum(array);

        


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

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

        // end

        return answer;
    }
    public int CountSignFlips(YFunction func, double a, double b, double h)
    {
        int sign = 0;

        double pred = func(a);
        for (double x = a + h; x <= b; x += h)
        {
            double tekyw = func(x);

            
            if ((pred > 0 && tekyw <= 0) || (pred < 0 && tekyw >= 0))
            {
                sign++;
            }

            pred = tekyw;
        }

        return sign;
    }

    public double F1(double x)
    {
        return x * x - Math.Sin(x);
    }

    public double F2(double x)
    {
        return Math.Exp(x) - 1;
    }
    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here

        double a1 = 0, b1 = 2, h1 = 0.1;
        double a2 = -1, b2 = 1, h2 = 0.2;
        func1 = CountSignFlips(F1, a1,b1,h1);
        func2 = CountSignFlips(F2, a2,b2,h2);
        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
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
    public int[,] InsertColumn(int[,] B, CountPositive CountRowPositive, int[,] C, CountPositive CountColumnPositive)
    {
        
        int RowIndex = CountRowPositive(B);
        int ColIndex = CountColumnPositive(C);

        
        int[,] A = new int[B.GetLength(0) + 1, B.GetLength(1)];

        
        for (int i = 0; i < B.GetLength(1); i++)
        {
            A[RowIndex + 1, i] = C[i, ColIndex];
        }

        
        for (int i = 0; i <= RowIndex; i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                A[i, j] = B[i, j];
            }
        }

      
        for (int i = RowIndex + 2; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                A[i, j] = B[i - 1, j];
            }
        }

        return A;
    }
    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here
        B = InsertColumn(B, CountRowPositive, C, CountColumnPositive);
        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

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

    public int MaxElement(int[,] matrix)
    {
        int max = int.MinValue;
        int maxind = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxind = i;
                }
            }
        }
        return maxind;
    }

    public int MinElement(int[,] matrix)
    {
        int min = int.MaxValue;
        int minind = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minind = i;
                }
            }
        }
        return minind;
    }

    public void RemoveRows(ref int[,] matrix, FindElementDelegate findMax, FindElementDelegate findMin)
    {
        int max = findMax(matrix);
        int min = findMin(matrix);

       
        if (max == min)
        {
            matrix = RemoveRow(matrix, max);
        }
        else
        {
           
            matrix = RemoveRow(matrix, min);

           
            if (min < max)
            {
                matrix = RemoveRow(matrix, max - 1);
            }
            else
            {
                matrix = RemoveRow(matrix, max);
            }
        }
    }


    public void Task_3_13(ref int[,] matrix)
    {
        // code here
        RemoveRows(ref matrix, MaxElement, MinElement);
        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
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
    public delegate void ReplaceMaxElement(int[,] matrix);
    public void EvenOddRowsTransform(int[,] matrix, ReplaceMaxElement ReplaceMaxElementOdd, ReplaceMaxElement ReplaceMaxElementEven)
    {
        ReplaceMaxElementOdd(matrix);
        ReplaceMaxElementEven(matrix);     
    }

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        EvenOddRowsTransform(A, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        EvenOddRowsTransform(B, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
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
