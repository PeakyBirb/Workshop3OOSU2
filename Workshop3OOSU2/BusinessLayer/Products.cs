using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Products : DataLayer.Products
    {
        public Products(DataLayer.Products products)
        {
            ProductID = products.ProductID;
            ProductName = products.ProductName;
            UnitPrice = products.UnitPrice;
            CategoryID = products.CategoryID;
            Discontinued = products.Discontinued;
            QuantityPerUnit = products.QuantityPerUnit;
            ReorderLevel = products.ReorderLevel;
            SupplierID = products.SupplierID;
            UnitsOnOrder = products.UnitsOnOrder;
            UnitsInStock = products.UnitsInStock;

        }
    }
}
