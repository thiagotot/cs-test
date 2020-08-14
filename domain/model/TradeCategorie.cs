
public class TradeCategorie:ITradeCategorie 
{
    public double Value { get; set; }
    public string ClientSector { get; set; }
    public string Operator { get; set; }
    public string Label { get; set; }

    public TradeCategorie(double Value , string ClientSector, string Operator, string Label)
    {
        this.Value = Value;
        this.ClientSector = ClientSector;
        this.Operator = Operator;
        this.Label = Label;
    }
   
   
}