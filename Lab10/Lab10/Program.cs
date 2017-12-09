using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void 
            Main(string[] args)
        {
            //Origen de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //Creacion de cosulta
            /*
            var query = from p in context.Products
                        select p;
            
            var query = from p in context.Products
                        where p.Categories.CategoryName == "Beverages"
                        select p;
            
            var query = from p in context.Products
                        where p.UnitPrice < 20
                        select p;
            
            var query = from p in context.Products
                        where p.ProductName.Contains("Queso")
                        select p;
            
            var query = from p in context.Products
                        where p.QuantityPerUnit.Contains("pkg")
                        where p.QuantityPerUnit.Contains("pkgs")
                        select p;
            
            var query = from p in context.Products
                        where p.ProductName.StartsWith("A")
                        select p;
            
            var query = from p in context.Products
                        where p.UnitsInStock <= 0
                        select p;
                        
            var query = from p in context.Products
                        where p.Discontinued.Equals(1)
                        select p;
            //Ejecucion de consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }
            
            //Creacion de la consulta
            Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;
            //Ejecucion de consulta
            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();
            
            Categories c = new Categories();
            c.CategoryName = "Carnes";
            c.Description = "diferentes tipos de carnes";
            //Ejecucion de consulta
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();
            
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;
            context.SubmitChanges();
            
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
            */
            /*
            var query = from p in context.Products
                        where p.Categories.CategoryName == "Dairy Products"
                        select p;
            //Ejecucion de consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Proveedor={2}", prod.ProductID,prod.ProductName, prod.Suppliers.CompanyName);
            }
            */

            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;

            //Ejecucion de consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Ubicado={2}", prod.ProductID, prod.ProductName, prod.Suppliers.Country);
            }

            Console.ReadKey();
        }
    }
}
