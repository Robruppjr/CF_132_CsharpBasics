//Arithmetic operators perfom operations with numeric operands

// addition (+)
//Ex: bankAccount +12

//subtraction (-)
//Ex: rations -1

//multiplication (*)
//Ex: total * taxPercentage

//division (/)
//Ex: markes /studentCount
//This gets how many times the value held by 'markers' can be divided into the value held
//by the variable student count

//remainder operator (%. known as modulus)
//Ex: 10 %3 , would return 1 (the remainder left over)
//determines even adn odd values

//Unary operators 
//Ex: increment ++ add by one, decrement -- remove by one

//Assume that studentCount holds a value of 30
int studentCount = 30;

//adding one to studentCount 
//studentCount+=1; we can do it this way
studentCount++;

//Decrement ;studentCount' by 1
// studentCount-=1; we can do it this way
studentCount--;

//More Examples:

//addition
int additionResult = 5+2;
System.Console.WriteLine("5+2 = " + additionResult);

//subtratction
int subtractionResult = 5-2;
System.Console.WriteLine("5-2 = " + subtractionResult);

//multiplication
int multiplicationResult = 5*2;
System.Console.WriteLine("5*2 = " + multiplicationResult);

//division
int divisionResult = 5/2;
System.Console.WriteLine("5/2 = " + divisionResult);

//Modulus
System.Console.WriteLine(10%2);

System.Console.WriteLine(10%9);

System.Console.WriteLine(16%3);

System.Console.WriteLine(19%5);
