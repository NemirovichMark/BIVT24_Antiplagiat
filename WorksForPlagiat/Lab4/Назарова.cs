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
        int strok = A.GetLength(0);
        int dlin = A.GetLength(1);
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < dlin; j++)
            {
                answer += A[i, j];
            }
        }
        // end
        //Console.WriteLine(A.GetLength(1));
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

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0, min = 1010101010;

        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min) { min = A[i, j]; row = i; col = j; }
            }
        }

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

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 3 || n != 5) return null;

        int[] answer = new int[A.GetLength(1)];
        int max = -999999;
        // code here

        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max) max = A[j, i];
            }
            answer[i] = max;
            max = -999999;
        }
        for (int h = 0; h < answer.Length; h++)
        {
            Console.WriteLine(answer[h]);
        }
        //end

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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 7) return null;

        int min = 999999, minIndex = 0, temp = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > min)
            {
                min = A[i, 2];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            temp = A[minIndex, j];
            A[minIndex, j] = A[3, j];
            A[3, j] = temp;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 5) return null;

        int max = -999999; int max_stolb = 0;
        int stolb = 0, strok = 0, temp = 0;
        // code here
        while (true)
        {
            if (stolb < A.GetLength(0))
            {
                if (A[strok, stolb] > max)
                {
                    max = A[strok, stolb];
                    max_stolb = stolb;
                }
                stolb++;
                strok++;
            }
            else break;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            //if (A[i,max_stolb] == 0) return null;
            temp = A[i, max_stolb];
            A[i, max_stolb] = A[i, 3];
            A[i, 3] = temp;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        int[,] matrix = new int[n, m];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = -999999, maxIndex = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
            }
            bool flag = true;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (max != A[i, j])
                {
                    matrix[i, count] = A[i, j];
                    count++;
                }
                else if (maxIndex == A.GetLength(1) - 1)
                {
                    matrix[i, count] = A[i, j];
                    count++;
                }
                else if (flag == true)
                {
                    matrix[i, count] = A[i, j];
                    flag = false;
                    //count++;
                    matrix[i, A.GetLength(1) - 1] = max;
                }
            }

        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        for (int i = 0; i < C.GetLength(0); i++)
        {
            int maxIndex = 0; double max = -999999;
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    maxIndex = j;
                }
            }
            for (int j = 0; j < maxIndex; j++)
            {
                if (C[i, j] < 0) C[i, j] /= max;
            }
        }
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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        double countPos = 0; double mid = 0;
        int m = Z.GetLength(0), n = Z.GetLength(1);
        if (m != 6 || n != 8) return null;

        // code here
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    mid += Z[i, j];
                    countPos++;
                }
            }
        }
        mid = Math.Round(mid / countPos, 2);
        double max = -999999; int max_y = 0, max_x = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    max_y = i;
                    max_x = j;
                }

            }
        }
        // end
        Console.WriteLine(max);
        Z[max_y, max_x] = mid;
        return Z;
    }
    public int[,] Task_1_23(int[,] j)
    {
        // code here

        // end

        return j;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        int min = 10000, max = -10000, minIndex = 0, maxIndex = 0;
        // code here
        int m = X.GetLength(0), n = X.GetLength(1);
        if (m != 6 || n != 5) return null;

        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    count++;
                }
            }
            if (count < min)
            {
                minIndex = i;
                min = count;
            }
            if (count > max)
            {
                maxIndex = i;
                max = count;
            }

        }
        int temp = 0;
        for (int j = 0; j < X.GetLength(1); j++)
        {
            temp = X[max, j];
            X[max, j] = X[minIndex, j];
            X[minIndex, j] = temp;
        }
        // end
        Console.WriteLine($"{maxIndex} + {max} and {minIndex} + {min}");
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 7 || n != 5) return null;

        int index = 0; int max = -999999;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > max)
            {
                max = sum;
                index = i;
            }
        }
        // end
        int count = 0;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[count, j] = A[i, j];
            }
            if (i == 2)
            {
                i++;
            }
            count++;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"{max} + {index}");
        return B;
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 8 || B.Length != 5) return null;

        int min = 999999; int minIndex = 0;
        // code here
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                minIndex = i;
            }
        }
        Console.WriteLine(min);
        if (minIndex != A.GetLength(1) - 1)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, minIndex + 1] = B[i];
            }
        }
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

        // end

        return answer;
    }
    #endregion
    #region Level 2

    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return default(double[,]);
        }
        for (int i = 0; i < n; i++)
        {
            double max = -100000;
            int max_i = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_i = j;
                }
            }
            if (max_i == 0)
            {
                A[i, 1] *= 2;
            }
            else if (max_i == m - 1)
            {
                A[i, m - 2] *= 2;
            }
            else
            {
                if (A[i, max_i - 1] < A[i, max_i + 1])
                {
                    if (A[i, max_i - 1] < 0)
                    {
                        A[i, max_i - 1] /= 2;
                    }
                    else
                    {
                        A[i, max_i - 1] *= 2;
                    }
                }
                else if (A[i, max_i - 1] > A[i, max_i + 1])
                {
                    if (A[i, max_i + 1] < 0)
                    {
                        A[i, max_i + 1] /= 2;
                    }
                    else
                    {
                        A[i, max_i + 1] *= 2;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            int c_pos = 0, c_not_pos = 0, max = -10000000, max_i = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
                if (A[j, i] > 0)
                {
                    c_pos++;
                }
                else
                {
                    c_not_pos++;
                }
            }
            if (c_pos > c_not_pos)
            {
                A[max_i, i] = 0;
            }
            else
            {
                A[max_i, i] = max_i + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5)
        {
            return default(int[,]);
        }
        for (int i = 0; i < m; i++)
        {
            int s = 0, max = -100000, max_i = -1;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            if (max_i < 5)
            {
                for (int _ = max_i + 1; _ < n; _++)
                {
                    s += A[_, i];
                }
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
        if (n != 7 || m != 5 || B.Length != 5)
        {
            return default(int[,]);
        }
        for (int i = 0; i < m; i++)
        {
            int max = -100000, max_i = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            if (max < B[i])
            {
                A[max_i, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5)
        {
            return default(double[,]);
        }
        for (int i = 0; i < m; i++)
        {
            double max = -10000;
            int max_i = -1;
            for (int j = 0; j < n; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    max_i = j;
                }
            }
            double s = (A[0, i] + A[n - 1, i]) / 2;
            if (max < s)
            {
                A[max_i, i] = s;
            }
            else
            {
                A[max_i, i] = max_i + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0)
        {
            return answer;
        }
        answer = new int[n, 3 * n];
        int[,] A = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    A[i, j] = 1;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int c = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (c == 3)
                {
                    c = 0;
                }
                answer[i, j] = A[i, c];
                c++;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6)
        {
            return default(int[,]);
        }
        int max = -100000, max_i = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        max_i = i;
                    }
                }
            }
        }
        for (int i = 0; i < max_i; i++)
        {
            for (int j = i + 1; j < m; j++)
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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6)
        {
            return default(int[,]);
        }
        int max1 = -100000, max1_i = 0, max2 = -100000, max2_i = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > max1)
                    {
                        max1 = B[i, j];
                        max1_i = j;
                    }
                }
                if (i % 2 != 0)
                {
                    if (B[i, j] > max2)
                    {
                        max2 = B[i, j];
                        max2_i = j;
                    }
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, max1_i] = max2;
                B[i, max2_i] = max1;
                max1 = -100000;
                max2 = -100000;
                max1_i = 0;
                max2_i = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 6 || m != 7)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n; i++)
        {
            int temp;
            for (int j = 0; j < m / 2; j++)
            {
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

        int[,] shortMatrix = new int[n, 2];

        const int min = 999999;

        for (int i = 0; i < n; i++)
        {
            shortMatrix[i, 0] = i;
            shortMatrix[i, 1] = min;

            for (int j = 0; j < m; j++)
                if (matrix[i, j] < shortMatrix[i, 1]) shortMatrix[i, 1] = matrix[i, j];
        }

        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0 || shortMatrix[i, 1] <= shortMatrix[i - 1, 1]) { i = j; j++; }
            else
            {
                int temp = shortMatrix[i, 1],
                    iTemp = shortMatrix[i, 0],
                    iNext = shortMatrix[i - 1, 0];

                for (int z = 0; z < m; z++)
                {
                    int temp1 = matrix[i, z];
                    matrix[i, z] = matrix[i - 1, z];
                    matrix[i - 1, z] = temp1;
                }

                shortMatrix[i, 1] = shortMatrix[i - 1, 1];
                shortMatrix[i, 0] = shortMatrix[i - 1, 0];

                shortMatrix[i - 1, 1] = temp;
                shortMatrix[i - 1, 0] = iTemp;
                i--;
            }
        }
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
        if (n != m || n < 3) return answer;

        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
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

        if (max[1] != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
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
        if (lenA < 2 || lenB < 2) return answer;

        int[,] matrixA = new int[n, n], matrixB = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[index];
                matrixB[i, j] = B[index];
                matrixA[j, i] = A[index];
                matrixB[j, i] = B[index];
                index++;
            }
        }

        int[] matrixC = new int[n * n];

        int indexC = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    matrixC[indexC] += matrixA[i, k] * matrixB[k, j];
                indexC++;
            }
        }
        answer = matrixC;
        foreach (int x in answer)
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

        int[] newMatrix = new int[m];

        for (int j = 0; j < m; j++)
        {
            short count = 0;

            for (int i = 0; i < n; i++)
                if (matrix[i, j] < 0) count++;

            newMatrix[j] = count;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m - i - 1; j++)
            {
                if (newMatrix[j] > newMatrix[j + 1])
                {
                    int temp = newMatrix[j];
                    newMatrix[j] = newMatrix[j + 1];
                    newMatrix[j + 1] = temp;

                    for (int k = 0; k < n; k++)
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                }
            }
        }                                       

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
        for (int i = 0; i < n; i++)
        {
            short zeros = 0;

            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0) { zeros = 1; matrix[i, 0] = 0; break; }

            if (zeros == 0)
                nonZero++;
        }

        int[,] newMatrix = new int[nonZero, m];

        for (int i = 0, k = -1; i < n; i++)
        {
            if (matrix[i, 0] == 0) continue;
            else k++;
            for (int j = 0; j < m; j++)
                newMatrix[k, j] = matrix[i, j];
        }

        for(int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < newMatrix.GetLength(1); j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        matrix = newMatrix;
        // end

        return matrix;
    }

    #endregion
}