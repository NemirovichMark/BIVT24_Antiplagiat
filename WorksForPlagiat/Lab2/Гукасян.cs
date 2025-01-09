using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    // Задания 2_12 и 2_13 не проходят тесты в связи с некорректной работой Math.Round
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
        int r = 2;
        // code here
        if (Math.Abs(x*x +y*y -r*r)<= 0.001)
        {
            answer = true;
        }else { answer = false; }

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y>=0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        else { answer = false; }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        
        // code here
        if (a > 0)
        {
            answer = Math.Max(a, b);
        }
        else
        {
            answer = Math.Min(a, b);
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if ((a != 0) && (b != 0) && (c != 0))
        {
            answer = Math.Max(Math.Min(a, b), c);
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        const double pi = 3.14;
        // code here
        if ((Math.Sqrt(r / pi))*Math.Sqrt(2) >= Math.Sqrt(s))
        {
            answer = true;
        }else { answer = false; }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        const double pi = 3.14;
        // code here
        if(2*Math.Sqrt(r / pi) <= Math.Sqrt(s))
        {
            answer = true;
        }
        else { answer = false; }
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
        else { answer = Math.Abs(x); }
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
        else { answer = x * x - 1; }
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
        if (((-1) < x)&&(x <= 1)) {
            answer = 1 + x;
        }
        if (x > 0)
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
        if ((x <= 1)&&(x>-1))
        {
            answer = -x;
        }
        if (x > 1)
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
        double s = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            s += double.Parse(Console.ReadLine());
        }
        // end
        answer = s / n;
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        
        // code here
        for (int i = 0; i < n; i++)

        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
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
        
        
        // code here
        for (int i = 1; i <= n; i++)
        {
            double s = double.Parse(Console.ReadLine());
            if ((s < 30) && (s>0))
            {
                answer += 0.2;
            }
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
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2)) {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double s = double.Parse(Console.ReadLine());
            if (s <= norm)
            {
                answer++;
            }
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
        for (int i = 1; i <= n; i++)
        {
            double x =double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            if ((x>=0) && (y>=0) && (y<=Math.Sin(x) && (x <= Math.PI))){
                answer++;
            }
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
        int answer2 = 0;
        int answer4 = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            if ((x>0) && (y > 0))
            {
                Console.WriteLine('1');
                answer1++;
            }
            if ((x < 0) && (y > 0))
            {
                Console.WriteLine('2');
                answer2++;
            }
            if ((x < 0) && (y < 0))
            {
                Console.WriteLine('3');
                answer3++;
            }
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine('4');
                answer4++;
            }
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
        if (n > 0)
        {
            for(int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (Math.Sqrt(x*x + y * y) < answerLength)
                {
                    answer = i;
                    answerLength=Math.Sqrt(x*x + y*y);
                }
            }
        }
        else
        {
            answerLength = 0;
        }
        // end
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        if (n > 0)
        {
            // code here
            for (int i = 1; i <= n; i++)
            {
                double result = double.Parse(Console.ReadLine());
                if (result < answer)
                {
                    answer = result;
                }
                
            }
        }
        else
        {
            answer = 0;
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
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                int b = 1;
                
                for (int k = 1; k <= 4; k++)
                {
                    double  oz = double.Parse(Console.ReadLine());
                    if (oz ==2 || oz==3)
                    {
                        b=0;
                    }
                    
                }
                answer += b;
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
        double s = 0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            bool check = false;
            s = 0;
            for (int k = 1; k <= 4; k++)
            {
                double oz = double.Parse((Console.ReadLine()));
                if (oz == 2) { check = true; }
                s += oz;
            }
            if (check) { answer++; }
            avg += s / 4;
        }
        avg = avg / n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r <= 0)
        {
            answer = 0;
        }
        else
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    Console.WriteLine("Area of square = {0}", answer);
                    
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    Console.WriteLine("Area of circle = {0}", answer);
                    
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    Console.WriteLine("Area of triangle = {0}", answer);
                    
                    break;
                default:
                    Console.WriteLine("Sorry...");
                    break;
            }
        }
       
        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                Console.WriteLine("Площадь прямоугольника = {0}", answer);
                
                break;
            case 1:
                answer = Math.PI * Math.Abs(A * A - B * B);
                Console.WriteLine("Площадь кольца = {0}", answer);
                
                break;
            case 2:
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4;
                Console.WriteLine("Площадь равнобедренного треугольника = {0}", answer);
                
                break;
            default:
                Console.WriteLine("Sorry...");
                break;
        }
        return (Math.Round(answer, 2));
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        double s = 0;
        // code here

        for (int i = 1; i <= int.MaxValue; i++)
        {
            double height = double.Parse(Console.ReadLine());
            if (height == -1) { break; }
            s += height;
            n++;
        }
        answer = s / n;

        // end
        Console.WriteLine(answer);
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
        for (int i = 1; i <= int.MaxValue; i++)
        {
            string output1 = Console.ReadLine();
            bool result = double.TryParse(output1, out var x);
            if (result == false) break;

            string output2 = Console.ReadLine();
            bool result2 = double.TryParse(output1, out var y);
            if (result2 == false) break;

            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
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
        int answer1 = 0, answer3 = 0, n = 0, answer2=0,answer4=0;

        // code here
        for (int i = 1; i <= int.MaxValue; i++)
        {
            string output1 = Console.ReadLine();
            bool result1= double.TryParse(output1, out var x);
            if (result1== false) { break; }

            string output2 = Console.ReadLine();
            bool result2 = double.TryParse(output2 , out var y);
            if (result2 == false) { break; }


            if ((x > 0) && (y > 0))
            {
                Console.WriteLine('1');
                answer1++;
            }
            if ((x < 0) && (y > 0))
            {
                Console.WriteLine('2');
                answer2++;
            }
            if ((x < 0) && (y < 0))
            {
                Console.WriteLine('3');
                answer3++;
            }
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine('4');
                answer4++;
            }
        }
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
            for (int i = 1; i <= int.MaxValue; i++)
            {
                int b = 1;

                for (int k = 1; k <= 4; k++)
                {
                    string s = Console.ReadLine();
                    bool result = int.TryParse(s, out var oz);
                    if (result == false || oz>5 ||oz<1 ){ goto endLoop; }
                    if (oz == 2 || oz == 3)
                    {
                        b = 0;
                    }

                }
                answer += b;
            }
            endLoop:
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer
        Console.WriteLine(answer);
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
