using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }

    public int Combinations(int n, int k)
    {
        int c = 0;
        c = Factorial(n) / (Factorial(k) * Factorial(n - k));
        return c;
    }
    public int Factorial(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; i++) f *= i;
        return f;
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here

        // create and use Combinations(n, k);
        // create and use Factorial(n);
        
        if (k == 0 || k > 0 && k == n) answer = 1;
        else if (k > 0 && k < n)
            answer = Combinations(n, k);
        else answer = 0;
        // end

        return answer;
    }


    public double GeronArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return S;

    }
    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here

        // create and use GeronArea(a, b, c);
        
        if (first.Length!=3 || second.Length!=3) return -1;
        double S1 = 0, S2 = 0;
        double a1 = first[0], b1 = first[1], c1 = first[2];
        double a2 = second[0], b2 = second[1], c2 = second[2];
        if (a1 <= 0 || a2 <= 0 || b1 <= 0 || b2 <= 0 || c1 <= 0 || c2 <= 0) answer = -1;
        else if (a1 + b1 <= c1 || a1 + c1 <= b1 || c1 + b1 <= a1 || a2 + b2 <= c2 || a2 + c2 <= b2 || c2 + b2 <= a2) answer = -1;
        else if (GeronArea(a1, b1, c1) == 0 || GeronArea(a2, b2, c2) == 0) answer = -1;
        else if (GeronArea(a1, b1, c1) == GeronArea(a2, b2, c2)) answer = 0;
        else if (GeronArea(a1, b1, c1) > GeronArea(a2, b2, c2)) answer = 1;
        else answer = 2;
        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }




    public double GetDistance(double v, double a, int t)
    {
        double S = v * t + a * t * t / 2;
        return S;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        
        if (v1 <= 0 || v2 <= 0 || time <= 0) return -1;
        else if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time)) answer = 1;
        else if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time)) answer = 2;
        else if (GetDistance(v1, a1, time) == GetDistance(v2, a2, time)) answer = 0;
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        
        int time = 1;
        while ( GetDistance(v1, a1, time) > GetDistance(v2, a2, time))
        {
            time++;
        }
        answer=time;
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


    public int FindMaxIndex(double[] A)
    {
        double mx = -11111111;
        int ST = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > mx)
            {
                mx = A[i];
                ST = i;
            }
        }
        return ST;
    }
    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!
        int q = 0;
        double SR = 0;
        int n = 0;
        if (FindMaxIndex(A)>FindMaxIndex(B))
        {
            for (int i = FindMaxIndex(B) + 1; i < B.Length; i++)
            {
                SR += B[i];
                n++;
            }
            q = 2;
        }
        else
        {
            for (int i = FindMaxIndex(A) + 1; i < A.Length; i++)
            {
                SR += A[i];
                n++;
            }
            q = 1;
        }
        SR /= n;
        if (q==1) A[FindMaxIndex(A)] = SR;
        if (q==2) B[FindMaxIndex(B)] = SR;
        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }



    public int FindDiagonalMaxIndex(int[,] A)
    {
        int mx = -1111111111;
        int ST = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > mx)
            {
                mx = A[i, i];
                ST = i;
            }
        }
        return ST;
    }
    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
        
        int STR_A = FindDiagonalMaxIndex(A);
        int ST_B = FindDiagonalMaxIndex(B);
        int[] STRA = new int[5];
        int[] STB = new int[5];
        for (int i=0; i<A.GetLength(1); i++)
        {
            STRA[i] = A[STR_A, i];
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            STB[i] = B[i, ST_B];
        }
        for (int i=0; i<A.GetLength(0); i++)
        {
            A[STR_A, i] = STB[i];
            B[i, ST_B] = STRA[i];
        }
        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }


    public int FindMax(int[] A)
    {
        int mx = -111111111, ST = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > mx)
            {
                mx = A[i];
                ST = i;
            }
        }
        return ST;
    }
    public int[] DeleteElement(int[] A, int i)
    {
        int[] S = new int[A.Length - 1];
        for (int j = 0; j < S.Length; j++)
        {
            if (j < i) S[j] = A[j];
            else S[j] = A[j + 1];
        }
        return S;
    }
    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        int[] Anew = new int[0];
        int[] Bnew = new int[0];
        Anew = DeleteElement(A, FindMax(A));
        Bnew = DeleteElement(B, FindMax(B));
        int[] NEW = new int[Anew.Length + Bnew.Length];
        int q = 0;
        for (int i=0; i<NEW.Length;i++)
        {
            if(i<A.Length-1)
            {
                NEW[i] = Anew[i];
            }
            else
            {
                NEW[i] = Bnew[q];
                q++;
            }
        }
        
        A = NEW;
        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }


    public int[] SortArrayPart(int[] A, int i)
    {
        int n = A.Length;
        for (int j = i + 2, q = j + 1; j < n;)
        {
            if (j == i + 1 || A[j] > A[j - 1])
            {
                j = q;
                q++;
            }
            else
            {
                int t = A[j];
                A[j] = A[j - 1];
                A[j - 1] = t;
                j--;
            }
        }
        return A;
    }
    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        
        // create and use SortArrayPart(array, startIndex);
        A=SortArrayPart(A, FindMax(A));
        B=SortArrayPart(B, FindMax(B));
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


    public int[,] RemoveColumn(int[,] A, int i)
    {
        int[,] Q = new int[A.GetLength(0), A.GetLength(1) - 1];
        for (int q = 0; q < Q.GetLength(1); q++)
        {
            for (int w = 0; w < A.GetLength(0); w++)
            {
                if (q < i)
                {
                    Q[w, q] = A[w, q];
                }
                else
                {
                    Q[w, q] = A[w, q + 1];
                }
            }
        }
        return Q;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        
        int mx = -1111111111;
        int STmx = 0;
        int q = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < q; j++)
            {
                if (matrix[i, j] > mx)
                {
                    mx = matrix[i, j];
                    STmx = j;
                }
            }
            q++;
        }
        
        int mn = 1111111111;
        int STmn = 0;
        q = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = q; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < mn)
                {
                    mn = matrix[i, j];
                    STmn = j;
                }
            }
            q++;
        }

        // create and use RemoveColumn(matrix, columnIndex);
        
        if (STmx > STmn)
        {
            matrix = RemoveColumn(matrix, STmx);
            matrix = RemoveColumn(matrix, STmn);
        }
        else if (STmn > STmx)
        {
            matrix = RemoveColumn(matrix, STmn);
            matrix = RemoveColumn(matrix, STmx);
        }
        else matrix = RemoveColumn(matrix, STmx);
        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }


    public int FindMaxColumnIndex(int[,] A)
    {
        int mx = -11111111, ST = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    ST = i;
                }
            }
        }
        return ST;
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);
        int STA = FindMaxColumnIndex(A);
        int STB = FindMaxColumnIndex(B);
        for (int i=0; i<A.GetLength(0);i++)
        {
            int T = A[i, STA];
            A[i, STA] = B[i, STB];
            B[i, STB] = T;
        }

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }


    public int[,] SortRow(int[,] A, int i)
    {

        int n = A.GetLength(1);
        for (int k = 1, q = 2; k < n;)
        {
            if (k == 0 || A[i, k] > A[i, k - 1])
            {
                k = q;
                q++;
            }
            else
            {
                int T = A[i, k];
                A[i, k] = A[i, k - 1];
                A[i, k - 1] = T;
                k--;
            }
        }
        return A;

    }
    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);
        
        for (int i = 0; i < matrix.GetLength(0); i++) matrix = SortRow(matrix, i);


        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }


    public int[] SortNegative(int[] A)
    {
        int cA = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0) cA++;
        }
        int[] Aotr = new int[cA];
        int qA = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                Aotr[qA] = A[i];
                qA++;
            }
        }

        int n = Aotr.Length;
        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0 || Aotr[i] > Aotr[i - 1])
            {
                i = j;
                j++;
            }
            else
            {
                int T = Aotr[i];
                Aotr[i] = Aotr[i - 1];
                Aotr[i - 1] = T;
                i--;
            }
        }
        int[] Q = new int[Aotr.Length];
        int q = Aotr.Length - 1;
        for (int i = 0; i < Aotr.Length; i++)
        {
            Q[i] = Aotr[q];
            q--;
        }

        qA = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                A[i] = Q[qA];
                qA++;
            }
        }
        return A;
    }
    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);
         
        A = SortNegative(A);
        B = SortNegative(B);
        
        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }


    public int[,] SortDiagonal(int[,] A)
    {
        int[] Q = new int[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Q[i] = A[i, i];
        }
        int n = Q.Length;
        for (int i = 1; i < n; i++)
        {
            int k = Q[i], j = i - 1;
            while (j >= 0 && Q[j] > k)
            {
                Q[j + 1] = Q[j];
                j--;
            }
            Q[j + 1] = k;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, i] = Q[i];
        }
        return A;
    }
    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);
        
        A = SortDiagonal(A);
        B = SortDiagonal(B);
        // end
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
        
        for(int i=A.GetLength(1)-1; i>=0; i--)
        {
            int q = 0;
            for(int j=0; j<A.GetLength(0); j++)
            {
                if (A[j, i] == 0) q++;
            }
            if (q==0)
            {
                A = RemoveColumn(A, i);
            }

        }
        for (int i = B.GetLength(1)-1; i >=0; i--)
        {
            int q = 0;
            for (int j = 0; j < B.GetLength(0); j++)
            {
                if (B[j, i] == 0) q++;
            }
            if (q == 0)
            {
                B = RemoveColumn(B, i);
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



    public int CountNegativeInRow(int[,] A, int i)
    {
        int c = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[i, j] < 0) c++;
        }
        return c;
    }
    public int[] FindMaxNegativePerColumn(int[,] A)
    {
        int[] Q = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = -1111111111;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx && A[j, i] < 0) mx = A[j, i];
            }
            Q[i] = mx;
        }
        return Q;
    }
    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here

        // create and use CountNegativeInRow(matrix, rowIndex);
        
        // create and use FindMaxNegativePerColumn(matrix);
        
        int[] Q = new int[matrix.GetLength(0)];
        for (int i=0; i<matrix.GetLength(0);i++)
        {
            Q[i] = CountNegativeInRow(matrix, i);
        }
        rows = Q;
        cols = FindMaxNegativePerColumn(matrix);
        // end
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }


    public int FindMaxIndex_1(int[,] A)
    {
        int mx = -11111111, ST = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    ST = i;
                }
            }
        }
        return ST;
    }
    public int[,] SwapColumnDiagonal(int[,] A, int i)
    {
        for (int j = 0; j < A.GetLength(0); j++)
        {
            int T = A[j, i];
            A[j, i] = A[j, j];
            A[j, j] = T;
        }
        return A;
    }
    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);
        
        A = SwapColumnDiagonal(A, FindMaxIndex_1(A));
        B = SwapColumnDiagonal(B, FindMaxIndex_1(B));
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
        
        int Amxc = 0, Bmxc=0, Astr=0, Bstr=0;
        for(int i=0; i<A.GetLength(0); i++)
        {
            if (CountNegativeInRow(A, i) > Amxc)
            {
                Amxc = CountNegativeInRow(A, i);
                Astr = i;
            }
            if (CountNegativeInRow(B, i) > Bmxc)
            {
                Bmxc = CountNegativeInRow(B, i);
                Bstr = i;
            }
        
        }
        for (int i=0; i<A.GetLength(0);i++)
        {
            int T = A[Astr, i];
            A[Astr,i]=B[Bstr, i];
            B[Bstr, i] = T;
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

    public int FindSequence(int[] Q, int A, int B)
    {
        bool INC = true;
        bool DEC = true;
        for (int i = A; i < B; i++)
        {
            if (Q[i] < Q[i + 1]) DEC = false;
            if (Q[i] > Q[i + 1]) INC = false;
        }
        if (INC) return 1;
        if (DEC) return -1;
        else return 0;
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



    public void FindIntervals(int[] A, ref int[,] answer)
    {
        int[,] Q = new int[(A.Length * (A.Length - 1) / 2), 2];
        int q = 0;
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (FindSequence(A, i, j) != 0)
                {
                    Q[q, 0] = i;
                    Q[q, 1] = j;
                    q++;
                }
            }
        }
        answer = new int[q, 2];
        for (int i = 0; i < q; i++)
        {
            answer[i, 0] = Q[i, 0];
            answer[i, 1] = Q[i, 1];
        }
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        
        // A and B - start and end indexes of elements from array for search
        

        FindIntervals(first, ref answerFirst);
        FindIntervals(second, ref answerSecond);
        // end
    }

    static int FindSequence_c(int[] Q, int A, int B)
    {
        bool INC = true;
        bool DEC = true;
        for (int i = A; i < B; i++)
        {
            if (Q[i] <= Q[i + 1]) DEC = false;
            if (Q[i] >= Q[i + 1]) INC = false;
        }
        if (INC) return 1;
        if (DEC) return -1;
        else return 0;
    }
    public int[] FindMax_28(int[] Q)
    {
        if (Q.Length == 0) return new int[] { -1, -1 };

        int mx = 1, l = 1, STind = 0, IND = 0;
        int end = 0;

        for (int i = 1; i < Q.Length; i++)
        {
            int c = FindSequence_c(Q, i - 1, i);
            if (c == 0)
            {
                c = FindSequence_c(Q, i, i + 1);
            }

            if (c == end)
            {
                l++;
            }
            else
            {
                if (l > mx)
                {
                    mx = l;
                    IND = STind;
                }

                STind = i - 1;
                l = 2;
            }
            if (c != 0)
                end = c;
        }
        if (l > mx)
        {
            mx = l;
            IND = STind;
        }

        return new int[] { IND, IND + mx - 1 };
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        
        // A and B - start and end indexes of elements from array for search

        answerFirst = FindMax_28(first);
        answerSecond = FindMax_28(second);
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



    public void SortAscending(int[] A)
    {
        for (int i = 0; i < A.Length - 1; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[i] > A[j])
                {
                    int T = A[i];
                    A[i] = A[j];
                    A[j] = T;
                }
            }
        }
    }
    public void SortDescending(int[] A)
    {
        for (int i = 0; i < A.Length - 1; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[i] < A[j])
                {
                    int T = A[i];
                    A[i] = A[j];
                    A[j] = T;
                }
            }
        }
    }
    public void SortMatrixRows(int[,] matrix)
    {
        SortRowStyle sortingDelegate;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] Q = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Q[j] = matrix[i, j];
            }
            sortingDelegate = (i % 2 == 0) ? SortAscending : SortDescending;
            sortingDelegate(Q);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Q[j];
            }
        }

    }
    public delegate void SortRowStyle(int[] A);
    public void Task_3_2(int[,] matrix)
    {
       SortRowStyle sortStyle = default(SortRowStyle); 
       // code here

        // create and use public delegate SortRowStyle(matrix, rowIndex);
        
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        
        SortMatrixRows(matrix);
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

        // end

        return answer;
    }


    public int[] GetUpperTriangle(int[,] A)
    {
        int n = A.GetLength(0);
        int[] Q = new int[n * (n + 1) / 2];
        int q = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Q[q++] = A[i, j];
            }
        }
        return Q;
    }
    public int[] GetLowerTriangle(int[,] A)
    {
        int n = A.GetLength(0);
        int[] Q = new int[n * (n + 1) / 2];
        int q = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Q[q++] = A[i, j];
            }
        }
        return Q;
    }
    public int GetSum(GetTriangole getTriangole, int[,] A)
    {
        int[] Q = getTriangole(A);
        int s = 0;
        foreach (int q in Q) s += q * q;
        return s;
    }
    public delegate int[] GetTriangole(int[,] A);
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        
        // create and use GetSum(GetTriangle, matrix)
        

        GetTriangole triangleDelegate;
        if (isUpperTriangle) triangleDelegate = GetUpperTriangle;
        else triangleDelegate = GetLowerTriangle;
        answer = GetSum(triangleDelegate, matrix);
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

        // end
    }


    
    public int FindFirstRowMaxIndex(int[,] A)
    {
        int mx = -11111111, STmx = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[0, i] > mx)
            {
                mx = A[0, i];
                STmx = i;
            }
        }
        return STmx;
    }
    public void SwapColumns(ref int[,] A, FindElementDelegate diagonal, FindElementDelegate row)
    {
        int q = diagonal(A);
        int qq = row(A);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int T = A[i, q];
            A[i, q] = A[i, qq];
            A[i, qq] = T;
        }

    }
    public delegate int FindElementDelegate(int[,] A);
    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        
        // create and use method FindFirstRowMaxIndex(matrix);
        
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);
        

        FindElementDelegate diagonal = FindDiagonalMaxIndex;
        FindElementDelegate row = FindFirstRowMaxIndex;
        SwapColumns(ref matrix, diagonal, row);
        // end
    }

    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }


    public int FindMaxBelowDiagonalIndex(int[,] A)
    {
        int mx = -11111111, ST = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    ST = j;
                }
            }
        }
        return ST;
    }
    public int FindMinAboveDiagonalIndex(int[,] A)
    {
        int mn = 11111111, ST = 0;
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] < mn)
                {
                    mn = A[i, j];
                    ST = j;
                }
            }
        }
        return ST;
    }
    public void RemoveColumn(ref int[,] A, FindIndex max, FindIndex min)
    {
        int ST1 = max(A);
        int ST2 = min(A);
        int mx = 0, mn = 0;
        if (ST1 > ST2)
        {
            mx = ST1;
            mn = ST2;
        }
        else
        {
            mx = ST2;
            mn = ST1;
        }
        if (mx != mn)
        {
            A = RemoveColumn(A, mx);
            A = RemoveColumn(A, mn);
        }
        else A = RemoveColumn(A, mx);
    }
    public delegate int FindIndex(int[,] A);
    public void Task_3_10(ref int[,] matrix)
    {
        FindIndex searchArea = default(FindIndex); //- uncomment me

        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        
        // create and use method FindMinAboveDiagonalIndex(matrix);
        
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)
        

        FindIndex max = FindMaxBelowDiagonalIndex;
        FindIndex min = FindMinAboveDiagonalIndex;
        RemoveColumn(ref matrix, max, min);
        // end
    }

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public int[] GetNegativeCountPerRow(int[,] A)
    {
        int[] Q = new int[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int c = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) c++;
            }
            Q[i] = c;
        }
        return Q;
    }
    public void FindNegatives(int[,] A, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
    {
        rows = GetNegativeCountPerRow(A);
        cols = FindMaxNegativePerColumn(A);
    }
    public delegate int[] GetNegativeArray(int[,] A);
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here

        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        

        GetNegativeArray searcherRows = GetNegativeCountPerRow;
        GetNegativeArray searcherCols = FindMaxNegativePerColumn;
        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // end
    }

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }

    public bool FindIncreasingSequence_lvl3(int[] Q, int A, int B)
    {
        for (int i = A; i < B; i++)
        {
            if (Q[i] > Q[i + 1])
            {
                return false;
            }
        }
        return true;
    }
    // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
    public bool FindDecreasingSequence_lvl3(int[] Q, int A, int B)
    {
        for (int i = A; i < B; i++)
        {
            if (Q[i] < Q[i + 1])
            {
                return false;
            }
        }
        return true;
    }
    public int DefineSequence(int[] A, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence)
    {
        if (FindIncreasingSequence_lvl3(A, 0, A.Length - 1))
        {
            return 1;
        }
        if (FindDecreasingSequence_lvl3(A, 0, A.Length - 1))
        {
            return -1;
        }
        return 0;
    }
    public delegate bool IsSequence(int[] A, int left, int right);
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);
        

        IsSequence findIncreasingSequence = FindIncreasingSequence_lvl3;
        IsSequence findDecreasingSequence = FindDecreasingSequence_lvl3;
        answerFirst = DefineSequence(first, findIncreasingSequence, findDecreasingSequence);
        answerSecond = DefineSequence(second, findIncreasingSequence, findDecreasingSequence);
        // end
    }



    public int[] FindLongestSequence(int[] A, IsSequence sequence)
    {
        int[] Q = new int[2];
        int mx = -1111111;
        for (int i = 0; i < A.Length - 1; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (sequence(A, i, j))
                {
                    if (j - i > mx)
                    {
                        mx = j - i;
                        Q[0] = i;
                        Q[1] = j;
                    }
                }
            }
        }
        return Q;
    }
    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        IsSequence findIncreasingSequence = FindIncreasingSequence_lvl3;
        IsSequence findDecreasingSequence = FindDecreasingSequence_lvl3;
        answerFirstIncrease = FindLongestSequence(first, FindIncreasingSequence_lvl3);
        answerFirstDecrease = FindLongestSequence(first, FindDecreasingSequence_lvl3);
        answerSecondIncrease = FindLongestSequence(second, FindIncreasingSequence_lvl3);
        answerSecondDecrease = FindLongestSequence(second, FindDecreasingSequence_lvl3);

        // end
    }
    #endregion
    #region bonus part

    public double[,] ToUpperTriangular(double[,] A)
    {
        for (int j = 0; j <= A.GetLength(0) - 2; j++)
        {
            for (int k = j + 1; k <= A.GetLength(0) - 1; k++)
            {
                double p = A[k, j] / A[j, j];
                for (int m = j; m <= A.GetLength(0) - 1; m++)
                {
                    A[k, m] = A[k, m] - A[j, m] * p;
                }
            }
        }
        return A;
    }
    public double[,] ToLowerTriangular(double[,] A)
    {
        for (int j = A.GetLength(0) - 1; j >= 0; j--)
        {
            for (int k = j - 1; k >= 0; k--)
            {
                double p = A[k, j] / A[j, j];
                for (int m = 0; m <= A.GetLength(0) - 1; m++)
                {
                    A[k, m] = A[k, m] - A[j, m] * p;
                }
            }
        }
        return A;
    }
    public double[,] ToLeftDiagonal(double[,] A)
    {
        A = ToUpperTriangular(A);
        A = ToLowerTriangular(A);
        return A;
    }
    public double[,] ToRightDiagonal(double[,] A)
    {
        A = ToLowerTriangular(A);
        A = ToUpperTriangular(A);
        return A;
    }
    public delegate double[,] MatrixConverter(double[,] A);
    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4];  //- uncomment me

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle
        mc[0] = new MatrixConverter(ToUpperTriangular);
        mc[1] = new MatrixConverter(ToLowerTriangular);
        mc[2] = new MatrixConverter(ToLeftDiagonal);
        mc[3] = new MatrixConverter(ToRightDiagonal);
        matrix = mc[index](matrix);
        
        // end

        return matrix;
    }
    #endregion
}
