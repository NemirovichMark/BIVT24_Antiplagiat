using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        double n = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            n += array[i];
        }

        for (int j = 0; j < array.Length; j += 1)
        {
            array[j] = Math.Round(array[j] / n, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                cnt++;
            }
        }
        double srar = s / cnt;
        for (int t = 0; t < array.Length; t++)
        {
            if (array[t] > 0)
            {
                array[t] = Math.Round(srar, 2);

            }
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sred = 0;
        double sum = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            k += 1;
        }
        sred = sum / k;
        for (int i = 0; i < array.Length; i += 1)
        {
            array[i] -= sred;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i += 2)
        {
            product += vector1[i] * vector2[i] + vector1[i + 1] * vector2[i + 1];
            product = Math.Round(product, 2);
        }

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        if (count > 0)
        {
            avg = s / count;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
            {
                array[i] = 0;
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
            if (array[i] < 0)
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

        // code here
        double s = 0;
        int k = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        if (k > 0)
        {
            avg = s / k;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
            {
                count++;
            }
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (P < array[i] && array[i] < Q)
            {
                count++;
            }
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach (double elem in array)
        {
            if (elem > 0)
                count++;
        }
        output = new double[count];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j++] = array[i];

            }

        }

        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        double v = 0;
        int ind = -1;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                v = array[i];
                ind = i;
            }
        }

        // end

        return (v, ind);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int index_1 = 0;
        int index_2 = 0;
        for (int i = 0; i < array.Length; i++)
            if (i % 2 == 0)
            {
                even[index_1] = array[i];
                index_1++;
            }

            else
            {
                odd[index_2] = array[i];
                index_2++;
            }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += Math.Pow(array[i], 2);
            }
            else
            {
                break;
            }
        }

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = Double.NaN;
            }

        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int ind = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                ind = i;
            }
        }
        if (array[ind] >= 0)
            array[ind] *= 2;
        else
            array[ind] /= 2;

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
        int n = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i < n && array[i] >= 0)
                array[i] *= 2;
            else if (i < n && array[i] < 0)
                array[i] /= 2;

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
        int Imax = 0, Imin = 0, count = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Imin]) Imin = i;
            if (array[i] > array[Imax]) Imax = i;
        }

        if (Imin > Imax)
        {
            int temp = Imax;
            Imax = Imin;
            Imin = temp;
        }

        for (int i = Imin + 1; i < Imax; i++)
            if (array[i] < 0)
                count++;

        double[] array2 = new double[count];

        for (int i = Imin + 1; i < Imax; i++)
            if (array[i] < 0)
            {
                array2[k] = array[i];
                k++;
            }
        array = array2;

        // end

        return array;
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
        int indm = 0;
        double valMax = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valMax)
            {

                valMax = array[i];
                indm = i;
            }
        }

        if (indm == array.Length - 1)
            return array;
        else if (array[indm + 1] > 0)
            array[indm + 1] = array[indm + 1] * 2;
        else
            array[indm + 1] = array[indm + 1] / 2;
        // end

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
        double average = 0;

        // code here
        double min = array[0];
        double max = array[0];
        int idmin = 0, idmax = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }

            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
        }


        if (idmin > idmax)
        {
            int temp = idmin;
            idmin = idmax;
            idmax = temp;
        }


        double sum = 0;
        int cnt = 0;
        for (int i = idmin + 1; i < idmax; i++)
        {
            sum += array[i];
            cnt++;
        }


        if (cnt > 0)
            average = sum / cnt;
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here
        double[] temp = new double[array.Length + 1];
        int Index = -1;
        for (int i = array.Length - 1; i > -1; i--)
        {
            if (array[i] > 0)
            {
                Index = i;
                break;
            }

        }
        if (Index == -1) return array;
        for (int i = 0; i <= Index; i++)
        {
            temp[i] = array[i];
        }
        temp[Index + 1] = P;

        for (int i = Index + 1; i < array.Length; i++)
        {
            temp[i + 1] = array[i];
        }
        array = temp;

        // end

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
        int ind = -1;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind = i;

                }
            }

        }

        array[ind] = ind;

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
        if (k >= A.Length)
            return A;
        output = new double[A.Length + B.Length];
        for (int i = 0; i <= k; i++)
            output[i] = A[i];
        for (int i = k + 1, j = 0; i < k + 1 + B.Length; i++)
            output[i] = B[j++];
        for (int i = k + 1 + B.Length, j = k + 1; i < output.Length; i++)
            output[i] = A[j++];

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
        int imax = -1, imin = -1;
        double amax = -999999, amin = 999999, sum = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                {
                    sum += array[i];
                    count++;
                }
            if (count == 0) return 0.0;
        }

        average = sum / count;
        Console.WriteLine(average);

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
        int indm = 0;
        double sum = 0, valMax = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

            if (array[i] > valMax)
            {
                indm = i;
                valMax = array[i];
            }
        }

        if (valMax > sum)
            array[indm] = 0;
        else
            array[indm] = valMax * 2;
        // end

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

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double max = -100000;
        int k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += k;
                k++;
            }
        }

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
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here
        double[] chet = new double[(array.Length + 1) / 2];
        int chetindex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            chet[chetindex] = array[i];
            chetindex++;
        }
        for (int i = 0; i < chet.Length - 1; i++)
        {
            for (int j = 0; j < chet.Length - 1 - i; j++)
            {
                if (chet[j] > chet[j + 1])
                {
                    double n = chet[j];
                    chet[j] = chet[j + 1];
                    chet[j + 1] = n;
                }
            }
        }
        chetindex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = chet[chetindex];
            chetindex++;

        }

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

        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here
        double[] copy = new double[array.Length];
        double[] output = new double[array.Length];
        double min = double.MinValue;
        int nom = -1;
        for (int i = 0; i < array.Length; i++)
            copy[i] = array[i];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                output[i] = array[i];
            else
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((copy[j] > min) & (copy[j] < 0))
                    {
                        min = copy[j];
                        nom = j;
                    }
                }
                output[i] = array[nom];

                copy[nom] = 3;

            }

            nom = -1;
            min = double.MinValue;

        }
        array = output;

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

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        X = new double[n];
        Y = new double[n];
        double h = (b - a) / (n - 1);
        double max = -1000000;
        double min = 1000000;
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = a + i * h;
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > max)
                max = Y[i];
            if (Y[i] < min)
                min = Y[i];
        }
        globalMax = max;
        globalMin = min;

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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here
        normalizedArray = new double[array.Length];
        double max = -1000000;
        double min = 1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }

        // end

        return normalizedArray;
    }
    #endregion
}