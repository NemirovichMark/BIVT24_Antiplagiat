using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Pipes;
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
        double s = 0;
        int count = 0;
        // code here
        for(int i = 0;i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1);j++)
            {
                if(A[i,j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
        }
        if (count > 0)
        {
            answer = s / count * 1.0;
        }
        
            

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

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        for(int i = 0;i < A.GetLength(0); i++)
        {
            if( A[i,colIndex] < 0)
            {
                value = A[i,colIndex];
                rowIndex = i;
                break;
            }
            else
            {
                rowIndex = 0;
            }
        }
        
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

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here
        answer = new double[A.GetLength(0)];
        for(int i = 0; i < A.GetLength(0); i ++)
        {
            int count = 0;
            double s = 0;
            for (int j = 0; j < A.GetLength(1); j ++)
            {
                if( A[i,j] > 0)
                {
                    s += A[i, j];
                    count++;   
                }
            }
            if (count == 0)
                answer[i] = 0;
            else
                answer[i] = s/count;
        }
        if (A.GetLength(0) != 4 && (A.GetLength(1) != 6))
            return default(double[]);
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

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        int Index = -1 ;
        int minElem = 0;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i,0] < minElem)
            {
                minElem = A[i, 0];
                Index = i;
            }
        }
        int[,] newA = new int[A.GetLength(0) - 1, A.GetLength(1)];
        if(Index != -1)
        {
            for (int i = 0; i < A.GetLength(0) - 1; i++)
            {
                if (i < Index)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        newA[i, j] = A[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        newA[i, j] = A[i + 1, j];
                    }
                }
            }
        }
        else
        {
            return default(int[,]);
        }
        A = newA;
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

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 4 && (A.GetLength(1) != 3))
            return default(int[]);

        answer = new int[A.GetLength(1)];
        for(int i = 0; i < A.GetLength(1); i++)
        {
            int countnegativeelem = 0;
            for(int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    countnegativeelem++;
                }
            }
            answer[i] = countnegativeelem;
        }
        
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

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        n = B.GetLength(0);
        m = B.GetLength(1);
        for(int i = 0; i < n; i++)
        {
            int minelem = 0;
            for (int j = 1; j < m; j++)
            {
                if(B[i, j] < minelem)
                {
                    minelem = j;
                }
            }
            int minzn = B[i, minelem];
            for (int j = minelem; j > 0; j--) //сдвиг элементов вправо для освобождения места 
            {
                B[i, j] = B[i, j - 1]; // сдвиг вправо 
            }
            B[i, 0] = minzn;//в начало строки
        }
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

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        n = F.GetLength(0);
        m = F.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            double maxelem = -1000; 
            int maxIndex = -1;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxelem)
                {
                    maxelem = F[i, j];
                    maxIndex = j; 
                }
            }

            double oneotr = 0, twootr = 0;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    oneotr = F[i, j];
                    break;
                }
            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    twootr = F[i, j];
                    break;
                }
            }

            double sum = 0;
            if (oneotr != 0 && twootr != 0)
            {
                sum = (oneotr + twootr) / 2;
            }

            if (maxIndex != -1 && sum != 0) // добавляем проверку на наличие максимального элемента
            {
                F[i, maxIndex] = sum; // обновляем значение максимального элемента
            }
        }
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

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        if (G.GetLength(0) != 5 && G.GetLength(1) != 7)
            return default(int[,]);

        for (int i = 0; i < G.GetLength(0); i++)
        {
            int maxzn = int.MinValue;
            int maxIndex = -1;
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                if (G[i, j] > maxzn)
                {
                    maxzn = G[i, j];
                    maxIndex = j;
                }
            }
            for(int j = G.GetLength(1) - 1; j > maxIndex+1; j--)
            {
                G[i,j] = G[i,j-1];
            }
            G[i, maxIndex + 1] = maxzn;
        }


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

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
            return default(int[,]);
        if (B.Length != 7)
            return default(int[,]);
        int Index = 0;
        int maxElem = int.MinValue;
        for(int i = 0; i <  A.GetLength(0); i++)
        {
            if (A[i, 5] > maxElem )
            {
                maxElem = A[i, 5];
                Index = i;
            }
        }
        for(int i = 0; i < A.GetLength(0);i++)
        {
            if (i == Index)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = B[j];
                }
            }
        }
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

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        if (F.GetLength(0) != 5 && F.GetLength(1) != 7)
            return default(int[,]);
        int Index = -1;
        int minElem = int.MaxValue;
        for(int i = 0; i < F.GetLength(1); i++)
        {
            if (Math.Abs(F[1, i]) < minElem)
            {
                minElem = Math.Abs(F[1, i]);
                Index = i;
            }
        }
        int[,] newF = new int[F.GetLength(0), F.GetLength(1) - 1];
        for(int i = 0; i < F.GetLength(0); i++)
        {
            for(int j = 0; j < F.GetLength(1); j++)
            {
                if(j < Index + 1)
                {
                    newF[i, j] = F[i, j];
                }
                else if(j > Index + 1)
                {
                    newF[i, j-1] = F[i, j];
                }
            }
        }
        F = newF;
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

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
            return null;
        int n = A.GetLength(0), m = A.GetLength(1);
        
        for(int i = 0; i < n; i++)
        {
            double avg = 0;
            double maxElem = A[i, 0];
            int indexMaxElem = 0;
            double posSum = 0;
            int count = 0;

            for(int j = 0;j < m; j++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    indexMaxElem = j;
                }
                if (A[i, j] > 0)
                {
                    posSum += A[i, j];
                    count++;
                }
            }
            if (count != 0)
               avg = posSum / count;

            A[i, indexMaxElem] = avg;
        }
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
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
            return null;

        int n = A.GetLength(0), m = A.GetLength(1);

        for(int i = 0; i < n; i++)
        {
            double maxElem = A[i, 0];
            int indexMaxElem = 0;
            for (int j = 0; j < m; j++)
            {
                if(A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    indexMaxElem = j;
                }
            }
            if(indexMaxElem == 0)
            {
                if (A[i, indexMaxElem + 1] < 0)
                    A[i, indexMaxElem + 1] /= 2;
                else
                    A[i, indexMaxElem + 1] *= 2;
            }
            else if (indexMaxElem == m - 1)
            {
                if (A[i, indexMaxElem - 1] < 0)
                    A[i, indexMaxElem - 1] /= 2;
                else
                    A[i, indexMaxElem - 1] *= 2;
            }
            else
            {
                if(A[i, indexMaxElem + 1] < A[i, indexMaxElem - 1])
                {
                    if (A[i, indexMaxElem + 1] < 0)
                        A[i, indexMaxElem + 1] /= 2;
                    else
                        A[i, indexMaxElem + 1] *= 2;
                }
                else
                {
                    if (A[i, indexMaxElem - 1] < 0)
                        A[i, indexMaxElem - 1] /= 2;
                    else
                        A[i, indexMaxElem - 1] *= 2;

                }
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5)
            return null;
        for(int j = 0; j < A.GetLength(1); j++)
        {
            int countpol = 0;
            int countotr = 0;
            int maxElem = A[0,0];
            int Index = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                {
                    countpol++;
                }
                if (A[i, j] < 0)
                {
                    countotr++;
                }
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    Index = i;

                }
            }
            
            if(Index >= 0)
            {
                if (countpol > countotr)
                {
                    A[Index, j] = 0;
                }
                else
                {
                    A[Index, j] = Index + 1;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 && A.GetLength(1) != 5)
            return null;
        for(int j = 0; j < A.GetLength(1); j++)
        {
            int maxElem = A[0, 0];
            int Index = -1;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] > maxElem)
                {
                    maxElem = A[i, j];
                    Index = i;
                }
            }
            if(Index < A.GetLength(0) / 2)
            {
                int sum = 0;
                for(int i = Index + 1; i< A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0,j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5)
            return null;
        if (B.Length != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxElem = A[0,0];
            int Index = -1;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j] > maxElem)
                {
                    maxElem = A[i, j];
                    Index = i;
                }
            }
            if (B[j] > maxElem)
            {
                A[Index,j] = B[j];
            }
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5)
            return null;
        for(int j = 0; j < A.GetLength(1); j++)
        {
            double maxElem = A[0,0];
            int Index = -1;
            for(int i = 0; i < A.GetLength(0);i++)
            {
                if (A[i,j] > maxElem)
                {
                    maxElem = A[i, j];
                    Index = i;
                }
            }
            double firstElem = A[0,j];
            double lastElem = A[A.GetLength(0) - 1,j];
            double sum = (firstElem + lastElem) / 2;
            if(maxElem < sum)
            {
                A[Index, j] = sum;
            }
            else
            {
                A[Index, j] = Index + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3)
            return answer;
        answer = new int[n, n * 3];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < n * 3;j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    answer[i, j] = 1;
                else
                    answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 6)
            return null;
        int maxElem = A[0, 0];
        int index = -1;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxElem)
            {
                maxElem = A[i, i];
                index = i;
            }
        }
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if(i < index)
            {
                for(int j = 0;j < A.GetLength(0);j++)
                {
                    if(i != j && j > i)
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
        // code here
        if (B.GetLength(0) != 6 && B.GetLength(1) != 6)
            return null;
        int[] arr = new int[6];
        for(int i = 0; i < B.GetLength(0); i++)
        {
            int maxElem = -100;
            int index = -1;
            for (int j = 0;j < B.GetLength(0); j++)
            {
                if (B[i, j] > maxElem)
                {
                    maxElem= B[i, j];
                    index = j;
                }
            }
            arr[i] = index;
            
        }
        for(int i = 0;i < B.GetLength(0) - 1; i+= 2)
        {
            int temp = B[i, arr[i]];
            B[i, arr[i]] = B[i + 1, arr[i + 1]];
            B[i + 1, arr[i + 1]] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 7)
            return null;
        for( int i = 0; i <  A.GetLength(0);i++)
        {
            for(int j = 0; j <  A.GetLength(1)/ 2;j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(0) - j];
                A[i, A.GetLength(0) - j] = temp;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        for(int i = 0; i < matrix.GetLength(0) * matrix.GetLength(0); i++)
        {
            int stroka = i / matrix.GetLength(0);
            int stolbec = i % matrix.GetLength(1);
            if(stroka == 0 || stroka == matrix.GetLength(0)- 1 || stolbec == 0 || stolbec == matrix.GetLength(0) - 1)
            {
                matrix[stroka, stolbec] = 0;
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
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return null;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0;  j < matrix.GetLength(0); j++)
            {
                if(i >= j && i >= matrix.GetLength(0) / 2)
                {
                    matrix[i, j] = 1;
                }
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
        if(matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);
        upper = new int[matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2];
        lower = new int[(matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2) - matrix.GetLength(0)];
        int count = 0; int count2 = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(0); j++)
            {
                if(i <= j)
                {
                    upper[count] = matrix[i, j];
                    count++;
                }
                else
                {
                    lower[count2] = matrix[i, j];
                    count2++;
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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5)
            return default(int[,]);
        int[] countpolozh = new int[matrix.GetLength(0)];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1);j++)
            {
                if(matrix[i, j] > 0)
                {
                    countpolozh[i]++;
                }
            }
        }
        int maxzn = countpolozh[0];
        int index = 0;
        for(int i = 0;i < matrix.GetLength(0);i++)
        {
            if(countpolozh[i] > maxzn)
            {
                maxzn = countpolozh[i];
                index = i;
            }
        }
        for(int i =0; i < matrix.GetLength(0) - 1;i++)
        {
            for(int j = 0;j < matrix.GetLength(0) - 1 - i; j++)
            {
                if (countpolozh[j] < countpolozh[j+1])
                {
                    for(int g = 0;g < matrix.GetLength(1); g++)
                    {
                        int temp = matrix[j, g];
                        matrix[j, g] = matrix[j+1, g];
                        matrix[j+1, g] = temp;
                    }
                    int temp2 = countpolozh[j];
                    countpolozh[j] = countpolozh[j + 1];
                    countpolozh[j+1] = temp2;
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
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for(int g = 0; g < matrix.GetLength(1) - j - 1; g++)
                {
                    if(i % 2 == 0)
                    {
                        if(matrix[i, g] < matrix[i, g+1])
                        {
                            int temp = matrix[i, g];
                            matrix[i,g] = matrix[i, g+1];
                            matrix[i, g+1] = temp;
                        }
                    }
                    else
                    {
                        if(matrix[i, g] > matrix[i, g + 1])
                        {
                            int temp2 = matrix[i, g];
                            matrix[i, g] = matrix[i, g + 1];
                            matrix[i, g + 1] = temp2;
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
        // code here
        int count0 = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            bool zero = false;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if(!zero)
            {
                count0++;
            }
        }
        int[,] newmatrix = new int[count0, matrix.GetLength(1)];
        int currow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool zero = false;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    zero = true;
                    break;
                }
            }
            if (!zero)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newmatrix[currow, j] = matrix[i, j];
                }
                currow++;
            }
        }
        matrix = newmatrix;
        // end

        return matrix;
    }
    #endregion
}