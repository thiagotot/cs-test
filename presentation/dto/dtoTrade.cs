public class dtoTrade 
{
    public double Value { get; set; }
    public string ClientSector { get; set; }

    public dtoTrade(double value, string clientSector)
    {
        this.Value = value;
        this.ClientSector = clientSector;
    }
}