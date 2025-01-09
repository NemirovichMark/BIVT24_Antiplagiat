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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a >= b)
                answer = a;
            if (b > a)
                answer = b;
        }
        if (a <= 0)
        {
            if (a <= b)
                answer = a;
            if (b <= a)
                answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double d = 0;
        if (a <= b)
            d = a;
        else
            d = b;
        if (d >= c)
            answer = d;
        else
            answer = c;


        // end
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double pi = Math.Round(Math.PI, 5);
        double storona = Math.Sqrt(s);
        double diametr = 2 * Math.Sqrt(r / pi);
        double diagonal = Math.Sqrt(2) * storona;
        if (diametr >= diagonal)
            answer = true;
        Console.WriteLine($"{diagonal} {s} {r} {diametr}");
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double pi = Math.Round(Math.PI, 5);
        double storona = Math.Sqrt(s);
        double diametr = 2 * Math.Sqrt(r / pi);
        if (diametr <= storona)
            answer = true;
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
        if (x > 0)
            answer = 1;
        if (x > -1 && x <= 0)
            answer = 1 + x;
        Console.WriteLine($"{x} {answer}");
        // end
        //answer = Math.Round(answer);
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        if (x > -1 && x <= 1) answer = -x;
        if (x > 1) answer = -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        double a = 0, s = 0;
        for (int i = 1; i <= n; i++)
        {
            a = double.Parse(Console.ReadLine());
            s += a;
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
        double x = 0, y = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i<= n;i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r);
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
        double a = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i<= n;i++)
        {
            a = double.Parse((Console.ReadLine()));
            if (a <= 30)
                answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0, y = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if(Math.Sqrt(x*x+y*y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
                answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double a = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i<= n;i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a <= norm)
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
        double x = 0, y = 0, pi = Math.PI;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i<=n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y >= 0 && y <= 1 && x >= 0 && x <= pi)
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
        n = int.Parse(Console.ReadLine());
        double x = 0, y = 0;
        for (int i = 1;i<=n;i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 && y >0)
                answer1++;
            if(x<0 && y<0)
                answer3++;

        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        n = int.Parse(Console.ReadLine());
        double x = 0, y = 0, b = 0;
        for (int i = 1;i<=n;i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            b = Math.Sqrt(x * x + y * y);
            if(b <= answerLength)
            {
                answerLength = b;
                answer = i;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double t = 0;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            t = double.Parse(Console.ReadLine());  
            if(t<=answer)
                answer = t;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int r1 = 0, r2 = 0, r3 = 0, r4 = 0;
        // code here;
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            r1 = int.Parse(Console.ReadLine());
            r2 = int.Parse(Console.ReadLine());
            r3 = int.Parse(Console.ReadLine());
            r4 = int.Parse(Console.ReadLine());
            if (r1 >= 4 && r2 >= 4 && r3 >= 4 && r4 >= 4)
                answer++;
        }

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        n = int.Parse(Console.ReadLine());
        int r1 = 0, r2 = 0, r3 = 0, r4 = 0 ;
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            r1 = int.Parse(Console.ReadLine());
            r2 = int.Parse(Console.ReadLine());
            r3 = int.Parse(Console.ReadLine());
            r4 = int.Parse(Console.ReadLine());
            if (r1 == 2 || r2 == 2 || r3 == 2 || r4 == 2)
                answer++;
            s += (r1 + r2 + r3 + r4)/4;
        }
        avg = s / n;
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        int n = 3;
        // code here;
        if(r<=0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        answer = Math.Round(answer, 2);
        
        Console.WriteLine(r);
        Console.WriteLine(type);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if(A<=0 || B<=0) return 0;  
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (B<A)
                    answer = 0;
                else 
                    answer = Math.PI * B * B - Math.PI * A * A; 
                break;
            case 2:
                answer = 0.5 * A * Math.Sqrt(B * B - 0.25 * A * A);
                break;
        }
        answer = Math.Round(answer, 2);
        // end

        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(type);
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = -1;

        // code here
        double a = 0, s = 0;
        Console.WriteLine("Введите рост, для окончания напишите 0");
        do
        {
            a = double.Parse(Console.ReadLine());
            s += a;
            n++;
        }
        while (a > 0);
        answer = s / n;
        Console.WriteLine(answer);
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
        double x = 0, y = 0;
        Console.WriteLine("Введите x и y, для окончания напишите 1000");
        do
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
                answer++;
        }
        while (x < 1000);
        // end
        Console.WriteLine(answer);
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

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        Console.WriteLine("Введите x, для окончания напишите 1000");
        double x = 0, y = 0;
        do
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                answer1++;
            if (x < 0 && y < 0)
                answer3++;

        }
        while (x < 1000);
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        Console.WriteLine("Введите оценку, для окончания напишите 6");
        int r1 = 0, r2 = 0, r3 = 0, r4 = 0;
        // code here;
        do
        {
            r1 = int.Parse(Console.ReadLine());
            r2 = int.Parse(Console.ReadLine());
            r3 = int.Parse(Console.ReadLine());
            r4 = int.Parse(Console.ReadLine());
            if (r1 >= 4 && r2 >= 4 && r3 >= 4 && r4 >= 4)
                answer++;
        }
        while (r1 < 6);
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
