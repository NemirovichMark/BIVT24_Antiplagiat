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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        double summma = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    summma = summma + A[i, j];
                    count++;
                }
            }
        if (count == 0)
        {
            return 0;
        }
        answer = summma / count;

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

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
        int v = 0, Index = -1;
        // code here
        int k = A.GetLength(0);
        for (int i = 0; i < k; i++)

        {
            if (A[i, colIndex] < 0)
            {
                v = A[i, colIndex];
                Index = i;
                break;
            }
        }
        if (v == 0) Index = 0;

        // end

        return (v, Index);
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 4 || m != 6) return answer;
        answer = new double[n];
        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            if (count > 0) answer[i] = Math.Round(sum / count, 2);

            else answer[i] = 0;

        }

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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        double small = A[0, 0];
        int Index = 0;

        for (int k = 1; k < A.GetLength(0); k++)
        {
            if (A[k, 0] < small)
            {
                small = A[k, 0];
                Index = k;
            }
        }

        n = A.GetLength(0) - 1;
        m = A.GetLength(1);
        int[,] Matrix = new int[n, m];

        for (int k = 0, newRow = 0; k < A.GetLength(0); k++)
        {
            if (k == Index) continue;


            for (int col = 0; col < m; col++)
                Matrix[newRow, col] = A[k, col];


            newRow++;
        }
        A = Matrix;


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
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        if (n != 4 || m != 3) return answer;



        answer = new int[m];

        for (int j = 0; j < m; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0) count++;

            }
            answer[j] = count;
        }
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
        for (int i = 0; i < n; i++)
        {
            int min = B[i, 0];
            int min_i = 0;

            for (int j = 1; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    min_i = j;
                }
            }

            if (min_i != 0)
            {
                for (int j = min_i; j > 0; j--)
                {
                    B[i, j] = B[i, j - 1];
                }
                B[i, 0] = min;
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
        for (int i = 0; i < n; i++)
        {
            double max = F[i, 0];
            int max_i = 0;
            double first = 0;
            double last = 0;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    max_i = j;
                }

                if (F[i, j] < 0)
                {
                    if (first == 0)
                        first = F[i, j];
                    last = F[i, j];
                }
            }
            if (first != 0 && last != 0)
            {
                F[i, max_i] = (first + last) / 2;
            }
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
        int m = G.GetLength(0);
        int n = G.GetLength(1);
        if (n != 7 || m != 5)
        {
            return default(int[,]);
        }

        for (int i = 0; i < m; i++)
        {
            int max_i = 0;
            for (int j = 1; j < n; j++)
            {
                if (G[i, j] > G[i, max_i])
                {
                    max_i = j;
                }
            }

            for (int j = n - 2; j >= max_i; j--)
            {
                G[i, j + 1] = G[i, j];
            }

            G[i, max_i + 1] = G[i, max_i];
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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 7)
        {
            return default(int[,]);
        }

        int max_i = -1;
        int max = A[0, 5];

        for (int i = 0; i < m; i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                max_i = i;
            }
        }

        if (max_i != -1)
        {
            for (int j = 0; j < n; j++)
            {
                A[max_i, j] = B[j];
            }
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
        int n = F.GetLength(0);
        int m = F.GetLength(1);

        if (n != 5 || m != 7)
            return null;

        int min_i = 0;
        int min = Math.Abs(F[1, 0]);

        for (int i = 1; i < m; i++)
        {
            int rez = Math.Abs(F[1, i]);
            if (rez < min)
            {
                min = rez;
                min_i = i;
            }
        }

        int Delete = min_i + 1;
        if (Delete >= m)
            return F;


        int[,] newMatrix = new int[n, m - 1];

        for (int row = 0; row < n; row++)
        {
            int targetCol = 0;
            for (int col = 0; col < m; col++)
            {
                if (col != Delete)
                {
                    newMatrix[row, targetCol] = F[row, col];
                    targetCol++;
                }
            }
        }
        F = newMatrix;

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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || n != 5 || m != 7)
            return null;


        for (int row = 0; row < n; row++)
        {
            double max = A[row, 0];
            int maxI = 0;
            double posSum = 0;
            int posCount = 0;

            for (int col = 0; col < m; col++)
            {

                if (A[row, col] > max)
                {
                    max = A[row, col];
                    maxI = col;
                }

                if (A[row, col] > 0)
                {
                    posSum += A[row, col];
                    posCount++;
                }
            }

            double positiveAverage = posCount > 0 ? posSum / posCount : 0;

            A[row, maxI] = positiveAverage;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        if (A == null || n != 5 || m != 7) return null;

        for (int row = 0; row < A.GetLength(0); row++)
        {
            double maximum = double.MinValue;
            int maxIndex = 0;

            for (int col = 0; col < A.GetLength(1); col++)
            {
                if (A[row, col] > maximum)
                {
                    maximum = A[row, col];
                    maxIndex = col;
                }
            }

            if (maxIndex > 0 && maxIndex < A.GetLength(1) - 1)
            {
                if (A[row, maxIndex - 1] < A[row, maxIndex + 1])
                {
                    if (A[row, maxIndex - 1] < 0) A[row, maxIndex - 1] /= 2;

                    else A[row, maxIndex - 1] *= 2;



                }
                else
                {
                    if (A[row, maxIndex + 1] < 0) A[row, maxIndex + 1] /= 2;

                    else A[row, maxIndex + 1] *= 2;

                }
            }
            else
            {
                if (maxIndex == 0)
                {
                    if (A[row, maxIndex + 1] > 0)
                    {
                        A[row, maxIndex + 1] *= 2;
                    }
                    else
                    {
                        A[row, maxIndex + 1] /= 2;
                    }
                }
                else
                {
                    if (A[row, maxIndex - 1] > 0)
                    {
                        A[row, maxIndex - 1] *= 2;
                    }
                    else
                    {
                        A[row, maxIndex - 1] /= 2;
                    }
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        for (int column = 0; column < m; column++)
        {
            int pos = 0, neg = 0, maxIndex = 0;

            for (int row = 0; row < n; row++)
            {
                int currentElement = A[row, column];

                if (currentElement > 0)
                {
                    pos++;
                }
                else if (currentElement < 0)
                {
                    neg++;
                }

                if (currentElement > A[maxIndex, column])
                {
                    maxIndex = row;
                }
            }

            bool morePositives = pos > neg;
            A[maxIndex, column] = morePositives ? 0 : maxIndex + 1;
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return null;

        for (int col = 0; col < m; col++)
        {
            int maxE = 0;
            int maxElement = A[0, col];

            for (int row = 1; row < n; row++)
            {
                if (A[row, col] > maxElement)
                {
                    maxElement = A[row, col];
                    maxE = row;
                }
            }

            if (maxE < n / 2)
            {
                int sum = 0;
                for (int row = maxE + 1; row < n; row++)
                {
                    sum += A[row, col];
                }
                A[0, col] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != m) return null;

        for (int i = 0; i < m; i++)
        {
            int maxE = A[0, i];
            int max_r = 0;

            for (int row = 1; row < n; row++)
            {
                if (A[row, i] > maxE)
                {
                    maxE = A[row, i];
                    max_r = row;
                }
            }


            if (B[i] > maxE) A[max_r, i] = B[i];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        for (int i = 0; i < m; i++)
        {
            double maxE = A[0, i];
            int max_Row = 0;


            for (int row = 1; row < n; row++)
            {
                if (A[row, i] > maxE)
                {
                    maxE = A[row, i];
                    max_Row = row;
                }
            }

            double halfSum = (A[0, i] + A[n - 1, i]) / 2.0;

            if (maxE < halfSum) A[max_Row, i] = halfSum;

            else A[max_Row, i] = max_Row + 1;

        }



        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
            return null;

        int[,] rezult = new int[n, 3 * n];

        for (int i = 0; i < n; i++)
        {
            rezult[i, i] = 1;
            rezult[i, i + n] = 1;
            rezult[i, i + 2 * n] = 1;
        }
        answer = rezult;

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || n != 6)
            return null;
        int maxE = int.MinValue;
        int maxRow = -1;

        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > maxE)
            {
                maxE = A[i, i];
                maxRow = i;
            }
        }

        for (int i = 0; i < maxRow; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                A[i, j] = 0;
            }
        }



        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0);
        int m = B.GetLength(1);

        if (n != 6 || m != 6)
            return null;

        for (int i = 0; i < 6; i += 2)
        {
            (int row1, int col1) = (i, 0);
            (int row2, int col2) = (i + 1, 0);

            for (int j = 1; j < m; j++)
            {
                if (B[i, j] > B[row1, col1])
                {
                    col1 = j;
                }
            }

            for (int j = 1; j < m; j++)
            {
                if (B[i + 1, j] > B[row2, col2])
                {
                    col2 = j;
                }
            }

            (B[row1, col1], B[row2, col2]) = (B[row2, col2], B[row1, col1]);

        }



        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int s = A.GetLength(0);
        int k = A.GetLength(1);
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for (int l = 0; l < s; l++)
        {
            for (int j = 0; j < k / 2; j++)
            {
                (A[l, j], A[l, k - j - 1]) = (A[l, k - j - 1], A[l, j]);
            }
        }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here


        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);

        if (n != matrix.GetLength(1))
            return null;

        for (int i = 0; i < n; i++)
        {
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
            matrix[0, i] = 0;
            matrix[n - 1, i] = 0;
        }



        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);

        if (n != matrix.GetLength(1))
            return null;
        for (int k = n / 2; k < n; k++)
            for (int l = 0; l <= k; l++)
                matrix[k, l] = 1;




        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (n != m) return (null, null);

        int upperCount = (n * (n + 1)) / 2;
        int lowerCount = (n * (n - 1)) / 2;

        upper = new int[upperCount];
        lower = new int[lowerCount];

        int upperIndex = 0;
        int lowerIndex = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                upper[upperIndex++] = matrix[i, j];
            }
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[lowerIndex++] = matrix[i, j];
            }
        }

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != 7 || m != 5) return null;

        int[] pos = new int[n]; 
        int[] rowIndices = new int[n];  

        for (int i = 0; i < n; i++)
        {
            rowIndices[i] = i;
        }

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                    count++;
            }
            pos[i] = count;
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (pos[j] < pos[j + 1])
                {
                    (pos[j], pos[j + 1]) = (pos[j + 1], pos[j]);
                    (rowIndices[j], rowIndices[j + 1]) = (rowIndices[j + 1], rowIndices[j]);
                }
            }
        }
        int[,] result = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int rowIndex = rowIndices[i];
            for (int j = 0; j < m; j++)
            {
                result[i, j] = matrix[rowIndex, j];
            }
        }

        // end
        matrix = result;

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (n == 0 || m == 0) return matrix;

        for (int i = 0; i < n; i++)
            if (i % 2 == 0)
            {
                for (int j = 0; j < m - 1; j++)
                    for (int k = 0; k < m - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
            }
            else
            {
                for (int j = 0; j < m - 1; j++)
                    for (int k = 0; k < m - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
            }





        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix == null) return null;

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int Count = 0;
        for (int i = 0; i < n; i++)
        {
            bool zero = false;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if (!zero) Count++;
        }


        if (Count == 0) return new int[0, 0];

        int[,] newMatrix = new int[Count, m];
        int Index = 0;

        for (int i = 0; i < n; i++)
        {
            bool Zero = false;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    Zero = true;
                    break;
                }
            }

            if (!Zero)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[Index, j] = matrix[i, j];
                }
                Index++;
            }
        }
        matrix = newMatrix;

        // end

        return matrix;
    }
    #endregion
}