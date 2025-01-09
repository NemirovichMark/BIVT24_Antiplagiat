using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;
        for (int i = 0; i < 4; i++)
        {
            answer += A[i, i];
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
        int[] answer = new int[4];
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        for (int i = 0;i<4;i++)
        {
            int min_j = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < A[i,min_j])
                {
                    min_j = j;
                }
                answer[i] = min_j;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxim_j = 0;
            for (int j=0;j<A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxim_j])
                {
                    maxim_j = j;
                }
            }
            int temp = A[i, maxim_j];
            A[i, maxim_j] = A[i, 0];
            A[i, 0] = temp;
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
        int maxim_i = 0;
        int maxim_j = 0;
        int[,] answer = new int[5, 6];
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[maxim_i, maxim_j])
                {
                    maxim_j = j;
                    maxim_i = i;
                }
            } 
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < maxim_i && j < maxim_j)  answer[i, j] = A[i, j]; 
                else if (i >= maxim_i && j < maxim_j) answer[i, j] = A[i + 1, j]; 
                else if (i < maxim_i && j >= maxim_j) answer[i, j] = A[i, j + 1]; 
                else answer[i, j] = A[i + 1, j + 1];
            }
        }
        A = answer;
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

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0;i<A.GetLength(0); i++)
        {
            int maxim_j = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, maxim_j])
                {
                    maxim_j = j;
                }
            }
            A[i, maxim_j] *= (i+1);
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
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;
        
        for (int i = 0; i < n; i++)
        {   int temp = 0;
            int maxim_j = 0, lastminus = -1, n1=0; 
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0 && j==0) break;
                if (D[i, j] > D[i, maxim_j] && n1==0) maxim_j = j;
                if (D[i,j]<0)
                {
                    lastminus = j;
                    n1++;
                }
            }
            
            if (n1==0) continue;
            temp = D[i, maxim_j];
            D[i, maxim_j] = D[i, lastminus];
            D[i, lastminus] = temp;
        }
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

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int n = -10000000;
            for (int j = 0; j < H.GetLength(1) - 1; j++)
            {
                if (H[i, j] > n && H[i, j] > H[i,6])  H[i, 6] = H[i,j];
            }
            int temp = H[i, 5];
            H[i,5]= H[i, 6];
            H[i,6] = temp;
         } 
    
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

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i=0; i < 6; i++)
        {
            double cz = 0, n = 0; int maxi = 0;
            for (int j = 0; j <5; j++)
            {
                if (Y[i, j] > Y[i, maxi]) maxi = j;
            }
            for (int j = maxi + 1; j < 5; j++)
            {
                if (Y[i, j] > 0) { cz += Y[i, j]; n++; }
            }            
            if (n != 0)  cz /= n;
            for (int j = 0;j < maxi; j++)
            {
                if ( Y[i,j]<0) Y[i,j] = cz;
            }
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        int[] a= new int[B.GetLength(0)];
        for (int i = 0; i < 5; i++)
        {
            int maxim = -111000;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i,j]>maxim) maxim = B[i,j];
            }
            a[4-i] = maxim;
        }
        for (int j=0;j<a.Length;j++)
            B[j,3] = a[j];
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int maxim = 0, otr=0;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, i] > B[maxim, maxim]) maxim = i;
        }
        for (int i = 0; i < 5; i++)
        {
            if (B[i, 2] < 0) otr = i;
            break;
        }
        for (int i=0; i < 5; i++)
        {
            int temp = B[otr, i];
            B[otr,i] = B[maxim, i];
            B[maxim, i] = temp;
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
    {   int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int otr = 0;
        for (int i = 0; i < 5; i++) 
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) otr++;
            }
        }
        int p = 0;
        answer= new int[otr];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) { answer[p]=A[i,j]; p++; }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int maxim_j = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[i, maxim_j]) maxim_j = j;
            }
            if (maxim_j == 6)
            {
                if (A[i, maxim_j - 1] > 0) A[i, maxim_j - 1] *= 2;
                else A[i, maxim_j - 1] /= 2;
            }
            else if (maxim_j == 0)
            {
                if (A[i, maxim_j + 1] > 0) A[i, maxim_j + 1] *= 2;
                else A[i, maxim_j + 1] /= 2;
            }
            else if (A[i, maxim_j - 1] < A[i, maxim_j + 1])
            {
                if (A[i, maxim_j - 1] > 0) A[i, maxim_j - 1] *= 2;
                else A[i, maxim_j - 1] /= 2;
            }
            else if (A[i, maxim_j - 1] > A[i, maxim_j + 1])
            {
                if (A[i, maxim_j + 1] > 0) A[i, maxim_j + 1] *= 2;
                else A[i, maxim_j + 1] /= 2;
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
            int plus = 0, minus = 0, maxim_i = 0; ;
            for (int i=0; i< A.GetLength(0); i++)
            {
                if ((A[i, j] > 0)) plus++;
                if ((A[i, j] < 0)) minus++;
                if ((A[i, j] > A[maxim_i, j])) maxim_i = i;
            }
            if (plus > minus) A[maxim_i, j] = 0;
            else A[maxim_i, j] = maxim_i+1;
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
            int maxim_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxim_i, j]) maxim_i = i;
            }
            int summa = 0;
            for (int i = maxim_i+1; i < A.GetLength(0); i++)
            {
                summa += A[i, j];
            }
            if (maxim_i < A.GetLength(0) / 2) A[0, j] = summa;
        }
                // end

                return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length!=5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxim_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxim_i, j]) maxim_i = i;
            }
            if (A[maxim_i, j] <B[j]) A[maxim_i, j] = B[j];


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
            int maxim_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[maxim_i, j]) maxim_i = i;
            }
            double summa = (A[0, j] + A[6, j]) / 2;
            if (A[maxim_i, j] < summa) A[maxim_i, j] = summa;
            else A[maxim_i, j] = maxim_i+1;


        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n<1) return null;
        answer = new int[n, n*3];
        for (int j = 0; j < n; j ++)
        {
            for (int i = 0; i < 3*n; i+=3)
            {
                answer[j, j + i] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int maxim = 0;
        for (int i=0; i < 6; i++)
        {
            if (A[i, i] > A[maxim,maxim])maxim = i;
        }
        for (int i = 0; i < maxim; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (j > i) A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int i = 0; i < B.GetLength(0)-1; i += 2)
        {
            int maxim_1 = 0;
            int maxim_2 = 0;
            for (int j=0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, maxim_1]) maxim_1 = j;
                if (B[i+1, j] > B[i+1, maxim_2]) maxim_2 = j;
            }
            int temp = B[i, maxim_1];
            B[i, maxim_1]=B[i+1, maxim_2];
            B[i+1, maxim_2]=temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < A.GetLength(0); i++) 
        {
            int[] a = new int[7];
            for (int j=0;j < A.GetLength(1); j++)
            {
                a[6-j]=A[i,j];
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = a[j];
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
        if (matrix.GetLength(0) !=matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j=0; j < matrix.GetLength(1); j++)
            {
                if (j == 0 || j == matrix.GetLength(1)-1 || i == 0 || i == matrix.GetLength(0)-1) matrix[i, j] = 0;
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
        int n = matrix.GetLength(0);
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = n/2; i < n; i++)
        {
            for (int j=0; j <= i; j++)
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        int k = 0, p = 0, ind = 0,ind_1=0 ;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                ind++;

            }
            for (int j = 0; j < i; j++)
            {
                ind_1++;
            }

        upper= new int[ind];
        lower= new int[ind_1];
        }
        for (int i=0; i < matrix.GetLength(0); i++)
        {
            for (int j=i; j < matrix.GetLength(1); j++)
            {
                upper[k] = matrix[i, j];
                k++;
               
            }
            for (int j = 0; j < i; j++)
            {
                lower[p] = matrix[i, j];
                p++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0)-i-1; j++)
            {
                int positive1 = 0, positive2 = 0;
                for (int p = 0; p < matrix.GetLength(1) ; p++)
                {
                    if (matrix[j,p] > 0) { positive1++; }
                    if (matrix[j + 1, p] > 0) { positive2++; }
                }
                if (positive1 < positive2)
                {
                    for (int p = 0; p < matrix.GetLength(1); p++)
                    {
                        int temp = matrix[j,p];
                        matrix[j,p] = matrix[j + 1, p];
                        matrix[j + 1, p] = temp;
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int p = 0; p < matrix.GetLength(1)-1; p++)
                {
                    if (i%2==0 && matrix[i,p]< matrix[i, p+1])
                    {
                        int temp = matrix[i, p];
                        matrix[i, p] = matrix[i, p+1];
                        matrix[i, p+1] = temp;
                    }
                    if (i % 2 != 0 && matrix[i, p] > matrix[i, p+1])
                    {
                        int temp = matrix[i, p];
                        matrix[i, p] = matrix[i, p + 1];
                        matrix[i, p + 1] = temp;
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
        int nol = 0;
        for (int i=0; i < matrix.GetLength(0); i++)
        {
            for (int j=0;j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) { nol++; break; }
            }
        }
        int[,] a=new int [matrix.GetLength(0)-nol, matrix.GetLength(1)];
        int k = 0, finish=matrix.GetLength(0)-nol;
        for (int i=0; i < matrix.GetLength(0); i++)
        {
            for (int j=0;j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) break;
                a[k,j]=matrix[i, j];
            }
            k++;
            if (k >= finish) break;
        }
        matrix = a;
        // end

        return matrix;
    }
    #endregion
}