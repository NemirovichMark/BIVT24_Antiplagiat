using System.Threading.Tasks.Dataflow;
using System.Data;
using System.Net.Mail;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
// // dotnet test --filter Tests.ProgramTests.Task_1_1Test
// public class Program
// {
//     public static void Main()
//     {
//         Program program = new Program();
//         //program.Task_1_1(0.9, 1.23);
//         //program.Task_1_2(0.9, 1.23);
//         //program.Task_1_3(0.9, 1.23);
//         //program.Task_1_4(0.9, 1.23, -0.1);
//         //program.Task_1_5(0.9, 1.23);
//         //program.Task_1_6(0.9, 1.23);
//         //program.Task_1_7(0.9);
//         //program.Task_1_8(0.9);
//         //program.Task_1_9(0.9);
//         //program.Task_1_10(0.9);
//         // program.Task_2_1(10);
//         // program.Task_2_2(5, 1, 3, 1);
//         //program.Task_2_2(5, 1.5, 1.5, 1);
//         //program.Task_2_2(5, 1, 3, 1);
//         // program.Task_2_3(6);
//         // program.Task_2_4(3, 1, 3);
//         // program.Task_2_5(6, 25.5);
//         // program.Task_2_6(3);
//         // program.Task_2_7(3);
//         // program.Task_2_8(3);
//         // program.Task_2_9(6);
//         // program.Task_2_10(6);
//         // program.Task_2_11(6);
//         // program.Task_2_12(10, 0);
//         //program.Task_2_13(10, 5, 0);
//         // program.Task_3_1();
//         // program.Task_3_2(3, 2, 1);
//         //program.Task_3_2(1.5, 1.5, 1);
//         //program.Task_3_2(1, 3, 1);
//         // program.Task_3_3();
//         // program.Task_3_4(1, 2);
//         // program.Task_3_5(30);
//         // program.Task_3_6();
//         // program.Task_3_7();
//         // program.Task_3_8();
//         // program.Task_3_9();
//         // program.Task_3_10();
//         // program.Task_3_11();
//         //program.Task_3_12(10, 0);
//         //program.Task_3_13(10, 5, 0);
//     }
//     #region Level 1
//     public bool Task_1_1(double x, double y)
//     {
//         bool answer = false;
//         // code here
//         if (Math.Abs(x*x+y*y-4) <= Math.Pow(10, -3))
//         {
//             answer = true;
//         }
//         else answer = false;
//         // end

//         return answer;
//     }
//     public bool Task_1_2(double x, double y)
//     {
//         bool answer = false;

//         // code here
//         if (y >= 0 && y + Math.Abs(x) <= 1)
//         {
//             answer = true;
//         }
//         else answer = false;
//         // end

//         return answer;
//     }
//     public double Task_1_3(double a, double b)
//     {
//         double answer = 0;

//         // code here
//         if (a > 0)
//         {
//             if (a > b) answer = a; else answer = b;
//         }
//         else if (a < b) answer = a; else answer = b;
//         // end

//         return answer;
//     }
//     public double Task_1_4(double a, double b, double c)
//     {
//         double answer = 0;
//         double min_A_B = 0;

//         // code here
//         if (a < b) min_A_B = a; else min_A_B = b;
//         if (min_A_B > c) answer = min_A_B; else answer = c;

//         // end

//         return answer;
//     }
//     public bool Task_1_5(double r, double s)
//     {
//         bool answer = false;

//         // code here
//         double d_s = Math.Sqrt(s)*Math.Sqrt(2);
//         double d_r = 2*Math.Sqrt(r/Math.PI);
//         if (d_s <= d_r) answer = true; else answer = false;
//         // end

//         return answer;
//     }
//     public bool Task_1_6(double r, double s)
//     {
//         bool answer = false;

//         // code here
//         double a_s = Math.Sqrt(s);
//         double d_r = 2*Math.Sqrt(r/Math.PI);
//         if (d_r <= a_s) answer = true; else answer = false;

//         // end

