// Exercise 9.3: Querying an Array of Invoice Objects

using System;
using System.Linq;

namespace Querying_an_Array_of_Invoice_Objects
{
   class Program
   {
      static void Main(string[] args)
      {
         Invoice[] invoices = new Invoice[8];
         invoices[0] = new Invoice(83, "Electric sander", 7, 57.98M);
         invoices[1] = new Invoice(24, "Power saw", 18, 99.99M);
         invoices[2] = new Invoice(7, "Sledge hammer", 11, 21.50M);
         invoices[3] = new Invoice(77, "Hammer", 76, 11.99M);
         invoices[4] = new Invoice(39, "Lawn mower", 3, 79.50M);
         invoices[5] = new Invoice(68, "Screwdriver", 106, 6.99M);
         invoices[6] = new Invoice(56, "Jig saw", 21, 11.00M);
         invoices[7] = new Invoice(3, "Wrench", 34, 7.50M);

         // Part a)
         var sortedDescription =
            from invoice in invoices
            orderby invoice.PartDescription
            select invoice;

         Console.WriteLine("Sorted by Part Description");
         foreach (var element in sortedDescription)
            Console.WriteLine(" {0}", element);
         Console.WriteLine();

         // Part b)
         var sortedPrice =
            from invoice in invoices
            orderby invoice.Price
            select invoice;

         Console.WriteLine("Sorted by Price");
         foreach (var element in sortedPrice)
            Console.WriteLine(" {0}", element);
         Console.WriteLine();

         // Part c)
         var sortedQuantity =
            from invoice in invoices
            orderby invoice.Quantity
            select new { invoice.PartDescription, invoice.Quantity };

         Console.WriteLine("Sorted by Quantity, selected with PartDescription and Quantity");
         foreach (var element in sortedQuantity)
            Console.WriteLine(" {0}", element);
         Console.WriteLine();

         // Part d)
         var sortedInvoiceTotal =
            from invoice in invoices
            let total = invoice.Quantity * invoice.Price
            orderby total
            select new { invoice.PartDescription, InvoiceTotal = total };

         Console.WriteLine("Sorted by InvoiceTotal, selected with PartDescription and InvoiceTotal");
         foreach(var element in sortedInvoiceTotal)
            Console.WriteLine(" {0}", element);
         Console.WriteLine();

         // Part e)
         var filteredSortedInvoiceTotal =
            from invoice in sortedInvoiceTotal
            where 200M <= invoice.InvoiceTotal && invoice.InvoiceTotal <= 500M
            select invoice;

         Console.WriteLine("Filtered InvoiceTotal in range $200 to $500");
         foreach (var element in filteredSortedInvoiceTotal)
            Console.WriteLine(" {0}", element);
         Console.WriteLine();

         // Freeze console window
         Console.ReadLine();
      }
   }
}
