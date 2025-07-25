using System;
using System.ComponentModel.DataAnnotations;

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
        var newContact = new ContactModel();


        Console.WriteLine("Enter the name of the person:");
        newContact.Name = Console.ReadLine();


        Console.WriteLine("Enter the phone number of the person:");
        newContact.PhoneNumber = Console.ReadLine();



        var isvalid = ValidateObject(newContact);

        if (isvalid)
        {
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

        //while (!ValidateObject(newContact))
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        Console.WriteLine("Please fill in the missing field: name");
        //        Console.WriteLine("Enter the name of the person:");
        //        name = Console.ReadLine();
        //    }



        //    if (string.IsNullOrWhiteSpace(phoneNumber))
        //    {
        //        Console.WriteLine("Please fill in the missing field: phone number");
        //        Console.WriteLine("Enter the phone number of the person:");
        //        phoneNumber = Console.ReadLine();
        //    }
        //    if (string.IsNullOrWhiteSpace(email))
        //    {
        //        Console.WriteLine("Please fill in the missing field: email");
        //        Console.WriteLine("Enter the email of the person:");
        //        email = Console.ReadLine();
        //    }
        //    if (string.IsNullOrWhiteSpace(address))
        //    {
        //        Console.WriteLine("Please fill in the missing field: address");
        //        Console.WriteLine("Enter the address of the person:");
        //        address = Console.ReadLine();
        //    }
        //    if (string.IsNullOrWhiteSpace(dobInput))
        //    {
        //        Console.WriteLine("Please fill in the missing field: date of birth");
        //        Console.WriteLine("Enter the date of birth of the person (yyyy-mm-dd):");
        //        dobInput = Console.ReadLine();
        //    }
        //}





    }

    private static bool ValidateObject(ContactModel contact)
    {
        var context = new ValidationContext(contact);
        var results = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(contact, context, results, true);

        if (!isValid)
        {
            foreach (var validationResult in results)
            {
                Console.WriteLine(validationResult.ErrorMessage);
            }
        }

        return isValid;
        //return string.IsNullOrWhiteSpace(contact.Name) ||
        //               string.IsNullOrWhiteSpace(contact.PhoneNumber) ||
        //               string.IsNullOrWhiteSpace(contact.Email) ||
        //               string.IsNullOrWhiteSpace(contact.Address) ||
        //               string.IsNullOrWhiteSpace(contact.DOB);
    }
}


public class Car : IDisposable
{
    public void Dispose()
    {
        GC.Collect();
    }
}