//         return answer;
//     }
    // public double Task_1_7(double x)
    // {
    //     double answer = 0;

    //     // code here
    //     if (Math.Abs(x) > 1) answer = 1;
    //     else answer = Math.Abs(x);
    //     Console.WriteLine(answer);
    //     // end

    //     return answer;
    // }
//     public double Task_1_8(double x)
//     {
//         double answer = 0;

//         // code here
//         if (Math.Abs(x) >= 1) answer = 0;
//         else answer = x*x - 1;
//         // end

//         return answer;
//     }
//     public double Task_1_9(double x)
//     {
//         double answer = 0;

//         // code here
//         if (x <= -1) answer = 0;
//         else if (-1 < x && x <= 0) answer = 1 + x;
//         else answer = 1;
//         // end

//         return answer;
//     }
//     public double Task_1_10(double x)
//     {
//         double answer = 0;

//         // code here
//         if (x <= -1) answer = 1;
//         else if (-1 < x && x <= 1) answer = -x;
//         else answer = -1;
//         Console.WriteLine(answer);
//         // end

//         return answer;
//     }
//     #endregion

//     #region Level 2
//     public double Task_2_1(int n) // dotnet test --filter Tests.ProgramTests.Task_2_1Test
//     {
//         double answer = 0;

//         // code here
//         int count = 0, height = 0;
//         for (int i=1; i<=n; i++)
//         {
//             int.TryParse(Console.ReadLine(), out height);
//             answer += height;
//             count++;
//         }
//         answer /= count;
//         answer = Math.Round(answer, 2);
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

//         return answer;
//     }
//     public int Task_2_2(int n, double r, double a, double b)
//     {
//         int answer = 0;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double x = Convert.ToDouble(Console.ReadLine());
//             double y = Convert.ToDouble(Console.ReadLine());
//             if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2)) answer += 1;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

//         return answer;
//     }
//     public double Task_2_3(int n)
//     {
//         double answer = 0;
//         // code here
//         for (int i=1; i<=n; i++) 
//         {
//             double child_height = Convert.ToDouble(Console.ReadLine());
//             if (child_height < 30) answer += 0.2;
//         }
//         answer = Math.Round(answer, 2);
//         Console.WriteLine(answer);        
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

//         return answer;
//     }
//     public int Task_2_4(int n, double r1, double r2) // dotnet test --filter Tests.ProgramTests.Task_2_4Test
//     {
//         int answer = 0;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double x = Convert.ToDouble(Console.ReadLine());
//             double y = Convert.ToDouble(Console.ReadLine());
//             if ((Math.Pow(r1, 2) <= Math.Pow(x, 2) + Math.Pow(y, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2))) answer += 1;
//             Console.WriteLine(answer);
//         }
//         // end

//         // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

//         return answer;
//     }
//     public int Task_2_5(int n, double norm)
//     {
//         int answer = 0;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double result = Convert.ToDouble(Console.ReadLine());
//             if (result <= norm) answer += 1;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

//         return answer;
//     }
//     public int Task_2_6(int n)
//     {
//         int answer = 0;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double x = Convert.ToDouble(Console.ReadLine());
//             double y = Convert.ToDouble(Console.ReadLine());
//             if ((0 <= x && x <= Math.PI) && (0 <= y && y <= Math.Sin(x))) answer += 1;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

//         return answer;
//     }
//     public (int, int) Task_2_7(int n)
//     {
//         int answer1 = 0;
//         int answer3 = 0;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double x = Convert.ToDouble(Console.ReadLine());
//             double y = Convert.ToDouble(Console.ReadLine());
//             if (x > 0 && y > 0) 
//             {
//                 Console.WriteLine(1); 
//                 answer1 += 1;
//             } 
//             else if (x < 0 && y > 0) Console.WriteLine(2); 
//             else if (x < 0 && y < 0)
//             {
//                 Console.WriteLine(3);
//                 answer3 += 1;
//             }
//             else Console.WriteLine(4);
//         }
//         Console.WriteLine(answer1);
//         Console.WriteLine(answer3);
//         // end

//         // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

