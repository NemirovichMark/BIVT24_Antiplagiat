using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        int sum = 0;
        // code here

        // end

        return sum;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0;
        }
        int cnt = 0;
        double sum = 0;
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                if (A[i, j] > 0)
                {
                    cnt++;
                    sum += A[i, j];
                }
            }
        }
        answer = sum / cnt;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4)
        {
            return (0, 0);
        }

        for (int i = 0; i <= 4; i++)
        {
            if (A[i, colIndex] < 0)
            {
                return (A[i, colIndex], i);
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
        double[] answer = new double[4];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6)
        {
            return null;
        }
        int cnt = 0;
        double sum = 0;
        for (int i = 0; i <= 3; i++)
        {
            cnt = 0;
            sum = 0;
            for (int j = 0; j <= 5; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                answer[i] = 0;
            }
            else
            {
                answer[i] = sum / cnt;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int min = 100000;
        int min_index = 0;
        for (int i = 0; i <= 4; i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                min_index = i;
            }
        }
        int[,] N = new int[4, 7];

        for (int i = 0; i < min_index; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                N[i, j] = A[i, j];
            }
        }

        for (int i = min_index; i < 4; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                N[i, j] = A[i + 1, j];
            }
        }
        // end

        return N;
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
        int[] answer = new int[3];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
        {
            return null;
        }
        int cnt = 0;
        // end
        for (int j = 0; j <= 2; j++)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (A[i, j] < 0)
                {
                    cnt++;
                }
            }
            answer[j] = cnt;
            cnt = 0;
        }
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
        if (B.GetLength(0) != n || B.GetLength(1) != m)
        {
            return null;
        }

        int min = 1000000;
        int min_index;
        int[] A = new int[m];


        for (int i = 0; i < n; i++)
        {
            min = 1000000;
            min_index = -1;

            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    min_index = j;
                }
            }

            for (int k = 0; k <= min_index; k++)
            {
                A[k] = B[i, k];
                B[i, k] = 0;
            }

            B[i, 0] = min;

            for (int j = 1; j <= min_index; j++)
            {
                B[i, j] = A[j - 1];
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
        if (F.GetLength(0) != n || F.GetLength(1) != m)
        {
            return null;
        }
        double max = double.NegativeInfinity;
        int max_index = 0;
        double half_sum = 0;
        for (int i = 0; i < n; i++)
        {
            half_sum = 0;
            max = double.NegativeInfinity;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    max_index = j;
                }
            }

            for (int a = 0; a < m; a++)
            {
                if (F[i, a] < 0)
                {
                    half_sum += F[i, a] / 2.0;
                    break;
                }
            }
            for (int a = 1; a <= m; a++)
            {
                if (F[i, m - a] < 0)
                {
                    half_sum += F[i, m - a] / 2.0;
                    break;
                }
            }
            if (half_sum == 0)
            {
                continue;
            }
            F[i, max_index] = half_sum;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
        {
            return null;
        }
        int max = -10000000;
        int max_index = 0;
        int[] A = new int[7];
        for (int i = 0; i <= 4; i++)
        {
            max = -1000000;
            max_index = 0;
            for (int m = 0; m <= 6; m++)
            {
                if (G[i, m] > max)
                {
                    max = G[i, m];
                    max_index = m;
                }
            }
            for (int a = max_index + 1; a <= 6; a++)
            {
                A[a] = G[i, a];
                G[i, a] = 0;
            }
            G[i, max_index + 1] = max;
            for (int j = max_index + 2; j <= 6; j++)
            {
                G[i, j] = A[j - 1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
        {
            return null;
        }

        int max = -10000000;
        int max_index = 0;
        for (int i = 0; i <= 4; i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                max_index = i;
            }
        }

        for (int j = 0; j <= 6; j++)
        {
            A[max_index, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
        {
            return null;
        }

        int min = 10000000;
        int min_index = 0;

        for (int j = 0; j <= 6; j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                min_index = j;
            }
        }
        int[,] N = new int[5, 6];

        for (int j = 0; j <= min_index; j++)
        {
            for (int i = 0; i <= 4; i++)
            {
                N[i, j] = F[i, j];
            }
        }
        for (int j = min_index + 1; j < 6; j++)
        {
            for (int i = 0; i <= 4; i++)
            {
                N[i, j] = F[i, j + 1];
            }
        }
        // end

        return N;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        double av = 0;
        int cnt = 0;
        double max = double.NegativeInfinity;
        int max_index = 0;

        for (int i = 0; i <= 4; i++)
        {
            av = 0;
            cnt = 0;
            max = double.NegativeInfinity;
            max_index = 0;
            for (int j = 0; j <= 6; j++)
            {
                if (A[i, j] > 0)
                {
                    cnt++;
                    av += A[i, j];
                }
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = j;
                }
            }
            if (cnt == 0)
            {
                A[i, max_index] = 0;
            }
            else
            {
                av /= cnt;
                A[i, max_index] = av;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        double max = double.NegativeInfinity;
        int max_index = -1;
        for (int i = 0; i <= 4; i++)
        {
            max = double.NegativeInfinity;
            max_index = -1;
            for (int j = 0; j <= 6; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j]; max_index = j;
                }
            }
            if (max_index == 0)
            {
                if (A[i, 1] > 0)
                {
                    A[i, 1] *= 2;
                }
                else
                {
                    A[i, 1] /= 2;
                }
            }
            else if (max_index == 6)
            {
                if (A[i, 5] > 0)
                {
                    A[i, 5] *= 2;
                }
                else
                {
                    A[i, 5] /= 2;
                }
            }
            else
            {
                if (A[i, max_index - 1] > A[i, max_index + 1])
                {
                    if (A[i, max_index + 1] > 0)
                    {
                        A[i, max_index + 1] *= 2;
                    }
                    else
                    {
                        A[i, max_index + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, max_index - 1] > 0)
                    {
                        A[i, max_index - 1] *= 2;
                    }
                    else
                    {
                        A[i, max_index - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int max = -100000;
        int max_index = 0;
        int pcnt = 0;
        int mcnt = 0;
        for (int j = 0; j <= 4; j++)
        {
            max = -100000;
            max_index = 0;
            pcnt = 0;
            mcnt = 0;
            for (int i = 0; i <= 6; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                }
                if (A[i, j] > 0)
                {
                    pcnt++;
                }
                if (A[i, j] < 0)
                {
                    mcnt++;
                }
            }
            if (pcnt > mcnt)
            {
                A[max_index, j] = 0;
            }
            else
            {
                A[max_index, j] = max_index + 1;
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
        int max_index = 0;
        int max = -1000000;
        int sum = 0;
        for (int j = 0; j <= 4; j++)
        {
            sum = 0;
            max = -1000000;
            max_index = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                }
            }
            if (max_index > 4)
            {
                continue;
            }
            for (int i = max_index + 1; i <= 9; i++)
            {
                sum += A[i, j];
            }
            A[0, j] = sum;
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
        int max_index = 0;
        int max = -1000000;
        for (int j = 0; j <= 4; j++)
        {
            max = -100000;
            max_index = 0;
            for (int i = 0; i <= 6; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                }
            }
            if (A[max_index, j] < B[j])
            {
                A[max_index, j] = B[j];
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
        int max_index = 0;
        double max = -1000000;
        double hsum = 0;
        for (int j = 0; j <= 4; j++)
        {
            max = -100000;
            max_index = 0;
            for (int i = 0; i <= 6; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                }
            }
            hsum = (A[0, j] + A[6, j]) / 2.0;
            if (max < hsum)
            {
                A[max_index, j] = hsum;
            }
            else
            {
                A[max_index, j] = max_index + 1;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {

        if (n < 1)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];

        // code here
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            answer[i, c] = 1; answer[i, c + n] = 1; answer[i, c + 2 * n] = 1;
            c++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int max = -1000000;
        int max_index = 0;
        for (int i = 0; i <= 5; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                max_index = i;
            }
        }
        for (int i = 0; i < max_index; i++)
        {
            for (int j = i + 1; j <= 5; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int[,] M = new int[2, 6];
        int max = -1000000;
        int max_index = 0;
        for (int i = 0; i <= 5; i++)
        {
            max = -1000000;
            max_index = 0;
            for (int j = 0; j <= 5; j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    max_index = j;
                }
            }
            M[0, i] = max;
            M[1, i] = max_index;
        }
        B[0, M[1, 0]] = M[0, 1];
        B[1, M[1, 1]] = M[0, 0];

        B[2, M[1, 2]] = M[0, 3];
        B[3, M[1, 3]] = M[0, 2];

        B[4, M[1, 4]] = M[0, 5];
        B[5, M[1, 5]] = M[0, 4];

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[] N = new int[7];

        for (int i = 0; i <= 5; i++)
        {

            for (int j = 0; j <= 6; j++)
            {
                N[j] = A[i, j];
            }
            for (int j = 0; j <= 6; j++)
            {
                A[i, 6 - j] = N[j];
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
        int[,] MIN = new int[2, 7];
        int[,] NEW = new int[7, 5];
        int min = 1000000;
        int min_index = 0;

        for (int i = 0; i <= 6; i++)
        {
            min = 1000000;
            //min_index = 0;
            for (int j = 0; j <= 4; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    //min_index = j;
                }
            }
            MIN[0, i] = min;
            MIN[1, i] = i;
            //MIN[1, i] = min_index;
        }
        int a;
        for (int s = 0; s <= 6; s++)
        {
            for (int o = 1; o <= 6; o++)
            {
                if (MIN[0, o] > MIN[0, o - 1])
                {
                    a = MIN[0, o];
                    MIN[0, o] = MIN[0, o - 1];
                    MIN[0, o - 1] = a;
                    a = MIN[1, o];
                    MIN[1, o] = MIN[1, o - 1];
                    MIN[1, o - 1] = a;
                }
            }
        }
        for (int b = 0; b <= 6; b++)
        {
            for (int y = 0; y <= 4; y++)
            {
                NEW[b, y] = matrix[MIN[1, b], y];
            }
        }
        // end
        for (int i = 0; i <= 6; i++)
        {
            for (int j = 0; j <= 4; j++)
            {
                Console.Write(NEW[i, j] + " ");
            }
        }
        return NEW;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int n = matrix.GetLength(0);
        int[] answer = new int[2 * n - 1];

        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= n - 1; j++)
            {
                answer[j - i + n - 1] += matrix[i, j];
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
        k -= 1;
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0))
        {
            return null;
        }
        int n = matrix.GetLength(0);

        int I = 0;
        int J = 0;
        int max_abs = -10000000;

        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= n - 1; j++)
            {
                if (Math.Abs(matrix[i, j]) > max_abs)
                {
                    max_abs = Math.Abs(matrix[i, j]);
                    I = i;
                    J = j;
                }
            }
        }

        int H;

        for (int i = 0; i<= n-1; i++)
        {
            H = matrix[i, J];
            matrix[i, J] = matrix[i, k];
            matrix[i, k] = H;
        }
        for (int j = 0; j<= n-1; j++)
        {
            H = matrix[I, j];
            matrix[I, j] = matrix[k, j];
            matrix[k, j] = H;
        }


        // end
        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= n - 1; j++)
            {
                Console.Write(matrix[i, j] + " ");
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
        if (n < 1 || A.Length / 2 != n || B.Length / 2 != n)
        {
            return null;
        }

        int cnt = 0;
        int cnt1 = 0;
        int[] answer = new int[n*n];
        int[,] matrix_A = new int[n , n]; 
        int[,] matrix_B = new int[n , n];

        for (int i = 0; i <= n-1; i++)
        {
            for (int j = i; j <= n-1; j++)
            {
                matrix_A[i, j] = A[cnt];
                matrix_B[i, j] = B[cnt];
                cnt++;
            }
        }
        for (int i = 0; i <= n-1; i++)
        {
            for (int j = 0; j <= n-1; j++)
            {
                matrix_A[j, i] = matrix_A[i, j];
                matrix_B[j, i] = matrix_B[i, j];
            }
        }
        int s = 0;
        for (int i = 0; i <= n-1; i++)
        {
            for (int j = 0; j <= n-1; j++)
            {
                s = 0;
                for (int o = 0; o <= n-1; o++)
                {
                    s += (matrix_A[i, o] * matrix_B[o, j]);
                }
                answer[cnt1++] = s;
            }
        }

        // code here

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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        {
            return null;
        }

        int[,] N = new int[2, 7];
        int cnt = 0;

        for (int j = 0; j<= 6; j++)
        {
            cnt = 0;
            for (int i = 0; i <= 4; i++)
            {
                if (matrix[i, j] < 0)
                {
                    cnt++;
                }
            }
            N[0,j] = cnt;
            N[1, j] = j;
        }
        int a;

        for (int s = 0; s <= 6; s++)
        {
            for (int o = 1; o <= 6; o++)
            {
                if (N[0, o] < N[0, o - 1])
                {
                    a = N[0, o];
                    N[0, o] = N[0, o - 1];
                    N[0, o - 1] = a;
                    a = N[1, o];
                    N[1, o] = N[1, o - 1];
                    N[1, o - 1] = a;
                }
            }
        }

        int[,] NEW = new int[5,7];

        for (int b = 0; b <= 4; b++)
        {
            for (int y = 0; y <= 6; y++)
            {
                NEW[b, y] = matrix[b, N[1,y]];
            }
        }
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        // end

        return NEW;
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

        int[] N = new int[matrix.GetLength(0)];
        // end
        int cnt = 0;
        for (int i = 0; i<= matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i,j] == 0)
                {
                    N[i] = 1;
                    cnt++;
                    break;
                }
            }
        }

        int[,] NEW = new int[matrix.GetLength(0)-cnt, matrix.GetLength(1)];
        int check_cnt = 0;

        for (int i = 0; i <= matrix.GetLength(0) - 1 - cnt; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
            {
                if (N[i] == 1)
                {
                    check_cnt++;
                    //continue;
                }
                NEW[i, j] = matrix[i+check_cnt,j];
            }
        }

        return NEW;
    }
    #endregion
}