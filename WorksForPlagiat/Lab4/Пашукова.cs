using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        int x = A.GetLength(1);
        int y = A.GetLength(0);
        if (y != 5 || x != 7)
        {
            return 0;
        }
        double answer = 0;
        int k = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    k++;
                }
            }
        }
        answer /= k;
        // end
        Console.WriteLine(answer);
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
        int x = A.GetLength(1);
        int y = A.GetLength(0);
        if (y != 5 || x != 4)
        {
            return (0, 0);
        }
        // code here
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    value = A[i, j];
                    rowIndex = i;
                }
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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6)
        {
            return null;
        }
        answer = new double[4];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            double k = 0;
            double avg = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }

            }
            if (sum == 0)
            {
                avg = 0;
            }
            else
            {
                avg = Math.Round(sum / k, 2);
                answer[i] = avg;
            }
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
        int ministr = 0;
        int[,] itog = new int[A.GetLength(0) - 1, A.GetLength(1)];
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int minim = 99999;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < minim)
            {
                minim = A[i, 0];
                ministr = i;
                //Console.WriteLine(ministr);
            }
        }

        int k = 0;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            if (j != ministr)
            {
                for (int i = 0; i < A.GetLength(1); i++)
                {
                    itog[k, i] = A[j, i];
                    Console.WriteLine(itog[k, i]);
                }
                k++;
                Console.WriteLine();
            }
        }

        // end

        return itog;
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
        int[] answer = new int[A.GetLength(1)];
        // code here
       
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int k = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    k++;
                }

            }
            answer[i] = k;
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
        int ind = 0;
        int[] elem = new int[B.GetLength(0)];  
        int[,] itog = new int[n, m];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int min = 9999;
            for (int j = 0; j < B.GetLength(1); j++)
            {
               if (B[i, j] < min)
               {
                    ind = j;
                    min = B[i, j];
               }
            }
            elem[i] = min;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j == 0)
                {
                    itog[i, j] = elem[i];
                } 
                //else if (j != 0 && B[i,j] != elem[i])
                //{
                //    itog[i, j] = B[i, j-1];
                //}
            }
            

        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int temp_schet = 0;
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, temp_schet] != elem[i])
                {
                    itog[i, j] = B[i, temp_schet];
                    temp_schet++;
                }
                else
                {
                    temp_schet++;
                    j--;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }
        // end
        return itog;
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
        int ind = 0;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            double polus = 0;
            int schet_otr = 0;
            double max = -9999;
            double otr = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < 0)
                {
                    if (schet_otr == 0)
                    {
                        polus += F[i, j];
                        schet_otr++;
                    }
                    otr = F[i, j];
                }
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    ind = j;
                }
