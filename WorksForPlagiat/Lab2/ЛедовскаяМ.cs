using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(8);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10,25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(4);
        //program.Task_2_8(4);
       //program.Task_2_9(10);
        //program.Task_2_10(6);
        //program.Task_2_11(8);
        // program.Task_2_12(10, 0);
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
        if (Math.Abs(x*x+y*y-r*r)<=(1/(10*10*10))) 
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y>=0) && (y+Math.Abs(x)<=1))
                answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
            if (a > b) answer = a;
            else answer = b;
        else
            if (a <b) answer = a;
            else answer = b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        // code here
        double mn = 0;
        if (a < b) mn = a;
        else mn=b;
        if (mn>c) answer= mn;
        else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        // code here
        double diameter = Math.Sqrt(r / Math.PI)*2;
        double diagonal = Math.Sqrt(2) * Math.Sqrt(s);
        if (diagonal <= diameter) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diameter = Math.Sqrt(r / Math.PI) * 2;
        double side= Math.Sqrt(s);
        if (side >= diameter) answer = true;
        // end
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if ((x>-1)&&(x<=0)) answer=1+x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if ((x > -1) && (x <= 1)) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        // code here
        int counter = 0;
        double summa = 0;
        while (counter < n)
        {
            counter++;
            string input = Console.ReadLine();
            Double.TryParse(input, out double student);
            summa += student;
        }
        answer = summa / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        int counter = 0;
        while (counter < n)
        {
            counter++;
            string inputx= Console.ReadLine();
            Double.TryParse(inputx,new CultureInfo("en-US"), out double x);
            string inputy = Console.ReadLine();
            Double.TryParse(inputy, new CultureInfo("en-US"), out double y);
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        int counter = 0;
        // end
        while (counter < n)
        {
            counter++;
            string input=Console.ReadLine();
            Double.TryParse(input,new CultureInfo ("en-US"), out double weight);
            if (weight<30)
                    answer += 0.2;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0, counter = 0;
        // code here
        while (counter < n)
        {
            counter++;
            Double.TryParse(Console.ReadLine(), new CultureInfo("en-US"),out double x);
            Double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out double y);
            double test = x * x + y * y;
            if ((r1*r1 <= test) && (test <= r2*r2)) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0, counter = 0;

        // code here
        while (counter < n)
        {
            counter++;
            string input= Console.ReadLine();
            Double.TryParse(input, new CultureInfo("en-US"), out double result);
            if (result<=norm)
                answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0, counter = 0;
        // code here
        while (counter < n)
        {
            counter++;
            string inputx = Console.ReadLine();
            Double.TryParse(inputx, new CultureInfo("en-US"), out double x);
            string inputy= Console.ReadLine();
            Double.TryParse(inputy, new CultureInfo("en-US"), out double y);
            if (y >= 0 && 0 <= x && x <= Math.PI && y <= Math.Sin(x)) 
                answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        // code here
        int counter = 0;
        while (counter < n)
        {
            counter++;
            string inputx = Console.ReadLine();
            Double.TryParse(inputx, new CultureInfo("en-US"), out double x);
            string inputy= Console.ReadLine();
            Double.TryParse (inputy, new CultureInfo("en-US"), out double y);
            if ((x>0) && (y>0))
            {
                Console.WriteLine(1);
                answer1++;
            }
            else if (x < 0 && y > 0) Console.WriteLine(2);
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
                answer3++;
            }
            else if (x>0 && y<0) Console.WriteLine(4);
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        int counter = 0;
        while (counter < n)
        {
            counter++;
            string inputx = Console.ReadLine();
            Double.TryParse(inputx, new CultureInfo("en-US"), out double x);
            string inputy = Console.ReadLine();
            Double.TryParse(inputy, new CultureInfo("en-US"), out double y);
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < answerLength)
            {
                answer = counter;
                answerLength = distance;
            }
        }
        // end
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        int counter = 0;
        while (counter < n)
        {
            counter++;
            string input = Console.ReadLine();
            Double.TryParse(input,new CultureInfo("en-US"), out double result);
            if (result < answer) answer = result;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int counter = 0;
        while (counter < n)
        {
            counter++;
            int start = 0, test=0;
            while (start < 4)
            {
                start++;
                Console.WriteLine($"Студент{counter}.Оценка{start}");
                string input = Console.ReadLine();
                Double.TryParse(input, out double result);
                if (result != 2 && result != 3) test++;
            }
            if (test == 4) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int student = 0;
        double summa = 0;
        while (student < n)
        {
            student++;
            int start = 0, test = 0;
            while (start < 4)
            {
                start++;
                Console.WriteLine($"Введите {start} оценку {student} студента");
                string input = Console.ReadLine();
                Double.TryParse(input,out double mark);
                summa += mark;
                if (mark > 2) test++;
            }
            if (test < 4) answer++;
        }
        avg = summa / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
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
            default:
                answer = 0;
                break;
        }
        answer=Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A<=0) ||(B<=0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            default:
                answer = 0;
                break;
        }
        // end
        answer= Math.Round(answer,2);
        return answer;
    }
    #endregion

    
    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        double summa = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Введите рост ученика, для окончания ввода введите 0");
            Double.TryParse(Console.ReadLine(), out double height);
            if (height == 0) break;
            summa += height;
            n++;
        }
        answer = summa / n;
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

        // code here
        while (true)
        {
            Console.WriteLine("Введите координатy x точки, для завершения ввода введите @");
            string s = Console.ReadLine();
            if (s == "@") break;
            Double.TryParse(s, new CultureInfo("en-US"),out double x);
            Console.WriteLine("Введите координату y точки");
            Double.TryParse(Console.ReadLine(), new CultureInfo("en-US"),out double y);
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2*r2)) answer++;
        }
        Console.WriteLine(answer);
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
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        while (true)
        {
            Console.WriteLine("Введите координату x  точки, для прекращения ввода введите stop");
            string s= Console.ReadLine();
            if (s == "stop") break;
            Double.TryParse(s, new CultureInfo("en-US"), out double x);
            Console.WriteLine("Введите координату y точки");
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Квадрант 1");
                answer1++;
            }
            else if (x < 0 && y > 0) Console.WriteLine("Квадрант 2");
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Квадрант 3");
                answer3++;
            }
            else if (x > 0 && y < 0) Console.WriteLine("Квадрант 4");
            else Console.WriteLine("Точка находится на оси");
        }
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

        // code here;
        int fl = 0;
        while (fl == 0)
        {   
            int test=0;
            for (int i = 0; i < 4; i++)
            {
                if (i + 1 == 4)
                {
                    Console.WriteLine("Введите 4 оценку студента, если студент последний, введите после оценки stop в той же строке");
                    string s = Console.ReadLine();
                    if (s.Contains("stop")) fl = 1;
                    int.TryParse(s, out int mark);
                    if (mark != 2 && mark != 3) test++;
                }
                else
                {
                    Console.WriteLine($"Введите {i + 1} оценку студента");
                    int.TryParse(Console.ReadLine(), out int mark);
                    if (mark != 2 && mark != 3) test++;
                }
            }
            if (test == 4) answer++;
        }
        // end
        Console.WriteLine(answer);
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
