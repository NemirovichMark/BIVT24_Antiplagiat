using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
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
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        for (int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                answer+=A[i,j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        double suma=0;
        int k=0;
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        for (int i=0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                if (A[i,j]>0)
                {
                    suma+=A[i,j];
                    k++;
                }
            }
        }
        if (k==0)
        {
            answer=0;
        }
        else
        {
            answer=suma/k;
        }
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int n=A.GetLength(0);
        for (int i=0;i<n;i++)
        {
            answer+=A[i,i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        int mini=10000;
        for (int i=0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                if (A[i,j]<mini)
                {
                    mini=A[i,j];
                    row=i;
                    col=j;
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
        int n=A.GetLength(0);
        for (int i=0;i<n;i++)
        {
            if (A[i,colIndex]<0)
            {
                rowIndex=i;
                value=A[i,colIndex];
                break;
            }
            else
            {
                value=0;
                rowIndex=0;
            }
        }
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        answer=new int[n];
        int mini=10000;
        int k=0;
        for (int i=0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                if (A[i,j]<mini)
                {
                    mini=A[i,j];
                    k=j;
                }
            }
            mini=10000;
            answer[i]=k;
        }
        if (n!=4 || m!=7)
        {
            return null;
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
    public double[] Task_1_8(int[,] A)//??????????
    {
        double[] answer = default(double[]);
        // code here
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        answer=new double[n];
        double srz=0;
        double suma=0;
        int k=0;
        for (int i=0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                if (A[i,j]>0)
                {
                    suma+=A[i,j];
                    k++;
                }
            }
            if (k==0)
            {
                srz=0;
            }
            else
            {
                srz=suma/k;
                k=0;
                suma=0;
            }
            answer[i]=srz;
        }
        if (n!=4 || m!=6)
        {
            return null;
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
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        int mini=10000;
        int index=0;
        for (int i=0;i<n;i++)
        {
            if (A[i,0]<mini)
            {
                mini=A[i,0];
                index=i;
            }
        }
        if (n!=5 || m!=7)
        {
            return null;
        }
        int[,] B = new int[n-1,m];
        int k=0;
        for (int i=0;i<n;i++)
        {
            if (i!=index)
            {
                for (int j=0;j<m;j++)
                {
                    B[k,j]=A[i,j];
                }
                k++;
            }
        }
        A=B;
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
        int n=A.GetLength(0);
        int m= A.GetLength(1);
        int k=0;
        int r=0;
        answer=new int[m];
        for (int j=0;j<m;j++)
        {
            for (int i=0;i<n;i++)
            {
                if (A[i,j]<0)
                {
                    k++;
                }
            }
            answer[r]=k;
            r++;
            k=0;
        }
        if (n!=4 || m!=3)
        {
            return null;
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
        int[] A= new int[m];
        int indexmini=0;
        for (int i=0;i<n;i++)
        {
            int mini=10000;
            for (int j=0;j<m;j++)
            {
                if (B[i,j]<mini)
                {
                    mini=B[i,j];
                    indexmini=j;
                }
            }
            int temp_s=B[i,0];
            for (int k=1;k<=indexmini;k++)
            {
                int temp=B[i,k];
                B[i,k]=temp_s;
                temp_s=temp;
            }
            B[i,0]=mini;
            mini=10000;
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
        int index=0;
        for (int i=0;i<n;i++)
        {
            double maxi=-10000;
            int first_index=-1;
            int last_index=-1;
            index=0;
            for (int j = 0;j<m;j++)
            {
                if (F[i,j]>maxi)
                {
                    maxi=F[i,j];
                    index=j;
                }
            }
            for (int k=0;k<m;k++)
            {
                if (F[i,k]<0)
                {
                    first_index=k;
                    break;
                }
            }
            for (int r=0;r<m;r++)
            {
                if (F[i,r]<0)
                {
                    last_index=r;
                }
            }
            if (last_index!=-1 && first_index != -1)
            {
                F[i,index]=Math.Round((F[i,first_index]+F[i,last_index])/2,2);
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

        int n=G.GetLength(0);
        int m=G.GetLength(1);
        for (int i=0;i<n;i++)
        {
            double maxi=-100000;
            int index_maxi=-1;
            for (int j =0;j<m;j++)
            {
                if (G[i,j]>maxi)
                {
                    maxi=G[i,j];
                    index_maxi=j;
                }
            }
            for (int k=m-2;k>index_maxi;k--)
            {
                G[i,k+1]=G[i,k];
            }
            G[i,index_maxi+1]=G[i,index_maxi];
        }
        if (n != 5 || m != 7) return null;
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
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        if (n != 5 || m != 7 || B.Length != 7) return null;
        double maxi=0;
        int index_maxi=-1;
        for (int i = 0; i<n;i++)
        {
            if (A[i,5]>maxi)
            {
                maxi=A[i,5];
                index_maxi=i;
            }
        }
        for (int j=0;j<m;j++)
        {
            A[index_maxi,j]=B[j];
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
        int n=F.GetLength(0);
        int m=F.GetLength(1);
        int mini = 10000;
        int index_mini=0;
        int[,] b=new int[5,6];
        if (n != 5 || m != 7) return null;
        for (int j=0;j<m;j++)
        {
            if (Math.Abs(F[2,j])<mini)
            {
                mini=Math.Abs(F[2,j]);
                index_mini=j;
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j <= index_mini; j++)
            {
                b[i, j] = F[i, j];
            }
            for (int j = index_mini + 2; j < m; j++)
            {
                b[i, j-1] = F[i, j];
            }
        }
        F=b;
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
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        double maxi=-1000;
        int index_m=0;
        double[] M= new double [n];
        double[] Srzn_pl= new double[n];
        if (n != 5 || m != 7) return null;
        for (int i=0;i<n;i++)
        {
            int k=0;
            double suma=0;
            for(int j = 0; j<m;j++)
            {
                if (A[i,j]>maxi)
                {
                    maxi=A[i,j];
                    index_m=j;
                }
                if(A[i,j]>0)
                {
                    k++;
                    suma+=A[i,j];
                }
            }
            M[i]=index_m;
            if (k!=0)
                Srzn_pl[i]=(suma/k);
            else
                Srzn_pl[i]=0;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if (j==M[i])
                {
                    A[i,j]=Srzn_pl[i];
                }
            }
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
        int n = A.GetLength(0);
        int m=A.GetLength(1);
        if (n != 5 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            int jmaxi = 0;
            double maxi = A[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    jmaxi = j;
                }
            }
            if (jmaxi == 0)
            {
                A[i, 1] *= 2;
            }
            if (jmaxi == (m - 1)) 
            {
                A[i, m - 2] *= 2;
            }
            if (jmaxi != 0 && jmaxi != (m - 1))
            {
                if (A[i, jmaxi - 1] > A[i, jmaxi + 1])
                {
                    if (A[i, jmaxi + 1] > 0)
                    {
                        A[i, jmaxi + 1] *= 2;
                    }
                    else 
                    {
                        A[i, jmaxi + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, jmaxi - 1] > 0)
                    {
                        A[i, jmaxi - 1] *= 2;
                    }
                    else 
                    {
                        A[i, jmaxi - 1] /= 2;
                    }
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m=A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int j=0;j<m;j++)
        {
            int positiv = 0;
            int negativ = 0;
            int imaxi = 0; 
            int maxi = A[0, j];
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > 0)
                {
                    positiv++;
                }
                if (A[i, j] < 0) 
                {
                    negativ++;
                }
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    imaxi = i;
                }
            }
            if (positiv > negativ)
            {
                A[imaxi, j] = 0;
            }
            else
            {
                A[imaxi, j] = imaxi+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m= A.GetLength(1);
        if (n != 10 || m != 5) return null;
        int maxiind=0;
        int suma=0;
        for (int j = 0; j < m; j++) 
        {
            maxiind = 0;
            suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i, j] > A[maxiind, j])
                {
                    maxiind = i; 
                    suma = 0; 
                }
                else 
                {
                    suma += A[i, j];
                }
            }
            if (maxiind < 5) 
            {
                A[0, j] = suma;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5 || B.Length != 5) return null;
        int maxiind=0;
        for (int j = 0; j < m; j++) 
        {
            maxiind = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i, j] > A[maxiind, j])
                {
                    maxiind = i;
                }
            }
            if (A[maxiind, j] < B[j]) A[maxiind, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int imaxi = 0;
            double maxi = A[0, j];
            for (int i = 0; i < m; i++)
            {
                if (A[i, j] > maxi)
                {
                    maxi = A[i, j];
                    imaxi = i;
                }
            }
            if (A[imaxi, j] < (A[0, j] + A[n - 1, j]) / 2)
            {
                A[imaxi, j] = (A[0, j] + A[n - 1, j]) / 2;
            }
            else
            {
                A[imaxi, j] = imaxi+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n,3*n];
        for(int i = 0; i < n; i++)
        {
            for (int j = 0;j < 3*n; j++)
            {
                if (i == j || i + n == j || i + 2 * n == j)
                {
                    answer[i, j] = 1;
                }
                else
                {
                    answer[i, j] = 0;
                }
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 6) return null;
        int maxind = 0;
        for (int i = 1; i < n; i++)
            if (A[i, i] > A[maxind, maxind])
            { 
                maxind = i;
            }
        for (int i = 0; i < maxind; i++)
        {
            for (int j = i+1; j < m; j++)
            {
                A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        if (n != 6 || m != 6) return null;
        for(int i = 0; i < n-1; i += 2)
        {
            int maxi1 = B[i, 0];
            int maxi2 = B[i+1, 0];
            int jmaxi1 = 0;
            int jmaxi2 = 0;
            for(int j=0; j < m; j++)
            {
                if (B[i,j] > maxi1)
                {
                    maxi1= B[i, j];
                    jmaxi1 = j;
                }
                if (B[i+1, j] > maxi2)
                {
                    jmaxi2 = j;
                    maxi2 = B[i+1, j];
                }
            }
            int t = B[i, jmaxi1];
            B[i, jmaxi1] = B[i + 1, jmaxi2];
            B[i+1, jmaxi2] = t;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            int temp;
            for (int j = 0; j < m / 2; j++)
            {
                temp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
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
        // code here
        int n=matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n!=m) return null;
        for (int i=0;i<n;i++)
        {
            matrix[0,i]=0;
            matrix[i,0]=0;
            matrix[(n-1),i]=0;
            matrix[i,(m-1)]=0;
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
        int n=matrix.GetLength(0);
        int m= matrix.GetLength(1);
        if (n!=m)
        {
            return null;
        }
        for (int i=n/2; i<n;i++)
        {
            for (int j=0;j<i+1;j++)
            {
                matrix[i,j]=1;
            }
        }
        for( int i=0;i<n;i++)
        {
            for (int j=0;j<m;j++)
            {
                System.Console.WriteLine(matrix[i,j]);
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
        int n=matrix.GetLength(0);
        int m=matrix.GetLength(1);
        if(n!=m)
        {
            return (null, null);
        }
        int up=n*(m+1)/2;
        int lo=n*(m-1)/2;
        upper = new int[up];
        lower = new int[lo];
        int k1=0; 
        int k2=0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if (j>=i)
                {
                    upper[k1]=matrix[i,j];
                    k1++;
                }
                else
                {
                    lower[k2]=matrix[i,j];
                    k2++;
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
        int n=matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n!=7 && m!=5) return null;
        int[] temp = new int[n];
        int c = 0, num = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j=0;j < m; j++)
            {
                if (matrix[i, j] > 0) num++;
            }
            temp[c] = num;
            c++;
            num = 0;
        }

        for(int i = 1, k = 2; i < temp.Length;)
        {
            if ((i==0) || (temp[i] <= temp[i - 1]))
            {
                i = k;
                k++;
            }
            else
            {
                for(int j = 0; j < m; j++)
                {
                    int r = matrix[i, j];
                    matrix[i, j] = matrix[i - 1, j];
                    matrix[i - 1, j] = r;
                }
                int t = temp[i];
                temp[i] = temp[i - 1];
                temp[i - 1] = t;
                i--;
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
        int n= matrix.GetLength(0);
        int m= matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < m; j++)
                {
                    int temp = matrix[i, j], k = j - 1;
                    while (k >= 0 && matrix[i, k] < temp)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k -= 1;
                    }
                    matrix[i, k + 1] = temp;
                }
            }
            else
            {
                for (int j = 1; j < m; j++)
                {
                    int temp = matrix[i, j], k = j - 1;
                    while (k >= 0 && matrix[i, k] > temp)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k -= 1;
                    }
                    matrix[i, k + 1] = temp;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n=matrix.GetLength(0);
        int m=matrix.GetLength(1);
        int count=0;
        int[] temp=new int[n];
        for (int i=0;i<n;i++)
        {
            int k=0;
            for (int j=0;j<m;j++)
            {
                if (matrix[i,j]==0)
                {
                    k++;
                }
            }
            if (k==0)
            {
                temp[i]=1;
                count++;
            }
            else
            {
                temp[i]=0;
            }
        }
        int[,] B=new int[count,m];
        int r=0;
        for(int i=0;i<n;i++)
        {
            if(temp[i]==1)
            {
                for (int j=0;j<m;j++)
                {
                    B[r,j]=matrix[i,j];
                }
                r++;
            }
        }
        matrix=B;
        // end

        return matrix;
    }
    #endregion
}