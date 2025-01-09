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
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(-0.75, 0);
        //program.Task_2_13(1.5, 3, 2);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        program.Task_3_6();
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
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x) <= 1))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a < b)
                answer = a;
            else
                answer = b;
        }
       
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double z;
        // code here
        if (a < b) // сравниваем с а
        {
            if (a > c)
                answer = a;
            else
                answer = c;
        }
        else // сравниваем с b
        {
            if (b > c)
                answer = b;
            else
                answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = 0, A = 0, D = 0;// радиус круга, сторона квадрата, диагональ квадрата
        R = Math.Sqrt(r / Math.PI);
        A = Math.Sqrt(s);
        D = A * Math.Sqrt(2);
        if (D / 2 <= R)
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = 0, A = 0, D = 0;// радиус круга, сторона квадрата, диаметр круга
        R = Math.Sqrt(r / Math.PI);
        A = Math.Sqrt(s);
        D = R * 2;
        if (D <= A)
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (-1 < x && x <= 0)
            answer = 1 + x;
        if (x > 0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (-1 < x && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        // end
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        int i = 1;
        double s = 0, sr = 0, r = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out r);
            s += r;
            i++;
        }
        sr = s / n;
        answer = sr;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y, s;
        int i = 1, k = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            i++;
            s = Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));//расстояние от точки до центра
            if (s <= r)
                k++;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double h;
        int i = 1, s = 0;
        // end
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out h);
            i++;
            if (h < 30)
                s += 200;
        }
        answer = (double)s / 1000;
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y, s;
        int i = 1, k = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            i++;
            s = Math.Sqrt(x * x + y * y);//расстояние от точки до центра окружностей (0,0)
            if (s >= r1 && s <= r2)
                k++;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double res;
        int i = 1, k = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out res);
            i++;
            if (res <= norm)
                k++;
        }
        answer = k;
        Console.WriteLine(answer);
        
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        int i = 1, k = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            i++;
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
                k++;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        int i = 1, k1 = 0, k3 = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                //Console.WriteLine($"{i} точка находится в I квадранте");
                k1++;
            }
            /*if (x < 0 && y > 0)
                Console.WriteLine($"{i} точка находится в II квадранте");*/
            if (x < 0 && y < 0)
            {
                //Console.WriteLine($"{i} точка находится в III квадранте");
                k3++;
            }
            /*if (x > 0 && y < 0)
                //Console.WriteLine($"{i} точка находится в IV квадранте");*/
            i++;
        }
        answer1 = k1;
        answer3 = k3;
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double mini = 10000000000, x, y, s;
        int i = 1, k = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            s = Math.Sqrt(x * x + y * y); //расстояние от точки до начала координат
            if (s < mini)
            {
                mini = s;
                k = i;
            }
            i++;
        }
        answer = k;
        answerLength = Math.Round(mini, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double mini = 10000000, res;
        int i = 1;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out res);
            i++;
            if (res < mini)
                mini = res;
        }
        answer = mini;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        // code here;
        int i = 1, count = 0;
        double mark1, mark2, mark3, mark4;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            if ((mark1>=4) && (mark2 >= 4) && (mark3 >= 4) && (mark4 >= 4))
                count++;
            i++;
        }
        answer = count;
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int i = 1, count = 0;
        double mark1, mark2, mark3, mark4, suma = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            if ((mark1 == 2) || (mark2 == 2) || (mark3 == 2) || (mark4 == 2))
                count++;
            suma += mark1 + mark2 + mark3 + mark4;
            i++;
        }
        avg = suma / (n * 4);
        answer = count;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
            answer = 0;
        else
        {
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
                default:
                    answer = 0;
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double s1, s2;
        if (A <= 0 || B <= 0)
            answer = 0;
        else
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    s1 = Math.PI * A * A;
                    s2 = Math.PI * B * B;
                    answer = Math.Abs(s1 - s2);
                    break;
                case 2:
                    answer = 0.5 * A * Math.Sqrt(B * B - (A / 2) * (A / 2));
                    break;
                default:
                    answer = 0;
                    break;
            }
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0, h;
        int n = 0, s = 0;
        // code here
        Console.WriteLine("Для окончания ввода введите: h <= 0");
        for (; ; n++)
        {
            double.TryParse(Console.ReadLine(), out h);
            if (h <= 0) break;
            if (h < 30)
                s += 200;
        }
        answer = (double)s / 1000;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        // code here
        double x = 0, y = 0;
        Console.WriteLine("Для окончания программы введите х = -1");
        while (x != -1)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
                answer++;
        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        // code here
        double mini = 10000000, res;
        int n = 0;
        Console.WriteLine("Для окончания ввода введите res <= 0");
        for (; ; n++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res <= 0) break;
            if (res < mini)
                mini = res;
        }
        answer = mini;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
