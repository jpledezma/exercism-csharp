static class AssemblyLine
{
    static int baseProductionPerHour = 221;
    
    public static double SuccessRate(int speed)
    {
        double successRate;
        if (speed >= 1 && speed < 5)
        {
            successRate = 1;
        }
        else if (speed >= 5 && speed < 9)
        {
            successRate = 0.9;
        }
        else if (speed == 9)
        {
            successRate = 0.8;
        
        }
        else if (speed == 10)
        {
            successRate = 0.77;
        }
        else
        {
            successRate = 0;
        }
        
        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        double productionRate = speed * baseProductionPerHour * successRate;
        return productionRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingCarsPerHour = ProductionRatePerHour(speed);
        double workingCarsPerMinute = workingCarsPerHour / 60;
        
        return (int)workingCarsPerMinute;
    }
}
