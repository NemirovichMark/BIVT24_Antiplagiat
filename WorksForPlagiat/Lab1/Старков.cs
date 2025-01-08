using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        //program.Task_3_2(0.1);
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
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
            answer += 1.0 / i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+=2)
            answer += i / (i + 1.0);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Cos(x);
        double x1 = x;
        if (x == 0)
            return 0;
        for (double i = 2; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / x1;
            x1 = x1 * x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        answer = p * p;
        for (double i = 1; i <= 9; i++)
            answer += (p + h * i) * (p + h * i);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        answer = 1;
        int s = 1;
        for (int i = 2; i <= 6; i++)
        {
            s *= i;
            answer += s;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double k = -1;
        double a = 5;
        double z = 1;
        answer = k * a / z;
        for (double i = 2; i <= 6; i++)
        {
            a *= 5;
            k *= -1;
            z *= i;
            answer += (k * a) / z;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            if (i < 6)
                Console.Write(i + " ");
            else
            {
                Console.Write(i);
                Console.WriteLine();
            }
        }
        for (int i = 1; i <= 6; i++)
        {
            if (i < 6)
                Console.Write("5 ");
            else
                Console.Write("5");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double x1 = x;
        answer = 1;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / x1;
            x1 *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > -1 && x <= 1)
            answer = -1 * x;
        else if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a1 = 1;
        int a2 = 1;
        Console.Write(a1 + " " + a2 + " ");
        for (int i = 3; i <= 7; i++)
        {
            int temp = a2;
            a2 += a1;
            a1 = temp;
            Console.Write(a2 + " ");
        }
        Console.Write(a2 + a1);
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x1 = 1;
        double y1 = 1;
        double x2 = 2;
        double y2 = 1;
        for (int i = 3; i <= 5; i++)
        {
            double temp1 = x2;
            double temp2 = y2;
            x2 += x1;
            y2 += y1;
            x1 = temp1;
            y1 = temp2;
        }
        // end
        answer = Math.Round((x2/y2), 2);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        answer = 1;
        double x = 1;
        for (int i = 2; i <= 64; i++)
        {
            x *= 2;
            answer += x;
        }
        answer /= 15;
        while (answer >= 10)
        {
            answer /= 10;
            power += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - (r * r));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = x / 3;
        answer = 10;
        for (int i = 1; i <= a; i++)
            answer *= 2;
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
        int p = 1;
        answer = 1;
        while (p <= 30000)
        {
            answer += 3;
            p *= answer;
        }
        answer -= 3;
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
        if (Math.Abs(x) == 1)
            return 0;
        double x1 = 1;
        double e = 0.0001;
        while (x1 >= e)
        {
            answer += x1;
            x1 *= x * x;
        }
        answer = Math.Round(answer, 2);
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
        int i = 10;
        while (i < 100000)
        {
            i *= 2;
            answer += 3;
        }
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
        double i = 10000;
        while (i < 20000)
        {
            i *= 1.08;
            answer += 1;
        }
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
        double x1 = 1;
        double y1 = 1;
        double x2 = 2;
        double y2 = 1;
        answer = 2;
        while(Math.Abs((x1 / y1) - (x2 / y2)) >= 0.001)
        {
            double temp1 = x2;
            double temp2 = y2;
            x2 += x1;
            y2 += y1;
            x1 = temp1;
            y1 = temp2;
            answer += 1;
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
        double k = 1;
        double i = 1;
        double x1 = x * x * x;
        double a = 1;
        while (Math.Abs(a) >= 0.0001)
        {
            a = k * x1 / (4 * i * i - 1);
            S += a;
            k *= -1;
            x1 *= x * x;
            i += 1;
        }
        S -= a;
        y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;
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