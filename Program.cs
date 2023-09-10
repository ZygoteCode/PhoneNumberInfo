using PhoneNumbersLib;
using System;

public class Program
{
    public static void Main()
    {
        Console.Title = "PhoneNumberInfo | Made by https://github.com/GabryB03/";

        while (true)
        {
            string phoneNumber = "";

            while (!PhoneNumbers.IsPhoneNumberValid(phoneNumber))
            {
                Console.Write("Please, enter a valid phone number: ");
                phoneNumber = Console.ReadLine();

                if (!PhoneNumbers.IsPhoneNumberValid(phoneNumber))
                {
                    Console.WriteLine("Invalid phone number, please try again.");
                }
            }

            PhoneNumber informations = new PhoneNumber(phoneNumber);

            Console.WriteLine($"\r\n" +
                $"INFORMATIONS" +
                $"\r\n\r\n" +
                $"Complete phone number: {informations.ToString()}\r\n" +
                $"Prefix: +{informations.Prefix}\r\n" +
                $"Number: {informations.Number}\r\n" +
                $"Country: {informations.Country}\r\n" +
                $"Country code: {informations.CountryCode}\r\n" +
                $"Country with code: {informations.Country} ({informations.CountryCode})\r\n" +
                (informations.Country == "Italy" ? $"Possible italian operator: {informations.GetPossibleItalianOperator()}\r\n" : ""));
        }
    }
}