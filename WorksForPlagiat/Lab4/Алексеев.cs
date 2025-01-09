using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        int sum = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                sum += A[i,j];
            }
        }
        answer = sum;
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        double sum = 0, cnt = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
                
            }
        }
        if (cnt > 0)
        {
            answer = sum / cnt;
        }
        
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            answer += A[i,i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        int min = A[0, 0];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1);j++)
            {
                if (A[i,j] < min)
                {
                    min = A[i,j];
                    row = i;
                    col = j;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }

        if (rowIndex == -1)
        {
            value = 0;
            rowIndex = 0;
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
        double sum = 0, cnt = 0;

        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {  
                        sum += A[i, j];
                        cnt++;
                    }
                }
                if (cnt != 0)
                {
                    sum = Math.Round(sum / cnt, 2);
                }            
                else
                {
                    sum = 0;
                }             
                cnt = 0;
                answer[i] = sum;
                sum = 0;
            }
        }
        else
        {
            answer = null;
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
        int[,] B = new int [4, 7];
        int min = int.MaxValue, index = -1;


        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for ( int i = 0; i < 5; i++)
            {
                if (A[i, 0] < min)
                {
                    min = A[i,0];
                    index = i;
                }
            }
           
            for ( int i = 0; i < index; i++)
            {
                for ( int j = 0; j < 7; j++)
                {
                    B[i,j] = A[i,j];
                }
            }
           
            for ( int i = index + 1; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    B[i-1,j] = A[i,j];
                }
            }
        }
        else
        {
            B = null;
        }

            // end

            return B;
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
        int[] answer = new int[A.GetLength(1)];
        int cnt = 0;
        // code here
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 3))
        {
            for ( int i = 0; i < 3;i++)
            {
                for ( int j = 0; j < 4;j++)
                {
                    if (A[j,i] < 0)
                    {
                        cnt++;
                    }
                }
                answer[i] = cnt;
                cnt = 0;
            }
        }
        else
        {
            answer = null;
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
        if ((B.GetLength(0) == n) && (B.GetLength(1) == m))
        {
            for (int i = 0; i < n; i++) 
            {
                int min = int.MaxValue; 
                int minIndex = -1;      

                
                for (int j = 0; j < m; j++)
                {
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                        minIndex = j;
                    }
                }

                
                if (minIndex != 0)
                {
                    
                    for (int j = minIndex; j > 0; j--)
                    {
                        B[i, j] = B[i, j - 1];
                    }

                    
                    B[i, 0] = min;
                }
            }
        }
        else
        {
            B = null;
        }

        return B;
    }
        // end

        
    
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
               
        if (F.GetLength(0) != n || F.GetLength(1) != m)
            return null;

        for (int i = 0; i < F.GetLength(0); i++)
        {
            double max = double.MinValue;
            int IndexMax = -1, IndexPervOtr = -1, IndexLastOtr = -1;
       
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i,j] <= max)
                    continue;
                max = F[i,j];
                IndexMax = j;
            }

            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i,j] < 0)
                    IndexLastOtr = j;
            }

            for (int j = F.GetLength(1) - 1; j >= 0; j--)
            {
                if (F[i,j] < 0)
                    IndexPervOtr = j;
            }

            if (IndexPervOtr != -1 || IndexLastOtr != -1)
            {
                F[i, IndexMax] = (F[i, IndexPervOtr] + F[i, IndexLastOtr]) / 2.0;
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
        
       

        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return null;

        

        for (int i = 0; i < G.GetLength(0); i++)
        {
            int max = int.MinValue, IndexMax = -1;

            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i,j] > max)
                {
                    max = G[i,j];
                    IndexMax = j;
                }
            }

            for (int k = G.GetLength(1) - 1; k > IndexMax; k--)
            {
                G[i, k] = G[i, k - 1];
            }
        }
        // end


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
        
        if (B.Length != A.GetLength(1))
        {
            return null;
        }

        
        int max = int.MinValue;
        int Index = -1;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                Index = i;
            }
        }

        if (Index != -1)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[Index, j] = B[j];
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
        int[,] B = new int[5, 6];

        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return null;

        int min = int.MaxValue, index = -1; 
         

        
        for (int i = 0; i < F.GetLength(1); i++)
        {
            if (Math.Abs(F[1, i]) < min) 
            {
                min = Math.Abs(F[1, i]);
                index = i;
            }
        }

        
        if (index == -1 || index + 1 >= F.GetLength(1))
            return F;

        
        

        
        int colB = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (j == index + 1) 
                continue;

            
            for (int i = 0; i < F.GetLength(0); i++)
            {
                B[i, colB] = F[i, j];
            }

            colB++;
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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue, sum = 0.0, avarage = 0.0;
            int maxIndex = -1, cnt = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
                
            }
            if (cnt != 0)
            {
                avarage = sum / cnt;
            }
            else
            {
                A[i, maxIndex] = 0;
            }
            A[i, maxIndex] = avarage;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[] MxInd = new int[5];
        double[] mxx = new double[5];
        double mx; 
        int index = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            mx = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (mx < A[i, j])
                {
                    mx = A[i, j];
                    index = j;
                }
            }
            mxx[i] = mx;
            MxInd[i] = index;
            double c = 0;
            if (index == 0 || A[i, index + 1] < A[i, index - 1])
            {
                if (A[i, index + 1] > 0)
                {
                    c = 2;
                }
                else
                {
                    c = 0.5;
                }
               
                A[i, index + 1] *= c;
            }
            else
            {
                if (A[i, index -1] > 0)
                {
                    c = 2;
                }
                else
                {
                    c = 0.5;
                }
                A[i, index - 1] *= c;
            }
        }
        
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = 0, min = 0, IndexMax = -1, maxx = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                {
                    max++;
                }
                else if (A[i, j] < 0)
                {
                    min++;
                }
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    IndexMax = i;
                }
            }
            if (max > min)
            {
                A[IndexMax, j] = 0;
            }
            else
            {
                A[IndexMax, j] = IndexMax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int sum = 0, max = A[0, j], c = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    c = i;
                }
            }
            if (c < A.GetLength(0) / 2)
            {
                for (int i = c + 1; i < A.GetLength(0); i++)
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
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        
        
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue, k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = i;
                }
            }
            if (B[j] > max) A[k, j] = B[j];
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
        
        
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = double.MinValue;
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = i;
                }
            }
            double sum = (A[0, j] + A[6, j]) / 2;
            if (max < sum) A[k, j] = sum;
            else A[k, j] = k + 1;
        }
        

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        
        if (n <= 0)
        {
            return null;
        }
            

        int[,] temp = new int[n, 3 * n];

        for (int i = 0; i < n; i++)
        {
            temp[i, i] = 1;
            temp[i, i + n] = 1;
            temp[i, i + 2 * n] = 1;
        }
        answer = temp;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        
        
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
            
        int max = int.MinValue, IndexMax = -1;
        

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                IndexMax = i;
            }
        }

        for (int i = 0; i < IndexMax; i++)
        {
            for (int j = i + 1; j < A.GetLength(0); j++)
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
        int imax1 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int imax = 0;
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, imax])
                {
                    imax = j;
                }
            }
            if (i % 2 == 0)
            {
                imax1 = imax;
            }
            else
            {
                var temp = B[i - 1, imax1];
                B[i - 1, imax1] = B[i, imax];
                B[i, imax] = temp;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
       
        
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
            
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - j - 1]) = (A[i, A.GetLength(1) - j - 1], A[i, j]);
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
        int k = matrix.GetLength(0);

        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (i == 0 || i == k - 1 || j == 0 || j == k - 1)
                    matrix[i, j] = 0;
            }
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
        int k = matrix.GetLength(0);

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        for (int i = k / 2; i < k; i++)
        {
            for (int j = 0; j < k; j++)
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
        int k = matrix.GetLength(0), up = 0, low = 0;

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (null, null);
        }


        upper = new int[k * k / 2 + k / 2];
        lower = new int[k * k - k * k / 2 - k / 2];

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (i <= j)
                    upper[up++] = matrix[i, j];
                else
                    lower[low++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
      
        int[] positiveCounts = new int[matrix.GetLength(0)];

        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int cnt = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    cnt++;
                }
            }
            positiveCounts[i] = cnt;
        }

       
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (positiveCounts[j] < positiveCounts[j + 1])
                {
                    
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }

                  
                    int tempCount = positiveCounts[j];
                    positiveCounts[j] = positiveCounts[j + 1];
                    positiveCounts[j + 1] = tempCount;
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
        
        

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return null;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
            }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = 0;
        int[] array = new int[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    n += 1;
                    array[i] = 1;
                    break;
                }

        int[,] answer = new int[matrix.GetLength(0) - n, matrix.GetLength(1)];
        int cnt = -1;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            if (array[i] == 1)
                continue;
            p += 1;
            for (int j = 0; j < matrix.GetLength(1); j++)
                answer[cnt, j] = matrix[i, j];
        }

        
        // end

        return answer;
    }
    #endregion
}