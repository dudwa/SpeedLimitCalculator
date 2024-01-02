
using Codecool.SpeedLimitFineCalculator.Model;
using Codecool.SpeedLimitFineCalculator.Service;

namespace Codecool.SpeedLimitFineCalculator.UI;

public class FineCalculatorUi
{
    private readonly ISpeedLimitFineCalculator _speedLimitFineCalculator;

    public FineCalculatorUi(ISpeedLimitFineCalculator speedLimitFineCalculator)
    {
        _speedLimitFineCalculator = speedLimitFineCalculator;
    }

    public void Run()  {
        GreetUser();
        
        VehicleType vehicleType = SelectVehicleType();
        RoadType roadType = SelectRoadType();
        double speed = GetSpeed(); 
        
        /*var vehicleTypeE
        num = SelectVehicleType();
        var roadTypeEnum = SelectRoadType();
        var speed = GetSpeed();*/

        double fine = _speedLimitFineCalculator.CalculateSpeedLimitFine(vehicleType, roadType, speed); // calculate fine
        Console.WriteLine(speed);
        if (fine == 0)
        {
            Console.WriteLine("You are within speed limits! No fine applies.");
        }
        else
        {
            Console.WriteLine($"Your fine is {fine} CodeCoins.");
        }
    }

    private static VehicleType SelectVehicleType()
    {
        Console.WriteLine("Please choose vehicle type:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Bus");
        Console.WriteLine("3. Truck");

        int choise = int.Parse(Console.ReadLine());

        Console.WriteLine((VehicleType)(choise - 1));
        return (VehicleType)(choise - 1);
    }
    
    private static RoadType SelectRoadType()
    {
        Console.WriteLine("Please choose road type:");
        Console.WriteLine("1. Urban");
        Console.WriteLine("2. Main road");
        Console.WriteLine("3. Highway");
        
        int choise = int.Parse(Console.ReadLine());

        return (RoadType)(choise - 1);
    }

    private double GetSpeed()
    {
        Console.WriteLine("Please give me the speed of the vehicle");
        double speed = double.Parse(Console.ReadLine());
        Console.WriteLine($"{speed} + this is the first speed.");
        return speed;
    }
    

    private static void GreetUser()
    {
        Console.WriteLine(
            "Hi! You were on the road again, but you were a bit too fast, weren't you? No worries, let's see how much it will cost you!");
    }
}
