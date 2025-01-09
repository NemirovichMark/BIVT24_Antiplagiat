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

        int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, -5 }
            };
        program.Task_2_8(matrix);
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                answer += A[i, j];
            }
        }

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        double sum = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                sum += A[i, j];
            }
        }
        
        answer = sum / (A.GetLength(0) * A.GetLength(1));
        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            answer += A[i, i];
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return answer;
        answer = new int[A.GetLength(0)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    answer[i] = j;
                }
            }
        }
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i]);
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
        

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0]; int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            int term = A[i, 0];
            A[i, 0] = max;
            A[i, index] = term;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int index0 = 0; int index1 = 0; int max = A[0,0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index0 = i;
                    index1 = j;
                }
            }
        }
        int[,] matrix = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0; i < index0; i++)
        {
            for (int j = 0; j < index1; j++)
            {
                matrix[i, j] = A[i, j];
            }
        }
        for (int i = index0 + 1; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < index1; j++)
            {
                matrix[i - 1, j] = A[i, j];
            }
        }
        for (int i = 0; i < index0; i++)
        {
            for (int j = index1 + 1; j < A.GetLength(1); j++)
            {
                matrix[i, j - 1] = A[i, j];
            }
        }
        for (int i = index0 + 1; i < A.GetLength(0); i++)
        {
            for (int j = index1 + 1; j < A.GetLength(1); j++)
            {
                matrix[i - 1, j - 1] = A[i, j];
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
        }
        return matrix;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int [] answer = new int[default];
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0]; int index = 0;
            A[i, index] *= (i + 1);
            for (int j = 0; j < A.GetLength(1); j++)
            {
                
                if (A[i, j] > max)
                {
                    
                    A[i, index] /= (i + 1);
                    max = A[i, j];
                    index = j;
                    A[i, index] *= (i + 1);
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
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
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int max = D[i, 0]; int index0 = 0; int index1 = 0; int j = 0;
            if (D[i, 0] < 0) { }
            else
            {
                max = D[i, 0]; index0 = 0; index1 = 0; j = 0;
                while (D[i, j] >= 0 && j < m - 1)
                {
                    if (D[i, j] > max)
                    {
                        max = D[i, j]; index0 = j;
                    }
                    j++;
                }
                for (j = 0; j < m; j++)
                {
                    if (D[i, j] < 0)
                    {
                        index1 = j;
                    }
                }
                if (index1 == 0) { }
                else
                {
                    int term = D[i, index1];
                    D[i, index1] = D[i, index0];
                    D[i, index0] = term;
                }
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0]; int index = 0;
            for (int j = 0; j < H.GetLength(1) - 1; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                    index = j;
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0]; int index = 0;
            for (int j = 0;  j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    index = j;
                }
            }
            if (max !=  Y[i, 0])
            {
                double mid = 0; int count = 0;
                for (int j = index + 1; j < Y.GetLength(1); j++)
                {
                    if (Y[i, j] > 0)
                    {
                        mid += Y[i, j]; count++;
                    }
                }
                if (count != 0)
                {
                    mid /= (double)count;
                }
                for (int j = 0; j < index; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = mid;
                    }
                }
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        int[,] B1 = new int[B.GetLength(0), B.GetLength(1)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B1[i, j] = B[i, j];
            }
        }
        for (int i = B.GetLength(0) - 1; i >= 0; i--)
        {
            int max = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            B1[B1.GetLength(0) - i - 1, 3] = max;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
        }
        return B1;
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int max = B[0, 0]; int index0 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > max)
            {
                max= B[i, i];
                index0 = i;
            }
        }
        int index1 = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                index1 = i;
                break;
            }
        }
        if (index1 == -1)
        {
            return B;
        }

        int[] term = new int[B.GetLength(1)];
        for (int j = 0; j < B.GetLength(0); j++)
        {
            term[j] = B[index0, j];
        }
        for (int j = 0; j < B.GetLength(0); j++)
        {
            B[index0, j] = B[index1, j];
            B[index1, j] = term[j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        int count = 0;

        for (int i = 0; i < 5; i++)
        {
            
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }
        answer = new int[count];
        int a = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[a] = A[i, j];
                    a++;
                }
            }
        }
        Console.WriteLine(answer.Length);
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i]);
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0]; int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            if (index == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (index == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0) A[i, A.GetLength(1) - 2] *= 2;
                else A[i, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[i, index - 1] != A[i, index + 1])
                {
                    if (A[i, index - 1] < A[i, index + 1])
                    {
                        if (A[i, index - 1] > 0) A[i, index - 1] *= 2;
                        else A[i, index - 1] /= 2;
                    }
                    else
                    {
                        if (A[i, index + 1] > 0) A[i, index + 1] *= 2;
                        else A[i, index + 1] /= 2;
                    }
                }
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int negnum = 0; int posnum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] < 0) negnum++;
                if (A[i,j] > 0) posnum++;
            }
            
            int max = A[0, j]; int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
                
            }
            if (negnum < posnum) A[index,j] = 0;
            if (posnum < negnum) A[index, j] = index + 1;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {

        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < 5; j++)
        {
            int sum = 0; int index = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i, j] > A[index, j]) index = i;
            }
            for (int i = index + 1; i < 10; i++)
            {
                sum += A[i, j];
            }
            A[0, j] = sum;
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[index, j]) index = i;
            }
            if (B[j] > A[index, j]) A[index, j] = B[j];
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[index, j]) index = i;
            }

            double half = (A[0, j] + A[6, j]) / 2.0;
            if (A[index, j] < half)
            {
                A[index, j] = half;
            }
            else
            {
                A[index, j] = index + 1;
            }
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        if (n <= 0) return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (j % 3 == i) answer[i, j] = 1;
            }
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int index = 0; int max = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                index = i;
            }
        }
        if (index == 0) return A;
        for (int i = 0; i < index; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i)
                {
                    A[i, j] = 0;
                }
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = B[i, 0]; int index1 = 0; int max2 = B[i + 1, 0]; int index2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    index1 = j;
                }
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    index2 = j;
                }
            }
            Console.WriteLine($"{max1} {max2}");
            int term = B[i, index1];
            B[i, index1] = B[i + 1, index2];
            B[i + 1, index2] = term;
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int[,] A1 = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1) - 1; j >= 0; j--)
            {
                A1[i,A.GetLength(1) - 1 - j] = A[i,j];
            }
        }

        return A1;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        
        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == 0 || i == matrix.GetLength(0) - 1)
                {
                    matrix[i, j] = 0;
                }
                else if (j == 0 || j == matrix.GetLength(1) - 1)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        return matrix;

    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        


        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = matrix.GetLength(0) - 1; i > matrix.GetLength(0) / 2 - 1; i--)
        {
            for (int j = 0; j <= i; j++)
            {
            matrix[i, j] = 1;  
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

        if (matrix.GetLength(0) != matrix.GetLength(1)) return (upper, lower);
        upper = new int[(matrix.GetLength(0) + 1) * matrix.GetLength(0) / 2];
        lower = new int[matrix.GetLength(0) * matrix.GetLength(0) - upper.Length];
        int lowerindex = 0; int upperindex = 0;
        for (int i = 0;  i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < i)
                {
                    lower[lowerindex] = matrix[i, j];
                    lowerindex++;
                }
                if (j >= i)
                {
                    upper[upperindex] = matrix[i, j];
                    upperindex++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        for (int x = 0; x < matrix.GetLength(0) - 1; x++)
        {
            
            for (int i = 0; i < matrix.GetLength(0) - x - 1; i++)
            {
                int count1 = 0; int count2 = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) count1++;
                    if (matrix[i + 1, j] > 0) count2++;
                }
                
                if (count1 < count2)
                {
                    for (int i1 = 0; i1 < matrix.GetLength(1); i1++)
                    {
                        int term = matrix[i, i1];
                        matrix[i, i1] = matrix[i + 1, i1];
                        matrix[i + 1, i1] = term;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 || matrix == null) return null; 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int x = 0; x < matrix.GetLength(1) - 1; x++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1 - x; j++)
                    {
                        if (matrix[i, j + 1] > matrix[i, j])
                        {
                            int term = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = term;
                        }
                    }
                }
            }
            else
            {
                for (int x = 0; x < matrix.GetLength(1) - 1; x++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1 - x; j++)
                    {
                        if (matrix[i, j + 1] < matrix[i, j])
                        {
                            int term = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = term;
                        }
                    }
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 || matrix == null) return null;
        int[] check = new int[matrix.GetLength(0)]; 
        int count = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    check[i] = 1;
                    count--;
                    break;
                }
            }
        }
        int[,] matrix1 = new int[count, matrix.GetLength(1)]; int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (check[i] == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[index, j] = matrix[i, j];
                }
                index++;
            }
        }

        return matrix1;
    }
    #endregion
}