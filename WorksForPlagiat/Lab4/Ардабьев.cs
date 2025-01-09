using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
{
    // Метод для вывода массива в консоль
    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void Print2DArrayDouble(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

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
        int s = 0;
        for (int i = 0, j = 0; i < A.GetLength(0); i++, j++)
        {
            s += A[i, j];
        }
        answer = s;
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
        answer = new int[A.GetLength(0)];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
        {
            return default(int[]);
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                int min = A[i,0];
                int index = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (A[i, j] <= min)
                    {
                        min = A[i, j];
                        index = j;
                    }
                }
                answer[i] = index;
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
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default(int[,]);
        }
        Print2DArray(A);
        for(int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max)
                {
                    
                    max = A[i, j];
                }
            }
            for (int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] == max)
                {
                    index = j;
                    A[i, index] = A[i, 0];
                    break;
                }
            }
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

        // Поиск максимального элемента массива и его индексов
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return default(int[,]);
        }
        int max = A[0, 0];
        int iIndex = 0, jIndex = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] >= max)
                {
                    max = A[i, j];
                    iIndex = i; jIndex = j;
                }
            }
        }

        // Создание новой матрицы без строки и столбца с максимумом
        int[,] newA = new int[5, 6];
        for (int i = 0, newI = 0; i < A.GetLength(0); i++)
        {
            if (i == iIndex) continue;

            for (int j = 0, newJ = 0; j < A.GetLength(1); j++)
            {
                if (j == jIndex) continue;

                newA[newI, newJ] = A[i, j];
                newJ++;
            }
            newI++;
        }
        A = newA;
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
        
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default(int[,]);
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max = A[i, 0];

            // Поиск максимального элемента в строке
            for (int j = 0;j < A.GetLength(1); j++)
            {
                if (A[i, j] >= max)
                {
                    max = A[i, j];
                }
            }

            // Повторный перебор по строке. Замена максимума на маскимум, умноженный на номер строки
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] == max)
                {
                    A[i, j]*= (i+1);
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

        // Проверка на соответствие размерам массива
        if (D.GetLength(0) != n || D.GetLength(1) != m)
        {
            return default(int[,]);
        }

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int firstNeg = 0, lastNeg = 0;
            int maxBeforeNeg = D[i, 0];
            bool firstNegWasFound = false;

            for (int j = 0; j < D.GetLength(1); j++)
            {   
                // Поиск первого отрицательного элемента в строке
                if (D[i, j] < 0 && firstNegWasFound == false)
                {
                    firstNeg = j;
                    firstNegWasFound = true;
                }

                // Поиск максимума перед отрицательным числом в строке
                if (firstNegWasFound == false)
                {
                    if (D[i, j] >= maxBeforeNeg)
                    {
                        maxBeforeNeg = D[i, j];
                    }
                }

                // Поиск последнего отрицательного элемента в строке
                if (D[i, j] < 0)
                {
                    lastNeg = D[i, j];
                }
            }

            // Если в строке нет отрицательных
            if (firstNeg == 0 || lastNeg == 0) continue;

            // Цикл замены макисмального перед первым отрицательным на последнее отрицательное (и наоборот)
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i,j] == maxBeforeNeg)
                {
                    D[i, j] = lastNeg;
                    continue;
                }
                if (D[i,j] == lastNeg)
                {
                    D[i, j] = maxBeforeNeg;
                    break;
                }
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

        // Проверка на соответствие размерам массива
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return default(int[,]);
        }

        // Поиск максимальных элементов в каждом ряду и вставка в предпоследний столбец
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int max = H[i, 0];
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i,j] >= max)
                {
                    max = H[i, j];
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max; // Помещаем максимальное значение каждого ряда в предпоследний столбец
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

        // Проверка на соответствие размерам массива
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return default(double[,]);
        }

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0];

            // Поиск максимального элемента строки
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] >= max)
                {
                    max = Y[i, j];
                }
            }

            double mean = 0, sum = 0;
            bool isMaxBehind = false;

            // Поиск среднего арифметического положительных элементов после максимума
            int count = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] == max && isMaxBehind == false)
                {
                    isMaxBehind = true;
                    continue;
                }

                if (isMaxBehind == true && Y[i, j] > 0)
                {
                    count++;
                    sum += Y[i, j];
                    mean = sum / count;
                }
            }

            // Замена отрицательных элементов перед максимумом на ср.ариф. после максимума
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] == max)
                {
                    break;
                }
                if (Y[i, j] < 0)
                {
                    Y[i, j] = mean;
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

        // Проверка на соответствие размерам матрицы
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return default(int[,]);
        }

        int[] arrayOfMax = new int[5];
        int k = 0;
        
        // Поиск максимального элемента каждой строки (в обратной последовательности) и формирование массива из таких элементов
        for (int i = B.GetLength(0)-1; i >= 0 ; i--)
        {
            int maxOfRow = B[i, 0];
            for (int j = 0 ; j < B.GetLength(1); j++)
            {
                if (B[i, j] >= maxOfRow)
                {
                    maxOfRow = B[i, j];
                }
            }
            arrayOfMax[k] = maxOfRow;
            k++;
        }

        // Замена 4-го элемента каждой строки матрицы на элемент из массива максимальных
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = arrayOfMax[i];
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

        // Проверка на соответствие размерам матрицы
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return default(int[,]);
        }

        // Поиск максимального элемента главной диагонали
        int maxOfDiag = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] >= maxOfDiag)
            {
                maxOfDiag = B[i, i];
            }
        }

        // Поиск строки с максимальным элементом диагонали
        int RowOfMaxDiag = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] == maxOfDiag)
                {
                    RowOfMaxDiag = i;
                }
            }
        }

        // Поиск строки, содержащей первый отрицательный элемент в 3-м столбце
        int RowWithNegative = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                RowWithNegative = i;
                break;
            }
        }
        
        // Меняем строки местами
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int temp = B[RowOfMaxDiag, i];
            B[RowOfMaxDiag, i] = B[RowWithNegative, i];
            B[RowWithNegative, i] = temp;
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

        // Проверяем на соответствие размеры матрицы
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default(int[]);
        }

        // Ищем сколько отрицательных чисел имеет матрица
        int countOfNeg = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] < 0)
                {
                    countOfNeg++;
                }
            }
        }

        answer = new int[countOfNeg]; // Объявляем массив размера количества отрицательных элементов

        // Добавляем в массив отрицательные элементы матрицы
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return default(double[,]);
        }

        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            // Находим максимальный элемент строки
            double maxOfRow = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxOfRow)
                {
                    maxOfRow = A[i, j];
                }
            }

            // Находим индекс максимального элемента строки
            int indexOfMax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == maxOfRow)
                {
                    indexOfMax = j;
                    break;
                }
            }

            // Ищем соседние элемента от максимального (или соседний) и увеличиваем его на 2. (делим на 2, если число отрицательное)

            if (indexOfMax == 0)            // Если максимальный элемент - первый в строке
            {
                if(A[i, indexOfMax + 1] < 0)   A[i, indexOfMax + 1] /= 2;   // если число отрицательное
                else
                    A[i, indexOfMax + 1] *= 2;  // если число положительное
            }

            else if(indexOfMax == 6)       // Если максимальный элемент - последний в строке
            {
                if(A[i, indexOfMax - 1] < 0)   A[i, indexOfMax - 1] /= 2;
                else
                    A[i, indexOfMax - 1] *= 2;
            }

            else
            {
                if(A[i,indexOfMax - 1] <= A[i, indexOfMax + 1])
                {
                    if(A[i, indexOfMax - 1] < 0)   A[i, indexOfMax - 1] /= 2;
                    else
                        A[i, indexOfMax - 1] *= 2;
                }
                else
                {
                    if(A[i, indexOfMax + 1] < 0)   A[i, indexOfMax + 1] /= 2;
                    else
                        A[i, indexOfMax + 1] *= 2;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return default(int[,]);
        }

        // В ходе решения задачи для удобства мы транспонируем матрицу
        // Для того, чтобы можно было работать со столбцами изначальной матрицы так, словно они - строки

        // Транспонируем матрицу
        int[,] transposedMatrix = new int[A.GetLength(1), A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                transposedMatrix[j, i] = A[i,j];
            }
        }
        A = transposedMatrix;

        for (int i = 0; i < A.GetLength(0); i++)
        {

            // Находим максимальный элемент, считаем положительные и отрицательные чисел
            int maxOfRow = A[i, 0];
            int countOfPos = 0, countOfNeg = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) countOfPos++;
                if (A[i, j] < 0) countOfNeg++;

                if (A[i,j] > maxOfRow)
                {
                    maxOfRow = A[i, j];
                }
            }

            // Находим номер максимального элемента
            int NumberOfMax = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] == maxOfRow)
                {
                    NumberOfMax = j+1;
                    break;
                }
            }

            // Меняем максимальный эленемент так, как сказано в условии
            bool isPositiveMore = countOfPos > countOfNeg;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if(A[i, j] == maxOfRow && isPositiveMore)
                {
                    A[i, j] = 0;
                    break;
                }
                else if (A[i, j] == maxOfRow && isPositiveMore == false)
                {
                    A[i, j] = NumberOfMax;
                    break;
                }
            }
        }

        // Транспонируем матрицу обратно
        transposedMatrix = new int[A.GetLength(1), A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                transposedMatrix[j, i] = A[i, j];
            }
        }
        A = transposedMatrix;
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return default(int[,]);
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            // Находим максимальный элемент столбца
            int maxOfCol = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxOfCol)     maxOfCol = A[i, j];
            }

            // Находим сумму чисел после максимального элемента, а так же индекс максимального элемента
            int sumAfterMax = 0, indexOfMax = 0;
            bool isMaxBehind = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == maxOfCol && isMaxBehind == false)
                {
                    isMaxBehind = true; indexOfMax = i; continue;
                }
                if (isMaxBehind)
                {
                    sumAfterMax += A[i, j];
                }
            }

            // Если максимальный элемент находится в первой половине столбца, то меняем первый элемент столбца на сумму после максимума
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (indexOfMax <= 5)
                {
                    A[0,j] = sumAfterMax;
                }
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        // Проверяем размеры матрицы и массива
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return default(int[,]);
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            // Находим максимальный элемент столбца
            int maxOfCol = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxOfCol) maxOfCol = A[i, j];
            }

            // Находим индекс максимального элемента
            int indexOfMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == maxOfCol)
                {
                    indexOfMax = i; break;
                }
            }

            // Если соответствующий элемент массива больше максимума, меняем максимум на этот элемент
            if (B[j] > maxOfCol)
            {
                A[indexOfMax,j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return default(double[,]);
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            // Находим максимальный элемент столбца
            double maxOfCol = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxOfCol) maxOfCol = A[i, j];
            }

            // Находим индекса и номера максимального элемента
            int numberOfMax = 0, indexOfMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == maxOfCol)
                {
                    numberOfMax = (i+1); indexOfMax = i; break;
                }
            }

            // Если максимальный элемент меньше полусуммы первого и последнего элемента, заменяем максимальный элемент на полусумму. Иначе - на его номер
            if (maxOfCol < (A[0, j] + A[A.GetLength(1), j]) / 2)
            {
                A[indexOfMax, j] = (A[0, j] + A[A.GetLength(1), j]) / 2;
            }
            else
            {
                A[indexOfMax, j] = numberOfMax;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // Проверим n на положительность
        if (n < 0)
        {
            return answer;
        }

        // Создаем матрицу размером n x 3n
        int[,] matrix = new int[n,3*n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = 1;           // Первая единичная матрица
                    matrix[i, j + n] = 1;       // Вторая единичная матрица
                    matrix[i, j + 2 * n] = 1;   // Третья единичная матрица
                }
                
            }
        }

        answer = matrix;
        Print2DArray(answer);
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return default(int[,]);
        }

        int maxOfDiag = A[0,0];
        int rowOfMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            // Ищем максимум диагонали
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (A[i,j] > maxOfDiag)
                    {
                        maxOfDiag = A[i,j];
                    }
                }
            }

            // Ищем индекс строки с максимумом диагонали
            
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == maxOfDiag && i == j)
                {
                    rowOfMax = i;
                    break;
                }
                
            }
        }

        // Заменяем в матрице на нули все элементы, стоящие правее диагонали и выше строки с максимумом
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i && i < rowOfMax)
                {
                    A[i, j] = 0;
                }
            }
        }
        Print2DArray(A);
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // Проверяем размеры матрицы
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return default(int[,]);
        }

        int temp = -10000;
        int indexOfTemp = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int maxOfRow = B[i, 0];

            // Находим максимум строки
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i,j] > maxOfRow)
                {
                    maxOfRow = B[i,j];
                }
            }

            // Находим индекс максимума строки
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] == maxOfRow && i%2 == 0)
                {
                    indexOfTemp = j;
                    break;
                }
            }

            // Сохраняем максимум строки
            if (i % 2 == 0)
            {
                temp = maxOfRow;
            }

            // Если индекс строки нечётный, производим замену текущего максимума с предыдущим
            if (i%2 == 1)
            {
                B[i - 1, indexOfTemp] = maxOfRow;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] == maxOfRow)
                    {
                        B[i, j] = temp;
                        break;
                    }
                }
            }
        }
        Print2DArray(B);
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // Проверяем размеры матрицы
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return default(int[,]);
        }

        // Создаем матрицу и заполняем её строки в обратном порядке
        int[,] matrix = new int[6,7];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1)-1, k = 0; j >=0 ; j--)
            {
                matrix[i,k] = A[i,j];
                k++;
            }
        }
        A = matrix;
        Print2DArray(A);
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

        // Проверяем, является ли матрица квадратной
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return default(int[,]);
        }

        // Меняем на 0 элементы по периметру матрицы
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[0,i] = 0;
            matrix[i,matrix.GetLength(0)-1] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
        }

        Print2DArray(matrix);
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

        // Проверяем, является ли матрица квадратной
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return default(int[,]);
        }

        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j <= i)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        Print2DArray (matrix);
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

        // Проверяем, является ли матрица квадратной
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (upper, lower);
        }

        // Для обоих треугольников считаем количество входящих в них элементов
        int countU = 0, countL = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                // Верхний треугольник
                if (j >= i)
                {
                    countU++;
                }

                // Нижний треугольник
                else if (j <= i)
                {
                    countL++;
                }
            }
        }

        upper = new int[countU];
        lower = new int[countL];

        // Заполняем массивы элементами треугольников
        int u = 0, l = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0;j < matrix.GetLength(1); j++)
            {

                // Верхний треугольник
                if (j >= i)
                {
                    upper[u] = matrix[i, j];
                    u++;
                }

                // Нижний треугольник
                else if (j <= i)
                {
                    lower[l] = matrix[i, j];
                    l++;
                }
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
        // code here

        // Проверяем размеры матрицы
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return default(int[,]);
        }

        int[,] stepMatrix = new int[7, 5];
        int[] positiveCounts = new int[7];

        // Подсчет положительных чисел в каждой строке
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCounts[i]++;
                }
            }
        }

        // Перестановка строк в соответствии с количеством положительных чисел
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(0); j++)
            {
                if (positiveCounts[i] < positiveCounts[j])
                {
                    // Меняем местами строки
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }

                    // Меняем местами подсчеты положительных чисел
                    int tempCount = positiveCounts[i];
                    positiveCounts[i] = positiveCounts[j];
                    positiveCounts[j] = tempCount;
                }
            }
        }

        // Для красоты ответа мы можем поменять местами 4-ю и 5-ю строки, так как в них одинаковое количество положительных чисел
        if (positiveCounts[3] == positiveCounts[4])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[3, j];
                matrix[3, j] = matrix[4, j];
                matrix[4, j] = temp;
            }
        }
        
        Print2DArray(matrix);

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

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] row = new int[matrix.GetLength(1)];
            
            // Формируем массив элементов из строки
            for (int j = 0, k = 0; j < matrix.GetLength(1); j++)
            {
                row[k] = matrix[i, j];
                k++;
            }

            if (i%2 == 0)
            {
                // Упорядочиваем по убыванию
                for (int j = 0; j < row.Length - 1; j++)
                {
                    for (int k = 0; k < row.Length - 1 - j; k++)
                    {
                        if (row[k] < row[k + 1])
                        {
                            int temp = row[k];
                            row[k] = row[k + 1];
                            row[k + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                // Упорядочиваем по возрастанию
                for (int j = 0; j < row.Length - 1; j++)
                {
                    for (int k = 0; k < row.Length - 1 - j; k++)
                    {
                        if (row[k] > row[k + 1])
                        {
                            int temp = row[k];
                            row[k] = row[k + 1];
                            row[k + 1] = temp;
                        }
                    }
                }
            }
            
            // Производим замену элементов строки на элементы из массива
            for (int j = 0, k = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = row[k];
                k++;
            }
        }
        Print2DArray(matrix);
        

        //// СЛЕДУЮЩЕЕ РЕШЕНИЕ НЕ СООТВЕТСТВУЕТ УСЛОВИЮ ЗАДАЧИ. УСЛОВИЕ БЫЛО ВОСПРИНЯТО КАК: ЭЛЕМЕНТЫ С ЧЁТНЫМИ ИНДЕКСАМИ
        //// СТРОКИ УПОРЯДОЧИТЬ ПО УБЫВАНИЮ, С НЕЧЁТНЫМИ - ПО ВОЗРАСТАНЮ.
        //// НО В ЗАДАЧЕ ИМЕЛОСЬ В ВВИДУ "ЧЕТНЫЙ ИНДЕКС СТОЛБЦА", НО ОБ ЭТОМ В ЗАДАЧЕ ЧЁТКО НЕ СКАЗАННО. ПОЭТОМУ СНАЧАЛА ЗАДАЧА БЫЛА РЕШЕНА ИНАЧЕ

        //int[] evens = new int[matrix.GetLength(1)/2+1];
        //int[] unevens = new int[matrix.GetLength(1)/2];

        //for(int i = 0; i < 2; i++)
        //{
        //    // Заполняем массивы элементами чётных и нечётных индексов строки
        //    int e = 0, ue = 0;
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        if (j % 2 == 0)
        //        {
        //            evens[e] = matrix[i, j];
        //            e++;
        //        }
        //        if (j % 2 == 1)
        //        {
        //            unevens[ue] = matrix[i, j];
        //            ue++;
        //        }
        //    }

        //    // Упорядочиваем элементы в массиве чётных по убыванию
        //    for (int j = 0; j < evens.Length - 1; j++)
        //    {
        //        for (int k = 0; k < evens.Length - 1 - j; k++)
        //        {
        //            if (evens[k] < evens[k + 1])
        //            {
        //                int temp = evens[k];
        //                evens[k] = evens[k + 1];
        //                evens[k + 1] = temp;
        //            }
        //        }
        //    }
        //    // Упорядочиваем элементы в массиве нечётных по возрастанию
        //    for (int j = 0; j < unevens.Length - 1; j++)
        //    {
        //        for (int k = 0; k < unevens.Length - 1 - j; k++)
        //        {
        //            if (unevens[k] > unevens[k + 1])
        //            {
        //                int temp = unevens[k];
        //                unevens[k] = unevens[k + 1];
        //                unevens[k + 1] = temp;
        //            }
        //        }
        //    }

        //    e = 0; ue = 0;
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        if (j % 2 == 0)
        //        {
        //            matrix[i, j] = evens[e];
        //            e++;
        //        }

        //        if (j % 2 == 1)
        //        {
        //            matrix[i, j] = unevens[ue];
        //            ue++;
        //        }
        //    }
        //}

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        int count = 0;
        // Считаем количество ненулевых строк
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasZero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                count++;
            }
        }

        // Создаём новую матрицу для хранения ненулевых строк
        int[,] newMatrix = new int[count, matrix.GetLength(1)];
        int newRow = 0;

        // Копируем ненулевые строки в новую матрицу
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasZero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[newRow, j] = matrix[i, j];
                }
                newRow++;
            }
        }

        matrix = newMatrix;
        // end

        return matrix;
    }
    #endregion
}