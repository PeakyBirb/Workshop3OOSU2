using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public List<Products> GetProducts()
        {
            using (var db = new Northwind())
            {
                return db.Products.ToList();

            }
        }

        public List<Products> GetProductsLINQ()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            select x;

                return query.ToList();

            }
        }

        public List<Products> GetProductsStartingWithA()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.ProductName.StartsWith("a")||x.ProductName.StartsWith("A")
                            select x;
                
                return query.ToList();

            }
        }

        public List<Products> GetProductsUnitPrice()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.UnitPrice > 100
                            select x;

                return query.ToList();

            }
        }
    }
}
