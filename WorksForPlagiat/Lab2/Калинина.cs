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
        int r = 2; 
        if (Math.Abs(x*x + y*y - r * r) <= 0.001)
        {
            answer = true;
            Console.WriteLine("Лежит");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не лежит");
        }

        // code here

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if ((y + Math.Abs(x)) <= 1 && y >= 0)
        {
            answer = true;
            Console.WriteLine("Пренадлежит");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не пренадлежит");
        }

        // code here

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        double c;

        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else c = b;
        }
        else
        {
            if (a>b)
            {
                c = b;
            }
            else c = a;
        }

        answer = c;
        // code here

        Console.WriteLine(c);

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double z, k;

        if (a > b)
        {
            k = b;
        }
        else k = a;

        if (k > c)
        {
            z = k;
        }

        else z = c;

        // code here

        answer = z;

        Console.WriteLine(z);

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double d = Math.Sqrt(s/2);
        double rad = Math.Sqrt(r / Math.PI);

        if (d <= rad)
        {
            answer = true;
            Console.WriteLine("Поместится");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не поместится");
        }


        // code here

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double rad = Math.Sqrt(r / Math.PI);
        double n = Math.Sqrt(s) / 2;

        if(rad <= n)
        {
            answer = true;
            Console.WriteLine("Поместится");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не поместится");
        }
        
        // code here

        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        double y;

        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else y = Math.Abs(x);

        answer = y;


        // code here

        Console.WriteLine(y);

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double y;

        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else y = x * x - 1;

        answer = y;

        // code here

        Console.WriteLine(y);

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        double y;

        if (x <= -1)
        {
            y = 0;
        }
        else if (x > -1 && x <= 0)
        {
            y = 1 + x;
        }
        else y = 1;

        answer = y;
        // code here

        Console.WriteLine(y);

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        double y;

        if (x <= -1)
        {
            y = 1;
        }

        else if (x>-1 && x <= 1)
        {
            y = -x;
        }
        else y = -1;

        answer = y;

        // code here

        Console.WriteLine(y);

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0, deti =0 ;
        

        for (int i = 1; i <= n; i+=1)
        {
            Console.WriteLine($"Введите рост ученика {i}:"); 
            double rost = Convert.ToDouble(Console.ReadLine());
            deti += rost;
        }
        answer = deti / n;

            // code here
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x;
        double y;

        for (int i = 1; i <= n; i+=1)
        {
            Console.Write($"Введите кординату x {i}:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите кординату y {i}:");
            y = Convert.ToDouble(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b) <= r * r))
            {
                answer += 1;
            }
        }

        // code here

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double m;

        for (int i = 1; i <= n; i+=1)
        {
            Console.WriteLine($"Введите массу ученика {i}:");
            m = Convert.ToDouble(Console.ReadLine());
            if (m < 30)
            {
                answer += 0.2;
            }
        }

        answer = Math.Round(answer, 1);
        // code here

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x;
        double y;

        for (int i = 1; i <= n; i+=1)
        {
            Console.Write($"Введите кординату x {i}:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите кординату y {i}:");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer += 1;
            }
        }
            // code here

        Console.WriteLine(answer);

            // end

            return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double vremy;

        for (int i = 1; i <= n; i += 1)
        {
            Console.Write($"Введите результат участника {i}:");
            vremy = Convert.ToDouble(Console.ReadLine());
            if (vremy <= norm)
            {
                answer += 1;
            }
        }
            // code here

            Console.WriteLine(answer);

            // end
        
            return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x; double y;

        for (int i = 1; i <= n; i += 1)
        {
            Console.Write($"Введите кординату x {i}:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите кординату y {i}:");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer += 1;
            }
        }

        Console.WriteLine(answer);

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        double x; double y;

        for (int i = 1; i <= n; i += 1)
        {
            Console.Write($"Введите кординату x {i}:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите кординату y {i}:");
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Находится в 1 квадранте");
                answer1 += 1;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Находится во 2 квадранте");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Находится во 3 квадранте");
                answer3 += 1;
            }
            else
            {
                Console.WriteLine("Находится в 4 квадранте");
            }

        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double g = 0;
        double x; double y;

        for (int i = 1; i <= n; i += 1)
        {
            Console.Write($"Введите кординату x {i}:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите кординату y {i}:");
            y = Convert.ToDouble(Console.ReadLine());
            g = Math.Sqrt(x * x + y * y);

            if (g < answerLength)
            {
                answerLength = g;
                answer = i;
            }
        }

        // code here

        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double result;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите результат спортсмена {i}:");
            result = Convert.ToDouble(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
            }
        }
        // code here

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int odin, dva, tri, hetire;

        for (int i = 1; i <= n; i++)
        {
            odin = Convert.ToInt32(Console.ReadLine());
            dva = Convert.ToInt32(Console.ReadLine());
            tri = Convert.ToInt32(Console.ReadLine());
            hetire = Convert.ToInt32(Console.ReadLine());

            if ((odin == 4 || odin == 5) && (dva == 4 || dva == 5) && (tri == 4 || tri == 5) && (hetire == 4 || hetire == 5))
            {
                answer += 1;
            }
        }

        // code here;

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int odin, dva, tri, hetire;
        double s = 0, m = 0;

        for (int i = 1; i <= n; i++)
        {
            odin = Convert.ToInt32(Console.ReadLine());
            dva = Convert.ToInt32(Console.ReadLine());
            tri = Convert.ToInt32(Console.ReadLine());
            hetire = Convert.ToInt32(Console.ReadLine());
            if (odin == 2 || dva == 2 || tri == 2 || hetire == 2)
            {
                answer += 1;
            }
            s = s + odin + dva + tri + hetire;
            m += 4;
        }
        avg = s / m;

        // code here;

        Console.WriteLine($"{answer}, {avg}");

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;


        if ((r < 0) || (type < 0) || (type > 2))
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
        }
        // end
        answer = Math.Round(answer, 2);

        // code here;

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if ((A < 0) || (type < 0) || (type > 2) || (B < 0) || (A >= 2 * B))
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A)) / 4;
                break;
        }
        answer = Math.Round(answer, 2);

        // code here;

        Console.Write(answer);

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        string vvod = "";
        double rost=0, deti = 0, k = 0;

        Console.WriteLine("введите Stop если хотите закончить");

        while (true)
        {
            Console.WriteLine("Введите рост:");
            vvod = Console.ReadLine();
            if (vvod == "Stop") break;
            else
            {
                rost = Convert.ToDouble(vvod);
                deti += rost;
                k += 1;
            }
        }
           answer = deti / k;
            

        // code here

        Console.WriteLine(answer);

        // end

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

        double x = 0, y = 0;
        string vvodx = "";
        string vvody = "";

        Console.WriteLine("введите Stop если хотите закончить");

        while (true)
        {
            Console.Write("Введите кординату x");
            vvodx = Console.ReadLine();
            Console.Write("Введите кординату y");
            vvody = Console.ReadLine();

            if (vvodx == "Stop" || vvody == "Stop") break;

            x = Convert.ToDouble(vvodx);
            y = Convert.ToDouble(vvody);

            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer += 1;
            }
        }

        Console.WriteLine(answer);

        // code here

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
        int answer1 = 0, answer3 = 0;

        double x = 0, y = 0;
        string vvodx = "";
        string vvody = "";

        Console.WriteLine("введите Stop если хотите закончить");

        while (true)
        {
            Console.Write("Введите кординату x");
            vvodx = Console.ReadLine();
            Console.Write("Введите кординату y");
            vvody = Console.ReadLine();

            if (vvodx == "Stop" || vvody == "Stop") break;

            x = Convert.ToDouble(vvodx);
            y = Convert.ToDouble(vvody);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Находится в 1 квадранте");
                answer1 += 1;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Находится во 2 квадранте");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Находится во 3 квадранте");
                answer3 += 1;
            }
            else
            {
                Console.WriteLine("Находится в 4 квадранте");
            }

        }
            // code here

         Console.WriteLine(answer1);
        Console.WriteLine(answer3);


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
        int answer = 0, n = 0;
        string vvod1 = "";
        string vvod2 = "";
        string vvod3 = "";
        string vvod4 = "";
        double odin, dva, tri, thatire;

        Console.WriteLine("введите Stop если хотите закончить");

        while (true)
        {
            Console.Write("Введите оценку за 1 экзамен");
            vvod1 = Console.ReadLine();
            Console.Write("Введите оценку за 2 экзамен");
            vvod2 = Console.ReadLine();
            Console.Write("Введите оценку за 3 экзамен");
            vvod3 = Console.ReadLine();
            Console.Write("Введите оценку за 4 экзамен");
            vvod4 = Console.ReadLine();

            if (vvod1 == "Stop" || vvod2 == "Stop" || vvod3 == "Stop" || vvod4 == "Stop") break;

            odin = Convert.ToDouble(vvod1);
            dva = Convert.ToDouble(vvod2);
            tri = Convert.ToDouble(vvod3);
            thatire = Convert.ToDouble(vvod4);

            if ((odin == 4 || odin == 5) && (dva == 4 || dva == 5) && (tri == 4 || tri == 5) && (thatire == 4 || thatire == 5))
            {
                answer += 1;
            }
        }

            // code here;

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