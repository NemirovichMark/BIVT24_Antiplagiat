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
        program.Task_1_13(new int[,] {
                { 1, 2, 3, 4, -5 },
                { 5, 11, -17, 11, 7 },
                { -9, -10, -11, -14, -15 },
                { -9, -10, -11, -14, -6 },
                { 0, -2, -3, -4, -5 }});
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7){
            return 0;
        }
        for(int i = 0;i < 5;i++){
            for(int j = 0;j < 7;j++){
                answer += A[i,j];
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
        double mn = double.MaxValue;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6){
            return (0,0);
        }
        for(int i = 0;i < 3 ;i++){
            for(int j = 0;j < 6 ;j++){
                if (A[i,j] < mn){
                    mn = A[i,j];
                    row = i;
                    col = j;
                }
            }
        }
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
        int[] answer = new int[5];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5){
            return null;
        }
        int k = 0;
        for(int i = 0;i < 5;i++){
           int mx = int.MinValue;
            for(int j = 0;j < 3;j++){
                if (A[j,i] > mx){
                    mx = A[j,i];
                }
                if (j == 2){
                    answer[k++] = mx;
                }
            }
        }
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
    public int[,] Task_1_10(int[,] A) // Скорее всего неправильный тест
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7){
            return null;
        }
        int mx = int.MinValue, row = 0,temp;
        for (int i = 0;i < 5;i++){
            if (mx < A[i,3]){
                mx = A[i,3];
                row = i;
            }
        }
        for(int i = 0; i < 7;i++){
            temp = A[3,i];
            A[3,i] = A[row,i];
            A[row,i] = temp;
        }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5){
            return null;
        }
        int mx = int.MinValue, col = 0, temp;
        for (int i = 0;i < 5;i++){
            if (mx < A[i,i]){
                mx = A[i,i];
                col = i;
            }
        }
        for(int i = 0; i < 5;i++){
            temp = A[i,3];
            A[i,3] = A[i,col];
            A[i,col] = temp;
        }
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
        int[,] mx = new int[n,2];
        for(int i = 0;i < n;i++){
            int mx0 = int.MinValue;
            for(int j = 0;j < m ;j++){
                if (A[i,j] >  mx0){
                    mx0 = A[i,j];
                    mx[i,0] = mx0;
                    mx[i,1] = j;
                }
            }
        }
        for(int i = 0;i < n;i++){
            for(int j = mx[i,1];j < m;j++){
                if (j == m - 1){
                    A[i,j] = mx[i,0];
                }
                else{
                    A[i,j] = A[i,j+1];
                }
            }
        }
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
        double[,] mx = new double[n,2];
        int indi = 0, indj = 0;
        if (C.GetLength(0) != n || C.GetLength(1) != m){
            return null;
        }
        for(int i = 0;i < C.GetLength(0);i++){
            double mx0 = Double.MinValue;
            for(int j = 0;j < C.GetLength(1) ;j++){
                if (C[i,j] >  mx0){
                    mx0 = C[i,j];
                    mx[i,0] = mx0;
                    mx[i,1] = j;
                }
            }
        }
        for(int i = 0;i < C.GetLength(0);i++){
            for(int j = 0;j < C.GetLength(1) ;j++){
                if (C[i,j]  < 0 && mx[i,1] > j){
                    C[i,j] /= mx[i,0];
                }
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8){
            return null;
        }
        double s = 0, mx = double.MinValue;
        int cnt = 0, row = 0, col = 0;
        for(int i = 0;i < 6;i++){
            for(int j = 0;j < 8;j++){
                if (Z[i,j] > 0){
                    s += Z[i,j];
                    cnt++;
                }
                if (mx < Z[i,j]){
                    mx = Z[i,j];
                    row = i;
                    col = j;
                }
            }
        }
        Z[row,col] = s/cnt;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5){
            return null;
        }
        int mx = int.MinValue , mn = int.MaxValue, temp,mx_ind = 0, mn_ind = 0;
        for (int i = 0;i < 6;i++){
            int cnt = 0;
            for (int j = 0;j < 5;j++){
            if (0 > X[i,j]){
                cnt++;
            }
            }
            if (cnt > mx){
                mx = cnt;
                mx_ind = i;
            }
            else if (cnt < mn){
                mn = cnt;
                mn_ind = i;
            }
        }
        for(int i = 0; i < 5;i++){
            temp = X[mn_ind,i];
            X[mn_ind,i] = X[mx_ind,i];
            X[mx_ind,i] = temp;
        }
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }
        int mx = int.MinValue ,mx_ind = 0;
        for (int i = 0;i < 7;i++){
            int s = 0;
            for (int j = 0;j < 5;j++){
            if (0 < A[i,j]){
                s += A[i,j];
            }
            }
            if (s > mx){
                mx = s;
                mx_ind = i;
            }
        }
        int [,] buf = new int[6,5];
        int fl = 0;
        for (int i = 0;i < 7;i++){
            if (i == mx_ind){fl = 1;}
            for (int j = 0;j < 5 && i != mx_ind;j++){
                buf[i-fl,j] = A[i,j];
            }
        }
        A = buf;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5){
            return null;
        }
        int col = 0, mn = int.MaxValue; 
        for(int j = 0; j < 8;j++){
            if(A[4,j] < mn) {
                col = j; 
                mn = A[4,j];
            }
        }
        if(col < 7){
        for(int i = 0; i < 5; i++){
            A[i,col + 1] = B[i];
        }
        }
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
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7){
            return null;
        }
        int[] mx_ind = new int[5];
        double[] mx0 = new double[5];
        double mx; int col = -1;
        for(int i = 0; i < 5;i++) {
            mx = Double.MinValue;
            for(int j = 0; j < 7;j++){
                if(mx < A[i,j]) {
                    mx = A[i,j];
                    col = j;
                }
            }
            mx0[i] = mx; 
            mx_ind[i] = col;
            double k = 0;
            if (col == 0 || A[i,col+1] < A[i,col-1]){
                k = A[i,col+1] > 0 ? 2: 0.5;
                A[i,col+1] *= k;
            }
            else{
                k = A[i,col-1] > 0 ? 2: 0.5;
                A[i,col-1] *= k;
            }
        }   
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }
        for(int j = 0; j < 5;j++){
            int mx = int.MinValue, mx_ind = 0, neg = 0, pos = 0;
            for(int i = 0; i < 7;i++){
                if (A[i,j] > 0){
                    pos++;
                }
                else{
                    neg++;
                }
                if (mx < A[i,j]){
                    mx = A[i,j]; 
                    mx_ind = i;
                }
            } 
            if(pos > neg){
                A[mx_ind,j] = 0;
            }
            else{
            A[mx_ind,j] = mx_ind;
            }
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if(A.GetLength(0) != 10 || A.GetLength(1) != 5){
            return null;
        } 
        for(int j = 0; j < 5;j++){
            int mx = int.MinValue, mx_ind = -1;
            for(int i = 0; i < 10;i++){
                if (mx < A[i,j]) {
                    mx=A[i,j]; 
                    mx_ind = i;
                    }
            }
            if (mx_ind < 5){
                int s = 0;
                for(int i = mx_ind + 1; i < 10;i++){
                    s += A[i,j];
                }
                A[0,j] = s;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5){
            return null;
        } 
        for(int j = 0; j < 5;j++){
           int mx = int.MinValue, mx_ind = 0;
            for(int i = 0; i < 7;i++){
                if (mx < A[i,j]) {
                    mx=A[i,j]; 
                    mx_ind = i;
                }
            }         
            if(B[j] > mx){
                A[mx_ind, j] = B[j];
            }   
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5){
            return null;
        }
        double s;
        for(int j = 0; j < 5;j++){
            double mx = double.MinValue; 
            int mx_ind = 0;
            s = (A[0, j] + A[6, j]) / 2;
            for(int i = 0; i < 7;i++){
                if (mx < A[i,j]){
                    mx=A[i,j]; 
                    mx_ind = i;
                }
            }
            if(mx < s){
                A[mx_ind, j] = s;
            }
            else {
                A[mx_ind, j] = mx_ind;
            } 
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if(n <= 0){
            return null;
        }
        int[,] answer = new int[n,3*n];
        for(int i = 0; i < 9;i += 3){
            for(int j = 0; j < n;j++) 
            {
                answer[j,j+i] = 1;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if(A.GetLength(0) != 6 || A.GetLength(1) != 6){
            return null;
        }
        int mx = int.MinValue, mxrow = 0, cnt = 0;
        for(int i = 0; i < 6;i++){
            if(mx < A[i,i]){
                mx=A[i,i];
                mxrow=i;
            }
        }
        for(int i = 0; i < mxrow;i++){
            cnt++;
            for(int j = cnt; j < 6;j++){
                A[i,j]= 0;
            }
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if(B.GetLength(0) != 6 || B.GetLength(1) != 6){
            return null;
        }
        for(int i = 0; i < 6;i += 2){
            int mx1 = int.MinValue, mx_index1 = 0, mx2 = int.MinValue,  mx_index2 = 0;
            for(int j = 0; j < 6;j++){
                if(mx1 < B[i,j]){
                    mx1 = B[i,j]; 
                    mx_index1=j;
                    }
                if(mx2 < B[i+1,j]){
                    mx2 = B[i+1,j];
                    mx_index2=j;
                    }
            }
            B[i,mx_index1] = mx2; 
            B[i+1,mx_index2] = mx1;
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if(A.GetLength(0) != 6 || A.GetLength(1) != 7){
            return null;
        }
        int buf;
        for(int i = 0; i < 6;i++) 
        {
            for(int j = 0; j < 3;j++){
                buf = A[i,6-j];
                A[i,6-j] = A[i,j];
                A[i,j] = buf;
            } 
        }
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if(matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5){
            return null;
        }
        int[] mn = new int[7];
        int temp;
        for(int i = 0; i < 7;i++) {
            int mn0 = int.MaxValue;
            for(int j = 0; j < 5;j++){
                if(matrix[i,j] < mn0){
                    mn0 = matrix[i,j];
                }
            }
            mn[i] = mn0;
        }
        for(int i = 0; i < 7;i++){
            for(int j = 0; j < 7-1-i;j++){
                if(mn[j] < mn[j + 1]){
                    temp = mn[j + 1];
                    mn[j + 1] = mn[j];
                    mn[j] = temp;
                    int buf;
                    for(int k = 0; k < 5; k++){
                        buf = matrix[j , k];
                        matrix[j, k] = matrix[j+1, k];
                        matrix[j+1, k] = buf;
                    }
                }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)){
            return null;
        }
        int n = matrix.GetLength(0), k = n-1, k1 = n-1, s,s1;
        int[] answer = new int[2*n-1];
        for (int i = 0;i < n;i++){
            s = 0; s1 = 0;
            for (int j = 0;i+j < n;j++){
                s += matrix[i+j,j];
                s1 += matrix [j,i+j];
            }
            answer[k--] = s;
            answer[k1++] = s1;
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
        if(matrix.GetLength(0) != matrix.GetLength(1) || k > matrix.GetLength(0) || k < 1){
            return null;
        }
        int n = matrix.GetLength(0);
        int row = 0,col = 0;
        int mx = int.MinValue;  
        for(int i = 0; i < n;i++){
            for(int j = 0; j < n;j++){
                if(mx < Math.Abs(matrix[i,j])){
                    mx = Math.Abs(matrix[i,j]); 
                    row = i; 
                    col = j;
                }
            }
        }
        int row2,buf;
        while(row != k-1) {
            if (row > k - 1) row2 = row -1;
            else row2 = row + 1;
            for(int i = 0; i < n;i++){
                buf = matrix[row , i];
                matrix[row,i] = matrix[row2,i];
                matrix[row2,i] = buf;
            }
            row = row2;
        } 
        int col2; 
        while(col != k-1) {
            if (col > k - 1) col2 = col -1;
            else col2 = col + 1;
            for(int i = 0; i < n;i++){
                buf = matrix[i , col];
                matrix[i,col] = matrix[i,col2];
                matrix[i,col2] = buf;
            }
            col = col2;
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
        if(A.Length != (n*(n+1)/2) || B.Length != (n*(n+1)/2)){
           return null; 
        }
        int cnt = 0;
        int[] answer = new int[n*n];
        int[,] mA = new int[n,n], mB = new int[n,n],mulmatrix = new int[n,n];
        for(int i = 0;i < n;i++){
            for(int j = i; j < n;j++){
                mA[i,j] = A[cnt]; 
                mA[j,i] = A[cnt];
                mB[i,j] = B[cnt]; 
                mB[j,i] = B[cnt];
                cnt++;
            }
        }
        for (int i = 0; i < n;i++){
            for(int j = 0; j < n;j++){
                mulmatrix[i,j] = 0;
                for (int k = 0; k < n;k++){
                    mulmatrix[i,j] += mA[i,k] * mB[k,j];
                }
               answer[j+i*n] = mulmatrix[i,j]; 
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
        if(matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7){
            return null;
        }
        int[] cnt = new int[7];
        int  temp,cnt_neg;
        for(int j = 0; j < 7;j++){
            cnt_neg = 0;
            for(int i = 0; i < 5;i++){
                if(matrix[i,j] < 0){
                    cnt_neg++;
                }
            }
            cnt[j] = cnt_neg;
        } 
        for(int j = 0; j < 7;j++){
            for(int i = 0; i < 5;i++){
                if(cnt[i] > cnt[i + 1]){
                    temp = cnt[i+1];
                    cnt[i+1] = cnt[i];
                    cnt[i] = temp;
                    int buf;
                    for(int k = 0; k < 5;k++){
                        buf = matrix[k , i];
                        matrix[k,i] = matrix[k, i+1];
                        matrix[k,i+1] = buf;
                    }
                }
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
        int cnt = matrix.GetLength(0);
        int[] m0 = new int[cnt];
        bool f = true;
        for(int i = 0; i < matrix.GetLength(0);i++){
            f = true;
            for(int j = 0; j < matrix.GetLength(1);j++){
                if (matrix[i,j] == 0){
                    cnt--;
                    f = false;
                    break;
                }
            }
            if (f){
                m0[i] = 1;
            }
        }
        int[,] A = new int[cnt,matrix.GetLength(1)];
        int k = 0;
        for(int i = 0; i < matrix.GetLength(0);i++) {
            for(int j = 0; j < matrix.GetLength(1);j++){
                if (m0[i] == 1){
                    A[k,j] = matrix[i,j];
                }
            }
            k++;
        }
        matrix = A;
        return matrix;
    }
    #endregion
}