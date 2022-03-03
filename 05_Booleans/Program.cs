//Booleans

//can hold true or values

bool isCool = false;
isCool = true;

//Boolean logical operators
//Operators that perfomr logical operationg and assements
//these use the keywords AND, OR, NOT, etc.

//NOT
//C# has the logical negation operator, or more commonly known as the bang operator
// "!iscCool" this evaulates to the oppistie of whatever value isCool is holding

//AND 
//C# uses apersand (&) to indicate AND statements
// A single ampersand evaluates both conditions always
//where a double ampersnad only evaluates the righjt side if its required.

//OR
//C# uses pipes (|) to indicate OR statements
//Similar to AND, one pipe checks both conditions and
//two pips evaluates left side frist then the right

//XOR
//C# uses the caret character (^) to indicate XOR statments.
//--Boolean Logical Operators
//Negation operator
bool isTrue =!false; //true
bool isFalse =!true; //false

//And Operator
bool trueAndExample = true && true; // true -> both of these HAVE to be true
bool falseAndExample = true && false; //false

//Or Operator
bool trueOrExample = true || false; // onl one of these have to pass!
bool falseOrExample = false || false; 

//XOR Operator
bool trueExclusiveOr = true ^ false; // true
bool falseExclusiveOr = true ^ true; //false;
bool falseExclusiveOr2 = false ^ true; //false;

System.Console.WriteLine($"Not False = {isTrue}");
System.Console.WriteLine($"False AND True = {falseAndExample}");
System.Console.WriteLine($"True or True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {falseExclusiveOr}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

//Comparison operators

//Equal
//To declare that values are equal, you must use two equal signes (==).

//Not Equal
//In C# we use (!=) to indicate the values given are not equal

//Greater Than
//C# uses the (>) indicates Greater Than.
//Evalutes to True if the left side is indeed greater than the right

//Greater Than or Equal
//C# uses the (=>) operator
//uses angle bracket but uses equal sign to end or indicate that it can include this value.

//Less than
//C# uses the (<) to indicate Less Than.
//Evaluates to True if the left side is indeed less than the right
//This does not include equal values. 10 is not leess than 10

//Less Than or Equal
//C# uses the (<=) operator
//uses the angel bracket but uses the equal sign to end or idcate that it can include this value.

//Examples:
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");


bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <= 5;
System.Console.WriteLine($"5 < 5 is {isLessThan}, and 5 <= 5 is {isLessThanOrEqualTo}");

bool equality = 17 == 9;
bool inequality = 17 != 9;
System.Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectfully.");