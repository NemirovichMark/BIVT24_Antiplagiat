using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        int count = 0;
        double s = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count += 1;
                }
            }
        }
        if (count == 0) return 0;
        answer = s / count;
        
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
        if (A == null || A.GetLength(0)!= 5 || A.GetLength(1)!= 4)
        {
            return default;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int p = colIndex; p < A.GetLength(1); p++)
            {
                if (A[i, p] < 0)
                {
                    value = A[i, p];
                    rowIndex = i;
                    break;
                }

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
        double[] answer = default(double[]);
        double avg;
        double s = 0;
        // code here
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 6)
        {
            return null;
        }

        answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    count += 1;
                }

            }
            if (count == 0) answer[i] = 0;
            if (count > 0)
            {
                avg = sum / count;
                Console.WriteLine(avg);
                answer[i] = avg;
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
        
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int minValue = A[0, 0];
        int rowIndex = 0;
        for (int i = 1; i < rows; i++)
        {
            if (A[i, 0] < minValue)
            {
                minValue = A[i, 0];
                rowIndex = i;
            }
        }

        int[,] newAnswer = new int[rows - 1, columns];
        int newRowIndex = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i != rowIndex)
            {
                for (int j = 0; j < columns; j++)
                {
                    newAnswer[newRowIndex, j] = A[i, j];
                }
                newRowIndex++;
            }
        }
        A = newAnswer;
        for (int i = 0; i < newAnswer.GetLength(0); i++)
        {
            for (int j = 0; j < newAnswer.GetLength(1); j++)
            {
                Console.Write(newAnswer[i, j] + " ");
            }
            Console.WriteLine();
        }
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        // code here
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 3)
        {
            return null;
        }
        answer = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] < 0) k += 1;
            }
            answer[j] = k;
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
        if (B == null || B.GetLength(0) != n || B.GetLength(1) != m)
        {
            return null;
        }
        int[,] newB = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int a = B[i, 0];
            int b = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < a)
                {
                    a = B[i, j];
                    b = j;
                }
            }
            newB[i, 0] = a;
            int c = 1;
            for (int j = 0; j < m; j++)
            {
                if (j != b)
                {
                    newB[i, c] = B[i, j];
                    c++;
                }
            }

        }
        B = newB;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
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
        if (F == null || F.GetLength(0) != n || F.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            double max = -100;
            int maxindex = 0;
            int firstindex = -1;
            int lastindex = -1;
            double polusum;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    maxindex = j;
                }
                if (firstindex == -1 && F[i, j] < 0)
                {
                    firstindex = j;
                }

            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    lastindex = j;
                    break;
                }
            }
            if (firstindex != -1 && lastindex != -1)
            {
                polusum = (F[i, firstindex] + F[i, lastindex]) / 2;

                F[i, maxindex] = polusum;
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
        int rows = G.GetLength(0);
        int columns = G.GetLength(1);
        if (G == null || G.GetLength(0) != 5 || G.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < rows; i++)
        {
            int max = -100;
            int maxindex = -1;
            for (int j = 0; j < columns; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    maxindex = j;
                }
            }
            for (int j = columns - 1; j > maxindex; j--)
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
        int rows = A.GetLength(0);
        int columns = A.GetLength(1);
        if (A == null || rows != 5 || columns != 7 || B.Length != 7)
        {
            return null;
        }
        for (int i = 0; i < rows; i++)
        {
            int max = -100;
            int maxindex = -1;
            for (int j = 0; j < columns; j++)
            {
                if (A[i, j] >= max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            if (maxindex == 3)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"B[{j}]: {B[j]}");
                    A[i, j] = B[j];
                }
            }
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
        int min= 100;
        int minindex = -1;
        int n = F.GetLength(0);
        int m = F.GetLength(1);
        int[,] newF = new int[n, m - 1];
        if (F == null || F.GetLength(0) != 5 || F.GetLength(1) != 7)
        {
            return null;
        }
        for (int j = 0; j < m; j++)
        {
            if (Math.Abs(F[2, j]) < min)
            {
                min = F[2, j];
                minindex = j;
            }
        }
        minindex += 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < minindex; j++)
            {
                newF[i, j] = F[i, j];
            }
            for (int j = minindex + 1; j < m; j++)
            {
                newF[i, j - 1] = F[i, j];
            }
        }
        F = newF;
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
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue;
            int maxindex = -1;
            double avg;
            double s = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count += 1;
                }
            }
            if (maxindex != -1 && count != 0)
            {
                avg = s / count;
                A[i, maxindex] = avg;
            }
            else if (count == 0)
            {
                A[i, maxindex] = 0;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int y = 0; y < A.GetLength(0); y++)
        {
            double max = -1000;
            int indM = 0;
            for (int i = 0; i < A.GetLength(1); i++)
            {
                if (A[y, i] > max)
                {
                    max = A[y, i];
                    indM = i;
                }
            }
            if (indM != 0 && indM != A.GetLength(0) - 1)
            {
                if (A[y, indM - 1] < A[y, indM + 1])
                {
                    if (A[y, indM - 1] < 0)
                    {
                        A[y, indM - 1] /= 2;
                    }
                    else A[y, indM - 1] *= 2;
                }
                else
                {
                    if (A[y, indM + 1] < 0)
                    {
                        A[y, indM + 1] /= 2;
                    }
                    else A[y, indM + 1] *= 2;
                }
            }
            else
            {
                if (indM == 0)
                {
                    if (A[y, indM + 1] > 0) A[y, indM + 1] *= 2;
                    else A[y, indM + 1] /= 2;
                }
                else
                {
                    if (A[y, indM - 1] > 0) A[y, indM - 1] *= 2;
                    else A[y, indM - 1] /= 2;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int y = 0; y < A.GetLength(1); y++)
        {
            int countPol = 0;
            int countOtr = 0;
            int Max = 0;
            int IndexMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, y] >= 0) countPol++;
                else countOtr++;
                if (A[i, y] > Max)
                {
                    Max = A[i, y];
                    IndexMax = i;
                }
            }
            if (countOtr < countPol) A[IndexMax, y] = 0;
            else A[IndexMax, y] = IndexMax + 1;
        }
                // end

                return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int iMax = 0, sumAfterMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[iMax, j])
                {
                    iMax = i;
                    sumAfterMax = 0;
                }
                else
                {
                    sumAfterMax += A[i, j];
                }
            }
            if (iMax < 5) A[0, j] = sumAfterMax;

        }
        
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;

        for (int j = 0; j < m; j++)
        {
            int iMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[iMax, j])
                    iMax = i;
            }
            if (B[j] > A[iMax, j]) A[iMax, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(double[,]);

        for (int j = 0; j < AWeight; j++)
        {
            double maxValue = A[0, j];
            int indMax = 0;
            double sum = (A[0, j] + A[AHeight - 1, j]) / 2;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    indMax = i;
                    maxValue = A[i, j];
                }
            }

            if (maxValue < sum)
                A[indMax, j] = sum;
            else
                A[indMax, j] = indMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, n * 3];
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            answer[i, i] = 1;
            answer[i, i + answer.GetLength(0)] = 1;
            answer[i, i + 2 * answer.GetLength(0)] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        // code here
        if (m != 6 || n != 6) return null;
        int a = -9999, b = -1;
        for (int j = 0; j < 6; j++)
        {
            if (A[j, j] > a)
            {
                a = A[j, j];
                b = j;
            }
        }
        if (b == -1) return null;
        for (int i = 0; i < b; i++)
        {
            for (int t = i + 1; t < 6; t++)
            {
                A[i, t] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (6 != B.GetLength(0) || 6 != B.GetLength(1)) 
        {
            return null;
        } 
        int i1 = -1, i2 = -1;
        for (int i = 0; i < 6; i += 2)
        {
            int m1 = -9999, m2 = -9999, o = 0;
            for (int a = 0; a < 6; a += 1)
            {
                if (B[i, a] > m1)
                {
                    i1 = a;
                    m1 = B[i, a];
                }
            }
            for (int j = 0; j < 6; j += 1)
            {
                if (B[i + 1, j] > m2)
                {
                    i2 = j;
                    m2 = B[i + 1, j];
                }
            }
            o = B[i, i1];
            B[i, i1] = B[i + 1, i2];
            B[i + 1, i2] = o;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (6 != A.GetLength(0) || 7 != A.GetLength(1)) 
        {
            return null;
        } 
        int k;
        int[] s;
        for (int i = 0; i < 6; i++)
        {
            k = 6;
            s = new int[7];
            for (int j = 0; j < 7; j += 1)
            {
                s[j] = A[i, k];
                k--;
            }
            for (int j = 0; j < 7; j += 1)
            {
                A[i, j] = s[j];
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3)
        {
            return null;
        }   
        int x1 = 0, x2 = n - 1, y1 = 0,  y2 = n - 1;
        for (int j = 0; j < n; j++)
        {
            matrix[j - x1, j] = 0;
            matrix[j + x2, j] = 0;
            matrix[j, j - y1] = 0;
            matrix[j, j + y2] = 0;
            x1++;
            x2--;
            y1++;
            y2--;
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) 
        {
            return null;
        } 
        for (int i = (int)(n / 2); i < n; i++)
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m)
        {
            return default;
        }
        int k1 = 0;
        int k2 = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j) k1++;
                else k2++;
            }
        }
        upper = new int[k1];
        int upper_index = 0;
        lower = new int[k2];
        int lower_index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j)
                {
                    upper[upper_index] = matrix[i, j];
                    upper_index++;
                }
                else
                {
                    lower[lower_index] = matrix[i, j];
                    lower_index++;
                }

            }
        }
        for (int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " ");
        }
        Console.WriteLine();
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
        int rows = matrix.GetLength(0), columns = matrix.GetLength(1);
        int[] pos = new int[7];
        if (rows != 7 || columns != 5) 
        {
            return null;
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0)
                {
                    pos[i]++;
                }
            }
        }
        for (int i = 0; i < pos.Length - 1; i++)
        {
            for (int j = 0; j < pos.Length - 1 - i; j++)
            {
                if (pos[j] < pos[j + 1])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int temp1 = pos[j];
                    pos[j] = pos[j + 1];
                    pos[j + 1] = temp1;
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
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            if (i % 2 == 0)
            {
                for (int c = 0; c < col; c++)
                {
                    for (int j = 0; j < col - c - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
                    }
                }
            }
            else
            {
                for (int c = 0; c < col; c++)
                {
                    for (int j = 0; j < col - c - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
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
        int count = 0;
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            bool boom = false;
            int nomer = 0;
            for (int y1 = 0; y1 < matrix.GetLength(1); y1++)
            {
                if (matrix[y, y1] == 0)
                {
                    boom = true;
                    nomer = y;
                    count++;
                    break;
                }
            }
            if (boom == true)
            {
                for (int P = nomer; P < matrix.GetLength(0) - 1; P++)
                {
                    for (int y1 = 0; y1 < matrix.GetLength(1); y1++)
                    {
                        matrix[P, y1] = matrix[P + 1, y1];
                    }
                }
            }
        }
        System.Console.WriteLine(count);
        int[,] kek = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        for (int i = 0; i < kek.GetLength(0); i++)
        {

            for (int j = 0; j < kek.GetLength(1); j++)
            {
                kek[i, j] = matrix[i, j];
            }
        }
        matrix = kek;
        // end

        return matrix;
    }
    #endregion
}