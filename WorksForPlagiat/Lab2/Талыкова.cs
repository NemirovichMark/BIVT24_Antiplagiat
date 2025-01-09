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
        //program.Task_1_1(1, 1);
        //program.Task_1_2(0, 2);
        //program.Task_1_3(0.5, 0.25);
        //program.Task_1_4(0, 2, -2);
        //program.Task_1_5(0.86, 0.74);
        //program.Task_1_6(3.2, 3.5);
        //program.Task_1_7(0.9);
        //program.Task_1_8(3);
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
        int r = 2;
        // code here
        if (Math.Abs( x*x + y*y - r*r ) <= 0.0001)
            answer = true;
        else
            answer = false;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ( y>=0 &&  y+Math.Abs(x)<=1 )
            answer = true;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a < b) 
                answer = b;
            else
                answer = a;
        }
        else
        {
            if (a < b)
                answer = a;
            else
                answer = b;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0, m = 0;

        // code here
        if (a > b)
            m = b;
        else
            m = a;
        if (m>c)
            answer = m;
        else
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double rKryg = 1, rKvad = 1;
        // code here r = pi * rKrug*rKrug ; s = a*a = (2r)*(2r) = 4*r*r
        rKryg = Math.Sqrt(r / Math.PI);
        rKvad = Math.Sqrt(s / 4) * Math.Sqrt(2);
        if ( rKryg >= rKvad )
            answer = true;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double rKryg = 1, rKvad = 1;
        // code here r = pi * rKrug*rKrug ; s = a*a = (2r)*(2r) = 4*r*r
        rKryg = Math.Sqrt(r / Math.PI);
        rKvad = Math.Sqrt(s / 4);
        if (rKryg <= rKvad)
            answer = true;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if ( Math.Abs(x)>1 )
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
        if (Math.Abs(x) < 1)
            answer = x*x - 1;
        else
            answer = 0;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x <= 0 && x > -1)
            answer = 1 + x;
        else if (x > 0)
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
        else if (x <= 1 && x > -1)
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
        double answer = 0, k = 1, a = 0;

        // code here

        while (k<=n)
        {
            Console.Write($"{k}. Рост ученика: ");
            double.TryParse(Console.ReadLine(), out a);
            answer += a; 
            k++;
        }        
        answer = answer / n;
        Console.WriteLine(answer);

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0, k = 0;
        double x = 0, y = 0;

        // code here
        Console.Write("Введите длину радиуса: ");
        double.TryParse(Console.ReadLine(), out r);
        Console.WriteLine("Введите координаты центра: ");
        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out b);
        Console.Write("Введите количество точек: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Координаты {k+=1}: ");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            n--;
            if ( (a-x)*(a-x) + (b-y)*(b-y) <= r*r )
            {
                answer += 1;
            }
        }
        Console.Write($"Ответ: {answer}");

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, k = 0, ves = 0;

        // code here

        Console.Write("Количество учеников: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0) 
        {
            Console.Write($"Ученик {k+=1}: ");
            double.TryParse(Console.ReadLine(), out ves);
            n--;
            if (ves < 30)
                answer += 0.2;
        }
        Console.Write($"Понадобится {answer} литр(-ов/-а) молока ");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0, k = 0;
        double x = 0, y = 0;

        // code here

        Console.Write("Количество точек: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Радиус 1: ");
        double.TryParse(Console.ReadLine(), out r1);
        Console.Write("Радиус 2: ");
        double.TryParse(Console.ReadLine(), out r2);
        while (n > 0)
        {
            Console.WriteLine($"Координаты точки {k += 1}: ");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            n--;
            if ((Math.Sqrt(x * x + y * y) >= r1) && (Math.Sqrt(x * x + y * y) <= r2))
                answer += 1;
        }
        Console.Write($"В кольцо попало {answer} точек(-ка/-ки)");

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0, k = 0;
        double result = 0;
        // code here

        Console.Write("Количество участников: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Норматив составляет: ");
        double.TryParse(Console.ReadLine(), out norm);
        while (n > 0)
        {
            Console.WriteLine($"Результат участника {k += 1}: ");
            double.TryParse(Console.ReadLine(), out result);
            n--;
            if ( result >= norm )
                answer += 1;
        }
        Console.Write($"Норматив выполнили {answer} участник(-а/-ов)");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0, k = 0;
        double x = 0, y = 0;

        // code here

        Console.Write("Количество точек: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Координаты точки {k += 1}: ");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            n--;
            if ( x < 3.14 && x >= 0 && y <= Math.Sin(x) && y >= 0 )
                answer += 1;
        }
        Console.Write($"В фигуру попало {answer} точек(-ка/-ки)");

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int k = 0;
        double x = 0, y = 0;

        // code here

        Console.Write("Количество точек: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Координаты точки {k += 1}: ");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            n--;
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Точка {k} в 1-м квадранте");
                answer1 += 1;
            }
            if (x > 0 && y < 0)
                Console.WriteLine($"Точка {k} во 2-м квадранте");
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"Точка {k} в 3-м квадранте");
                answer3 += 1;
            }
            if (x < 0 && y > 0)
                Console.WriteLine($"Точка {k} в 4-м квадранте");
            if (x == 0 && y > 0)
                Console.WriteLine($"Точка {k} в 1-м и во 2-м квадрантах");
            if (x == 0 && y < 0)
                Console.WriteLine($"Точка {k} в 3-м и в 4-м квадрантах");
            if (y == 0 && x > 0)
                Console.WriteLine($"Точка {k} в 1-м и в 4-м квадрантах");
            if (y == 0 && x < 0)
                Console.WriteLine($"Точка {k} во 2-м и в 3-м квадрантах");
            if (y == 0 && x == 0)
                Console.WriteLine($"Точка {k} лежит в начале координат");
        }
        Console.WriteLine($"Точек в 1-м квадранте: {answer1}");
        Console.WriteLine($"Точек в 3-м квадранте: {answer3}");

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        int k = 0;
        double x = 0, y = 0;

        // code here

        Console.Write("Количество точек: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Координаты точки {k += 1}: ");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            n--;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = k;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"Точка {answer} на мин. расстоянии {answerLength}");

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue, a = 0;
        int k = 0;

        // code here

        Console.Write("Количество участников: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.Write($"Результат участника {k += 1}: ");
            double.TryParse(Console.ReadLine(), out a);
            n--;
            if ( a < answer )
            {
                answer = a;
            }
        }
        Console.WriteLine($"Лучший результат {answer}");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, k = 0, o1 = 0, o2 = 0, o3 = 0, o4 = 0;

        // code here;

        Console.Write("Количество студентов: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Оценки студента {k += 1}: ");
            int.TryParse(Console.ReadLine(), out o1);
            int.TryParse(Console.ReadLine(), out o2);
            int.TryParse(Console.ReadLine(), out o3);
            int.TryParse(Console.ReadLine(), out o4);
            n--;
            if (o1 > 3 && o2 > 3 && o3 > 3 && o4 > 3)
                answer++;
        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0, k = 0, o1 = 0, o2 = 0, o3 = 0, o4 = 0;
        double avg = 0.0;

        // code here;

        Console.Write("Количество студентов: ");
        int.TryParse(Console.ReadLine(), out n);
        while (n > 0)
        {
            Console.WriteLine($"Оценки студента {k += 1}: ");
            int.TryParse(Console.ReadLine(), out o1);
            int.TryParse(Console.ReadLine(), out o2);
            int.TryParse(Console.ReadLine(), out o3);
            int.TryParse(Console.ReadLine(), out o4);
            n--;
            avg += (o1 + o2 + o3 + o4)/4;
            if (o1 == 2 | o2 == 2 | o3 == 2 | o4 == 2)
                answer++;
        }
        avg = Math.Round(avg / k, 2);
        Console.WriteLine($"Неуспевающих студентов: {answer}");
        Console.WriteLine($"Средний балл группы: {avg}");

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        
        double answer = 0;
        // code here;
        
        if (r <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:
                answer = r * r; break;
            case 1:
                answer = Math.PI * r * r; break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4; break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        
        
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A <= 0 || B <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:
                answer = A * B; break;
            case 1:
                answer = Math.Abs((Math.PI * A * A) - (Math.PI * B * B)); break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                if (answer <= 0) 
                    return 0; 
                break;
        }
        answer = Math.Round(answer, 2);
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0, ves = 0;
        int n = 0;

        // code here

        Console.WriteLine("Для конца нажмите Enter");
        do
        {
            Console.Write($"Вес ученика {n += 1}: ");
            double.TryParse(Console.ReadLine(), out ves);
            if (ves < 30 && ves > 0)
                answer += 0.2;
        } while (ves > 0);

        Console.WriteLine($"Понадобится {answer} литр(-ов/-а) молока ");

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

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        double x = 0, y = 0;

        // code here

        do
        {
            Console.WriteLine("Чтобы закончить, введите х=1000 и у=1000");
            Console.WriteLine($"Координаты точки {n += 1}: ");
            Console.Write("х = ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("у = ");
            double.TryParse(Console.ReadLine(), out y);

            if (x < 3.14 && x >= 0 && y <= Math.Sin(x) && y >= 0)
                answer += 1;
        } while (x != 1000 && y != 1000);
        Console.WriteLine($"В фигуру попало {answer} точек(-ка/-ки)");

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

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue, a = 0;
        int n = 0;

        // code here

        Console.WriteLine("Для конца нажмите Enter");
        do
        {
            Console.Write($"Результат участника {n += 1}: ");
            double.TryParse(Console.ReadLine(), out a);
            
            if (a < answer && a > 0)
            {
                answer = a;
            }
        } while (a > 0);

        Console.WriteLine($"Лучший результат: {answer}");

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
