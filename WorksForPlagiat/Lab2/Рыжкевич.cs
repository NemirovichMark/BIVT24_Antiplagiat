using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r=2;
        if (Math.Abs(x*x+y*y-r*r)<=0.001)
            answer=!answer; 
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && y+Math.Abs(x)<=1)
            answer=!answer;
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
        else 
        {
            if(a < b)
                answer = a;
            else answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double m = a;
        if (a < b)
            m = a;
        else m = b;
        if (m < c)
            answer = c;
        else answer = m;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s)*Math.Sqrt(2)<=2*(Math.Sqrt(r/Math.PI)))
            answer=!answer;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2*(Math.Sqrt(r/Math.PI))<=(Math.Sqrt(s)))
            answer=!answer;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>1)
            answer = 1;
        else 
            answer=Math.Abs(x);
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
        else if (x > -1 && x <= 1)
            answer = -x;
        else if (x > 1)
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
        double r, s = 0, g=0;
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите рост ученика");
            r = double.Parse(Console.ReadLine());
            if (r == 0) break;
            s = s + r;
            g = g + 1;
        }
        answer = s / g;
        Console.WriteLine("Средний рост {0:f2}", answer);
        // end
        //rabotaeeeeeeeet
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite x");
            double x=double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite y");
            double y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
                answer++;
        }
        Console.WriteLine("Popadet {0:f2}", answer);
        // end
        // rabotaet
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double r;
        double ml = 0.2, an=0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите вес ученика");
            r = double.Parse(Console.ReadLine());
            if (r < 30) 
                an = an + 1;
        }
         answer = ml * an;
        Console.WriteLine("надо литров молока {0:f2}", answer);
        // end
        // rabotaeeeeeeeeeeeet yraaaaa
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite y");
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y < r1 * r1 && x * x + y * y < r2 * r2)
                answer++;
        }
        Console.WriteLine("Popadet {0:f2}", answer);
        // end
        // rabotaeeeeeeeet
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double r = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите результат ученика");
            r = double.Parse(Console.ReadLine());
            if (r <=norm)
                answer ++;
        } 
        Console.WriteLine("Vipolnili normativ: {0:f2}", answer);
        // end
        // rabotaet
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite y");
            double y = double.Parse(Console.ReadLine());
            if (x <= Math.PI && x>=0 && y<=Math.Sin(x) && y>=0)
                answer++;
        }
        Console.WriteLine("Принажлежат {0:f2}", answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite y");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка в 1 квадранте");
                answer1++;
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка в 3 квадранте");
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка в 4 квадранте");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка в 4 квадранте");
            }
        }
        Console.WriteLine("Tochek v 1 {0:f2}", answer1);
        Console.WriteLine("Tochek v 3 {0:f2}", answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite y");
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y)< answerLength);
            { 
                answerLength= Math.Sqrt(x * x + y *y);
                answer = i;
            }

        }
        answerLength=Math.Round(answerLength, 2);
        Console.WriteLine("bliz {0:f2} Rast {1:f2}", answer, answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("vvedite resultat");
            double resul = double.Parse(Console.ReadLine());
            if (resul < answer)
            {
                answer = resul;
            }
        }
        Console.WriteLine("Лучший результат {0:f2}", answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        

        for (int i = 1; i <= n; i++)
        {
            int c = 0;
            for (int l = 1; l <= 4; l++)
            {
                Console.WriteLine("Введите оценки:");
                double x = double.Parse(Console.ReadLine());
                if (x==2 ||  x==3)
                    c++;
            }
            if (c == 0)
                answer++;
        }
        Console.WriteLine("не имеют 2 и 3 {0:f2}", answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double s = 0.0;
        for (int i = 1; i <= n; i++)
        {
            int c = 0;
            double go = 0;
            for (int l = 1; l <= 4; l++)
            {
                Console.WriteLine("Введите оценки:");
                double x = double.Parse(Console.ReadLine());
                go += x;
                if (x == 2 || x == 1)
                    c++;
            }
            s += go / 4;
            avg = s/4;
            avg = Math.Round(avg, 2);
            if (c != 0)
                answer++;
        }
        
            // end

            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0:
                answer = r*r; break;
            case 1:
                answer = r*r*Math.PI; break;
            case 2:
                answer = (r*r*Math.Sqrt(3))/4; break;
            default:
                return 0;
        }
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A<=0) || (B<=0)) return 0;
            switch (type)
            {
                case 0:
                    answer = A * B; break;
                case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                       break; 
                case 2:
                    answer = (A * Math.Sqrt(4*B*B-A*A))/4; 
                    break;
                default:
                    Console.WriteLine("выберите правильное число 1,2 или 3");
                    break;
            }
        answer= Math.Round(answer, 2);
        Console.WriteLine("S= {0:f2}", answer);
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
        double sr, s = 0;
        while (true) 
        {
            Console.WriteLine("Введите рост ученика");
            string? r = Console.ReadLine();
            if (r == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(r, out double k);
                s = s + k;
                n = n + 1;
            }
        }
        sr = s / n;
        Console.WriteLine("Средний рост {0:f2}", sr);

        // end
        // rabotaeeeeeeeet
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

        // code here

        while (true)
        {
            Console.WriteLine($"Введите координаты точки: ");
            string? s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                string? s2 = Console.ReadLine();
                double.TryParse(s, out double x);
                double.TryParse(s2, out double y);
                double distance = Math.Sqrt(x * x + y * y);
                if (distance >= r1 && distance <= r2)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine($"{answer} Точек входит в промежуток");
        // end
        // работает
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

        // code here
        
        while(true) 
        {
            Console.WriteLine("vvedite x");
            string? x1 = Console.ReadLine();
            if (x1 == "stop")
            {
                break;
            }
            else
            {
                Console.WriteLine("vvedite y");
                string? s2 = Console.ReadLine();
                double.TryParse(x1, out double x);
                double.TryParse(s2, out double y);
              
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Точка в 1 квадранте");
                    answer1++;
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Точка в 3 квадранте");
                    answer3++;
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Точка в 4 квадранте");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка в 4 квадранте");
                }
            }
        } 
        Console.WriteLine("Tochek v 1 {0:f2}", answer1);
        Console.WriteLine("Tochek v 3 {0:f2}", answer3);
        // end

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
        int answer = 0;
        // code here;
        int c = 0;
        for (int l = 1; ; l++)
        {
            Console.WriteLine("Введите оценки:");
            string s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out double x);
                if (x == 2 || x == 3)
                    c++;
            }
        }
          Console.WriteLine("stydentov {0:f2}", answer);
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