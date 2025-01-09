using System;
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
        program.Task_3_2(new int[,] {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
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
        //Найти след (сумму диагональных элементов) квадратной матрицы А размера 4 × 4).
        int answer = 0;
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 4) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                }
            }
        }
        Console.WriteLine(answer);
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
        //  Сформировать одномерный массив из индексов минимальных элементов строк матрицы А размера 4 × 7
        int[] answer = default(int[]);
        // code here
        int n = A.GetLength(0), m = A.GetLength (1), k = 0;
        answer = new int [n];
        if (n != 4 || m != 7) answer = default;
        else
        {
            for (int i = 0; i < n; i++)
            {
                int mini = A[i, 0];
                int indexmini = 0;
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] < mini)
                    {
                        mini = A[i, j];
                        indexmini = j;
                    }
                }
                answer[k] = indexmini;
                k++;
            }
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

        //  Поменять местами максимальный и 1-й элементы строк матрицы А размера 5 × 7. 
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            int maxi = A[i, 0], t = A[i,0];
            int indexmaxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = j;
                }
            }
            A[i, 0] = A[i, indexmaxi];
            A[i, indexmaxi] = t;
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
        //  В матрице А размера 6 × 7 удалить столбец и строку, на пересечении которых находится максимальный элемент матрицы.
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return default;
        int maxi = A[0, 0], index_i = 0, index_j = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    index_i = i;
                    index_j = j;
                }
            }
        }
        int[,] B = new int[n - 1, m];

        for (int i = 0; i < n - 1; i++) // удаляем строку
        {
            if (i < index_i)
            {
                for (int j = 0; j < m; j++) B[i, j] = A[i, j];
            }
            else
            {
                for (int j = 0; j < m; j++) B[i, j] = A[i + 1, j];
            }
        }
        int[,] B1 = new int[n - 1, m - 1];
        for (int j = 0; j < m - 1; j++) // удаляем столбец
        {
            if (j < index_j)
            {
                for (int i = 0; i < n - 1; i++) 
                    B1[i, j] = B[i, j];
            }
            else
            {
                for (int i = 0; i < n - 1; i++) B1[i, j] = B[i, j + 1];
            }
        }
        A = B1;

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
        //  Преобразовать матрицу А размера 5 × 7, умножив максимальный элемент каждой строки на номер этой строки.
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            int maxi = A[i, 0], indexmaxi = 0;

            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = j;
                }
            }
            A[i, indexmaxi] *= (i + 1); // тк нужен номер строки а не его индекс
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
        //  В каждой строке матрицы D размера n × m максимальный среди элементов, расположенных до первого отрицательного, поменять местами с последним
        //  отрицательным в этой строке.
        // code here
       for (int i = 0; i < n; i++)
        {
            int indexfirst = 0, indexlast = 0, maxi = D[i,0], indexmaxi = 0, t = D[i, indexmaxi];
            for (int j = 0; j < m; j++)// ищем индекс первого отрицательного
            {
                if (D[i,j] < 0)
                {
                    indexfirst = j;
                    break;
                }
            }
            
            for (int j = 0; j < indexfirst; j++)//ищем индекс максимального до первого отрицательного
            {
                if (D[i, j] > maxi)
                {
                    maxi = D[i,j];
                    indexmaxi = j;
                }
            }
            for (int j = 0; j < m; j++)// ищем индекс последнего отрицательного
            {
                if (D[i, j] < 0)
                {
                    indexlast = j;
                }
            }
            if (indexfirst != 0)
            {
                t = D[i, indexmaxi];
                D[i, indexmaxi] = D[i, indexlast];
                D[i, indexlast] = t;
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
        //  В матрице Н размера 5 × 7 заполнены первые 6 столбцов. Поместить в качестве предпоследнего столбца столбец, состоящий из максимальных элементов строк.
        // code here
        int n = H.GetLength(0), m = H.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            int maxi = H[i, 0], t = H[i, m - 2];
            for (int j = 0; j < m; j++) // ищем максимальное число в строке
            {
                if (H[i,j] > maxi)
                {
                    maxi = H[i, j];
                }
            }
            H[i, m - 1] = H[i, m - 2];
            H[i, m - 2] = maxi;
            

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
        //  В матрице Y размера 6 × 5 в каждой строке заменить отрицательные элементы, расположенные перед максимальным, на среднее среди положительных элементов,
        //  расположенных после максимального.
        // code here
        int n = Y.GetLength(0), m = Y.GetLength(1);
        if (n != 6 || m != 5) return default;
        for (int i = 0; i < n; i++)
        {
            double maxi = Y[i, 0], sr = 0, s = 0;
            int indexmaxi = 0, k = 0;
            for (int j = 0; j < m; j++)// ищем индекс максимального в строке
            {
                if (Y[i, j] > maxi)
                {
                    maxi= Y[i, j];
                    indexmaxi = j;
                }
            }

            for (int j = indexmaxi + 1; j < m; j++) // ищем среднее значение 
            {
                if (Y[i, j] > 0)
                {
                    s += Y[i, j];
                    k++;
                }
            }
            if (k == 0) sr = 0;
            else sr = s / k;

            for (int j = 0; j < indexmaxi; j++)
            {
                if (Y[i,j] < 0)
                {
                    Y[i, j] = sr;
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
        // В матрице В размера 5 × 7 4-й столбец матрицы заменить одномерным массивом, состоящим из максимальных элементов строк, расположенных в обратном порядке
        // (т.е 1 - й элемент 4 - го столбца – это максимальный элемент 5 - й строки и т.д.). 
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 7) return default;
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            int maxi = B[i, 0], indexmaxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > maxi)
                {
                    maxi = B[i, j];
                    indexmaxi = j;
                }
            }
            A[i] = maxi;
        }
        for (int i = 0; i < n; i++)
        {
            B[i, 3] = A[n - i - 1];

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
        //  Строку, содержащую максимальный элемент главной диагонали матрицы В размера 5 × 5 поменять местами со строкой, содержащей первый(от начала столбца)
        //  отрицательный элемент в 3 - м столбце.
        // code here
        int n = B.GetLength (0), m = B.GetLength(1);
        if (n != 5 || m != 5) return default;
        int maxi = B[0,0], indexmaxi = 0;
        for (int i = 0; i < n; i++)// находим номер строки где максимальный элемент
        {
           if (B[i, i] > maxi)
           {
                maxi = B[i, i];
                indexmaxi = i;
           }
        }
        int indexfirst = -1;
        for (int i = 0; i < n; i++) // ищем номер строки где первый отрицательный
        {
            if (B[i,2] < 0)
            {
                indexfirst = i;
                break;
            }
        }
        for (int j = 0; j < m; j++)
        {
            int t = B[indexmaxi, j];
            B[indexmaxi, j] = B[indexfirst, j];
            B[indexfirst, j] = t;

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
        // Сформировать одномерный массив из отрицательных элементов матрицы А размера 5 × 7.
        // code here
        int n = A.GetLength(0), m = A.GetLength(1), k = 0;
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }
        }
        answer = new int[k];
        k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[k] = A[i, j];
                    k++;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            double maxi = A[i, 0];
            int indexmaxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = j;
                }
            }
            if (indexmaxi != 0 && indexmaxi != m - 1)
            {
                if (A[i, indexmaxi - 1] < A[i, indexmaxi + 1])
                {
                    if (A[i, indexmaxi - 1] > 0)
                        A[i, indexmaxi - 1] *= 2;
                    else 
                        A[i, indexmaxi - 1] /= 2;
                }
                else
                {
                    if (A[i, indexmaxi + 1] > 0)
                        A[i, indexmaxi + 1] *= 2;
                    else
                        A[i, indexmaxi + 1] /= 2;
                }     
            }
            else if (indexmaxi == 0)
            {
                if (A[i, 1] > 0)
                    A[i, 1] *= 2;
                else
                    A[i, 1] /= 2;
            }
            else
            {
                if (A[i, m - 2] > 0)
                    A[i, m - 2] *= 2;
                else
                    A[i, m - 2] /= 2;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        
        for (int j = 0; j < m; j++)
        {
            int k_pol = 0, k_otr = 0, maxi = A[0,0], indexmaxi = 0;
            for (int i = 0; i < n; i++)// считаем количество отрицательных и положительных
            {
                if (A[i, j] < 0) k_otr++;
                else k_pol++;
            }
            for (int i = 0; i < n; i++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i,j];
                    indexmaxi = i;
                }
            }
            if (k_pol > k_otr) A[indexmaxi, j] = 0;
            else A[indexmaxi, j] = indexmaxi;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int maxi = A[0, 0], indexmaxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = i;
                }
            }
            if (indexmaxi < n / 2)
            {
                int s = 0;
                for (int i = indexmaxi + 1; i < n; i++)
                {
                    s += A[i, j];
                }
                A[0, j] = s;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1), l = B.Length;
        if (n != 7 || m != 5 || l != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int maxi = A[0, 0], indexmaxi = 0, t = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = i;
                }
            }
            if (A[indexmaxi, j] < B[j])
            {
                t = B[j];
                B[j] = A[indexmaxi, j];
                A[indexmaxi, j] = t;
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            double maxi = A[0, j];
            int indexmaxi = 0;
            for (int i  = 0; i < n; i++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i, j];
                    indexmaxi = i;
                }
            }
            double suma = (A[0, j] + A[n - 1, j]) / 2;
            if (A[indexmaxi, j] < suma) A[indexmaxi, j] = suma;
            else A[indexmaxi, j] = indexmaxi;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // Сформировать матрицу размера n x 3n, составленную из трех единичных квадратных матриц размера n x n.
        // code here
        if (n < 0) return default;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = count; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
                
            }
            count++;
        }
        

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return default;
        int maxi = A[0, 0], indexmaxi = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i,i] > maxi)
            {
                maxi = A[i,i];
                indexmaxi = i;
            }
        }
        for (int i =0; i < indexmaxi; i++)
        {
            for (int j = i + 1 ; j < m; j++)
            {
                A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        //В матрице В размера 6 × 6 поменять местами максимальные элементы 1-й и 2-й строк, 3 - й и 4 - й, 5 - й и 6 - й.
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) return default;
        for (int i = 0; i < n ; i += 2)
        {
            int maxi1 = B[i, 0], indexmaxi1 = 0, maxi2 = B[i + 1, 0], indexmaxi2 = 0; ;
            for (int j = 0; j < m; j++)
            {
                if (B[i,j] > maxi1)
                {
                    maxi1 =B[i,j];
                    indexmaxi1 = j;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (B[i + 1, j] > maxi2)
                {
                    maxi2 = B[i + 1, j];
                    indexmaxi2 = j;
                }
            }
            int t = B[i, indexmaxi1];
            B[i, indexmaxi1] = B[i + 1, indexmaxi2];
            B[i + 1, indexmaxi2] = t;
            //A[k] = indexmaxi;// запоминаем индекс столбца где максимальный элемент
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
                Console.Write($"{B[i, j]} ");
            Console.WriteLine();
        }
        //foreach(int x in A) Console.Write(x);
        //for (int i = 0; i < n - 1; i++)
        //{
        //    double t = B[i, A[i]];
        //    B[i, A[i]] = B[i + 1, A[i + 1]];
        //    B[i + 1, A[i + 1]] = B[i, A[i]];
        //}
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // В матрице А размера 6 × 7 расположить элементы строк в обратном порядке
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                int t = A[i, m - j - 1];
                A[i, m - j - 1] = A[i, j];
                A[i, j] = t;

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
        //  Заполнить нулями элементы квадратной матрицы, расположенные по ее периметру (использовать один цикл).
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m) return default;
        for (int i = 0; i < n; i++)
        {
            matrix[0, i % n] = 0;
            matrix[n - 1, i % n] = 0;
            matrix[i % n, 0] = 0;
            matrix[i % n, n - 1] = 0;
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
        // Для матрицы размера n x n заполнить единицами нижнюю половину (включая среднюю строку, если n нечетное) за исключением элементов,
        //расположенных справа от главной диагонали.
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m) return default;
        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
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
        // В матрице размера n x n сформировать два одномерных массива: в один переслать по строкам верхний треугольник матрицы,
        // включая элементы главной диагонали, в другой – нижний треугольник. Вывести верхний и нижний треугольники по строкам.
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1),c_up = 0, c_down = 0;
        if (n != m) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
                c_up++;
            }
        }
        upper = new int[c_up];
        c_up = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
                upper[c_up] = matrix[i, j];
                c_up++;
            }
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                c_down++;
            }
        }
        lower = new int[c_down];
        c_down = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[c_down] = matrix[i, j];
                c_down++;
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
        // В матрице размера 7 × 5 переставить строки таким образом, чтобы количества положительных элементов в строках следовали в порядке убывания. 
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int i = 0; i < n ; i++)// сортировка пузырьком
        {
            for(int j = 0; j < m - i - 1; j++)
            {
                int count_now = 0, count_next = 0;
                for (int k = 0; k < m; k++)
                {
                    if (matrix[j, k] > 0) count_now++;
                    if (matrix[j + 1, k] > 0) count_next++;
                }
                if (count_now < count_next)
                {
                    int[] t = new int[m];
                    for (int k = 0; k < m; k++)
                    {
                        t[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = t[k];
                    }
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
        //  В заданной матрице упорядочить элементы строк с четными индексами по убыванию, с нечетными -по возрастанию.
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for (int k = 0; k < m - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int t = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = t;
                        }
                    }
                    else
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int t = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = t;
                        }
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // В заданной матрице удалить все строки, содержащие нулевые элементы.
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1), count = 0;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] A = new int[n - count, m];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0) break;
                A[k, j] = matrix[i, j];
            }
            k++;
            if (k >= n - count) break;
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}