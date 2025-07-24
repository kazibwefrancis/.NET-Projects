using System;

class Contact
{
    public static void Main()
    {
        Console.WriteLine("----------------------Welcome to The contact Management  application ------------------");
        Console.WriteLine(@"-----INSTRUCTIONS-----
                            1.Enter a contact ..please dont leave any field empty
                            2. You can retrieve the any contact 
                            3. You can delete and update.");

        string name = "", phoneNumber = "", email = "", address = "", dobInput = "";

        while (string.IsNullOrWhiteSpace(name) ||
               string.IsNullOrWhiteSpace(phoneNumber) ||
               string.IsNullOrWhiteSpace(email) ||
               string.IsNullOrWhiteSpace(address) ||
               string.IsNullOrWhiteSpace(dobInput))
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please fill in the missing field: name");
                Console.WriteLine("Enter the name of the person:");
                name = Console.ReadLine();
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                Console.WriteLine("Please fill in the missing field: phone number");
                Console.WriteLine("Enter the phone number of the person:");
                phoneNumber = Console.ReadLine();
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Please fill in the missing field: email");
                Console.WriteLine("Enter the email of the person:");
                email = Console.ReadLine();
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Please fill in the missing field: address");
                Console.WriteLine("Enter the address of the person:");
                address = Console.ReadLine();
            }
            if (string.IsNullOrWhiteSpace(dobInput))
            {
                Console.WriteLine("Please fill in the missing field: date of birth");
                Console.WriteLine("Enter the date of birth of the person (yyyy-mm-dd):");
                dobInput = Console.ReadLine();
            }
        }

        
        using (var context = new ContactContext())
        {
            var contact = new ContactModel
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address,
                DateOfBirth = DateTime.Parse(dobInput)
            };
            context.Contacts.Add(contact);
            context.SaveChanges();
            Console.WriteLine("Contact saved to the database!");
        }
    }
}