using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
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

        int n = A.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            answer += A[i,i];
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
        int[] answer = default(int[]);
        // code here
        int m = A.GetLength(0), l = A.GetLength(1);
        answer = new int[m];
        if (m != 4 || l != 7) answer = default;
        else
        {
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int min = 1000000;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        k = j;
                    }
                }
                answer[i] = k;
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

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 5 || l != 7) return A = default;
        else
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int max = -100000000, l1 = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = j;
                    }
                }
                int k = A[i, 0];
                A[i, 0] = max;
                A[i, l1] = k;
            }
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

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 6 || l != 7) return A = default;
        else
        {
            int[,] A1 = new int[5, 6];
            int max = -100000000, l1 = 0, m1 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = j;
                        m1 = i;
                    }
                }
            }
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < l1; j++) A1[i, j] = A[i, j];
            }
            for (int i = 0; i < m1; i++)
            {
                for (int j = l1+1; j < A.GetLength(1); j++) A1[i, j - 1] = A[i, j];
            }
            for (int i = m1+1; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < l1; j++) A1[i-1, j] = A[i, j];
            }
            for (int i = m1+1; i < A.GetLength(0); i++)
            {
                for (int j = l1+1; j < A.GetLength(1); j++) A1[i - 1, j - 1] = A[i, j];
            }
            A = A1;
        }
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

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 5 || l != 7) return A = default;
        else
        {
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int max = -1000000;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        k = j;
                    }
                }
                A[i, k] *= i+1;
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

        if (n != D.GetLength(0) || m != D.GetLength(1)) return D = default;
        else
        { 
            for (int i = 0; i < D.GetLength(0); i++)
            {
                int k = 0, max = -1000000, index = 100, t = 0;
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    if (D[i, j] < 0)
                    {
                        k = j;
                        break;
                    }
                }
                for (int j = 0; j < k; j++)
                {
                    if (D[i, j] > max) 
                    {
                        max = D[i, j];
                        index = j;
                    }
                }
                for (int j = D.GetLength(1)-1; j >= 0; j--)
                {
                    if (D[i, j] < 0)
                    {
                        t = j;
                        break;
                    }
                }
                if ((k != 0 || t != 0) && index != 100)
                {
                    int temp = D[i, index];
                    D[i, index] = D[i, t];
                    D[i, t] = temp;
                }
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

        int m = H.GetLength(0), l = H.GetLength(1);
        if (m != 5 || l != 7) return H = default;
        else
        {
            for (int i = 0; i < H.GetLength(0); i++)
            {
                int max = -10000000;
                for (int j = 0; j < H.GetLength(1) - 1; j++)
                {
                    if (H[i, j] > max)
                    {
                        max = H[i, j];
                    }
                }
                H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
                H[i, H.GetLength(1) - 2] = max;
            }
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

        int m = Y.GetLength(0), l = Y.GetLength(1);
        if (m != 6 || l != 5) return Y = default;
        else
        {
            for (int i = 0; i < Y.GetLength(0); i++)
            {
                double max = -10000000, sum = 0;
                int k = 0, count = 0;
                for (int j = 0; j < Y.GetLength(1); j++)
                {
                    if (Y[i, j] > max)
                    {
                        max = Y[i, j];
                        k = j;
                    }
                }
                for (int j = k+1; j < Y.GetLength(1); j++)
                {
                    if (Y[i, j] > 0)
                    {
                        sum += Y[i, j];
                        count ++;
                    }
                }
                sum /= count;
                if (count == 0)
                {
                    sum = 0;
                }
                for (int j = 0; j < k; j++)
                {
                    if (Y[i, j] < 0)
                    {
                        Y[i, j] = sum;
                    }
                }
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

        int[] array = new int[5];
        int m = B.GetLength(0), l = B.GetLength(1);
        if (m != 5 || l != 7) return B = default;
        else
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                int max = -1000000;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                }
                array[i] = max;
            }
            int k = 4;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 3] = array[k];
                k--;
            }
        }

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

        int m = B.GetLength(0), l = B.GetLength(1);
        if (m != 5 || l != 5) return B = default;
        else
        {
            int max = -100000, k = 0;
            for (int i = 0; i < m; i++)
            {
                if (B[i, i] > max) 
                {
                    max = B[i, i];
                    k = i;
                }
            }
            int p = 0;
            for (int i = 0; i < m; i++)
            {
                int count = 0;
                for (int j = 0; j < l; j++)
                {
                    if (B[i, j] < 0 && j == 2 && count == 0) p = i;
                    count++;
                }
            }
            for (int j = 0; j < B.GetLength(1); j++)
            {
                int term = B[k, j];
                B[k, j] = B[p, j];
                B[p, j] = term;
            }
            Console.WriteLine(p);
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
    {
        int[] answer = default(int[]);
        // code here

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 5 || l != 7) return default;
        else
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            answer = new int[count];
            int count1 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        answer[count1] = A[i, j];
                        count1++;
                    }
                }
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

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 5 || l != 7) A = default;
        else
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double max = -100000000;
                int l1 = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = j;
                    }
                }
                if (l1 == 0)
                {
                    if (A[i, l1 + 1] > 0) A[i, l1 + 1] *= 2;
                    else A[i, l1 + 1] /= 2;
                }
                else if (l1 == 6)
                {
                    if (A[i, l1 - 1] > 0) A[i, l1 - 1] *= 2;
                    else A[i, l1 - 1] /= 2;
                }
                else
                {
                    if (A[i, l1 + 1] < A[i, l1 - 1])
                    {
                        if (A[i, l1 + 1] > 0) A[i, l1 + 1] *= 2;
                        else A[i, l1 + 1] /= 2;
                    }
                    else
                    {
                        if (A[i, l1 - 1] > 0) A[i, l1 - 1] *= 2;
                        else A[i, l1 - 1] /= 2;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 7 || l != 5) A = default;
        else
        {
            for (int j = 0 ; j < A.GetLength(1); j++)
            {
                int countOTR = 0, countPOL = 0, max = -10000000, l1 = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > 0) countPOL++;
                    if (A[i, j] < 0) countOTR++;
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = i;
                    }
                }
                if (countPOL > countOTR) A[l1, j] = 0;
                else A[l1, j] = l1+1;
            }
        }

            // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 10 || l != 5) A = default;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int  max = -10000000, l1 = 0, sum = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = i;
                    }
                }
                for (int i = l1+1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                if (l1 < A.GetLength(0) / 2) A[0, j] = sum;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        int m = A.GetLength(0), l = A.GetLength(1), d = B.Length;
        if (m != 7 || l != 5 || d != 5) A = default;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int max = -10000000, l1 = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = i;
                    }
                }
                if (B[j] > max) A[l1, j] = B[j];
            }
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 7 || l != 5) A = default;
        else
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                double max = -10000000;
                int l1 = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        l1 = i;
                    }
                }
                double sum = (A[0, j] + A[6, j]) / 2;
                if (max < sum) A[l1, j] = sum;
                else A[l1, j] = l1+1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n < 0) answer = default;
        else
        {
            answer = new int[n, n];
            int[,] answer1 = new int[n, 3 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) answer[i, j] = 0;
            }
            for (int i = 0; i < n; i++) answer[i, i] = 1;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    answer1[i, k] = answer[i, j];
                    k++;
                }
                for (int j = 0; j < n; j++)
                {
                    answer1[i, k] = answer[i, j];
                    k++;
                }
                for (int j = 0; j < n; j++)
                {
                    answer1[i, k] = answer[i, j];
                    k++;
                }
            }
            answer = answer1;
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 6 || l != 6) A = default;
        else
        {
            int max = -10000000;
            int k = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, i] > max) { max = A[i, i]; k = i; };
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0;j < A.GetLength(1); j++)
                {
                    if (j > i && i < k) A[i, j] = 0;
                }
            }
        }

                // end

                return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here


        int[] A = new int[6];
        int m = B.GetLength(0), l = B.GetLength(1);
        if (m != 6 || l != 6) B = default;
        else
        {
            for (int i = 0; i < B.GetLength(0); i += 2)
            {
                int max1 = -100000000, max2 = -100000000, k = 0, p = 0;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max1) { max1 = B[i, j]; k = j; };
                    if (B[i+1, j] > max2) { max2 = B[i+1, j]; p = j; };
                }
                int term = B[i, k];
                B[i, k] = B[i + 1, p];
                B[i + 1, p] = term;
            }
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        int[] B = new int[7];
        int m = A.GetLength(0), l = A.GetLength(1);
        if (m != 6 || l != 7) A = default;
        else
        {
            for(int i = 0; i < 6; i++)
            {
                int count = 0;
                for (int j = 0;j < 7; j++)
                {
                    B[j] = A[i, j];
                }
                for (int j = 6; j >= 0; j--)
                {
                    A[i,count] = B[j];
                    count++;
                }
            }
        }

            // end

            return A;
    }
    #endregion

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

        int m = matrix.GetLength(0);
        if (m != matrix.GetLength(1)) matrix = default;
        else
        { 
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0 ;j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || i == (matrix.GetLength(0) - 1)) matrix[i, j] = 0;
                    if (j == 0 || j == (matrix.GetLength(0) - 1)) matrix[i, j] = 0;
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

        int m = matrix.GetLength(0);
        if (m != matrix.GetLength(1)) matrix = default;
        else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i > (matrix.GetLength(0) / 2)-1) && j <= i) matrix[i, j] = 1;
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
        int m = matrix.GetLength(0);
        if (m != matrix.GetLength(1)) matrix = default;
        else
        {
            int p1 = 0, k1 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j >= i) k1++;
                    else p1++;
                }
            }
            upper = new int[k1];
            lower = new int[p1];
            int k = 0, p = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j >= i) { upper[k] = matrix[i, j]; k++; }
                    else { lower[p] = matrix[i, j]; p++; }
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

        int m = matrix.GetLength(0), l = matrix.GetLength(1);
        if (m != 7 || l != 5) matrix = default;
        else
        {
            int[] array = new int[l];
            int[] arraycount = new int[m];
            for (int i = 0; i < m; i++)
            {
                int countPOL = 0;
                for (int j = 0; j < l; j++)
                {
                    if (matrix[i, j] > 0) countPOL++;
                }
                arraycount[i] = countPOL;
            }
            int count = 0;
            while (count != matrix.GetLength(0))
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        array[j] = matrix[i, j];
                    }
                    if (i != 0)
                    {
                        if (arraycount[i] > arraycount[i-1])
                        {
                            int t = arraycount[i];
                            arraycount[i] = arraycount[i-1];
                            arraycount[i-1] = t;
                            count = 0;
                            for ( int j = 0; j < l; j++)
                            {
                                matrix[i,j] = matrix[i-1,j];
                                matrix[i - 1, j] = array[j];
                            }
                        }
                        else count++;
                    }
                    count++;
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
            if(i%2 == 0)
            {
                int d = matrix.GetLength(1)/2 + 1;
                while( d != 0)
                {
                    for (int j = 0;j < matrix.GetLength(1); j++)
                    {
                        if (j + d < matrix.GetLength(1))
                        {
                            if (matrix[i, j] < matrix[i, j + d])
                            {
                                int t = matrix[i, j];
                                matrix[i, j] = matrix[i, j + d];
                                matrix[i, j + d] = t;
                            }
                        }
                        else break;
                    }
                    d--;
                }
            }
            else
            {
                int d = matrix.GetLength(1) / 2 +1;
                while (d != 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j + d < matrix.GetLength(1))
                        {
                            if (matrix[i, j] > matrix[i, j + d])
                            {
                                int t = matrix[i, j];
                                matrix[i, j] = matrix[i, j + d];
                                matrix[i, j + d] = t;
                            }
                        }
                        else break;
                    }
                    d--;
                }
            }
        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        int[] array = new int[matrix.GetLength(0)];
        int count1 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) count++;
            }
            if (count > 0) count1++;
            array[i]=count;
        }
        int[,] matrix1 = new int[count1+1, matrix.GetLength(1)];
        int count2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (array[i] == 0)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[count2, j] = matrix[i, j];
                }
                count2++;
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}