using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

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
        //program.Task_2_8(10);
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
        int r = 2;
        double p = 0.0001;
        if ( Math.Abs((x * x) + (y * y) - (r*r))<= p)
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
        if ( y>=0 && y + Math.Abs(x) <= 1)
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
        double c;
        if (a>0)
        {
            if (a > b)
                c = a;
            else
                c = b;
        }
        else
        {
            c = Math.Min(a, b);
        }
        Console.WriteLine(c);
        // end

        return answer= c;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z;
        z = Math.Max(Math.Min(a, b), c);
        // end

        return answer=z;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double rd, q, sd;
        rd = Math.Sqrt(r / Math.PI) * 2;
        q = Math.Sqrt(s) * Math.Sqrt(2);
        sd = Math.Sqrt(s);
        if (sd <= r)
            answer = true;
        if (q >= rd)
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double rd, sd;
        rd = Math.Sqrt(r / Math.PI) * 2;
        sd = Math.Sqrt(s);
        if (rd <= sd)
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
        double y;
        if (Math.Abs(x) > 1)
            answer = 1;
        if (Math.Abs(x) <= 1)
            answer = Math.Abs(x);
        // end

        return answer ;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        if (Math.Abs(x) < 1)
            answer = x*x-1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (x > -1 && x <= 0)
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
        if (x <= 1)
            answer = 1;
        if (x > -1 && x <= 1)
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
        double h, s = 0;
        for (int i=1; i<= n; i++)
        {
            double.TryParse(Console.ReadLine(), out h);
            s += h;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i=1; i<=n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) 
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        int w;
        for (int i=1;i<=n;i++)
        {
            int.TryParse(Console.ReadLine(), out w);
            answer += 0.2;
            if (w < 30) answer += 0.2;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x * x + y * y) < r2 * r2)
            {
                if ((x * x) + (y * y) > r1 * r1)
                    answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int answer = 0;

        // code here
        if (n == 0 || norm == 0)
            return 0;

        for (int i = 1; i <= n; i++)
        {
            double result;
            result = double.Parse(Console.ReadLine());
            if (result <= norm)
                answer++;
        }
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
        for ( int i=0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x>= 0 && Math.PI >= x && Math.Sin(x) > y)
                answer++;
        }
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
        for (int i=0; i<n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"1 четверть");
                answer1++;
            }
            if (x < 0 && y > 0)
                Console.WriteLine($"2 четверть");
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"3 четверть");
                answer3++;
            }
            if (x > 0 && y < 0)
                Console.WriteLine($"4 четверть");
        }
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
        double x, y, r, r_min = 10;
        for (int i=0; i<5; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            r =Math.Round( Math.Sqrt(x * x + y * y), 2);
            //Console.WriteLine($"{r_min}");
            if (r < r_min)
            {
                //Console.WriteLine($"{ i+1}");
                answer = i + 1;
                answerLength =r;
                r_min=r;
                //Console.WriteLine($"{answerLength}");
            }
            else if (r> r_min)
            {
                //Console.WriteLine($"{i + 1}");
                answer = i + 1;
            }
        }
        Console.WriteLine($"{answer}");
        Console.WriteLine($"{answerLength}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res,p=40;
        for (int i=0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res<= p)
            {
                p = res;
                answer = res;
            }
            answer = p;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int mark;
        for (int i=0; i<n; i++)
        {
            bool fl = true;
            for (int j=0; j<4;j++)
            {
                int.TryParse(Console.ReadLine(), out mark);
                if (mark == 2 || mark == 3)
                {
                    fl = false;
                }
            }
            if (fl == true)
                answer++;
        }
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
        int mark;
        double s=0;
        for (int i = 0; i < n; i++)
        {
            bool fl = true;
            for (int j = 0; j < 4; j++)
            {
                int.TryParse(Console.ReadLine(), out mark);
                s += mark;
                if (mark == 2 )
                {
                    fl = false;
                }
            }
            s /= 4;
            avg += s;
            s = 0;
            //Console.WriteLine(avg);
            if (fl == false)
            {
                answer++;
            }
 
        }
        avg = avg / n;
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
        int n = 3;
        if (r <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * (r * r);
                break;
            case 2:
                answer = (r * r) * Math.Sqrt(3) / 4;
                break;

            default:
                Console.WriteLine("Неверный ответ");
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here
        if (A <= 0 || B <= 0)
            return 0;
        
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                break;
            case 2:
                answer = (A * Math.Sqrt((4 * B * B) - A * A)) / 4;
                break;
            default:
                Console.WriteLine("Неверный ответ");
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        //double x, y;
        while (true)
        {
            string ? s = Console.ReadLine();
            if (s == "stop") break;
            else
            {
                string ? s2 = Console.ReadLine(); 
                double.TryParse(s, out double x);
                double.TryParse(s2, out double y);
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    answer++;
                    Console.WriteLine(answer);
                }
            }
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

        // code here
        if (norm == 0)
            return 0;

        while (true)
        {
            string? s = Console.ReadLine();
            if (s == "stop") break;
            else
            {
                double.TryParse(s, out double result);
                if (result <= norm)
                    answer++;
                //Console.WriteLine(answer);
            }
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
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double r, r_min = 10;
        while (true)
        {
            string? s = Console.ReadLine();
            if (s == "stop") break;
            else
            {
                string? s2 = Console.ReadLine();
                double.TryParse(s, out double x);
                double.TryParse(s2, out double y);
                r = Math.Round(Math.Sqrt(x * x + y * y), 2);
                if (r < r_min)
                {
                    answer++;
                    answerLength = r;
                    r_min = r;
                }
                else if (r > r_min)
                {
                    answer++;
                }
            }
            
        }
        Console.WriteLine($"{answer}");
        Console.WriteLine($"{answerLength}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
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

        // code here;
        double ch = 0, k=0;
        while (true)
        {
            Console.WriteLine($"Введите 'start', чтобы добавить оценки студенту или 'stop', чтобы получить результат");
            string comand = Console.ReadLine();
            if (comand == "stop")
            {
                break;
            }
            else if (comand == "start")
            {
                bool a = false;
                int cnt = 0;
                for (int j = 0; j < 4; j++)
                {
                    string? s = Console.ReadLine();
                    int.TryParse(s, out int mark);
                    ch += mark;
                    cnt++;
                    if (mark < 3)
                    {
                        a = true;
                    }
                }
                if (a == true)
                {
                    answer++;
                }
                avg+=ch / cnt;
                k++;
                ch = 0;
                Console.WriteLine(avg);
            }
            else
            {
                Console.WriteLine("Неверная команда");
            }
        }
        avg = Math.Round(avg/k, 2);
        System.Console.WriteLine($"Студентов не успевают :{answer} и средний балл группы :{avg}");
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
