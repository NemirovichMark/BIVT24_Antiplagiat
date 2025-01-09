using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Xml.Linq;

public class Program
{

    static void PrintMatrix(int[,] matrix)
    {
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                System.Console.WriteLine(matrix[i, j]);
            }
            System.Console.WriteLine();
        }
    }

    public static void Main()
    {
        Program program = new Program();
        program.Task_3_7(
            new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 10, 11, 12, 13, 14, 15 }, 3);

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int AHight = A.GetLength(0), AWeight = A.GetLength(1);

        for (int i = 0; i < AHight; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1), cntPos = 0;
        double sum = 0;

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cntPos++;
                }
            }
        }

        if (cntPos == 0 || AHeight <= 0)
            answer = 0;
        else
            answer = sum / cntPos;
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int sumValue = 0, AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        // for (int i = 0; i < AHeight; i++){
        //     for (int j = 0; j < AWeight; j++){
        //         if (i == j || Math.Abs(j - i) == AWeight)
        //             sumValue += A[i, j];
        //     }
        // }

        for (int i = 0, j = AWeight - 1; i < AHeight; i++, j--)
        {
            if (i + j == i + i)
                sumValue += A[i, j];
            sumValue += A[i, i];
        }

        answer = sumValue;
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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight == 0 || colIndex > AHeight || colIndex < 0)
            return (default(int), 0);

        for (int i = 0; i < AHeight; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }

        if (value == 0)
            return (default(int), 0);
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);
        int k = 0;

        if (AHeight == 0)
        {
            return answer;
        }
        answer = new double[AHeight];


        for (int i = 0; i < AHeight; i++)
        {
            double sumPos = 0;
            int cntPos = 0;
            for (int j = 0; j < AWeight; j++)
            {
                if (A[i, j] > 0)
                {
                    sumPos += A[i, j];
                    cntPos++;
                }
            }

            if (cntPos != 0)
            {
                answer[i] = sumPos / cntPos;
                k++;
            }
            else
                answer[i] = 0;
        }
        if (k == 0)
            return default(double[]);
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight <= 2)
            return default(int[,]);

        int minValue = A[0, 0], delString = 0;

        for (int i = 0; i < AHeight; i++)
        {
            if (A[i, 0] < minValue)
            {
                minValue = A[i, 0];
                delString = i;
            }
        }

        int[,] newA = new int[AHeight - 1, AWeight];
        for (int i = 0; i < AHeight - 1; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (i < delString)
                    newA[i, j] = A[i, j];
                else
                    newA[i, j] = A[i + 1, j];
            }
        }
        A = newA;
        // end
        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);
        int countReplace = 0;

        if (AWeight == 0 || AHeight == 0)
            return answer;
        answer = new int[AWeight];

        for (int j = 0; j < AWeight; j++)
        {
            int countPos = 0;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] < 0)
                {
                    countPos++;
                    countReplace++;
                }
            }

            answer[j] = countPos;
        }

        if (countReplace == 0)
            return default(int[]);
        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

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
        if (m <= 0 || n <= 0)
            return default(int[,]);

        for (int i = 0; i < n; i++)
        {
            int minValue = B[i, 0], ind = -1;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < minValue)
                {
                    minValue = B[i, j];
                    ind = j;
                }
            }

            if (ind != -1)
            {
                for (int p = ind; p > 0; p--)
                {
                    B[i, p] = B[i, p - 1];
                }
                B[i, 0] = minValue;
            }
        }
        // end
        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

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
        int AHeight = F.GetLength(0), AWeight = F.GetLength(1);

        for (int i = 0; i < AHeight; i++)
        {

            double maxValue = F[i, 0], firstDif = 0, lastDif = 0;
            int indMax = 0;
            for (int j = 0; j < AWeight; j++)
            {
                if (F[i, j] > maxValue)
                {
                    maxValue = F[i, j];
                    indMax = j;
                }

                if (F[i, j] < 0 && firstDif == 0)
                    firstDif = F[i, j];

                if (F[i, j] < 0 && firstDif != 0)
                    lastDif = F[i, j];
            }

            if (firstDif != 0 || lastDif != 0)
                F[i, indMax] = (lastDif + firstDif) / 2;
        }
        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

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
        int AHeight = G.GetLength(0), AWeight = G.GetLength(1);

        if (AHeight < 3)
            return default(int[,]);

        for (int i = 0; i < AHeight; i++)
        {
            int maxValue = G[i, 0], indMax = 0;
            for (int j = 0; j < AWeight; j++)
            {
                if (G[i, j] > maxValue)
                {
                    maxValue = G[i, j];
                    indMax = j;
                }
            }
            if (indMax == AWeight - 2)
                G[i, AWeight - 1] = maxValue;
            else
            {
                for (int k = AWeight - 1; k > indMax; k--)
                {
                    G[i, k] = G[i, k - 1];
                }
            }
        }
        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1), vectorLenght = B.Length;
        int column = 6 - 1;

        if (AHeight < 3 || AWeight != vectorLenght)
            return default(int[,]);

        int maxValue = A[0, column];
        int delString = 0;



        for (int i = 0; i < AHeight; i++)
        {
            if (A[i, column] > maxValue)
            {
                maxValue = A[i, column];
                delString = i;
            }
        }

        for (int j = 0; j < AWeight; j++)
        {
            A[delString, j] = B[j];
        }
        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

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
        int AHeight = F.GetLength(0), AWeight = F.GetLength(1);

        if (AHeight < 3)
            return default(int[,]);

        int minValue = F[1, 0];
        int delColumn = 0;

        for (int j = 0; j < AWeight; j++)
        {
            if (Math.Abs(F[1, j]) < minValue)
            {
                minValue = F[1, j];
                delColumn = j;
            }
        }

        delColumn++;

        int[,] G = new int[AHeight, AWeight - 1];
        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight - 1; j++)
            {
                if (j < delColumn)
                    G[i, j] = F[i, j];
                else
                    G[i, j] = F[i, j + 1];
            }
        }
        F = G;
        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(double[,]);

        for (int i = 0; i < AHeight; i++)
        {
            int indMax = 0, countPos = 0;
            double maxValue = A[i, 0], sumPos = 0, avg = 0;
            for (int j = 0; j < AWeight; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    indMax = j;
                }

                if (A[i, j] > 0)
                {
                    countPos++;
                    sumPos += A[i, j];
                }

                if (countPos != 0)
                    avg = sumPos / countPos;
            }

            A[i, indMax] = avg;
        }
        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(double[,]);

        for (int i = 0; i < AHeight; i++)
        {
            double maxValue = A[i, 0];
            int indMax = 0;
            for (int j = 0; j < AWeight; j++)
            {
                if (A[i, j] > maxValue)
                {
                    indMax = j;
                    maxValue = A[i, j];
                }
            }

            if (indMax == 0)
                A[i, indMax + 1] *= 2;
            else if (indMax == AWeight - 1)
                A[i, indMax - 1] *= 2;
            else
            {
                if (A[i, indMax + 1] < A[i, indMax - 1])
                {
                    if (A[i, indMax + 1] > 0)
                        A[i, indMax + 1] *= 2;
                    else
                        A[i, indMax + 1] /= 2;
                }
                else
                {
                    if (A[i, indMax - 1] > 0)
                        A[i, indMax - 1] *= 2;
                    else
                        A[i, indMax - 1] /= 2;
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
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(int[,]);

        for (int j = 0; j < AWeight; j++)
        {
            int countPos = 0, countDif = 0;
            int maxValue = A[0, j], indMax = 0;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    indMax = i;
                }

                if (A[i, j] > 0)
                    countPos++;
                else if (A[i, j] != 0)
                    countDif++;
            }

            if (countPos > countDif)
                A[indMax, j] = 0;
            else
                A[indMax, j] = indMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(int[,]);


        for (int j = 0; j < AWeight; j++)
        {
            int maxValue = A[0, j], indMax = 0;
            int sum = 0;
            for (int i = 0; i < AHeight; i++)
            {
                sum += A[i, j];

                if (A[i, j] > maxValue)
                {
                    indMax = i;
                    maxValue = A[i, j];
                    sum = 0;
                }
            }

            if (indMax <= AHeight / 2)
                A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1), BLenght = B.Length;

        if (AHeight < 3 || BLenght != AWeight)
            return default(int[,]);

        for (int j = 0; j < AWeight; j++)
        {
            int maxValue = A[0, j], indMax = 0;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    indMax = i;
                }
            }

            if (A[indMax, j] < B[j])
                A[indMax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(double[,]);

        for (int j = 0; j < AWeight; j++)
        {
            double maxValue = A[0, j];
            int indMax = 0;
            double sum = (A[0, j] + A[AHeight - 1, j]) / 2;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    indMax = i;
                    maxValue = A[i, j];
                }
            }

            if (maxValue < sum)
                A[indMax, j] = sum;
            else
                A[indMax, j] = indMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3)
            return answer;

        int[,] A = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    A[i, j] = 1;
                else
                    A[i, j] = 0;
            }
        }
        answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3 || AHeight != AWeight)
            return default(int[,]);

        int maxValue = A[0, 0], iMax = 0;
        for (int i = 0; i < AHeight; i++)
        {
            if (A[i, i] > maxValue)
            {
                iMax = i;
                maxValue = A[i, i];
            }
        }

        for (int i = 0; i < iMax; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (j > i)
                    A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int BHeight = B.GetLength(0), BWeight = B.GetLength(1);

        if (BHeight < 3)
            return default(int[,]);

        for (int i = 0; i < BHeight; i += 2)
        {
            int maxValue1 = B[i, 0], maxValue2 = B[i + 1, 0];
            int indMax1 = 0, indMax2 = 0;
            for (int j = 0; j < BWeight; j++)
            {
                if (B[i, j] > maxValue1)
                {
                    indMax1 = j;
                    maxValue1 = B[i, j];
                }

                if (B[i + 1, j] > maxValue2)
                {
                    indMax2 = j;
                    maxValue2 = B[i + 1, j];
                }
            }

            B[i, indMax1] = maxValue2;
            B[i + 1, indMax2] = maxValue1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight != 6 && AWeight != 7)
            return default(int[,]);

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, AWeight - j - 1];
                A[i, AWeight - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != 7 && AWeight != 5)
            return default(int[,]);

        int[] minVal = new int[AHeight];
        int[] minValInd = new int[AHeight];


        for (int i = 0; i < AHeight; i++)
        {
            int minElem = matrix[i, 0];
            minValInd[i] = i;

            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] < minElem)
                    minElem = matrix[i, j];
            }
            minVal[i] = minElem;
        }


        for (int i = 1; i < AHeight; i++)
        {
            int key = minVal[i];
            int iKey = minValInd[i];
            int j = i - 1;
            while (j >= 0 && minVal[j] < key)
            {
                minVal[j + 1] = minVal[j];
                minValInd[j + 1] = minValInd[j];
                j -= 1;
            }
            minVal[j + 1] = key;
            minValInd[j + 1] = iKey;
        }


        int[,] sortedMatrix = new int[AHeight, AWeight];
        for (int i = 0; i < AHeight; i++)
        {
            int originalRowInd = minValInd[i];
            for (int j = 0; j < AWeight; j++)
            {
                sortedMatrix[i, j] = matrix[originalRowInd, j];
            }
        }
        matrix = sortedMatrix;
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight)
            return default(int[,]);

        for (int i = 0; i < AHeight; i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, AHeight - 1] = 0;
            matrix[AHeight - 1, i] = 0;
        }
        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight || AHeight < 3)
            return answer;

        answer = new int[AHeight * 2 - 1];

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AHeight; j++)
            {
                int ind = j - i + AHeight - 1;
                answer[ind] += matrix[i, j];
            }
        }
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight)
            return default(int[,]);

        for (int i = AHeight / 2; i < AHeight; i++)
        {
            for (int j = i / AHeight; j <= i; j++)
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
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight || AHeight < 3)
            return default(int[,]);

        int maxVal = matrix[0, 0];
        int indI = -1, indJ = -1;
        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AHeight; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(maxVal))
                {
                    maxVal = matrix[i, j];
                    indI = i;
                    indJ = j;
                }
            }
        }
        if (indJ != k - 1)
        {
            for (int i = 0; i < AHeight; i++)
            {
                int temp = matrix[i, indJ];
                matrix[i, indJ] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        if (indI != k - 1)
        {
            for (int j = 0; j < AHeight; j++)
            {
                int temp = matrix[indI, j];
                matrix[indI, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight)
            return (null, null);

        upper = new int[AHeight * (AHeight + 1) / 2];
        lower = new int[(AHeight * (AHeight + 1) / 2) - AHeight];

        int cnt1 = 0, cnt2 = 0;
        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AHeight; j++)
            {
                if (i <= j)
                {
                    upper[cnt1] = matrix[i, j];
                    cnt1++;
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
        int lenghtA = A.Length, lenghtB = B.Length;

        if (lenghtA < 2 || lenghtB < 2)
            return answer;

        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];

        int ind = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[ind];
                matrixA[j, i] = A[ind];

                matrixB[i, j] = B[ind];
                matrixB[j, i] = B[ind];

                ind++;
            }
        }

        int[] matrixC = new int[n * n];

        int indc = 0;
        for (int col = 0; col < n; col++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matrixC[indc] += matrixA[i, j] * matrixB[j, col];
                }
                indc++;
            }

        }

        // int[] C = new int [n * n];


        answer = matrixC;

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != 7 && AWeight != 5)
            return default(int[,]);

        int[] countPos = new int[AHeight];

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] > 0)
                {
                    countPos[i]++;
                }
            }
        }

        int maxVal = countPos[0], maxInd = 0;
        for (int i = 0; i < AHeight; i++)
        {
            if (countPos[i] > maxVal)
            {
                maxVal = countPos[i];
                maxInd = i;
            }
        }

        for (int i = 0; i < AHeight - 1; i++)
        {
            for (int j = 0; j < AHeight - i - 1; j++)
            {
                if (countPos[j] < countPos[j + 1])
                {
                    for (int k = 0; k < 5; k++)
                    {
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
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0), columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - j - 1; k++)
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
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight < 2)
            return default(int[,]);

        int nonZeroRowsCount = 0;
        for (int i = 0; i < AHeight; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (hasZero == false)
                nonZeroRowsCount++;
        }

        int[,] filteredMatrix = new int[nonZeroRowsCount, AWeight];
        int currentRow = 0;

        for (int i = 0; i < AHeight; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (hasZero == false)
            {
                for (int j = 0; j < AWeight; j++)
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
