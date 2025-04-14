using System;

public class TestCar
{
    public static void Main(string[] args)
    {
        // Create a Car object
        Car myCar = new Car("Toyota", "Corolla", "AB123CD", 2020, 15500.50m);

        // Print full details using ToString
        Console.WriteLine(myCar.ToString());

        // Print current value and year using methods
        Console.WriteLine("Current Value: $" + myCar.GetCurrentValue());
        Console.WriteLine("Year of Registration: " + myCar.GetYear());
    }
}