using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

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
        program.Task_2_8(5);
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
        if (Math.Abs(x*x+y*y-r*r)<=0.001) 
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
        if (y>=0 && y+Math.Abs(x)<=1)
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
        if (a>0)
        {
            answer = a;
            if (b>a)
            {
                answer = b;
            }
        }
        if (a<=0)
        {
            answer = a;
            if (b<a)
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
        double mini = a;

        // code here
        if (b<a)
        {
            mini= b;
        }
        answer = mini;
        if (mini < c)
        {
            answer = c;
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double d, a;

        // code here
        d = Math.Sqrt(r / double.Pi) * 2;
        a = Math.Sqrt(s);
        a = Math.Sqrt(a * a * 2);
        if (d>=a)
        {
            answer= true;
        }
       
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double d, a;
        // code here
        d = Math.Sqrt(r / double.Pi) * 2;
        a = Math.Sqrt(s);
        if (a>=d)
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
        if(Math.Abs(x) <= 1)
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
        if (Math.Abs(x) < 1)
        {
            answer = x * x - 1;

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
       if (-1<x && x <= 0)
        {
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
        if (-1 < x && x <= 1)
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
        double r, s = 0;
        for (int i = 0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out r);
            s+= r;
        }
        answer = s / n;
        // code here

        // end
        Console.WriteLine(answer.ToString());
        return answer;
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("¬ведите y");
            double.TryParse(Console.ReadLine(), out y);
            if ((x-a)*(x-a)+(y-b)*(y-b)<r*r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end
        //for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 - 0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double v;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out v);
            if (v < 30)
            {
                answer += 200;
            }
        }
        Console.WriteLine(answer / 1000);
        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double result;
        // code here
        for (int i = 0; i < n; i++)
        {
           double.TryParse(Console.ReadLine(),out result);
            if (result <= norm)
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
        double x, y;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0)) answer++;

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
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("первый квадрант");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("второй квадрант");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("третий квадрант");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("четвертый квадрант");
            }
        }
        Console.WriteLine("кол-во точек в 1 квадранте {0}", answer1);
        Console.WriteLine("кол-во точек в 3 квадранте {0}", answer3);
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double s = Math.Sqrt(x * x + y * y);
            if (s < answerLength)
            {
                answer = i;
                answerLength = s;

            }

        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double result;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer)
                answer = result;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int grade_1,grade_2, grade_3, grade_4;
        // code here;
        for (int i = 0; i < n; i++)
        {
            
            int.TryParse(Console.ReadLine(), out grade_1);
            int.TryParse(Console.ReadLine(), out grade_2);
            int.TryParse(Console.ReadLine(), out grade_3);
            int.TryParse(Console.ReadLine(), out grade_4);

            if (grade_1 >= 4 && grade_2 >= 4 && grade_3 >= 4 && grade_4 >= 4) answer++;
        }
        Console.WriteLine("ответ:{0}", answer);
        // end
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double sum = 0;
        int grade_1, grade_2, grade_3, grade_4;
        // code here;
        for (int i = 1; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out grade_1);
            int.TryParse(Console.ReadLine(), out grade_2);
            int.TryParse(Console.ReadLine(), out grade_3);
            int.TryParse(Console.ReadLine(), out grade_4);
            if (grade_1 == 2 || grade_2 == 2 || grade_3 == 2 || grade_4 == 2) answer++;
            double s = grade_1 + grade_2 + grade_3 + grade_4;
            sum += s;
        }
        avg = sum / n / 4;
        Console.WriteLine("кол-во неуспевающих студентов:{0}", answer);
        Console.WriteLine("средний балл группы:{0}", avg);
        // end
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
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
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4.0;
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
        double p = (A + B + B) / 2;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * (B * B - A * A);
                    break;
                case 2:
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;
            }
        }
        answer = Math.Round(Math.Abs(answer), 2);
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
        double x, y;
        string x1 = "1";
        string y1 = "1";
        // code here
        while (x1!="stop")
        {
            x1 = Console.ReadLine();
            if (x1 != "stop")
            {
                y1=Console.ReadLine();
                x=double.Parse(x1);
                y= double.Parse(y1);
                if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
                {
                    answer++;
                }
            }
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
        string res1 = "1";
        double res = 0;
        // code here
        while (res1 != "stop")
        {
            res1 = Console.ReadLine();
            if (res1 != "stop")
            {
                res=double.Parse(res1);
                if (res <= norm)
                {
                    answer++;
                }
            }
        }
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
        double x, y;
        string x1 = "1";
        string y1 = "1";
        int count = 0;
        // code here
        while (x1 != "stop")
        {
            x1 = Console.ReadLine();
            if (x1 != "stop")
            {
                y1 = Console.ReadLine();
                x = double.Parse(x1);
                y = double.Parse(y1);
                count++;
                double s = Math.Sqrt(x * x + y * y);
                if (s < answerLength)
                {
                    answer = count;
                    answerLength = s;

                }
                
            }
        }

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
        double exz1, exz2, exz3, exz4;
        double s = 0;
        string exz1_1 = "1";
        while (exz1_1 != "stop")
        {
            exz1_1 = Console.ReadLine();
            if (exz1_1 != "stop")
            {
                
                exz1 = double.Parse(exz1_1);
                exz2 = double.Parse(Console.ReadLine());
                exz3 = double.Parse(Console.ReadLine());
                exz4 = double.Parse(Console.ReadLine());
                s = s + exz1 + exz2 + exz3 + exz4;
                if ((exz1 == 2) || (exz2 == 2) || (exz3 == 2) || (exz4 == 2))
                {
                    answer += 1;
                }
            }
        }
        avg = s / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}