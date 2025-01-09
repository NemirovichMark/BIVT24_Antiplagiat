using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        program.Task_2_13(10, 5, 0);
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
        int r = 2;

        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
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
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
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
            else answer = b;
        }
        if (a <= 0)
        {
            if (a < b)
                answer = a;
            else answer = b;
        }

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double p;
        double z;

        // code here
        if (a < b)
            p = a;
        else
            p = b;
        if (p > c)
            z = p;
        else
            z = c;
       answer = z;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(s + s))
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
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
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
        if (Math.Abs(x) > 1) return 1;
        if (Math.Abs(x) <= 1)
            return Math.Abs(x);

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) return 0;
        if (Math.Abs(x) < 1)
            return x * x - 1;

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 0;
        if (x > -1 && x <= 0)
            return 1 + x;
        if (x > 0)
            return 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        if (x > -1 && x <= 1)
            return -x;
        if (x > 1)
            return -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double r = 0;
        double sr = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            answer += r;
        }
         sr = answer / n;
        Console.WriteLine(sr);

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y = 0;
        // code here
        for(int i =0;i<n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(((x-a)*(x-a)+(y-b)*(y-b)) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
       
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double ves = 0;

        // code here
        for(int i = 0;i<n;i++)
        {
            ves = double.Parse(Console.ReadLine());
            if (ves < 30)
                answer += 0.2;
            else
                continue;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y = 0;
        // code here
        for (int i = 0;i < n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse (Console.ReadLine(), out y);
            if (Math.Sqrt((x * x) + (y * y)) >= r1 && Math.Sqrt((x * x) + (y * y)) <= r2)
            {
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
        int answer = 0;
        double res = 0;
        // code here
        for(int i =0;i < n ;i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res < norm)
            {
                answer++;
            }
            
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y = 0;

        // code here
        for(int i = 0;i<n;i++)
        {
            double.TryParse(Console.ReadLine() , out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x)))
            {
                answer++;
            }
            else
                continue;
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
        double x, y = 0;
        // code here
        for (int i = 0; i <= n; i++)
        {
            double.TryParse((Console.ReadLine()), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("Точка в первом квадранте");
                answer1++;
            }
            if (x<0 && y > 0)
                Console.WriteLine("Точка во втором квадранте");
            if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Точка в третьем квадранте");
                answer3++;
            }
            if (x>0 && y < 0)
                Console.WriteLine("Точка в четвёртом квадранте");
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
        double x;
        double y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt((x * x) + (y * y));
                answer = i;
            }
         
        }

         Console.WriteLine(answer);
         Console.WriteLine(Math.Round(answerLength,2));
        
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double res = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if(res < answer)
                answer = res;
            else
                continue;
        }
        Console.WriteLine(answer);
      
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int x1,x2,x3,x4 = 0;
        // code here;
        for(int i = 0;i < n;i++)
        {
            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out x3);
            int.TryParse(Console.ReadLine(), out x4);
            if(x1>3 && x2 > 3 && x3 > 3 && x4 > 3)
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
        double sum = 0.0;
        double x1,x2,x3,x4;
        // code here;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x1);
            double.TryParse(Console.ReadLine(), out x2);
            double.TryParse(Console.ReadLine(), out x3);
            double.TryParse(Console.ReadLine(), out x4);
            if (x1 < 3 || x2 < 3 || x3 < 3 || x4 < 3)
                answer++;
            if (x1 > 1 || x2 > 1 || x3 > 1 || x4 > 1)
                sum += (x1 + x2 + x3 + x4)/4;
        }
        avg = sum / n;
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
        if(r <= 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = r * r;
                Console.WriteLine("Площадь квадрата", answer);
                break;
            case 1:
                answer = Math.PI * r * r;
                Console.WriteLine("Площадь круга", answer);
                break;
            case 2:
                answer = (r*r * Math.Sqrt(3)) / 4;
                Console.WriteLine("Площадь одностороннего треугольника", answer);
                break;
            default:
                answer = 0;
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
        double p, k = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = A * B;
                Console.WriteLine("площадь прямоугольника", answer);
                break;
            case 1:
                p = Math.PI * A * A;
                k = Math.PI * B * B;
                answer = Math.Abs(p - k);
                Console.WriteLine("Площадь кольца", answer);
                break;
            case 2:
                answer = 0.5 * A * Math.Sqrt(B * B - (A / 2) * (A / 2));
                Console.WriteLine("Площадь равнобедренного треугольника", answer);
                break;
            default:
                answer = 0;
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;
        double ves = 0;

        // code here
        while(true)
        {
            string input = Console.ReadLine();
            bool succes = double.TryParse(input, out ves);
            if (succes)
            {
                if (ves < 30)
                {
                    answer += 0.2;
                }
            }
            else
                break;
        }
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
        double x, y = 0;
        // code here
        while(true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            bool succes1 = double.TryParse(input1, out x);
            bool succes2 = double.TryParse(input2,out y);
            if(succes1&&succes2)
            {
                if (x >= 0&& x<=Math.PI && y>=0 && y <= Math.Sin(x))
                {
                    answer++;
                }
            }
            else break;
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
        int n = 0;
        double res = 0;

        // code here
        while(true)
        {
            string input = Console.ReadLine();
            bool succes = double.TryParse(input, out res);
            if(succes)
            {
                if(res < answer)
                {
                    answer = res;
                }
            }
            else break;
        }
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
