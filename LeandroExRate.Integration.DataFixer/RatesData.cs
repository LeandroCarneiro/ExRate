using System;
using System.Collections.Generic;
using System.Linq;

namespace LeandroExRate.Integration.DataFixer
{
    public class RatesData
    {
        public bool Success { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime Date { get; set; }
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }

        public decimal GetRate(string from, string to)
        {
            if (from == to)
                return 1;

            var fromToEur = Rates.Where(x => x.Key == from).FirstOrDefault().Value;
            var toToEur = Rates.Where(x => x.Key == to).FirstOrDefault().Value;

            var rate = (1 / fromToEur) * toToEur;

            return rate;
        }
    }
}
