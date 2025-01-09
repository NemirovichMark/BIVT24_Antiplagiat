using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) { return 0; }
        for (int i = 0; i < 4; i++) {
            answer += A[i, i];
        }
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int[] answer = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int minn = 100000;
            for (int j = 0; j < 7; j++)
            {
                if (A[i,j] < minn)
                {
                    minn = A[i, j];
                    answer[i] = j;
                }
            }
        }
        


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
 

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int ind = -1;
            int maxx = -1000000;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxx){
                    maxx = A[i, j];
                    ind = j;
                }
            }
            int temp = A[i, ind];
            A[i, ind] = A[i, 0];
            A[i, 0] = temp;
        }

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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        

        int maxx = -20000;
        int indI = -1, indJ = -1;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxx) {
                    maxx = A[i, j];
                    indI = i; indJ = j;
                }
            }
        }
        int[,] answer = new int[5, 6];
        int i1 = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == indI) continue;
            int j1 = 0;
            for (int j = 0; j < 7; j++)
            {
                if (j == indJ) continue;
                
                answer[i1,j1] = A[i, j];
                j1++;   
            }
            i1++;
        }
        return answer; 
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int ind = -1;
            int maxx = -1000000;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxx)
                {
                    maxx = A[i, j];
                    ind = j;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                if ( j == ind)
                {
                    A[i, j] *= i + 1;
                }
            }
            
        }
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
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            int indmax = -1; int maxx = -10000;
            int indLastOtr = -1, indFirstotr = -1;

            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    indLastOtr = j;
                    break;
                }
            }

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    indFirstotr = j;
                    break;
                }
            }

            if (indFirstotr == -1) continue;

            for (int j = 0; j < indFirstotr; j++)
            {
                if (D[i, j] > maxx)
                {
                    maxx = D[i, j];
                    indmax = j;
                }
            }
            if (indmax != -1)
            {
                int temp = D[i, indmax];
                D[i, indmax] = D[i, indLastOtr];
                D[i, indLastOtr] = temp;

            }
        }

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
        
        
        //В матрице Н размера 5 × 7 заполнены первые 6 столбцов.
        //Поместить в качестве предпоследнего столбца столбец, состоящий из максимальных элементов строк.
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int maxx = -1000000;
            for (int j = 0; j < 7; j++)
            {
                if (H[i,j] > maxx)
                {
                    maxx = H[i,j]; 
                }
            }
            int temp = H[i, 5];
            H[i, 5] = maxx;
            H[i, 6] = temp;

        }
        
        
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
        //матрице Y размера 6 × 5 в каждой строке заменить отрицательные элементы,
        //расположенные перед максимальным, на среднее среди положительных элементов,
        //расположенных после максимального.

        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;

        for (int i = 0; i < 6; i++)
        {
            double maxx = -1000000;
            int ind = -1;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > maxx)
                {
                    maxx = Y[i, j]; ind = j;
                }
            }
            double amount = 0; double summ = 0;
            for (int z = ind + 1; z < 5; z++)
            {
                if (Y[i, z] > 0) {
                    amount += 1; summ += Y[i, z];
                }
            }
            double sr_sum = 0;
            if (amount == 0) {sr_sum = 0;} else { sr_sum = summ / amount; }

            
            for (int l = 0; l < ind; l++)
            {
                if (Y[i, l] < 0)
                {
                    Y[i, l] = sr_sum;
                }
            }

        }
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
        int n = B.GetLength(0); int m = B.GetLength(1);
        if (n != 5 || m != 7) return null;
        for (int i = 0; i <= n / 2; i++)
        {
            int max1 = B[i, 0]; int max1_index = 0;
            int max2 = B[n - i - 1, 0]; int max2_index = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    max1_index = j;
                }
                if (B[n - i - 1, j] > max2)
                {
                    max2 = B[n - i - 1, j];
                    max2_index = j;
                }
            }
            int temp = max2;
            B[n - i - 1, 3] = max1;
            B[i, 3] = temp;
        }
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
        //Строку, содержащую максимальный элемент главной диагонали матрицы
        //В размера 5 × 5 поменять местами со строкой,
        //содержащей первый (от начала столбца) отрицательный элемент в 3-м столбце.
        if (B.GetLength(0) != 5 && B.GetLength(1) != 5) return null;
        int maxx = -100000; int ind = -1;
        for (int i = 0; i < B.GetLength(1); i++)
        {
            if (B[i,i] > maxx)
            {
                maxx = B[i, i];
                ind = i;
            }
        }
        int str = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i,2] < 0)
            {
                str = i; break;
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j =  0; j < B.GetLength(1); j++)
            {
                int temp = B[ind,j];
                B[ind,j] = B[str,j] ;
                B[str,j] = temp ;
            }
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int amount = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0) { amount++; }


            }
        }
        if (amount == 0) return null;
        int[] answer = new int[amount];
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[k] = A[i, j];
                    k++;
                }
            }
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {

        int n = A.GetLength(0);
        int m = A.GetLength(1);

        if (n != 5 || m != 7)
            return null;

        int maxElCol;
        double maxEl;

        for (int row = 0; row < n; row++)
        {
            maxEl = -1000000000000000;
            maxElCol = 0;

            for (int col = 0; col < m; col++)
            {
                if (A[row, col] <= maxEl)
                    continue;
                maxEl = A[row, col];
                maxElCol = col;
            }

            if (maxElCol == 0)
                if (A[row, 1] > 0)
                    A[row, 1] *= 2.0;
                else
                    A[row, 1] /= 2.0;
            else if (maxElCol == 6)
                if (A[row, 5] > 0)
                    A[row, 5] *= 2.0;
                else
                    A[row, 5] /= 2.0;
            else
            {
                if (A[row, maxElCol - 1] > A[row, maxElCol + 1])
                    if (A[row, maxElCol + 1] > 0)
                        A[row, maxElCol + 1] *= 2.0;
                    else
                        A[row, maxElCol + 1] /= 2.0;
                else if (A[row, maxElCol + 1] > A[row, maxElCol - 1])
                    if (A[row, maxElCol - 1] > 0)
                        A[row, maxElCol - 1] *= 2.0;
                    else
                        A[row, maxElCol - 1] /= 2.0;
            }
        }
        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        //Дана матрица A размера 7 × 5.
        //Если количество положительных элементов столбца больше количества отрицательных,
        //то максимальный элемент этого столбца заменить на 0,
        //в противном случае максимальный элемент заменить на номер максимального элемента
        //этого столбца .

        int n = A.GetLength(0); int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;

        for (int j = 0; j < m; j++)
        {
            int max = A[0, j];
            int max_index = 0;
            int count = 0;
            int count0 = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    max_index = i;
                }
                if (A[i, j] > 0)
                    count++;
                else if (A[i, j] < 0)
                    count0++;
            }
            if (count > count0)
                A[max_index, j] = 0;
            else
                A[max_index, j] = max_index+1;
        }
        return A;

        }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int max_index = 0;
            int summa = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    max_index = i;
                    summa = 0;
                }
                else
                    summa += A[i, j];
            }
            if (max_index <= A.GetLength(0) / 2)
            {
                A[0, j] = summa;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++) {
            int maxx = A[0,j];
            int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maxx < A[i, j])
                {
                    maxx = A[i, j];
                    ind = i;
                }
            
            }
            int el_zamena = B[j];
            if (el_zamena > maxx)
            {
                A[ind, j] = el_zamena;
            }
        }



        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxx = A[0,j];
            int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (maxx < A[i, j])
                {
                    maxx = A[i, j];
                    ind = i;
                }
            }
            double summ = (A[0, j] + A[A.GetLength(0)-1, j])/2;
            if (maxx < summ)
            {
                A[ind,j] = summ;
            }
            else
            {
                A[ind, j] = ind + 1;
            }
        }

        return A;

    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;
        int[,] A = new int[n,3*n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3*n; j++)
            {
                A[i, j] = 0;
            }
        }
        int k = -1;
        for (int i = 0; i < n; i++)
        {
            k++;
            for (int j = k; j < 3*n;)
            {
                A[i, j] = 1;
                j += 3;
            }
        }
        

        return A;
    }
    public int[,] Task_2_7(int[,] A)
    {

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int maxx = -1000000000;
        int ind = -1;
        for (int i = 0; i < 6; i++)
        {
            if (maxx < A[i, i])
            {
                maxx = A[i, i];
                ind = i;
            }
        }
        for (int i = 0; i < ind; i++)
        {
            for (int j = i + 1; j < 6; j++)
            {
                A[i, j] = 0;
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if  (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;

        for (int i = 0; i < 6; i+=2)
        {
            int max1 = -1000000000;int ind1 = -1;
            int max2 = -1000000000;int ind2 = -1;
            for (int j = 0; j < 6; j++) {
                if (max1 < B[i, j])
                {
                    max1 = B[i, j];
                    ind1 = j;
                }
                if (max2< B[i+1, j])
                {
                    max2 = B[i+1, j];
                    ind2 = j;
                }
            }
            int temp = B[i, ind1];
            B[i,ind1] = B[i+1, ind2];
            B[i+1,ind2] = temp;
        }


        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {

        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 7  - j - 1];
                A[i, 7  - j - 1] = temp;
            }
        }

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
        int rI = matrix.GetLength(0);
        int rJ = matrix.GetLength(1);
        if (rI != rJ) return null;

        for (int i = 0; i < rI; i++)
        {
            if (i == 0 || i == rI - 1) {
                for (int j = 0; j < rJ; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            matrix[i, 0] = 0;
            matrix[i, rJ-1] = 0;
        }

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] A)
    {
        int rI = A.GetLength(0);
        int rJ = A.GetLength(1);
        if (rI != rJ) return null;

        for (int i = rI / 2; i < rI; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                A[i, j] = 1;
            }
        }


        return A;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] A)
    {
        int[] upper = default(int[]); // главная диагональ и слева от нее
        int[] lower = default(int[]); //  все что ниже

        int rI = A.GetLength(0);
        int rJ = A.GetLength(1);
        if (rI != rJ) { return default; }


        int el = 0;
        int le = 0;
        for (int i = 0; i < rI; i++)
        {
            for (int j = 0; j < rJ; j++)
            {
                if (j >= i)
                {
                    el++;
                }
                else
                {
                    le++;
                }
            }
        }
        upper = new int[el];
        lower = new int[le];
        int k = 0;
        int k1 = 0;
        for (int i = 0; i < rI; i++)
        {
            for (int j = 0; j < rJ; j++)
            {
                if (j >= i)
                {
                    upper[k++] = A[i, j];
                    
                }
                else
                {
                    lower[k1++] = A[i, j];
                }
            }
        }

        for (int i = 0;i < k1; i++) {
            Console.Write(lower[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            Console.Write(upper[i] + " ");
        }

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] A)
    {

        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) - i - 1; j++)
            {
                int curr = 0, next = 0;
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    if (A[j, k] > 0)
                    {
                        curr++;
                    }
                    if (A[j + 1, k] > 0)
                    {
                        next++;
                    }

                }
                if (curr < next)
                {
                    for (int  w = 0; w < A.GetLength(1); w++)
                    {
                        int temp = A[j, w];
                        A[j, w] = A[j + 1, w];
                        A[j + 1, w] = temp;
                    }
                }
            }
        }
        return A;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {

        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {

        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;

        int amount = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] == 0) { amount++; break;}
            }
        }
        int[,] matrix1 = new int[5 - amount, 7];
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (matrix[i, j] == 0) break;
                matrix1[k, j] = matrix[i, j];
            }
            k++;
            if (k >= 5 - amount) break;
        }
        return matrix1;
    }
    #endregion
}