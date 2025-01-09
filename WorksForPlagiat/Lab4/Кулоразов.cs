using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4)
            return 0;
        for (int i = 0; i < 4; i++)
        { 
            answer += A[i,i];
        }
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
            return null;
        int[] answer = new int[4];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double min = double.MaxValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    answer[i] = j;
                }
            }
            Console.WriteLine(answer[i]);
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        int[,] answer = new int[5,7];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxindex = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            A[i, maxindex] = A[i, 0];
            A[i, 0] = max;
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", A[i,0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        int[,] answer = new int[5, 6];
        int max = int.MinValue;
        int maxi = -1;
        int maxj = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                    maxj = j;
                }
            }
        }
        Console.WriteLine(max);
        int ia = -1;
        int ja = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == maxi)
                continue;
            ia += 1;
            ja = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j == maxj)
                    continue;
                ja += 1;
                answer[ia, ja] = A[i, j];
            }
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5]);
        }
        return answer;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxindex = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            A[i, maxindex] = A[i, maxindex]*(i +1);
            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
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
    public int[,] Task_1_18(int[,] A, int n, int m)
    {
        if (A.GetLength(0) != n || A.GetLength(1) != m||n<=0||m<=0)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxindex = -1;
            int index1= -1;
            int index2= -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= 0 && index1==-1)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        maxindex = j;
                    }
                }
                if (A[i, j] < 0 && index1 == -1)
                    index1 = j;
                if (A[i, j] < 0)
                    index2 =j;
            }
            if (maxindex != -1 && index1 != -1 && index2 != -1)
            {
                A[i, maxindex] = A[i, index2];
                A[i, index2] = max;
            }
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
        }
        return A;
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
    public int[,] Task_1_21(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            A[i, 6] = A[i, 5];
            A[i, 5] = max;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
        }

        return A;
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
    public double[,] Task_1_24(double[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 5)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int maxindex = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            double count = 0;
            double sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > maxindex && A[i,j]>0)
                {
                    sum += A[i, j];
                    count++;
                }
            }
            double sr = 0;
            if (count != 0)
                sr = sum / count;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j < maxindex && A[i, j] < 0)
                {
                    A[i, j] = sr;
                }
            }
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
        }

        return A;
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
    public int[,] Task_1_27(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        int[] sp = new int[A.GetLength(0)];
        for (int i = 0; i < sp.Length; i++)
            sp[i] = int.MinValue;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] > sp[i])
                {
                    sp[i] = A[i, j];
                }
            }
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5], A[i, 6]);
        }
        int k = A.GetLength(0);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            k = k - 1;
            A[i, 3] = sp[k];
        }
        return A;
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
    public int[,] Task_1_30(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
            return null;
        int k1 = -1;
        int max = -1;
        int k2 = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (k1 == -1 && A[i, 2] < 0)
                k1 = i;
            if (A[i, i] >= max)
                k2 = i;
        }
        int p = 0;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            p = A[k1, j];
            A[k1, j] = A[k2, j];
            A[k2, j] = p;
        }

        return A;
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
        //int[] answer = new int[20];
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            //int[] ans = new int[0];
            return null;
        }
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] < 0)
                    k += 1;
        int[] answer = new int[k];
        k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] < 0)
                {
                    answer[k] = A[i, j];
                    k += 1;
                }
        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int maxindex = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                { 
                    max= A[i, j];
                    maxindex = j;
                }
            }
            if (maxindex != 0 && maxindex != A.GetLength(1) - 1)
                if (A[i, maxindex - 1] < A[i, maxindex + 1])
                    if (A[i, maxindex - 1]>=0)
                        A[i, maxindex - 1] = A[i, maxindex - 1] * 2;
                    else
                        A[i, maxindex - 1] = A[i, maxindex - 1] / 2;
                else
                    if (A[i, maxindex + 1] >= 0)
                        A[i, maxindex + 1] = A[i, maxindex + 1] * 2;
                    else
                        A[i, maxindex + 1] = A[i, maxindex + 1] / 2;
            else if (maxindex == 0)
                if (A[i, maxindex + 1] >= 0)
                    A[i, maxindex + 1] = A[i, maxindex + 1] * 2;
                else
                    A[i, maxindex + 1] = A[i, maxindex + 1] / 2;
            else if (maxindex == A.GetLength(1) - 1)
                if (A[i, maxindex - 1] >= 0)
                    A[i, maxindex - 1] = A[i, maxindex - 1] * 2;
                else
                    A[i, maxindex - 1] = A[i, maxindex - 1] / 2;
        }
        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double count1 = 0;
            double count2 = 0;
            int maxindex = int.MinValue;
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                    count1+=1;
                if (A[i, j] < 0)
                    count2+=1;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = i;
                }
            }
            if (count1 > count2)
                A[maxindex, j] = 0;
            else
                A[maxindex, j] = maxindex;

        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            int maxindex = int.MinValue;
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = i;
                }
            }
            if (maxindex <= 4)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (i > maxindex)
                        count += A[i, j];
                }
                A[0, j] = count;
            }

        }
        return A;

    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxindex = int.MinValue;
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = i;
                }
            }
            if (max < B[j])
                A[maxindex, j] = B[j];
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxindex = int.MinValue;
            double max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = i;
                }
            }
            if (max < (A[0, j] + A[A.GetLength(0) - 1, j]) / 2)
                A[maxindex, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            else
                A[maxindex, j] = maxindex;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0)
            return null;
        int[,] answer = new int[n,3*n];
        int[,] ans = new int[n, n];
        for(int i=0;i<n;i++)
            ans[i,i] = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 3*n; j++)
                answer[i,j]=ans[i,j%3];
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int maxindex = int.MinValue;
        int max = int.MinValue;
        for (int i = 0; i < A.GetLength(0); i++)
            if (A[i, i] > max)
            { 
                max = A[i, i]; 
                maxindex = i;
            }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < maxindex && j > i)
                    A[i, j] = 0;
            }
            Console.WriteLine("{0} {1} {2} {3} {4} {5}",A[i,0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5]);
        }
        return A;
    }
    public int[,] Task_2_8(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int maxindex1 = int.MinValue;
        int maxindex2 = int.MinValue;
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int flag = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = int.MinValue;
            int maxindex = int.MinValue;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxindex = j;
                }
            }
            if (flag == 0)
            { 
                maxindex1 = maxindex;
                max1 = max;
                flag += 1;
            }
            else if (flag == 1)
            {
                maxindex2 = maxindex;
                max2 = max;
                A[i - 1, maxindex1] = max2;
                A[i, maxindex2] = max1;
                flag = 0;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5]);
        }
        return A;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        int[,] ans = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0, p = A.GetLength(1)-1;j< A.GetLength(1);j++, p--)
                ans[i, j] = A[i, p];
        /*for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", A[i, 0], A[i, 1], A[i, 2], A[i, 3], A[i, 4], A[i, 5]);
        }*/
        return ans;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;

        int[,] sort = new int[A.GetLength(0), 2];
        int[,] ans = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                { 
                    min = A[i, j];
                }
            }
            sort[i,0]=min;
            sort[i, 1] = i;
        }

        for(int i =0;i<sort.GetLength(0);i++)
            Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i,1]);

        while (true)
        {
            int flag = 0;
            for (int i = 1; i < sort.GetLength(0); i++)
                if (sort[i, 0] > sort[i - 1, 0])
                {
                    int p0 = sort[i - 1, 0];
                    int p1 = sort[i - 1, 1];
                    sort[i - 1, 0] = sort[i, 0];
                    sort[i - 1, 1] = sort[i, 1];
                    sort[i, 0] = p0;
                    sort[i, 1] = p1;
                }
                else
                    flag += 1;
            if(flag== sort.GetLength(0)-1)
                    break;
        }

        Console.WriteLine();
        for (int i = 0; i < sort.GetLength(0); i++)
            Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i, 1]);

        for (int i = 0; i < ans.GetLength(0); i++)
            for (int j = 0; j < ans.GetLength(1); j++)
            {
                ans[i, j] = A[sort[i, 1], j];
            }
        return ans;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
            return null;
        int[] answer = new int[2*matrix.GetLength(0)-1];

        int k = 0;
        for (int s = matrix.GetLength(0) - 1; s >= 0; s--)
        {
            int pi = s;
            int pj = 0;
            do
            { 
                answer[k] += matrix[pi, pj];
                pi += 1;
                pj += 1;
            }
            while (pi < matrix.GetLength(0) && pj < matrix.GetLength(1));
            k += 1;
        }

        for (int s = 1; s <matrix.GetLength(1); s++)
        {
            int pi = 0;
            int pj = s;
            do
            {
                answer[k] += matrix[pi, pj];
                pi += 1;
                pj += 1;
            }
            while (pi < matrix.GetLength(0) && pj < matrix.GetLength(1));
            k += 1;
        }

        Console.WriteLine();
        for (int i = 0; i < answer.Length; i++)
            Console.WriteLine(answer[i]);

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        //
        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0||k>matrix.GetLength(0)||k<1)
            return null;
        k = k - 1;
        int indexi=int.MinValue;
        int indexj=int.MinValue;
        int max=int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (Math.Abs(matrix[i, j]) > max)
                { 
                    max= Math.Abs(matrix[i, j]);
                    indexi=i;
                    indexj=j;
                }
        for (int p = 0; p < matrix.GetLength(1); p++)
        {
            int l = matrix[indexi, p];
            matrix[indexi, p] = matrix[k, p];
            matrix[k, p] = l;
        }
        for (int p = 0; p < matrix.GetLength(0); p++)
        {
            int l = matrix[p, indexj];
            matrix[p, indexj] = matrix[p, k];
            matrix[p, k] = l;
        }
        for(int i = 0;i<matrix.GetLength(0);i++)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", matrix[i,0], matrix[i, 1], matrix[i, 2], matrix[i, 3], matrix[i, 4], matrix[i, 5]);

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

        if (A.Length!=(n+1)/2*n|| B.Length != (n + 1) / 2 * n||n<=0)
            return null;
        int[] answer = new int[n*n];
        int[,] Am = new int[n,n];
        int[,] Bm = new int[n,n];
        int p = 0;

        p = 0;
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                Am[i, j] = A[p];
                p += 1;
            }
        p = 0;
        for (int j = 0; j < n; j++)
            for (int i = j; i < n; i++)
            {
                Am[i, j] = A[p];
                p += 1;
            }

        p = 0;
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                Bm[i, j] = B[p];
                p += 1;
            }
        p = 0;
        for (int j = 0; j < n; j++)
            for (int i = j; i < n; i++)
            {
                Bm[i, j] = B[p];
                p += 1;
            }

        p = 0;
        for (int i = 0; i < n; i++)         
            for (int j = 0; j < n; j++)     
            {                               
                int a = 0;
                for (int ii = 0, jj = 0; ii < n; ii++, jj++)
                {
                    a += Am[i, jj] * Bm[ii, j];
                    Console.WriteLine("{0} {1} {2}",Am[i, jj] * Bm[ii, j], Am[i, jj], Bm[ii, j]);
                }
                answer[p] = a;
                p+=1;
            }
        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;

        int[,] sort = new int[2, A.GetLength(1)];
        int[,] ans = new int[A.GetLength(0), A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
            {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                    count += 1;
            }
            sort[0, j] = count;
            sort[1, j] = j;
        }

        //for (int i = 0; i < sort.GetLength(0); i++)
        //    Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i, 1]);

        while (true)
        {
            int flag = 0;
            for (int j = 1; j < sort.GetLength(1); j++)
                if (sort[0, j] < sort[0,j-1])
                {
                    int p0 = sort[0, j-1];
                    int p1 = sort[1, j-1];
                    sort[0, j-1] = sort[0, j];
                    sort[1, j-1] = sort[1, j];
                    sort[0, j] = p0;
                    sort[1, j] = p1;
                }
                else
                    flag += 1;
            if (flag == sort.GetLength(1) - 1)
                break;
        }

        Console.WriteLine();
        for (int i = 0; i < sort.GetLength(0); i++)
            Console.WriteLine("{0}\t{1}", sort[i, 0], sort[i, 1]);

        int p = 0;
        for (int j = 0; j < ans.GetLength(1); j++)
            for (int i = 0; i < ans.GetLength(0); i++)
            {
                ans[i, j] = A[i, sort[1, j]];
            }
        return ans;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int n = 0;
        int[] arr = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    n += 1;
                    arr[i] = 1;
                    break;
                }

        int[,] answer = new int[matrix.GetLength(0)-n, matrix.GetLength(1)];
        int p = -1;
        for (int i = 0; i < answer.GetLength(0);i++)
        {
            if (arr[i] == 1)
                continue;
            p += 1;
            for (int j = 0; j < matrix.GetLength(1); j++)
                answer[p,j]= matrix[i,j];
        }
        
        return answer;
    }
    #endregion
}