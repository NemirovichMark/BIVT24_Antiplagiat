using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        int n = 4;
        int m = 4;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return 0; }
        else
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (i==j)
                        answer+= A[i, j];
            }
        }
        Console.WriteLine(answer);
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
        int n = 4;
        int m = 7;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return answer; }
        else
        answer = new int[n];
        {
            
            
            for (int i = 0; i < n; i++)
            {
                int minel = 10000;
                int indmin = -1;
                for (int j = 0; j < m; j++) 
                { 
                    if (minel> A[i, j]) { minel = A[i, j]; indmin = j; }
                    
                }
                answer[i]= indmin; 
            }
        }
        Console.WriteLine(answer);
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
        int[,] answer = new int[5, 7];
        int n = 5;
        int m = 7;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m|| A == null) { return null; }
        else
        {
            for (int i = 0; i < n; i++)
            {
                int maxel = -100000;
                int indmax = 0;
                int value = 0;
                for (int j = 0; j < m; j++)
                {
                    if (maxel< A[i, j]) { maxel = A[i, j]; indmax = j; }

                }
                (A[i, 0], A[i, indmax]) = (A[i, indmax], A[i, 0]);
                
                Console.WriteLine(A[i,0]);
                Console.WriteLine(A[i,indmax]);
            }
        }
        Console.WriteLine(A);
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
        
        int n = 6;
        int m = 7;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m|| A == null) { return default; }
        else
        {
            int[,] answer = new int[5, 6];
            int maxel = -100000;
            int numstb = 0;
            int numstr = 0;
            int value = 0;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    if (maxel< A[i, j]) { maxel = A[i, j]; numstb = j; numstr = i; }

                }
            }
            int[,] B = new int[n - 1, m];

            for (int i = 0; i < n - 1; i++) 
            {
                if (i < numstr)
                {
                    for (int j = 0; j < m; j++) { B[i, j] = A[i, j]; }
                }
                else
                {
                    for (int j = 0; j < m; j++) { B[i, j] = A[i + 1, j]; }
                }
            }
            int[,] A1 = new int[n - 1, m - 1];
            for (int j = 0; j < m - 1; j++) 
            {
                if (j < numstb)
                {
                    for (int i = 0; i < n - 1; i++) { A1[i, j] = B[i, j]; }
                }
                else
                {
                    for (int i = 0; i < n - 1; i++) { A1[i, j] = B[i, j + 1]; }
                }
            }

            return A1;
        }
        // end

        
    }
    public int[,] Task_1_13(int[,] A)
    {
        
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
        int n = 5;
        int m = 7;
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m|| A == null) return default;
        else
        {


            int[,] answer = new int[5, 6];

            for (int i = 0; i < n; i++)
            {
                int maxel = A[i, 0]; int indj = 0;
                for (int j = 0; j < m; j++)
                {
                    if (maxel< A[i, j]) { maxel = A[i, j]; indj = j; }

                }
                A[i, indj] = A[i, indj] * (i+1);

            }
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
        if (  D== null) { return D; }


        for (int i = 0; i < n; i++)
        {
            int indexf = 0, indexl = 0, maxi = D[i, 0], indexmaxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {indexf = j;break;}
            }

            for (int j = 0; j < indexf; j++)
            {
                if (D[i, j] > maxi)
                {
                    maxi = D[i, j];
                    indexmaxi = j;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    indexl = j;
                }
            }
            var t = D[i, indexmaxi];
            if (indexf != 0)
            {
                t = D[i, indexmaxi];
                D[i, indexmaxi] = D[i, indexl];
                D[i, indexl] = t;
            }

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
        int n = 5;
        int m = 7;
        if (H.GetLength(0) != n || H.GetLength(1) != m|| H == null) return default;
        for (int i = 0; i < n; i++)
        {
            int maxel = H[i, 0], indexmax = 0, t = 0;
            for (int j = 0; j< m; j++)
            {
                if (H[i, j] > maxel) { indexmax = j; maxel = H[i,j];}
            }
            t = H[i, m-2];
            H[i,m -2] = H[i, indexmax];
            H[i, m-1] = t;
            //for (int j = 0; j< m; j++)
            //{
            //    Console.WriteLine(H[i, j]);
            //}
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
        int n = 6;
        int m = 5;
        if (Y.GetLength(0) != n || Y.GetLength(1) != m|| Y == null) return default;
        for (int i = 0; i < n; i++)
        {
            double maxel = Y[i, 0]; int indexmax = 0;
            for (int j = 0; j< m; j++)
            {
                if (Y[i, j] > maxel) { indexmax = j; maxel = Y[i, j]; }
            }
            double sum = 0;
            int k = 0;
            for (int j = indexmax +1; j< m; j++)
            {
                if (Y[i, j]>0) {  sum += Y[i, j]; k++; }
            }
            double sr = 0;
            if (k==0) { sr = 0; }
            else { sr = sum/k; }
            
            for (int j = 0; j< indexmax; j++)
            {
                if (Y[i, j]<00) { Y[i, j] = sr;}
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
        int n = 5;
        int m = 7;
        if (B.GetLength(0) != n || B.GetLength(1) != m || B == null) return default;
        else 
        {
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                int maxel = B[i, 0], indexmax = 0;
                for (int j = 0; j < m; j++)
                {
                    if (B[i, j] > maxel)
                    {
                        maxel = B[i, j];
                        indexmax = j;
                    }
                }
                A[i] = maxel;
            }
            for (int i = 0; i < n; i++)
            {
                B[i, 3] = A[n - i -1];

            }
            return B;
        }
        // end

        
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
        int n = 5;
        int m = 5;
        if (B.GetLength(0) != n || B.GetLength(1) != m || B == null) return default;
        int neg = 0, indexneg = 0;
        for (int i = 0; i < n; i++)
        {

            if (B[i,2] < 0) { neg = B[i, 2]; indexneg = i; break; }
        }
        int maxel = B[0, 0], indexmax = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j=0; j<m; j++)
            {
                if (i==j)
                {
                    if (B[i, j] > maxel)
                    {
                        maxel = B[i, j];
                        indexmax = i;
                    }
                }
            }
        }
        for (int j = 0; j < m; j++)
        {
            var t = B[indexmax, j];
            B[indexmax, j] = B[indexneg, j];
            B[indexneg, j] = t;

        }
        return B;


        // end


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
        int n = 5;
        int m = 7;
        if (A.GetLength(0) != n || A.GetLength(1) != m || A == null) return default;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0) {k++;}
            }
        }
        answer = new int[k];
        k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                if (A[i, j]<0) { answer[k] = A[i, j]; k++; }
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
        int n = 5;
        int m = 7;
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return default; }
        for (int i = 0; i < n; i++)
        {
            double maxel = A[i, 0];
            int indexmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxel){ maxel = A[i, j]; indexmax = j;}
            }
            if (indexmax != 0 && indexmax != m - 1)
            {
                if (A[i, indexmax - 1] < A[i, indexmax + 1])
                {
                    if (A[i, indexmax - 1] > 0) { A[i, indexmax - 1] *= 2; }
                    else { A[i, indexmax - 1] /= 2; }
                }
                else
                {
                    if (A[i, indexmax + 1] > 0) { A[i, indexmax + 1] *= 2; }
                    else { A[i, indexmax + 1] /= 2; }
                }
            }
            else if (indexmax == 0)
            {
                if (A[i, 1] > 0) { A[i, 1] *= 2; }
                else { A[i, 1] /= 2; }
            }
            else
            {
                if (A[i, m - 2] > 0) { A[i, m - 2] *= 2; }
                else { A[i, m - 2] /= 2; }
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = 7;
        int m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return default; }
        for (int j = 0; j < m; j++)
        {
            int kpos = 0, kneg = 0, maxel = 0, indexmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j]>=0) {  kpos++; }
                else { kneg++; }
                if (A[i, j] > maxel) { maxel = A[i, j]; indexmax = i; }
            }
            if (kpos> kneg) { A[indexmax, j] = 0; }
            else { A[indexmax,j] = indexmax+1; }
        }
        // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = 10;
        int m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return default; }
        for (int j = 0; j < m; j++)
        {
            int maxel = 0, indexmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > maxel) { maxel = A[i, j]; indexmax = i; }
            }
            if (indexmax+1<=A.Length/2)
            {
                int sum = 0;
                for (int i = indexmax+1;i < n; i++) { sum+= A[i, j]; }
                A[0,j] = sum;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = 7;
        int m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m || B ==null|| B.Length!=5) { return default; }
        for (int j = 0; j < m; j++)
        {
            int maxel = 0, indexmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > maxel) { maxel = A[i, j]; indexmax = i; }
            }
            if (B[j]>A[indexmax, j]) { A[indexmax, j] = B[j]; }
            
        }
            // end

            return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = 7;
        int m = 5;
        if (A.GetLength(0) != n || A.GetLength(1) != m ) { return default; }
        for (int j = 0; j < m; j++)
        {
            double maxel = 0; int indexmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > maxel) { maxel = A[i, j]; indexmax = i; }
            }
            double sum = A[0, j]+ A[n-1, j]/2;
            if (sum>A[indexmax, j]) { A[indexmax, j] = sum; }
            else { A[indexmax,j] = indexmax+1; }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return default;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++){ answer[i, j] = 0; }
        }
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = k; j < 3 * n; j += 3) { answer[i, j] = 1; }
            k++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = 6;
        int m = 6;
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return default; }
        double maxel = 0; int indexmax = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > maxel) { maxel = A[i, i]; indexmax = i; }
        }
        for (int i = 0; i < indexmax; i++)
        {
            for (int j = i + 1; j < m; j++)
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
        int n = 6;
        int m = 6;
        if (B.GetLength(0) != n || B.GetLength(1) != m) { return default; }
        for (int i = 0; i < m-1;)
        {
            double maxel = 0; int indexmax = 0;
            double maxel2 = 0; int indexmax2 = 0;
            for (int j = 0; j < n; j++)
            {
                if (B[i, j] > maxel) { maxel = B[i, j]; indexmax = j; }
            }
            for (int j = 0; j < n; j++)
            {
                if (B[i+1, j] > maxel2) { maxel2 = B[i+1, j]; indexmax2 = j; }
            }
            var t = B[i, indexmax];
            B[i,indexmax] = B[i+1,indexmax2];
            B[i+1, indexmax2]=t;
            i+=2;
        }
        // end

            return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = 6;
        int m = 7;
        if (A.GetLength(0) != n || A.GetLength(1) != m) { return default; }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                var t = A[i, m - j - 1];
                A[i, m - j - 1] = A[i, j];
                A[i, j] = t;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = 7;
        int m = 5;
        if (matrix.GetLength(0) != n || matrix.GetLength(1) != m) { return default; }
        for (int i = 1; i < n;)
        {
            int min1 = 10000, min2 = 10000;
            for (int j = 0; j < m; j++)
            {
                if (i!=0)
                {
                    
                    if (matrix[i - 1, j] <= min1) min1 = matrix[i - 1, j];
                    if (matrix[i, j] <= min2) min2 = matrix[i, j];
                }
            }
            if (i == 0 || min1>=min2)
                i++;
            else
            {
                for (int j = 0; j < m; j++)
                {
                    int t = matrix[i, j];
                    matrix[i, j] = matrix[i-1, j];
                    matrix[i-1, j] = t;
                }
                i--;
            }
        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || 0>=n) return default;
        answer = new int[2*n-1];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n-1;
                answer[index] += matrix[i, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k > n || k < 1) return null;
        int imax = 0, jmax = 0,maxel=0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > maxel) { imax = i; jmax = j; maxel = Math.Abs(matrix[i, j]); }

        if (imax == k && jmax == k) return matrix;

        for (int j = 0; j < n; j++)
        {
            int t = matrix[k-1, j];
            matrix[k-1, j] = matrix[imax, j];
            matrix[imax, j] = t;
        }
        for (int i = 0; i < n; i++)
        {
            int tmp = matrix[i, k - 1];
            matrix[i, k-1] = matrix[i, jmax];
            matrix[i, jmax] = tmp;
        }

        //end
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
        int m1 = A.Length, m2 = B.Length;
        if (m1 != m2 || m1 == 0) return default;
        var A1 = new int[n, n]; var B1 = new int[n, n]; var res = new int[n, n];
        answer = new int[n*n];
        int p = 0;
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                A1[i, j] = A[p];
                A1[j, i] = A[p];
                B1[i, j] = B[p];
                B1[j, i] = B[p];
                p++;
            }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                {
                    res[i, j] += A1[i, k] * B1[k, j];
                }
        int count = 0;
        for (int i = 0; i< n; i++) 
        {
            for (int j = 0;j<n; j++)
            {
                answer[count] = res[i, j];
                count++;
            }
            
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
 
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7 ) return default;
        var kneg = new int[m];
        for (int j = 0; j < m; j++)
        {
            int k = 0;
            for (int i = 0; i<n; i++)
            {
                if (matrix[i, j] < 0) { k++; }
            }
            kneg[j] = k;
        }
        for (int pos = 1; pos < m; pos++)
        {
            int j = pos;
            while (j > 0 && kneg[j-1] > kneg[j])
            {
                var t = kneg[j-1];
                kneg[j-1] = kneg[j];
                kneg[j] = t;
                for (int i = 0; i < n; i++)
                {
                    t = matrix[i, j-1];
                    matrix[i, j-1] = matrix[i, j];
                    matrix[i, j] = t;
                }
                j--;
            }
        }

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
        int n = matrix.GetLength(0), m = matrix.GetLength(1), k = 0;
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) {k++; break;}
            }
        }
        int[,] A = new int[n - k, m];
        for (int i = 0; i < n-k; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) { break; }
                else { A[i, j] = matrix[i, j]; }
            }    
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}