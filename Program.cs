using System;

namespace SeniorTicket
{
    class Program
    {
            const int SENIOR_AGE = 65;
            const int CHILD_AGE = 12;
        static void Main(string[] args)
        {
            
            int ticketPrice = 14;
            int userAge = 20;
            bool isStudent = false; 

            try {
                if (userAge < 0) {
                    throw new Exception();
                }

                if (userAge >= SENIOR_AGE) {
                ticketPrice = 10;
                } else if (userAge <= CHILD_AGE) {
                    ticketPrice = 8;
                }

                if (isStudent) {
                    ticketPrice = 8;
                }

                Console.WriteLine("Your ticket price is: " + ticketPrice);
            } catch (Exception e) {
                Console.WriteLine("Enter a correct age " + e.Message);
            }

        }
    }
}
