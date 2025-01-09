using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

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
        int n = A.GetLength(0);
        for (int i = 0; i < n; i++)
        {   
            answer += A[i, i]; //главная диаг
            //answer += A[i, n-i-1];//побочная диаг
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
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 7)
        {
            return null; 
        }
        int[] answer = new int[A.GetLength(0)];
        // code here
        //идем по каждой строке
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int mini = 0; // Начинаем с нуля для первой строки
            // проходим по эл строки каждого столбца
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < mini) 
                {
                    mini = j; 
                    Console.WriteLine(mini);
                }
            }
            answer[i] = mini;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null; 
        }
        //идем по строкам
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxindex = 0; //индекс
            int maxval = A[i, 0]; //нач знач макс элемента
            
            
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxval)
                {
                    maxval = A[i, j];
                    maxindex = j; 
                }
            }

            //меняем первый и максимальный
            if (maxindex != 0) // если макс эл не первый, то меняем
            {
                int temp = A[i, 0];
                A[i, 0] = A[i, maxindex];
                A[i, maxindex] = temp;
            }
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
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null; 
        }
        int maxi = A[0,0];
        int maxindex1 = 0;
        int maxindex2 = 0;
        for (int i = 0; i < A.GetLength(0); i ++)
        {
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i,j];
                    maxindex1 = i;
                    maxindex2 = j;
                }

            }
        }
        int[,] result = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        for (int i = 0, newi = 0; i < A.GetLength(0); i++)
        {
            if (i == maxindex1) continue; //пропуск строки
            for (int j = 0, newj = 0; j < A.GetLength(1); j++)
            {
                if (j == maxindex2) continue; //пропуск столбца
                result[newi, newj] = A[i, j];
                newj++;
            }
            newi++;
        }
        // end

        return result;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null; 
        }

        for (int i = 0; i < A.GetLength(0); i ++)
        {
            int maxi = 0;
            int maxival = A[i,0];
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if (A[i,j] > maxival)
                {
                    maxival = A[i,j];
                    maxi = j;
                }
            }
            A[i,maxi] *= i + 1;
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
        // if (D == null || D.GetLength(0) != n || D.GetLength(1) != m)
        // {
        //     return D; 
        // }
        for (int i = 0; i < n; i++)
        {
            int maxindex = -1; 
            int lastindex = -1; 
            int maxval = -9999999; 

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    break; 
                }
                if (D[i, j] > maxval)
                {
                    maxval = D[i, j];
                    maxindex = j; 
                }
            }

            //последний отриц
            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    lastindex = j; 
                    break; 
                }
            }
            //первый отриц(по заданию последний, но тесты прошли с первым)
            // for (int j = 0; j < m; j++)
            // {
            //     if (D[i, j] < 0)
            //     {
            //         lastindex = j; 
            //         break; 
            //     }
            // }

            
            if (maxindex != -1 && lastindex != -1)
            {
                int temp = D[i, maxindex];
                D[i, maxindex] = D[i, lastindex];
                D[i, lastindex] = temp;
            }
        }
        // end
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(D[i, j] + " ");
            }
            Console.WriteLine();
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
        // code here
        if (H == null || H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null; 
        }
        for (int i = 0; i < H.GetLength(0); i ++)
        {
            int maxj = 0;
            int maxval = H[i,0];
            for(int j = 0; j < H.GetLength(1) - 1; j ++)
            {
                if (H[i, j] > maxval)
                {
                    maxval = H[i,j];
                    maxj = j;
                }
                
            }
            //H[i, H.GetLength(1) - 2] = maxval;
            int temp = maxval;
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2]; //значение из предпоследнего записываем в последний
            H[i, H.GetLength(1) - 2] = temp; // макс эл записываем в предпоследний столбец
        }
        for (int i = 0; i < H.GetLength(0); i++)
        {
            for (int j = 0; j < H.GetLength(1); j++)
            {
                Console.Write(H[i, j] + " ");
            }
            Console.WriteLine();
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
        if (Y == null || Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return null; 
        }
        for (int i = 0; i < Y.GetLength(0); i ++)
        {
            int maxj = 0;
            double maxval = Y[i,0];
            for(int j = 0; j < Y.GetLength(1); j ++)
            {
                if (Y[i, j] > maxval)
                {
                    maxval = Y[i,j];
                    maxj = j;
                }
            }
            double avg = 0;
            double sum = 0;
            double number = 0;
            for(int j = maxj; j < Y.GetLength(1); j ++)
            {
                if (j == maxj) continue; //чтобы макс значение не включалось в расчет среднего знач
                if (Y[i,j] > 0)
                {
                    sum += Y[i,j];
                    number += 1;
                }
            }
            if (number != 0)
            {
                avg = sum / number;
            }
            
            for(int j = 0; j < maxj; j ++)
            {
                if (Y[i,j] < 0)
                {
                    //double temp = avg;
                    Y[i,j] = avg;
                }
            }
        }
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                Console.Write(Y[i, j] + " ");
            }
            Console.WriteLine();
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
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return null; 
        }
        int[] temp = new int[B.GetLength(0)];
        //for (int i = B.GetLength(0); i > 0; i --)
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int maxj = 0;
            int maxval = B[i,0];
            //for(int j = B.GetLength(1); j > 0; j --)
            for(int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxval)
                {
                    maxval = B[i,j];
                    maxj = j;
                }
            }
            temp[i] = maxval;
        }
        //замена 4 столбца в обратном порядке макс знач
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = temp[B.GetLength(0) - 1 - i]; //обр порядок(5 - 1 - 0 = 4 и тд по убыв)
        }
        // end
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
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
        // code here
        if (B == null || B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return null; 
        }

        int maxel = B[0,0];
        int maxind = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            
            if (B[i,i] > maxel)
            {
                maxel = B[i, i];
                maxind = i;
            }
        }
        int otric = -1;

        //поиск первой строки с отриц эл в 3 столб
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0) //3 столбец с индексом 2
            {
                otric = i;
                break; //останавливаемся на одной строке
            }
        }

        if (otric != -1)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                int temp = B[maxind, j];
                B[maxind, j] = B[otric, j];
                B[otric, j] = temp;
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
        //int[] answer = default(int[]);
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        
        int count = 0;
        for(int i = 0; i < A.GetLength(0); i ++)
        {
            for(int j = 0; j < A.GetLength(1); j ++)
            {
                if(A[i,j] < 0)
                {
                    count += 1;
                }
            }
        }
        int[] answer = new int[count];
        count = 0;
        for(int i = 0; i < A.GetLength(0); i ++)
        {
            for(int j = 0; j < A.GetLength(1); j ++)
            {
                if(A[i,j] < 0)
                {
                    answer[count] = A[i,j];
                    count ++;
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
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null; 
        }
        // double maxval = A[0,0];
        // int maxi = 0;
        // int maxj = 0;
        for(int i = 0; i < A.GetLength(0); i ++)
        {
            double maxval = A[0,0];
            int maxi = 0;
            int maxj = 0;
            for(int j = 0; j < A.GetLength(1); j ++)
            {
                if(A[i,j] > maxval)
                {
                    maxval = A[i,j];
                    maxi = i;
                    maxj = j;
                }
            }

            if (maxj > 0 && maxj < A.GetLength(1) - 1) 
            {
                double left = A[i, maxj - 1];
                double right = A[i, maxj + 1];

                if (left < right)
                {
                    if(left > 0)
                    {
                        A[i, maxj - 1] *= 2;
                    }
                    else
                    {
                        A[i, maxj - 1] /= 2;
                    }    
                }
                else
                {
                    if (A[i, maxj + 1] > 0)
                    {
                        A[i, maxj + 1] *= 2;
                    }
                    else
                    {
                        A[i, maxj + 1] /= 2;
                    }
                }
            }
            else if (maxj == 0)
            {
                if (A[i, 1] > 0)
                {
                    A[i, 1] *= 2;
                }
                else
                {
                    A[i, 1] /= 2;
                }
            }
            else if (maxj == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0)
                {
                    A[i, A.GetLength(1) - 2] *= 2;
                } 
                else
                {
                    A[i, A.GetLength(1) - 2] /= 2;
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null; 
        }
        // int countpol = 0;
        // int countotr = 0;
        // int maxi = 0;
        
        for(int j = 0; j < A.GetLength(1); j ++)
        {
            int countpol = 0;
            int countotr = 0;
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if(A[i,j] > 0)
                {
                    countpol += 1;
                }
                if(A[i,j] < 0)
                {
                    countotr += 1;
                }
                if(A[i,j] > A[maxi,j])
                {
                    maxi = i;
                }
            }
            if(countpol > countotr)
            {
                A[maxi,j] = 0;
            }
            if(countpol < countotr)
            {
                A[maxi,j] = maxi;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null; 
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxval = A[0, j];
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxval)
                {
                    maxval = A[i, j];
                    maxi = i;
                }
            }
            if (maxi < 5)
            {
                int sum = 0;
                for (int i = maxi + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        } 
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null; 
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxval = A[0, j];
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxval)
                {
                    maxval = A[i, j];
                    maxi = i;
                }
            }
            if (B[j] > maxval)
            {
                A[maxi, j] = B[j];
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null; 
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxval = A[0, j];
            int maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                
                if (A[i, j] > maxval)
                {
                    maxval = A[i, j];
                    maxi = i;
                }
            }
            double first = A[0, j];
            double last = A[A.GetLength(0) - 1, j];
            double sum = (first + last) / 2;
            if (maxval < sum)
            {
                A[maxi, j] = sum;
            }
            else
            {
                A[maxi, j] = maxi; 
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) 
        {
            return null;
        }
        int[,] answer = new int[n,n * 3];
        // code here
        // for (int i = 0; i < n; i++)
        // {
        //     // единичная матрица - на главной диагонали единицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // единичная матрица - на главной диагонали единицы
                if (i == j) 
                    answer[i, j] = 1; // первый n столбец
                if (i == j) 
                    answer[i, j + n] = 1; // второй n столбец
                if (i == j) 
                    answer[i, j + 2 * n] = 1; // третий n столбец
            }
        }

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                Console.Write(answer[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null; 
        }
        int maxi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > A[maxi, maxi])
            {
                maxi = i;
            } 
        }
        for (int i = 0; i < maxi; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null; 
        }
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int maxj1 = 0;
            int maxj2 = 0;
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, maxj1])
                {
                    maxj1 = j; //макс эл в 1 строке
                } 
                if (B[i + 1, j] > B[i + 1, maxj2])
                {
                    maxj2 = j; //макс эл во 2 строке
                } 
            }
            int temp = B[i, maxj1];
            B[i, maxj1] = B[i + 1, maxj2];
            B[i + 1, maxj2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null; 
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            // идем от начала к концу
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j]; // Меняем с данным эл с конца
                A[i, A.GetLength(1) - 1 - j] = temp; 
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null; 
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i % matrix.GetLength(0)] = 0;
            matrix[matrix.GetLength(0) - 1, i % matrix.GetLength(0)] = 0;
            matrix[i % matrix.GetLength(0), 0] = 0;
            matrix[i % matrix.GetLength(0), matrix.GetLength(0) - 1] = 0;
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null; 
        }
        for(int i = matrix.GetLength(0) - 1; i >= matrix.GetLength(0)/2; i --)
        {
            for(int j = matrix.GetLength(1) - 1; j >= 0; j --)
            {
                if(i >= j)
                {
                    matrix[i,j] = 1;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return default; 
        }
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int count = 0;
        int count2 = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i <= j)
                {
                    count ++;
                }
                else
                {
                    count2 ++;
                }
            }
        }
        upper = new int[count];
        lower = new int[count2];
        int up = 0;
        int low = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i <= j)
                {
                    upper[up] = matrix[i,j];
                    up ++;
                }
                else
                {
                    lower[low] = matrix[i,j];
                    low ++;
                }
            }
        }
        for (int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] + " ");
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
        if (matrix == null || matrix.GetLength(0) != 7 ||  matrix.GetLength(1) != 5)
        {
            return null; 
        }
        int count = 0;
        for (int i = 0; i <  matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                int count1 = 0, count2 = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[j, k] > 0) 
                    {
                        count1++;
                    }
                    if (matrix[j + 1, k] > 0)
                    {
                        count2++;
                    } 
                }
                if (count1 < count2) 
                {
                    int[] A = new int[matrix.GetLength(1)]; 
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        A[k] = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = A[k];
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
        // code here
        // if (matrix == null || matrix.GetLength(0) != 7 ||  matrix.GetLength(1) != 5)
        // {
        //     return null; 
        // }
        // //проходим по строкам
        // for(int i = 0; i < matrix.GetLength(0); i ++)
        // {
        //     //цикл по количеству проходов
        //     for(int j = 0; j < matrix.GetLength(1); j += 2)
        //     {
        //         //прохожим по элементам строк
        //         for (int k = 0; k < matrix.GetLength(1) - j - 2; k+= 1)
        //         {
        //             if(matrix[i,k] >= matrix[i, k + 2])
        //             {
        //                 int temp = matrix[i,k];
        //                 matrix[i,k] = matrix[i, k + 2];
        //                 matrix[i, k + 2] = temp;
        //             }
        //         }
        //     }
        // }
        // for(int i = 0; i < matrix.GetLength(0); i ++)
        // {
        //     for(int j = 0; j < matrix.GetLength(1); j ++)
        //     {
        //         for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
        //         {
        //             if(matrix[i,k] <= matrix[i, k + 1])
        //             {
        //                 int temp = matrix[i,k];
        //                 matrix[i,k] = matrix[i, k + 1];
        //                 matrix[i, k + 1] = temp;
        //             }
        //         }
        //     }
        // }
        // проходим по строкам
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                //колво проходов
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    //элементы
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {

                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
            // нечет
            else
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;

                    //перемещаем элементы большие ключа вперед
                    while (k >= 0 && matrix[i, k] < key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
            }
            else
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int key = matrix[i, j];
                    int k = j - 1;

                    // меньше - вперед
                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k--;
                    }
                    matrix[i, k + 1] = key;
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] answer = new int[matrix.GetLength(0) - count, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) 
                {
                    break;
                }
                answer[k, j] = matrix[i, j]; //в новую матрицу
            }
            k++;
            if (k >= matrix.GetLength(0) - count)  //достигает количества строк в новой матрице - break
            {
                break;
            }
        }
        matrix = answer;
        // end

        return matrix;
    }
    #endregion
}