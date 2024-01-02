using Codecool.SpeedLimitFineCalculator.Model;

namespace Codecool.SpeedLimitFineCalculator.Service;

public interface IVehicleLimitCalculator
{
    double GetVehicleLimitByRoadType(VehicleType vehicleType, RoadType roadType);
}