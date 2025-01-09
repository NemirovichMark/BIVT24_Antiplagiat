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
        if (A.GetLength(0) != 5) return 0;
        if (A.GetLength(1) != 7) return 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++) answer += A[i, j];
        }
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

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        if (A.GetLength(0) != 3) return (row, col);
        if (A.GetLength(1) != 6) return (row, col);
        int min = int.MaxValue;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    row = i; col = j;
                }
            }
        }

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
        if (A.GetLength(0) != 3) return default(int[]);
        if (A.GetLength(1) != 5) return default(int[]);

        int[] answer = new int[5];
        int max;

        for (int j = 0; j < 5; j++)
        {
            max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (max < A[i, j]) max = A[i, j];
            }
            answer[j] = max;
        }


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
        if (A.GetLength(0) != 5) return default(int[,]);
        if (A.GetLength(1) != 7) return default(int[,]);

        int max = int.MinValue, row = -1, temp;
        for (int i = 0; i < 5; i++)
        {
            if (max <= A[i, 2]) { max = A[i, 2]; row = i; };
        }

        if (row == 3) return A;
        else
        {
            for (int j = 0; j < 7; j++)
            {
                temp = A[3, j];
                A[3, j] = A[row, j];
                A[row, j] = temp;
            }
            return A;
        }
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
        if (A.GetLength(0) != 5) return default(int[,]);
        if (A.GetLength(1) != 5) return default(int[,]);

        int max = int.MinValue, col = -1, temp;
        for (int i = 0; i < 5; i++)
        {
            if (max < A[i, i]) { max = A[i, i]; col = i; }
        }

        if (col == 3) return A;

        for (int i = 0; i < 5; i++)
        {
            temp = A[i, 3];
            A[i, 3] = A[i, col];
            A[i, col] = temp;
        }
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
        int[] max = new int[n];
        int[] max_index = new int[n];
        int mx, col = -1;

        for (int i = 0; i < n; i++)
        {
            mx = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; col = j; }
            }
            max[i] = mx; max_index[i] = col;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = max_index[i]; j < m; j++)
            {
                if (j == m - 1) A[i, j] = max[i];
                else A[i, j] = A[i, j + 1];
            }
        }

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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        double[] max = new double[n];
        int[] max_index = new int[n];
        double mx;
        int col = -1;

        for (int i = 0; i < n; i++)
        {
            mx = double.NegativeInfinity;
            for (int j = 0; j < m; j++)
            {
                if (mx < C[i, j]) { mx = C[i, j]; col = j; }
            }
            max[i] = mx; max_index[i] = col;
        }

        for (int i = 0; i < n; i++)
        {
            if (max[i] == 0) continue;
            for (int j = 0; j < max_index[i]; j++)
            {
                if (C[i, j] < 0) C[i, j] /= max[i];
            }
        }

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
        if (Z.GetLength(0) != 6) return default(double[,]);
        if (Z.GetLength(1) != 8) return default(double[,]);


        double sum = 0; int count = 0;
        int row = -1, col = -1; double max = Double.NegativeInfinity;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > 0) { sum += Z[i, j]; count++; }
                if (max < Z[i, j]) { max = Z[i, j]; row = i; col = j; }
            }
        }

        Z[row, col] = sum / count;

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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        if (X.GetLength(0) != 6) return default(int[,]);
        if (X.GetLength(1) != 5) return default(int[,]);


        int[] count = new int[] { 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0) count[i]++;
            }
        }

        int minRow = -1, maxRow = -1;
        int mx = int.MinValue, mn = int.MaxValue;
        int temp;

        for (int i = 0; i < 6; i++)
        {
            if (mx < count[i]) { mx = count[i]; maxRow = i; }
            if (count[i] < mn) { mn = count[i]; minRow = i; }
        }

        if (minRow == maxRow) return X;

        for (int j = 0; j < 5; j++)
        {
            temp = X[minRow, j];
            X[minRow, j] = X[maxRow, j];
            X[maxRow, j] = temp;
        }

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
        if (A.GetLength(0) != 7) return default(int[,]);
        if (A.GetLength(1) != 5) return default(int[,]);


        int maxSum = int.MinValue, maxRow = -1, temp;

        for (int i = 0; i < 7; i++)
        {
            temp = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0) temp += A[i, j];
            }
            if (maxSum < temp) { maxSum = temp; maxRow = i; }
        }

        int[,] newA = new int[6, 5];
        for (int i = 0; i < maxRow; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newA[i, j] = A[i, j];
            }
        }
        for (int i = maxRow + 1; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newA[i - 1, j] = A[i, j];
            }
        }

        return newA;
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
        if (A.GetLength(0) != 5) return default(int[,]);
        if (A.GetLength(1) != 8) return default(int[,]);
        if (B.GetLength(0) != 5) return default(int[,]);

        int col = -1, min = int.MaxValue;

        for (int j = 0; j < 8; j++)
        {
            if (A[4, j] < min) { col = j; min = A[4, j]; }
        }

        if (col < 7)
        {
            for (int i = 0; i < 5; i++) A[i, col + 1] = B[i];
        }

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

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void megaDouble(ref double x)
    {
        if (x < 0) x /= 2;
        else x *= 2;
    }

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5) return default(double[,]);
        if (A.GetLength(1) != 7) return default(double[,]);

        int[] max_index = new int[5];
        double[] max = new double[5];
        double mx; int col = -1;

        for (int i = 0; i < 5; i++)
        {
            mx = Double.NegativeInfinity;
            for (int j = 0; j < 7; j++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; col = j; }
            }
            max[i] = mx; max_index[i] = col;
        }


        for (int i = 0; i < 5; i++)
        {
            if (max_index[i] == 0) megaDouble(ref A[i, max_index[i] + 1]);
            else if (max_index[i] == 4) megaDouble(ref A[i, max_index[i] - 1]);
            else
            {
                if (A[i, max_index[i] + 1] < A[i, max_index[i] - 1]) megaDouble(ref A[i, max_index[i] + 1]);
                else megaDouble(ref A[i, max_index[i] - 1]);
            }
        }


        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7) return default(int[,]);
        if (A.GetLength(1) != 5) return default(int[,]);

        int mx, mxInd, neg, pos;

        for (int j = 0; j < 5; j++)
        {
            mx = int.MinValue; mxInd = -1;
            neg = 0; pos = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) pos++;
                else neg++;

                if (mx < A[i, j]) { mx = A[i, j]; mxInd = i; }
            }

            if (pos > neg) A[mxInd, j] = 0;
            else A[mxInd, j] = mxInd + 1;
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10) return default(int[,]);
        if (A.GetLength(1) != 5) return default(int[,]);

        int mx, mxInd, sum;

        for (int j = 0; j < 5; j++)
        {
            mx = int.MinValue; mxInd = -1;
            for (int i = 0; i < 10; i++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; mxInd = i; }
            }

            if (mxInd < 5)
            {
                sum = 0;
                for (int i = mxInd + 1; i < 10; i++) sum += A[i, j];
                A[0, j] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (B.GetLength(0) != 5) return default(int[,]);
        if (A.GetLength(0) != 7) return default(int[,]);
        if (A.GetLength(1) != 5) return default(int[,]);

        int mx, mxInd;

        for (int j = 0; j < 5; j++)
        {
            mx = int.MinValue; mxInd = -1;
            for (int i = 0; i < 7; i++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; mxInd = i; }
            }

            if (B[j] > mx) A[mxInd, j] = B[j];

        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7) return default(double[,]);
        if (A.GetLength(1) != 5) return default(double[,]);

        int mxInd;
        double ps, mx;

        for (int j = 0; j < 5; j++)
        {
            mx = double.NegativeInfinity; mxInd = -1;
            ps = (A[0, j] + A[6, j]) / 2;
            for (int i = 0; i < 7; i++)
            {
                if (mx < A[i, j]) { mx = A[i, j]; mxInd = i; }
            }

            if (mx < ps) A[mxInd, j] = ps;
            else A[mxInd, j] = mxInd + 1;

        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return default(int[,]);
        int[,] answer = new int[n, 3 * n];

        for (int k = 0; k < 9; k += 3)
        {
            for (int i = 0; i < n; i++) answer[i, i + k] = 1;
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6) return default(int[,]);
        if (A.GetLength(1) != 6) return default(int[,]);

        int max = int.MinValue, maxRow = -1;

        for (int i = 0; i < 6; i++)
        {
            if (max < A[i, i]) { max = A[i, i]; maxRow = i; }
        }



        for (int i = 0, count = 0; i < maxRow; i++)
        {
            count++;
            for (int j = count; j < 6; j++) A[i, j] = 0;
        }


        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6) return default(int[,]);
        if (B.GetLength(1) != 6) return default(int[,]);

        int max1, maxIndex1, max2, maxIndex2;

        for (int i = 0; i < 6; i += 2)
        {
            max1 = int.MinValue; max2 = int.MinValue; maxIndex1 = -1; maxIndex2 = -1;
            for (int j = 0; j < 6; j++)
            {
                if (max1 < B[i, j]) { max1 = B[i, j]; maxIndex1 = j; }
                if (max2 < B[i + 1, j]) { max2 = B[i + 1, j]; maxIndex2 = j; }
            }
            B[i, maxIndex1] = max2; B[i + 1, maxIndex2] = max1;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6) return default(int[,]);
        if (A.GetLength(1) != 7) return default(int[,]);

        int temp;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                temp = A[i, 7 - 1 - j];
                A[i, 7 - 1 - j] = A[i, j];
                A[i, j] = temp;
            }

        }

        return A;
    }

    public void swapRows(ref int[,] A, int row1, int row2)
    {
        int columns = A.GetLength(1);
        int temp;
        for (int j = 0; j < columns; j++)
        {
            temp = A[row1, j];
            A[row1, j] = A[row2, j];
            A[row2, j] = temp;
        }
    }

    public void swapColumns(ref int[,] A, int col1, int col2)
    {
        int rows = A.GetLength(0);
        int temp;
        for (int i = 0; i < rows; i++)
        {
            temp = A[i, col1];
            A[i, col1] = A[i, col2];
            A[i, col2] = temp;
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return default(int[,]);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return default(int[,]);
        int strok = matrix.GetLength(0);
        int stolb = matrix.GetLength(1);
        for (int i = strok / 2 - 1 + strok % 2; i < strok; i++)
        {
            for (int g = 0; g <= i; g++)
            {
                matrix[i, g] = 1;

            }
        }
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
        int f = 0, k = 0;
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(1) <= 0) return (null, null);
        upper = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2];
        int[] lower = default(int[]);
        lower = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2 + matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (i > g) upper[f++] = matrix[i, g];
                else lower[k++] = matrix[i, g];
            }
        }
        return (lower, upper);
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default(int[,]);
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (count_elements(j, matrix) < count_elements(j + 1, matrix))
                {
                    for (int s = 0; s < matrix.GetLength(1); s++)
                    {
                        int templ = matrix[j, s];
                        matrix[j, s] = matrix[j + 1, s];
                        matrix[j + 1, s] = templ;
                    }
                }
            }

        }

        return matrix;
    }
    int count_elements(int strok, int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[strok, i] > 0) count++;
        }
        return count;

    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j += 1)
                {
                    for (int j1 = 0; j1 < matrix.GetLength(1) - j - 1; j1 += 1)
                    {
                        if (matrix[i, j1] < matrix[i, j1 + 1])
                        {
                            int t = matrix[i, j1];
                            matrix[i, j1] = matrix[i, j1 + 1];
                            matrix[i, j1 + 1] = t;
                        }
                    }
                }
            }
            if (i % 2 != 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j += 1)
                {
                    for (int j1 = 0; j1 < matrix.GetLength(1) - j - 1; j1 += 1)
                    {
                        if (matrix[i, j1] > matrix[i, j1 + 1])
                        {
                            int t = matrix[i, j1];
                            matrix[i, j1] = matrix[i, j1 + 1];
                            matrix[i, j1 + 1] = t;
                        }
                    }
                }
            }

        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine(count);
        int s = 0;
        int[,] new_matrix = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                new_matrix[s, j] = matrix[i, j];
                if (matrix[i, j] == 0)
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(s);
            if (s == new_matrix.GetLength(0) - 1) break;
            if (flag) s++;

        }
        PrintMatrix(new_matrix);
        return new_matrix;
    }
    #endregion
}