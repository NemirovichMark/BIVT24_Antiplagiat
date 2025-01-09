using Microsoft.VisualBasic;
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
        //program.Task_1_8(new int[,] { { 1, 2, 3, 4, -5, -6 },{ 5, 11, -17, 11, -10, 6 },{ -9, -10, -11, -14, -15, -6 },{ -9, -10, -11, -14, -15, 6 }});
        //program.Task_1_28(new int[,] { { 1, 2, -3, 4, -5, 6, 7 },{ 5, 6, -7, 8, 9, -10, -11 },{ 9, 10, 11, 12, 13, 14, 15 },{ -13, 14, 15, 16, 17, -18, -19 },{ 0, -1, -2, -3, -4, -5, -6 }});
        //program.Task_1_1(new int[,] {{ 1, 2, -3, 4, -5, 6, 7 },{ 5, 6, -7, 8, 9, -10, -11 },{ 9, 10, 11, 12, 13, 14, 15 },{ -13, 14, 15, 16, 17, -18, -19 },{ 0, -1, -2, -3, -4, -5, -6 }});
        int[,] matrix = {
                { 9,    -100,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
        program.Task_3_10(matrix);
       
        
        
        //program.Task_2_3(new int[,] {{ 1, 2, -3, 7, 7 },{ 5, 6, -7, 9, -11 },{ 9, 10, 11, 15, 15 },{ -13, 14, 25, 25, -19 },{ 5, 6, -7, 8, 9},{ -13, 14, 2, 3, -19 }, { 1, 2, -3, 7, 0 },{ 5, 0, -1, 9, -1 },{ 9, 10, 11, 2, 15 },{ 0, 0, -1, -2, -3 }});
        //program.Task_2_1(new double[,] {{ 1, 2, -3, 7, -5, 7, 7 },{ 5, 6, -7, 8, 9, 9, -11 },{ 9, 10, 11, 12, 13, 15, 15 },{ -13, -30, 25, 25, 16, 17, -19 },{ -6, -5, -1, -2, -3, -4, -6 }});
        //program.Task_2_3(new int[,] {{ 1, 2, -3, 7, -5 },{ 5, 6, -7, 8, 9 },{ 9, 10, 11, 12, 13 }});
        //program.Task_2_2(new int[,] {{ 1, 2, -3, 7, 7 },{ 5, 6, -7, 9, -11 },{ 9, 10, 11, 15, 15 },{ -13, 14, 25, 25, -19 },{ 5, 6, -7, 8, 9},{ -13, 14, 25, 25, -19 },{ 0, 0, -1, -2, -3 }});
        //program.Task_1_26(new int[,]  {{ 1, 2, -3, 4, -5, 7, 7 },{ 5, 6, -7, 8, 9, 9, -11 },{ 9, 10, 11, 12, 13, 15, 15 },{ -13, 14, 25, 25, 16, 17, -19 },{ 0, 0, -1, -2, -3, -4, -6 }}, new int[] { 1, 2, 3, 4, 5, 6, 7 });
        //program.Task_1_2(new int[,] { { 1, 2, 3, 4, 5, 6, 7 }, { 5, 6, 7, 8, 9, 10, 11 }, { 9, 10, 11, 12, 13, 14, 15 }, { 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6 } });
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
        int sum = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if(A[i, j] > 0)
                {
                    answer += A[i, j];
                    sum += 1;
                }
            }
                
                
        }
        answer = answer / sum;
        // end
       Console.WriteLine(answer);
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
        int row = 3, col = 0;
        // code here
        
        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0,0);
        for (int i = 0; i < 5; i++)
        {
            
                if (A[i, colIndex] < 0)
                {
                    value = A[i, colIndex];
                    rowIndex = i ;
                    break;
                }
            
        }
        if (rowIndex < 0) return (0, 0);
        // end
        
        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = [2];


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
        double sum = 0;
        double fir = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return (null);
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0;j<6; j++)
            {
                if(A[i, j] > 0)
                {
                    sum += A[i, j];
                    fir +=1;
                }
               
            }
            if (fir > 0) answer[i] = Math.Round(sum / fir, 2);
            else answer[i] = 0;
            sum = 0;
            fir = 0;
        }
        // end
        for (int i = 0; i < 4; i++) Console.WriteLine(answer[i]);
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return (null);
        int imin = -1;
        double min = double.MaxValue;
        for(int i = 0; i < 5; i++)
        {
            if((A[i, 0] < min))
            {
                min = A[i, 0];
                imin = i;
            }
        }
        int[,] B = new int[4, 7];
        for(int i = 0; i < 5; i++)
        {
            if (i < imin)
            {
                for(int j=0;j<7;j++) B[i, j] = A[i,j];
            }
            if (i > imin)
            {
                for (int j = 0; j < 7; j++) B[i-1, j] = A[i, j];
            }
        }
        A = B;
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
        int sum = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return (null);
        for(int i=0;i<3;i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (A[j, i] < 0) sum += 1;
            }
            answer[i] = sum;
            sum = 0;
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
        int[] fer =new int[n];
        int min = int.MaxValue;
        int imin = -1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < m; j++)
            {
                if (B[i,j] < min)
                {
                    min = B[i,j];
                    imin = j;
                }
                
            }
            
            fer[i] = imin;
            min = int.MaxValue;
            imin = 0;
            
        }
        //foreach (int x in fer) Console.WriteLine(x);
        for(int i = 0; i < n; i++)
        {
            int p = B[i,fer[i]];
            for(int j = 0; j < fer[i]; j++)
            {
                
               B[i, fer[i]-j] = B[i,fer[i]-j-1];
                

            }
            B[i, 0] = p;
        }
        // end
        //for(int i=0;i<n;i++) for(int j=0;j<m;j++) Console.WriteLine(B[i,j]);
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
        int[] fer = new int[n];
        double max = int.MinValue;
        int imax = -1;
        int otr = -1;
        double _1 = 0;
        double last = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    imax = j;
                }

            }

            fer[i] = imax;
            max = int.MinValue;
            imax = 0;
            
        }
        
        //foreach (int x in fer) Console.WriteLine(x);
        
      
        
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (_1 == 0) if (F[i, j] < 0)
                        {
                            otr = j;
                            _1 = F[i, j];
                        }

                    if (F[i, j] < 0) last = F[i, j];


                }
                if (otr >= 0)
                {
                     double ns = (_1 + last) / 2;
                     for (int j = 0; j < m; j++)
                     {
                         if (j == fer[i]) F[i, j] = ns;
                     }
                }
                otr = -1;
                _1 = 0;
            }
        
        // end
        //for (int i = 0; i < n; i++) for (int j = 0; j < m; j++) Console.WriteLine(F[i, j]);
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
                if (j <6- fer[i]) G[i, 6 - j] = G[i, 6 - j - 1];


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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length!=7) return (null);
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7 ) return (null);
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
        int[,] B = new int [5,6]; 
        // end
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<7;j++)
            {
                if (j <= imin) B[i, j] = F[i, j];
                else if (j > imin + 1) B[i,j-1] = F[i, j];

                
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 ) return (null);
        double max = double.MinValue;
        int imax = -1;
        double sum = 0;
        int col = 0;
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
                if(A[i, j] > 0)
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return (null);
        int[] ind = new int[5];
        int inr = -1;
        double max = double.MinValue;
        for (int i = 0; i < 5; i++)
        {

            max = double.MinValue;
            for (int j = 0; j < 7; j++)
            {

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    inr = j;
                }
            }
            ind[i] = inr;
        }
        for (int i = 0; i < 5; i++)
        {
            if (ind[i] == 0)
            {
                if (A[i, 1] >= 0)
                    A[i, 1] = A[i, 1] * 2;
                else A[i, 1] = A[i, 1] / 2;
                continue;
            }
            if (ind[i] == 6)
            {
                if (A[i, 5] >= 0)
                    A[i, 5] = A[i, 5] * 2;
                else A[i, 5] = A[i, 5] / 2;
                continue;
            }
            if (A[i, ind[i] - 1] > A[i, ind[i] + 1])
            {
                if (A[i,  ind[i] + 1] >= 0)
                    A[i, ind[i] + 1] = A[i, ind[i] + 1] * 2;
                else A[i, ind[i] + 1] = A[i, ind[i] + 1] / 2;
            }
            else
            {
                if (A[i, ind[i] -1] >= 0)
                    A[i, ind[i] - 1] = A[i, ind[i] - 1] * 2;
                else A[i, ind[i] - 1] = A[i, ind[i] - 1] / 2;
            }
        }
        //for (int i = 0; i < 5; i++) for (int j = 0; j < 7; j++) Console.WriteLine(A[i, j]);
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return (null);
        int [] ind = new int[5];
        int sum = 0;
        int inr = -1;
        int[] yes = new int[5];
        int max = int.MinValue;
        for (int j = 0; j < 5; j++)
        {
            sum = 0;
            max = int.MinValue;
            for(int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) sum += 1;
                if(A[i, j] > max)
                {
                    max=A[i, j];
                    inr=i;
                }
            }
            ind[j] = inr;
            if (sum > 7 - sum) yes[j] = 1;
            else yes[j] = 0;
        }
        //foreach(int x in ind) Console.WriteLine(x);
        //foreach (int x in yes) Console.WriteLine(x);
        for (int j = 0; j < 5; j++)
        {
            if (yes[j] == 1) A[ind[j], j] = 0;
            else A[ind[j], j] = ind[j]+1 ;
        }
        // end
        //for (int i = 0; i < 7; i++) for (int j = 0; j < 5; j++) Console.WriteLine(A[i, j]);
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return (null);
        int[] ind = new int[5];
        int inr = -1;
        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {

            max = int.MinValue;
            for (int j = 0; j < 10; j++)
            {

                if (A[j, i] > max)
                {
                    max = A[j, i];
                    inr = j;
                }
            }
            ind[i] = inr;
        }
        int sum = 0;
        int[] sum_ = new int[5];
        for(int i=0; i < 5; i++)
        {
            sum = 0;
            for(int j=0;j < 10; j++)
            {
                if (ind[i] < j) sum += A[j, i];
            }
            sum_[i] = sum;
        }
        for(int i=0;i<5;i++) if (ind[i]<=4) A[0,i]=sum_[i];
        // end
        for (int i = 0; i < 10; i++) for (int j = 0; j < 5; j++) Console.WriteLine(A[i, j]);
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length!=5) return (null);
        int[] ind = new int[5];
        int inr = -1;
        int max = int.MinValue;
        for (int j = 0; j < 5; j++)
        {
            
            max = int.MinValue;
            for (int i = 0; i < 7; i++)
            {
                
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    inr = i;
                }
            }
            ind[j] = inr;
        }
        for(int j = 0; j < 5; j++)
        {
            
                if (B[j] > A[ind[j], j]) A[ind[j], j] = B[j];
            
        }
        // end
        for (int i = 0; i < 7; i++) for (int j = 0; j < 5; j++) Console.WriteLine(A[i, j]);
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return (null);
        int[] ind = new int[5];
        int inr = -1;
        double max = double.MinValue;
        double[] sum_ = new double[5];
        for (int i = 0; i < 5; i++)
        {
            sum_[i] = (A[0, i] + A[6, i]) / 2;
            max = double.MinValue;
            for (int j = 0; j < 7; j++)
            {

                if (A[j, i] > max)
                {
                    max = A[j, i];
                    inr = j;
                }
            }
            ind[i] = inr;
        }
        for(int i = 0; i < 5; i++)
        {
            if (A[ind[i], i] < sum_[i]) A[ind[i], i] = sum_[i];
            else A[ind[i], i] = ind[i]+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n <= 0 || n % 1 != 0) return null;
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++) for (int j = i; j < 3 * n; j+=3) 
                answer[i, j] = 1;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return (null);
        int max = int.MinValue;
        int ind = 0;
        for(int i=0;i<6;i++)
        {
            if (A[i, i] > max)
            {
                max=A[i, i]; ind = i;
            }
        }
        for(int i = 0; i < 6; i++)
        {
            if (i == ind) break;
            for(int j = i + 1; j < 6; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return (null);
        int[] ind = new int[6];
        int inr = -1;
        int max = int.MinValue;
        for (int I = 0; I < 6; I++)
        {

            max = int.MinValue;
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
        for(int i = 0; i < 6; i += 2)
        {
            temp = B[i, ind[i]];
            B[i, ind[i]]= B[i+1, ind[i+1]];
            B[i + 1, ind[i + 1]] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return (null);
        int a1;
        int a2;
        int a3;
        for(int i = 0; i < 6; i++)
        {
            a1= A[i, 0]; 
            a2= A[i, 1]; 
            a3= A[i, 2]; 
            A[i, 2] = A[i, 4]; 
            A[i, 4] = a3;
            A[i, 1] = A[i, 5];
            A[i, 5] = a2;
            A[i, 0] = A[i, 6];
            A[i, 6] = a1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int n = matrix.GetLength(0);
        for(int i = 0; i < n; i++)
        {


            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1) matrix[i, j] = 0; 
            }
            matrix[i, 0] = 0;
            matrix[i, n - 1] = 0;
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
        int n = matrix.GetLength(0);
        if (n % 2 == 0) n = n / 2;
        else n = n / 2 + 1;
        
        for(int i= matrix.GetLength(0)-1; i >=0; i--)
        {
            if (i < n-1) continue;
            for(int j=0;j< matrix.GetLength(0) ; j++)
            {
                if (j > i) break;
                matrix[i, j] = 1;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++) for (int j = 0; j < matrix.GetLength(0); j++) Console.WriteLine(matrix[i, j]);
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
       
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null,null);
        int n = matrix.GetLength(0);
        int k = 0;
        for (int i = 1; i < n; i++) k +=i;
        int[] upper = new int[n*n-k];
        int[] lower = new int[k];
        int ind1 = 0;
        int ind2 = 0;
        // code here
        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < n; j++)
            {
                if(j>=i)
                {
                    upper[ind1]= matrix[i,j];
                    ind1 += 1;
                }
                if (j < i)
                {
                    lower[ind2]= matrix[i,j];
                    ind2 += 1;
                }
            }
        }
        // end
        for (int i = 0; i < matrix.GetLength(0); i++) for (int j = 0; j < matrix.GetLength(0); j++) Console.WriteLine(matrix[i, j]);
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
        int[] sum = new int[7];

        for(int i = 0; i < 7; i++)
        {
            int sum_ = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0) sum_ += 1;
            }
            sum[i] = sum_;
        }
        int[,] A = new int[7, 5];
        for(int i=0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++) A[i, j] = matrix[i, j];
        }
        for(int i = 0; i < 7; i++)
        {
            int max = int.MinValue;
            int ind = 0 ;
            for(int h = 0; h < 7; h++)
            {
                if (sum[h] > max)
                {
                    max = sum[h];
                    ind = h;
                }
            }
            sum[ind] = -1;
            for(int j=0; j < 5; j++)
            {
                matrix[i, j] = A[ind, j];
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
        int[,] lem=new int[matrix.GetLength(0),matrix.GetLength(1)];
        
        int[] mel = new int [matrix.GetLength(1)];
        for(int i=0;i< matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for(int j=0;j<matrix.GetLength(1); j++)
                {
                    mel[j]= matrix[i,j];
                }
                for (int d = 1; d < matrix.GetLength(1);)
                {
                    if (d == 0 || mel[d] <= mel[d - 1]) d++;
                    else
                    {
                        int temp = mel[d];
                        mel[d] = mel[d - 1];
                        mel[d - 1]= temp;
                        d--;
                    }
                    
                }
        
                for (int l=0;l<matrix.GetLength(1);l++) lem[i,l]=mel[l];
                
            }
            if (i % 2 == 1)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mel[j] = matrix[i, j];
                }
                
                for (int d = 1; d < matrix.GetLength(1);)
                {
                    if (d == 0 || mel[d] >= mel[d - 1]) d++;
                    else
                    {
                        int temp = mel[d];
                        mel[d] = mel[d - 1];
                        mel[d - 1] = temp;
                        d--;
                    }
                }
                for (int l = 0; l < matrix.GetLength(1); l++) lem[i, l] = mel[l];
            }
        }
        // end
       
        return lem;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        
        int[] sum = new int[matrix.GetLength(0)];
        int rug = matrix.GetLength(0);
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    sum[i] = 1;
                    rug -=1;
                    break;
                }
            }
        }
        int[,] lem = new int[rug, matrix.GetLength(1)];
        int h = 0;
        for(int i = 0;i< matrix.GetLength(0); i++)
        {
            if (sum[i] == 0)
            {
                for (int j = 0; j< matrix.GetLength(1); j++)
                {
                    lem[h, j] = matrix[i,j];
                }
                h++;
            }
            
        }
        
        // end

        return lem;
    }
    #endregion
}