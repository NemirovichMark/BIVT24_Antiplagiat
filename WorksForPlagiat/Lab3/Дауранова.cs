using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double S = 0;
        for(int i = 0;i<array.Length; i++)
        {
            S+=array[i]; // сумма массива

        }
        for(int k=0;k<array.Length;k++)
        {
            double a = array[k]/S;
            array[k] = Math.Round(a,2);

        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double S = 0;
        int k = 0;
        for (int i = 0; i<array.Length;i++)
        {
            if (array[i]>0)
            {
                S+=array[i];
                k++;
            }
        }
        double a = S/k;
        for (int i =0; i<array.Length;i++)
        {
            if (array[i]>0)
            {
                array[i] = Math.Round(a,2);
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0;i<4;i++)
        {
            sum[i]=Math.Round(first[i]+second[i],2);
            dif[i]=Math.Round(first[i]-second[i],2);

        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for ( int i = 0; i<array.Length; i++)
        {
            s+=array[i];
        }
        double razm = s/array.Length;
        razm = Math.Round(razm,2);
        double[] result = new double[array.Length];
        for (int i = 0; i<array.Length; i++)
        {
            result[i] = Math.Round(array[i] - razm, 2);
        }
        // end

        return result;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        if (vector1 == null || vector2 == null || vector1.Length != 4 || vector2.Length != 4) 
        {
        return 0; 
        }
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }

        return Math.Round(product, 2);
        // end

        
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);
        //end
        return Math.Round(length, 2);

        // end

        
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double S = 0;
        for (int i = 0; i < array.Length;i++)
        {
            S+=array[i];
        }
        double a = S/array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>a)
            {
                array[i]=0;
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0)
            {
                count++;
            }

        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double s = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            s += array[i];
        }
        double a = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                count += 1;
            }
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > P && array[i] < Q)
            {
                count += 1;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
             int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        double[] output = new double[count];
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;

            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] e = new double[array.Length / 2];
        double[] o = new double[array.Length/2];
        int n_e = 0;
        int n_o= 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                e[n_e++] = array[i];           
               
            }
            else if (i % 2 != 0)
            {
                o[n_o++] = array[i];     
            }

        }
        return (e, o);
    }
    public double Task_1_14(double[] array)
    {
        double s = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                break;
            }
            s += array[i] * array[i];
            
        }
        // end

        return s;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            }
            System.Console.WriteLine($"{x[i]:F3}\t{y[i]:F3}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        
        double min = Double.MaxValue;
        int idMin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                idMin = i;
            }
        }
        if (array[idMin] < 0)
        {
            array[idMin] = min / 2;
        }
        else
        {
            array[idMin] = min * 2;
        }

        // end

        return array;
        

       
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = array[0];
        int a = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<min)
            {
                min = array[i];
                a = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i < a && array[i] >= 0 )
            {
                array[i] *= 2;
            }
            else if (i < a && array[i] < 0)
            {
                array[i] /= 2;
            }
            System.Console.WriteLine(array[i]);    
        }

        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double max = array[0];
        double min = array[0];
        int max_i = -1;
        int min_i = -1;
        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_i = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
        }
        int start, end;
        if (min_i < max_i)
        {
            start = min_i+1;
            end = max_i;
        }
        else
        {
            start = max_i +1;
            end = min_i;
        }
        int neg = 0;
        {
            for (int i = start; i<end; i++)
            {
                if (array[i]<0)
                {
                    neg++;
                }
            }
        }
        double[] neg_el = new double[neg];
        int j = 0;
        for (int i = start; i<end;i++)
        {
            if (array[i]<0)
            {
                neg_el[j] = array[i];
                j++;
            }
        }

        return neg_el;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here
        int maxI = 0;
        double max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
        }
        if (maxI == array.Length - 1)
        {
            return array;
        }
        else if (array[maxI +1]>0)
        {
            array[maxI + 1] = array[maxI + 1] * 2;
        }
        else
        {
            array[maxI + 1] = array[maxI + 1] / 2;
        }
        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double avarage = 0;
        double min = array[0];
        double max = array[0];
        int minI = 0;
        int maxI = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minI = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
            
        }
        if (minI > maxI)
        {
            int temp = minI;
            minI = maxI;
            maxI = temp;
        }
        
        double s = 0;
        int k = 0;

        for (int i = minI + 1;i < maxI; i++)
        {
            s += array[i];
            k++;
        }
        if (k > 0)
        {
            avarage = s/k;
        }

        return avarage;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int maxI = -1;
        for (int i = array.Length - 1; i>=0; i--)
        {
            if (array[i] > 0)
            {
                maxI = i;
                break;
            }
        }
        double[] reslt = new double[array.Length + 1];
        if (maxI < 0)
        {
            reslt = array;
        }
        else 
        {
            for (int i = 0; i<=maxI; i++)
            {
                reslt[i] = array[i];
            }
            reslt[maxI + 1] = P;

            for (int i = maxI + 1; i < array.Length; i++)
            {
                reslt[i + 1] = array[i];
            }
        }
        array = reslt;
        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here
        double max = array[0];
        int maxI = 0;

        for (int i = 0; i <array.Length; i++)
        {
            if (array[i]>max && i % 2==0)
            {
                max = array[i];
                maxI = i;
            }
        }
        array[maxI] = maxI;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here
        int n = A.Length + B.Length;
        output = new double[n];
        if (k<A.Length)
        {
            for ( int i = 0; i<= k; i++)
            {
                output[i] = A[i];

            }
            for (int i = 0; i<B.Length; i++)
            {
                output[i+k+1] = B[i];
            }
            for (int i = A.Length - 1; i >= k + 1; i--)
            {
                output[i + B.Length] = A[i];
            }
        }
        else
        {
            output = A;
        }
        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here
        int maxI = 0, minI = 0;
        double max = array[0], min = array[0];
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minI = i;
            }

        }
        if (maxI < minI)
        {
            double s = 0;
            int k = 0;
            for ( int j = 0; j <array.Length; j++)
            {
                if (array[j]>0)
                {
                    k++;
                    s+=array[j];
                }
            }
            if (k == 0)
            {
                return 0;
            }
            average  = Math.Round(s/k,3);
        }
        else
        {
            double s1 = 0;
            int k1 = 0;
            for (int a = 0; a < array.Length; a++)
            {
                if (array[a]<0)
                {
                    k1++;
                    s1+=array[a];
                }
            }
            if (k1 == 0)
            {
                return 0;
            }
            average =  Math.Round(s1/k1,3);
        }
        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here
        int maxI = 0;
        double s = 0;
        double max = -10000000000;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
                maxI = i;
            }
            s += array[i];
        }
        if (max - s > 0)
        {
            array[maxI] = 0;
        }
        else 
        {
            array[maxI] *= 2;
        }
        
        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        double id = -1;
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > id)
            {
                id = array[i];
                k = 1;
            }
            else if (array[i] == id)
            {
                k++;
            }
        }

        if (k == 0)
            return output;

        output = new int[k];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == id)
            {
                output[index++] = i;
            }
        }

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        
        if (array.Length == 0)
        {
            return array;
        }

        double max = double.MinValue;
        foreach (double x in array)
        {
            if (x > max)
            {
                max = x;
            }
        }

        double n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                n += array[i];
                array[i] = Math.Round(n, 2) - array[i];
            }

            else
            {
                n += array[i];
            }
        }
        // end

        return array;
}

    public double[] Task_3_5(double[] array)
    {
        // code here

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here
        int p = 0;
        int o = 0;

        foreach (double n in array)
        {
            if (n >= 0)
            {
                p++;
            }
            else
            {
                o++;
            }
        }

        double[] pn = new double[p];
        double[] on = new double[o];

        int pid = 0, oid = 0;

        foreach (double num in array)
        {
            if (num >= 0)
            {
                pn[pid++] = num;
            }
            else
            {
                on[oid++] = num;
            }
        }

        double[] result = new double[array.Length];
        int index = 0;

        foreach (double num in pn)
        {
            result[index++] = num;
        }

        foreach (double num in on)
        {
            result[index++] = num;
        }
        array = result;

       
        // end

        return array;
}  
    public double[] Task_3_8(double[] array)
    {
        // code here

        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here
        
        for (int i = array.Length-1; i>= 0; i-=2)
        {
            array[i] = array[i/2];
            array[i-1] = array[i];
        }
        
        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

        // end

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here
        int n = 0; int p = 0;
        double[] neww = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            bool d = true;
            for (int j = 0; j < neww.Length; j++)
            {
                if (array[i] == neww[j])
                {
                    d = false;
                }
            }
            if (d == true)
            {
                neww[i] = array[i];
            }
        }
        for (int i = 0; i < neww.Length; i++)
        {
            if (neww[i] == 0 && neww[i] != array[i])
            {
                n++;
            }
        }
        double[] res = new double[neww.Length - n];

        for (int i = 0; i < neww.Length; i++)
        {
            if (neww[i] == array[i])
            {
                res[p] = neww[i];
                p++;
            }
        }
        array = res;
        // end

        return array;
       
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here

        // end

        return normalizedArray;
    }
    #endregion
}