using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return 0; 
        for (int i=0;i<5; i++){
            for (int j=0; j<7; j++){
                answer+=A[i,j];
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

        double mn=double.MaxValue;
        double n=A.GetLength(0);
        double m=A.GetLength(1);
        if (n!=3 || m!=6) return (0,0);
        for (int i=0;i<n; i++){
            for (int j=0;j<m; j++){
                if (A[i, j]<mn) {mn=A[i,j];
                col=j;
                row=i;}
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
        int[] answer = new int[5];
        // code here
        if (A.GetLength(0)!=3 || A.GetLength(1)!=5) return null;
        for (int j = 0; j<A.GetLength(1); j++){
            int mx = int.MinValue;
            for (int i =0; i<A.GetLength(0); i++){
                if (mx<A[i,j]) mx = A[i,j];
            }
            answer[j] = mx;
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7) return null;
        int mx = int.MinValue, id=-1;
        int temp;
        for (int i=0; i<A.GetLength(0); i++){
            if (mx<A[i,2]){
                mx = A[i,2]; id = i;
            }
        }
        for (int j =0; j<A.GetLength(1);j++){
            temp = A[3,j];
            A[3,j]=A[id,j];
            A[id,j]=temp;
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=5) return null;
        int mx = int.MinValue, id=-1, temp;
        for (int i =0;i<5; i++){
            if (A[i, i] > mx)
            {
                mx = A[i, i];
                id = i;
            }
        }
        for (int i = 0; i < 5; i++)
        {
            temp = A[i, 3];
            A[i, 3] = A[i, id];
            A[i, id] = temp;
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
        int col=0, row=0, z=0;
        for (int i=0; i<n; i++){
            int mx=int.MinValue;
            for (int j=0; j<m;j++){
                if (A[i,j]>mx) {mx = A[i,j];
                col=j;
                row=i;}
            }
            for (;col<m-1;col++){
                z=A[i,col];
                A[i,col]=A[i,col+1];
                A[i,col+1]=z;
            }
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
        for (int i=0;i<n;i++){
            double mx = double.MinValue;
            int col=0;
            for (int j=0;j<m;j++){
                if (C[i,j]>mx) {
                    mx=C[i,j];
                    col=j;
                }
            }
            for (int jj=0; jj<col;jj++){
                if (mx==0) C[i,jj]=C[i,jj];
                else if (C[i,jj]<0) C[i,jj]/=mx;
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
        double c=0,sum=0;
        int col=-1, row=-1;
        double mx=double.MinValue;
        if (Z.GetLength(0)!=6 || Z.GetLength(1)!=8) return null;
        for (int i =0; i<6; i++){
            for (int j=0; j<8; j++){
                if (Z[i,j]>0){
                    c++;
                    sum+=Z[i,j];
                }
                if (Z[i,j]>mx){
                    mx=Z[i,j];
                    col=j;
                    row=i;
                }
            }
        }
        Z[row,col] = sum/c;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int count=0;
        int[] new_count=new int[6];
        int mx=int.MinValue;
        int mn=int.MaxValue;
        int rowmx=0,rowmn=0;
        int z=0;
        for (int i=0; i<6; i++){
            count=0;
            for (int j=0;j<5; j++){
                if (X[i,j]<0) count++;
            }
            new_count[i]=count;
        }
        for (int i=0; i<new_count.GetLength(0);i++){
            if (new_count[i]>mx){
                mx=new_count[i];
                rowmx=i;
            }
            if (new_count[i]<mn){
                mn=new_count[i];
                rowmn=i;
            }
        }
        for(int i=0;i<5;i++){
            z=X[rowmx,i];
            X[rowmx, i]=X[rowmn, i];
            X[rowmn, i]=z;
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
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return null;
        int count=0, mxrow=0, mx=int.MinValue;
        int[] sum = new int[A.GetLength(0)];
        int[,] result=new int[A.GetLength(0)-1, A.GetLength(1)];
        for (int i = 0; i < 7; i++)
        {
            count = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0) count += A[i, j];
            }
            sum[i] = count;
        }
        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] > mx)
            {
                mx = sum[i];
                mxrow = i;
            }
        }

        for (int i = 0; i < result.GetLength(0); i++)
        {
            if (i < mxrow)
            {
                for (int j = 0; j<result.GetLength(1); j++)
                {
                    result[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j<result.GetLength(1); j++)
                {
                    result[i, j] = A[i + 1, j];
                }
            }

        }
        // end

        return result;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;
        int mndg = int.MaxValue;
        int mni = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < mndg)
            {
                mndg = A[4, i];
                mni = i;
            }
        }
        if (mni == A.GetLength(1) - 1) return null;
        int temp = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1) - 1; j > mni + 1; j--)
            {
                A[i, j] = temp;
                A[i, j] = A[i, j - 1];
                A[i, j - 1] = temp;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, mni + 1] = B[i];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;

        int[] mx = new int[A.GetLength(0)];
        double local_mx = double.MinValue;
        int mxi = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            local_mx = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > local_mx)
                {
                    local_mx = A[i, j];
                    mxi = j;
                }
            }
            mx[i] = mxi;
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {

                if (j == mx[i])
                {
                    if (A[i, j - 1] < A[i, j + 1])
                    {
                        if (A[i, j - 1] < 0)
                        {
                            A[i, j - 1] = A[i, j - 1] / 2;
                        }
                        if (A[i, j - 1] > 0)
                        {
                            A[i, j - 1] = A[i, j - 1] * 2;
                        }
                    }
                    else
                    {
                        if (A[i, j + 1] < 0)
                        {
                            A[i, j + 1] = A[i, j + 1] / 2;
                        }
                        if (A[i, j + 1] > 0)
                        {
                            A[i, j + 1] = A[i, j + 1] * 2;
                        }
                    }
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
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        for (int j = 0; j < cols; j++)
        {
            int countNegative = 0, countPostive = 0;
            int mx = int.MinValue;
            int mxi = -1;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    mxi = i;
                }

                if (A[i, j] > 0) countPostive++;
                else if (A[i, j] < 0) countNegative++;
            }

            if (countPostive > countNegative) A[mxi, j] = 0;
            else A[mxi, j] = mxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        int rows = A.GetLength(0), cols = A.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            int mxi = 0, s = 0, X = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > X)
                {
                    X = A[i, j];
                    mxi= i;
                }
            }
            if (mxi < rows / 2)
            {
                for (int i = mxi + 1; i < rows; i++) s += A[i, j];
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length!=5) return null;
        int rows = A.GetLength(0), cols = A.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            int mx = int.MinValue;
            int mxi = -1;
            for (int i = 0; i < rows; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    mxi = i;
                }
            }
            if (mx < B[j]) A[mxi, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int rows = A.GetLength(0), cols = A.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            int mxi = 0;
            double sum = (A[0, j] + A[rows - 1, j]) / 2;
            for (int i = 0; i < rows; i++)
            {
                if (A[mxi, j] < A[i, j]) mxi = i;
            }
            if (A[mxi, j] < sum) A[mxi, j] = sum;
            else A[mxi, j] = mxi + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];

        for (int i = 0; i < answer.GetLength(1); i++)
        {
            answer[i % 3, i] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int rows = A.GetLength(0), cols = A.GetLength(1);
        int mxi = 0;
        for (int i = 0; i < rows; i++)
        {
            if (A[mxi, mxi] < A[i,i]) mxi = i;
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i < mxi && j > i) A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int[] mx = new int[B.GetLength(0)];
        for (int i = 0; i<6; i++)
        {
            int max = int.MinValue;
            int mxi = 0;
            for (int j = 0; j < 6; j++)
            {
                if (max < B[i, j])
                {
                    max = B[i, j];
                    mxi = j;
                }
            }
            mx[i] = mxi;
        }
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (mx[i] == j && i % 2 == 0)
                {
                    temp = B[i, mx[i]];
                    B[i, mx[i]] = B[i + 1, mx[i + 1]];
                    B[i + 1, mx[i + 1]] = temp;
                }
            }
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int rows = A.GetLength(0), cols = A.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, cols - 1 - j];
                A[i, cols - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return null;
        int[,] data = new int[rows, 2];
        for (int i = 0; i<rows; i++)
        {
            int mn = 0;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < mn) mn = matrix[i, j];
            }
            data[i, 0] = i;
            data[i, 1] = mn;
        }
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                if (data[j, 1] < data[j + 1, 1])
                {
                    int tmp1 = data[j, 0];
                    int tmp2 = data[j, 1];

                    data[j, 0] = data[j + 1, 0];
                    data[j, 1] = data[j + 1, 1];

                    data[j + 1, 0] = tmp1;
                    data[j + 1, 1] = tmp2;
                }
            }
        }
        int[,] newMatrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                newMatrix[i, j] = matrix[data[i, 0], j];
            }
        }
        matrix = newMatrix;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m) return answer;
        answer = new int[2*n-1];
        for (int i = 0; i < 2*n-1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j - i + (n - 1)] += matrix[i, j];
            }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m || k < 1) return null;
        int mx = int.MinValue,  rows= 0, cols = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > mx)
                {
                    mx = Math.Abs(matrix[i, j]);
                    rows = i;
                    cols = j;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int P = matrix[rows, i];
            matrix[rows, i] = matrix[k-1, i];
            matrix[k-1, i] = P;
        }
        for (int i = 0; i < n; i++)
        {
            int P = matrix[i, rows];
            matrix[i, rows] = matrix[i, k-1];
            matrix[i, k-1] = P;
        }
        // end

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
        if (A.Length + A.Length - n != n * n || B.Length + B.Length - n != n * n) return null;
        int[,] new_matrix = new int[n, n];
        int [,] new_matrix2 = new int[n, n];
        int[] result = new int[n * n];
        for (int i = 0, y = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                new_matrix[i, j] = A[y];
                new_matrix[j, i] = A[y];
                new_matrix2[i, j] = B[y];
                new_matrix2[j, i] = B[y];
                y++;
            }
        }
        for (int i = 0, y = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += new_matrix[i, j] * new_matrix2[j, k];
                }
                result[y] = s;
                y++;
            }
        }
        answer = result;
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        int[,] pass = new int[matrix.GetLength(1), 2];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int otr = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] < 0) otr++;
            }
            pass[i, 0] = i;
            pass[i, 1] = otr;
        }
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (pass[j, 1] > pass[j + 1, 1])
                {
                    int el = pass[j, 0];
                    int el1 = pass[j, 1];
                    pass[j, 0] = pass[j + 1, 0];
                    pass[j, 1] = pass[j + 1, 1];
                    pass[j + 1, 0] = el;
                    pass[j + 1, 1] = el1;
                }
            }
        }
        int[,] new_matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                new_matrix[j, i] = matrix[j, pass[i, 0]];
            }
        }
        matrix = new_matrix;
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
        int  count = 0;
        int[] index = new int[matrix.GetLength(0)];
        for (int i = 0, i2 = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 0)
                {
                    count++;
                    flag = false;
                    break;
                }
            if (!flag) 
                index[i2++] = i;
        }
        int[,] new_matrix = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        for (int i = 0, i2 = 0; i < matrix.GetLength(0); i++)
        {
            if (i == index[i2]) 
                i2++;
            else
                for (int j = 0; j < matrix.GetLength(1); j++) 
                    new_matrix[i, j] = matrix[i, j];

        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    #endregion
}