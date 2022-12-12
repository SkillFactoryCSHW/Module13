using System.Collections.Generic;

string name;
long number;
string email;

var phoneBook = new List<Contact>();
phoneBook.Add(new Contact("Mike", 100, "@mail"));
phoneBook.Add(new Contact("Loh", 200, "@mail"));

Console.WriteLine("Enter the name");
name = Console.ReadLine();
Console.WriteLine("Enter the number");
number = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Enter the email");
email = Console.ReadLine();

Contact contact = new Contact(name, number, email);
AddUnique(contact, ref phoneBook);

foreach (var item in phoneBook)
{
    Console.Write("Name: " + item.Name + ", " + "Number: " + item.PhoneNumber + ", " + "Email: " + item.Email);
	Console.WriteLine();
}


static List<Contact> AddUnique(Contact contact,ref List<Contact> phoneBook)
{
	foreach (var item in phoneBook)
	{
		if (item.Name == contact.Name)
		{
            Console.WriteLine("Already exist");
			break;
        }
		else
		{
			phoneBook.Add(contact);
            break;
        }
	}
	return phoneBook;
}