//         return (answer1, answer3);
//     }
//     public (int, double) Task_2_8(int n)
//     {
//         int answer = 0;
//         double answerLength = double.MaxValue;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double x = Convert.ToDouble(Console.ReadLine());
//             double y = Convert.ToDouble(Console.ReadLine());

//             double distance = Math.Sqrt(x*x+y*y);

//             if (distance < answerLength)
//             {
//                 answerLength = distance;
//                 answer = i;
//             }
//         }
//         answerLength = Math.Round(answerLength, 2);
//         Console.WriteLine(answer);
//         Console.WriteLine(answerLength);
//         // end

//         // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

//         return (answer, answerLength);
//     }
//     public double Task_2_9(int n)
//     {
//         double answer = double.MaxValue;

//         // code here
//         for (int i=1; i<=n; i++)
//         {
//             double time = Convert.ToDouble(Console.ReadLine());
//             if (time <= answer) answer = time;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

//         return answer;
//     }
//     public int Task_2_10(int n)
//     {
//         int answer = 0;

//         // code here;
//         for (int i=1; i<=n; i++)
//         {
//             bool bad_student = false;
//             for (int j=1; j<=4; j++)
//             {
//                 int grade = Convert.ToInt32(Console.ReadLine());
//                 if (grade == 2 || grade == 3) bad_student = true;
//             };
//             if (!bad_student) answer += 1;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

//         return answer;
//     }
//     public (int, double) Task_2_11(int n)
//     {
//         int answer = 0;
//         double avg = 0.0;

//         // code here;
//         for (int i = 1; i <= n; i++)
//         {
//             bool failGrade = false;
//             double averageRating = 0;

//             for (int j = 1; j <= 4; j++)
//             {
//                 int grade = Convert.ToInt32(Console.ReadLine());
//                 if (grade == 2) failGrade = true;
//                 averageRating += grade;
//                 avg += grade;
//             }

//             if (failGrade) answer += 1;
//             averageRating /= 4;
//         }
//         avg /= n * 4;
//         Console.WriteLine(answer);
//         Console.WriteLine(avg);
//         // end

//         return (answer, avg);
//     }

//     public double Task_2_12(double r, int type) // dotnet test --filter Tests.ProgramTests.Task_2_12Test
//     {
//         double answer = 0;

//         // code here
//         if (r <= 0 || type < 0 || type > 2)
//         {
//             return 0;
//         }

//         switch (type)
//         {
//             case 0:
//                 answer = r * r;
//                 break;
//             case 1:
//                 answer = Math.PI * r * r;
//                 break;
//             case 2:
//                 answer =  r * r * (Math.Sqrt(3) / 4);
//                 break;
//         }
//         Console.WriteLine((r, type, answer));
//         answer = Math.Round(answer, 2);
//         // end
        
//         return answer;
//         }
    public double Task_2_13(double A, double B, int type) // dotnet test --filter Tests.ProgramTests.Task_2_13Test
    {
        double answer = 0;

        // code here
        if (A <= 0 || B <= 0 || (type < 0 || type > 2))
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * (Math.Pow(B, 2) - Math.Pow(A, 2));
                break;
            case 2:
                answer = (A * Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A / 2, 2))) / 2;
                break;
        }
        answer = Math.Abs(Math.Round(answer, 2));
        // end

        return answer;
    }
//     #endregion

//     #region Level 3
//     public double Task_3_1()
//     {
//         int count = 0;
//         double answer = 0;

//         while (true)
//         {
//             string input = Console.ReadLine();
//             if (input == "") break;
//             if (double.TryParse(input, out double height))
//             {
//                 answer += height;
//                 count++;
//             }
//             else
//             {
//                 Console.WriteLine("Ошибочка (для завершения ввода данных подайте пустую строку)");
//             }
//         }
//         if (count != 0)
//         {
//             answer /= count;
//             answer = Math.Round(answer, 2);
//             Console.WriteLine(answer);
//         }
//         else
//         {
//             Console.WriteLine("Не введено ни одного числового значения.");
//         }

//         return answer;
//     }
//     public int Task_3_2(double r, double a, double b)
//     {
//         int answer = 0;

