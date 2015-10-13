// Exercise 7.8: Parking Charges
// Calculates the parking garage charges for any number of vehicles.
// Displays the charge for each vehicle and a running total for the ones just entered.

using System;

//Grade 10/10 Nice job

public class ParkingCharges
{
   public static void Main(string[] args)
   {
      // Initial variables
      int vehicleNumber = 1;
      decimal runningTotal = 0.0M;
      string format = "Enter the number of hours for vehicle {0}\nOr -1 to quit: ";

      // Enter data for the first vehicle
      Console.Write(format, vehicleNumber);
      decimal hours = Convert.ToDecimal(Console.ReadLine());

      // Loop through the remaining vehicles
      while (hours > 0.0M)
      {
         // Calculate charges and total
         decimal charge = CalculateCharges(hours);
         runningTotal += charge;

         // Display results
         Console.WriteLine("The charge for this vehicle is: {0:C}", charge);
         Console.WriteLine("Running total for all vehicles is: {0:C}", runningTotal);
         Console.WriteLine();

         // Increment next vehicle number
         vehicleNumber++;

         // Enter data for the remaining vehicles
         Console.Write(format, vehicleNumber);
         hours = Convert.ToDecimal(Console.ReadLine());
      }

      // Display final results
      Console.WriteLine();
      Console.WriteLine("For all {0} vehicles, the total parking charges was {1:C}.",
         vehicleNumber - 1, runningTotal);
   }

   /* This method returns the parking garage charges for a vehicle based on a given number of hours */
   public static decimal CalculateCharges(decimal hours)
   {
      // initial variables
      decimal minimumHours = 3.0M;
      decimal charge = 2.00M; // minimum charge
      decimal chargePerHour = 0.50M; // rate if greater than minimum hours
      decimal maximumCharge = 10.00M;

      // calculate charge if hours greater than minimum
      if (hours > minimumHours)
      {
         charge += Math.Ceiling(hours - minimumHours) * chargePerHour;
      }

      // calculate charge if charge is greater than maximum
      if (charge > maximumCharge)
      {
         charge = maximumCharge;
      }

      // return final result
      return charge;
   }
}

