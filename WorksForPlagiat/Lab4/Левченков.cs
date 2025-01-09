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
        
        
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;
        
        for (int i = 0; i < 4; i++)
        {
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
        int[] ans = new int[4];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 4; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    ans[i] = j;
                }
            }
        }
        // end

        return ans;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int ind = -1;
            int max = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }
            int tmp = A[i, ind];
            A[i, ind] = A[i, 0];
            A[i, 0] = tmp;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        int max = int.MinValue;
        int posi = -1, posj = -1;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    posi = i;
                    posj = j;
                }
            }
        }
        int[,] ans = new int[5, 6];
        int k = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == posi)
                continue;
            int m = 0;
            for (int j = 0; j < 7; j++)
            {
                if (j == posj)
                    continue;
                ans[k, m] = A[i, j];
                m++;
            }
            k++;
        }
        // end

        return ans;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            int ind = -1;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                if (j == ind)
                    A[i, j] *= (i + 1);
            }
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

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            int indmax = -1, max = int.MinValue, indlst = -1, indfst = -1;

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    indlst = j;

                }
            }
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    indfst = j;
                    break;
                }
            }
            for (int j = 0; j < indfst; j++)
            {
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    indmax = j;
                }
            }
            if (indmax != -1)
            {
                int tmp = D[i, indmax];
                D[i, indmax] = D[i, indlst];
                D[i, indlst] = tmp;
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > max)
                    max = H[i, j];
            }
            int tmp = H[i, 5];
            H[i, 5] = max;
            H[i, 6] = tmp;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;

        for (int i = 0; i < 6; i++)
        {
            int pos = -1;
            double max = int.MinValue, sr = 0;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    pos = j;
                }
            }
            double cnt = 0, sum = 0;
            for (int j = pos + 1; j < 5; j++)
            {
                if (Y[i, j] > 0)
                {                 
                    sum += Y[i, j];
                    cnt++;
                }
            }            
            if (cnt == 0)
                sr = 0;
            else
                sr = sum / cnt;

            for (int j = 0; j < pos; j++)
            {
                if (Y[i, j] < 0)
                    Y[i, j] = sr;
            }
        }
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

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
            return null;

        int[] temp = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                    max = B[i, j];
            }
            temp[B.GetLength(0) - i - 1] = max;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = temp[i];
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
        if (B.GetLength(0) != 5 && B.GetLength(1) != 5) return null;

        int max = int.MinValue, ind = -1, str = 0;
        for (int i = 0; i < B.GetLength(1); i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                ind = i;
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                str = i;
                break;
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                int tmp = B[ind, j];
                B[ind, j] = B[str, j];
                B[str, j] = tmp;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        int cnt = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                    cnt++;
            }
        }
        if (cnt == 0) return null;
        answer = new int[cnt];
        int ind = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[ind] = A[i, j];
                    ind++;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, min])
                    min = j;
            }
            if (min == A.GetLength(1) - 1)
                A[i, min - 1] *= 2;
            else if (min == 0)
                A[i, min + 1] *= 2;
            else
            {
                if (A[i, min - 1] > A[i, min + 1])
                {
                    if (A[i, min + 1] < 0)
                        A[i, min + 1] *= 0.5;
                    else
                        A[i, min + 1] *= 2;
                }
                else
                {
                    if (A[i, min - 1] < 0)
                        A[i, min - 1] *= 0.5;
                    else
                        A[i, min - 1] *= 2;
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

        for (int j = 0; j < A.GetLength(1); ++j)
        {
            int min = 0;
            int cntpos = 0;
            int cntneg = 0;
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                if (A[i, j] > 0)
                    cntpos++;
                if (A[i, j] < 0)
                    cntneg++;
                if (A[i, j] > A[min, j])
                    min = i;
            }
            if (cntpos > cntneg)
                A[min, j] = 0;
            else
                A[min, j] = min + 1;
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
            int max = A[0, j], indmax = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indmax = i;
                    sum = 0;
                }
                else
                    sum += A[i, j];
            }
            if (indmax <= A.GetLength(0) / 2)
            {
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

        for (int j = 0; j < A.GetLength(1); ++j)
        {
            int min = 0;
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                if (A[i, j] > A[min, j])
                    min = i;
            }
            if (B[j] > A[min, j])
                A[min, j] = B[j];
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
            double max = A[0, j], sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            int pos = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    pos = i;
                }
            }           
            if (max < sum)
                A[pos, j] = sum;
            else
                A[pos, j] = pos + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if ((j - i) % n == 0)
                    answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int max = int.MinValue, pos = -1;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                pos = i;
            }
        }
        for (int i = 0; i < pos; i++)
        {
            for (int j = i + 1; j < 6; j++)
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

        for (int i = 0; i < 6; i += 2)
        {
            int max1 = int.MinValue, pos1 = -1, max2 = int.MinValue, pos2 = -1;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    pos1 = j;
                }
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    pos2 = j;
                }
            }
            int tmp = B[i, pos1];
            B[i, pos1] = B[i + 1, pos2];
            B[i + 1, pos2] = tmp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - j - 1]) = (A[i, A.GetLength(1) - j - 1], A[i, j]);
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        
        int[] mns = new int[matrix.GetLength(0)];
        int[] tmp = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        int[,] ans = new int[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, mns[i]] > matrix[i, j])
                    mns[i] = j;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (matrix[tmp[j + 1], mns[j + 1]] > matrix[tmp[j], mns[j]])
                {
                    int tmpmin = mns[j];
                    mns[j] = mns[j + 1];
                    mns[j + 1] = tmpmin;
                    tmpmin = tmp[j];
                    tmp[j] = tmp[j + 1];
                    tmp[j + 1] = tmpmin;
                }
            }
        }        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                ans[i, j] = matrix[tmp[i], j];
            }
        }
        matrix = ans;      
        // end

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) <= 0) return null;

        answer = new int[2 * matrix.GetLength(0) - 1];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                answer[matrix.GetLength(0) - 1 - (i - j)] += matrix[i, j];
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k > matrix.GetLength(0) || k < 1) return null;

        int max = 0, posi = 0, posj = 0, tmp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(max))
                {
                    max = matrix[i, j];
                    posi = i;
                    posj = j;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            tmp = matrix[posi, i];
            matrix[posi, i] = matrix[k - 1, i];
            matrix[k - 1, i] = tmp;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            tmp = matrix[i, posj];
            matrix[i, posj] = matrix[i, k - 1];
            matrix[i, k - 1] = tmp;
        }
        // end

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
        if (A.Length != (n * (n + 1) / 2) && B.Length != (n * (n + 1) / 2)) return null;
        
        answer = new int[n * n];
        int[,] m_A = new int[n, n];
        int[,] m_B = new int[n, n];
        int[,] tmp = new int[n, n];
        int pos = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                m_A[i, j] = A[pos];
                m_A[j, i] = A[pos];
                m_B[i, j] = B[pos];
                m_B[j, i] = B[pos];
                pos++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    tmp[i, j] += m_A[i, k] * m_B[k, j];
                }
                answer[j + i * n] = tmp[i, j];
            }
        }

        for (int i = 0; i < n * n; i++)
        {
            Console.Write(answer[i] + " ");
        }
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int [] neg_cnt = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int neg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                    neg++;
            }
            neg_cnt[j] = neg;
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (neg_cnt[i] > neg_cnt[i + 1])
                {
                    (neg_cnt[i], neg_cnt[i + 1]) = (neg_cnt[i + 1], neg_cnt[i]);                    
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        (matrix[k, i], matrix[k, i + 1]) = (matrix[k, i + 1], matrix[k, i]);
                    }
                }
            }
        }        
        // end

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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int cnt = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    cnt++;
                    break;
                }
            }
        }
        int[,] ans = new int[matrix.GetLength(0) - cnt, matrix.GetLength(1)];
        int ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                    break;
                ans[ind, j] = matrix[i, j];
            }
            ind++;
            if (ind >= matrix.GetLength(0) - cnt)
                break;
        }
        // end

        return ans;
    }
    #endregion
}