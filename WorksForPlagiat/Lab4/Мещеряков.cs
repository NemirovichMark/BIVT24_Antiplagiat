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
        Program program = new Program();
        program.Task_1_2(new int[,] {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, 9, 10, 11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { 13, 14, 15, 16, 17, 18, 19 },
                { 0, 1, 2, 3, 4, 5, 6 } });

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
        double sum = 0;
        double avg = 0;
        int count = 0;

        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
        return 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
                
            }
        }

        avg = sum / count;
        answer = avg;
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int j =  A.GetLength(0) - 1;

        for (int i = 0; i < A.GetLength(0); i++, j--)
        {
            if(i + j == i + i)
            {
                answer += A[i, j];
            }
            answer += A[i, i];
        }

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
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7)
        return null;

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

        // end

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
        if (n!= B.GetLength(0) || m!= B.GetLength(1))
        return null;

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int minIndex = 0;
            int minValue = B[i, 0];

            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] < minValue)
                {
                    minValue = B[i, j];
                    minIndex = j;
                }
            }

            int[] newRow = new int[B.GetLength(1)];
            newRow[0] = minValue; 

            int index = 1;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j != minIndex)
                {
                    newRow[index] = B[i, j];
                    index++;
                }
            }

            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = newRow[j];
            }
        }

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        if (n != D.GetLength(0) || m != D.GetLength(1))
            return null;

        for (int i = 0; i < n; i++)
        {
            int maxBeforeNegative = int.MinValue;
            int maxIndex = -1;
            int lastNegativeIndex = -1;

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    lastNegativeIndex = j; 
                }
                else
                {
                    if (lastNegativeIndex == -1 && D[i, j] > maxBeforeNegative)
                    {
                        maxBeforeNegative = D[i, j];
                        maxIndex = j;
                    }
                }   
            }

            if (maxIndex != -1 && lastNegativeIndex != -1)
            {
                int temp = D[i, maxIndex];
                D[i, maxIndex] = D[i, lastNegativeIndex];
                D[i, lastNegativeIndex] = temp;
            }
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
    // end
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
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
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

       
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        return null;
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        for(int j = 0; j < m; j++)
        {
            int maxElem = int.MinValue;
            int maxIndex = -1;
            int countPoz = 0, countNeg = 0;
            for(int i = 0; i < n; i++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    maxIndex = i;
                }
                if (A[i, j] > 0)
                {
                    countPoz++;
                }
                else if (A[i, j] < 0)
                {
                    countNeg++;
                }
            }
            if (countPoz > countNeg)
            {
                A[maxIndex, j] = 0;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1;
            }

        }    

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
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

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
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

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        return null;

        int n = A.GetLength(0);
        int m = A.GetLength(1);

        for(int j = 0; j < m; j++)
        {
            double maxElem = double.MinValue;
            int maxIndex = -1;
            for(int i = 0; i < n; i++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    maxIndex = i;
                }
            }

            double polSum = (A[0, j] + A[n - 1, j]) / 2;
            if (polSum > maxElem)
            {
                A[maxIndex, j] = polSum;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
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
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
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
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
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

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
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
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
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
          
        // end
        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if(matrix.GetLength(0)!= matrix.GetLength(1))
        return null;
        int n = matrix.GetLength(0);
        for(int i = 0; i < n; i++)
        {
            matrix[0, i] = 0;
            matrix[i, n - 1] = 0;
            matrix[i, 0] = 0;
            matrix[n - 1, i] = 0;
        }
        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here
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

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        if(matrix.GetLength(0)!= matrix.GetLength(1))
        return null;
        int n = matrix.GetLength(0);
        for (int i = n/2; i < n; i++)
        {
            for (int j = i/n; j <= i; j++)
            {
                matrix[i, j] = 1; 
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0))
        return null;

        int n = matrix.GetLength(0);
        int maxElem = matrix[0, 0];
        int maxI = 0, maxJ = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(maxElem))
                {
                    maxElem = matrix[i, j];
                    maxI = i;
                    maxJ = j;
                }
            }
        }

        int[,] newMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        int temp = newMatrix[k - 1, maxJ];
        newMatrix[k - 1, maxJ] = maxElem;
        newMatrix[maxI, maxJ] = temp;

        return matrix;
    }

    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        if(matrix.GetLength(0)!= matrix.GetLength(1))
        return (null, null);

        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2];
        lower = new int[(n * (n + 1) / 2) - n];
        int cnt = 0, cnt2 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i <= j)
                {
                    upper[cnt] = matrix[i, j];
                    cnt++;
                } 
                else
                {
                    lower[cnt2] = matrix[i, j];
                    cnt2++;
                }
            }
        }
        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here
        answer = new int[n * n]; 

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                answer[(i * (i + 1)) / 2 + j] = 0; 

                for (int k = 0; k <= i; k++)
                {
                    if (j <= k) 
                    {
                        answer[(i * (i + 1)) / 2 + j] += A[(i * (i + 1)) / 2 + k] * B[(k * (k + 1)) / 2 + j];
                    }
                }
            }
        }



        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);  
  
        if (n != 7 && m != 5)  
            return default(int[,]);  
  
        int[] countPos = new int[n];  
  
        for (int i = 0; i < n; i++){  
            for (int j = 0; j < m; j++){  
                if (matrix[i, j] > 0){  
                    countPos[i]++;  
                }  
            }  
        }  
  
        int maxVal = countPos[0], maxInd = 0; 
        for (int i = 0; i < n; i++){ 
            if (countPos[i] > maxVal){ 
                maxVal = countPos[i]; 
                maxInd = i; 
            } 
        } 
 
        for (int i = 0; i < n - 1; i++){ 
            for (int j = 0; j < n - i - 1; j++){ 
                if (countPos[j] < countPos[j + 1]){ 
                    for (int k = 0; k < 5; k++){ 
                        int temp = matrix[j, k]; 
                        matrix[j, k] = matrix[j + 1, k]; 
                        matrix[j + 1, k] = temp; 
                    } 
                    int tempCount = countPos[j]; 
                    countPos[j] = countPos[j + 1]; 
                    countPos[j + 1] = tempCount; 
                } 
            } 
        }

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        if(matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        return null;

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] negCnts = new int[m];
        
        
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0)
                {
                    negCnts[j]++;
                }
            }
        }

        
        int[] indexs = new int[m];

        for (int j = 0; j < m; j++)
        {
            indexs[j] = j; 
        }

        for (int i = 0; i < indexs.Length - 1; i++)
        {
            for (int j = i + 1; j < indexs.Length; j++)
            {
                if (negCnts[indexs[i]] > negCnts[indexs[j]])
                {
                    int tempIndex = indexs[i];
                    indexs[i] = indexs[j];
                    indexs[j] = tempIndex;
                }
            }
        }

        int[,] sortedMatrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sortedMatrix[i, j] = matrix[i, indexs[j]];
            }
        }
        matrix = sortedMatrix;
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = 0; k < cols - j - 1; k++)
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


        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int nonZeroRowsCount = 0;
        for (int i = 0; i < n; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break; 
                }
            }
            if (!hasZero)
            {
                nonZeroRowsCount++; 
            }
        }

        int[,] filteredMatrix = new int[nonZeroRowsCount, m];
        int currentRow = 0;

        for (int i = 0; i < n; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break; 
                }
            }
            if (!hasZero)
            {
                for (int j = 0; j < m; j++)
                {
                    filteredMatrix[currentRow, j] = matrix[i, j];
                }
                currentRow++;  
            }
        }
        matrix = filteredMatrix;
        // end

        return matrix;
    }
    #endregion
}