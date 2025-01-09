using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
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
       
        /* Найти след (сумму диагональных элементов) квадратной матрицы А размера 4 × 4). */      
        int trace = 0;
        int n = A.GetLength(0);
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4)
        {
            trace = 0;
            return trace;
        }
        for (int i = 0; i < n; i++)
        {
            trace += A[i, i];
        }
        return trace;
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
        /* Сформировать одномерный массив из индексов минимальных элементов строк матрицы А размера 4 × 7.*/
        int[] array = new int[4];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
            return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            
            int minvalue = A[i, 0];
            int minindex = 0;

            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minvalue)
                {
                    minvalue = A[i, j];
                    minindex = j;
                }
            }

            array[i] = minindex; 
        }
        foreach (int x in array)
        {
            Console.WriteLine(x);
        }

        return array;
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
        // Поменять местами максимальный и 1-й элементы строк матрицы А размера 5 × 7.
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxvalue = A[i, 0];
            int maxindex = 0;

            
            for (int j = 1; j < A.GetLength(1); j++)  
            {
                if (A[i, j] > maxvalue)
                {
                    maxvalue = A[i, j];
                    maxindex = j;
                }
            }

            
            int temp = A[i, 0];
            A[i, 0] = A[i, maxindex];
            A[i, maxindex] = temp;
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
        // В матрице А размера 6 × 7 удалить столбец и строку, на пересечении которых находится максимальный элемент матрицы.
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        int indexi = 0, indexj = 0, maxx = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxx < A[i, j])
                {
                    maxx = A[i, j];
                    indexi = i;
                    indexj = j;
                }
            }
        }
        int[,] B = new int[5, 6];
        int bi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == indexi) continue;
            int bj = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j == indexj) continue;
                B[bi, bj] = A[i, j];
                bj++;
            }
            bi++;
        }
        A = B;
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
        // Преобразовать матрицу А размера 5 × 7, умножив максимальный элемент каждой строки на номер этой строки.
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0];
            int jmax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    jmax = j;
                }
                             
            }
            A[i, jmax] = max * (i + 1);
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
        // В каждой строке матрицы D размера n × m максимальный среди элементов,
        // расположенных до первого отрицательного, поменять местами с последним отрицательным в этой строке
        if (D.GetLength(0) != n || D.GetLength(1) != m)
            return null;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = int.MinValue, maxindexj = -1, negindexj1 = -1, negindexj2 = -1;

            // ищем последний отрицательный элемент
            for (int j = D.GetLength(1) - 1; j >= 0; j--)
            {
                if (D[i, j] < 0) { negindexj2 = j; break; }
            }

            // ищем первый отрицательный элемент
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0) { negindexj1 = j; break; }
            }
            // Если нет отрицательных элементов, то пропускаем строку
            if (negindexj1 == -1) continue;

            // Ищем максимальный элемент до первого отрицательного
            for (int j = 0; j < negindexj1; j++)
            {
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    maxindexj = j;
                }
            }

            // Если максимальный элемент найден, то меняем местами элементы
            if (maxindexj != -1)
            {
                int temp = D[i, maxindexj];
                D[i, maxindexj] = D[i, negindexj2];
                D[i, negindexj2] = temp;
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
        // В матрице Н размера 5 × 7 заполнены первые 6 столбцов.
        // Поместить в качестве предпоследнего столбца столбец, состоящий из максимальных элементов строк.
    

        // проверяем размер матрицу
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0];
            // находим в строке максимум
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (max < H[i, j])
                {
                    max = H[i, j];
                }
                    
            }

            // меняем значение последнего и предпоследнего столбцов
            int temp = max;
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = temp;
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
        // В матрице Y размера 6 × 5 в каждой строке заменить отрицательные элементы,
        // расположенные перед максимальным, на среднее среди положительных элементов, расположенных после максимального.
        /* 
        1.проверить размер матрицы
        2.найти максимальный элемент и его индекс в каждой строке матрицы
        3.создание счетчика, где i начинается с индекса макс элемента + 1, проверка на положительность числа, добавление такого числа к сумме, подсчет количества таких чисел
        4.нахождение среднего арифметичсекого
        5.создание счетчика, где i < индекса макс значения
        6.проверка число на отрицательность, замена отрицательного числа на среднее арифметическое
        */

        // проверка размера матрицы
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) { return null; }

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0];
            int indexj = -1;
            // нахождение макс элемента и его индекса в каждой строке 
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (max < Y[i, j]) { max = Y[i, j]; indexj = j; }  
            }



            // нахождение среднего арифметического
            double sum = 0;
            int count = 0;
            for (int j = indexj + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    sum += Y[i, j];
                    count++;
                }
            }
            double avaragesum;
            if (count == 0) { avaragesum = 0;  }

            else avaragesum = sum / count;

            // замена отрицательных значений на среднее арифметическое
            for (int j = 0; j < indexj; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = avaragesum;
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
        // В матрице В размера 5 × 7 4-й столбец матрицы заменить одномерным массивом, состоящим из максимальных элементов строк,
        // расположенных в обратном порядке (т.е 1-й элемент 4-го столбца – это максимальный элемент 5-й строки и т.д.).
        
        // проверка матрицы на размер
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) { return null; }

        // Создание массива для хранения максимальных элементов строк
        int[] maxarray = new int[B.GetLength(0)];

        // нахождение максимального значения элемента в каждой строке
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[i, 0];
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max) { max = B[i, j]; }
            }
            maxarray[i] = max;
        }
        // Замена 4-го столбца
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = maxarray[B.GetLength(0) - 1 - i];
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
        // Строку, содержащую максимальный элемент главной диагонали матрицы В размера 5 × 5 поменять местами со строкой,
        // содержащей первый (от начала столбца) отрицательный элемент в 3-м столбце.

        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;


        int i1 = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[0, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i != j) continue;
                if (max < B[i, j])
                {
                    max = B[i, j];
                    i1 = i;
                }
            }
        }


        bool foundNegative = false;
        int i2 = -1;



        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                i2 = i;
                foundNegative = true;
                break;  
            }
        }

        if (!foundNegative) return B;  


       
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int temp = B[i2, j];
            B[i2, j] = B[i1, j];
            B[i1, j] = temp;
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
        // Сформировать одномерный массив из отрицательных элементов матрицы А размера 5 × 7.
        
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) { return null; }
        int len = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) len++;
            }
        }
        int[] array = new int[len];
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) array[index++] = A[i, j];
            }
        }
        return array;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // Дана матрица A размера 5 × 7. Для каждой строки сравнить элементы,
        // расположенные непосредственно перед и после максимального элемента этой строки,
        // и меньший из них увеличить в 2 раза. Если максимальный элемент является первым или последним в строке,
        // то увеличить в 2 раза только один соседний с максимальным элемент.
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (max < A[i, j]) { max = A[i, j]; index = j; }
            }

            double temp;
            if (A[i, index + 1] > A[i, index - 1] || index == A.GetLength(1) - 1)
            {
                temp = A[i, index - 1];
                if (temp >= 0) { temp *= 2; }
                else { temp /= 2; }
                A[i, index - 1] = temp;
            }
            else if (A[i, index + 1] < A[i, index - 1] || index == 0)
            {
                temp = A[i, index + 1];
                if (temp >= 0) { temp *= 2; }
                else { temp /= 2; }
                A[i, index + 1] = temp;
            }
        }   
        return A;       
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // Дана матрица A размера 7 × 5. Если количество положительных элементов столбца больше количества отрицательных,
        // то максимальный элемент этого столбца заменить на 0, в противном случае максимальный элемент заменить на номер
        // максимального элемента этого столбца .

        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) { return null; }

        for (int j = 0; j < m; j++)
        {
            int max = A[0, j];
            int index = 0;
            int negativeCount = 0, positiveCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    index = i;
                }

                if (A[i, j] > 0) positiveCount++;
                else if (A[i, j] < 0) negativeCount++;
            }

            if (positiveCount > negativeCount) { A[index, j] = 0; }
            else { A[index, j] = index; } // Индексация с 1, чтобы соответствовать номеру строки
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        //Дана матрица A размера 10 × 5. Преобразовать матрицу следующим образом: заменить первый элемент столбца суммой элементов
        //столбца, расположенных после максимального элемента, если максимальный элемент находится в первой половине столбца.
        //В противном случае оставить столбец без изменения.

        // Проверка размера матрицы
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) { return null; }

        for (int j = 0; j < m; j++) // Для каждого столбца
        {
            int max = A[0, j];
            int index = 0;

            // Нахождение максимального элемента и его индекса
            for (int i = 0; i < n; i++) 
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            // Проверка, находится ли максимальный элемент в первой половине столбца
            if (index < n / 2)
            {
                int sum = 0;

                // Подсчет суммы элементов после максимального
                for (int i = index + 1; i < n; i++)
                {
                    sum += A[i, j];
                }

                // Замена первого элемента столбца
                A[0, j] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // Дана матрица A размера 7 × 5 и массив B размера 5.
        // Заменить максимальный элемент столбца соответствующим элементом массива B,
        // если этот элемент больше найденного максимального элемента столбца. В противном случае замены не производить.
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) { return null; }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (A[index, j] < B[j]) { A[index, j] = B[j]; }
        }


        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // Дана матрица A размера 7 × 5. Максимальный элемент столбца заменить полусуммой первого и последнего элементов столбца,
        // если максимальный элемент меньше этой полусуммы, в противном случае максимальный элемент заменить его номером в столбце.
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) { return null; }

        for (int j = 0; j < m; j++)
        {
            double max = A[0, j];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            double halfasum = (A[0, j] + A[n - 1, j]) / 2;

            if (max < halfasum) A[index, j] = halfasum;
            else A[index, j] = index;
        }


        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0)
        {
            return answer;
        }
        answer = new int[n, n * 3];
        int k = answer.GetLength(0);
        int m = answer.GetLength(1);
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < m; j++)
            {
                answer[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < k; i++)
        {
            count++;
            for (int j = count; j < m;)
            {
                answer[i, j] = 1;
                j += 3;
            }
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // В матрице А размера 6 × 6 найти максимальный элемент на главной диагонали.
        // Заменить нулями элементы матрицы, расположенные правее главной диагонали в строках,
        // расположенных выше строки, содержащей максимальный элемент на главной диагонали.
   
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return null;

        int max = A[0, 0];
        int k = 0; 
        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                k = i;
            }
        }

        for (int i = 0; i < k; i++) 
        {
            for (int j = i + 1; j < m; j++) 
            {
                A[i, j] = 0;
            }
        }

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // В матрице В размера 6 × 6 поменять местами максимальные элементы 1-й и 2-й строк, 3-й и 4-й, 5-й и 6-й.
        
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) return null;

        for (int i = 0; i < n; i += 2)
        {
            int max1 = B[i, 0], max2 = B[i + 1, 0];
            int index1 = 0, index2 = 0;

            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > max1) { max1 =  B[i, j]; index1 = j; }

                if (B[i + 1, j] > max2 ) { max2 = B[i + 1, j]; index2 = j; }

            }


            int temp = B[i, index1];
            B[i, index1] = B[i + 1, index2];
            B[i + 1, index2] = temp;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // В матрице А размера 6 × 7 расположить элементы строк в обратном порядке.
        
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 6 || m != 7) return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
            }
        }

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // В матрице размера 7 × 5 переставить строки таким образом, чтобы минимальные элементы строк следовали в порядке убывания.
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return default(int[,]);
        int[] indexes = new int[rows], elems = new int[rows];
        int[,] new_matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int min_elem = 0;
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] < min_elem) min_elem = matrix[i, j];
            }
            indexes[i] = i; elems[i] = min_elem;
        }

        for (int i = 1, j = i + 1; i < rows;)
        {
            if (i == 0 || elems[i] <= elems[i - 1])
            {
                i = j;
                j++;
            }
            else if (elems[i] > elems[i - 1])
            {
                int temp = elems[i];
                elems[i] = elems[i - 1];
                elems[i - 1] = temp;
                int temp_index = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for (int i = 0; i < rows; i++) Console.Write(elems[i] + " ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                new_matrix[i, j] = matrix[indexes[i], j];
            }
        }
        matrix = new_matrix;
        // end

        return matrix;


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
        //int[] answer = default(int[]);
        int[] answer = default(int[]);
        // code here

        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != cols) return default(int[]);
        int[] vector = new int[2 * rows - 1];

        for (int i = rows - 1, index = 0; i >= 0; i--, index++)
        {
            int row = i, col = 0, sum_left = 0, sum_right = 0;
            while (row < rows && col < cols)
            {
                sum_left += matrix[row, col];
                sum_right += matrix[col, row];
                row++; col++;
            }
            vector[index] = sum_left;
            vector[2 * rows - 2 - index] = sum_right;
        }
        for (int i = 0; i < rows; i++) Console.Write(vector[i] + " ");
        answer = vector;
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != cols || k <= 0) return default(int[,]);
        int max_row = 0, max_col = 0;
        k--;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max_row, max_col]))
                {
                    max_row = i;
                    max_col = j;
                }
        }

        if (max_col != k)
        {
            for (int i = 0; i < cols; i++)
            {
                int temp = matrix[i, max_col];
                matrix[i, max_col] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        if (max_row != k)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[max_row, j];
                matrix[max_row, j] = matrix[k, j];
                matrix[k, j] = temp;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
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

        int[] answer = default(int[]);

        // code here

        int rows = A.Length, cols = B.Length;
        if (rows + rows - n != n * n || cols + cols - n != n * n) return default(int[]);
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        int[] result = new int[n * n];
        for (int i = 0, index = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix1[j, i] = A[index];
                matrix2[i, j] = B[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }

        for (int i = 0, index = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += matrix1[i, j] * matrix2[j, k];
                }
                result[index] = s;
                index++;
            }
        }
        answer = result;

        for (int i = 0; i < n * n; i++)
        {
            Console.Write(result[i] + " ");
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 5 || cols != 7) return default(int[,]);
        int[] indexes = new int[cols], negative_counts = new int[cols];
        int[,] new_matrix = new int[rows, cols];

        for (int j = 0; j < cols; j++)
        {
            int cnt = 0;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < 0) cnt++;
            }
            indexes[j] = j; negative_counts[j] = cnt;
        }

        for (int i = 1, j = i + 1; i < cols;)
        {
            if (i == 0 || negative_counts[i] >= negative_counts[i - 1])
            {
                i = j;
                j++;
            }
            else if (negative_counts[i] < negative_counts[i - 1])
            {
                int temp = negative_counts[i];
                negative_counts[i] = negative_counts[i - 1];
                negative_counts[i - 1] = temp;
                int temp_index = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for (int i = 0; i < cols; i++) Console.Write(negative_counts[i] + " ");

        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                new_matrix[i, j] = matrix[i, indexes[j]];
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
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1), count_0 = 0;
        int[] indexes = new int[rows];

        for (int i = 0, index = 0; i < rows; i++)
        {
            bool flag = true;
            for (int j = 0; j < cols; j++)
                if (matrix[i, j] == 0)
                {
                    count_0++;
                    flag = false;
                    break;
                }
            if (!flag) indexes[index++] = i;
        }

        int[,] new_matrix = new int[rows - count_0, cols];

        for (int i = 0, index = 0; i < rows; i++)
        {
            if (i == indexes[index]) index++;
            else
                for (int j = 0; j < cols; j++) new_matrix[i, j] = matrix[i, j];

        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    #endregion
}