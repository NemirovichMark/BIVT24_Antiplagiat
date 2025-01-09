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

    int change_elem(int el) {
        if (el > 0) { el *= 2; }
        else el /= 2;
        return el;
    }

    double change_elem(double el)
    {
        if (el > 0) { el *= 2; }
        else el /= 2;
        return el;
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7) {
            double sum = 0, count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] > 0) { sum += A[i, j]; count++; }
                }
            }
            answer = sum / count;
        }
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
        if (A.GetLength(1) <= colIndex) return (0, 0);
        if (A.GetLength(0) == 5 && A.GetLength(1) == 4 && colIndex >= 0 && colIndex <= 3)  {
            for (int i = 0; i < 5; i++) {
                if (A[i, colIndex] < 0) { value = A[i, colIndex]; rowIndex = i; break; }
            }
        }
        if (rowIndex == -1) return (0, 0);
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
        double pos_count;
        double pos_s;

        if (!(A.GetLength(0) == 4 && A.GetLength(1) == 6)) { return default(double[]); }

        answer = new double[4];
        for (int i = 0; i < 4; i++) {
            pos_count = 0;
            pos_s = 0;
            for (int j = 0; j < 6; j++) {
                if (A[i, j] > 0) { pos_count++; pos_s += A[i, j]; }
            }
            if (pos_count != 0) { answer[i] = pos_s / pos_count; }
            else { answer[i] = 0; }
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
        if (!(A.GetLength(0) == 5 && A.GetLength(1) == 7)) { return null; }

        int[,] answer = new int[4, 7];
        int min_row = -1;
        double mini = double.MaxValue;
        for (int i = 0; i < 5; i++) {
            if (A[i, 0] < mini) {
                mini = A[i, 0];
                min_row = i;
            }
        }
        if (min_row != -1) {
            for (int i = 0; i < 5; i++) {
                if (i == min_row) { continue; }
                if (i > min_row)
                {
                    for (int j = 0; j < 7; j++) { answer[i - 1, j] = A[i, j]; }
                }
                else { for (int j = 0; j < 7; j++) { answer[i, j] = A[i, j]; } }
            }
            return answer;
        }
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

        if (!(A.GetLength(0) == 4 && A.GetLength(1) == 3)) { return default(int[]); }

        answer = new int[3];
        int neg_count;
        for (int j = 0; j < 3; j++) {
            neg_count = 0;
            for (int i = 0; i < 4; i++) {
                if (A[i, j] < 0) { neg_count++; }
            }
            if (neg_count != 0) { answer[j] = neg_count; }
            else { answer[j] = 0; }
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
        double mini;
        int mini_index;
        int tmp;
        for (int i = 0; i < n; i++)
        {
            mini = double.MaxValue;
            mini_index = -1;
            for (int j = 0; j < m; j++) {
                if (B[i, j] < mini) { mini = B[i, j]; mini_index = j; }
            }
            for (int c = mini_index; c > 0; c--) {
                tmp = B[i, c - 1];
                B[i, c - 1] = B[i, c];
                B[i, c] = tmp;
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
        double maxi, first_neg, last_neg = 1;
        int maxi_ind;
        for (int i = 0; i < n; i++) {
            maxi = double.MinValue;
            maxi_ind = -1;
            first_neg = 1;
            for (int j = 0; j < m; j++) {
                if (F[i, j] > maxi) { maxi = F[i, j]; maxi_ind = j; }
                if (F[i, j] < 0 && first_neg == 1)
                {
                    first_neg = F[i, j];
                    last_neg = F[i, j];
                }
                else if (F[i, j] < 0) { last_neg = F[i, j]; }
            }
            if (first_neg != 1)
            {
                F[i, maxi_ind] = (first_neg + last_neg) / 2.0;
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
        if (!(G.GetLength(0) == 5 && G.GetLength(1) == 7)) { return null; }

        int maxi;
        int maxi_index;
        int tmp;
        for (int i = 0; i < 5; i++) {
            maxi = int.MinValue;
            maxi_index = -1;
            for (int j = 0; j < 6; j++) {
                if (G[i, j] > maxi) {
                    maxi = G[i, j];
                    maxi_index = j;
                }
            }
            for (int j = 6; j > maxi_index + 1; j--)
            {
                tmp = G[i, j - 1];
                G[i, j - 1] = G[i, j];
                G[i, j] = tmp;
            }
            G[i, maxi_index + 1] = maxi;
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
        if (!(A.GetLength(0) == 5 && A.GetLength(1) == 7)) { return null; }
        if (B.Length != 7) { return null; }

        int maxi = int.MinValue;
        int maxi_index = -1;
        for (int i = 0; i < 5; i++) {
            if (A[i, 5] > maxi) { maxi = A[i, 5]; maxi_index = i; }
        }
        for (int i = 0; i < 7; i++)
        {
            A[maxi_index, i] = B[i];
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
        if (!(F.GetLength(0) == 5 && F.GetLength(1) == 7)) { return null; }

        int mini = int.MaxValue;
        int mini_index = -1;
        for (int j = 0; j < 7; j++) {
            if (Math.Abs(F[1, j]) < Math.Abs(mini)) { mini = F[1, j]; mini_index = j; }
        }

        int[,] answer = new int[5, 6];
        for (int j = 0; j < 7; j++)
        {
            if (j == mini_index + 1) { continue; }
            if (j > mini_index)
            {
                for (int i = 0; i < 5; i++)
                {
                    answer[i, j - 1] = F[i, j];
                }
            }
            else if (j <= mini_index)
            {
                for (int i = 0; i < 5; i++)
                {
                    answer[i, j] = F[i, j];
                }
            }
        }

         F = answer;

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
        if (!(A.GetLength(0) == 5 && A.GetLength(1) == 7)) { return null; }

        double maxi;
        int maxi_index;
        double sum_pos_row;
        int count_pos_row;
        for (int i = 0; i < 5; i++) {
            maxi = double.MinValue;
            maxi_index = -1;
            sum_pos_row = 0;
            count_pos_row = 0;
            for (int j = 0; j < 7; j++) {
                if (A[i, j] > 0) { count_pos_row++; sum_pos_row += A[i, j]; }
                if (A[i, j] > maxi) { maxi = A[i, j]; maxi_index = j; }
            }
            if (count_pos_row > 0) { A[i, maxi_index] = sum_pos_row / count_pos_row; }
            else { A[i, maxi_index] = 0; }
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
        if (!(A.GetLength(0) == 5 && A.GetLength(1) == 7)) { return null; }

        double maxi;
        int maxi_index;
        for (int i = 0; i < 5; i++) {
            maxi = double.MinValue;
            maxi_index = -1;
            for (int j = 0; j < 7; j++) { 
                if (A[i, j] > maxi) { maxi = A[i, j]; maxi_index = j; }
            }
            if (maxi_index == 6) { A[i, 5] = change_elem(A[i, 5]); }
            else if (maxi_index == 0) { A[i, 1] = change_elem(A[i, 1]); }
            else {
                if (A[i, maxi_index + 1] > A[i, maxi_index - 1]) { A[i, maxi_index - 1] = change_elem(A[i, maxi_index - 1]); }
                else { A[i, maxi_index + 1] = change_elem(A[i, maxi_index + 1]); }
            }
        }
        // end

        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (!(A.GetLength(0) == 7 && A.GetLength(1) == 5)) { return null; }

        int count_pos, count_neg, maxi, maxi_index;
        for (int j = 0; j < 5; j++) {
            count_neg = 0;
            count_pos = 0;
            maxi = int.MinValue;
            maxi_index = -1;
            for (int i = 0; i < 7; i++) {
                if (A[i, j] > 0) { count_pos++; }
                else { count_neg++; }

                if (A[i, j] > maxi) { maxi = A[i, j]; maxi_index = i; }
            }
            if (count_pos > count_neg) { A[maxi_index, j] = 0; }
            else { A[maxi_index, j] = maxi_index + 1; }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (!(A.GetLength(0) == 10 && A.GetLength(1) == 5)) { return null; }

        int maxi;
        int maxi_index;
        int sum;
        for (int j = 0; j < 5; j++) { 
            maxi = int.MinValue;
            maxi_index = -1;
            for (int i = 0; i < 10; i++) {
                if (A[i, j] > maxi) { maxi = A[i, j]; maxi_index = i; }
            }
            if (maxi_index >= 4)
            {
                continue;
            }
            else {
                sum = 0;
                for (int c = maxi_index + 1; c < 10; c++)
                {
                    sum += A[c, j];
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
        if (!(A.GetLength(0) == 7 && A.GetLength(1) == 5)) { return null; }
        if (!(B.Length == 5)) { return null; }
        int maxi, index_maxi;
        for  (int j = 0; j < 5; j++) { 
            maxi = int.MinValue;
            index_maxi = -1;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > maxi) { maxi = A[i, j]; index_maxi = i; }
            }
            if (B[j] > A[index_maxi, j]) { A[index_maxi, j] = B[j]; }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (!(A.GetLength(0) == 7 && A.GetLength(1) == 5)) { return null; }
        double maxi, polusum;
        int index_maxi;
        for (int j = 0; j < 5; j++)
        {
            maxi = int.MinValue;
            index_maxi = -1;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > maxi) { maxi = A[i, j]; index_maxi = i; }
            }
            polusum = (A[0, j] + A[6, j]) / 2.0;
            if (A[index_maxi, j] < polusum)
            {
                A[index_maxi, j] = polusum;
            }
            else { A[index_maxi, j] = index_maxi + 1; }
        }   
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return null;
        }

        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++) { 
            for (int j = 0; j < 3 * n; j++) {
                if (j % n == i) { answer[i, j] = 1; }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (!(A.GetLength(0) == 6 && A.GetLength(1) == 6)) { return null; }
        int maxi = int.MinValue;
        int maxi_index = -1;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxi)
            {
                maxi = A[i, i];
                maxi_index = i;
            }
        }
        for (int i = 0; i < maxi_index; i++)
        {
            for (int j = 0; j < 6; j++)
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
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (!(B.GetLength(0) == 6 && B.GetLength(1) == 6)) { return null; }
        int tmp;
        int maxi_up, maxi_index_up_i, maxi_down, maxi_index_down_i, maxi_index_down_j, maxi_index_up_j;
        for (int i = 0; i < 6; i += 2) {
            maxi_up = int.MinValue; maxi_down = int.MinValue;
            maxi_index_down_i = -1; maxi_index_up_i = -1; maxi_index_up_j = -1; maxi_index_down_j = -1;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxi_up) { maxi_up = B[i, j]; maxi_index_up_i = i; maxi_index_up_j = j; }
                if (B[i + 1, j] > maxi_down) { maxi_down = B[i + 1, j]; maxi_index_down_i = i + 1; maxi_index_down_j = j; }
            }
            tmp = B[maxi_index_up_i, maxi_index_up_j];
            B[maxi_index_up_i, maxi_index_up_j] = B[maxi_index_down_i, maxi_index_down_j];
            B[maxi_index_down_i, maxi_index_down_j] = tmp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (!(A.GetLength(0) == 6 && A.GetLength(1) == 7)) { return null; }
        int tmp;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                tmp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = tmp;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) { return null; }
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            matrix[i, 0] = 0; matrix[0, i] = 0;
            matrix[size - 1 - i, size - 1] = 0; matrix[size - 1, size - 1 - i] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) { return null; }
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++) {
                if (i >= j) {
                    if (i >= (size / 2)) {
                        matrix[i, j] = 1;
                    }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) { return (null, null); }
        int size = matrix.GetLength(0);
        lower = new int[(size - 1) * (size) / 2];
        upper = new int[size * (size + 1) / 2];
        int a = 0, b = 0;
        for (int i = 0; i < size; i++) { 
            for (int j = 0; j < size; j++)
            {
                if (i > j) { lower[b++] = matrix[i, j]; }
                else { upper[a++] = matrix[i, j]; }
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
        if (!(matrix.GetLength(0) == 7 && matrix.GetLength(1) == 5)) { return null; }

        int[] counts_pos = new int[7];
        int[] indexes_rows = new int[7];

        int pos_per_row;
        for (int i = 0; i < 7; i++) {
            pos_per_row = 0;
            for (int j = 0; j < 5; j++) {
                if (matrix[i, j] > 0) { pos_per_row++; }
            }
            counts_pos[i] = pos_per_row;
            indexes_rows[i] = i;
        }

        int tmp;
        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6 - i; j++) {
                if ((counts_pos[j] < counts_pos[j + 1])) {
                    tmp = counts_pos[j];
                    counts_pos[j] = counts_pos[j + 1];
                    counts_pos[j + 1] = tmp;

                    tmp = indexes_rows[j];
                    indexes_rows[j] = indexes_rows[j + 1];
                    indexes_rows[j + 1] = tmp;
                }
            }
        }

        int[,] answer = new int[7, 5];
        for (int i = 0; i < 7; i++) {
            for (int j = 0; j < 5; j++) {
                answer[i, j] = matrix[indexes_rows[i], j];
            }
        }
        matrix = answer;
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }

    public int[] bubble_sort(int[] array, string mode) {
        int tmp;
        for (int i = 0; i < array.Length - 1; i++) {
            tmp = 0;
            for (int j = 0; j < array.Length - i - 1; j++) {
                if (mode == "V")
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j]; array[j] = array[j + 1]; array[j + 1] = tmp;
                    }
                }
                else {
                    if (array[j] < array[j + 1])
                    {
                        tmp = array[j]; array[j] = array[j + 1]; array[j + 1] = tmp;
                    }
                }
            }
        }
        return array;
    }

    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];

        int[] row = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                row[j] = matrix[i, j];
            }
            if (i % 2 == 0) {
                row = bubble_sort(row, "U");
            }
            else { 
                row = bubble_sort(row, "V"); 
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = row[j];
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int[,] answer = null;
        int[] rows_to_delete = new int[matrix.GetLength(1)];
        int answer_rows = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] == 0) { rows_to_delete[i] = 1; answer_rows++; break; }
            }
        }

        answer = new int[matrix.GetLength(0) - answer_rows, matrix.GetLength(1)];

        int skipped = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (rows_to_delete[i] == 1) { skipped++;  continue; }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[i - skipped, j] = matrix[i, j];
            }
        }
        matrix = answer;
        // end

        return matrix;
    }
    #endregion
}