using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        Program program = new Program();
        //program.Task_1_1(1.5, 0.7); //+
        //program.Task_1_2(0.9, 1.23); //+
        //program.Task_1_3(0.9, 1.23); //+
        //program.Task_1_4(0.9, 1.23, -0.1); //+
        //program.Task_1_5(0.9, 1.23); //+
        //program.Task_1_6(0.9, 1.23); //+
        //program.Task_1_7(0.9); //+
        //program.Task_1_8(0.9); //+
        //program.Task_1_9(0.9); //+
        //program.Task_1_10(0.9); //+
        //program.Task_2_1(10); //+
        //program.Task_2_2(5, 3, 2, 1); //+
        //program.Task_2_2(5, 1.5, 1.5, 1); //+
        //program.Task_2_2(5, 1, 3, 1); //+
        //program.Task_2_3(8); //+
        //program.Task_2_4(5, 1, 3); //+
        //program.Task_2_5(10, 30); //+
        //program.Task_2_6(5); //+
        //program.Task_2_7(4); //+
        //program.Task_2_8(5); //+
        //program.Task_2_9(10); //+
        //program.Task_2_10(6); //+
        //program.Task_2_11(8); //+
        //program.Task_2_12(10, 0); //+
        //program.Task_2_13(1.5, 3, 2); //
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1); //+
        //program.Task_3_2(1.5, 1.5, 1); //+
        //program.Task_3_2(3, 2, 1); //+
        //program.Task_3_3();
        //program.Task_3_4(1, 2); 
        //program.Task_3_5(30); //+
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8(); //+
        //program.Task_3_9();
        //program.Task_3_10();
        program.Task_3_11(); //+
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        // code here
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && y+Math.Abs(x)<=1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0)
        {
            if (a>b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }

        }
        else
        {
            if(a>b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min_a_b = 0;
        if (a<b)
        {
            min_a_b = a;
        }
        else
        {
            min_a_b = b;
        }
        if (min_a_b>c)
        {
            answer = min_a_b;
        }
        else
        {
            answer = c;
        }


        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double R = Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        // code here
        if (2*R > Math.Sqrt(2)*a)
        {
            answer = true;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        // code here
        if (2 * R < a)
        {
            answer = true;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>1)
        {
            answer = 1;
        }
        if (Math.Abs(x)<=1)
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
        if (Math.Abs(x)>=1)
        {
            answer = 0;
        }
        if (Math.Abs(x)<1)
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
        if (x<=-1)
        {
            answer = 0;
        }
        if (-1<x && x<=0)
        {
            answer = 1 + x;
        }
        if (x>0)
        {
            answer = 1;
        }

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1)
        {
            answer = 1;
        }
        else if (x>-1 && x<=1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion
    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double r = 0, s = 0;

        // code here
        for(int i = 0; i<n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;

        for (int deistvie = 0; deistvie < n; deistvie++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a)*(x-a) + (y-b)*(y - b)) <= r)
            {
                answer++;
            }

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double moloko = 0;
        double ves = 0.0;
        for (int i = 0; i<n; i++)
        {
            ves = double.Parse(Console.ReadLine());
            if (ves < 30)
            {
                moloko += 0.2;
            }
        }
        // end
        Console.WriteLine(moloko);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        int popal = 0;
        double x = 0, y =0;
        for(int i =0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double rast = Math.Sqrt(x * x + y * y);
            if ((r1 <= rast) && (rast <= r2))
            {
                popal++;
            }
        }
        Console.WriteLine(popal);




        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i<n; i++)
        {
            double rez = double.Parse(Console.ReadLine());
            if (rez<=norm)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        for (int i = 0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer++;
            }  
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x = 0, y = 0;
        // code here
        int kv1 = 0, kv3 = 0;
        for (int i = 0; i<n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x>0) && (y>0))
            {
                //Console.WriteLine("1й квадрант");
                answer1++;
            }
            else if ((x>0) && (y<0))
            {
                //Console.WriteLine("4й квадрант");
                continue;
            }
            else if ((x<0) && (y<0))
            {
                //Console.WriteLine("3й квадрант");
                answer3++;
            }
            else if ((x<0) && (y>0))
            {
                //onsole.WriteLine("2й квадрант");
                continue;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x = 0, y = 0;
        double promesh = 100000;
        int num = 0;
        // code here
        for (int i =1; i<=n; i++)
        {
            x = double.Parse((Console.ReadLine()));
            y = double.Parse((Console.ReadLine()));
            double rast = Math.Sqrt(x * x + y * y);
            //Console.WriteLine(rast);
            if (rast<promesh)
            {
                promesh = rast;
                num = i;
            }

        }
        promesh = Math.Round(promesh, 2);
        answer = num;
        answerLength = promesh;
        // end
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double promrez = 10000, rez = 0;
        // code here
        for(int i=0; i<n; i++)
        {
            rez = double.Parse(Console.ReadLine());
            if (rez < promrez)
            {
                promrez = rez;
            }
        }
        Console.WriteLine(promrez);
        answer = promrez;
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        // code here;
        for(int i = 0; i<n; i++)
        {
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if (mark1 == 2 || mark1 == 3 || mark2 == 2 || mark2 == 3 || mark3 == 2 || mark3 == 3 || mark4 == 2 || mark4 ==3)
            {
                continue;
            }
            else
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
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        int dvoichnik = 0;
        double srbal = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                dvoichnik += 1;
            }
            avg += (mark4 + mark1 + mark3 + mark2) / 4;
        }
        avg = avg / n;
        answer = dvoichnik;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // хот€бы 1 двойку получил - неуспевающий
        // end

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
                //Console.WriteLine(answer);
                break;
            case 1:
                answer = Math.PI * r * r;
                //Console.WriteLine(answer);
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                //Console.WriteLine(answer);
                break;
            default:
                //Console.WriteLine("Ќеверный выбор");
                break;
        }


        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A<=0 || B<=0)
        {
            return answer = 0;
        }
        switch (type)
        {
            case 0:
                answer = Math.Round((A * B), 2);
                Console.WriteLine(answer);
                if (answer<0)
                {
                    return answer = 0;
                }    
                break;
            case 1:
                if (A>B)
                {
                    answer = Math.Round(Math.PI * (A * A - B * B), 2);
                    Console.WriteLine(answer);
                }
                else if (B>A)
                {
                    answer = Math.Round(Math.PI * (B * B - A * A), 2);
                    Console.WriteLine(answer);
                    
                }
                if (answer < 0)
                {
                    return answer = 0;
                }
                break;
            case 2:
                double A2 = A / 2;
                double h = Math.Sqrt(B * B - A2 * A2);
                //Console.WriteLine(h);
                answer = Math.Round((A*h)/2, 2);
                Console.WriteLine(answer);

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
        

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0;
        double x = 0, y = 0;
        // code here
        Console.WriteLine("¬ведите stop чтобы остановить прграмму");
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out x);
                y = double.Parse(Console.ReadLine());
                if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
                {
                    answer++;
                }

            }

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
       

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;
        int rez = 0;
        // code here
        while(true)
        {
            string s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                int.TryParse(s, out rez);
                if (rez <= norm)
                {
                    answer++;
                    Console.WriteLine(answer);
                }
            }
            
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x = 0, y = 0;
        double promesh = 100000;
        int num = 0;
        // code here
        int i = 0;
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out x);
                y = double.Parse((Console.ReadLine()));
                double rast = Math.Sqrt(x * x + y * y);
                //Console.WriteLine(rast);
                if (rast < promesh)
                {
                    promesh = rast;
                }
                i++;
            }
        }
        // end
        promesh = Math.Round(promesh, 2);
        answerLength = promesh;
        answer = i;
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0;

        // code here;
        int sum = 0;
        while (true)
        {
            int c = int.Parse(Console.ReadLine());
            sum += c;
            Console.WriteLine(sum);
        }
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        int dvoichnik = 0;
        int n = 0;
        double sum = 0;
        // code here;
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out mark1);
                mark2 = double.Parse(Console.ReadLine());
                mark3 = double.Parse(Console.ReadLine());
                mark4 = double.Parse(Console.ReadLine());
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    dvoichnik += 1;
                }
                sum += mark1 + mark2 + mark3 + mark4;
                n++;
            }
        }
        Console.WriteLine(n);
        avg = sum/(n*4);
        answer = dvoichnik;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end
        return (answer, avg);
    }
    #endregion
}