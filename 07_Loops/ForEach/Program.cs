
//Foreach syntax
//foreach(declaredIterator in enumberableCollection)
//{
    //body
//}

//Ex:
string instructorName = "Amanda";
// make an enumberable Collection
string[] instructors = new string []{"Michael","Joshuas",instructorName};

//loop through this
//using temp variable name called instructor
//that represents a single instructor called 'instructor'
//for each iteration of the loop
foreach (string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}

int[] intArray = new int[]
{
    1,
    2,
    -3,
    4,
    5,
    0
};
foreach (int value in intArray)
{
    if(value < 0)
    {
        System.Console.WriteLine("this is a negative number!");
    }
    else if(value>0)
    {
        System.Console.WriteLine("this is a positive number!");
    }
    else
    {
        System.Console.WriteLine("This is a neutral number!");
    }
}