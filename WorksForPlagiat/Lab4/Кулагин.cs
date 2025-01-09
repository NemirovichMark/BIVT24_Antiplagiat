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
        program.Task_2_1(new double[,]{
            { 1, 2, -3, 7, -5, 7, 7 },
            { 5, 6, -7, 8, 9, 9, -11 },
            { 9, 10, 11, 12, 13, 15, 15 },
            { -13, -30, 25, 25, 16, 17, -19 },
            { -6, -5, -1, -2, -3, -4, -6 }
        });
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return 0;
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0) answer += A[i, j];
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
        if (A.GetLength(0) != 4 && A.GetLength(1) != 4) return 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j == i) answer += A[i, j];
            }
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
        int[] arr = new int[4];
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7) return answer;
        
        for (int i = 0; i < 4; i++)
        {
            int minElement = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < minElement)
                {
                    minElement = A[i, j];
                    index = j;
                }
            }

            arr[i] = index;
        }

        answer = arr;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int maxElement = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    index = j;
                }
            }
            A[i, index] = A[i, 0];
            A[i, 0] = maxElement;
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
        if (A.GetLength(0) != 6 && A.GetLength(1) != 7) return null;
        
        int maxElement = A[0, 0];
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i < 6; i++)
        {
            int foo = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > foo)
                {
                    foo = A[i, j];
                    index = j;
                }
            }

            if (foo > maxElement)
            {
                maxElement = foo;
                index1 = i;
                index2 = index;
            }
        }

        int[,] arr = new int[5, 6];
        
        int ii = 0;
        for (int i = 0; i < 6; i++)
        {
            int jj = 0;
            if (i == index1) continue;
            for (int j = 0; j < 7; j++)
            {
                if (j == index2) continue;
                arr[ii, jj] = A[i, j];
                jj++;
            }

            ii++;
        }

        A = arr;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int foo = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > foo)
                {
                    foo = A[i, j];
                    index = j;
                }
            }

            A[i, index] *= (i+1);
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
        if (D.GetLength(0) != n && D.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            bool isTrue = false;
            int foo = -9999;
            int index = -1;

            int bar = 0;
            int index2 = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    isTrue = true;
                    bar = D[i, j];
                    index2 = j;
                }

                if (D[i, j] > foo && !isTrue)
                {
                    foo = D[i, j];
                    index = j;
                }
            }
            if (index2 == -1 || index == -1) continue;
            D[i, index] = bar;
            D[i, index2] = foo;
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
        if (H.GetLength(0) != 5 && H.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int foo = H[i, 0];
            int index = 0;

            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > foo)
                {
                    foo = H[i, j];
                    index = j;
                }
            }

            H[i, 6] = H[i, 5];
            H[i, 5] = foo;
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
        if (Y.GetLength(0) != 6 && Y.GetLength(1) != 5) return null;
        
        for (int i = 0; i < 6; i++)
        {
            double maxFoo = Y[0, 0];
            int index = -1;

            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > maxFoo)
                {
                    maxFoo = Y[i, j];
                    index = j;
                }
            }

            int count = 0;
            double summa = 0;
            for (int j = index + 1; j < 5; j++)
            {
                if (Y[i, j] > 0)
                {
                    summa += Y[i, j];
                    count++;
                }
            }

            if (count > 0) summa /= count;
            for (int j = 0; j < index; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = summa;
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
        int[] arr = new int[5];
        
        if (B.GetLength(0) != 5 && B.GetLength(1) != 7) return null;

        int index = 0;
        for (int i = 4; i >= 0; i--)
        {
            int maxFoo = B[i, 0];
            for (int j = 0; j < 7; j++)
            {
                maxFoo = Math.Max(B[i, j], maxFoo);
            }

            arr[index] = maxFoo;
            index++;
        }

        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = arr[i];
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
        if (B.GetLength(0) != 5 && B.GetLength(1) != 5) return null;

        int maxMaxFoo = -9999;
        int index = 0;
        
        int numBar = 0;
        bool isTrue = false;

        for (int i = 0; i < 5; i++)
        {
            int maxFoo = 0;
            int maxFooIndex = -1;
            for (int j = 0; j < 5; j++)
            {
                if (i == j && maxFoo < B[i, j])
                {
                    maxFoo = B[i, j];
                    maxFooIndex = j;
                }

                if (j == 2 && !isTrue)
                {
                    numBar = i;
                    isTrue = true;
                }
            }

            if (maxMaxFoo < maxFoo)
            {
                maxMaxFoo = maxFoo;
                index = maxFooIndex;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            int temp = B[index, i];
            B[index, i] = B[numBar, i];
            B[numBar, i] = temp;
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }

        int[] arr = new int[count];
        int index = 0;
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    arr[index] = A[i, j];
                    index++;
                }
            }
        }

        answer = arr;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            double maxFoo = A[i, 0];
            int index = 0;

            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxFoo)
                {
                    maxFoo = A[i, j];
                    index = j;
                }
            }
            
            if (index == 0)
            {
                if (A[i, index + 1] < 0) A[i, index + 1] /= 2;
                else A[i, index + 1] *= 2;
                continue;
            }
            if (index == 6)
            {
                if (A[i, index - 1] < 0) A[i, index - 1] /= 2;
                else A[i, index - 1] *= 2;
                continue;
            }

                if (A[i, index - 1] < A[i, index + 1])
                {
                    if (A[i, index - 1] < 0) A[i, index - 1] /= 2;
                    else A[i, index - 1] *= 2;
                }
                else
                {
                    if (A[i, index + 1] < 0) A[i, index + 1] /= 2;
                    else A[i, index + 1] *= 2;
                }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            double maxFoo = A[0, i];
            int index = 0;

            int countFoo = 0;
            int countBar = 0;
            
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxFoo)
                {
                    maxFoo = A[j, i];
                    index = j;
                }

                if (A[j, i] > 0) countFoo++;
                if (A[j, i] < 0) countBar++;
            }

            if (countFoo > countBar) A[index, i] = 0;
            else A[index, i] = index + 1;
        }
        // end
        
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 && A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++)
        {
            double maxFoo = A[0, i];
            int index = 0;

            int summa = 0;
            
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > maxFoo)
                {
                    maxFoo = A[j, i];
                    index = j;
                }
            }

            if (index < 5)
            {
                A[0, i] = 0;
                for (int j = index + 1; j < 10; j++)
                {
                    A[0, i] += A[j, i];
                }
            }
        }
        // end

        return A;
    }

    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.GetLength(0) != 5) return null;

        for (int i = 0; i < 5; i++) {
            int maxFoo = A[0, i];
            int index = 0;
            
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxFoo)
                {
                    maxFoo = A[j, i];
                    index = j;
                }
            }

            if (B[i] > maxFoo) A[index, i] = B[i];
        }

    // end

    return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int i = 0; i < 5; i++) {
            double maxFoo = A[0, i];
            int index = 0;
            
            for (int j = 0; j < 7; j++)
            {
                if (A[j, i] > maxFoo)
                {
                    maxFoo = A[j, i];
                    index = j;
                }
            }

            if ((A[0, i] + A[4, i]) / 2 > maxFoo) A[index, i] = (A[0, i] + A[A.Length - 1, i]) / 2;
            else A[index, i] = index + 1;
        }
        // end

        return A;
    }

    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 0) return null;
        int[,] arr = new int[n, 3 * n];

        for (int z = 0; z < n; z++)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j) arr[i, j + 3 * z] = 1;
                    else arr[i, j + 3 * z] = 0;
                }
            }
        }
        
        answer = arr;
        return answer;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;

        int maxFoo = A[0, 0];
        int index = 0;
        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++)
            {
                if (i == j && A[i, j] > maxFoo)
                {
                    maxFoo = A[i, j];
                    index = i;
                }
            }
        }

        for (int i = 0; i < index; i++)
        {
            for (int j = i + 1; j < 6; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        
        for (int i = 0; i < 6; i += 2) {
            int maxFoo1 = B[i, 0];
            int maxFoo2 = B[i + 1, 0];
            int index1 = 0;
            int index2 = 0;
            
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxFoo1)
                {
                    maxFoo1 = B[i, j];
                    index1 = j;
                }
                if (B[i + 1, j] > maxFoo2)
                {
                    maxFoo2 = B[i + 1, j];
                    index2 = j;
                }
            }

            B[i, index1] = maxFoo2;
            B[i + 1, index2] = maxFoo1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0, k = 6; j < 4; j++, k--)
            {
                int temp = A[i, j];
                A[i, j] = A[i, k];
                A[i, k] = temp;
            }
        }
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

        int index = 0;
        int count = 0;
        while (count < 4) {
            if (index == matrix.GetLength(0))
            {
                index = 0;
                count++;
                continue;
            }
            
            switch (count)
            {
                case 0:
                    matrix[0, index] = 0;
                    break;
                case 1: matrix[matrix.GetLength(0) - 1, index] = 0;
                    break;
                case 2: matrix[index, matrix.GetLength(0) - 1] = 0;
                    break;
                case 3: matrix[index, 0] = 0;
                    break;
            }

            index++;
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

        int count = 0;
        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++) {
            for (int j = 0; j <= i; j++)
            {
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);

        int len1 = 0;
        int len2 = 0;
        int count1 = 0; 
        int count2 = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = i; j < matrix.GetLength(0); j++)
            {
                len1++;
            }
            for (int j = 0; j < i; j++)
            {
                len2++;
            }
        }
        
        int[] arr = new int[len1];
        int[] arr2 = new int[len2];
        
        Console.WriteLine("{0} {1}", len1, len2);
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = i; j < matrix.GetLength(0); j++)
            {
                Console.WriteLine("{0} {1}", i, j);

                arr[count1] = matrix[i, j];
                count1++;
            }
            for (int j = 0; j < i; j++)
            {
                arr2[count2] = matrix[i, j];
                count2++;
            }
        }
        //
        // for (int i = 0; i < arr.GetLength(0); i++)
        // {
        //     Console.Write("{0} ", arr[i]);
        // }
        // Console.WriteLine();
        // for (int i = 0; i < arr2.GetLength(0); i++)
        // {
        //     Console.Write("{0} ", arr2[i]);
        // }
        
        upper = arr;
        lower = arr2;
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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5) return null;

        int[] arr = new int[7];
        for (int i = 0; i < 7; i++)
        {
            int count = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0) count++;
            }

            arr[i] = count;
        }
        
        for (int i = 0; i < 7; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                int summa1 = 0;
                int summa2 = 0;
                if (arr[i] == arr[j])
                {
                    for (int k = 0; k < 5; k++)
                    {
                        summa1 += matrix[i, k];
                        summa2 += matrix[j, k];
                    }   
                }
                if (arr[i] < arr[j] || (arr[i] == arr[j] && summa1 > summa2))
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }

                    int temp2 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp2;
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
        //if (matrix.GetLength(0) !=  && matrix.GetLength(1) != ) return null;

        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if ((k % 2 != 0 && matrix[k, i] > matrix[k, j]) || (k % 2 == 0 && matrix[k, i] < matrix[k, j]))
                    {
                        int temp = matrix[k, i];
                        matrix[k, i] = matrix[k, j];
                        matrix[k, j] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();

        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int count = 0;
        
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            bool isTrue = false;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[k, i] == 0) isTrue = true;
            }

            if (!isTrue) count++;
        }

        int[,] arr = new int[count, matrix.GetLength(1)];

        int foo = 0;
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            bool isTrue = false;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[k, i] == 0) isTrue = true;
            }

            if (!isTrue)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    arr[foo, j] = matrix[k, j];
                }

                foo++;
            }
        }

        matrix = arr;
        // end

        return matrix;
    }
    #endregion
}