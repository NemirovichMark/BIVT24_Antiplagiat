using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                }
            }
        } 
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
        int[] answer = default(int[]);
        // code here

        // end
        int Line = A.GetLength(0);
        int Col = A.GetLength(1);
        if (Line != 4 || Col != 7) return answer;
        answer = new int[4];
        for (int i = 0; i < Line; i++)
        {
            int mini = A[i, 0];
            int index = 0;
            for(int j = 1; j < Col; j++)
            {
                if (A[i, j] < mini)
                {
                    mini = A[i, j];
                    index = j;
                }
            }
            answer[i] = index;
        }


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

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        // end
        int Line = A.GetLength(0);
        int Col = A.GetLength(1);
        if (Line != 5 || Col != 7) return null;
        for (int i = 0; i < Line; i++)
        {
            int maxx = A[i, 0];
            int index = 0;
            for (int j = 1; j < Col; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    index = j;
                }
            }
            int peremen = A[i, 0];
            A[i, 0] = A[i, index];
            A[i, index] = peremen;
        }

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

        // end
        int Line = A.GetLength(0);
        int Col = A.GetLength(1);
        if (Line != 6 || Col != 7) return null;
        int maxx = A[0, 0];
        int lindex = 0, lcol = 0;
        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Col; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    lindex = i;
                    lcol = j;
                }
            }
        }
        int[,] An = new int[5, 6];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < lindex) An[i, j] = j < lcol ? A[i, j] : A[i, j + 1];
                else An[i, j] = j < lcol ? A[i+1, j] : A[i+1, j+1];
            }
        }
        A = An;
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

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end
        int Line = A.GetLength(0);
        int Col = A.GetLength(1);
        if (Line != 5 || Col != 7) return null;
        for (int i = 0; i < Line; i++)
        {
            int maxx = int.MinValue;
            int index = 0;
            for (int j = 0; j < Col; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    index = j;
                }
            }
            A[i, index] = maxx * (i + 1);
        }
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

        // end
        for (int i = 0; i < n; i++)
        {
            int maxx = int.MinValue;
            int index = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0) break;
                if (D[i, j] > maxx)
                {
                    maxx = D[i, j];
                    index = j;
                }
            }
            int otr = -1;
            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    otr = j;
                    break;
                }
            }
            if (index != -1 && otr != -1)
            {
                int peremen = D[i, index];
                D[i, index] = D[i, otr];
                D[i, otr] = peremen;
            }

        }
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

        // end
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int maxx = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > maxx) maxx = H[i, j];
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = maxx;
        }
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

        // end
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i = 0; i < 6; i++)
        {
            int index = 0, count = 0;
            double maxx = double.MinValue, sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > maxx)
                {
                    maxx = Y[i, j];
                    index = j;
                    sum = 0;
                    count = 0;
                }
                else if (Y[i, j] > 0)
                {
                    sum += Y[i, j]; 
                    count++;
                }
            }
            double sr = count == 0 ? 0 : sum / count;
            for (int j = 0; j < index; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = sr;
            }
        }

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

        // end
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;

        int[] max = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int maxx = int.MinValue;
            for (int j = 0; j < 7; j++)
            {
                if (B[i, j] > maxx) maxx = B[i, j];
            }
            max[5 - i - 1] = maxx;
        }
        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = max[i];
        }
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

        // end
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int index1 = 0;
        int index2 = -1; 
        int maxx = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > maxx)
            {
                maxx = B[i, i]; 
                index1 = i;
            }
            if (index2 == -1 && B[i, 2] < 0) index2 = i;
        }
        for (int i = 0; i < 5; i++)
        {
            int peremen = B[index1, i];
            B[index1, i] = B[index2, i];
            B[index2, i] = peremen;
        }
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

        // end
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            int count = 0;
            foreach (int cell in A)
            {
                if (cell < 0) count++;
            }
            answer = new int[count];
            int i = 0;
            foreach (int cell in A)
            {
                if (cell < 0)
                {
                    answer[i] = cell;
                    i++;
                }
            }
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            double maxx = int.MinValue;
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j]; 
                    index = j;
                }
            }
            if (index == 0) A[i, 1] *= A[i, 1] > 0 ? 2 : 0.5;            
            else if (index == 6) A[i, 5] *= A[i, 5] > 0 ? 2 : 0.5;
            else if (A[i, index-1] < A[i, index+1]) A[i, index-1] *= A[i, index-1] > 0 ? 2 : 0.5;
            else A[i, index+1] *= A[i, index+1] > 0 ? 2 : 0.5;
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < 5; i++)
        {
            int maxx = int.MinValue;
            int index = 0;
            int polosh = 0;
            int otrich = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    index = j;
                }
                if (A[j, i] < 0) otrich++;
                else if (A[j, i] > 0) polosh++;
            }
            if (polosh > otrich) A[index, i] = 0;
            else A[index, i] = index+1;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < 5; i++)
        {
            int maxx = int.MinValue;
            int index = 0;
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    index = j;
                    sum = 0;
                }
                else sum += A[j, i];
            }
            if (index <= 5) A[0, i] = sum;
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        // end
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int i = 0; i < 5; i++)
        {
            int maxx = int.MinValue;
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    index = j;
                }
            }
            if (B[i] > maxx) A[index, i] = B[i];
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int i = 0; i < 5; i++)
        {
            double maxx = double.MinValue;
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxx)
                {
                    maxx = A[j, i];
                    index = j;
                }
            }
            if (maxx < (A[0, i] + A[6, i]) / 2) A[index, i] = (A[0, i] + A[6, i]) / 2;
            else A[index, i] = index+1;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // end
        if (n > 0)
        {
            answer = new int[n, 3 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    answer[j % 3, j] = 1;
                }
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int maxx = int.MinValue;
        int index = -1;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxx)
            {
                maxx = A[i, i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = i + 1; j < 6; j++)
            {
                A[i, j] = 0;
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // end
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int i = 0; i < 6; i += 2)
        {
            int maxx1 = int.MinValue;
            int index1 = -1;
            int maxx2 = int.MinValue;
            int index2 = -1;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxx1)
                {
                    maxx1 = B[i, j];
                    index1 = j;
                }
                if (B[i + 1, j] > maxx2)
                {
                    maxx2 = B[i + 1, j];
                    index2 = j;
                }
            }
            int peremen = B[i, index1];
            B[i, index1] = B[i + 1, index2];
            B[i + 1, index2] = peremen;
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // end
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j <7/2; j++)
            {
                (A[i, j], A[i, 7-j-1]) = (A[i, 7-j-1], A[i, j]);
            }
        }
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

        // end
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1) matrix[i, j] = 0;
            }
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
        // code here

        // end
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = matrix.GetLength(0)/2; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j) matrix[i, j] = 1;
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
        int[] lower = default(int[]);
        // code here

        // end
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || (matrix.GetLength(0) == 0)) return (null, null);
        int Line = matrix.GetLength(0);
        upper = new int[Line * (Line + 1) / 2]; 
        lower = new int[Line * (Line - 1) / 2];
        int count1 = 0; 
        int count2 = 0; 
        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Line; j++)
            {
                if (j >= i) 
                {
                    upper[count1] = matrix[i, j];
                    count1++;
                }
                else if (j < i)
                {
                    lower[count2] = matrix[i, j];
                    count2++;
                }
            }
        }
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

        // end
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] count = new int[matrix.GetLength(0)];
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 4 - i; j++)
            {
                int poll = 0, poln = 0;
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[j, x] > 0) poll++;
                    if (matrix[j + 1, x] > 0) poln++;
                }
                if (poll < poln)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int peremen = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = peremen;
                    }
                }
            }
        }
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

        // end
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int x = 0; x < matrix.GetLength(1) - j - 1; x++)
                {
                    if (i % 2 == 0 && matrix[i, x] < matrix[i, x + 1])
                    {
                        int peremen = matrix[i, x];
                        matrix[i, x] = matrix[i, x + 1];
                        matrix[i, x + 1] = peremen;
                    }
                    if (i % 2 != 0 && matrix[i, x] > matrix[i, x + 1])
                    {
                        int peremen = matrix[i, x];
                        matrix[i, x] = matrix[i, x + 1];
                        matrix[i, x + 1] = peremen;
                    }
                }
            }
        }
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end
        int Line = matrix.GetLength(0);
        int Col = matrix.GetLength(1);
        int lline = Line, line = 0;
        for (int i = 0; i < Line; i++)
        {
            int count = 0;
            for (int j = 0; j < Col; j++)
            {
                if (matrix[i, j] == 0) count++;
            }
            if (count > 0) lline--;
        }
        int[,] A = new int[lline, Col];
        for (int i = 0; i < Line; i++)
        {
            int count = 0;
            for (int j = 0; j < Col; j++)
            {
                if (matrix[i, j] == 0) count++;
            }
            if (count <= 0)
            {
                for (int j = 0; j < Col; j++)
                {
                    A[line, j] = matrix[i, j];
                }
                line++;
            }

        }
        matrix = A;
        return matrix;
    }
    #endregion
}