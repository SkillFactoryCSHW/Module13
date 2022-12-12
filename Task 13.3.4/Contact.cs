using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contact
{
    string name;
    long phoneNumber;
    string email;

    public Contact(string name, long phoneNumber, string email)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public string Name { get { return name; }}
    public long PhoneNumber { get { return phoneNumber; }}
    public string Email { get { return email; }}
}
