using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
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
        // program.Task_2_2(5, 3, 2, 1);
        // program.Task_2_2(5, 1.5, 1.5, 1);
        // program.Task_2_2(5, 1, 3, 1);
        // program.Task_2_3(10);
        // program.Task_2_4(5, 1, 2);
        // program.Task_2_5(10, 30);
        // program.Task_2_6(5);
        // program.Task_2_7(5);
        // program.Task_2_8(5);
        // program.Task_2_9(10);
        // program.Task_2_10(10);
        // program.Task_2_11(10);
        // program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        // program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        // program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        // program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        if(Math.Abs(x * x + y * y - 4) < 1e-3) {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y >= 0 && y + Math.Abs(x) <= 1) {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        answer = a;
        if(a > 0) {
           if(answer < b) {
            answer = b;
           } 
        } else {
            if(answer > b) {
                answer = b;
            } 
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if(a < b) {
            answer = a;
        } else {
            answer = b;
        }
        if(answer < c) {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double edge = Math.Sqrt(s);
        if(2 * R >= edge * Math.Sqrt(2)) {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double edge = Math.Sqrt(s);
        if(2 * R <= edge) {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if(Math.Abs(x) > 1) {
            answer = 1;
        } else {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if(Math.Abs(x) < 1) {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if(x > -1 && x <= 0) {
            answer = 1 + x;
        } else if(x > 0) {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1) {
            answer = 1;
        } else if(x <= 1) {
            answer = -x;
        } else {
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

        // code here
        for(int i = 0; i < n; ++i) {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            answer += x;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= r * r) {
                ++answer;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            if(weight < 30) {
                answer += 200;
            }
        }
        answer /= 1000;
        Console.WriteLine($"Ответ: {answer}");
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1) {
                ++answer;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double result;
            double.TryParse(Console.ReadLine(), out result);
            if(result <= norm) {
                answer++;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(y > 0 && y <= Math.Sin(x)) {
                ++answer;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 0; i < n; ++i) {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(y > 0) {
                if(x > 0) {
                    ++answer1;
                    Console.WriteLine($"Точка ({x}, {y}) лежит в I квадранте");
                } else if(x < 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит во II квадранте");
                } else {
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
                }
            } else if(y < 0) {
                if(x > 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит в IV квадранте");
                } else if(x < 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит в III квадранте");
                    ++answer3;
                } else {
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
                }
            } else {
                Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
            }
        }
        Console.WriteLine($"{answer1} точек лежит в I квадранте, {answer3} в III");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for(int i = 0; i < n; ++i) {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(x * x + y * y < answerLength) {
                answer = i + 1;
                answerLength = x * x + y * y;
            }
        }
        answerLength = Math.Round(Math.Sqrt(answerLength), 2);
        Console.WriteLine($"Номер точки: {answer}, расстояние до начала координат: {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for(int i = 0; i < n; ++i) {
            double result;
            double.TryParse(Console.ReadLine(), out result);
            if(result < answer) {
                answer = result;
            }
        }
        Console.WriteLine($"Лучший результат: {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for(int i = 0; i < n; ++i) {
            bool f = false;
            for(int j = 0; j < 4; ++j) {
                int mark;
                int.TryParse(Console.ReadLine(), out mark);
                if(mark < 4) {
                    f = true;
                }
            }
            if(!f) {
                ++answer;
            }
        }
        Console.WriteLine($"Учеников без двоек и троек: {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for(int i = 0; i < n; ++i) {
            double sum = 0;
            bool f = false;
            for(int j = 0; j < 4; ++j) {
                double mark;
                double.TryParse(Console.ReadLine(), out mark);
                sum += mark;
                if(mark == 2) {
                    f = true;
                }
            }
            avg += sum;
            if(f) {
                ++answer;
            }
        }
        avg /= n * 4;
        avg = Math.Round(avg, 2);
        Console.WriteLine($"Неуспевающих учеников: {answer}, средний балл группы: {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if(r < 0) {
            Console.WriteLine("Длина стороны не может быть отрицательной");
            return 0;
        }
        switch(type) {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if(A < 0 || B < 0) {
            Console.WriteLine("Длина стороны не может быть отрицательной");
            return 0;
        }
        switch(type) {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * Math.Abs(A * A - B * B);
                break;
            case 2:
                answer = A * Math.Sqrt(Math.Abs(B*B - A*A/4)) / 2;
                break;
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
        string stopper = "Write 'stop' to stop";
        Console.WriteLine(stopper);
        while(true) {
            stopper = Console.ReadLine();
            if(stopper == "stop") {
                break;
            }
            double x;
            double.TryParse(stopper, out x);
            answer += x;
            ++n;
        }
        answer /= n;
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
        string stopper = "Write 'stop' to stop";
        Console.WriteLine(stopper);
        while(true) {
            stopper = Console.ReadLine();
            if(stopper == "stop") {
                break;
            }
            double x, y;
            double.TryParse(stopper, out x);
            double.TryParse(Console.ReadLine(), out y);
            if(x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1) {
                ++answer;
            }
        }
        Console.WriteLine($"Ответ: {answer}");
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
        string stopper = "Write 'stop' to stop";
        while(true) {
            stopper = Console.ReadLine();
            if(stopper == "stop") {
                break;
            }
            double x, y;
            double.TryParse(stopper, out x);
            double.TryParse(Console.ReadLine(), out y);
            if(y > 0) {
                if(x > 0) {
                    ++answer1;
                    Console.WriteLine($"Точка ({x}, {y}) лежит в I квадранте");
                } else if(x < 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит во II квадранте");
                } else {
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
                }
            } else if(y < 0) {
                if(x > 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит в IV квадранте");
                } else if(x < 0) {
                    Console.WriteLine($"Точка ({x}, {y}) лежит в III квадранте");
                    ++answer3;
                } else {
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
                }
            } else {
                Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
            }
        }
        Console.WriteLine($"{answer1} точек лежит в I квадранте, {answer3} в III");
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

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        Console.WriteLine("Write -1 to stop");
        while(true) {
            double sum = 0;
            bool f = false;
            bool stop = false;
            for(int j = 0; j < 4; ++j) {
                double mark;
                double.TryParse(Console.ReadLine(), out mark);
                if(mark == -1) {
                    stop = true;
                    break;
                }
                sum += mark;
                if(mark == 2) {
                    f = true;
                }
            }
            if(stop) {
                break;
            }
            ++n;
            avg += sum;
            if(f) {
                ++answer;
            }
        }
        avg /= n * 4;
        avg = Math.Round(avg, 2);
        Console.WriteLine($"Неуспевающих учеников: {answer}, средний балл группы: {avg}");
        // end

        return (answer, avg);
    }
    #endregion
}