//         // code here
//         while (true)
//         {
//             string x = Console.ReadLine();
//             if (x == "") break;
//             if (double.TryParse(x, out double x_double))
//             {
//                 double y = Convert.ToDouble(Console.ReadLine());
//                 if (Math.Pow(x_double - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2)) answer += 1;
//             }
//             else Console.WriteLine("Ошибочка, для завершения ввода данных подайте пустую строку");
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
//         // answer should be equal to the task_2_2 answer

//         return answer;
//     }
//     public double Task_3_3()
//     {
//         double answer = 0;

//         // code here
//         while (true)
//         {
//             string strChildHeight = Console.ReadLine();
//             if (strChildHeight == "") break;
//             if (double.TryParse(strChildHeight, out double child_height))
//             {
//                 if (child_height < 30) answer += 0.2;
//             }
//             else Console.WriteLine("Ошибочка (для завершения ввода данных подайте пустую строку)");
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
//         // answer should be equal to the task_2_3 answer

//         return answer;
//     }
//     public int Task_3_4(double r1, double r2)
//     {
//         int answer = 0;

//         // code here
//         while (true)
//         {
//             string str_x = Console.ReadLine();
//             if (str_x == "") break;
//             if (double.TryParse(str_x, out double x))
//             {
//                 double y = Convert.ToDouble(Console.ReadLine());
//                 Console.WriteLine((x, y));
//                 if ((Math.Pow(r1, 2) <= Math.Pow(x, 2) + Math.Pow(y, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2))) answer += 1;
//             }
//             else Console.WriteLine("Ошибочка (для завершения ввода данных подайте пустую строку)");
//         }
//         Console.WriteLine(answer);

//         // end

//         // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
//         // answer should be equal to the task_2_4 answer

//         return answer;
//     }
//     public int Task_3_5(double norm)
//     {
//         int answer = 0;

//         // code here
//         while (true)
//         {
//             string str_result = Console.ReadLine();
//             if (str_result == "") break;
//             if (double.TryParse(str_result, out double result))
//             {
//                 if (result <= norm) answer += 1;
//             };
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
//         // answer should be equal to the task_2_5 answer

//         return answer;
//     }
//     public int Task_3_6()
//     {
//         int answer = 0;

//         // code here
//         while (true)
//         {
//             string strX = Console.ReadLine();
//             if (strX == "") break;
//             if (double.TryParse(strX, out double x))
//             {
//                 double y = Convert.ToDouble(Console.ReadLine());
//                 if ((0 <= x && x <= Math.PI) && (0 <= y && y <= Math.Sin(x))) answer += 1;
//             }
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
//         // answer should be equal to the task_2_6 answer

//         return answer;
//     }
//     public (int, int) Task_3_7()
//     {
//         int answer1 = 0, answer3 = 0;

//         // code here
//         while (true)
//         {
//             string strX = Console.ReadLine();
//             if (strX == "") break;
//             if (double.TryParse(strX, out double x))
//             {
//                 double y = Convert.ToDouble(Console.ReadLine());
//                 if (x > 0 && y > 0) 
//                 {
//                     Console.WriteLine(1); 
//                     answer1 += 1;
//                 } 
//                 else if (x < 0 && y > 0) Console.WriteLine(2); 
//                 else if (x < 0 && y < 0)
//                 {
//                     Console.WriteLine(3);
//                     answer3 += 1;
//                 }
//                 else Console.WriteLine(4);
//             }
//         }
//         Console.WriteLine((answer1, answer3));
//         // end

//         // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
//         // answer should be equal to the task_2_7 answer

//         return (answer1, answer3);
//     }
//     public (int, double) Task_3_8()
//     {
//         int answer = 0, n = 1;
//         double answerLength = double.MaxValue;

//         // code here
//         while (true)
//         {
//             string strX = Console.ReadLine();
//             if (strX == "") break;
//             if (double.TryParse(strX, out double x))
//             {
//                 double y = Convert.ToDouble(Console.ReadLine());
//                 double distance = Math.Sqrt(x*x+y*y);

