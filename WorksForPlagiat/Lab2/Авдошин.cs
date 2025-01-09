using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        //program.Task_2_12(1.5, 0);
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
        double r = 2;
        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.0001) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0)
        {
            if (a > b) answer = a; else answer = b;
        }
        else
        {
            if (a > b) answer = b; else answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double d = 0;
        // code here
        if (a > b)
        {
            d = b;
            if (c > d) answer = c; else answer = d;
        }
        else
        {
            d = a;
            if (c > d) answer = c; else answer = d; 
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(r / Math.PI)*2 >= Math.Sqrt(s*2)) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(r / Math.PI) * 2 < Math.Sqrt(s)) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        if (Math.Abs(x) <= 1) answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1) answer = (Math.Pow(x,2) - 1);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if ((x > -1) && (x <= 0)) answer = 1 + x;
        if (x > 0) answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        // code here
        double a = 0, s;
        for(int i = 1;i<n;i++)
        {
            Console.WriteLine($"рост ученика {i}");
            double b = double.Parse(Console.ReadLine());
            a += b;
        }
        s = a /n;
        Console.WriteLine(s);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for(int i = n;i>0;i--)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(Math.Pow(x-a,2)+Math.Pow(y-b,2))<=r) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        // code here
        double k = 0;
        for(int i = 1;i<n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 30) k += 0.2;
        }
        answer = Math.Round(k, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for( int i = 1;i<n;i++)
        {
            double x, y;
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            if (Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))>=r1 && Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))<=r2) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for(int i=1;i<n;i++)
        {
            double x;
            string x1 = Console.ReadLine();
            double.TryParse(x1 , out x);
            if(x>=norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for(int i=1;i<n;i++)
        {
            double x, y;
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            double.TryParse(x1 , out x);
            double.TryParse (y1 , out y);
            if(x>=0 && x<=Math.PI && y>=0 && y<=Math.Sin(x)) answer++;
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
        for (int i=1;i<n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x == 0 || y == 0) Console.WriteLine($"на оси");
            else if (x > 0 && y > 0)
            {
                Console.WriteLine($"первый квадрант");
                answer1++;
            }
            else if (x > 0 && y < 0) Console.WriteLine($"четвертый квадрант");
            else if (x > 0 && y < 0) Console.WriteLine($"второй квадрант");
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"третий квадрант");
                answer3++;
            }
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
        for (int i=1;i<n;i++)
        {
            double x, y;
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            double m = Math.Sqrt(x * x + y * y);
            if(m<answerLength)
            {
                answer = i;
                answerLength = m;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        if (n <= 0) return 0;
        for(int i=1;i<n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < answer) answer = x;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i < n; i++)
        {
            bool a = true;
            for (int j = 1; j < 4; j++)
            {
                int x = int.Parse(Console.ReadLine());
                if ((x == 2) || (x == 3)) a = false;
            }
            if (a == true) answer++;
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
        double m = 0;
        if (n <= 0) return (0, 0);
        for(int i = 1;i < n; i++)
        {
            bool b = true;
            for(int j = 1;j<5; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a<=0) return(0, 0);
                m += a;
                if(a == 2 || a == 3) b  = false;
            }
            if (b != true) answer++;
        }
        avg = m /(n*4);
        // end
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        Console.WriteLine($"\nТип фигуры:\n0.Квадрат\n1. Круг\n2. Равносторонний треугольник");
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r*r; break;
            case 1:
                answer = Math.PI*Math.Pow(r, 2); break;
            case 2:
                answer = Math.Pow(r, 2) * Math.Sqrt(3) / 4; break;
            default: return 0;
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        Console.WriteLine("\nТип фигуры:\n0. Прямоугольник\n1. Кольцо\n2. Равнобедренный треугольник");
        if (A <= 0 || B<=0) return 0;
        switch (type)
        {
            case 0:
                answer = A*B; break;
            case 1:
                answer = Math.Abs(Math.PI *Math.Pow(A, 2) - Math.PI*Math.Pow(B,2)); break;
            case 2:
                answer = Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A, 2) / 4) * A / 2; break;
            default: return 0;
        }
        answer = Math.Round(answer,2);
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
        for (int i = 0;; i++)
        {
            double x, y;
            string x1 = Console.ReadLine();
            if (x1 == "all") break;
            string y1 = Console.ReadLine();
            double.TryParse(x1,out x);
            double.TryParse(y1, out y);
            if (Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2)) <= r) answer++;
            
        }
        Console.WriteLine(answer);
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
        for (int i = 1;; i++)
        {
            double x;
            string x1 = Console.ReadLine();
            if (x1 == "all") break;
            double.TryParse(x1, out x);
            if (x >= norm) answer++;
        }
        Console.WriteLine(answer);
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
        for (int i = 1;; i++)
        {
            double x, y;
            string x1 = Console.ReadLine();
            if (x1 == "all") break;
            string y1 = Console.ReadLine();
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            double m = Math.Sqrt(x * x + y * y);
            if (m < answerLength)
            {
                answer = i;
                answerLength = m;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        int k = 0;
        double m = 0;
        for (int i = 1;; i++)
        {
            Console.WriteLine($"номер студента");
            string x = Console.ReadLine();
            if (x == "all") break;
            k++;
            bool b = true;
            Console.WriteLine($"баллы студента");
            for (int j = 1; j < 5; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0) return (0, 0);
                m += a;
                if (a == 2 || a == 3) b = false;
            }
            if (b != true) answer++;
        }
        avg = m /(k*4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}