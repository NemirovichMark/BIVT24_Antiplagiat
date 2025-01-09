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
        int[,] matrix = {
                { 1, 2, 3, 4, -5 },
                { 5, 11, -17, 11, -10 },
                { -9, -10, -11, -14, -15 }
            };
        program.Task_1_7(matrix);

        // int[] to_sort = new int[]{1, -1, 0, 1789, -123, 5, 6, 8, 2,5, 98, 1, 0, 0};
        // to_sort = InsertSort(to_sort);
        // for (int i = 0; i < to_sort.Length; i++){
        //     Console.Write(to_sort[i]);
        //     Console.Write(' ');
        // }

    }
    public static void PrintMatrix_Int(int[,] m){
        for(int i = 0; i < m.GetLength(0); i++){
            for (int j = 0; j < m.GetLength(1); j++){
                Console.Write(m[i, j]);
                Console.Write(' ');
            }
            Console.Write("\n");
        }
    }

    public static int[] InsertSort(int[] array){
        for (int i = 0; i < array.Length; i++){
            int key = array[i];
            int j = i -1;

            while (j >= 0 && array[j] > key){
                array[j+1] = array[j];
                j--;
            }

            array[j+1] = key;
        }
        return array;
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                answer += A[i,j];
            }
        }
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

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                if (A[i, j] < A[row, col]){
                    row = i;
                    col = j;
                }
            }
        }
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

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5){
            return null;
        }
        int k = 0;
        int[] temp = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++){
            int max = A[0, j];
            for(int i = 0; i < A.GetLength(0); i++){
                if (A[i, j] > max){
                    max = A[i, j];
                }
            }
            temp[k++] = max;
        }
        answer = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7){
            return null;
        }
        int ind_switch = 0;
        for (int i = 0; i < A.GetLength(0); i++){
            if (A[i, 2] > A[ind_switch, 2]){
                ind_switch = i;
            }
        }
        int temp;
        for (int i = 0; i < A.GetLength(1); i++){
            temp = A[ind_switch, i];
            A[ind_switch, i] = A[3, i];
            A[3, i] = temp;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5){
            return null;
        }
        int ind_switch = 0;
        for (int i = 0; i < A.GetLength(0); i++){
            if (A[i, i] > A[ind_switch, ind_switch]){
                ind_switch = i;
            }
        }
        int temp;
        for (int j = 0; j < A.GetLength(0); j++){
            temp = A[j, 3];
            A[j, 3] = A[j, ind_switch];
            A[j, ind_switch] = temp;
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
        for (int i = 0; i < A.GetLength(0); i++){
            int ind_max = 0;
            for (int j = 0; j < A.GetLength(1); j++){
                if (A[i, j]  > A[i, ind_max]){
                    ind_max = j;
                }
            }
            int temp = A[i, ind_max];
            for (int j = ind_max; j < A.GetLength(1)-1; j++){
                A[i, j] = A[i, j+1];
            }
            A[i, m-1] = temp;
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
        for (int i = 0; i < C.GetLength(0); i++){
            int ind_max = 0;
            for (int j = 0; j < C.GetLength(1); j++){
                if (C[i, j]  > C[i, ind_max]){
                    ind_max = j;
                }
            }
            for (int j = 0; j < ind_max; j++){
                if (C[i, j] < 0){
                    C[i, j] /= C[i, ind_max];
                }
            }
        }
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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8){
            return null;
        }
        int i_max = 0, j_max = 0;
        for (int i = 0; i < Z.GetLength(0); i++){
            for (int j = 0; j < Z.GetLength(1); j++){
                if (Z[i, j] > Z[i_max, j_max]){
                    i_max = i;
                    j_max = j;
                }
            }
        }

        int n = 0;
        double arifm = 0;
        for (int i = 0; i < Z.GetLength(0); i++){
            for (int j = 0; j < Z.GetLength(1); j++){
                if (Z[i, j] > 0){
                    arifm += Z[i, j];
                    n++;
                }
            }
        }
        Z[i_max, j_max] = arifm/n;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5){
            return null;
        }
        int row_max_neg = 0, max_neg = 0, row_min_neg = 0, min_neg = X.GetLength(1);
        for (int i = 0; i < X.GetLength(0); i++){
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++){
                if (X[i, j] < 0) count++;
            }
            if (count > max_neg){
                max_neg = count;
                row_max_neg = i;
            }
            if (count < min_neg){
                min_neg = count;
                row_min_neg = i;
            }
        }
        int temp;
        for (int j = 0; j < X.GetLength(1); j++){
            temp = X[row_max_neg, j];
            X[row_max_neg, j] = X[row_min_neg, j];
            X[row_min_neg, j] = temp;
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
        // code here
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }
        
        int ind_row = -1, max_sum = 0;  

        for (int i = 0; i < A.GetLength(0); i++){
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++){
                if (A[i, j] > 0){
                sum += A[i, j];
                }
            }
            if (sum > max_sum){
                max_sum = sum;
                ind_row = i;
            }
        }
        int [,] Temp = new int[A.GetLength(0)-1, A.GetLength(1)];
        for (int i = 0, k = 0; i < A.GetLength(0); i++){
            if (i == ind_row){
                continue;
            }
            for (int j = 0; j < A.GetLength(1); j++){
                Temp[k, j] = A[i, j];
            }
            k++;
        }
        A = Temp;
        
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5){
            return null;
        }


        int j_of_min = 0;
        for (int j = 0; j < A.GetLength(1); j++){
            if (A[4, j] < A[4, j_of_min]){
                j_of_min = j;
            }
        }

        for (int j = A.GetLength(1)-2; j >= j_of_min; j--){
            for (int i = 0; i < A.GetLength(0); i++){
                A[i, j+1] = A[i, j];
            }
        } 

        for (int i = 0; i < A.GetLength(0); i++){
            A[i, j_of_min+1] = B[i];
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
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7){
            return null;
        }   
        int j_max = 0;
        for (int i = 0; i < A.GetLength(0); i++){
            j_max = 0;
            for (int j = 0; j < A.GetLength(1); j++){
                if (A[i, j] > A[i, j_max]){
                    j_max = j;
                }
            }
            if (j_max == 0){
                A[i, 1] *= A[i, 1]>0 ? 2: 0.5;
            }
            else if (j_max == A.GetLength(1)-1){
                A[i, A.GetLength(1)-2] *= A[i, A.GetLength(1)-2]>0 ? 2: 0.5;
            }
            else{
                if (A[i, j_max+1] >  A[i, j_max-1]){
                    A[i, j_max-1] *= A[i, j_max-1]>0 ? 2: 0.5;
                }
                else{
                    A[i, j_max+1] *= A[i, j_max+1]>0 ? 2: 0.5;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }   
        int i_max;

        for (int j = 0; j < A.GetLength(1); j++){
            
            int n = 0;
            i_max = 0;

            for (int i = 0; i < A.GetLength(0); i++){
                if (A[i,j] > 0) n++;
                else n--;
                if (A[i, j] > A[i_max, j]){
                    i_max = i;
                }
            }
              
            if (n > 0){
                A[i_max, j] = 0;
            }
            else{
                A[i_max, j] = i_max+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5){
            return null;
        }   
        int i_max;
        int sum = 0;
        for (int j = 0; j < A.GetLength(1); j++){
            
            i_max = 0;
            sum = 0;

            for (int i = 0; i < A.GetLength(0); i++){
                if (A[i, j] > A[i_max, j]){
                    i_max = i;
                }
            }
            for (int i = i_max+1; i < A.GetLength(0); i++){
                sum += A[i, j];
            }

            if (i_max <= 5){
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5){
            return null;
        }   
        int i_max;
        int k = 0;
        for (int j = 0; j < A.GetLength(1); j++){
            
            i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++){
                if (A[i, j] > A[i_max, j]){
                    i_max = i;
                }
            }

            A[i_max, j] = A[i_max, j] > B[k] ? A[i_max, j] : B[k];
            k++;
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }   

        int i_max;
        double hsum;
        for (int j = 0; j < A.GetLength(1); j++){
            hsum = 0;
            i_max = 0;
            for (int i = 0; i < A.GetLength(0); i++){
                if (A[i, j] > A[i_max, j]){
                    i_max = i;
                }
            }

            hsum = (A[0, j] + A[0, 4])/2;

            if (A[i_max, j] < hsum){
                A[i_max, j] = hsum;
            }
            else{
                A[i_max, j] = i_max+1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0){
            return null;
        }
        int[,] temp = new int[n, 3*n];
        for (int j = 0; j < 3*n; j++){
            temp[j%n, j] = 1;
        }
        answer = temp;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6){
            return null;
        }   
        int k_max = 0;
        
        for (int k = 0; k < A.GetLength(0); k++){
            if (A[k, k] > A[k_max, k_max]){
                k_max = k;
            }
        }

        for (int i = 0; i < k_max; i++){
            for (int j = 0; j < A.GetLength(1); j++){
                if (j > i){
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6){
            return null;
        }   

        int temp;
        for (int irn = 0; irn<6; irn+=2){
            int jm1 = 0, jm2 = 0;

            for (int j = 0; j < B.GetLength(1); j++){
                if (B[irn, j] > B[irn, jm1]) jm1 = j;
            }
            for (int j = 0; j < B.GetLength(1); j++){
                if (B[irn+1, j] > B[irn+1, jm2]) jm2 = j;
            }

            temp = B[irn, jm1];
            B[irn, jm1] = B[irn+1, jm2];
            B[irn+1, jm2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7){
            return null;
        }   
        int temp;
        
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0, k = A.GetLength(1)-1; j < A.GetLength(1)/2; j++, k--){
                temp = A[i, j];
                A[i, j] = A[i, k];
                A[i, k] = temp;
            }
        }
        PrintMatrix_Int(A);
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
        for (int i = 0; i < matrix.GetLength(0); i++){
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, matrix.GetLength(0)-1] = 0;
            matrix[matrix.GetLength(0)-1, i] = 0;
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
        for (int i = matrix.GetLength(0)/2; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                if (i >= j){
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        
        int n = matrix.GetLength(0);
        int k = 0, m = 0;
        upper = new int[n*(n+1)/2];
        lower = new int[n*(n-1)/2];

        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                if (i <= j){
                    upper[k++] = matrix[i, j];
                }
                else{
                    lower[m++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5){
            return null;
        }
        //count the amount of positives in each row
        int[] positivs = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) count++;
            }
            positivs[i] = count;
        }


        //actually sort
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int key_positiv = positivs[i]; //key as number of positives
            int[] key_row = new int[matrix.GetLength(1)]; //key as the actual row
            int j = i - 1;

            //copy the row to key_row
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                key_row[k] = matrix[i, k];
            }

           
            while (j >= 0 && positivs[j] < key_positiv)
            {
                positivs[j + 1] = positivs[j];
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j + 1, k] = matrix[j, k];
                }
                j--;
            }

            //put the key in place
            positivs[j + 1] = key_positiv;

            //put the row in place
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[j + 1, k] = key_row[k];
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
        if (matrix == null) return null;

        int[] temp;
        
        temp = new int[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++){
            int k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++){
                temp[k++] = matrix[i, j];
            }

            temp = InsertSort(temp);

            if (i%2 == 0){
                int t;
                for (int a = 0, b = temp.Length-1; a < b; a++, b--){
                    t = temp[a];
                    temp[a] = temp[b];
                    temp[b] = t;
                }
            }
            k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++){
                matrix[i, j] = temp[k++];
            }
        }
        // end

        return matrix;
    }
    static int[,] DeleteRow(int[,] matrix, int row){
            int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)];

            for (int i = 0, k = 0; i < row; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }

            for (int i = row + 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i-1, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        for (int i = matrix.GetLength(0)-1; i>=0; i--){
            bool flag = false;
            for (int j = 0; j < matrix.GetLength(1); j++){
                if (matrix[i, j] == 0){
                    flag = true;
                    break;
                }
            }

            if(flag){
                matrix = DeleteRow(matrix, i);
            }
        }
        // end

        return matrix;
    }
    #endregion
}