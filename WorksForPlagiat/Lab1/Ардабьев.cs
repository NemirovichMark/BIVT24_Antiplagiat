using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int n = 2, s = 0;

        while (n <= 35)
        {
            Console.WriteLine(s + " " + n);
            s += n;
            n += 3;
        }
        answer = s;
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0, den = 1.0;         //s - сумма,  den - знаменатель(denominator)
        while (den <= 10.0)
        {
            s = s + 1.0 / den;
            den = den + 1.0;
            Console.WriteLine(Math.Round(s,2));
        }
        // end
        answer = Math.Round(s, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0, numerator = 2.0, denominator = 3.0;
        while ((numerator <=112.0) && (denominator <= 113.0))
        {
            s += numerator / denominator;
            numerator += 2.0;
            denominator += 2.0;
            Console.WriteLine(s);
        }
        // end
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, temp = 0;
        double den;
        if (x != 0)
        {
            s += Math.Cos(x);
            for (int i = 2; i <= 9; i++)
            {
                temp = Math.Cos(i * x);
                den = x;
                for (int n = 1; n < i - 1; n++)
                {
                    den = den * x;
                }
                temp = temp / den;
                s += temp;
            }
        }
        answer = Math.Round(s, 2);
        // end
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, temp;
        for (int n = 0; n < 10; n++)
        {
            temp = p + n * h;
            temp *= temp;
            s += temp;
        }

        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y;
        y = x * (0.5 * x - 7);
        // end
        answer = Math.Round(y,2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int number = 6, fac = 1;
        for (int i = 1; i <= number;i++){fac = fac * i;}
        answer = fac;
        // end
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here
        int end = 6, s = 0;
        for (int j = 1; j <= end; j++)
        {

            int number = j, fac = 1;
            for (int i = 1; i <= number; i++) { fac = fac * i; }
            s += fac;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, temp;
        double x, y, z;

        for (int n = 1; n <= 6; n++)
        {
            x = -1; y = 5; z = n;
            for (int i = 1; i < n; i++)
            {
                x*= -1;
            }

            for (int i = 1; i < n; i++)
            {
                y*= 5;
            }

            int fac = 1;
            for (int i = 1; i <= z; i++)
            {
                fac = fac * i;
            }
            z = fac;
            temp = x * y / z;
            s += temp;
        }
        // end
        answer = Math.Round(s,2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here ¬озвести число 3 в 7-ю степень, не использу€ операцию возведени€ в степень.
        int number = 3, pow = 7;
        for (int i = 1; i<7; i++)
        {
            number *= 3;
        }
        answer = number;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        string str1 = "";
        for (int n = 1; n <= 6; n++)
        {
            if (n != 6){str1 += $"{n} ";}
            else {str1 += $"{n}";}   
        }
        Console.WriteLine(str1);

        string str2 = "";
        for (int n = 1; n <= 6; n++)
        {
            if (n != 6) {str2 += "5 ";}
            else {str2 += '5';}
        }
        Console.WriteLine(str2);
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, temp = x;
        if (x != 0)
        {
            s += 1;
            for (int n = 1; n <= 10; n++)
            {
                s += 1 / temp;
                temp = x;
                for (int i = 1; i <= n; i++)
                {
                    temp *= x;
                }
                Console.WriteLine(s);
            }
        }
        // end
        answer = Math.Round(s,2);
        return answer;
    }
    public double Task_1_13(double x)   
    {
        double answer = 0;

        // code here
        double y;

        if (x <= -1)
        {
            y = 1;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
        }
        else
        {
            y = -1;
        }
        answer = y;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int temp1 =1,temp2 = 1,summ;
        string str = "";
        for (int i = 1; i <= 8; i++)
        {
            if (i == 8) { str += $"{temp1}"; }  // чисто
            else { str += $"{temp1} "; }        // косметически
            summ = temp1 + temp2;
            temp1 = temp2;
            temp2 = summ;
        }
        Console.WriteLine(str);

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double temp = 0;
        int temp1, temp2, summ;
        int numirator = 1, denominator = 1;
        for (int n = 1; n <= 5; n++)
        {
            temp1 = 1; temp2 = 1; summ = 1;
            for (int i = 1; i <= n; i++)
            {
                numirator = summ;
                summ = temp1 + temp2;
                temp1 = temp2;
                temp2 = summ;
                
            }
            //Console.WriteLine(numirator);

            temp1 = 1; temp2 = 1; summ = 1;
            for (int i = 1; i <= n-1; i++)
            {
                denominator = summ;
                summ = temp1 + temp2;
                temp1 = temp2;
                temp2 = summ;
            }
            //Console.WriteLine(denominator);
            temp = (double)numirator / (double)denominator;
            //Console.WriteLine($"{numirator}/{denominator}");
        }
        answer = Math.Round(temp, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        ulong wheat = 1, amount=0;
        for (int i = 1; i <= 64; i++)
        {
            amount += wheat; // кол-во зЄрен, но ответ не удовлетвор€ет тест)
            //Console.WriteLine($"пшена на клетке: {wheat} || кол-во зЄрен на доске: {amount}");
            wheat *= 2;
        }
        double weight = amount / 15; // масса в граммах

        for (int i = 0; weight > 1; i++)
        {
            if(weight/10 > 1)
            {
                power++;
                weight = weight / 10;
            }
            else { break; }
        }
        // end
        answer = Math.Round(weight, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350, d;
        for (int h = 1; h <= x; h++)
        {
            d = Math.Sqrt(h * (2 * R + h));
            answer = d;
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int count = 10;
        for(int h = 3; h <= x; h+=3)
        {
            count *= 2;
            //Console.WriteLine($"количество клеток: {count} прошло часов:{h}");
            answer = count;
        }
        // end
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int L = 30000,p = 1,n = 1;
        while(p * n <= L)
        {
            n += 3;
            p = p * n;
            answer = n;
        }
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, temp = x;
        int n = 2;

        if (Math.Abs(x) < 1)
        {
            s += 1;
            while (true)
            {
                temp = x;
                for (int i = 1; i < n; i++)
                {
                    temp *= x;
                }

                s += temp;
                n += 2;

                if (temp < 0.0001)
                {
                    break;
                }
                Console.WriteLine(s);
            }
        }
        
        answer = Math.Round(s,2);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()   
    {
        int answer = 0;

        // code here
        int count = 10;
        int h=3;
        for (h = 3; count <= Math.Pow(10, 5); h += 3)
        {
            count *= 2;
            Console.WriteLine($"количество клеток: {count} прошло часов:{h}");
            if (count >= Math.Pow(10, 5)) { break; }
        }
        answer = h;
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        double s = 10000, k = 0.08;
        int month = 0;
        while (s < 20000)
        {
            month++;
            s += s * k;
            Console.WriteLine($"мес€ц {month},сумма {s}");
        }
        answer = month;
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        int count = 0;

        double temp = 0;
        int temp1, temp2, summ;
        int numirator = 1, denominator = 1;
        for (int n = 1; n <= 100; n++)
        {
            temp1 = 1; temp2 = 1; summ = 1;
            for (int i = 1; i <= n; i++)
            {
                numirator = summ;
                summ = temp1 + temp2;
                temp1 = temp2;
                temp2 = summ;

            }


            temp1 = 1; temp2 = 1; summ = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                denominator = summ;
                summ = temp1 + temp2;
                temp1 = temp2;
                temp2 = summ;
            }

            double temp0 = temp;
            temp = (double)numirator / (double)denominator;

            count += 1;
            if (Math.Abs(temp - temp0) <= 0.001)
            {
                answer = count;
                Console.WriteLine(count);
                Console.WriteLine(temp);
                Console.WriteLine(temp0);
                break;
            }


        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here
        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        double n = x;
        for (int i = 1; n > 0.0001; i++)
        {
            S += n * Math.Sin(i * Math.PI / 4);
            n *= x;
        }
        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}
