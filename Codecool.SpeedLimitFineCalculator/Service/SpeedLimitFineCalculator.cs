using Codecool.SpeedLimitFineCalculator.Model;

namespace Codecool.SpeedLimitFineCalculator.Service;

public class SpeedLimitFineCalculator : ISpeedLimitFineCalculator
{
    private readonly IVehicleLimitCalculator _vehicleLimitCalculator;

    public SpeedLimitFineCalculator(IVehicleLimitCalculator vehicleLimitCalculator)
    {
        _vehicleLimitCalculator = vehicleLimitCalculator;
    }

    public double CalculateSpeedLimitFine(VehicleType vehicleType, RoadType roadType, double actualSpeed)
    {
        double vehicleLimit = _vehicleLimitCalculator.GetVehicleLimitByRoadType(vehicleType, roadType);

        if (actualSpeed <= vehicleLimit)
        {
            Console.WriteLine($"{vehicleLimit} + ok");
            return 0;
        }
        else
        {
            double fineAmount = (actualSpeed - vehicleLimit) * 10;
            Console.WriteLine($"{vehicleLimit} + You must to pay");
            return fineAmount;
        }
    }
}