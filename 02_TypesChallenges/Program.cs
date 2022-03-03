//Bronze
// For this challenge go ahead and create a list of variables using the following data types: int ,string ,bool ,decimal ,float ,doublie , and ulong . For each of these types, do the following:
// Make at least two examples for each type
// Make one a declaration only
// Declare and initialize the other
// Once you have your variables, go ahead and print some of these values to the console.

int age = 24;

int yearsRunning = 10;
System.Console.WriteLine(yearsRunning);

string m = "Top of the Morning!";
string e = "Bottom of the Evening";
System.Console.WriteLine(e);

bool isLoggedin = true;
bool isAsleep = false;
System.Console.WriteLine(isAsleep);

decimal cashOnHand = 20.25m;
decimal ammountWithDrawn = 4000.57m;
System.Console.WriteLine(ammountWithDrawn);

float f = 10.987654423210098706084894f;
float h = 3.14159265358979323846264338f;
System.Console.WriteLine(3.14159265358979323846264338f);

double db = 10.987654423210098706084894d;
double dc = 3.14159265358979323846264338d;
System.Console.WriteLine(3.14159265358979323846264338d);

ulong L = 7800086454654120;
ulong LL = 12345678912345678912;
System.Console.WriteLine(LL);

//silver
// Concatenate two string variables. If you don't remember how to do that, check the Microsoft Docs here (Links to an external site.).
// Next, try to concatenate a number with a string as well and see what happens.
// Finally, print the results to the console.

string silverChallenge = e + " " + m;
System.Console.WriteLine(silverChallenge);
string silverChallengeA = m + " " + 7;
System.Console.WriteLine(silverChallengeA);

//Gold
//Create a variable to hold a year.
//ask the user to enter a string value that represents a year (whole number)
//The catch for this challenge is that you want to gather the value for the year as an int .
//Your task will be to research how to convert a string to an integer in C#.
// Once you have accomplished this, display the year in the console.
System.Console.WriteLine("What Year is it?");
string currentYear = Console.ReadLine();
int y = Convert.ToInt32(currentYear);
System.Console.WriteLine("The Current Year is " + y);