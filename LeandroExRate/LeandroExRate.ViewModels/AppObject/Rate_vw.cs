
using LeandroExRate.Common;
using System;

namespace LeandroExRate.ViewModels.AppObjects
{
    public class Rate_vw : EntityBase_vw
    {
        public ECurrency From { get; set; }
        public ECurrency To { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime Date { get; set; }

        public string ResultString => $"From {From.ToString()} to {To.ToString()}: {ExchangeRate} at {Date}";
    }
}
