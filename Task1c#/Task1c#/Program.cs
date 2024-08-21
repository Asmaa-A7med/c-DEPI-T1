using System.Threading.Channels;

namespace Task1c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1: Write a C# program that prints your name, age, and favorite hobby on separate lines.
            #region qustion 1
            /** 
              Console.WriteLine(" please enter your name : ");
              string name = Console.ReadLine();
              Console.WriteLine(" please enter your age :");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine(" Enter your hobbies ");
              string hobby = Console.ReadLine();
              Console.WriteLine($"your name : {name}\n your age : {age} \n your fav hobbies : {hobby}");
            **/
            #endregion

            //Question 2: Write a C# program that declares variables of different data types (int, double, string, bool) and assigns them values.
            //Then, print these values to the console.
            #region question 2 
            /**
            int number = 10;
            double num2 = 15.236;
            string city = " tanta ";
            bool light = false;

            Console.WriteLine($"number = : {number}\n double number : {num2}\n city : {city} \n light is : {light}");
            **/
            #endregion

            //Question 3: Write a C# program that converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
            #region question 3
            /**
             Console.WriteLine(" enter the temprature in celsius :" );
            float CelsiusTemp = float.Parse( Console.ReadLine() );
            double fahrenheit = (CelsiusTemp * 1.8) + 32;
            Console.WriteLine($"Temprature in fahrenheit is : {fahrenheit}");
            **/
            #endregion
            //Question 4: Write a C# program that takes two numbers as input and performs the following operations:
            //addition, subtraction, multiplication, and division. Print the results of each operation.
            #region question 4 
            /** 
             Console.WriteLine(" enter the first number :");
              double num1=double.Parse(Console.ReadLine());
              Console.WriteLine( "enter the seconde number :");
              double num2=double.Parse(Console.ReadLine());
               
              double addition= num1+num2;
              double sub = num1 - num2;
              double multi = num1 * num2;
              double div = num1 / num2;
              Console.WriteLine($" addition = {addition}\n subtraction =  {sub}\n multiplication = {multi}\n division = {div}");
            **/
            #endregion
            //Question 5: Write a C# program that calculates the area of a rectangle.
            //The program should prompt the user to enter the length and width of the rectangle, and then calculate and display the area.
            #region question 5
            /**
            Console.WriteLine(" enter the length :");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the width :");
            double width=double.Parse(Console.ReadLine());
            Console.WriteLine($"Area of the rectangle = {width*length}");
            **/
            #endregion
            //Write a C# program that takes an integer as input and checks if it is even or odd. Print a message indicating whether the number is even or odd.
            #region question 6 
            
            Console.WriteLine("enter the number : ");
            int num= int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ?"Even":"Odd");
            
            #endregion
            // Write a C# program that prompts the user to enter their age. If the age is 18 or older, print "You are eligible to vote.
            // " If the age is less than 18, print "You are not eligible to vote."
            #region question 7
            /**
            Console.WriteLine("enter your age ");
            int age =int.Parse(Console.ReadLine());
            if (age >=18) 
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            **/
            #endregion

            //Question 8: Write a C# program that simulates a simple grading system.
            #region question 8
            /**
            Console.WriteLine(" enter your score from 0 to 100 ");
            float score=float.Parse(Console.ReadLine());
            if (score >=90 && score<=100 ) 
            {
                Console.WriteLine("your grade is : A ");
            }
            else if(score >=80 && score <=89)
            {
                Console.WriteLine(" your grade is : B");
            }else if(score >=70 && score <= 79)
            {
                Console.WriteLine(" your grade is : C");
            }else if (score >=60 && score <= 69)
            {
                Console.WriteLine("your grade is : D");
            }else if (score < 60)
            {
                Console.WriteLine("your grade is : F ");
            }else 
            {
             Console.WriteLine("Invalid score entered, please enter from 0 to 100 ");
            }

            **/
            #endregion
            // CALCULATOR TASK 
            #region calculater task
            /**
            Console.WriteLine(" enter the first number :");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("choose  the operation '+' or '-' or '/' or '*' ");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the seconde number :");
            double num2 = double.Parse(Console.ReadLine());
            
            if (operation == '+')
            {
                Console.WriteLine($"the result of {num1}+ {num2}={num1 + num2}");
            } else if (operation == '-')
            {
                Console.WriteLine($"resukt of {num1}-{num2}= {num1-num2} ");
            }else if (operation == '*')
            {
                Console.WriteLine($"result of {num1}*{num2}={num1 * num2}");
            }else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Exeption , please enter anthor number ");
                }
                else
                {
                    Console.WriteLine($"result of {num1}/{num2}={num1 / num2}");
                }
            }
            else
            {
                Console.WriteLine("please choose valod operator ");
            }

           **/
            #endregion
            #region coins
            Console.WriteLine("enter number");
           // int num=int.Parse(Console.ReadLine());
            double result = num % 100;
            #endregion
        }


    }
}

 