using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        double chet = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    chet++;
                }
            }
        }
        if (chet != 0)
        {
            answer /= chet;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0, 0);
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
        double[] answer = new double[4];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;

        int gen = 0;

        for (int i = 0; i < 4; i++)
        {
            double sum = 0;
            int centr = 0;
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    centr++;
                }
            }
            answer[gen] = (centr != 0) ? sum / centr : 0;
            gen++;
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
        int[,] yur = new int[4, 7];
        int rr = int.MaxValue, rr2 = -1;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 0] < rr)
            {
                rr = A[i, 0];
                rr2 = i;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (i == rr2) continue;
            for (int j = 0; j < 7; j++)
            {
                yur[(i < rr2) ? i : i - 1, j] = A[i, j];
            }
        }

        return yur;
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
        int[] answer = new int[3];
        // code here
        int r  = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (A[j, i] < 0) 
                    r ++;
            }
            answer[i] = r;
            r = 0;
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        int[] d = new int[n];
        int min = int.MaxValue;
        int imin = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    imin = j;
                }

            }

            d[i] = imin;
            min = int.MaxValue;
            imin = 0;

        }
       
        for (int i = 0; i < n; i++)
        {
            int p = B[i, d[i]];
            for (int j = 0; j < d[i]; j++)
            {

                B[i, d[i] - j] = B[i, d[i] - j - 1];


            }
            B[i, 0] = p;
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

        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            double maxElem = double.MinValue;
            int maxIdx = -1;
            int firstNeg = -1, lastNeg = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxElem)
                {
                    maxElem = F[i, j];
                    maxIdx = j;
                }
                if (F[i, j] < 0)
                {
                    if (firstNeg == -1)
                    {
                        firstNeg = j;
                    }
                    lastNeg = j;
                }
                
            }
            if (firstNeg == -1)
                continue;
            F[i, maxIdx] = (F[i, firstNeg] + F[i, lastNeg]) / 2.0;

            
            
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return (null);
        int[] fer = new int[5];
        int max = int.MinValue;
        int imax = -1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    imax = j;
                }

            }

            fer[i] = imax;
            max = int.MinValue;
            imax = 0;
        }
        int p;
        for (int i = 0; i < 5; i++)
        {

            for (int j = 0; j < 7; j++)
            {
                if (j < 6 - fer[i]) G[i, 6 - j] = G[i, 6 - j - 1];


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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return (null);
        int max = int.MinValue;
        int imax = -1;

        for (int i = 0; i < 5; i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                imax = i;
            }

        }
        for (int j = 0; j < 7; j++) A[imax, j] = B[j];
        for (int i = 0; i < 5; i++) for (int j = 0; j < 7; j++) Console.WriteLine(A[i, j]);
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return (null);
        int min = int.MaxValue;
        int imin = -1;

        for (int i = 0; i < 7; i++)
        {
            if (Math.Abs(F[1, i]) < min)
            {
                min = Math.Abs(F[1, i]);
                imin = i;
            }

        }
        int[,] B = new int[5, 6];
        // end
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j <= imin) B[i, j] = F[i, j];
                else if (j > imin + 1) B[i, j - 1] = F[i, j];


            }
        }
        return B;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return (null);
        double max = double.MinValue;
        int imax = -1;
        double sum = 0;
        int col = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    col += 1;
                }

            }
            if (col == 0) col = 1;
            A[i, imax] = sum / col;
            sum = 0;
            col = 0;
            max = double.MinValue;


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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        
        
        
        
        
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int cnt = 0;double max = double.MinValue;int max_index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = j;
                }
            }
            if (max_index == A.GetLength(1) - 1 || A[i, max_index - 1] < A[i, max_index + 1])
            {
                double elem = A[i, max_index - 1];
                if (elem < 0) 
                    A[i, max_index - 1] /= 2;
                else 
                    A[i, max_index - 1] *= 2;
            }
            else if (max_index == 0 || A[i, max_index + 1] < A[i, max_index - 1])
            {
                double elem = A[i, max_index + 1];
                if (elem < 0) 
                    A[i, max_index + 1] /= 2;
                else 
                    A[i, max_index + 1] *= 2;
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
            int pol = 0, otr = 0, max = int.MinValue, maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) otr++;
                if (A[i, j] > 0) pol++;
                if (A[i, j] > max) { maxi = i; max = A[i, j]; }

            }
            if (pol > otr) A[maxi, j] = 0; 
            else A[maxi,j] = maxi+1;
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
            int max_index = 0, s = 0, max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                    s = 0;
                    continue;
                }
                s += A[i, j];
            }
            if (max_index < A.GetLength(0) / 2) A[0, j] = s;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0, max =int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max) { max = A[i, j];
                    maxi = i;
                }
            }
            if (A[maxi, j] < B[j]) A[maxi, j] = B[j];
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
            int max_index = 0;double max =double.MinValue;
            double s = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index = i;
                }
            }
            if (A[max_index, j] < s) A[max_index, j] = s;
            else A[max_index, j] = max_index+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here
        
        
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < n; i++)
            {
                answer[i, i + (n * j)] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int max_index = 0, max = int.MinValue;
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        for (int i = 1; i < A.GetLength(0); i++)
        {
            
            if (A[i, i] > max)
            {
                max = A[i, i];
                max_index = i;
            }
        }

        for (int i = 0; i < max_index; i++)
        {
            for (int j = i + 1; j < A.GetLength(0); j++) A[i, j] = 0;
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return (null);
        int[] ind = new int[6];
        int inr = -1;
        for (int I = 0; I < 6; I++)
        {
            int max = int.MinValue;
            for (int j = 0; j < 6; j++)
            {
                if (B[I, j] > max)
                {
                    max = B[I, j];
                    inr = j;
                }
            }
            ind[I] = inr;
        }
        int temp = 0;
        for (int i = 0; i < 6; i += 2)
        {
            temp = B[i, ind[i]];
            B[i, ind[i]] = B[i + 1, ind[i + 1]];
            B[i + 1, ind[i + 1]] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null ;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int ii = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = ii;
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

        int[,] data = new int[matrix.GetLength(0), 2];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min) min = matrix[i, j];
            }
            data[i, 0] = i;
            data[i, 1] = min;
        }

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (data[j, 1] < data[j + 1, 1])
                {
                    int tmp1 = data[j, 0];
                    int tmp2 = data[j, 1];

                    data[j, 0] = data[j + 1, 0];
                    data[j, 1] = data[j + 1, 1];

                    data[j + 1, 0] = tmp1;
                    data[j + 1, 1] = tmp2;
                }
            }
        }

        int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[data[i, 0], j];
            }
        }

        matrix = newMatrix;
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
        
        
        
        if (matrix.GetLength(0) != matrix.GetLength(1)) return answer;

        answer = new int[2 * matrix.GetLength(0) - 1];
        for (int i = 0; i < 2 * matrix.GetLength(0) - 1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                answer[j - i + (matrix.GetLength(0) - 1)] += matrix[i, j];
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
        
        
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1) return null;

        int max = int.MinValue, ii = 0, jj = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    ii = i;
                    jj = j;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int P = matrix[ii, i];
            matrix[ii, i] = matrix[k - 1, i];
            matrix[k - 1, i] = P;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int P = matrix[i, ii];
            matrix[i, ii] = matrix[i, k - 1];
            matrix[i, k - 1] = P;
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
        
        if (A.Length + A.Length - n != n * n || B.Length + B.Length - n != n * n) return null;
        int[,] new_matrix = new int[n, n];
        int [,] new_matrix2 = new int[n, n];
        int[] result = new int[n * n];
        for (int i = 0, y = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                new_matrix[i, j] = A[y];
                new_matrix[j, i] = A[y];
                new_matrix2[i, j] = B[y];
                new_matrix2[j, i] = B[y];
                y++;
            }
        }

        for (int i = 0, y = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += new_matrix[i, j] * new_matrix2[j, k];
                }
                result[y] = s;
                y++;
            }
        }
        answer = result;

        for (int i = 0; i < n * n; i++)
        {
            Console.Write(result[i] + " ");
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

        int[,] pass = new int[matrix.GetLength(1), 2];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int otr = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] < 0) otr++;
            }
            pass[i, 0] = i;
            pass[i, 1] = otr;
        }

        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (pass[j, 1] > pass[j + 1, 1])
                {
                    int el = pass[j, 0];
                    int el1 = pass[j, 1];

                    pass[j, 0] = pass[j + 1, 0];
                    pass[j, 1] = pass[j + 1, 1];

                    pass[j + 1, 0] = el;
                    pass[j + 1, 1] = el1;
                }
            }
        }

        int[,] new_matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                new_matrix[j, i] = matrix[j, pass[i, 0]];
            }
        }

        matrix = new_matrix;
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
        int  count_0 = 0;
        int[] index = new int[matrix.GetLength(0)];

        for (int i = 0, ii = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    count_0++;
                    flag = false;
                    break;
                }
            if (!flag) 
                index[ii++] = i;
        }

        int[,] new_matrix = new int[matrix.GetLength(0) - count_0, matrix.GetLength(1)];

        for (int i = 0, ii = 0; i < matrix.GetLength(0); i++)
        {
            if (i == index[ii]) 
                ii++;
            else
                for (int j = 0; j < matrix.GetLength(1); j++) 
                    new_matrix[i, j] = matrix[i, j];

        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    #endregion
}


















//пузырьковая
//int n = array.Length
//;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n-i-1;j++)

//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//        }
//    }
//}

//гномья неефек
//int n = array.Length
//;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n - i - 1; j++)

//    {
//        if (array[j] > array[j + 1])
//        {
//            int temp = array[j];
//            array[j] = array[j + 1];
//            array[j + 1] = temp;
//        }
//    }
//}




//int n = array.Length
//;
//for (int i = 1; i < n; i++)
//{
//    int key = array[i], j = i- 1;
//    while (j >= 0 && array[j] > key)
//    {
//        array[j + 1] = array[j]; j--;
//    }
//    array[j + 1] = key;
//}

int n = arr.Length, gap = n / 2
;
while (gap > 0)
{
    for (int i = gap; i < n; i++)
    {
        int key = arr[i], j = i- gap;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + gap] = arr[j];
            j-= gap;
        }
        arr[j + gap] = key;
    }
    gap /= 2;
}