//                 if (distance < answerLength)
//                 {
//                     answerLength = distance;
//                     answer = n;
//                 }
//                 n++;
//             }
//         }
//         answerLength = Math.Round(answerLength, 2);
//         Console.WriteLine(answer);
//         Console.WriteLine(answerLength);
//         // end
        
//         // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
//         // answer should be equal to the task_2_8 answer

//         return (answer, answerLength);
//     }
//     public double Task_3_9()
//     {
//         double answer = double.MaxValue;

//         // code here
//         while (true)
//         {
//             string strTime = Console.ReadLine();
//             if (strTime == "") break;
//             if (double.TryParse(strTime, out double time))
//             {
//                 if (time <= answer) answer = time;
//             }
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
//         // answer should be equal to the task_2_9 answer

//         return answer;
//     }
//     public int Task_3_10()
//     {
//         int answer = 0;

//         // code here
//         bool flag = true;
//         while (flag)
//         {
//             bool bad_student = false;
//             for (int i=1; i<=4; i++)
//             {
//                 string strGrade = Console.ReadLine();
//                 if (strGrade == "") {flag = false; break;};
//                 if (int.TryParse(strGrade, out int grade))
//                 {
//                     if (grade == 2 || grade == 3) bad_student = true;
//                 }
//             }
//             if (!bad_student) answer += 1;
//         }
//         Console.WriteLine(answer);
//         // end

//         // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
//         // answer should be equal to the task_2_10 answer

//         return answer;
//     }
//     public (int, double) Task_3_11()
//     {
//         int answer = 0, n = 0;
//         double avg = 0.0;

//         // code here;

//         bool flag = true;
//         while (flag)
//         {
//             bool failGrade = false;
//             double averageRating = 0;
//             for (int i=1; i<=4; i++)
//             {
//                 string strGrade = Console.ReadLine();
//                 if (strGrade == "") {flag = false; break;};
//                 if (int.TryParse(strGrade, out int grade))
//                 {
//                     if (grade == 2) failGrade = true;
//                     averageRating += grade;
//                     avg += grade;
//                 }
//             }
//             if (averageRating == 0) break;
//             n += 1;
//             averageRating /= 4;
//             if (failGrade) answer += 1;
//         }
//         avg /= n*4;
        
//         Console.WriteLine(answer);
//         Console.WriteLine(avg);
//         // end

//         // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
//         // answer should be equal to the task_2_11 answer

//         return (answer, avg);
//     }
//     public double Task_3_12(double r, int type)
//     {
//         double answer = 0;

//         // code here;
//         if (r <= 0 || type < 0 || type > 2)
//         {
//             return 0;
//         }

//         switch (type)
//         {
//             case 0:
//                 answer = r * r;
//                 break;
//             case 1:
//                 answer = Math.PI * r * r;
//                 break;
//             case 2:
//                 answer =  r * r * (Math.Sqrt(3) / 4);
//                 break;
//         }
        
//         answer = Math.Round(answer, 2);
//         // end
        
//         return answer;
//     }
//     public double Task_3_13(double A, double B, int type)
//     {
//         double answer = 0;

//         // code here
//         if (A <= 0 || B <= 0 || (type < 0 || type > 2))
//         {
//             return 0;
//         }

//         switch (type)
//         {
//             case 0:
//                 answer = A * B;
//                 break;
//             case 1:
//                 answer = Math.PI * (Math.Pow(B, 2) - Math.Pow(A, 2));
//                 break;
//             case 2:
//                 answer = (A * Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A / 2, 2))) / 2;
//                 break;
//         }

//         answer = Math.Abs(Math.Round(answer, 2));
//         // end

//         return answer;
//     }
//     #endregion
// }


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
        if ((x*x+y*y-r*r<=1/1000) && (x * x + y * y - r * r >=1/1000)){
            answer = true;
        }
        else
        {
            answer = false;
        }
