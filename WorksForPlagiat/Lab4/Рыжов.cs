using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

public class Program
{
    
    //public static int[] DeleteK(int[] A, int k)
    //{
    //    int[] B = new int[A.Length-1];
    //    for (int i = 0; i < A.Length; i++)
    //    {
    //        if (i < k) B[i] = A[i];
    //        else if (i > k) B[i-1] = A[i];
    //    }
    //    A = B;  
    //    return A;
    //}
    
    

    public static void Main()
    {
        //int[] S = new int[] { 10, 23, -12, 45, 99, -140, 2, 1, 4 };
        //for (int i = 0; i < S.Length; i++) Console.Write(S[i]+" ");
        //Console.WriteLine("------");
        //int[] Z = DeleteK(S, 1);
        //for (int i = 0; i < Z.Length; i++) Console.Write(Z[i] + " ");
        //Console.WriteLine();
        //Console.WriteLine(Math.Ceiling(5/2.0));

        Program program = new Program();
        //program.Pyzurik(new int[] {10, 23, -12, 45, 99,-140, 2, 1, 4});

        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_1_3(new int[,] {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        });
        program.Task_1_6(new int[,] {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, -9, 10, 11 },
                { 9, 10, -11, -12, -13, -14, -15 },
                { -13, -14, 15, 16, 17, 18, -19 }
            });
        program.Task_1_9(new int[,] {
                { 4, 2, 3, 1, -5, -6, -7 },
                { 11, 5, -17, 11, -10, 6, 5 },
                { 1, -10, -11, -14, -15, -16, -9 },
                { -2, -10, -11, -14, -15, -6, -9 },
                { 6, -10, -11, -14, -15, -9, 4 }
            });
        program.Task_1_12(new int[,] {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 } });
        program.Task_1_15(new int[,] {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 } });
        program.Task_1_18(new int[,]{
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            }, 5, 7);
        program.Task_1_21(new int[,] {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 15, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            });
        program.Task_1_24(new double[,] {
                { 1, 2, -3, 4, -5 },
                { 5, 6, -7, 8, 9, },
                { 9, 10, 11, 12, 13},
                { -13, 14, 25, 16, 11 },
                { 0, -1, -2, -3, -4 },
                { 1, -1, 2, -2, 3 }
            });
        program.Task_1_27(new int[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 } });

        program.Task_1_30(new int[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 } });
        program.Task_2_1(new double[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, -30, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 } });
        program.Task_2_2(new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 } });
        program.Task_2_3(new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 2, 3, -19 },
                { 1, 2, -3, 7, 0 },
                { 5, 0, -1, 9, -1 },
                { 9, 10, 11, 2, 15 },
                { 0, 0, -1, -2, -3 }
            });
        program.Task_2_4(new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            }, new int[] { 10, 20, 30, 0, -50 });
        program.Task_2_6(3);
        program.Task_2_7(new int[,] {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 } });
        program.Task_2_8(new int[,] {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, -5 } });
        program.Task_3_8(new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            });
        program.Task_3_10(new int[,] {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            });

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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                    Console.WriteLine($"{i}/{j} --> {A[i, j]}");
                }

            }
        }
        Console.WriteLine(answer);
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
        Console.WriteLine(A.GetLength(0));
        
        if (A.GetLength(0) != 4) return answer;
        answer = new int[A.GetLength(0)];
        for (int i =0; i < A.GetLength(0); i++)
        {
            int mins = int.MaxValue;
            int mini = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < mins) { mini = j; mins = A[i, j]; }
            }
            answer[i] = mini;
            Console.WriteLine($"{i}  {answer[i]} ? {mins}");
        }
        for (int h = 0; h < A.GetLength(0); h++) Console.Write($"{answer[h] } ");


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
        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) return null;
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxs = int.MinValue;
            int maxi = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxs) { maxi = j; maxs = A[i, j]; }
            }
            A[i, maxi] = A[i, 0];
            A[i, 0] = maxs;
            Console.WriteLine($"");
        }
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
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
        Console.WriteLine();
        if ((A.GetLength(0) != 6) || (A.GetLength(1) != 7)) return null;
        int maxs = int.MinValue;
        int maxi = -1;
        int maxj = -1;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxs) { maxi = i; maxj = j; maxs = A[i, j]; }

            }
        }
        int[,] B = new int[A.GetLength(0)-1, A.GetLength(1)-1];
        Console.WriteLine($"{maxs} i({maxi}) j({maxj})");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int a = -1;
            if (i < maxi) a = i; else if (i > maxi) a = i - 1; else continue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int b=-1;
                if (j < maxj) b = j; else if (j > maxj) b = j - 1; else continue;
                B[a, b] = A[i, j];

            }
        }
        A = B;
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
        }

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
        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxv = int.MinValue;
            int maxj = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxv < A[i, j])
                {
                    maxv = A[i, j];
                    maxj = j;
                }
            }
            A[i, maxj] = A[i, maxj]*(i+1);
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
        Console.WriteLine("------------");
        if ((D.GetLength(0) != n) || (D.GetLength(1) != m)) return null;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int maxv = int.MinValue;
            int maxj = -1;
            bool fl = true;
            int potrj = -1;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                
                if (D[i, j] < 0)
                {
                    potrj = j;
                    fl = false;
                }
                if (fl && D[i, j] > maxv)
                {
                    maxv = D[i, j];
                    maxj = j;
                }
            }
            if ((potrj == -1)||(maxj == -1)) { Console.WriteLine($"BAN {i}  maxj = {maxj}  portj = {potrj}"); continue; }
            int tempt = D[i, potrj];
            Console.WriteLine($"{i} {potrj} -- > {D[i, potrj]} | {i} {maxj} -- > {D[i, maxj]} ");
            D[i, potrj] = maxv;
            D[i, maxj] = tempt;

        }
        for (int h = 0; h < D.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < D.GetLength(1); k++) Console.Write($"{D[h, k]} ");
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
        if ((H.GetLength(0) != 5) || (H.GetLength(1) != 7)) return null;
        // code here
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int maxv = int.MinValue;
            for (int j = 0; j < H.GetLength(1)-1; j++)
            {
                if (H[i, j] > maxv) maxv = H[i, j];
                
            }
            H[i, H.GetLength(1)-1] = maxv;
        }

        for (int i = 0; i < H.GetLength(0); i++)
        {
            int tempt = H[i, H.GetLength(1)-1];
            H[i, H.GetLength(1)-1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = tempt;

        }

        // end
        Console.WriteLine();
        Console.WriteLine("--------------");
        Console.WriteLine();
        for (int h = 0; h < H.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < H.GetLength(1); k++) Console.Write($"{H[h, k]} ");
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
        Console.WriteLine();
        Console.WriteLine();
        if ((Y.GetLength(0) != 6) || (Y.GetLength(1) != 5)) return null;
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double maxv = double.MinValue;
            int maxj = -1;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > maxv)
                {
                    maxv = Y[i, j];
                    maxj = j;
                }

            }
            double smp = 0;
            int q = 0;
            for (int k = maxj+1; k < Y.GetLength(1); k++)
            {
                if (Y[i, k] > 0)
                {
                    smp += Y[i, k];
                    q++;
                }

            }
            double srzn;
            if (q == 0) srzn = 0;
            else srzn = smp / q;
            srzn = Math.Round(srzn, 2);

            for (int j = 0; j < maxj; j++)
            {
                if (Y[i, j] <  0)
                {
                    Y[i, j] = srzn;
                }

            }
        }
        for (int h = 0; h < Y.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < Y.GetLength(1); k++) Console.Write($"{Y[h, k]} ");
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
        if ((B.GetLength(0) != 5) || (B.GetLength(1) != 7)) return null;
        int[] m = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int maxv = int.MinValue;
            int maxi = -1;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxv)
                {
                    maxv = B[i, j];
                    maxi = j;
                }
                
            }
            m[B.GetLength(0) - (i + 1)] = maxv;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = m[i];
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
        if ((B.GetLength(0) != 5) || (B.GetLength(1) != 5)) return null;
        int maxd = int.MinValue;
        int maxi = -1;
        int pri = -1;
        bool fl = true;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > maxd)
            {
                maxd = B[i, i];
                maxi = i;
            }
            if (B[i, 2] < 0 && fl)
            {
                pri = i;
                fl = false;
            }
            
        }
        if (pri == -1) return B;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int tempt = B[maxi, j];
            B[maxi, j] = B[pri, j];
            B[pri, j] = tempt;
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
        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) return null;
        int[] answer = default(int[]);
        // code here
        int qotr = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) qotr++;
            }
        }
        answer = new int[qotr];
        int ni = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) { answer[ni] = A[i, j]; ni++; }
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
        if ((A.GetLength(0) != 5) || (A.GetLength(1) != 7)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxv = double.MinValue;
            int maxj = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxv < A[i, j])
                {
                    maxv = A[i, j];
                    maxj = j;
                }
            }
            if (maxj == 0)
            {
                if (A[i, maxj + 1] < 0) A[i, maxj + 1] = A[i, maxj + 1] / 2;
                else A[i, maxj + 1] = A[i, maxj + 1] * 2;
            }
            else if (maxj == A.GetLength(1) - 1)
            { 
                if (A[i, maxj - 1]< 0) A[i, maxj - 1] = A[i, maxj - 1] / 2;
                else A[i, maxj - 1] = A[i, maxj - 1] * 2;
            }
            else
            {
                if (A[i, maxj - 1] < A[i, maxj + 1])
                {
                    if (A[i, maxj - 1] < 0) A[i, maxj - 1] = A[i, maxj - 1] / 2;
                    else A[i, maxj - 1] = A[i, maxj - 1] * 2;
                }


                else
                {
                    if (A[i, maxj + 1] < 0) A[i, maxj + 1] = A[i, maxj + 1] / 2;
                    else A[i, maxj + 1] = A[i, maxj + 1] * 2;
                }
            }
        }
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxv = int.MinValue;
            int maxi = -1;
            int qp = 0;
            int qotr = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxv) 
                {
                    maxv = A[i, j];
                    maxi = i;
                }
                if (A[i, j] > 0) qp++;
                else if (A[i, j] < 0) qotr++;
            }
            if (qp > qotr)
            {
                A[maxi, j] = 0;
            }
            else
            {
                A[maxi, j] = maxi+1;
            }
        }
        // end
        Console.WriteLine(" ");
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if ((A.GetLength(0) != 10) || (A.GetLength(1) != 5)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxv = int.MinValue;
            int maxi = -1;
            int sr = A.GetLength(0) / 2;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxv)
                {
                    maxv = A[i, j];
                    maxi = i;
                }

            }
            int sm = 0;
            for (int i = maxi+1; i < A.GetLength(0); i++)
            {
                sm += A[i, j];
            }
            if (maxi < sr)
            {
                A[0, j] = sm;
                Console.WriteLine();
                Console.WriteLine($"Maxv   {maxv}");
            }
            else
            {
                Console.WriteLine(sm);
            }
        }

        Console.WriteLine(" ");
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5) || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxv = int.MinValue;
            int maxi = -1;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxv)
                {
                    maxv = A[i, j];
                    maxi = i;
                }
            }
            if (maxv < B[j])
            {
                A[maxi, j] = B[j];
            }
            
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if ((A.GetLength(0) != 7) || (A.GetLength(1) != 5)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxv = double.MinValue;
            int maxi = -1;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxv)
                {
                    maxv = A[i, j];
                    maxi = i;
                }
            }
            double ps = (A[0, j] + A[A.GetLength(0) - 1, j])/2;
            if (maxv < ps)
            {
                A[maxi, j] = ps;
            }
            else
            {
                A[maxi, j] = maxi+1;

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
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                answer[i, i + k * n] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if ((A.GetLength(0) != 6) || (A.GetLength(1) != 6)) return null;
        int maxi = -1;
        int maxv = int.MinValue;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxv)
            {
                maxi = i;
                maxv = A[i, i];
            }
        }
        for (int i = 0; (i < maxi); i++)
        {
            for ( int j = 0; j < A.GetLength(1); j++)
            {
                if (i < j)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end
        Console.WriteLine(" ");
        Console.WriteLine($"-----> {maxi}");
        for (int h = 0; h < A.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < A.GetLength(1); k++) Console.Write($"{A[h, k]} ");
        }
        
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if ((B.GetLength(0) != 6) || (B.GetLength(1) != 6)) return null;
        int[] maxv = new int[B.GetLength(0)];
        int[] maxi = new int[B.GetLength(0)];

        for (int i = 0; i < B.GetLength(0); i++)
        {

            int maxv0 = int.MinValue;
            int maxi0 = -1;

            for (int j = 0; j < B.GetLength(1); j++)
            {
                    if (B[i, j] > maxv0)
                    {
                        maxv0 = B[i, j];
                        maxi0 = j;
                    }
            }


            maxv[i] = maxv0;
            maxi[i] = maxi0;

        }
        B[0, maxi[0]] = maxv[1];
        B[1, maxi[1]] = maxv[0];

        B[2, maxi[2]] = maxv[3];
        B[3,maxi[3]] = maxv[2];

        B[4,maxi[4]] = maxv[5];
        B[5,maxi[5]] = maxv[4];

        // end
        Console.WriteLine();
        Console.WriteLine("0-0-0-0-0-0");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            Console.Write($"{maxv[i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            Console.Write($"{maxi[i]} ");
        }
        Console.WriteLine();
        for (int h = 0; h < B.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < B.GetLength(1); k++) Console.Write($"{B[h, k]} ");
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if ((A.GetLength(0) != 6) || (A.GetLength(1) != 7)) return null;
        
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            for (int j = 0; j <= A.GetLength(1)/2; j ++)
            {
                int temp = A[i,j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = temp;
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
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || (matrix.GetLength(0) == 0)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;

            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
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
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || (matrix.GetLength(0) == 0)) return null;
        int sr = matrix.GetLength(0) / 2;
        for (int i = sr; i< matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
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
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || (matrix.GetLength(0) == 0)) return (null, null);
        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2]; 
        lower = new int[n * (n - 1) / 2];
        int i1 = 0; 
        int i2 = 0; 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= i) 
                {
                    upper[i1] = matrix[i, j];
                    i1++;
                }
                else if (j < i)
                {
                    lower[i2] = matrix[i, j];
                    i2++;
                }
            }
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
        if ((matrix.GetLength(0) != 7) || (matrix.GetLength(1) != 5)) return null;
        int[] maxv = new int[matrix.GetLength(0)];
        int[] maxi = new int[matrix.GetLength(0)];

        Console.WriteLine();
        Console.WriteLine("______");
        Console.WriteLine();
        for (int h = 0; h < matrix.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(1); k++) Console.Write($"{matrix[h, k]} ");
        }
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            maxi[i] = i;
            int maxv1 = 0;
            for (int j = 0;j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    maxv1 ++;
                }
            }
            maxv[i] = maxv1;
        }
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n- i- 1; j++)
            {
                if (maxv[j] < maxv[j + 1])
                {
                    int temp = maxv[j];
                    int tempi = maxi[j];
                    maxv[j] = maxv[j + 1];
                    maxi[j] = maxi[j + 1];
                    maxv[j + 1] = temp;
                    maxi[j + 1] = tempi;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        for ( int z = 0;  z < matrix.GetLength(0); z++)
        {
            Console.Write($"{maxi[z]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int z = 0; z < matrix.GetLength(0); z++)
        {
            Console.Write($"{maxv[z]} ");
        }

        int[,] nmatrix = new int[n, matrix.GetLength(1)];
        for (int i = 0; i < nmatrix.GetLength(0); i++)
        {
            int ki = maxi[i];
            for (int j = 0;j < nmatrix.GetLength(1); j++)
            {
                nmatrix[i, j] = matrix[ki,j];
            }
        }
        matrix = nmatrix;


        Console.WriteLine();
        Console.WriteLine();
        for (int h = 0; h < matrix.GetLength(0); h++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(1); k++) Console.Write($"{matrix[h, k]} ");
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

    public static int[] Pyzurik1(int[] A)
    {

        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length - i - 1; j++)
            {

                if (A[j + 1] > A[j])
                {
                    int temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
        }
        return A;
    }
    public static int[] Pyzurik2(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length - i - 1; j++)
            {

                if (A[j + 1] < A[j])
                {
                    int temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
        }
        return A;
    }
    public int[,] Task_3_10(int[,] matrix) 
    {
        // code here

        Console.WriteLine();
        //int[] m = new int[] {3, 6, 1, 9};
        //m = Pyzurik1(m);
        //for (int i = 0; i < m.Length; i++) Console.Write($"{m[i]}  ");
        //Console.WriteLine();

        if ((matrix.GetLength(0) == 0)) return null;
        int r = matrix.GetLength(0);  
        int c = matrix.GetLength(1); 

        for (int i = 0; i < r; i++)
        {
            int[] st = new int[c];  
            for (int j = 0; j < c; j++)  
            {
                st[j] = matrix[i, j];
            }

            
            if (i % 2 == 0)  
            {
                st = Pyzurik1(st);                
            }
            else  
            {
                st = Pyzurik2(st);
            }

            
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = st[j];
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if ((matrix.GetLength(0) == 0)) return null;
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);
        int ksn = 0;
        for (int i = 0; i < r; i++)
        {
            bool fl = true;
            for (int j = 0; j < c; j++)
            {
                if (matrix[i, j] == 0)
                {
                    fl = false;
                    break;
                }
            }
            if (fl) ksn++;
        }

        int[] sti = new int[ksn];
        int ii = 0;
        for (int i = 0; i< r; i++)
        {
            bool fl = true;
            for (int j = 0; j < c; j++)
            {
                if (matrix[i, j] == 0)
                {
                    fl = false;
                    break;
                }
            }
            if (fl) sti[ii] = i;
            ii++;
        }

        int[,] nmatrix = new int[ksn, c];

        for (int i = 0; i < ksn; i++)
        {
            int mi = sti[i];
            for (int j = 0;j < c; j++)
            {
                nmatrix[i,j] = matrix[mi,j];
            }
        }
        matrix = nmatrix;
            

        // end

        return matrix;
    }
    #endregion
}