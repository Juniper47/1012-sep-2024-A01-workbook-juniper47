// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tI LOVE MATH WEEEEE!!!!!!!!!\n");


//Create a calculator demonstrating a modular approach to the solution

//methods
//DisplayMenu() : this will display the menu for the calculator
//int GetNumber(string prompt) : this will retrieve a numeric value from the user
//void DisplayResults(int num1, int num2, double results, bool valid, string symbol) : this will display the results of the requested calculation

#region Driver
int num1 = 0;
int num2 = 0;
string choice = "";
double results = 0;
bool valid = false;
string symbol = "";
//get two numbers for the calculation
num1 = GetNumber("Enter your first number for calculation");
num2 = GetNumber("Enter your second number for calculation");
//display the choices of calculations within a menu
DisplayMenu();
choice = Console.ReadLine();

//decide and do the calculation
//switch structure
switch (choice.ToUpper())
{
    case "A": 
        {
            break;
        }
    case "B":
        {
            break;
        }
    case "C":
        {
            break;
        }
    case "D":
        {
            break;
        }

    default:
        {
            Console.WriteLine("your menu choice sucks do it again");
            break;
        }
}

//display of the calculation results
DisplayResults(num1, num2, results, valid, symbol);
#endregion

#region Methods
//methods
//DisplayMenu() : this will display the menu for the calculator
//int GetNumber(string prompt) : this will retrieve a numeric value from the user
//void DisplayResults(int num1, int num2, double results, bool valid, string symbol) : this will display the results of the requested calculation

static void DisplayMenu()
{
    Console.WriteLine("\nChoose the calculation to perform.");
    Console.WriteLine("a) ADD.");
    Console.WriteLine("b) Subtract.");
    Console.WriteLine("c) Multiply.");
    Console.WriteLine("d) Divide.");
    Console.Write("Enter your calculation choice:\t");
}

static int GetNumber(string prompt)
{
    return 0;
}

static void DisplayResults(int num1, int num2, double results, bool valid, string symbol)
{
    
}
#endregion