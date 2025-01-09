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
        //program.Task_2_3(6);
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
        program.Task_3_8();
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
        int r = 2;
        double cond = Math.Abs((x * x) + (y * y) - (r * r));
        double eps = 0.001;

        if (cond <= eps)
            return true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x) <= 1))
            return true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (b > a)
                answer = b;
            else
                answer = a;
        }
        else
        {
            if (b > a)
                answer = a;
            else
                answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        //double answer = 0;

        // code here
        double mn;

        if (a < b)
            mn = a;
        else
            mn = b;

        if (c > mn)
            return c;
        return mn;
        // end

        //return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double side_square = Math.Sqrt(s);

        if (side_square <= r)
            return true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double side_square = Math.Sqrt(s);
        double square_circle = 2 * Math.Sqrt(r / Math.PI);

        if (side_square >= square_circle)
            return true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            return 1;
        return Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            return 0;
        return x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            return 0;
        else if (x <= 0 && x > -1)
            return 1 + x;
        return 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            return 1;
        if (x > 1)
            return -1;
        return -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        int cnt = 0;
        double height = 0, average_height;

        for (int i = 1; i <= n; i++)
        {
            double height_stud;

            Console.WriteLine($"Введите рост ученика {i}");
            height_stud = double.Parse(Console.ReadLine());

            height += height_stud;
            cnt++;
        }
        average_height = height / cnt;
        Console.WriteLine(average_height);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x, y; 

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2)) <= r) answer++;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        double sum_weight = 0;
        int cnt = 0;

        for (int i = 1; i <= n; i++)
        {
            double weight_stud;

            Console.WriteLine($"Введите вес ученика {i}");
            weight_stud = double.Parse(Console.ReadLine());

            if (weight_stud < 30)
                cnt += 1;
        }
        answer = Math.Round(cnt * 0.2, 2);

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        /* n = 4;                                               */
        /* r1 = 1; // для проверки, чтобы не листать вверх      */
        /* r2 = 3;                                              */

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        for (int i = 0; i < n; i++)
        {
            double x, y, cond;

            string str_x = Console.ReadLine();
            string str_y = Console.ReadLine();

            double.TryParse(str_x, out x);
            double.TryParse(str_y, out y);

            cond = Math.Sqrt(x * x + y * y);
            if (cond >= r1 && cond <= r2) 
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        int cnt_sportsmen = 0;
        //norm = 30; n = 8;

        if (n == 0 || norm == 0)
            return 0;

        for (int i = 1; i <= n; i++)
        {
            double result;
            Console.WriteLine($"Введите результат {i} спорстмена:");
            result = double.Parse(Console.ReadLine());

            if (result < norm)
                answer++;

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        for (int i = 1; i <= n; i++)
        {
            double x, y;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) 
                answer++;
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
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 квадрант\n");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 квадрант\n");
            }
            else if (x > 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("4 квадрант\n");
            }
            else if (x < 0 && y > 0)
            {
                answer3++;
                Console.WriteLine("2 квадрант\n");
            }
        }
        Console.WriteLine($"В квадранте 1: {answer1}\nВ квадранте 3: {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        for (int i = 1; i <= n; i++)
        {
            double x, y;
            
            string str_x = Console.ReadLine();
            string str_y = Console.ReadLine();
            
            double.TryParse(str_x, out x);
            double.TryParse(str_y, out y);

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"Номер точки: {answer}\nРасстояние: {Math.Round(answerLength, 2)}");

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        double max_result = double.MaxValue;

        if (n <= 0)
            return 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите результат участника {i}");
            double res = double.Parse(Console.ReadLine());

            if (res < max_result)
                max_result = res;
        }

        Console.WriteLine(max_result);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int cnt_res = 0;

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;

            Console.WriteLine($"Введите оценки ученика {i}");
            for (int j = 1; j <= 4; j++)
            {                
                int res = int.Parse(Console.ReadLine());

                if (res == 2 || res == 3)
                    flag = false;
            }
            
            if (flag == true)
                cnt_res++;
        }
        Console.WriteLine($"Ответ - {cnt_res}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int cnt_no_stud = 0;
        double sum_res = 0;

        if (n <= 0)
            return (0, 0);

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;

            Console.WriteLine($"Введите оценки студента {i}");
            for (int j = 1; j <= 4; j++)
            {
                int res = int.Parse(Console.ReadLine());

                if (res <= 0)
                    return (0, 0);

                sum_res += res;

                if (res == 2 || res == 3)
                    flag = false;                
            }

            if (flag != true)
                cnt_no_stud++;
        }

        Console.WriteLine($"Кол-во неуспевающих студентов: {cnt_no_stud}\nСредний балл группы: {sum_res / (n * 4)}");

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        Console.WriteLine("\nВыберите тип фигуры:\n0. Квадрат\n1. Круг\n2. Равносторонний треугольник");
        if (r < 0)
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
                answer = r * r * Math.Sqrt(3) / 4;
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
        Console.WriteLine("\nВыберите тип фигуры:\n0. Прямоугольник\n1. Кольцо\n2. Равнобедренный треугольник");
        if (A <= 0 || B <= 0)
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
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
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

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        int cnt = 0;
        double height = 0, average_height;

        Console.WriteLine("Для завершения ввода введите 'STOP'");

        for (int i = 1; ; i++)
        {
            double height_stud;

            Console.WriteLine($"Введите рост ученика {i}");
            
            string str = Console.ReadLine();

            if (str == "STOP")
                break;

            double.TryParse(str, out height_stud);

            height += height_stud;
            cnt++;
        }
        average_height = height / cnt;
        Console.WriteLine(average_height);
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
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        Console.WriteLine("Для завершения ввода введите 'STOP'");

        int cnt_sportsmen = 0;


        if (norm == 0)
            return 0;

        for (int i = 1; ; i++)
        {
            double result;

            Console.WriteLine($"Введите результат {i} спорстмена:");

            string s = Console.ReadLine();

            if (s == "STOP")
                break;

             double.TryParse(s, out result);

            if (result < norm)
                answer++;

        }
        Console.WriteLine(answer);
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
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        Console.WriteLine("Для завершения ввода введите 'STOP'");

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        for (int i = 1; ; i++)
        {
            double x = 0, y = 0;

            string str_x = Console.ReadLine();
            string str_y = Console.ReadLine();

            if (str_x == "STOP" || str_y == "STOP")
                break;

            double.TryParse(str_x, out x);
            double.TryParse(str_y, out y);

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"Номер точки: {answer}\nРасстояние: {Math.Round(answerLength, 2)}");
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

        // end

        return (answer, avg);
    }
    #endregion
}