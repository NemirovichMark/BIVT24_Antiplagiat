using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
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
        int counter = 0;
        for (int i1 = 0; i1 < A.GetLength(0); i1++)
        {
            for (int i = 0; i < A.GetLength(1); i++)
            {
                if (A[i1, i] > 0)
                {
                    answer += A[i1, i];
                    counter++;
                }
            }
        }
        if (counter == 0) return 0;
        answer /= counter;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if ((A[i, colIndex] < 0))
            {
                rowIndex = i;
                value = A[i, colIndex];
                break;
            }
        }
        if (rowIndex == -1) rowIndex++;
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
        double[] answer = new double[4];
        double arifm = 0;
        double counter = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    arifm += A[i, j];
                    counter++;
                }
            }
            if (counter > 0)
            {
                arifm = Math.Round(arifm / counter, 2);
                answer[i] = arifm;
            }
            else answer[i] = 0;
            counter = 0;
            arifm = 0;
        }
        foreach (double i in answer)
        {
            if (i == 0) counter++;
        }
        if (counter == 4) answer = null;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(int[,]);
        int[,] A1 = new int[4, 7];
        int min = A[0, 0], index = 0, i1 = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                index = i;
            }
        }
        for (int i = 0; i < A1.GetLength(0); i++)
        {
            if (i == index)
            {
                i1++;
                //continue;
            }
            for (int j = 0; j < A1.GetLength(1); j++)
            {
                A1[i, j] = A[i1, j];
            }
            i1++;
        }
        return A1;
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
        int[] answer = new int[3];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        int counter = 0, index = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0) counter++;
            }
            answer[index] = counter;
            counter = 0;
            index++;
        }
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
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int min = B[i, 0], index = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    index = j;
                }
            }
            for (int j = index; j > 0; j--)
            {
                B[i, j] = B[i, j - 1];
            }
            B[i, 0] = min;
        }
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
        if (F.GetLength(0) != n || F.GetLength(1) != m) return default(double[,]);
        for (int i = 0; i < F.GetLength(0); i++)
        {
            double max = F[i, 0];
            int index = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    index = j;
                }
            }
            double first = 0, last = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < first) { first = F[i, j]; break; }
            }
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < 0 && F[i, j] != first) { last = F[i, j]; }
            }
            if (first == 0 || last == 0) continue;
            else F[i, index] = (first + last) / 2;
        }
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
    public int[,] Task_1_23(int[,] F)
    {
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            int max = F[i, 0];
            int index = 0;
            for (int j = 0; j < F.GetLength(1) - 1; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    index = j;
                }
            }
            for (int j = F.GetLength(1) - 1; j > index; j--)
            {
                F[i, j] = F[i, j - 1];
            }
            F[i, index] = max;
        }
        return F;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7) return default(int[,]);
        int mx = A[0, 5], index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > mx)
            {
                mx = A[i, 5];
                index = i;
            }
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[index, i] = B[i];
        }
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7) return null;
        int min = Math.Abs(F[1, 0]), index = 0;
        for (int i = 0; i < F.GetLength(1) - 1; i++)
        {
            if (Math.Abs(F[1, i]) <= min)
            {
                min = F[1, i];
                index = i + 1;
            }
        }
        int[,] F1 = new int[5, 6];
        for (int i = 0; i < F1.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < F1.GetLength(1); j++)
            {
                if (j == index) temp++;
                F1[i, j] = F[i, temp];
                temp++;
            }
        }
        return F1;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double mx = A[i, 0], mid = 0;
            int index = 0, counter = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = j;
                }
                if (A[i, j] > 0)
                {
                    mid += A[i, j];
                    counter++;
                }
            }
            if (counter > 0)
            {
                mid = mid / counter;
                A[i, index] = mid;
            }
            else A[i, index] = 0;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default(double[,]);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double mx = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    index = j;
                }
            }
            if (index == 0 && A[i, index + 1] > 0) { A[i, index + 1] *= 2; }
            if (index == 0 && A[i, index + 1] < 0) { A[i, index + 1] /= 2; }
            if (index == A.GetLength(1) - 1 && A[i, index - 1] > 0) { A[i, index - 1] *= 2; }
            if (index == A.GetLength(1) - 1 && A[i, index - 1] < 0) { A[i, index - 1] /= 2; }
            if ((A[i, index + 1] > (A[i, index - 1]) && A[i, index - 1] > 0)) { A[i, index - 1] *= 2; continue; }
            if ((A[i, index + 1] > (A[i, index - 1]) && A[i, index - 1] < 0)) { A[i, index - 1] /= 2; continue; }
            if ((A[i, index + 1] < (A[i, index - 1]) && A[i, index + 1] > 0)) { A[i, index + 1] *= 2; continue; }
            if ((A[i, index + 1] < (A[i, index - 1]) && A[i, index + 1] < 0)) { A[i, index + 1] /= 2; continue; }
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int positive_num = 0, negative_num = 0, mx = -999999, index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx) { mx = A[i, j]; index = i; }
                if (A[i, j] > 0) positive_num++;
                else if (A[i, j] < 0) negative_num++;
            }
            if (positive_num > negative_num) A[index, j] = 0;
            else A[index, j] = index + 1;
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mx = A[0, j], index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx) { mx = A[i, j]; index = i; }
            }
            if (index < 5)
            {
                int sum = 0;
                for (int i = index + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
            else continue;


        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mx = A[0, j], index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx) { mx = A[i, j]; index = i; }
            }
            if (B[j] > mx) { A[index, j] = B[j]; }
            else continue;
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double mx = A[0, j];
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx) { mx = A[i, j]; index = i; }
            }
            double first = A[0, j], last = A[6, j];
            double sum = (first + last) / 2;
            if (mx < sum) { A[index, j] = sum; }
            else A[index, j] = index + 1;
        }
        return A;
    }

    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] A = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == i) { A[i, j] = 1; }
                else A[i, j] = 0;
            }
        }
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            int index = 0;
            for (int j = 0; j < 3 * n; j++)
            {
                if (j % n == 0) { index = 0; }
                answer[i, j] = A[i, index];
                index++;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int mx = A[0, 0];
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j == i && A[i, j] > mx) { mx = A[i, j]; index = i; }
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int counter = 0; counter <= 4; counter += 2)
        {
            int mx1 = 0, mx2 = 0;
            int index1 = 0, index2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[counter, j] > mx1) { mx1 = B[counter, j]; index1 = j; }
            }
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[counter + 1, j] > mx2) { mx2 = B[counter + 1, j]; index2 = j; }
            }
            B[counter, index1] = mx2;
            B[counter + 1, index2] = mx1;
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int temp = 0;
            int n = A.GetLength(1);
            for (int j = 0; j <= n / 2; j++)
            {
                temp = A[i, j];
                A[i, j] = A[i, n - j - 1];
                A[i, n - j - 1] = temp;
            }
        }
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            int ind = 0, min = 1000000000;
            for (int j = 1; j < m; j++)
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    ind = j;
                }
            a[i] = matrix[i, ind];
        }
        for (int x = 1; x < n; x++)
        {
            int i = x;
            while (i > 0 && a[i - 1] < a[i])
            {
                int p = a[i - 1];
                a[i - 1] = a[i];
                a[i] = p;
                for (int j = 0; j < m; j++)
                {
                    p = matrix[i - 1, j];
                    matrix[i - 1, j] = matrix[i, j];
                    matrix[i, j] = p;
                }
                i--;
            }
        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] answer = new int[2 * n - 1];
        if (n != m || 0 >= n) return null;        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
            }
        

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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k > n || k < 1) return null;
        int i_max = 0, j_max = 0, max_el = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > max_el)
                {
                    i_max = i; j_max = j;
                    max_el = Math.Abs(matrix[i, j]);                    
                }
        if (i_max == k && j_max == k) return matrix;
        for (int j = 0; j < n; j++)
        {
            int t = matrix[k - 1, j];
            matrix[k - 1, j] = matrix[i_max, j];
            matrix[i_max, j] = t;
        }
        for (int i = 0; i < n; i++)
        {
            int tmp = matrix[i, k - 1];
            matrix[i, k - 1] = matrix[i, j_max];
            matrix[i, j_max] = tmp;
        }                
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
        int m1 = A.Length, m2 = B.Length;
        if (m1 != m2 || m1 == 0) return null;
        int[] answer = new int[n * n];
        var A1 = new int[n, n]; var B1 = new int[n, n]; int[,] result = new int[n, n];        
        int temp = 0;
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                A1[i, j] = A[temp];
                A1[j, i] = A[temp];
                B1[i, j] = B[temp];
                B1[j, i] = B[temp];
                temp++;
            }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += A1[i, k] * B1[k, j];
                }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[count] = result[i, j];
                count++;
            }

        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return null;
        int[] array = new int[m];
        for (int j = 0; j < m; j++)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0) { counter++; }
            }
            array[j] = counter;
        }
        for (int position = 1; position < m; position++)
        {
            int j = position;
            while (j > 0 && array[j - 1] > array[j])
            {
                int temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;
                for (int i = 0; i < n; i++)
                {
                    temp = matrix[i, j - 1];
                    matrix[i, j - 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
                j--;
            }
        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1), counter = 0;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    counter++;
                    break;
                }
            }
        }
        int[,] A = new int[n - counter, m];
        for (int i = 0; i < n - counter; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) break; 
                else { A[i, j] = matrix[i, j]; }
            }
        }
        matrix = A;        
        return matrix;
    }
    #endregion
}