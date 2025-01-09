using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_3_9(new int[,] {{ 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            });
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7) {
            return answer;
        }
        for(int i = 0; i < 5; ++i) {
            for(int j = 0; j < 7; ++j) {
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
        // code here
        if(A.GetLength(0) != 3 || A.GetLength(1) != 6) {
            return (row, col);
        }
        int minimum = A[0, 0];
        for(int i = 0; i < 3; ++i) {
            for(int j = 0; j < 6; ++j) {
                if(A[i, j] < minimum) {
                    minimum = A[i, j];
                    row = i; col = j;
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
        if(A.GetLength(0) != 3 || A.GetLength(1) != 5) {
            return answer;
        }
        answer = new int[5];
        for(int i = 0; i < 5; ++i) {
            int maximum = A[0, i];
            for(int j = 0; j < 3; ++j) {
                if(A[j, i] > maximum) {
                    maximum = A[j, i];
                }
            }
            answer[i] = maximum;
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
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7) {
            return null;
        }

        int ind = 0, maximum = A[0, 2];
        for(int i = 0; i < 5; ++i) {
            if(A[i, 2] > maximum) {
                ind = i;
                maximum = A[i, 2];
            }
        }
        for(int i = 0; i < 7; ++i) {
            int temp = A[3, i];
            A[3, i] = A[ind, i];
            A[ind, i] = temp;
        }
        // end
        for(int i = 0; i < 5; ++i) {
            for(int j = 0; j < 7; ++j) {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
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
        // code here
        if(A.GetLength(0) != 5 || A.GetLength(1) != 5) {
            return null;
        }
        int num = 0, maximum = A[0, 0];
        for(int i = 0; i < 5; ++i) {
            if(A[i, i] > maximum) {
                maximum = A[i, i];
                num = i;
            }
        }
        for(int i = 0; i < 5; ++i) {
            int p = A[i, num];
            A[i, num] = A[i, 3];
            A[i, 3] = p;
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
        if(A.GetLength(0) != n || A.GetLength(1) != m) {
            return null;
        }
        for(int i = 0; i < n; ++i) {
            int maximum = A[i, 0], ind = 0;
            for(int j = 0; j < m; ++j) {
                if(A[i, j] > maximum) {
                    maximum = A[i, j];
                    ind = j;
                }
            }
            for(int j = ind; j < m - 1; ++j) {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = maximum;
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
        if(C.GetLength(0) != n || C.GetLength(1) != m) {
            return null;
        }
        for(int i = 0; i < n; ++i) {
            double maximum = C[i, 0];
            int ind = 0;
            for(int j = 0; j < m; ++j) {
                if(C[i, j] > maximum) {
                    maximum = C[i, j];
                    ind = j;
                }
            }
            for(int j = 0; j < ind; ++j) {
                if(C[i, j] < 0) {
                    C[i, j] /= maximum;
                    Console.WriteLine(C[i, j]);
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
        if(Z.GetLength(0) != 6 || Z.GetLength(1) != 8) {
            return null;
        }
        double sum = 0, maximum = Z[0, 0], num = 0;
        int ind1 = 0, ind2 = 0;
        for(int i = 0; i < 6; ++i) {
            for(int j = 0; j < 8; ++j) {
                if(Z[i, j] > 0) {
                    sum += Z[i, j];
                    ++num;
                }
                if(Z[i, j] > maximum) {
                    ind1 = i; ind2 = j;
                    maximum = Z[i, j];
                }
            }   
        }
        if(num > 0) {
            Z[ind1, ind2] = sum / num;
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
        if(X.GetLength(0) != 6 || X.GetLength(1) != 5) {
            return null;
        }
        int indstrmin = 0, indstrmax = 0, minimum = 10, maximum = -1;
        for(int i = 0; i < 6; ++i) {
            int neg = 0;
            for(int j = 0; j < 5; ++j) {
                if(X[i, j] < 0) {
                    ++neg;
                }
            }
            if(neg < minimum) {
                minimum = neg;
                indstrmin = i;
            }
            if(neg > maximum) {
                maximum = neg;
                indstrmax = i;
            }
        }
        for(int j = 0; j < 5; ++j) {
            int temp = X[indstrmin, j];
            X[indstrmin, j] = X[indstrmax, j];
            X[indstrmax, j] = temp;
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
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5) {
            return null;
        }
        int ind = 0, sum = 0;
        for(int i = 0; i < 7; ++i) {
            int pos = 0;
            for(int j = 0; j < 5; ++j) {
                if(A[i, j] > 0) {
                    pos += A[i, j];
                }
            }
            if(pos > sum) {
                ind = i;
                sum = pos;
            }
        }
        int[,] B = new int[6, 5];
        int now = 0;
        for(int i = 0; i < 7; ++i) {
            if(i == ind) {
                    continue;
                }
            for(int j = 0; j < 5; ++j) {
                B[now, j] = A[i, j];
            }
            ++now;
        }
        A = B;
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
         if(A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) {
            return null;
        }
        int ind = 0, minimum = A[4, 0];
        for(int j = 0; j < 7; ++j) {
            if(A[4, j] < minimum) {
                minimum = A[4, j];
                ind = j;
            }
        }
        for(int i = 0; i < 5; ++i) {
            for(int j = ind + 1; j < 8; ++j) {
                int temp = A[i, j];
                A[i, j] = B[i];
                B[i] = temp;
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
        // code here
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7) {
            return null;
        }
        for(int i = 0; i < 5; ++i) {
            int ind = 0;
            double maximum = A[i, 0];
            for(int j = 0; j < 7; ++j) {
                if(A[i, j] > maximum) {
                    ind = j;
                    maximum = A[i, j];
                }
            }
            int ind_change = -1;
            if(ind == 0) {
                ind_change = 1;
            } else if(ind == 6) {
                ind_change = 5;
            } else {
                if(A[i, ind - 1] <= A[i, ind + 1]) {
                    ind_change = ind - 1;
                } else {
                    ind_change = ind + 1;
                }
            }
            if(A[i, ind_change] < 0) {
                A[i, ind_change] /= 2;
            } else {
                A[i, ind_change] *= 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5) {
            return null;
        }
        for(int j = 0; j < 5; ++j) {
            int pos = 0, neg = 0, maximum = A[0, j], ind = 0;
            for(int i = 0; i < 7; ++i) {
                if(A[i, j] < 0) {
                    ++neg;
                } else if(A[i, j] > 0) {
                    ++pos;
                }
                if(A[i, j] > maximum) {
                    ind = i;
                    maximum = A[i, j];
                }
            }
            if(pos > neg) {
                A[ind, j] = 0;
            } else {
                A[ind, j] = ind + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if(A.GetLength(0) != 10 || A.GetLength(1) != 5) {
            return null;
        }
        for(int j = 0; j < 5; ++j) {
            int ind = 0, sum = 0, maximum = A[0, j];
            for(int i = 0; i < 10; ++i) {
                if(ind >= 5) {
                    break;
                }
                sum += A[i, j];
                if(A[i, j] > maximum) {
                    sum = 0;
                    maximum = A[i, j];
                    ind = i;
                }
            }
            if(ind >= 5) {
                continue;
            } else {
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) {
            return null;
        }
        for(int j = 0; j < 5; ++j) {
            int ind = 0, maximum = A[0, j] - 1;
            for(int i = 0; i < 7; ++i) {
                if(A[i, j] > maximum) {
                    maximum = A[i, j];
                    ind = i;
                }
            }
            if(A[ind, j] < B[j]) {
                A[ind, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5) {
            return null;
        }
        for(int j = 0; j < 5; ++j) {
            int ind = 0;
            double maximum = A[0, j];
            for(int i = 0; i < 7; ++i) {
                if(A[i, j] > maximum) {
                    maximum = A[i, j];
                    ind = i;
                }
            }
            if(maximum < (A[0, j] + A[6, j]) / 2) {
                A[ind, j] = (A[0, j] + A[6, j]) / 2;
            } else {
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
        if(n <= 0) {
            return null;
        }
        answer = new int[n, 3*n];
        for(int k = 0; k < 3; ++k) {
            for(int i = 0; i < n; ++i) {
                answer[i, k * n + i] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if(A.GetLength(0) != 6 || A.GetLength(1) != 6) {
            return null;
        }
        int maximum = A[0, 0], ind = 0;
        for(int i = 0; i < 6; ++i) {
            if(A[i, i] > maximum) {
                maximum = A[i, i];
                ind = i;
            }
        }
        for(int i = 0; i < ind; ++i) {
            for(int j = i + 1; j < 6; ++j) {
                A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if(B.GetLength(0) != 6 || B.GetLength(1) != 6) {
            return null;
        }
        int ind1 = 0, ind2 = 0;
        for(int i = 0; i < 6; ++i) {
            int maximum = B[i, 0] - 1;
            for(int j = 0; j < 6; ++j) {
                if(B[i, j] > maximum) {
                    maximum = B[i, j];
                    if(i % 2 == 0) {
                        ind1 = j;
                    } else {
                        ind2 = j;
                    }
                }
            }
            if(i % 2 == 1) {
                int temp = B[i - 1, ind1];
                B[i - 1, ind1] = B[i, ind2];
                B[i, ind2] = temp;
            } 
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if(A.GetLength(0) != 6 || A.GetLength(1) != 7) {
            return null;
        }
        for(int i = 0; i < 6; ++i) {
            for(int j = 0; j < 3; ++j) {
                int temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if(matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) {
            return null;
        }
        int[] vec = new int[7];
        for(int i = 0; i < 7; ++i) {
            int minimum = matrix[i, 0] + 1;
            for(int j = 0; j < 5; ++j) {
                if(matrix[i, j] < minimum) {
                    minimum = matrix[i, j];
                }
            }
            vec[i] = minimum;
        }
        for(int k = 0; k < 7; ++k) {
            for(int i = 0; i < 6 - k; ++i) {
                if(vec[i] < vec[i + 1]) {
                    for(int j = 0; j < 5; ++j) {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i + 1, j];
                        matrix[i + 1, j] = temp;
                    }
                    int t = vec[i];
                    vec[i] = vec[i + 1];
                    vec[i + 1] = t;
                }
            }
        }
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
        if(matrix.GetLength(0) != matrix.GetLength(1)) {
            return null;
        }
        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < n; ++j) {
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
        --k;
        if(k < 0 || n != matrix.GetLength(1)) {
            return null;
        }
        int maximum = int.MinValue, ind1 = 0, ind2 = 0;
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < n; ++j) {
                if(Math.Abs(matrix[i, j]) > maximum) {
                    ind1 = i; ind2 = j;
                    maximum = Math.Abs(matrix[i, j]);
                }
            }
        }
        if (ind1 != k) {
            for (int j = 0; j < n; ++j) {
                int temp = matrix[k, j];
                matrix[k, j] = matrix[ind1, j];
                matrix[ind1, j] = temp;
            }
        }
        if (ind2 != k) {
            for (int i = 0; i < n; ++i) {
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, ind2];
                matrix[i, ind2] = temp;
            }
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

    public void Print_matrix(int[,] a) {
        for(int i = 0; i < a.GetLength(0); ++i) {
            for(int j = 0; j < a.GetLength(1); ++j) {
                Console.Write(a[i, j] + "     ");
            }
            Console.WriteLine();
        }
    }

    public void Print_mass(int[] a) {
        for(int i = 0; i < a.Length; ++i) {
            Console.Write(a[i]);
        }
        Console.WriteLine();
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here
        if(A.Length != n * (n + 1) / 2 || B.Length != n * (n + 1) / 2) {
            return null;
        }
        answer = new int[n * n];
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        int ind = 0;
        for(int i = 0; i < n; ++i) {
            for(int j = i; j < n; ++j) {
                matrix1[i, j] = A[ind];
                matrix1[j, i] = A[ind];
                matrix2[i, j] = B[ind];
                matrix2[j, i] = B[ind];
                ++ind;
            }
        }
        int[,] result = new int[n, n];
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < n; ++j) {
                result[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        ind = 0;
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < n; j++) {
                answer[ind] = result[i, j];
                ++ind;
            }
        }
        Print_matrix(matrix1);
        Print_matrix(matrix2);
        Print_matrix(result);
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
        if(matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) {
            return null;
        }
        int[] vec = new int[7];
        for(int j = 0; j < 7; ++j) {
            int neg = 0;
            for(int i = 0; i < 5; ++i) {
                if(matrix[i, j] < 0) {
                    ++neg;
                }
            }
            vec[j] = neg;
        }
        for(int k = 0; k < 7; ++k) {
            for(int j = 0; j < 6 - k; ++j) {
                if(vec[j] > vec[j + 1]) {
                    int t = vec[j];
                    vec[j] = vec[j + 1];
                    vec[j + 1] = t;
                    for(int i = 0; i < 5; ++i) {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, j + 1];
                        matrix[i, j + 1] = temp;
                    }
                }
            }
        }
        Print_matrix(matrix);
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int N = n;
        bool[] vec = new bool[n];
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < m; ++j) {
                if(matrix[i, j] == 0) {
                    vec[i] = true;
                    --N;
                    break;
                }
            }
        }
        int ind = 0;
        int[,] result = new int[N, m];
        for(int i = 0; i < n; ++i) {
            if(!vec[i]) {
                for(int j = 0; j < m; ++j) {
                    result[ind, j] = matrix[i, j];
                }
                ++ind;
            }
        }
        matrix = result;
        // end

        return matrix;
    }
    #endregion
}