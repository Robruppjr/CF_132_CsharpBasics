//For loops 

//executes a statement or a block of code while the specified boolean expression
//evaluates to true. 
//behind the scenes a for loop is a while loop 

//Syntax:
//for (intializer; condition; iterator)
//{
    // body
//}

//Ex: 
int number = 100;
//1     //2         //3      //4
for (int i = 0; i < number; i++)
{
    //5
    Console.WriteLine(i);
}

//1 - for keyword
//2 -Declaraation of variable
//3 - Boolean expression (will run as long as the expression is true)
//4 - Increment the iterator at the end of each of loop
//5- body of the loop (whats performed)

//Challenge
//Promt the user for a number to count to from zero
System.Console.WriteLine("Give me a number to count from zero to! (no greater than 50)");
//Take the input from the user and write to the console

int userInput =  int.Parse(Console.ReadLine());
//all numbers from zero to the number given by the user.
//This should be inclusive (zero and the number given to you the console should appear)
for (int i = 0; i <= userInput; i++)
{
    System.Console.WriteLine(i);
}