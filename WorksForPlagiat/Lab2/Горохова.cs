using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO.Compression;
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
        program.Task_2_7(5);
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

        // code here

        if (Math.Abs(x * x + y * y - 4) <= 0.001)
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
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
            if (a > b)
            {
                answer = a;
            }
            if (a <= b)
            {
                answer = b;
            }
        }
        if (a <= 0)
        {
            if (a < b)
            {
                answer = a;
            }
            if (a >= b)
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
        double mn = 0;
        if (a < b)
        {
            mn = a;
        }
        if (a >= b)
        {
            mn = b;
        }
        if (mn > c)
        {
            answer = mn;
        }
        if (mn <= c)
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double dk = 0, dO = 0;
        dO = Math.Sqrt(r / Math.PI) * 2;
        dk = Math.Sqrt(2 * s);
        if (dk <= dO)
        {
            answer = true;
        }
        if (dk > dO)
        {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double sk = 0, ro = 0;
        sk = Math.Sqrt(s);
        ro = Math.Sqrt(r / Math.PI) * 2;
        if (ro <= sk)
        {
            answer = true;
        }
        if (ro > sk)
        {
            answer = false;
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
        if (Math.Abs(x) <= 1)
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
        if (x > -1 && x <= 0)
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
        if (x > -1 && x <= 1)
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

        // code here
        double r;
        for (int i = 1; i <= n; i++)
        {
            string q = Console.ReadLine();
            r = double.Parse(q, new CultureInfo("en-US"));

            answer += r;
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x, y;
        int i, k;
        k = 0;
        for (i = 1; i < n; i++)
        {
            Console.WriteLine("¬ведите x");
            string q = Console.ReadLine();
            x = double.Parse(q, new CultureInfo("en-US"));
            Console.WriteLine("¬ведите y");
            string p = Console.ReadLine();
            y = double.Parse(q, new CultureInfo("en-US"));
            if (x * x + y * y < r * r) k++;
        }
        Console.WriteLine("¬ круг попало {0} точек из {1} ", k, n);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double x;
        double m = 0.2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите x");
            string input = Console.ReadLine();
            x = double.Parse(input, new CultureInfo("en-US"));
            if (x < 30)
            {
                answer += m;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите x");
            string p = Console.ReadLine();
            x = double.Parse(p, new CultureInfo("en-US"));
            Console.WriteLine("¬ведите y");
            string q = Console.ReadLine();
            y = double.Parse(q, new CultureInfo("en-US"));
            if (x * x + y * y < r2 * r2)
            {
                if (x * x + y * y > r1 * r1)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rez;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите результат");
            string p = Console.ReadLine();
            rez = double.Parse(p, new CultureInfo("en-US"));
            if (rez <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y, k;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите x");
            string p = Console.ReadLine();
            x = double.Parse(p, new CultureInfo("en-US"));
            Console.WriteLine("¬ведите y");
            string q = Console.ReadLine();
            y = double.Parse(q, new CultureInfo("en-US"));
            if (x >= 0 && y > 0)
            {

                if (y <= Math.Sin(x) && x <= Math.PI)
                {
                    answer++;
                }
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

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите x");
            string p = Console.ReadLine();
            x = double.Parse(p, new CultureInfo("en-US"));
            Console.WriteLine("введите y");
            string q = Console.ReadLine();
            y = double.Parse(q, new CultureInfo("en-US"));
            if (x >= 0 && y >= 0)
            {
                answer1++;
                Console.WriteLine("точка попала в первый квадрант");
            }
            if (x <= 0 && y <= 0)
            {
                answer3++;
                Console.WriteLine("точка попала в третий квадрант");
            }
            if (x <= 0 && y >= 0)
            {
                Console.WriteLine("точка попала во второй квадрант");
            }
            if (x >= 0 && y <= 0)
            {
                Console.WriteLine("точка попала в четвертый квадрант");
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
        double x, y, gipot;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("введите x");
            string p = Console.ReadLine();
            x = double.Parse(p, new CultureInfo("en-US"));
            Console.WriteLine("введите y");
            string q = Console.ReadLine();
            y = double.Parse(q, new CultureInfo("en-US"));
            gipot = Math.Sqrt(x * x + y * y);
            if (gipot <= answerLength)
            {
                answerLength = gipot;
                answer = i;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double rez;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите результат");
            string p = Console.ReadLine();
            rez = double.Parse(p, new CultureInfo("en-US"));
            if (rez <= answer)
            {
                answer = rez;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        double k = n * 4;
        while (k != 0)
        {
            bool otl = true;
            Console.WriteLine("введите оценки");
            for (int i = 0; i <= 3; i++)
            {
                int o = int.Parse(Console.ReadLine());
                if (otl && (o == 2 || o == 3))
                {
                    otl = false;
                }
            }
            if (otl == true)
            {
                answer++;
            }
            k = k - 4;
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
        int k = n * 4;
        int sum = 0;
        while (k != 0)
        {
            bool otl = true;
            Console.WriteLine("введите оценки");
            for (int i = 0; i <= 3; i++)
            {

                int o = int.Parse(Console.ReadLine());
                sum += o;
                if (otl == true && (o == 2))
                {
                    otl = false;
                }
            }
            if (otl == false)
            {
                answer++;
            }
            k = k - 4;
        }
        avg = sum / (n*4);

        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
      
        if (r <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                Console.WriteLine(answer);
                break;
            case 1:
                answer = Math.PI * r * r;
                Console.WriteLine(answer);
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                Console.WriteLine(answer);
                break;
            default:
                Console.WriteLine("неверно");
                break;
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
        
        if (A <= 0 || B <= 0)
            return 0;
        switch(type)
        {
            case 0:
                answer = A * B;
                Console.WriteLine(answer);
                break;
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                Console.WriteLine(answer);
                break;
            case 2:
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                Console.WriteLine(answer);
                break;
            default:
                Console.WriteLine("неверно");
                break;
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

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        Console.WriteLine("дл€ окончани€ ввода введите x = 1000");
        double x=0, y=0;
        while (x < 1000)
        {
            Console.WriteLine("¬ведите x");
            string q = Console.ReadLine();
            x = double.Parse(q, new CultureInfo("en-US"));
            Console.WriteLine("¬ведите y");
            string p = Console.ReadLine();
            y = double.Parse(p, new CultureInfo("en-US"));
            if (x * x + y * y < r * r)
            {
                answer++;
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

        // code here
        double x = 0;
        while (x < 1000)
        {
            Console.WriteLine("¬ведите rez");
            string q = Console.ReadLine();
            double rez = double.Parse(q, new CultureInfo("en-US"));
            
            if (rez <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine("¬ыполнили норматив {0} участников", answer);
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
        double x, y, gipot;
        int k = 0;
        while (k < 1000)
        {
            Console.WriteLine("¬ведите x");
            string q = Console.ReadLine();
            x = double.Parse(q, new CultureInfo("en-US"));
            Console.WriteLine("¬ведите y");
            string p = Console.ReadLine();
            y = double.Parse(p, new CultureInfo("en-US"));
            gipot = Math.Sqrt(x * x + y * y);
            if (gipot <= answerLength)
            {
                answerLength = gipot;
                answer = k;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
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
        int k = n * 4;
        int sum = 0;
        while (k > -1000)
        {
            bool otl = true;
            Console.WriteLine("введите оценки");
            for (int i = 0; i <= 3; i++)
            {

                int o = int.Parse(Console.ReadLine());
                sum += o;
                if (otl == true && (o == 2))
                {
                    otl = false;
                }
            }
            if (otl == false)
            {
                answer++;
            }
            k = k - 4;
        }
        avg = sum / (n * 4);

        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}