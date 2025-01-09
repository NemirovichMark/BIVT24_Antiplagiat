using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization.Formatters;
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
        int row = A.GetLength(0), col = A.GetLength(1);
        for (int i = 0; i < row; i++)
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
        // code here

        int a = 0;
        int[] answer = new int[A.GetLength(0)];
        int row = A.GetLength(0), col = A.GetLength(1);

        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
    
        for (int i = 0; i < row; i++)
        {
            int min = 100;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    a = j;
                }
            }
            //Console.WriteLine(a);
            answer[i] = a;
        }
        
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

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0], maxint = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max) { max = A[i, j]; maxint = j; }
            }
            if (maxint != 0)
            {
                int zag = A[i, 0];
                A[i, 0] = A[i, maxint];
                A[i, maxint] = zag;
            }
        }
        //end


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
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return null; 
        int max = A[0, 0], in1 = 0, in2 = 0;
    
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max) { max = A[i, j]; in1 = i; in2 = j; }
            }
        }
        int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];

        for (int i = 0, newi = 0; i < A.GetLength(0); i++)
        {
            if (i == in1) continue; 
            for (int j = 0, newj = 0; j < A.GetLength(1); j++)
            {
                if (j == in2) continue;
                answer[newi, newj] = A[i, j];
                newj++;
            }
            newi++;
        }
        // end
        return answer;
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
        int row = A.GetLength(0), col = A.GetLength(1);
        if (A == null || row != 5 || col != 7) return null;

        for (int i = 0; i < row; i++)
        {
            int max = int.MinValue, imax1 = 0, imax2 = 0; 
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > max) { max = A[i, j]; imax1 = i; imax2 = j; }
            }
            A[imax1, imax2] *= (i + 1);
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
        int row = n, col = m;
        if (D == null || D.GetLength(0) != n || D.GetLength(1) != m) return null;

        for (int i = 0; i < row; i++)
        {
            int max = int.MinValue, imax = -1, ineg = -1; 
            for (int j = 0; j < col; j++)
            {
                if (D[i, j] < 0) break;
                if (D[i, j] > max) { max = D[i, j]; imax = j; }
            }
            for (int k = col - 1; k >= 0; k--)
            {
                if (D[i, k] < 0) {ineg = k; break; }
            }
            if (imax != -1 && ineg != -1)
            {
                int t = D[i, imax];
                D[i, imax] = D[i, ineg];
                D[i, ineg] = t;
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
        int row = H.GetLength(0), col = H.GetLength(1);
        if (H == null || H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;

        for (int i = 0; i < row; i++)
        {
            int max = int.MinValue, imax = -1;
            for (int j = 0; j < col; j++)
            {
                if (H[i, j] > max) { max = H[i, j]; imax = j; }
            }
            if (imax != -1)
            {
                int t = max;
                H[i, 6] = H[i, 5];
                H[i, 5] = t;
            }
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
        int row = Y.GetLength(0), col = Y.GetLength(1);
        if (Y == null || Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;

        for (int i = 0; i < row; i++)
        {
            double average = 0, s = 0, max = double.MinValue;
            int imax = -1, cnt = 0;

            for (int j = 0; j < col; j++)
            {
                if (Y[i, j] > max) { max =  Y[i, j]; imax = j; }
            }
            for (int j = imax + 1; j < col; j++)
            {
                if (Y[i, j] > 0) { s += Y[i, j]; cnt++; }
            }
            if (cnt != 0) average = s / cnt;

            for (int j = 0; j < imax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = average;
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
        int row = B.GetLength(0), col = B.GetLength(1);
        int[] newmassive = new int[5];
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        for (int i = 0; i < row; i++)
        {
            int max = int.MinValue, imax = -1;
            for (int j = 0;j < col; j++)
            {
                if (B[i, j] > max) { max = B[i, j]; imax = j; }
            }
            newmassive[i] = max;
        }
        for (int i = 0; i < row; i++)
        {
            B[row - i - 1, 3] = newmassive[i];
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
        int ineg = -1, max = int.MinValue, imax = -1;
        int row = B.GetLength(0), col = B.GetLength(1);
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        for (int i = 0; i < row; i++)
        {
            if (B[i, i] > max) { max = B[i, i]; imax = i; }
        }
        for (int i = 0; i < col; i++)
        {
            if (B[i, 2] < 0) { ineg = i; break; }
        }
        if (ineg != -1)
        {
            for (int j = 0; j < col; j++)
            {
                int t = B[ineg, j];
                B[ineg, j] = B[imax, j];
                B[imax, j] = t;
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
        //int[] answer = default(int[]);
        // code here

        int lenght_massive = 0;
        int row = A.GetLength(0), col = A.GetLength(1);
        if (A == null || row != 5 || col != 7) return null;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] < 0) lenght_massive++;
            }
        }
        
        int[] answer = new int[lenght_massive];
        for (int i = 0, k = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] < 0) { answer[k] = A[i, j]; k++; }
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
        int row = A.GetLength(0), col = A.GetLength(1), imax = -1, index = -1;
        double max = double.MinValue, a = 0, b = 0, c = 0;
        if (A == null || row != 5 || col != 7) return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > max) { max = A[i, j]; imax = j; } 
            }
            if (imax > 0 && imax < col - 1) 
            {
                a = A[i, imax - 1]; 
                b = A[i, imax + 1];
                c = Math.Min(a, b);

                if (c == a) index = imax - 1; 
                else if (c == b) index = imax + 1;
                if (c > 0) A[i, index] *= 2;
                else A[i, index] /= 2;
            }
            else if (imax == 0) 
            {
                if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2; 
                else A[i, imax + 1] /= 2;
            }
            else if (imax == col - 1) 
            {
                if (A[i, col - 2] > 0) A[i, col - 2] *= 2; 
                else A[i, col - 2] /= 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int row = A.GetLength(0), col = A.GetLength(1);
        if (A == null || row != 7 || col != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int cntpositive = 0, cntnegative = 0; 
            int max = int.MinValue, maxi = -1;
            for (int i = 0; i < A.GetLength(0); i++) 
            {
                if (A[i, j] > 0) cntpositive++;
                else cntnegative++; 
                if (A[i, j] > max) { max = A[i, j]; maxi = i; } 
            }
            if (cntpositive > cntnegative) A[maxi, j] = 0;
            else A[maxi, j] = maxi + 1; 
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
       
        for (int j = 0; j < col; j++) 
        {
            int max = int.MinValue, maxi = -1, s = 0;
            for (int i = 0; i < row; i++)  
            {
                if (A[i, j] > max) { max = A[i, j]; maxi = i; } 
            }
            if (maxi <= row / 2) 
            {
                for (int k = maxi + 1; k < row; k++)
                {
                    s += A[k, j]; 
                }
                A[0, j] = s; 
            }
        }
        
        // end

        return A;
    }
    public void Print(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write("{0,3}", arr[i, j]);
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        for (int j = 0; j < col; j++) 
        {
            int max = int.MinValue, imax = -1;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > max) { max = A[i, j]; imax = i; }
            }
            
            if (B[j] > max) 
            {
                A[imax, j] = B[j]; 
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        
        int imax = -1;
        for (int j = 0; j < col; j++)
        {
            double halfsum = 0, max = double.MinValue, sum = 0;
            for (int i = 0; i < row; i++)
            {
                if (i == 0 || i == 6) sum += A[i, j]; 
                if (A[i, j] > max) { max = A[i, j]; imax = i; }
            }
            halfsum = sum / 2; 
            if (max < halfsum) A[imax, j] = halfsum;
            else A[imax, j] = imax + 1; 
        }
        
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
       
        // code here
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1; 
            answer[i, i + n] = 1;
            answer[i, i + 2 * n] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        int imax = -1, max = int.MinValue;
        for (int i = 0; i < col; i++)
        {
            if (A[i, i] > max) { max = A[i, i]; imax = i; } 
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = 1 + i; j < col; j++)  
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
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int row = B.GetLength(0), col = B.GetLength(1);

        for (int i = 0; i < row; i += 2) 
        {
            int imax1 = -1, imax2 = -1, max1 = int.MinValue, max2 = int.MinValue;
            for (int j = 0; j < col; j++) 
            {
                if (B[i, j] > max1) { max1 = B[i, j]; imax1 = j; } 
            }
            for (int j = 0; j < col; j++) 
            {
                if (B[i + 1, j] > max2) { max2 = B[i + 1, j]; imax2 = j; } 
            }
            int temp = B[i, imax1];
            B[i, imax1] = B[i + 1, imax2];
            B[i + 1, imax2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int row = A.GetLength(0), col = A.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col / 2; j++) 
            {
                int temp = A[i, j];
                A[i, j] = A[i, col - j - 1];
                A[i, col - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != 7 && col != 5) return null;
        int[,] newmatrix = new int[row, 2];
        const int min = int.MaxValue;

        for (int i = 0; i < row; i++)
        {
            newmatrix[i, 0] = i;
            newmatrix[i, 1] = min;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] < newmatrix[i, 1])
                    newmatrix[i, 1] = matrix[i, j];
            }
        }
        for (int i = 1, j = 2; i < row;)
        {
            if (i == 0 || newmatrix[i, 1] <= newmatrix[i - 1, 1]) { i = j; j++; }
            else
            {
                int temp = newmatrix[i, 1],
                itemp = newmatrix[i, 0],
                inext = newmatrix[i - 1, 0];
                for (int k = 0; k < col; k++)
                {
                    int temp1 = matrix[i, k];
                    matrix[i, k] = matrix[i - 1, k];
                    matrix[i - 1, k] = temp1;
                }
                newmatrix[i, 1] = newmatrix[i - 1, 1];
                newmatrix[i, 0] = newmatrix[i - 1, 0];

                newmatrix[i - 1, 1] = temp;
                newmatrix[i - 1, 0] = itemp;
                i--;
            }
        }


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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != col || row < 3) return answer;

        answer = new int[row * 2 - 1];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                int index = j - i + row - 1;
                answer[index] += matrix[i, j];
            }
        }
        //Print(matrix);
        //foreach (int i in answer) Console.WriteLine(i);
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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != col || k < 1) return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]]))
                {
                    max[0] = i;
                    max[1] = j;
                }
            }
        }
        if (max[1] != k - 1)
        {
            for (int j = 0; j < row; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < row; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
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
        int index = 0;
        if (A.Length < 2 || B.Length < 2) return answer;
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix2[i, j] = B[index];
                matrix1[j, i] = A[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }
        int[] matrix3 = new int[n * n];
        int index3 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    matrix3[index3] += matrix1[i, k] * matrix2[k, j];
                index3++;
            }
        }
        answer = matrix3;
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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (matrix == null || row  != 5 || col != 7) return default;
        bool flag;
        for (int i = 0; i < col; i++)
        {
            flag = false;
            for (int j = 0; j < col - 1; j++)
            {
                int ci = 0, cj = 0;
                for (int z = 0; z < row; z++)
                {
                    if (matrix[z, j] < 0) ci++;
                    if (matrix[z, j + 1] < 0) cj++;
                }
                if (ci > cj)
                {
                    for (int z = 0; z < row; z++)
                    {
                        int temp = matrix[z, j];
                        matrix[z, j] = matrix[z, j + 1];
                        matrix[z, j + 1] = temp;
                    }
                    flag = true;
                }
            }
            if (flag == false) break;
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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        int cnt = 0;
        if (matrix == null) return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0) { cnt++; break; }
            }
        }
        int[,] array = new int[row - cnt, col];
        for (int i = 0, z = 0; i < row; i++)
        {
            int count = 0;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0) { count++; break; }
            }
            for (int j = 0; j < col; j++)
            {
                if (count == 0) array[z, j] = matrix[i, j];
            }
            if (count == 0) z++;
        }
        matrix = array;
        // end

        return matrix;
    }
    #endregion
}