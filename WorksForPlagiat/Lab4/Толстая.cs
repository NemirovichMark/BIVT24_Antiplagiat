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
        /*program.Task_1_6(new int[,] { {1,2,3 } , {1,2,3 } });
        program.Task_1_24(new double[,] {
                { 1, 2, -3, 4, -5 },
                { 5, 6, -7, 8, 9, },
                { 9, 10, 11, 12, 13},
                { -13, 14, 25, 16, 11 },
                { 0, -1, -2, -3, -4 },
                { 1, -1, 2, -2, 3 }
            });
        program.Task_1_30(new int[,] {
                { 1, 2, -3, 7, -5},
                { 5, 6, -7, 8, 9 },
                { 9, 10, 11, 12, 13 },
                { -13, 14, 25, 25, 16 },
                { 0, 0, -1, -2, -3 }
            });
        program.Task_2_1(new double[,] {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, -30, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            });
        program.Task_2_2(new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            });*/
        int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        program.Task_3_2(matrix);

        program.Task_3_6(new int[,] {
            { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
        });

        program.Task_3_8(new int[,]{
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            });
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
        int sum = 0;
        for (int i = 0; i < A.GetLength(0); i++) {
            sum += A[i, i];
        }
        // end
        answer = sum;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
                       
        int c = 0;
        int minc = 0;
        int min = 100000;
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;                        
            for (j = 0; j < col; j++) {                
                if (A[i, j]!=0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;            
        }
        if (continueProgram == false)
            return answer;
        
        answer = new int[row];
        for (int i = 0; i < row; i++) {
            int j = 0;          
            min = 1000000000;
            for (j = 0; j < col; j++) {
                if (A[i,j] < min) {
                    min = A[i,j];
                    minc = j;
                }
            }
            answer[c] = minc;
            c++;
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
        int[,] answer = default(int[,]);

        int row = A.GetLength(0);
        int col = A.GetLength(1);

        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;            
            for (j = 0; j < col; j++) {                
                if (A[i, j]!=0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;


        int max = Int32.MinValue;
        int maxc = 0;

        for (int i = 0; i < row; i++) {
            int j = 0;
            max = Int32.MinValue;
            for (j = 0; j < col; j++) {
                if (A[i,j] > max) { 
                    max = A[i,j];
                    maxc = j;
                }              
                }
            A[i,maxc] = A[i,0];
            A[i,0] = max;                     
            
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;            
            for (j = 0; j < col; j++) {                
                if (A[i, j]!=0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxi = 0;
        int maxj = 0;
        for (int i = 0; i < row; i++) {
            
            for (int j = 0; j < col; j++) {
                if (A[i,j] > max) {
                    max = A[i, j];
                    maxi = i;
                    maxj = j;
                }
            }
        }
        int [,] B = new int[row-1,col-1];

        for (int i = 0; i < row - 1; i++) {
            if (i < maxi) {
                for (int j = 0; j < col - 1; j++) {
                    if (j < maxj) {
                        B[i, j] = A[i, j];
                    }
                    else {
                        B[i, j] = A[i, j + 1];
                    }
                }
            }
            else {
                for (int j = 0; j < col - 1; j++) {
                    if (j < maxj) {
                        B[i, j] = A[i+1, j];
                    }
                    else {
                        B[i, j] = A[i+1, j + 1];
                    }
                }
            }
        }
        // end

        return B;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxi = 0;
        for (int i = 0; i < row; i++) {
            max = Int32.MinValue;
            for (int j = 0; j < col; j++) {
                if (A[i,j] > max) {
                    max = A[i, j];
                    maxi = i+1;
                }
            }
            for (int j = 0; j < col; j++) {
                if (A[i,j] == max) {
                    A[i, j] = max * maxi;
                }
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
        int row = D.GetLength(0);
        int col = D.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (D[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxj = 0;
        int minj = 0;
        for (int i = 0; i < row; i++) {
            max = Int32.MinValue;
            minj = -1;
            for (int j = 0; j < col; j++) {
                if (D[i, j] < 0) {
                    break;
                }
                if (D[i, j] > max) {
                    max = D[i, j];
                    maxj = j;
                }
            }
            for (int j = 0; j < col; j++) {
                if (D[i,j] < 0) {
                    minj = j;
                    
                }
            }
            if (minj == -1 || max == Int32.MinValue) {
                continue;
            }
            else {
                D[i, maxj] = D[i, minj];
                D[i, minj] = max;
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
        int row = H.GetLength(0);
        int col = H.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (H[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;
        int max = Int32.MinValue;
        
        for (int i = 0; i < row; i++) {
            max = Int32.MinValue;
            for (int j = 0; j < col; j++) {
                if (H[i,j] > max) {
                    max = H[i, j];
                }
            }
            H[i, col - 1] = H[i, col - 2]; 
            H[i, col - 2] = max;
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
        int row = Y.GetLength(0);
        int col = Y.GetLength(1);
        double[,] answer = default(double[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (Y[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        double max = Double.MinValue;
        int maxj = 0;
        int c = 0;
        double sr = 0;
        double sum = 0;
        for (int i = 0; i < row; i++) {
            max = Double.MinValue;
            c = 0;
            sr = 0;
            sum = 0;
            for (int j = 0; j < col; j++) {
                if (Y[i,j] > max){
                    max = Y[i,j];
                    maxj = j;
                }
            }
            for (int j = maxj + 1; j < col; j++) {
                if (Y[i,j] > 0) {
                    c++;
                    sum += Y[i,j];
                }
            }
            if (sum == 0) { sr = 0; }
            else { sr = sum / c; }
            for (int j = 0; j < maxj; j++) {
                if (Y[i,j] < 0) {
                    Y[i,j] = sr;
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
        int row = B.GetLength(0);
        int col = B.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (B[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int[] A = new int[row];
        int max = Int32.MinValue;
        for (int i = 0; i < row; i++) {
            max = Int32.MinValue;
            for (int j = 0; j < col; j++) {
                if (B[i, j] > max) {
                    max = B[i, j];
                }
            }
            A[i] = max;
        }
        for (int i = 0; i < row; i++) {
            B[i,3] = A[row-i-1];
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
        int row = B.GetLength(0);
        int col = B.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (B[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxi = 0;
        int mini = 0;
        bool flag = false;
        for (int i = 0; i < row; i++) {
            if (B[i,i] >  max) {
                max=B[i,i];
                maxi=i;
            }
            if (B[i,2] < 0 && flag == false) {
                mini = i;
                flag = true;
            }
        }
        for (int i = 0; i < col; i++) {
            int P = B[maxi,i];
            B[maxi,i] = B[mini,i];
            B[mini,i] = P;  
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
        
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[] answer = default(int[]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int c = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (A[i,j] < 0) {
                    c ++;
                }
            }
        }
        answer = new int[c];
        c = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (A[i,j] < 0) {
                    answer[c] = A[i,j];
                    c++;
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
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double[,] answer = default(double[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {            
            for (int j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        double max = Double.MinValue;
        int maxj = 0;
        for (int i = 0; i < row; i++) {
            max = Double.MinValue;
            for (int j = 0; j < col; j++) {
                if (A[i, j] > max) {
                    max = A[i, j];
                    maxj = j;
                }
            }
            if (maxj == 0) {
                if (A[i, 1] > 0) {
                    A[i, 1] = A[i, 1] * 2;
                        }
                else {
                    A[i,1] = A[i,1]*0.5;
                }
            }
            else if (maxj == col - 1) {
                if (A[i, col-2] > 0) {
                    A[i, col-2] = A[i, col-2] * 2;
                }
                else {
                    A[i, col-2] = A[i, col-2] * 0.5;
                }
            }
            else if (A[i,maxj-1] > A[i, maxj + 1]) {
                if (A[i, maxj+1] > 0) {
                    A[i, maxj+1] = A[i, maxj+1] * 2;
                }
                else {
                    A[i, maxj + 1] = A[i, maxj+1] * 0.5;
                }
            }
            else {
                if (A[i, maxj - 1] > 0) {
                    A[i, maxj - 1] = A[i, maxj - 1] * 2;
                }
                else {
                    A[i, maxj - 1] = A[i, maxj - 1] * 0.5;
                }
            }
        }


        // end

        return A;
    }
    

    public double[,] Task_2_1_test(double[,] A) {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double[,] answer = default(double[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {                
                if (A[i,i] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        double max = Double.MinValue;
        int maxj = 0;
        
        for (int i = 0; i < row; i++) {
            double mult = 2;
            max = Double.MinValue;
            for (int j = 0; j < col; j++) {
                if (A[i, j] > max) {
                    max = A[i, j];
                    maxj = j;
                }
            }
            int elem = 0;
            if (maxj == 0||maxj == col-1) {
                if (maxj == 0) {
                    elem = 1;
                }
                else {
                    elem = col - 2;
                }
                //elem = maxj == 0 ? 1 : col- 2;                                
            }
            else {
                if (A[i, maxj - 1] < A[i, maxj + 1]) {
                    elem = maxj - 1;
                }
                else {
                    elem = maxj + 1;
                }
                //elem = A[i, maxj - 1] < A[i, maxj + 1] ? maxj - 1 : maxj + 1;
            }
            if (A[i, elem] < 0) {
                mult = 0.5;
            }            
            //mult = A[i, elem] > 0 ? 2 : 0.5;
            A[i, elem] = A[i, elem] * mult;
        }
        // end
        return A;
    }

    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int plus = 0;
        int minus = 0;
        int max = Int32.MinValue;
        int maxj = 0;

        for (int i = 0; i < col; i++) {
            max = Int32.MinValue;
            plus = 0;
            minus = 0;
            for (int j = 0; j < row; j++) {
                if (A[j,i] > 0) {
                    plus++;
                }
                else if (A[j, i] < 0) {
                    minus++;
                }
                if (A[j,i] > max) {
                    max = A[j,i];
                    maxj = j;
                }
            }
            if (plus > minus) {
                A[maxj,i] = 0;
            }
            else {
                A[maxj, i] = maxj;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxj = 0;
        int sum = 0;
        for (int i = 0; i < col; i++) {
            max = Int32.MinValue;
            sum = 0;
            for (int j = 0; j < row; j++) {                  
                if (A[j, i] > max) {
                    max = A[j, i];
                    maxj = j;
                }
            }
            if (maxj == row - 1) {
                continue;
            }
            for (int j = maxj + 1; j < row; j++) {
                sum += A[j, i];
            }
            if (maxj < row/2 ) {
                A[0,i] = sum;
            }            
        }
            // end

            return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;
       
        bool continueProgram_1 = false;
        for (int i = 0; i < B.Length; i++) {
            if (B[i] != 0) {
                continueProgram_1 = true;
                break;
            }                        
        }
        if (continueProgram_1 == false)
            return answer;


        int max = Int32.MinValue;
        int maxj = 0;        
        for (int i = 0; i < col; i++) {
            max = Int32.MinValue;           
            for (int j = 0; j < row; j++) {
                if (A[j, i] > max) {
                    max = A[j, i];
                    maxj = j;
                }
            }
            if (max < B[i]) {
                A[maxj,i] = B[i];
            }
        }
            // end

            return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        double[,] answer = default(double[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        double max = Int32.MinValue;
        int maxj = 0;        
        for (int i = 0; i < col; i++) {
            max = Int32.MinValue;            
            for (int j = 0; j < row; j++) {
                if (A[j, i] > max) {
                    max = A[j, i];
                    maxj = j;
                }
            }
            if ( (A[0,i] + A[row-1,i])/2 > max) {
                A[maxj,i] = (A[0, i] + A[row - 1, i]) / 2;
            }
            else {
                A[maxj, i] = maxj;
            }

        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {       
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) {
            return answer;
        }
        answer = new int[n,n*3];
        int row = answer.GetLength(0);
        int col = answer.GetLength(1);
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                answer[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < row; i++) {
            count++;
            for (int j = count; j < col;) {
                answer[i,j] = 1;
                j += 3;
            }
        }
       
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max = Int32.MinValue;
        int maxi = 0;
        for (int i = 0; i < row; i++) {
            if (A[i,i] > max) {
                max = A[i,i];
                maxi = i;
            }
        }

        for (int i = 0; i < maxi; i++) {
            for (int j = i+1; j < col; j++) {
                A[i, j] = 0;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int row = B.GetLength(0);
        int col = B.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (B[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        int max_1 = Int32.MinValue;
        int maxj_1 = 0;
        int max_2 = Int32.MinValue;
        int maxj_2 = 0;
        for (int i = 0; i < row; i += 2) {
            max_1 = Int32.MinValue;
            max_2 = Int32.MinValue;
            for (int j = 0; j < col; j++) {
                if (B[i,j] > max_1) {
                    max_1 = B[i,j];
                    maxj_1 = j;
                }
            }
            for (int j = 0; j < col; j++) {
                if (B[i+1, j] > max_2) {
                    max_2 = B[i+1, j];
                    maxj_2 = j;
                }
            }
            B[i, maxj_1] = max_2;
            B[i+1, maxj_2] = max_1;
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int row = A.GetLength(0);
        int col = A.GetLength(1);
        int[,] answer = default(int[,]);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {
            int j = 0;
            for (j = 0; j < col; j++) {
                if (A[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return answer;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col/2; j++) {
                int P = A[i, j];
                A[i, j] = A[i, col - j-1];
                A[i,col-j-1] = P;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        bool continueProgram = false;
        for (int i = 0; i < row; i++) {            
            for (int j = 0; j < col; j++) {
                if (matrix[i, j] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < row-i-1; j++) {
                int minCurrent = int.MaxValue;
                int minNext = int.MaxValue;
                for (int k = 0; k < col ; k++) {
                    minCurrent = matrix[j,k]<minCurrent ? matrix[j,k] : minCurrent;
                }
                for (int k = 0; k < col; k++) {
                    minNext = matrix[j+1, k] < minNext ? matrix[j+1, k] : minNext;
                }

                if (minCurrent < minNext) {
                    int[] buff = new int[col];
                    for (int k = 0; k < col; k++)
                        buff[k] = matrix[j,k];
                    for (int k = 0; k < col; k++) 
                        matrix[j, k] = matrix[j + 1, k];                                                                                   
                    for (int k = 0; k < col; k++) 
                        matrix[j + 1, k] = buff[k];
                }
            }
        }
            // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        bool continueProgram = false;
        for (int q = 0; q < row; q++) {            
            for (int m = 0; m < col; m++) {
                if (matrix[q, m] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;

        int border = 0;
        if (row > col) {
            border = row;
        }
        else {
            border = col;
        }       
        for (int k = 0; k < border; k++) {
            matrix[0, k % col] = 0;
            matrix[k % row, 0] = 0;
            matrix[k % row, col - 1] = 0;
            matrix[row - 1, k % col] = 0;
        }
        // end                
        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        
        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        bool continueProgram = false;
        for (int q = 0; q < row; q++) {
            for (int m = 0; m < col; m++) {
                if (matrix[q, m] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;

        for (int i = row/2; i < row; i++) {
            for (int j = 0; j <= i; j++) {
                matrix[i, j] = 1;
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

        // code here
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        bool continueProgram = false;
        for (int q = 0; q < row; q++) {
            for (int m = 0; m < col; m++) {
                if (matrix[q, m] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return (upper, lower);

        upper = new int[(row*col)/2 + row/2];
        lower = new int[(row * col) / 2 - row / 2];
        int c = 0;
        for (int i = 0; i < row; i++) {
            for (int j = i; j < col; j++) {
                Console.Write(matrix[i, j] + " ");                 
                upper[c] = matrix[i, j];
                c ++;
            }
            Console.WriteLine();
        }
        c = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < i; j++) {
                Console.Write(matrix[i, j] + " ");
                lower[c] = matrix[i, j];
                c++;
            }
            Console.WriteLine();
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);        
        bool continueProgram = false;
        for (int q = 0; q < rows; q++) {
            for (int m = 0; m < cols; m++) {
                if (matrix[q, m] != 0) {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < rows - i - 1; j++) {
                int countCurrent = 0;
                int countNext = 0;
                for (int p = 0; p < cols; p++) {
                    if (matrix[j, p] > 0)
                        countCurrent++;
                    if (matrix[j + 1, p] > 0)
                        countNext++;
                }
                if (countCurrent < countNext) {
                    int[] temp = new int[cols];
                    for (int p = 0; p < cols; p++) {
                        temp[p] = matrix[j, p];
                        matrix[j, p] = matrix[j + 1, p];
                        matrix[j + 1, p] = temp[p];
                    }
                }
            }
        }
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int a = 0; a < rows; a++) {
            for (int i = 0; i < cols - 1; i++) {
                for (int j = 0; j < cols - i - 1; j++) {

                    if (a % 2 == 0) {
                        if (matrix[a, j] < matrix[a, j + 1]) {
                            int temp = matrix[a, j];
                            matrix[a, j] = matrix[a, j + 1];
                            matrix[a, j + 1] = temp;
                        }
                    }
                    else {
                        if (matrix[a, j] > matrix[a, j + 1]) {
                            int temp = matrix[a, j];
                            matrix[a, j] = matrix[a, j + 1];
                            matrix[a, j + 1] = temp;
                        }
                    }


                }
            }
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        // code here
        int count = 0;
        bool found = false;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    count++;
                    found = true;
                    break;
                }
            }
            if (found) {
                found = false;
                continue;
            }
        }

        int index = 0;
        int[,] tempArray = new int[rows - count, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {                   
                    found = true;
                    break;
                }
                tempArray[index, j] = matrix[i, j];
            }
            if (found) {
                found = false;
                continue;
            }
            index++;
            if (index >= rows - count)
                break;
        }
        matrix = tempArray;

        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);

        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    
    #endregion
}