using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
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
        int i1 = A.GetLength(0);
        int j1 = A.GetLength(1);
        for(int i =0;i< i1;i++)
        {
            for(int j = 0; j < j1;j++)
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

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int i1 = A.GetLength (0);
        int j1 = A.GetLength(1);
        if (i1 != 4 && j1 != 4)
            return answer;
        for(int i =0; i<i1;i++)
        {
            for(int j = 0;j<j1;j++)
            {
                if(i==j)
                    answer += A[i, j];
            }    
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
        int[] answer = new int[4];
        // code here
        int jmin = 0;
        
        int i1 = A.GetLength(0);
        int j1 = A.GetLength(1);
        if (i1 != 4 && j1 != 7) return null;
        for(int i =0;i<i1;i++)
        {
            for(int j =1;j<j1; j++)
            {
                if (A[i,j] < A[i,jmin])
                {
                    jmin = j;
                   
                }
            }
            answer[i] =jmin;
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
       
        int i1 = A.GetLength (0);
        int j1 = A.GetLength (1);
        if (i1 != 5 || j1 != 7) return null;
        for(int i = 0;i < i1;i++)
        {
            int jmax = 0;
            for(int j =1;j<j1;j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            if (jmax != 0)
            {
                int t = A[i, 0];
                A[i, 0] = A[i, jmax];
                A[i, jmax] = t;
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
        
        int imaxi = 0;int imaxj = 0;
        int i1 = A.GetLength (0); int j1 = A.GetLength (1);
        if (i1 != 6 || j1 != 7) return null;
        for(int i = 0;i<i1;i++)
        {
            for (int j = 0; j < j1; j++)
            {
                if (A[i, j] > A[imaxi, imaxj])
                {
                    imaxi = i;
                    imaxj = j;
                }
            }
        }
        int newi1 = i1 - 1;
        int newj1 = j1 - 1;
        int[,] A2 = new int[newi1, newj1];
        int i2 = 0; int j2 = 0;
        for(int i = 0; i < i1;i++)
        {
            if(i == imaxi)
            {
                continue;
            }
            j2 = 0;
            for(int j = 0;j < j1;j++)
            {
                if(j ==imaxj)
                    { continue; }
                A2[i2,j2]= A[i,j];
                j2++;
            }
            i2++;
        }
       


        // end

        return A2;
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

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxi = 0;
            int maxival = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxival)
                {
                    maxival = A[i, j];
                    maxi = j;
                }
            }
            A[i, maxi] *= i + 1;
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
           

            if (maxindex != -1 && lastindex != -1)
            {
                int temp = D[i, maxindex];
                D[i, maxindex] = D[i, lastindex];
                D[i, lastindex] = temp;
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
        int n = H.GetLength(0);
        int m = H.GetLength(1);
        int[] answer = new int[n];
        if (n != 5 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (H[i, j] > H[i, jmax])
                {
                    jmax = j;
                }
            }
            int t = H[i,jmax];
            H[i,m-1] = H[i,m-2];
            H[i, m - 2] = t;
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
        int n = Y.GetLength(0), m = Y.GetLength(1);
        if (n != 6 || m != 5) return null;
        // code here
        for (int i = 0; i < n; i++)
        {
            int jMax = 0;
            for (int j = 1; j < m; j++)
            {
                if (Y[i, jMax] < Y[i, j]) jMax = j;
            }
            double mid = 0, count = 0;
            for (int j = jMax; j < m; j++)
            {
                if (j == jMax) continue;
                if (Y[i, j] > 0)
                {
                    mid += Y[i, j];
                    count++;
                }
            }
            if (mid != 0) mid /= count;
            for (int j = 0; j < jMax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = mid;
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

        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 7) return null;
        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] > B[i, jmax])
                        jmax = j;
            }
            temp[i] = B[i, jmax];
        }
        for (int i = 0; i < n; i++)
        {
            B[i, 3] = temp[4 - i];
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
            return null;

        int n = B.GetLength(0);
        int ijmax = 0, ifirst_neg = -1;

        for (int i = 0; i < n; i++)
        {
            if (B[i, i] > B[ijmax, ijmax])
                ijmax = i;
            if (B[n - i - 1, 2] < 0)
                ifirst_neg = n - i - 1;
        }

        if (ifirst_neg != ijmax)
            for (int i = 0; i < n; i++)
            {
                int tmp = B[ijmax, i];
                B[ijmax, i] = B[ifirst_neg, i];
                B[ifirst_neg, i] = tmp;
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
        int k = 0;
        int i1 = A.GetLength(0);
        int j2 = A.GetLength(1);
        if (i1 != 5 || j2 != 7) return null;
        for(int i =0;i<i1;i++)
        {
            for(int j =0;j<j2;j++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }
        }
        int[] answer = new int[k];
        int ik= 0;
        for (int i =0;i<i1; i++)
        {
            for(int j = 0;j<j2; j++)
            {
                if (A[i,j] <0)
                {
                    answer[ik] = A[i,j];
                    ik++;
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
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        double max = -10000000000;
        int maxim = 0;

        if (ctr != 5 || stol != 7) return null;


        for (int i = 0; i < ctr; i++)
        {
            double per = 2;
            max = -1000000000;
            for (int j = 0; j < stol; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxim = j;
                }
            }
            int elem = 0;
            if (maxim == 0 || maxim == stol - 1)
            {
                if (maxim == 0)
                    elem = 1;
                else
                    elem = stol - 2;
            }
            else
            {
                if (A[i, maxim - 1] < A[i, maxim + 1])
                    elem = maxim - 1;
                else
                    elem = maxim + 1;
            }
            if (A[i, elem] < 0)
                per = 0.5;
            A[i, elem] = A[i, elem] * per;
        }



        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 7 || col != 5) return null;
        for (int j = 0; j < col; j++)
        {
            double max = -10000;
            int imax = 0, kp = 0, ko = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > 0) kp++;
                if (A[i, j] < 0) ko++;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (kp > ko) A[imax, j] = 0;
            else A[imax, j] = imax + 1;
        }


            // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        
        int n = A.GetLength (0);
        int m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        int inmax = 0;
        for(int j = 0;j<m;j++)
        {
            int max = -100000, sum = 0;
            for(int i =0;i<n;i++)
            {
                if(A[i,j]>max)
                {
                    max = A[i, j];
                    inmax = i;
                }
            }
            if (inmax > 5) break;
            for(int i= inmax + 1;i<n;i++)
            {
                sum += A[i, j];
            }
            A[0,j] = sum;

        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5|| B.Length !=5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = -10000, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }

            }
            if (A[imax, j] < B[j])
            {
                A[imax, j] = B[j];
            }
            else
                break;
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
        int indmax = 0;
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[indmax, j])
                    indmax = i;

            }
            double s = (A[0, j] + A[n - 1, j]) / 2;
            if (A[indmax, j] < s)
                A[indmax, j] = s;
            else
                A[indmax, j] = indmax + 1;

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
            return answer;
        }
        answer = new int[n, n * 3];
        int ctr = answer.GetLength(0);
        int stol = answer.GetLength(1);
        for (int i = 0; i < ctr; i++)
        {
            for (int j = 0; j < stol; j++)
            {
                answer[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < ctr; i++)
        {
            count++;
            for (int j = count; j < stol;)
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
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 6) return null;
        int maxi = A[0, 0];
        int indmax = 0;
        for(int i = 1;i<n;i++)
        {
            for(int j = i;j<m;j++)
            {
                if (A[i,j] > maxi)
                {
                    maxi = A[i,j];
                    indmax = j;

                }
            }
        }
        for(int i =0;i<indmax;i++)
        {
            for (int j = i + 1; j < m; j++)
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
        if (n != 6 || m != 6)return null;
        for(int i=0;i<n;i+=2)
        {
            int max1 = -100000, max2 = -100000,imax1 = 0,imax2 = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > max1)
                {
                    max1 = B[i, j];
                    imax1 = j;
                }


                if (B[i + 1, j] > max2)
                {
                    max2 = B[i + 1, j];
                    imax2 = j;
                }
            }
            B[i, imax1] = max2;
            B[i+1,imax2] = max1;
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
        for(int i = 0;i< n; i++)
        {
            for(int j = 0; j<m/2;j++)
            {
                int t = A[i,j];
                A[i,j] = A[i,m-1-j];
                A[i,m-1-j] = t;
            }
        }
        
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int nom = 0, min = int.MaxValue, max = int.MinValue;
        int[,] matrix2 = new int[7, 5];
        int[] tem = new int[7];
        if ((matrix.GetLength(0) == 7) && (matrix.GetLength(1) == 5))
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        nom = j;
                    }
                }
                tem[i] = matrix[i, nom];
                nom = 0;
                min = int.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (tem[j] > max)
                    {
                        max = tem[j];
                        nom = j;
                    }
                }
                tem[nom] = int.MinValue;
                for (int j = 0; j < 5; j++)
                {
                    matrix2[i, j] = matrix[nom, j];
                }
                max = int.MinValue;
                nom = 0;
            }

        }
        else
            matrix2 = null;


        // end

        return matrix2 ;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        int n= matrix.GetLength(0);
        int m = n;
   
        bool continueProgram = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] != 0)
                {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;
        answer = new int[2 * m - 1];
        int half = (int)answer.Length / 2;
        for (int i = 0; i < m; i++)
        {
            int sum_l = 0;
            int sum_r = 0;
            for (int j = 0; j < n; j++)
            {
                if (i - j >= 0)
                {
                    sum_l = sum_l + matrix[n- 1 - j, i - j];
                }
                if (i + j < n)
                {
                    sum_r = sum_r + matrix[j, i + j];
                }
            }
            answer[i] = sum_l;
            answer[i + half] = sum_r;
        }

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
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k < 1) return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]])) { max[0] = i; max[1] = j; }

        if (max[1] != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        // end

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
        answer = new int[n * n];
        int[,]matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int index = 0;
        bool nulotrel = false;
        for(int i = 0;i < A.Length;i++)
        {
            if (A[i] != 0 || B[i] != 0)
                nulotrel = true;
        }
        if (nulotrel == false)
            return null;
        for(int i = 0;i<n;i++)
        {
            for(int j = i;j<n;j++)
            {
                matrix1[i, j] = A[index];
                matrix2[i,j] = B[index];
                index++;
            }
        }
        for(int i = 0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                matrix1[j,i] = matrix1[i,j];
                matrix2[j,i] = matrix2[i,j];

            }
        }
        index = 0;
        int sum;
        for (int i = 0;i<n;i++)
        {
            for(int j = 0;j<n;j++)
            {
                sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrix1[i, k] * matrix2[k,j];
                }
                answer[index++] = sum;
            }
        }


        // end

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
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        bool nulotrel = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] != 0)
                {
                    nulotrel = true;
                    break;
                }
            }
            if (nulotrel)
                break;
        }
        if (nulotrel == false)
            return null;
        for(int i= 0;i<m-1;i++)
        {
            for(int j = 0;j<m-i-1;j++)
            {
                int count1 = 0;
                int count2 = 0;
                for(int k = 0;k<n;k++)
                {
                    if (matrix[k,j]<0)
                        count1++;
                    if(matrix[k,j+1]<0)
                        count2++;
                }
                if(count1>count2)
                {
                    int[]tem = new int[n];
                    for (int k = 0; k < n; k++)
                    {
                        tem[k] = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = tem[k];
                    }

                }
            }
        }

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
                answer[k, j] = matrix[i, j]; 
            }
            k++;
            if (k >= matrix.GetLength(0) - count) 
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