//Strings

//Just a collection of characters stored and used throughout an application in different ways
//Almost any text, single character, or number can be a string

//in C3 we can initialize string by using double qoutes("") wrapped around the value

//# waus to use a string type
//Concatenation
//Composite Formatting
//Interpolation

//Concatentation
string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

string concatenatedResult = first + " " + second;
//Basically taking the varaibles and  (+) them to one another
// we also added thge " " as well.
System.Console.WriteLine(concatenatedResult);

//Composite Formatting
//using {} braces inside of the string itself with a number inside the braces
string firstName = "Jenn";
string lastName = "Williams";

//now we need to use string.Format method
string compositeResult = string.Format ("Her is {0} {1}",firstName,lastName);
System.Console.WriteLine(compositeResult);

//String Interpolation
//Allows you to simply put a variable directly into the string.
string interpolationResult = $"Her name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);

//Challenge
//Practice these three ways of joining strings (3) more examples of each

//Concatenation Challenge

string start = "My favorite Video Game is";
string finish = "Legend of Zelda: Breath of the Wild";
string challengeResult = start + " " + finish;

string firstA = "There are only two types of pizza";
string secondA = "Cheese and Pizza with toppings";
string challengeAResult = firstA + ":" + secondA;

string firstB = "his name is";
string secondB = "John Jacob";
string thirdB = "JingleHimmer Schmitd";
string challegneBResults = firstB + " " + secondB + " " + thirdB;

//Composite Formatting Challenge

string compositeChallengeA = string.Format("Robert Declared: {0} {1}",start,finish);
System.Console.WriteLine(compositeChallengeA);
string compositeChallengeB = string.Format("It is an opinion that {0} {1}",firstA,secondA);
System.Console.WriteLine(compositeChallengeB);
string compositeChallengeC = string.Format("Rumor has it {0} {1} {2}",firstB,secondB,thirdB);
System.Console.WriteLine(compositeChallengeC);

//Interpolation Challenge
string interpolationChallengeA = $"Robert declared: {start} {finish}.";
string interpolationChallengeB = $"It is an opinion that {firstA} {secondA}.";
string interpolationChallengeC = $"Rumor has it {firstB} {secondB} {thirdB}.";
System.Console.WriteLine(interpolationChallengeC);