;
            }
            if (schet_otr == 0)
            {
                polus = max*2;
            }
            Console.WriteLine(polus);
            polus += otr;
            polus /= 2;
            F[i, ind] = polus;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{F[i, j]} ");
            }
            Console.WriteLine();
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
        int[,] otvet = new int[G.GetLength(0), G.GetLength(1)];
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
        {
            return null;
        }
        int[] max = new int[5];
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int maxim = -9999;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > maxim)
                {
                    maxim = G[i, j];
                }
            }
            max[i]= maxim;
        }
        for (int i = 0; i < G.GetLength(0); i++)
        {
            bool flag = true;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] == max[i] && flag==true)
                {
                    flag = false;
                    otvet[i, j] = max[i];
                    j++;
                    otvet[i, j] = max[i];
                }
                else
                {
                    if (flag == true)
                    {
                        otvet[i, j] = G[i, j];
                    }
                    else
                    {
                        otvet[i, j] = G[i, j - 1];
                    }
                }
            }
        }
        //end
        return otvet;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length!=7)
        {
            return null;
        }
        double max = -9999;
        int ind = 0;
        int stroka = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
                if (j == 6)
                {
                    stroka = i;
                }
            }
        }
        Console.WriteLine(stroka);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[stroka-1,j]= B[j];
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
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
        int min = 9999;
        int stolb = 0;
        int[,] itog = new int[5, 6];
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
        {
            return null;
        }
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                stolb = j;
            }
        }
        Console.WriteLine(stolb);
        int schet = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (j != stolb+1)
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    itog[i, schet] = F[i, j];
                }
                schet++;
            }
        }
        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i,j]} ");
            }
            Console.WriteLine();
        }
        // end

        return itog;
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
        
        int[] indexmax = new int[A.GetLength(0)];
        double[] srarifm = new double[A.GetLength(0)];
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double avg = 0;
            double n = 0;
            double max = -9999;
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
                if (A[i, j] > 0)
                {
                    avg += A[i, j];
                    n++;
                }
            }
            if (n == 0)
            {
                avg = 0;
            }
            else
            {
                avg /= n;
            }
            srarifm[i] = avg;
            indexmax[i] = index;
        }
       
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, indexmax[i]] = srarifm[i];
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
        {
            return null;
        }
        int[] index_maxims = new int[A.GetLength(0)];           
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxim = -9999;                               
            int maxim_ind = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxim)                            
                {
                    maxim = A[i, j];
                    maxim_ind = j;
                }
            }
            index_maxims[i] = maxim_ind;                        
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (index_maxims[i] == 0)                           
            {
                if (A[i, index_maxims[i] + 1] > 0)              
                {
                    A[i, index_maxims[i] + 1] *= 2;
                }
                else
                {
                    A[i, index_maxims[i] + 1] /= 2;
                }
            }
            else if (index_maxims[i] == A.GetLength(1)-1)         
            {
                if (A[i, index_maxims[i] - 1] > 0)              
                {
                    A[i, index_maxims[i] - 1] *= 2;
                }
                else
                {
                    A[i, index_maxims[i] - 1] /= 2;
                }
            }
            else                                                
            {
                if (A[i, index_maxims[i] - 1] < A[i, index_maxims[i] + 1])
                {
                    if (A[i, index_maxims[i] - 1] > 0)
                    {
                        A[i, index_maxims[i] - 1] *= 2;
                    }
                    else
                    {
                        A[i, index_maxims[i] - 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, index_maxims[i] + 1] > 0)
                    {
                        A[i, index_maxims[i] + 1] *= 2;
                    }
                    else
                    {
                        A[i, index_maxims[i] + 1] /= 2;
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
        if (A.GetLength(0) != 7 && A.GetLength(1) != 5)
        {
            return null;
        }
        int[] index_maxims = new int[A.GetLength(0)];           
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxim = -9999;                               
            int maxim_ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxim)                            
                {
                    maxim = A[i, j];
                    maxim_ind = i;
                }
            }
            index_maxims[j] = maxim_ind;                        
        }
        for (int j = 0; j < A.GetLength(1); j++)                
        {
            int schet_pol = 0;                                 
            int schet_otr = 0;                                  
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) schet_pol++;                   
                else schet_otr++;
            }
            if (schet_pol > schet_otr)                          
            {
                A[index_maxims[j], j] = 0;                      
            }
            else
            {
                A[index_maxims[j], j] = index_maxims[j] + 1;      
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 && A.GetLength(1) != 5)            
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)                    
        {
            int maxim = -9999;                                      
            int maxim_ind = 0;                                      
            for (int i = 0; i < A.GetLength(0); i++)                
            {
                if (A[i, j] > maxim)
                {
                    maxim = A[i, j];
                    maxim_ind = i;
                }
            }
            if (maxim_ind < A.GetLength(0) / 2)                         
            {
                int sum = 0;
                for (int i = maxim_ind + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)            
        {
            return null;
        }
        for (int j = 0; j < A.GetLength(1); j++)                                  
        {
            int maxim = -9999;                                                 
            int maxim_ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)                              
            {
                if (A[i, j] > maxim)
                {
                    maxim = A[i, j];
                    maxim_ind = i;
                }
            }
            if (maxim < B[j])                                                     
            {                                                                     
                A[maxim_ind, j] = B[j];
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
            double maxim = -9999;                                   
            int maxim_ind = 0;
            double polu = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;       
            for (int i = 0; i < A.GetLength(1); i++)
            {
                if (A[i, j] > maxim)                                
                {
                    maxim = A[i, j];
                    maxim_ind = i;
                }
            }
            if (maxim < polu)                                       
            {                                                       
                A[maxim_ind, j] = polu;
            }
            else
            {
                A[maxim_ind, j] = maxim_ind + 1;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        // code here
        if (n != 3) return null;
        int[,] answer = new int[3, 9];
        int schet = 0;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (schet == 0)
                {
                    answer[i, j] = 1;
                }
                else if (schet == 2)
                {
                    schet = -1;
                }
                schet++;
            }
            schet -= 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)          
        {
            return null;
        }
        int maxim = -9999;                                          
        int maxim_str = 0;
        int j = 0;
        for (int i = 0; i < A.GetLength(0); i++)                    
        {
            if (A[i, j] > maxim)
            {
                maxim = A[i, j];
                maxim_str = i;
            }
            j++;
        }
        int temp = 1;
        for (int i = 0; i < maxim_str; i++)
        {
            for (int x = temp; x < A.GetLength(1); x++)
            {
                A[i, x] = 0;
            }
            temp++;
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
        int[] maxim_poz = new int[B.GetLength(0)];                 
        for (int i = 0; i < B.GetLength(0); i++)                   
        {
            int maxik = -9999;
            int maxim_ind = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxik)
                {
                    maxik = B[i, j];
                    maxim_ind = j;
                }
            }
            maxim_poz[i] = maxim_ind;                               
        }

        for (int i = 0; i < B.GetLength(0); i++)                   
        {
            int temp = B[i, maxim_poz[i]];
            B[i, maxim_poz[i]] = B[i + 1, maxim_poz[i + 1]];
            B[i + 1, maxim_poz[i + 1]] = temp;
            i++;
        }
        // end
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[,] itog = new int[A.GetLength(0), A.GetLength(1)];
        int schet_str = 0;
        int schet_stl = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = A.GetLength(1) - 1; j >= 0; j--)
            {
                itog[schet_str, schet_stl] = A[i, j];
                schet_stl++;
            }
            schet_str++;
            schet_stl = 0;
        }
        // end

        return itog;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
        int[] minim = new int[7];
        int[,] itog = new int[7, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = 9999;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min= matrix[i, j];
                    
                }
            }
            minim[i] = min;
        }
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int max = -9999;
            for (int g = 0; g < minim.Length; g++)
            {
                if (minim[g] > max)
                {
                    max = minim[g];
                    index = g;
                }
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                itog[i, j] = matrix[index, j]; 
            }
            minim[index] = -9999;
        }
        // end

        return itog;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }
        int[] answer = new int[2 * matrix.GetLength(1) - 1];
        // code here 
        int schet1 = 0;
        for (int i = matrix.GetLength(0)-1; i>=0; i--)
        {
            int sum = 0;
            int temp = i;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (temp != matrix.GetLength(0))
                {
                    sum += matrix[temp, j];
                    temp++;
                }
            }
            answer[schet1] = sum;
            schet1++;
        }
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            int temp = j;
            for (int i = 0; i< matrix.GetLength(0); i++)
            {
                if (temp!= matrix.GetLength(1))
                {
                    sum += matrix[i, temp];
                    temp++;
                }
            }
            answer[schet1] = sum;
            schet1++;
        }
        
        for (int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1) return null;
        int[] maxim = new int[] { 0, 0 };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[maxim[0], maxim[1]]))
                {
                    maxim[0] = i;
                    maxim[1] = j; 
                }
            }
        }
            

        if (maxim[1] != k - 1)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int temp = matrix[maxim[0], j];
                matrix[maxim[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (maxim[0] != k - 1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, maxim[1]];
                matrix[i, maxim[1]] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
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
        // code here 
        int[] itog = new int[n * n];
        int[,] mA = new int[n, n];
        int[,] mB = new int[n, n];
        int count = 0;
        bool prov = false;
        for (int k = 0; k < A.Length; k++)
        {
            if (A[k] != 0 || B[k] != 0)
            {
                prov = true;
                break;
            }
        }
        if (prov == false)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                mA[i, j] = A[count];
                mB[i, j] = B[count];
                count++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                mA[i, j] = mA[j, i];
                mB[i, j] = mB[j, i];
            }
        }
        count = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += mA[row, k] * mB[k, col];
                }
                itog[count++] = sum;
            }
        }
        return itog;
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        {
            return null;
        }
        int[] otr = new int[matrix.GetLength(1)];
        int[,] itog = new int[5, 7];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int schet = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    schet++;
                }
            }
            otr[j] = schet;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minim = 99999;
            int ind = 0;
            for (int g = 0; g < matrix.GetLength(1); g++)
            {
                if (otr[g] < minim)
                {
                    minim = otr[g];
                    ind = g;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                itog[i, j] = matrix[i, ind];
            }
            otr[ind] = 99999;
        }

        // end

        return itog;
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
        int index = 0;
        int kolvo = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool prov=true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    prov = false;
                }
            }
            if (prov == true)
            {
                kolvo++;
            }
        }
        int[] no = new int[matrix.GetLength(0) - kolvo];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            index = -1;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                no[k] = index;
                k++;
            }
        }
        int[,] itog = new int[kolvo,matrix.GetLength(1)];
        k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool flag = true;
            for (int g = 0; g < no.Length; g++)
            {
                if (i == no[g])
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine(i);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    itog[k, j] = matrix[i, j];
                }
                k++;
            }
            
        }
        for (int i = 0; i < itog.GetLength(0); i++)
        {
            for (int j = 0; j < itog.GetLength(1); j++)
            {
                Console.Write($"{itog[i, j]} ");
            }
            Console.WriteLine();
        }


        // end

        return itog;
    }
    #endregion
}