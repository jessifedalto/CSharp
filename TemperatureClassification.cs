
public class Temperature
{
    TemperatureClassification Classify(int temperature)
        => temperature switch
        {
            >30 => TemperatureClassification.Hot,
            <15 => TemperatureClassification.Cold,
            _ => TemperatureClassification.Ok // UNDERLINE É DEFAULT
        };

    public enum TemperatureClassification
    {
        Hot,
        Ok,
        Cold
    }
}