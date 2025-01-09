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
        //program.Task_2_8(4);
        //program.Task_2_9(10);
        //program.Task_2_10(8);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
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
        answer = Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - 4) <= 0.001;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = y >= 0 && y + Math.Abs(x) <= 1;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a <= 0){
            if (a < b)
            {
                answer = a;
            }
            else {
                answer = b;
            }
        }
        else
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (c > a)
            {
                answer = c;
            }
            else
            {
                answer = a;
            }
        }
        else
        {
            if (c > b)
            {
                answer = c;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        answer = (Math.Sqrt(s * 2) <= Math.Sqrt(r / double.Pi)*2);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        answer = (Math.Sqrt(s) >= Math.Sqrt(r / double.Pi) * 2);
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
        if(Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x*x-1;
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
        else if (x<=0)
        {
            answer = 1+x;
        }else
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
        else if (x <= 1)
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
        for (int i = 0; i<n; i++)
        {
            answer += Convert.ToInt32(Console.ReadLine());  
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Replace(".", ",").Split();
            double x = Convert.ToDouble(p[0]);
            double y = Convert.ToDouble(p[1]);
            if (Math.Pow(a - x, 2)+ Math.Pow(b - y, 2) <= r * r)
            {
                answer += 1;
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

        // code here
        double weight;
        for (int i =0; i<n; i++)
        {
            double.TryParse(Console.ReadLine().Replace(".", ","), out weight);
            if (weight < 30) { answer += 0.2; }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow( x, 2) + Math.Pow(y, 2) > r1 * r1 && Math.Pow(x, 2) + Math.Pow(y, 2) < r2 * r2)
            {
                answer += 1;
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

        // code here
        double rez;
        for(int i = 0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out rez);
            if (rez <= norm) { answer ++; }

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

        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x))
            {
                answer++;
            }
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
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1 квадрат");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 квадрат");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3 квадрат");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 квадрат");
            }
        }
        Console.WriteLine($"количесво точек в 1 квадрате {answer1}");
        Console.WriteLine($"количесво точек в 3 квадрате {answer3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double l = -1;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            k++;
            if (Math.Sqrt(x*x + y*y) < l ^ l==-1)
            {
                l = Math.Sqrt(x * x + y * y);
                answer = k;
            }
            answerLength = l;

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

        // code here
        double t = -1;
        for (int i =0; i <n; i++)
        {
            double y = Convert.ToDouble(Console.ReadLine());
            if (y<t ^ t==-1)
            {
                t = y;
            }
        }
        answer = t;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i =0; i <n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (a < 4 || b < 4 || c < 4 || d < 4 )
            {
                answer++;
            }

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
        for (int i = 0; i<n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (a < 3 || b < 3 || c < 3 || d < 3)
            {
                answer++;
            }
            int sum = a + b + c + d;
            avg += sum;
        }
        avg = avg / (4 * n);
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
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                {
                    answer = r * r;
                    break;
                }
            case 1:
                {
                    answer = Math.PI * r * r;
                    break;
                }
            case 2:
                {
                    answer = r * r * Math.Sqrt(3) / 4;
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
        if (A <= 0 || B <= 0)
            return 0;
        switch (type)
        {
            case 0:
                
                    answer = A * B;
                    break;
                
            case 1:
                
                    answer = Math.PI * Math.Abs(A * A - B*B);
                    break;
                
            case 2:
                    answer = Math.Sqrt(B*B - Math.Pow(A/2,2))*A / 2;
                    break;
                
            default:
                
                    return 0;
                
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
        string a;

        // code here
        while (true)
        {
            a = Console.ReadLine();
            if (a.Length == 0)
            {
                break;
            }
            n++;
            answer += Convert.ToDouble(a);
        }
        answer = answer / n;
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
        string a;

        // code here
        while (true)
        {
            a =(Console.ReadLine());
            if (a.Length == 0)
            {
                break;
            }
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) > r1 * r1 && Math.Pow(x, 2) + Math.Pow(y, 2) < r2 * r2)
            {
                answer += 1;
            }
        }
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
        string a;
        while (true) 
        {
            a = (Console.ReadLine());
            if (a.Length == 0)
            {
                break;
            }
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(Console.ReadLine());
            if (x >= 0 && y >= 0)
            {
                answer1++;
            }
            else if (x <= 0 && y <= 0)
            {
                answer3++;
            }
        }
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

        // code here;
        while (true) 
        {
            string a = Console.ReadLine();
            if (a.Length == 0)
            {
                break;
            }
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string s = a + b + c + d;
            if (!s.Contains('2') && !s.Contains('3'))
            {
                answer++;
            }

        }
        Console.WriteLine(answer);
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
