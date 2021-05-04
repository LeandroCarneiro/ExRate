using LeandroExRate.Common;
using System;

namespace LeandroExRate.Domain.Entities
{
    public class Rate
    {
        public ECurrency From { get; set; }        
        public ECurrency To { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime Date { get; set; }
    }
}
