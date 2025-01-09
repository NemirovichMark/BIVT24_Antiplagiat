using System.Collections;
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
        //program.Task_1_3(new int[,] {
        //{ 1, 2, 3, 4 },{ 5, 6, 7, 8 },{ 9, 10, 11, 12 },{ 13, 14, 15, 16 }});
        //program.Task_1_6(new int[,] {
        //        { 1, 2, 3, 4, 5, 6, 7 },
        //        { 5, 6, 7, 8, -9, 10, 11 },
        //        { 9, 10, -11, -12, -13, -14, -15 },
        //        { -13, -14, 15, 16, 17, 18, -19 }});
        //program.Task_1_9(new int[,] {
        //        { 1, 2, 3, 4, -5, -6, -7 },
        //        { 5, 11, -17, 11, -10, 6, 5 },
        //        { -9, -10, -11, -14, -15, -16, 1 },
        //        { -9, -10, -11, -14, -15, -6, -2 },
        //        { -9, -10, -11, -14, -15, 6, 4 } });
        //program.Task_1_12(new int[,] {
        //        { 1, 2, 3, 4, -5, -6, -7 },
        //        { 5, 11, -17, 11, -10, 6, 5 },
        //        { -9, -10, -11, -14, -15, -16, 1 },
        //        { -9, -10, -11, -14, 15, -6, -2 },
        //        { -9, -10, -11, -14, -15, 6, 4 },
        //        { 0, -2, -3, -4, -5, 0, 5 }});
        //program.Task_1_15(new int[,] {
        //        { 1, 2, -3, 4, -5, 6, 7 },
        //        { 5, 6, -7, 8, 9, -10, -11 },
        //        { 9, 10, 11, -12, 13, 14, 15 },
        //        { -13, 14, 15, 16, 17, -18, -19 },
        //        { 0, -1, -2, -3, -4, -5, -6 }});
        //program.Task_1_18(new int[,] {
        //        { 1, 2, -3, 4, -5, 6, 7 },
        //        { 5, 6, -7, 8, 9, -10, -11 },
        //        { 9, 10, 11, 12, 13, 14, 15 },
        //        { -13, 14, 15, 16, 17, -18, -19 },
        //        { 0, -1, -2, -3, -4, -5, -6 }}, 5, 7);
        //program.Task_1_21(new int[,] {
        //        { 1, 2, -3, 4, -5, 7, 0 },
        //        { 5, 6, -7, 8, 9, -11, 0 },
        //        { 9, 10, 11, 12, 13, 15, 0 },
        //        { -13, 14, 15, 16, 17, -19,0 },
        //        { 0, -1, -2, -3, -4, -6, 0 }});
        //program.Task_1_24(new double[,] {
        //        { 1, 2, -3, 4, -5 },
        //        { 5, 6, -7, 8, 9, },
        //        { 9, 10, 11, 12, 13 },
        //        { -13, 14, 25, 16, 11 },
        //        { 0, -1, -2, -3, -4 },
        //        { 1, -1, 2, -2, 3 }});
        //program.Task_1_27(new int[,] {
        //        { 1, 2, -3, 7, -5, 7, 7 },
        //        { 5, 6, -7, 8, 9, 9, -11 },
        //        { 9, 10, 11, 12, 13, 15, 15 },
        //        { -13, 14, 25, 25, 16, 17, -19 },
        //        { 0, 0, -1, -2, -3, -4, -6 }});
        //program.Task_1_30(new int[,] {
        //        { 1, 2, -3, 7, -5},
        //        { 5, 6, -7, 8, 9 },
        //        { 9, 10, 11, 12, 13 },
        //        { -13, 14, 25, 25, 16 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_1_33(new int[,] {
        //        { 1, 2, -3, 7, -5, 7, 7 },
        //        { 5, 6, -7, 8, 9, 9, -11 },
        //        { 9, 10, 11, 12, 13, 15, 15 },
        //        { -13, 14, 25, 25, 16, 17, -19 },
        //        { -6, -5, -1, -2, -3, -4, -6 }});
        //program.Task_2_1(new double[,] {
        //        { 1, 2, -3, 7, -5, 7, 7 },
        //        { 5, 6, -7, 8, 9, 9, -11 },
        //        { 9, 10, 11, 12, 13, 15, 15 },
        //        { -13, -30, 25, 25, 16, 17, -19 },
        //        { -6, -5, -1, -2, -3, -4, -6 }});
        //program.Task_2_2(new int[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 25, 25, -19 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_2_3(new int[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 2, 3, -19 },
        //        { 1, 2, -3, 7, 0 },
        //        { 5, 0, -1, 9, -1 },
        //        { 9, 10, 11, 2, 15 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_2_4(new int[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 25, 25, -19 },
        //        { 0, 0, -1, -2, -3 }},
        //        new int[] { 10, 20, 30, 0, -50 });
        //program.Task_2_5(new double[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 25, 25, -19 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_2_6(3);
        //program.Task_2_7(new int[,] {
        //        { 1, 2, -3, 7, 7, 0 },
        //        { 5, 6, -7, 9, -11, 1 },
        //        { 9, 10, 11, 15, 15, 2 },
        //        { -13, 14, 25, 25, -19, 3 },
        //        { 5, 6, -7, 8, 9, 4},
        //        { 0, 0, -1, -2, -3, 5 }});
        //program.Task_2_8(new int[,] {
        //        { 1, 2, -3, 7, 7, 0 },
        //        { 5, 6, -7, 9, -11, 1 },
        //        { 9, 10, 11, 15, 15, 2 },
        //        { -13, 14, 25, 25, -19, 3 },
        //        { 5, 6, -7, 8, 9, 4},
        //        { 0, 0, -1, -2, -3, -5 }});
        //program.Task_2_9(new int[,] {
        //        { 1, 2, -3, 7, 7, 0, -2 },
        //        { 5, 6, -7, 9, -11, 1, 3 },
        //        { 9, 10, 11, 15, 15, 2, 5 },
        //        { -13, 14, 25, 25, -19, 3, -7 },
        //        { 5, 6, -7, 8, 9, 4, 4},
        //        { 0, 0, -1, -2, -3, -5, 0 }});
        //program.Task_3_2(new int[,] {
        //        { 1, 2, -3, 7, 7, 0 },
        //        { 5, 6, -7, 9, -11, 1 },
        //        { 9, 10, 11, 15, 15, 2 },
        //        { -13, 14, 25, 25, -19, 3 },
        //        { 5, 6, -7, 8, 9, 4},
        //        { 0, 0, -1, -2, -3, 5 }});
        //program.Task_3_4(new int[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_3_6(new int[,] {
        //        { 1, 2, -3, 7, 7, 0 },
        //        { 5, 6, -7, 9, -11, 1 },
        //        { 9, 10, 11, 15, 15, 2 },
        //        { -13, 14, 5, 25, -19, 3 },
        //        { 5, 6, -7, 8, -99, 4},
        //        { 0, 0, -1, -2, -3, 5 }});
        //program.Task_3_8(new int[,] {
        //        { 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 25, 25, -19 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_3_10(new int[,] {
        //        { 1,      2,     -3,     7,      -5,     7,       7 },
        //        { 5,      6,     -7,     8,       9,     9,      -11 },
        //        { 9,      10,    11,     12,     13,     15,      15 },
        //        { -13,   -30,    25,     25,     16,     17,     -19 },
        //        { -6,    -5,     -1,     -2,     -3,     -4,     -6 }});
        //program.Task_3_11(new int[,] {
        //        { 1,      2,      -3,     7,      -5,     7,       7 },
        //        { 5,      6,      -7,     8,       9,     9,      -11  },
        //        { 9,      10,     11,     12,     13,     15,     15 },
        //        { -13,    0,      25,     25,     16,     0,      -19 },
        //        { -6,     -5,     -1,     -2,     -3,     -4,      0 }});

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

        if (A == null || A.GetLength(0) != A.GetLength(1))
        {
            return 0;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            answer += A[i, i];
            //answer += A[i, n - i - 1];
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
        int[] answer = default(int[]);

        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1); 
        answer = new int [strok];

        if (A == null || strok != 4 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemin = 999;
            int indmin = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] < elemin)
                {
                    elemin = A[i, j];
                    indmin = j;
                }
            }
            answer[i] = indmin;
        }
        Console.Write("Искомый массив: ");
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
        }
        Console.WriteLine();

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

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemax = -999, indmax = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = j;
                }
            }
            A[i, indmax] = A[i, 0];
            A[i, 0] = elemax;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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

        int strok = A.GetLength(0), stolb = A.GetLength(1);             
        
        if (A == null || strok != 6 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        int indmax = 0, jndmax = 0, elemax = -999;
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                    jndmax = j;
                }
            }
        }
        Console.WriteLine("Макс элемент: " + A[indmax, jndmax]);
        Console.WriteLine("Находится в строке " + (indmax+1) + " в столбце " + (jndmax+1));

        int[,] answer = new int[strok - 1, stolb - 1];
        for (int i = 0, a = 0; i < strok; i++)
        {
            if (i == indmax) continue;                   //пропуск строки
            for (int j = 0, b = 0; j < stolb; j++)
            {
                if (j == jndmax) continue;               //пропуск столбца
                answer[a, b] = A[i, j];
                b++;
            }
            a++;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok-1; i++)
        {
            for (int j = 0; j < stolb-1; j++)
                Console.Write(answer[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        A = answer;

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

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        int indmax = 0, jndmax = 0;
        for (int i = 0; i < strok; i++)
        {
            int elemax = -999;
            for (int j = 0 ; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                    jndmax = j;
                }
            }
            A[indmax, jndmax] *= (i + 1);
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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

        Console.WriteLine("Исходная матрица:");     // массив до
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)                 // для каждой строки поочередно
        {
            int jotrfirst = -1, jotrlast = -1;
            int elemax = -999, jndmax = -1;

            for (int j = 0; j < m; j++)             // поиск первого отрицательного
            {
                if (D[i, j] < 0)
                {
                    jotrfirst = j;
                    break;
                }
            }
            for (int j = 0; j < jotrfirst; j++)     // поиск максимального до первого отриц.
            {
                if (D[i, j] > elemax)
                {
                    elemax = D[i, j];
                    jndmax = j;
                }
            }
            for (int j = (m-1); j >= 0; j--)        // поиск последнего отрицательного
            {
                if (D[i, j] < 0)
                {
                    jotrlast = j;
                    break;
                }
            }
            if (jotrfirst <= 0)                     // если отрицательных нет, то продолжить
            {
                continue;
            }
            else                                    // замена 
            { 
                D[i, jndmax] = D[i, jotrlast];
                D[i, jotrlast] = elemax;
            }            
        }             

        Console.WriteLine("Искомая матрица:");      // массив после
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
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

        int strok = H.GetLength(0), stolb = H.GetLength(1);

        if (H == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(H[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemax = -999;
            for (int j = 0; j < stolb; j++)
            {
                if (H[i, j] > elemax)
                {
                    elemax = H[i, j];
                }
            }            
            H[i, stolb - 1] = H[i, stolb - 2];
            H[i, stolb - 2] = elemax;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(H[i, j] + " ");
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

        int strok = Y.GetLength(0), stolb = Y.GetLength(1);

        if (Y == null || strok != 6 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(Y[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            double elemax = -999, srednee = 0, k = 0; 
            int jndmax = 0;
            for (int j = 0; j < stolb; j++)            // поиск максимального
            {
                if (Y[i, j] > elemax)
                {
                    elemax = Y[i, j];
                    jndmax = j;
                }
            }
            for (int j = jndmax+1; j < stolb; j++)     // поиск среднего
            {
                if (Y[i, j] >= 0)
                {
                    k++;
                    srednee += Y[i, j];
                }                
            }
            if (srednee > 0)                           // вычисление среднего
                srednee = srednee / k;
            else
                srednee = 0;
            for (int j = 0; j < jndmax; j++)           // замена
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = srednee;
                }
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(Y[i, j] + " ");
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

        int strok = B.GetLength(0), stolb = B.GetLength(1);
        int[] array = new int[strok];

        if (B == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemax = -999;
            for (int j = stolb-1; j >= 0; j--)           
            {
                if (B[i, j] > elemax)
                {
                    elemax = B[i, j];
                }
            }
            array[i] = elemax;            
        }
        for (int i = 0; i < strok; i++)
        {
            B[i, 3] = array[strok - i - 1];
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
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

        int strok = B.GetLength(0), stolb = B.GetLength(1);
        int elemax = -999, indmax = 0, indotr = 0, reserv = 0;

        if (B == null || strok != 5 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)      // поиск строки с максимальным на диагонали
        {
            if (B[i, i] > elemax)
            {
                elemax = B[i, i];
                indmax = i;
            }
        }
        for (int i = 0; i < strok; i++)      // поиск строки с первым отрицательным 
        {                                    // в 3-м столбце
            if (B[i, 2] < 0)
            {
                indotr = i;
                break;
            }
        }
        for (int j = 0; j < strok; j++)      // замена двух строк
        {
            reserv = B[indmax, j]; 
            B[indmax, j] = B[indotr, j]; 
            B[indotr, j] = reserv;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
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

        int strok = A.GetLength(0), stolb = A.GetLength(1), k = 0;

        if (A == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }    
        }
        answer = new int[k];
        for (int i = strok-1; i >= 0; i--)
        {
            for (int j = stolb-1; j >= 0; j--)
            {
                if (A[i, j] < 0)
                {
                    k--;
                    answer[k] = A[i, j];
                }
            }
        }

        Console.WriteLine("Искомый массив:");
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
        }
        Console.WriteLine();

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            double elemax = -999;
            int jndmax = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    jndmax = j;
                }
            }

            if (jndmax == 0 || A[i, jndmax - 1] > A[i, jndmax + 1])
            {
                if (A[i, jndmax + 1] > 0)
                    A[i, jndmax + 1] *= 2;
                else if (A[i, jndmax + 1] < 0)
                    A[i, jndmax + 1] /= 2;
            }
            else if (jndmax == stolb - 1 || A[i, jndmax - 1] < A[i, jndmax + 1])
            {
                if (A[i, jndmax - 1] > 0)
                    A[i, jndmax - 1] *= 2;
                else if (A[i, jndmax - 1] < 0)
                    A[i, jndmax - 1] /= 2;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 7 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int j = 0; j < stolb; j++)
        {
            int kolvopol = 0, kolvootr = 0;
            int elemax = -999, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
                if (A[i, j] >= 0) kolvopol += 1;
                else kolvootr += 1;
            }
            for (int i = 0; i < strok; i++)
            {
                if (kolvopol > kolvootr)
                    A[indmax, j] = 0;
                else
                    A[indmax, j] = indmax + 1;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 10 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int j = 0; j < stolb; j++)
        {
            int elemax = -999, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
            }
            if (indmax < (strok / 2))
            {
                int sum = 0;
                for (int i = indmax + 1; i < strok; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }

        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1), dlina = B.Length;

        if (A == null || strok != 7 || stolb != 5 || B == null || dlina != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < dlina; i++)
        {
            Console.Write(B[i] + " ");
        }
        Console.WriteLine();

        for (int j = 0; j < stolb; j++)
        {
            int elemax = -999, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
            }
            if (elemax < B[j])
            {
                A[indmax, j] = B[j];
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here        

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 7 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int j = 0; j < stolb; j++)
        {
            double elemax = -999; 
            int indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
            }
            double polysumma = (A[0,j] + A[strok-1,j]) / 2;
            if (polysumma > elemax) { A[indmax, j] = polysumma; }
            else { A[indmax, j] = indmax+1; }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);

        // code here

        if (n <= 0)
        {
            return null;
        }
        answer = new int[n, n * 3];

        int strok = answer.GetLength(0), stolb = answer.GetLength(1), k = n, zanovo = 0;

        for (int j = 0; j < stolb; j++)
        {
            for (int i = 0; i < strok; i++)
            {
                if (k == n) 
                {
                    answer[i, j] = 1;
                    k = 0;
                    zanovo += 1;
                }
                else
                {
                    answer[i, j] = 0;
                    k += 1;
                }
                if (zanovo == n) 
                { 
                    k = n;
                    zanovo = 0;
                }
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(answer[i, j] + " ");
            Console.WriteLine();
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here 

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 6 || stolb != 6)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        int elemax = -999, indmax = 0;
        for (int j = 0; j < stolb; j++)
        {            
            if (A[j, j] > elemax)
            {
                elemax = A[j, j];
                indmax = j;
            }
        }

        for (int i = 0; i < indmax; i++)
        {
            for (int j = 1; j < stolb; j++)
            {
                if (j > i) 
                    A[i, j] = 0;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        
        int strok = B.GetLength(0), stolb = B.GetLength(1);
        
        if (B == null || strok != 6 || stolb != 6)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i+=2)
        {
            int elemax1 = -999, elemax2 = -999, jnd1 = 0, jnd2 = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (B[i, j] > elemax1)
                {
                    elemax1 = B[i, j];
                    jnd1 = j;
                }
                if (B[i+1, j] > elemax2)
                {
                    elemax2 = B[i+1, j];
                    jnd2 = j;
                }
            }
            B[i, jnd1] = elemax2;
            B[i+1, jnd2] = elemax1;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here 

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 6 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int reserv = 0;
            for (int j = 0; j < stolb/2; j++)
            {
                reserv = A[i, j];
                A[i, j] = A[i, stolb - j -1];
                A[i, stolb - j - 1] = reserv;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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
        // code here

        int n = matrix.GetLength(0);

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, 0] = 0;
                    matrix[i, n - 1] = 0;
                }
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
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

        int n = matrix.GetLength(0);

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
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
        int[] upper = default(int[]);
        int[] lower = default(int[]);

        // code here

        int n = matrix.GetLength(0), nomerupper = 0, nomerlower = 0;

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (null, null);
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        upper = new int[n * n / 2 + n / 2]; 
        lower = new int[n * n - n * n / 2 - n / 2];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                    upper[nomerupper++] = matrix[i, j];
                else
                    lower[nomerlower++] = matrix[i, j];
            }
        }

        Console.WriteLine("Элементы верхнего треугольника:");
        for (int i = 0; i < upper.Length; i++)
        {
            Console.Write(upper[i] + " "); 
        }
        Console.WriteLine();
        Console.WriteLine("Элементы нижнего треугольника:");
        for (int i = 0; i < lower.Length; i++)
        {
            Console.Write(lower[i] + " ");
        }
        Console.WriteLine();

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

        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);

        if (matrix == null || strok != 7 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok-1; i++)
        {
            int kolvootriz1 = 0, kolvootriz2 = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] < 0)
                    kolvootriz1++;
            }
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i+1, j] < 0)
                    kolvootriz2++;
            }
            if (kolvootriz1 > kolvootriz2)
            {
                int reserv = 0;
                for (int j = 0; j < stolb; j++)
                {
                    reserv = matrix[i+1, j];
                    matrix[i+1, j] = matrix[i, j];
                    matrix[i, j] = reserv;
                }
                i = -1;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
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

        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);

        if (matrix == null)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i += 2)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[i, j], k = j - 1;
                while (k >= 0 && matrix[i, k] < key)
                {
                    matrix[i, k + 1] = matrix[i, k];
                    k--;
                }
                matrix[i, k + 1] = key;
            }
        }
        for (int i = 1; i < strok; i += 2)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[i, j], k = j - 1;
                while (k >= 0 && matrix[i, k] > key)
                {
                    matrix[i, k + 1] = matrix[i, k];
                    k--;
                }
                matrix[i, k + 1] = key;
            }
        }
        if (strok / 2 == 0)
        {
            for (int j = 1; j < stolb; j++)
            {
                int key = matrix[strok - 1, j], k = j - 1;
                while (k >= 0 && matrix[strok - 1, k] < key)
                {
                    matrix[strok - 1, k + 1] = matrix[strok - 1, k];
                    k--;
                }
                matrix[strok - 1, k + 1] = key;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
        int minusstrok = 0;

        if (matrix == null)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] == 0)
                {
                    minusstrok++;
                    break;
                }
            }
        }
        int[,] array = new int[strok - minusstrok, stolb];
        for (int i = 0, k = 0; i < strok; i++)
        {
            int flag = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag++;
                    break;
                }
            }
            for (int j = 0; j < stolb; j++)
            {
                if (flag == 0)
                    array[k, j] = matrix[i, j];
            }
            if (flag == 0)
                k++;
        }

        matrix = array;

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok - minusstrok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return matrix;
    }
    #endregion
}