using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            var query = from p in context.Suppliers
                        where SqlMethods.Like(p.Country, "%USA%")
                        select p;
            foreach (var supp in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Country={2}", supp.SupplierID, supp.CompanyName, supp.Country);
            }
            Console.ReadKey(); 

            /*

            var query = from q in context.Products 
                        from p in context.Suppliers
                        where q.SupplierID == p.SupplierID
                         select new { ProductID = q.ProductID, ProductName = q.ProductName, CompanyName = p.CompanyName };
            foreach (var product in query)
            {
                    Console.WriteLine("ID={0} \t Name={1} \t Supplier={2}", product.ProductID, product.ProductName, product.CompanyName);
            }

            Console.ReadKey();*/
            /*var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();

            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
            */

            /*
            Categories p = new Categories();
            p.CategoryName = "Hamburguers";
            p.Description = "Hamburguesas de carne, pollo, pavo, etc";


            context.Categories.InsertOnSubmit(p);
            context.SubmitChanges();
            */
            //Creacion consulta
            /*  var query = from p in context.Products
                          where SqlMethods.Like(p.ProductName, "A%")
                          select p;

              //Ejecutccion consulta 
              foreach (var prod in query)
              {
                  Console.WriteLine("ID={0} \t Name={1} \t Price={2}", prod.ProductID, prod.ProductName, prod.UnitPrice);
              }
              Console.ReadKey();*/
        }
    }
}
