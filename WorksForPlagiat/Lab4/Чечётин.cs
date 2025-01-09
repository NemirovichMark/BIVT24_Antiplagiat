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


    }
    #region Level 1
    static int Task_1_1(int[,] A)
    {
        int answer = 0;

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // double sum = 0;
        // int count = 0;

        // if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
        // return 0;
        // for (int i = 0; i < A.GetLength(0); i++)
        // {
        //     for (int j = 0; j < A.GetLength(1); j++)
        //     {
        //         if (A[i,j] > 0)
        //         {
        //             sum += A[i,j];
        //             count ++;
        //         }
        //     }
        // }
        // answer = sum/count;
        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        
        int j =  A.GetLength(0) - 1;

        for (int i = 0; i < A.GetLength(0); i++, j--)
        {
            if(i == j)
            {
                answer += A[i, j];
            }
            answer += A[i, i];
        }

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
        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7){
            return null;
        }

        answer = new int[A.GetLength(0)];
        int maxElem;
        int indexMaxElem = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            maxElem = A[i, 0];
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if (maxElem > A[i, j])
                {
                    maxElem = A[i, j];
                    indexMaxElem = j;
                }
            }
            answer[i] = indexMaxElem;
        }

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
        
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7)
        return null;

        int [] answer = new int[A.GetLength(0)];
        int maxElem;
        int indexMaxElem = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            maxElem = A[i, 0];
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if (maxElem < A[i, j])
                {
                    maxElem = A[i, j];
                    indexMaxElem = j;
                }
            }
            answer[i] = indexMaxElem;
        }

        for(int i = 0; i < answer.Length; i++)
        {
            int temp = A[i, 0];
            A[i, 0] = A[i, answer[i]];
            A[i, answer[i]] = temp;
        }

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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        return null;

        int n = A.GetLength(0), m = A.GetLength(1);
        int maxElem = int.MinValue;
        int indexRow = -1, indexColum = -1;

        for (int i = 0; i < n; i++)
        {   
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    indexRow = i;
                    indexColum = j;
                }
            }
        }

        int[,] answer = new int[n - 1, m - 1];
    
        for (int i = 0, newRow = 0; i < n; i++)
        {
            if (i == indexRow) continue;

            for (int j = 0, newCol = 0; j < m; j++)
            {
                if (j == indexColum) continue;
            
                answer[newRow, newCol] = A[i, j];
                newCol++;
            }
            newRow++;
        }

        A = answer;

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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
        return null;

        int [] indekMaxElements = new int[A.GetLength(0)];
        int maxElem;
        int indexMaxElem = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            maxElem = A[i, 0];
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if (maxElem < A[i, j])
                {
                    maxElem = A[i, j];
                    indexMaxElem = j;
                }
            }
            indekMaxElements[i] = indexMaxElem;
            indexMaxElem = 0;
        }

        for(int i = 0; i < indekMaxElements.Length; i++)
        {
            A[i, indekMaxElements[i]] *= i + 1;
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
        
    for (int i = 0; i < n; i++)
    {
        int maxBeforeFirstNegative = int.MinValue;
        int maxIndex = -1;
        int lastNegativeIndex = -1;

        for (int j = 0; j < m; j++)
        {
            if (D[i, j] < 0)
            {
                if (lastNegativeIndex == -1)
                {
                    lastNegativeIndex = j;
                }

                lastNegativeIndex = j;
            }
            else if (lastNegativeIndex == -1)
            {
                if (D[i, j] > maxBeforeFirstNegative)
                {
                    maxBeforeFirstNegative = D[i, j];
                    maxIndex = j;
                }
            }
        }

        if (maxIndex != -1 && lastNegativeIndex != -1 && maxIndex != lastNegativeIndex)
        {
            int temp = D[i, maxIndex];
            D[i, maxIndex] = D[i, lastNegativeIndex];
            D[i, lastNegativeIndex] = temp;
        }
    }

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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        return null;

        int n = H.GetLength(0);
        int m = H.GetLength(1);
        int [] maxElemCol = new int[n];

        for (int i = 0; i < n; i++)
        {
            int maxElem = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (maxElem < H[i, j])
                {
                    maxElem = H[i, j];
                }
            }
            maxElemCol[i] = maxElem;
        }

        for (int i = 0; i < n; i++)
        {
            int temp =  H[i, m - 2];
            H[i, m - 2] = maxElemCol[i];
            H[i, m - 1] = temp;
        }

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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
    return null;

    int n = Y.GetLength(0);
    int m = Y.GetLength(1);
    double[] averages = new double[n]; 

    for (int i = 0; i < n; i++)
    {
        double max = double.MinValue;
        int maxIndex = -1;

        for (int j = 0; j < m; j++)
        {
            if (Y[i, j] > max)
            {
                max = Y[i, j];
                maxIndex = j;
            }
        }

        double sum = 0;
        int count = 0;

        for (int j = maxIndex + 1; j < m; j++)
        {
            if (Y[i, j] > 0)
            {
                sum += Y[i, j];
                count++;
            }
        }

        if (count == 0)
        {
            averages[i] = 0;
        }

        else
        {
            averages[i] = Math.Round(sum / count, 2);
        }

        for (int j = 0; j < maxIndex; j++)
        {
            if (Y[i, j] < 0)
            {
                Y[i, j] = averages[i];
            }
        }
    }

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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        return null;

        int n = B.GetLength(0);
        int m = B.GetLength(1);
        int[] maxElem = new int[n];
        int count = n - 1;

        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (max < B[i, j])
                {
                    max = B[i, j];
                }
            }
            maxElem[i] = max;

        }

        for (int i = 0; i < n; i++)
        {
            B[i, 3] = maxElem[count];
            count--;
        }


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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        return null;

        int n = B.GetLength(0);
        int m = B.GetLength(1);
        double maxElem = double.MinValue;
        int indexMaxElem = -1, indexMinElem = -1;


        for(int i = 0; i < n; i++)
        {
            if (B[i,i] > maxElem)
            {
                maxElem = B[i, i];
                indexMaxElem = i;
            }
        }
        for(int i = 0; i < n; i++)
        {
            if(B[i,2] < 0)
            {
                indexMinElem = i;
                break;
            }
        }

        for(int i = 0; i < n; i++)
        {
            int temp = B[indexMaxElem, i];
            B[indexMaxElem, i] = B[indexMinElem, i];
            B[indexMinElem, i] = temp;
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        return null;

        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }

        answer = new int[count];
        count = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[count] = A[i, j];
                    count++;
                }
            }
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        return null;
       
        double n = A.GetLength(0);
        double m = A.GetLength(1);

        for(int i = 0; i < n; i++)
        {
            double maxElem = int.MinValue;
            for(int j = 0; j < m; j++)
            {
                if(A[i,j] > maxElem)
                {
                    maxElem = A[i, j];
                }
            }
            for(int j = 0; j < m; j++)
            {
                if(A[i,j] == maxElem && j != 0 && j != m - 1)
                {
                    if(A[i,j + 1] < A[i,j - 1])
                    {
                        j++;
                    }
                    else
                    {
                        j--;
                    }
                    if (A[i,j] > 0)
                    {
                        A[i,j] *= 2;
                    }
                    else
                    {
                        A[i,j] /= 2;
                    }
                    break;
                }
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 7 || col != 5){
            return null;
        }

        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > 0){
                    MaxCount++;
                }
                if (A[i, j] < 0){
                    MinCount++;
                }
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            if (MaxCount > MinCount){
                A[MaxIndexI, MaxIndexJ] = 0;
            }
            else{
                A[MaxIndexI, MaxIndexJ] = MaxIndexI+1;
            }
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
         if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        return null;
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        for(int j = 0; j < m; j++)
        {
            int maxElem = int.MinValue;
            int indexMaxElem = -1;
            for(int i = 0; i < n; i++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    indexMaxElem = i;
                }
            }
            if (indexMaxElem < n/2)
            {
                int sum = 0;
                for(int i = indexMaxElem + 1; i < n; i++)
                {
                    sum += A[i, j];
                }
                A[0,j] = sum;
            }
           
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        return null;
        int n = A.GetLength(0);
        int m = A.GetLength(1);


        for(int j = 0; j < m; j++)
        {
            int maxElem = int.MinValue;
            int maxIndex = -1;

            for(int i = 0; i < n; i++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    maxIndex = i;
                }
            }
            if(A[maxIndex, j] < B[j])
            {
                A[maxIndex, j] = B[j];
            }
                
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 7 || col != 5){
            return null;
        }
        
        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            double sum = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            sum = (A[0, j] + A[row-1, j])/2;
            if (MaxVal < sum){
                A[MaxIndexI, MaxIndexJ] = sum;
            }
            else{
                A[MaxIndexI, MaxIndexJ] = MaxIndexI+1;
            }
            

        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        if(n < 0)
        return null;
        
        answer = new int[n, n * 3];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n * 3; j++)
            {
                answer[i, j] = 0;
            }
        }

        for(int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, n + i] = 1;
            answer[i, 2 * n + i] = 1;
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0)!= 6 || A.GetLength(1)!= 6)
        return null;
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int maxElem = int.MinValue;
        int indexElem = -1;

        for(int i = 0; i < n; i++)
        {
            if(A[i,i] > maxElem)
            {
                maxElem = A[i,i];
                indexElem = i;
            }   
        }
        int test = 0;
        for(int i = 0; i < n; i++)
        {
            test = i;
            if(test == indexElem) break;   
            for(int j = 0; j < m; j++)
            {
                if(j > i)
                {
                    A[i, j] = 0;   
                }
            }
            
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0)!= 6 || B.GetLength(1)!= 6)
        return null;
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        

        for(int i = 0; i < n; i+=2)
        {
            int firstMaxElem = int.MinValue, secMaxElem = int.MinValue;
            int firstMaxIndex = -1, secMaxIndex = -1;
            int temp = 0;
            for(int j = 0; j < m; j++)
            {
                if(firstMaxElem < B[i,j])
                {
                    firstMaxElem = B[i,j];
                    firstMaxIndex = j;
                }
                if(secMaxElem < B[i + 1, j])
                {
                    secMaxElem = B[i + 1, j];
                    secMaxIndex = j;
                }
            }
            temp = firstMaxElem;
            B[i, firstMaxIndex] = secMaxElem;
            B[i + 1, secMaxIndex] = temp;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0)!= 6 || A.GetLength(1)!= 7)
        return null;
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        for(int i = 0; i < n; i++)
        {
            int temp = 0;
            for(int j = 0; j < m/2; j++)
            {
                temp = A[i, j];
                A[i, j] = A[i, m - 1 - j];
                A[i, m - 1 - j] = temp;
            }
        }    

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if(matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        return null;

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] minElems = new int[n];
        int[] minElemIndexes = new int[n];

        
        for (int i = 0; i < n; i++)
        {
            int minElem = int.MaxValue;
            minElemIndexes[i] = i; 

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < minElem)
                {
                    minElem = matrix[i, j];
                }
            }
            minElems[i] = minElem;
        }

        
        for (int i = 1; i < n; i++)
        {
            int key = minElems[i];
            int indexKey = minElemIndexes[i];
            int j = i - 1;

            while (j >= 0 && minElems[j] < key) 
            {
                minElems[j + 1] = minElems[j];
                minElemIndexes[j + 1] = minElemIndexes[j];
                j -= 1;
            }
            minElems[j + 1] = key;
            minElemIndexes[j + 1] = indexKey;
        }

        
        int[,] sortedMatrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int originalRowIndex = minElemIndexes[i];
            for (int j = 0; j < m; j++)
            {
                sortedMatrix[i, j] = matrix[originalRowIndex, j];
            }
        }
        matrix = sortedMatrix;

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
        if(matrix.GetLength(0) != matrix.GetLength(1))
        return null;

        int n = matrix.GetLength(0);

        answer = new int[n * 2 - 1];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int index = j - i + (n - 1);
                answer[index] += matrix[i, j];
            }
        }

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
        if(matrix.GetLength(0)!= matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0))
        return null;

        int n = matrix.GetLength(0);
        int maxElem = matrix[0,0];
        int indexI = -1, indexJ = -1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(Math.Abs(matrix[i, j]) > Math.Abs(maxElem))
                {
                    maxElem = matrix[i, j];
                    indexI = i; 
                    indexJ = j;
                }
            }
        }
        if(indexJ != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, indexJ];
                matrix[i, indexJ] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        if(indexI != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[indexI, j];
                matrix[indexI, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
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

        if (n < 1|| A.Length != n * n / 2 + n / 2 + n % 2 || B.Length != n * n / 2 + n / 2 + n % 2)
            return null;
        answer = new int[n * n];
        int[,] AA = new int[n, n];
        int[,] BB = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                AA[i, j] = A[k];
                BB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j)
                {
                    AA[i, j] = AA[j, i];
                    BB[i, j] = BB[j, i];
                }
            }
        }
        k = 0;
        int sm = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sm = 0;
                for (int l = 0; l < n; l++)
                {
                    sm += AA[i, l] * BB[l, j];
                }
                answer[k] = sm;
                k++;
            }
        }

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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
            return null;
        int[,] B = new int[7, 2];
        int k = 0;
        for (int j = 0; j < 7; j++)
        {
            k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                    k++;
            }
            B[j, 0] = k;
            B[j, 1] = j;
        }
        int[,] A = new int[5, 7];
        int t = 0;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 0; j < 7 - i; j++)
            {
                if (B[j, 0] > B[j + 1, 0])
                {
                    t = B[j, 0];
                    B[j, 0] = B[j + 1, 0];
                    B[j + 1, 0] = t;
                    t = B[j, 1];
                    B[j, 1] = B[j + 1, 1];
                    B[j + 1, 1] = t;
                }
            }
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                A[i, j] = matrix[i, B[j, 1]];
            }
        }
        return A;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1)
            return null;
        int f = 0;
        int kol = 0;
        int[] spi = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            f = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    f = 1;
                    kol++;
                    break;
                }
            }
            spi[i] = f;
        }
        if (matrix.GetLength(0) - kol <= 0)
            return null;
        int[,] A = new int[matrix.GetLength(0) - kol, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (spi[i] == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    A[k, j] = matrix[i, j];
                }
                k++;
            }
        }

        return A;
    }
    #endregion
}

// for (int i =1, j = 2; i < n;)
// {
//     if (i == 0 || arr[i] >= arr[i - 1])
//     {
//         i = j;
//         j++;
//     }
//     else 
//     {
//         int temp = arr[i];
//         arr[i] = arr[i- 1];
//         arr[i - 1] = temp;
//         i--;
//     }
// }

// int[] arr = new int[] { 5, 1, 4, 2, 8 };
// int n = arr.Length, gap = n / 2;
// while (gap > 0) 
// {
//     for (int i = gap; i < n; i++) 
//     {
//         int key = arr[i], j = i - gap;
//         while (j >= 0 && arr[j] > key) 
//         {
//             arr[j + gap] = arr[j];
//             j-= gap;
//         }
//     arr[j + gap] = key;
//     }
//     gap /= 2;
// }
