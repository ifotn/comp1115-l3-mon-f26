// Ex 1: Lab 1 redo w/variable
/*Console.WriteLine("Enter your birth year");

// create an integer variable (whole #) to store the user's input. convert input from string to int.
int year = int.Parse(Console.ReadLine());

// create int var to calculate and store user's age
int age = 2026 - year;

// display output showing user's age on birthday in 2026
Console.WriteLine("In 2026 you will be " + age + " years old");
Console.WriteLine($"In 2026 you will be {age} years old"); */

// Ex 2: simple addition using vars
/*Console.WriteLine("Enter 1st #");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd #");
int y = int.Parse(Console.ReadLine());

int z = x + y;
Console.WriteLine($"{x} + {y} = {z}"); */

// Ex 3 - Calorie Counter
Console.WriteLine("Enter breakfast calories");
int breakfast = int.Parse(Console.ReadLine());

Console.WriteLine("Enter lunch calories");
int lunch = int.Parse(Console.ReadLine());

Console.WriteLine("Enter dinner calories");
int dinner = int.Parse(Console.ReadLine());

// processing / calculations
int total = breakfast + lunch + dinner;
int averageCalories = total / 3;

// outputs
Console.WriteLine($"You ate {total} total calories for an average of {averageCalories} per meal.");