//Loops
//purpose use to repeat operations w/n an application
//We have to define the operation, functionality, and 'wrap' a loop around it.
//loop will have specific iterations it needs to execute before ending.

//Declare a variable -> used fir ur loops boolean expression
int number = 0; //starting point

//While the value in number is less than or eqaul to 100 then do the following:
while (number <=100)
{
   //Writing the value of number to the console
    System.Console.WriteLine(number);
   //incrementing number by 5 -> each iteration.
    number+=5;
}

//Infinite loops (our enemy....)
//while (number == 0)
//{
//    System.Console.WriteLine("Oh, S**t!");
//}

//What can we do to kinda control this behavior
int value2 =100;
while(value2 > 0)
{
    value2--;
    if(value2== 90)
    {
        System.Console.WriteLine("We just jumped out of the while loop!");
        break;
    }
    if (value == 80)
    {
        System.Console.WriteLine("We'll just return (leave the loop)");
        return;
    }
    if (value == 10)
    {
        System.Console.WriteLine("We'll just carry on with the loop.");
    }
}