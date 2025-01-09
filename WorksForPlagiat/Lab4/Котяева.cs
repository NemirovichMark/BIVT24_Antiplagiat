using System;
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
        //2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 
        int p = 0;
        int nom = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    nom = A[i, j];
                    if (nom > 0)
                    {
                        p++;
                        answer += A[i, j];
                    }
                }

            }
            answer = answer / p;
        }
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
        if ((A.GetLength(0) == 5) && (colIndex <= 4))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, colIndex] < 0)
                {
                    value = A[i, colIndex];
                    rowIndex = i;
                    break;
                }
            }
        }
        // end
        if (rowIndex == -1)
        {
            value = 0;
            rowIndex = 0;
        }
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
        double[] answer = new double[A.GetLength(0)];
        // code here
        double a = 0;
        double summ = 0;
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (A[i, j] > 0)
                    {
                        a++;
                        summ += A[i, j];
                    }
                }
                if (a != 0)
                    summ = Math.Round(summ / a, 2);
                else
                    summ = 0;
                a = 0;

                answer[i] = summ;
                summ = 0;
            }
        }
        else
        {
            answer = null;
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
        int[,] B = new int[4, 7];
        int nom = 0;
        double min = double.MaxValue;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 0] < min)
                {
                    min = A[i, 0];
                    nom = i;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < nom; i++)
                {
                    B[i, j] = A[i, j];
                }
                for (int i = nom + 1; i < 5; i++)
                {
                    B[i - 1, j] = A[i, j];
                }
            }
            min = double.MaxValue;
            nom = 0;
        }
        else
            B = null;

        // end

        return B;
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
        int[] answer = new int[A.GetLength(1)];
        // code here
        int nom = 0;
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 3))
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[j, i] < 0)
                    {
                        nom++;
                    }
                }
                answer[i] = nom;
                nom = 0;
            }
        }
        else
        {
            answer = null;
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
        int r = B.GetLength(0);
        int c = B.GetLength(1);

        if (r != n || c != m)
            return null;

        int minElement,
            minElementIndex;

        for (int row = 0; row < r; row++)
        {
            minElement = int.MaxValue;
            minElementIndex = -1;
            for (int col = 0; col < c; col++)
            {
                if (B[row, col] >= minElement)
                    continue;
                minElement = B[row, col];
                minElementIndex = col;
            }

            for (int col = c - 1; col >= 0; col--)
            {
                if (col == 0)
                    continue;
                if (col <= minElementIndex)
                    B[row, col] = B[row, col - 1];
            }
            B[row, 0] = minElement;
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
        int r = F.GetLength(0);
        int c = F.GetLength(1);

        if (r != n || c != m)
            return null;

        double maxElement;
        int maxElementCol;
        int firstNegativeCol,
            lastNegativeCol;

        for (int j = 0; j < r; j++)
        {
            maxElement = double.MinValue;
            maxElementCol = -1;
            firstNegativeCol = -1;
            lastNegativeCol = -1;

            for (int i = 0; i < c; i++)
            {
                if (F[j, i] <= maxElement)
                    continue;
                maxElement = F[j, i];
                maxElementCol = i;
            }

            for (int i = 0; i < c; i++)
            {
                if (F[j, i] < 0)
                    lastNegativeCol = i;
            }

            for (int i = c - 1; i >= 0; i--)
            {
                if (F[j, i] < 0)
                    firstNegativeCol = i;
            }

            if (firstNegativeCol == -1 || lastNegativeCol == -1)
                continue;

            F[j, maxElementCol] = (F[j, firstNegativeCol] + F[j, lastNegativeCol]) / 2.0;
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
        int r = G.GetLength(0);
        int c = G.GetLength(1);

        if (r != 5 || c != 7)
            return null;

        int maxElement,
            maxElementCol;

        for (int j = 0; j < r; j++)
        {
            maxElement = int.MinValue;
            maxElementCol = -1;
            for (int i = 0; i < c; i++)
            {
                if (G[j, i] > maxElement)
                {
                    maxElement = G[j, i];
                    maxElementCol = i;
                }
            }

            for (int col = c - 1; col > maxElementCol; col--)
            {
                G[j, col] = G[j, col - 1];
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
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        int b = B.GetLength(0);

        if (r != 5 || c != 7)
            return null;
        if (b != c)
            return null;

        int maxElementInSixthCol = int.MinValue;
        int rowToReplace = 0;

        for (int j = 0; j < r; j++)
        {
            if (A[j, 5] <= maxElementInSixthCol)
                continue;
            maxElementInSixthCol = A[j, 5];
            rowToReplace = j;
        }

        for (int i = 0; i < c; i++)
        {
            A[rowToReplace, i] = B[i];
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
        int r = F.GetLength(0);
        int c = F.GetLength(1);

        if (r != 5 || c != 7)
            return null;

        int[,] R = new int[5, 6];
        int minAbsElementInSecondRow = int.MaxValue;
        int colToRemove = 0;

        for (int i = 0; i < c; i++)
        {
            if (Math.Abs(F[1, i]) >= minAbsElementInSecondRow)
                continue;
            minAbsElementInSecondRow = Math.Abs(F[1, i]);
            colToRemove = i + 1;
        }

        if (colToRemove > 6)
            return null;

        for (int j = 0; j < r; j++)
        {
            for (int i = 0; i < c; i++)
            {
                if (i < colToRemove)
                    R[j, i] = F[j, i];
                if (i > colToRemove)
                    R[j, i - 1] = F[j, i];
            }
        }
        // end

        return R;
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
        int r = A.GetLength(0);
        int c = A.GetLength(1);

        if (r != 5 || c != 7)
            return null;

        double maxElement;
        int maxElementCol;
        int positiveCount;
        double cumSum;

        for (int j = 0; j< r; j++)
        {
            maxElement = double.MinValue;
            maxElementCol = 0;
            positiveCount = 0;
            cumSum = 0.0;

            for (int i = 0; i < c; i++)
            {
                if (A[j, i] <= maxElement)
                    continue;
                maxElement = A[j, i];
                maxElementCol = i;
            }

            for (int i = 0; i < c; i++)
            {
                if (A[j, i] <= 0)
                    continue;
                positiveCount++;
                cumSum += A[j, i];
            }

            if (positiveCount != 0)
                A[j, maxElementCol] = cumSum / positiveCount;
            else
                A[j, maxElementCol] = 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[] mx_ind = new int[5];
        double[] mx0 = new double[5];
        double mx; int col = -1;
        for (int i = 0; i < 5; i++)
        {
            mx = Double.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    col = j;
                }
            }
            mx0[i] = mx;
            mx_ind[i] = col;
            double k = 0;
            if (col == 0 || A[i, col + 1] < A[i, col - 1])
            {
                k = A[i, col + 1] > 0 ? 2 : 0.5;
                A[i, col + 1] *= k;
            }
            else
            {
                k = A[i, col - 1] > 0 ? 2 : 0.5;
                A[i, col - 1] *= k;
            }
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int mx = int.MinValue, mx_ind = 0, neg = 0, pos = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0)
                {
                    pos++;
                }
                else
                {
                    neg++;
                }
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    mx_ind = i;
                }
            }
            if (pos > neg)
            {
                A[mx_ind, j] = 0;
            }
            else
            {
                A[mx_ind, j] = mx_ind+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int mx = int.MinValue, mx_ind = -1;
            for (int i = 0; i < 10; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    mx_ind = i;
                }
            }
            if (mx_ind < 5)
            {
                int s = 0;
                for (int i = mx_ind + 1; i < 10; i++)
                {
                    s += A[i, j];
                }
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        for (int j = 0; j < 5; j++)
        {
            int mx = int.MinValue, mx_ind = 0;
            for (int i = 0; i < 7; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    mx_ind = i;
                }
            }
            if (B[j] > mx)
            {
                A[mx_ind, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        double s;
        for (int j = 0; j < 5; j++)
        {
            double mx = double.MinValue;
            int mx_ind = 0;
            s = (A[0, j] + A[6, j]) / 2;
            for (int i = 0; i < 7; i++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    mx_ind = i;
                }
            }
            if (mx < s)
            {
                A[mx_ind, j] = s;
            }
            else
            {
                A[mx_ind, j] = mx_ind+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) { return null; }
        int[,] A = new int[n, 3 * n];
        int k = 2;
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < 3 * n; y++)
            {
                A[x, y] = ((y + k) % 3) / 2;
            }
            k--;
        }
        answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 6) return null;
        int ma = -9999, i = -1;
        for (int j = 0; j < 6; j++)
        {
            if (A[j, j] > ma)
            {
                ma = A[j, j];
                i = j;
            }
        }
        if (i == -1) return null;
        for (int x = 0; x < i; x++)
        {
            for (int y = x + 1; y < 6; y++)
            {
                A[x, y] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (6 != B.GetLength(0) || 6 != B.GetLength(1)) return null;
        int i1 = -1, i2 = -1;
        for (int x = 0; x < 6; x += 2)
        {
            int ma1 = -9999, ma2 = -9999, o = 0;
            for (int y = 0; y < 6; y += 1)
            {
                if (B[x, y] > ma1)
                {
                    i1 = y;
                    ma1 = B[x, y];
                }
            }
            for (int j = 0; j < 6; j += 1)
            {
                if (B[x + 1, j] > ma2)
                {
                    i2 = j;
                    ma2 = B[x + 1, j];
                }
            }
            o = B[x, i1];
            B[x, i1] = B[x + 1, i2];
            B[x + 1, i2] = o;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (6 != A.GetLength(0) || 7 != A.GetLength(1)) return null;
        int k;
        int[] s;
        for (int x = 0; x < 6; x++)
        {
            k = 6;
            s = new int[7];
            for (int y = 0; y < 7; y += 1)
            {
                s[y] = A[x, k];
                k--;
            }
            for (int y = 0; y < 7; y += 1)
            {
                A[x, y] = s[y];
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
        if (n != matrix.GetLength(1) || n < 3) return null;
        int x1 = 0, y1 = 0, x2 = n - 1, y2 = n - 1;
        for (int j = 0; j < n; j++)
        {
            matrix[j - x1, j] = 0;
            matrix[j, j - y1] = 0;
            matrix[j + x2, j] = 0;
            matrix[j, j + y2] = 0;
            x1++;
            y1++;
            x2--;
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) return null;
        for (int x = (int)(n / 2); x < n; x++)
        {
            for (int y = 0; y < x + 1; y++)
            {
                matrix[x, y] = 1;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m)
        {
            return default;
        }
        int k1 = 0;
        int k2 = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j) k1++;
                else k2++;
            }
        }
        upper = new int[k1];
        int upper_index = 0;
        lower = new int[k2];
        int lower_index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        for (int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] + " ");
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - i - 1; j++)
            {
                int count_now = 0, count_next = 0;
                for (int k = 0; k < m; k++)
                {
                    if (matrix[j, k] > 0) count_now++;
                    if (matrix[j + 1, k] > 0) count_next++;
                }
                if (count_now < count_next)
                {
                    int[] t = new int[m];
                    for (int k = 0; k < m; k++)
                    {
                        t[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = t[k];
                    }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for (int k = 0; k < m - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int t = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = t;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int t = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = t;
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
        int n = 0;
        int[] index = new int[matrix.GetLength(0)];
        int ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool a = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    n++;
                    a = false;
                    break;
                }
            }
            if (!a)
            {
                index[ind++] = i;
            }
        }
        int[,] matrix1 = new int[matrix.GetLength(0) - n, matrix.GetLength(1)];
        ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == index[ind])
            {
                ind++;
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix[i, j];
                }
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}