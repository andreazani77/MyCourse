using System;
using MyCourse.Models.Enums;

namespace Mycouse.Models.ValueTypes
{
    public class Money
    {
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The amount cannot be negative");
                }
                amount = value;
            }
        }

        public Currency Currency
        {
            get; set;
        }

        private decimal amount = 0;
        public Money() : this(Currency.EUR, 0.00m)
        {
        }
        public Money(Currency currency, decimal amount)
        {
            Amount = amount;
            Currency = currency;
        }

        
        
        public override string ToString()
        {
            return $"{Currency} {Amount:0.00}";
        }
    }
}