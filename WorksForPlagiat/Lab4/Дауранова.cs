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

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int h = A.GetLength(0);
        int w = A.GetLength(1);

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int h = A.GetLength(0), w = A.GetLength(1), c = 0;
        double s = 0;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (A[i, j] > 0) 
                {
                    s += A[i, j];
                    c++;
                }
            }
        }

        if (c == 0 || h <= 0)
            answer = 0;
        else
            answer = s/c;
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
        int h = A.GetLength(0), w = A.GetLength(1);
        
        if (h == 0 || colIndex > h || colIndex < 0)
            return (default(int), 0);

        for (int i = 0; i < h; i++){
            if (A[i, colIndex] < 0){
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }

        if (value == 0)
            return (default(int), 0);
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
        int h = A.GetLength(0), w = A.GetLength(1);
        int k = 0;

        if (h == 0)
        {
            return answer;
        }
        answer = new double[h];

        for (int i = 0; i<h;i++)
        {
            double s = 0;
            int cnt = 0;
            for (int j = 0; j<w; j++)
            {
                if (A[i,j] > 0)
                {
                    s += A[i,j];
                    cnt++;
                }
            }
            if (cnt != 0)
            {
                answer[i] = s/cnt;
                k++;
            }
            else
            {
                answer[i] = 0;
            }
        }
        if (k==0)
        {
            return default(double[]);
        }
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
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h <= 2)
            return default(int[,]);

        int minValue = A[0, 0], string_d = 0;

        for (int i = 0; i < h; i++)
        {
            if (A[i, 0] < minValue)
            {
                minValue = A[i, 0];
                string_d = i;
            }
        }

        int[,] new_A = new int[h - 1, w];
        for (int i = 0; i < h - 1; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (i < string_d)
                    new_A[i, j] = A[i, j];
                else
                    new_A[i, j] = A[i + 1, j];
            }
        }
        A = new_A;
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
        int h = A.GetLength(0), w = A.GetLength(1);
        int k = 0;

        if (w == 0 || h == 0) 
            return answer;
        answer = new int [w];
        
        for (int j = 0; j < w; j++)
        {
            int k_p = 0;
            for (int i = 0; i < h; i++)
            {
                if (A[i,j] < 0)
                {
                    k_p++;
                    k++;
                }
            }
            
            answer[j] = k_p;
        }

        if (k == 0)
        return default(int[]);
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
        if (m <= 0 || n<=0)
        {
            return default(int[,]);
        }
        for (int i = 0; i < n; i++){
            int min_val = B[i,0], ind = -1; 
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < min_val)
                {
                    min_val = B[i, j];
                    ind = j;
                }
            }

            if (ind != -1)
            {
                for (int p = ind; p > 0; p--)
                {
                    B[i, p] = B[i, p - 1];
                }
                B[i, 0] = min_val;
            } 
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
        int h = F.GetLength(0), w = F.GetLength(1);
        
        for (int i = 0; i < h; i++){

            double max_val = F[i, 0], first = 0, last = 0;
            int ind_max = 0;
            for (int j = 0; j < w; j++)
            {
                if (F[i, j] > max_val)
                {
                    max_val = F[i, j];
                    ind_max = j;
                }

                if (F[i, j] < 0 && first == 0)
                    first = F[i, j];

                if (F[i, j] < 0 && first != 0)
                    last = F[i, j];
            }

            if (first != 0 || last != 0)
                F[i, ind_max] = (last + first) / 2;
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
        int h = G.GetLength(0), w = G.GetLength(1);

        if (h < 3)
            return default(int[,]);
            
        for (int i = 0; i < h; i++){
            int max_val = G[i, 0], ind_max = 0;
            for (int j = 0; j < w; j++)
            {
                if (G[i, j] > max_val)
                {
                    max_val = G[i, j];
                    ind_max = j;
                }
            }
            if (ind_max == w - 2)
                    G[i, w - 1] = max_val;
                else 
                {
                    for (int k = w - 1; k > ind_max; k--)
                    {
                        G[i, k] = G[i, k - 1];
                    }
                }
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
         int h = A.GetLength(0), w = A.GetLength(1), vectorLenght = B.Length;
        int column = 6 - 1;

        if (h < 3 || w != vectorLenght)
            return default(int[,]);

        int max_val = A[0, column];
        int string_del = 0;
        
        

        for (int i = 0; i < h; i++)
        {
            if (A[i, column] > max_val)
            {
                max_val = A[i, column];
                string_del = i;
            }
        }

        for (int j = 0; j < w; j++){
            A[string_del, j] = B[j];
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
        int h = F.GetLength(0), w = F.GetLength(1);

        if (h < 3)
            return default(int[,]);

        int min_val = F[1, 0];
        int col = 0;

        for (int j = 0; j < w; j++)
        {
            if (Math.Abs(F[1, j]) < min_val)
            {
                min_val = F[1, j];
                col = j;
            }
        }

        col++;

        int[,] G = new int[h, w - 1];
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w - 1; j++)
            {
                if (j < col)
                    G[i, j] = F[i, j];
                else 
                    G[i, j] = F[i, j + 1];
            }
        }
        F = G;
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
        int h = A.GetLength(0), w = A.GetLength(1);
        
        if (h < 3)
            return default(double[,]);

        for (int i = 0; i < h; i++){
            int ind_max = 0, k = 0;
            double max_val = A[i, 0], s = 0, avg = 0;
            for (int j = 0; j < w; j++)
            {
                if (A[i, j] > max_val)
                {
                    max_val = A[i, j];
                    ind_max = j;
                }

                if (A[i, j] > 0)
                {
                    k++;
                    s += A[i, j];
                }

                if (k != 0)
                    avg = s / k;
            }

            A[i, ind_max] = avg;
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
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h < 3)
            return default(double[,]);

        for (int i = 0; i < h; i++)
        {
            double max_val = A[i, 0];
            int ind_max = 0;
            for (int j = 0; j < w; j++)
            {
                if (A[i, j] > max_val){
                    ind_max = j;
                    max_val = A[i, j];
                }
            }

            if (ind_max == 0)
                A[i, ind_max + 1] *= 2;
            else if (ind_max == w - 1)
                A[i, ind_max - 1] *= 2;
            else 
            {
                if (A[i, ind_max + 1] < A[i, ind_max - 1])
                {
                    if (A[i, ind_max + 1] > 0)
                        A[i, ind_max + 1] *= 2;
                    else
                        A[i, ind_max + 1] /= 2;
                }
                else
                {
                    if (A[i, ind_max - 1] > 0)
                        A[i, ind_max - 1] *= 2;
                    else
                        A[i, ind_max - 1] /= 2;
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
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h < 3)
            return default(int[,]);

        for (int j = 0; j < w; j++)
        {
            int countPos = 0, countDif = 0;
            int max_val = A[0, j], ind_max = 0;
            for (int i = 0; i < h; i++)
            {
                if (A[i, j] > max_val)
                {
                    max_val = A[i, j];
                    ind_max = i;
                }

                if (A[i, j] > 0)
                    countPos++;
                else if (A[i, j] != 0)
                    countDif++;
            }

            if (countPos > countDif)
                A[ind_max, j] = 0;
            else
                A[ind_max, j] = ind_max + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h < 3)
            return default(int[,]);

        
        for (int j = 0; j < w; j++)
        {
            int max_val = A[0, j], ind_max = 0;
            int sum = 0;
            for (int i = 0; i < h; i++)
            {
                sum += A[i, j]; 

                if (A[i, j] > max_val)
                {
                    ind_max = i;
                    max_val = A[i, j];
                    sum = 0;
                }
            }

            if (ind_max <= h / 2)
                A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int h = A.GetLength(0), w = A.GetLength(1), bLenght = B.Length;

        if (h < 3 || bLenght != w)
            return default(int[,]);

        for (int j = 0; j < w; j++){
            int max_val = A[0, j], ind_max = 0;
            for (int i = 0; i < h; i++)
            {
                if (A[i, j] > max_val)
                {
                    max_val = A[i, j];
                    ind_max = i;
                }
            }

            if (A[ind_max, j] < B[j])
                A[ind_max, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h < 3)
            return default(double[,]);

        for (int j = 0; j < w; j++)
        {
            double max_val = A[0, j];
            int ind_max = 0;
            double sum = (A[0, j] + A[h - 1, j]) / 2;
            for (int i = 0; i < h; i++)
            {
                if (A[i, j] > max_val)
                {
                    ind_max = i;
                    max_val = A[i, j];
                }
            }

            if (max_val < sum)
                A[ind_max, j] = sum;
            else
                A[ind_max, j] = ind_max + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] a = default(int[,]);
        // code here
        if (n < 3)
            return a;

        int[,] A = new int [n, n * 3];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    A[i, j] = 1;
                else 
                    A[i, j] = 0;
            }
        }
        a = A;
        // end

        return a;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h < 3 || h != w)
            return default(int[,]);

        int max_val = A[0, 0], i_max = 0;
        for (int i = 0; i < h; i++)
        {
            if (A[i, i] > max_val)
            {
                i_max = i;
                max_val = A[i, i];
            }
        }

        for (int i = 0; i < i_max; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (j > i)
                    A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int h = B.GetLength(0), w = B.GetLength(1);

        if (h < 3)
            return default(int[,]);

        for (int i = 0; i < h; i += 2){
            int max_val = B[i, 0], max_val1 = B[i + 1, 0];
            int ind_max = 0, ind_max1 = 0;
            for (int j = 0; j < w; j++)
            {
                if (B[i, j] > max_val)
                {
                    ind_max = j;
                    max_val = B[i, j];
                }

                if (B[i + 1, j] > max_val1)
                {
                    ind_max1 = j;
                    max_val1 = B[i + 1, j];
                }
            }

            B[i, ind_max] = max_val1;
            B[i + 1, ind_max1] = max_val;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int h = A.GetLength(0), w = A.GetLength(1);

        if (h != 6 && w != 7)
            return default(int[,]);

        for (int i = 0; i < h; i++){
            for (int j = 0; j < w / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, w - j - 1];
                A[i, w - j - 1] = temp;
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
        // end
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight)
            return default(int[,]);

        for(int i = 0; i < AHeight; i++)
        {
            matrix[0, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, AHeight - 1] = 0;
            matrix[AHeight- 1, i] = 0;
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
        int h = matrix.GetLength(0), w = matrix.GetLength(1);

        if (h != w)
            return default(int[,]);

        for (int i = h / 2; i < h; i++)
        {
            for (int j = i / h; j <= i; j++)
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
        int h = matrix.GetLength(0), w = matrix.GetLength(1);

        if (h != w)
            return (null, null);

        upper = new int[h * (h + 1) / 2];
        lower = new int[(h * (h + 1) / 2) - h];

        int cnt1 = 0, cnt2 = 0;
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                if(i <= j)
                {
                    upper[cnt1] = matrix[i, j];
                    cnt1++;
                } 
                else{
                    lower[cnt2] = matrix[i, j];
                    cnt2++;
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
        // code  here
        int h = matrix.GetLength(0), w = matrix.GetLength(1); 
 
        if (h != 7 && w != 5) 
            return default(int[,]); 
 
        int[] k = new int[h]; 
 
        for (int i = 0; i < h; i++)
        { 
            for (int j = 0; j < w; j++)
            { 
                if (matrix[i, j] > 0)
                { 
                    k[i]++; 
                } 
            } 
        } 
 
        int maxVal = k[0], maxInd = 0;
        for (int i = 0; i < h; i++)
        {
            if (k[i] > maxVal)
            {
                maxVal = k[i];
                maxInd = i;
            }
        }

        for (int i = 0; i < h - 1; i++)
        {
            for (int j = 0; j < h - i - 1; j++)
            {
                if (k[j] < k[j + 1])
                {
                    for (int u = 0; u < 5; u++)
                    {
                        int temp = matrix[j, u];
                        matrix[j, u] = matrix[j + 1, u];
                        matrix[j + 1, u] = temp;
                    }
                    int tempCount = k[j];
                    k[j] = k[j + 1];
                    k[j + 1] = tempCount;
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
        int rows = matrix.GetLength(0), columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - j - 1; k++)
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
                    else {
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
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
         int h = matrix.GetLength(0), w = matrix.GetLength(1);

        if (h < 2)
            return default(int[,]);

        int k = 0;
        for (int i = 0; i < h; i++) 
        {
            bool nol = false;
            for (int j = 0; j < w; j++)
            {
                if (matrix[i, j] == 0) 
                {
                    nol = true;
                    break; 
                }
            }
            
            if (nol == false)
                k++; 
        }

        int[,] filteredMatrix = new int[k, w];
        int r = 0;

        for (int i = 0; i < h; i++){
            bool hasZero = false;

            for (int j = 0; j < w; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break; 
                }
            }
            if (hasZero == false)
            {
                for (int j = 0; j < w; j++)
                {
                    filteredMatrix[r, j] = matrix[i, j];
                }
                r++;  
            }
        }
        matrix = filteredMatrix;
        // end

    
        return matrix;
    }
    #endregion
}