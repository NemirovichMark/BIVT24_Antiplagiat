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

        // code here
        double r = 2;
        if (Math.Abs(x*x + y*y - 4) <= 0.001)
            answer = true;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y > 0) & (y + Math.Abs(x) <= 1))
            answer = true;

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double itog = 0;
        if (a > 0)
        {
            if (a > b)
                itog = a;
            else
                itog = b;
        }
        else
        {
            if (a > b)
                itog = b;
            else
                itog = a;
        }
        answer = itog;   
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double itog = 0;
        if (a < b)
            itog = a;
        else
            itog = b;
        if (c > itog)
            answer = c;
        else
            answer = itog;


        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        s = Math.Sqrt(s);
        s = s * (Math.Sqrt(2) / 2);
        r = Math.Sqrt(r / Math.PI);
        if (s <= r)
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
        s = Math.Sqrt(s) / 2;
        r = Math.Sqrt(r / Math.PI);
        if (s >= r)
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
        else if ((x > -1) & (x <= 0))
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
        else if ((x > -1) & (x <= 1))
            answer = -x;
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

        // code here
        for (int i = 1; i <= n; i++)
            answer += Convert.ToDouble(Console.ReadLine());
        answer *= 0.1;
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        int chiclo;
        chiclo = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x - a <= r) & (y - b <= r) & ((x - a) * (x - a) + (y - b) * (y - b) <= r * r))
                chiclo += 1;
        }
        Console.WriteLine(chiclo);
        Console.ReadLine();
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double x;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 30)
                answer++;
        }
        answer *= 0.2;
        Console.WriteLine(Math.Round(answer,2));
        Console.ReadLine();
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x <= r2) & (y <= r2) & (x * x + y * y <= r2 * r2))
            {
                if ((x < r1) & (y < r1) & (x * x + y * y < r1 * r1))
                    answer = answer;
                else
                    answer++;


            }
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            if (Convert.ToDouble(Console.ReadLine()) >= norm)
                answer++;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) & (y >= 0) & (x <= Math.PI) & (y <= Math.Sin(x)))
                answer ++;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) & (y >= 0))
            {
                Console.WriteLine("Точка находится в 1 квадранте");
                answer1++;
            }
            if ((x <= 0) & (y >= 0))
                Console.WriteLine("Точка находится во 2 квадранте");
            if ((x <= 0) & (y <= 0))
            {
                Console.WriteLine("Точка находится в 3 квадранте");
                answer3++;
            }
            if ((x >= 0) & (y <= 0))
                Console.WriteLine("Точка находится в 4 квадранте");

        }

        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        Console.ReadLine();
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y; 
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine("Введите координату x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            y = Convert.ToDouble(Console.ReadLine());
            if (x*x + y*y < answerLength)
            {
                answerLength = Math.Sqrt(x*x + y*y);
                answer = i;
            }
        }
        if (n == 0)
        {
            answer = 0;
            answerLength = 0;
        }
            
        
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        Console.ReadLine();
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here\
        double per;
        for (int i = 1; i <= 0; i++)
        {
            per = Convert.ToDouble(Console.ReadLine());
            if (per < answer)
                answer = per;
        }

        // end
        if (n == 0)
            answer = 0;
        Console.WriteLine(answer);
        Console.ReadLine();
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int a, b, c, d;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите оценки " + i + "-ого ученика");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if ((a == 2) || (b == 2) || (c == 2) || (d == 2) || (a == 3) || (b == 3) || (c == 3) || (d == 3))
                answer = answer;
            else
            answer++;

        }
        Console.WriteLine("Количество учеников не получивших '2' и '3': " + answer);
        Console.ReadLine();
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int a, b, c, d;
        double summ;
        summ = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите оценки " + i + "-ого ученика");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if ((a == 2) || (b == 2) || (c == 2) || (d == 2))
                answer = answer;
            else
                answer++;
            summ += a + b + c + d;
        }
        answer = n - answer;
        summ /= 4 * n;
        avg = summ;
        Console.WriteLine("Количество отстающих учеников: " + answer);
        Console.WriteLine("Средний балл учеников: " + avg);
        Console.ReadLine();
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 3; i++)
        {
            if ((r < 0) || (type < 0) || (type > 2))
                answer = 0;
            else if (type == 0)
                answer = Math.Round(r * r, 2);
            else if (type == 1)
                answer = Math.Round(Math.PI * r * r, 2);
            else
                answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2);

        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 3; i++)
        {
            if ((A < 0) || (type < 0) || (type > 2) || (B < 0) || (A >= 2 * B))
                answer = 0;
            else if (type == 0)
                answer = Math.Round(A * B, 2);
            else if (type == 1)
                if (A > B)
                    answer = 0;
                else
                    answer = Math.PI * (Math.Abs(A * A - B * B));
            else
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4;

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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        int chiclo;
        string x1, y1;
        chiclo = 0;
        x = 0;
        y = 0;
        x1 = "";
        y1 = "";
        Console.WriteLine("Если захотите прекратить ввод, напишите 'стоп' два раза ");
        while ((x1 != "стоп") & (y1 != "стоп"))
        {
            Console.WriteLine("Введите координату x");
            x1 = Console.ReadLine();
            if (x1 != "стоп")
                x = Convert.ToDouble(x1);
            Console.WriteLine("Введите координату y");
            y1 = Console.ReadLine();
            if (y1 != "стоп")
                y = Convert.ToDouble(y1);
            if ((x - a <= r) & (y - b <= r) & ((x - a) * (x - a) + (y - b) * (y - b) <= r * r))
                chiclo += 1;
        }
        Console.WriteLine(chiclo);
        Console.ReadLine();
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        double a;
        a = 0;
        string a1 = "";
        // code here
        Console.WriteLine("Если захотите прекратить ввод, напишите 'стоп'");
        while (a1 != "стоп" )
        {
            a1 = Console.ReadLine();
            if (a1 != "стоп")
                a = Convert.ToDouble(a1);
            if (a >= norm)
                answer++;
            a = 0;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
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
        double x, y;
        string x1, y1;
        x1 = "";
        y1 = "";
        int i = 0;
        Console.WriteLine("Если захотите прекратить ввод, напишите 'стоп' два раза ");
        while ((x1 != "стоп") & (y1 != "стоп"))
        {
            Console.WriteLine("Введите координату x");
            x1 = Console.ReadLine();
            Console.WriteLine("Введите координату y");
            y1 = Console.ReadLine();
            
            if ((x1 != "стоп") & (y1 != "стоп"))
            {
                y = Convert.ToDouble(y1);
                x = Convert.ToDouble(x1);
                i++;
                if (x * x + y * y < answerLength)
                {
                    answerLength = Math.Round(Math.Sqrt(x * x + y * y), 2);
                    answer = i;
                }
            }
        }
        


        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        Console.ReadLine();
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
        int a, b, c, d, i;
        double summ;
        summ = 0;
        i = 1;

        string a1, b1, c1, d1;
        a1 = "";
        b1 = "";
        c1 = "";
        d1 = "";
        Console.WriteLine("Если захотите прекратить ввод, напишите 'с' 'т' 'о' 'п' ");
        while ((a1 != "с") &(b1 != "т") & (c1 != "о") & (d1 != "п"))
        {
            
            Console.WriteLine("Введите оценки " + i + "-ого ученика");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            c1 = Console.ReadLine();
            d1 = Console.ReadLine();
            if ((a1 != "с") & (b1 != "т") & (c1 != "о") & (d1 != "п"))
            {
                a = Convert.ToInt32(a1);
                b = Convert.ToInt32(b1);
                c = Convert.ToInt32(c1);
                d = Convert.ToInt32(d1);
                i++;
                if ((a == 2) || (b == 2) || (c == 2) || (d == 2))
                    answer = answer;
                else
                    answer++;
                summ += a + b + c + d;
            }
        }
        i--;
        if (i == 0)
        {
            answer = 0;
            avg = 0;
        }
        else
        {
            answer = i - answer;
            summ /= 4 * i;
            avg = summ;
        }
        Console.WriteLine("Количество отстающих учеников: " + answer);
        Console.WriteLine("Средний балл учеников: " + avg);
        Console.ReadLine();
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
