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
        double s = 0;
        double count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;            
                }
            }
        }
        if (count > 0)
        {
            answer = s / count;
        }
        else return 0;
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
        int value = 0, rowIndex = -1;
        // code here
        if (colIndex < 0 || colIndex >= A.GetLength(1))
        {
            return (0, -1);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                return (value, rowIndex);
            }
        }
        return (0, 0);
        // end
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
        answer = new double[A.GetLength(0)];
        if (A.GetLength(0) == 4 || A.GetLength(1) == 6)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double s = 0;
                int count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        s += A[i, j];
                        count++;
                    }
                }
                if (count > 0)
                    answer[i] = s / count;
                else
                    answer[i] = 0;

            }
        }
        else return null;
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
        int indexmin = 0;
        double min = double.MaxValue;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, 0] < min)
                {
                    min = A[i, 0];
                    indexmin = i;
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < indexmin; i++)
                {
                    B[i, j] = A[i, j];
                }
                for (int i = indexmin + 1; i < A.GetLength(0); i++)
                {
                    B[i - 1, j] = A[i, j];
                }
            }
            min = double.MaxValue;
            indexmin = 0;
            return B;
        }
        else
            return null;
        // end
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
        answer = new int[A.GetLength(1)];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
            return null;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] < 0)
                        answer[j]++;
                }
            }
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
            int indexmin = 0;
            int min = B[i, 0];
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    indexmin = j;
                }
            }
            if (indexmin != 0)
            {
                int temp = B[i, indexmin];
                for (int j = indexmin; j > 0; j--)
                {
                    B[i, j] = B[i, j - 1];
                }
                B[i, 0] = temp;
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
            int indexmax = 0;
            double max = F[i, 0];
            int first = -1;
            int last = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    indexmax = j;
                }
                if (F[i, j] < 0)
                {
                    if (first == -1)
                    {
                        first = j; 
                    }
                    last = j; 
                }
            }
            if (first != -1 && last != -1)
            {
                double s = (F[i, first] + F[i, last]) / 2;
                F[i, indexmax] = s;
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
        if ((G.GetLength(0) == 5) || (G.GetLength(1) == 7))
        {
            for (int i = 0; i < G.GetLength(0); i++)
            {
                int indexmax = -1;
                int max = -100;
                for (int j = 0; j < G.GetLength(1); j++)
                {
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        indexmax = j;
                    }
                }
                for (int j = G.GetLength(1) - 1; j > indexmax; j--)
                {
                    G[i, j] = G[i, j - 1];
                }
            }
        }
        else return null;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = -100;
            int maxindex = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            if (maxindex == 3)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = B[j];
                }
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
        int min = 100;
        int minindex = -1;
        int[,] newF = new int[F.GetLength(0), F.GetLength(1) - 1];
        if (F == null || F.GetLength(0) != 5 || F.GetLength(1) != 7)
        {
            return null;
        }
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[2, j]) < min)
            {
                min = F[2, j];
                minindex = j;
            }
        }
        minindex += 1;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < minindex; j++)
            {
                newF[i, j] = F[i, j];
            }
            for (int j = minindex + 1; j < F.GetLength(1); j++)
            {
                newF[i, j - 1] = F[i, j];
            }
        }
        F = newF;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int maxindex = -1;
            double avg;
            double s = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count += 1;
                }
            }
            if (maxindex != -1 && count != 0)
            {
                avg = s / count;
                A[i, maxindex] = avg;
            }
            else if (count == 0)
            {
                A[i, maxindex] = 0;
            }
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = -1000;
            int indexmax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexmax = j;
                }
            }
            if (indexmax != 0 && indexmax != A.GetLength(0) - 1)
            {
                if (A[i, indexmax - 1] < A[i, indexmax + 1])
                {
                    if (A[i, indexmax - 1] < 0)
                    {
                        A[i, indexmax - 1] /= 2;
                    }
                    else A[i, indexmax - 1] *= 2;
                }
                else
                {
                    if (A[i, indexmax + 1] < 0)
                    {
                        A[i, indexmax + 1] /= 2;
                    }
                    else A[i, indexmax + 1] *= 2;
                }
            }
            else
            {
                if (indexmax == 0)
                {
                    if (A[i, indexmax + 1] > 0) A[i, indexmax + 1] *= 2;
                    else A[i, indexmax + 1] /= 2;
                }
                else
                {
                    if (A[i, indexmax - 1] > 0) A[i, indexmax - 1] *= 2;
                    else A[i, indexmax - 1] /= 2;
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
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int countPol = 0;
            int countOtr = 0;
            int max = -100;
            int indexmax = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) countPol++;
                else if (A[i, j] < 0) countOtr++;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexmax = i;
                }
            }
            if (countOtr < countPol)
            {
                A[indexmax, j] = 0;
            }
            else A[indexmax, j] = indexmax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indexmax = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indexmax, j])
                {
                    indexmax = i;
                    sum = 0;
                }
                else
                {
                    sum += A[i, j];
                }
            }
            if (indexmax < 5) A[0, j] = sum;

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indexmax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indexmax, j])
                    indexmax = i;
            }
            if (B[j] > A[indexmax, j]) A[indexmax, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = -100;
            int indexmax = 0;
            double sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    indexmax = i;
                    max = A[i, j];
                }
            }
            if (max < sum)
                A[indexmax, j] = sum;
            else
                A[indexmax, j] = indexmax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, n * 3];
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            answer[i, i] = 1;
            answer[i, i + answer.GetLength(0)] = 1;
            answer[i, i + 2 * answer.GetLength(0)] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = -1000, indexmax = -1;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[j, j] > max)
            {
                max = A[j, j];
                indexmax = j;
            }
        }
        if (indexmax == -1) return null;
        for (int i = 0; i < indexmax; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int indexmax1 = -1, indexmax2 = -1;
        for (int i = 0; i < 6; i += 2)
        {
            int max1 = -100, max2 = -100, temp = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > max1)
                {
                    indexmax1 = j;
                    max1 = B[i, j];
                }
            }
            for (int j = 0; j < 6; j++)
            {
                if (B[i + 1, j] > max2)
                {
                    indexmax2 = j;
                    max2 = B[i + 1, j];
                }
            }
            temp = B[i, indexmax1];
            B[i, indexmax1] = B[i + 1, indexmax2];
            B[i + 1, indexmax2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int k;
        int[] s;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            k = 6;
            s = new int[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j += 1)
            {
                s[j] = A[i, k];
                k--;
            }
            for (int j = 0; j < A.GetLength(1); j += 1)
            {
                A[i, j] = s[j];
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 3) return null;
        int x1 = 0, x2 = matrix.GetLength(0) - 1, y1 = 0, y2 = matrix.GetLength(0) - 1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[j - x1, j] = 0;
            matrix[j + x2, j] = 0;
            matrix[j, j - y1] = 0;
            matrix[j, j + y2] = 0;
            x1++;
            x2--;
            y1++;
            y2--;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 3) return null;
        for (int i = (int)(matrix.GetLength(0) / 2); i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i + 1; j++)
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

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1)) return default;
        int k1 = 0;
        int k2 = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j) k1++;
                else k2++;
            }
        }
        upper = new int[k1];
        int upper_index = 0;
        lower = new int[k2];
        int lower_index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j)
                {
                    upper[upper_index] = matrix[i, j];
                    upper_index++;
                }
                else
                {
                    lower[lower_index] = matrix[i, j];
                    lower_index++;
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

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] pos = new int[7];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    pos[i]++;
                }
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int count = pos[i];
            int[] array = new int[5];
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                array[k] = matrix[i, k];
            }
            int j = i - 1;
            while (j >= 0 && pos[j] < count)
            {
                pos[j + 1] = pos[j];
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j + 1, k] = matrix[j, k];
                }
                j--;
            }
            pos[j + 1] = count;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[j + 1, k] = array[k];
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - c - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
                    }
                }
            }
            else
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - c - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
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
        int k = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] == 0)
                {
                    k--;
                    matrix[i, 0] = 0;
                    break;
                }

            }
        }
        int[,] A = new int[k, matrix.GetLength(1)];
        int n = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, 0] != 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    A[n, j] = matrix[i, j];
                }
                n++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}