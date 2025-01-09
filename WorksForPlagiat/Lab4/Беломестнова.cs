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
        double s = 0;
        double a = 0;
        int k = 0;
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }
        }
        a = s / k;
        answer = a;
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
        if (rowIndex == -1)
        {
            value = 0;
            rowIndex = 0;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
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
        double[] answer = default(double[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;

        answer = new double[A.GetLength(0)];
        double s = 0;
        double k = 0;
        double a = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }

            if (k == 0) a = 0;
            else a = s / k;

            answer[i] = a;
            s = 0;
            k = 0;
            a = 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        double min = A[0, 0];
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                k = i;
            }
        }
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < k)
                {
                    B[i, j] = A[i, j];
                }
                else
                {
                    B[i, j] = A[i + 1, j];
                }
            }
        }
        A = B;
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
        answer = new int[A.GetLength(1)];
        int k = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                {
                    k++;
                }
            }
            answer[j] = k;
            k = 0;
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            int k = 0, min = B[i, 0];
            for (int j = 1; j < m; j++) 
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    k = j;
                }
            }

            int[] p = new int[m];
            p[0] = min;
            int index = 1;

            for (int j = 0; j < m; j++) 
            {
                if (j != k)
                {
                    p[index] = B[i, j];
                    index++;
                }
            }

            for (int j = 0; j < m; j++)
            {
                B[i, j] = p[j];
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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            double first = 0;
            double last = 0;
            double sum = 0;
            int k = 0;
            int p = -1;
            double max = F[i, 0];

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    k = j;
                }
                if (F[i, j] < 0)
                {
                    first = F[i, j];
                    p++;
                }
            }

            if (p == -1) continue;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    last = F[i, j];
                    break;
                }
            }

            sum = (first + last) / 2;
            F[i, k] = sum;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        int a = G.GetLength(0), n = G.GetLength(1);
        for (int i = 0; i < a; i++)
        {
            int max = G[i, 0];
            int k = 0;
            for (int j = 1; j < n; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    k = j;
                }
            }

            int[] p = new int[n];
            for (int j = 0; j < n; j++)
            {
                if (j < k)
                {
                    p[j] = G[i, j];
                }
                else if (j == k)
                {
                    p[j] = max;
                }
                else
                {
                    p[j] = G[i, j - 1];
                }
            }
            for (int j = 0; j < n; j++)
            {
                G[i, j] = p[j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (B.Length != 7) return null;

        int k = 0;
        int max = A[0, 5];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                k = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[k, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)  return null;
        int min = Math.Abs(F[1, 0]);
        int k = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                k = j;
            }
        }
        int[,] temp = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int j = 0; j < F.GetLength(1) - 1; j++)
        {
            if (j < k + 1)
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    temp[i, j] = F[i, j];
                }
            }
            else
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    temp[i, j] = F[i, j + 1];
                }
            }
        }
        F = temp;

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double s = 0;
            double a = 0;
            int k = 0;
            int l = 0;
            double max = double.MinValue;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    l = j;
                }

                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    k++;
                }
            }

            if (k == 0)  a = 0;
            else a = s / k;

            A[i, l] = a; 
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
        int a = A.GetLength(0);
        int n = A.GetLength(1);
        if (a != 5 || n != 7) return default;

        for (int i = 0; i < a; i++)
        {
            int indexmax = 0;
            double max = A[i, 0];

            for (int j = 0; j < n; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexmax = j;
                }
            }

            int indext = -1;

            if (indexmax > 0 && indexmax < n - 1)
            {
                if (A[i, indexmax - 1] < A[i, indexmax + 1])
                {
                    indext = indexmax - 1;
                }
                else
                {
                    indext = indexmax + 1;
                }
            }
            else if (indexmax == 0)
            {
                indext = 1;
            }
            else if (indexmax == n - 1)
            {
                indext = n - 2;
            }

            if (indext != -1)
            {
                if (A[i, indext] > 0)
                {
                    A[i, indext] *= 2;
                }
                else
                {
                    A[i, indext] /= 2;
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
        int a = A.GetLength(0);
        int n = A.GetLength(1);

        if (a != 7 || n != 5)
            return null;

        for (int j = 0; j < n; j++)
        {
            int pos_k = 0;
            int neg_k = 0;
            int indexmax = 0;

            for (int i = 0; i < a; i++)
            {
                if (A[i, j] < 0)
                    neg_k++;
                else
                    pos_k++;

                if (A[i, j] > A[indexmax, j])
                    indexmax = i;
            }

            if (neg_k > pos_k)
                A[indexmax, j] = indexmax + 1;
            else
                A[indexmax, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int n = A.GetLength(1);
        if (a != 10 || n != 5) return default;

        for (int j = 0; j < n; j++)
        {
            int max = A[0, j], indexmax = 0; 


            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexmax = i;
                }
            }
            if (indexmax < a / 2) // если максимальный элемент в первой половине столбца
            {
                int s = 0;
                for (int i = indexmax + 1; i < a; i++)
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
        int a = A.GetLength(0);
        int n = A.GetLength(1);
        int l = B.Length;
        if (a != 7 || n != 5 || l != 5) return default;

        for (int j = 0; j < n; j++) 
        {
            int max = A[0, j], indexmax = 0, t = 0;
            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexmax = i;
                }
            }
            if (A[indexmax, j] < B[j])
            {
                t = B[j];
                B[j] = A[indexmax, j];
                A[indexmax, j] = t;
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

        int a = A.GetLength(0);
        int n = A.GetLength(1);

        for (int j = 0; j < n; j++)
        {
            int indexmax = 0;
            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > A[indexmax, j])
                {
                    indexmax = i;
                }
            }

            double average = (A[0, j] + A[a - 1, j]) / 2;

            if (average > A[indexmax, j])
            {
                A[indexmax, j] = average;
            }
            else
            {
                A[indexmax, j] = indexmax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return default;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int k = i;
            for (int j = k; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int n = A.GetLength(1);

        if (a != 6 || n != 6)
        {
            return default;
        }
        int max = A[0, 0];
        int indexmax = 0;
        for (int i = 0; i < a; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                indexmax = i;
            }
        }
        for (int i = 0; i < indexmax; i++)
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
        if (n != 6 || B.GetLength(1) != 6)
            return null;

        int previousJMax = 0;

        for (int i = 0; i < n; i++)
        {
            int jMax = 0;
            for (int j = 0; j < n; j++)
            {
                if (B[i, j] > B[i, jMax])
                {
                    jMax = j;
                }
            }

            if (i % 2 == 0)
            {
                previousJMax = jMax;
            }
            else
            {
                int temp = B[i, jMax];
                B[i, jMax] = B[i - 1, previousJMax];
                B[i - 1, previousJMax] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int n = A.GetLength(1);

        if (a != 6 || n != 7)
            return default;

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, n - j - 1];
                A[i, n - j - 1] = temp;
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

        if (n != matrix.GetLength(1)) return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    matrix[i, j] = 0;
            }
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

        if (n != matrix.GetLength(1))  return null;

        for (int k = n / 2; k < n; k++)
        {
            for (int l = 0; l <= k; l++)
            {
                matrix[k, l] = 1;
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
        int a = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        if (a != n) return (null, null);

        int upperCount = (a * (a + 1)) / 2;
        int lowerCount = (a * (a - 1)) / 2;

        upper = new int[upperCount];
        lower = new int[lowerCount];

        int upperIndex = 0;
        int lowerIndex = 0;

        for (int i = 0; i < a; i++)
        {
            for (int j = i; j < a; j++)
            {
                upper[upperIndex++] = matrix[i, j];
            }
        }

        for (int i = 1; i < a; i++)
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
        int a = matrix.GetLength(0);  
        int n = matrix.GetLength(1); 
        if (a != 7 || n != 5) return null;

        int[] pos = new int[a];
        int[] rowi = new int[a];

        for (int i = 0; i < a; i++)
        {
            rowi[i] = i;
        }
        for (int i = 0; i < a; i++)
        {
            int k = 0;
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > 0)
                    k++;
            }
            pos[i] = k;
        }
        for (int i = 0; i < a - 1; i++)
        {
            for (int j = 0; j < a - i - 1; j++)
            {
                if (pos[j] < pos[j + 1])
                {
                    (pos[j], pos[j + 1]) = (pos[j + 1], pos[j]);
                    (rowi[j], rowi[j + 1]) = (rowi[j + 1], rowi[j]);
                }
            }
        }
        int[,] res = new int[a, n];
        for (int i = 0; i < a; i++)
        {
            int rowI = rowi[i];
            for (int j = 0; j < n; j++)
            {
                res[i, j] = matrix[rowI, j];
            }
        }

        return res;
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
        int a = matrix.GetLength(0);  
        int n = matrix.GetLength(1);

        if (a == 0 || n == 0) return matrix;

        for (int i = 0; i < a; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = 0; k < n - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = 0; k < n - j - 1; k++)
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
        if (matrix == null) return null;

        int a = matrix.GetLength(0);  
        int n = matrix.GetLength(1);  
        int k = 0;

        for (int i = 0; i < a; i++)  
        {
            bool z = false;
            for (int j = 0; j < n; j++) 
            {
                if (matrix[i, j] == 0)
                {
                    z = true;
                    break;
                }
            }
            if (!z) k++;
        }

        if (k == 0) return new int[0, 0];

        int[,] temp = new int[k, n]; 
        int id = 0;

        for (int i = 0; i < a; i++) 
        {
            bool Zero = false;
            for (int j = 0; j < n; j++) 
            {
                if (matrix[i, j] == 0)
                {
                    Zero = true;
                    break;
                }
            }

            if (!Zero)
            {
                for (int j = 0; j < n; j++)  
                {
                    temp[id, j] = matrix[i, j];
                }
                id++;
            }
        }

        matrix = temp;
        // end

        return matrix;
    }
    #endregion
}