namespace MetacriticScraperCore.Interfaces
{
    public interface IParameterData
    {
        string ParameterString { get; set; }
        string GetParameterValue(string parameter);
    }
}
