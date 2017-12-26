using Infrastructure.CrossCutting.Helpers;
using System;

namespace Domain.Model
{
    public class Product : Entity<Guid>
    {
        public Product(string name, decimal unitPrice) 
            : base(Guid.NewGuid())
        {
            Guard.ArgumentIsNotNull(name, nameof(name));
            Guard.ArgumentIsNotNull(unitPrice, nameof(unitPrice));

            this.Name = name;
            this.UnitPrice = unitPrice;
        }

        public string Name { get; private set; }

        public decimal UnitPrice { get; private set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice {
            get
            {
                return UnitPrice * Quantity;
            }
        }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateUnitPrice(decimal unitPrice)
        {
            this.UnitPrice = unitPrice;
        }
    }
}
