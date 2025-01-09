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
        program.Task_2_7(5);
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

        // code here
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 1 / 1000)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);
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
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0 && a > b)
        {
            c = a;
        }
        else if (a > 0 && a < b)
        {
            c = b;
        }
        else if (a <= 0 && a > b)
        {
            c = b;
        }
        else
        {
            c = a;
        }
        answer = c;
        Console.WriteLine(c);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z = 0;
        if (a < b && a > c)
        {
            z = a;
        }
        else if (a > b && b > c)
        {
            z = b;
        }
        else
        {
            z = c;
        }
        answer = z;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R, D;
        R = Math.Sqrt(r / Math.PI);
        D = Math.Sqrt(2 * s);
        if (D <= 2 * R)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R, a;
        R = Math.Sqrt(r / Math.PI);
        a = Math.Sqrt(s);
        if (R <= a / 2)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = x * x - 1;
        }
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 0;
        }
        else if (x > -1 && x <= 0)
        {
            y = 1 + x;
        }
        else
        {
            y = 1;
        }
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
        }
        else
        {
            y = -1;
        }
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sr, r, s = 0;
        Console.WriteLine("Введите рост учеников r");
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        sr = s / n;
        answer = sr;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        int k, i;
        k = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Введитек координаты х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты у");
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine($"В круг попало {k} точек из {n} ");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight, milk = 0; // вес, молоко
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите вес weight");
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                milk += 0.2;
            }
        }
        answer = milk;
        Console.WriteLine($"Ежедневно для одного класса, состоящего из {n} учеников потребуется {milk} литров молока");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        int k, i;
        k = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Введите х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите у");
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine($"В кольцо с внутренним радиусом {r1} и внешним {r2} попадёт {k} точек");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        int i, k = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Введите результаты участников");
            result = double.Parse(Console.ReadLine());
            if (result <= norm)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine($"Норматив сдали {k} участникa");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        int i, k = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Введите х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите у");
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y >= 0)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine($"{k} точки принадлежат фигуре");
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
        int i, k1 = 0, k3 = 0;
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Введите х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите у");
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0) //Первый квадрат
            {
                k1++;
                Console.WriteLine($"Точка с координатами ({x}, {y}) попала в первый квадрат");
            }
            else if (x < 0 && y > 0) //Второй квадрат
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) попала во второй квадрат");
            }
            else if (x < 0 && y < 0) //Третий квадрат
            {
                k3++;
                Console.WriteLine($"Точка с координатами ({x}, {y}) попала в третий квадрат");
            }
            else if (x > 0 && y < 0) //Четвёртый квадрат
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) попала в четвёртый квадрат");
            }
            else continue;

        }
        answer1 = k1;
        answer3 = k3;
        Console.WriteLine($"В первом квадрате - {k1}, в третьем - {k3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y, r = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите у");
            y = double.Parse(Console.ReadLine());
            r = Math.Sqrt(x * x + y * y);
            if (r < answerLength)
            {
                answerLength = r;
                answer = i;
            }
        }
        Console.WriteLine($"Hомер точки, ближайшей к началу координат - {answer} и величинa расстояния от нее до начала координат - {Math.Round(answerLength, 2)}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите результат");
            result = double.Parse(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
            }
        }
        Console.WriteLine($"Наилучший результат - {answer}");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int exam1, exam2, exam3, exam4, student = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите оценки");
            exam1 = int.Parse(Console.ReadLine());
            exam2 = int.Parse(Console.ReadLine());
            exam3 = int.Parse(Console.ReadLine());
            exam4 = int.Parse(Console.ReadLine());
            if ((exam1 == 4 || exam1 == 5) && (exam2 == 4 || exam2 == 5) && (exam3 == 4 || exam3 == 5) && (exam4 == 4 || exam4 == 5))
            {
                student++;
            }
        }
        answer = student;
        Console.WriteLine($"Всего {student} студентов не имеют двоек и троек");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0, number = 0;
        int exam1, exam2, exam3, exam4, student = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите оценки");
            exam1 = int.Parse(Console.ReadLine());
            exam2 = int.Parse(Console.ReadLine());
            exam3 = int.Parse(Console.ReadLine());
            exam4 = int.Parse(Console.ReadLine());
            if (exam1 == 2 || exam2 == 2 || exam3 == 2 || exam4 == 2)
            {
                student++;
            }
            sum += exam1 + exam2 + exam3 + exam4;
            number += 4;
        }
        avg = sum / number;
        answer = student;
        Console.WriteLine($"Неуспевающие студенты - {student}, средний балл группы - {avg}");
            // end

            // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        double s = 0;
        if (r < 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case 0:
                s = r * r; break;
            case 1:
                s = Math.PI * r * r; break;
            case 2:
                s = (r * r * Math.Sqrt(3)) / 4; break;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double s = 0;
        if (A <= 0 || B <= 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case 0:
                s = A * B;
                break;
            case 1:
                if (A > B)
                {
                    s = Math.Abs(Math.PI * ((A * A) - (B * B)));
                }
                else
                {
                    s = Math.Abs(Math.PI * ((B * B) - (A * A)));
                }
                break;
            case 2:
                s = Math.Sqrt(B * B - (A * A / 4)) * 0.5 * A;
                break;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
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
        while (true)
        {
            double x, y;
            int k = 0;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x == 0) break;
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                k++;
            }
            answer = k;
        }
        Console.WriteLine(answer);
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

        // code here
        int k = 0;
        while (true)
        {
            double result;
            double.TryParse(Console.ReadLine(), out result);
            if (result == 0) break;
            if (result <= norm)
            {
                k++;
            }
            answer = k;
        }
        Console.WriteLine(answer);
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
        while (true)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x == 0) break;
            double length = Math.Sqrt(x * x + y * y);
            if (length < answerLength)
            {
                answerLength = length;
                answer++;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer}, {answerLength}");
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
