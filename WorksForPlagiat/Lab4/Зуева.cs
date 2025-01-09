using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };
        program.Task_3_11(matrix);
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    answer += A[i, j];
            }

        }

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
        int row = 0, col = 0;
        int minElem = int.MaxValue;

        // code here
        if (A.GetLength(0) == 3 && A.GetLength(1) == 6)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < minElem)
                    {
                        minElem = A[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
        }
        // end
        Console.WriteLine("{0}, {1}", row, col);
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


        // code here
        int j = 0, n = 0;
        int[] answer = new int[5];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return null;
        }
        else
        {
            while (n != 5)
            {
                int maxElem = int.MinValue;
                for (int i = 0; i < A.GetLength(0); i++)
                {


                    if (A[i, j] > maxElem)
                        maxElem = A[i, j];




                }
                j++;
                answer[n] = maxElem;
                n++;
            }
            return answer;
        }
        // end



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
        // code here
        int n = 4;
        int maxi = 0;
        int maxElem = int.MinValue;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, n] > maxElem)
                {
                    maxElem = A[i, n];
                    maxi = i;
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int temp = A[maxi, j];
                A[maxi, j] = A[3, j];
                A[3, j] = temp;
            }
            return A;
        }
        else
            return null;
        // end

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
        int maxElem = int.MinValue;
        int maxi = 0;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 5)
        {

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if ((i == j || i == j - 1 - i) && A[i, j] > maxElem)
                    {
                        maxElem = A[i, j];
                        maxi = i;
                    }
                }
            }


            for (int i = 0; i < A.GetLength(0); i++)
            {
                int temp = A[i, 3];
                A[i, 3] = A[i, maxi];
                A[i, maxi] = temp;

            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            return A;
        }
        else
        {
            return null;
        }
        // end
        

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
        int o = 0;
        while (o != n)
        {
            int maxElem = int.MinValue;
            int maxi = 0;
            int[] a = new int[m];
            for (int i = 0; i<m; i++)
            {
                a[i] = A[o, i];
            }
            for (int i = 0; i < m; i++)
            {
                if (a[i] > maxElem)
                {
                    maxElem = a[i];
                    maxi = i;
                }
            }
            for (int i = maxi; i < m-1; i++)
            {
                a[i] = a[i + 1];
            }
            a[m - 1] = maxElem;
            
            for (int i = 0; i < m; i++)
            {
                A[o,i] = a[i];
            }
            o++;
        }
        
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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        
        // code here
        for (int i = 0; i<n; i++)
        {
            double maxElem = double.MinValue;
            int maxi = 0;
            for (int j = 0; j<m; j++)
            {
                if (C[i, j] > maxElem)
                {
                    maxElem = C[i, j];
                    maxi = j;
                }
            }
            for (int k = 0; k<m; k++)
            {
                if (C[i, k] < 0 && k<maxi && maxElem!=0)
                    C[i, k] /= maxElem;
            }
        }
       

        
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
        if (Z.GetLength(0) == 6 && Z.GetLength(1) == 8)
        {
            int cnt = 0;
            double sum = 0;
            double maxElem = double.MinValue;
            int maxii = 0, maxij=0;

            for (int i = 0; i< Z.GetLength(0); i++)
            {
                for (int j = 0; j< Z.GetLength(1); j++)
                {
                    if (Z[i, j] > 0)
                    {
                        cnt++;
                        sum += Z[i, j];
                    }
                    if (Z[i, j] > maxElem)
                    {
                        maxElem = Z[i, j];
                        maxii = i;
                        maxij = j;
                    }
                }
            }
            double ave = sum / cnt;
            Z[maxii, maxij] = ave;

            return Z;
        }
        else
            return null;
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
        int iitog = 0;
        int maxmin = 0;
        int kitog = 0;
        int minmin = 10;
        if (X.GetLength(0) == 6 && X.GetLength(1) == 5)
        {
            int icnt = 0;
            
            for (int i =0; i<X.GetLength(0); i++)
            {
                icnt = 0;
                for(int j = 0; j<X.GetLength(1); j++)
                {
                    if (X[i, j] < 0)
                        icnt++;
                    
                }
                if (icnt > maxmin)
                {
                    iitog = i;
                    maxmin = icnt;
                }
                    
                if (minmin > icnt)
                {
                    kitog = i;
                    minmin = icnt;
                }
                    
            }
            
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    int temp = X[iitog, j];
                    X[iitog, j] = X[kitog, j];
                    X[kitog, j] = temp;

                }
                
                       
            return X;
        }
        else
            return null;
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
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            int maxelementov = 0;
            int nstr = 0;

            for (int i = 0; i<A.GetLength(0); i++)
            {
                int cnt = 0;
                for (int j = 0; j<A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        cnt += A[i,j];
                }
                if (cnt > maxelementov)
                {
                    maxelementov = cnt;
                    nstr = i;
                }
            }
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (i < nstr)
                {
                    for (int j = 0; j< B.GetLength(1); j++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = A[i+1, j];
                    }
                }
                
            }

            return B;
        }
        else
            return null;
        // end

        
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 8 && B.Length ==5)
        {
            int minElem = int.MaxValue;
            int mini = 0;
            for( int j = 0; j<A.GetLength(1); j++)
            {
                if (A[4, j] < minElem)
                {
                    minElem = A[4, j];
                    mini = j;
                }
            }
            for(int i = 0; i<A.GetLength(0); i++)
            {
                A[i, mini+1] = B[i];
            }

            
            return A;
        }
        // end
        else
            return null;
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            
            for (int i = 0; i<A.GetLength(0); i++)
            {
                double maxElem = double.MinValue;
                int maxind = 0;
                
                for (int j = 0; j<A.GetLength(1); j++)
                {
                    if (A[i, j] > maxElem)
                    {
                        maxElem = A[i, j];
                        maxind = j;
                    }
                    
                }
                
                if (maxind==0 && A[i, maxind + 1] > 0)
                {
                    A[i, maxind + 1] *= 2;
                } else if (maxind == 0 && A[i, maxind + 1] < 0)
                {
                    A[i, maxind + 1] /= 2;
                }
                else if (maxind == A.GetLength(1)-1 && A[i, maxind - 1] < 0)
                {
                    A[i, maxind - 1] /= 2;
                }
                else if (maxind == A.GetLength(1) - 1 && A[i, maxind - 1] > 0)
                {
                    A[i, maxind - 1] *= 2;
                }
                else if(maxind>0 && maxind < A.GetLength(1) - 1){ 
                
                    if (A[i, maxind - 1] < A[i,maxind+1] && A[i, maxind - 1] > 0)
                    {
                        A[i, maxind-1] *= 2;
                        continue;
                    }else if (A[i, maxind - 1] < A[i, maxind + 1] && A[i, maxind - 1] < 0)
                    {
                        A[i, maxind-1] /= 2;
                        continue;
                    }
                    if (A[i, maxind - 1] > A[i, maxind + 1] && A[i, maxind - 1] > 0)
                    {
                        A[i, maxind+1] *= 2;
                        continue;
                    }
                    else if (A[i, maxind - 1] > A[i, maxind + 1] && A[i, maxind - 1] < 0)
                    {
                        A[i, maxind+1] /= 2;
                        continue;
                    }
                }
            }
           
            return A;
        }
        else
            return null;
        // end

        
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            for (int i = 0; i<A.GetLength(1); i++)
            {
                int cntplus = 0;
                int cntminus = 0;
                double maxElem = double.MinValue;
                int indmax = 0;
                for(int j = 0; j< A.GetLength(0); j++)
                {
                    if (A[j, i] > 0)
                        cntplus++;
                    else
                        cntminus++;
                    if (A[j, i] > maxElem)
                    {
                        maxElem = A[j, i];
                        indmax = j;
                    }
                }
                if (cntplus > cntminus)
                {
                    A[indmax, i] = 0;
                } else
                    A[indmax, i] = indmax;
            }

            return A;
        }
        else
            return null;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) == 10 && A.GetLength(1) == 5)
        {
            // end
            for(int i = 0; i<A.GetLength(1); i++)
            {
                int maxElem = int.MinValue;
                int indmax = 0;
                int sum = 0;
                int polmasa = A.GetLength(0) / 2;
                for(int j = 0; j<A.GetLength(0); j++)
                {
                    if (A[j, i] > maxElem)
                    {
                        maxElem = A[j, i];
                        indmax = j;
                    }
                }
                if (indmax < polmasa)
                {
                    for (int j = indmax+1; j < A.GetLength(0); j++)
                    {
                        sum += A[j, i];
                    }
                    A[0, i] = sum;
                }
            }
            
            return A;
        }
        else
        {
            return null;
        }
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5 && B.Length==5)
        {
            int maxElem = int.MinValue;
            int indmax = 0;
            for (int i = 0; i<A.GetLength(1); i++)
            {
                maxElem = int.MinValue;
                for (int j = 0; j<A.GetLength(0); j++)
                {
                    if (A[j, i] > maxElem)
                    {
                        maxElem = A[j, i];
                        indmax = j;
                    }

                }
                if (maxElem < B[i])
                    A[indmax, i] = B[i];

                
            }
           
            return A;
        }
        else
            return null;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            double maxElem = double.MinValue;
            int indmax = 0;
            double polusum = 0;
            for (int i = 0; i < A.GetLength(1); i++)
            {
                maxElem = double.MinValue;
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    if (A[j, i] > maxElem)
                    {
                        maxElem = A[j, i];
                        indmax = j;
                    }

                }
                polusum = (A[0, i] + A[A.GetLength(0) - 1, i]) / 2;
                Console.WriteLine("{0}, {1}, {2}", indmax, polusum, maxElem);
                if (maxElem < polusum)
                    A[indmax, i] = polusum;
                else
                    A[indmax, i] = indmax;


            }
            // end
            
            return A;
        }
        else return null;
    }
    public int[,] Task_2_6(int n)
    {
        if (n > 0)
        {
            int[,] answer = new int[n, 3 * n];
            // code here
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    if ((j + 1) % 3 == (i + 1) % 3)
                        answer[i, j] = 1;
                }
            }
            // end
            PrintMatrix(answer);
            return answer;
        }
        else return null;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) == 6 && A.GetLength(1) == 6)
        {
            int maxElem = int.MinValue;
            int ind = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == j && maxElem < A[i, j])
                    {
                        maxElem = A[i, j];
                        ind = i;
                    }
                }

            }
            for (int i = 0; i < ind; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        A[i, j] = 0;
                    }
                }

            }
            // end

            return A;
        }
        else return null;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) == 6 && B.GetLength(1) == 6)
        {

            for (int i = 0; i<B.GetLength(0); i+=2)
            {
                int maxElem1 = int.MinValue;
                int maxElem2 = int.MinValue;
                int indi1 = 0, indi2 = 0, indj1 = 0, indj2 = 0;
                for(int j = 0; j<B.GetLength(1); j++)
                {
                    if (maxElem1 < B[i, j])
                    {
                        maxElem1 = B[i, j];
                        indi1 = i;
                        indj1 = j;
                    }
                    if (maxElem2 < B[i+1, j])
                    {
                        maxElem2 = B[i+1, j];
                        indi2 = i+1;
                        indj2 = j;
                    }
                }
                int temp = B[indi1, indj1];
                B[indi1, indj1] = B[indi2, indj2];
                B[indi2, indj2] = temp;
            }
                
            
            return B;
        }
        else return null;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(1);
        int temp;
        if (A.GetLength(0) == 6 && A.GetLength(1) == 7)
        {
            for (int i = 0; i<A.GetLength(0); i++)
            {
                for(int j = 0; j<n/2; j++)
                {
                    temp = A[i, j];
                    A[i, j] = A[i, n - j-1];
                    A[i, n - j-1] = temp;
                }
            }
            PrintMatrix(A);
            return A;
        }
        else return null;
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
        if (matrix.GetLength(0) == matrix.GetLength(1))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = 0;
                matrix[0, i] = 0;
                matrix[matrix.GetLength(0) - 1, i] = 0;
                matrix[i, matrix.GetLength(0) - 1] = 0;
            }
            // end
            PrintMatrix(matrix);
            return matrix;
        }
        else return null;
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
        if (matrix.GetLength(0) == matrix.GetLength(1))
        {
            for (int i = matrix.GetLength(0)/2; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    if (i >= j)
                        matrix[i, j] = 1;
                }
            }
            PrintMatrix(matrix);
            return matrix;
        }
        else return null;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[] upper = new int[n*(n-1)/2+n];
        int[] lower = new int[n*(n-1)/2];
        int cnt1 = 0, cnt2 = 0;
        // code here
        if (matrix.GetLength(0) == matrix.GetLength(1))
        {
            for( int i = 0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        upper[cnt1] = matrix[i, j];
                        cnt1++;
                    }
                    else
                    {
                        lower[cnt2] = matrix[i, j];
                        cnt2++;
                    }
                }
            }
            foreach (int x in upper) Console.WriteLine(x);
            Console.WriteLine();
            foreach (int x in lower) Console.WriteLine(x);
            return (upper, lower);
        }
        else return (null, null);
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
        if (matrix.GetLength(0) == 7 && matrix.GetLength(1) == 5)
        {
            int cnt1=0, cnt2 = 0;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i,j] > 0) cnt2++;
                    }
                    if (cnt2 < cnt1 && i != matrix.GetLength(0) - 1)
                    {
                        flag = true;
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            int temp = matrix[i,j];
                            matrix[i,j] = matrix[i + 1,j];
                            matrix[i + 1,j] = temp;
                        }
                    }
                    cnt1 = cnt2;
                    cnt2 = 0;
                }
            }

            PrintMatrix(matrix);
            return matrix;
        }
        else return null;
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
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 != 0)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;
                    while(k>=0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;
                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
                for(int j=0; j<matrix.GetLength(1)/2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1];
                    matrix[i, matrix.GetLength(1) - j - 1] = temp;
                }
            }
        }
        // end
        PrintMatrix(matrix);
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int[] strtodel = new int[matrix.GetLength(0)];
        int cnt = 0;
        for(int i =0; i<matrix.GetLength(0); i++)
        {
            for(int j = 0; j<matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    strtodel[i] = 1;
                    cnt++;
                    continue;
                }
            }
        }
        int[,] newmatrix = new int[matrix.GetLength(0) - cnt+1, matrix.GetLength(1)];
        int count = 0;
        for (int i = 0; i<newmatrix.GetLength(0); i++)
        {
            
            
            if (strtodel[i] != 1)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
            newmatrix[count, j] = matrix[i, j];
            }
            count++;
            }
            else continue;
                
            
        }
        // end
        PrintMatrix(newmatrix);
        return newmatrix;
    }

    public static void PrintMatrix(int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion
}
