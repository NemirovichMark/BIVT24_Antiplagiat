using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] A = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
        program.Task_2_2(A);

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
        for (int i = 0; i < 5; i ++)
        {
            for (int j = 0; j < 7; j ++)
            {
                if (A[i, j] > 0)
                {
                    count++;
                    answer += A[i, j];
                }
            }
        }
        answer = answer / count;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4) return (0, 0);
        for (int i = 0;i < 5; i++)
        {
            for (int j = 0; j < 4; j ++)
            {
                if ((A[i, j] < 0))
                {
                    value = A[i, j];
                    rowIndex = i;
                }
            }
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
        answer = new double[4];
        
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return null;
        for (int i = 0;i < 4; i++)
        {
            int count = 0;
            double s = 0;
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] > 0)
                {
                    count++;
                    s += A[i, j];
                }
            }
            if (count != 0)
            {
                answer[i] = s/count;
            }

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
        int str = 0;
        double mini = double.MaxValue;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0;i < 5; i++)
        {
            for (int j = 0; j < 1; j ++)
            {
                if (A[i, j] < mini)
                {
                    mini = A[i, j];
                    str = i;
                }
            }
        }
        int[,] B = new int[4, 7];
        for (int i = 0; i < 4; i ++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i < str)
                {
                    B[i, j] = A[i, j];
                }               
                else
                {
                    B[i, j] = A[i + 1, j];
                }
            }
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
        int[] answer = default(int[]);
        // code here
        answer = new int[3];
        if (A.GetLength(0) != 4 && A.GetLength(1) != 3) return null;
        for(int j  = 0; j < 3; j++)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if ((A[i, j] < 0))
                {
                    count++;
                }
            }
            answer[j] = count;
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
        
        int el = 0;
        for (int i = 0; i < n; i++)
        {
            int ind = 0;
            int mini = int.MaxValue;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < mini)
                {
                    mini = B[i, j];
                    ind = j;
                    //Console.WriteLine(mini);
                }
            }
            for (int j = ind; j > 0; j--)
            {
                el = B[i, j];
                B[i, j] = B[i, j - 1];
                B[i, j - 1] = el;
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
        for (int i = 0; i < n; i++)
        {
            double maxi = Double.MinValue;
            int imax = -1;
            double first = 0;
            double last = 0;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxi)
                {
                    maxi = F[i, j];
                    imax = j; //максимальный
                    //Console.WriteLine(maxi);
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    if (first == 0)
                    {
                        first = F[i, j];
                    }
                    last = F[i, j];
                }
                //Console.WriteLine(first + " " + last);



            }
        if (first != 0)
        { 
            F[i, imax] = (first + last) / 2;
        }
        Console.WriteLine(F[i, imax]);
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
        
        int ind = 0;
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        for (int i = 0;i < 5; i++)
        {
            int maxi = int.MinValue;
            for (int j = 0;j < 6;j++)
            {
                if (G[i,j] > maxi)
                {
                    maxi = G[i,j];
                    ind = j;
                    //Console.WriteLine(maxi);
                }

            }
            
            for (int j = 6;  j > ind; j--)
            {
                
                G[i, j] = G[i, j - 1];
                //Console.WriteLine(i + "  " + j);
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
        int ind = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A.GetLength(1) != B.Length) return null;
        for (int j = 5; j < 6; j++)
        {
            int maxi = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (maxi < A[i,j])
                {
                    maxi = A[i,j];
                    ind = i;
                    //Console.WriteLine(maxi);
                }
            }
        }
        
        for (int j = 0; j < 7; j++)
        {
            A[ind, j] = B[j];
            //Console.WriteLine(A[ind, j]);
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
        int ind = 0;
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        for(int i = 1;i < 2; i++)
        {
            int mini = int.MaxValue;
            for(int j = 0;j < 7; j++)
            {
                if(mini > Math.Abs(F[i,j]))
                {
                    mini = F[i,j];
                    ind = j;
                    //Console.WriteLine(mini);
                }
            }
        }
        int[,]B = new int[5,6];
        for(int j = 0;j < 6; j++)
        {
            for(int i = 0; i < 5; i++)
            {
                if ( j <= ind)
                {
                    B[i,j] = F[i,j];
                }
                else
                {
                    B[i, j] = F[i,j + 1];
                }
            }
        }
        for(int i = 0;i<5;i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(B[i,j]);
            }
        }
        // end

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            double maxi = Double.MinValue;
            double middle = 0;
            int count = 0;
            int ind = 0;
            for (int j=0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    middle += A[i, j];
                    count ++;
                }
            }
            if (count != 0)
            {
                middle = middle / count;
            }
            for (int j = 0; j < 7; j++)
            {
                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                    ind = j;
                }
            }
            A[i, ind] = middle;
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
        for (int i = 0; i < 5; i++)
        {
            double maxi = double.MinValue;
            int ind = 0;
            for (int j = 0; j < 7; j++)
            {
                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                    ind = j; //максимальный
                    //Console.WriteLine(maxi);
                }
            }
            if (ind == 0)
            {
                if (A[i, ind + 1] < 0) A[i, ind + 1] /= 2;
                else A[i, ind + 1] *= 2;
            }
            else if (ind == 6)
            {
                if (A[i, ind - 1] < 0) A[i, ind - 1] /= 2;
                else A[i, ind - 1] *= 2;
            }
            else
            {
                if (A[i, ind - 1] < A[i, ind + 1])
                {
                    if (A[i, ind - 1] < 0) A[i, ind - 1] /= 2;
                    else A[i, ind - 1] *= 2;
                }
                else
                {
                    if (A[i, ind + 1] < 0) A[i, ind + 1] /= 2;
                    else A[i, ind + 1] *= 2;
                }
            }
        }
        /*for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(A[i,j] + " ");
            }
        }*/

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        
        for (int j = 0; j < 5; j ++)
        {
            int pos = 0;
            int neg = 0;
            int maxi = int.MinValue;
            int ind = 0;
            for (int i = 0;i < 7; i ++)
            {
                if (A[i, j] > 0) pos += 1;
                if (A[i, j] < 0) neg += 1;
                if (A[i,j] > maxi)
                { 
                    maxi = A[i,j];
                    ind = i;
                    Console.WriteLine(maxi);
                }
            }
            if (pos > neg) A[ind, j] = 0;
            else A[ind, j] = ind + 1;
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                //Console.Write(A[i, j] + " ");
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            
            int maxi = int.MinValue;
            int ind = 0;
            for(int i = 0; i < 10; i++)
            {
                if (A[i,j] > maxi)
                {
                    maxi=A[i,j];
                    ind = i;
                }
            }
            if (ind >=0 && ind<= 4)
            {
                int sum = 0;
                for (int i = ind + 1; i < 10; i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A.GetLength(1) != B.Length) return null;
        for (int j = 0;j < 5; j++)
        {
            int maxi = int.MinValue;
            int ind = 0;
            for (int i = 0;i < 7; i++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i,j];
                    ind = i;
                }
            }
            if (B[j] > maxi)
            {
                A[ind,j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            double maxi = int.MinValue;
            int ind = 0;
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    ind = i;
                }
            }
            sum = (A[0, j] + A[6, j]) / 2;
            if (maxi < sum)
            {
                A[ind, j] = sum;
            }
            else
            {
                A[ind, j] = ind + 1;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return null;
        answer = new int[n, 3 * n];
        for (int j = 0;j < answer.GetLength(1); j++)
        {
            answer[j % 3, j] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int maxi = int.MinValue;
        int ind = 0;
        for (int i = 0;i < 6; i++)
        {
            if(maxi < A[i,i])
            {
                maxi = A[i,i];  
                ind = i;
            }
        }
        for (int i = 0;i < ind;i++)
        {
            for(int j = i + 1; j < 6; j++)
            {
                A[i,j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for(int i = 0;i < 6; i += 2)
        {
            int maxi1 = int.MinValue;
            int ind1 = 0;
            int maxi2 = int.MinValue;
            int ind2 = 0;
            for (int j = 0; j< 6; j++)
            {
                if (maxi1 < B[i,j])
                {
                    maxi1= B[i,j];
                    ind1 = j;
                }
                if (maxi2 < B[i + 1, j])
                {
                    maxi2 = B[i + 1, j];
                    ind2 = j;
                }
            }
            int temp = B[i, ind1];
            B[i, ind1] = B[i + 1, ind2];
            B[i + 1, ind2] = temp;

        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0;i < 6; i++)
        {
            for(int j = 0;j < 7/2; j++)
            {
                int temp = A[i,j];
                A[i,j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = temp;
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
        for(int i = 0;i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == 0  || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                {
                    matrix[i, j] = 0;
                }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for(int i = matrix.GetLength(0)/2; i < matrix.GetLength(0);i++)
        {
            for(int j = 0;j < matrix.GetLength(1);j++)
            {
                if(i >= j)
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
        upper = new int[matrix.GetLength(0) * (matrix.GetLength(1) - 1) / 2 + matrix.GetLength(0)];
        lower = new int[matrix.GetLength(0) * (matrix.GetLength(1)- 1) / 2];
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int upcount = 0;
        int lowcount = 0;
        for (int i = 0; i < matrix.GetLength(0);i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i > j)
                {
                    lower[lowcount] = matrix[i, j];
                    lowcount++;
                }
                else
                {
                    upper[upcount] = matrix[i, j];
                    upcount++;
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] count = new int[matrix.GetLength(0)];
        for (int i = 0; i < 7; i++)
        { 
   
            for(int j = 0; j < 4 - i; j++)
            {
                int last = 0;
                int next = 0;
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[j, x] > 0)
                    {
                        last++;
                    }
                    if (matrix[j + 1, x] > 0)
                    {
                        next++;
                    }
                }
                if (last < next)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int x = 0; x < matrix.GetLength(1) - j - 1; x++)
                {
                    if (i % 2 == 0 && matrix[i, x] < matrix[i, x + 1])
                    {
                        int temp = matrix[i, x];
                        matrix[i, x] = matrix[i, x + 1];
                        matrix[i, x + 1] = temp;
                    }
                    if (i % 2 != 0 && matrix[i, x] > matrix[i, x + 1])
                    {
                        int temp = matrix[i, x];
                        matrix[i, x] = matrix[i, x + 1];
                        matrix[i, x + 1] = temp;
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] B = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0;i < matrix.GetLength(0); i++)
        {
            for (int j = 0;j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) break;
                B[k, j] = matrix[i, j];
            }
            k++;
            if (k >= matrix.GetLength(0) - count) break;
        }
        // end

        return B;
    }
    #endregion
}