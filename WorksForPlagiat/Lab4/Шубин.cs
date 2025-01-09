using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };
        int[] vector = new int[] { 1, 2, 3, 4, 5 };
        program.Task_3_11(matrix);
    }

    public static void PrintMatrix(int[,] matrix){
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        for (int i = 0; i < AHeight; i++){
            for (int j = 0; j < AWeight; j++){
                System.Console.Write(matrix[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    
    public static void PrintMatrixDouble(double[,] matrix){
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        for (int i = 0; i < AHeight; i++){
            for (int j = 0; j < AWeight; j++){
                System.Console.Write(matrix[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                answer += A[i, j];
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
        int minMemb = int.MaxValue;
        // code here
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                if (A[i, j] < minMemb){
                    row = i;
                    col = j;
                    minMemb = A[i, j];
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return null;
        int[] answer =new int[A.GetLength(1)];
        // code here
        for (int j = 0; j < A.GetLength(1); j++){
            int MaxVal = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                }
            }
            answer[j] = MaxVal;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        if (row != 5 || col != 7){
            return null;
        }
        int IndexMaxEl = 0;
        int MaxVal = int.MinValue;
        for (int i = 0; i < row; i++){
                //System.Console.Write(A[i, 2] + " ");
                if (A[i, 2] > MaxVal){
                    MaxVal = A[i, 2];
                    IndexMaxEl = i;
                }
        }
        System.Console.WriteLine(IndexMaxEl);
        int[,] answer = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (i == 3){
                    answer[i, j] = A[IndexMaxEl, j];
                    continue;
                }
                if (i == IndexMaxEl){
                    answer[i, j] = A[3, j];
                    continue;
                }
                answer[i, j] = A[i, j];
            }
        }
        PrintMatrix(answer);
        // end  

        return answer;
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
    int row = A.GetLength(0);
    int col = A.GetLength(1);
    int MaxIndex = -1;
    int MaxVal = int.MinValue;
    if (col != 5 || row != 5){
        return null;
    }
    for (int i = 0; i < row; i++){
        if (A[i, i] > MaxVal){
            MaxVal = A[i, i];
            MaxIndex = i;
        }
    }
    int [,] answer = new int[row, col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            if (j == 3){
                answer[i, j] = A[i, MaxIndex];
                continue;
            }
            if (j == MaxIndex){
                answer[i, j] = A[i, 3];
                continue;
            }
            answer[i, j] = A[i, j];
        }
    }
        // end
    PrintMatrix(answer);
        return answer;
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
    int row = A.GetLength(0);
    int col = A.GetLength(1);
    int [,] answer = new int[row, col];
    for (int i = 0; i < row; i++){
        int MaxVal = int.MinValue;
        int MaxIndex = -1;
        for (int j = 0; j < col; j++){
            if (A[i, j] > MaxVal){
                MaxVal = A[i, j];
                MaxIndex = j;
            }
        }
        System.Console.WriteLine(MaxIndex);
        for (int j = 0; j < col; j++){
            if (j >= MaxIndex && j != col-1){
                answer[i, j] = A[i, j+1];
                continue;
            }
            if (j == col-1){
                answer[i, j] = A[i, MaxIndex];
                continue;
            }
            answer[i, j] = A[i, j];
        }
    }
        // end
        PrintMatrix(A);
        System.Console.WriteLine();
        PrintMatrix(answer);

        return answer;
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
        
        int row = C.GetLength(0);
        int col = C.GetLength(1);
        double [,] answer = new double [row, col];
        for (int i = 0; i < n; i++){
            double MaxVal = double.MinValue;
            int MaxIndex = -1;
            for (int j = 0; j < m; j++){
                if (C[i, j] > MaxVal){
                    MaxVal = C[i, j];
                    MaxIndex = j;
                }
            }
            for (int j = 0; j < m; j++){
                if (j < MaxIndex && C[i, j] < 0){
                    answer[i, j] = C[i, j]/MaxVal;
                    continue;
                }
                answer[i, j] = C[i, j];
            } 
        }
        // end

        return answer;
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
        int row = Z.GetLength(0);
        int col = Z.GetLength(1);
        double [,] answer = new double [row, col];
        double med;
        double sum = 0;
        double count = 0;
        double MaxVal = double.MinValue;
        int MaxIndex = -1;
        if (row != 6 || col != 8){
            return null;
        }
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (Z[i, j] > 0){
                    sum += Z[i, j];
                    count++;
                }
                if (Z[i, j] > MaxVal){ 
                    MaxVal = Z[i, j];
                }
            }
        }
        med = sum/count;
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (Z[i, j] == MaxVal){ 
                    Z[i, j] = med;
                }
            }
        }
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
        int row = X.GetLength(0);
        int col = X.GetLength(1);
        int [,] answer = new int [row, col];
        double med;
        double sum = 0;
        int MaxCountEl = int.MinValue;
        int MinCountEl = int.MaxValue;
        int MaxIndex = -1;
        int MinIndex = -1;
        if (row != 6 || col != 5){
            return null;
        }
        for (int i = 0; i < row; i++){
            int count = 0;
            for (int j = 0; j < col; j++){
                if (X[i, j] < 0){
                    count++;
                }
            }
            if (count > MaxCountEl){
                MaxCountEl = count;
                MaxIndex = i;
            }
            if (count < MinCountEl){
                MinCountEl = count;
                MinIndex = i;
            }
        }

        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (i == MaxIndex){
                    answer[i, j] = X[MinIndex, j];
                    continue;
                }
                if (i == MinIndex){
                    answer[i, j] = X[MaxIndex, j];
                    continue;
                }
                answer[i, j] = X[i, j];
        }
        }
        // end

        return answer;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double med;
        int MaxSum = int.MinValue;
        int MaxIndex = -1;
        if (row != 7 || col != 5){
            return null;
        }
        int [,] answer = new int [row-1, col];
        for (int i = 0; i < row; i++){
            int sum = 0;
            for (int j = 0; j < col; j++){
                if (A[i, j] > 0){
                    sum += A[i, j];
                }
            }
            if (sum > MaxSum){
                MaxSum = sum;
                MaxIndex = i;
            }
        }
        System.Console.WriteLine(MaxIndex);
        System.Console.WriteLine(answer.GetLength(0));
        System.Console.WriteLine(col);
        int ansI = 0;
        for (int i = 0; i < row; i++){
            if (i == MaxIndex){
                    continue;
                }
            for (int j = 0; j < col; j++){
                answer[ansI, j] = A[i, j];
            }
            ansI++;
        }
        // end

        return answer;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int [,] answer = new int [row, col];
        double med;
        int MinVal = int.MaxValue;
        int MinIndex = -1;
        if (row != 5 || col != 8 || B.Length != row){
            return null;
        }
        for (int j = 0; j < col; j++){
            if (A[4, j] < MinVal){
                MinVal = A[4,j];
                MinIndex = j;
            }
        }   

        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (j == MinIndex + 1){
                    answer[i, j] = B[i];
                    continue;
                }
                answer[i, j] = A[i, j];
            }
        }
        PrintMatrix(answer);
        System.Console.WriteLine("1");
        return answer;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 5 || col != 7){
            return null;
        }

        for (int i = 0; i < row; i++){
            double MaxVal = double.MinValue;
            int MaxIndex = -1;
            for (int j = 0; j < col; j++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndex = j;
                }
            }
            if (MaxIndex == col-1){
                if ( A[i, MaxIndex-1] < 0){
                    A[i, MaxIndex-1] /= 2;
                }
                else{
                    A[i, MaxIndex-1] *= 2;
                }
            }
            if (MaxIndex == 0){
                if ( A[i, MaxIndex+1] < 0){
                    A[i, MaxIndex+1] /= 2;
                }
                else{
                    A[i, MaxIndex+1] *= 2;
                }
            }
            else{
            double leftChar = A[i, MaxIndex-1];
            double rightChar = A[i, MaxIndex+1];
            if (leftChar < rightChar){
                if ( A[i, MaxIndex-1] < 0){
                    A[i, MaxIndex-1] /= 2;
                }
                else{
                    A[i, MaxIndex-1] *= 2;
                }
            }
            else{
                if ( A[i, MaxIndex+1] < 0){
                    A[i, MaxIndex+1] /= 2;
                }
                else{
                    A[i, MaxIndex+1] *= 2;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 7 || col != 5){
            return null;
        }

        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > 0){
                    MaxCount++;
                }
                if (A[i, j] < 0){
                    MinCount++;
                }
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            if (MaxCount > MinCount){
                A[MaxIndexI, MaxIndexJ] = 0;
            }
            else{
                A[MaxIndexI, MaxIndexJ] = MaxIndexI+1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        PrintMatrix(A);
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 10 || col != 5){
            return null;
        }
        
        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            int SumEl = 0;
            for (int i = 0; i < row; i++){
                if (i > MaxIndexI){
                    SumEl += A[i, j];
                }
            }
            if (MaxIndexJ <= (row+1)/2){
                A[0, j] = SumEl;
            }
        }
        PrintMatrix(A);
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        PrintMatrix(A);
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 7 || col != 5 || B.Length != 5){
            return null;
        }
        
        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            if (A[MaxIndexI, MaxIndexJ] < B[j]){
                A[MaxIndexI, MaxIndexJ] = B[j];
            }
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        PrintMatrixDouble(A);
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 7 || col != 5){
            return null;
        }
        
        for (int j = 0; j < col; j++){
            double MaxVal = double.MinValue;
            int MaxIndexI = -1;
            int MaxIndexJ = -1;
            double MinVal = double.MaxValue;
            int MinIndexI = -1;
            int MinIndexJ = -1;
            int MaxCount = 0;
            int MinCount = 0;
            double sum = 0;
            for (int i = 0; i < row; i++){
                if (A[i, j] > MaxVal){
                    MaxVal = A[i, j];
                    MaxIndexI = i;
                    MaxIndexJ = j; 
                }
                if (A[i, j] < MinVal){
                    MinVal = A[i, j];
                    MinIndexI = i;
                    MinIndexJ = j; 
                }
            }
            sum = (A[0, j] + A[row-1, j])/2;
            if (MaxVal < sum){
                A[MaxIndexI, MaxIndexJ] = sum;
            }
            else{
                A[MaxIndexI, MaxIndexJ] = MaxIndexI+1;
            }
            

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 1){
            return null;
        }
        int[,] answer = new int[n,3*n];
        int row = answer.GetLength(0);
        int col = answer.GetLength(1);
        // code here
        // end
        for (int i = 0; i < row; i++){
            for (int j = i; j < col; j+=(n)){
                //System.Console.WriteLine(j);
                answer[i, j] = 1;
                
                    System.Console.WriteLine(i);
                }
        }
        PrintMatrix(answer);
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        PrintMatrix(A);
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        double MaxVal = double.MinValue;
        int MaxIndexI = -1;
        int MaxIndexJ = -1;
        double MinVal = double.MaxValue;
        int MinIndexI = -1;
        int MinIndexJ = -1;
        int MaxCount = 0;
        int MinCount = 0;
        double sum = 0;

        if (row != 6 || col != 6){
            return null;
        }
        
        for (int i = 0; i < row; i++){
            if (A[i, i] > MaxVal){
                MaxVal = A[i, i];
                MaxIndexI = i;
            }
        }

        for (int i = 0; i < MaxIndexI; i++){
            for (int j = i + 1; j < col; j++){
                //System.Console.Write($"{i} {j} ");
                A[i, j] = 0;
            }
            System.Console.WriteLine();
        }
        // end
        PrintMatrix(A);
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        PrintMatrix(B);
        System.Console.WriteLine();
        int row = B.GetLength(0);
        int col = B.GetLength(1);

        if (row != 6 || col != 6){
            return null;
        }

        for (int i = 0; i < row-1; i+=2){
            double MaxValFirst = double.MinValue;
            double MaxValSecond = double.MinValue;
            
            int MaxIndexFirstI = -1;
            int MaxIndexFirstJ = -1;

            int MaxIndexSecondI = -1;
            int MaxIndexSecondJ = -1;
            for (int j = 0; j < col; j++){
                // System.Console.Write($"{B[i, j]} ");
                // System.Console.WriteLine($"{B[i+1, j]}");
                if (B[i, j] > MaxValFirst){
                    MaxValFirst = B[i, j];
                    MaxIndexFirstI = i;
                    MaxIndexFirstJ = j;
                }
                if (B[i+1, j] > MaxValSecond){
                    MaxValSecond = B[i+1, j];
                    MaxIndexSecondI = i+1;
                    MaxIndexSecondJ = j;
                }
            }
            int tmp = B[MaxIndexFirstI, MaxIndexFirstJ];
            B[MaxIndexFirstI, MaxIndexFirstJ] = B[MaxIndexSecondI, MaxIndexSecondJ];
            B[MaxIndexSecondI, MaxIndexSecondJ] = tmp;
            System.Console.Write($"{MaxIndexFirstI}, {MaxIndexSecondJ} ");
            System.Console.WriteLine($"{MaxIndexSecondI}, {MaxIndexSecondJ}");
            //System.Console.WriteLine($"{B[MaxIndexFirstI, MaxIndexFirstJ]}, {tmp}");

        }
        PrintMatrix(B);
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        PrintMatrix(A);
        System.Console.WriteLine();
        int row = A.GetLength(0);
        int col = A.GetLength(1);

        if (row != 6 || col != 7){
            return null;
        }

        for (int i = 0; i < row; i++){
            int [] tmp = new int[col];
            for (int j = 0; j < col; j++){
                tmp[j] = A[i, j];
            }
            // for(int k = 0; k < tmp.Length; k++){
            //         System.Console.Write(tmp[k]+" ");
            //     }
            //     System.Console.WriteLine();
            for (int j = col-1; j >= 0; j--){
                //System.Console.WriteLine($"{j} {col-j-1}");
                A[i, j] = tmp[col-j-1];
            }
        }
        PrintMatrix(A);
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row != col || row < 1){
            return null;
        }

        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (i == 0 || j == 0 || i == row-1 || j == col-1){
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row != col || row < 1){
            return null;
        }
        int ind = (col/2)+1;
        for (int i = row/2; i < row; i++){
            for (int j = 0; j < ind; j++){
                matrix[i, j] = 1;
            }
            ind++;
        }
        PrintMatrix(matrix);
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int CountUpper = 0;
        for (int i = 1; i < row+1; i++){
            CountUpper+=i;
        }
        int CountLower = row*row-CountUpper;
        int[] upper = new int[CountUpper];
        int[] lower = new int[CountLower];
        // code here
        //System.Console.WriteLine(CountUpper);
        if (row != col || row < 1){
            return (null, null);
        }
        int k = 0;
        int k2 =0;
        for (int i = 0; i < row; i++){
            string s = "";
            for (int j = i; j < col; j++){
                upper[k] = matrix[i, j];
                
                s += $" {matrix[i, j], 2}";
                k+=1;
            }
            System.Console.Write($"{s,20}");
            System.Console.WriteLine();
            string s2 = "";
            for (int j = 0; j < i; j++){
                //matrix[i, j] = 0; 
                lower[k2] = matrix[i, j];
                k2++;  
                s2 +=$" {matrix[i, j], 2}";
            }
            System.Console.Write($"{s2,-20}");
            System.Console.WriteLine();
        }
        // foreach (int member in upper){
        //     System.Console.Write(member + " ");
        // }
        System.Console.WriteLine();
        PrintMatrix(matrix);
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row != 7 || col != 5){
            return null;
        }
        int[] CountList = new int[row];
        for (int i = 0; i < row; i++){
            int count = 0;
            for (int j = 0; j < col; j++){
                if(matrix[i, j] > 0){
                    count++;
                }
            }
            CountList[i] = count;
        }
        for (int i = 0; i < row-1; i++){
            for (int j = 0; j < row-i-1; j++){
                if (CountList[j] < CountList[j+1]){
                    int temp = CountList[j];
                    CountList[j] = CountList[j + 1];
                    CountList[j + 1] = temp;

                    for (int index = 0; index < col; index++){
                        int tmpMat = matrix[j, index];
                        matrix[j, index] = matrix[j+1, index];
                        matrix[j+1, index] = tmpMat;
                    }
                }
            }
        }
        foreach(int member in CountList){
            System.Console.WriteLine(member);
        }
        PrintMatrix(matrix);
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    
    public int[] TopSort(int[] matrix){
        int n = matrix.Length;
        for (int i = 0; i < n - 1; i++){
            for (int j = 0; j < n - i - 1; j++){
                if (matrix[j] > matrix[j+1]){
                    int tmp = matrix[j];
                    matrix[j] = matrix[j+1];
                    matrix[j+1] = tmp;
                }
            }
        }
        return matrix;
    }
    
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row < 1 || col < 1){
            return null;
        }

        for (int i = 0; i < row; i+=2){
            for (int j = 0; j < col - 1; j++){
                for (int k = 0; k < col - j - 1; k++){
                    if (matrix[i, k] < matrix[i, k+1]){
                        int tmp = matrix[i, k];
                        matrix[i, k] = matrix[i, k+1];
                        matrix[i, k+1] = tmp;
                    }
                }
            }
        }
        for (int i = 1; i < row; i+=2){
            for (int j = 0; j < col - 1; j++){
                for (int k = 0; k < col - j - 1; k++){
                    if (matrix[i, k] > matrix[i, k+1]){
                        int tmp = matrix[i, k];
                        matrix[i, k] = matrix[i, k+1];
                        matrix[i, k+1] = tmp;
                    }
                }
            }
        }
        // end
        PrintMatrix(matrix);
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row < 1 || col < 1){
            return null;
        }
        int countNulls = 0;
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (matrix[i, j] == 0){
                    countNulls++;
                    break;
                }
            }
        }
        System.Console.WriteLine(countNulls);
        int[] nulls = new int[countNulls];
        int nullsIndex = 0;
        for (int i = 0; i < row; i++){
            bool flag = false;
            for (int j = 0; j < col; j++){
                if (matrix[i, j] == 0){
                    flag = true;
                    break;
                }
            }
            if (flag == true){
            nulls[nullsIndex] = i;
            nullsIndex++;
            }
        }

        foreach(int member in nulls){
            System.Console.WriteLine(member);
        }
        
        int[,] answer = new int[row - nulls.Length, col];
        int index = 0;
        for (int i = 0; i < row; i++){
            bool flag = false;
            for (int j = 0; j < nulls.Length; j++){
                if (i == nulls[j]){
                    flag = true;
                    break;
                }
            }
            if (flag == true){
                continue;
            }
            for (int j = 0; j < col; j++){
                answer[index, j] = matrix[i, j];
            }
            index++;
        }
        // end
        PrintMatrix(answer);

        return answer;
    }
    #endregion
}