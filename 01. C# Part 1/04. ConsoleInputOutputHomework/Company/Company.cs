using System;

class Company
{

    // A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console

    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        int companyPhone = int.Parse(Console.ReadLine());
        int companyFax = int.Parse(Console.ReadLine());
        string website = Console.ReadLine();
        string manager = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        int managerPhone = int.Parse(Console.ReadLine());
        Console.WriteLine("The company {0} has adress {1}, its phone number is {2} and fax number is {3}." , companyName, companyAdress, companyPhone, companyFax );
        Console.WriteLine("The company's manager is {0} and the company's website is {1}.", manager, website );
        Console.WriteLine("The manager's names are {0} {1}, his phone is {2} and he is {3} years old", managerFirstName, managerLastName, managerPhone, managerAge);
    }
}
