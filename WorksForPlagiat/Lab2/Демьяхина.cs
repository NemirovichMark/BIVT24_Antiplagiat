using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        program.Task_2_6(5);
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
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
        answer = (a > 0) ? Math.Max(a, b) : Math.Min(a, b);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2*Math.Sqrt(r / double.Pi);
        double d1= Math.Sqrt(s+s);
        if (d1 <= d) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / double.Pi);
        double d1 = Math.Sqrt(s);
        if (d<=d1) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) > 1) ? 1 : Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) >= 1) ? 0 : x*x-1 ;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else
        {
            if (x > -1 && x <= 0) answer = 1 + x;
            else answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else
        {
            if (x > -1 && x <= 1) answer = -x;
            else answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double s = 0;
        double x;
        
        for (int i=1; i<=n; i++)
        {
            x = int.Parse(Console.ReadLine());
            s += x;
        }
        
        answer = s / n;
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r) answer++;

        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        int k = 0;
        double x;
        // code here
        for ( int i = 1; i<=n; i++)
        {
            Console.WriteLine("Введите вес ученика");
            x= double.Parse(Console.ReadLine());
            if (x<30)
            {
                k++;
            }
        }
        // end
        answer = k * 0.2;
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i<=n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (x*x+y*y<=r2*r2 && x*x+y*y>=r1*r1) answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double x;
        // code here
        for (int i = 1; i<=n;i++)
        {
            x= double.Parse(Console.ReadLine());
            if (x<=norm) answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i<=n;i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= double.Pi && y <= Math.Sin(x) && y >= 0) answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

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
                Console.WriteLine("Первая четверть");
                answer1++;
            }
            if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Третья четверть");
                answer3++;
            }
            if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
            return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 1;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        double d = 0;
        double m = 0;
        Console.WriteLine("Введите x");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите y");
        y = double.Parse(Console.ReadLine());
        d = Math.Sqrt(x * x + y * y);
        for (int i = 2; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            m = Math.Sqrt(x * x + y * y);
            if (m<d)
            {
                answer = i;
                d = m;
            }
            
        }
        answerLength = d;
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5 

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double y;
        
        for (int i=1; i<=n; i++)
        {
            y=double.Parse(Console.ReadLine());
            if (y<answer) answer=y;

        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int x1,x2,x3,x4;
        for (int i=0; i<n; i++)
        {
            Console.WriteLine("Введите оценки студента");
            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out x3);
            int.TryParse(Console.ReadLine(), out x4);
            if (x1>3 && x2>3 && x3>3 && x4>3)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int s = 0;
        int x1, x2, x3, x4;
        // code here;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите оценки студента");
            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out x3);
            int.TryParse(Console.ReadLine(), out x4);
            if (x1 < 3 || x2 < 3 || x3 < 3 || x4 < 3) answer++;
            s += x1 + x2 + x3 + x4;
        }
        // end
        avg = s / (n * 4.0);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        Console.WriteLine(answer);
        Console.WriteLine(avg);
       
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r; break;
                case 1:
                    answer = r * r * double.Pi; break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4; break;
                default: answer = 0; break;

            }
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A>0 && B>0)
        {
            switch (type)
            {
                case 0:
                    //Console.WriteLine("Площадь прямоугольника = ");
                    answer= A * B; break;
                    
                case 1:
                    //Console.WriteLine("Площадь кольца = ");
                    answer =Math.Abs(double.Pi*A*A-double.Pi*B*B); break;
                case 2:
                    //Console.WriteLine("Площадь равнобедренного треугольника = ");
                    answer = A / 2 * Math.Sqrt(B * B - A * A / 4); break;
            }
           
        }
        // end

        return Math.Round(answer,2);
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
        string t;
        double x, y;
        for (; ;)
        { 
        Console.WriteLine("Введите x или stop, если хотите завершить");
        t = Console.ReadLine();
        if (double.TryParse(t, out x))
        {
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r) answer++;
        }
        else break;

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

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
        double x;
        string t;
        // code here
        for (; ; )
        {
            Console.WriteLine("Введите результат спортсмена или stop, если хотите завершить");
            t = Console.ReadLine();
            if (double.TryParse(t, out x))
            {
                if (x <= norm) answer++;
            }
            else break;

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

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
        int answer = 1, n = 0;
        double answerLength = double.MaxValue;
        double x, y, d;
        string t;
        // code here
        for (int i=1; ;i++ )
        {
            Console.WriteLine("Введите x или stop, если хотите завершить");
            t = Console.ReadLine();
            if (double.TryParse(t, out x))
            {
                Console.WriteLine("Введите y");
                y = double.Parse(Console.ReadLine());
                d = Math.Sqrt(x * x + y * y);
                if (d < answerLength)
                {
                    answerLength = d;
                    answer = i;
                }
            }
            else break;

        }

        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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
        int s = 0;
        int x1, x2, x3, x4;
        string t;
        // code here
        for (int i=1; ;i++)
        {
            Console.WriteLine("Введите оценки студента или stop, если хотите завершить");
            t = Console.ReadLine();
            if (int.TryParse(t, out x1))
            {
                int.TryParse(Console.ReadLine(), out x2);
                int.TryParse(Console.ReadLine(), out x3);
                int.TryParse(Console.ReadLine(), out x4);
                if (x1 < 3 || x2 < 3 || x3 < 3 || x4 < 3) answer++;
                s += x1 + x2 + x3 + x4;
                n++;
            }
            else break;

        }
        // end
        avg = s / (n * 4.0);
        // end
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
