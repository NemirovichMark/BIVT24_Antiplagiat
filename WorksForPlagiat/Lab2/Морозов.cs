using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        int score = 0, mark = 0,n=20;
        
            while(n-- > 0)
            {
                score= int.Parse(Console.ReadLine());
                if(score >= 450)
                {
                    Console.WriteLine("Отлично");
                }
                else if(score >=350)
                {
                    Console.WriteLine("Хорошо");
                }
                else if (score >= 250)
                {
                    Console.WriteLine("Удовлетворительно");
                }
                else
                {
                    Console.WriteLine("Неудовлетворительно");
                }
            }
    
       
        
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        Program program = new Program();
        //program.Task_1_1(1, 1);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.86, 0.74);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5,1,3,1);
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6,25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(2);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(10);

        //program.Task_2_12(3,2);
        //program.Task_2_13(3, 2.5, 1);
        //program.Task_3_1(10);
        //program.Task_3_2(5, 2);
        //program.Task_3_3();
        //program.Task_3_4(5, 1, 3);
        //program.Task_3_5(10, 30);
        //program.Task_3_6(5);
        //program.Task_3_7(5);
        //program.Task_3_8(10);
        //program.Task_3_9(10);
        //program.Task_3_10(10);
        //program.Task_3_11(10);
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        double r = 2;
        // code here
        if(Math.Abs(x*x+y*y- r * r)  <= 0.001)
        {
            answer = true;
        
        }
        // end
        Console.WriteLine(x * x + y * y-r*r);
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y>=0 && y+ Math.Abs(x) <= 1)
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
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double R = 2* Math.Sqrt(r / Math.PI);
        double S = Math.Sqrt(s * 2.0 );
        // code here
        Console.WriteLine(R);
        Console.WriteLine(S);
        if (R > S )
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double R = 2* Math.Sqrt(r / Math.PI);
        double S = Math.Sqrt(s);
        // code here
        Console.WriteLine(R);
        Console.WriteLine(S);
        if (S>R)
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
        if (Math.Abs(x) > 1)
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
        if (x<=-1)
        {
            answer = 0;
        }
        else if(x<=0)
        {
            answer = x+1;
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
        for (int i = 0; i < n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        
        return answer;
    }
    public int Task_2_2(int n, double r,double a,double b)
    {
        int answer = 0;
        double x, y; 

        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x-a)*(x-a)+(y-b)*(y-b)<=r*r)
            {
                answer ++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0,m =0 ;

        // code here
        for (int i = 0; i < n; i++)
        {
            m = double.Parse(Console.ReadLine());
            if (m < 30.0)
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

        double x, y,t;
        if(r1< r2)
        {
            t = r1;r1 = r2;r2 = t;
        }
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y <= r1 * r1 && x * x + y * y >= r2 * r2)
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
        double m = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            m = double.Parse(Console.ReadLine());
            if (m < norm)
            {
                answer ++;
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
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y >= 0 && y <= Math.Abs(Math.Sin(x)) && x>=0 && x <=Math.PI)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 && y>0)
            {
                //Console.WriteLine("1");
                answer1++;
            }else if (x < 0 && y > 0)
            {
                //Console.WriteLine("2");
                
            }
            else if (x < 0 && y < 0)
            {
                //Console.WriteLine("3");
                answer3++;
            }
            else if(x>0 && y<0)
            { 
                //Console.WriteLine("4");
            }
        }
        // end
        Console.WriteLine($"{ answer1 } { answer3 }");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y,s;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            s = Math.Sqrt(x * x + y * y);
            if (s <= answerLength)
            {
                answerLength = s;
                answer = i;
            }
   
        }
        if (n == 0) answerLength = 0;
        // end
        Console.WriteLine($"{answer} {answerLength}");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double t;
        // code here
        for (int i = 0;i < n; i++)
        {
            t = double.Parse(Console.ReadLine());
            if(t< answer)
            {
                answer = t;
            }
        }
        if (n == 0) answer = 0;
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0,mark =0,numb=0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            numb = 0;
            for(int j = 1; j <= 4; j++)
            {
                mark = int.Parse(Console.ReadLine());
                if(mark ==4 || mark == 5)
                {
                    numb++;
                }
            }
            if (numb == 4)
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
        int mark = 0, numb = 0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            numb = 0;
            for (int j = 1; j <= 4; j++)
            {
                mark = int.Parse(Console.ReadLine());
                avg += mark;
                if (mark == 2)
                {
                    numb = 1;
                }
            }
            if (numb == 1)
            {
                answer++;
            }
        }
        avg =avg/(n*4);
        // end
        Console.WriteLine(answer);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;

        if (type < 0 || type > 2) 
            return 0;
        
        if (type == 0)
        {
            answer = r * r;
        }
        else if (type == 1)
        {
            answer = Math.PI * r * r;
        }
        else if (type == 2)
        {
            answer = (Math.Sqrt(3) * r * r) / 4;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2) return 0;
        if (A <= 0) return 0;
        if (B <= 0) return 0;
        if (type == 0)
        {
            answer = A*B;
        }
        else if (type == 1)
        {
            
            answer = Math.PI *Math.Abs(B*B-A*A);
        }
        else if (type == 2)
        {
            double h = Math.Sqrt(B * B - A * A / 4);
            answer = A * h/2;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1(int n)
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(int n, double r)
    {
        int answer = 0;
        

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        string stop = "";

        // code here
        while (true)
        {
            stop = Console.ReadLine();
            Double.TryParse(stop, out double m);
            if (stop == "stop") break;
            if (m < 30.0)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(int n, double norm)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here
        string stop= "";
        // code here
        while(true)
        {
            stop = Console.ReadLine();
            Double.TryParse(stop, out double x);
            if (stop == "stop") break;
            stop = Console.ReadLine();
            Double.TryParse(stop, out double y);
            if (stop == "stop") break;
            if (y >= 0 && y <= Math.Abs(Math.Sin(x)))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8(int n)
    {
        int answer = 0;
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
        string stop = "";
        double t = 0;
        // code here
        while(true)
        {

            stop = Console.ReadLine();
            Double.TryParse(stop, out t);
            if (stop == "stop") break;
            if (t < answer)
            {
                answer = t;
            }
        }
        if (t==0) answer = 0;
        // end
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10(int n)
    {
        int answer = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11(int n)
    {
        int answer = 0;
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