using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[] m = { 1, 3, 8, 2, 6, 2, -1, 5 };
        prM(m);
        prM(bubleSort(m));

        int[] m2 = { 1, 3, 8, 2, 6, 2, -1, 5 };
        prM(m2);
        //prM(GnomSort(m2));

        int[] m3 = { 8, 1, 2, 3, 4, 5, 6 };
        prM(Vstavkami(m3));

        prM(vstavkami5(new int[] { 5, 3, 2, 7, 5, 2, 7, 3, 2, -1 }));
    }
    static void prM(int[] m, string pr="")
    {
        Console.Write(pr);
        for (int i = 0; i < m.Length; i++)
        {
            
            Console.Write(m[i]);
            Console.Write(" ");
        }
        Console.WriteLine("");
    }
    static int[] bubleSort(int[] m)
    {
        for(int i =0; i < m.Length; i++)
        {
            for(int j = 0; j < m.Length-1; j++)
            {
                if (m[j] > m[j+1])
                {
                    int temp = m[j];
                    m[j] = m[j+1];
                    m[j+1] = temp;
                }
            }
        }
        return m;
    }

    static int[] GnomSort(int[] m)
    {
        
            for (int j = 0; j < m.Length-1; j++)
            {

                
                if (m[j] > m[j+1])
                {
                    
                    int temp = m[j];
                    m[j] = m[j+1];
                    m[j+1] = temp;
                    
                    for (int i = j-1; i >= 0; i--)
                    {
                    
                       
                        if (m[i] > m[i+1])
                        {

                            int temp2 = m[i];
                            m[i] = m[i+1];
                            m[i+1] = temp2;
                        }
                        else
                        {
                            
                            break;
                        }
                    }
                }
            }
        
        return m;
    }
    static int[] vstavkami4(int[] m)
    {
        int n = m.Length;
        for(int i = 0; i < n; i++)
        {
            int temp = m[i];
            int j = i -1;
            while(j >= 0 && temp < m[j])
            {
                m[j + 1] = m[j];
                j--;
            }
            m[j + 1] = temp;
        }
        return m;
    }
    static int[] vstavkami5(int[] m)
    {

        int n = m.Length;
        int gap = n/2;
        while (gap > 0)
        {
            for (int i = 1; i < n; i++)
            {

                int temp = m[i];
                int j = i-gap;
                while (j >= 0 && m[j] > temp)
                {
                    m[j + gap] = m[j];
                    j -= gap;
                }
                m[j + gap] = temp;
            }
            gap = gap /2;

        }
        return m;

    }
    static int[] vstavkami2(int[] m)
    {
        int n = m.Length;
        for(int i = 1; i < n; i++)
        {
            int key = m[i];
            int j = i - 1;
            while(j >= 0 && m[j] > key)
            {
                m[j + 1] = m[j];
                j--;
            }
            m[j + 1] = key;

        }
        return m;
    }
    static int[] Vstavkami(int[] m)
    {
       
        int n = m.Length;
        int gap = n/2;
        while (gap > 0)
        {


            for (int i = gap; i < n; i++)
            {
                int key = m[i];
                int j = i - gap;
                while (j >= 0 && m[j] > key)
                {
                    m[j + gap] = m[j];
                    j -= gap;
                }
                m[j + gap] = key;
            }
            gap = gap/2;
        }
        return m;

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


        if (A.GetLength(0) != A.GetLength(1) || A.GetLength(1) != 4)
        {
            return 0;
        }
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
        int[] answer = new int[A.GetLength(0)];
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int minN = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < A[i, minN])
                {
                    minN = j;
                }
            }
            answer[i] = minN;

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int indMin = -1;
            int minV = -99999999;
            
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (minV < A[i, j])
                {
                    minV = A[i, j];
                    indMin = j;
                }
            }
            A[i, indMin] = A[i, 0];
            A[i, 0] = minV;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[,] res = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
        // code here

        int indX = -1;
        int indY = -1;
        int maxV = -999999999;
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if ((maxV < A[i, j]))
                {
                    indX = i;
                    indY = j;
                    maxV = A[i, j];
                    
                }
            }
        }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                if (i < indX && j < indY)
                {
                    res[i, j] = A[i, j];
                }
                if (i < indX && j >= indY)
                {
                    res[i, j] = A[i, j + 1];
                }
                if (i >= indX && j < indY)
                {
                    res[i, j] = A[i + 1, j];
                }
                if (i >= indX && j >= indY)
                {
                    res[i, j] = A[i + 1, j + 1];
                }
            }
        }

        return res;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {

            int maxi = -1;
            int maxj = -1;
            int maxV = -9999999;
            
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxV < A[i, j])
                {
                    maxi = i;
                    maxj = j;
                    maxV = A[i, j];
                    
                }

            }
            A[maxi, maxj] = A[maxi, maxj] * (i + 1);
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
        for (int i = 0; i < n; i++)
        {
            int jMinus = -1;
            int jV = -1;
            int maxV = -99999999;
            
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    jMinus = j;
                }
                if (jMinus == -1 && D[i, j] > maxV)
                {
                    jV = j;
                    maxV = D[i, j];
                    
                }
            }
            if (jV != -1 && jMinus != -1 )
            {
                int temp = D[i, jV];
                D[i, jV] = D[i, jMinus];
                D[i, jMinus] = temp;
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
        // code here
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < H.GetLength(0); i++)
        {
            int maxV = -99999999;

            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (j != H.GetLength(1) - 1 && H[i, j] > maxV)
                {
                    maxV = H[i, j];
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = maxV;
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
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double sum = 0;
            int inndM = -1;
            double maxV = -999999;
            
            
            int n = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if ((Y[i, j] > 0))
                {
                    sum += Y[i, j];
                    n++;
                }
                if (Y[i, j] > maxV)
                {
                    sum = 0;
                    n = 0;
                    maxV = Y[i, j];
                    inndM = j;
                }

            }

            double avr;
            if (n == 0)
            {
                avr = 0;

            }
            else
            {
                avr = sum / (5 - inndM - 1);
            }
            for (int j = 0; j < inndM; j++)
            {
                if (Y[i, j] < 0)
                {
                    Y[i, j] = avr;
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
        // code here
        
        int[] mat = new int[B.GetLength(0)];
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int maxV = -999999;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxV)
                {
                    maxV = B[i, j];
                }
            }
            mat[i] = maxV;
        }
        for (int i = 0; i < B.GetLength(0) / 2; i++)
        {
            int temp = mat[i];
            mat[i] = mat[B.GetLength(0) - 1 - i];
            mat[B.GetLength(0) - i - 1] = temp;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = mat[i];
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
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5)
        {
            return null;
        }
        int iMin = -1;
        int iMinus = -1;
        int maxV = -99999999;
        
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {

                if (iMinus == -1 && j == 2 && B[i, j] < 0)
                {
                    iMinus = i;
                }

                if (B[i, i] > maxV && i == j)
                {
                    maxV = B[i, i];
                    iMin = i;
                }
                
            }
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int temp = B[iMin, j];
            B[iMin, j] = B[iMinus, j];
            B[iMinus, j] = temp;
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
        
        
        // code here
       
        int n = 0;
        if (A.GetLength(1) != 7 || A.GetLength(0) != 5)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    n++;
                }
            }
        }
        int[] answer = new int[n];
        n = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[n] = A[i, j];
                    n++;
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
        
        if ( A.GetLength(1) != 7 || A.GetLength(0) != 5)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int indM = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, indM])
                {
                    indM = j;
                }
            }
            if (indM > 0 && indM < A.GetLength(1) - 1)
            {
                if (A[i, indM + 1] > A[i, indM - 1])
                {
                    if (A[i, indM - 1] < 0)
                    {
                        A[i, indM - 1] = A[i, indM - 1] /2;
                    }
                    else
                    {
                        A[i, indM - 1] = A[i, indM - 1] * 2;
                    }
                }
                else
                {
                    if (A[i, indM + 1] < 0)
                    {
                        A[i, indM + 1] = A[i, indM + 1] / 2;
                    }
                    else
                    {
                        A[i, indM + 1] = A[i, indM + 1] * 2;
                    }
                }
            }
            else if (indM == 0)
            {
                if (A[i, indM + 1] < 0)
                {
                    A[i, indM + 1] = A[i, indM + 1] / 2;
                }
                else
                {
                    A[i, indM + 1] = A[i, indM + 1] * 2;
                }
            }
            else if (indM == A.GetLength(1) - 1)
            {
                if (A[i, indM - 1] < 0)
                {
                    A[i, indM - 1] = A[i, indM - 1] / 2;
                }
                else
                {
                    A[i, indM - 1] = A[i, indM - 1] * 2;
                }

            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
       
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int nNig = 0;
            int nPos = 0;
            int max = -999999;
            int maxIndex = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = i;
                }

                if (A[i, j] > 0)
                {
                    nPos++;
                }
                else if (A[i, j] < 0)
                {
                    nNig++;
                }
            }

            if (nPos > nNig)
            {
                A[maxIndex, j] = 0;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1;
            }
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
       
        if (A.GetLength(1) != 5 || A.GetLength(0) != 10)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            
            int s = 0;
            int max = -99999;
            int indMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                     indMax = i;
                    max = A[i, j];
                   
                }
            }

            int mid = (A.GetLength(0) / 2);
            if (indMax < mid)
            {
                for (int i = indMax + 1; i < A.GetLength(0); i++)
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
        //int rows = A.GetLength(0), cols = A.GetLength(1);
        if (A.GetLength(1) != 5 || A.GetLength(0) != 7  || B.Length != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -99999;
            int indMax = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    indMax = i;
                    max = A[i, j];
                    
                }
            }

            if (max < B[j])
            {
                A[indMax, j] = B[j];
            }

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int indMax = 0;
            double sum = (A[A.GetLength(0) - 1, j] +A[0, j]) / 2;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[indMax, j] < A[i, j])
                {
                    indMax = i;
                }
            }
            if (A[indMax, j] < sum)
            {
                A[indMax, j] = sum;
            }
            else
            {
                A[indMax, j] = indMax + 1;
            }
        }
        

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        

        if (n <= 0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];
        // code here

        for (int i = 0; i < 3 * n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == (i % n))
                {
                    answer[j, i] = 1;
                }
                else
                {
                    answer[j, i] = 0;
                }
            }
        }

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int indMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[indMax, indMax] < A[i, i])
            {
                indMax = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i && i < indMax )
                {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
    
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int EvenMax = 0;
        int OddMax = 0;
        

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, EvenMax] < B[i, j] && (i + 1) % 2 == 0)
                {
                    EvenMax = j;
                }
                else if (B[i, OddMax] < B[i, j] && (i + 1) % 2 != 0)
                {
                    OddMax = j;
                }
                
            }
            if ((i + 1) % 2 ==0)
            {
                int temp = B[i, EvenMax];
                B[i, EvenMax] = B[i-1, OddMax];
                B[i-1, OddMax] = temp;

                EvenMax = 0;
                OddMax = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        //int rows = A.GetLength(0), cols = A.GetLength(1);
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int mid = A.GetLength(1) / 2;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < mid; j++)
            {
                int temp = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j]  = A[i, j];
                A[i, j] = temp;
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
        {
            return null;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[0, i] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
            matrix[i, matrix.GetLength(0) - 1] = 0;
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
        {
            return null;
        }
        int mid = matrix.GetLength(0) / 2;
        for (int i = mid; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (i >= j)
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

        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (null, null);
        }
        int bottom = 0;
        int top = 0;

        int[] lower = new int[matrix.GetLength(0) * (matrix.GetLength(0) - 1) / 2];
        int[] upper = new int[matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2];
        
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (i > j)
                {
                    lower[bottom] = matrix[i, j];
                    bottom++;
                    
                }
                else
                {
                    upper[top] = matrix[i, j];
                    top++;
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
        //int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
        int[] metrT = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    metrT[i]++;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (metrT[j] < metrT[j+1])
                {
                    int temp = 0;
                    for (int s = 0; s < matrix.GetLength(1); s++)
                    {
                        temp = matrix[j + 1, s];
                        matrix[j + 1, s] = matrix[j, s];
                        matrix[j, s] = temp;
                    }
                    temp = metrT[j + 1];
                    metrT[j+1] = metrT[j];
                    metrT[j] = temp;
                }
            }

        }


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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int q = 0; q < matrix.GetLength(1) - 1; q++)
                    {
                        if (matrix[i, q] > matrix[i, q + 1])
                        {
                            int temp = matrix[i, q +1];
                            matrix[i, q + 1] = matrix[i, q];
                            matrix[i, q] = temp;
                        }
                    }
                }



            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int q = 0; q < matrix.GetLength(1) - 1; q++)
                    {
                        if (matrix[i, q] < matrix[i, q + 1])
                        {
                            int temp = matrix[i, q + 1];
                            matrix[i, q + 1] = matrix[i, q];
                            matrix[i, q] = temp;
                        }
                    }
                }
            }
        }

        return matrix;

        
    }

    static void pr(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
        }
    }
    static int[,] Delet(int[,] mat, int row)
    {
        int[,] newM = new int[mat.GetLength(0) - 1, mat.GetLength(1)];
      //  Console.Write(mat.GetLength(0));
        //Console.Write(" ");
        //Console.Write(mat.GetLength(1));
        //Console.WriteLine();

      //  Console.Write(newM.GetLength(0));
      //  Console.Write(" ");
       // Console.Write(newM.GetLength(1));
       // Console.WriteLine();
       
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            
            if (i <  row)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    newM[i, j] = mat[i, j];
                }
            }
            if (i > row)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    newM[i-1, j] = mat[i, j];
                }
            }
           // Console.WriteLine("------");
           // pr(newM);

        }
       // pr(newM);
        return newM;
    }


    public int[,] Task_3_11(int[,] matrix)
    {
        int row = 0;
       // pr(matrix);
        while (row < matrix.GetLength(0))
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                //Console.WriteLine(j);
                if (matrix[row, j]  == 0)
                {
                    matrix = Delet(matrix, row);
                    row -=1;
                    break;
                }
            }
            row++;
        }
        Console.WriteLine("----");
        pr(matrix);
        return matrix;
    }
    #endregion
}
