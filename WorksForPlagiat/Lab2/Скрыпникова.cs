using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
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
       // program.Task_2_2(5, 3, 2, 1);
       // program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
       // program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
       // program.Task_2_6(5);
        program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
       // program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
       // program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
       // program.Task_3_7();
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
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r)<=0.0001)
            answer=true;
        else
            answer=false;
        Console.WriteLine(answer);
       
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ( y>=0 && y+Math.Abs(x)<=1)
            answer=true;
        else 
            answer=false;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        double c = 0;
        // code here
        if (a > 0)
        {
            if (a < b)
                c = b;
            else
                c = a;
        }
        else
        {
            if (a < b)
                c = a;
            else
                c = b;
        }
        answer= c;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
            if (b > c)
                answer = b;
            else
                answer = c;

        if (a < b)
            if (a > c)
                answer = a;
            else
                answer = c;
        Console.WriteLine (answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double rC, rK ;
        // code here
        rK = Math.Sqrt(s);//сторона квадрата
        rC= Math.Sqrt(r/Math.PI);//радиус круга
        if ((rK*Math.Sqrt(2))<2*rC)
            answer = true;
        else
            answer = false;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double rC, rK;
        // code here
        rK = Math.Sqrt(s);//сторона квадрата
        rC = Math.Sqrt(r / Math.PI);//радиус круга
        if (rC*2<=rK)
            answer = true;
        else
            answer = false;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        double y;
        // code here
        if (Math.Abs(x) > 1)
            y = 1;
        else
            y=Math.Abs(x);
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double y;
        // code here
        if (Math.Abs(x) >= 1)
            y = 0;
        else
            y = x * x - 1;
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        
        // code here
        if (x <= -1)
            answer = 0;
        if (-1<x && x <= 0)
            answer = 1 + x;
        if (x>0)
            answer = 1;
        
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
       
        // code here
        if (x <= -1)
            answer = 1;
        if (-1 < x && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        
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
        double r;
        int count = 0;
        double sum = 0;
        while (count < n)
        {
            r = double.Parse(Console.ReadLine());
            if (r == 0)
                break;
            else
            {
                sum += r;
                count++;
            }
        }
        answer = sum / count;
        Console.WriteLine($"Средний рост: {answer}"); 
        
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        //code here
        double x, y;
        for (int i=1; i<n; i++)
        {
            x= double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((x-a)*(x-a)+(y-b)*(y-b)<=r*r)
            {
                answer++;
            }
        }
        Console.WriteLine($"Итого : {answer}");
        // end
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double ves = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

            if (ves < 30)
                answer += 200;
            else 
                continue;
        }
        answer = answer / 1000;
        Console.WriteLine($"Итого потребуется литров: {answer}");
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        
        int  count = 0;
        for (int i=0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (((x * x + y * y) >= r1 * r1) && ( (x * x + y * y )<= r2 * r2) )
                count++;
            else
                continue;
        }
        answer = count;
        Console.WriteLine($"Итого входит точек : {answer}");
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rez;
        int count = 0;
        for (int i = 0; i<n; i++)
        {
            rez = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (rez <= norm)
                count++;
            else continue;

        }
        answer = count;
        Console.WriteLine($"Выполнили норматив : {answer}");
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        int count = 0;
        for (int i=1; i<=n; i++)
        {
            x= double.Parse(Console.ReadLine(),new CultureInfo("en-US"));
            y= double.Parse(Console.ReadLine(),new CultureInfo("en-US"));
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                count++;
            }
        }
        answer = count;
        Console.WriteLine($"Принадлежит фигуре : {answer}");
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i=0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine(),new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x > 0 && y > 0)
            {
                Console.WriteLine("В 1 квадранте");
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("В 2 квадранте");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("В 4 квадранте");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Во 2 квадранте");
            }
        }
        Console.WriteLine($"В первом квадранте : {answer1}");
        Console.WriteLine($"В третьем квадранте : {answer3}");

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double l=double.MaxValue;
        double x, y;
        // code here
        for (int i=1; i<n; i++)
        {
            x=double.Parse(Console.ReadLine(),new CultureInfo("en-US"));
            y=double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (Math.Sqrt(x*x+y*y)<l)
            {
                l = Math.Sqrt(x * x + y * y);
                answer = i;
            }
            else continue ;
        }
        double answerLengt = l;
        Console.WriteLine(answer);
        Console.WriteLine(answerLengt);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double sec;
        for (int i=0; i<n; i++)
        {
            sec = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (sec < answer)
            {
                answer = sec;
            }
            else continue;
        }
        
        Console.WriteLine($"Лучший результат : {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double k1, k2, k3, k4;
        // code here;
        for (int i=0; i<n;i++)
        {
            k1= double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k2= double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k3= double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k4= double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (k1>3 && k2>3 && k3>3 && k4>3)
            {
                answer++;
            }
        }
        Console.WriteLine($"Ответ : {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int k1, k2, k3, k4;
        // code here;
        for (int i = 0; i < n; i++)
        {
            k1 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k2 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k3 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            k4 = int.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (k1 <= 3 || k2 <= 3 || k3 <= 3 || k4 <= 3)
            {
                answer++;
         
            }
            avg += k1 + k2 + k3 + k4;


        }
        avg = avg / 4 / n;
        Console.WriteLine($"Кол-во неуспевающих: {answer}");
        Console.WriteLine($"Средний балл {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here
        if (r <= 0) return 0;
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
                break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A<=0 || B<=0) return 0;
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
                break;
        }
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
        double r;
        int count = 0;
        double sum = 0;
        string input;
        Console.WriteLine("Для завершения ввода напишите 'end'");
        while (true)
        {
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out r);
            if (r == 0)
                break;
            else
            {
                sum += r;
                count++;
            }
        }
        answer = sum / count;
        Console.WriteLine($"Средний рост: {answer}");
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
        double x, y;
        string input;
        int count = 1;
        Console.WriteLine("Для завершения ввода напишите 'end'");
        while (true)
        {
            
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out x);
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out y);
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
            {
                count++;
            }
        }
        answer = count;
        Console.WriteLine($"Итого входит точек : {answer}");
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
        double x, y;
        string input;
        Console.WriteLine("Для завершения ввода напишите 'end'");
        while (true) 
        {
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out x);
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out y);
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                answer3++;
            }
            
        }
        Console.WriteLine($"В первом квадранте : {answer1}");
        Console.WriteLine($"В третьем квадранте : {answer3}");
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
        double k1, k2, k3, k4;
        string input;
        Console.WriteLine("Для завершения ввода напишите 'end'");
        while (true) 
        {
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out k1);
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out k2);
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out k3);
            input = Console.ReadLine();
            if (input == "end")
                break;
            double.TryParse(input, out k4);
            if (k1 > 3 && k2 > 3 && k3 > 3 && k4 > 3)
            {
                answer++;
            }
        }
        Console.WriteLine($"Ответ : {answer}");
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