Console.WriteLine("Please insert 4 numbers to find out their average.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int fourthNumber = Convert.ToInt32(Console.ReadLine());
int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + average);
