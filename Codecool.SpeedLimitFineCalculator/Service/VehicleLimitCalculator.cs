using Codecool.SpeedLimitFineCalculator.Model;

namespace Codecool.SpeedLimitFineCalculator.Service;

public class VehicleLimitCalculator : IVehicleLimitCalculator 
{
    public double GetVehicleLimitByRoadType(VehicleType vehicleType, RoadType roadType)
    {
        switch (vehicleType)
        {
            case VehicleType.Car:
                return GetCarLimitByRoadType(roadType);
            case VehicleType.Bus:
                return GetBusLimitByRoadType(roadType);
            case VehicleType.Truck:
                return GetTruckLimitByRoadType(roadType);
            default:
                throw new AggregateException("Invalid vehicle type.");
        }
    }

    public double GetCarLimitByRoadType(RoadType roadType)
    {
        switch (roadType)
        {
            case RoadType.Urban:
                return 50;
            case RoadType.MainRoad:
                return 90;
            case RoadType.Highway:
                return 120;
            default:
                throw new ArgumentException("Invalid road type.");
        }
    }

    public double GetBusLimitByRoadType(RoadType roadType)
    {
        switch (roadType)
        {
            case RoadType.Urban:
                return 40;
            case RoadType.MainRoad:
                return 70;
            case RoadType.Highway:
                return 90;
            default:
                throw new AggregateException("Invalid road type.");
        }
    }

    public double GetTruckLimitByRoadType(RoadType roadType)
    {
        switch (roadType)
        {
            case RoadType.Urban:
                return 30;
            case RoadType.MainRoad:
                return 70;
            case RoadType.Highway:
                return 90;
            default:
                throw new AggregateException("Invalid road type.");
        }
    }
}