using System;
using System.Collections.Generic;

namespace cs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main();

            List<dtoTrade> dto = new List<dtoTrade>();

            dto.Add(new dtoTrade(2000000, "Private"));
            dto.Add(new dtoTrade(400000, "Public"));
            dto.Add(new dtoTrade(500000, "Public"));
            dto.Add(new dtoTrade(3000000, "Public"));

            main.ReturnRisk(dto);

        }
    }
}
