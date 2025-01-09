using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ExceptionServices;
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
        
        for (int i=0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++) 
                answer += A[i, j];
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        
        double cnt = 0;
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {   
                if (A[i,j] > 0)
                {
                    answer += A[i, j];
                    cnt++;
                }

            }
        }
        answer /= cnt;
        
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

        int j = colIndex;
        for (int i=0; i < A.GetLength(0); i++)
        {
            if (A[i, j] < 0)
            {
                value = A[i, j];
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
        // code here
        
        double sum = 0, cnt = 0, sr = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j<A.GetLength(1);j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
               
            }
            if (cnt == 0)
            {
                sr = 0;
            }
            else
            {
                sr = sum / cnt;
            }
            
            answer[i] = sr;
            
            sum = 0; cnt = 0; sr = 0;


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
        double min = A[0, 0];
        int k = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] B = new int[A.GetLength(0)-1,A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                k = i;
            }
        }
        for (int i=0; i < A.GetLength(0)-1; i++)
        {
            if (i < k)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i + 1, j];
                }
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
        int[] answer = default(int[]);
        // code here
        answer = new int [A.GetLength(1)];
        int cnt = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                {
                     cnt++;
                }
            }
            answer[j] = cnt;
            cnt = 0;
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
        
        for (int i =0; i < n; i++)
        {
            int min = B[i, 0];
            int k = 0;

            for (int j=1;j < m; j++)
            {   
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    k = j;
                }
            }

            int[] nov = new int[B.GetLength(1)];
            nov[0] = min;
            int i2 = 1;
            for (int j = 0; j < m; j++)
            {
                if ( j!= k)
                {
                    nov[i2] = B[i, j];
                    i2++;
                }
            }
            for (int j = 0; j< m; j++)
            {
                B[i, j] = nov[j];
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
        // code here
        if (F.GetLength(0) != n || F.GetLength(1) != m) return null;
        

        for (int i = 0; i < n; i++)
        {
            double s1 = 0, s2 = 0, summ = 0;
            int k = 0, p = -1;
            double max = F[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    k = j;
                }

                if (F[i, j] < 0)
                {
                    s1 = F[i, j];
                    p++;
                }
                
            }
            if (p == -1) continue;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    s2 = F[i, j];
                    break;
                }
            }
            summ = (s1 + s2) / 2;
            F[i, k] = summ;




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
        if (G.GetLength(0) != 5 ||  G.GetLength(1) != 7) return null;    
        int n = G.GetLength(0);
        int m = G.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            int max = G[i, 0];
            int k = 0;

            for (int j = 1; j < m; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    k = j;
                }
            }

            int[] nov = new int[G.GetLength(1)];
            
            for (int j = 0; j < m; j++)
            {
                if(j <= k)
                {
                    nov[j] = G[i, j];
                }
                else if (j == k + 1)
                {
                    nov[j] = max;
                }

                else
                {
                    nov[j] = G[i, j - 1];
                }
                    
            }
            for (int j = 0; j < m; j++)
            {
                G[i, j] = nov[j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        if (B.Length != 7) return null;
        int k = 0, max = A[0, 5]; ;
        for (int i=0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                k = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[k, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        int min = Math.Abs(F[1, 0]), k = 0;

        for (int j=0; j<F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                k = j;
            }
        }
        int[,] b = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int j = 0; j< F.GetLength(1)-1;j++)
        {
            if (j < k+1)
            {
                for (int i=0; i < F.GetLength(0);i++)
                {
                    b[i, j] = F[i, j];
                }
            }
            else
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    b[i, j] = F[i, j + 1];
                }
            }
        }
        F = b;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int k = 0;
        for (int i =0; i < A.GetLength(0); i++)
        {
            double sum = 0,sr=0;
            int cnt = 0;

            double max = double.MinValue;
            for (int j=0; j<A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
            if (cnt == 0) sr = 0;
            else
            {
                sr = sum / cnt;
            }
            
            A[i, k] = sr;
            
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
       
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++, k=0)
        {
            double max = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {

                if (max < A[i, j])
                {
                    max = A[i, j];
                    k = j;
                }
                
            }
            if ( k - 1 == -1 || k+1== A.GetLength(1)+1 ) continue;
            else
            {   
                
                if (A[i, k - 1] > A[i, k + 1])
                {
                    if (A[i, k + 1] > 0)
                    {
                        A[i, k + 1] *= 2;
                    }
                    else
                    {
                        A[i, k + 1] /= 2;
                    }

                }
                else
                {
                    if (A[i, k - 1] > 0)
                    {
                        A[i, k - 1] *= 2;
                    }
                    else
                    {
                        A[i, k - 1] /= 2;
                    }
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int cnt = 0, cnt2=0, k = 0;
        for (int j=0; j < A.GetLength(1); j++, cnt = 0, cnt2=0)
        {
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {   
                if (max < A[i, j])
                {
                    max = A[i, j];
                    k = i;
                }
                if (A[i,j] > 0)
                {
                    cnt++;
                }
                else if (A[i,j]<0)
                {
                    cnt2++;
                }
                
            }
            if (cnt > cnt2)
            {
                A[k, j] = 0;
            }
            else
            {
                A[k, j] = k+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        
        int max = int.MinValue;
        for (int j = 0; j < A.GetLength(1); j++, max = int.MinValue)
        {
            int sum = 0, k = 0, cnt = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {   
                    
                    max = A[i, j];
                   
                }
               
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i, j] == max)
                {
                    k = i;
                    break;
                }
            }
            double polovin = A.GetLength(0) / 2;
            if (k < polovin)
            {
                for (int i = k +1; i < A.GetLength(0); i++)
                {

                    cnt += A[i, j];

                }
                A[0, j] = cnt;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j =0; j<A.GetLength(1); j++)
        {
            int max = int.MinValue;
            for (int i=0; i<A.GetLength(0); i++)
            {
                if (max<A[i, j])
                {
                    max = A[i, j];
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max == A[i,j])
                {
                    if (A[i, j] < B[j])
                    {
                        A[i, j] = B[j];
                        break;
                    }

                }
                

            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for(int j=0; j < A.GetLength(1); j++)
        {
            int k = 0;
            double max = double.MinValue;
            double polsum = (A[A.GetLength(1), j] + A[0,j])/2;
            for (int i=0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j]; 

                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == max)
                {
                    k = i;
                    break;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[k,j]<polsum)
                {
                    A[k,j]=polsum;
                }
                else
                {
                    A[k, j] = k+1;
                }
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
        answer = new int[n,3*n];
        for (int i = 0; i<n; i++)
        {
            for(int j=0; j<3*n; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i =0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, i + n] = 1;
            answer[i, i + 2*n] = 1;
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = A[0, 0], k =0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (max < A[i, i])
            {
                max = A[i, i];
                k = i;
            }
        }
        for (int i = 0; i < k; i++)
        {
            for (int j = i+1; j < A.GetLength(1); j++)
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
        
        for (int i=0; i<B.GetLength(0); i+=2)
        {
            int max = int.MinValue, max2 = int.MinValue, k=0, k1=0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                    k = j;
                }
                if (B[i+1, j] > max2)
                {
                    max2 = B[i+1, j];
                    k1 = j;
                }

            }
            B[i, k] = max2;
            B[i+1,k1]=max;

        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int k = 0;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1)/2; j++)
            {
                k = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1-j];
                A[i, A.GetLength(1) - 1-j] = k;

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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i< matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[matrix.GetLength(1)-1, i] = 0;
            matrix[i, matrix.GetLength(0)-1] = 0;
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
        int pol = matrix.GetLength(1) / 2;
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i=pol; i<matrix.GetLength(0); i++)
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int pol = matrix.GetLength(1) / 2;
        int cnt = 0;
        int cnt1 = 0;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j)
                {
                    cnt++;
                }
                else
                {
                    cnt1++;
                }

            }
        }
        upper = new int[cnt];
        lower = new int[cnt1];
        int k = 0, k1=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j)
                {
                    upper[k] = matrix[i, j];
                    k++;
                }
                else
                {
                    lower[k1] = matrix[i, j];
                    k1++;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);

        if (n != 7 && m != 5) return default(int[,]);

        int[] cnt = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                {
                    cnt[i]++;
                }
            }
        }

        int max = cnt[0], id = 0;
        for (int i = 0; i < n; i++)
        {
            if (cnt[i] > max)
            {
                max = cnt[i];
                id = i;
            }
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (cnt[j] < cnt[j + 1])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int tempCount = cnt[j];
                    cnt[j] = cnt[j + 1];
                    cnt[j + 1] = tempCount;
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
        
        

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
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
        
        
        int cnt = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool z = false;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    z = true;
                    break;
                }
            }
            if (!z)
            {
                cnt++;
            }
        }

        int[,] matrix2 = new int[cnt, matrix.GetLength(1)];
        int i2 = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool z = false;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    z = true;
                    break;
                }
            }
            if (!z)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix2[i2, j] = matrix[i, j];
                }
                i2++;
            }
        }
        matrix = matrix2;
        // end

        return matrix;
    }
    #endregion
}