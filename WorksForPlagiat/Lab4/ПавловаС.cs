using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
        program.Task_3_8(matrix);
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
        int amount = 0;
        // code here

        foreach (int item in A)
        {
            if (item > 0)
            {
                answer += item;
                amount++;
            }
        }
        if (amount != 0) answer /= amount;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4 || colIndex < 0 || colIndex >= A.GetLength(1)) return (0, 0);

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
        double[] answer = new double[A.GetLength(0)];
        double averange = 0;
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;

        for (int i = 0, amount = 0; i < A.GetLength(0); i++, averange = 0, amount = 0)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] > 0) { 
                    averange += A[i, j];
                    amount++;
                }
            }
            if(amount != 0) {
                averange /= amount;
            }
            answer[i] = Math.Round(averange, 2);
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
        
        int rowMin = 0;
        
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < A[rowMin, 0]) rowMin = i;
        }

        int[,] tmp = new int[A.GetLength(0) - 1, A.GetLength(1)];

        for(int i = 0, k = 0; k < tmp.GetLength(0); i++, k++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if(i < rowMin) 
                {
                    tmp[k, j] = A[i, j];
                }
                else
                {
                    tmp[k, j] = A[i + 1, j];
                }
            }
        }

        A = tmp;
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

        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;

        answer = new int[A.GetLength(1)];

        for(int j = 0, counter = 0; j < A.GetLength(1); j++, counter = 0)
        {
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) counter++;
            }
            answer[j] = counter;
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
        if (B == null || m == 0 || n == 0) return null;

        for(int i = 0, indexMin = 0; i < n; i++, indexMin = 0)
        {
            for(int j = 1; j < m; j++)
            {
                if (B[i, j] < B[i, indexMin]) indexMin = j;
            }
            if (indexMin != 0)
            {
                int tmp = B[i, indexMin];
                for (int j = indexMin; j > 0; j--)
                {
                    B[i, j] = B[i, j - 1];
                }
                B[i, 0] = tmp;
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
        double firstNeg = 0, lastNeg = 0, sum = 0;
        // code here
        if ( F == null || m == 0 || n == 0) return null;

        for (int i = 0, indexMax = 0, k = 1; i < n; i++, indexMax = 0, k = 1)
        {
            for(int j = 0; j < m; j++)
            {
                if (F[i, j] > F[i, indexMax]) indexMax = j;
                if (F[i, j] < 0)
                {
                    if(k == 1) {
                        firstNeg = F[i, j];
                        k++;
                    }
                    lastNeg = F[i, j];
                }
            }
            if(lastNeg != 0)
            {
                sum = (lastNeg + firstNeg) / 2;
                F[i, indexMax] = sum;
                lastNeg = 0;
                firstNeg = 0;
            }
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

        for(int i = 0, indexMax = 0 ; i < G.GetLength(0); i++, indexMax = 0)
        {
            for(int j = 1; j < G.GetLength(1) - 1; j++)
            {
                if (G[i, j] > G[i, indexMax]) indexMax = j;
            }
            for (int j =  G.GetLength(1) - 1; j > indexMax ;j--)
            {
                G[i, j] = G[i, j - 1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return null;

        int rowIndMax = 0;

        for(int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, A.GetLength(1) - 2] > A[rowIndMax, A.GetLength(1) - 2]) rowIndMax = i;
        }
        for(int i = 0; i < A.GetLength(1); i++)
        {
            A[rowIndMax, i] = B[i];
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
        int columnMin = 0;
        // code here
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;

        for(int i = 1; i < F.GetLength(1); i++)
        {
            if (Math.Abs(F[1, i]) < Math.Abs(F[1, columnMin])) columnMin = i;
        }

        int[,] tmp = new int[F.GetLength(0), F.GetLength(1) - 1];

        for(int i = 0; i < tmp.GetLength(0); i++)
        {
            for(int j = 0, k = 0; k < F.GetLength(1); k++)
            {
                if(k == columnMin + 1)
                {
                    continue;
                }
                else
                {
                    tmp[i, j++] = F[i, k];
                }
            }
        }
        F = tmp;
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
        double sum = 0;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0, indexMax = 0, counterPos = 0; i < A.GetLength(0); i++, indexMax = 0, counterPos = 0, sum = 0)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, indexMax]) indexMax = j;
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    counterPos++;
                }
            }
            if(counterPos != 0) sum /= counterPos;
            A[i, indexMax] = sum;
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
        int indexMax = 0;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, indexMax]) indexMax = j;
            }
            if (indexMax == A.GetLength(1) - 1 || A[i, indexMax - 1] < A[i, indexMax + 1])
            {
                if (A[i, indexMax - 1] > 0)
                { A[i, indexMax - 1] *= 2; }
                else
                { A[i, indexMax - 1] /= 2; }
            }
            else
            {
                if (A[i, indexMax + 1] > 0)
                { A[i, indexMax + 1] *= 2; }
                else
                { A[i, indexMax + 1] /= 2; }
            }
        }
        // end
        return A;
        
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0, posCounter = 0, negCounter = 0, indexMax = 0; j < A.GetLength(1); j++, posCounter = 0, negCounter = 0, indexMax = 0)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) { posCounter++; }
                else if (A[i, j] != 0) { negCounter++; }

                if (A[i, j] > A[indexMax, j]) indexMax = i;
            }
            if(posCounter > negCounter)
            {
                A[indexMax, j] = 0;
            }
            else
            {
                A[indexMax, j] = indexMax + 1;
            }
        }
        // end
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;

        for (int j = 0, indexMax = 0, sum = 0; j < A.GetLength(1); j++, indexMax = 0, sum = 0)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indexMax, j]) indexMax = i;
            }
            if(indexMax < A.GetLength(0) / 2)
            {
                for(int i = indexMax + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
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

        for (int j = 0, indexMax = 0; j < A.GetLength(1); j++, indexMax = 0)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indexMax, j]) indexMax = i;
            }
            if (B[j] > A[indexMax, j]) A[indexMax, j] = B[j];
        }
        // end
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        double sum = 0;
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0, indexMax = 0; j < A.GetLength(1); j++, indexMax = 0, sum = 0)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[indexMax, j]) indexMax = i;
            }
            sum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (A[indexMax, j] < sum)
            {
                A[indexMax, j] = sum;
            }
            else
            {
                A[indexMax, j] = indexMax + 1;
            }
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

        for (int i = 0; i < 3 * n; i++)
        {
            answer[i % n, i] = 1;
        }
        // end
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int indexMax = 0;
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        
        for(int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > A[indexMax, indexMax]) indexMax = i;
        }
        for(int i = 0; i < indexMax; i++)
        {
            for(int j = i + 1; j < A.GetLength(1); j++)
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

        for(int i = 0,  indexMaxFirst = 0, indexMaxSecond = 0; i < B.GetLength(0); i = i + 2, indexMaxFirst = 0, indexMaxSecond = 0)
        {
            for(int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, indexMaxFirst]) indexMaxFirst = j;
                if (B[i + 1, j] > B[i + 1, indexMaxSecond]) indexMaxSecond = j;
            }
            int tmp = B[i, indexMaxFirst];
            B[i, indexMaxFirst] = B[i + 1, indexMaxSecond];
            B[i + 1, indexMaxSecond] = tmp;
        }
        // end
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for(int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int tmp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = tmp;
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

        // end
        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        for(int i = 0; i < matrix.GetLength(1); i++) 
        {
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;
            matrix[0, i] = 0;
            matrix[matrix.GetLength(1) - 1, i] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i + 1; j++)
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
        if(matrix.GetLength(0) != matrix.GetLength(1)) return (null,  null);

        upper = new int[(matrix.Length - matrix.GetLength(0)) / 2 + matrix.GetLength(0)];
        lower = new int[matrix.Length - upper.Length];
        
        for(int i = 0, k = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = i; j < matrix.GetLength(1); j++)
            {
                upper[k++] = matrix[i, j]; 
            }
        }
        for (int i = 1, k = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[k++] = matrix[i, j];
            }
        }

        for(int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " ");
        }
        Console.WriteLine("");
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] + " ");
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

        int[] posCounter = new int[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) posCounter[i]++;
            }
        }
        //
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int k = 0; k < matrix.GetLength(0) - 1 - i; k++)
            {
                if (posCounter[k] < posCounter[k + 1])
                {
                    int tmp_1 = posCounter[k];
                    posCounter[k] = posCounter[k + 1];
                    posCounter[k + 1] = tmp_1;

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int tmp_2 = matrix[k, j];
                        matrix[k, j] = matrix[k + 1, j];
                        matrix[k + 1, j] = tmp_2;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i % 2 == 0)
                {
                    for(int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int tmp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = tmp;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int tmp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = tmp;
                        }
                    }
                }
            }
        }
                // end
                for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine("");
        }
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        for(int deleteRow = 0; deleteRow < matrix.GetLength(0); deleteRow++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[deleteRow, j] == 0)
                {
                    matrix = DeleteRows(matrix, deleteRow);
                    deleteRow--;
                    break;
                }
            }
        }
        // end
        return matrix;
    }
    static int[,] DeleteRows(int[,] matrix, int deleteRow)
    {
        if (matrix == null || deleteRow < 0 || deleteRow >= matrix.GetLength(0)) return null;

        int[,] tmp = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

        for (int i = 0, k = 0; k < tmp.GetLength(0); i++, k++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= deleteRow)
                {
                    tmp[k, j] = matrix[i + 1, j];
                }
                else
                {
                    tmp[k, j] = matrix[i, j];
                }
            }
        }
        matrix = tmp;
        return matrix;
    }
    #endregion
}