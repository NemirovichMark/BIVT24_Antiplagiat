using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        //program.Task_2_13(1.2, 2.1, 0);
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
        program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        int r = 2;
        // code here
        answer = Math.Abs(x * x + y * y - r * r) <= 0.001;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && Math.Abs(x) + y <= 1) {
            answer = ! answer;
        } 

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
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
        double mn = a;
        if (b < a)
        {
            mn = b;
        }
        answer = c;
        if (mn > answer)
        {
        answer = mn; 
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double d = a * Math.Sqrt(2);
        double radius = Math.Sqrt(r/Math.PI);
        if (d<= radius * 2)
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
        double radius = Math.Sqrt(r / Math.PI);
        if (radius * 2<= a)
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
            answer = x*x -1;
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
        else if (-1 < x && x <= 0)
        {
            answer = 1+x;
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
        else if (x>-1 && x <= 1)
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
        Console.WriteLine("Введите рост учеников:");
        // code here
        for (int i = 1; i <= n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int i = 1; i<=n; i++)
        {
            Console.WriteLine("Точка {0}, введите координату по Х:", i);
            x= double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату по У:");
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((a-x) * (a - x) + (b-y) * (b-y)) <= r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight = 0;
        Console.WriteLine("Введите вес учеников:");
        // code here
        for (int i = 1; i <= n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                answer += 0.2;
            }
            
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Точка {0}, введите координату по Х:", i);
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату по У:");
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double res = 0;
        // code here
        for (int i=0; i<n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if (res <= norm){
                answer++;
            }
        }
        // end
        Console.WriteLine (answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Точка {0}, введите координату по Х:", i);
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату по У:");
            y = double.Parse(Console.ReadLine());
            if (x<= Math.PI && x>=0 && y<= Math.Sin(x) && y>=0)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Точка {0}, введите координату по Х:", i);
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату по У:");
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y>0)
            {
                answer1++;
                Console.WriteLine("1");
            } else if (x<0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x = 0;
        double y = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Точка {0}, введите координату по Х:", i);
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату по У:");
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x+y*y)< answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }

        }
        Console.WriteLine(answer);
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double res = 0;
        // code here
        for (int i =0; i<n; i++)
        {
            res = double.Parse(Console.ReadLine()); 
            if (res < answer)
            {
                answer = res;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double a1 = 0;
        double a2 = 0;
        double a3 = 0;
        double a4 = 0;
        // code here;
        for (int i = 0; i<n; i++)
        {
            Console.WriteLine("Введите оценки ученика {0}", i+1);
            a1= double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            a3 = double.Parse(Console.ReadLine());
            a4 = double.Parse(Console.ReadLine());
            if (a1 > 3 && a2 > 3 && a3 > 3 && a4 > 3)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        double a1 = 0;
        double a2 = 0;
        double a3 = 0;
        double a4 = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите оценки ученика {0}", i + 1);
            a1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            a3 = double.Parse(Console.ReadLine());
            a4 = double.Parse(Console.ReadLine());
            if (a1 ==2 || a2 ==2 || a3 ==2 || a4 == 2)
            {
                answer++;
            }
            avg += a1 + a2 + a3 + a4;
        }
        // end
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r*r*Math.Sqrt(3) / 4;
                break;
            default:
                answer = 0;
                break;
        }
        answer = Math.Round(answer, 2);
        
        // end
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A<=0 || B <= 0)
        {
            return answer;
        }
        if (type <0 || type > 2)
        {
            return answer;
        }
        // code here;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI*B*B - Math.PI*A*A);
                break;
            case 2:
                answer = Math.Sqrt(B*B-A*A/4)*A/2;
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        double r = 0;
        // code here
        Console.WriteLine("Введите рост учеников, для окончания 0");
        while (true)
        {
            r = double.Parse(Console.ReadLine());
            if (r <= 0) break;
            answer += r;
            n++;
        }
        answer /= n;
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
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
        double x = 0;
        double y = 0;
        Console.WriteLine("Введите координаты точек, для окончания 10000");
        // code here
        while (true)
        {
            x = double.Parse(Console.ReadLine());
            if (x == 10000) break;
            y = double.Parse(Console.ReadLine());
            if (y == 10000) break;
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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
        double x = 0;
        double y = 0;
        Console.WriteLine("Введите координаты точек, для окончания 10000");
        // code here
        while (true)
        {
            x = double.Parse(Console.ReadLine());
            if (x == 10000) break;
            y = double.Parse(Console.ReadLine());
            if (y == 10000) break;
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        double a1 = 0;
        double a2 = 0;
        double a3 = 0;
        double a4 = 0;
        // code here;
        Console.WriteLine("Введите оценки учеников, для окончания 0");
        while (true)
        {
            a1 = double.Parse(Console.ReadLine());
            if (a1 == 0) break;
            a2 = double.Parse(Console.ReadLine());
            if (a2 == 0) break;
            a3 = double.Parse(Console.ReadLine());
            if (a3 == 0) break;
            a4 = double.Parse(Console.ReadLine());
            if (a4 == 0) break;
            if (a1 > 3 && a2 > 3 && a3 > 3 && a4 > 3)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
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
