using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        int count = 0;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] > 0)
                {
                    answer += A[i, j];
                    count++;
                }
                    
            }
        }

        if (count > 0)
        {
            answer = answer / count;
        }

        else
            answer = 0;
        
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
            else
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
        double[] answer = default(double[]);
        // code here

        answer = new double[A.GetLength(0)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double s = 0;
            int count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }

            if(count != 0)
                answer[i] = s / count;
            else
                answer[i] = 0;
        }

        if (A.GetLength(0) != 4 && (A.GetLength(1) != 6))
            return default(double[]);

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
        int mini = 0;
        int index = -1;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < mini)
            {
                mini = A[i, 0];
                index = i;
            }
        }


        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];

        if(index != -1)
        {
            for (int i = 0; i < A.GetLength(0) - 1; i++)
            {
                if (i < index)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                        B[i, j] = A[i, j];
                }
                else
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                        B[i, j] = A[i + 1, j];
                }
            }
        }

        else
        {
            return default(int[,]);
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

        if (A.GetLength(0) != 4 && (A.GetLength(1) != 3))
            return default(int[]);

        answer = new int[A.GetLength(1)];

        for(int i = 0; i < A.GetLength(1); i++)
        {
            int count = 0;

            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    count++;
                }
            }



            answer[i] = count;
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
        
        int[] array = new int[B.GetLength(0)];
        int index = 0;

        if (B.GetLength(0) != n && (B.GetLength(1) != m))
            return default(int[,]);

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int mini = 100;
            for(int j = 0; j < B.GetLength(1); j++)
            {
                if(B[i, j] < mini)
                {
                    mini = B[i, j];
                    index = j;
                }
            }
            array[i] = index;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int t = B[i, array[i]];

            if (array[i] != 0)
            {
                for (int j = array[i]; j > 0; j--)
                {
                    B[i, j] = B[i, j - 1];
                }
            }
            else
                continue;
            B[i, 0] = t;
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
        n = F.GetLength(0);
        m = F.GetLength(1);
        int[] array = new int[F.GetLength(0)];

        for(int i = 0; i < F.GetLength(0); i++)
        {
            double maxi = -100;
            int index = 0;
            for(int j = 0; j < F.GetLength(1); j++)
            {
                if(F[i, j] > maxi)
                {
                    maxi = F[i, j];
                    index = j;
                }
            }
            array[i] = index;
        }
        double[] array2 = new double[n];
        for(int i = 0; i < F.GetLength(0); i++)
        {
            double otr1 = 0, otr2 = 0;
            for(int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < 0)
                {
                    otr1 = F[i, j];
                    break;
                }
            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    otr2 = F[i, j];
                    break;
                }
            }

            array2[i] = (otr1 + otr2)/2;
        }
        for(int i = 0; i < n; i++)
        {
            if (array2[i] != 0)
            {
                F[i, array[i]] = array2[i];
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
        int[] array = new int[G.GetLength(0)];

        if (G.GetLength(0) != 5 && (G.GetLength(1) != 7))
            return default(int[,]);

        for (int  i = 0; i < G.GetLength(0); i++)
        {
            int maxi = -100, index = 0;
            for(int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > maxi)
                {
                    maxi = G[i, j];
                    index = j;
                }
            }
            array[i] = index;
        }

        for(int i = 0; i < G.GetLength(0); i++)
        {

            for(int j = G.GetLength(1) - 1; j > array[i] + 1; j--)
            {

                G[i, j] = G[i, j - 1];
            }

            G[i, array[i] + 1] = G[i, array[i]];
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
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
            return default(int[,]);
        if (B.Length != 7)
        {
            return default(int[,]);
        }
        int index = 0;
        int maxi = -100;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            
            if (A[i, 5] > maxi)
            {
                maxi = A[i, 5];
                index = i;
            }
        }

        for(int i = 0; i < A.GetLength(0); i++)
        {
            if(i == index)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = B[j];
                }
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
        if (F.GetLength(0) != 5 && (F.GetLength(1) != 7))
            return default(int[,]);
        int mini = 100;
        int index = -1;

        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < mini)
            {
                mini = Math.Abs(F[1, j]);
                index = j; 
            }
        }

        
        if (index >= 0 && index < F.GetLength(1) - 1)
        {
            
            int[,] F2 = new int[F.GetLength(0), F.GetLength(1) - 1];

            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    if (j <= index) 
                    {
                        F2[i, j] = F[i, j];
                    }
                    else if (j == index + 1) 
                    {
                        continue;
                    }
                    else 
                    {
                        F2[i, j - 1] = F[i, j]; 
                    }
                }
            }

            
            F = F2;
        }
        else return F;


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
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
            return default(double[,]);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxi = -100;
            int index = -1;
            for(int j = 0;j < A.GetLength(1); j++)
            {
                if(A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index = j;
                }
            }
            double sum = 0;
            double kol = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    kol++;
                }
            }
            sum = sum / kol;
            if(sum >= 0)
            {
                A[i, index] = sum;
            }
            else
            {
                A[i, index] = 0;
            }
            
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
        if (A.GetLength(0) != 5 && (A.GetLength(1) != 7))
            return default(double[,]);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxi = -100;
            int index = -1;
            for(int j = 0;j < A.GetLength(1); j++)
            {
                if(A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index = j;
                }
            }

            if(index != 0 && index < A.GetLength(1) - 1)
            {
                if (A[i, index - 1] < A[i, index + 1])
                {
                    if(A[i, index - 1] > 0)
                    {
                        A[i, index - 1] *= 2;
                    }
                    else
                    {
                        A[i, index - 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, index + 1] > 0)
                    {
                        A[i, index + 1] *= 2;
                    }
                    else
                    {
                        A[i, index + 1] /= 2;
                    }
                }
            }

            else if (A[i, index] == 0)
            {
                if (A[i, index + 1] > 0)
                {
                    A[i, index + 1] *= 2;
                }
                else
                {
                    A[i, index + 1] /= 2;
                }
            }
            else if (A[i, index] == A.GetLength(1) - 1)
            {
                if (A[i, index - 1] > 0)
                {
                    A[i, index - 1] *= 2;
                }
                else
                {
                    A[i, index - 1] /= 2;
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
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
            return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = -100;
            int index = -1;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index = i;
                }
            }
            int kolpol = 0;
            int kolotr = 0;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i, j] > 0)
                {
                    kolpol += 1;
                }
                else if (A[i, j] < 0)
                {
                    kolotr += 1;
                }
            }
            if (kolpol > kolotr)
            {
                A[index, j] = 0;
            }
            else
            {
                A[index, j] = index + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 && (A.GetLength(1) != 5))
            return default(int[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0;
            int index = -1;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index = i;
                }
            }

            if(index <= 4)
            {
                int sum = 0;
                for(int i = index + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
            return default(int[,]);
        if (B.Length != 5)
            return default(int[,]);

        for (int j = 0;j < A.GetLength(1); j++)
        {
            int maxi = -100;
            int index = -1;
            for(int i = 0;i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi= A[i, j];
                    index = i;
                }
            }

            if (B[j] > maxi)
            {
                A[index, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 && (A.GetLength(1) != 5))
            return default(double[,]);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxi = -100;
            int index = -1;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index = i;
                }
            }

            double polsum = (A[0,j] + A[6,j])/2;
            if(maxi < polsum)
            {
                A[index,j] = polsum;
            }
            else
            {
                A[index, j] = index + 1;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3)
            return answer;
        answer = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    answer[i, j] = 1;
                else
                    answer[i, j] = 0;
            }
        }
        
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && (A.GetLength(1) != 6))
            return default(int[,]);
        int maxi = -100, index = -1;
        int n = A.GetLength(0);
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i,i] > maxi)
            {
                maxi = A[i, i];
                index = i;
            }
        }
        for(int i = 0; i < n; i++)
        {
            if(i < index)
            {
                for(int j = 0;j < n; j++)
                {
                    if(i != j && j > i)
                    {
                        A[i,j] = 0;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 && (B.GetLength(1) != 6))
            return default(int[,]);
        int n = B.GetLength(0);
        int[] B2 = new int[6];
        int[] B3 = new int[6];
        for(int i = 0; i < n; i++)
        {
            int maxi = -100;
            int index = -1;
            for(int j = 0; j < n; j++)
            {
                if(B[i,j] > maxi)
                {
                    maxi = B[i,j];
                    index = j;
                }
            }

            B2[i] = maxi;
            B3[i] = index;
        }
        for (int i = 0; i < n - 1; i+= 2)
        {
 
            int temp1 = B2[i];
            int temp2 = B[i, B3[i]];
            B[i, B3[i]] = B[i + 1, B3[i + 1]];
            B[i + 1, B3[i + 1]] = temp2;

        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && (A.GetLength(1) != 7))
            return default(int[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int[] A2 = new int[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A2[j] = A[i, j];
            }
            int n = 1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = A2[A2.Length - n];
                n++;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return default(int[,]);
        int n = matrix.GetLength(0);
        for (int i = 0; i < n * n; i++)
        {
            int str = i / n;
            int stl = i % n;
            if (str == 0 || str == n - 1 || stl == 0 || stl == n - 1)
            {
                matrix[str, stl] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return default(int[,]);
        int n = matrix.GetLength(0);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i >= j && i >= n / 2)
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);
        int n = matrix.GetLength(0);
        int upperrange = (n * n) / 2 + (n / 2);
        upper = new int[upperrange];
        lower = new int[n * n - upperrange];
        int index = 0, index2 = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < n; j++)
            {
                if(i <= j)
                {
                    upper[index++] = matrix[i, j];
                }
                else
                {
                    lower[index2++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 && (matrix.GetLength(1) != 5))
            return default(int[,]);

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] kolpol = new int[n];
        for(int i = 0; i < n; i++)
        {
            int kol = 0;
            for(int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                {
                    kol++;
                }
            }
            kolpol[i] = kol;
        }

        int maxkol = kolpol[0], maxindex = 0;
        for (int i = 0; i < n; i++)
        {
            if (kolpol[i] > maxkol)
            {
                maxkol = kolpol[i];
                maxindex = i;
            }
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (kolpol[j] < kolpol[j + 1])
                {
                    for (int k = 0; k < m; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
                    int temp2 = kolpol[j];
                    kolpol[j] = kolpol[j + 1];
                    kolpol[j + 1] = temp2;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m - 1; j++)
            {
                for(int k = 0; k < m - j - 1; k++)
                {
                    if(i % 2 == 0)
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
                            int temp2 = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp2;
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

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int kol0 = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    kol0++;
                    break;
                }
            }
        }

        int[,] matrix2 = new int[n - kol0, m];
        int i2 = 0;

        for (int i = 0; i < n; i++)
        {
            bool proverka0 = false;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    proverka0 = true;
                    break;
                }
            }

            if (proverka0 == false)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix2[i2, j] = matrix[i, j];
                }
                i2++;
            }
        }

        return matrix2;
        // end

        return matrix;
    }
    #endregion
}