// end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && Math.Abs(x) + y <= 1)
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
        if (a > 0){
            if (a > b){
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if( a > b){
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
        if (a > b){
            answer = b;
        }
        else
        {
            answer = a;
        }
        if (answer < c)
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(r/Math.PI) * 2;
        double b = Math.Sqrt(s) * Math.Sqrt(2);
        if (b > a)
        {
            answer = false;
        }
        else
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
        double a = Math.Sqrt(r/Math.PI) * 2;
        if (a > Math.Sqrt(s))
        {
            answer = false;
        }
        else
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
        if ((x>1) && (x < -1))
        {
            answer = 0;
        }
        else
        {
            if (x < 0){
                answer = x * (-1);
            }
            else
            {
                answer = x;
            }
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if ((x > -1)&& (x < 1)){
            answer = (x * x) - 1;
        }
        else
        {
            answer = 0;
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
        else if ((x>-1) && (x <= 0))
        {
            answer = x + 1;
        }
        else
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if((x>-1) && (x <= 1))
        {
            answer = x * (-1);
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

        // code here
        double sr,r, s = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ���� �������");
            r = double.Parse(Console.ReadLine());
            s = s + r;
        }
        sr = s / n;
        answer = Math.Round(sr, 1);
            // end

            return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ���������� �����");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) > r * r)
            {
                answer += 0;
            }
            else
            {
                answer += 1;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double s = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ��� �����");
            double x = double.Parse(Console.ReadLine());
            if (x > 30)
            {
                s++;
            }
        }
        answer = s / 5;
            // end
            return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ���������� �");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ���������� y");
            double y = double.Parse(Console.ReadLine());
            if((x*x+y*y>=r1*r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
            }

            // end
        }
            return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ����� ������������ �");
            double x = double.Parse(Console.ReadLine());
            if (x <= norm)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ���������� �");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ���������� y");
            double y = double.Parse(Console.ReadLine());
            if ((x>=0) && (x<= Math.PI))
            {
                double r= x * (Math.PI / 180);
                if (y<= Math.Sin(r) &&(y>0))
                {
                    answer++;
                }
            }

        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ���������� �: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ���������� y: ");
            double y = double.Parse(Console.ReadLine());
            if ((y>0) && (x > 0))
            {
                answer1++;
            }
            else if ((y < 0) && (x < 0))
            {
                answer3++;
            }
        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        Console.WriteLine("������� ���������� �: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("������� ���������� y: ");
        double y = double.Parse(Console.ReadLine());
        answerLength = x * x + y * y;
        answer = 1;
        for (int i = 2; i < n + 1; i++)
        {
            Console.WriteLine("������� ���������� �: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ���������� y: ");
            y = double.Parse(Console.ReadLine());
            if (answerLength > x * x + y * y)
            {
                answerLength = x * x + y * y;
                answer = i;
            }
            answerLength= Math.Round((Math.Sqrt(answerLength)),2);
        }
            // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        Console.WriteLine("������� ����� ����������");
        double t = double.Parse(Console.ReadLine());
        answer = t;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("������� ����� ����������");
            t = double.Parse(Console.ReadLine());
            if (answer > t)
            {
                answer = t;
            }
        }
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        Console.WriteLine("������� ����� ����������");
        for (int i = 0; i < n; i++)
        {
            int s = 0;
            for(int j = 0; j < 3; j++)
            {
                s = s + int.Parse(Console.ReadLine());
            }
            if (s >= 16)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double s = 0;
        int k = 0;
        // code here;
        Console.WriteLine("������� ������ ��������");
        for (int i = 0; i < n; i++)
        {
            answer = 0;
            for(int j = 0; j < 3; j++)
            {
                if (int.Parse(Console.ReadLine()) == 2)
                {
                    answer = 1;
                }
                s = s + int.Parse(Console.ReadLine());
            }
            k = k + answer;
        }
        answer = k;
        avg = s / n;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (((type >= 0) && (type <= 2)) && (r > 0))
        {
            if (type == 0)
            {
                answer = r * r;
            }
            else if (type == 1)
            {
                answer = r * r * Math.PI;
            }
            else
            {
                answer = (r * r * Math.Sqrt(3)) / 4;
            }
        }
        else
        {
            Console.WriteLine("������������ �������� ��� ����������");
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

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