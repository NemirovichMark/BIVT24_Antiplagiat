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
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
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
        double r = 2;
        
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
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
            if (a > b)
            {
                c = a;
            }
            else if (a < b)
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
            else if (a > b)
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
        double z = 0, minab = 0;
        if (a < b)
        {
            minab = a;
        }
        else
        {
            minab = b;
        }
        if (minab > c)
        {
            z = minab;
        }
        else
        {
            z = c;
        }
        answer = z;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double dkr = 0, dkv = 0;
        dkv = Math.Sqrt(2 * s);
        dkr = Math.Sqrt(4 * r / Math.PI);
        if (dkr >= dkv)
        {
            answer = true;
        }

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double dkr = 0, a = 0;
        a = Math.Sqrt(s);
        dkr = Math.Sqrt(4 * r / Math.PI);
        if (dkr <= a)
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
        double y = 0;
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else if (Math.Abs(x) <= 1)
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
        else if (Math.Abs(x) < 1)
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
        else if (-1 < x & x <= 0)
        {
            y = 1 + x;
        }
        else if (x > 0)
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
        else if (-1 < x & x <= 1)
        {
            y = -x;
        }
        else if (x > 1)
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
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //double height = 0, allheight = 0, srdn = 0;
        
        //while(i <= n)
        //{
        //    double.TryParse(Console.ReadLine(), out height);
        //    allheight += height;
        //    i++;
        //}  
        //if (n > 0)
        //{
        //    srdn = allheight/n;
        //}
        //answer = srdn;
        //Console.WriteLine(srdn);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        
        //int.TryParse(Console.ReadLine(), out n);
        //double.TryParse(Console.ReadLine(), out r);
        //double.TryParse(Console.ReadLine(), out a);
        //double.TryParse(Console.ReadLine(), out b);
        //double x = 0, y = 0;
        //int i = 1, k = 0;
        //while (i <= n)
        //{
        //    double.TryParse(Console.ReadLine(), out x);
        //    double.TryParse(Console.ReadLine(), out y);
        //    if ((Math.Pow(a - x, 2) + Math.Pow(b - y, 2)) < r * r)
        //    {
        //        k += 1;
        //    }
        //    i++;
        //}
        //answer = k;
        //Console.WriteLine(k);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //double weight = 0, l = 0;
        //while (i <= n)
        //{
        //    double.TryParse(Console.ReadLine(), out weight);
        //    if (weight < 30)
        //    {
        //        l += 0.2;
        //    }
        //    i++;
        //}
        //answer = l;
        //Console.WriteLine(l);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1, k = 0;
        //double x = 0, y = 0;
        //double.TryParse(Console.ReadLine(), out r1);
        //double.TryParse(Console.ReadLine(), out r2);
        //while (i <= n)
        //{
        //    double.TryParse(Console.ReadLine(), out x);
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (Math.Pow(x, 2) + Math.Pow(y, 2) > r1 * r1 && Math.Pow(x, 2) + Math.Pow(y, 2) < r2 * r2)
        //    {
        //        k++;
        //    }
        //    i++;
        //}
        //answer = k;
        //Console.WriteLine(k);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1, k = 0;
        //double point =  0;
        //double.TryParse(Console.ReadLine(), out norm);
        //while (i <= n)
        //{
        //    double.TryParse(Console.ReadLine(), out point);
        //    if (point >= norm)
        //    {
        //        k++;
        //    }
        //    i++;
        //}
        //answer = k;
        //Console.WriteLine(k);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //while (i <= n)
        //{
        //    double x = 0, y = 0;
        //    double.TryParse(Console.ReadLine(), out x);
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x > 0 && x < Math.PI && y > 0 && y < Math.Sin(x))
        //    {
        //        answer++;
        //    }
        //    i++;
        //}
        //Console.WriteLine();
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1, k1 = 0, k3 = 0;
        //while (i <= n)
        //{
        //    double x=0, y=0;
        //    double.TryParse(Console.ReadLine(), out x);
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x > 0 && y > 0)
        //    {
        //        Console.WriteLine("1й квадрант");
        //        k1++;
        //    }
        //    else if (x < 0 && y > 0)
        //    {
        //        Console.WriteLine("2й квадрант");
        //    }
        //    else if (x < 0 && y < 0)
        //    {
        //        Console.WriteLine("3й квадрант");
        //        k3++;
        //    }
        //    else if (x > 0 && y < 0)
        //    {
        //        Console.WriteLine("4й квадрант");
        //    }
        //    i++;

        //}
        //answer1 = k1;
        //answer3 = k3;
        //Console.WriteLine(k1);
        //Console.WriteLine(k3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1, a = 0, b = 0, number = 0;
        //double d = 0;
        //while (i <= n)
        //{
        //    double x = 0, y = 0;
        //    double.TryParse(Console.ReadLine(), out x);
        //    double.TryParse(Console.ReadLine(), out y);
        //    d = Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));
        //    if (d < answerLength)
        //    {
        //        answerLength = d;
        //        number = i;
        //    }
        //    i++;
        //}
        //answerLength = Math.Round(answerLength, 2);
        //answer = number;
        //answerLength = answerLength;
        //Console.WriteLine(number);
        //Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //while (i <= n)
        //{
        //    double point = 0;
        //    double.TryParse(Console.ReadLine(), out point);
        //    if (point < answer)
        //    {
        //        answer = point;
        //    }
        //    i++;
        //}
        //Console.WriteLine();
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //while (i <= n)
        //{
        //    int mark = 0, bad = 0;
        //    Console.WriteLine("Введите 4 оценки:");
        //    for (int k = 1; k <= 4; k++)
        //    {
        //        int.TryParse(Console.ReadLine(), out mark);
        //        if (mark < 4)
        //        {
        //            bad++;
        //        }
        //    }
        //    if (bad == 0)
        //    {
        //        answer++;
        //    }
        //    i++;
        //}
        //Console.WriteLine();
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        //int.TryParse(Console.ReadLine(), out n);
        //int i = 1;
        //while (i <= n)
        //{
        //    int mark = 0, bad = 0;
        //    Console.WriteLine("Введите 4 оценки:");
        //    for (int k = 1; k <= 4; k++)
        //    {
        //        int.TryParse(Console.ReadLine(), out mark);
        //        avg += mark;
        //        if (mark <= 2)
        //        {
        //            bad++;
        //        }
        //    }
        //    if (bad > 0)
        //    {
        //        answer++;
        //    }
        //    i++;
        //}
        //avg = avg / (n * 4);
        //avg = Math.Round(avg, 9);
        //Console.WriteLine();
        //Console.WriteLine(answer);
        //Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        int n = 3, i = 0;
        //int.TryParse(Console.ReadLine(), out n);
        while (i < n)
        {
            //double.TryParse(Console.ReadLine(), out r);
            i++;
            if (r > 0)
            {
                switch (type)
                {
                    case 0:
                        answer = Math.Round(r * r, 2);
                        Console.WriteLine("Площадь квадрата: ", answer);
                        break;
                    case 1:
                        answer = Math.Round(Math.PI * r * r, 2);
                        Console.WriteLine("Площадь круга: ", answer);
                        break;
                    case 2:
                        answer = Math.Round((r * r * Math.Sqrt(3)) / 4, 2);
                        Console.WriteLine("Площадь равностороннего треугольника: ", answer);
                        break;
                    default:
                        answer = 0;
                        Console.WriteLine("Неверно, выберите 0,1,2:");
                        break;
                }
            }
        }
                    // end

                    return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        int n = 3, i = 0;
        //int.TryParse(Console.ReadLine(), out n);
        while (i < n)
        {
            i++;
            //double.TryParse(Console.ReadLine(), out A);
            //double.TryParse(Console.ReadLine(), out B);
            if (A > 0 && B > 0)
            {

                switch (type)
                {
                    case 0:
                        answer = Math.Round(A * B, 2);
                        Console.WriteLine("Площадь прямоугольника: ", answer);
                        break;
                    case 1:
                        answer = Math.Round(Math.Abs(Math.PI * A * A - Math.PI * B * B), 2);
                        Console.WriteLine("Площадь кольца: ", answer);
                        break;
                    case 2:
                        answer = Math.Round(A / 2 * Math.Sqrt(B * B - A * A / 4),2);
                        Console.WriteLine("Площадь равнобедренного треугольника: ", answer);
                        break;
                    default:
                        answer = 0;
                        Console.WriteLine("Выберите 0,1,2:");
                        break;
                }
            }
        }
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

        //double height = 1, allheight = 0, srdn = 0;
        //Console.WriteLine("Для завершения программы введите рост 0");
        //while (height > 0)
        //{
        //    Console.WriteLine("Введите рост:");
        //    double.TryParse(Console.ReadLine(), out height);
        //    if (height > 0)
        //    {

        //        allheight += height;

        //        n++;
        //    }
        //}
        //srdn = allheight / n;

        //answer = srdn;
        //Console.WriteLine(srdn);

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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        //Console.WriteLine("Введите x равный 123456789 для остановки программы");
        //int i = 0;
        //double x = 0, y = 0;
        //Console.WriteLine("Введите 2 радиуса: ");
        //double.TryParse(Console.ReadLine(), out r1);
        //double.TryParse(Console.ReadLine(), out r2);
        //for (; ; i++)
        //{
        //    Console.WriteLine("Введите координаты точки(или стоп число): ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    if (x == 123456789) break;

        //    double.TryParse(Console.ReadLine(), out y);
        //    if (Math.Pow(x, 2) + Math.Pow(y, 2) > r1 * r1 && Math.Pow(x, 2) + Math.Pow(y, 2) < r2 * r2)
        //    {
        //        n++;
        //    }
        //}
        //answer = n;
        //Console.WriteLine();
        //Console.WriteLine(n);

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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        //Console.WriteLine("Введите стоп число 123456789 для остановки программы");
        //int i = 0, k1 = 0, k3 = 0;
        //for (; ; i++)
        //{
        //    double x = 0, y = 0;
        //    Console.WriteLine("Введите координаты(или стоп число):");
        //    double.TryParse(Console.ReadLine(), out x);
        //    if (x == 123456789) break;
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x > 0 && y > 0)
        //    {
        //        Console.WriteLine("1й квадрант");
        //        k1++;
        //    }
        //    else if (x < 0 && y > 0)
        //    {
        //        Console.WriteLine("2й квадрант");
        //    }
        //    else if (x < 0 && y < 0)
        //    {
        //        Console.WriteLine("3й квадрант");
        //        k3++;
        //    }
        //    else if (x > 0 && y < 0)
        //    {
        //        Console.WriteLine("4й квадрант");
        //    }

        //}
        //answer1 = k1;
        //answer3 = k3;
        //Console.WriteLine();
        //Console.WriteLine(k1);
        //Console.WriteLine(k3);

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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        //Console.WriteLine("Введите стоп число 10 для остановки программы");
        //int i = 0;
        //for (; ; i++)
        //{
        //    int mark = 0, bad = 0, stop = 0;
        //    Console.WriteLine("Введите 4 оценки(или один раз стоп число):");
        //    for (int k = 1; k <= 4; k++)
        //    {
        //        int.TryParse(Console.ReadLine(), out mark);
        //        if (mark == 10)
        //        {
        //            stop++;
        //            break;
        //        }
        //        else if (mark < 4)
        //        {
        //            bad++;
        //        }
        //    }
        //    if (stop > 0) break;
        //    else if (bad == 0)
        //    {
        //        answer++;
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine(answer);

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