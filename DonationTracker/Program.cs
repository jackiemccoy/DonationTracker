using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            TakeDenominationInformation();
        }

        private static void TakeDenominationInformation()
        {
            int quarters;
            int ones;
            int fives;
            int tens;
            int twenties;
            int fifties;
            int hundreds;
            double total;

            Console.WriteLine("How many quarters are being donated?");
            quarters = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ones are being donated?");
            ones = int.Parse(Console.ReadLine()); 
            Console.WriteLine("How many fives are being donated?");
            fives = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tens are being donated?");
            tens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenties are being donated?");
            twenties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifties are being donated?");
            fifties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundreds are being donated?");
            hundreds = int.Parse(Console.ReadLine());

            total = ((quarters*25) + (ones*1) + (fives*5) + (tens*10) + (twenties*20) + (fifties*50) + (hundreds*100));
            TakeDonorInformation(total);
            //Console.WriteLine("Total:\t{0,8:c}", total);
            //return total;

        }

        protected static void TakeDonorInformation(double totalAmount)
        {
            string donorName;
            string donorAddress;
            string donorEmail;
            int fiscalYear;
            double totalDonationAmt;
            totalDonationAmt = totalAmount;

            Console.WriteLine("Enter Name of Donor");
            donorName = Console.ReadLine();
            Console.WriteLine("Enter address of Donor");
            donorAddress = Console.ReadLine();
            Console.WriteLine("Enter email of Donor");
            donorEmail = Console.ReadLine();
            Console.WriteLine("Enter fiscal year of Donor");
            fiscalYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Donor Name: " + donorName);
            Console.WriteLine("Donor Address: " + donorAddress);
            Console.WriteLine("Donor Email: " + donorEmail);
            Console.WriteLine("Donation Fiscal Year: " + fiscalYear);
            Console.WriteLine("Total Donation Amount:\t{0,8:c}", totalDonationAmt);
           
              

        }
    }
}
