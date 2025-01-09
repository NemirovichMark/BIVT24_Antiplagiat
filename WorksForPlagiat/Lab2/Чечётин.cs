//Done
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        int i = 1;
        double member = 1;
        double a = Convert.ToInt32(Console.ReadLine());
        double x = a
        while (Math.Abs(member) > 0.0001){
            double powx = x
            if (((i+1) % 2) == 0){
                member = ((2*i - 1)*powx)/(2i+1);
            }
            else{
                member = 
            }

        }













        

        
        
        
        
        
        
        
        Program program = new Program();
        //program.Task_1_1();
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
       // program.Task_2_6(5);
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
    //public bool Task_1_1()
    // {
    //      double summa = 0;
    //      double ch = 3;
    //      double zn = 4;
    //      int n = Convert.ToInt32(Console.ReadLine());
    //      for (int i = 1; i <=n; i++){
    //         summa += (ch/zn);
    //         ch++;
    //         zn++;
    //      }
    //      System.Console.WriteLine(summa);
    // }

    public bool Task_1_2(double x, double y)
    {
        //  int i = 1;
        //  double summa = 0;
        //  double x = 3;
        //  double zn = x;
        //  double ch = i*i;
        // while ((Math.Abs(ch/zn)) > 0.0001){
        //     summa += (ch)/(zn);
        //     System.Console.WriteLine(ch);
        //     System.Console.WriteLine(zn);
        //     i++;
        //     zn*=x;
        //     ch = i*i;

        // }
        // System.Console.WriteLine(summa);

        // return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        double c;
        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        else
        {
            if (a > b)
            {
                c = b;
            }
            else
            {
                c = a;
            }
        }
        answer = c;
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double z;
        double m;
        if (a > b)
        {
            m = b;
            if (m > c)
            {
                z = m;
            }
            else
            {
                z = c;
            }
        }
        else
        {
            m = a;
            if (m > c)
            {
                z = m;
            }
            else
            {
                z = c;
            }
        }
        answer = z;
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double diam = 2 * Math.Sqrt(r / Math.PI);
        double diag = Math.Sqrt(2*s);
        if (diag <= diam)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double diam = 2 * Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        if (diam <= a)
        {
            answer = true;
        }
        
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        double y;
        
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        answer = y;

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double y;
        
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = Math.Pow(x,2) - 1;
        }
        answer = y;


        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        double y = 0;
        
        if (x <= -1)
        {
           y = 0;
        }
        if (x > 0)
        {
            y = 1;
        }
        if (x > -1 && x <=0)
        {
            y = 1 + x;
        }
        answer = y;


        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        double y = 0;
        
        if (x <= -1)
        {
           y = 1;
        }
        if (x > 1)
        {
            y = -1;
        }
        if (x > -1 && x <=1)
        {
            y = -x;
        }
        answer = y;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double height;
        double sum = 0;
        for (int i = 1;i <= n; i++)
        {
            height = double.Parse(Console.ReadLine());
            sum += height;
        }
        answer = sum / n;
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        int counter = 0;
        double distanceFromCenter = 0;
        double x;
        double y;
        for(int i = 1; i <= n; i++)
         {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            distanceFromCenter = Math.Sqrt(Math.Pow((x - a), 2) + Math.Pow((y-b),2));
            if (distanceFromCenter <= r)
            {
                counter +=1;
            }
         }
        System.Console.WriteLine(counter);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight;
        double summa = 0;
        for (int i = 1; i <= n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                summa += 0.2;
            }
        }
        System.Console.WriteLine(summa);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double distanceFromCenter = 0;
        double x;
        double y;
        int counter = 0;
        for(int i = 1; i <= n; i++)
         {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            distanceFromCenter = Math.Sqrt(Math.Pow((x), 2) + Math.Pow((y),2));
            if (distanceFromCenter <= r2 && distanceFromCenter >= r1)
            {
                counter +=1;
            }      
        }
    counter = answer;
    return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double timing;
        int counter = 0;
        
        for(int i = 1;i <= n; i++)
        {
            timing = double.Parse(Console.ReadLine());
            if (timing <= norm){
                counter += 1;
            }
            
        }
        System.Console.WriteLine(counter);
        answer = counter;
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        int counter = 0;


        for(int i = 1; i <= n; i++){
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if(x >=0 && x<=Math.PI && Math.Sin(x) >= y && y >=0){
                counter +=1;
            }
        }
        System.Console.WriteLine(counter);
        answer = counter;
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int counter1 = 0;
        int counter3 = 0;
        double x;
        double y;

        for(int i = 1; i <=n; i++){
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        
        if(x > 0 && y > 0 ){
            counter1 +=1;
            System.Console.WriteLine("1 Квадрант");
        }
        else if(x < 0 && y > 0 ){
            System.Console.WriteLine("2 Квадрант");
        }
        else if(x < 0 && y < 0 ){
            counter3 +=1;
            System.Console.WriteLine("3 Квадрант");
        }
        else if(x > 0 && y < 0 ){
            System.Console.WriteLine("4 Кваддрант");
        }
        }
        System.Console.WriteLine("Количество 1 квадрантов: " + counter1);
        System.Console.WriteLine("Количество 3 квадрантов: "+ counter3);
        answer1 = counter1;
        answer3 = counter3;
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double s = Math.Pow(10, 10);
        double x;
        double y;
        int number = 0;
        for(int i = 1; i <=n; i++){
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        if(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < s){
            s = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            number = i;
        } 
        }
        System.Console.WriteLine(number);
        System.Console.WriteLine(s);
        answerLength = s;
        answer = number;
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double best_result = 0;

        if (n==0){
            answer = 0;
        }
        else{
        for (int i = 1; i <= n; i++){
            best_result = double.Parse(Console.ReadLine());

            if (best_result<answer){
                answer = best_result;
            }
        }
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int flag;
        int grade;

        for(int i = 1; i <= n; i++){
            flag = 1;
            for(int j = 1; j <=4; j++){
                grade = int.Parse(Console.ReadLine());
                if (2 <= grade && grade <= 3){
                    flag = 0;
                }
                else{
                    continue;
                }
            }
                if(flag == 0){
                    answer +=1;
                }
            }
            System.Console.WriteLine(answer);
            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        double sum_grades = 0;
        double count = 0;
        for (int i = 1; i <= n; i++){
            int flag = 0;
            for (int j = 1; j <= 4; j++){
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3){
                    flag = 1;
                }
                sum_grades += grade;
                count++;
            }
            if (flag == 1){
                answer++;
            }
        avg = Math.Round(sum_grades/count, 2);
        }
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if(r>0){
        switch (type){
            case 0:
                answer = r*r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = Math.Sqrt(3) * r * r / 4.0;
                break;
            default:
                answer = 0;
                break;
        }
        }
        else{
            answer = 0;
        }
        answer = Math.Round(answer,2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if(A > 0 & B > 0){
            switch (type){
            case 0:
                answer = A*B;
                break;
            case 1:
                answer = Math.Abs((Math.PI * A * A) - (Math.PI * B * B));
                break;
            case 2:
                answer = A/4 * Math.Sqrt(4*B*B - A*A);
                break;
            default:
                answer = 0;
                break;
        }
        }
        else{
            answer = 0;
        }
        answer = Math.Round(answer,2);
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
        double weight;
        double summa = 0;
        System.Console.WriteLine("To end the input please enter 0");

        while (true){
            weight = int.Parse(Console.ReadLine());
            if ( weight == 0){
                break;
            }
            else{
                summa +=0.2;
            }
        }
        answer = Math.Round(summa, 2);
        System.Console.WriteLine(answer);


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
        double x;
        double y;
        int counter = 0;
         System.Console.WriteLine("To end the input please enter stop");

        while (true){
            string input = (Console.ReadLine());
            if(input == "stop"){
                break;
            }
            x = Convert.ToDouble(input); 
            y = double.Parse(Console.ReadLine());
            if(x >=0 && x<=Math.PI && Math.Sin(x) >= y && y >=0){
                counter +=1;
            }

        }
        answer = counter;
        System.Console.WriteLine(answer);
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
        double best_result;
        System.Console.WriteLine("To end the input please enter stop");

        while (true){
            string input = (Console.ReadLine());
            if(input == "stop"){
                break;
            }
            best_result = Convert.ToDouble(input); 
            if(best_result < answer){
                answer = best_result;
            }
            }
        System.Console.WriteLine(answer);
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