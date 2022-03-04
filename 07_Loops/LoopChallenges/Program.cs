//Loops Challenges:

//Bronze:
//Write a for loop to print the numbers 500 through 525.
// for (int i = 500; i <= 525; i++)
// {
//     System.Console.WriteLine(i);
// }

//Silver:
//Create a for loop to print the numbers from 0-100 by 5's.
// for (int i = 0; i <= 100; i+=5)
// {
//     System.Console.WriteLine(i);
// }
//Gold:
//Create a for loop to print the numbers 1-100. 
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}
//If the number is divisible by 3, print 'Fizz' instead of the number. 
//If it's divisible by 5, print 'Buzz', instead of the number. 
//If it's divisible by both 3 and 5, print 'FizzBuzz' otherwise print the number.