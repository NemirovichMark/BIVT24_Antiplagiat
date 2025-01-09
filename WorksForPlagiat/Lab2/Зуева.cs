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
        //program.Task_1_1(1.5, 0.7);
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
        double r = 2;
        
        // code here
        if (Math.Abs(x*x+y*y-r*r)<=1/1000)
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
        if (a > 0 && a > b)
            answer = a;
        else if (a>0 && a < b)
            answer = b;
        else if (a <= 0 && a > b)
            answer = b;
        else
            answer = a;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double minab = 0;
        // code here
        if (a < b)
            minab = a;
        else
            minab = b;
        if (c > minab)
            answer = c;
        else
            answer = minab;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        r = 2*Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(2) *Math.Sqrt(s);
        // code here
        if (s <= r)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        r = 2 * Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
        // code here
        if (r <= s)
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
        else if (x > -1 && x <= 0)
            answer = 1 + x;
        else
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > -1 && x < 1)
            answer = -1 * x;
        else
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        int height;
        // code here
        for (int i = 0; i<n; i++)
        {
            int.TryParse(Console.ReadLine(), out height);
            answer += height;
        }
        // end
        answer /= n;
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i=0; i<n; i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
           
            if (((a-x)*(a-x)+(b-y)*(b-y))<=( r * r))
                answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight;

        // code here
        for (int i = 0; i<n; i++)
        {
            weight=double.Parse(Console.ReadLine());
            if (weight < 30)
                answer+=200;
        }
        // end
        answer /= 1000;
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
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
        double res;
        // code here
        for(int i=0; i<n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if (res < norm)
                answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i=0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y >= 0 & x >= 0 & x <= Math.PI & y<=Math.Sin(x))
                answer++;
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
        double x, y;
        // code here
        for (int i = 0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 & y>0)
            {
                answer1++;
                Console.WriteLine("1 квадрант");
            }
            if (x < 0 & y > 0)
            {
               
                Console.WriteLine("2 квадрант");
            }
            if (x < 0 & y < 0)
            {
                answer3++;
                Console.WriteLine("3 квадрант");
            }
            if (x > 0 & y < 0)
            {
                
                Console.WriteLine("4 квадрант");
            }
        }
        // end
        Console.Write("количество точек в 1 квадранте: {0:d} \n количество точек в 3 квадранте: {1:d}",answer1, answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y,c;
        // code here
        for( int i=0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            c = Math.Sqrt(x*x+y*y);
            if (c < answerLength)
            {
                answer = i + 1;
                answerLength = c;
            }
            

        }
        // end
        Console.Write("{0}, {1}", answer,answerLength);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double res;
        // code here
        for (int i=0; i<n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if (res < answer)
                answer = res;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int res1, res2, res3, res4;
        // code here;
        for (int i = 0; i<n; i++)
        {
            res1 = int.Parse(Console.ReadLine());
            res2 = int.Parse(Console.ReadLine());
            res3 = int.Parse(Console.ReadLine());
            res4 = int.Parse(Console.ReadLine());
            if (res1>3 && res2 >3 && res3 >3 && res4 >= 3)
                answer++;
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
        int res1, res2, res3, res4;
        // code here;
        for (int i = 0; i<n; i++)
        {
            res1 = int.Parse(Console.ReadLine());
            res2 = int.Parse(Console.ReadLine());
            res3 = int.Parse(Console.ReadLine());
            res4 = int.Parse(Console.ReadLine());
            avg += res1 + res2 + res3 + res4;
            if (res1 == 2 || res2 == 2 || res3 == 2 || res4 == 2)
                answer++;
        }

        // end
        Console.WriteLine("кол-во неуспевающих: {0}, средний балл группы: {1}", answer,avg / (n*4));
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r > 0){
            switch (type) {
                case 0:
                    answer = r * r ; break;
                case 1:
                    answer = r * r * Math.PI; break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4; break;
                default: break;
            }
        }
        else
        {
            return 0;
        }
        // code here;

        // end

        return Math.Round(answer,2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                double temp = (A > B) ? A : B;
                A = (A > B) ? B : A;
                B = temp;
                answer = Math.PI * B * B - Math.PI * A * A;
                break;
            case 2:
                double h = Math.Sqrt(B * B - (A / 2)*(A/2));
                answer = 0.5 * A * h;
                break;
            default:
                answer = 0;
                break;
        }

        answer = Math.Round(answer, 2);

        if (A <= 0 || B <= 0) answer = 0;
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        

        // code here
        double answer = 0, n=0;
        int height;
        string stop;
        // code here
        for (int i = 0; i < 1000000000000000; i++)
        {
            stop = Console.ReadLine();
            
            if (stop == "stop") break;
            else
            {
                height = int.Parse(stop);
                answer += height;
                n++;
            }
        }
        // end
        answer /= n;
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
        double x, y;
        string stop1;
        // code here
        for (int i = 0; i < 100000000000; i++)
        {
            stop1 = Console.ReadLine();
            if (stop1 == "stop") 
                break;

            
            
            else
            {
               
                x = double.Parse(stop1);
                y = double.Parse(Console.ReadLine());
                if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
                    answer++;
            }
        }
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
        int answer1 = 0, answer3 = 0;
        
        // code here
        double x, y;
        string stop1;
        // code here
        
        for (int i = 0; i < 1000000000000000; i++)
        {
            stop1 = Console.ReadLine();
            if (stop1 == "stop") break;
            else
            {
                

                x = double.Parse(stop1);
                y = double.Parse(Console.ReadLine());
                if (x > 0 & y > 0)
                {
                    answer1++;
                    Console.WriteLine("1 квадрант");
                }
                if (x < 0 & y > 0)
                {

                    Console.WriteLine("2 квадрант");
                }
                if (x < 0 & y < 0)
                {
                    answer3++;
                    Console.WriteLine("3 квадрант");
                }
                if (x > 0 & y < 0)
                {

                    Console.WriteLine("4 квадрант");
                }
            }
        }
        // end
        Console.Write("количество точек в 1 квадранте: {0:d} \n количество точек в 3 квадранте: {1:d}", answer1, answer3);
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
        int answer = 0;
        string stop;
        // code here;
        int res1, res2, res3, res4;
        // code here;
        for (int i = 0; i < 100000000; i++)
        {
            stop = Console.ReadLine();
            if (stop == "stop") break;
            else
            {
                res1 = int.Parse(stop);
                res2 = int.Parse(Console.ReadLine());
                res3 = int.Parse(Console.ReadLine());
                res4 = int.Parse(Console.ReadLine());
                if (res1 > 3 && res2 > 3 && res3 > 3 && res4 >= 3)
                    answer++;
            }
        }
        // end
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
