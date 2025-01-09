using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Sockets;
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
        int n = A.GetLength(0), k = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                }
            }

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
        int[] answer = default(int[]);
        // code here

        int n = A.GetLength(0), k = A.GetLength(1);
        if (n != 4 || k != 7)
        {
            return null;
        }
        answer = new int[4];
        for (int i = 0; i < n; i++)
        {
            double min = 100000;
            int index = 0;
            for (int j = 0; j < k; j++)
            {
                if (A[i,j] < min)
                {
                    min = A[i,j];
                    index = j;
                }
                answer[i] = index;
            }
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
        int n = A.GetLength(0), k = A.GetLength(1), index = 0;
        if (n != 5 || k != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int max = -100000;
            int vrem = 0;
            for (int j = 0; j < k; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    index = j;
                }
            }
            vrem = A[i, index];
            A[i, index] = A[i, 0];
            A[i, 0] = vrem;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        int max = -100000; int maxY = 0, maxX = 0;
        if (A.GetLength(0) != 6 ||  A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j < m; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    maxY = i;
                    maxX = j;
                }
            }
        }
        Console.WriteLine(max);
        int[,] N = new int[n-1, m-1];
        int schetX = 0, schetY = 0;
        for (int i = 0; i < n; i++)
        {
            if (maxY != i)
            {
                for (int j = 0; j < m; j++)
                {
                    if (maxX != j)
                    {
                        N[schetX,schetY] = A[i,j];
                        schetY++;
                    }
                }
                schetY = 0;
                schetX++;
            }
        }
        // end
        
        return N;
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
        int n = A.GetLength(0), k = A.GetLength(1);
        
        if (n != 5 || k != 7)
        {
            return null;
        }
        
        for (int i = 0; i < n; i++)
        {
            int index = 0;
            int max = -100000;
            for (int j = 0; j < k; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    index = j;
                    
                }
            }
            A[i, index] = max * (i+1);           
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
        int[] maxi = new int[D.GetLength(1)];
        int[] in_max = new int[D.GetLength(1)];
        int[] per_otr = new int[D.GetLength(1)];
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = -100000, index_max = 0;
            int p_otr = 0, index_p_otr = 0;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] > max) 
                {
                    max = D[i, j];
                    index_max = j;
                }
                
                if (D[i, j] < 0)
                {
                    p_otr = D[i, j];
                    index_p_otr = j;
                    break;
                }
            }
            per_otr[i] = p_otr;
            maxi[i] = max;
            in_max[i] = index_max;
            //Console.WriteLine(maxi[i]);
            //Console.WriteLine(per_otr[i]);
        }
        int[] otri = new int[D.GetLength(1)];
        int[] otr2 = new int[D.GetLength(1)];
        for (int i = 0; i < D.GetLength(0); i++)
        {
            int otr1 = 0, index_otr = 0;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i,j] < 0)
                {
                    otr1 = D[i, j];
                    index_otr = j;
                    
                }
            }
            otr2[i] = otr1;
            otri[i] = index_otr;
            //Console.WriteLine(otr2[i]);
        }
        int[,] mas = new int[D.GetLength(0), D.GetLength(1)];
        for (int i = 0; i < D.GetLength(0); i++)
        {
            for (int j = 0; j < D.GetLength(1); j++)
            {
                
                if (j == otri[i] && maxi[i] != per_otr[i])
                {
                    mas[i, j] = maxi[i];
                }
                else if (j == in_max[i] && maxi[i] != per_otr[i])
                {
                    mas[i, j] = otr2[i];
                    
                }
                else 
                {
                    mas[i, j] = D[i, j];
                }
                if (otr2[i] == 0)
                {
                    mas[i, j] = D[i, j];

                }
                
            }
        }

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for(int g = 0; g < mas.GetLength(1); g++)
            {
                Console.Write($"{mas[i,g]} ");
            }
            Console.WriteLine();
        }


        // end

        return mas;
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
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null;
        }
        int[] maxi = new int[H.GetLength(1)];
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = -10000;
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }
            maxi[i] = max;
            //Console.WriteLine(maxi[i]);
        }
        int[,] mat = new int[H.GetLength(0), H.GetLength(1)];
        for (int i = 0; i < H.GetLength(0); i++)
        {
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (j == 5)
                {
                    mat[i, j] = maxi[i];
                }
                else if (j == 6)
                {
                    mat[i,j] = H[i,j-1];
                }
                else
                {
                    mat[i, j] = H[i, j];
                }
            }
        }
        for (int i = 0; i < H.GetLength(0); i++)
        {
            for (int g = 0; g < H.GetLength(1); g++)
            {
                Console.Write($"{mat[i, g]} ");
            }
            Console.WriteLine();
        }

        // end

        return mat;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return null;
        }
        int[] in_mx = new int[Y.GetLength(0)];
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = -100000;
            int ind_max = 0;
            
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i,j] > max)
                {
                    max = Y[i, j];
                    ind_max = j;
                }
            }
            in_mx[i] = ind_max;
            Console.WriteLine(max);
        }
        Console.WriteLine();
        
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double sum = 0, sr = 0;
            double k = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (j > in_mx[i])
                {
                    if (Y[i,j] > 0)
                    {
                        sum += Y[i, j];
                        k++;
                    }
                }
            }
            if (k == 0)
            {
                //Console.WriteLine(sr);
                for (int j = 0; j < in_mx[i]; j++)
                {
                    if (Y[i,j]<0)
                    {
                        Y[i, j] = 0;
                    }
                }
            }
            else
            {
                sr = Math.Round(sum / k, 2);
                for (int j = 0; j < in_mx[i]; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = sr;
                    }
                }
                //Console.WriteLine(sr);
            }
            //Console.WriteLine(sr_z[i]);
        }
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            for (int g = 0; g < Y.GetLength(1); g++)
            {
                Console.Write($"{Y[i, g]} ");
            }
            Console.WriteLine();
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
        {
            return null;
        }
        int[] mx = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = -100000;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i,j] > max)
                {
                    max = B[i,j];
                }
            }
            mx[i] = max;
            Console.WriteLine(max);
        }
        int k = 4;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j == 3)
                {
                    B[i, j] = mx[k];
                    k--;
                }
            }
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
        int max = -10000, ind = 0, ind2 = 0;
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (B[i,j] > max)
                    {
                        max = B[i,j];
                        ind = i;
                    }
                }
            }
            
        }
        Console.WriteLine(ind);
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j == 2)
                {
                    if (B[i, j] < 0)
                    {
                        ind2 = i;
                        
                    }

                }
                break;
            }
        }
        Console.WriteLine(ind2);
        int[] mas = new int[B.GetLength(1)];
        int[] ms = new int[B.GetLength(1)];
        int shet = 0, shet2 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i == ind)
                {
                    mas[shet] = B[i, j];
                    shet++;
                }
                if (i == ind2)
                {
                    ms[shet2] = B[i, j];
                    shet2++;
                }
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i == ind2)
                {
                    B[i, j] = mas[j];
                }
                if (i == ind)
                {
                    B[i, j] = ms[j];
                }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }
        }
        
        answer = new int[k];
        int shet = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] < 0)
                {
                    answer[shet] = A[i,j];
                    shet++;
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
        int[] ind = new int[A.GetLength(0)];
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0;i < A.GetLength(0); i++)
        {
            double max = -10000; int index = 0;
            for (int j = 0; j < A.GetLength(1);j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    index = j;
                }
            }
            ind[i] = index;
            //Console.WriteLine(index);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (ind[i] == 0)
            {
                if (A[i,ind[i]+1] < 0)
                {
                    A[i, ind[i] + 1] = A[i, ind[i] + 1] / 2;
                }
                else
                {
                    A[i, ind[i] + 1] = A[i, ind[i] + 1] * 2;
                }
            } 
            if (ind[i] == A.GetLength(0)-1)
            {
                if (A[i, ind[i]-1] < 0)
                {
                    A[i, ind[i] - 1] = A[i, ind[i] - 1] / 2;
                }
                else
                {
                    A[i, ind[i] - 1] = A[i, ind[i] - 1] * 2;
                }
            }
            if (ind[i] != A.GetLength(0) - 1 && ind[i] != 0)
            {
                if (A[i, ind[i]-1] < A[i, ind[i] + 1])
                {
                    if (A[i, ind[i] - 1] < 0)
                    {
                        A[i, ind[i] - 1] = A[i, ind[i] - 1] / 2;
                    } 
                    else
                    {
                        A[i, ind[i] - 1] = A[i, ind[i] - 1] * 2;
                    }
                } else /*(A[i, ind[i] - 1] > A[i, ind[i] + 1])*/
                {
                    if (A[i, ind[i] + 1] < 0)
                    {
                        A[i, ind[i] + 1] = A[i, ind[i] + 1] / 2;
                    }
                    else
                    {
                        A[i, ind[i] + 1] = A[i, ind[i] + 1] * 2;
                    }
                }
            }
            
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int g = 0; g < A.GetLength(1); g++)
            {
                Console.Write($"{A[i,g]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int[] otri = new int[A.GetLength(0)];
        int[] poli = new int[A.GetLength(0)];
        int[] inmx = new int[A.GetLength(0)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int otr = 0, pol = 0, max = -10000, n = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] < 0)
                {
                    otr++;
                } else
                {
                    pol++;
                }
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    n = i;
                }
            }
            otri[j] = otr;
            poli[j] = pol;
            inmx[j] = n;
            //Console.WriteLine(n);
            //Console.WriteLine(pol);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            
            if (otri[j] > poli[j])
            {
                A[inmx[j], j] = inmx[j]+1;
            }
            else
            {
                A[inmx[j], j] = 0;
            }
            
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int g = 0; g < A.GetLength(1); g++)
            {
                Console.Write($"{A[i, g]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -10000, ind = 0, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            for (int i = ind + 1; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
            }
            if (ind <= 4)
            {
                A[0, j] = sum;
            }
            else continue;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5 )
        {
            return null;
        }
        int[] inmax = new int[A.GetLength(0)];
        int[] maxi = new int[A.GetLength(0)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -10000, ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            maxi[j] = max;
            inmax[j] = ind;
            //Console.WriteLine(ind);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (B[j] > maxi[j])
            {
                A[inmax[j], j] = B[j];
            }
            
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int g = 0; g < A.GetLength(1); g++)
            {
                Console.Write($"{A[i, g]} ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int[] inmax = new int[A.GetLength(0)];
        double[] maxi = new double[A.GetLength(0)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = -10000; int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            maxi[j] = max;
            inmax[j] = ind;
            //Console.WriteLine(ind);
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (maxi[j] < (A[0, j] + A[6, j]) / 2)
            {
                A[inmax[j], j] = (A[0,j] + A[6, j])/2;
            }
            else
            {
                A[inmax[j], j] = inmax[j]+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) 
            return null;
        int[,] answer = new int[n, 3 * n];
        // code here
        int p = 2;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            int step = p;
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (step == 2)
                {
                    answer[i, j] = 1;
                    step = 0;
                }
                else
                {
                    answer[i, j] = 0;
                    step++;
                }
            }
            p--;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) 
            return null;

        int c = 0;
        int max = -100000, max_x = 0, max_y = 0;
        // code here
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                max_x = i;
                max_y = i;
            }

        }
        for (int i = 0; i < max_y; i++)
        {
            c++;
            for (int j = c; j < A.GetLength(1); j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int[] inmax = new int[B.GetLength(1)];
        double[] maxi = new double[B.GetLength(1)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = -10000, ind = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i,j] > max)
                {
                    max = B[i,j];
                    ind = j;
                }
            }
            maxi[i] = max;
            inmax[i] = ind;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int vrem = B[i, inmax[i]];
            B[i, inmax[i]] = B[i + 1, inmax[i + 1]];
            B[i + 1, inmax[i + 1]] = vrem;
            i++;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) 
            return null;

        int[,] perevert = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int step = 0;
            for (int j = A.GetLength(1) - 1; j >= 0; j--)
            {
                perevert[i, step] = A[i, j];
                step++;
            }
        }
        
        // end

        return perevert;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        int k = 0;
        bool test = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 && k != matrix.GetLength(1) - 1 && test == false)
            {
                matrix[i, k] = 0;
                matrix[matrix.GetLength(0) - 1, k] = 0;
                k++;
                i--;
            }
            else
            {
                test = true;
                k = 0;
            }
            if (i != -1 && i != matrix.GetLength(1) - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, matrix.GetLength(1) - 1] = 0;
            }
        }
        matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        
        int middle_ind = 0;
        if ((matrix.GetLength(0) / 2) % 2 == 0)
        {
            middle_ind = matrix.GetLength(0) / 2;
        }
        else
        {
            middle_ind = matrix.GetLength(0) / 2;
        }
        for (int i = middle_ind; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= middle_ind; j++)
            {
                matrix[i, j] = 1;
            }
            middle_ind++;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);
        
        int upsh = 0, dwsh = 0;
        int diag = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= diag)
                {
                    upsh++;
                }
                else
                {
                    dwsh++;
                }
            }
            diag++;
        }
        diag = 0;
        int[] up = new int[upsh];
        int[] down = new int[dwsh];
        upsh = 0; dwsh = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= diag)
                {
                    up[upsh] = matrix[i, j];
                    upsh++;
                }
                else
                {
                    down[dwsh] = matrix[i, j];
                    dwsh++;
                }
            }
            diag++;
        }
        // end

        return (up, down);
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) 
            return null;

        int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[,] temp = new int[matrix.GetLength(0), 2];
        int schet_temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            schet_temp = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] >= 0)
                {
                    schet_temp++;
                }
            }
            temp[i, 0] = schet_temp;
            temp[i, 1] = i;
        }
        int max = 0, maxy = 0, maxx = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (temp[j, 0] > max)
                {
                    max = temp[j, 0];
                    maxy = temp[j, 1];
                    maxx = j;
                }
            }
            temp[maxx, 0] = 0;
            //Console.WriteLine(maxim);
            //Console.WriteLine(maxim_y);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[i, j] = matrix[maxy, j];
            }
            max = 0;
            maxx = 0;
            maxy = 0;
        }
        // end

        return answer;
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
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (j % 2 == 0)
            {
                bool puzirek = true;
                do
                {
                    puzirek = false;
                    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[j, i] < matrix[j, i + 1])
                        {
                            int temp = matrix[j, i];
                            matrix[j, i] = matrix[j, i + 1];
                            matrix[j, i + 1] = temp;
                            puzirek = true;
                        }
                    }
                } while (puzirek);
            }
            else
            {
                bool puzirek = true;
                do
                {
                    puzirek = false;
                    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[j, i] > matrix[j, i + 1])
                        {
                            int temp = matrix[j, i];
                            matrix[j, i] = matrix[j, i + 1];
                            matrix[j, i + 1] = temp;
                            puzirek = true;
                        }
                    }
                } while (puzirek);
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool prov = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    prov = true;
                }
            }
            if (prov == true)
            {
                k++;
            }
        }

        int[,] answer = new int[matrix.GetLength(0) - k, matrix.GetLength(1)];
        int k_final = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool prov_2 = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    prov_2 = true;
                }
            }
            if (prov_2 == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    answer[k_final, j] = matrix[i, j];

                }
                k_final++;
            }
        }
        // end

        return answer;
    }
    #endregion
}