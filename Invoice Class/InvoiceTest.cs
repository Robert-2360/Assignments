// Exercise 4.12: Invoice Class
// Test program fot the Invoice class

using System;

//Graded 10/10
class InvoiceTest
{
   static void Main(string[] args)
   {
      // Initialize variables
      InvoiceClass invoice = new InvoiceClass("A101-01", "Hammer", 2, 9.99M);

      // Display invoice values
      Console.WriteLine("Values of invoice");
      DisplayInvoice(invoice);

      // Modify invoice
      invoice.Quantity = 1;

      // Display invoice values again
      Console.WriteLine("Change quantity to 1");
      DisplayInvoice(invoice);

      // Modify invoice with an invalid quantity
      invoice.Quantity = -1;

      // Display invoice values again
      Console.WriteLine("Change quantity to -1");
      DisplayInvoice(invoice);

      //Freeze console window
      Console.ReadLine();
   }

   // Display Invoice class variables
   public static void DisplayInvoice(InvoiceClass i)
   {
      string formatA = "{0, -20}{1, 12}";
      string formatB = "{0, -20}{1, 12:C}";
      Console.WriteLine(formatA, "Part Number:", i.PartNumber);
      Console.WriteLine(formatA, "Part Description:", i.PartDescription);
      Console.WriteLine(formatA, "Quantity:", i.Quantity);
      Console.WriteLine(formatB, "Price Per Item:", i.PricePerItem);
      Console.WriteLine(formatB, "Invoice Amount:", i.GetInvoiceAmount());
      Console.WriteLine();
   }
}