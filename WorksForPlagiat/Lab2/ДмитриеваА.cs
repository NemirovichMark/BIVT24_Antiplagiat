using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        program.Task_3_1();
        program.Task_3_2(3, 2, 1);
        program.Task_3_2(1.5, 1.5, 1);
        program.Task_3_2(1, 3, 1);
        program.Task_3_3();
        program.Task_3_4(1, 2);
        program.Task_3_5(30);
        program.Task_3_6();
        program.Task_3_7();
        program.Task_3_8();
        program.Task_3_9();
        program.Task_3_10();
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here

        int r = 2;
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

        if (y >= 0 && y + Math.Abs(x) <= 1)
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

        if (a > 0)
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        else
        {
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        double min = 0;
        if (a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }
        if (c < min)
        {
            answer = min;
        }
        else
        {
            answer = c;
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        double a = Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);
        if (Math.Sqrt(a * a * 2) <= 2 * radius)
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

        double a = Math.Sqrt(s);
        double diametr = 2 * Math.Sqrt(r / Math.PI);
        if (a >= diametr)
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

        if (Math.Abs(x) >= 1)
        {
            answer = 1;
        }
        else
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

        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1)
        {
            answer = 0;
        }
        else if (0 >= x && x > -1)
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
        else if (1 >= x && x > -1)
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

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //int height = 0;
        //double sr = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    int.TryParse(Console.ReadLine(), out height);
        //    sr += height;
        //    Console.WriteLine();
        //}
        //answer = sr / n;
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //Console.Write("a = ");
        //double.TryParse(Console.ReadLine(), out a);
        //Console.Write("b = ");
        //double.TryParse(Console.ReadLine(), out b);
        //Console.Write("r = ");
        //double.TryParse(Console.ReadLine(), out r);
        //for (int i = 0; i < n; i++)
        //{
        //    double x = 0, y = 0;
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) < r * r)
        //    {
        //        answer++;
        //    }
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //for (int i = 0; i < n; i++)
        //{
        //    double kg = 0;
        //    Console.Write("kg = ");
        //    double.TryParse(Console.ReadLine(), out kg);
        //    if (kg < 30)
        //    {
        //        answer += 0.2;
        //    }
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //Console.Write("r1 = ");
        //double.TryParse(Console.ReadLine(), out r1);
        //Console.Write("r2 = ");
        //double.TryParse(Console.ReadLine(), out r2);
        //for (int i = 0; i < n; i++)
        //{
        //    double x = 0, y = 0;
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x * x + y * y < r2 * r2 && x * x + y * y > r1 * r1)
        //    {
        //        answer++;
        //    }
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //Console.Write("norm = ");
        //double.TryParse(Console.ReadLine(), out norm);
        //for (int i = 0; i < n; i++)
        //{
        //    double res = 0;
        //    Console.Write("res = ");
        //    double.TryParse(Console.ReadLine(), out res);
        //    if (res <= norm)
        //    {
        //        answer++;
        //    }

        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //for (int i = 0; i < n; i++)
        //{
        //    double x = 0, y = 0;
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x >= 0 && y >= 0 && x <= Math.PI && y <= Math.Sin(x))
        //    {
        //        answer += 1;
        //    }
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //for (int i = 0; i < n; i++)
        //{
        //    double x = 0, y = 0;
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (y > 0 && x > 0)
        //    {
        //        Console.WriteLine("1 квадрант"); 
        //        answer1++;
        //    }
        //    else if (y > 0 && x < 0) Console.WriteLine("2 квадрант");
        //    else if (y < 0 && x < 0)
        //    {
        //        Console.WriteLine("3 квадрант"); 
        //        answer3++;
        //    }
        //    else if (y < 0 && x > 0) 
        //        Console.WriteLine("4 квадрант");
        //}
        //Console.WriteLine("в 1 квадранте: " + answer1);
        //Console.WriteLine("в 3 квадранте: " + answer3);

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //double x = 10000000000000, y = 1000000000000000, s = 1000000000000000000;
        //for (int i = 0; i < n; i++)
        //{
        //    double x1 = 0, y1 = 0;
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x1);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y1);
        //    if (Math.Abs(x1*x1+y1*y1) <= s) y = y1; x = x1; answer = n;
        //}
        //answerLength = Math.Sqrt(x * x + y * y);
        //Console.WriteLine(answer + " " + Math.Round(answerLength, 2));

        // end

        return (answer, answerLength);

    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //double res = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("res = ");
        //    double.TryParse(Console.ReadLine(), out res);
        //    if (res < answer) answer = res;
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //for (int i = 0; i < n; i++)
        //{
        //    int res1 = 0, res2 = 0, res3 = 0, res4 = 0;
        //    Console.Write("res1 = ");
        //    int.TryParse(Console.ReadLine(), out res1);
        //    Console.Write("res2 = ");
        //    int.TryParse(Console.ReadLine(), out res2);
        //    Console.Write("res3 = ");
        //    int.TryParse(Console.ReadLine(), out res3);
        //    Console.Write("res4 = ");
        //    int.TryParse(Console.ReadLine(), out res4);
        //    if (res1 > 3 && res2 > 3 && res3 > 3 && res4 > 3) answer++;
        //}
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        //Console.Write("n = ");
        //int.TryParse(Console.ReadLine(), out n);
        //for (int i = 0; i < n; i++)
        //{
        //    int res1 = 0, res2 = 0, res3 = 0, res4 = 0;
        //    Console.Write("res1 = ");
        //    int.TryParse(Console.ReadLine(), out res1);
        //    Console.Write("res2 = ");
        //    int.TryParse(Console.ReadLine(), out res2);
        //    Console.Write("res3 = ");
        //    int.TryParse(Console.ReadLine(), out res3);
        //    Console.Write("res4 = ");
        //    int.TryParse(Console.ReadLine(), out res4);
        //    int res = res1 + res2 + res3 + res4;
        //    if (res1 <= 2 || res2 <= 2 || res3 <= 2 || res4 <= 2) answer++;
        //    avg += res;
        //}
        //avg /= n*4;
        //Console.WriteLine(answer + " " + avg);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        int n = 1;
        for (int i = 0; i < n; i++)
        {
            if (r > 0)
            {
                switch (type)
                {
                    case 0:
                        answer = Math.Round(r * r, 2);
                        break;
                    case 1:
                        answer = Math.Round(Math.PI * r * r, 2);
                        break;
                    case 2:
                        answer = Math.Round((Math.Sqrt(3) / 4) * r * r, 2);
                        break;
                    default:
                        answer = 0;
                        break;
                }
            }
        }
        Console.WriteLine(answer);

        // end
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        int n = 1;
        for (int i = 0; i < n; i++)
        {
            if (A > 0 && B > 0)
            {
                switch (type)
                {
                    case 0:
                        answer = Math.Round(A * B, 2);
                        break;
                    case 1:
                        answer = Math.Round(Math.Abs(Math.PI * A * A - Math.PI * B * B), 2);
                        break;
                    case 2:
                        answer = Math.Round((A / 4) * (Math.Sqrt(4 * B * B - A * A)), 2);
                        break;
                    default:
                        answer = 0;
                        break;
                }
            }
            Console.WriteLine(answer);
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

        //Console.WriteLine("10000+ - дл€ окончани€ программы");
        //double kg = 0;
        //while (kg < 10000)
        //{
        //    Console.Write("kg = ");
        //    double.TryParse(Console.ReadLine(), out kg);
        //    if (kg < 30)
        //    {
        //        answer += 0.2;
        //    }
        //}
        //Console.WriteLine(answer);

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

        //Console.WriteLine("x >= 10000 or y >= 10000 - дл€ окончани€ программы");
        //double x = 0, y = 0;
        //while (x < 10000 && y < 10000)
        //{
        //    Console.Write("x = ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("y = ");
        //    double.TryParse(Console.ReadLine(), out y);
        //    if (x >= 0 && y >= 0 && x <= Math.PI && y <= Math.Sin(x))
        //    {
        //        answer += 1;
        //    }
        //}
        //Console.WriteLine(answer);

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

        //Console.WriteLine("10000+ - дл€ окончани€ программы");
        //double res = 0;
        //while (res < 10000)
        //{
        //    Console.Write("res = ");
        //    double.TryParse(Console.ReadLine(), out res);
        //    if (res < answer) answer = res;
        //}
        //Console.WriteLine(answer);

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
    