using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

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
        int n = A.GetLength(0), m = A.GetLength(1);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                answer += A[i, j];
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        double sum = 0;
        int k = 0;
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
        if (k == 0)
            return 0;
        answer = sum / k;
                    
                
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int n = A.GetLength(0);
        for (int i = 0; i < n; i++)
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
        double min = 1000;
        int n = A.GetLength(0), m = A.GetLength(1);
        for (int i = 0 ;i < n; i++)
            for(int j = 0; j < m; j++)
                if (A[i,j]<min)
                {
                    min = A[i,j];
                    row = i;
                    col = j;
                }


        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = 1;
        // code here
        int n = A.GetLength(0);
        int j = colIndex;
        for (int i = 0; i < n; i++)
        {
            if (A[i, j] < 0)
            {
                value = A[i, j];
                rowIndex = i;
                break;
            }
            else
            {
                value = 0;
                rowIndex = 0;
            }
        }
           

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int []answer = {0};
        // code here

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        //int[] answer = default(int[]);
        // code here
        
        int[] answer = new int[A.GetLength(1)];
        int max = -10000;
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 3 || m != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)    
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                    max = A[i, j];
            }
            answer[j] = max;
            max = -10000;
        }
            
            

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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        int max = -10000, maxi = 0;
        if (n != 5 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            if (A[i, 2] > max)
            {
                max = A[i, 2];
                maxi = i;
            }
        }
        int x = 0;
        for (int i = 0; i < n; i++)
            for(int j = 0; j < m; j++)

            {
                x = A[maxi, j];
                A[maxi, j] = A[3,j];
                A[3,j] = x;
            }
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

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        int max = -10000, maxi = 0;
        if (n != 5 || m != 5) return null;
        int sto = 0, str = 0;
        // code here
        while (true)
        {
            if (sto < A.GetLength(0))
            {
                if (A[str, sto] > max)
                {
                    max = A[str, sto];
                    maxi = sto;
                }
                sto++;
                str++;
            }
            else break;
        }

        int x = 0;
        for (int i = 0; i < A.GetLength(1); i++)

        {
            x = A[i, maxi];
            A[i, maxi] = A[i, 3];
            A[i, 3] = x;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        int[,] x = new int[n, m];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = -10101, maxi = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = j;
                }
            }
            bool flag = true;
            int k = 0;
            for (int j = 0; j < m; j++)
            {
                if (max != A[i, j])
                {
                    x[i, k] = A[i, j];
                    k++;
                }
                else if (maxi == A.GetLength(1) - 1)
                {
                    x[i, k] = A[i, j];
                    k++;
                }
                else if (flag == true)
                {
                    x[i, k] = A[i, j];
                    flag = false;
                    //schet++;
                    x[i, A.GetLength(1) - 1] = max;
                }
            }

        }


        // end

        return x;
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

        for (int i = 0; i < C.GetLength(0); i++)
        {
            double max = -1000;
            int maxi = 0;
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    maxi = j;
                }

            }
            for(int j = 0; j < maxi; j++)
            {
                if (C[i, j] < 0) C[i, j] /= max;
            }
        }
        //end
        
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
        int m = Z.GetLength(0), n = Z.GetLength(1);
        if (m != 6 || n != 8) return null;
        double max = -100000, s = 0; int maxi = 0, maxj = 0, k = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
            for (int j = 0; j < Z.GetLength(1); j++)
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }

        s /= k;
        s = Math.Round(s, 2);
        for (int i = 0; i < Z.GetLength(0); i++)
            for(int j = 0; j < Z.GetLength(1); j++)
            {
                
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    maxi = i;
                    maxj = j;
                }
            }
        
        Console.WriteLine(s);
        Z[maxi, maxj] = s;



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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        int min = 10000, max = -10000, mini = 0, maxi = 0;
        int m = X.GetLength(0), n = X.GetLength(1);
        if (m != 6 || n != 5) return null;

        for (int i = 0; i < X.GetLength(0); i++)
        {
            int k = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k < min)
            {
                mini = i;
                min = k;
            }
            if (k > max)
            {
                maxi = i;
                max = k;
            }

        }
        int temp = 0;
        for (int j = 0; j < X.GetLength(1); j++)
        {
            temp = X[max, j];
            X[max, j] = X[mini, j];
            X[mini, j] = temp;
        }
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        int index = 0; int max = -999999;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int s = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                }
            }
            if (s > max)
            {
                max = s;
                index = i;
            }
        }
        // end
        int k = 0;
        int[,] output = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < output.GetLength(1); j++)
            {
                output[k, j] = A[i, j];
            }
            if (i == 2)
            {
                i++;
            }
            k++;
        }
        return output;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 8 || B.Length != 5) return null;
        int min = 8998; int mini = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                mini = i;
            }
        }
        if (mini != A.GetLength(1) - 1)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, mini + 1] = B[i];
            }
        }
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

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return null;

        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = -8998; int maxi = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = j;
                }
            }
            if (maxi == 0)
            {
                if (A[i, 1] > 0)
                    A[i, 1] *= 2;
                else
                    A[i, 1] /= 2;
            }
            else if (maxi == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0)
                    A[i, A.GetLength(1) - 2] *= 2;
                else
                    A[i, A.GetLength(1) - 2] /= 2;
            }
            else if (A[i, maxi - 1] > A[i, maxi + 1])
            {
                if (A[i, maxi + 1] > 0)
                    A[i, maxi + 1] *= 2;
                else
                    A[i, maxi + 1] /= 2;
            }
            else
            {
                if (A[i, maxi - 1] > 0)
                    A[i, maxi - 1] *= 2;
                else
                    A[i, maxi - 1] /= 2;
            }

        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        // code here
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxi = 0, k1 = 0, k2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                {
                    k1++;
                }
                else if (A[i, j] < 0)
                {
                    k2++;
                }
                if (A[maxi, j] < A[i, j]) maxi = i;
            }
            if (k1 >= k2)
            {
                A[maxi, j] = 0;
            }
            else
            {
                A[maxi, j] = maxi+1;
            }
        }
        
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -1000, maxi = 0, s = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            for (int i = maxi + 1; i < A.GetLength(0); i++)
            {
                s += A[i, j];
            }
            if (maxi <= 4)
            {
                A[0, j] = s;
            }
            else continue;
        }
        // end

        return A;
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;
        for(int j = 0; j < A.GetLength(1); j++)
        {
            int max = -10000, maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            
            }
            if (max < B[j])
                A[maxi, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double x = A[0,j] + A[n-1,j], max = -100000;
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (A[maxi,j] < x)
                A[maxi, j] = x;
            else
                A[maxi, j] = maxi+1;
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here
        int x = 2;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            int k = x;
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (k == 2)
                {
                    answer[i, j] = 1;
                    k = 0;
                }
                else
                {
                    answer[i, j] = 0;
                    k++;
                }
            }
            x--;
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return null;
        int x = 0;
        int max = -101010, maxi1 = 0, maxi2 = 0;
        // code here
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                maxi1 = i;
                maxi2 = i;
            }

        }
        for (int i = 0; i < maxi2; i++)
        {
            x++;
            for (int j = x; j < A.GetLength(1); j++)
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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) return null;
        for (int i = 0; i < B.GetLength(0); i = i+2)
        {
            int t = 0; int max1 = -1010101; int max2 = -101010; int maxi1 = 0; int maxi2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    maxi1 = j;
                }
            }
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    maxi2 = j;
                }
            }
            t = B[i, maxi1];
            B[i, maxi1] = B[i + 1, maxi2];
            B[i + 1, maxi2] = t;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 7) return null;

        int[,] output = new int[m, n];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int k = 0;
            for (int j = n - 1; j >= 0; j--)
            {
                output[i, k] = A[i, j];
                k++;
            }
        }
        // end

        return output;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m && n <= 2) return null;
        int k = 0; bool f = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 && k != matrix.GetLength(1) - 1 && f == false)
            {
                matrix[i, k] = 0;
                matrix[matrix.GetLength(0) - 1, k] = 0;
                k++;
                i--;
            }
            else
            {
                f = true;
                k = 0;
            }
            if (i != -1 && i != matrix.GetLength(1) - 1)
            {
                matrix[i, 0] = 0;
                matrix[i, matrix.GetLength(1) - 1] = 0;
            }
        }
        matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] = 0;
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
        if (matrix.GetLength(1) != matrix.GetLength(0)) return null;
        int chet = 0;
        // code here
        if ((matrix.GetLength(0) / 2) % 2 == 0)
        {
            chet = matrix.GetLength(0) / 2;
        }
        else
        {
            chet = matrix.GetLength(0) / 2;
        }
        for (int i = chet; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= chet; j++)
            {
                matrix[i, j] = 1;
            }
            chet++;
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
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (m != n) return (null, null);
        int up_k = 0, low_k = 0;
        int diag = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= diag)
                {
                    up_k++;
                }
                else
                {
                    low_k++;
                }
            }
            diag++;
        }
        diag = 0;
        int[] upper = new int[up_k];
        int[] lower = new int[low_k];
        up_k = 0; low_k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= diag)
                {
                    upper[up_k] = matrix[i, j];
                    up_k++;
                }
                else
                {
                    lower[low_k] = matrix[i, j];
                    low_k++;
                }
            }
            diag++;
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
        if (n != 7 || m != 5) return null;
        int[,] output = new int[n, m];
        int[,] array_temp = new int[matrix.GetLength(0), 2];
        int k_temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            k_temp = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] >= 0)
                {
                    k_temp++;
                }
            }
            array_temp[i, 0] = k_temp;
            array_temp[i, 1] = i;
        }
        int max = 0, max1 = 0, max2 = 0;
        bool index = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            index = false;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (array_temp[j, 0] > max)
                {
                    index = true;
                    max = array_temp[j, 0];
                    max1 = array_temp[j, 1];
                    max2 = j;
                }
            }
            array_temp[max2, 0] = 0;
            //Console.WriteLine(maxim);
            //Console.WriteLine(maxim_y);
            if (index == false)
            {
                break;
            }
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                output[i, g] = matrix[max1, g];
            }
            max = 0;
            max2 = 0;
            max1 = 0;
        }
        return output;
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
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (j % 2 == 0)
            {
                bool sw;
                do
                {
                    sw = false;
                    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                        if (matrix[j, i] < matrix[j, i + 1])
                        {
                            int temp = matrix[j, i];
                            matrix[j, i] = matrix[j, i + 1];
                            matrix[j, i + 1] = temp;
                            sw = true;
                        }
                } 
                while (sw);
            }
            else
            {
                bool sw;
                do
                {
                    sw = false;
                    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                        if (matrix[j, i] > matrix[j, i + 1])
                        {
                            int temp = matrix[j, i];
                            matrix[j, i] = matrix[j, i + 1];
                            matrix[j, i + 1] = temp;
                            sw = true;
                        }
                } 
                while (sw);
            }
        }
        //end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {

        int k = 0;
        // code here
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool f = false;
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (matrix[i, g] == 0)
                {
                    f = true;
                }
            }
            if (f == true)
            {
                k++;
            }
        }
        int[,] output = new int[matrix.GetLength(0) - k, matrix.GetLength(1)];
        int k_output = 0;
        // end
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool f = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    f = true;
                }
            }
            if (f == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output[k_output, j] = matrix[i, j];

                }
                k_output++;
            }
        }

        return output;
    }
    #endregion
}