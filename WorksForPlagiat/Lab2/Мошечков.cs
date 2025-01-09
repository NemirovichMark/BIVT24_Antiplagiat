
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

        // code here
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
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
        if (a > 0)
        {
            if (a > b)
                answer = a;
            else answer = b;
        }
        else
        {
            if (a <= 0)
                if (a > b)
                    answer = b;
                else answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a >= b) answer = b;

        else answer = a;

        if (c >= answer) answer = c;


        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double dround = 0;
        double dsquare = 0;

        dsquare = Math.Sqrt(s * 2);
        dround = 2 * Math.Sqrt(r / Math.PI);
        if (dsquare <= dround)
            answer = true;


        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double dround = 0;
        double a = 0;

        a = Math.Sqrt(s);
        dround = 2 * Math.Sqrt(r / Math.PI);
        if (a >= dround)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) > 1) answer = 1;
        else
            answer = Math.Abs(x);

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if ((Math.Abs(x) >= 1)) answer = 0;
        else answer = x * x - 1;

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        if (-1 < x && x <= 0) answer = 1 + x;
        if (x > 0) answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1; //ìîæíî óáðàòü ýòó ñòðîêó // наверное тут было что то важное
        if (-1 < x && x <= 1) answer = -1 * x;
        if (x > 1) answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        int i = 0;
        double sum = 0;
        double N = 0;
        while (i < n)
        {
            N = double.Parse(Console.ReadLine());
            if (N == 0) break;
            else
            {
                sum = sum + N;
                i++;
            }
        }
        answer = sum / i;
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                answer++;
            else continue;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (x < 30)
                answer += 0.2;
            else continue;
        }

        Console.WriteLine(answer);
        Console.ReadLine();
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
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                answer++;
            else continue;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double x = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (x <= norm)
                answer++;
            else continue;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here

        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y >= 0)
                answer++;
            else continue;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
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
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("точка лежит в первом квадранте");
            }
            if (x < 0 && y > 0)
                Console.WriteLine("точка лежит во втором квадранте");
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("точка лежит в третьем квадранте");
            }
            if (x > 0 && y < 0)
                Console.WriteLine("точка лежит в четвертом квадранте");
        }
        Console.WriteLine($"{answer1}, {answer3}");
        Console.ReadLine();
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;

        double min = double.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x * x + y * y < min)

            {
                answer = i;
                min = x * x + y * y;
            }


        }
        answerLength = Math.Round(Math.Sqrt(min), 2);

        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        Console.ReadLine();
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here


        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x < answer)
                answer = x;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            int m1 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m2 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m3 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m4 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
                answer++;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            int m1 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m2 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m3 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            int m4 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (m1 < 3 || m2 < 3 || m3 < 3 || m4 < 3)
                answer++;
            avg = avg + m1 + m2 + m3 + m4;


        }
        avg = avg / 4 / n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        Console.ReadLine();
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r < 0) return answer;
        else
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round(r * r, 2);
                    break;
                case 1:
                    answer = Math.Round(r * r * Math.PI, 2);
                    break;
                case 2:
                    answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2);
                    break;
                default:
                    answer = 0;
                    break;
            }
        }

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A <=0 || B<=0 ) answer=0;
        else
        { 
            switch (type)
            {
                case 0:
                    answer = Math.Round(A * B, 2);
                    break;
                case 1:
                    answer = Math.Round(Math.Abs(A * A - B * B) * Math.PI, 2);
                    break;
                case 2:
                    
                    answer = Math.Round((A * Math.Sqrt(B * B - (A * A) / 4)) / 2, 2);
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here


        int n = 0;
        double sum = 0, H = 0;

        do

        {
            Console.WriteLine("Enter heights. Ener 0 to finish.");
            string input = Console.ReadLine();
            bool result = double.TryParse(input, out H);
            if (result == true && H != 0)
            {
                sum += H;
                n++;
            }
            else continue;
        }
        while (H != 0);
        answer = sum / n;
        Console.WriteLine(answer);
        Console.ReadLine();
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

        // code here
        double x, y = 0;

        while (true)

        {
            Console.WriteLine("Enter X, Y . Enter stop to finish ");
            string input = Console.ReadLine();
            if (input == "stop") break;

            bool result_x = double.TryParse(input, out x);
            bool result_y = double.TryParse(input, out y);
            if (result_x == false || result_y == false)
                continue;
            else if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                answer++;
            else continue;

        }


        Console.WriteLine(answer);
        Console.ReadLine();
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

        // code here


        while (true)

        {

            double x, y;
            Console.WriteLine("Enter X, Y . Enter stop to finish");
            string input_x = Console.ReadLine();
            if (input_x == "stop") break;
            string input_y = Console.ReadLine();


            bool result_x = double.TryParse(input_x, new CultureInfo("en-US"), out x);
            bool result_y = double.TryParse(input_y, new CultureInfo("en-US"), out y);
            if (result_x == false || result_y == false || x == 0 || y == 0)
                continue;
            else
            {
                if (x > 0 && y > 0)
                    answer1++;
                if (x < 0 && y < 0)
                    answer3++;
            }
        }
        Console.WriteLine($"{answer1}, {answer3}");
        Console.ReadLine();


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

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;


        int m1, m2, m3, m4;
        while (true)

        {
            Console.WriteLine(" enter marks. enter stop to finish ");
            string input_m1 = Console.ReadLine();
            if (input_m1 == "stop") break;
            string input_m2 = Console.ReadLine();
            string input_m3 = Console.ReadLine();
            string input_m4 = Console.ReadLine();

            bool result_m1 = int.TryParse(input_m1, new CultureInfo("en-US"), out m1);
            bool result_m2 = int.TryParse(input_m2, new CultureInfo("en-US"), out m2);
            bool result_m3 = int.TryParse(input_m3, new CultureInfo("en-US"), out m3);
            bool result_m4 = int.TryParse(input_m4, new CultureInfo("en-US"), out m4);
            if (result_m1 == false || result_m2 == false || result_m3 == false || result_m3 == false)
                continue;
            else

            {
                if (m1 < 3 || m2 < 3 || m3 < 3 || m4 < 3)
                    answer++;
                avg = avg + m1 + m2 + m3 + m4;
            }

            n++;
        }
        Convert.ToDouble(avg);
        avg = avg / 4 / n;

        Console.WriteLine(answer);
        Console.WriteLine(avg);
        Console.ReadLine();
        // end

        return (answer, avg);

    }
    #endregion
}