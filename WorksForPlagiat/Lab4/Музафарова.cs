using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                }
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
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int[] answer = new int[4];
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double min = double.MaxValue;
            int h = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    h = j;
                }
            }
            answer[k] = h;
            k += 1;
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
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for(int i = 0; i < 5; i++)
        {
            int h = 0;
            int max = int.MinValue;
            for(int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    h = j;
                }
            }
            int g = A[i, 0];
            A[i, 0] = A[i, h];
            A[i, h] = g;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int max = int.MinValue; 
        int imax = 0;
        int jmax = 0;
        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        int[,] B = new int[5, 6];
        int ib = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i == imax) { continue; }

            int jb = -1;
            for (int j = 0; j < 7; j++)
            {
                if (j == jmax) { continue; }
                jb += 1;
                B[ib, jb] = A[i, j];
            }
            ib += 1;
        }
        A = B;
        

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for(int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            int mi = 0;
            int mj = 0;
            for(int j = 0; j < 7; j++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    mi = i;
                    mj = j;
                }
            }
            A[mi, mj] = A[mi, mj] * (i + 1);
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
        //В каждой строке матрицы D размера n × m максимальный среди элементов, 
        //расположенных до первого отрицательного, поменять местами с последним
        //отрицательным в этой строке.

        // code here
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;
        for(int i = 0; i < n; i++)
        {
            int jfirst = -1;
            for(int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    jfirst = j;
                    break;
                }
            }
            if(jfirst == -1) { continue; }
            int jlast = 0;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    jlast = j;
                }
            }
            if(jfirst != jlast)
            {
                int max = int.MinValue; ;
                int jmax = -1;
                for (int j = 0; j < jfirst; j++)
                {
                    if (D[i, j] > max)
                    {
                        max = D[i, j];
                        jmax = j;
                    }
                }
                if (jmax != -1)
                {
                    int k = D[i, jmax];
                    D[i, jmax] = D[i, jlast];
                    D[i, jlast] = k;
                }
            }
            else { continue; }
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
        // В матрице Н размера 5 × 7 заполнены первые 6 столбцов. Поместить в качестве 
        //предпоследнего столбца столбец, состоящий из максимальных элементов строк.

        // code here
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for(int  i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            for(int j = 0; j < 7; j++)
            {
                if (H[i, j] > max)
                {
                    max = H[i, j];
                }
            }
            H[i, 6] = max;
        }
        for(int i = 0; i < 5; i++)
        {
            int k = H[i, 5];
            H[i, 5] = H[i, 6];
            H[i, 6] = k;
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
        //В матрице Y размера 6 × 5 в каждой строке заменить отрицательные элементы,
        //расположенные перед максимальным, на среднее среди положительных элементов,
        //расположенных после максимального. 

        // code here
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        for (int i = 0; i < 6; i++)
        {
            double max = double.MinValue; ;
            int jmax = 0;
            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > max)
                {
                    max = Y[i, j];
                    jmax = j;
                }
            }
            int k = 0;
            double sum = 0;
            for(int j = jmax + 1; j < 5; j++)
            {
                if (Y[i, j] > 0)
                {
                    k += 1;
                    sum += Y[i, j];
                }
            }
            double srsum = 0;
            if(k != 0)
            {
                srsum = sum / k;
            }
            else
            {
                srsum = 0;
            }
            for(int j = 0; j <jmax; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = srsum;
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
        //В матрице В размера 5 × 7 4 - й столбец матрицы заменить одномерным массивом, 
        //состоящим из максимальных элементов строк, расположенных в обратном порядке
        //(т.е 1 - й элемент 4 - го столбца – это максимальный элемент 5 - й строки и т.д.). 

        // code here
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;
        int[] A = new int[5];
        int k = 0;
        for(int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            for(int j = 0; j < 7; j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
            }
            A[k] = max;
            k += 1;
        }
        int[] C = new int[5];
        int f = 0;
        for(int i = A.Length -1; i >=0; i -=1)
        {
            C[f] = A[i];
            f += 1;
        }
        A = C;
        int s = 0;
        for(int i = 0; i < 5; i++)
        {
            B[i, 3] = A[s];
            s += 1;
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
        //Строку, содержащую максимальный элемент главной диагонали матрицы В размера
        //5 × 5 поменять местами со строкой, содержащей первый(от начала столбца)
        //отрицательный элемент в 3 - м столбце.

        // code here

        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        int max = int.MinValue;
        int imax = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (B[i, i] > max)
                {
                    max = B[i, j];
                    imax = i;
                }
            }
        }
        int h = -1;
        for (int i = 0; i < 5; i++)
        {
            if (B[i, 0] > 0 && B[i, 1] > 0 &&B[i, 2] < 0)
            {
                h = i;
                break;
            }
        }
    
        if (h != -1)
        {
            for (int j = 0; j < 5; j++)
            {
                int g = B[imax, j];
                B[imax, j] = B[h, j];
                B[h, j] = g;
            }
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
        //Сформировать одномерный массив из отрицательных элементов матрицы А размера
        //5 × 7

        // code here
        if(A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int k = 0;
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    k += 1;
                }
            }
        }
        int[] answer = new int[k];
        int h = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    answer[h] = A[i, j];
                    h += 1;
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
        //Дана матрица A размера 5 × 7.Для каждой строки сравнить элементы,
        //расположенные непосредственно перед и после максимального элемента этой
        //строки, и меньший из них увеличить в 2 раза.Если максимальный элемент является
        //первым или последним в строке, то увеличить в 2 раза только один соседний с
        //максимальным элемент.

        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            double max = double.MinValue;
            int jmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            if(jmax != 0 && jmax != A.GetLength(1) - 1)
            {
                if (A[i, jmax - 1] > A[i, jmax + 1])
                {
                    if (A[i, jmax + 1] > 0) { A[i, jmax +1] *= 2; }
                    else { A[i, jmax + 1] /= 2; }
                }
                else
                {
                    if (A[i, jmax - 1] > 0) { A[i, jmax - 1] *= 2; }
                    else { A[i, jmax - 1] /= 2; }
                }
            }
            else if(jmax == 0)
            {
                A[i, jmax + 1] *= 2;
            }
            else if(jmax == A.GetLength(1) - 1)
            {
                A[i, jmax - 1] *= 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        //Дана матрица A размера 7 × 5.Если количество положительных элементов
        //столбца больше количества отрицательных, то максимальный элемент этого
        //столбца заменить на 0, в противном случае максимальный элемент заменить на
        //номер максимального элемента этого столбца . 

        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for(int j = 0; j< 5; j+=1)
        {
            int k1 = 0;
            int k2 = 0;
            for(int i = 0; i < 7; i += 1)
            {
                if (A[i, j] > 0)
                {
                    k1 += 1;
                }
                if (A[i, j] < 0)
                {
                    k2 += 1;
                }
            }
            int max = int.MinValue;
            int imax = 0;
            for(int i = 0; i < 7; i += 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if(k1 > k2)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        //Дана матрица A размера10 × 5.Преобразовать матрицу следующим образом:
        //заменить первый элемент столбца суммой элементов столбца, расположенных
        //после максимального элемента, если максимальный элемент находится в первой
        //половине столбца.В противном случае оставить столбец без изменения.

        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for(int j = 0; j < 5; j += 1)
        {
            int max = int.MinValue;
            int imax = 0;
            for(int i = 0; i < 10; i += 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            int sum = 0;
            if(imax < 4)
            {
                for(int i = imax+ 1; i < 10; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
            else
            {
                continue;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        //Дана матрица A размера 7 × 5 и массив B размера 5.Заменить максимальный
        //элемент столбца соответствующим элементом массива B, если этот элемент больше
        //найденного максимального элемента столбца. В противном случае замены не
        //производить.

        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for(int j = 0; j < 5; j += 1)
        {
            int max = int.MinValue;
            int imax = 0;
            for(int i = 0; i < 7; i += 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (B[j] > A[imax, j])
            {
                A[imax, j] = B[j];
            }
            else
            {
                continue;
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        //Дана матрица A размера 7 × 5.Максимальный элемент столбца заменить
        //полусуммой первого и последнего элементов столбца, если максимальный элемент
        //меньше этой полусуммы, в противном случае максимальный элемент заменить его
        //номером в столбце.

        // code here
        if(A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for(int j = 0; j < 5; j++)
        {
            double max = double.MinValue;
            int imax = 0;
            for(int i = 0; i < 7; i += 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            double sum = (A[0, j] + A[4, j])/2;
            if (max < sum)
            {
                A[imax, j] = sum;
            }
            else
            {
                A[imax, j] = imax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        //Сформировать матрицу размера n  3n, составленную из трех единичных
        //квадратных матриц размера n  n.

        // code here
        int[,] answer = default(int[,]);
        if (n <= 0) { return answer; }
        answer = new int[n, n * 3];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = i; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        //В матрице А размера 6 × 6 найти максимальный элемент на главной диагонали. 
        //Заменить нулями элементы матрицы, расположенные правее главной диагонали в
        //строках, расположенных выше строки, содержащей максимальный элемент на
        //главной диагонали.  

        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = int.MinValue;
        int imax = 0;
        for(int i = 0; i < 6; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                imax = i;
            }
        }
        if(imax != 0)
        {
            for(int i = 0; i < imax; i += 1)
            {
                for(int j = 0; j < 6;j += 1)
                {
                    if(i < j)
                    {
                        A[i, j] = 0;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        //В матрице В размера 6 × 6 поменять местами максимальные элементы 1 - й и 2 - й
        //строк, 3 - й и 4 - й, 5 - й и 6 - й.

        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for(int i = 0; i < 6; i+= 2)
        {
            int max1 = int.MinValue;
            int imax1 = 0;
            for(int j = 0; j < 6; j += 1)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    imax1 = j;
                }
            }


            int max2 = int.MinValue;
            int imax2 = 0;
            for (int j = 0; j < 6; j += 1)
            {
                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    imax2 = j;
                }
            }

            int h = B[i, imax1];
            B[i, imax1] = B[i + 1, imax2];
            B[i + 1, imax2] = h;

        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        //В матрице А размера 6 × 7 расположить элементы строк в обратном порядке. 

        // code here
        if(A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int[,] B = new int[6, 7];
        for(int i = 0; i < 6; i += 1)
        {
            int k = 0;
            for(int j = A.GetLength(1) - 1; j >= 0; j -=1)
            {
                B[i, k] = A[i, j];
                k += 1;
            }
        }
        A = B;
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
        //Заполнить нулями элементы квадратной матрицы, расположенные по ее периметру
        //(использовать один цикл). 

        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int k = matrix.GetLength(0);
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (i == 0 || j == 0 || i == k - 1 || j == k - 1)
                {
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
        //Для матрицы размера n  n заполнить единицами нижнюю половину(включая
        //среднюю строку, если n нечетное) за исключением элементов, расположенных справа от
        //главной диагонали.

        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int k = matrix.GetLength(0);
        for(int i = k/2; i < k; i += 1)
        {
            for(int j = 0; j < k; j += 1)
            {
                if(j > i)
                {
                    continue;
                }
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
        //В матрице размера n  n сформировать два одномерных массива: в один переслать
        //по строкам верхний треугольник матрицы, включая элементы главной диагонали, в
        //другой – нижний треугольник. Вывести верхний и нижний треугольники по строкам.

        // code here
        int k1 = matrix.GetLength(0);
        int k2 = matrix.GetLength(1);
        int[] upper = new int[k1 * (k2 - 1) / 2 + k1];
        int[] lower = new int[k1 * (k2 - 1) / 2];
  
        if (k1 != k2) return (null, null);
        int h1 = 0, h2 = 0;
        for (int i = 0; i < k1; i++)
        {
            for (int j = 0; j < k2; j++)
            {
                if (i > j)
                {
                    lower[h1] = matrix[i, j];
                    h1++;
                }
                else
                {
                    upper[h2] = matrix[i, j];
                    h2++;
                }
            }
        }
        // code here

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
        //В матрице размера 7 × 5 переставить строки таким образом, чтобы количества
        //положительных элементов в строках следовали в порядке убывания.

        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
                                          
        int[] positiveCount = new int[7];
        for (int i = 0; i < 7; i++)
        {
            int count = 0;
            for (int j = 0; j < 5; j++)     // Это подсчет положительных элементов в каждой строке
            {
                if (matrix[i, j] > 0)
                    count++;
            }
            positiveCount[i] = count;
        }

        for (int i = 0; i < 7 - 1; i++)
        {
            for (int j = 0; j < 7 - i - 1; j++)
            {
                if (positiveCount[j] < positiveCount[j + 1])
                {

                    int temp = positiveCount[j];
                    positiveCount[j] = positiveCount[j + 1];
                    positiveCount[j + 1] = temp;

                    for (int k = 0; k < 5; k++)
                    {
                        int tempElement = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = tempElement;
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
        //В заданной матрице упорядочить элементы строк с четными индексами по
        //убыванию, с нечетными -по возрастанию.

        // code here
        int k1 = matrix.GetLength(0);
        int k2 = matrix.GetLength(1);
        for (int i = 0; i < k1; i++)
        {
            int[] array = new int[k2];
            for (int j = 0; j < k2; j++)
            {
                array[j] = matrix[i, j];
            }

            for (int j = 0; j < k2 - 1; j++)
            {
                for (int k = 0; k < k2 - j - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        if (array[k] < array[k + 1])
                        {
                            int temp = array[k];          // Для четных строк 
                            array[k] = array[k + 1];
                            array[k + 1] = temp;
                        }
                    }
                    else
                    {
                        if (array[k] > array[k + 1])
                        {
                            int temp = array[k];              // Для нечетных строк
                            array[k] = array[k + 1];
                            array[k + 1] = temp;
                        }
                    }
                }
            }
            for (int j = 0; j < k2; j++)
            {
                matrix[i, j] = array[j];
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int k1 = matrix.GetLength(0);
        int k2 = matrix.GetLength(1);
        int a = 0;
        bool h = false;

        for (int i = 0; i < k1; i++)
        {
            for (int j = 0; j < k2; j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    h = true;
                    break;
                }
            }
            if (h)
            {
                h = false;
                continue;
            }
        }
        int count = 0;
        int[,] matrix1 = new int[k1 - a, k2];
        for (int i = 0; i < k1; i++)
        {
            for (int j = 0; j < k2; j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    h = true;
                    break;
                }
                matrix1[count, j] = matrix[i, j];
            }
            if (h)
            {
               h = false;
                continue;
            }
            count++;
            if (count >= matrix.GetLength(0) - a)
                break;
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}