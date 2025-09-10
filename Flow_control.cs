//flow control in c#



// if..else, if...else if and nested statements
//testing when a condition is inevitable in programming


//C# if (if-then) Statement -will execute a block of code if the given condition is true. 


if (boolean - expression/ condition)
{
    // statements executed if boolean-expression is true
}







if (number < 5)
{
    number += 5;
}






if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}







int x = 30;
 int y = 18;
if (x > y)
  {
    Console.WriteLine("x is greater than y");
}









//the statement will be executed oonly if the value of number is less than 5.

//example


using System;

namespace Conditional
{
              class IfStatement
     {
        public static void Main(string[] args)
        {
            int number = 2;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }

      
    }
}


// output will be:

2 is less than 5











// C# if...else (if-then-else) Statement



//block of code inside the elsse statement will be executed if the expression is evaluated to false







if (condition)
{
    // block of code to be executed if the condition is True
}
else
{
    // block of code to be executed if the condition is False
}








int time = 20;
if (time < 18)
  {
    Console.WriteLine("Good day.");
}
else
  {
    Console.WriteLine("Good evening.");
  }
// Outputs "Good evening.











    using System;

namespace Controlflow
{
    class IfElseStatement
    {
        public static void Main(string[] args)
        {
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is greater than or equal to 5", number);
            }

            
        }
    }



    //output 

    12 is greater than or equal to 5


















//C# if...else if (if-then-else if) Statement      

//multiple condition to tsest and execute one of the many block of code.


           string vehicle = "vehicle";


        //syntax

if (boolean-expression-1)
{
	// statementss executed if boolean-expression-1 is true
}
else if (boolean - expression - 2)
{
    // statements executed if boolevan-expression-2 is true
}
else if (boolean - expression - 3)
{
    // statements executed if boolean-expression-3 is true
}
.
.
.
else
{
    // statements executed if all above expressions are false
}






using System;

namespace Controlflow
{
    class IfElseIfStatement
    {
        public static void Main(string[] args)
        {
            int number = 11;

            if (number < 3)
            {
                Console.WriteLine("{0} is less than 3", number);
            }
            else if (number > 3)
            {
                Console.WriteLine("{0} is greater than 3", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 3");
            }
        }
    }
}













//Nested if...else Statement


// when a statement exist within another if ..else statement

if (boolean - expression)
     {
    if (nested - expression - 1)
      {
        // code to be executed
       }
    else
       {
        // code to be executed
       }
}
else
{
    if (nested - expression - 2)
       {
        // code to be executed
    }
    else
    {
        // code to be executed
    }
}







int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}











using System;
 
namespace Controlflow
  {
    class Nested
        { 
        public static void Main(string[] args)
          
            int first = 7, second = -23, third = 13;
            if (first > second)
            {
                if (firstNumber > third)
                {
                    Console.WriteLine("{0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("{0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            
        }
    }
}







            //   Short fHand If...Else (Ternary Operator)

// variable = (condition) ? expressionTrue :  expressionFalse;



//Used for simple one-line conditional assignments.

int age = 20;
string status = (age >= 18) ? "Adult" : "Minor";   
Console.WriteLine(status); // Output: Adult













using System;

namespace Controlflow
{
    class Ternary
    {
        public static void Main(string[] args)
        {
            int number = 2;
            bool isEven;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
        }
    }
}



//output = true











//C# for loop



//for loop  - repeatedly execute a certain block of statements until some condition is met.



for (initialization; condition; iterator)
  {
    // body of for loop
}
 





using System;

namespace Loop
{
        class ForLoop
      {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
            }
        }
      }
}






//outp


C# For Loop: Iteration 1
C# For Loop: Iteration 2
C# For Loop: Iteration 3
C# For Loop: Iteration 4
C# For Loop: Iteration 5










//How for loop works?
C# for looop has three statements: initialization, condition and iterator.
The initialization statement is executed at first and only once. Here, the variable is usually declared and initialized.
Then, the condition is evaluated. The condition is a boolean expression, i.e. it returns either true or false.
If the condition is evaluated to true:
The statements inside the for loop are executed.
Then, the iteratoor statement is executed which usually changes the value of the initialized variable.
Again the condition is evaluated.
The process continues until the condition is evaluated to false.
If the condition is evaluated to false, the for loop terminates.





//for loop to compute sum of first n natural numbers




using System;

namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int n = 5, sum = 0;

            for (int i = 1; i <= n; i++)
            {
                // sum = sum + i;
                sum += i;
            }

            Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);
        }
    }
}





//  output-  Sum of first 5 natural numbers = 15





//




// C# while and do...while loop


while (test - expression)
{
    // body of while
}




// How while loop works?
C# while loop conasists of a test-expression.
If the test-expression is evaluated to true,
statements inside the while loop are executed.
after execution, the test-expression is evaluated again.
If the test-expression is evaluated to false, the while loop terminates.





using System;

namespace Loop



{



    class WhileLoop


    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }
        }
    }
}



// output  



C# For Loop: Iteration 1
C# For Loop: Iteration 2
C# For Loop: Iteration 3
C# For Loop: Iteration 4
C# For Loop: Iteration 5





//cover    nested loops, break  statements , switch statements, goto and continue statements  