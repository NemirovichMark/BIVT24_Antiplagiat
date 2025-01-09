using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = !answer;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = !answer;
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
            if (a < b)
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
        double min;
        if (a < b)
            min = a;
        else min = b;
        if (c > min)
            answer = c;
        else answer = min;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) * Math.Sqrt(2) <= 2 * (Math.Sqrt(r / Math.PI)))
            answer = !answer;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * (Math.Sqrt(r / Math.PI)) <= Math.Sqrt(s))
            answer = !answer;
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
        double r, s = 0;
        for (int i = 1; i <= n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s = s + r;
        }
        answer = s / n;
        // end
        //ПРАВИЛЬНО!!!!!!!
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
                answer++;
        }
        // end
        // правильно
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите вес ученика");
            double x = double.Parse(Console.ReadLine());
            if (x < 30)
                answer += 0.2;
        }
        // end
        // правильно
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2)
                answer++;
            // end
            //правильно
            // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        }
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите результат спортсмена");
            double x = double.Parse(Console.ReadLine());
            if (x < norm)
                answer++;
        }
        // end
        //правильно
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer++;
        }
        // end
        // правильно
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 1 квадранте");
                answer1++;
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 3 квадранте");
                answer3++;
            }
            else if (x < 0 && y > 0)
                Console.WriteLine("Точка находится во 2 квадранте.");
            else if (x > 0 && y < 0)
                Console.WriteLine("Точка находится в 4 квадранте.");
        }
        // end
        //правильно
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
            // end
            //правильно
            // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите результат");
            double time = double.Parse(Console.ReadLine());
            if (time < answer)
            {
                answer = time;
            }
        }
        // end
        //правильно
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("Введите оценки студента");
                double grade = double.Parse(Console.ReadLine());
                if (grade == 2 || grade == 3)
                    count++;
            }
            if (count == 0)
                answer++;
        }
            // end
            //правильно
            // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double score = 0.0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            double s = 0;
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("Введите оценки студента");
                double grade = double.Parse(Console.ReadLine());
                s += grade;
                if (grade == 2)
                    count++;
            }
            score += s / 4;
            avg = score / n;
            avg = Math.Round(avg, 2);
            if (count != 0)
                answer++;
        }
        // end
        //правильно
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

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
                answer = r * r;
                break;

            case 1:
                answer = Math.PI * r * r;
                break;

            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default: return 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;

            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;

            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A))/4;
                break;
            default: return 0;
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
        while (true)
        {
            Console.WriteLine("Введите x");
            string x = Console.ReadLine();
            Console.WriteLine("Введите y");
            string y = Console.ReadLine();
            if ((x == "" || x == null) && (y == "" || y == null))
            {
                break;
            }
            double x1, y1;
            double.TryParse(x, out x1);
            double.TryParse(y, out y1);
            if ((x1 - a) * (x1 - a) + (y1 - b) * (y1 - b) < r * r)
                answer++;
        }
        // end
        //правильно
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
        while (true)
        {
            Console.WriteLine("Введите результат спортсмена");
            string x = Console.ReadLine();
            if (x == "" || x == null)
                break;
            double x1;
            double.TryParse(x, out x1);
            if (x1 < norm)
                answer++;
        }
        // end
        // правильно
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
        int k = 0;

        // code here
        while (true)
        {
            k++;
            Console.WriteLine("Введите x");
            string x = Console.ReadLine();
            Console.WriteLine("Введите y");
            string y = Console.ReadLine();
            if ((x == "" || x == null) && (y == "" || y == null))
            {
                break;
            }
            double x1, y1;
            double.TryParse(x, out x1);
            double.TryParse(y, out y1);
            if (Math.Sqrt(x1 * x1 + y1 * y1) < answerLength)
            {
                answerLength = Math.Sqrt(x1 * x1 + y1 * y1);
                answer = k;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end
        // правильно
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
        double score = 0.0;
        string x;
        // code here;
        while (true)
        {
            int count = 0;
            double s = 0;
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("Введите оценки студента");
                x = Console.ReadLine();
                if (x == "" || x == null)
                {
                    if (j == 1)
                    {
                        return (answer, avg);
                    }
                    break;
                }
                double grade = double.Parse(x);
                s += grade;
                if (grade == 2)
                {
                    count++;
                }
            }
            n++;
            score += s / 4;
            if (count != 0)
            {
                answer++;
            }
            if (n > 0)
            {
                avg = score / n;
                avg = Math.Round(avg, 2);
            }
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

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
