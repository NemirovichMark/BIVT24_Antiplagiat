using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
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
        int strok = A.GetLength(0);
        int dlin = A.GetLength(1);
        for (int i = 0; i < strok; i++)
        {
            for (int g = 0; g < dlin; g++)
            {
                answer += A[i, g];
            }
        }
        // end
        //Console.WriteLine(A.GetLength(1));
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
        int row = 0, col = 0, min = 1010101010;

        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int g = 0; g < A.GetLength(1); g++)
            {
                if (A[i, g] < min) { min = A[i, g]; row = i; col = g; }
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 3 || n != 5) return null;

        int[] answer = new int[A.GetLength(1)];
        int maxim = -10101;
        // code here

        for (int i = 0; i < A.GetLength(1);i++)
        {
            for (int g = 0; g < A.GetLength(0); g++)
            {
                if (A[g,i]>maxim) maxim = A[g,i];
            }
            answer[i] = maxim;
            maxim = -10101;
        }
        for (int h = 0; h < answer.Length; h++)
        {
            Console.WriteLine(answer[h]);
        }
        //end

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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 7) return null;

        int minim = 10101, minim_ind = 0, temp = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] < minim)
            {
                minim = A[i, 2];
                minim_ind = i;
            }
        }
        Console.WriteLine(minim_ind);
        for (int g = 0; g < A.GetLength(1); g++)
        {
            temp = A[minim_ind, g];
            A[minim_ind, g] = A[3, g];
            A[3, g] = temp;
        }
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

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 5) return null;

        int maxim = -10101; int maxim_stolb = 0;
        int stolb = 0, strok = 0, temp = 0;
        // code here
        while (true)
        {
            if (stolb < A.GetLength(0))
            {
                if (A[strok, stolb] > maxim)
                {
                    maxim = A[strok, stolb];
                    maxim_stolb = stolb;
                }
                stolb++;
                strok++;
            }
            else break;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            //if (A[i,maxim_stolb] == 0) return null;
            temp = A[i, maxim_stolb];
            A[i, maxim_stolb] = A[i,3];
            A[i, 3] = temp;
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
        int[,] matrix = new int[n, m];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxim = -10101, maxim_ind = 0;
            for (int g = 0; g < A.GetLength(1); g++)
            {
                if (A[i, g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = g;
                }
            }
            bool flag = true;
            int schet = 0;
            for (int g = 0; g < m; g++)
            {
                if (maxim != A[i, g])
                {
                    matrix[i, schet] = A[i, g];
                    schet++;
                }
                else if (maxim_ind == A.GetLength(1) - 1)
                {
                    matrix[i, schet] = A[i, g];
                    schet++;
                }
                else if (flag == true)
                {
                    matrix[i, schet] = A[i, g];
                    flag = false;
                    //schet++;
                    matrix[i, A.GetLength(1) - 1] = maxim;
                }
            }

        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
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
        for (int i = 0; i < C.GetLength(0); i++)
        {
            int maxim_ind = 0; double maxim = -101010;
            for (int g = 0; g < C.GetLength(1); g++)
            {
                if (C[i, g] > maxim)
                {
                    maxim = C[i, g];
                    maxim_ind = g;
                }
            }
            for (int g = 0; g < maxim_ind; g++)
            {
                if (C[i, g] < 0) C[i, g] /= maxim;
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
        double schet_pol = 0; double sr_arifm = 0;
        int m = Z.GetLength(0), n = Z.GetLength(1);
        if (m != 6 || n != 8) return null;

        // code here
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int g = 0; g < Z.GetLength(1); g++)
            {
                if (Z[i, g] > 0)
                {
                    sr_arifm += Z[i, g];
                    schet_pol++;
                }
            }
        }
        sr_arifm = Math.Round(sr_arifm / schet_pol, 2);
        double maxim = -1010101; int maxim_y = 0, maxim_x = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int g = 0; g < Z.GetLength(1); g++)
            {
                if (Z[i, g] > maxim)
                {
                    maxim = Z[i, g];
                    maxim_y = i;
                    maxim_x = g;
                }
                
            }
        }
        // end
        Console.WriteLine(maxim);
        Z[maxim_y, maxim_x] = sr_arifm;
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
        int minim = 10000, maxim = -10000, minim_ind = 0, maxim_ind = 0;
        // code here
        int m = X.GetLength(0), n = X.GetLength(1);
        if (m != 6 || n != 5) return null;

        for (int i = 0; i < X.GetLength(0); i++)
        {
            int schet = 0;
            for (int g = 0; g < X.GetLength(1); g++)
            {
                if (X[i, g] < 0)
                {
                    schet++;
                }
            }
            if (schet < minim)
            {
                minim_ind = i;
                minim = schet;
            }
            if (schet > maxim)
            {
                maxim_ind = i;
                maxim = schet;
            }

        }
        int temp = 0;
        for (int g = 0; g < X.GetLength(1); g++)
        {
            temp = X[maxim, g];
            X[maxim,g] = X[minim_ind,g];
            X[minim_ind, g] = temp;
        }
        // end
        Console.WriteLine($"{maxim_ind} + {maxim} and {minim_ind} + {minim}");
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 7 || n != 5) return null;

        int pol_ind = 0; int maxim = -1010101;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int g = 0; g < A.GetLength(1); g++)
            {
                if (A[i, g] > 0)
                {
                    sum += A[i, g];
                }
            }
            if (sum > maxim)
            {
                maxim = sum;
                pol_ind = i;
            }
        }
        // end
        int schet = 0;
        int[,] itog = new int[A.GetLength(0)-1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int g = 0; g < itog.GetLength(1); g++)
            {
                itog[schet,g]= A[i,g];
            }
            if (i == 2)
            {
                i++;
            }
            schet++;
        }
        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"{maxim} + {pol_ind}");
        return itog;            
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 8 || B.Length!=5) return null;

        int min = 1010101; int min_ind = 0;
        // code here
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                min_ind = i;
            }
        }
        Console.WriteLine(min);
        if (min_ind != A.GetLength(1) - 1)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, min_ind + 1] = B[i];
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
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 5 || n != 7) return null;

        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxim = -10101;int maxim_ind = 0;
            for (int g = 0; g < A.GetLength(1); g++)
            {
                if (A[i, g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = g;
                }
            }
            if (maxim_ind == 0)
            {
                if (A[i, 1]>0)
                    A[i, 1] *= 2;
                else
                    A[i, 1] /= 2;
            }
            else if (maxim_ind == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0)
                    A[i, A.GetLength(1) - 2] *= 2;
                else
                    A[i, A.GetLength(1) - 2] /= 2;
            }
            else if (A[i, maxim_ind - 1] > A[i, maxim_ind + 1])
            {
                if (A[i, maxim_ind + 1] > 0)
                    A[i, maxim_ind + 1] *= 2;
                else
                    A[i, maxim_ind + 1] /= 2;
            }
            else
            {
                if (A[i, maxim_ind - 1] > 0)
                    A[i, maxim_ind - 1] *= 2;
                else
                    A[i, maxim_ind - 1] /= 2;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 7 || n != 5) return null;

        // code here
        for (int g = 0; g < A.GetLength(1); g++)
        {
            int maxim = -1010101, maxim_ind = 0, schet_pol = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = i;
                }
                if (A[i, g] > 0)
                {
                    schet_pol++;
                }
            }
            if (schet_pol >= 4)
            {
                A[maxim_ind, g] = 0;
            }
            else
            {
                A[maxim_ind, g] = maxim_ind;
            }
        }
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 10 || n != 5) return null;
        for (int g = 0; g < A.GetLength(1); g++)
        {
            int maxim = -10101, maxim_ind = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = i;
                }
            }
            for (int i = maxim_ind+1; i < A.GetLength(0); i++)
            {
                sum += A[i, g];
            }
            if (maxim_ind <= 4)
            {
                A[0, g] = sum;
            }
            else continue;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 7 || n != 5 || B.Length!=5) return null;

        for (int g = 0; g < A.GetLength(1); g++)
        {
            int maxim = -10101, maxim_ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = i;
                }
            }
            if (B[g]>maxim)
            {
                A[maxim_ind, g] = B[g];
            }
        }
        // end
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 7 || n != 5) return null;
        // code here
        for (int g = 0; g < A.GetLength(1); g++)
        {
            double maxim = -10101;int maxim_ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, g] > maxim)
                {
                    maxim = A[i, g];
                    maxim_ind = i;
                }
            }
            if (maxim < (A[0, g] + A[A.GetLength(0) - 1, g]) / 2)
            {
                A[maxim_ind, g] = (A[0, g] + A[A.GetLength(0) - 1, g]) / 2;
            }
            else
            {
                A[maxim_ind, g] = maxim_ind;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n,3*n];
        // code here
        int edin = 2;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
           int schet = edin;
           for (int g = 0; g < answer.GetLength(1); g++)
            {
                if (schet == 2)
                {
                    answer[i, g] = 1;
                    schet = 0;
                }
                else
                {
                    answer[i, g] = 0;
                    schet++;
                }
            }
            edin--;
        }
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                Console.Write($"{answer[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 6) return null;
        int ixs = 0;
        int maxim = -101010, maxim_x = 0, maxim_y = 0;
        // code here
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxim)
            {
                maxim = A[i, i];
                maxim_x = i;
                maxim_y = i;
            }

        }
        for (int i = 0; i < maxim_y; i++)
        {
            ixs++;
            for (int g = ixs; g < A.GetLength(1); g++)
            {
                A[i, g] = 0;
            }
        }
        Console.WriteLine(maxim);
        Console.WriteLine(maxim_x);
        Console.WriteLine(maxim_y);
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        int m = B.GetLength(0), n = B.GetLength(1);
        if (m != 6 || n != 6) return null;
        // code here
        for (int i = 0; i < B.GetLength(0);i+=2)
        {
            int temp = 0; int maxim1 = -1010101; int maxim2 = -101010; int maxim1_ind = 0; int maxim2_ind = 0;
            for (int g = 0; g < B.GetLength(1); g++)
            {
                if (B[i, g] > maxim1)
                {
                    maxim1 = B[i, g];
                    maxim1_ind = g;
                }
            }
            for (int g = 0; g < B.GetLength(1); g++)
            {
                if (B[i+1, g] > maxim2)
                {
                    maxim2 = B[i+1, g];
                    maxim2_ind = g;
                }
            }
            temp = B[i, maxim1_ind];
            B[i, maxim1_ind] = B[i + 1, maxim2_ind];
            B[i + 1, maxim2_ind] = temp;
        }
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(B.GetLength(0));
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 7) return null;

        int[,] itog = new int[m, n];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int schet = 0;
            for (int g = n - 1; g >= 0; g--)
            {
                itog[i, schet] = A[i, g];
                schet++;
            }
        }
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return itog;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        if (m != n && m<=2) return null;
        int schet = 0; bool flag1 = false, flag2 = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 && schet != matrix.GetLength(1) - 1 && flag1==false)
            {
                matrix[i, schet] = 0;
                matrix[matrix.GetLength(0) - 1, schet] = 0;
                schet++;
                i--;
            }
            else
            {
                flag1 = true;
                schet = 0;
            }
            if (i != -1 && i != matrix.GetLength(1) - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, matrix.GetLength(1) - 1] = 0;
            }
        }
        matrix[matrix.GetLength(0) - 1, matrix.GetLength(1)-1] = 0;
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
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
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        if (m != n && m <= 2) return null;
        int sred = 0;
        // code here
        if (matrix.GetLength(0) / 2 % 2 == 0)
        {
            sred = matrix.GetLength(0) / 2;
        }
        else
        {
            sred = matrix.GetLength(0) / 2;
        }
        for (int i = sred; i < matrix.GetLength(0); i++)
        {
            for (int g = 0; g <= sred; g++)
            {
                matrix[i, g] = 1;
            }
            sred++;
        }

        Console.WriteLine(sred);
        // end
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
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
        // code here
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        if (m != n && m <= 2) return (null, null);
        int upper_schet=0,lower_schet=0;
        int diag = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (g >= diag)
                {
                    upper_schet++;
                }
                else
                {
                    lower_schet++;
                }
            }
            diag++;
        }
        diag = 0;
        Console.WriteLine($"{upper_schet} и {lower_schet}");
        int[] upper = new int[upper_schet];
        int[] lower = new int[lower_schet];
        upper_schet = 0; lower_schet = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (g >= diag)
                {
                    upper[upper_schet] = matrix[i,g];
                    upper_schet++;
                }
                else
                {
                    lower[lower_schet] = matrix[i, g];
                    lower_schet++;
                }
            }
            diag++;
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
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        if (m != 7 || n != 5) return null;
        int[,] itog = new int[m,n];
        int[,] massiv_temp = new int[matrix.GetLength(0),2];
        int schet_temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            schet_temp = 0;
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (matrix[i, g] >= 0)
                {
                    schet_temp++;
                }
            }
            massiv_temp[i, 0] = schet_temp;
            massiv_temp[i, 1] = i;
        }
        int maxim = 0, maxim_y = 0, maxim_x = 0;
        bool ind = true;
        for (int i = 0; i < matrix.GetLength(0);i++)
        {
            ind = false;
            for (int h = 0; h < matrix.GetLength(0); h++)
            {
                if (massiv_temp[h, 0] > maxim)
                {
                    ind = true;
                    maxim = massiv_temp[h, 0];
                    maxim_y = massiv_temp[h, 1];
                    maxim_x = h;
                }
            }
            massiv_temp[maxim_x, 0] = 0;
            //Console.WriteLine(maxim);
            //Console.WriteLine(maxim_y);
            if (ind == false)
            {
                break;
            }
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                itog[i, g] = matrix[maxim_y, g];
            }
            maxim = 0;
            maxim_x = 0;
            maxim_y = 0;
        }

        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }
        return itog;
        // end

    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        int[] array = { 5, 3, 1, 7, 9, 2 };
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);

        foreach (int num in array)
        {
            Console.WriteLine(num);
        }

        //end
        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        for (int g = 0; g < matrix.GetLength(0); g++)
        {
            if (g % 2 == 0)
            {
                bool swapped;
                do
                {
                    swapped = false;
                    for (int i = 0; i < matrix.GetLength(1)-1; i++)
                    {
                        if (matrix[g,i] < matrix[g,i + 1])
                        {
                            int temp = matrix[g,i];
                            matrix[g,i] = matrix[g,i + 1];
                            matrix[g,i + 1] = temp;
                            swapped = true;
                        }
                    }
                } while (swapped);
            }
            else
            {
                bool swapped;
                do
                {
                    swapped = false;
                    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[g, i] > matrix[g, i + 1])
                        {
                            int temp = matrix[g, i];
                            matrix[g, i] = matrix[g, i + 1];
                            matrix[g, i + 1] = temp;
                            swapped = true;
                        }
                    }
                } while (swapped);
            }
        }
        // end
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {

        int schet = 0;
        // code here
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = false;
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (matrix[i, g] == 0)
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                schet++;
            }
        }
        Console.WriteLine(schet);
        int[,] itog = new int[matrix.GetLength(0)-schet, matrix.GetLength(1)];
        int schet_itog = 0;
        // end
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = false;
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (matrix[i, g] == 0)
                    {
                        flag = true;
                    }
            }
            if (flag == false)
                {
                    for (int g = 0; g < matrix.GetLength(1); g++)
                    {
                        itog[schet_itog, g] = matrix[i, g];

                    }
                    schet_itog++;
                }
        }
        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }
        return itog;
    }
    #endregion
}