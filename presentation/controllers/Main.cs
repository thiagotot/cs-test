using System.Collections.Generic;
using System;
public class Main
{
    public void ReturnRisk(List<dtoTrade> dto)
    {
        List<ITrade> portfolio = new List<ITrade>();

        foreach (var item in dto)
        {
            Trade itemTrade = new Trade();
            itemTrade.ClientSector = item.ClientSector;
            itemTrade.Value = item.Value;

            portfolio.Add(itemTrade);

        }

        List<string> lResults = ProcessRisk(portfolio, AddTradeCategorie());

        foreach (string item in lResults)
        {
            Console.WriteLine(item);
        }

    }

    public List<ITradeCategorie> AddTradeCategorie()
    {
        List<ITradeCategorie> lTradeCategorie = new List<ITradeCategorie>();
        lTradeCategorie.Add(new TradeCategorie(1000000, "Public", "less", "LOWRISK"));
        lTradeCategorie.Add(new TradeCategorie(1000000, "Public", "greater", "MEDIUMRISK"));
        lTradeCategorie.Add(new TradeCategorie(1000000, "Private", "greater", "HIGHRISK"));
        return lTradeCategorie;
    }

    public List<string> ProcessRisk(List<ITrade> portfolio, List<ITradeCategorie> tradeCategoriesRisk)
    {
        List<string> lReturnLabels = new List<string>();

        foreach (var itemPortifolio in portfolio)
        {
            foreach (var itemCatRisk in tradeCategoriesRisk)
            {
                if (itemCatRisk.ClientSector == itemPortifolio.ClientSector)
                {
                    if (itemCatRisk.Operator == "less" && itemPortifolio.Value < itemCatRisk.Value)
                        lReturnLabels.Add(itemCatRisk.Label);

                    if (itemCatRisk.Operator == "greater" && itemPortifolio.Value > itemCatRisk.Value)
                        lReturnLabels.Add(itemCatRisk.Label);
                }
            }
        }

        return lReturnLabels;

    }
}