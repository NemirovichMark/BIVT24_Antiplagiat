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
        if ((y>=0)&&(y+Math.Abs(x)<=1))
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
            answer = b >= a ? b : a;
        } else
        {
            answer = b >= a ? a : b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double d = 0;
        d = a >= b ? b : a;
        answer = d >= c ? d : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        //r - площадь круга
        //s - площадь квадрата

        if ((s/2)<=(r/Math.PI))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if ((r/Math.PI)<=s/4)
        {
            answer = true;
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
        } else
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
        else
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
        else if (x > 0) { answer = 1; } else { answer = 1 + x; }
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
        else if (x > 1) { answer = -1; } else { answer = -x; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double height;
        double average_height;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out height);
            answer += height;
        }
        average_height = answer / n;
        Console.WriteLine($"Средний рост: {average_height}");
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;//кол-во точек попавших внутрь круга

        // code here
        double x, y;
        for(int i=1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;  
        }
        Console.WriteLine($"В круг попало {answer} точек");
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weigh;
        for(int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out weigh);
            if (weigh < 30) answer += 0.2;
        }
        Console.WriteLine($"{answer} литров молока потребуется на класс, состоящий из {n} учеников");
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        //предположим,что подразумевается кольцо с центром в (0,0)

        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            if ((x*x+y*y<=r2*r2)&&(x*x+y*y>=r1*r1)) answer++;
        }
        Console.WriteLine($"В кольцо попало {answer} точек");

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out result);
            if (result <= norm) answer++;//я считаю, что если спортсмен пробежал ровно за норму, то он справился с заданием
        }
        Console.WriteLine($"{answer} спортсменов выполнили норматив");
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            if ((y>=0)&&(y<=Math.Sin(x))&&(x>=0)&&(x<=Math.PI)) answer++;
        }
        Console.WriteLine($"В заданную область попало {answer} точек");

        // end

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
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            if (x >= 0)
            {
                if (y >= 0) 
                { 
                    answer1++; 
                    Console.WriteLine($"({x};{y}) находится в 1 квадранте"); 
                } else
                {
                    Console.WriteLine($"({x};{y}) находится в 4 квадранте");
                }
            }
            else
            {
                if(y >= 0)
                {
                    Console.WriteLine($"({x};{y}) находится во 2 квадранте");
                }
                else
                {
                    answer3++;
                    Console.WriteLine($"({x};{y}) находится в 3 квадранте");
                }
            }
        }
        Console.WriteLine($"В 1 квадранте {answer1} точек, в 3 квадранте {answer3} точек");

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            if (Math.Sqrt(x * x + y * y) <= answerLength) 
            { 
                answer = i; 
                answerLength= Math.Sqrt(x * x + y *y);
            }
        }
        Console.WriteLine($"Ближайшая точка к началу координат под номером {answer} на расстоянии {answerLength:f2}");

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double x;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            if (x <= answer)
            {
                answer = x;
            }
        }
        Console.WriteLine($"Лучший результат равен {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double x;
        int k;
        for (int i = 1; i <= n; i++)
        {
            k = 0;
            for (int j = 1; j <= 4; j++)
            {
                double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
                if ((x == 2) || (x == 3))
                {
                    k++;
                }
            }
            if (k == 0) answer++;
        }
        Console.WriteLine($"Число студентов, не имеющих '2' и '3' равно {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double x;
        int k;
        int successful_student = 0;
        double s1 = 0;
        double avg1 = 0.0;
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            k = 0;
            for (int j = 1; j <= 4; j++)
            {
                double.TryParse(Console.ReadLine(), out x);
                if ((x == 2))//неуспевающие - есть хотя бы одна двойка
                {
                    k++;
                }
                s1 += x;
            }
            if (k == 0) successful_student++;
            avg1 = s1 / 4;
            s += avg1;
        }
        avg = s / n;
        answer = n - successful_student;
        Console.WriteLine($"Число неуспевающих студентов равно {answer}");
        Console.WriteLine($"Средний балл группы {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        
        switch (type)
        {
            case 0:
                answer = r * r; break;
            case 1:
                answer = Math.PI * r * r; break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4; break;
            default:
                break;

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
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B; break;
            case 1:
                answer = Math.PI * Math.Abs(A*A-B*B); break;
            case 2:
                answer = 0.25 * A * Math.Sqrt(4 * B * B - A * A); break;
            default:
                break;
        }
        answer=Math.Round(answer, 2);
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
        double weigh;
        do
        {
            Console.WriteLine("Введите вес ученика, для окончания введите 0");
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out weigh);
            if (weigh <= 0) break;
            n++;
            if (weigh < 30) answer += 0.2;
        } while (weigh > 0);
        Console.WriteLine($"{answer} литров молока потребуется на класс, состоящий из {n} учеников");
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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        do
        {
            Console.WriteLine("Введите x, для окончания 100");
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
            if (x >= 100) break;
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
            n++;
            if ((y >= 0) && (y <= Math.Sin(x)) && (x >= 0) && (x <= Math.PI)) answer++;
        } while (x < 100);
        Console.WriteLine($"В заданную область попало {answer} точек из {n} точек");

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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        double x;
        do
        {
            Console.WriteLine("Введите x, для окончания 0");
            double.TryParse(Console.ReadLine(), out x);
            if (x <=0) break;
            n++;
            if (x <= answer)
            {
                answer = x;
            }
        } while (x > 0);
        Console.WriteLine($"Лучший результат равен {answer} среди {n} спортсменов");
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
