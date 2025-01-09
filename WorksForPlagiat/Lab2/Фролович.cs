using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(8);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs(x*x + y*y - r*r) <= 0.001){
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 & y + Math.Abs(x) <= 1)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0)
        {
            c = Math.Max(a, b);
        }
        else
        {
            c = Math.Min(a, b);
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a,b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
            double d = 0;
            d = Math.Sqrt(2 * s);
            double D = 0;
            D = Math.Sqrt(4 * r / Math.PI);
            if (d <= D)
                answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(r / Math.PI);
        double b = Math.Sqrt(s);
        if (2 * a <= b)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        } 
        else if (Math.Abs(x) <= 1)
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 0;
        }
        else if (Math.Abs(x) <= 1)
        {
            answer = x*x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x  <= -1)
        {
            answer = 0;
        }
        else if (-1 < x & x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x & x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double s = 0;
        int a = 0;
        double age = 0;
        for(int i = 1;i <= 10 ; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out age);
            age = double.Parse(input, new CultureInfo("en-US"));
            age = Convert.ToDouble(input, new CultureInfo("en-US"));
            s += age;
        }
        answer = s / 10;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        double d = 0;
        // code here
        //Console.WriteLine(n);
        //Console.WriteLine(r);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            x -= a; y -= b;
            d = Math.Sqrt(x*x + y*y);
            //Console.WriteLine(d);
            if (d <= r)
            {
                answer++;
            }
            n -= 1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double w = 0;
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out w);
            if (w < 30)
            {
                answer+= 0.2;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0; double y = 0;double d = 0;
        while (n > 0) 
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            d = Math.Sqrt(x*x + y*y);
            if (d >= r1 & d <= r2)
            {
                answer++;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double d = 0;
        // code here
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out d);
            if (d < norm)
            {
                answer++;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        // code here
        double x = 0;
        double y = 0;
        double d = 0;
        while (n > 0)
        {
            double.TryParse(Console.ReadLine() , out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 & y <= Math.Sin(x) & x >= 0 & x <= Math.PI)
            {
                answer++;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x = 0, y = 0;
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 & y > 0)
            {
                Console.WriteLine(" вадрант 1");
                answer1++;
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine(" вадрант 4");
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine(" вадрант 2");
            }
            else 
            { 
                Console.WriteLine(" вадрант 3");
                answer3++;
            }
            n -= 1;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        int num = 0;
        double x = 0;
        double y = 0;
        double d = 0;
        while (n > 0) 
        {
            num += 1;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            d = Math.Sqrt(x * x + y * y);
            if (d < answerLength)
            {
                answer = num;
                answerLength = d;
            }
            n -= 1;
        }
        answerLength = Math.Round(answerLength,2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double t = 0;
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out t);
            if (t < answer)
            {
                answer = t;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        // code here;
        while (n > 0) 
        {
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            int.TryParse(Console.ReadLine(), out d);
            if (a > 3 & b > 3 & c > 3 & d > 3)
            {
                answer++;
            }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        double num = 0;
        double x = n;
        while (n > 0) 
        {
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            int.TryParse(Console.ReadLine(), out d);
            if (a == 2 || b == 2 || c == 2 || d == 2) 
            {
                answer++;
            }
            num += a;
            num += b;
            num += c;
            num += d;
            n -= 1;
        }
        avg = num / (x * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2 || r <= 0){
            answer = 0;
        }
        else if (type == 0)
            answer = r * r;
        else if (type == 1)
            answer = Math.PI * r * r;
        else if (type == 2)
            answer = r * r * Math.Sqrt(3) / 4;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2 || A <= 0 || B <= 0)
        {
            answer = 0;
        }
        else if (type == 0)
        {
            answer = A * B;
        }
        else if (type == 1)
        {
            answer = Math.PI * Math.Abs(A * A - B * B);
        }
        else if (type == 2)
        {
            answer = 0.5 * A * Math.Sqrt(B*B-(A*A)/4) ;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        double counter = 0;
        double num = 0;
        int check = 0;
        // code here
        while (true)
        {
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Continue? Yes = 1 No = 0");
            int.TryParse(Console.ReadLine(), out check);
            counter += n;
            num++;
            if (check == 0)
            {
                break;
            }
        }
        answer = counter / num;
        Console.WriteLine(answer); 
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        double ves = 0;
        while (true)
        {
            Console.WriteLine("введите start, чтобы начать или продолжить, а stop, чтобы остановить");
            string flag = Console.ReadLine();
            if (flag == "stop")
                break;
            else if (flag == "start")
            {
                ves = double.Parse(Console.ReadLine());
                if (ves < 30)
                    answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        double x, y = 0;
        while (true)
        {
            Console.WriteLine("введите start, чтобы начать или продолжить, а stop, чтобы остановить");
            string flag = Console.ReadLine();
            if (flag == "stop")
                break;
            else if (flag == "start")
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (y >= 0 && Math.Sin(x) >= y)
                    answer++;
                else if (y <= 0 && Math.Sin(x) <= y)
                    answer++;
                else
                    continue;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        double vrem = 0;
        while (true)
        {
            Console.WriteLine("введите start, чтобы начать или продолжить, а stop, чтобы остановить");
            string flag = Console.ReadLine();
            if (flag == "stop")
                break;
            else if (flag == "start")
            {
                vrem = double.Parse(Console.ReadLine());
                if (vrem < answer)
                    answer = vrem;
            }

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}