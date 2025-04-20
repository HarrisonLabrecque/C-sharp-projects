using System;

namespace Calc
{
    class Calc{
        public static void Main(string[] args){

        double num1 = 0.00;
        double num2 = 0.00;
        double res = 0.00;
        int option = 0;
        string choice = "";
        

        Console.WriteLine("Welcome to the Basic Calculator");

        do{
            Console.WriteLine("Enter in the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            do{
            Console.WriteLine("Here is a list of operations:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Which operation would you like to perform?");
            option = Convert.ToInt32(Console.ReadLine());

            if (option < 1 || option > 4){
                Console.WriteLine("Please enter in a valid operation (1-4)");
            }

            }while(option < 1 || option > 4);

            switch(option){

                case 1:
                    res = Add(num1,num2);
                    break;
                
                case 2:
                    res = Sub(num1,num2);
                    break;
                
                case 3:
                    res = Mult(num1,num2);
                    break;

                case 4:
                    res = Div(num1,num2);
                    break;
                
            }

            Console.WriteLine("The result is {0:F2}", res);


            Console.WriteLine("Would you like to perform another operation?");
            choice = Console.ReadLine();



        }while(choice != "N" && choice != "n");
    }
    public static double Add(double a, double b){
        return a + b;
    }
    public static double Sub(double a, double b){
        return a - b;
    }
    public static double Mult(double a, double b){
        return a * b;
    }

    public static double Div(double a, double b){
         if (b == 0){
        Console.WriteLine("Cannot divide by zero.");
        return 0;
        }   
        return a / b;
    }
    
    }
}