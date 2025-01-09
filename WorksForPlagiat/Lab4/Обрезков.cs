using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
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

        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;
        
        for (int i = 0; i < A.GetLength(1); i++)
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        
        int[] answer = new int[A.GetLength(0)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = A[i, 0], index = 0;

            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0], index = 0;

            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }

            A[i, index] = A[i, 0];
            A[i, 0] = max;
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

        int max = A[0, 0], maxI = 0, maxJ = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxI = i;
                    maxJ = j;
                }
            }
        }

        int[,] answer = new int[5, 6];

        for (int i = 0, ii = 0; i < A.GetLength(0); i++)
        {
            if (i == maxI) continue;
            
            for (int j = 0, jj = 0; j < A.GetLength(1); j++)
            {
               if (j == maxJ) continue;

               answer[ii, jj] = A[i, j];
               jj++;
            }

            ii++;
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0], index = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }

            A[i, index] *= i + 1;
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
        for (int i = 0; i < D.GetLength(0); i++)
        {
            if (D[i, 0] < 0) continue;
                
            int max = D[i, 0], index = 0;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0) break;

                if (D[i, j] > max)
                {
                    max = D[i, j];
                    index = j;
                }
            }

            int lastIndex = D.GetLength(1) - 1;
            for (int j = D.GetLength(1) - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    lastIndex = j;
                    break;
                }
            }

            (D[i, lastIndex], D[i, index]) = (D[i, index], D[i, lastIndex]);
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
            int max = H[i, 0];

            for (int j = 0; j < H.GetLength(1) - 1; j++)
            {
                max = (H[i, j] > max) ? H[i, j] : max;
            }
            
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = max;
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
            double max = Y[i, 0];
            int index = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    index = j;
                }
            }
            
            double avg = 0;
            int cnt = 0;
            for (int j = index + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] < 0) continue;

                avg += Y[i, j];
                cnt++;
            }
            
            if (cnt != 0) avg /= cnt;

            for (int j = 0; j < index; j++)
            {
                if (Y[i, j] > 0) continue;

                Y[i, j] = avg;
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

        int[] maxs = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                max = (B[i, j] > max) ? B[i, j] : max;
            }

            maxs[i] = max;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = maxs[B.GetLength(0) - 1 - i];
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
        if (B.GetLength(0) != 5 || B.GetLength(0) != 5) return null;

        int index1 = 0, index2 = 0;

        int max = B[0, 0];
        bool flag = true;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > max)
            {
                max = B[i, i];
                index1 = i;
            }
            
            if (B[i, 2] < 0 && flag)
            {
                index2 = i;
                flag = false;
            }
        }

        for (int i = 0; i < B.GetLength(1); i++)
        {
            (B[index1, i], B[index2, i]) = (B[index2, i], B[index1, i]);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        int cnt = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) cnt++;
            }
        }

        int[] answer = new int[cnt];
        
        for (int i = 0, index = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[index] = A[i, j];
                    index++;
                }
            }
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
            double max = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }

            if (index == 0) A[i, 1] *= (A[i, 1] > 0) ? 2 : 0.5;
            else if (index == A.GetLength(1) - 1) A[i, A.GetLength(1) - 1] *= (A[i, A.GetLength(1) - 1] > 0) ? 2 : 0.5;
            else if (A[i, index - 1] < A[i, index + 1]) A[i, index - 1] *= (A[i, index - 1] > 0) ? 2 : 0.5;
            else A[i, index + 1] *= (A[i, index + 1] > 0) ? 2 : 0.5;
        }

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j], maxIndex = 0, cntPos = 0, cntNeg = 0;
            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) cntPos++;
                else cntNeg++;

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            if (cntPos > cntNeg) A[maxIndex, j] = 0;
            else A[maxIndex, j] = maxIndex + 1;
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j], maxIndex = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;

                    sum = 0;
                    continue;
                }

                sum += A[i, j];
            }

            if (maxIndex < 5)
            {
                A[0, j] = sum;
            }
        }
        
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j], maxIndex = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            if (B[j] > max)
            {
                A[maxIndex, j] = B[j];
            }
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = A[0, j];
            int maxIndex = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }
            }

            double sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;

            if (max < sum) A[maxIndex, j] = sum;
            else A[maxIndex, j] = maxIndex + 1;
        }

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;
        
        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                answer[j, i * n + j] = 1;
            }
        }
        
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int max = A[0, 0], maxIndex = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                maxIndex = i;
            }
        }
        
        for (int i = 0; i < maxIndex; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }
        
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = B[i, 0], max2 = B[i + 1, 0], maxIndex1 = 0, maxIndex2 = 0;

            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    maxIndex1 = j;
                }

                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    maxIndex2 = j;
                }
            }

            B[i, maxIndex1] = max2;
            B[i + 1, maxIndex2] = max1;
        }
        
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - 1 - j]) = (A[i, A.GetLength(1) - 1 - j], A[i, j]);
            }
        }

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;

        int[] mins = new int[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            mins[i] = matrix[i, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                mins[i] = (matrix[i, j] < mins[i]) ? matrix[i, j] : mins[i];
            }
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int j = i - 1;
            while (j >= 0 && mins[j] < mins[j + 1])
            {
                (mins[j], mins[j + 1]) = (mins[j + 1], mins[j]);

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    (matrix[j, k], matrix[j + 1, k]) = (matrix[j + 1, k], matrix[j, k]);
                }
                
                j--;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        int[] answer = new int[2 * matrix.GetLength(0) - 1];

        for (int k = 0, j = answer.Length / 2; k < answer.Length; k++, j--)
        {
            int i = matrix.GetLength(0) - 1 - k;
            i = (i < 0) ? 0 : i;
            while (i < matrix.GetLength(0) && i - j < matrix.GetLength(1))
            {
                answer[k] += matrix[i, i - j];
                i++;
            }
        }

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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k <= 0) return null;

        int max = matrix[0, 0], indexI = 0, indexJ = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    indexI = i;
                    indexJ = j;
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            (matrix[i, indexJ], matrix[i, k - 1]) = (matrix[i, k - 1], matrix[i, indexJ]);
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            (matrix[indexI, j], matrix[k - 1, j]) = (matrix[k - 1, j], matrix[indexI, j]);
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
        if (A.Length == 0 || B.Length == 0) return null;

        int[,] matrixA = new int[n, n], matrixB = new int[n, n];

        for (int i = 0, ii = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[ii];
                matrixB[i, j] = B[ii];

                ii++;
            }
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                matrixA[i, j] = matrixA[j, i];
                matrixB[i, j] = matrixB[j, i];
            }
        }
        
        PrintMatrix(matrixA);
        Console.WriteLine();
        PrintMatrix(matrixB);
        Console.WriteLine();

        int[,] answer = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    answer[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        
        PrintMatrix(answer);
        Console.WriteLine();

        int[] arrayAnswer = new int[answer.Length];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arrayAnswer[i * n + j] = answer[i, j];
            }
        }

        return arrayAnswer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int[] negatives = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0) negatives[j]++;
            }
        }

        for (int i = 1; i < negatives.Length; i++)
        {
            int j = i - 1;
            while (j >= 0 && negatives[j] > negatives[j + 1])
            {
                (negatives[j], negatives[j + 1]) = (negatives[j + 1], negatives[j]);
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    (matrix[k, j], matrix[k, j + 1]) = (matrix[k, j + 1], matrix[k, j]);
                }
                
                j--;
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

        int[,] answer = new int[matrix.GetLength(0) - cnt, matrix.GetLength(1)];

        for (int i = 0, ii = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            
            if (flag) continue;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[ii, j] = matrix[i, j];
            }

            ii++;
        }

        return answer;
    }
    #endregion
}