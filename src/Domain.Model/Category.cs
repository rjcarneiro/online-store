namespace Domain.Model
{
    using Infrastructure.CrossCutting.Exceptions;
    using Infrastructure.CrossCutting.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class Category : Entity<Guid>
    {
        public Category(string name): base(Guid.NewGuid())
        {
            Guard.ArgumentIsNotNull(name, nameof(name));

            this.Name = name;
            Products = new Collection<Product>();
        }

        public string Name { get; private set; }

        public ICollection<Product> Products { get; }

        public void AddProduct(Product product)
        {
            Guard.ArgumentIsNotNull(product, nameof(product));

            var productWithSameName = this.Products.SingleOrDefault(p => p.Name.Equals(product.Name));

            if(productWithSameName != null)
            {
                throw new ProductWithSameNameException($"Product with name {product.Name} not found!");
            }

            Products.Add(product);
        }

        public void UpdateCategory(string updatedName)
        {
            Guard.ArgumentIsNotNull(updatedName, nameof(updatedName));

            this.Name = updatedName;
        }
    }
}
