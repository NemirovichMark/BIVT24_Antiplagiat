using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        //int n = 10;
        //double answer = 0;
        //int cnt = 0;
        //double sum = 0;
        //while (cnt < n)
        //{
        //    Console.Write("введите рост: ");
        //    double height = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
        //    sum += height;
        //    cnt++;
        //}
        //answer = sum / 10;
        //Console.Write("средний рост: ");
        //Console.Write(answer);

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
        //int cnt1 = 0;
        //int cnt2 = 0;

        //// Используем бесконечный цикл, чтобы принимать данные до тех пор, пока не иссякнет входной поток
        //while (true)
        //{
        //    // Пытаемся прочитать данные
        //    string line = Console.ReadLine();
        //    if (line == null) // Проверяем, иссяк ли входной поток
        //    {
        //        break;
        //    }

        //    // Разделяем данные на x и y
        //    string[] values = line.Split(' ');
        //    if (values.Length != 2)
        //    {
        //        Console.WriteLine("Ошибка: Ожидалось два числа на строке.");
        //        continue;
        //    }

        //    double x;
        //    double y;
        //    try
        //    {
        //        x = double.Parse(values[0], new CultureInfo("en-US"));
        //        y = double.Parse(values[1], new CultureInfo("en-US"));
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Ошибка: Неверный формат числа.");
        //        continue;
        //    }

        //    // Подсчитываем значения
        //    if (x > 0 && y > 0)
        //    {
        //        cnt1++;
        //    }
        //    if (x < 0 && y < 0)
        //    {
        //        cnt2++;
        //    }
        //}

        
        //Console.WriteLine(cnt1);
        //Console.WriteLine(cnt2);
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
        double num = Math.Pow(10, -3);
        if (Math.Abs(x * x + y * y - r * r) <= num)
        {
            answer = true;
        }
       
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double c = 0;
        if (a > 0)
        {
            if (a > b)
                c = a;
            else
                c = b;
        }
        else
        {
            if (a < b)
                c = a;
            else
                c = b;
        }

        return c;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double mx = 0;
        double mn = 0;
        if (a > b)
            mn = b;
        else
            mn = a;
        if (mn > c)
            mx = mn;
        else
            mx = c;

        return mx;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double diag = Math.Sqrt(2 * s);
        double diam = Math.Sqrt((4 * r) / Math.PI);
        if (diag <= diam) 
            answer = true;

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double side = Math.Sqrt(s);
        double diam = Math.Sqrt((4 * r) / Math.PI);
        if (diam <= side)
            answer = true;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double y = 0;

        if (Math.Abs(x) > 1)
            y = 1;
        else
            y = Math.Abs(x);

        return y;
    }
    public double Task_1_8(double x)
    {
        double y = 1;

        if (Math.Abs(x) >= 1)
            y = 0;
        else
            y = x * x - 1;

        return y;
    }
    public double Task_1_9(double x)
    {
        double y = 0;
        if (x <= -1)
            y = 0;
        if (x > -1 && x <= 0)
            y = 1 + x;
        if (x > 0)
            y = 1;

        return y;
    }
    public double Task_1_10(double x)
    {
        double y = 0;
        if (x <= -1)
            y = 1;
        else if (x > -1 && x <= 1)
            y = -x;
        else if (x > 1)
            y = -1;

        return y;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        n = 10;
        int cnt = 0;
        double sum = 0;
        while (cnt < n)
        {
            Console.Write("введите рост: ");
            double height = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            sum += height;
            cnt++;
        }
        answer = sum / 10;
        Console.Write("средний рост: ");
        Console.Write(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        n = int.Parse(Console.ReadLine());
        r = int.Parse(Console.ReadLine());
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);

        return cnt;
    }
    public double Task_2_3(int n)
    {

        n = int.Parse(Console.ReadLine());
        double total = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("введите вес: ");
            double weight = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (weight < 30)
            {
                total += 0.2;
            }
            else
                continue;
        }

        Console.WriteLine(total);

        return total;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        int cnt = 0;
        n = int.Parse(Console.ReadLine());
        r1 = double.Parse(Console.ReadLine());
        r2 = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double distance = Math.Sqrt(x * x + y * y);
            if (distance >= r1 && distance <= r2)
                cnt++;

        }
        Console.WriteLine(cnt);

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
    

        n = int.Parse(Console.ReadLine());
        int cnt = 0;
        norm = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (res <= norm)
                cnt++;
            else
                continue;

        }
        Console.WriteLine(cnt);

        return cnt;
    }
    public int Task_2_6(int n)
    {
        n = int.Parse(Console.ReadLine());
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= Math.Sin(x)))
                cnt++;
        }
        Console.WriteLine(cnt);

        return cnt;
    }
    public (int, int) Task_2_7(int n)
    {
        n = int.Parse(Console.ReadLine());
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x > 0 && y > 0)
            {
                cnt1++;
                Console.WriteLine("Точка находится в 1 квандранте");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 2 квандранте");
            }
            else if (x < 0 && y < 0)
            {
                cnt2++;
                Console.WriteLine("Точка находится в 3 квандранте");
            }
            else
            {
                Console.WriteLine("Точка находится в 4 квандранте");
            }
        }
        Console.WriteLine(cnt1);
        Console.WriteLine(cnt2);

        return (cnt1, cnt2);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        n = int.Parse(Console.ReadLine());
        double minres = 100000;
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < minres)
            {
                minres = distance;
                num = i + 1;
            }
        }
        minres = Math.Round(minres, 2);
        Console.WriteLine(num);
        Console.WriteLine(minres);

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        n = int.Parse(Console.ReadLine());
        double bestres = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (res < bestres)
                bestres = res;
        }
        Console.WriteLine(bestres);

        return answer;
    }
    public int Task_2_10(int n)
    {


        n = int.Parse(Console.ReadLine());
        int cntstudents = 0;
        for (int i = 0; i < n; i++)
        {
            bool cnt23 = false;
            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3)
                {
                    cnt23 = true;
                    break;
                }
            }
            if (!cnt23)
            {
                cntstudents++;
            }

        }
        Console.WriteLine("Ответ:");
        Console.Write(cntstudents);


        return cntstudents;
    }
    public (int, double) Task_2_11(int n)
    {
        n = int.Parse(Console.ReadLine());

        int failingCount = 0;
        double totalScore = 0;

        for (int i = 0; i < n; i++)
        {
            double sumScores = 0;
            bool isFailing = false;

            for (int j = 0; j < 4; j++)
            {
                double score = double.Parse(Console.ReadLine());

                if (score == 2)
                {
                    isFailing = true;
                }

                sumScores += score;
            }
            if (isFailing)
            {
                failingCount++;
            }

            totalScore += sumScores / 4;
        }

        double averageScore = totalScore / n;

        Console.WriteLine(failingCount);
        Console.WriteLine(averageScore);


        return (failingCount, averageScore);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;

            }
        }
        answer = Math.Round(answer, 2);
    
        return answer;

    }
    public double Task_2_13(double A, double B, int type)
    {

        double answer = 0;
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
        answer = Math.Round(answer, 2);
        answer = Math.Abs(answer);

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double avg ;
        double totalHeight = 0;
        int studentcnt = 0;
        Console.WriteLine("Введите рост ученика. Для завершения ввода введите 'stop':");
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stop")
                break;
            else
            {
                double height = double.Parse(input);
                totalHeight += height;
                studentcnt++;
            }
        }
        avg = totalHeight / studentcnt;
        Console.WriteLine($"Средний рост учеников: {avg:F2}");

        // answer should be equal to the task_2_1 answer
        return avg;
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

        int cnt = 0;
        r1 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
        r2 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "stop")
                break;
            double x = double.Parse(line, new CultureInfo("en-US"));
            line = Console.ReadLine();
            if (line == "stop")
                break;
            double y = double.Parse(line, new CultureInfo("en-US"));
            double distance = Math.Sqrt(x * x + y * y);
            if (distance >= r1 && distance <= r2)
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);

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

        int countQuadrant1 = 0;
        int countQuadrant3 = 0;
        string stopWord = "exit";

        Console.WriteLine("Введите координаты точек в формате 'x y'. Для завершения ввода введите 'exit':");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == stopWord)
            {
                break;
            }

            string[] coordinates = input.Split(' ');
            double x = double.Parse(coordinates[0], new CultureInfo("en-US"));
            double y = double.Parse(coordinates[1], new CultureInfo("en-US"));
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 1-м квадранте.");
                countQuadrant1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во 2-м квадранте.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 3-м квадранте.");
                countQuadrant3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 4-м квадранте.");
            }
        }
        Console.WriteLine($"Количество точек, находящихся по отдельности в 1-м квадранте: {countQuadrant1}");
        Console.WriteLine($"Количество точек, находящихся по отдельности в 3-м квадранте: {countQuadrant3}");

        return (countQuadrant1, countQuadrant3);
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

        int countStudentsWithoutBadMarks = 0;
        string input = Console.ReadLine();

        while (true)
        {
       
            if (input == "stop")
            {
                break;
            }

            int studentCount = int.Parse(input);

            for (int i = 0; i < studentCount; i++)
            {
                bool hasBadMark = false;

                for (int j = 0; j < 4; j++)
                {
                    int mark = int.Parse(Console.ReadLine());
                    if (mark == 2 || mark == 3)
                    {
                        hasBadMark = true;
                        break;
                    }
                }

                if (!hasBadMark)
                {
                    countStudentsWithoutBadMarks++;
                }
            }
        }

        Console.WriteLine(countStudentsWithoutBadMarks);

        return countStudentsWithoutBadMarks;
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