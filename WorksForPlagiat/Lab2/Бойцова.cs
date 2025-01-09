using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO.Pipes;
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
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(8);
        //program.Task_2_11(8);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        if (Math.Abs(x * x + y * y - 2 * 2) <= 1 / 10 * 10 * 10)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
            if (b > a) answer = b;
            if (b < a) answer = a;
        }
        else
        {
            if (b > a) answer = a;
            if (b < a) answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (c > a)
                return c;
            else return a;
        }
        else
        {
            if (c > b)
                return c;
            else return b;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diagonal = Math.Sqrt(2) * Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);
        if (diagonal < 2 * radius)
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double side = Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);
        if (side >= 2 * radius)
            answer = true;
        else
            answer = false;
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
        if (x > -1 && x <= 0)
            answer = 1 + x;
        if (x > 0)
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
        if (x <= 1 && x > -1)
            answer = -x;
        if (x > 1)
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

        double s = 0;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out int height);
            s += height;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer += 1;
        }
        Console.WriteLine(answer);
        // end
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        //1,2
        //0,7
        //2
        //2
        //4,5
        //0,1
        //-1
        //1,5
        //-2,5
        //-0,5
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            //double.TryParse(Console.ReadLine(), out double weight);
            if (weight < 30) answer += 200;
        }
        Console.WriteLine(answer / 1000);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        //27,5
        //32,5
        //30
        //22,3
        //26,8
        //36,6
        //30
        //29,9
        //20,1
        //28,5
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2) answer += 1;
        }
        Console.WriteLine(answer);
        // end
        //1,2
        //0,7
        //2
        //2
        //4,5
        //0,1
        //-1
        //1,5
        //-0,5
        //-0,5
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result <= norm) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        //27,5
        //32,5
        //30,0
        //22,3
        //26,8
        //36,6
        //30,0
        //29,9
        //20,1
        //28,5
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0)) answer++;

        }
        Console.WriteLine(answer);
        //1,2
        //0,7
        //2
        //0,2
        //0,5
        //0,5
        //-1
        //1,5
        //0,5
        //0,1
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("первый квадрант");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("второй квадрант");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("третий квадрант");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("четвертый квадрант");
            }
        }
        Console.WriteLine("кол-во точек в 1 квадранте {0}", answer1);
        Console.WriteLine("кол-во точек в 3 квадранте {0}", answer3);
        // end
        //-1,2
        //0,7
        //2
        //-2
        //0,5
        //0,9
        //1
        //1,5
        //-0,5
        //-1,5
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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(x * x + y * y);
            if (s < answerLength)
            {
                answer = i;
                answerLength = s;
                
            }

        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        //-1,2
        //0,7
        //2
        //-2
        //0,5
        //0,9
        //1
        //1,5
        //-0,5
        //-0,5


        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result < answer)
                answer = result;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        //27,5
        //32,5
        //30
        //22,3
        //26,8
        //36,6
        //30
        //29,9
        //20,1
        //28,5
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        { 
            int grade_1 = int.Parse(Console.ReadLine());
            int grade_2 = int.Parse(Console.ReadLine());
            int grade_3 = int.Parse(Console.ReadLine());
            int grade_4 = int.Parse(Console.ReadLine());
            if (grade_1>=4 && grade_2>=4 && grade_3>=4 && grade_4 >= 4) answer++;
        }
        Console.WriteLine("ответ:{0}",answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            int grade_1 = int.Parse(Console.ReadLine());
            int grade_2 = int.Parse(Console.ReadLine());
            int grade_3 = int.Parse(Console.ReadLine());
            int grade_4 = int.Parse(Console.ReadLine());
            if (grade_1 == 2 || grade_2 == 2 || grade_3 == 2 || grade_4 == 2) answer++;
            double s = grade_1 + grade_2 + grade_3 + grade_4;
            sum += s;
        }
        avg = sum /n/4;
        Console.WriteLine("кол-во неуспевающих студентов:{0}", answer);
        Console.WriteLine("средний балл группы:{0}", avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0: answer = r * r;
                //Console.WriteLine("площадь квадрата = {0}",answer);
                break;
            case 1: answer = Math.PI * r * r;
                //Console.WriteLine("площадь окружности = {0}", answer);
                break;
            case 2: answer = (Math.Sin(Math.PI/3)* r * r)/2;
                //Console.WriteLine("площадь р/с треугольника = {0}", answer);
                break;
            default: answer = 0; Console.WriteLine("неверный ввод.попробуйте 0, 1 или 2."); break;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2: answer = (Math.Sqrt(B * B - (A / 2) * (A / 2))*A)/2; break;
            default: answer = 0; break;
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
        Console.WriteLine("чтобы прекратить ввод введите любой символ кроме цифр.");
        // code here
        double s = 0;
        while (true)
        {
            int height;
            bool check = int.TryParse(Console.ReadLine(), out height);
            if (check)
            {
                s += height;
                n++;
            }
            else
            {
                Console.WriteLine("конец ввода");
                s = s / n;
                Console.WriteLine("ответ:{0}", s);
            } 
            

        }
        
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
        Console.WriteLine("чтобы прекратить ввод введите любой символ кроме цифр.");
        while (true)
        {
            double dot_x, dot_y;
            bool check_x = double.TryParse(Console.ReadLine(), out dot_x);
            bool check_y = double.TryParse(Console.ReadLine(), out dot_y);
            if (check_x == true && check_y == true)
            {
                if (Math.Sqrt(dot_x * dot_x + dot_y * dot_y) >= r1 && Math.Sqrt(dot_x * dot_x + dot_y * dot_y) <= r2) answer += 1;
            }
            else
            {
                Console.WriteLine("конец ввода");
                Console.WriteLine("ответ: {0}",answer);
            }

        }
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
        Console.WriteLine("чтобы прекратить ввод введите любой символ кроме цифр.");
        while (true)
        {
            double x, y;
            bool check_x = double.TryParse(Console.ReadLine(), out x);
            bool check_y = double.TryParse(Console.ReadLine(), out y);
            if (check_x == true && check_y == true)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("первый квадрант");
                    answer1++;
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("второй квадрант");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("третий квадрант");
                    answer3++;
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("четвертый квадрант");
                }
            }
            else 
            {
                Console.WriteLine("конец ввода");
                Console.WriteLine("кол-во точек в 1 квадранте {0}", answer1);
                Console.WriteLine("кол-во точек в 3 квадранте {0}", answer3);
            }
            
        }
        
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
        Console.WriteLine("чтобы прекратить ввод введите любой символ кроме цифр.");

        while (true)
        {
            int grade_1, grade_2, grade_3, grade_4;

            bool check_1 = int.TryParse(Console.ReadLine(), out grade_1);
            bool check_2 = int.TryParse(Console.ReadLine(), out grade_2);
            bool check_3 = int.TryParse(Console.ReadLine(), out grade_3);
            bool check_4 = int.TryParse(Console.ReadLine(), out grade_4);
            if (check_1 == true && check_2 == true && check_3 == true && check_4 == true)
            {
                if (grade_1 >= 4 && grade_2 >= 4 && grade_3 >= 4 && grade_4 >= 4) answer++;
            }
            else 
            {
                Console.WriteLine("конец ввода");
                Console.WriteLine("ответ:{0}", answer);
            }
            
        }
        
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
