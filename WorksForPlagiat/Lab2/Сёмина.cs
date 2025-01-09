using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.InteropServices;

public class Program
{
    public object Int { get; private set; }

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
        int r = 2;
        // code here
        if (Math.Abs(x*x + y*y - r*r) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        else { answer = false; }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
     
    {
        bool answer = false;
        
        // code here
        if (y >= 0 && (y+ Math.Abs(x))<= 1)
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
            if (a > b) { answer = a; }
            else if (b > a) { answer = b; }
        }
        else if (a <= 0)
        {
            if (a < b) { answer = a;}
            else if (b < a) { answer = b;}
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double n1 = -1000000;

        // code here
        if (a < b) 
        {
            n1 = a;
            if (n1>c) { answer = n1; }
            else if (c > n1) { answer = c; }

        }
        if (b < a)
        {
            n1 = b;
            if (n1>c) {answer = n1; }
            else if (c > n1) { answer = c; }
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double r4 = Math.Sqrt(s/2);
        double ro = Math.Sqrt(r/Math.PI);
        if (r4 <= ro) { answer = true; }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double r4 = Math.Sqrt(s/4);
        double ro = Math.Sqrt(r/Math.PI);
        if (r4 >= ro) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>1) { answer = 1; }
        else if (Math.Abs(x)<=1) { answer = Math.Abs(x);}
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>=1) { answer = 0; }
        else if (Math.Abs(x)<1) { answer = x*x - 1; }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 0; }
        else if (-1<= x && x<= 0) { answer = 1 + x; }
        else if (x>0) { answer = 1; }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (-1 < x && x<= 1) { answer = -x; }
        else if (x>1) { answer = -1; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        //n = int.Parse(Console.ReadLine());
        double s = 0;
        double h = 0;
        // code here
        
        for (int i = 0; i<n; i++)
        {
            h=double.Parse(Console.ReadLine());
            s += h;
        }
        answer = s / n;
        //System.Console.WriteLine(answer);
        // end
        return answer;
    }

    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            Double.TryParse(Console.ReadLine(), out double y);
            if ((x-a)*(x-a) + (y-b)*(y-b) <= r*r)
            {
                answer++;
            }
            counter++;
        }
        // end
        //Console.WriteLine(answer);     
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        int counter = 0;
        double s = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < 30)
            {
                s += 200;
            }
            counter++;
        }
        // end
        answer = s/1000;
        //Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            Double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine(x*x + y*y);
            if (((x*x + y*y)<= r2*r2) && ((x*x + y*y)>= r1*r1))
            {
                answer++;
                //Console.WriteLine(x*x + y*y);
            }
            counter++;
        }
        // end
        //Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x<=norm)
            {
                answer++;
            }
            counter++;
        }
        // end
        //Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            Double.TryParse(Console.ReadLine(), out double y);
            if (y >= 0 && 0 <= x && x <= Math.PI && y <= Math.Sin(x)) 
            { 
                answer++; 
            }
            counter++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            Double.TryParse(Console.ReadLine(), out double y);
            if (x>0 && y>0)
            {
                answer1++;
                Console.WriteLine(1);
            }
            else if (x<0 && y<0)
            {
                answer3++;
                Console.WriteLine(3);
            }
            else if (x>0 && y<0)
            {
                Console.WriteLine(4);
            }
            else if (x<0 && y>0 )
            {
                Console.WriteLine(2);
            }
            counter++;
        }
        
        //Console.WriteLine(answer1);
        //Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        int counter = 1;
        // code here
        while (counter <= n)
        {
            Double.TryParse(Console.ReadLine() , out double x);
            Double.TryParse(Console.ReadLine(), out double y);
            if ((Math.Abs(x)*Math.Abs(x) + Math.Abs(y)*Math.Abs(y)) < answerLength)
            {
                answerLength = Math.Round((Math.Sqrt(Math.Abs(x)*Math.Abs(x) + Math.Abs(y)*Math.Abs(y))),2);
                answer = counter;
            }
            counter++;
        }


        // end
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        int counter = 0;
        // code here
        while (counter < n)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < answer)
            {
                answer = x;
            }
            counter++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int counter = 0;
        int s = 0;
        // code here;
        while (counter < n)
        {
            int.TryParse(Console.ReadLine(), out int n1);
            int.TryParse(Console.ReadLine(), out int n2);
            int.TryParse(Console.ReadLine(), out int n3);
            int.TryParse(Console.ReadLine(), out int n4);
            counter++;
            s = s + n1 +n2 + n3;
            if ((n1!=2)&&(n1!=3)&&(n2!=3)&&(n2!=2)&&(n3!=3)&&(n3!=2)&&(n4!=3)&&(n4!=2))
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int counter = 0;
        double s = 0;
        // code here;
        while (counter < n)
        {
            int.TryParse(Console.ReadLine(), out int n1);
            int.TryParse(Console.ReadLine(), out int n2);
            int.TryParse(Console.ReadLine(), out int n3);
            int.TryParse(Console.ReadLine(), out int n4);
            counter++;
            s = s + n1 +n2 + n3 +n4;
            if (n1==2 || n2==2|| n3==2 || n4 ==2)
            {
                answer++;
            }
        }
        avg = Math.Round((s/(n*4)),2);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

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
        switch(type)
        {
            case 0:
                answer = r*r; break;
            case 1:
                answer = r*r*Math.PI; break;
            case 2:
                answer = r*r*Math.Sqrt(3)/4; break;
        }
        answer = Math.Round(answer,2);
        System.Console.WriteLine(answer);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0|| B<=0)
        {
            return 0;
        }
        switch(type)
        {
            case 0:
                answer = A*B; break;    
            case 1:
                answer = Math.Abs(Math.PI * (A*A - B*B)); break;
            case 2:
                answer = 0.5 * A * Math.Sqrt(B*B - 0.25 * A * A); break;
        }
        // end
        answer = Math.Round(answer,2);
        System.Console.WriteLine(answer);
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
        double s = 0;
        // code here
        while (true)
        {
            Console.WriteLine("¬ведите вес, дл€ окончани€ ввода введите 0");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x == 0) break;
            if (x< 30)
            {
                s += 200;
            }
        }
        // end
        answer = s/1000;
        Console.WriteLine(answer);
        return answer;
    }
//        
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
        while (true)
        {
            Console.WriteLine("¬ведите координаты точки x, дл€ окончани€ ввода введите '*'");
            string s = Console.ReadLine();
            if (s == "*") break;
            Double.TryParse(s, out double x);
            Console.WriteLine("¬ведите координаты точки y");
            Double.TryParse(Console.ReadLine(), out double y);

            if (y >= 0 && 0 <= x && x <= Math.PI && y <= Math.Sin(x))
            {
                answer++;
            }
        }


        // end
        Console.WriteLine(answer);
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
        while (true)
        {
            Console.WriteLine("¬ведите результат спортсмена, дл€ окончани€ ввода введите 0");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x == 0) break;
            
            if (x < answer)
            {
                answer = x;
            }
        }
        // end
        Console.WriteLine(answer);
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
//23 369