public class Program
{
    public static void Matrix(int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void Matrixd(double[,] A,int x, int y)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{A[i, j]} ");
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
        foreach (int item in A) { answer += item; }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int s = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    s++;
                }
            }
        }
        if (s == 0) { return 0; }
        answer /= s;
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int a = A.GetLength(0);
        for (int i = 0; i < a; i++)
        {
            answer += A[i, i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int mi = 9999;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < mi)
                {
                    mi = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        int b = A.GetLength(0);
        for (int i = 0; i < b; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value += A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1) { return (0, 0); }
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 3 || b != 5)
        {
            return null;
        }
        int mi = 9999;
        answer = new int[b];
        for (int j = 0; j < b; j++)
        {
            mi = -9999;
            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > mi)
                {
                    mi = A[i, j];
                }
            }
            answer[j] = mi;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 5 || b != 7)
        {
            return null;
        }
        int ma = -99999;
        int idex = -1;
        int s;
        for (int x = 0; x < A.GetLength(0); x++)
        {
            if (A[x, 2] > ma)
            {
                ma = A[x,2];
                idex = x;
            }
        }
        for (int y = 0; y<A.GetLength(1); y++)
        {
            s = A[3, y];
            A[3, y] = A[idex,y];
            A[idex,y] = s;
        }
        Matrix(A);
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

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 5 || b != 5)
        {
            return null;
        }
        int ma = -9999,i = -1,s;
        for(int y = 0; y< A.GetLength(0); y++)
        {
            if (A[y,y] > ma)
            {
                ma = A[y,y];
                i = y;
            }
        }
        Console.WriteLine(i);
        for(int y = 0; y< A.GetLength(0); y++)
        {
            s=A[y, 3];
            A[y, 3] = A[y, i];
            A[y,i] = s;

        }
        foreach(int y in A)
        {
            Console.WriteLine(y);
        }
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

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int ma = -9999,i=-1,fl=0;
        int [] l = new int[b];
        for (int y = 0; y < a; y++)
        {
            ma = -9999;
            l=new int[b];
            fl = 0;
            for (int x = 0; x < b; x++)
            {
                if (A[y, x] > ma)
                {
                    ma=A[y, x];
                    i = x;
                }
            }
            for(int o=0; o<b; o++)
            {
                if (A[y, o] == ma)
                {
                    fl = 1;
                }
                if (o == b - 1)
                {
                    l[o] = ma;
                }
                else
                {
                    l[o] = A[y,o+fl];
                }
            }
            fl = 0;
            for (int x = 0;x < b; x++)
            {
                A[y,x] = l[x];
            }
        }
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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        int i = -1;
        for (int x = 0; x < n; x++)
        {
            double ma = -9999;
            i = -1;
            for (int y = 0; y < m; y++)
            {
                if (C[x, y] > ma)
                {
                    ma = C[x, y];
                    i = y;
                }
            }
            if(ma ==0) continue;
            for(int k = 0; k < i; k++)
            {
                if (C[x,k] < 0)
                {
                    C[x,k] = C[x,k]/ma;
                }
            }
        }
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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double sr = 0,ma=-9999;
        int k = 0,i=-1,v=0,a=0,b=0;
        // code here
        foreach(int x in Z)
        {
            if (x > 0)
            {
                sr += x;
                k++;
            }
            if (x > ma)
            {
                ma = x;
                i = v;
            }
            v++;
        }
        sr = sr / k;
        a = i / 6-1;
        b = i % 6;
        Z[a, b] = sr;
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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) !=5)
        {
            return null;
        }
        int k = 0;
        int mi = 9999,mii = -1, ma = -9999, mai=-1;
        for (int x =0; x < 6; x++)
        {
            k = 0;
            for(int y =0; y< 5; y++)
            {
                if (X[x, y] < 0)
                {
                    k++;
                }
            }
            if (k < mi) { mi = k; mii = x; }
            if (k > ma) { ma = k; mai = x; }
        }
        int s = 0;
        for (int y = 0; y < 5; y++)
        {
            s = X[mii, y];
            X[mii, y] = X[mai, y];
            X[mai,y] = s;
        }
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int[,] matr = new int[6,5];
        int ma = -9999,su=0,i=-1;
        for (int x = 0; x<7; x++)
        {
            su = 0;
            for (int y = 0;y < 5; y++)
            {
                if (A[x, y] > 0)
                {
                    su += A[x, y];
                }
            }
            if (su > ma)
            {
                ma= su;
                i = x;
            }
        }
        int fl = 0;
        for (int x = 0; x < 7; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                if (x == i)
                {
                    fl = 1;
                    continue;
                }
                matr[x-fl, y] = A[x, y];
            }
        }
        A= matr;
        Matrix(A);
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8)
        {
            return null;
        }
        if (B.Length != 5)
        {
            return null;
        }
        int mi = 9999, i =-1;
        for (int y = 0; y < A.GetLength(1); y++)
        {
            if (A[4, y] < mi)
            {
                mi = A[4, y];
                i = y;
            }
        }
        for (int x = 0; x< A.GetLength(0); x++)
        {
            A[x,7] = A[x,i+1];
            A[x, i + 1] = B[x];
        }
        Matrix(A);
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

        // end

        return answer;
    }
    #endregion

    #region Level 2
    private static double Umn(double A)
    {
        if (A>0)
        {
            return A * 2;
        }
        else
        {
            return A / 2;
        }
    }
    public double[,] Task_2_1(double[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int x = 0; x < 5; x++)
        {
            double ma = -9999;
            int i = -1;
            for (int y = 0; y < 7; y++)
            {
                if(A[x,y] > ma)
                {
                    ma= A[x,y];
                    i = y;
                    Console.WriteLine(i);
                }
            }
            if (i == 0)
            {
                A[x,i+1] = Umn(A[x,i+1]);
            }
            else if (i == 6)
            {
                A[x, i - 1] = Umn(A[x, i - 1]);
            }
            else if (A[x, i + 1]< A[x, i - 1])
            {
                A[x, i + 1] = Umn(A[x, i + 1]);
            }
            else
            {
                A[x, i - 1] = Umn(A[x, i - 1]);
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            int p = 0,o=0,m=-9999,i=-1;
            for (int x = 0; x < 7; x++)
            {
                if (A[x,y] > 0)
                {
                    p++;
                }
                else
                {
                    o++;
                }
                if (A[x, y] > m)
                {
                    m= A[x, y];
                    i = x;
                }
            }
            if (o < p)
            {
                A[i, y] = 0;
            }
            else
            {
                A[i, y] = i;
            }
        }
        Matrix(A);
        // end
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            int m = 0, i = -1, su = 0;
            for (int x = 0; x < 10; x++)
            {
                su += A[x, y];
                if (A[x, y] > m) { m= A[x, y]; i = x; su = 0; }
            }
            if (i <= 4)
            {
                A[0, y] = su;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length !=5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            int m = -9999, i = -1;
            for (int x = 0; x < 7; x++)
            {
                if (A[x, y] > m)
                    { 
                        m = A[x, y]; i = x; 
                    }
            }
            if (m<B[y]) { A[i, y] = B[y]; }
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
        for (int y = 0; y < 5; y++)
        {
            double m = -9999;
            int i = -1;
            for (int x = 0; x < 7; x++)
            {
                if (A[x, y] > m)
                {
                    m = A[x, y]; i = x;
                }
            }
            if (m< (A[0,y] + A[6, y]) / 2)
            {
                A[i,y] = (A[0, y] + A[6, y]) / 2;
            }
            else
            {
                A[i, y] = i;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n <= 0) { return null; }
        int[,] A = new int[n, 3 * n];
        int k = 2;
        for( int x = 0; x < n; x++)
        {
            for(int y = 0; y< 3 * n; y++)
            {
                A[x, y] = ((y + k) %3) / 2;
            }
            k--;
        }
        int[,] answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 6) return null;
        int ma = -9999, i = -1;
        for( int j =0; j < 6; j++)
        {
            if (A[j,j] > ma)
            {
                ma = A[j,j];
                i = j;
            }
        }
        if (i == -1) return null;
        for (int x = 0; x<i; x++)
        {
            for (int y = x+1; y<6; y++)
            {
                A[x, y] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (6 != B.GetLength(0) || 6 != B.GetLength(1)) return null;
        int i1 = -1, i2 = -1;
        for (int x = 0; x<6; x+=2)
        {
            int ma1 = -9999, ma2 = -9999,o=0;
            for (int y = 0; y<6; y += 1)
            {
                if (B[x,y] > ma1)
                {
                    i1 = y;
                    ma1 = B[x,y];
                }
            }
            for (int j = 0; j < 6; j += 1)
            {
                if (B[x+1, j] > ma2)
                {
                    i2 = j;
                    ma2 = B[x+1, j];
                }
            }
            o = B[x, i1];
            B[x, i1] = B[x+1, i2];
            B[x+1, i2] =o;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (6 != A.GetLength(0) || 7 != A.GetLength(1)) return null;
        int k;
        int[] s;
        for (int x = 0; x < 6; x ++)
        {
            k = 6;
            s= new int[7];
            for(int y = 0; y < 7; y += 1)
            {
                s[y] = A[x,k];
                k--;
            }
            for (int y = 0; y < 7; y += 1)
            {
                A[x, y] = s[y];
            }

        }
        Matrix(A);
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
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) return null;
        int x1 = 0, y1 = 0, x2 = n - 1, y2 = n - 1;
        for (int j = 0; j < n; j++)
        {
            matrix[j - x1, j] = 0;
            matrix[j, j - y1] = 0;
            matrix[j + x2, j] = 0;
            matrix[j, j + y2] = 0;
            x1++;
            y1++;
            x2--;
            y2--;
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
        int n =matrix.GetLength(0);
        if (n != matrix.GetLength(1) || n < 3) return null;
        for (int x =(int)(n/2); x < n; x++)
        {
            for (int y =0; y < x+1; y++)
            {
                matrix[x, y] = 1;
            }
        }
        Matrix(matrix);
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
        int n = matrix.GetLength(0);
        int u = (int)((n * n) / 2 + 0.5 * n);
        int uk = 0, lk = 0,v=0,v1=n,w=0;
        upper = new int[u];
        lower = new int[n*n-u];
        if (n != matrix.GetLength(1) || n < 2) return (null, null);
        for (int x = 0; x < n; x += 1)
        {
            for (int y = 0; y < n; y += 1)
            {
                if (y >= x)
                {
                    upper[uk] = matrix[x, y];
                    uk++;
                }
                else
                {
                    lower[lk] = matrix[x, y];
                    lk++;
                }
            }
            for (int r = 0; r < v1; r++)
            {
                Console.Write($"{upper[v]} ");
                v++;
            }
            Console.WriteLine();
            for (int r = 0; r < (n-v1); r++)
            {
                Console.Write($"{lower[w]} ");
                w++;
            }
            if (v1 < n)
            {
                Console.WriteLine();
            }
            v1--;
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
        int a = matrix.GetLength(0);
        int b = matrix.GetLength(1);
        int[,] c = new int[a,b+1];
        int k = 0;
        if (a != 7 || b != 5) return null;
        for(int x = 0; x< a; x++)
        {

            k = 0;
            for (int y = 1; y<b+1; y++)
            {
                c[x,y] = matrix[x,y-1];
                if (c[x,y] > 0)
                {
                    k++;
                }
            }
            c[x, 0] = k;
        }
        Matrix(c);
        int g;
        bool flag = true;
        while (flag)
        {
            flag = false;
            for(int x = 0; x<a-1; x++)
            {
                if (c[x, 0] < c[x + 1, 0])
                {
                    for (int y = 0; y < b + 1; y++)
                    {
                        g = c[x, y];
                        c[x, y] = c[x + 1, y];
                        c[x + 1, y] = g;
                    }
                    flag = true;
                }
            }
            
        }

        Matrix(c);
        for (int x = 0; x < a; x++)
        {
            for (int y = 0; y < b; y++)
            {
                matrix[x,y] = c[x, y+1];
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
        // данная задача была решена через сортировку Radix sort(цифровая сортировка), и т.к я не смог придумать достаточно быстрый алгоритм (иначе какой смысл в этой сортировке) для отрицательных чисел, я просто добавлял к каждому числу 102. Если вас не затруднит прошу объяснить, почему при прибавление 100 алгоритм перестает работать.
        Matrix(matrix);

        int n = matrix.GetLength(1);
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for(int y = 0;y < matrix.GetLength(1); y++)
            {
                matrix[x,y] = matrix[x,y] +101;
            }
        }
        if (n ==0 || 0 == matrix.GetLength(0)) return null;
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            int ma = matrix[x, 0];
            for (int i = 1; i < n; i++)
            {
                if (ma < matrix[x, i])
                {
                    ma = matrix[x, i];
                }
            }
            for (int pl = 1; ma / pl != 0; pl *= 10)
            {
                int[] V = new int[n];
                int[] k = new int[10];
                for (int i = 0; i < n; i++)
                {
                    k[(matrix[x, i] / pl) % 10]++;
                }
                for (int i = 1; i < 10; i++)
                {
                    k[i] += k[i - 1];
                }
                for (int i = n - 1; i >= 0; i--)
                {
                    V[k[(matrix[x, i] / pl) % 10] - 1] = matrix[x, i];
                    k[(matrix[x, i] / pl) % 10]--;
                }
                Console.WriteLine(string.Join(" ",V));
                if (x % 2 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        matrix[x, i] = V[i];
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        matrix[x, i] = V[n - i - 1];
                    }
                }
            }
        }
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                matrix[x, y] = matrix[x, y] - 101;
            }
        }
        Matrix(matrix);
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}