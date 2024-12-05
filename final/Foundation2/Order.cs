using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }

            decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
            return total + shippingCost;
        }

        public string GetPackingLabel()
        {
            var label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"- {product.GetPackingInfo()}\n";
            }
            return label.TrimEnd();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
        }
    }
}
