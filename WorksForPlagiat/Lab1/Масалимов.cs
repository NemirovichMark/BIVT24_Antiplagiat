using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
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
        int i = 0;
        for (i = 2; i <= 35; i = i + 3)
        {
            answer = answer + i;
        }

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            answer = Math.Cos(x);
            double x1 = x;
            for (double i = 2; i <= 9; i++)
            {
                answer += Math.Cos(x * i) / x1;
                x1 *= x;
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer += (p + h * (i - 1)) * (p + h * (i - 1));
        }
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
        int answer = 1;

        // code here
        for (int i = 1; i < 7; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int j = 1;
        for (int i = 1; i < 7; i++)
        {
            j *= i;
            answer += j;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double one = 1;
        double two = 1;
        double three = 1;
        for (double i = 1; i < 7; i++)
        {
            one *= (-1);
            two *= 5;
            three *= i;
            answer += one * two / three;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i < 8; i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i < 7; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine();
        for (int i = 1; i < 7; i++)
        {
            Console.Write(5);
            Console.Write(' ');
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double x_pow = 1;
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / x_pow;
                x_pow *= x;
            }
            answer = Math.Round(answer, 2);
        }

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (x <= 1) { answer = -x; }
        else { answer = -1; }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int one = 1, two = 1, three = 0;
        Console.Write(1);
        Console.Write(' ');
        Console.Write(1);
        for (int i = 0; i <= 5; i++)
        {
            three = two;
            two = one + two;
            one = three;
            Console.Write(' ');
            Console.Write(two);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double one = 1, two = 1, three = 0;
        for (int i = 0; i <= 4; i++)
        {
            answer = two / one;
            three = two;
            two = one + two;
            one = three;

        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double seed = 1;
        double one = 1;
        for (int i = 0; i < 8 * 8 - 1; i++)
        {
            one *= 2;
            seed += one / 15;
        }
        while (seed >= 10.0)
        {
            power += 1;
            seed /= 10;
        }
        answer = Math.Round(seed, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = x; i > 0; i -= 3)
        {
            answer *= 2;
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
        int answer = 1;

        // code here
        int L = 30000;
        int p = 1;
        while (p * (answer + 3) < L)
        {
            answer += 3;
            p *= answer;
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
        double answer = 1;
        double Change = 1;

        // code here
        if (x >= 1 || x <= -1)
        {
            answer = 0;
        }
        else
        {
            while (Change >= 0.0001)
            {
                Change *= x * x;
                answer += Change;
            }
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
        int cells = 10;
        while (cells < 100000) {
            cells *= 2;
            answer += 1;
        }
        answer *= 3;
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
        double money = 10000;
        while (money < 20000)
        {
            money *= 1.08;
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
        int answer = 2;

        // code here;
        double one = 1, two = 1, three = 0;
        double answer1 = two / one;
        three = two;
        two = one + two;
        one = three;
        double answer2 = two / one;
        while (Math.Abs(answer2 - answer1) > 0.001)
        {
            answer1 = answer2;
            three = two;
            two = one + two;
            one = three;
            answer2 = two / one;
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
        double e = 1;

        y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        double S1 = 1;
        double j = 1, x1 = 1, factorial_j = 1;
        while (S1 >= 0.0001)
        {
            x1 *= x * x;
            S += S1;
            S1 = (2 * j + 1) * x1 / factorial_j;
            j++;
            factorial_j *= j;
        }
        // end
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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
