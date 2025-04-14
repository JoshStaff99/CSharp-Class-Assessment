using System;

public class Car
{
    // Fields (or you can use properties instead)
    private string make;
    private string model;
    private string registration;
    private int year;
    private decimal currentValue;

    // Constructor
    public Car(string make, string model, string registration, int year, decimal currentValue)
    {
        this.make = make;
        this.model = model;
        this.registration = registration;
        this.year = year;
        this.currentValue = currentValue;
    }

    // Method to get the current value
    public decimal GetCurrentValue()
    {
        return currentValue;
    }

    // Method to get the year
    public int GetYear()
    {
        return year;
    }

    // Override ToString to display full car info
    public override string ToString()
    {
        return $"Make: {make}, Model: {model}, Registration: {registration}, Year: {year}, Current Value: ${currentValue:N2}";
    }
}