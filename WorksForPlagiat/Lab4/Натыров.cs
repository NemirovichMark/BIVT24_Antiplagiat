using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Pipes;
using System.Numerics;
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
        if (A.GetLength(0) == 0 || A.GetLength(1) == 0) return answer;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                answer += A[i, j];
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
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) return (0, 0);
        int min = 10000;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    row = i;
                    col = j;
                }
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
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return null;
        int[] answer = new int[A.GetLength(1)];
        // code here

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = -100000;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max) max = A[j, i];
            }
            answer[i] = max;
        }

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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int min = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > A[min, 2]) 
                min = i;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int temp = A[min, j];
            A[min, j] = A[3, j];
            A[3, j] = temp;
        }
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
        // code here
        if (A.GetLength(0) != A.GetLength(1) && A.GetLength(0) != 5) return null;
        int max = -1000;
        int colmax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            if (A[i, i] > max)
            {
                max = A[i, i];
                colmax = i;
            }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int var = A[i, colmax];
            A[i, colmax] = A[i,3];
            A[i, 3] = var;
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
        // code here
        if (A.GetLength(0) == 0 || A.GetLength(1) == 0) return null;
        for (int i = 0; i < n; i++)
        {
            int mx = A[i, 0];
            int mxindex = 0;
            for (int j = 1; j < m; j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    mxindex = j;
                }
            }
            for (int j = mxindex; j < m - 1; j++)
                A[i, j] = A[i, j + 1];
            A[i, m - 1] = mx;
        }
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
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        for (int i = 0; i < n; i++)
        {
            double max = -100000;
            int imax = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    imax = j;
                }
            }
            for (int l = 0; l < imax; l++)
            {
                if (C[i, l] < 0)
                {
                    C[i, l] /= max;
                }
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
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double s = 0;
        int k = 0;
        double max = -10000;
        int imax = 0;
        int jmax = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
        }
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i,j] > max)
                {
                    max = Z[i,j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        double sredn = s / k;
        Z[imax,jmax] = sredn;
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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int indexmincount = 0;
        int mincount = 1000000;
        int indexmaxcount = 0;
        int maxcount = -10000000;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                    count++;
            }
            if (count < mincount)
            {
                indexmincount = i;
                mincount = count;
            }
        }
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                    count++;
            }
            if (count > maxcount)
            {
                indexmaxcount = i;
                maxcount = count;
            }
        }
        for (int j = 0; j < X.GetLength(1); j++)
        {
            int temp = X[indexmincount, j];
            X[indexmincount, j] = X[indexmaxcount, j];
            X[indexmaxcount, j] = temp;
        }
        if (indexmaxcount == indexmincount) return null;
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int maxs = -10000000;
        int maxst = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
                if (sum > maxs)
                {
                    maxs = sum;
                    maxst = i;
                }
            }
        }
        for (int i = 0; i < (A.GetLength(0) - 1); i++)
        {
            if (i < maxst)
                for (int j = 0; j < A.GetLength(1); j++)
                    answer[i, j] = A[i, j];
            else
                for (int j = 0; j < A.GetLength(1); j++)
                    answer[i, j] = A[i + 1, j];
        }
        A = answer;
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) 
            return null;
        int min = 10000000;
        int stol = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                stol = i;
            }
        }
        if (stol == 8) 
            return A;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < stol + 1; j++)
            {
                A[i, j] = A[i, j];
            }
            for (int j = stol + 1; j < A.GetLength(1); j++)
            {
                if (j == stol + 1)
                {
                    A[i, j] = B[i];
                }
                else
                {
                    A[i, j] = A[i, j - 1];
                }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxstol = 0;
            double max = -1000000000;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxstol = j;
                }
            }
            if (maxstol == 0)
            {
                if (A[i, maxstol + 1] > 0) A[i, maxstol + 1] *= 2;
                else A[i, maxstol + 1] /= 2;
            }
            else if (maxstol == A.GetLength(1) - 1)
            {
                if (A[i, maxstol - 1] > 0) A[i, maxstol - 1] *= 2;
                else A[i, maxstol - 1] /= 2;
            }
            else
            {
                if (A[i, maxstol - 1] > A[i, maxstol + 1])
                {
                    if (A[i, maxstol + 1] > 0) A[i, maxstol + 1] *= 2;
                    else A[i, maxstol + 1] /= 2;
                }
                else
                {
                    if (A[i, maxstol - 1] > 0) A[i, maxstol - 1] *= 2;
                    else A[i, maxstol - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mx = int.MinValue;
            int imxst = 0;
            int cnt1 = 0;
            int cntm = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    imxst = i;
                }
                if (A[i, j] > 0) cnt1++;
                else cntm++;
            }
            if (cnt1 > cntm)
            {
                A[imxst, j] = 0;
            }
            else A[imxst, j] = imxst + 1;

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
            int sum = 0;
            int stmax = 0;
            int max = -999999;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    stmax = i;
                }
            }
            if (stmax < (A.GetLength(0) / 2))
            {
                for (int c = stmax + 1; c < A.GetLength(0); c++)
                {
                    sum += A[c, j];
                }
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int mx = A[0, i];
            int nomer = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    nomer = j;
                }
            }
            if (B[i] > mx) 
                A[nomer, i] = B[i];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
            return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double mx = A[0, i];
            int nomer = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > mx)
                {
                    mx = A[j, i];
                    nomer = j;
                }
            }
            if (mx < (A[0, i] + A[A.GetLength(0) - 1, i] / 2)) 
                A[nomer, i] = (A[0, i] + A[A.GetLength(0) - 1, i] / 2);
            else 
                A[nomer, i] = nomer + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
            return answer;
        answer = new int[n, 3 * n];
        int a = 0;
        for (int i = 0; i < n; i++)
        {
            int b = a;
            for (int j = 0; j < 3; j++)
            {
                answer[i, b] = 1;
                b += n;
            }
            a += 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) 
            return null;
        int max = A[0, 0];
        int nomer = 0;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                nomer = i;
            }
        }
        for (int i = 0; i < nomer; i++)
        {
            for (int j = i + 1; j < 6; j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) 
            return null;
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int maxnomer1 = 0;
            int maxnomer2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, maxnomer1]) maxnomer1 = j;
                if (B[i + 1, j] > B[i + 1, maxnomer2]) maxnomer2 = j;
            }
            int temp = B[i, maxnomer1];
            B[i, maxnomer1] = B[i + 1, maxnomer2];
            B[i + 1, maxnomer2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) 
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < (A.GetLength(1) / 2); j++)
            {
                int save = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = A[i, j];
                A[i, j] = save;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) != matrix.GetLength(0)) return null;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[0, i] = 0;
            matrix[matrix.GetLength(1) - 1, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) != matrix.GetLength(0)) return null;
        int nomer = matrix.GetLength(1) / 2;
        for (int i = (matrix.GetLength(0) / 2); i < matrix.GetLength(0); i++, nomer++)
        {
            for (int j = 0; j <= nomer; j++)
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) != matrix.GetLength(0)) return (null, null);
        int cnt_upper = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            cnt_upper += (matrix.GetLength(0) - i);
        int n = matrix.GetLength(0);
        upper = new int[cnt_upper];
        lower = new int[n * n - cnt_upper];
        int stol = 0;
        int index = 0;
        for (int i = 0; i < n; i++, stol++)
        {
            for (int j = stol; j < n; j++)
            {
                upper[index] = matrix[i, j];
                index++;
            }
        }
        int poslstol = 0;
        index = 0;
        for (int i = 0; i < n; i++, poslstol++)
        {
            for (int j = 0; j < poslstol; j++)
            {
                lower[index] = matrix[i, j];
                index++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(0) - i; j++)
            {
                int cnt = 0;
                int k = 0;
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[j - 1, l] > 0) cnt++;
                    if (matrix[j, l] > 0) k++;
                }
                if (k > cnt)
                {
                    for (int l = 0; l < matrix.GetLength(1); l++)
                    {
                        int temp = matrix[j, l];
                        matrix[j, l] = matrix[j - 1, l];
                        matrix[j - 1, l] = temp;
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
        if (matrix.GetLength(0) == 0  || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int l = 1;l < matrix.GetLength(1) - j; l++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, l] > matrix[i, l - 1])
                        {
                            int temp = matrix[i, l];
                            matrix[i, l] = matrix[i, l - 1];
                            matrix[i, l - 1] = temp;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        if (matrix[i, l] < matrix[i, l - 1])
                        {
                            int temp = matrix[i,l];
                            matrix[i, l] = matrix[i, l - 1];
                            matrix[i, l - 1] = temp;
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
        if (matrix.GetLength(0) == 0) return null;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool nichevo = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    nichevo = true;
                    break;
                }
            }
            if (nichevo == false) count++;
        }
        if (count == 0) return new int[0, 0];
        int[,] matrix1 = new int[count, matrix.GetLength(1)];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool nichevo = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    nichevo = true;
                    break;
                }
            }
            if (nichevo == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[index, j] = matrix[i, j];
                }
                index++;
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}