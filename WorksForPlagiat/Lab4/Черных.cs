using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
        //R.I.P Test for 4th lab. We will remember you
        program.Task_3_9(matrix);
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
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);

        if (m == n)
            for (int i = 0; i < 4; i++)
                answer += A[i, i];
        else
            return 0;

        Console.WriteLine(answer);
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

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), min = 999999, index = 0;
        answer = new int[m];
        if (m != 4 || n != 7)
            return default(int[]);
        else
            for (int i = 0, k = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    if (A[i, j] < min) { min = A[i, j]; index = j; }
                answer[k] = index;
                k++;
            }

        foreach (int i in answer)
            Console.Write(i + " ");
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

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        void swap(int[,] arr, int i, int j, int h) { int a = arr[h, j]; arr[h, j] = arr[h, i]; arr[h, i] = a; }
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, index = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            swap(A, 0, index, i);
            max = -999999;
            index = -1;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, indexI = -1, indexJ = -1;
        if (m != 6 || n != 7) return null;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; indexI = i; indexJ = j; }

        int[,] B = new int[m - 1, n - 1];
        for (int i = 0, a = 0; i < m; i++)
        {
            for (int j = 0, b = 0; j < n; j++)
                if (j != indexJ) { B[a, b] = A[i, j]; b++; }
            if (i != indexI) a++;
        }

        A = new int[m - 1, n - 1];
        A = B;

        for (int i = 0; i < m - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, index = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            A[i, index] *= (i + 1);
            index = -1;
            max = -999999;
        }
        // end
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        for (int i = 0; i < D.GetLength(0); i++){
            int max = -999, iMax = 0, iLast = 0, iFirst = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0){
                    iLast = j;
                    if(iFirst == -1) iFirst = j;
                }
            }
            for (int j = 0; j < iFirst; j++)
                if (D[i, j] > max){ max = D[i, j]; iMax = j; }

            if (iFirst != 0 && iLast != 0 && max != -999){
                D[i, iMax] = D[i, iLast];
                D[i, iLast] = max;
            }
            Console.WriteLine($"first: {iFirst} last: {iLast} max: {max}");
        }
        
        for (int i = 0; i < D.GetLength(0); i++){
            for (int j = 0; j < D.GetLength(1); j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        int m = H.GetLength(0), n = H.GetLength(1), maxAbs = -9999999, indexAbs = -1, max = -999999, indexMax = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(H[i, j]) > max) { maxAbs = H[i, j]; indexAbs = j; }
                if (H[i, j] > max) { max = H[i, j]; indexMax = j; }
            }
            if (maxAbs >= 0)
            {
                H[i, n - 1] = maxAbs;
            }
            if (maxAbs < 0)
            {
                H[i, n - 1] = maxAbs;
                H[i, n - 2] = max;
            }
            max = maxAbs = -999999;
            indexMax = indexAbs = -1;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(H[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        int m = Y.GetLength(0), n = Y.GetLength(1), index = -1;
        double max = -999999, sum = 0, count = 0;
        if (m != 6 || n != 5) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if (Y[i, j] > max) { max = Y[i, j]; index = j; }
            if (index != n - 1)
                for (int j = index + 1; j < n; j++)
                    if (Y[i, j] > 0) { sum += Y[i, j]; count++; }
                    else
                        sum = count = 0;
            if (count == 0) sum = 0;
            else sum /= count;
            for (int j = 0; j < index; j++)
                if (Y[i, j] < 0) Y[i, j] = sum;
            sum = count = 0;
            max = -9999;
            index = -1;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(Y[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        int m = B.GetLength(0), n = B.GetLength(1), max = -9999999;
        int[] numbers = new int[m];
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if (B[i, j] > max) { max = B[i, j]; }
            numbers[i] = max;
            max = -9999;
        }
        for (int i = 0, j = m - 1; i < m; i++, j--)
            B[i, 3] = numbers[j];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        int m = B.GetLength(0), n = B.GetLength(1);
        if (m != 5 || n != 5) return null;
        for (int i = 0; i < m; i++)
        {
            int a = B[0, i];
            B[0, i] = B[3, i];
            B[3, i] = a;
        }
        /*Console.WriteLine(" i 0 1 2 3 4");
        Console.WriteLine("j  _________");
        for (int i = 0; i < m; i++){
            Console.Write(i + "| ");
            for(int j = 0; j < m; j++)
                Console.Write($"{B[i, j]} ");
            Console.WriteLine();
        }
        Console.WriteLine(B[3, 0]);*/
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }
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

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), count = 0, counter = 0;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] < 0) count++;
        answer = new int[count];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] < 0) { answer[counter] = A[i, j]; counter++; }

        foreach (int i in answer)
            Console.Write(i + " ");
        // end

        return answer;
    }
    #endregion
    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), indexMax = -1, indexPrev = -1, indexPost = -1;
        double max = -99999;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; indexMax = j; }
            if (indexMax == n)
            {
                if (A[i, indexPrev] > 0) A[i, indexPrev] *= 2;
                else A[i, indexPrev] /= 2;
            }
            else if (indexMax == 0)
            {
                if (A[i, indexPost] > 0) A[i, indexPost] *= 2;
                else A[i, indexPost] /= 2;
            }
            else if (A[i, indexMax - 1] > A[i, indexMax + 1])
            {
                if (A[i, indexMax + 1] > 0) A[i, indexMax + 1] *= 2;
                else A[i, indexMax + 1] /= 2;
            }
            else
            {
                if (A[i, indexMax - 1] > 0) A[i, indexMax - 1] *= 2;
                else A[i, indexMax - 1] /= 2;
            }
            //Console.WriteLine($"prev: {indexPrev} | max: {indexMax} | post: {indexPost}");
            max = -99999;
            indexMax = -1;
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 7 || m != 5) return null;

        for (int i = 0; i < m; i++){
            int pos = 0, neg = 0, max = -999999, iMax = 0;
            for (int j = 0; j < n; j++){

                if (A[j, i] > max) { max = A[j, i]; iMax = j; }

                if (A[j, i] > 0)pos++;
                else neg++;
            }
            if (pos > neg) A[iMax, i] = 0;
            else A[iMax, i] = iMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        for (int i = 0; i < m; i++){
            int s = 0, max = -999999, iMax = -1;
            for (int j = 0; j < n; j++)
                if (A[j, i] > max){ max = A[j, i]; iMax = j; }

            if (iMax < 5){
                for (int j = iMax + 1; j < n; j++)  s += A[j, i];
                A[0, i] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;
        for (int i = 0; i < m; i++){
            int max = -999999, iMax = 0;
            for (int j = 0; j < n; j++)
                if (A[j, i] > max){ max = A[j, i]; iMax = j; }

            if (max < B[i]){ A[iMax, i] = B[i]; }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int i = 0; i < m; i++){
            double max = -999999;
            int iMax = -1;

            for (int j = 0; j < n; j++)
                if (A[j, i] > max){ max = A[j, i]; iMax = j; }

            double s = (A[0, i] + A[n - 1, i]) / 2;

            if (max < s) A[iMax, i] = s;
            else A[iMax, i] = iMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return answer;

        answer = new int[n, 3 * n];

        int[,] A = new int[n, n];
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i == j) A[i, j] = 1;

        for (int i = 0; i < n; i++){
            int count = 0;
            for (int j = 0; j < 3 * n; j++){
                if (count == 3) count = 0;

                answer[i, j] = A[i, count];
                count++;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1), max = -999999, iMax = -1;
        if (n != 6 || m != 6) return null;

        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++)
                if (i == j)
                    if (A[i, j] > max){ max = A[i, j]; iMax = i; }
        }

        for (int i = 0; i < iMax; i++)
            for (int j = i + 1; j < m; j++)
                A[i, j] = 0;
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1), max1 = -999999, iMax1 = -1, max2 = -999999, iMax2 = -1;

        if (n != 6 || m != 6) return null;

        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++){
                if (i % 2 == 0)
                    if (B[i, j] > max1){ max1 = B[i, j]; iMax1 = j;}

                if (i % 2 != 0)
                    if (B[i, j] > max2){ max2 = B[i, j]; iMax2 = j;}
            }
            if (i % 2 != 0){
                B[i - 1, iMax1] = max2;
                B[i, iMax2] = max1;
                max1 = max2 = -999999;
                iMax1 = iMax2 = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 6 || m != 7) return null;

        for (int i = 0; i < n; i++){
            int temp;
            for (int j = 0; j < m / 2; j++){
                temp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);

        if (n != 7 && m != 5) return null;

        //укороченная матрица [индекс строки, min элемент строки]
        int[,] shortMatrix = new int[n, 2];

        const int min = 999999;

        //заполнение
        for(int i = 0; i < n; i++){
            shortMatrix[i, 0] = i;
            shortMatrix[i, 1] = min;

            for (int j = 0; j < m; j++)
                if (matrix[i, j] < shortMatrix[i, 1]) shortMatrix[i, 1] = matrix[i, j];
        }

        //сортировка по [i, 1]
        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0 || shortMatrix[i, 1] <= shortMatrix[i - 1, 1]){ i = j; j++; }
            else{
                int temp = shortMatrix[i, 1],
                    iTemp = shortMatrix[i, 0],
                    iNext = shortMatrix[i-1, 0];

                for(int z = 0; z < m; z++){
                    int temp1 = matrix[i, z];
                    matrix[i, z] = matrix[i-1, z];
                    matrix[i - 1, z] = temp1;
                }

                shortMatrix[i, 1] = shortMatrix[i - 1, 1];
                shortMatrix[i, 0] = shortMatrix[i - 1, 0];

                shortMatrix[i - 1, 1] = temp;
                shortMatrix[i - 1, 0] = iTemp;
                i--;
            }
        }


        /*for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++)
               Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < shortMatrix.GetLength(0); i++){
            for (int j = 0; j < shortMatrix.GetLength(1); j++)
                Console.Write(shortMatrix[i, j] + " ");
            Console.WriteLine();
        }*/
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || n < 3)return answer;

        answer = new int[n * 2 - 1];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k < 1) return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]])) { max[0] = i; max[1] = j; }

        if (max[1] != k-1){
            for (int j = 0; j < n; j++){
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1){
            for (int i = 0; i < n; i++){
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
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
        int lenA = A.Length, lenB = B.Length, index = 0; ;
        if (lenA < 2 || lenB < 2)return answer;

        int[,] matrixA = new int[n, n], matrixB = new int[n, n];

        for (int i = 0; i < n; i++){
            for (int j = i; j < n; j++){
                matrixA[i, j] = A[index];
                matrixB[i, j] = B[index];
                matrixA[j, i] = A[index];
                matrixB[j, i] = B[index];
                index++;
            }
        }

        int[] matrixC = new int[n * n];

        int indexC = 0;
        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++){
                for (int k = 0; k < n; k++)
                    matrixC[indexC] += matrixA[i, k] * matrixB[k, j];
                indexC++;
            }
        }
        answer = matrixC;
        foreach(int x in answer)
            Console.Write(x + " ");
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 && m != 7) return null;

        int[] shortMatrix = new int[m];

        for (int j = 0; j < m; j++){
            short count = 0;

            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) count++;

            shortMatrix[j] = count;
        }
        /*foreach(int x in shortMatrix)
            Console.Write(x + " ");
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();*/

        //принцип мини-карты
        for (int i = 0; i < m; i++){
            for (int j = 0; j < m - i - 1; j++){
                if (shortMatrix[j] > shortMatrix[j + 1]){
                    int temp = shortMatrix[j];
                    shortMatrix[j] = shortMatrix[j + 1];
                    shortMatrix[j + 1] = temp;

                    for(int k = 0; k < n; k++){
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                }
            }
        }
        /*foreach (int x in shortMatrix)
            Console.Write(x + " ");
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }*/
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n < 2) return null;

        int nonZero = 0;
        for (int i = 0; i < n; i++){
            short zeros = 0;

            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0){ zeros = 1; break; }

            if (zeros == 1)
                nonZero++;
        }

        int[,] newMatrix = new int[nonZero, m];
        int row = 0;

        for (int i = 0; i < n; i++){
            short zeros = 1;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0){ zeros = 1; break; }

            if (zeros == 1){
                for (int j = 0; j < m; j++)
                    newMatrix[row, j] = matrix[i, j];

                row++;
            }
        }
        matrix = newMatrix;
        // end

        return matrix;
    }
    #endregion
}