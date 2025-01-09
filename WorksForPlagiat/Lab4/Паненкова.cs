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
        int p = A.GetLength(0), k = A.GetLength(1);
        // code here
        int sum = 0;
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                sum += A[i, g];
            }
        }
        // end
        return sum;
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
        int p = A.GetLength(0), k = A.GetLength(1);
        int row = 0, col = 0; int min = 999999;
        // code here
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (A[i, g] < min)
                {
                    min = A[i, g];
                    row = i; col = g;
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
        int p = A.GetLength(0), k = A.GetLength(1);
        int max = -99999;
        int[] answer = new int[k];
        // code here
        if (p != 3 || k != 5) 
            return null;
        for (int i = 0; i < k; i++)
        {
            for (int g = 0; g < p; g++)
            {
                if (A[g, i] > max)
                {
                    max = A[g, i];
                }
            }
            answer[i] = max;
            max = -99999;
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
        int p = A.GetLength(0), k = A.GetLength(1);
        int max = -99999, r = 0, vrem = 0;
        // code here
        if (p != 5 || k != 7)
            return null;
        for (int i = 0; i < p; i++)
        {
            if (A[i, 2] > max)
            {
                max = A[i, 2];
                r = i;
            }
        }
        for (int i = 0; i < k; i++)
        {
            vrem = A[r, i];
            A[r, i] = A[3, i];
            A[3, i] = vrem;
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
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        int max = 0, sc = 0;
        if (p != 5 || k != 5)
        {
            return null;
        }
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (i == g)
                {
                    if (A[i, g] > max)
                    {
                        sc = g;
                        max = A[i,g];
                    }
                }
            }
        }
        int[] mas = new int[A.GetLength(0)];
        int[] nmass = new int[A.GetLength(0)];
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (j == sc)
                {
                    mas[i] = A[i,j];
                } if (j == 3)
                {
                    nmass[i] = A[i,j];
                }
            }
        }

        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (j == sc)
                {
                    A[i, 3] = mas[i];
                }
                if (j == 3)
                {
                    A[i, sc] = nmass[i];
                }
            }
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
        int p = A.GetLength(0), k = A.GetLength(1);
        int[] output = new int[p];
        for (int i = 0; i < p; i++)
        {
            int maxi = -99999;
            for (int j = 0; j < k; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    output[i] = A[i, j];
                }
            }
        }
        int[,] massi = new int[p, k];
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (A[i, g] != output[i])
                {
                    massi[i, g] = A[i, g];
                }
                else
                {
                    for (int j = g+1; j < k; j++)
                    {
                        massi[i, g] = A[i, j];
                        g++;
                    }
                    massi[i, k-1]= output[i];
                }
            }
        }
        // end
        return massi;
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
        double p = C.GetLength(0), k = C.GetLength(1);
        double[] maxis = new double[n];
        int[] maxis_ind = new int[n];
        for (int i = 0; i < p; i++)
        {
            double maxi = -99999;
            int maxi_ind = 0;
            for (int j = 0; j < k; j++)
            {
                if (C[i, j] > maxi)
                {
                    maxi = C[i, j];
                    maxi_ind = j;
                }
            }
            maxis[i] = maxi;
            maxis_ind[i] = maxi_ind;
        }
        for (int i = 0; i < p; i++)
        {
            if (maxis[i] == 0)
            {
                break;
            }
            for (int j = 0; j < maxis_ind[i]; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j]/=maxis[i];
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
        double p = Z.GetLength(0), k = Z.GetLength(1);
        if (p != 6 || k != 8)
        {
            return null;
        }
        double sr_arifm = 0, schet = 0;
        int maxim_stolb = 0, maxim_str = 0;
        double maxim = -9999;
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (Z[i, j] > maxim)
                {
                    maxim = Z[i, j];
                    maxim_stolb = j;
                    maxim_str = i;
                }
                if (Z[i, j] > 0)
                {
                    sr_arifm += Z[i, j];
                    schet++;
                }
            }
        }
        sr_arifm /= schet;
        Z[maxim_str, maxim_stolb] = sr_arifm;
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
        int p = X.GetLength(0), k = X.GetLength(1);
        if (p != 6 || k != 5)
        {
            return null;
        }
        int[] max_otr =  new int[p];
        for (int i = 0; i < p; i++)
        {
            int otr = 0;
            for (int g = 0; g < k; g++)
            {
                if (X[i, g] < 0)
                {
                    otr++;
                }
            }
            max_otr[i] = otr;
        }
        int max = -9999; int maxi = 0;
        int min = 9999; int mini = 0;
        for (int i = 0; i < p; i++)
        {
            if (max_otr[i] > max)
            {
                max = max_otr[i];
                maxi = i;
            }
            if (max_otr[i] < min)
            {
                min = max_otr[i];
                mini = i;
            }
        }
        for (int g = 0; g < k; g++)
        {

            int vrem = X[maxi, g];
            X[maxi, g] = X[mini, g];
            X[mini, g] = vrem;
        }
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
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 7 || k != 5)
        {
            return null;
        }
        int[] max_pol = new int[p];
        for (int i = 0; i < p; i++)
        {
            int pol = 0;
            for (int g = 0; g < k; g++)
            {
                if (A[i, g] > 0)
                {
                    pol=+A[i, g];
                }
            }
            max_pol[i] = pol;
        }
        int max = 0, maxi = 0;
        for (int i = 0; i < max_pol.Length; i++)
        {
            if (max_pol[i] > max)
            {
                max = max_pol[i];
                maxi = i;
            }
        }
        int [,] novenkii = new int [p - 1,k];
        int schet = 0;
        for (int i = 0; i < p; i++)
        {
            if (i != maxi)
            {
                for (int g = 0; g < k; g++)
                {
                    novenkii[schet, g] = A[i, g];
                }
                schet++;
            }
            
        }
        // end
        return novenkii;
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
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 5 || k != 8)
        {
            return null;
        }
        if (B.Length != 5)
        {
            return null;
        }
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (g == 7)
                {
                    A[i, g] = B[i];
                }
            }
        }
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                Console.WriteLine($"{A[i,g]}");
            }
            Console.WriteLine();
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
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 5 || k != 7)
        {
            return null;
        }
        int maxii = 0;
        double maxi = -999999; int ind = 0;
        for (int i = 0; i < p; i++)
        {
            maxi = -999999; ind = 0;
            for (int g = 0; g < k; g++)
            {
                if (A[i, g] > maxi)
                {
                    maxi = A[i, g];
                    maxii = g;
                }
            }
            if (maxii == 0)
            {
                if (A[i, 1] > 0)
                    A[i, 1] *= 2;
                else
                    A[i, 1] /= 2;
            }
            if (maxii == 6)
            {
                if (A[i, 5] > 0)
                    A[i, 5] *= 2;
                else
                    A[i, 5] /= 2;
            }
            else if (A[i, maxii - 1] > A[i, maxii + 1])
            {
                if (A[i, maxii + 1] > 0)
                    A[i, maxii + 1] *= 2;
                else
                    A[i, maxii + 1] /= 2;
            }
            else
            {
                if (A[i, maxii - 1] > 0)
                    A[i, maxii - 1] *= 2;
                else
                    A[i, maxii - 1] /= 2;
            }
        }
        // end
        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 7 || k != 5)
        {
            return null;
        }
        for (int j = 0; j < k; j++)
        {
            int schpol = 0, schotr = 0, max = -99999;
            int indstr = 0;
            for (int i = 0; i < p; i++)
            {
                if (A[i,j] > 0)
                {
                    schpol++;
                    if (A[i,j] > max)
                    {
                        max = A[i, j];
                        indstr = i;
                    }
                }
                else
                {
                    schotr++;
                }
            }
            if (schpol > schotr)
            {
                A[indstr, j] = 0;
            }
            else
            {
                A[indstr, j] = indstr+1;
            }
        }
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.WriteLine($"{A[i,j]}");
            }
            Console.WriteLine();
        }
        // end
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 10 || k != 5)
        {
            return null;
        }
        for (int j = 0; j < k; j++)
        {
            int maxim = -10101, maxim_ind = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] > maxim)
                {
                    maxim = A[i, j];
                    maxim_ind = i;
                }
            }
            for (int i = maxim_ind + 1; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
            }
            if (maxim_ind <= 4)
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
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 7 || k != 5 || B.Length!=5)
        {
            return null;
        }
        for (int i = 0; i < k; i++)
        {
            int max = -999999, nomer = 0;
            for (int j = 0; j < p; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    nomer = j;
                }
            }
            if (B[i] > max)
            {
                A[nomer,i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 7 || k != 5)
        {
            return null;
        }
        for (int i = 0; i < k; i++)
        {
            double maxi = -99999, polusum =0;
            int ind = 0;
            for (int j = 0; j < p; j++)
            {
                polusum = 0;
                polusum = (A[0,i] + A[6,i])/2;
                if (A[j, i] > maxi)
                {
                    maxi = A[j, i];
                    ind = j;
                }
            }
            if (maxi<polusum)
            {
                A[ind,i] = polusum;
            }
            else
            {
                A[ind, i] = ind+1;
            }
        }
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.WriteLine($"{A[i, j]}");
            }
            Console.WriteLine();
        }
        // end
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        int p = n; int k = 3 * n;
        if (p != n || k != 3*n || n<=0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];
        int f = 2;
        for (int i = 0; i < p; i++)
        {
            int l = f;
            for (int j = 0; j < k; j++)
            {
                if (l == 2)
                {
                    answer[i, j] = 1;
                    l = 0;
                }
                else
                {
                    answer[i, j] = 0;
                    l++;
                }
            }
            f--;
        }

        // end
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 6 || k != 6)
        {
            return null;
        }
        int maxi = -99999, maxii = 0;
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (i == j)
                {
                    if (A[i, j] > maxi)
                    {
                        maxi = A[i, j];
                        maxii = i;
                    }
                }
            }
        }
        int f = 0;
        for (int i = 0; i < maxii; i++)
        {
            f++;
            for (int j = f; j < k; j++)
            {
                A[i, j] = 0;
            }
        }
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.WriteLine($"{A[i, j]}");
            }
            Console.WriteLine();
        }
        // end
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int p = B.GetLength(0), k = B.GetLength(1);
        if (p != 6 || k != 6)
        {
            return null;
        }
        int maxi = -99999;
        int[] nov = new int[6];
        int[] maxii = new int[6];
        for (int i = 0; i < p; i++)
        {
            maxi = -99999;
            for (int j = 0; j < k; j++)
            {
                if (B[i, j] > maxi)
                {
                    maxi = B[i, j];
                    nov[i] = j;
                    maxii[i] = maxi;
                }
            }
        }
        for (int i = 0; i < p; i+=2)
        {
            B[i, nov[i]] = maxii[i + 1];
            B[i + 1, nov[i + 1]] = maxii[i];
        }
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.WriteLine($"{B[i, j]}");
            }
            Console.WriteLine();
        }
        // end
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int p = A.GetLength(0), k = A.GetLength(1);
        if (p != 6 || k != 7)
        {
            return null;
        }
        int[,] novenkii = new int[p, k];
        for (int i = 0; i < p; i++)
        {
            int g = 0;
            for (int j = k-1; j >= 0; j--)
            {
                novenkii[i,j] = A[i,g];
                g++;
            }
        }
        // end
        return novenkii;
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
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        if (p != k && p <= 2)
        {
            return null;
        }
        int sh = 0; bool prov = false;
        for (int i = 0; i < p; i++)
        {
            if (i == 0 && sh != k - 1 && prov == false)
            {
                matrix[i, sh] = 0;
                matrix[p - 1, sh] = 0;
                sh++;
                i--;
            }
            else
            {
                prov = true;
                sh = 0;
            }
            if (i != -1 && i != k - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, p - 1] = 0;
            }
        }
        matrix[p - 1, k - 1] = 0;
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
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        if (p != k && p <=2)
        {
            return null;
        }
        int sh = k / 2;
        for (int i = p / 2; i < p; i++)
        {
            for (int j = 0; j <= sh; j++)
            {
                matrix[i, j] = 1;
            }
            sh++;
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
        // code here
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        if (p != k && p <= 2)
        {
            return (null, null);
        }
        int uppermas = 0, lowermas = 0;
        int d = 0;
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (g >= d)
                {
                    uppermas++;
                }
                else
                {
                    lowermas++;
                }
            }
            d++;
        }
        d = 0;
        int[] upper = new int[uppermas];
        int[] lower = new int[lowermas];
        uppermas = 0; lowermas = 0;
        for (int i = 0; i < p; i++)
        {
            for (int g = 0; g < k; g++)
            {
                if (g >= d)
                {
                    upper[uppermas] = matrix[i, g];
                    uppermas++;
                }
                else
                {
                    lower[lowermas] = matrix[i, g];
                    lowermas++;
                }
            }
            d++;
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
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        if (p != 7 || k != 5)
        {
            return null;
        }
        int[,] novenkii = new int[p, k];
        int[,] massi = new int[p, 2];
        int sh = 0;
        for (int i = 0; i < p; i++)
        {
            sh = 0;
            for (int g = 0; g < k; g++)
            {
                if (matrix[i, g] >= 0)
                {
                    sh++;
                }
            }
            massi[i, 0] = sh;
            massi[i, 1] = i;
        }
        int maxi = 0, maxii = 0, maxij = 0;
        bool prov = true;
        for (int i = 0; i < p; i++)
        {
            prov = false;
            for (int j = 0; j < p; j++)
            {
                if (massi[j, 0] > maxi)
                {
                    prov = true;
                    maxi = massi[j, 0];
                    maxii = massi[j, 1];
                    maxij = j;
                }
            }
            massi[maxij, 0] = 0;
            if (prov == false)
            {
                break;
            }
            for (int g = 0; g < k; g++)
            {
                novenkii[i, g] = matrix[maxii, g];
            }
            maxi = 0;
            maxij = 0;
            maxii = 0;
        }
        return novenkii;
        // end
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
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        for (int g = 0; g < p; g++)
        {
            if (g % 2 == 0)
            {
                bool pomen;
                do
                {
                    pomen = false;
                    for (int i = 0; i < k - 1; i++)
                    {
                        if (matrix[g, i] < matrix[g, i + 1])
                        {
                            int vrem = matrix[g, i];
                            matrix[g, i] = matrix[g, i + 1];
                            matrix[g, i + 1] = vrem;
                            pomen = true;
                        }
                    }
                } while (pomen);
            }
            else
            {
                bool pomen;
                do
                {
                    pomen = false;
                    for (int i = 0; i < k - 1; i++)
                    {
                        if (matrix[g, i] > matrix[g, i + 1])
                        {
                            int vrem = matrix[g, i];
                            matrix[g, i] = matrix[g, i + 1];
                            matrix[g, i + 1] = vrem;
                            pomen = true;
                        }
                    }
                } while (pomen);
            }
        }
        // end
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int p = matrix.GetLength(0), k = matrix.GetLength(1);
        int sh = 0;
        // code here
        for (int i = 0; i < p; i++)
        {
            bool nuli = false;
            for (int j = 0; j < k; j++)
            {
                if (matrix[i, j] == 0)
                {
                    nuli = true;
                }
            }
            if (nuli == true)
            {
                sh++;
            }
        }
        int[,] novenkii = new int[p - sh, k];
        int shnovenkii = 0;
        for (int i = 0; i < p; i++)
        {
            bool nul = false;
            for (int j = 0; j < k; j++)
            {
                if (matrix[i, j] == 0)
                {
                    nul = true;
                }
            }
            if (nul == false)
            {
                for (int j = 0; j < k; j++)
                {
                    novenkii[shnovenkii, j] = matrix[i, j];
                }
                shnovenkii++;
            }
        }
        return novenkii;
        // end+
    }
    #endregion
}