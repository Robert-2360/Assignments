// Exercise 4.12: Invoice Class
// An invoice class that a hardware store might use.

public class InvoiceClass
{
   private int quantity;
   private decimal pricePerItem;

   public int Quantity
   {
      get { return quantity; }
      set { if (value >= 0) quantity = value; }
   }

   public decimal PricePerItem
   {
      get { return pricePerItem; }
      set { if (value >= 0) pricePerItem = value; }
   }

   public string PartNumber { get; set; }

   public string PartDescription { get; set; }

   public InvoiceClass(string pNumber, string pDescription, int quan, decimal price)
   {
      PartNumber = pNumber;
      PartDescription = pDescription;
      Quantity = quan;
      PricePerItem = price;
   }

   // Calculates the invoice amount
   public decimal GetInvoiceAmount()
   {
      return Quantity * PricePerItem;
   }
}