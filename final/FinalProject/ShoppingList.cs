using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ShoppingList
    {
        protected DateOnly _date = new();
        protected double _amount = 0;
        protected double _tax = 0;
        protected double _discount = 0;
        protected double _total = 0;
        protected Person _idCustomer;
        protected List<Product> _products = new();
        public ShoppingList(DateOnly date, Person idCustomer)
        {
            _date = date;
            _idCustomer = idCustomer;

        }
        public virtual void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public virtual void DropProduct(Product product)
        {
            _products.Remove(product);
        }
        public virtual void ClearList()
        {
            _products.Clear();
        }
        public override string ToString()
        {
            return $"{_date}";
        }
    }
}
