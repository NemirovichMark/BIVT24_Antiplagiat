using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
        program.Task_2_1(10);
        program.Task_2_2(5, 3, 2, 1);
        program.Task_2_2(5, 1.5, 1.5, 1);
        program.Task_2_2(5, 1, 3, 1);
        program.Task_2_3(10);
        program.Task_2_4(5, 1, 2);
        program.Task_2_5(10, 30);
        program.Task_2_6(5);
        program.Task_2_7(5);
        program.Task_2_8(5);
        program.Task_2_9(10);
        program.Task_2_10(10);
        program.Task_2_11(10);
        program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        program.Task_3_2(3, 2, 1);
        program.Task_3_2(1.5, 1.5, 1);
        program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;

        if (Math.Abs((x * x + y * y) - (r * r)) <= 0.001)
        {
            answer = true;
            Console.WriteLine("Точка лежит на окружности");
                }
        else
        {
            answer = false;
            Console.WriteLine("Точка не лежит на окружности");
                }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
            Console.WriteLine("Точка лежит внутри треугольника");
                }
        else
        {
            answer = false;
            Console.WriteLine("Точка лежит вне треугольника");
                }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c;

        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        else
        {
            if (a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z, ab;

        if (a < b)
            ab = a;
        else
            ab = b;
        if (ab > c)
            z = ab;
        else
            z = c;

        answer = z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double dl = Math.Sqrt(2 * s);
        double dr = 2 * (Math.Sqrt(r / 3,14));

        if (dl <= dr)
        {
            answer = true;
            Console.WriteLine("Квадрат поместиться в круг");
        }
        else
        {
            answer = false;
            Console.WriteLine("Квадрат не поместиться в круг");
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double dl = Math.Sqrt(s);
        double dr = 2 * (Math.Sqrt(r / 3,14));

        if (dr <= dl)
        {
            answer = true;
            Console.WriteLine("Круг поместиться в квадрат");
        }
        else
        {
            answer = false;
            Console.WriteLine("Круг не поместится в квадрат");
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y = 0;

        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y = 0;

        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = x * x - 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;

        if (x <= -1)
        {
            y = 0;
        }
        else if (-1 < x && x <= 0)
        {
            y = 1 + x;
        }
        else
        {
            y = 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;

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
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sr, r, s = 0;

        for (int i = 1; i <= n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        sr = s / n;
        answer = sr;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double c = 0, x, y;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                c++;
        }

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double c = 0, w;
        for (double i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите вес");
            w = double.Parse(Console.ReadLine());

            if (w < 30)
                c += 200;
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double с = 0, x, y;

        for (double i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());

            if (Math.Abs(x * x + y * y) >= r1 * r1 && (Math.Abs(x * x + y * y) <= r2 * r2))
                с++;
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double a = 0, r;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите результаты участников");
            r = double.Parse(Console.ReadLine());

            if (r <= norm)
                a++;
        }
        Console.WriteLine(a);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
                answer++;
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
        double x, y;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка лежит в 1 квадранте");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка лежит во 2 квадранте");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в 3 квадранте");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в 4 квадранте");
            }
        }
        Console.WriteLine($"В первом квадранте лежит = {answer1}, в 3 квадранте лежит = {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"Ближайшая точка = {answer}, величина расстояния = {answerLength:F2}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double r;

        for (int i = 1; i <= n; i++)
        {
            r = Convert.ToDouble(Console.ReadLine());
            if (r < answer)
                answer = r;
        }
        Console.WriteLine($"Лучший результат = {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double p1 = 0, p2 = 0, p3 = 0, p4 = 0;

        for (int i = 1; i <= n; i++)
        {
            p1 = double.Parse(Console.ReadLine());
            p2 = double.Parse(Console.ReadLine());
            p3 = double.Parse(Console.ReadLine());
            p4 = double.Parse(Console.ReadLine());

            if (p1 > 3 && p2 > 3 && p3 > 3 && p4 > 3)
                answer++;

        }
        Console.WriteLine($"Студениы не имеющие «2» и «3» = {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double p1 = 0, p2 = 0, p3 = 0, p4 = 0;
        double s = 0, k = 0;

        for (int i = 1; i <= n; i++)
        {
            p1 = double.Parse(Console.ReadLine());
            p2 = double.Parse(Console.ReadLine());
            p3 = double.Parse(Console.ReadLine());
            p4 = double.Parse(Console.ReadLine());
            if (p1 == 2 || p2 == 2 || p3 == 2 || p4 == 2)
            {
                answer++;
            }
            s += p1 + p2 + p3 + p4;
            k += 4;
        }
        avg = s / k;
        Console.WriteLine($"Неуспевающие студенты = {answer},  средний балл группы = {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A)) / 4;
                break;
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

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        bool stop = false;
        double c = 0, x, y;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("Введите x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("Введите y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop)
            {
                break;
            }
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                c++;
            }
        }
        Console.WriteLine($"В круг попадет {c} точек");
        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

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
        bool stop = false;
        double a = 0, r;

        for (int i = 1; ; i++)
        {
            Console.WriteLine("Введите результаты участников");
            stop = !double.TryParse(Console.ReadLine(), out r);
            if (stop)
            {
                break;
            }
            if (r <= norm)
            {
                a++;
            }
        }
        Console.WriteLine(a);
        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

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
        bool stop = false;
        double x, y;

        for (int i = 1; ; i++)
        {
            Console.WriteLine("Введите x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("Введите y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop)
            {
                break;
            }

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"Ближайшая точка = {answer}, величина расстояния = {answerLength:F2}");
        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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
        bool stop = false;
        double p1 = 0, p2 = 0, p3 = 0, p4 = 0;
        double s = 0, k = 0;

        for (int i = 1; ; i++)
        {
            Console.WriteLine("Введите");
            stop = !double.TryParse(Console.ReadLine(), out p1);
            stop = !double.TryParse(Console.ReadLine(), out p2);
            stop = !double.TryParse(Console.ReadLine(), out p3);
            stop = !double.TryParse(Console.ReadLine(), out p4);
            if (stop)
            {
                break;
            }
            if (p1 == 2 || p2 == 2 || p3 == 2 || p4 == 2)
            {
                answer++;
            }
            s += p1 + p2 + p3 + p4;
            k += 4;
        }
        avg = s / k;
        Console.WriteLine($"Неуспевающие студенты = {answer},  средний балл группы = {avg}");
        // end

        return (answer, avg);
    }
    #endregion
}